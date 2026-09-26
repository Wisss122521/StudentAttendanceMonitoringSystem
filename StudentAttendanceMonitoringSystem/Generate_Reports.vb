Imports System.Data.Odbc
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports ClosedXML.Excel

Public Class Generate_Reports
    Private Sub AttendanceReports_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        If con Is Nothing OrElse con.State <> ConnectionState.Open Then
            vbConnection()
        End If

        ' Default date range:
        ' First day of current month hanggang today
        dtpFrom.Value =
            New DateTime(Date.Today.Year, Date.Today.Month, 1)

        dtpTo.Value = Date.Today

        LoadCourses()
        LoadAttendanceReports()

    End Sub


    '====================================
    ' LOAD COURSE COMBOBOX
    '====================================
    Private Sub LoadCourses()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If

            cboCourse.Items.Clear()
            cboCourse.Items.Add("All")

            Dim query As String =
                "SELECT DISTINCT course " &
                "FROM students " &
                "WHERE course IS NOT NULL " &
                "AND TRIM(course) <> '' " &
                "ORDER BY course ASC"

            Using cmd As New OdbcCommand(query, con)

                Using reader As OdbcDataReader = cmd.ExecuteReader()

                    While reader.Read()

                        cboCourse.Items.Add(
                            reader("course").ToString()
                        )

                    End While

                End Using

            End Using

            cboCourse.SelectedIndex = 0

        Catch ex As Exception

            MessageBox.Show(
                "Load Course Error: " & ex.Message,
                "Attendance Reports",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' LOAD ATTENDANCE
    '====================================
    Private Sub LoadAttendanceReports()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            If dtpFrom.Value.Date > dtpTo.Value.Date Then

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
                "s.students_id AS student_id, " &
                "s.students_name AS student_name, " &
                "CONCAT(s.year_level, ' - ', s.course) AS year_course, " &
                "a.attendance_date, " &
                "a.time_in, " &
                "a.time_out " &
                "FROM attendance_records a " &
                "INNER JOIN students s " &
                "ON a.students_id = s.students_id " &
                "WHERE a.attendance_date BETWEEN ? AND ? "


            ' Search
            If txtSearch.Text.Trim() <> "" Then

                query &=
                    "AND (" &
                    "s.students_name LIKE ? " &
                    "OR CAST(s.students_id AS CHAR) LIKE ?" &
                    ") "

            End If


            ' Course
            If cboCourse.Text <> "" AndAlso
               cboCourse.Text <> "All" Then

                query &= "AND s.course = ? "

            End If


            query &=
                "ORDER BY " &
                "a.attendance_date DESC, " &
                "a.time_in DESC"


            Using cmd As New OdbcCommand(query, con)

                ' ODBC parameters are positional
                cmd.Parameters.AddWithValue(
                    "@dateFrom",
                    dtpFrom.Value.Date
                )

                cmd.Parameters.AddWithValue(
                    "@dateTo",
                    dtpTo.Value.Date
                )


                If txtSearch.Text.Trim() <> "" Then

                    Dim searchValue As String =
                        "%" & txtSearch.Text.Trim() & "%"

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


                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvAttendance.DataSource = dt

            End Using


            UpdateReportSummary()

        Catch ex As Exception

            MessageBox.Show(
                "Load Attendance Error: " & ex.Message,
                "Attendance Reports",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '====================================
    ' SUMMARY
    '====================================
    Private Sub UpdateReportSummary()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


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
                "INNER JOIN students s " &
                "ON a.students_id = s.students_id " &
                "WHERE a.attendance_date BETWEEN ? AND ? "


            If txtSearch.Text.Trim() <> "" Then

                query &=
                    "AND (" &
                    "s.students_name LIKE ? " &
                    "OR CAST(s.students_id AS CHAR) LIKE ?" &
                    ") "

            End If


            If cboCourse.Text <> "" AndAlso
               cboCourse.Text <> "All" Then

                query &= "AND s.course = ? "

            End If


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@dateFrom",
                    dtpFrom.Value.Date
                )

                cmd.Parameters.AddWithValue(
                    "@dateTo",
                    dtpTo.Value.Date
                )


                If txtSearch.Text.Trim() <> "" Then

                    Dim searchValue As String =
                        "%" & txtSearch.Text.Trim() & "%"

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
                            reader("total_count").ToString()

                        lblComplete.Text =
                            reader("complete_count").ToString()

                        lblNoTimeOut.Text =
                            reader("no_timeout_count").ToString()

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Summary Error: " & ex.Message,
                "Attendance Reports",
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
            cboCourse.SelectedIndex = 0
        End If

        dtpFrom.Value =
            New DateTime(
                Date.Today.Year,
                Date.Today.Month,
                1
            )

        dtpTo.Value = Date.Today

        LoadAttendanceReports()

    End Sub

    Private Function GetReportData() As DataTable

        Dim dt As New DataTable()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If

            Dim query As String =
                "SELECT " &
                "s.students_id AS 'Student ID', " &
                "s.students_name AS 'Student Name', " &
                "CONCAT(s.year_level, ' - ', s.course) AS 'Year / Course', " &
                "DATE_FORMAT(a.attendance_date, '%Y-%m-%d') AS 'Date', " &
                "TIME_FORMAT(a.time_in, '%h:%i:%s %p') AS 'Time In', " &
                "CASE " &
                "WHEN a.time_out IS NULL THEN '' " &
                "ELSE TIME_FORMAT(a.time_out, '%h:%i:%s %p') " &
                "END AS 'Time Out' " &
                "FROM attendance_records a " &
                "INNER JOIN students s " &
                "ON a.students_id = s.students_id " &
                "WHERE a.attendance_date BETWEEN ? AND ? "

            If txtSearch.Text.Trim() <> "" Then
                query &=
                    "AND (s.students_name LIKE ? " &
                    "OR CAST(s.students_id AS CHAR) LIKE ?) "
            End If

            If cboCourse.Text <> "" AndAlso
               cboCourse.Text <> "All" Then

                query &= "AND s.course = ? "

            End If

            query &=
                "ORDER BY a.attendance_date DESC, a.time_in DESC"

            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@from",
                    dtpFrom.Value.Date
                )

                cmd.Parameters.AddWithValue(
                    "@to",
                    dtpTo.Value.Date
                )

                If txtSearch.Text.Trim() <> "" Then

                    Dim searchValue As String =
                        "%" & txtSearch.Text.Trim() & "%"

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

                Using adapter As New OdbcDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Report Data Error: " & ex.Message,
                "Attendance Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

        Return dt

    End Function

    Private Sub btnGenerateExcel_Click(
    sender As Object,
    e As EventArgs
) Handles btnGenerateExcel.Click

        Try

            Dim dt As DataTable = GetReportData()

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

                save.Filter = "Excel Workbook|*.xlsx"

                save.FileName =
                "Student_Entry_Exit_Report_" &
                DateTime.Now.ToString("yyyy-MM-dd_HHmmss") &
                ".xlsx"

                If save.ShowDialog() <> DialogResult.OK Then
                    Return
                End If


                Using workbook As New XLWorkbook()

                    Dim ws As IXLWorksheet =
                    workbook.Worksheets.Add("Entry Exit Report")


                    '========================================
                    ' SCHOOL NAME
                    '========================================
                    ws.Range("A1:F1").Merge()

                    ws.Cell("A1").Value =
                    "COLEGIO DE STA. TERESA DE AVILLA"

                    With ws.Cell("A1").Style
                        .Font.Bold = True
                        .Font.FontSize = 16
                        .Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    End With


                    '========================================
                    ' REPORT TITLE
                    '========================================
                    ws.Range("A2:F2").Merge()

                    ws.Cell("A2").Value =
                    "STUDENT ENTRY/EXIT REPORT"

                    With ws.Cell("A2").Style
                        .Font.Bold = True
                        .Font.FontSize = 13
                        .Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    End With


                    '========================================
                    ' SYSTEM TITLE
                    '========================================
                    ws.Range("A3:F3").Merge()

                    ws.Cell("A3").Value =
                    "QR Code-Based Student Time-In/Time-Out Monitoring System"

                    With ws.Cell("A3").Style
                        .Font.FontSize = 10
                        .Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    End With


                    '========================================
                    ' FILTER VALUES
                    '========================================
                    Dim studentFilter As String = "All Students"
                    Dim courseFilter As String = "All"

                    If txtSearch.Text.Trim() <> "" Then
                        studentFilter = txtSearch.Text.Trim()
                    End If

                    If cboCourse.Text.Trim() <> "" AndAlso
                   cboCourse.Text <> "All" Then

                        courseFilter = cboCourse.Text

                    End If


                    '========================================
                    ' REPORT INFORMATION
                    '========================================
                    ws.Cell("A5").Value = "REPORT INFORMATION"
                    ws.Cell("A5").Style.Font.Bold = True


                    ws.Cell("A6").Value = "Date Range"
                    ws.Cell("B6").Value =
                    dtpFrom.Value.ToString("MMMM dd, yyyy") &
                    " - " &
                    dtpTo.Value.ToString("MMMM dd, yyyy")


                    ws.Cell("A7").Value = "Course"
                    ws.Cell("B7").Value = courseFilter


                    ws.Cell("A8").Value = "Student"
                    ws.Cell("B8").Value = studentFilter


                    ws.Cell("A9").Value = "Generated"
                    ws.Cell("B9").Value =
                    DateTime.Now.ToString(
                        "MMMM dd, yyyy - hh:mm tt"
                    )


                    ' Bold labels
                    ws.Range("A6:A9").Style.Font.Bold = True


                    '========================================
                    ' ENTRY / EXIT RECORDS TITLE
                    '========================================
                    ws.Range("A11:F11").Merge()

                    ws.Cell("A11").Value =
                    "ENTRY/EXIT RECORDS"

                    ws.Cell("A11").Style.Font.Bold = True


                    '========================================
                    ' TABLE HEADERS
                    '========================================
                    Dim headerRow As Integer = 12

                    For i As Integer = 0 To dt.Columns.Count - 1

                        ws.Cell(headerRow, i + 1).Value =
                        dt.Columns(i).ColumnName

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
                        .Font.FontColor = XLColor.White

                        .Fill.BackgroundColor =
                        XLColor.FromHtml("#673C24")

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

                    For Each row As DataRow In dt.Rows

                        For col As Integer =
                        0 To dt.Columns.Count - 1

                            Dim value As String =
                            row(col).ToString()

                            ' Empty Time Out
                            If dt.Columns(col).ColumnName = "Time Out" AndAlso
                           value.Trim() = "" Then

                                value = "-"

                            End If

                            ws.Cell(
                            currentRow,
                            col + 1
                        ).Value = value

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


                        currentRow += 1

                    Next


                    '========================================
                    ' COUNT SUMMARY
                    '========================================
                    Dim completeCount As Integer = 0
                    Dim noExitCount As Integer = 0


                    For Each row As DataRow In dt.Rows

                        If row("Time Out").ToString().Trim() = "" Then

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

                    ws.Cell(summaryRow, 1).Value =
                    "SUMMARY"

                    ws.Cell(summaryRow, 1).Style.Font.Bold =
                    True


                    ws.Cell(summaryRow + 1, 1).Value =
                    "Total Records"

                    ws.Cell(summaryRow + 1, 2).Value =
                    dt.Rows.Count


                    ws.Cell(summaryRow + 2, 1).Value =
                    "Complete Entry/Exit"

                    ws.Cell(summaryRow + 2, 2).Value =
                    completeCount


                    ws.Cell(summaryRow + 3, 1).Value =
                    "No Exit Record"

                    ws.Cell(summaryRow + 3, 2).Value =
                    noExitCount


                    ws.Range(
                    summaryRow + 1,
                    1,
                    summaryRow + 3,
                    1
                ).Style.Font.Bold = True


                    Dim summaryRange =
                    ws.Range(
                        summaryRow + 1,
                        1,
                        summaryRow + 3,
                        2
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

                    ws.Cell(signatureRow, 1).Value =
                    "Prepared by:"

                    ws.Cell(signatureRow + 2, 1).Value =
                    "____________________________"

                    ws.Cell(signatureRow + 3, 1).Value =
                    "Administrator / Authorized Personnel"

                    ws.Cell(signatureRow + 5, 1).Value =
                    "Date Prepared: ____________________"


                    '========================================
                    ' COLUMN WIDTHS
                    '========================================
                    ws.Columns().AdjustToContents()

                    ws.Column(1).Width = 15
                    ws.Column(2).Width = 28
                    ws.Column(3).Width = 22
                    ws.Column(4).Width = 18
                    ws.Column(5).Width = 16
                    ws.Column(6).Width = 16


                    '========================================
                    ' ALIGNMENTS
                    '========================================
                    ws.Column(1).Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center

                    ws.Column(4).Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center

                    ws.Column(5).Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center

                    ws.Column(6).Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center


                    '========================================
                    ' SAVE EXCEL
                    '========================================
                    workbook.SaveAs(save.FileName)

                End Using


                MessageBox.Show(
                "Excel report generated successfully.",
                "Student Entry/Exit Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            End Using


        Catch ex As Exception

            MessageBox.Show(
            "Excel Error: " & ex.Message,
            "Generate Excel",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub btnGeneratePDF_Click(
    sender As Object,
    e As EventArgs
) Handles btnGeneratePDF.Click

        Try

            Dim dt As DataTable = GetReportData()

            If dt.Rows.Count = 0 Then

                MessageBox.Show(
                "No attendance records found for the selected filters.",
                "Generate PDF",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

                Return

            End If


            Using save As New SaveFileDialog()

                save.Filter = "PDF File|*.pdf"

                save.FileName =
                "Attendance_Report_" &
                DateTime.Now.ToString("yyyy-MM-dd_HHmmss") &
                ".pdf"

                If save.ShowDialog() <> DialogResult.OK Then
                    Return
                End If


                '========================================
                ' DOCUMENT
                '========================================
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
                    FileMode.Create
                )
            )

                document.Open()


                '========================================
                ' FONTS
                '========================================
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


                '========================================
                ' SCHOOL HEADER
                '========================================
                Dim schoolName As New Paragraph(
                "COLEGIO DE STA. TERESA DE AVILLA",
                schoolFont
            )

                schoolName.Alignment = Element.ALIGN_CENTER

                document.Add(schoolName)


                Dim reportTitle As New Paragraph(
                "STUDENT ENTRY/EXIT REPORT",
                titleFont
            )

                reportTitle.Alignment = Element.ALIGN_CENTER
                reportTitle.SpacingBefore = 4

                document.Add(reportTitle)


                Dim systemTitle As New Paragraph(
                "QR Code-Based Student Time-In/Time-Out Monitoring System",
                subtitleFont
            )

                systemTitle.Alignment = Element.ALIGN_CENTER
                systemTitle.SpacingAfter = 12

                document.Add(systemTitle)


                '========================================
                ' LINE
                '========================================
                Dim line As New iTextSharp.text.pdf.draw.LineSeparator()

                line.LineWidth = 0.8F
                line.LineColor = New BaseColor(120, 100, 90)

                document.Add(line)

                document.Add(New Paragraph(" "))


                '========================================
                ' REPORT INFORMATION
                '========================================
                Dim infoTitle As New Paragraph(
                "REPORT INFORMATION",
                sectionFont
            )

                infoTitle.SpacingAfter = 6

                document.Add(infoTitle)


                Dim studentFilter As String = "All Students"

                If txtSearch.Text.Trim() <> "" Then
                    studentFilter = txtSearch.Text.Trim()
                End If


                Dim courseFilter As String = "All"

                If cboCourse.Text.Trim() <> "" AndAlso
               cboCourse.Text <> "All" Then

                    courseFilter = cboCourse.Text

                End If


                Dim infoTable As New PdfPTable(2)

                infoTable.WidthPercentage = 55
                infoTable.HorizontalAlignment = Element.ALIGN_LEFT

                infoTable.SetWidths(
                New Single() {1.3F, 3.7F}
            )


                ' DATE RANGE
                Dim cellLabel As PdfPCell
                Dim cellValue As PdfPCell


                cellLabel =
                New PdfPCell(
                    New Phrase(
                        "Date Range",
                        boldFont
                    )
                )

                cellLabel.Border = Rectangle.NO_BORDER
                cellLabel.Padding = 3

                infoTable.AddCell(cellLabel)


                cellValue =
                New PdfPCell(
                    New Phrase(
                        dtpFrom.Value.ToString("MMMM dd, yyyy") &
                        " - " &
                        dtpTo.Value.ToString("MMMM dd, yyyy"),
                        normalFont
                    )
                )

                cellValue.Border = Rectangle.NO_BORDER
                cellValue.Padding = 3

                infoTable.AddCell(cellValue)


                ' COURSE
                cellLabel =
                New PdfPCell(
                    New Phrase(
                        "Course",
                        boldFont
                    )
                )

                cellLabel.Border = Rectangle.NO_BORDER
                cellLabel.Padding = 3

                infoTable.AddCell(cellLabel)


                cellValue =
                New PdfPCell(
                    New Phrase(
                        courseFilter,
                        normalFont
                    )
                )

                cellValue.Border = Rectangle.NO_BORDER
                cellValue.Padding = 3

                infoTable.AddCell(cellValue)


                ' STUDENT
                cellLabel =
                New PdfPCell(
                    New Phrase(
                        "Student",
                        boldFont
                    )
                )

                cellLabel.Border = Rectangle.NO_BORDER
                cellLabel.Padding = 3

                infoTable.AddCell(cellLabel)


                cellValue =
                New PdfPCell(
                    New Phrase(
                        studentFilter,
                        normalFont
                    )
                )

                cellValue.Border = Rectangle.NO_BORDER
                cellValue.Padding = 3

                infoTable.AddCell(cellValue)


                ' GENERATED
                cellLabel =
                New PdfPCell(
                    New Phrase(
                        "Generated",
                        boldFont
                    )
                )

                cellLabel.Border = Rectangle.NO_BORDER
                cellLabel.Padding = 3

                infoTable.AddCell(cellLabel)


                cellValue =
                New PdfPCell(
                    New Phrase(
                        DateTime.Now.ToString(
                            "MMMM dd, yyyy - hh:mm tt"
                        ),
                        normalFont
                    )
                )

                cellValue.Border = Rectangle.NO_BORDER
                cellValue.Padding = 3

                infoTable.AddCell(cellValue)


                document.Add(infoTable)

                document.Add(New Paragraph(" "))


                '========================================
                ' ATTENDANCE RECORDS TITLE
                '========================================
                Dim recordsTitle As New Paragraph(
                "ENTRY/EXIT RECORDS",
                sectionFont
            )

                recordsTitle.SpacingAfter = 7

                document.Add(recordsTitle)


                '========================================
                ' ATTENDANCE TABLE
                '========================================
                Dim table As New PdfPTable(dt.Columns.Count)

                table.WidthPercentage = 100
                table.HeaderRows = 1

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


                ' HEADER COLOR
                Dim headerColor As New BaseColor(
                103,
                60,
                36
            )


                ' COLUMN HEADERS
                For Each column As DataColumn In dt.Columns

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

                    headerCell.BackgroundColor = headerColor

                    headerCell.HorizontalAlignment =
                    Element.ALIGN_CENTER

                    headerCell.VerticalAlignment =
                    Element.ALIGN_MIDDLE

                    headerCell.Padding = 7

                    table.AddCell(headerCell)

                Next


                '========================================
                ' TABLE DATA
                '========================================
                For Each row As DataRow In dt.Rows

                    For Each column As DataColumn In dt.Columns

                        Dim value As String =
                        row(column).ToString()

                        If column.ColumnName = "Time Out" AndAlso
                       value.Trim() = "" Then

                            value = "-"

                        End If


                        Dim dataCell As New PdfPCell(
                        New Phrase(
                            value,
                            normalFont
                        )
                    )

                        dataCell.Padding = 6

                        dataCell.VerticalAlignment =
                        Element.ALIGN_MIDDLE


                        If column.ColumnName = "Date" OrElse
                       column.ColumnName = "Time In" OrElse
                       column.ColumnName = "Time Out" Then

                            dataCell.HorizontalAlignment =
                            Element.ALIGN_CENTER

                        Else

                            dataCell.HorizontalAlignment =
                            Element.ALIGN_LEFT

                        End If


                        table.AddCell(dataCell)

                    Next

                Next


                document.Add(table)

                document.Add(New Paragraph(" "))


                '========================================
                ' SUMMARY
                '========================================
                Dim completeCount As Integer = 0
                Dim noTimeOutCount As Integer = 0


                For Each row As DataRow In dt.Rows

                    If row("Time Out").ToString().Trim() = "" Then

                        noTimeOutCount += 1

                    Else

                        completeCount += 1

                    End If

                Next


                Dim summaryTitle As New Paragraph(
                "SUMMARY",
                sectionFont
            )

                summaryTitle.SpacingAfter = 5

                document.Add(summaryTitle)


                Dim summaryTable As New PdfPTable(2)

                summaryTable.WidthPercentage = 35
                summaryTable.HorizontalAlignment = Element.ALIGN_LEFT

                summaryTable.SetWidths(
                New Single() {2.5F, 1.0F}
            )


                ' TOTAL RECORDS
                Dim summaryLabel As New PdfPCell(
                New Phrase(
                    "Total Records",
                    boldFont
                )
            )

                summaryLabel.Padding = 5

                summaryTable.AddCell(summaryLabel)


                Dim summaryValue As New PdfPCell(
                New Phrase(
                    dt.Rows.Count.ToString(),
                    boldFont
                )
            )

                summaryValue.HorizontalAlignment =
                Element.ALIGN_CENTER

                summaryValue.Padding = 5

                summaryTable.AddCell(summaryValue)


                ' COMPLETE
                summaryLabel =
                New PdfPCell(
                    New Phrase(
                        "Complete Entry/Exit",
                        boldFont
                    )
                )

                summaryLabel.Padding = 5

                summaryTable.AddCell(summaryLabel)


                summaryValue =
                New PdfPCell(
                    New Phrase(
                        completeCount.ToString(),
                        boldFont
                    )
                )

                summaryValue.HorizontalAlignment =
                Element.ALIGN_CENTER

                summaryValue.Padding = 5

                summaryTable.AddCell(summaryValue)


                ' NO TIME OUT
                summaryLabel =
                New PdfPCell(
                    New Phrase(
                        "No Exit Record",
                        boldFont
                    )
                )

                summaryLabel.Padding = 5

                summaryTable.AddCell(summaryLabel)


                summaryValue =
                New PdfPCell(
                    New Phrase(
                        noTimeOutCount.ToString(),
                        boldFont
                    )
                )

                summaryValue.HorizontalAlignment =
                Element.ALIGN_CENTER

                summaryValue.Padding = 5

                summaryTable.AddCell(summaryValue)


                document.Add(summaryTable)

                document.Add(New Paragraph(" "))
                document.Add(New Paragraph(" "))


                '========================================
                ' SIGNATURE
                '========================================
                Dim prepared As New Paragraph(
                "Prepared by:",
                normalFont
            )

                prepared.SpacingAfter = 22

                document.Add(prepared)


                Dim signature As New Paragraph(
                "____________________________",
                normalFont
            )

                document.Add(signature)


                Dim signatureTitle As New Paragraph(
                "Administrator / Authorized Personnel",
                normalFont
            )

                document.Add(signatureTitle)


                Dim datePrepared As New Paragraph(
                vbCrLf &
                "Date Prepared: ____________________",
                normalFont
            )

                document.Add(datePrepared)


                '========================================
                ' CLOSE
                '========================================
                document.Close()


                MessageBox.Show(
                "PDF report generated successfully.",
                "Attendance Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            End Using


        Catch ex As Exception

            MessageBox.Show(
            "PDF Error: " & ex.Message,
            "Generate PDF",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

End Class
