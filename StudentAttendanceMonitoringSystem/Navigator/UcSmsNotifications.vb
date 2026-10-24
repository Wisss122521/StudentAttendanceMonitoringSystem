Imports System.Data.Odbc
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports System.Drawing

Public Class UcSmsNotifications

    '==================================================
    ' SELECTED STUDENT
    '==================================================
    Private selectedStudentId As Integer = 0
    Private selectedStudentName As String = ""
    Private selectedContactNumber As String = ""


    '==================================================
    ' USERCONTROL LOAD
    '==================================================
    Private Sub SmsNotification_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            txtMessage.MaxLength = 160

            timerClock.Interval = 1000
            timerClock.Start()


            LoadStudents()
            LoadSmsLogs()

            ClearSelectedStudent()

            UpdateCharacterCount()
            UpdateDateTime()
            UpdateSendButtonAppearance()


        Catch ex As Exception

            MessageBox.Show(
                "Notifications Error: " & ex.Message,
                "SMS Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

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
    ' LOAD STUDENTS
    '==================================================
    Private Sub LoadStudents()

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            Dim query As String =
                "SELECT " &
                "students_id AS student_id, " &
                "students_name AS student_name, " &
                "CONCAT(year_level, ' - ', course) AS year_course " &
                "FROM students " &
                "WHERE 1=1 "


            If txtSearchStudent.Text.Trim() <> "" Then

                query &=
                    "AND (" &
                    "students_name LIKE ? " &
                    "OR CAST(students_id AS CHAR) LIKE ?" &
                    ") "

            End If


            query &=
                "ORDER BY students_name ASC"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                If txtSearchStudent.Text.Trim() <> "" Then

                    Dim searchValue As String =
                        "%" &
                        txtSearchStudent.Text.Trim() &
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


                Dim adapter As New OdbcDataAdapter(
                    cmd
                )

                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvStudents.DataSource =
                    dt

            End Using


            dgvStudents.ClearSelection()


        Catch ex As Exception

            MessageBox.Show(
                "Load Students Error: " &
                ex.Message,
                "SMS Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' SEARCH STUDENT
    '==================================================
    Private Sub txtSearchStudent_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearchStudent.TextChanged

        LoadStudents()

    End Sub


    '==================================================
    ' STUDENT CELL CLICK
    '==================================================
    Private Sub dgvStudents_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvStudents.CellClick

        If e.RowIndex < 0 Then
            Return
        End If


        Try

            Dim rowView As DataRowView =
                TryCast(
                    dgvStudents.Rows(
                        e.RowIndex
                    ).DataBoundItem,
                    DataRowView
                )


            If rowView Is Nothing Then
                Return
            End If


            Dim studentId As Integer =
                Convert.ToInt32(
                    rowView("student_id")
                )


            LoadSelectedStudent(
                studentId
            )


        Catch ex As Exception

            MessageBox.Show(
                "Student Selection Error: " &
                ex.Message,
                "SMS Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' LOAD SELECTED STUDENT
    '==================================================
    Private Sub LoadSelectedStudent(
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
                "parent_contact_number " &
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
                                reader(
                                    "students_id"
                                )
                            )


                        selectedStudentName =
                            reader(
                                "students_name"
                            ).ToString()


                        If IsDBNull(
                            reader(
                                "parent_contact_number"
                            )
                        ) Then

                            selectedContactNumber = ""

                        Else

                            selectedContactNumber =
                                reader(
                                    "parent_contact_number"
                                ).ToString().Trim()

                        End If


                        lblSelectedStudent.Text =
                            selectedStudentName


                        lblYearCourse.Text =
                            reader(
                                "year_level"
                            ).ToString() &
                            " - " &
                            reader(
                                "course"
                            ).ToString()


                        If selectedContactNumber = "" Then

                            lblContactNumber.Text =
                                "No contact number"

                        Else

                            lblContactNumber.Text =
                                selectedContactNumber

                        End If


                        btnSendSMS.Enabled =
                            selectedContactNumber <> ""

                    End If

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Student Details Error: " &
                ex.Message,
                "SMS Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' MESSAGE CHARACTER COUNT
    '==================================================
    Private Sub txtMessage_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtMessage.TextChanged

        UpdateCharacterCount()

    End Sub


    Private Sub UpdateCharacterCount()

        lblCharacterCount.Text =
            "Characters: " &
            txtMessage.TextLength.ToString() &
            " / 160"

    End Sub


    '==================================================
    ' CLEAR MESSAGE
    '==================================================
    Private Sub btnClearMessage_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClearMessage.Click

        txtMessage.Clear()

        txtMessage.Focus()

    End Sub


    '==================================================
    ' SEND SMS
    '==================================================
    Private Async Sub btnSendSMS_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSendSMS.Click


        '----------------------------------------------
        ' NO STUDENT SELECTED
        '----------------------------------------------
        If selectedStudentId = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Send SMS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        '----------------------------------------------
        ' NO CONTACT NUMBER
        '----------------------------------------------
        If selectedContactNumber.Trim() = "" Then

            MessageBox.Show(
                "The selected student has no parent contact number.",
                "Send SMS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        '----------------------------------------------
        ' EMPTY MESSAGE
        '----------------------------------------------
        If txtMessage.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter a message.",
                "Send SMS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtMessage.Focus()

            Return

        End If


        Dim messageToSend As String =
            txtMessage.Text.Trim()


        '----------------------------------------------
        ' CONFIRMATION
        '----------------------------------------------
        Dim result As DialogResult =
            MessageBox.Show(
                "Send this message to the parent/guardian of " &
                selectedStudentName &
                "?" &
                vbCrLf &
                vbCrLf &
                "Contact Number:" &
                vbCrLf &
                selectedContactNumber &
                vbCrLf &
                vbCrLf &
                "Message:" &
                vbCrLf &
                messageToSend,
                "Confirm SMS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If result <> DialogResult.Yes Then
            Return
        End If


        Try

            btnSendSMS.Enabled =
                False

            btnSendSMS.Text =
                "Sending..."


            Dim sent As Boolean =
                Await SendManualSMS(
                    selectedContactNumber,
                    messageToSend
                )


            If sent Then

                SaveSmsLog(
                    selectedStudentId,
                    selectedContactNumber,
                    messageToSend,
                    "MANUAL",
                    "SENT"
                )


                MessageBox.Show(
                    "SMS sent successfully.",
                    "SMS Sent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


                txtMessage.Clear()

            Else

                SaveSmsLog(
                    selectedStudentId,
                    selectedContactNumber,
                    messageToSend,
                    "MANUAL",
                    "FAILED"
                )

            End If


            ' Refresh logs + summary automatically
            LoadSmsLogs()


        Catch ex As Exception

            MessageBox.Show(
                "Send SMS Error: " &
                ex.Message,
                "SMS Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Finally

            btnSendSMS.Text =
                "Send SMS"

            btnSendSMS.Enabled =
                selectedContactNumber <> ""

        End Try

    End Sub


    '==================================================
    ' SEND MANUAL SMS
    '==================================================
    Private Async Function SendManualSMS(
        parentNumber As String,
        message As String
    ) As Task(Of Boolean)


        ' Put your working iProgTech API token here.
        ' Do not post the token publicly.
        Dim apiToken As String =
            "de73dee5c2e1e19b2984f9eba3b0084e9adb82a1"


        Dim apiUrl As String =
            "https://sms.iprogtech.com/api/v1/sms_messages?api_token=" &
            apiToken


        Try

            Dim safeNumber As String =
                EscapeJson(
                    parentNumber
                )

            Dim safeMessage As String =
                EscapeJson(
                    message
                )


            Dim jsonBody As String =
                "{""phone_number"":""" &
                safeNumber &
                """,""message"":""" &
                safeMessage &
                """}"


            Using client As New HttpClient()

                Dim content As New StringContent(
                    jsonBody,
                    Encoding.UTF8,
                    "application/json"
                )


                Dim response As HttpResponseMessage =
                    Await client.PostAsync(
                        apiUrl,
                        content
                    )


                Dim responseBody As String =
                    Await response.Content.
                    ReadAsStringAsync()


                If response.IsSuccessStatusCode Then

                    Return True

                Else

                    MessageBox.Show(
                        "SMS failed to send." &
                        vbCrLf &
                        vbCrLf &
                        responseBody,
                        "SMS Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )

                    Return False

                End If

            End Using


        Catch ex As HttpRequestException

            MessageBox.Show(
                "No internet connection or the SMS server cannot be reached.",
                "Network Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return False


        Catch ex As TaskCanceledException

            MessageBox.Show(
                "The SMS request timed out.",
                "SMS Timeout",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return False


        Catch ex As Exception

            MessageBox.Show(
                "An error occurred while sending the SMS." &
                vbCrLf &
                ex.Message,
                "SMS Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return False

        End Try

    End Function


    '==================================================
    ' ESCAPE JSON
    '==================================================
    Private Function EscapeJson(
        value As String
    ) As String

        If value Is Nothing Then
            Return ""
        End If


        Return value.
            Replace("\", "\\").
            Replace("""", "\""").
            Replace(vbCrLf, "\n").
            Replace(vbCr, "\n").
            Replace(vbLf, "\n").
            Replace(vbTab, "\t")

    End Function


    '==================================================
    ' CLEAR SELECTED STUDENT
    '==================================================
    Private Sub ClearSelectedStudent()

        selectedStudentId = 0
        selectedStudentName = ""
        selectedContactNumber = ""


        lblSelectedStudent.Text =
            "No student selected"


        lblYearCourse.Text =
            "-"


        lblContactNumber.Text =
            "-"


        btnSendSMS.Enabled =
            False

    End Sub


    '==================================================
    ' SAVE SMS LOG
    '==================================================
    Private Sub SaveSmsLog(
        studentId As Integer,
        contactNumber As String,
        message As String,
        smsType As String,
        status As String
    )

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            Dim query As String =
                "INSERT INTO sms_logs " &
                "(students_id, contact_number, message, sms_type, status) " &
                "VALUES (?, ?, ?, ?, ?)"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@studentId",
                    studentId
                )

                cmd.Parameters.AddWithValue(
                    "@contact",
                    contactNumber
                )

                cmd.Parameters.AddWithValue(
                    "@message",
                    message
                )

                cmd.Parameters.AddWithValue(
                    "@type",
                    smsType
                )

                cmd.Parameters.AddWithValue(
                    "@status",
                    status
                )


                cmd.ExecuteNonQuery()

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "SMS Log Error: " &
                ex.Message,
                "SMS Logs",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' LOAD SMS LOGS
    '==================================================
    Private Sub LoadSmsLogs()

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            Dim query As String =
                "SELECT " &
                "IFNULL(s.students_name, 'Unknown Student') AS student_name, " &
                "l.contact_number, " &
                "l.sms_type, " &
                "l.message, " &
                "l.sent_at, " &
                "l.status " &
                "FROM sms_logs l " &
                "LEFT JOIN students s " &
                "ON l.students_id = s.students_id " &
                "ORDER BY l.sent_at DESC"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Dim adapter As New OdbcDataAdapter(
                    cmd
                )

                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvSMSLogs.DataSource =
                    dt

            End Using


            dgvSMSLogs.ClearSelection()


            ' Refresh summary every time logs load
            LoadSmsSummary()


        Catch ex As Exception

            MessageBox.Show(
                "Load SMS Logs Error: " &
                ex.Message,
                "SMS Logs",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' SMS SUMMARY
    '==================================================
    Private Sub LoadSmsSummary()

        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            Dim query As String =
                "SELECT " &
                "COUNT(*) AS total_logs, " &
                "SUM(CASE WHEN UPPER(status) = 'SENT' THEN 1 ELSE 0 END) AS sent_count, " &
                "SUM(CASE WHEN UPPER(status) = 'FAILED' THEN 1 ELSE 0 END) AS failed_count " &
                "FROM sms_logs"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        lblTotalLogs.Text =
                            If(
                                IsDBNull(
                                    reader(
                                        "total_logs"
                                    )
                                ),
                                "0",
                                reader(
                                    "total_logs"
                                ).ToString()
                            )


                        lblSentCount.Text =
                            If(
                                IsDBNull(
                                    reader(
                                        "sent_count"
                                    )
                                ),
                                "0",
                                reader(
                                    "sent_count"
                                ).ToString()
                            )


                        lblFailedCount.Text =
                            If(
                                IsDBNull(
                                    reader(
                                        "failed_count"
                                    )
                                ),
                                "0",
                                reader(
                                    "failed_count"
                                ).ToString()
                            )

                    End If

                End Using

            End Using


        Catch ex As Exception

            lblTotalLogs.Text = "0"
            lblSentCount.Text = "0"
            lblFailedCount.Text = "0"

        End Try

    End Sub


    '==================================================
    ' REFRESH LOGS
    '==================================================
    Private Sub btnRefreshLogs_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefreshLogs.Click

        LoadSmsLogs()

    End Sub


    '==================================================
    ' SMS LOG STATUS COLOR
    '==================================================
    Private Sub dgvSMSLogs_CellFormatting(
        sender As Object,
        e As DataGridViewCellFormattingEventArgs
    ) Handles dgvSMSLogs.CellFormatting


        If e.RowIndex < 0 Then
            Return
        End If


        If e.ColumnIndex <>
           dgvSMSLogs.Columns(
               "colLogStatus"
           ).Index Then

            Return

        End If


        If e.Value Is Nothing Then
            Return
        End If


        Dim status As String =
            e.Value.ToString().
            Trim().
            ToUpper()


        Select Case status

            Case "SENT"

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


            Case "FAILED"

                e.CellStyle.BackColor =
                    Color.FromArgb(
                        250,
                        218,
                        218
                    )

                e.CellStyle.ForeColor =
                    Color.FromArgb(
                        170,
                        35,
                        35
                    )

                e.CellStyle.SelectionBackColor =
                    Color.FromArgb(
                        238,
                        190,
                        190
                    )

        End Select

    End Sub


    '==================================================
    ' SEND BUTTON APPEARANCE
    '==================================================
    Private Sub btnSendSMS_EnabledChanged(
        sender As Object,
        e As EventArgs
    ) Handles btnSendSMS.EnabledChanged

        UpdateSendButtonAppearance()

    End Sub


    Private Sub UpdateSendButtonAppearance()

        If btnSendSMS.Enabled Then

            btnSendSMS.BackColor =
                Color.FromArgb(
                    103,
                    60,
                    36
                )

            btnSendSMS.ForeColor =
                Color.White

            btnSendSMS.Cursor =
                Cursors.Hand

        Else

            btnSendSMS.BackColor =
                Color.FromArgb(
                    215,
                    210,
                    205
                )

            btnSendSMS.ForeColor =
                Color.Gray

            btnSendSMS.Cursor =
                Cursors.Default

        End If

    End Sub

End Class