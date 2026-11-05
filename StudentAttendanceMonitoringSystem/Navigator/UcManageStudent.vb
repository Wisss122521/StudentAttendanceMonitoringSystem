Imports System.Data
Imports System.Data.Odbc
Imports ClosedXML.Excel

Public Class UcManageStudent

    Private selectedStudentId As Integer = 0
    Private isLoading As Boolean = False


    '==================================================
    ' USERCONTROL LOAD
    '==================================================
    Private Sub ManageStudents_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            isLoading = True

            EnsureDatabaseConnection()

            LoadDropdowns()

            isLoading = False

            LoadStudents()
            UpdateTotalStudents()

            ClearFields()
            UpdateButtonAppearance()

            timerClock.Interval = 1000
            timerClock.Start()

            UpdateDateTime()

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load Manage Students." &
                vbCrLf &
                vbCrLf &
                ex.Message,
                "Manage Students Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            isLoading = False

        End Try

    End Sub


    '==================================================
    ' DATABASE CONNECTION
    '==================================================
    Private Sub EnsureDatabaseConnection()

        If con Is Nothing OrElse
           con.State <> ConnectionState.Open Then

            vbConnection()

        End If

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
    ' TIMER
    '==================================================
    Private Sub timerClock_Tick(
        sender As Object,
        e As EventArgs
    ) Handles timerClock.Tick

        UpdateDateTime()

    End Sub


    Private Sub UpdateDateTime()

        lblDateTime.Text =
            DateTime.Now.ToString(
                "dddd, MMMM dd, yyyy"
            ) &
            "   |   " &
            DateTime.Now.ToString(
                "hh:mm:ss tt"
            )

    End Sub


    '==================================================
    ' LOAD STUDENTS
    '==================================================
    Private Sub LoadStudents()

        Try

            EnsureDatabaseConnection()


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
            If Not String.IsNullOrWhiteSpace(
                txtSearch.Text
            ) Then

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


            Using cmd As New OdbcCommand(
                query,
                con
            )

                '=========================
                ' SEARCH PARAMETERS
                '=========================
                If Not String.IsNullOrWhiteSpace(
                    txtSearch.Text
                ) Then

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
            ' CLEAN USER-FRIENDLY TABLE HEADERS
            '==================================================
            FormatStudentsGrid()

            dgvStudents.ClearSelection()


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

                Case "student_id"

                    column.HeaderText =
                    "Student ID"

                    column.FillWeight =
                    55


                Case "student_name"

                    column.HeaderText =
                    "Student Name"

                    column.FillWeight =
                    130


                Case "year_level"

                    column.HeaderText =
                    "Year Level"

                    column.FillWeight =
                    75


                Case "course"

                    column.HeaderText =
                    "Course"

                    column.FillWeight =
                    65


                Case "parent_contact_number"

                    column.HeaderText =
                    "Parent Contact Number"

                    column.FillWeight =
                    105

            End Select


            '==================================================
            ' CENTER EVERY COLUMN
            '==================================================
            column.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        Next

    End Sub


    '==================================================
    ' TOTAL STUDENTS
    '==================================================
    Private Sub UpdateTotalStudents()

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT COUNT(*) " &
                "FROM students"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Dim result As Object =
                    cmd.ExecuteScalar()


                If result Is Nothing OrElse
                   IsDBNull(result) Then

                    lblTotalStudents.Text =
                        "0"

                Else

                    lblTotalStudents.Text =
                        Convert.ToInt32(
                            result
                        ).ToString()

                End If

            End Using


        Catch

            lblTotalStudents.Text =
                "0"

        End Try

    End Sub


    '==================================================
    ' SEARCH
    '==================================================
    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        If isLoading Then
            Return
        End If

        LoadStudents()

    End Sub


    '==================================================
    ' YEAR FILTER
    '==================================================
    Private Sub cboFilterYear_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboFilterYear.SelectedIndexChanged

        If isLoading Then
            Return
        End If

        LoadStudents()

    End Sub


    '==================================================
    ' COURSE FILTER
    '==================================================
    Private Sub cboFilterCourse_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboFilterCourse.SelectedIndexChanged

        If isLoading Then
            Return
        End If

        LoadStudents()

    End Sub


    '==================================================
    ' CLICK STUDENT
    '==================================================
    Private Sub dgvStudents_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvStudents.CellClick

        If e.RowIndex < 0 Then
            Return
        End If


        If e.RowIndex >=
           dgvStudents.Rows.Count Then

            Return

        End If


        Try

            Dim selectedRow As DataGridViewRow =
                dgvStudents.Rows(
                    e.RowIndex
                )


            If selectedRow Is Nothing Then
                Return
            End If


            Dim rowView As DataRowView =
                TryCast(
                    selectedRow.DataBoundItem,
                    DataRowView
                )


            If rowView Is Nothing Then
                Return
            End If


            If Not rowView.Row.Table.Columns.Contains(
                "student_id"
            ) Then

                Return

            End If


            If IsDBNull(
                rowView("student_id")
            ) Then

                Return

            End If


            selectedStudentId =
                Convert.ToInt32(
                    rowView("student_id")
                )


            txtStudentName.Text =
                If(
                    IsDBNull(
                        rowView("student_name")
                    ),
                    "",
                    rowView(
                        "student_name"
                    ).ToString()
                )


            cboYearLevel.Text =
                If(
                    IsDBNull(
                        rowView("year_level")
                    ),
                    "",
                    rowView(
                        "year_level"
                    ).ToString()
                )


            cboCourse.Text =
                If(
                    IsDBNull(
                        rowView("course")
                    ),
                    "",
                    rowView(
                        "course"
                    ).ToString()
                )


            txtParentContact.Text =
                If(
                    IsDBNull(
                        rowView(
                            "parent_contact_number"
                        )
                    ),
                    "",
                    rowView(
                        "parent_contact_number"
                    ).ToString()
                )


            btnSave.Enabled =
                False

            btnUpdate.Enabled =
                True

            btnDelete.Enabled =
                True


        Catch ex As Exception

            MessageBox.Show(
                "Student Selection Error: " &
                ex.Message,
                "Manage Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' BUTTON APPEARANCE
    '==================================================
    Private Sub UpdateButtonAppearance()

        '==================================================
        ' SAVE
        '==================================================
        If btnSave.Enabled Then

            btnSave.BackColor =
                Color.FromArgb(
                    103,
                    60,
                    36
                )

            btnSave.ForeColor =
                Color.White

            btnSave.Cursor =
                Cursors.Hand

        Else

            btnSave.BackColor =
                Color.FromArgb(
                    220,
                    220,
                    220
                )

            btnSave.ForeColor =
                Color.Gray

            btnSave.Cursor =
                Cursors.No

        End If


        '==================================================
        ' UPDATE
        '==================================================
        If btnUpdate.Enabled Then

            btnUpdate.BackColor =
                Color.FromArgb(
                    103,
                    60,
                    36
                )

            btnUpdate.ForeColor =
                Color.White

            btnUpdate.Cursor =
                Cursors.Hand

        Else

            btnUpdate.BackColor =
                Color.FromArgb(
                    220,
                    220,
                    220
                )

            btnUpdate.ForeColor =
                Color.Gray

            btnUpdate.Cursor =
                Cursors.No

        End If


        '==================================================
        ' DELETE
        '==================================================
        If btnDelete.Enabled Then

            btnDelete.BackColor =
                Color.FromArgb(
                    201,
                    75,
                    67
                )

            btnDelete.ForeColor =
                Color.White

            btnDelete.Cursor =
                Cursors.Hand

        Else

            btnDelete.BackColor =
                Color.FromArgb(
                    220,
                    220,
                    220
                )

            btnDelete.ForeColor =
                Color.Gray

            btnDelete.Cursor =
                Cursors.No

        End If

    End Sub


    Private Sub Buttons_EnabledChanged(
        sender As Object,
        e As EventArgs
    ) Handles btnSave.EnabledChanged,
              btnUpdate.EnabledChanged,
              btnDelete.EnabledChanged

        UpdateButtonAppearance()

    End Sub


    '==================================================
    ' VALIDATE STUDENT FORM
    '==================================================
    Private Function ValidateStudentForm() As Boolean

        If String.IsNullOrWhiteSpace(
            txtStudentName.Text
        ) Then

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


        '==================================================
        ' PARENT CONTACT
        '==================================================
        If Not String.IsNullOrWhiteSpace(
            txtParentContact.Text
        ) Then

            Dim contact As String =
                txtParentContact.Text.Trim()


            If Not contact.All(
                AddressOf Char.IsDigit
            ) Then

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

            EnsureDatabaseConnection()


            '==================================================
            ' DUPLICATE CHECK
            '==================================================
            If StudentExists(
                txtStudentName.Text.Trim(),
                cboYearLevel.Text,
                cboCourse.Text
            ) Then

                MessageBox.Show(
                    "A student with the same name, year level, and course already exists.",
                    "Duplicate Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtStudentName.Focus()

                Return

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


                If String.IsNullOrWhiteSpace(
                    txtParentContact.Text
                ) Then

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


                Dim rowsAffected As Integer =
                    cmd.ExecuteNonQuery()


                If rowsAffected <= 0 Then

                    Throw New Exception(
                        "The student record was not inserted."
                    )

                End If

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

        If selectedStudentId <= 0 Then

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


        Try

            EnsureDatabaseConnection()


            '==================================================
            ' DUPLICATE CHECK
            ' EXCLUDE CURRENT STUDENT
            '==================================================
            If StudentExists(
                txtStudentName.Text.Trim(),
                cboYearLevel.Text,
                cboCourse.Text,
                Nothing,
                selectedStudentId
            ) Then

                MessageBox.Show(
                    "Another student with the same name, year level, and course already exists.",
                    "Duplicate Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtStudentName.Focus()

                Return

            End If


            Dim result As DialogResult =
                MessageBox.Show(
                    "Update the information of this student?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )


            If result <> DialogResult.Yes Then
                Return
            End If


            Dim query As String =
                "UPDATE students SET " &
                "students_name = ?, " &
                "year_level = ?, " &
                "course = ?, " &
                "parent_contact_number = ? " &
                "WHERE students_id = ?"


            Using cmd As New OdbcCommand(
                query,
                con
            )

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


                If String.IsNullOrWhiteSpace(
                    txtParentContact.Text
                ) Then

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


                Dim rowsAffected As Integer =
                    cmd.ExecuteNonQuery()


                If rowsAffected <= 0 Then

                    Throw New Exception(
                        "The student record was not found or no changes were made."
                    )

                End If

            End Using


            MessageBox.Show(
                "Student information updated successfully.",
                "Update Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadStudents()
            UpdateTotalStudents()
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
    ' CHECK IF STUDENT HAS RELATED RECORDS
    '==================================================
    Private Function HasRelatedRecords(
        studentId As Integer
    ) As Boolean

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "(" &
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE students_id = ?" &
                ") + " &
                "(" &
                    "SELECT COUNT(*) " &
                    "FROM sms_logs " &
                    "WHERE students_id = ?" &
                ") AS related_count"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@attendanceStudentId",
                    studentId
                )

                cmd.Parameters.AddWithValue(
                    "@smsStudentId",
                    studentId
                )


                Dim result As Object =
                    cmd.ExecuteScalar()


                If result Is Nothing OrElse
                   IsDBNull(result) Then

                    Return False

                End If


                Return Convert.ToInt32(
                    result
                ) > 0

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Unable to verify the student's related records." &
                vbCrLf &
                vbCrLf &
                ex.Message,
                "Delete Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

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

        If selectedStudentId <= 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Delete Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        '==================================================
        ' DO NOT DELETE STUDENT WITH HISTORY
        '==================================================
        If HasRelatedRecords(
            selectedStudentId
        ) Then

            MessageBox.Show(
                "This student cannot be deleted because " &
                "they already have entry/exit or SMS records." &
                vbCrLf &
                vbCrLf &
                "Keeping the student record prevents historical " &
                "system data from being lost.",
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


        If result <> DialogResult.Yes Then
            Return
        End If


        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "DELETE FROM students " &
                "WHERE students_id = ?"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedStudentId
                )


                Dim rowsAffected As Integer =
                    cmd.ExecuteNonQuery()


                If rowsAffected <= 0 Then

                    Throw New Exception(
                        "The student record was not found."
                    )

                End If

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

        selectedStudentId =
            0

        txtStudentName.Clear()
        txtParentContact.Clear()

        cboYearLevel.SelectedIndex =
            -1

        cboCourse.SelectedIndex =
            -1


        If dgvStudents IsNot Nothing Then

            dgvStudents.ClearSelection()

        End If


        btnSave.Enabled =
            True

        btnUpdate.Enabled =
            False

        btnDelete.Enabled =
            False


        If txtStudentName.CanFocus Then

            txtStudentName.Focus()

        End If

    End Sub


    '==================================================
    ' NORMALIZE YEAR LEVEL FOR IMPORT
    '==================================================
    Private Function NormalizeYearLevel(
        value As String
    ) As String

        If value Is Nothing Then
            Return ""
        End If


        Dim text As String =
            value.Trim().
            ToLowerInvariant()


        Select Case text

            Case "1",
                 "1st",
                 "1st year",
                 "first year"

                Return "1st Year"


            Case "2",
                 "2nd",
                 "2nd year",
                 "second year"

                Return "2nd Year"


            Case "3",
                 "3rd",
                 "3rd year",
                 "third year"

                Return "3rd Year"


            Case "4",
                 "4th",
                 "4th year",
                 "fourth year"

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

        If value Is Nothing Then
            Return ""
        End If


        Dim text As String =
            value.Trim().
            ToUpperInvariant()


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
    ' BULK EXCEL IMPORT BUTTON
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
    ' CHECK DUPLICATE STUDENT
    '==================================================
    Private Function StudentExists(
        studentName As String,
        yearLevel As String,
        course As String,
        Optional transaction As OdbcTransaction = Nothing,
        Optional excludeStudentId As Integer = 0
    ) As Boolean


        If transaction Is Nothing Then

            EnsureDatabaseConnection()

        Else

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                Throw New InvalidOperationException(
                    "The database connection is not available."
                )

            End If

        End If


        Dim query As String =
            "SELECT COUNT(*) " &
            "FROM students " &
            "WHERE LOWER(TRIM(students_name)) = LOWER(TRIM(?)) " &
            "AND year_level = ? " &
            "AND course = ? "


        If excludeStudentId > 0 Then

            query &=
                "AND students_id <> ? "

        End If


        Using cmd As New OdbcCommand(
            query,
            con
        )

            If transaction IsNot Nothing Then

                cmd.Transaction =
                    transaction

            End If


            cmd.Parameters.AddWithValue(
                "@name",
                studentName.Trim()
            )

            cmd.Parameters.AddWithValue(
                "@year",
                yearLevel
            )

            cmd.Parameters.AddWithValue(
                "@course",
                course
            )


            If excludeStudentId > 0 Then

                cmd.Parameters.AddWithValue(
                    "@excludeId",
                    excludeStudentId
                )

            End If


            Dim result As Object =
                cmd.ExecuteScalar()


            If result Is Nothing OrElse
               IsDBNull(result) Then

                Return False

            End If


            Return Convert.ToInt32(
                result
            ) > 0

        End Using

    End Function


    '==================================================
    ' IMPORT EXCEL FUNCTION
    '==================================================
    Private Sub ImportStudentsFromExcel(
        filePath As String
    )

        Try

            EnsureDatabaseConnection()


            Using workbook As New XLWorkbook(
                filePath
            )

                Dim worksheet =
                    workbook.Worksheet(1)


                '==================================================
                ' CHECK EMPTY WORKSHEET
                '==================================================
                Dim lastUsedRow =
                    worksheet.LastRowUsed()


                If lastUsedRow Is Nothing Then

                    MessageBox.Show(
                        "The Excel file does not contain student records.",
                        "Import Students",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    Return

                End If


                Dim lastRow As Integer =
                    lastUsedRow.RowNumber()


                If lastRow < 2 Then

                    MessageBox.Show(
                        "The Excel file does not contain student records.",
                        "Import Students",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    Return

                End If


                Dim importedCount As Integer =
                    0

                Dim duplicateCount As Integer =
                    0

                Dim invalidCount As Integer =
                    0


                '==================================================
                ' START DATABASE TRANSACTION
                '==================================================
                Using transaction As OdbcTransaction =
                    con.BeginTransaction()

                    Try

                        ' Row 1 = headers
                        For row As Integer =
                            2 To lastRow


                            Dim studentName As String =
                                worksheet.
                                Cell(row, 1).
                                GetString().
                                Trim()


                            Dim yearValue As String =
                                worksheet.
                                Cell(row, 2).
                                GetString().
                                Trim()


                            Dim courseValue As String =
                                worksheet.
                                Cell(row, 3).
                                GetString().
                                Trim()


                            Dim parentContact As String =
                                worksheet.
                                Cell(row, 4).
                                GetString().
                                Trim()


                            '======================================
                            ' IGNORE EMPTY ROW
                            '======================================
                            If studentName = "" AndAlso
                               yearValue = "" AndAlso
                               courseValue = "" AndAlso
                               parentContact = "" Then

                                Continue For

                            End If


                            '======================================
                            ' NORMALIZE
                            '======================================
                            Dim yearLevel As String =
                                NormalizeYearLevel(
                                    yearValue
                                )


                            Dim course As String =
                                NormalizeCourse(
                                    courseValue
                                )


                            '======================================
                            ' REQUIRED INFORMATION
                            '======================================
                            If studentName = "" OrElse
                               yearLevel = "" OrElse
                               course = "" Then

                                invalidCount += 1

                                Continue For

                            End If


                            '======================================
                            ' CONTACT VALIDATION
                            '======================================
                            If parentContact <> "" AndAlso
                               Not parentContact.All(
                                   AddressOf Char.IsDigit
                               ) Then

                                invalidCount += 1

                                Continue For

                            End If


                            '======================================
                            ' DUPLICATE CHECK
                            '======================================
                            If StudentExists(
                                studentName,
                                yearLevel,
                                course,
                                transaction
                            ) Then

                                duplicateCount += 1

                                Continue For

                            End If


                            '======================================
                            ' INSERT
                            '======================================
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
                                con,
                                transaction
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


                                Dim rowsAffected As Integer =
                                    cmd.ExecuteNonQuery()


                                If rowsAffected <= 0 Then

                                    Throw New Exception(
                                        "Unable to import student on Excel row " &
                                        row.ToString() &
                                        "."
                                    )

                                End If

                            End Using


                            importedCount += 1

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


                LoadStudents()
                UpdateTotalStudents()
                ClearFields()


                MessageBox.Show(
                    "Import completed successfully." &
                    vbCrLf &
                    vbCrLf &
                    "Imported: " &
                    importedCount.ToString() &
                    vbCrLf &
                    "Duplicates skipped: " &
                    duplicateCount.ToString() &
                    vbCrLf &
                    "Invalid rows skipped: " &
                    invalidCount.ToString(),
                    "Import Students",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "The student import failed." &
                vbCrLf &
                vbCrLf &
                "No partial import was kept." &
                vbCrLf &
                ex.Message,
                "Import Students",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class