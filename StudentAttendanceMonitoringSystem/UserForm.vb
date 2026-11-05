Imports System.Data
Imports System.Data.Odbc
Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks


Public Class UserForm

    '==================================================
    ' SCANNER STATE
    '==================================================
    Private isProcessingScan As Boolean = False
    Private lastScannedQR As String = ""
    Private lastScanTime As DateTime = DateTime.MinValue

    Private Const ScanCooldownSeconds As Integer = 3


    '==================================================
    ' SHARED SMS CLIENT
    '==================================================
    Private Shared ReadOnly smsClient As New HttpClient() With {
        .Timeout = TimeSpan.FromSeconds(10)
    }


    '==================================================
    ' CLOCK
    '==================================================
    Private Sub timerClock_Tick_1(
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
            "     |     " &
            DateTime.Now.ToString(
                "hh:mm:ss tt"
            )

    End Sub


    '==================================================
    ' FORM LOAD
    '==================================================
    Private Sub UserForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            EnsureDatabaseConnection()

            timerClock.Interval = 1000
            timerClock.Start()

            UpdateDateTime()

            ResetStudentDisplay()

            LoadRecentAttendance()

            txtQrCode.Focus()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to initialize the attendance scanner.",
                "Attendance System",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Debug.WriteLine(
                "UserForm Load Error: " &
                ex.Message
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
    ' RESET STUDENT DISPLAY
    '==================================================
    Private Sub ResetStudentDisplay()

        lblStudentName.Text =
            "No student scanned"

        lblYearLevel.Text =
            "-"

        lblParentNumber.Text =
            "-"

        lblStatus.Text =
            "READY"

        lblAttendance.Text =
            "Waiting for QR Code scan..."

        lblTime.Text =
            "--:--:--"

    End Sub


    '==================================================
    ' LOAD RECENT ATTENDANCE
    '==================================================
    Private Sub LoadRecentAttendance()

        Try

            EnsureDatabaseConnection()


            ' Latest attendance records regardless of date.
            ' This allows old records to remain visible.
            Dim query As String =
                "SELECT " &
                "attendance_id, " &
                "students_id, " &
                "attendance_date, " &
                "time_in, " &
                "time_out " &
                "FROM attendance_records " &
                "ORDER BY attendance_id DESC " &
                "LIMIT 50"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    Dim table As New DataTable()

                    adapter.Fill(table)

                    dgvAttendance.DataSource =
                        table

                End Using

            End Using


            dgvAttendance.ClearSelection()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load recent scans.",
                "Attendance Records",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Debug.WriteLine(
                "Load Attendance Error: " &
                ex.Message
            )

        End Try

    End Sub


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
    ' SEND TIME-OUT SMS
    '==================================================
    Private Async Function SendSmsTimeOut(
        studentId As Integer,
        parentNumber As String,
        studentName As String
    ) As Task

        Dim apiToken As String =
            Environment.GetEnvironmentVariable(
                "IPROGTECH_API_TOKEN"
            )


        Dim message As String =
            "Hello, your child " &
            studentName &
            " has left the school."


        '==================================================
        ' NO CONTACT NUMBER
        '==================================================
        If String.IsNullOrWhiteSpace(
            parentNumber
        ) Then

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
        If String.IsNullOrWhiteSpace(
            apiToken
        ) Then

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


            Using content As New StringContent(
                jsonBody,
                Encoding.UTF8,
                "application/json"
            )

                Using response As HttpResponseMessage =
                    Await smsClient.PostAsync(
                        apiUrl,
                        content
                    )

                    Dim responseBody As String =
                        Await response.Content.
                        ReadAsStringAsync()


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

            End Using


        Catch ex As TaskCanceledException

            SaveAttendanceSmsLog(
                studentId,
                parentNumber,
                message,
                "TIME OUT",
                "FAILED"
            )

            MessageBox.Show(
                "Time Out was recorded, but the SMS request timed out.",
                "SMS Timeout",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )


        Catch ex As HttpRequestException

            SaveAttendanceSmsLog(
                studentId,
                parentNumber,
                message,
                "TIME OUT",
                "FAILED"
            )

            MessageBox.Show(
                "Time Out was recorded, but the SMS server could not be reached.",
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

            Debug.WriteLine(
                "Time-Out SMS Error: " &
                ex.Message
            )

        End Try

    End Function


    '==================================================
    ' SEND TIME-IN SMS
    '==================================================
    Private Async Function SendSmsTimeIn(
        studentId As Integer,
        parentNumber As String,
        studentName As String
    ) As Task

        Dim apiToken As String =
            Environment.GetEnvironmentVariable(
                "IPROGTECH_API_TOKEN"
            )


        Dim message As String =
            "Hello, your child " &
            studentName &
            " has arrived at school."


        '==================================================
        ' NO CONTACT NUMBER
        '==================================================
        If String.IsNullOrWhiteSpace(
            parentNumber
        ) Then

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
        If String.IsNullOrWhiteSpace(
            apiToken
        ) Then

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


            Using content As New StringContent(
                jsonBody,
                Encoding.UTF8,
                "application/json"
            )

                Using response As HttpResponseMessage =
                    Await smsClient.PostAsync(
                        apiUrl,
                        content
                    )

                    Dim responseBody As String =
                        Await response.Content.
                        ReadAsStringAsync()


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

            End Using


        Catch ex As TaskCanceledException

            SaveAttendanceSmsLog(
                studentId,
                parentNumber,
                message,
                "TIME IN",
                "FAILED"
            )

            MessageBox.Show(
                "Time In was recorded, but the SMS request timed out.",
                "SMS Timeout",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )


        Catch ex As HttpRequestException

            SaveAttendanceSmsLog(
                studentId,
                parentNumber,
                message,
                "TIME IN",
                "FAILED"
            )

            MessageBox.Show(
                "Time In was recorded, but the SMS server could not be reached.",
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

            Debug.WriteLine(
                "Time-In SMS Error: " &
                ex.Message
            )

        End Try

    End Function


    '==================================================
    ' QR CODE ENTER
    '==================================================
    Private Async Sub txtQRCode_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles txtQrCode.KeyDown

        If e.KeyCode <> Keys.Enter Then
            Return
        End If


        e.SuppressKeyPress = True
        e.Handled = True


        '==================================================
        ' PREVENT SECOND SCAN WHILE PROCESSING
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
        If String.IsNullOrWhiteSpace(
            scannedQR
        ) Then

            ResetStudentDisplay()

            lblAttendance.Text =
                "Please scan a valid student QR Code."

            txtQrCode.Clear()
            txtQrCode.Focus()

            Return

        End If


        '==================================================
        ' DOUBLE-SCAN PROTECTION
        '==================================================
        Dim secondsSinceLastScan As Double =
            (
                DateTime.Now -
                lastScanTime
            ).TotalSeconds


        If String.Equals(
            scannedQR,
            lastScannedQR,
            StringComparison.OrdinalIgnoreCase
        ) AndAlso
           secondsSinceLastScan <
           ScanCooldownSeconds Then

            lblStatus.Text =
                "PLEASE WAIT"

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


            lastScannedQR =
                scannedQR

            lastScanTime =
                DateTime.Now


        Catch ex As Exception

            MessageBox.Show(
                "Unable to process the QR Code. Please try again.",
                "QR Scan Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Debug.WriteLine(
                "QR Scan Error: " &
                ex.Message
            )


        Finally

            isProcessingScan = False

            txtQrCode.Clear()

            txtQrCode.Enabled = True

            txtQrCode.Focus()

        End Try

    End Sub


    '==================================================
    ' MARK ATTENDANCE
    '==================================================
    Private Async Function MarkAttendance(
        scannedQR As String
    ) As Task

        Try

            EnsureDatabaseConnection()


            ' IMPORTANT:
            ' Actual students table has NO status column.
            Dim query As String =
                "SELECT " &
                "students_id, " &
                "students_name, " &
                "parent_contact_number, " &
                "course, " &
                "year_level " &
                "FROM students " &
                "WHERE qr_code_data = ? " &
                "LIMIT 1"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@qr",
                    scannedQR.Trim()
                )


                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()


                    '==================================================
                    ' QR NOT FOUND
                    '==================================================
                    If Not reader.Read() Then

                        lblStudentName.Text =
                            "Student not found"

                        lblYearLevel.Text =
                            "-"

                        lblParentNumber.Text =
                            "-"

                        lblStatus.Text =
                            "INVALID QR"

                        lblAttendance.Text =
                            "The scanned QR Code is not registered."

                        lblTime.Text =
                            DateTime.Now.ToString(
                                "hh:mm:ss tt"
                            )

                        Return

                    End If


                    '==================================================
                    ' STUDENT INFORMATION
                    '==================================================
                    Dim studentId As Integer =
                        Convert.ToInt32(
                            reader(
                                "students_id"
                            )
                        )


                    Dim studentName As String =
                        reader(
                            "students_name"
                        ).ToString()


                    Dim yearLevel As String =
                        reader(
                            "year_level"
                        ).ToString()


                    Dim course As String =
                        reader(
                            "course"
                        ).ToString()


                    Dim parentNumber As String =
                        reader(
                            "parent_contact_number"
                        ).ToString()


                    '==================================================
                    ' DISPLAY STUDENT
                    '==================================================
                    lblStudentName.Text =
                        studentName


                    lblYearLevel.Text =
                        yearLevel &
                        " - " &
                        course


                    If String.IsNullOrWhiteSpace(
                        parentNumber
                    ) Then

                        lblParentNumber.Text =
                            "Not provided"

                    Else

                        lblParentNumber.Text =
                            parentNumber

                    End If


                    ' Must close reader before another
                    ' command uses the same connection.
                    reader.Close()


                    Await ProcessAttendanceAsync(
                        studentId,
                        studentName,
                        parentNumber
                    )

                End Using

            End Using


        Catch ex As Exception

            lblStatus.Text =
                "SCAN ERROR"

            lblAttendance.Text =
                "Unable to process this QR Code."


            MessageBox.Show(
                "Unable to process the QR Code. Please try again.",
                "Attendance Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


            Debug.WriteLine(
                "MarkAttendance Error: " &
                ex.Message
            )

        End Try

    End Function


    '==================================================
    ' PROCESS TIME-IN / TIME-OUT
    '==================================================
    Private Async Function ProcessAttendanceAsync(
        studentId As Integer,
        studentName As String,
        parentNumber As String
    ) As Task

        Try

            EnsureDatabaseConnection()


            Dim today As String =
                DateTime.Now.ToString(
                    "yyyy-MM-dd"
                )


            Dim currentTime As String =
                DateTime.Now.ToString(
                    "HH:mm:ss"
                )


            '==================================================
            ' CHECK OPEN ATTENDANCE RECORD
            '==================================================
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


                    '==================================================
                    ' OPEN RECORD FOUND = TIME OUT
                    '==================================================
                    If reader.Read() Then

                        Dim attendanceId As Integer =
                            Convert.ToInt32(
                                reader(
                                    "attendance_id"
                                )
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

                        End Using


                        '==================================================
                        ' DISPLAY TIME OUT
                        '==================================================
                        lblStatus.Text =
                            "TIME OUT"

                        lblAttendance.Text =
                            "Attendance recorded successfully!"

                        lblTime.Text =
                            DateTime.Now.ToString(
                                "hh:mm:ss tt"
                            )


                        LoadRecentAttendance()


                        '==================================================
                        ' SEND TIME-OUT SMS
                        '==================================================
                        Await SendSmsTimeOut(
                            studentId,
                            parentNumber,
                            studentName
                        )


                    Else

                        '==================================================
                        ' NO OPEN RECORD = TIME IN
                        '==================================================
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

                        End Using


                        '==================================================
                        ' DISPLAY TIME IN
                        '==================================================
                        lblStatus.Text =
                            "TIME IN"

                        lblAttendance.Text =
                            "Attendance recorded successfully!"

                        lblTime.Text =
                            DateTime.Now.ToString(
                                "hh:mm:ss tt"
                            )


                        LoadRecentAttendance()


                        '==================================================
                        ' SEND TIME-IN SMS
                        '==================================================
                        Await SendSmsTimeIn(
                            studentId,
                            parentNumber,
                            studentName
                        )

                    End If

                End Using

            End Using


        Catch ex As Exception

            lblStatus.Text =
                "SAVE ERROR"

            lblAttendance.Text =
                "Attendance could not be recorded."


            MessageBox.Show(
                "Failed to save attendance. Please try again.",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


            Debug.WriteLine(
                "Attendance Save Error: " &
                ex.Message
            )

        End Try

    End Function


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
                    If(
                        contactNumber,
                        ""
                    )
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
                "Attendance was saved, but the SMS log could not be recorded.",
                "SMS Log Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )


            Debug.WriteLine(
                "SMS Log Error: " &
                ex.Message
            )

        End Try

    End Sub


    '==================================================
    ' LOG OUT
    '==================================================
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


        If result =
           DialogResult.Yes Then

            Me.Close()

        End If

    End Sub

End Class