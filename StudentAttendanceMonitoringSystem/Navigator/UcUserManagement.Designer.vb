<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcUserManagement

    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)

        Try

            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

        Finally

            MyBase.Dispose(disposing)

        End Try

    End Sub


    Private components As System.ComponentModel.IContainer


    'NOTE:
    'The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor unless necessary.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlUserInformation = New Panel()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAddUser = New Button()
        cboRole = New ComboBox()
        lblRole = New Label()
        txtConfirmPassword = New TextBox()
        lblConfirmPassword = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        pnlUserInformationHeader = New Panel()
        lblUserInformationTitle = New Label()
        pnlUserAccounts = New Panel()
        dgvUsers = New DataGridView()
        cboRoleFilter = New ComboBox()
        lblFilterRole = New Label()
        txtSearchUser = New TextBox()
        lblSearch = New Label()
        pnlUserAccountsHeader = New Panel()
        lblUserAccountsTitle = New Label()
        pnlSummary = New Panel()
        pnlGuardAccounts = New Panel()
        lblGuardCount = New Label()
        lblGuardAccountsTitle = New Label()
        pnlAdminAccounts = New Panel()
        lblAdminCount = New Label()
        lblAdminAccountsTitle = New Label()
        pnlTotalUsers = New Panel()
        lblTotalUsers = New Label()
        lblTotalUsersTitle = New Label()
        lblSummaryTitle = New Label()
        timerClock = New Timer(components)
        pnlHeader.SuspendLayout()
        pnlUserInformation.SuspendLayout()
        pnlUserInformationHeader.SuspendLayout()
        pnlUserAccounts.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        pnlUserAccountsHeader.SuspendLayout()
        pnlSummary.SuspendLayout()
        pnlGuardAccounts.SuspendLayout()
        pnlAdminAccounts.SuspendLayout()
        pnlTotalUsers.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlHeader.BorderStyle = BorderStyle.FixedSingle
        pnlHeader.Controls.Add(lblDateTime)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(18, 14)
        pnlHeader.Margin = New Padding(3, 2, 3, 2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(998, 68)
        pnlHeader.TabIndex = 0
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblDateTime.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblDateTime.Location = New Point(648, 24)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(324, 19)
        lblDateTime.TabIndex = 2
        lblDateTime.Text = "Date | Time"
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        lblSubtitle.Location = New Point(23, 44)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(263, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage system user accounts and access"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 24.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTitle.Location = New Point(19, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(318, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "User Management"
        ' 
        ' pnlUserInformation
        ' 
        pnlUserInformation.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlUserInformation.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlUserInformation.BorderStyle = BorderStyle.FixedSingle
        pnlUserInformation.Controls.Add(btnClear)
        pnlUserInformation.Controls.Add(btnDelete)
        pnlUserInformation.Controls.Add(btnUpdate)
        pnlUserInformation.Controls.Add(btnAddUser)
        pnlUserInformation.Controls.Add(cboRole)
        pnlUserInformation.Controls.Add(lblRole)
        pnlUserInformation.Controls.Add(txtConfirmPassword)
        pnlUserInformation.Controls.Add(lblConfirmPassword)
        pnlUserInformation.Controls.Add(txtPassword)
        pnlUserInformation.Controls.Add(lblPassword)
        pnlUserInformation.Controls.Add(txtUsername)
        pnlUserInformation.Controls.Add(lblUsername)
        pnlUserInformation.Controls.Add(pnlUserInformationHeader)
        pnlUserInformation.Location = New Point(18, 90)
        pnlUserInformation.Margin = New Padding(3, 2, 3, 2)
        pnlUserInformation.Name = "pnlUserInformation"
        pnlUserInformation.Size = New Size(320, 342)
        pnlUserInformation.TabIndex = 1
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(242), CByte(230), CByte(220))
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnClear.Location = New Point(210, 304)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(86, 26)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(201), CByte(75), CByte(67))
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(116, 304)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(86, 26)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(242), CByte(230), CByte(220))
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnUpdate.Location = New Point(22, 304)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(86, 26)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        btnAddUser.Cursor = Cursors.Hand
        btnAddUser.FlatAppearance.BorderSize = 0
        btnAddUser.FlatStyle = FlatStyle.Flat
        btnAddUser.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnAddUser.ForeColor = Color.White
        btnAddUser.Location = New Point(22, 266)
        btnAddUser.Margin = New Padding(3, 2, 3, 2)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(274, 30)
        btnAddUser.TabIndex = 9
        btnAddUser.Text = "Add User"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Font = New Font("Segoe UI", 10.0F)
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Admin", "Guard"})
        cboRole.Location = New Point(22, 229)
        cboRole.Margin = New Padding(3, 2, 3, 2)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(274, 25)
        cboRole.TabIndex = 8
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblRole.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblRole.Location = New Point(19, 210)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(44, 17)
        lblRole.TabIndex = 7
        lblRole.Text = "Role *"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Segoe UI", 10.0F)
        txtConfirmPassword.Location = New Point(22, 176)
        txtConfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(274, 25)
        txtConfirmPassword.TabIndex = 6
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblConfirmPassword.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblConfirmPassword.Location = New Point(19, 158)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(128, 17)
        lblConfirmPassword.TabIndex = 5
        lblConfirmPassword.Text = "Confirm Password *"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(22, 124)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(274, 25)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblPassword.Location = New Point(19, 105)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 17)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password *"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(22, 71)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(274, 25)
        txtUsername.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblUsername.Location = New Point(19, 52)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(79, 17)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username *"
        ' 
        ' pnlUserInformationHeader
        ' 
        pnlUserInformationHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlUserInformationHeader.Controls.Add(lblUserInformationTitle)
        pnlUserInformationHeader.Dock = DockStyle.Top
        pnlUserInformationHeader.Location = New Point(0, 0)
        pnlUserInformationHeader.Margin = New Padding(3, 2, 3, 2)
        pnlUserInformationHeader.Name = "pnlUserInformationHeader"
        pnlUserInformationHeader.Size = New Size(318, 38)
        pnlUserInformationHeader.TabIndex = 0
        ' 
        ' lblUserInformationTitle
        ' 
        lblUserInformationTitle.AutoSize = True
        lblUserInformationTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblUserInformationTitle.ForeColor = Color.White
        lblUserInformationTitle.Location = New Point(14, 8)
        lblUserInformationTitle.Name = "lblUserInformationTitle"
        lblUserInformationTitle.Size = New Size(134, 21)
        lblUserInformationTitle.TabIndex = 0
        lblUserInformationTitle.Text = "User Information"
        ' 
        ' pnlUserAccounts
        ' 
        pnlUserAccounts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlUserAccounts.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlUserAccounts.BorderStyle = BorderStyle.FixedSingle
        pnlUserAccounts.Controls.Add(dgvUsers)
        pnlUserAccounts.Controls.Add(cboRoleFilter)
        pnlUserAccounts.Controls.Add(lblFilterRole)
        pnlUserAccounts.Controls.Add(txtSearchUser)
        pnlUserAccounts.Controls.Add(lblSearch)
        pnlUserAccounts.Controls.Add(pnlUserAccountsHeader)
        pnlUserAccounts.Location = New Point(350, 90)
        pnlUserAccounts.Margin = New Padding(3, 2, 3, 2)
        pnlUserAccounts.Name = "pnlUserAccounts"
        pnlUserAccounts.Size = New Size(665, 342)
        pnlUserAccounts.TabIndex = 2
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AllowUserToResizeRows = False
        dgvUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.BorderStyle = BorderStyle.None
        dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.ColumnHeadersHeight = 42
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(50), CByte(35), CByte(28))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(52), CByte(32), CByte(23))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvUsers.Location = New Point(18, 109)
        dgvUsers.Margin = New Padding(3, 2, 3, 2)
        dgvUsers.MultiSelect = False
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersVisible = False
        dgvUsers.RowTemplate.Height = 38
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(626, 214)
        dgvUsers.TabIndex = 5
        ' 
        ' cboRoleFilter
        ' 
        cboRoleFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoleFilter.Font = New Font("Segoe UI", 10.0F)
        cboRoleFilter.FormattingEnabled = True
        cboRoleFilter.Items.AddRange(New Object() {"All", "Admin", "Guard"})
        cboRoleFilter.Location = New Point(464, 69)
        cboRoleFilter.Margin = New Padding(3, 2, 3, 2)
        cboRoleFilter.Name = "cboRoleFilter"
        cboRoleFilter.Size = New Size(180, 25)
        cboRoleFilter.TabIndex = 4
        ' 
        ' lblFilterRole
        ' 
        lblFilterRole.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFilterRole.AutoSize = True
        lblFilterRole.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblFilterRole.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblFilterRole.Location = New Point(464, 50)
        lblFilterRole.Name = "lblFilterRole"
        lblFilterRole.Size = New Size(59, 15)
        lblFilterRole.TabIndex = 3
        lblFilterRole.Text = "Filter Role"
        ' 
        ' txtSearchUser
        ' 
        txtSearchUser.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearchUser.BorderStyle = BorderStyle.FixedSingle
        txtSearchUser.Font = New Font("Segoe UI", 10.0F)
        txtSearchUser.Location = New Point(18, 69)
        txtSearchUser.Margin = New Padding(3, 2, 3, 2)
        txtSearchUser.Name = "txtSearchUser"
        txtSearchUser.Size = New Size(425, 25)
        txtSearchUser.TabIndex = 2
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblSearch.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblSearch.Location = New Point(16, 50)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(69, 15)
        lblSearch.TabIndex = 1
        lblSearch.Text = "Search User"
        ' 
        ' pnlUserAccountsHeader
        ' 
        pnlUserAccountsHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlUserAccountsHeader.Controls.Add(lblUserAccountsTitle)
        pnlUserAccountsHeader.Dock = DockStyle.Top
        pnlUserAccountsHeader.Location = New Point(0, 0)
        pnlUserAccountsHeader.Margin = New Padding(3, 2, 3, 2)
        pnlUserAccountsHeader.Name = "pnlUserAccountsHeader"
        pnlUserAccountsHeader.Size = New Size(663, 38)
        pnlUserAccountsHeader.TabIndex = 0
        ' 
        ' lblUserAccountsTitle
        ' 
        lblUserAccountsTitle.AutoSize = True
        lblUserAccountsTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblUserAccountsTitle.ForeColor = Color.White
        lblUserAccountsTitle.Location = New Point(14, 8)
        lblUserAccountsTitle.Name = "lblUserAccountsTitle"
        lblUserAccountsTitle.Size = New Size(115, 21)
        lblUserAccountsTitle.TabIndex = 0
        lblUserAccountsTitle.Text = "User Accounts"
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummary.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlSummary.BorderStyle = BorderStyle.FixedSingle
        pnlSummary.Controls.Add(pnlGuardAccounts)
        pnlSummary.Controls.Add(pnlAdminAccounts)
        pnlSummary.Controls.Add(pnlTotalUsers)
        pnlSummary.Controls.Add(lblSummaryTitle)
        pnlSummary.Location = New Point(18, 442)
        pnlSummary.Margin = New Padding(3, 2, 3, 2)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(998, 83)
        pnlSummary.TabIndex = 3
        ' 
        ' pnlGuardAccounts
        ' 
        pnlGuardAccounts.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlGuardAccounts.BackColor = Color.FromArgb(CByte(228), CByte(238), CByte(247))
        pnlGuardAccounts.Controls.Add(lblGuardCount)
        pnlGuardAccounts.Controls.Add(lblGuardAccountsTitle)
        pnlGuardAccounts.Location = New Point(674, 30)
        pnlGuardAccounts.Margin = New Padding(3, 2, 3, 2)
        pnlGuardAccounts.Name = "pnlGuardAccounts"
        pnlGuardAccounts.Size = New Size(302, 41)
        pnlGuardAccounts.TabIndex = 3
        ' 
        ' lblGuardCount
        ' 
        lblGuardCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGuardCount.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblGuardCount.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblGuardCount.Location = New Point(219, 5)
        lblGuardCount.Name = "lblGuardCount"
        lblGuardCount.Size = New Size(66, 30)
        lblGuardCount.TabIndex = 1
        lblGuardCount.Text = "0"
        lblGuardCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblGuardAccountsTitle
        ' 
        lblGuardAccountsTitle.AutoSize = True
        lblGuardAccountsTitle.Font = New Font("Segoe UI", 9.5F)
        lblGuardAccountsTitle.Location = New Point(12, 6)
        lblGuardAccountsTitle.Name = "lblGuardAccountsTitle"
        lblGuardAccountsTitle.Size = New Size(100, 17)
        lblGuardAccountsTitle.TabIndex = 0
        lblGuardAccountsTitle.Text = "Guard Accounts"
        ' 
        ' pnlAdminAccounts
        ' 
        pnlAdminAccounts.Anchor = AnchorStyles.Top
        pnlAdminAccounts.BackColor = Color.FromArgb(CByte(248), CByte(224), CByte(220))
        pnlAdminAccounts.Controls.Add(lblAdminCount)
        pnlAdminAccounts.Controls.Add(lblAdminAccountsTitle)
        pnlAdminAccounts.Location = New Point(346, 30)
        pnlAdminAccounts.Margin = New Padding(3, 2, 3, 2)
        pnlAdminAccounts.Name = "pnlAdminAccounts"
        pnlAdminAccounts.Size = New Size(302, 41)
        pnlAdminAccounts.TabIndex = 2
        ' 
        ' lblAdminCount
        ' 
        lblAdminCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblAdminCount.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblAdminCount.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblAdminCount.Location = New Point(219, 5)
        lblAdminCount.Name = "lblAdminCount"
        lblAdminCount.Size = New Size(66, 30)
        lblAdminCount.TabIndex = 1
        lblAdminCount.Text = "0"
        lblAdminCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblAdminAccountsTitle
        ' 
        lblAdminAccountsTitle.AutoSize = True
        lblAdminAccountsTitle.Font = New Font("Segoe UI", 9.5F)
        lblAdminAccountsTitle.Location = New Point(12, 6)
        lblAdminAccountsTitle.Name = "lblAdminAccountsTitle"
        lblAdminAccountsTitle.Size = New Size(101, 17)
        lblAdminAccountsTitle.TabIndex = 0
        lblAdminAccountsTitle.Text = "Admin Accounts"
        ' 
        ' pnlTotalUsers
        ' 
        pnlTotalUsers.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        pnlTotalUsers.Controls.Add(lblTotalUsers)
        pnlTotalUsers.Controls.Add(lblTotalUsersTitle)
        pnlTotalUsers.Location = New Point(18, 30)
        pnlTotalUsers.Margin = New Padding(3, 2, 3, 2)
        pnlTotalUsers.Name = "pnlTotalUsers"
        pnlTotalUsers.Size = New Size(302, 41)
        pnlTotalUsers.TabIndex = 1
        ' 
        ' lblTotalUsers
        ' 
        lblTotalUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalUsers.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTotalUsers.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTotalUsers.Location = New Point(219, 5)
        lblTotalUsers.Name = "lblTotalUsers"
        lblTotalUsers.Size = New Size(66, 30)
        lblTotalUsers.TabIndex = 1
        lblTotalUsers.Text = "0"
        lblTotalUsers.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalUsersTitle
        ' 
        lblTotalUsersTitle.AutoSize = True
        lblTotalUsersTitle.Font = New Font("Segoe UI", 9.5F)
        lblTotalUsersTitle.Location = New Point(12, 6)
        lblTotalUsersTitle.Name = "lblTotalUsersTitle"
        lblTotalUsersTitle.Size = New Size(73, 17)
        lblTotalUsersTitle.TabIndex = 0
        lblTotalUsersTitle.Text = "Total Users"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.AutoSize = True
        lblSummaryTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblSummaryTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblSummaryTitle.Location = New Point(16, 8)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Size = New Size(69, 19)
        lblSummaryTitle.TabIndex = 0
        lblSummaryTitle.Text = "Summary"
        ' 
        ' timerClock
        ' 
        timerClock.Interval = 1000
        ' 
        ' UserManagement
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Controls.Add(pnlSummary)
        Controls.Add(pnlUserAccounts)
        Controls.Add(pnlUserInformation)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UserManagement"
        Size = New Size(1032, 540)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlUserInformation.ResumeLayout(False)
        pnlUserInformation.PerformLayout()
        pnlUserInformationHeader.ResumeLayout(False)
        pnlUserInformationHeader.PerformLayout()
        pnlUserAccounts.ResumeLayout(False)
        pnlUserAccounts.PerformLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        pnlUserAccountsHeader.ResumeLayout(False)
        pnlUserAccountsHeader.PerformLayout()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        pnlGuardAccounts.ResumeLayout(False)
        pnlGuardAccounts.PerformLayout()
        pnlAdminAccounts.ResumeLayout(False)
        pnlAdminAccounts.PerformLayout()
        pnlTotalUsers.ResumeLayout(False)
        pnlTotalUsers.PerformLayout()
        ResumeLayout(False)

    End Sub


    '==================================================
    ' DECLARATIONS
    '==================================================

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label

    Friend WithEvents pnlUserInformation As Panel
    Friend WithEvents pnlUserInformationHeader As Panel
    Friend WithEvents lblUserInformationTitle As Label

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox

    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox

    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox

    Friend WithEvents lblRole As Label
    Friend WithEvents cboRole As ComboBox

    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents pnlUserAccounts As Panel
    Friend WithEvents pnlUserAccountsHeader As Panel
    Friend WithEvents lblUserAccountsTitle As Label

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchUser As TextBox

    Friend WithEvents lblFilterRole As Label
    Friend WithEvents cboRoleFilter As ComboBox

    Friend WithEvents dgvUsers As DataGridView

    Friend WithEvents colUserId As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colRole As DataGridViewTextBoxColumn

    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label

    Friend WithEvents pnlTotalUsers As Panel
    Friend WithEvents lblTotalUsersTitle As Label
    Friend WithEvents lblTotalUsers As Label

    Friend WithEvents pnlAdminAccounts As Panel
    Friend WithEvents lblAdminAccountsTitle As Label
    Friend WithEvents lblAdminCount As Label

    Friend WithEvents pnlGuardAccounts As Panel
    Friend WithEvents lblGuardAccountsTitle As Label
    Friend WithEvents lblGuardCount As Label

    Friend WithEvents timerClock As Timer

End Class