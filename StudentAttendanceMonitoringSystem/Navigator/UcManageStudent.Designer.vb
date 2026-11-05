<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcManageStudent

    Inherits System.Windows.Forms.UserControl


    '==================================================
    ' DISPOSE
    '==================================================
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


    '==================================================
    ' INITIALIZE COMPONENT
    '==================================================
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlStudentInfo = New Panel()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        txtParentContact = New TextBox()
        lblParentContact = New Label()
        cboCourse = New ComboBox()
        lblCourse = New Label()
        cboYearLevel = New ComboBox()
        lblYearLevel = New Label()
        txtStudentName = New TextBox()
        lblStudentName = New Label()
        pnlStudentInfoHeader = New Panel()
        lblStudentInfoTitle = New Label()
        pnlStudents = New Panel()
        dgvStudents = New DataGridView()
        cboFilterCourse = New ComboBox()
        lblFilterCourse = New Label()
        cboFilterYear = New ComboBox()
        lblFilterYear = New Label()
        txtSearch = New TextBox()
        lblSearch = New Label()
        pnlStudentsHeader = New Panel()
        lblStudentsTitle = New Label()
        pnlSummary = New Panel()
        btnImportStudents = New Button()
        lblImportDescription = New Label()
        lblImportTitle = New Label()
        pnlTotalStudents = New Panel()
        picTotalStudentsIcon = New PictureBox()
        lblTotalStudents = New Label()
        lblTotalStudentsTitle = New Label()
        lblSummaryTitle = New Label()
        timerClock = New Timer(components)
        lblexname = New Label()
        lblexnumber = New Label()
        pnlHeader.SuspendLayout()
        pnlStudentInfo.SuspendLayout()
        pnlStudentInfoHeader.SuspendLayout()
        pnlStudents.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudentsHeader.SuspendLayout()
        pnlSummary.SuspendLayout()
        pnlTotalStudents.SuspendLayout()
        CType(picTotalStudentsIcon, ComponentModel.ISupportInitialize).BeginInit()
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
        lblDateTime.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
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
        lblSubtitle.Font = New Font("Segoe UI", 10F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        lblSubtitle.Location = New Point(23, 44)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(334, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Add, update, delete and manage student information"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 24F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTitle.Location = New Point(19, 6)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(300, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manage Students"
        ' 
        ' pnlStudentInfo
        ' 
        pnlStudentInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlStudentInfo.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlStudentInfo.BorderStyle = BorderStyle.FixedSingle
        pnlStudentInfo.Controls.Add(lblexnumber)
        pnlStudentInfo.Controls.Add(lblexname)
        pnlStudentInfo.Controls.Add(btnClear)
        pnlStudentInfo.Controls.Add(btnDelete)
        pnlStudentInfo.Controls.Add(btnUpdate)
        pnlStudentInfo.Controls.Add(btnSave)
        pnlStudentInfo.Controls.Add(txtParentContact)
        pnlStudentInfo.Controls.Add(lblParentContact)
        pnlStudentInfo.Controls.Add(cboCourse)
        pnlStudentInfo.Controls.Add(lblCourse)
        pnlStudentInfo.Controls.Add(cboYearLevel)
        pnlStudentInfo.Controls.Add(lblYearLevel)
        pnlStudentInfo.Controls.Add(txtStudentName)
        pnlStudentInfo.Controls.Add(lblStudentName)
        pnlStudentInfo.Controls.Add(pnlStudentInfoHeader)
        pnlStudentInfo.Location = New Point(18, 90)
        pnlStudentInfo.Margin = New Padding(3, 2, 3, 2)
        pnlStudentInfo.Name = "pnlStudentInfo"
        pnlStudentInfo.Size = New Size(320, 422)
        pnlStudentInfo.TabIndex = 1
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(242), CByte(230), CByte(220))
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnClear.Location = New Point(207, 340)
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
        btnDelete.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(113, 340)
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
        btnUpdate.Enabled = False
        btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnUpdate.Location = New Point(19, 340)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(86, 26)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnSave.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(19, 302)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(274, 30)
        btnSave.TabIndex = 9
        btnSave.Text = "Add Student"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtParentContact
        ' 
        txtParentContact.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtParentContact.BorderStyle = BorderStyle.FixedSingle
        txtParentContact.Font = New Font("Segoe UI", 10F)
        txtParentContact.Location = New Point(22, 246)
        txtParentContact.MaxLength = 11
        txtParentContact.Name = "txtParentContact"
        txtParentContact.Size = New Size(274, 25)
        txtParentContact.TabIndex = 8
        txtParentContact.Text = "09"
        ' 
        ' lblParentContact
        ' 
        lblParentContact.AutoSize = True
        lblParentContact.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblParentContact.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblParentContact.Location = New Point(19, 227)
        lblParentContact.Name = "lblParentContact"
        lblParentContact.Size = New Size(153, 17)
        lblParentContact.TabIndex = 7
        lblParentContact.Text = "Parent Contact Number"
        ' 
        ' cboCourse
        ' 
        cboCourse.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.Font = New Font("Segoe UI", 10F)
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(22, 193)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(274, 25)
        cboCourse.TabIndex = 6
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblCourse.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblCourse.Location = New Point(19, 175)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(60, 17)
        lblCourse.TabIndex = 5
        lblCourse.Text = "Course *"
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboYearLevel.Font = New Font("Segoe UI", 10F)
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Location = New Point(22, 141)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(274, 25)
        cboYearLevel.TabIndex = 4
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblYearLevel.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblYearLevel.Location = New Point(19, 122)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(78, 17)
        lblYearLevel.TabIndex = 3
        lblYearLevel.Text = "Year Level *"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtStudentName.BorderStyle = BorderStyle.FixedSingle
        txtStudentName.Font = New Font("Segoe UI", 10F)
        txtStudentName.Location = New Point(22, 71)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(274, 25)
        txtStudentName.TabIndex = 2
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStudentName.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblStudentName.Location = New Point(19, 52)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(106, 17)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "Student Name *"
        ' 
        ' pnlStudentInfoHeader
        ' 
        pnlStudentInfoHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlStudentInfoHeader.Controls.Add(lblStudentInfoTitle)
        pnlStudentInfoHeader.Dock = DockStyle.Top
        pnlStudentInfoHeader.Location = New Point(0, 0)
        pnlStudentInfoHeader.Name = "pnlStudentInfoHeader"
        pnlStudentInfoHeader.Size = New Size(318, 38)
        pnlStudentInfoHeader.TabIndex = 0
        ' 
        ' lblStudentInfoTitle
        ' 
        lblStudentInfoTitle.AutoSize = True
        lblStudentInfoTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblStudentInfoTitle.ForeColor = Color.White
        lblStudentInfoTitle.Location = New Point(14, 8)
        lblStudentInfoTitle.Name = "lblStudentInfoTitle"
        lblStudentInfoTitle.Size = New Size(159, 21)
        lblStudentInfoTitle.TabIndex = 0
        lblStudentInfoTitle.Text = "Student Information"
        ' 
        ' pnlStudents
        ' 
        pnlStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStudents.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlStudents.BorderStyle = BorderStyle.FixedSingle
        pnlStudents.Controls.Add(dgvStudents)
        pnlStudents.Controls.Add(cboFilterCourse)
        pnlStudents.Controls.Add(lblFilterCourse)
        pnlStudents.Controls.Add(cboFilterYear)
        pnlStudents.Controls.Add(lblFilterYear)
        pnlStudents.Controls.Add(txtSearch)
        pnlStudents.Controls.Add(lblSearch)
        pnlStudents.Controls.Add(pnlStudentsHeader)
        pnlStudents.Location = New Point(350, 90)
        pnlStudents.Name = "pnlStudents"
        pnlStudents.Size = New Size(665, 422)
        pnlStudents.TabIndex = 2
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AllowUserToResizeRows = False
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.ColumnHeadersHeight = 42
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(50), CByte(35), CByte(28))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(52), CByte(32), CByte(23))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
        dgvStudents.EnableHeadersVisualStyles = False
        dgvStudents.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvStudents.Location = New Point(18, 109)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowTemplate.Height = 38
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(626, 294)
        dgvStudents.TabIndex = 7
        ' 
        ' cboFilterCourse
        ' 
        cboFilterCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterCourse.Font = New Font("Segoe UI", 10F)
        cboFilterCourse.FormattingEnabled = True
        cboFilterCourse.Location = New Point(464, 69)
        cboFilterCourse.Name = "cboFilterCourse"
        cboFilterCourse.Size = New Size(180, 25)
        cboFilterCourse.TabIndex = 6
        ' 
        ' lblFilterCourse
        ' 
        lblFilterCourse.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblFilterCourse.AutoSize = True
        lblFilterCourse.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblFilterCourse.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblFilterCourse.Location = New Point(464, 50)
        lblFilterCourse.Name = "lblFilterCourse"
        lblFilterCourse.Size = New Size(43, 15)
        lblFilterCourse.TabIndex = 5
        lblFilterCourse.Text = "Course"
        ' 
        ' cboFilterYear
        ' 
        cboFilterYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterYear.Font = New Font("Segoe UI", 10F)
        cboFilterYear.FormattingEnabled = True
        cboFilterYear.Location = New Point(281, 69)
        cboFilterYear.Name = "cboFilterYear"
        cboFilterYear.Size = New Size(165, 25)
        cboFilterYear.TabIndex = 4
        ' 
        ' lblFilterYear
        ' 
        lblFilterYear.AutoSize = True
        lblFilterYear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblFilterYear.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblFilterYear.Location = New Point(281, 50)
        lblFilterYear.Name = "lblFilterYear"
        lblFilterYear.Size = New Size(59, 15)
        lblFilterYear.TabIndex = 3
        lblFilterYear.Text = "Year Level"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(18, 69)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(245, 25)
        txtSearch.TabIndex = 2
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblSearch.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblSearch.Location = New Point(16, 50)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(88, 15)
        lblSearch.TabIndex = 1
        lblSearch.Text = "Search Student"
        ' 
        ' pnlStudentsHeader
        ' 
        pnlStudentsHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlStudentsHeader.Controls.Add(lblStudentsTitle)
        pnlStudentsHeader.Dock = DockStyle.Top
        pnlStudentsHeader.Location = New Point(0, 0)
        pnlStudentsHeader.Name = "pnlStudentsHeader"
        pnlStudentsHeader.Size = New Size(663, 38)
        pnlStudentsHeader.TabIndex = 0
        ' 
        ' lblStudentsTitle
        ' 
        lblStudentsTitle.AutoSize = True
        lblStudentsTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblStudentsTitle.ForeColor = Color.White
        lblStudentsTitle.Location = New Point(14, 8)
        lblStudentsTitle.Name = "lblStudentsTitle"
        lblStudentsTitle.Size = New Size(97, 21)
        lblStudentsTitle.TabIndex = 0
        lblStudentsTitle.Text = "Student List"
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummary.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlSummary.BorderStyle = BorderStyle.FixedSingle
        pnlSummary.Controls.Add(btnImportStudents)
        pnlSummary.Controls.Add(lblImportDescription)
        pnlSummary.Controls.Add(lblImportTitle)
        pnlSummary.Controls.Add(pnlTotalStudents)
        pnlSummary.Controls.Add(lblSummaryTitle)
        pnlSummary.Location = New Point(18, 518)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(998, 103)
        pnlSummary.TabIndex = 3
        ' 
        ' btnImportStudents
        ' 
        btnImportStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnImportStudents.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        btnImportStudents.Cursor = Cursors.Hand
        btnImportStudents.FlatAppearance.BorderSize = 0
        btnImportStudents.FlatStyle = FlatStyle.Flat
        btnImportStudents.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnImportStudents.ForeColor = Color.White
        btnImportStudents.Location = New Point(752, 30)
        btnImportStudents.Name = "btnImportStudents"
        btnImportStudents.Size = New Size(220, 41)
        btnImportStudents.TabIndex = 4
        btnImportStudents.Text = "Import Students from Excel"
        btnImportStudents.UseVisualStyleBackColor = False
        ' 
        ' lblImportDescription
        ' 
        lblImportDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblImportDescription.AutoSize = True
        lblImportDescription.Font = New Font("Segoe UI", 8F)
        lblImportDescription.ForeColor = Color.DimGray
        lblImportDescription.Location = New Point(554, 53)
        lblImportDescription.Name = "lblImportDescription"
        lblImportDescription.Size = New Size(192, 13)
        lblImportDescription.TabIndex = 3
        lblImportDescription.Text = "Import multiple students from Excel."
        ' 
        ' lblImportTitle
        ' 
        lblImportTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblImportTitle.AutoSize = True
        lblImportTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblImportTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblImportTitle.Location = New Point(554, 34)
        lblImportTitle.Name = "lblImportTitle"
        lblImportTitle.Size = New Size(132, 17)
        lblImportTitle.TabIndex = 2
        lblImportTitle.Text = "Bulk Student Import"
        ' 
        ' pnlTotalStudents
        ' 
        pnlTotalStudents.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        pnlTotalStudents.Controls.Add(picTotalStudentsIcon)
        pnlTotalStudents.Controls.Add(lblTotalStudents)
        pnlTotalStudents.Controls.Add(lblTotalStudentsTitle)
        pnlTotalStudents.Location = New Point(18, 26)
        pnlTotalStudents.Name = "pnlTotalStudents"
        pnlTotalStudents.Size = New Size(302, 68)
        pnlTotalStudents.TabIndex = 1
        ' 
        ' picTotalStudentsIcon
        ' 
        picTotalStudentsIcon.BackColor = Color.Transparent
        picTotalStudentsIcon.Image = My.Resources.Resources.dashboard_students
        picTotalStudentsIcon.Location = New Point(5, 5)
        picTotalStudentsIcon.Name = "picTotalStudentsIcon"
        picTotalStudentsIcon.Size = New Size(67, 59)
        picTotalStudentsIcon.SizeMode = PictureBoxSizeMode.Zoom
        picTotalStudentsIcon.TabIndex = 2
        picTotalStudentsIcon.TabStop = False
        ' 
        ' lblTotalStudents
        ' 
        lblTotalStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalStudents.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTotalStudents.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTotalStudents.Location = New Point(192, 20)
        lblTotalStudents.Name = "lblTotalStudents"
        lblTotalStudents.Size = New Size(66, 30)
        lblTotalStudents.TabIndex = 1
        lblTotalStudents.Text = "0"
        lblTotalStudents.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalStudentsTitle
        ' 
        lblTotalStudentsTitle.AutoSize = True
        lblTotalStudentsTitle.Font = New Font("Segoe UI", 9.5F)
        lblTotalStudentsTitle.ForeColor = Color.FromArgb(CByte(75), CByte(54), CByte(43))
        lblTotalStudentsTitle.Location = New Point(78, 24)
        lblTotalStudentsTitle.Name = "lblTotalStudentsTitle"
        lblTotalStudentsTitle.Size = New Size(90, 17)
        lblTotalStudentsTitle.TabIndex = 0
        lblTotalStudentsTitle.Text = "Total Students"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.AutoSize = True
        lblSummaryTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblSummaryTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblSummaryTitle.Location = New Point(16, 4)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Size = New Size(69, 19)
        lblSummaryTitle.TabIndex = 0
        lblSummaryTitle.Text = "Summary"
        ' 
        ' timerClock
        ' 
        timerClock.Interval = 1000
        ' 
        ' lblexname
        ' 
        lblexname.AutoSize = True
        lblexname.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblexname.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblexname.Location = New Point(23, 99)
        lblexname.Name = "lblexname"
        lblexname.Size = New Size(149, 17)
        lblexname.TabIndex = 13
        lblexname.Text = "Ex. Martin, Juan Miguel"
        ' 
        ' lblexnumber
        ' 
        lblexnumber.AutoSize = True
        lblexnumber.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblexnumber.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblexnumber.Location = New Point(22, 274)
        lblexnumber.Name = "lblexnumber"
        lblexnumber.Size = New Size(104, 17)
        lblexnumber.TabIndex = 14
        lblexnumber.Text = "Ex. 09123456789"
        ' 
        ' UcManageStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Controls.Add(pnlSummary)
        Controls.Add(pnlStudents)
        Controls.Add(pnlStudentInfo)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UcManageStudent"
        Size = New Size(1032, 636)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlStudentInfo.ResumeLayout(False)
        pnlStudentInfo.PerformLayout()
        pnlStudentInfoHeader.ResumeLayout(False)
        pnlStudentInfoHeader.PerformLayout()
        pnlStudents.ResumeLayout(False)
        pnlStudents.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlStudentsHeader.ResumeLayout(False)
        pnlStudentsHeader.PerformLayout()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        pnlTotalStudents.ResumeLayout(False)
        pnlTotalStudents.PerformLayout()
        CType(picTotalStudentsIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub


    '==================================================
    ' DECLARATIONS
    '==================================================

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label


    Friend WithEvents pnlStudentInfo As Panel
    Friend WithEvents pnlStudentInfoHeader As Panel
    Friend WithEvents lblStudentInfoTitle As Label

    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox

    Friend WithEvents lblYearLevel As Label
    Friend WithEvents cboYearLevel As ComboBox

    Friend WithEvents lblCourse As Label
    Friend WithEvents cboCourse As ComboBox

    Friend WithEvents lblParentContact As Label
    Friend WithEvents txtParentContact As TextBox

    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button


    Friend WithEvents pnlStudents As Panel
    Friend WithEvents pnlStudentsHeader As Panel
    Friend WithEvents lblStudentsTitle As Label

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents lblFilterYear As Label
    Friend WithEvents cboFilterYear As ComboBox

    Friend WithEvents lblFilterCourse As Label
    Friend WithEvents cboFilterCourse As ComboBox

    Friend WithEvents dgvStudents As DataGridView

    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearLevel As DataGridViewTextBoxColumn
    Friend WithEvents colCourse As DataGridViewTextBoxColumn
    Friend WithEvents colParentContact As DataGridViewTextBoxColumn


    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label

    Friend WithEvents pnlTotalStudents As Panel
    Friend WithEvents picTotalStudentsIcon As PictureBox
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents lblTotalStudents As Label

    Friend WithEvents lblImportTitle As Label
    Friend WithEvents lblImportDescription As Label
    Friend WithEvents btnImportStudents As Button


    Friend WithEvents timerClock As Timer
    Friend WithEvents lblexnumber As Label
    Friend WithEvents lblexname As Label

End Class