Imports System.Data
Imports System.Data.Odbc
Imports System.Drawing

Public Class UcDashboard

    '==================================================
    ' DASHBOARD LOAD
    '==================================================
    Private Sub Dashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            timerClock.Interval = 1000
            timerClock.Start()

            UpdateDateTime()

            RefreshDashboard()

            Me.AutoScroll = True


        Catch ex As Exception

            MessageBox.Show(
                "Dashboard Error: " & ex.Message,
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

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
    ' DATE / TIME
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
    ' SIMPLE COUNT FUNCTION
    '==================================================
    Private Function GetCount(
        query As String
    ) As Integer

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


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


                Return Convert.ToInt32(result)

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Count Query Error:" &
                vbCrLf &
                vbCrLf &
                ex.Message &
                vbCrLf &
                vbCrLf &
                "Query:" &
                vbCrLf &
                query,
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return 0

        End Try

    End Function


    '==================================================
    ' DASHBOARD SUMMARY
    '==================================================
    Private Sub LoadDashboardSummary()

        Try

            '==============================================
            ' TOTAL STUDENTS
            '==============================================
            lblTotalStudents.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students"
                ).ToString()


            '==============================================
            ' QR GENERATED
            '==============================================
            lblQRGenerated.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students " &
                    "WHERE qr_code_data IS NOT NULL " &
                    "AND TRIM(qr_code_data) <> ''"
                ).ToString()


            '==============================================
            ' TODAY'S ENTRY
            '==============================================
            lblTodayEntry.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE()"
                ).ToString()


            '==============================================
            ' TODAY'S EXIT
            '==============================================
            lblTodayExit.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE() " &
                    "AND time_out IS NOT NULL"
                ).ToString()


            '==============================================
            ' QR NOT GENERATED
            '==============================================
            lblQRNotGenerated.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM students " &
                    "WHERE (" &
                    "qr_code_data IS NULL " &
                    "OR TRIM(qr_code_data) = ''" &
                    ")"
                ).ToString()


            '==============================================
            ' NO EXIT TODAY
            '==============================================
            lblNoExitToday.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM attendance_records " &
                    "WHERE attendance_date = CURDATE() " &
                    "AND time_out IS NULL"
                ).ToString()


            '==============================================
            ' FAILED SMS
            '==============================================
            lblFailedSMS.Text =
                GetCount(
                    "SELECT COUNT(*) " &
                    "FROM sms_logs " &
                    "WHERE status = 'FAILED'"
                ).ToString()


        Catch ex As Exception

            MessageBox.Show(
                "Dashboard Summary Error: " &
                ex.Message,
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' RECENT ENTRY / EXIT
    ' TODAY ONLY
    '==================================================
    Private Sub LoadRecentEntryExit()

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


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

                Dim adapter As New OdbcDataAdapter(
                    cmd
                )

                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvRecentEntryExit.DataSource =
                    dt

            End Using


            dgvRecentEntryExit.ClearSelection()


        Catch ex As Exception

            MessageBox.Show(
                "Recent Entry/Exit Error: " &
                ex.Message,
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' RECENT SMS
    '==================================================
    Private Sub LoadRecentSMS()

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


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

                Dim adapter As New OdbcDataAdapter(
                    cmd
                )

                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvRecentSMS.DataSource =
                    dt

            End Using


            dgvRecentSMS.ClearSelection()


        Catch ex As Exception

            MessageBox.Show(
                "Recent SMS Error: " &
                ex.Message,
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' ENTRY / EXIT CELL COLOR
    '==================================================
    Private Sub dgvRecentEntryExit_CellFormatting(
        sender As Object,
        e As DataGridViewCellFormattingEventArgs
    ) Handles dgvRecentEntryExit.CellFormatting

        If e.RowIndex < 0 Then
            Return
        End If


        If e.ColumnIndex <>
           dgvRecentEntryExit.Columns(
               "colEntryTimeOut"
           ).Index Then

            Return

        End If


        Dim hasTimeOut As Boolean = False


        If e.Value IsNot Nothing AndAlso
           Not IsDBNull(e.Value) AndAlso
           e.Value.ToString().Trim() <> "" Then

            hasTimeOut = True

        End If


        If hasTimeOut Then

            ' COMPLETE ENTRY / EXIT
            e.CellStyle.BackColor =
                Color.FromArgb(
                    220,
                    242,
                    224
                )

            e.CellStyle.ForeColor =
                Color.FromArgb(
                    32,
                    110,
                    55
                )

            e.CellStyle.SelectionBackColor =
                Color.FromArgb(
                    190,
                    225,
                    197
                )

        Else

            ' NO EXIT YET
            e.Value = "-"

            e.CellStyle.BackColor =
                Color.FromArgb(
                    250,
                    218,
                    218
                )

            e.CellStyle.ForeColor =
                Color.FromArgb(
                    170,
                    45,
                    45
                )

            e.CellStyle.SelectionBackColor =
                Color.FromArgb(
                    238,
                    190,
                    190
                )

            e.FormattingApplied = True

        End If

    End Sub


    '==================================================
    ' SMS STATUS COLOR
    '==================================================
    Private Sub dgvRecentSMS_CellFormatting(
    sender As Object,
    e As DataGridViewCellFormattingEventArgs
) Handles dgvRecentSMS.CellFormatting

        If e.RowIndex < 0 Then Return

        If e.ColumnIndex < 0 OrElse
       e.ColumnIndex >= dgvRecentSMS.Columns.Count Then

            Return

        End If


        Dim currentColumn As DataGridViewColumn =
        dgvRecentSMS.Columns(e.ColumnIndex)


        ' Status column lang
        If currentColumn.DataPropertyName <> "status" Then
            Return
        End If


        If e.Value Is Nothing OrElse IsDBNull(e.Value) Then
            Return
        End If


        Dim status As String =
        e.Value.ToString().Trim().ToUpper()


        Select Case status

            Case "SENT"

                e.CellStyle.BackColor =
                Color.FromArgb(220, 242, 224)

                e.CellStyle.ForeColor =
                Color.FromArgb(32, 110, 55)

                e.CellStyle.SelectionBackColor =
                Color.FromArgb(190, 225, 197)


            Case "FAILED"

                e.CellStyle.BackColor =
                Color.FromArgb(250, 218, 218)

                e.CellStyle.ForeColor =
                Color.FromArgb(170, 45, 45)

                e.CellStyle.SelectionBackColor =
                Color.FromArgb(238, 190, 190)

        End Select

    End Sub

End Class