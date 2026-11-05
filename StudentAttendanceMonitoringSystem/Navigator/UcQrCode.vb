Imports System.Data.Odbc
Imports System.Drawing.Imaging
Imports QRCoder

Public Class UcQrCode

    Private selectedStudentId As Integer = 0
    Private selectedStudentName As String = ""
    Private selectedQRToken As String = ""

    Private Function GetSafeFileName(
        value As String
    ) As String

        Dim result As String =
            value.Trim()

        For Each invalidChar As Char In
            IO.Path.GetInvalidFileNameChars()

            result =
                result.Replace(
                    invalidChar,
                    "_"c
                )

        Next


        result =
        result.Replace(
            " ",
            "_"
        )


        Return result

    End Function
    Private Sub timerClock_Tick_1(sender As Object, e As EventArgs) Handles timerClock.Tick
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()

        lblDateTime.Text =
        DateTime.Now.ToString("dddd, MMMM dd, yyyy") &
        "   |   " &
        DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub LoadStudents()

        Try

            If con Is Nothing OrElse
           con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            Dim query As String =
            "SELECT " &
            "students_id, " &
            "students_name, " &
            "CONCAT(year_level, ' - ', course) AS year_course, " &
            "CASE " &
            "WHEN qr_code_data IS NULL OR qr_code_data = '' " &
            "THEN 'NOT GENERATED' " &
            "ELSE 'GENERATED' " &
            "END AS qr_status " &
            "FROM students " &
            "WHERE 1=1 "


            If txtSearch.Text.Trim() <> "" Then

                query &=
                "AND (" &
                "students_name LIKE ? " &
                "OR CAST(students_id AS CHAR) LIKE ?" &
                ") "

            End If


            If cboQRStatus.Text = "Generated" Then

                query &=
                "AND qr_code_data IS NOT NULL " &
                "AND qr_code_data <> '' "

            ElseIf cboQRStatus.Text = "Not Generated" Then

                query &=
                "AND (" &
                "qr_code_data IS NULL " &
                "OR qr_code_data = ''" &
                ") "

            End If


            query &=
            "ORDER BY students_name ASC"


            Using cmd As New OdbcCommand(
            query,
            con
        )

                If txtSearch.Text.Trim() <> "" Then

                    Dim searchValue As String =
                    "%" &
                    txtSearch.Text.Trim() &
                    "%"


                    cmd.Parameters.AddWithValue(
                    "@search1",
                    searchValue
                )

                    cmd.Parameters.AddWithValue(
                    "@search2",
                    searchValue
                )

                End If


                Using adapter As New OdbcDataAdapter(
                cmd
            )

                    Dim dt As New DataTable()

                    adapter.Fill(dt)

                    dgvStudents.DataSource =
                    dt

                End Using

            End Using


            '==================================================
            ' CLEAN TABLE HEADERS
            '==================================================
            FormatStudentsGrid()

            dgvStudents.ClearSelection()

            UpdateSummary()


        Catch ex As Exception

            MessageBox.Show(
            "Load Students Error: " &
            ex.Message,
            "QR Code Management",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub


    '==================================================
    ' FORMAT STUDENTS TABLE
    '==================================================
    Private Sub FormatStudentsGrid()

        If dgvStudents Is Nothing OrElse
           dgvStudents.Columns.Count = 0 Then

            Return

        End If


        '==================================================
        ' CENTER HEADERS
        '==================================================
        dgvStudents.ColumnHeadersDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter


        '==================================================
        ' CENTER ALL ROW TEXT
        '==================================================
        dgvStudents.DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter

        dgvStudents.RowsDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter

        dgvStudents.AlternatingRowsDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter


        '==================================================
        ' COLUMN STYLE
        '==================================================
        For Each column As DataGridViewColumn In
        dgvStudents.Columns


            Dim columnKey As String =
            column.DataPropertyName


            If String.IsNullOrWhiteSpace(
            columnKey
        ) Then

                columnKey =
                column.Name

            End If


            columnKey =
            columnKey.
            Trim().
            ToLowerInvariant()


            Select Case columnKey

            '==================================================
            ' STUDENT ID
            '==================================================
                Case "students_id",
                 "student_id",
                 "colstudentid"

                    column.HeaderText =
                    "Student ID"

                    column.FillWeight =
                    55


            '==================================================
            ' STUDENT NAME
            '==================================================
                Case "students_name",
                 "student_name",
                 "colstudentname"

                    column.HeaderText =
                    "Student Name"

                    column.FillWeight =
                    130


            '==================================================
            ' YEAR / COURSE
            '==================================================
                Case "year_course",
                 "colyearcourse"

                    column.HeaderText =
                    "Year / Course"

                    column.FillWeight =
                    100


            '==================================================
            ' QR STATUS
            '==================================================
                Case "qr_status",
                 "colqrstatus"

                    column.HeaderText =
                    "QR Status"

                    column.FillWeight =
                    80

            End Select


            '==================================================
            ' CENTER EVERY COLUMN
            '==================================================
            column.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        Next

    End Sub

    Private Sub UC_QRCodeGenerate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con Is Nothing OrElse con.State <> ConnectionState.Open Then
            vbConnection()
        End If

        cboQRStatus.Items.Clear()
        cboQRStatus.Items.Add("All")
        cboQRStatus.Items.Add("Generated")
        cboQRStatus.Items.Add("Not Generated")

        cboQRStatus.SelectedIndex = 0

        timerClock.Interval = 1000
        timerClock.Start()

        LoadStudents()
        ClearPreview()
        UpdateDateTime()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        LoadStudents()

    End Sub

    Private Sub cboQRStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQRStatus.SelectedIndexChanged

        LoadStudents()

    End Sub

    Private Sub dgvStudents_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvStudents.CellClick

        If e.RowIndex < 0 Then
            Return
        End If

        Try

            Dim selectedRow As DataGridViewRow =
            dgvStudents.Rows(e.RowIndex)

            If selectedRow Is Nothing Then
                Return
            End If


            Dim rowView As DataRowView =
            TryCast(
                selectedRow.DataBoundItem,
                DataRowView
            )

            If rowView Is Nothing Then

                MessageBox.Show(
                "Unable to read the selected student.",
                "QR Code Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

                Return

            End If


            If Not rowView.Row.Table.Columns.Contains(
            "students_id"
        ) Then

                MessageBox.Show(
                "Student ID column was not found.",
                "QR Code Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

                Return

            End If


            If IsDBNull(rowView("students_id")) Then
                Return
            End If


            Dim studentId As Integer =
            Convert.ToInt32(
                rowView("students_id")
            )


            LoadStudentPreview(studentId)


        Catch ex As Exception

            MessageBox.Show(
            "Student Selection Error: " &
            ex.Message,
            "QR Code Management",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub LoadStudentPreview(
        studentId As Integer
    )

        Try

            If con Is Nothing OrElse
           con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            Dim query As String =
            "SELECT " &
            "students_id, " &
            "students_name, " &
            "year_level, " &
            "course, " &
            "qr_code_data " &
            "FROM students " &
            "WHERE students_id = ?"


            Using cmd As New OdbcCommand(
            query,
            con
        )

                cmd.Parameters.AddWithValue(
                "@id",
                studentId
            )


                Using reader As OdbcDataReader =
                cmd.ExecuteReader()

                    If reader.Read() Then

                        selectedStudentId =
                        Convert.ToInt32(
                            reader("students_id")
                        )


                        selectedStudentName =
                        If(
                            IsDBNull(
                                reader("students_name")
                            ),
                            "",
                            reader(
                                "students_name"
                            ).ToString()
                        )


                        selectedQRToken =
                        If(
                            IsDBNull(
                                reader("qr_code_data")
                            ),
                            "",
                            reader(
                                "qr_code_data"
                            ).ToString().Trim()
                        )


                        Dim yearLevel As String =
                        If(
                            IsDBNull(
                                reader("year_level")
                            ),
                            "",
                            reader(
                                "year_level"
                            ).ToString()
                        )


                        Dim course As String =
                        If(
                            IsDBNull(
                                reader("course")
                            ),
                            "",
                            reader(
                                "course"
                            ).ToString()
                        )


                        lblStudentName.Text =
                        selectedStudentName

                        lblStudentID.Text =
                        selectedStudentId.ToString()


                        If yearLevel <> "" AndAlso
                       course <> "" Then

                            lblYearCourse.Text =
                            yearLevel &
                            " - " &
                            course

                        ElseIf yearLevel <> "" Then

                            lblYearCourse.Text =
                            yearLevel

                        ElseIf course <> "" Then

                            lblYearCourse.Text =
                            course

                        Else

                            lblYearCourse.Text =
                            "-"

                        End If


                        If String.IsNullOrWhiteSpace(
                        selectedQRToken
                    ) Then

                            lblQRStatus.Text =
                            "NOT GENERATED"

                            picQRCode.Image =
                            Nothing

                            btnGenerateQR.Text =
                            "Generate QR Code"

                            btnDownloadQR.Enabled =
                            False

                        Else

                            lblQRStatus.Text =
                            "GENERATED"

                            picQRCode.Image =
                            CreateQRCode(
                                selectedQRToken
                            )

                            btnGenerateQR.Text =
                            "Generate New QR"

                            btnDownloadQR.Enabled =
                            True

                        End If

                    Else

                        ClearPreview()

                        MessageBox.Show(
                        "Student record was not found.",
                        "QR Code Management",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    End If

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
            "Preview Error: " &
            ex.Message,
            "QR Code Management",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Function GenerateQRToken() As String

        Return "STU-" & Guid.NewGuid().ToString()

    End Function

    Private Sub btnGenerateMissing_Click(
    sender As Object,
    e As EventArgs
) Handles btnGenerateMissing.Click

        Try

            If con Is Nothing OrElse
           con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            Dim studentIds As New List(Of Integer)


            '==================================================
            ' GET STUDENTS WITHOUT QR
            '==================================================
            Dim selectQuery As String =
            "SELECT students_id " &
            "FROM students " &
            "WHERE qr_code_data IS NULL " &
            "OR TRIM(qr_code_data) = ''"


            Using selectCmd As New OdbcCommand(
            selectQuery,
            con
        )

                Using reader As OdbcDataReader =
                selectCmd.ExecuteReader()

                    While reader.Read()

                        studentIds.Add(
                        Convert.ToInt32(
                            reader("students_id")
                        )
                    )

                    End While

                End Using

            End Using


            '==================================================
            ' NOTHING TO GENERATE
            '==================================================
            If studentIds.Count = 0 Then

                MessageBox.Show(
                "All students already have QR Codes.",
                "Generate QR Codes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

                Return

            End If


            Dim result As DialogResult =
            MessageBox.Show(
                "Generate QR Codes for " &
                studentIds.Count.ToString() &
                " student(s)?",
                "Generate Missing QR Codes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


            If result <> DialogResult.Yes Then
                Return
            End If


            '==================================================
            ' START TRANSACTION
            '==================================================
            Using transaction As OdbcTransaction =
            con.BeginTransaction()

                Try

                    For Each studentId As Integer In studentIds

                        Dim qrToken As String =
                        GenerateQRToken()


                        Dim updateQuery As String =
                        "UPDATE students " &
                        "SET qr_code_data = ? " &
                        "WHERE students_id = ?"


                        Using updateCmd As New OdbcCommand(
                        updateQuery,
                        con,
                        transaction
                    )

                            updateCmd.Parameters.AddWithValue(
                            "@qr",
                            qrToken
                        )

                            updateCmd.Parameters.AddWithValue(
                            "@id",
                            studentId
                        )

                            updateCmd.ExecuteNonQuery()

                        End Using

                    Next


                    transaction.Commit()


                Catch

                    Try
                        transaction.Rollback()
                    Catch
                    End Try

                    Throw

                End Try

            End Using


            '==================================================
            ' REFRESH
            '==================================================
            LoadStudents()
            UpdateSummary()
            ClearPreview()


            MessageBox.Show(
            studentIds.Count.ToString() &
            " QR Code(s) generated successfully.",
            "QR Generation Complete",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )


        Catch ex As Exception

            MessageBox.Show(
            "QR generation failed." &
            vbCrLf &
            vbCrLf &
            "No partial QR generation was kept." &
            vbCrLf &
            ex.Message,
            "Generate QR Codes",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub btnGenerateQR_Click(
    sender As Object,
    e As EventArgs
) Handles btnGenerateQR.Click

        If selectedStudentId = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Generate QR Code",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If selectedQRToken <> "" Then

            Dim result As DialogResult =
                MessageBox.Show(
                    "This student already has a QR Code." &
                    vbCrLf &
                    vbCrLf &
                    "Generating a new QR Code will immediately invalidate the old one." &
                    vbCrLf &
                    vbCrLf &
                    "Do you want to continue?",
                    "Replace QR Code",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

            If result = DialogResult.No Then Return

        End If


        Try

            Dim token As String =
                GenerateQRToken()

            Dim query As String =
                "UPDATE students " &
                "SET qr_code_data = ? " &
                "WHERE students_id = ?"

            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue("@qr", token)
                cmd.Parameters.AddWithValue("@id", selectedStudentId)

                cmd.ExecuteNonQuery()

            End Using


            selectedQRToken = token

            picQRCode.Image =
                CreateQRCode(token)

            lblQRStatus.Text = "GENERATED"

            btnGenerateQR.Text =
                "Generate New QR"

            btnDownloadQR.Enabled = True


            LoadStudents()


            MessageBox.Show(
                "QR Code generated successfully for " &
                selectedStudentName & ".",
                "QR Generated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Generate QR Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnDownloadQR_Click(
    sender As Object,
    e As EventArgs
) Handles btnDownloadQR.Click

        If picQRCode.Image Is Nothing Then

            MessageBox.Show(
                "No QR Code available."
            )

            Return

        End If


        Using save As New SaveFileDialog()

            save.Filter =
                "PNG Image|*.png"

            save.FileName =
                GetSafeFileName(
                    selectedStudentName
                ) &
                "_QR.png"

            If save.ShowDialog() =
                DialogResult.OK Then

                picQRCode.Image.Save(
                    save.FileName,
                    ImageFormat.Png
                )

                MessageBox.Show(
                    "QR Code saved successfully."
                )

            End If

        End Using

    End Sub

    Private Sub UpdateSummary()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If

            Dim query As String =
                "SELECT " &
                "COUNT(*) AS total_students, " &
                "SUM(CASE " &
                "WHEN qr_code_data IS NOT NULL " &
                "AND TRIM(qr_code_data) <> '' " &
                "THEN 1 ELSE 0 END) AS generated_count, " &
                "SUM(CASE " &
                "WHEN qr_code_data IS NULL " &
                "OR TRIM(qr_code_data) = '' " &
                "THEN 1 ELSE 0 END) AS not_generated_count " &
                "FROM students"

            Using cmd As New OdbcCommand(query, con)

                Using reader As OdbcDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        Dim totalStudents As Integer = 0
                        Dim generatedCount As Integer = 0
                        Dim notGeneratedCount As Integer = 0

                        If Not IsDBNull(reader("total_students")) Then
                            totalStudents =
                                Convert.ToInt32(reader("total_students"))
                        End If

                        If Not IsDBNull(reader("generated_count")) Then
                            generatedCount =
                                Convert.ToInt32(reader("generated_count"))
                        End If

                        If Not IsDBNull(reader("not_generated_count")) Then
                            notGeneratedCount =
                                Convert.ToInt32(reader("not_generated_count"))
                        End If

                        lblTotalStudents.Text =
                            totalStudents.ToString()

                        lblGeneratedCount.Text =
                            generatedCount.ToString()

                        lblNotGeneratedCount.Text =
                            notGeneratedCount.ToString()

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Summary Error: " & ex.Message,
                "QR Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub ClearPreview()

        selectedStudentId = 0
        selectedStudentName = ""
        selectedQRToken = ""

        lblStudentName.Text =
            "Select a student"

        lblStudentID.Text = "-"
        lblYearCourse.Text = "-"
        lblQRStatus.Text = "-"

        picQRCode.Image = Nothing

        btnGenerateQR.Text =
            "Generate QR Code"

        btnDownloadQR.Enabled = False

    End Sub
    Private Function CreateQRCode(qrData As String) As Bitmap

        Using qrGenerator As New QRCodeGenerator()

            Using qrCodeData As QRCodeData =
            qrGenerator.CreateQrCode(
                qrData,
                QRCodeGenerator.ECCLevel.Q
            )

                Using qrCode As New QRCode(qrCodeData)

                    Return qrCode.GetGraphic(10)

                End Using

            End Using

        End Using

    End Function


End Class
