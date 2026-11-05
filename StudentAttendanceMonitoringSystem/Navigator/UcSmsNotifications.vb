Imports System.Data
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

            EnsureDatabaseConnection()

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
                "Notifications Error: " &
                ex.Message,
                "SMS Notifications",
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

            EnsureDatabaseConnection()


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


                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    Dim dt As New DataTable()

                    adapter.Fill(dt)

                    dgvStudents.DataSource =
                        dt

                End Using

            End Using


            FormatStudentsGrid()

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
    ' FORMAT STUDENTS TABLE
    '==================================================
    Private Sub FormatStudentsGrid()

        If dgvStudents Is Nothing OrElse
           dgvStudents.Columns.Count = 0 Then

            Return

        End If


        dgvStudents.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvStudents.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvStudents.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvStudents.RowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvStudents.AlternatingRowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter


        dgvStudents.RowsDefaultCellStyle.BackColor =
            Color.White

        dgvStudents.RowsDefaultCellStyle.ForeColor =
            Color.Black

        dgvStudents.AlternatingRowsDefaultCellStyle.BackColor =
            Color.White

        dgvStudents.AlternatingRowsDefaultCellStyle.ForeColor =
            Color.Black


        dgvStudents.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(
                230,
                220,
                210
            )

        dgvStudents.DefaultCellStyle.SelectionForeColor =
            Color.Black


        dgvStudents.RowHeadersVisible =
            False

        dgvStudents.AllowUserToResizeRows =
            False

        dgvStudents.RowTemplate.Height =
            30


        For Each row As DataGridViewRow In dgvStudents.Rows

            row.Height = 30

        Next


        For Each column As DataGridViewColumn In dgvStudents.Columns

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

            End Select


            column.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter

        Next

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
                    rowView(
                        "student_id"
                    )
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

            EnsureDatabaseConnection()


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

                            selectedContactNumber =
                                ""

                        Else

                            selectedContactNumber =
                                reader(
                                    "parent_contact_number"
                                ).ToString().
                                Trim()

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

                    Else

                        ClearSelectedStudent()

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

        '==================================================
        ' STUDENT CHECK
        '==================================================
        If selectedStudentId = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Send SMS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        '==================================================
        ' NO CONTACT NUMBER
        '==================================================
        If String.IsNullOrWhiteSpace(
            selectedContactNumber
        ) Then

            MessageBox.Show(
                "The selected student has no parent contact number.",
                "Send SMS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        '==================================================
        ' VALIDATE / NORMALIZE NUMBER
        '==================================================
        Dim normalizedNumber As String = ""

        If Not TryNormalizePhilippineMobileNumber(
            selectedContactNumber,
            normalizedNumber
        ) Then

            MessageBox.Show(
                "The parent's contact number is invalid." &
                vbCrLf &
                vbCrLf &
                "Please update the student's contact number first." &
                vbCrLf &
                vbCrLf &
                "Example: 09171234567",
                "Invalid Contact Number",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        '==================================================
        ' MESSAGE CHECK
        '==================================================
        If String.IsNullOrWhiteSpace(
            txtMessage.Text
        ) Then

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


        '==================================================
        ' CONFIRM SEND
        '==================================================
        Dim result As DialogResult =
            MessageBox.Show(
                "Send this message to the parent/guardian of " &
                selectedStudentName &
                "?" &
                vbCrLf &
                vbCrLf &
                "Contact Number:" &
                vbCrLf &
                normalizedNumber &
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
                    normalizedNumber,
                    messageToSend
                )


            If sent Then

                SaveSmsLog(
                    selectedStudentId,
                    normalizedNumber,
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
                    normalizedNumber,
                    messageToSend,
                    "MANUAL",
                    "FAILED"
                )

            End If


            LoadSmsLogs()


        Catch ex As Exception

            '==================================================
            ' UNEXPECTED FAILURE
            '==================================================
            SaveSmsLog(
                selectedStudentId,
                normalizedNumber,
                messageToSend,
                "MANUAL",
                "FAILED"
            )


            LoadSmsLogs()


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
                Not String.IsNullOrWhiteSpace(
                    selectedContactNumber
                )

        End Try

    End Sub


    '==================================================
    ' NORMALIZE / VALIDATE PHILIPPINE MOBILE NUMBER
    '==================================================
    Private Function TryNormalizePhilippineMobileNumber(
        input As String,
        ByRef normalized As String
    ) As Boolean

        normalized = ""


        If String.IsNullOrWhiteSpace(
            input
        ) Then

            Return False

        End If


        Dim number As String =
            input.Trim().
            Replace(" ", "").
            Replace("-", "").
            Replace("(", "").
            Replace(")", "").
            Replace(".", "")


        '==================================================
        ' +639XXXXXXXXX -> 09XXXXXXXXX
        '==================================================
        If number.StartsWith(
            "+63",
            StringComparison.Ordinal
        ) Then

            number =
                "0" &
                number.Substring(3)


            '==================================================
            ' 639XXXXXXXXX -> 09XXXXXXXXX
            '==================================================
        ElseIf number.StartsWith(
            "63",
            StringComparison.Ordinal
        ) Then

            number =
                "0" &
                number.Substring(2)


            '==================================================
            ' 9XXXXXXXXX -> 09XXXXXXXXX
            '==================================================
        ElseIf number.Length = 10 AndAlso
               number.StartsWith(
                   "9",
                   StringComparison.Ordinal
               ) Then

            number =
                "0" &
                number

        End If


        '==================================================
        ' MUST BE 11 DIGITS
        '==================================================
        If number.Length <> 11 Then
            Return False
        End If


        '==================================================
        ' MUST START WITH 09
        '==================================================
        If Not number.StartsWith(
            "09",
            StringComparison.Ordinal
        ) Then

            Return False

        End If


        '==================================================
        ' NUMBERS ONLY
        '==================================================
        For Each character As Char In number

            If Not Char.IsDigit(
                character
            ) Then

                Return False

            End If

        Next


        normalized =
            number

        Return True

    End Function


    '==================================================
    ' SEND MANUAL SMS
    '==================================================
    Private Async Function SendManualSMS(
        parentNumber As String,
        message As String
    ) As Task(Of Boolean)

        '==================================================
        ' GET API TOKEN FROM WINDOWS ENVIRONMENT VARIABLE
        '==================================================
        Dim apiToken As String =
            Environment.GetEnvironmentVariable(
                "IPROGTECH_API_TOKEN"
            )


        '==================================================
        ' API TOKEN CHECK
        '==================================================
        If String.IsNullOrWhiteSpace(
            apiToken
        ) Then

            MessageBox.Show(
                "The SMS API is not configured." &
                vbCrLf &
                vbCrLf &
                "The IPROGTECH_API_TOKEN environment variable is missing.",
                "SMS Configuration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return False

        End If


        '==================================================
        ' VALIDATE CONTACT AGAIN FOR SAFETY
        '==================================================
        Dim normalizedNumber As String = ""

        If Not TryNormalizePhilippineMobileNumber(
            parentNumber,
            normalizedNumber
        ) Then

            MessageBox.Show(
                "The parent's contact number is invalid." &
                vbCrLf &
                vbCrLf &
                "The SMS was not sent.",
                "Invalid Contact Number",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return False

        End If


        '==================================================
        ' API URL
        '==================================================
        Dim apiUrl As String =
            "https://sms.iprogtech.com/api/v1/sms_messages?api_token=" &
            apiToken


        Try

            '==================================================
            ' PREPARE JSON
            '==================================================
            Dim safeNumber As String =
                EscapeJson(
                    normalizedNumber
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


            '==================================================
            ' SEND HTTP REQUEST
            '==================================================
            Using client As New HttpClient()

                client.Timeout =
                    TimeSpan.FromSeconds(20)


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


                '==================================================
                ' SUCCESS
                '==================================================
                If response.IsSuccessStatusCode Then

                    Return True

                End If


                '==================================================
                ' API / PROVIDER ERROR
                '==================================================
                ShowSmsProviderError(
                    CInt(
                        response.StatusCode
                    ),
                    responseBody
                )

                Return False

            End Using


        Catch ex As HttpRequestException

            MessageBox.Show(
                "The SMS could not be sent because the internet connection " &
                "or SMS server is unavailable." &
                vbCrLf &
                vbCrLf &
                "Please check the internet connection and try again.",
                "Network Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return False


        Catch ex As TaskCanceledException

            MessageBox.Show(
                "The SMS request timed out." &
                vbCrLf &
                vbCrLf &
                "The SMS server took too long to respond." &
                vbCrLf &
                "Please try again.",
                "SMS Timeout",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return False


        Catch ex As Exception

            MessageBox.Show(
                "An unexpected error occurred while sending the SMS." &
                vbCrLf &
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
    ' SHOW SMS PROVIDER ERROR
    '==================================================
    Private Sub ShowSmsProviderError(
        statusCode As Integer,
        responseBody As String
    )

        Dim errorText As String = ""


        Select Case statusCode

            '==================================================
            ' BAD REQUEST
            '==================================================
            Case 400

                errorText =
                    "The SMS provider rejected the request." &
                    vbCrLf &
                    vbCrLf &
                    "Please check the phone number and message."


            '==================================================
            ' INVALID API TOKEN
            '==================================================
            Case 401, 403

                errorText =
                    "The SMS API authentication failed." &
                    vbCrLf &
                    vbCrLf &
                    "Please check the IPROGTECH_API_TOKEN configuration."


            '==================================================
            ' PAYMENT / CREDIT PROBLEM
            '==================================================
            Case 402

                errorText =
                    "The SMS could not be sent." &
                    vbCrLf &
                    vbCrLf &
                    "Please check your SMS account or available credits."


            '==================================================
            ' NOT FOUND
            '==================================================
            Case 404

                errorText =
                    "The SMS service endpoint could not be found."


            '==================================================
            ' TIMEOUT
            '==================================================
            Case 408

                errorText =
                    "The SMS provider timed out while processing the request."


            '==================================================
            ' VALIDATION ERROR
            '==================================================
            Case 422

                errorText =
                    "The SMS provider rejected the phone number or message." &
                    vbCrLf &
                    vbCrLf &
                    "Please check the information and try again."


            '==================================================
            ' TOO MANY REQUESTS
            '==================================================
            Case 429

                errorText =
                    "Too many SMS requests were sent." &
                    vbCrLf &
                    vbCrLf &
                    "Please try again later."


            '==================================================
            ' PROVIDER SERVER ERROR
            '==================================================
            Case 500 To 599

                errorText =
                    "The SMS provider is currently experiencing a server problem." &
                    vbCrLf &
                    vbCrLf &
                    "Please try again later."


                '==================================================
                ' OTHER ERROR
                '==================================================
            Case Else

                errorText =
                    "The SMS provider rejected the request." &
                    vbCrLf &
                    vbCrLf &
                    "HTTP Status: " &
                    statusCode.ToString()

        End Select


        Dim providerResponse As String =
            GetSafeProviderResponse(
                responseBody
            )


        If providerResponse <> "" Then

            errorText &=
                vbCrLf &
                vbCrLf &
                "Provider Response:" &
                vbCrLf &
                providerResponse

        End If


        MessageBox.Show(
            errorText,
            "SMS Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

    End Sub


    '==================================================
    ' SAFE PROVIDER RESPONSE
    '==================================================
    Private Function GetSafeProviderResponse(
        responseBody As String
    ) As String

        If String.IsNullOrWhiteSpace(
            responseBody
        ) Then

            Return ""

        End If


        Dim result As String =
            responseBody.Trim()


        '==================================================
        ' LIMIT VERY LONG SERVER RESPONSE
        '==================================================
        If result.Length > 500 Then

            result =
                result.Substring(
                    0,
                    500
                ) &
                "..."

        End If


        Return result

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

            EnsureDatabaseConnection()


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

            EnsureDatabaseConnection()


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

                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    Dim dt As New DataTable()

                    adapter.Fill(dt)

                    dgvSMSLogs.DataSource =
                        dt

                End Using

            End Using


            FormatSmsLogsGrid()

            dgvSMSLogs.ClearSelection()

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
    ' FORMAT SMS LOGS TABLE
    '==================================================
    Private Sub FormatSmsLogsGrid()

        If dgvSMSLogs Is Nothing OrElse
           dgvSMSLogs.Columns.Count = 0 Then

            Return

        End If


        dgvSMSLogs.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvSMSLogs.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvSMSLogs.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvSMSLogs.RowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvSMSLogs.AlternatingRowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter


        dgvSMSLogs.RowsDefaultCellStyle.BackColor =
            Color.White

        dgvSMSLogs.RowsDefaultCellStyle.ForeColor =
            Color.Black

        dgvSMSLogs.AlternatingRowsDefaultCellStyle.BackColor =
            Color.White

        dgvSMSLogs.AlternatingRowsDefaultCellStyle.ForeColor =
            Color.Black


        dgvSMSLogs.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(
                230,
                220,
                210
            )

        dgvSMSLogs.DefaultCellStyle.SelectionForeColor =
            Color.Black


        dgvSMSLogs.RowHeadersVisible =
            False

        dgvSMSLogs.AllowUserToResizeRows =
            False

        dgvSMSLogs.RowTemplate.Height =
            30


        For Each row As DataGridViewRow In dgvSMSLogs.Rows

            row.Height = 30

        Next


        For Each column As DataGridViewColumn In dgvSMSLogs.Columns

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
                     "collogstudentname"

                    column.HeaderText =
                        "Student Name"

                    column.FillWeight =
                        120


                Case "contact_number",
                     "collogcontactnumber"

                    column.HeaderText =
                        "Contact Number"

                    column.FillWeight =
                        90


                Case "sms_type",
                     "collogsmstype"

                    column.HeaderText =
                        "SMS Type"

                    column.FillWeight =
                        75


                Case "message",
                     "collogmessage"

                    column.HeaderText =
                        "Message"

                    column.FillWeight =
                        190

                    column.DefaultCellStyle.WrapMode =
                        DataGridViewTriState.False


                Case "sent_at",
                     "collogsentat"

                    column.HeaderText =
                        "Sent At"

                    column.FillWeight =
                        110

                    column.DefaultCellStyle.Format =
                        "MMM dd, yyyy hh:mm tt"


                Case "status",
                     "collogstatus"

                    column.HeaderText =
                        "Status"

                    column.FillWeight =
                        65

            End Select


            column.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter

        Next

    End Sub


    '==================================================
    ' SMS SUMMARY
    '==================================================
    Private Sub LoadSmsSummary()

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "COUNT(*) AS total_logs, " &
                "COALESCE(SUM(CASE WHEN UPPER(status) = 'SENT' THEN 1 ELSE 0 END), 0) AS sent_count, " &
                "COALESCE(SUM(CASE WHEN UPPER(status) = 'FAILED' THEN 1 ELSE 0 END), 0) AS failed_count " &
                "FROM sms_logs"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        lblTotalLogs.Text =
                            reader(
                                "total_logs"
                            ).ToString()

                        lblSentCount.Text =
                            reader(
                                "sent_count"
                            ).ToString()

                        lblFailedCount.Text =
                            reader(
                                "failed_count"
                            ).ToString()

                    Else

                        lblTotalLogs.Text = "0"
                        lblSentCount.Text = "0"
                        lblFailedCount.Text = "0"

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

        If e.RowIndex < 0 OrElse
           e.ColumnIndex < 0 Then

            Return

        End If


        If e.ColumnIndex >=
           dgvSMSLogs.Columns.Count Then

            Return

        End If


        Dim currentColumn As DataGridViewColumn =
            dgvSMSLogs.Columns(
                e.ColumnIndex
            )


        If currentColumn Is Nothing Then
            Return
        End If


        Dim columnKey As String =
            currentColumn.DataPropertyName


        If String.IsNullOrWhiteSpace(
            columnKey
        ) Then

            columnKey =
                currentColumn.Name

        End If


        columnKey =
            columnKey.
            Trim().
            ToLowerInvariant()


        If columnKey <> "status" AndAlso
           columnKey <> "collogstatus" Then

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

                e.CellStyle.SelectionForeColor =
                    Color.FromArgb(
                        32,
                        110,
                        55
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

                e.CellStyle.SelectionForeColor =
                    Color.FromArgb(
                        170,
                        35,
                        35
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