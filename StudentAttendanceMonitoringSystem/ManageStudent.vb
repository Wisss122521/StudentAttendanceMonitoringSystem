Imports System.Data.Odbc
Imports ClosedXML.Excel

Public Class ManageStudent
    Private selectedStudentId As Integer = 0


    '==================================================
    ' USERCONTROL LOAD
    '==================================================
    Private Sub ManageStudents_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If

            LoadDropdowns()
            LoadStudents()
            UpdateTotalStudents()

            ClearFields()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Manage Students Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' LOAD DROPDOWNS
    '==================================================
    Private Sub LoadDropdowns()

        '=========================
        ' YEAR LEVEL - FORM
        '=========================
        cboYearLevel.Items.Clear()

        cboYearLevel.Items.Add("1st Year")
        cboYearLevel.Items.Add("2nd Year")
        cboYearLevel.Items.Add("3rd Year")
        cboYearLevel.Items.Add("4th Year")

        cboYearLevel.SelectedIndex = -1


        '=========================
        ' COURSE - FORM
        '=========================
        cboCourse.Items.Clear()

        cboCourse.Items.Add("BSTM")
        cboCourse.Items.Add("BSHM")
        cboCourse.Items.Add("BSIT")
        cboCourse.Items.Add("BSEd")

        cboCourse.SelectedIndex = -1


        '=========================
        ' YEAR FILTER
        '=========================
        cboFilterYear.Items.Clear()

        cboFilterYear.Items.Add("All")
        cboFilterYear.Items.Add("1st Year")
        cboFilterYear.Items.Add("2nd Year")
        cboFilterYear.Items.Add("3rd Year")
        cboFilterYear.Items.Add("4th Year")

        cboFilterYear.SelectedIndex = 0


        '=========================
        ' COURSE FILTER
        '=========================
        cboFilterCourse.Items.Clear()

        cboFilterCourse.Items.Add("All")
        cboFilterCourse.Items.Add("BSTM")
        cboFilterCourse.Items.Add("BSHM")
        cboFilterCourse.Items.Add("BSIT")
        cboFilterCourse.Items.Add("BSEd")

        cboFilterCourse.SelectedIndex = 0

    End Sub


    '==================================================
    ' LOAD STUDENTS
    '==================================================
    Private Sub LoadStudents()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT " &
                "students_id AS student_id, " &
                "students_name AS student_name, " &
                "year_level, " &
                "course, " &
                "parent_contact_number " &
                "FROM students " &
                "WHERE 1=1 "


            '=========================
            ' SEARCH
            '=========================
            If txtSearch.Text.Trim() <> "" Then

                query &=
                    "AND (" &
                    "students_name LIKE ? " &
                    "OR CAST(students_id AS CHAR) LIKE ? " &
                    "OR parent_contact_number LIKE ?" &
                    ") "

            End If


            '=========================
            ' YEAR FILTER
            '=========================
            If cboFilterYear.Text <> "" AndAlso
               cboFilterYear.Text <> "All" Then

                query &=
                    "AND year_level = ? "

            End If


            '=========================
            ' COURSE FILTER
            '=========================
            If cboFilterCourse.Text <> "" AndAlso
               cboFilterCourse.Text <> "All" Then

                query &=
                    "AND course = ? "

            End If


            query &=
                "ORDER BY students_name ASC"


            Using cmd As New OdbcCommand(query, con)

                '=========================
                ' SEARCH PARAMETERS
                '=========================
                If txtSearch.Text.Trim() <> "" Then

                    Dim searchValue As String =
                        "%" &
                        txtSearch.Text.Trim() &
                        "%"

                    cmd.Parameters.AddWithValue(
                        "@searchName",
                        searchValue
                    )

                    cmd.Parameters.AddWithValue(
                        "@searchID",
                        searchValue
                    )

                    cmd.Parameters.AddWithValue(
                        "@searchContact",
                        searchValue
                    )

                End If


                '=========================
                ' YEAR PARAMETER
                '=========================
                If cboFilterYear.Text <> "" AndAlso
                   cboFilterYear.Text <> "All" Then

                    cmd.Parameters.AddWithValue(
                        "@year",
                        cboFilterYear.Text
                    )

                End If


                '=========================
                ' COURSE PARAMETER
                '=========================
                If cboFilterCourse.Text <> "" AndAlso
                   cboFilterCourse.Text <> "All" Then

                    cmd.Parameters.AddWithValue(
                        "@course",
                        cboFilterCourse.Text
                    )

                End If


                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvStudents.DataSource = dt

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Load Students Error: " &
                ex.Message,
                "Manage Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' TOTAL STUDENTS
    '==================================================
    Private Sub UpdateTotalStudents()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT COUNT(*) " &
                "FROM students"


            Using cmd As New OdbcCommand(query, con)

                Dim total As Integer =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    )

                lblTotalStudents.Text =
                    total.ToString()

            End Using


        Catch ex As Exception

            lblTotalStudents.Text = "0"

        End Try

    End Sub


    '==================================================
    ' SEARCH
    '==================================================
    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        LoadStudents()

    End Sub


    '==================================================
    ' YEAR FILTER
    '==================================================
    Private Sub cboFilterYear_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboFilterYear.SelectedIndexChanged

        LoadStudents()

    End Sub


    '==================================================
    ' COURSE FILTER
    '==================================================
    Private Sub cboFilterCourse_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboFilterCourse.SelectedIndexChanged

        LoadStudents()

    End Sub


    '==================================================
    ' CLICK STUDENT
    '==================================================
    Private Sub dgvStudents_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvStudents.CellClick

        If e.RowIndex < 0 Then Return


        Try

            Dim rowView As DataRowView =
                TryCast(
                    dgvStudents.Rows(e.RowIndex).
                    DataBoundItem,
                    DataRowView
                )


            If rowView Is Nothing Then Return


            selectedStudentId =
                Convert.ToInt32(
                    rowView("student_id")
                )


            txtStudentName.Text =
                rowView("student_name").
                ToString()


            cboYearLevel.Text =
                rowView("year_level").
                ToString()


            cboCourse.Text =
                rowView("course").
                ToString()


            If IsDBNull(
                rowView("parent_contact_number")
            ) Then

                txtParentContact.Text = ""

            Else

                txtParentContact.Text =
                    rowView(
                        "parent_contact_number"
                    ).ToString()

            End If


            btnSave.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True


        Catch ex As Exception

            MessageBox.Show(
                "Student Selection Error: " &
                ex.Message
            )

        End Try

    End Sub


    '==================================================
    ' VALIDATE STUDENT FORM
    '==================================================
    Private Function ValidateStudentForm() As Boolean

        If txtStudentName.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the student name.",
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtStudentName.Focus()

            Return False

        End If


        If cboYearLevel.SelectedIndex = -1 Then

            MessageBox.Show(
                "Please select a year level.",
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            cboYearLevel.Focus()

            Return False

        End If


        If cboCourse.SelectedIndex = -1 Then

            MessageBox.Show(
                "Please select a course.",
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            cboCourse.Focus()

            Return False

        End If


        ' Parent contact is optional in database.
        ' But if entered, basic validation:
        If txtParentContact.Text.Trim() <> "" Then

            Dim contact As String =
                txtParentContact.Text.Trim()


            If Not contact.All(AddressOf Char.IsDigit) Then

                MessageBox.Show(
                    "Parent contact number must contain numbers only.",
                    "Invalid Contact Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtParentContact.Focus()

                Return False

            End If

        End If


        Return True

    End Function


    '==================================================
    ' SAVE STUDENT
    '==================================================
    Private Sub btnSave_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSave.Click

        If Not ValidateStudentForm() Then
            Return
        End If


        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "INSERT INTO students " &
                "(" &
                "students_name, " &
                "year_level, " &
                "course, " &
                "parent_contact_number, " &
                "qr_code_data" &
                ") " &
                "VALUES (?, ?, ?, ?, NULL)"


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@name",
                    txtStudentName.Text.Trim()
                )

                cmd.Parameters.AddWithValue(
                    "@year",
                    cboYearLevel.Text
                )

                cmd.Parameters.AddWithValue(
                    "@course",
                    cboCourse.Text
                )


                If txtParentContact.Text.Trim() = "" Then

                    cmd.Parameters.AddWithValue(
                        "@contact",
                        DBNull.Value
                    )

                Else

                    cmd.Parameters.AddWithValue(
                        "@contact",
                        txtParentContact.Text.Trim()
                    )

                End If


                cmd.ExecuteNonQuery()

            End Using


            MessageBox.Show(
                "Student added successfully.",
                "Manage Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadStudents()
            UpdateTotalStudents()
            ClearFields()


        Catch ex As Exception

            MessageBox.Show(
                "Save Student Error: " &
                ex.Message,
                "Manage Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' UPDATE STUDENT
    '==================================================
    Private Sub btnUpdate_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpdate.Click

        If selectedStudentId = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Update Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If Not ValidateStudentForm() Then
            Return
        End If


        Dim result As DialogResult =
            MessageBox.Show(
                "Update the information of this student?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If result = DialogResult.No Then
            Return
        End If


        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "UPDATE students SET " &
                "students_name = ?, " &
                "year_level = ?, " &
                "course = ?, " &
                "parent_contact_number = ? " &
                "WHERE students_id = ?"


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@name",
                    txtStudentName.Text.Trim()
                )

                cmd.Parameters.AddWithValue(
                    "@year",
                    cboYearLevel.Text
                )

                cmd.Parameters.AddWithValue(
                    "@course",
                    cboCourse.Text
                )


                If txtParentContact.Text.Trim() = "" Then

                    cmd.Parameters.AddWithValue(
                        "@contact",
                        DBNull.Value
                    )

                Else

                    cmd.Parameters.AddWithValue(
                        "@contact",
                        txtParentContact.Text.Trim()
                    )

                End If


                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedStudentId
                )


                cmd.ExecuteNonQuery()

            End Using


            MessageBox.Show(
                "Student information updated successfully.",
                "Update Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadStudents()
            ClearFields()


        Catch ex As Exception

            MessageBox.Show(
                "Update Student Error: " &
                ex.Message,
                "Manage Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' CHECK IF STUDENT HAS ENTRY/EXIT RECORDS
    '==================================================
    Private Function HasEntryExitRecords(
        studentId As Integer
    ) As Boolean

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT COUNT(*) " &
                "FROM attendance_records " &
                "WHERE students_id = ?"


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@id",
                    studentId
                )


                Dim count As Integer =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    )


                Return count > 0

            End Using


        Catch

            Return True

        End Try

    End Function


    '==================================================
    ' DELETE STUDENT
    '==================================================
    Private Sub btnDelete_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDelete.Click

        If selectedStudentId = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Delete Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        ' Do not delete students with historical records.
        If HasEntryExitRecords(selectedStudentId) Then

            MessageBox.Show(
                "This student cannot be deleted because " &
                "they already have entry/exit records." &
                vbCrLf &
                vbCrLf &
                "Keeping the student record prevents historical " &
                "entry/exit data from being lost.",
                "Cannot Delete Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Dim result As DialogResult =
            MessageBox.Show(
                "Are you sure you want to delete " &
                txtStudentName.Text.Trim() &
                "?" &
                vbCrLf &
                vbCrLf &
                "This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )


        If result = DialogResult.No Then
            Return
        End If


        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "DELETE FROM students " &
                "WHERE students_id = ?"


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedStudentId
                )

                cmd.ExecuteNonQuery()

            End Using


            MessageBox.Show(
                "Student deleted successfully.",
                "Delete Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadStudents()
            UpdateTotalStudents()
            ClearFields()


        Catch ex As Exception

            MessageBox.Show(
                "Delete Student Error: " &
                ex.Message,
                "Manage Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' CLEAR BUTTON
    '==================================================
    Private Sub btnClear_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClear.Click

        ClearFields()

    End Sub


    '==================================================
    ' CLEAR FIELDS
    '==================================================
    Private Sub ClearFields()

        selectedStudentId = 0

        txtStudentName.Clear()
        txtParentContact.Clear()

        cboYearLevel.SelectedIndex = -1
        cboCourse.SelectedIndex = -1

        dgvStudents.ClearSelection()

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtStudentName.Focus()

    End Sub


    '==================================================
    ' NORMALIZE YEAR LEVEL FOR IMPORT
    '==================================================
    Private Function NormalizeYearLevel(
        value As String
    ) As String

        Dim text As String =
            value.Trim().ToLower()


        Select Case text

            Case "1st year"
                Return "1st Year"

            Case "2nd year"
                Return "2nd Year"

            Case "3rd year"
                Return "3rd Year"

            Case "4th year"
                Return "4th Year"

            Case Else
                Return ""

        End Select

    End Function


    '==================================================
    ' NORMALIZE COURSE FOR IMPORT
    '==================================================
    Private Function NormalizeCourse(
        value As String
    ) As String

        Dim text As String =
            value.Trim().ToUpper()


        Select Case text

            Case "BSTM"
                Return "BSTM"

            Case "BSHM"
                Return "BSHM"

            Case "BSIT"
                Return "BSIT"

            Case "BSED"
                Return "BSEd"

            Case Else
                Return ""

        End Select

    End Function


    '==================================================
    ' BULK EXCEL IMPORT
    '==================================================
    Private Sub btnImportStudents_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnImportStudents.Click

        Try

            Using openFile As New OpenFileDialog()

                openFile.Filter =
                    "Excel Workbook (*.xlsx)|*.xlsx"

                openFile.Title =
                    "Select Student Excel File"


                If openFile.ShowDialog() <>
                   DialogResult.OK Then

                    Return

                End If


                ImportStudentsFromExcel(
                    openFile.FileName
                )

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Import Error: " &
                ex.Message,
                "Import Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' IMPORT EXCEL FUNCTION
    '==================================================
    Private Sub ImportStudentsFromExcel(
        filePath As String
    )

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Using workbook As New XLWorkbook(filePath)

                Dim worksheet =
                    workbook.Worksheet(1)


                Dim lastRow As Integer =
                    worksheet.LastRowUsed().
                    RowNumber()


                If lastRow < 2 Then

                    MessageBox.Show(
                        "The Excel file does not contain student records.",
                        "Import Students",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    Return

                End If


                Dim importedCount As Integer = 0
                Dim skippedCount As Integer = 0


                ' Row 1 = headers
                For row As Integer = 2 To lastRow

                    Dim studentName As String =
                        worksheet.Cell(row, 1).
                        GetString().
                        Trim()


                    Dim yearValue As String =
                        worksheet.Cell(row, 2).
                        GetString().
                        Trim()


                    Dim courseValue As String =
                        worksheet.Cell(row, 3).
                        GetString().
                        Trim()


                    Dim parentContact As String =
                        worksheet.Cell(row, 4).
                        GetString().
                        Trim()


                    ' Ignore completely empty row
                    If studentName = "" AndAlso
                       yearValue = "" AndAlso
                       courseValue = "" AndAlso
                       parentContact = "" Then

                        Continue For

                    End If


                    Dim yearLevel As String =
                        NormalizeYearLevel(
                            yearValue
                        )


                    Dim course As String =
                        NormalizeCourse(
                            courseValue
                        )


                    ' Required information missing
                    If studentName = "" OrElse
                       yearLevel = "" OrElse
                       course = "" Then

                        skippedCount += 1
                        Continue For

                    End If


                    ' Contact must be numeric if present
                    If parentContact <> "" AndAlso
                       Not parentContact.All(
                           AddressOf Char.IsDigit
                       ) Then

                        skippedCount += 1
                        Continue For

                    End If


                    Dim query As String =
                        "INSERT INTO students " &
                        "(" &
                        "students_name, " &
                        "year_level, " &
                        "course, " &
                        "parent_contact_number, " &
                        "qr_code_data" &
                        ") " &
                        "VALUES (?, ?, ?, ?, NULL)"


                    Using cmd As New OdbcCommand(
                        query,
                        con
                    )

                        cmd.Parameters.AddWithValue(
                            "@name",
                            studentName
                        )

                        cmd.Parameters.AddWithValue(
                            "@year",
                            yearLevel
                        )

                        cmd.Parameters.AddWithValue(
                            "@course",
                            course
                        )


                        If parentContact = "" Then

                            cmd.Parameters.AddWithValue(
                                "@contact",
                                DBNull.Value
                            )

                        Else

                            cmd.Parameters.AddWithValue(
                                "@contact",
                                parentContact
                            )

                        End If


                        cmd.ExecuteNonQuery()

                    End Using


                    importedCount += 1

                Next


                LoadStudents()
                UpdateTotalStudents()
                ClearFields()


                MessageBox.Show(
                    "Import completed." &
                    vbCrLf &
                    vbCrLf &
                    "Imported: " &
                    importedCount.ToString() &
                    vbCrLf &
                    "Skipped: " &
                    skippedCount.ToString(),
                    "Import Students",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Excel Import Error: " &
                ex.Message,
                "Import Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class
