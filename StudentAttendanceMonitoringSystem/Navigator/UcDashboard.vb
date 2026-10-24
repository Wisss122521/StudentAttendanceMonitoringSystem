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
    Private Function GetCount(query As String) As Integer

        EnsureDatabaseConnection()

        Using cmd As New OdbcCommand(query, con)

            Dim result As Object =
                cmd.ExecuteScalar()

            If result Is Nothing OrElse
               IsDBNull(result) Then

                Return 0

            End If

            Return Convert.ToInt32(result)

        End Using

    End Function


    '==================================================
    ' DASHBOARD SUMMARY
    '==================================================
    Private Sub LoadDashboardSummary()

        Try

            ' Total registered students
            lblTotalStudents.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students"
                ).ToString()


            ' Students with generated QR code
            lblQRGenerated.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students " &
                    "WHERE qr_code_data IS NOT NULL " &
                    "AND TRIM(qr_code_data) <> ''"
                ).ToString()


            ' Entry records today
            lblTodayEntry.Text =
                GetCount(
                    "SELECT COUNT(DISTINCT students_id) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE()"
                ).ToString()


            ' Completed exits today
            lblTodayExit.Text =
                GetCount(
                    "SELECT COUNT(DISTINCT students_id) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE() " &
                    "AND time_out IS NOT NULL"
                ).ToString()


            ' Students without QR code
            lblQRNotGenerated.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students " &
                    "WHERE qr_code_data IS NULL " &
                    "OR TRIM(qr_code_data) = ''"
                ).ToString()


            ' Entry records without exit today
            lblNoExitToday.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE() " &
                    "AND time_out IS NULL"
                ).ToString()


            ' Failed SMS logs
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


            Using cmd As New OdbcCommand(query, con)

                Using adapter As New OdbcDataAdapter(cmd)

                    Dim table As New DataTable()

                    adapter.Fill(table)

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

        For Each column As DataGridViewColumn In
            dgvRecentEntryExit.Columns

            Select Case column.DataPropertyName

                Case "student_id"

                    column.HeaderText =
                        "Student ID"

                    column.FillWeight =
                        60


                Case "student_name"

                    column.HeaderText =
                        "Student Name"

                    column.FillWeight =
                        120


                Case "year_course"

                    column.HeaderText =
                        "Year / Course"

                    column.FillWeight =
                        100


                Case "time_in"

                    column.HeaderText =
                        "Time In"

                    column.FillWeight =
                        75


                Case "time_out"

                    column.HeaderText =
                        "Time Out"

                    column.FillWeight =
                        75

            End Select

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


            Using cmd As New OdbcCommand(query, con)

                Using adapter As New OdbcDataAdapter(cmd)

                    Dim table As New DataTable()

                    adapter.Fill(table)

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

        For Each column As DataGridViewColumn In
            dgvRecentSMS.Columns

            Select Case column.DataPropertyName

                Case "student_name"

                    column.HeaderText =
                        "Student"

                    column.FillWeight =
                        110


                Case "sms_type"

                    column.HeaderText =
                        "Type"

                    column.FillWeight =
                        60


                Case "sent_at"

                    column.HeaderText =
                        "Date / Time"

                    column.FillWeight =
                        95


                Case "status"

                    column.HeaderText =
                        "Status"

                    column.FillWeight =
                        60

            End Select

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


        Dim column As DataGridViewColumn =
            dgvRecentEntryExit.Columns(e.ColumnIndex)


        ' Only format the Time Out column
        If column.DataPropertyName <> "time_out" Then
            Return
        End If


        Dim hasTimeOut As Boolean =
            e.Value IsNot Nothing AndAlso
            Not IsDBNull(e.Value) AndAlso
            e.Value.ToString().Trim() <> ""


        If hasTimeOut Then

            ApplySuccessStyle(
                e.CellStyle
            )

        Else

            e.Value = "-"

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


        Dim column As DataGridViewColumn =
            dgvRecentSMS.Columns(e.ColumnIndex)


        ' Only format the Status column
        If column.DataPropertyName <> "status" Then
            Return
        End If


        If e.Value Is Nothing OrElse
           IsDBNull(e.Value) Then

            Return

        End If


        Dim status As String =
            e.Value.ToString().
            Trim().
            ToUpper()


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
    ' GREEN CELL STYLE
    '==================================================
    Private Sub ApplySuccessStyle(
        style As DataGridViewCellStyle
    )

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

    End Sub


    '==================================================
    ' RED / WARNING CELL STYLE
    '==================================================
    Private Sub ApplyWarningStyle(
        style As DataGridViewCellStyle
    )

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

    End Sub

End Class