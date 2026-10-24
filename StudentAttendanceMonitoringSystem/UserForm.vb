Imports System.Data
Imports System.Data.Odbc
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class UserForm
    Private isProcessingScan As Boolean = False
    Private lastScannedQR As String = ""
    Private lastScanTime As DateTime = DateTime.MinValue

    Private Const ScanCooldownSeconds As Integer = 3


    Private Sub timerClock_Tick_1(sender As Object, e As EventArgs) Handles timerClock.Tick
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()

        lblDateTime.Text =
        DateTime.Now.ToString("dddd, MMMM dd, yyyy") &
        "     |     " &
        DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub MarkAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timerClock.Interval = 1000
        timerClock.Start()

        UpdateDateTime()

    End Sub

    Public Sub dgvLoaderAttendance(sql As String, dgv As DataGridView)
        Try
            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then
                vbConnection()
            End If
            Dim adapter As New OdbcDataAdapter(sql, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show(
                "Failed to load data." &
                vbCrLf &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbConnection()
        Call dgvLoaderAttendance("SELECT * FROM attendance_records ORDER BY attendance_id DESC", dgvAttendance)
    End Sub

    Private Async Function SendSmsTimeOut(
    studentId As Integer,
    parentNumber As String,
    studentName As String
) As Task

        Dim apiToken As String =
        Environment.GetEnvironmentVariable("IPROGTECH_API_TOKEN")

        Dim message As String =
        "Hello, your child " &
        studentName &
        " has left the school."


        '==================================================
        ' NO CONTACT NUMBER
        '==================================================
        If String.IsNullOrWhiteSpace(parentNumber) Then

            SaveAttendanceSmsLog(
            studentId,
            "",
            message,
            "TIME OUT",
            "FAILED"
        )

            MessageBox.Show(
            "Time Out was recorded, but this student has no parent contact number.",
            "SMS Not Sent",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Return

        End If


        '==================================================
        ' API TOKEN CHECK
        '==================================================
        If String.IsNullOrWhiteSpace(apiToken) Then

            SaveAttendanceSmsLog(
            studentId,
            parentNumber,
            message,
            "TIME OUT",
            "FAILED"
        )

            MessageBox.Show(
            "Time Out was recorded, but the SMS API is not configured.",
            "SMS Configuration",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Return

        End If


        Dim apiUrl As String =
        "https://sms.iprogtech.com/api/v1/sms_messages?api_token=" &
        apiToken


        Try

            Dim jsonBody As String =
            "{""phone_number"":""" &
            parentNumber &
            """,""message"":""" &
            message.Replace("""", "\""") &
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
                Await response.Content.ReadAsStringAsync()


                If response.IsSuccessStatusCode Then

                    SaveAttendanceSmsLog(
                    studentId,
                    parentNumber,
                    message,
                    "TIME OUT",
                    "SENT"
                )

                Else

                    SaveAttendanceSmsLog(
                    studentId,
                    parentNumber,
                    message,
                    "TIME OUT",
                    "FAILED"
                )

                    MessageBox.Show(
                    "Time Out was recorded, but SMS failed." &
                    vbCrLf &
                    responseBody,
                    "SMS Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                End If

            End Using


        Catch ex As HttpRequestException

            SaveAttendanceSmsLog(
            studentId,
            parentNumber,
            message,
            "TIME OUT",
            "FAILED"
        )

            MessageBox.Show(
            "Time Out was recorded, but SMS could not be sent because the SMS server could not be reached.",
            "Network Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )


        Catch ex As Exception

            SaveAttendanceSmsLog(
            studentId,
            parentNumber,
            message,
            "TIME OUT",
            "FAILED"
        )

            MessageBox.Show(
            "Time Out was recorded, but an error occurred while sending the SMS.",
            "SMS Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

        End Try

    End Function

    Private Async Function SendSmsTimeIn(
    studentId As Integer,
    parentNumber As String,
    studentName As String
) As Task

        Dim apiToken As String =
        Environment.GetEnvironmentVariable("IPROGTECH_API_TOKEN")

        Dim message As String =
        "Hello, your child " &
        studentName &
        " has arrived at school."


        '==================================================
        ' NO CONTACT NUMBER
        '==================================================
        If String.IsNullOrWhiteSpace(parentNumber) Then

            SaveAttendanceSmsLog(
            studentId,
            "",
            message,
            "TIME IN",
            "FAILED"
        )

            MessageBox.Show(
            "Time In was recorded, but this student has no parent contact number.",
            "SMS Not Sent",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Return

        End If


        '==================================================
        ' API TOKEN CHECK
        '==================================================
        If String.IsNullOrWhiteSpace(apiToken) Then

            SaveAttendanceSmsLog(
            studentId,
            parentNumber,
            message,
            "TIME IN",
            "FAILED"
        )

            MessageBox.Show(
            "Time In was recorded, but the SMS API is not configured.",
            "SMS Configuration",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Return

        End If


        Dim apiUrl As String =
        "https://sms.iprogtech.com/api/v1/sms_messages?api_token=" &
        apiToken


        Try

            Dim jsonBody As String =
            "{""phone_number"":""" &
            parentNumber &
            """,""message"":""" &
            message.Replace("""", "\""") &
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
                Await response.Content.ReadAsStringAsync()


                If response.IsSuccessStatusCode Then

                    SaveAttendanceSmsLog(
                    studentId,
                    parentNumber,
                    message,
                    "TIME IN",
                    "SENT"
                )

                Else

                    SaveAttendanceSmsLog(
                    studentId,
                    parentNumber,
                    message,
                    "TIME IN",
                    "FAILED"
                )

                    MessageBox.Show(
                    "Time In was recorded, but SMS failed." &
                    vbCrLf &
                    responseBody,
                    "SMS Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                End If

            End Using


        Catch ex As HttpRequestException

            SaveAttendanceSmsLog(
            studentId,
            parentNumber,
            message,
            "TIME IN",
            "FAILED"
        )

            MessageBox.Show(
            "Time In was recorded, but SMS could not be sent because the SMS server could not be reached.",
            "Network Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )


        Catch ex As Exception

            SaveAttendanceSmsLog(
            studentId,
            parentNumber,
            message,
            "TIME IN",
            "FAILED"
        )

            MessageBox.Show(
            "Time In was recorded, but an error occurred while sending the SMS.",
            "SMS Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

        End Try

    End Function

    Private Async Sub txtQRCode_KeyDown(
    sender As Object,
    e As KeyEventArgs
) Handles txtQrCode.KeyDown

        ' Enter lang ang magpo-process
        If e.KeyCode <> Keys.Enter Then
            Return
        End If

        e.SuppressKeyPress = True
        e.Handled = True


        '==================================================
        ' PREVENT SCAN WHILE CURRENT SCAN IS PROCESSING
        '==================================================
        If isProcessingScan Then

            txtQrCode.Clear()

            Return

        End If


        Dim scannedQR As String =
        txtQrCode.Text.Trim()


        '==================================================
        ' EMPTY QR
        '==================================================
        If scannedQR = "" Then

            lblStatus.Text =
            "Please scan QR Code."

            lblStudentName.Text = ""
            lblTime.Text = ""
            lblAttendance.Text = ""
            lblYearLevel.Text = ""
            lblParentNumber.Text = ""

            txtQrCode.Clear()
            txtQrCode.Focus()

            Return

        End If


        '==================================================
        ' DOUBLE-SCAN PROTECTION
        '==================================================
        Dim secondsSinceLastScan As Double =
        (DateTime.Now - lastScanTime).TotalSeconds


        If String.Equals(
        scannedQR,
        lastScannedQR,
        StringComparison.OrdinalIgnoreCase
    ) AndAlso
       secondsSinceLastScan < ScanCooldownSeconds Then

            lblStatus.Text =
            "QR Code scanned too quickly. Please wait."

            lblAttendance.Text =
            "Duplicate scan ignored."

            txtQrCode.Clear()
            txtQrCode.Focus()

            Return

        End If


        '==================================================
        ' START PROCESSING
        '==================================================
        isProcessingScan = True

        txtQrCode.Enabled = False


        Try

            Await MarkAttendance(
            scannedQR
        )


            ' Remember last processed QR
            lastScannedQR =
            scannedQR

            lastScanTime =
            DateTime.Now


        Catch ex As Exception

            MessageBox.Show(
            "Unable to process the QR Code." &
            vbCrLf &
            ex.Message,
            "QR Scan Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )


        Finally

            '==================================================
            ' READY FOR NEXT SCAN
            '==================================================
            isProcessingScan = False

            txtQrCode.Clear()

            txtQrCode.Enabled = True

            txtQrCode.Focus()

        End Try

    End Sub

    Private Async Function MarkAttendance(scannedQR As String) As Task
        Try

            If con Is Nothing OrElse
               con.State <> ConnectionState.Open Then

                vbConnection()

            End If

            Dim query As String =
                "SELECT students_id, students_name, parent_contact_number, course, year_level " &
                "FROM students " &
                "WHERE LOWER(qr_code_data) = LOWER(?)"

            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@qr",
                    scannedQR.Trim()
                )

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If Not reader.Read() Then

                        lblStudentName.Text = ""
                        lblStatus.Text = "QR Code not found."
                        lblTime.Text = ""
                        lblAttendance.Text = ""
                        lblYearLevel.Text = ""
                        lblParentNumber.Text = ""

                        Return

                    End If

                    Dim studentId As Integer =
                        Convert.ToInt32(
                            reader("students_id")
                        )

                    Dim studentName As String =
                        reader("students_name").ToString()


                    Dim yearLevel As String =
                        reader("year_level").ToString()

                    Dim course As String =
                        reader("course").ToString()

                    Dim parentNumber As String =
                        reader("parent_contact_number").ToString()

                    reader.Close()

                    lblStudentName.Text =
                        studentName

                    lblYearLevel.Text =
                        yearLevel & " - " & course

                    lblParentNumber.Text =
                        parentNumber

                    Await ProcessAttendanceAsync(
                        studentId,
                        studentName,
                        parentNumber
                    )

                End Using

            End Using

        Catch ex As Exception

            lblStatus.Text =
                "Error processing QR Code."

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Function

    Private Async Function ProcessAttendanceAsync(
    studentId As Integer,
    studentName As String,
    parentNumber As String
) As Task

        Try

            Dim today As String =
                DateTime.Now.ToString("yyyy-MM-dd")

            Dim currentTime As String =
                DateTime.Now.ToString("HH:mm:ss")

            Dim checkQuery As String =
                "SELECT attendance_id " &
                "FROM attendance_records " &
                "WHERE students_id = ? " &
                "AND attendance_date = ? " &
                "AND time_out IS NULL " &
                "ORDER BY attendance_id DESC " &
                "LIMIT 1"

            Using checkCmd As New OdbcCommand(
                checkQuery,
                con
            )

                checkCmd.Parameters.AddWithValue(
                    "@studentId",
                    studentId
                )

                checkCmd.Parameters.AddWithValue(
                    "@date",
                    today
                )

                Using reader As OdbcDataReader =
                    checkCmd.ExecuteReader()

                    If reader.Read() Then

                        Dim attendanceId As Integer =
                            Convert.ToInt32(
                                reader("attendance_id")
                            )

                        reader.Close()

                        Dim updateQuery As String =
                            "UPDATE attendance_records " &
                            "SET time_out = ? " &
                            "WHERE attendance_id = ?"

                        Using updateCmd As New OdbcCommand(
                            updateQuery,
                            con
                        )

                            updateCmd.Parameters.AddWithValue(
                                "@timeOut",
                                currentTime
                            )

                            updateCmd.Parameters.AddWithValue(
                                "@attendanceId",
                                attendanceId
                            )

                            updateCmd.ExecuteNonQuery()
                            Await SendSmsTimeOut(
                                studentId,
                                parentNumber,
                                studentName
                            )

                        End Using

                        Call dgvLoaderAttendance("SELECT * FROM attendance_records ORDER BY attendance_id DESC", dgvAttendance)

                        lblStatus.Text = "TIME OUT"

                        lblAttendance.Text = "Attendance recorded successfully!"

                        lblTime.Text =
                            DateTime.Now.ToString("hh:mm:ss tt")

                        'MessageBox.Show(
                        '    studentName &
                        '    vbCrLf &
                        '    "Time Out: " &
                        '    DateTime.Now.ToString("hh:mm:ss tt"),
                        '    "Attendance Recorded",
                        '    MessageBoxButtons.OK,
                        '    MessageBoxIcon.Information
                        ')

                    Else

                        reader.Close()


                        Dim insertQuery As String =
                            "INSERT INTO attendance_records " &
                            "(students_id, attendance_date, time_in) " &
                            "VALUES (?, ?, ?)"

                        Using insertCmd As New OdbcCommand(
                            insertQuery,
                            con
                        )

                            insertCmd.Parameters.AddWithValue(
                                "@studentId",
                                studentId
                            )

                            insertCmd.Parameters.AddWithValue(
                                "@date",
                                today
                            )

                            insertCmd.Parameters.AddWithValue(
                                "@timeIn",
                                currentTime
                            )

                            insertCmd.ExecuteNonQuery()
                            Await SendSmsTimeIn(
                                studentId,
                                parentNumber,
                                studentName
                            )

                        End Using

                        Call dgvLoaderAttendance("SELECT * FROM attendance_records ORDER BY attendance_id DESC", dgvAttendance)

                        lblStatus.Text = "TIME IN"

                        lblAttendance.Text = "Attendance recorded successfully!"

                        lblTime.Text =
                            DateTime.Now.ToString("hh:mm:ss tt")

                        'MessageBox.Show(
                        '    studentName &
                        '    vbCrLf &
                        '    "Time In: " &
                        '    DateTime.Now.ToString("hh:mm:ss tt"),
                        '    "Attendance Recorded",
                        '    MessageBoxButtons.OK,
                        '    MessageBoxIcon.Information
                        ')

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Failed to save attendance." &
                vbCrLf &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Function

    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click

        Dim result As DialogResult =
        MessageBox.Show(
            "Are you sure you want to log out?",
            "Log Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    '==================================================
    ' SAVE AUTOMATIC SMS LOG
    '==================================================
    Private Sub SaveAttendanceSmsLog(
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
            "Attendance was saved, but the SMS log could not be recorded." &
            vbCrLf &
            ex.Message,
            "SMS Log Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

        End Try

    End Sub
End Class