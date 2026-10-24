Imports System.Data
Imports System.Data.Odbc

Public Class LoginForm

    Private loginAttempts As Integer = 0
    Private Const MaxLoginAttempts As Integer = 3


    '==================================================
    ' LOGIN FORM LOAD
    '==================================================
    Private Sub LoginForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            If Connector.con Is Nothing OrElse
               Connector.con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            lblLoginMessage.Text = ""

            txtUsername.Clear()
            txtPassword.Clear()

            txtUsername.Focus()


        Catch ex As Exception

            ShowLoginError(
                "Unable to connect to the database."
            )

        End Try

    End Sub


    '==================================================
    ' LOGIN FORM CLOSED
    '==================================================
    Private Sub LoginForm_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles Me.FormClosed

        Application.Exit()

    End Sub


    '==================================================
    ' LOGIN BUTTON
    '==================================================
    Private Sub btnLogin_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogin.Click

        lblLoginMessage.Text = ""


        '==============================================
        ' GET VALUES
        '==============================================
        Dim username As String =
            txtUsername.Text.Trim()

        Dim password As String =
            txtPassword.Text


        '==============================================
        ' VALIDATION
        '==============================================
        If username = "" AndAlso password = "" Then

            ShowLoginError(
                "Please enter your username and password."
            )

            txtUsername.Focus()

            Return

        End If


        If username = "" Then

            ShowLoginError(
                "Please enter your username."
            )

            txtUsername.Focus()

            Return

        End If


        If password = "" Then

            ShowLoginError(
                "Please enter your password."
            )

            txtPassword.Focus()

            Return

        End If


        ' Prevent multiple clicks while checking
        btnLogin.Enabled = False


        Try

            '==============================================
            ' CHECK CONNECTION
            '==============================================
            If Connector.con Is Nothing OrElse
               Connector.con.State <> ConnectionState.Open Then

                vbConnection()

            End If


            '==============================================
            ' LOGIN QUERY
            '==============================================
            Dim sql As String =
                "SELECT Username, Password, Role " &
                "FROM login_table " &
                "WHERE Username = ? " &
                "LIMIT 1"


            Using cmd As New OdbcCommand(
                sql,
                Connector.con
            )

                cmd.Parameters.Add(
                    "@username",
                    OdbcType.VarChar,
                    50
                ).Value = username


                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()


                    '======================================
                    ' USER NOT FOUND
                    '======================================
                    If Not reader.Read() Then

                        LoginFailed()

                        Return

                    End If


                    Dim dbUsername As String =
                        reader("Username").ToString()

                    Dim dbPassword As String =
                        reader("Password").ToString()

                    Dim userRole As String =
                        reader("Role").ToString().Trim()


                    '======================================
                    ' CHECK PASSWORD
                    '======================================
                    Dim usernameCorrect As Boolean =
                        String.Equals(
                            username,
                            dbUsername,
                            StringComparison.Ordinal
                        )


                    Dim passwordCorrect As Boolean =
                    VerifyPassword(
                        password,
                        dbPassword
                    )


                    If Not usernameCorrect OrElse
                       Not passwordCorrect Then

                        LoginFailed()

                        Return

                    End If

                    '==============================================
                    ' UPGRADE OLD PLAINTEXT PASSWORD
                    '==============================================
                    If Not IsHashedPassword(dbPassword) Then

                        UpgradePasswordHash(
                        dbUsername,
                        password
                    )

                    End If


                    '======================================
                    ' LOGIN SUCCESS
                    '======================================
                    loginAttempts = 0

                    lblLoginMessage.ForeColor =
                        Color.FromArgb(
                            32,
                            110,
                            55
                        )

                    lblLoginMessage.Text =
                        "Login successful."


                    ' Save role before reader closes
                    Dim role As String =
                        userRole


                    '======================================
                    ' OPEN CORRECT FORM
                    '======================================
                    OpenUserForm(role)

                End Using

            End Using


        Catch ex As OdbcException

            ShowLoginError(
                "Database connection error. Please try again."
            )

            MessageBox.Show(
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Catch ex As Exception

            ShowLoginError(
                "An unexpected error occurred."
            )

            MessageBox.Show(
                ex.Message,
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Finally

            btnLogin.Enabled = True
            btnLogin.Text = "LOGIN"

        End Try

    End Sub


    '==================================================
    ' LOGIN FAILED
    '==================================================
    Private Sub LoginFailed()

        loginAttempts += 1


        Dim remainingAttempts As Integer =
            MaxLoginAttempts - loginAttempts


        txtPassword.Clear()


        If remainingAttempts > 0 Then

            ShowLoginError(
                "Invalid username or password. " &
                remainingAttempts.ToString() &
                " attempt(s) remaining."
            )

            txtPassword.Focus()

        Else

            ShowLoginError(
                "Maximum login attempts reached."
            )


            MessageBox.Show(
                "Maximum login attempts reached." &
                vbCrLf &
                "The system will now close.",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


            Application.Exit()

        End If

    End Sub


    '==================================================
    ' OPEN ADMIN / USER FORM
    '==================================================
    Private Sub OpenUserForm(
        role As String
    )

        ' Hide login while dashboard is open
        Me.Hide()


        Try

            If String.Equals(
                role,
                "Admin",
                StringComparison.OrdinalIgnoreCase
            ) Then

                Using admin As New AdminForm()

                    admin.ShowDialog()

                End Using


            ElseIf String.Equals(
                role,
                "Guard",
                StringComparison.OrdinalIgnoreCase
            ) Then

                Using user As New UserForm()

                    user.ShowDialog()

                End Using


            Else

                MessageBox.Show(
                    "This account has an unknown role: " &
                    role,
                    "Invalid Role",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If


        Finally

            '==============================================
            ' RETURN TO LOGIN AFTER LOGOUT
            '==============================================
            Me.Show()

            txtUsername.Clear()
            txtPassword.Clear()

            lblLoginMessage.Text = ""

            txtUsername.Focus()

        End Try

    End Sub


    '==================================================
    ' DISPLAY LOGIN ERROR
    '==================================================
    Private Sub ShowLoginError(
        message As String
    )

        lblLoginMessage.ForeColor =
            Color.FromArgb(
                190,
                50,
                45
            )

        lblLoginMessage.Text =
            message

    End Sub


    '==================================================
    ' CLEAR ERROR WHEN USER TYPES
    '==================================================
    Private Sub LoginFields_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtUsername.TextChanged,
              txtPassword.TextChanged

        lblLoginMessage.Text = ""

    End Sub

    '==================================================
    ' UPGRADE OLD PASSWORD TO HASH
    '==================================================
    Private Sub UpgradePasswordHash(
        username As String,
        plainPassword As String
    )

        Try

            Dim hashedPassword As String =
                HashPassword(
                    plainPassword
                )


            Dim query As String =
                "UPDATE login_table " &
                "SET Password = ? " &
                "WHERE Username = ?"


            Using cmd As New OdbcCommand(
                query,
                Connector.con
            )

                cmd.Parameters.Add(
                    "@password",
                    OdbcType.VarChar,
                    255
                ).Value = hashedPassword


                cmd.Parameters.Add(
                    "@username",
                    OdbcType.VarChar,
                    50
                ).Value = username


                cmd.ExecuteNonQuery()

            End Using


        Catch ex As Exception

            ' Do not block login if migration fails.
            ' The user already entered the correct password.
            Debug.WriteLine(
                "Password migration failed: " &
                ex.Message
            )

        End Try

    End Sub

End Class