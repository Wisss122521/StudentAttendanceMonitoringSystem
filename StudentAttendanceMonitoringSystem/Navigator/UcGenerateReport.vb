Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Imports ClosedXML.Excel
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class UcGenerateReport

    '====================================
    ' FORM LOAD
    '====================================
    Private Sub AttendanceReports_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try
            EnsureDatabaseConnection()

            LoadDefaultDateRange()
            LoadCourses()
            LoadAttendanceReports()

            timerClock.Interval = 1000
            timerClock.Start()

            UpdateDateTime()

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load the report page." &
                vbCrLf &
                ex.Message,
                "Student Entry/Exit Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' DATABASE CONNECTION
    '====================================
    Private Sub EnsureDatabaseConnection()

        If con Is Nothing OrElse
           con.State <> ConnectionState.Open Then

            vbConnection()

        End If

    End Sub


    '====================================
    ' TIMER
    '====================================
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


    '====================================
    ' LOAD DEFAULT DATE RANGE
    '====================================
    Private Sub LoadDefaultDateRange()

        Try

            EnsureDatabaseConnection()

            Dim query As String =
                "SELECT " &
                "MIN(attendance_date) AS min_date, " &
                "MAX(attendance_date) AS max_date " &
                "FROM attendance_records"


            Using cmd As New OdbcCommand(query, con)

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() AndAlso
                       Not IsDBNull(reader("min_date")) AndAlso
                       Not IsDBNull(reader("max_date")) Then

                        dtpFrom.Value =
                            Convert.ToDateTime(
                                reader("min_date")
                            ).Date

                        dtpTo.Value =
                            Convert.ToDateTime(
                                reader("max_date")
                            ).Date

                    Else

                        dtpFrom.Value =
                            New DateTime(
                                Date.Today.Year,
                                Date.Today.Month,
                                1
                            )

                        dtpTo.Value =
                            Date.Today

                    End If

                End Using

            End Using


        Catch

            dtpFrom.Value =
                New DateTime(
                    Date.Today.Year,
                    Date.Today.Month,
                    1
                )

            dtpTo.Value =
                Date.Today

        End Try

    End Sub


    '====================================
    ' LOAD COURSES
    '====================================
    Private Sub LoadCourses()

        Try

            EnsureDatabaseConnection()

            cboCourse.Items.Clear()
            cboCourse.Items.Add("All")


            Dim query As String =
                "SELECT DISTINCT course " &
                "FROM students " &
                "WHERE course IS NOT NULL " &
                "AND TRIM(course) <> '' " &
                "ORDER BY course ASC"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    While reader.Read()

                        cboCourse.Items.Add(
                            reader(
                                "course"
                            ).ToString()
                        )

                    End While

                End Using

            End Using


            cboCourse.SelectedIndex = 0


        Catch ex As Exception

            MessageBox.Show(
                "Load Course Error: " &
                ex.Message,
                "Student Entry/Exit Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' LOAD ATTENDANCE RECORDS
    '====================================
    Private Sub LoadAttendanceReports()

        Try

            EnsureDatabaseConnection()


            If dtpFrom.Value.Date >
               dtpTo.Value.Date Then

                MessageBox.Show(
                    "Date From cannot be later than Date To.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            Dim query As String =
                "SELECT " &
                "a.students_id AS student_id, " &
                "COALESCE(s.students_name, 'Unknown Student') AS student_name, " &
                "COALESCE(CONCAT(s.year_level, ' - ', s.course), '-') AS year_course, " &
                "a.attendance_date, " &
                "a.time_in, " &
                "a.time_out " &
                "FROM attendance_records a " &
                "LEFT JOIN students s " &
                "ON a.students_id = s.students_id " &
                "WHERE a.attendance_date BETWEEN ? AND ? "


            If Not String.IsNullOrWhiteSpace(
                txtSearch.Text
            ) Then

                query &=
                    "AND (" &
                    "s.students_name LIKE ? " &
                    "OR CAST(a.students_id AS CHAR) LIKE ?" &
                    ") "

            End If


            If cboCourse.Text <> "" AndAlso
               cboCourse.Text <> "All" Then

                query &=
                    "AND s.course = ? "

            End If


            query &=
                "ORDER BY " &
                "a.attendance_date DESC, " &
                "a.time_in DESC"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@dateFrom",
                    dtpFrom.Value.Date
                )

                cmd.Parameters.AddWithValue(
                    "@dateTo",
                    dtpTo.Value.Date
                )


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

                End If


                If cboCourse.Text <> "" AndAlso
                   cboCourse.Text <> "All" Then

                    cmd.Parameters.AddWithValue(
                        "@course",
                        cboCourse.Text
                    )

                End If


                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    Dim dt As New DataTable()

                    adapter.Fill(dt)

                    dgvAttendance.DataSource =
                        dt

                End Using

            End Using


            FormatAttendanceGrid()

            dgvAttendance.ClearSelection()

            UpdateReportSummary()


        Catch ex As Exception

            MessageBox.Show(
                "Load Attendance Error: " &
                ex.Message,
                "Student Entry/Exit Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' FORMAT ATTENDANCE GRID
    '====================================
    Private Sub FormatAttendanceGrid()

        If dgvAttendance Is Nothing OrElse
           dgvAttendance.Columns.Count = 0 Then

            Return

        End If


        ' CENTER HEADERS
        dgvAttendance.ColumnHeadersDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter


        ' CENTER ALL ROW TEXT
        dgvAttendance.DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter


        For Each column As DataGridViewColumn In
        dgvAttendance.Columns


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

                Case "student_id",
                 "colstudentid"

                    column.HeaderText =
                    "Student ID"

                    column.FillWeight =
                    60


                Case "student_name",
                 "colstudentname"

                    column.HeaderText =
                    "Student Name"

                    column.FillWeight =
                    130


                Case "year_course",
                 "colyearcourse"

                    column.HeaderText =
                    "Year / Course"

                    column.FillWeight =
                    100


                Case "attendance_date",
                 "colattendancedate",
                 "coldate"

                    column.HeaderText =
                    "Date"

                    column.FillWeight =
                    80

                    column.DefaultCellStyle.Format =
                    "MMM dd, yyyy"


                Case "time_in",
                 "coltimein"

                    column.HeaderText =
                    "Time In"

                    column.FillWeight =
                    75


                Case "time_out",
                 "coltimeout"

                    column.HeaderText =
                    "Time Out"

                    column.FillWeight =
                    75

            End Select


            ' CENTER EACH COLUMN
            column.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        Next

    End Sub


    '====================================
    ' TIME OUT CELL FORMATTING
    '====================================
    Private Sub dgvAttendance_CellFormatting(
        sender As Object,
        e As DataGridViewCellFormattingEventArgs
    ) Handles dgvAttendance.CellFormatting

        If e.RowIndex < 0 OrElse
           e.ColumnIndex < 0 Then

            Return

        End If


        If dgvAttendance Is Nothing OrElse
           e.ColumnIndex >=
           dgvAttendance.Columns.Count Then

            Return

        End If


        Dim column As DataGridViewColumn =
            dgvAttendance.Columns(
                e.ColumnIndex
            )


        Dim columnKey As String =
            column.DataPropertyName


        If String.IsNullOrWhiteSpace(
            columnKey
        ) Then

            columnKey =
                column.Name

        End If


        If String.Equals(
            columnKey,
            "time_out",
            StringComparison.OrdinalIgnoreCase
        ) Then

            If e.Value Is Nothing OrElse
               IsDBNull(e.Value) OrElse
               String.IsNullOrWhiteSpace(
                   e.Value.ToString()
               ) Then

                e.Value = "-"
                e.FormattingApplied = True

            End If

        End If

    End Sub


    '====================================
    ' REPORT SUMMARY
    '====================================
    Private Sub UpdateReportSummary()

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "COUNT(*) AS total_count, " &
                "COALESCE(SUM(" &
                "CASE WHEN a.time_out IS NOT NULL " &
                "THEN 1 ELSE 0 END" &
                "), 0) AS complete_count, " &
                "COALESCE(SUM(" &
                "CASE WHEN a.time_out IS NULL " &
                "THEN 1 ELSE 0 END" &
                "), 0) AS no_timeout_count " &
                "FROM attendance_records a " &
                "LEFT JOIN students s " &
                "ON a.students_id = s.students_id " &
                "WHERE a.attendance_date BETWEEN ? AND ? "


            If Not String.IsNullOrWhiteSpace(
                txtSearch.Text
            ) Then

                query &=
                    "AND (" &
                    "s.students_name LIKE ? " &
                    "OR CAST(a.students_id AS CHAR) LIKE ?" &
                    ") "

            End If


            If cboCourse.Text <> "" AndAlso
               cboCourse.Text <> "All" Then

                query &=
                    "AND s.course = ? "

            End If


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@dateFrom",
                    dtpFrom.Value.Date
                )

                cmd.Parameters.AddWithValue(
                    "@dateTo",
                    dtpTo.Value.Date
                )


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

                End If


                If cboCourse.Text <> "" AndAlso
                   cboCourse.Text <> "All" Then

                    cmd.Parameters.AddWithValue(
                        "@course",
                        cboCourse.Text
                    )

                End If


                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        lblTotalRecords.Text =
                            reader(
                                "total_count"
                            ).ToString()

                        lblComplete.Text =
                            reader(
                                "complete_count"
                            ).ToString()

                        lblNoTimeOut.Text =
                            reader(
                                "no_timeout_count"
                            ).ToString()

                    Else

                        lblTotalRecords.Text =
                            "0"

                        lblComplete.Text =
                            "0"

                        lblNoTimeOut.Text =
                            "0"

                    End If

                End Using

            End Using


        Catch ex As Exception

            lblTotalRecords.Text = "0"
            lblComplete.Text = "0"
            lblNoTimeOut.Text = "0"

            MessageBox.Show(
                "Summary Error: " &
                ex.Message,
                "Student Entry/Exit Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' APPLY FILTER
    '====================================
    Private Sub btnApplyFilter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnApplyFilter.Click

        LoadAttendanceReports()

    End Sub


    '====================================
    ' RESET FILTER
    '====================================
    Private Sub btnReset_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReset.Click

        txtSearch.Clear()


        If cboCourse.Items.Count > 0 Then

            cboCourse.SelectedIndex =
                0

        End If


        LoadDefaultDateRange()

        LoadAttendanceReports()

    End Sub


    '====================================
    ' GET REPORT DATA
    '====================================
    Private Function GetReportData() As DataTable

        Dim dt As New DataTable()


        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "a.students_id AS 'Student ID', " &
                "COALESCE(s.students_name, 'Unknown Student') AS 'Student Name', " &
                "COALESCE(CONCAT(s.year_level, ' - ', s.course), '-') AS 'Year / Course', " &
                "DATE_FORMAT(a.attendance_date, '%Y-%m-%d') AS 'Date', " &
                "TIME_FORMAT(a.time_in, '%h:%i:%s %p') AS 'Time In', " &
                "CASE " &
                "WHEN a.time_out IS NULL THEN '' " &
                "ELSE TIME_FORMAT(a.time_out, '%h:%i:%s %p') " &
                "END AS 'Time Out' " &
                "FROM attendance_records a " &
                "LEFT JOIN students s " &
                "ON a.students_id = s.students_id " &
                "WHERE a.attendance_date BETWEEN ? AND ? "


            If Not String.IsNullOrWhiteSpace(
                txtSearch.Text
            ) Then

                query &=
                    "AND (" &
                    "s.students_name LIKE ? " &
                    "OR CAST(a.students_id AS CHAR) LIKE ?" &
                    ") "

            End If


            If cboCourse.Text <> "" AndAlso
               cboCourse.Text <> "All" Then

                query &=
                    "AND s.course = ? "

            End If


            query &=
                "ORDER BY " &
                "a.attendance_date DESC, " &
                "a.time_in DESC"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@from",
                    dtpFrom.Value.Date
                )

                cmd.Parameters.AddWithValue(
                    "@to",
                    dtpTo.Value.Date
                )


                If Not String.IsNullOrWhiteSpace(
                    txtSearch.Text
                ) Then

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


                If cboCourse.Text <> "" AndAlso
                   cboCourse.Text <> "All" Then

                    cmd.Parameters.AddWithValue(
                        "@course",
                        cboCourse.Text
                    )

                End If


                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    adapter.Fill(dt)

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Report Data Error: " &
                ex.Message,
                "Student Entry/Exit Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try


        Return dt

    End Function


    '====================================
    ' CHECK SAVE LOCATION
    '====================================
    Private Function CanWriteToFolder(
        filePath As String
    ) As Boolean

        Try

            Dim folderPath As String =
                Path.GetDirectoryName(
                    filePath
                )


            If String.IsNullOrWhiteSpace(
                folderPath
            ) Then

                Return False

            End If


            If Not Directory.Exists(
                folderPath
            ) Then

                Return False

            End If


            Dim testFile As String =
                Path.Combine(
                    folderPath,
                    "write_test_" &
                    Guid.NewGuid().ToString(
                        "N"
                    ) &
                    ".tmp"
                )


            Using stream As New FileStream(
                testFile,
                FileMode.CreateNew,
                FileAccess.Write,
                FileShare.None
            )

                stream.WriteByte(0)

            End Using


            File.Delete(testFile)

            Return True


        Catch

            Return False

        End Try

    End Function


    '====================================
    ' CHECK TARGET FILE
    '====================================
    Private Function CanCreateOrOverwriteFile(
        filePath As String
    ) As Boolean

        Try

            If Not File.Exists(
                filePath
            ) Then

                Return True

            End If


            Using stream As New FileStream(
                filePath,
                FileMode.Open,
                FileAccess.ReadWrite,
                FileShare.None
            )

            End Using


            Return True


        Catch

            Return False

        End Try

    End Function


    '====================================
    ' VALIDATE SAVE PATH
    '====================================
    Private Function ValidateReportSavePath(
        filePath As String,
        reportType As String
    ) As Boolean

        If String.IsNullOrWhiteSpace(
            filePath
        ) Then

            Return False

        End If


        If Not CanWriteToFolder(
            filePath
        ) Then

            MessageBox.Show(
                "The selected folder or drive cannot be written to." &
                vbCrLf &
                vbCrLf &
                "Please choose another folder or make sure the drive is connected and writable.",
                "Cannot Save " &
                reportType &
                " Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return False

        End If


        If Not CanCreateOrOverwriteFile(
            filePath
        ) Then

            MessageBox.Show(
                "The selected file is currently being used by another program or cannot be overwritten." &
                vbCrLf &
                vbCrLf &
                "Close the existing file and try again.",
                "Cannot Save " &
                reportType &
                " Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return False

        End If


        Return True

    End Function


    '====================================
    ' GENERATE EXCEL
    '====================================
    Private Sub btnGenerateExcel_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGenerateExcel.Click

        Try

            Dim dt As DataTable =
                GetReportData()


            If dt.Rows.Count = 0 Then

                MessageBox.Show(
                    "No entry/exit records found for the selected filters.",
                    "Generate Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Return

            End If


            Using save As New SaveFileDialog()

                save.Title =
                    "Save Excel Report"

                save.Filter =
                    "Excel Workbook (*.xlsx)|*.xlsx"

                save.FilterIndex = 1
                save.DefaultExt = "xlsx"
                save.AddExtension = True
                save.CheckFileExists = False
                save.CheckPathExists = True
                save.CreatePrompt = False
                save.OverwritePrompt = True
                save.RestoreDirectory = True
                save.ValidateNames = True

                save.FileName =
                    "Student_Entry_Exit_Report_" &
                    DateTime.Now.ToString(
                        "yyyy-MM-dd_HHmmss"
                    )


                If save.ShowDialog() <>
                   DialogResult.OK Then

                    Return

                End If


                If Not ValidateReportSavePath(
                    save.FileName,
                    "Excel"
                ) Then

                    Return

                End If


                Using workbook As New XLWorkbook()

                    Dim ws As IXLWorksheet =
                        workbook.Worksheets.Add(
                            "Entry Exit Report"
                        )


                    '========================================
                    ' SCHOOL NAME
                    '========================================
                    ws.Range(
                        "A1:F1"
                    ).Merge()

                    ws.Cell("A1").Value =
                        "COLEGIO DE STA. TERESA DE AVILA"

                    With ws.Cell("A1").Style

                        .Font.Bold = True
                        .Font.FontSize = 16

                        .Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        .Alignment.Vertical =
                            XLAlignmentVerticalValues.Center

                    End With


                    '========================================
                    ' REPORT TITLE
                    '========================================
                    ws.Range(
                        "A2:F2"
                    ).Merge()

                    ws.Cell("A2").Value =
                        "STUDENT ENTRY/EXIT REPORT"

                    With ws.Cell("A2").Style

                        .Font.Bold = True
                        .Font.FontSize = 13

                        .Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        .Alignment.Vertical =
                            XLAlignmentVerticalValues.Center

                    End With


                    '========================================
                    ' SYSTEM TITLE
                    '========================================
                    ws.Range(
                        "A3:F3"
                    ).Merge()

                    ws.Cell("A3").Value =
                        "QR Code-Based Student Entry and Exit Monitoring System with Real-Time Parent Notifications"

                    With ws.Cell("A3").Style

                        .Font.FontSize = 10

                        .Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        .Alignment.Vertical =
                            XLAlignmentVerticalValues.Center

                    End With


                    '========================================
                    ' FILTER VALUES
                    '========================================
                    Dim studentFilter As String =
                        "All Students"

                    Dim courseFilter As String =
                        "All"


                    If Not String.IsNullOrWhiteSpace(
                        txtSearch.Text
                    ) Then

                        studentFilter =
                            txtSearch.Text.Trim()

                    End If


                    If cboCourse.Text.Trim() <> "" AndAlso
                       cboCourse.Text <> "All" Then

                        courseFilter =
                            cboCourse.Text

                    End If


                    '========================================
                    ' REPORT INFORMATION
                    '========================================
                    ws.Range(
                        "A5:F5"
                    ).Merge()

                    ws.Cell("A5").Value =
                        "REPORT INFORMATION"

                    With ws.Cell("A5").Style

                        .Font.Bold = True

                        .Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Left

                        .Alignment.Vertical =
                            XLAlignmentVerticalValues.Center

                    End With


                    ' DATE RANGE
                    ws.Cell("A6").Value =
                        "Date Range"

                    ws.Range(
                        "B6:F6"
                    ).Merge()

                    ws.Cell("B6").Value =
                        dtpFrom.Value.ToString(
                            "MMMM dd, yyyy"
                        ) &
                        " - " &
                        dtpTo.Value.ToString(
                            "MMMM dd, yyyy"
                        )


                    ' COURSE
                    ws.Cell("A7").Value =
                        "Course"

                    ws.Range(
                        "B7:F7"
                    ).Merge()

                    ws.Cell("B7").Value =
                        courseFilter


                    ' STUDENT
                    ws.Cell("A8").Value =
                        "Student"

                    ws.Range(
                        "B8:F8"
                    ).Merge()

                    ws.Cell("B8").Value =
                        studentFilter


                    ' GENERATED
                    ws.Cell("A9").Value =
                        "Generated"

                    ws.Range(
                        "B9:F9"
                    ).Merge()

                    ws.Cell("B9").Value =
                        DateTime.Now.ToString(
                            "MMMM dd, yyyy - hh:mm tt"
                        )


                    ws.Range(
                        "A6:A9"
                    ).Style.Font.Bold =
                        True


                    ws.Range(
                        "A6:F9"
                    ).Style.Alignment.Vertical =
                        XLAlignmentVerticalValues.Center


                    ws.Range(
                        "A5:F9"
                    ).Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Left


                    '========================================
                    ' ENTRY / EXIT RECORD TITLE
                    '========================================
                    ws.Range(
                        "A11:F11"
                    ).Merge()

                    ws.Cell("A11").Value =
                        "ENTRY/EXIT RECORDS"

                    With ws.Cell("A11").Style

                        .Font.Bold = True

                        .Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        .Alignment.Vertical =
                            XLAlignmentVerticalValues.Center

                    End With


                    '========================================
                    ' TABLE HEADERS
                    '========================================
                    Dim headerRow As Integer =
                        12


                    For i As Integer =
                        0 To dt.Columns.Count - 1

                        ws.Cell(
                            headerRow,
                            i + 1
                        ).Value =
                            dt.Columns(
                                i
                            ).ColumnName

                    Next


                    Dim headerRange =
                        ws.Range(
                            headerRow,
                            1,
                            headerRow,
                            dt.Columns.Count
                        )


                    With headerRange.Style

                        .Font.Bold = True

                        .Font.FontColor =
                            XLColor.White

                        .Fill.BackgroundColor =
                            XLColor.FromHtml(
                                "#673C24"
                            )

                        .Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        .Alignment.Vertical =
                            XLAlignmentVerticalValues.Center

                        .Border.TopBorder =
                            XLBorderStyleValues.Thin

                        .Border.BottomBorder =
                            XLBorderStyleValues.Thin

                        .Border.LeftBorder =
                            XLBorderStyleValues.Thin

                        .Border.RightBorder =
                            XLBorderStyleValues.Thin

                    End With


                    '========================================
                    ' TABLE DATA
                    '========================================
                    Dim currentRow As Integer =
                        headerRow + 1


                    For Each row As DataRow In
                        dt.Rows

                        For col As Integer =
                            0 To dt.Columns.Count - 1

                            Dim value As String =
                                row(
                                    col
                                ).ToString()


                            If dt.Columns(
                                col
                            ).ColumnName =
                               "Time Out" AndAlso
                               value.Trim() = "" Then

                                value =
                                    "-"

                            End If


                            ws.Cell(
                                currentRow,
                                col + 1
                            ).Value =
                                value

                        Next


                        Dim rowRange =
                            ws.Range(
                                currentRow,
                                1,
                                currentRow,
                                dt.Columns.Count
                            )


                        With rowRange.Style.Border

                            .TopBorder =
                                XLBorderStyleValues.Thin

                            .BottomBorder =
                                XLBorderStyleValues.Thin

                            .LeftBorder =
                                XLBorderStyleValues.Thin

                            .RightBorder =
                                XLBorderStyleValues.Thin

                        End With


                        ws.Cell(
                            currentRow,
                            1
                        ).Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        ws.Cell(
                            currentRow,
                            3
                        ).Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        ws.Cell(
                            currentRow,
                            4
                        ).Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        ws.Cell(
                            currentRow,
                            5
                        ).Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center

                        ws.Cell(
                            currentRow,
                            6
                        ).Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center


                        currentRow += 1

                    Next


                    '========================================
                    ' COUNT SUMMARY
                    '========================================
                    Dim completeCount As Integer =
                        0

                    Dim noExitCount As Integer =
                        0


                    For Each row As DataRow In
                        dt.Rows

                        If row(
                            "Time Out"
                        ).ToString().
                        Trim() = "" Then

                            noExitCount += 1

                        Else

                            completeCount += 1

                        End If

                    Next


                    '========================================
                    ' SUMMARY
                    '========================================
                    Dim summaryRow As Integer =
                        currentRow + 2


                    ws.Range(
                        summaryRow,
                        1,
                        summaryRow,
                        3
                    ).Merge()


                    ws.Cell(
                        summaryRow,
                        1
                    ).Value =
                        "SUMMARY"


                    With ws.Cell(
                        summaryRow,
                        1
                    ).Style

                        .Font.Bold = True

                        .Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Left

                        .Alignment.Vertical =
                            XLAlignmentVerticalValues.Center

                    End With


                    ' TOTAL RECORDS
                    ws.Range(
                        summaryRow + 1,
                        1,
                        summaryRow + 1,
                        2
                    ).Merge()


                    ws.Cell(
                        summaryRow + 1,
                        1
                    ).Value =
                        "Total Records"


                    ws.Cell(
                        summaryRow + 1,
                        3
                    ).Value =
                        dt.Rows.Count


                    ' COMPLETE ENTRY / EXIT
                    ws.Range(
                        summaryRow + 2,
                        1,
                        summaryRow + 2,
                        2
                    ).Merge()


                    ws.Cell(
                        summaryRow + 2,
                        1
                    ).Value =
                        "Complete Entry/Exit"


                    ws.Cell(
                        summaryRow + 2,
                        3
                    ).Value =
                        completeCount


                    ' NO EXIT RECORD
                    ws.Range(
                        summaryRow + 3,
                        1,
                        summaryRow + 3,
                        2
                    ).Merge()


                    ws.Cell(
                        summaryRow + 3,
                        1
                    ).Value =
                        "No Exit Record"


                    ws.Cell(
                        summaryRow + 3,
                        3
                    ).Value =
                        noExitCount


                    ws.Range(
                        summaryRow + 1,
                        1,
                        summaryRow + 3,
                        2
                    ).Style.Font.Bold =
                        True


                    ws.Range(
                        summaryRow + 1,
                        3,
                        summaryRow + 3,
                        3
                    ).Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Center


                    ws.Range(
                        summaryRow + 1,
                        1,
                        summaryRow + 3,
                        3
                    ).Style.Alignment.Vertical =
                        XLAlignmentVerticalValues.Center


                    Dim summaryRange =
                        ws.Range(
                            summaryRow + 1,
                            1,
                            summaryRow + 3,
                            3
                        )


                    With summaryRange.Style.Border

                        .TopBorder =
                            XLBorderStyleValues.Thin

                        .BottomBorder =
                            XLBorderStyleValues.Thin

                        .LeftBorder =
                            XLBorderStyleValues.Thin

                        .RightBorder =
                            XLBorderStyleValues.Thin

                    End With


                    '========================================
                    ' SIGNATURE
                    '========================================
                    Dim signatureRow As Integer =
                        summaryRow + 6


                    ws.Range(
                        signatureRow,
                        1,
                        signatureRow,
                        3
                    ).Merge()

                    ws.Cell(
                        signatureRow,
                        1
                    ).Value =
                        "Prepared by:"


                    ws.Range(
                        signatureRow + 2,
                        1,
                        signatureRow + 2,
                        3
                    ).Merge()

                    ws.Cell(
                        signatureRow + 2,
                        1
                    ).Value =
                        "____________________________"


                    ws.Range(
                        signatureRow + 3,
                        1,
                        signatureRow + 3,
                        3
                    ).Merge()

                    ws.Cell(
                        signatureRow + 3,
                        1
                    ).Value =
                        "Administrator / Authorized Personnel"


                    ws.Range(
                        signatureRow + 5,
                        1,
                        signatureRow + 5,
                        3
                    ).Merge()

                    ws.Cell(
                        signatureRow + 5,
                        1
                    ).Value =
                        "Date Prepared: ____________________"


                    ws.Range(
                        signatureRow,
                        1,
                        signatureRow + 5,
                        3
                    ).Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Left


                    '========================================
                    ' COLUMN WIDTHS
                    '========================================
                    ws.Column(1).Width =
                        16

                    ws.Column(2).Width =
                        30

                    ws.Column(3).Width =
                        22

                    ws.Column(4).Width =
                        18

                    ws.Column(5).Width =
                        16

                    ws.Column(6).Width =
                        16


                    ' Automatically adjust row height
                    ws.Rows().AdjustToContents()


                    '========================================
                    ' SAVE EXCEL
                    '========================================
                    workbook.SaveAs(
                        save.FileName
                    )

                End Using


                MessageBox.Show(
                    "Excel report generated successfully." &
                    vbCrLf &
                    vbCrLf &
                    "Saved to:" &
                    vbCrLf &
                    save.FileName,
                    "Student Entry/Exit Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End Using


        Catch ex As UnauthorizedAccessException

            MessageBox.Show(
                "Windows denied access to the selected folder." &
                vbCrLf &
                vbCrLf &
                "Please choose another folder or drive.",
                "Excel Save Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Catch ex As IOException

            MessageBox.Show(
                "The Excel file could not be saved." &
                vbCrLf &
                vbCrLf &
                "The file may already be open, the drive may be unavailable, or the folder may not be writable." &
                vbCrLf &
                vbCrLf &
                ex.Message,
                "Excel Save Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Catch ex As Exception

            MessageBox.Show(
                "Excel Error: " &
                ex.Message,
                "Generate Excel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' GENERATE PDF
    '====================================
    Private Sub btnGeneratePDF_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGeneratePDF.Click

        Try

            Dim dt As DataTable =
                GetReportData()


            If dt.Rows.Count = 0 Then

                MessageBox.Show(
                    "No entry/exit records found for the selected filters.",
                    "Generate PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Return

            End If


            Using save As New SaveFileDialog()

                save.Title =
                    "Save PDF Report"

                save.Filter =
                    "PDF File (*.pdf)|*.pdf"

                save.FilterIndex = 1
                save.DefaultExt = "pdf"
                save.AddExtension = True
                save.CheckFileExists = False
                save.CheckPathExists = True
                save.CreatePrompt = False
                save.OverwritePrompt = True
                save.RestoreDirectory = True
                save.ValidateNames = True

                save.FileName =
                    "Student_Entry_Exit_Report_" &
                    DateTime.Now.ToString(
                        "yyyy-MM-dd_HHmmss"
                    )


                If save.ShowDialog() <>
                   DialogResult.OK Then

                    Return

                End If


                If Not ValidateReportSavePath(
                    save.FileName,
                    "PDF"
                ) Then

                    Return

                End If


                Dim document As New Document(
                    PageSize.A4.Rotate(),
                    35,
                    35,
                    30,
                    35
                )


                PdfWriter.GetInstance(
                    document,
                    New FileStream(
                        save.FileName,
                        FileMode.Create,
                        FileAccess.Write,
                        FileShare.None
                    )
                )


                document.Open()


                Dim schoolFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        16
                    )

                Dim titleFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        13
                    )

                Dim subtitleFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA,
                        9
                    )

                Dim sectionFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        10
                    )

                Dim normalFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA,
                        9
                    )

                Dim boldFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        9
                    )


                '====================================
                ' HEADER
                '====================================
                Dim schoolName As New Paragraph(
                    "COLEGIO DE STA. TERESA DE AVILA",
                    schoolFont
                )

                schoolName.Alignment =
                    Element.ALIGN_CENTER

                document.Add(
                    schoolName
                )


                Dim reportTitle As New Paragraph(
                    "STUDENT ENTRY/EXIT REPORT",
                    titleFont
                )

                reportTitle.Alignment =
                    Element.ALIGN_CENTER

                reportTitle.SpacingBefore =
                    4

                document.Add(
                    reportTitle
                )


                Dim systemTitle As New Paragraph(
                    "QR Code-Based Student Entry and Exit Monitoring System with Real-Time Parent Notifications",
                    subtitleFont
                )

                systemTitle.Alignment =
                    Element.ALIGN_CENTER

                systemTitle.SpacingAfter =
                    12

                document.Add(
                    systemTitle
                )


                '====================================
                ' SEPARATOR
                '====================================
                Dim separatorTable As New PdfPTable(
                    1
                )

                separatorTable.WidthPercentage =
                    100


                Dim separatorCell As New PdfPCell(
                    New Phrase("")
                )

                separatorCell.Border =
                    Rectangle.BOTTOM_BORDER

                separatorCell.BorderWidthBottom =
                    0.8F

                separatorCell.BorderColorBottom =
                    New BaseColor(
                        120,
                        100,
                        90
                    )

                separatorCell.FixedHeight =
                    5


                separatorTable.AddCell(
                    separatorCell
                )

                document.Add(
                    separatorTable
                )

                document.Add(
                    New Paragraph(" ")
                )


                '====================================
                ' REPORT INFORMATION
                '====================================
                Dim infoTitle As New Paragraph(
                    "REPORT INFORMATION",
                    sectionFont
                )

                infoTitle.SpacingAfter =
                    6

                document.Add(
                    infoTitle
                )


                Dim studentFilter As String =
                    "All Students"

                Dim courseFilter As String =
                    "All"


                If Not String.IsNullOrWhiteSpace(
                    txtSearch.Text
                ) Then

                    studentFilter =
                        txtSearch.Text.Trim()

                End If


                If cboCourse.Text.Trim() <> "" AndAlso
                   cboCourse.Text <> "All" Then

                    courseFilter =
                        cboCourse.Text

                End If


                Dim infoTable As New PdfPTable(
                    2
                )

                infoTable.WidthPercentage =
                    55

                infoTable.HorizontalAlignment =
                    Element.ALIGN_LEFT

                infoTable.SetWidths(
                    New Single() {
                        1.3F,
                        3.7F
                    }
                )


                AddInfoRow(
                    infoTable,
                    "Date Range",
                    dtpFrom.Value.ToString(
                        "MMMM dd, yyyy"
                    ) &
                    " - " &
                    dtpTo.Value.ToString(
                        "MMMM dd, yyyy"
                    ),
                    boldFont,
                    normalFont
                )


                AddInfoRow(
                    infoTable,
                    "Course",
                    courseFilter,
                    boldFont,
                    normalFont
                )


                AddInfoRow(
                    infoTable,
                    "Student",
                    studentFilter,
                    boldFont,
                    normalFont
                )


                AddInfoRow(
                    infoTable,
                    "Generated",
                    DateTime.Now.ToString(
                        "MMMM dd, yyyy - hh:mm tt"
                    ),
                    boldFont,
                    normalFont
                )


                document.Add(
                    infoTable
                )

                document.Add(
                    New Paragraph(" ")
                )


                '====================================
                ' RECORDS TITLE
                '====================================
                Dim recordsTitle As New Paragraph(
                    "ENTRY/EXIT RECORDS",
                    sectionFont
                )

                recordsTitle.SpacingAfter =
                    7

                document.Add(
                    recordsTitle
                )


                '====================================
                ' RECORD TABLE
                '====================================
                Dim table As New PdfPTable(
                    dt.Columns.Count
                )

                table.WidthPercentage =
                    100

                table.HeaderRows =
                    1

                table.SetWidths(
                    New Single() {
                        1.1F,
                        2.2F,
                        1.8F,
                        1.4F,
                        1.3F,
                        1.3F
                    }
                )


                Dim headerColor As New BaseColor(
                    103,
                    60,
                    36
                )


                For Each column As DataColumn In
                    dt.Columns

                    Dim headerCell As New PdfPCell(
                        New Phrase(
                            column.ColumnName,
                            FontFactory.GetFont(
                                FontFactory.HELVETICA_BOLD,
                                8,
                                BaseColor.WHITE
                            )
                        )
                    )

                    headerCell.BackgroundColor =
                        headerColor

                    headerCell.HorizontalAlignment =
                        Element.ALIGN_CENTER

                    headerCell.VerticalAlignment =
                        Element.ALIGN_MIDDLE

                    headerCell.Padding =
                        7

                    table.AddCell(
                        headerCell
                    )

                Next


                '====================================
                ' TABLE DATA
                '====================================
                For Each row As DataRow In
                    dt.Rows

                    For Each column As DataColumn In
                        dt.Columns

                        Dim value As String =
                            row(
                                column
                            ).ToString()


                        If column.ColumnName =
                           "Time Out" AndAlso
                           value.Trim() = "" Then

                            value =
                                "-"

                        End If


                        Dim dataCell As New PdfPCell(
                            New Phrase(
                                value,
                                normalFont
                            )
                        )

                        dataCell.Padding =
                            6

                        dataCell.VerticalAlignment =
                            Element.ALIGN_MIDDLE


                        If column.ColumnName =
                           "Student ID" OrElse
                           column.ColumnName =
                           "Year / Course" OrElse
                           column.ColumnName =
                           "Date" OrElse
                           column.ColumnName =
                           "Time In" OrElse
                           column.ColumnName =
                           "Time Out" Then

                            dataCell.HorizontalAlignment =
                                Element.ALIGN_CENTER

                        Else

                            dataCell.HorizontalAlignment =
                                Element.ALIGN_LEFT

                        End If


                        table.AddCell(
                            dataCell
                        )

                    Next

                Next


                document.Add(
                    table
                )

                document.Add(
                    New Paragraph(" ")
                )


                '====================================
                ' SUMMARY
                '====================================
                Dim completeCount As Integer =
                    0

                Dim noTimeOutCount As Integer =
                    0


                For Each row As DataRow In
                    dt.Rows

                    If row(
                        "Time Out"
                    ).ToString().
                    Trim() = "" Then

                        noTimeOutCount +=
                            1

                    Else

                        completeCount +=
                            1

                    End If

                Next


                Dim summaryTitle As New Paragraph(
                    "SUMMARY",
                    sectionFont
                )

                summaryTitle.SpacingAfter =
                    5

                document.Add(
                    summaryTitle
                )


                Dim summaryTable As New PdfPTable(
                    2
                )

                summaryTable.WidthPercentage =
                    35

                summaryTable.HorizontalAlignment =
                    Element.ALIGN_LEFT

                summaryTable.SetWidths(
                    New Single() {
                        2.5F,
                        1.0F
                    }
                )


                AddSummaryRow(
                    summaryTable,
                    "Total Records",
                    dt.Rows.Count.ToString(),
                    boldFont
                )


                AddSummaryRow(
                    summaryTable,
                    "Complete Entry/Exit",
                    completeCount.ToString(),
                    boldFont
                )


                AddSummaryRow(
                    summaryTable,
                    "No Exit Record",
                    noTimeOutCount.ToString(),
                    boldFont
                )


                document.Add(
                    summaryTable
                )

                document.Add(
                    New Paragraph(" ")
                )

                document.Add(
                    New Paragraph(" ")
                )


                '====================================
                ' SIGNATURE
                '====================================
                Dim prepared As New Paragraph(
                    "Prepared by:",
                    normalFont
                )

                prepared.SpacingAfter =
                    22

                document.Add(
                    prepared
                )


                document.Add(
                    New Paragraph(
                        "____________________________",
                        normalFont
                    )
                )


                document.Add(
                    New Paragraph(
                        "Administrator / Authorized Personnel",
                        normalFont
                    )
                )


                document.Add(
                    New Paragraph(
                        vbCrLf &
                        "Date Prepared: ____________________",
                        normalFont
                    )
                )


                document.Close()


                MessageBox.Show(
                    "PDF report generated successfully." &
                    vbCrLf &
                    vbCrLf &
                    "Saved to:" &
                    vbCrLf &
                    save.FileName,
                    "Student Entry/Exit Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End Using


        Catch ex As UnauthorizedAccessException

            MessageBox.Show(
                "Windows denied access to the selected folder." &
                vbCrLf &
                vbCrLf &
                "Please choose another folder or drive.",
                "PDF Save Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Catch ex As IOException

            MessageBox.Show(
                "The PDF file could not be saved." &
                vbCrLf &
                vbCrLf &
                "The file may already be open, the drive may be unavailable, or the folder may not be writable." &
                vbCrLf &
                vbCrLf &
                ex.Message,
                "PDF Save Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Catch ex As Exception

            MessageBox.Show(
                "PDF Error: " &
                ex.Message,
                "Generate PDF",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' PDF INFO ROW
    '====================================
    Private Sub AddInfoRow(
        table As PdfPTable,
        labelText As String,
        valueText As String,
        boldFont As iTextSharp.text.Font,
        normalFont As iTextSharp.text.Font
    )

        Dim labelCell As New PdfPCell(
            New Phrase(
                labelText,
                boldFont
            )
        )

        labelCell.Border =
            Rectangle.NO_BORDER

        labelCell.Padding =
            3


        Dim valueCell As New PdfPCell(
            New Phrase(
                valueText,
                normalFont
            )
        )

        valueCell.Border =
            Rectangle.NO_BORDER

        valueCell.Padding =
            3


        table.AddCell(
            labelCell
        )

        table.AddCell(
            valueCell
        )

    End Sub


    '====================================
    ' PDF SUMMARY ROW
    '====================================
    Private Sub AddSummaryRow(
        table As PdfPTable,
        labelText As String,
        valueText As String,
        font As iTextSharp.text.Font
    )

        Dim labelCell As New PdfPCell(
            New Phrase(
                labelText,
                font
            )
        )

        labelCell.Padding =
            5


        Dim valueCell As New PdfPCell(
            New Phrase(
                valueText,
                font
            )
        )

        valueCell.HorizontalAlignment =
            Element.ALIGN_CENTER

        valueCell.Padding =
            5


        table.AddCell(
            labelCell
        )

        table.AddCell(
            valueCell
        )

    End Sub

End Class