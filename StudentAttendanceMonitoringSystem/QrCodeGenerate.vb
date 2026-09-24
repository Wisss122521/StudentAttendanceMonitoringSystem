Imports System.Data.Odbc
Imports System.Drawing.Imaging
Imports QRCoder

Public Class QrCodeGenerate

    Private selectedStudentId As Integer = 0
    Private selectedStudentName As String = ""
    Private selectedQRToken As String = ""



    Private Sub LoadStudents()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
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
                query &= "AND (students_name LIKE ? OR CAST(students_id AS CHAR) LIKE ?) "
            End If

            If cboQRStatus.Text = "Generated" Then

                query &= "AND qr_code_data IS NOT NULL AND qr_code_data <> '' "

            ElseIf cboQRStatus.Text = "Not Generated" Then

                query &= "AND (qr_code_data IS NULL OR qr_code_data = '') "

            End If

            query &= "ORDER BY students_name ASC"

            Using cmd As New OdbcCommand(query, con)

                If txtSearch.Text.Trim() <> "" Then

                    Dim searchValue As String =
                    "%" & txtSearch.Text.Trim() & "%"

                    cmd.Parameters.AddWithValue("@search1", searchValue)
                    cmd.Parameters.AddWithValue("@search2", searchValue)

                End If

                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvStudents.DataSource = dt

            End Using

            UpdateSummary()

        Catch ex As Exception

            MessageBox.Show(
            ex.Message,
            "Load Students Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

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

        LoadStudents()
        ClearPreview()

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

        If e.RowIndex < 0 Then Return

        Dim studentId As Integer =
        Convert.ToInt32(
            dgvStudents.Rows(e.RowIndex).
            Cells("colStudentID").Value
        )

        LoadStudentPreview(studentId)

    End Sub

    Private Sub LoadStudentPreview(studentId As Integer)

        Try

            Dim query As String =
                "SELECT students_id, students_name, " &
                "year_level, course, qr_code_data " &
                "FROM students " &
                "WHERE students_id = ?"

            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue("@id", studentId)

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        selectedStudentId =
                            Convert.ToInt32(reader("students_id"))

                        selectedStudentName =
                            reader("students_name").ToString()

                        selectedQRToken =
                            If(
                                IsDBNull(reader("qr_code_data")),
                                "",
                                reader("qr_code_data").ToString()
                            )

                        lblStudentName.Text =
                            selectedStudentName

                        lblStudentID.Text =
                            selectedStudentId.ToString()

                        lblYearCourse.Text =
                            reader("year_level").ToString() &
                            " - " &
                            reader("course").ToString()

                        If selectedQRToken = "" Then

                            lblQRStatus.Text = "NOT GENERATED"

                            picQRCode.Image = Nothing

                            btnGenerateQR.Text =
                                "Generate QR Code"

                            btnDownloadQR.Enabled = False

                        Else

                            lblQRStatus.Text = "GENERATED"

                            picQRCode.Image =
                                CreateQRCode(selectedQRToken)

                            btnGenerateQR.Text =
                                "Generate New QR"

                            btnDownloadQR.Enabled = True

                        End If

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Preview Error",
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

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If

            ' Kunin muna lahat ng students na walang QR
            Dim studentIds As New List(Of Integer)

            Dim selectQuery As String =
            "SELECT students_id " &
            "FROM students " &
            "WHERE qr_code_data IS NULL"

            Using selectCmd As New OdbcCommand(selectQuery, con)

                Using reader As OdbcDataReader = selectCmd.ExecuteReader()

                    While reader.Read()

                        studentIds.Add(
                        Convert.ToInt32(reader("students_id"))
                    )

                    End While

                End Using

            End Using


            ' Kapag wala nang missing QR
            If studentIds.Count = 0 Then

                MessageBox.Show(
                "All students already have QR Codes.",
                "Generate QR Codes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

                Return

            End If


            ' Generate QR token bawat student
            For Each studentId As Integer In studentIds

                Dim qrToken As String =
                "STU-" & Guid.NewGuid().ToString()

                Dim updateQuery As String =
                "UPDATE students " &
                "SET qr_code_data = ? " &
                "WHERE students_id = ?"

                Using updateCmd As New OdbcCommand(updateQuery, con)

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


            ' Refresh table at summary
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
            ex.Message,
            "Generate Missing QR Error",
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
                    "Do you want to generate a new one?" &
                    vbCrLf &
                    vbCrLf &
                    "The old QR Code will no longer work.",
                    "Generate New QR Code",
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
                selectedStudentName.Replace(" ", "_") &
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

            Dim query As String =
                "SELECT " &
                "COUNT(*) AS total_students, " &
                "SUM(CASE WHEN qr_code_data IS NOT NULL " &
                "AND qr_code_data <> '' THEN 1 ELSE 0 END) AS generated, " &
                "SUM(CASE WHEN qr_code_data IS NULL " &
                "OR qr_code_data = '' THEN 1 ELSE 0 END) AS not_generated " &
                "FROM students"

            Using cmd As New OdbcCommand(query, con)

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        lblSummary.Text =
                            reader("total_students").ToString() &
                            " Students • " &
                            reader("generated").ToString() &
                            " Generated • " &
                            reader("not_generated").ToString() &
                            " Not Generated"

                    End If

                End Using

            End Using

        Catch ex As Exception

            lblSummary.Text = ""

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
