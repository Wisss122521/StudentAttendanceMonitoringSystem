Imports System.Data.Odbc
Imports System.Data.SqlTypes
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class SmsNotification

    '========================================
    ' SELECTED STUDENT VARIABLES
    '========================================
    Private selectedStudentId As Integer = 0
    Private selectedStudentName As String = ""
    Private selectedContactNumber As String = ""

    Private WithEvents timerClock As New Timer()


    '========================================
    ' USERCONTROL LOAD
    '========================================
    Private Sub SmsNotifications_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
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

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Notifications Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================
    ' DATE / TIME
    '========================================
    Private Sub timerClock_Tick(
        sender As Object,
        e As EventArgs
    ) Handles timerClock.Tick

        UpdateDateTime()

    End Sub


    Private Sub UpdateDateTime()

        lblDateTime.Text =
            DateTime.Now.ToString("dddd, MMMM dd, yyyy") &
            "     |     " &
            DateTime.Now.ToString("hh:mm:ss tt")

    End Sub


    '========================================
    ' LOAD STUDENTS
    '========================================
    Private Sub LoadStudents()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT " &
                "students_id AS student_id, " &
                "students_name AS student_name, " &
                "CONCAT(year_level, ' - ', course) AS year_course " &
                "FROM students " &
                "WHERE 1=1 "


            ' SEARCH
            If txtSearchStudent.Text.Trim() <> "" Then

                query &=
                    "AND (" &
                    "students_name LIKE ? " &
                    "OR CAST(students_id AS CHAR) LIKE ?" &
                    ") "

            End If


            query &=
                "ORDER BY students_name ASC"


            Using cmd As New OdbcCommand(query, con)

                If txtSearchStudent.Text.Trim() <> "" Then

                    Dim searchValue As String =
                        "%" & txtSearchStudent.Text.Trim() & "%"

                    cmd.Parameters.AddWithValue(
                        "@search1",
                        searchValue
                    )

                    cmd.Parameters.AddWithValue(
                        "@search2",
                        searchValue
                    )

                End If


                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvStudents.DataSource = dt

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Load Students Error: " & ex.Message,
                "Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================
    ' SEARCH STUDENT
    '========================================
    Private Sub txtSearchStudent_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearchStudent.TextChanged

        LoadStudents()

    End Sub


    '========================================
    ' CLICK STUDENT
    '========================================
    Private Sub dgvStudents_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvStudents.CellClick

        If e.RowIndex < 0 Then Return


        Try

            Dim rowView As DataRowView =
                TryCast(
                    dgvStudents.Rows(e.RowIndex).DataBoundItem,
                    DataRowView
                )


            If rowView Is Nothing Then Return


            Dim studentId As Integer =
                Convert.ToInt32(
                    rowView("student_id")
                )


            LoadSelectedStudent(studentId)


        Catch ex As Exception

            MessageBox.Show(
                "Student Selection Error: " & ex.Message,
                "Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================
    ' LOAD SELECTED STUDENT DETAILS
    '========================================
    Private Sub LoadSelectedStudent(
        studentId As Integer
    )

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
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


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@id",
                    studentId
                )


                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        selectedStudentId =
                            Convert.ToInt32(
                                reader("students_id")
                            )


                        selectedStudentName =
                            reader("students_name").ToString()


                        If IsDBNull(
                            reader("parent_contact_number")
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
                            reader("year_level").ToString() &
                            " - " &
                            reader("course").ToString()


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
                "Student Details Error: " & ex.Message,
                "Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================
    ' MESSAGE CHARACTER COUNT
    '========================================
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


    '========================================
    ' CLEAR MESSAGE
    '========================================
    Private Sub btnClearMessage_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClearMessage.Click

        txtMessage.Clear()
        txtMessage.Focus()

    End Sub


    '========================================
    ' SEND SMS BUTTON
    '========================================
    Private Async Sub btnSendSMS_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSendSMS.Click


        ' NO STUDENT SELECTED
        If selectedStudentId = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Send SMS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        ' NO CONTACT NUMBER
        If selectedContactNumber.Trim() = "" Then

            MessageBox.Show(
                "The selected student has no parent contact number.",
                "Send SMS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        ' EMPTY MESSAGE
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


        ' CONFIRMATION
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


        If result = DialogResult.No Then
            Return
        End If


        Try

            btnSendSMS.Enabled = False
            btnSendSMS.Text = "Sending..."


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

            LoadSmsLogs()


        Catch ex As Exception

            MessageBox.Show(
                "Send SMS Error: " & ex.Message,
                "Notifications",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Finally

            btnSendSMS.Enabled =
                selectedContactNumber <> ""

            btnSendSMS.Text =
                "Send SMS"

        End Try

    End Sub


    '========================================
    ' SEND MANUAL SMS USING IPROGTECH
    '========================================
    Private Async Function SendManualSMS(
        parentNumber As String,
        message As String
    ) As Task(Of Boolean)


        ' IMPORTANT:
        ' Generate a NEW API token.
        ' Do not reuse the token you posted publicly.
        Dim apiToken As String =
            "de73dee5c2e1e19b2984f9eba3b0084e9adb82a1"


        Dim apiUrl As String =
            "https://sms.iprogtech.com/api/v1/sms_messages?api_token=" &
            apiToken


        Try

            ' Escape characters that can break JSON
            Dim safeNumber As String =
                EscapeJson(parentNumber)

            Dim safeMessage As String =
                EscapeJson(message)


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

                    Console.WriteLine(
                        "SMS Sent: " &
                        responseBody
                    )

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


    '========================================
    ' ESCAPE JSON TEXT
    '========================================
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


    '========================================
    ' CLEAR SELECTED STUDENT
    '========================================
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

    Private Sub SaveSmsLog(
    studentId As Integer,
    contactNumber As String,
    message As String,
    smsType As String,
    status As String
)

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If

            Dim query As String =
                "INSERT INTO sms_logs " &
                "(students_id, contact_number, message, sms_type, status) " &
                "VALUES (?, ?, ?, ?, ?)"

            Using cmd As New OdbcCommand(query, con)

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
                "SMS Log Error: " & ex.Message,
                "SMS Logs",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub LoadSmsLogs()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
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

            Using cmd As New OdbcCommand(query, con)

                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvSMSLogs.DataSource = dt

            End Using

        Catch ex As Exception

            MessageBox.Show(
            "Load SMS Logs Error: " & ex.Message,
            "SMS Logs",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

End Class