Imports System.Data
Imports System.Data.Odbc
Imports System.Drawing

Public Class UcUserManagement

    Private selectedUserId As Integer = 0
    Private selectedUserRole As String = ""
    Private isLoading As Boolean = False


    '==================================================
    ' USERCONTROL LOAD
    '==================================================
    Private Sub UserManagement_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            isLoading = True

            EnsureDatabaseConnection()

            timerClock.Interval = 1000
            timerClock.Start()

            If cboRoleFilter.Items.Count > 0 Then

                cboRoleFilter.SelectedIndex = 0

            End If

            isLoading = False

            LoadUsers()
            UpdateSummary()
            ClearFields()
            UpdateDateTime()

        Catch ex As Exception

            MessageBox.Show(
                "User Management Error: " &
                ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            isLoading = False

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
    ' LOAD USERS
    '==================================================
    Private Sub LoadUsers()

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "UserId, " &
                "Username, " &
                "Role " &
                "FROM login_table " &
                "WHERE 1=1 "


            '==================================================
            ' SEARCH
            '==================================================
            If Not String.IsNullOrWhiteSpace(
                txtSearchUser.Text
            ) Then

                query &=
                    "AND Username LIKE ? "

            End If


            '==================================================
            ' ROLE FILTER
            '==================================================
            If cboRoleFilter.Text <> "" AndAlso
               cboRoleFilter.Text <> "All" Then

                query &=
                    "AND UPPER(Role) = UPPER(?) "

            End If


            query &=
                "ORDER BY Username ASC"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                If Not String.IsNullOrWhiteSpace(
                    txtSearchUser.Text
                ) Then

                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" &
                        txtSearchUser.Text.Trim() &
                        "%"
                    )

                End If


                If cboRoleFilter.Text <> "" AndAlso
                   cboRoleFilter.Text <> "All" Then

                    cmd.Parameters.AddWithValue(
                        "@role",
                        cboRoleFilter.Text.Trim()
                    )

                End If


                Using adapter As New OdbcDataAdapter(
                    cmd
                )

                    Dim dt As New DataTable()

                    adapter.Fill(dt)

                    dgvUsers.DataSource =
                        dt

                End Using

            End Using


            FormatUsersGrid()

            dgvUsers.ClearSelection()


        Catch ex As Exception

            MessageBox.Show(
                "Load Users Error: " &
                ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==================================================
    ' FORMAT USERS TABLE
    '==================================================
    Private Sub FormatUsersGrid()

        If dgvUsers Is Nothing OrElse
           dgvUsers.Columns.Count = 0 Then

            Return

        End If


        '==================================================
        ' GENERAL TABLE STYLE
        '==================================================
        dgvUsers.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvUsers.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvUsers.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvUsers.RowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvUsers.AlternatingRowsDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvUsers.RowHeadersVisible =
            False

        dgvUsers.AllowUserToResizeRows =
            False

        dgvUsers.RowTemplate.Height =
            30


        For Each row As DataGridViewRow In
            dgvUsers.Rows

            row.Height =
                30

        Next


        '==================================================
        ' COLUMN STYLE
        '==================================================
        For Each column As DataGridViewColumn In
            dgvUsers.Columns

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

                '==================================================
                ' USER ID
                '==================================================
                Case "userid",
                     "coluserid"

                    column.HeaderText =
                        "User ID"

                    column.FillWeight =
                        60


                '==================================================
                ' USERNAME
                '==================================================
                Case "username",
                     "colusername"

                    column.HeaderText =
                        "Username"

                    column.FillWeight =
                        130


                '==================================================
                ' ROLE
                '==================================================
                Case "role",
                     "colrole"

                    column.HeaderText =
                        "Role"

                    column.FillWeight =
                        80

            End Select


            column.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter

        Next

    End Sub


    '==================================================
    ' SUMMARY
    '==================================================
    Private Sub UpdateSummary()

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT " &
                "COUNT(*) AS total_count, " &
                "COALESCE(SUM(" &
                "CASE WHEN UPPER(Role) = 'ADMIN' " &
                "THEN 1 ELSE 0 END" &
                "), 0) AS admin_count, " &
                "COALESCE(SUM(" &
                "CASE WHEN UPPER(Role) = 'GUARD' " &
                "THEN 1 ELSE 0 END" &
                "), 0) AS guard_count " &
                "FROM login_table"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                Using reader As OdbcDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        lblTotalUsers.Text =
                            Convert.ToInt32(
                                reader(
                                    "total_count"
                                )
                            ).ToString()


                        lblAdminCount.Text =
                            Convert.ToInt32(
                                reader(
                                    "admin_count"
                                )
                            ).ToString()


                        lblGuardCount.Text =
                            Convert.ToInt32(
                                reader(
                                    "guard_count"
                                )
                            ).ToString()

                    Else

                        lblTotalUsers.Text =
                            "0"

                        lblAdminCount.Text =
                            "0"

                        lblGuardCount.Text =
                            "0"

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


        '==================================================
        ' USERNAME
        '==================================================
        If String.IsNullOrWhiteSpace(
            txtUsername.Text
        ) Then

            MessageBox.Show(
                "Please enter a username.",
                "User Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtUsername.Focus()

            Return False

        End If


        '==================================================
        ' ROLE
        '==================================================
        If cboRole.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(
               cboRole.Text
           ) Then

            MessageBox.Show(
                "Please select a role.",
                "User Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            cboRole.Focus()

            Return False

        End If


        '==================================================
        ' PASSWORD
        '
        ' New account = password required.
        ' Updating account = password optional.
        '
        ' If either password field has content,
        ' validate both fields.
        '==================================================
        Dim passwordEntered As Boolean =
            txtPassword.Text <> "" OrElse
            txtConfirmPassword.Text <> ""


        If requirePassword OrElse
           passwordEntered Then


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


            '==================================================
            ' MINIMUM PASSWORD LENGTH
            '==================================================
            If txtPassword.Text.Length < 8 Then

                MessageBox.Show(
                    "Password must contain at least 8 characters.",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtPassword.Focus()
                txtPassword.SelectAll()

                Return False

            End If


            '==================================================
            ' PASSWORD MATCH
            '==================================================
            If txtPassword.Text <>
               txtConfirmPassword.Text Then

                MessageBox.Show(
                    "Passwords do not match.",
                    "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtConfirmPassword.Focus()
                txtConfirmPassword.SelectAll()

                Return False

            End If

        End If


        Return True

    End Function


    '==================================================
    ' CHECK USERNAME EXISTS
    '==================================================
    Private Function UsernameExists(
        username As String,
        Optional excludeUserId As Integer = 0
    ) As Boolean

        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT COUNT(*) " &
                "FROM login_table " &
                "WHERE LOWER(TRIM(Username)) = " &
                "LOWER(TRIM(?)) "


            If excludeUserId > 0 Then

                query &=
                    "AND UserId <> ? "

            End If


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@username",
                    username.Trim()
                )


                If excludeUserId > 0 Then

                    cmd.Parameters.AddWithValue(
                        "@id",
                        excludeUserId
                    )

                End If


                Dim result As Object =
                    cmd.ExecuteScalar()


                If result Is Nothing OrElse
                   IsDBNull(result) Then

                    Return False

                End If


                Return Convert.ToInt32(
                    result
                ) > 0

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Username Check Error: " &
                ex.Message,
                "User Management",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            ' Sa database error, treat as existing
            ' para hindi makagawa ng duplicate accidentally.
            Return True

        End Try

    End Function


    '==================================================
    ' BUTTON APPEARANCE
    '==================================================
    Private Sub UpdateButtonAppearance()

        '==================================================
        ' ADD USER
        '==================================================
        If btnAddUser.Enabled Then

            btnAddUser.BackColor =
                Color.FromArgb(
                    103,
                    60,
                    36
                )

            btnAddUser.ForeColor =
                Color.White

            btnAddUser.Cursor =
                Cursors.Hand

        Else

            btnAddUser.BackColor =
                Color.FromArgb(
                    220,
                    220,
                    220
                )

            btnAddUser.ForeColor =
                Color.Gray

            btnAddUser.Cursor =
                Cursors.No

        End If


        '==================================================
        ' UPDATE
        '==================================================
        If btnUpdate.Enabled Then

            btnUpdate.BackColor =
                Color.FromArgb(
                    103,
                    60,
                    36
                )

            btnUpdate.ForeColor =
                Color.White

            btnUpdate.Cursor =
                Cursors.Hand

        Else

            btnUpdate.BackColor =
                Color.FromArgb(
                    220,
                    220,
                    220
                )

            btnUpdate.ForeColor =
                Color.Gray

            btnUpdate.Cursor =
                Cursors.No

        End If


        '==================================================
        ' DELETE
        '==================================================
        If btnDelete.Enabled Then

            btnDelete.BackColor =
                Color.FromArgb(
                    201,
                    75,
                    67
                )

            btnDelete.ForeColor =
                Color.White

            btnDelete.Cursor =
                Cursors.Hand

        Else

            btnDelete.BackColor =
                Color.FromArgb(
                    220,
                    220,
                    220
                )

            btnDelete.ForeColor =
                Color.Gray

            btnDelete.Cursor =
                Cursors.No

        End If

    End Sub


    '==================================================
    ' BUTTON ENABLED CHANGED
    '==================================================
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


        If Not ValidateUserForm(
            True
        ) Then

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

            EnsureDatabaseConnection()


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
                    cboRole.Text.Trim()
                )


                Dim rowsAffected As Integer =
                    cmd.ExecuteNonQuery()


                If rowsAffected <= 0 Then

                    Throw New Exception(
                        "The user account was not created."
                    )

                End If

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
                "Add User Error: " &
                ex.Message,
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


        If e.RowIndex >=
           dgvUsers.Rows.Count Then

            Return

        End If


        Try

            Dim row As DataGridViewRow =
                dgvUsers.Rows(
                    e.RowIndex
                )


            If row Is Nothing Then

                Return

            End If


            Dim data As DataRowView =
                TryCast(
                    row.DataBoundItem,
                    DataRowView
                )


            If data Is Nothing Then

                MessageBox.Show(
                    "Unable to read the selected user.",
                    "User Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            If IsDBNull(
                data(
                    "UserId"
                )
            ) Then

                Return

            End If


            selectedUserId =
                Convert.ToInt32(
                    data(
                        "UserId"
                    )
                )


            txtUsername.Text =
                If(
                    IsDBNull(
                        data(
                            "Username"
                        )
                    ),
                    "",
                    data(
                        "Username"
                    ).ToString()
                )


            selectedUserRole =
                If(
                    IsDBNull(
                        data(
                            "Role"
                        )
                    ),
                    "",
                    data(
                        "Role"
                    ).ToString()
                )


            cboRole.Text =
                selectedUserRole


            '==================================================
            ' PASSWORD IS NEVER LOADED INTO FORM
            '==================================================
            txtPassword.Clear()
            txtConfirmPassword.Clear()


            btnAddUser.Enabled =
                False

            btnUpdate.Enabled =
                True

            btnDelete.Enabled =
                True


        Catch ex As Exception

            MessageBox.Show(
                "User Selection Error: " &
                ex.Message,
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


        If selectedUserId <= 0 Then

            MessageBox.Show(
                "Please select a user first.",
                "Update User",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If Not ValidateUserForm(
            False
        ) Then

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

            txtUsername.Focus()

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
            cboRole.Text.Trim(),
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

                cboRole.Text =
                    "Admin"

                cboRole.Focus()

                Return

            End If

        End If


        Dim changePassword As Boolean =
            Not String.IsNullOrEmpty(
                txtPassword.Text
            )


        Dim result As DialogResult =
            MessageBox.Show(
                "Update this user account?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If result <> DialogResult.Yes Then

            Return

        End If


        Try

            EnsureDatabaseConnection()


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


            Using cmd As New OdbcCommand(
                query,
                con
            )

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
                    cboRole.Text.Trim()
                )

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedUserId
                )


                Dim rowsAffected As Integer =
                    cmd.ExecuteNonQuery()


                If rowsAffected <= 0 Then

                    Throw New Exception(
                        "The user account was not found or no changes were made."
                    )

                End If

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
                "Update User Error: " &
                ex.Message,
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

            EnsureDatabaseConnection()


            Dim query As String =
                "SELECT COUNT(*) " &
                "FROM login_table " &
                "WHERE UPPER(Role) = 'ADMIN'"


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


                Return Convert.ToInt32(
                    result
                )

            End Using


        Catch ex As Exception

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


        If selectedUserId <= 0 Then

            MessageBox.Show(
                "Please select a user first.",
                "Delete User",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        '==================================================
        ' DO NOT ALLOW DELETING FINAL ADMIN ACCOUNT
        '==================================================
        If String.Equals(
            selectedUserRole,
            "Admin",
            StringComparison.OrdinalIgnoreCase
        ) AndAlso
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


        If result <> DialogResult.Yes Then

            Return

        End If


        Try

            EnsureDatabaseConnection()


            Dim query As String =
                "DELETE FROM login_table " &
                "WHERE UserId = ?"


            Using cmd As New OdbcCommand(
                query,
                con
            )

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedUserId
                )


                Dim rowsAffected As Integer =
                    cmd.ExecuteNonQuery()


                If rowsAffected <= 0 Then

                    Throw New Exception(
                        "The user account was not found."
                    )

                End If

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
                "Delete User Error: " &
                ex.Message,
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

        cboRole.SelectedIndex =
            -1


        If dgvUsers IsNot Nothing Then

            dgvUsers.ClearSelection()

        End If


        btnAddUser.Enabled =
            True

        btnUpdate.Enabled =
            False

        btnDelete.Enabled =
            False


        UpdateButtonAppearance()


        If txtUsername.CanFocus Then

            txtUsername.Focus()

        End If

    End Sub


    '==================================================
    ' SEARCH
    '==================================================
    Private Sub txtSearchUser_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearchUser.TextChanged


        If isLoading Then

            Return

        End If


        LoadUsers()

    End Sub


    '==================================================
    ' ROLE FILTER
    '==================================================
    Private Sub cboRoleFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboRoleFilter.SelectedIndexChanged


        If isLoading Then

            Return

        End If


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