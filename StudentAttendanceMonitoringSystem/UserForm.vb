Imports System.Data.Odbc
Imports System.Data.SqlTypes
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class UserForm

    Private Sub UserForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

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

    Private Async Function SendSmsTimeOut(parentNumber As String, studentName As String) As Task

        Dim apiToken As String = "de73dee5c2e1e19b2984f9eba3b0084e9adb82a1"
        Dim apiUrl As String = "https://sms.iprogtech.com/api/v1/sms_messages?api_token=" & apiToken

        Dim message As String = "Hello, your child " & studentName & " has left the school."

        Try

            Dim jsonBody As String =
            "{""phone_number"":""" & parentNumber & """,""message"":""" & message & """}"

            Using client As New HttpClient()

                Dim content As New StringContent(jsonBody, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage =
                Await client.PostAsync(apiUrl, content)

                Dim responseBody As String =
                Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then

                    Console.WriteLine("SMS Sent: " & responseBody)

                Else

                    MessageBox.Show(
                    "Attendance saved, but SMS failed." &
                    vbCrLf &
                    responseBody,
                    "SMS Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                End If

            End Using

        Catch ex As HttpRequestException

            MessageBox.Show(
            "No internet connection.",
            "Network Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        Catch ex As Exception

            MessageBox.Show(
            "An error occurred while sending SMS.",
            "SMS Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Function

    Private Async Function SendSmsTimeIn(parentNumber As String, studentName As String) As Task

        Dim apiToken As String = "de73dee5c2e1e19b2984f9eba3b0084e9adb82a1"
        Dim apiUrl As String = "https://sms.iprogtech.com/api/v1/sms_messages?api_token=" & apiToken

        Dim message As String = "Hello, your child " & studentName & " has arrived at school."

        Try

            Dim jsonBody As String =
            "{""phone_number"":""" & parentNumber & """,""message"":""" & message & """}"

            Using client As New HttpClient()

                Dim content As New StringContent(jsonBody, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage =
                Await client.PostAsync(apiUrl, content)

                Dim responseBody As String =
                Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then

                    Console.WriteLine("SMS Sent: " & responseBody)

                Else

                    MessageBox.Show(
                    "Attendance saved, but SMS failed." &
                    vbCrLf &
                    responseBody,
                    "SMS Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                End If

            End Using

        Catch ex As HttpRequestException

            MessageBox.Show(
            "No internet connection.",
            "Network Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        Catch ex As Exception

            MessageBox.Show(
            "An error occurred while sending SMS.",
            "SMS Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Function

    Private Async Sub txtQRCode_KeyDown(
    sender As Object,
    e As KeyEventArgs
) Handles txtQrCode.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            Dim scannedQR As String = txtQrCode.Text.Trim()

            If scannedQR = "" Then
                lblStatus.Text = "Please scan QR Code."
                lblStudentName.Text = ""
                lblTime.Text = ""
                lblAttendance.Text = ""
                lblYearLevel.Text = ""
                lblParentNumber.Text = ""
                Return
            End If

            Await MarkAttendance(scannedQR)

            txtQrCode.Clear()
            txtQrCode.Focus()

        End If

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
                            Await SendSmsTimeOut(parentNumber, studentName)

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
                            Await SendSmsTimeIn(parentNumber, studentName)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim lg As New LoginForm()
        lg.Show()

    End Sub
End Class