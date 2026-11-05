Imports System.Data
Imports System.Data.Odbc
Imports System.Drawing

Public Class UcDashboard

    '==================================================
    ' FORM LOAD
    '==================================================
    Private Sub UcDashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            EnsureDatabaseConnection()

            Me.AutoScroll = True

            timerClock.Interval = 1000
            timerClock.Start()

            UpdateDateTime()
            RefreshDashboard()

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load the dashboard." &
                vbCrLf &
                ex.Message,
                "Dashboard Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

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
    ' REFRESH DASHBOARD
    '==================================================
    Public Sub RefreshDashboard()

        LoadDashboardSummary()
        LoadRecentEntryExit()
        LoadRecentSMS()

    End Sub


    '==================================================
    ' DATE AND TIME
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
                "dddd, MMMM dd, yyyy   |   hh:mm:ss tt"
            )

    End Sub


    '==================================================
    ' GET COUNT FROM DATABASE
    '==================================================
    Private Function GetCount(
        query As String
    ) As Integer

        EnsureDatabaseConnection()

        Using cmd As New OdbcCommand(
            query,
            con
        )

            Dim result As Object =
                cmd.ExecuteScalar()

            If result Is Nothing OrElse
               IsDBNull(result) Then

                Return 0

            End If

            Return Convert.ToInt32(
                result
            )

        End Using

    End Function


    '==================================================
    ' DASHBOARD SUMMARY
    '==================================================
    Private Sub LoadDashboardSummary()

        Try

            EnsureDatabaseConnection()


            '==================================================
            ' TOTAL REGISTERED STUDENTS
            '==================================================
            lblTotalStudents.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students"
                ).ToString()


            '==================================================
            ' STUDENTS WITH GENERATED QR
            '==================================================
            lblQRGenerated.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students " &
                    "WHERE qr_code_data IS NOT NULL " &
                    "AND TRIM(qr_code_data) <> ''"
                ).ToString()


            '==================================================
            ' ENTRY RECORDS TODAY
            '==================================================
            lblTodayEntry.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE()"
                ).ToString()


            '==================================================
            ' COMPLETED EXIT RECORDS TODAY
            '==================================================
            lblTodayExit.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE() " &
                    "AND time_out IS NOT NULL"
                ).ToString()


            '==================================================
            ' STUDENTS WITHOUT GENERATED QR
            '==================================================
            lblQRNotGenerated.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students " &
                    "WHERE qr_code_data IS NULL " &
                    "OR TRIM(qr_code_data) = ''"
                ).ToString()


            '==================================================
            ' OPEN ENTRY RECORDS / NO EXIT TODAY
            '==================================================
            lblNoExitToday.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE() " &
                    "AND time_out IS NULL"
                ).ToString()


            '==================================================
            ' FAILED SMS TODAY
            '==================================================
            lblFailedSMS.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM sms_logs " &
                    "WHERE UPPER(status) = 'FAILED' " &
                    "AND DATE(sent_at) = CURDATE()"
                ).ToString()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load dashboard summary." &
                vbCrLf &
                ex.Message,
                "Dashboard Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' RECENT ENTRY / EXIT RECORDS
    '==================================================
    Private Sub LoadRecentEntryExit()

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "s.students_id AS student_id, " &
                "s.students_name AS student_name, " &
                "CONCAT(s.year_level, ' - ', s.course) AS year_course, " &
                "a.time_in, " &
                "a.time_out " &
                "FROM attendance_records a " &
                "INNER JOIN students s " &
                "ON a.students_id = s.students_id " &
                "WHERE a.attendance_date = CURDATE() " &
                "ORDER BY a.time_in DESC " &
                "LIMIT 10"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    Dim table As New DataTable()

                    adapter.Fill(
                        table
                    )

                    dgvRecentEntryExit.DataSource =
                        table

                End Using

            End Using


            FormatEntryExitGrid()

            dgvRecentEntryExit.ClearSelection()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load recent entry/exit records." &
                vbCrLf &
                ex.Message,
                "Dashboard Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' FORMAT ENTRY / EXIT GRID
    '==================================================
    Private Sub FormatEntryExitGrid()

        If dgvRecentEntryExit Is Nothing OrElse
           dgvRecentEntryExit.Columns.Count = 0 Then

            Return

        End If


        '==================================================
        ' GENERAL TABLE STYLE
        '==================================================
        dgvRecentEntryExit.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvRecentEntryExit.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter


        ' CENTER ALL ROW TEXT
        dgvRecentEntryExit.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvRecentEntryExit.RowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvRecentEntryExit.AlternatingRowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter


        ' SAME ROW COLOR
        dgvRecentEntryExit.RowsDefaultCellStyle.BackColor =
            Color.White

        dgvRecentEntryExit.RowsDefaultCellStyle.ForeColor =
            Color.Black

        dgvRecentEntryExit.AlternatingRowsDefaultCellStyle.BackColor =
            Color.White

        dgvRecentEntryExit.AlternatingRowsDefaultCellStyle.ForeColor =
            Color.Black


        ' SELECTION COLOR
        dgvRecentEntryExit.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(
                230,
                220,
                210
            )

        dgvRecentEntryExit.DefaultCellStyle.SelectionForeColor =
            Color.Black


        dgvRecentEntryExit.RowHeadersVisible =
            False

        dgvRecentEntryExit.AllowUserToResizeRows =
            False

        dgvRecentEntryExit.RowTemplate.Height =
            30


        For Each row As DataGridViewRow In
            dgvRecentEntryExit.Rows

            row.Height =
                30

        Next


        '==================================================
        ' COLUMNS
        '==================================================
        For Each column As DataGridViewColumn In
            dgvRecentEntryExit.Columns


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
                        120


                Case "year_course",
                     "colyearcourse"

                    column.HeaderText =
                        "Year / Course"

                    column.FillWeight =
                        100


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


            ' CENTER EVERY COLUMN
            column.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter

        Next

    End Sub


    '==================================================
    ' RECENT SMS NOTIFICATIONS
    '==================================================
    Private Sub LoadRecentSMS()

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "IFNULL(s.students_name, 'Unknown Student') AS student_name, " &
                "l.sms_type, " &
                "l.sent_at, " &
                "l.status " &
                "FROM sms_logs l " &
                "LEFT JOIN students s " &
                "ON l.students_id = s.students_id " &
                "ORDER BY l.sent_at DESC " &
                "LIMIT 10"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    Dim table As New DataTable()

                    adapter.Fill(
                        table
                    )

                    dgvRecentSMS.DataSource =
                        table

                End Using

            End Using


            FormatSMSGrid()

            dgvRecentSMS.ClearSelection()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load recent SMS notifications." &
                vbCrLf &
                ex.Message,
                "Dashboard Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' FORMAT SMS GRID
    '==================================================
    Private Sub FormatSMSGrid()

        If dgvRecentSMS Is Nothing OrElse
           dgvRecentSMS.Columns.Count = 0 Then

            Return

        End If


        '==================================================
        ' GENERAL TABLE STYLE
        '==================================================
        dgvRecentSMS.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvRecentSMS.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter


        ' CENTER ALL ROW TEXT
        dgvRecentSMS.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvRecentSMS.RowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvRecentSMS.AlternatingRowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter


        ' SAME ROW COLOR
        dgvRecentSMS.RowsDefaultCellStyle.BackColor =
            Color.White

        dgvRecentSMS.RowsDefaultCellStyle.ForeColor =
            Color.Black

        dgvRecentSMS.AlternatingRowsDefaultCellStyle.BackColor =
            Color.White

        dgvRecentSMS.AlternatingRowsDefaultCellStyle.ForeColor =
            Color.Black


        ' SELECTION COLOR
        dgvRecentSMS.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(
                230,
                220,
                210
            )

        dgvRecentSMS.DefaultCellStyle.SelectionForeColor =
            Color.Black


        dgvRecentSMS.RowHeadersVisible =
            False

        dgvRecentSMS.AllowUserToResizeRows =
            False

        dgvRecentSMS.RowTemplate.Height =
            30


        For Each row As DataGridViewRow In
            dgvRecentSMS.Rows

            row.Height =
                30

        Next


        '==================================================
        ' COLUMNS
        '==================================================
        For Each column As DataGridViewColumn In
            dgvRecentSMS.Columns


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

                Case "student_name",
                     "colstudentname"

                    column.HeaderText =
                        "Student"

                    column.FillWeight =
                        110


                Case "sms_type",
                     "colsmstype"

                    column.HeaderText =
                        "Type"

                    column.FillWeight =
                        60


                Case "sent_at",
                     "colsentat"

                    column.HeaderText =
                        "Date / Time"

                    column.FillWeight =
                        95

                    column.DefaultCellStyle.Format =
                        "MMM dd, yyyy hh:mm tt"


                Case "status",
                     "colstatus"

                    column.HeaderText =
                        "Status"

                    column.FillWeight =
                        60

            End Select


            ' CENTER EVERY COLUMN
            column.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter

        Next

    End Sub


    '==================================================
    ' ENTRY / EXIT CELL FORMATTING
    '==================================================
    Private Sub dgvRecentEntryExit_CellFormatting(
        sender As Object,
        e As DataGridViewCellFormattingEventArgs
    ) Handles dgvRecentEntryExit.CellFormatting


        If e.RowIndex < 0 OrElse
           e.ColumnIndex < 0 Then

            Return

        End If


        If dgvRecentEntryExit Is Nothing Then

            Return

        End If


        If e.ColumnIndex >=
           dgvRecentEntryExit.Columns.Count Then

            Return

        End If


        Dim column As DataGridViewColumn =
            dgvRecentEntryExit.Columns(
                e.ColumnIndex
            )


        If column Is Nothing Then

            Return

        End If


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


        '==================================================
        ' ONLY FORMAT TIME OUT
        '==================================================
        If columnKey <> "time_out" AndAlso
           columnKey <> "coltimeout" Then

            Return

        End If


        Dim hasTimeOut As Boolean =
            e.Value IsNot Nothing AndAlso
            Not IsDBNull(e.Value) AndAlso
            Not String.IsNullOrWhiteSpace(
                e.Value.ToString()
            )


        If hasTimeOut Then

            ApplySuccessStyle(
                e.CellStyle
            )

        Else

            e.Value =
                "-"

            ApplyWarningStyle(
                e.CellStyle
            )

            e.FormattingApplied =
                True

        End If

    End Sub


    '==================================================
    ' SMS STATUS CELL FORMATTING
    '==================================================
    Private Sub dgvRecentSMS_CellFormatting(
        sender As Object,
        e As DataGridViewCellFormattingEventArgs
    ) Handles dgvRecentSMS.CellFormatting


        If e.RowIndex < 0 OrElse
           e.ColumnIndex < 0 Then

            Return

        End If


        If dgvRecentSMS Is Nothing Then

            Return

        End If


        If e.ColumnIndex >=
           dgvRecentSMS.Columns.Count Then

            Return

        End If


        Dim column As DataGridViewColumn =
            dgvRecentSMS.Columns(
                e.ColumnIndex
            )


        If column Is Nothing Then

            Return

        End If


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


        '==================================================
        ' ONLY FORMAT STATUS
        '==================================================
        If columnKey <> "status" AndAlso
           columnKey <> "colstatus" Then

            Return

        End If


        If e.Value Is Nothing OrElse
           IsDBNull(e.Value) Then

            Return

        End If


        Dim status As String =
            e.Value.ToString().
            Trim().
            ToUpperInvariant()


        Select Case status

            Case "SENT"

                ApplySuccessStyle(
                    e.CellStyle
                )


            Case "FAILED"

                ApplyWarningStyle(
                    e.CellStyle
                )

        End Select

    End Sub


    '==================================================
    ' GREEN / SUCCESS CELL STYLE
    '==================================================
    Private Sub ApplySuccessStyle(
        style As DataGridViewCellStyle
    )

        If style Is Nothing Then

            Return

        End If


        style.BackColor =
            Color.FromArgb(
                220,
                242,
                224
            )


        style.ForeColor =
            Color.FromArgb(
                32,
                110,
                55
            )


        style.SelectionBackColor =
            Color.FromArgb(
                190,
                225,
                197
            )


        style.SelectionForeColor =
            Color.FromArgb(
                32,
                110,
                55
            )


        style.Alignment =
            DataGridViewContentAlignment.MiddleCenter

    End Sub


    '==================================================
    ' RED / WARNING CELL STYLE
    '==================================================
    Private Sub ApplyWarningStyle(
        style As DataGridViewCellStyle
    )

        If style Is Nothing Then

            Return

        End If


        style.BackColor =
            Color.FromArgb(
                250,
                218,
                218
            )


        style.ForeColor =
            Color.FromArgb(
                170,
                45,
                45
            )


        style.SelectionBackColor =
            Color.FromArgb(
                238,
                190,
                190
            )


        style.SelectionForeColor =
            Color.FromArgb(
                170,
                45,
                45
            )


        style.Alignment =
            DataGridViewContentAlignment.MiddleCenter

    End Sub


End Class