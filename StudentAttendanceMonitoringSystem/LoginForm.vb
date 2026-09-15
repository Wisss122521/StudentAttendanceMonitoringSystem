Imports System.Data.Odbc
Imports Microsoft.Data.SqlClient

Public Class LoginForm


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbConnection()
    End Sub


    Private Count As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsername.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Some Fields Are Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim sql As String = "SELECT Username, Password, Role FROM login_table WHERE Username=?"
            Dim cmd As New OdbcCommand(sql, Module1.con)
            cmd.Parameters.AddWithValue("?", txtUsername.Text)

            Dim reader As OdbcDataReader = cmd.ExecuteReader()

            Dim isValid As Boolean = False
            Dim userRole As String = ""

            If reader.Read() Then
                Dim dbUsername As String = reader("Username").ToString()
                Dim dbPassword As String = reader("Password").ToString()

                If String.Equals(txtUsername.Text, dbUsername, StringComparison.Ordinal) AndAlso
               String.Equals(txtPassword.Text, dbPassword, StringComparison.Ordinal) Then
                    isValid = True
                    userRole = reader("Role").ToString()
                End If
            End If

            reader.Close()

            If isValid Then
                Count = 0

                If String.Equals(userRole, "Admin", StringComparison.OrdinalIgnoreCase) Then
                    Dim ad As New AdminForm()
                    ad.Show()
                Else
                    Dim ug As New UserForm()
                    ug.Show()
                End If

                Me.Hide()
            Else
                Count += 1
                MessageBox.Show("Username or Password Not Matched", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Count >= 3 Then
                    MessageBox.Show("Maximum attempt reached." & vbCrLf & "System will exit.", "System Exit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub
End Class
