Imports System.Data.Odbc
Imports System.Data.SqlTypes

Public Class UcUserManagement

    Private selectedUserId As Integer = 0
    Private selectedUserRole As String = ""


    '==================================================
    ' USERCONTROL LOAD
    '==================================================
    Private Sub UserManagement_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If

            If cboRoleFilter.Items.Count > 0 Then
                cboRoleFilter.SelectedIndex = 0
            End If

            timerClock.Start()

            LoadUsers()
            UpdateSummary()
            ClearFields()
            UpdateDateTime()

        Catch ex As Exception

            MessageBox.Show(
                "User Management Error: " & ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' LOAD USERS
    '==================================================
    Private Sub LoadUsers()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT UserId, Username, Role " &
                "FROM login_table " &
                "WHERE 1=1 "


            ' SEARCH
            If txtSearchUser.Text.Trim() <> "" Then
                query &= "AND Username LIKE ? "
            End If


            ' ROLE FILTER
            If cboRoleFilter.Text <> "" AndAlso
               cboRoleFilter.Text <> "All" Then

                query &= "AND Role = ? "

            End If


            query &= "ORDER BY Username ASC"


            Using cmd As New OdbcCommand(query, con)

                If txtSearchUser.Text.Trim() <> "" Then

                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" & txtSearchUser.Text.Trim() & "%"
                    )

                End If


                If cboRoleFilter.Text <> "" AndAlso
                   cboRoleFilter.Text <> "All" Then

                    cmd.Parameters.AddWithValue(
                        "@role",
                        cboRoleFilter.Text
                    )

                End If


                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvUsers.DataSource = dt

            End Using


            dgvUsers.ClearSelection()

        Catch ex As Exception

            MessageBox.Show(
                "Load Users Error: " & ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' SUMMARY
    '==================================================
    Private Sub UpdateSummary()

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT " &
                "COUNT(*) AS total_count, " &
                "SUM(CASE WHEN Role = 'Admin' THEN 1 ELSE 0 END) AS admin_count, " &
                "SUM(CASE WHEN Role = 'Guard' THEN 1 ELSE 0 END) AS guard_count " &
                "FROM login_table"


            Using cmd As New OdbcCommand(query, con)

                Using reader As OdbcDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        lblTotalUsers.Text =
                            reader("total_count").ToString()


                        If IsDBNull(reader("admin_count")) Then
                            lblAdminCount.Text = "0"
                        Else
                            lblAdminCount.Text =
                                reader("admin_count").ToString()
                        End If


                        If IsDBNull(reader("guard_count")) Then
                            lblGuardCount.Text = "0"
                        Else
                            lblGuardCount.Text =
                                reader("guard_count").ToString()
                        End If

                    End If

                End Using

            End Using

        Catch ex As Exception

            lblTotalUsers.Text = "0"
            lblAdminCount.Text = "0"
            lblGuardCount.Text = "0"

        End Try

    End Sub


    '==================================================
    ' VALIDATE USER FORM
    '==================================================
    Private Function ValidateUserForm(
        requirePassword As Boolean
    ) As Boolean


        If txtUsername.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter a username.",
                "User Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtUsername.Focus()

            Return False

        End If


        If cboRole.SelectedIndex = -1 Then

            MessageBox.Show(
                "Please select a role.",
                "User Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            cboRole.Focus()

            Return False

        End If


        If requirePassword Then

            If txtPassword.Text = "" Then

                MessageBox.Show(
                    "Please enter a password.",
                    "User Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                txtPassword.Focus()

                Return False

            End If


            If txtConfirmPassword.Text = "" Then

                MessageBox.Show(
                    "Please confirm the password.",
                    "User Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                txtConfirmPassword.Focus()

                Return False

            End If

        End If


        ' If either password box has content,
        ' both must match.
        If txtPassword.Text <> "" OrElse
           txtConfirmPassword.Text <> "" Then

            If txtPassword.Text <> txtConfirmPassword.Text Then

                MessageBox.Show(
                    "Passwords do not match.",
                    "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtConfirmPassword.Focus()

                Return False

            End If

        End If


        Return True

    End Function


    '==================================================
    ' USERNAME EXISTS
    '==================================================
    Private Function UsernameExists(
        username As String,
        Optional excludeUserId As Integer = 0
    ) As Boolean

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT COUNT(*) " &
                "FROM login_table " &
                "WHERE Username = ? "


            If excludeUserId > 0 Then
                query &= "AND UserId <> ?"
            End If


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@username",
                    username
                )


                If excludeUserId > 0 Then

                    cmd.Parameters.AddWithValue(
                        "@id",
                        excludeUserId
                    )

                End If


                Dim count As Integer =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    )

                Return count > 0

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Username Check Error: " & ex.Message
            )

            Return True

        End Try

    End Function

    Private Sub UpdateButtonAppearance()

        ' ADD USER
        If btnAddUser.Enabled Then

            btnAddUser.BackColor = Color.FromArgb(103, 60, 36)
            btnAddUser.ForeColor = Color.White
            btnAddUser.Cursor = Cursors.Hand

        Else

            btnAddUser.BackColor = Color.FromArgb(220, 220, 220)
            btnAddUser.ForeColor = Color.Gray
            btnAddUser.Cursor = Cursors.No

        End If


        ' UPDATE
        If btnUpdate.Enabled Then

            btnUpdate.BackColor = Color.FromArgb(103, 60, 36)
            btnUpdate.ForeColor = Color.White
            btnUpdate.Cursor = Cursors.Hand

        Else

            btnUpdate.BackColor = Color.FromArgb(220, 220, 220)
            btnUpdate.ForeColor = Color.Gray
            btnUpdate.Cursor = Cursors.No

        End If


        ' DELETE
        If btnDelete.Enabled Then

            btnDelete.BackColor = Color.FromArgb(201, 75, 67)
            btnDelete.ForeColor = Color.White
            btnDelete.Cursor = Cursors.Hand

        Else

            btnDelete.BackColor = Color.FromArgb(220, 220, 220)
            btnDelete.ForeColor = Color.Gray
            btnDelete.Cursor = Cursors.No

        End If

    End Sub

    Private Sub Buttons_EnabledChanged(
    sender As Object,
    e As EventArgs
) Handles btnAddUser.EnabledChanged,
          btnUpdate.EnabledChanged,
          btnDelete.EnabledChanged

        UpdateButtonAppearance()

    End Sub


    '==================================================
    ' ADD USER
    '==================================================
    Private Sub btnAddUser_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAddUser.Click


        If Not ValidateUserForm(True) Then
            Return
        End If


        If UsernameExists(
            txtUsername.Text.Trim()
        ) Then

            MessageBox.Show(
                "This username already exists.",
                "Duplicate Username",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtUsername.Focus()

            Return

        End If


        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If
            Dim hashedPassword As String =
                HashPassword(
                    txtPassword.Text
                )


            Dim query As String =
                "INSERT INTO login_table " &
                "(Username, Password, Role) " &
                "VALUES (?, ?, ?)"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                "@username",
                txtUsername.Text.Trim()
            )

                cmd.Parameters.AddWithValue(
                "@password",
                hashedPassword
            )

                cmd.Parameters.AddWithValue(
                "@role",
                cboRole.Text
            )


                cmd.ExecuteNonQuery()

            End Using


            MessageBox.Show(
                "User added successfully.",
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadUsers()
            UpdateSummary()
            ClearFields()

        Catch ex As Exception

            MessageBox.Show(
                "Add User Error: " & ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' DATAGRIDVIEW CLICK
    '==================================================
    Private Sub dgvUsers_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvUsers.CellClick

        If e.RowIndex < 0 Then
            Return
        End If

        Try

            Dim row As DataGridViewRow =
            dgvUsers.Rows(e.RowIndex)

            Dim data As DataRowView =
            TryCast(row.DataBoundItem, DataRowView)

            If data Is Nothing Then
                MessageBox.Show("Unable to read selected user.")
                Return
            End If

            selectedUserId =
            Convert.ToInt32(data("UserId"))

            txtUsername.Text =
            data("Username").ToString()

            selectedUserRole =
            data("Role").ToString()

            cboRole.Text =
            selectedUserRole

            txtPassword.Clear()
            txtConfirmPassword.Clear()

            btnAddUser.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True

        Catch ex As Exception

            MessageBox.Show(
            "Cell Click Error: " & ex.Message,
            "User Management",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub


    '==================================================
    ' UPDATE USER
    '==================================================
    Private Sub btnUpdate_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpdate.Click


        If selectedUserId = 0 Then

            MessageBox.Show(
                "Please select a user first.",
                "Update User",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If Not ValidateUserForm(False) Then
            Return
        End If


        If UsernameExists(
            txtUsername.Text.Trim(),
            selectedUserId
        ) Then

            MessageBox.Show(
                "This username is already being used.",
                "Duplicate Username",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        '==================================================
        ' PROTECT LAST ADMIN ACCOUNT
        '==================================================
        If String.Equals(
            selectedUserRole,
            "Admin",
            StringComparison.OrdinalIgnoreCase
        ) AndAlso
        Not String.Equals(
            cboRole.Text,
            "Admin",
            StringComparison.OrdinalIgnoreCase
        ) Then

            If GetAdminCount() <= 1 Then

                MessageBox.Show(
                    "The last Admin account cannot be changed to Guard." &
                    vbCrLf &
                    vbCrLf &
                    "Create another Admin account first.",
                    "Cannot Change Admin Role",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                cboRole.Text = "Admin"
                cboRole.Focus()

                Return

            End If

        End If

        Dim changePassword As Boolean =
            txtPassword.Text <> ""


        Dim result As DialogResult =
            MessageBox.Show(
                "Update this user account?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If result = DialogResult.No Then
            Return
        End If


        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String


            If changePassword Then

                query =
                    "UPDATE login_table SET " &
                    "Username = ?, " &
                    "Password = ?, " &
                    "Role = ? " &
                    "WHERE UserId = ?"

            Else

                query =
                    "UPDATE login_table SET " &
                    "Username = ?, " &
                    "Role = ? " &
                    "WHERE UserId = ?"

            End If


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@username",
                    txtUsername.Text.Trim()
                )


                If changePassword Then

                    Dim hashedPassword As String =
                        HashPassword(
                            txtPassword.Text
                        )

                    cmd.Parameters.AddWithValue(
                        "@password",
                        hashedPassword
                    )

                End If


                cmd.Parameters.AddWithValue(
                    "@role",
                    cboRole.Text
                )

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedUserId
                )


                cmd.ExecuteNonQuery()

            End Using


            MessageBox.Show(
                "User updated successfully.",
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadUsers()
            UpdateSummary()
            ClearFields()

        Catch ex As Exception

            MessageBox.Show(
                "Update User Error: " & ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' GET ADMIN COUNT
    '==================================================
    Private Function GetAdminCount() As Integer

        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "SELECT COUNT(*) " &
                "FROM login_table " &
                "WHERE Role = 'Admin'"


            Using cmd As New OdbcCommand(query, con)

                Return Convert.ToInt32(
                    cmd.ExecuteScalar()
                )

            End Using

        Catch

            Return 0

        End Try

    End Function


    '==================================================
    ' DELETE USER
    '==================================================
    Private Sub btnDelete_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDelete.Click


        If selectedUserId = 0 Then

            MessageBox.Show(
                "Please select a user first.",
                "Delete User",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        ' Do not allow deleting final Admin account
        If selectedUserRole = "Admin" AndAlso
           GetAdminCount() <= 1 Then

            MessageBox.Show(
                "The last Admin account cannot be deleted." &
                vbCrLf &
                vbCrLf &
                "Create another Admin account first.",
                "Cannot Delete Admin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Dim result As DialogResult =
            MessageBox.Show(
                "Are you sure you want to delete the user '" &
                txtUsername.Text.Trim() &
                "'?" &
                vbCrLf &
                vbCrLf &
                "This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )


        If result = DialogResult.No Then
            Return
        End If


        Try

            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                vbConnection()
            End If


            Dim query As String =
                "DELETE FROM login_table " &
                "WHERE UserId = ?"


            Using cmd As New OdbcCommand(query, con)

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedUserId
                )

                cmd.ExecuteNonQuery()

            End Using


            MessageBox.Show(
                "User deleted successfully.",
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadUsers()
            UpdateSummary()
            ClearFields()

        Catch ex As Exception

            MessageBox.Show(
                "Delete User Error: " & ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' CLEAR BUTTON
    '==================================================
    Private Sub btnClear_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClear.Click

        ClearFields()

    End Sub


    '==================================================
    ' CLEAR FIELDS
    '==================================================
    Private Sub ClearFields()

        selectedUserId = 0
        selectedUserRole = ""

        txtUsername.Clear()

        txtPassword.Clear()
        txtConfirmPassword.Clear()

        cboRole.SelectedIndex = -1

        dgvUsers.ClearSelection()

        btnAddUser.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtUsername.Focus()

    End Sub


    '==================================================
    ' SEARCH
    '==================================================
    Private Sub txtSearchUser_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearchUser.TextChanged

        LoadUsers()

    End Sub


    '==================================================
    ' ROLE FILTER
    '==================================================
    Private Sub cboRoleFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboRoleFilter.SelectedIndexChanged

        LoadUsers()

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

End Class