<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcSmsNotifications

    Inherits System.Windows.Forms.UserControl

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


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlSendSMS = New Panel()
        btnClearMessage = New Button()
        btnSendSMS = New Button()
        lblCharacterCount = New Label()
        lblMessageHint = New Label()
        txtMessage = New TextBox()
        lblMessageCaption = New Label()
        lblMessageHeader = New Label()
        lblContactNumber = New Label()
        lblContactCaption = New Label()
        lblYearCourse = New Label()
        lblYearCourseCaption = New Label()
        lblSelectedStudent = New Label()
        lblSelectedStudentCaption = New Label()
        lblStudentInfoHeader = New Label()
        pnlSendSMSHeader = New Panel()
        lblSendSMSTitle = New Label()
        pnlStudents = New Panel()
        dgvStudents = New DataGridView()
        txtSearchStudent = New TextBox()
        lblSearchStudent = New Label()
        pnlStudentsHeader = New Panel()
        lblStudentsTitle = New Label()
        pnlSMSLogs = New Panel()
        dgvSMSLogs = New DataGridView()
        pnlSMSLogsHeader = New Panel()
        lblSMSLogsTitle = New Label()
        pnlSummary = New Panel()
        btnRefreshLogs = New Button()
        pnlFailed = New Panel()
        lblFailedCount = New Label()
        lblFailedTitle = New Label()
        pnlSent = New Panel()
        lblSentCount = New Label()
        lblSentTitle = New Label()
        pnlTotalLogs = New Panel()
        lblTotalLogs = New Label()
        lblTotalLogsTitle = New Label()
        lblSummaryTitle = New Label()
        timerClock = New Timer(components)
        pnlHeader.SuspendLayout()
        pnlSendSMS.SuspendLayout()
        pnlSendSMSHeader.SuspendLayout()
        pnlStudents.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudentsHeader.SuspendLayout()
        pnlSMSLogs.SuspendLayout()
        CType(dgvSMSLogs, ComponentModel.ISupportInitialize).BeginInit()
        pnlSMSLogsHeader.SuspendLayout()
        pnlSummary.SuspendLayout()
        pnlFailed.SuspendLayout()
        pnlSent.SuspendLayout()
        pnlTotalLogs.SuspendLayout()
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
        pnlHeader.Size = New Size(1190, 68)
        pnlHeader.TabIndex = 0
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblDateTime.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblDateTime.Location = New Point(840, 24)
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
        lblSubtitle.Size = New Size(296, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Send SMS to parents and view notification logs"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 24.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTitle.Location = New Point(19, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(313, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SMS Notifications"
        ' 
        ' pnlSendSMS
        ' 
        pnlSendSMS.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlSendSMS.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlSendSMS.BorderStyle = BorderStyle.FixedSingle
        pnlSendSMS.Controls.Add(btnClearMessage)
        pnlSendSMS.Controls.Add(btnSendSMS)
        pnlSendSMS.Controls.Add(lblCharacterCount)
        pnlSendSMS.Controls.Add(lblMessageHint)
        pnlSendSMS.Controls.Add(txtMessage)
        pnlSendSMS.Controls.Add(lblMessageCaption)
        pnlSendSMS.Controls.Add(lblMessageHeader)
        pnlSendSMS.Controls.Add(lblContactNumber)
        pnlSendSMS.Controls.Add(lblContactCaption)
        pnlSendSMS.Controls.Add(lblYearCourse)
        pnlSendSMS.Controls.Add(lblYearCourseCaption)
        pnlSendSMS.Controls.Add(lblSelectedStudent)
        pnlSendSMS.Controls.Add(lblSelectedStudentCaption)
        pnlSendSMS.Controls.Add(lblStudentInfoHeader)
        pnlSendSMS.Controls.Add(pnlSendSMSHeader)
        pnlSendSMS.Location = New Point(18, 90)
        pnlSendSMS.Margin = New Padding(3, 2, 3, 2)
        pnlSendSMS.Name = "pnlSendSMS"
        pnlSendSMS.Size = New Size(320, 572)
        pnlSendSMS.TabIndex = 1
        ' 
        ' btnClearMessage
        ' 
        btnClearMessage.BackColor = Color.FromArgb(CByte(242), CByte(230), CByte(220))
        btnClearMessage.Cursor = Cursors.Hand
        btnClearMessage.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnClearMessage.FlatStyle = FlatStyle.Flat
        btnClearMessage.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnClearMessage.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnClearMessage.Location = New Point(210, 310)
        btnClearMessage.Name = "btnClearMessage"
        btnClearMessage.Size = New Size(86, 26)
        btnClearMessage.TabIndex = 14
        btnClearMessage.Text = "Clear"
        btnClearMessage.UseVisualStyleBackColor = False
        ' 
        ' btnSendSMS
        ' 
        btnSendSMS.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        btnSendSMS.Cursor = Cursors.Hand
        btnSendSMS.FlatAppearance.BorderSize = 0
        btnSendSMS.FlatStyle = FlatStyle.Flat
        btnSendSMS.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSendSMS.ForeColor = Color.White
        btnSendSMS.Location = New Point(22, 310)
        btnSendSMS.Name = "btnSendSMS"
        btnSendSMS.Size = New Size(180, 26)
        btnSendSMS.TabIndex = 13
        btnSendSMS.Text = "Send SMS"
        btnSendSMS.UseVisualStyleBackColor = False
        ' 
        ' lblCharacterCount
        ' 
        lblCharacterCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCharacterCount.Font = New Font("Segoe UI", 7.5F)
        lblCharacterCount.Location = New Point(191, 292)
        lblCharacterCount.Name = "lblCharacterCount"
        lblCharacterCount.Size = New Size(105, 16)
        lblCharacterCount.TabIndex = 15
        lblCharacterCount.Text = "0 / 160"
        lblCharacterCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblMessageHint
        ' 
        lblMessageHint.AutoSize = True
        lblMessageHint.Font = New Font("Segoe UI", 7.5F)
        lblMessageHint.ForeColor = Color.DimGray
        lblMessageHint.Location = New Point(22, 293)
        lblMessageHint.Name = "lblMessageHint"
        lblMessageHint.Size = New Size(117, 12)
        lblMessageHint.TabIndex = 16
        lblMessageHint.Text = "Maximum 160 characters."
        ' 
        ' txtMessage
        ' 
        txtMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtMessage.BorderStyle = BorderStyle.FixedSingle
        txtMessage.Font = New Font("Segoe UI", 9.0F)
        txtMessage.Location = New Point(22, 249)
        txtMessage.MaxLength = 160
        txtMessage.Multiline = True
        txtMessage.Name = "txtMessage"
        txtMessage.ScrollBars = ScrollBars.Vertical
        txtMessage.Size = New Size(274, 41)
        txtMessage.TabIndex = 10
        ' 
        ' lblMessageCaption
        ' 
        lblMessageCaption.AutoSize = True
        lblMessageCaption.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblMessageCaption.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblMessageCaption.Location = New Point(19, 232)
        lblMessageCaption.Name = "lblMessageCaption"
        lblMessageCaption.Size = New Size(106, 15)
        lblMessageCaption.TabIndex = 17
        lblMessageCaption.Text = "Message Content *"
        ' 
        ' lblMessageHeader
        ' 
        lblMessageHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblMessageHeader.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        lblMessageHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblMessageHeader.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblMessageHeader.Location = New Point(0, 205)
        lblMessageHeader.Name = "lblMessageHeader"
        lblMessageHeader.Padding = New Padding(15, 0, 0, 0)
        lblMessageHeader.Size = New Size(318, 24)
        lblMessageHeader.TabIndex = 18
        lblMessageHeader.Text = "Message Details"
        lblMessageHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblContactNumber.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        lblContactNumber.BorderStyle = BorderStyle.FixedSingle
        lblContactNumber.Font = New Font("Segoe UI", 9.0F)
        lblContactNumber.Location = New Point(22, 173)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Padding = New Padding(6, 0, 0, 0)
        lblContactNumber.Size = New Size(274, 24)
        lblContactNumber.TabIndex = 19
        lblContactNumber.Text = "-"
        lblContactNumber.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblContactCaption
        ' 
        lblContactCaption.AutoSize = True
        lblContactCaption.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblContactCaption.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblContactCaption.Location = New Point(19, 156)
        lblContactCaption.Name = "lblContactCaption"
        lblContactCaption.Size = New Size(132, 15)
        lblContactCaption.TabIndex = 20
        lblContactCaption.Text = "Parent Contact Number"
        ' 
        ' lblYearCourse
        ' 
        lblYearCourse.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblYearCourse.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        lblYearCourse.BorderStyle = BorderStyle.FixedSingle
        lblYearCourse.Font = New Font("Segoe UI", 9.0F)
        lblYearCourse.Location = New Point(22, 129)
        lblYearCourse.Name = "lblYearCourse"
        lblYearCourse.Padding = New Padding(6, 0, 0, 0)
        lblYearCourse.Size = New Size(274, 24)
        lblYearCourse.TabIndex = 21
        lblYearCourse.Text = "-"
        lblYearCourse.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblYearCourseCaption
        ' 
        lblYearCourseCaption.AutoSize = True
        lblYearCourseCaption.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblYearCourseCaption.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblYearCourseCaption.Location = New Point(19, 112)
        lblYearCourseCaption.Name = "lblYearCourseCaption"
        lblYearCourseCaption.Size = New Size(76, 15)
        lblYearCourseCaption.TabIndex = 22
        lblYearCourseCaption.Text = "Year / Course"
        ' 
        ' lblSelectedStudent
        ' 
        lblSelectedStudent.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblSelectedStudent.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        lblSelectedStudent.BorderStyle = BorderStyle.FixedSingle
        lblSelectedStudent.Font = New Font("Segoe UI", 9.0F)
        lblSelectedStudent.Location = New Point(22, 85)
        lblSelectedStudent.Name = "lblSelectedStudent"
        lblSelectedStudent.Padding = New Padding(6, 0, 0, 0)
        lblSelectedStudent.Size = New Size(274, 24)
        lblSelectedStudent.TabIndex = 23
        lblSelectedStudent.Text = "No student selected"
        lblSelectedStudent.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSelectedStudentCaption
        ' 
        lblSelectedStudentCaption.AutoSize = True
        lblSelectedStudentCaption.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblSelectedStudentCaption.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblSelectedStudentCaption.Location = New Point(19, 68)
        lblSelectedStudentCaption.Name = "lblSelectedStudentCaption"
        lblSelectedStudentCaption.Size = New Size(97, 15)
        lblSelectedStudentCaption.TabIndex = 24
        lblSelectedStudentCaption.Text = "Selected Student"
        ' 
        ' lblStudentInfoHeader
        ' 
        lblStudentInfoHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStudentInfoHeader.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        lblStudentInfoHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblStudentInfoHeader.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblStudentInfoHeader.Location = New Point(0, 38)
        lblStudentInfoHeader.Name = "lblStudentInfoHeader"
        lblStudentInfoHeader.Padding = New Padding(15, 0, 0, 0)
        lblStudentInfoHeader.Size = New Size(318, 26)
        lblStudentInfoHeader.TabIndex = 25
        lblStudentInfoHeader.Text = "Student Information"
        lblStudentInfoHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlSendSMSHeader
        ' 
        pnlSendSMSHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlSendSMSHeader.Controls.Add(lblSendSMSTitle)
        pnlSendSMSHeader.Dock = DockStyle.Top
        pnlSendSMSHeader.Location = New Point(0, 0)
        pnlSendSMSHeader.Name = "pnlSendSMSHeader"
        pnlSendSMSHeader.Size = New Size(318, 38)
        pnlSendSMSHeader.TabIndex = 0
        ' 
        ' lblSendSMSTitle
        ' 
        lblSendSMSTitle.AutoSize = True
        lblSendSMSTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblSendSMSTitle.ForeColor = Color.White
        lblSendSMSTitle.Location = New Point(14, 8)
        lblSendSMSTitle.Name = "lblSendSMSTitle"
        lblSendSMSTitle.Size = New Size(84, 21)
        lblSendSMSTitle.TabIndex = 0
        lblSendSMSTitle.Text = "Send SMS"
        ' 
        ' pnlStudents
        ' 
        pnlStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStudents.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlStudents.BorderStyle = BorderStyle.FixedSingle
        pnlStudents.Controls.Add(dgvStudents)
        pnlStudents.Controls.Add(txtSearchStudent)
        pnlStudents.Controls.Add(lblSearchStudent)
        pnlStudents.Controls.Add(pnlStudentsHeader)
        pnlStudents.Location = New Point(350, 90)
        pnlStudents.Margin = New Padding(3, 2, 3, 2)
        pnlStudents.Name = "pnlStudents"
        pnlStudents.Size = New Size(857, 291)
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
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.ColumnHeadersHeight = 34
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(50), CByte(35), CByte(28))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(52), CByte(32), CByte(23))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
        dgvStudents.EnableHeadersVisualStyles = False
        dgvStudents.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvStudents.Location = New Point(18, 82)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowTemplate.Height = 30
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(818, 193)
        dgvStudents.TabIndex = 3
        ' 
        ' txtSearchStudent
        ' 
        txtSearchStudent.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearchStudent.BorderStyle = BorderStyle.FixedSingle
        txtSearchStudent.Font = New Font("Segoe UI", 10.0F)
        txtSearchStudent.Location = New Point(125, 48)
        txtSearchStudent.Name = "txtSearchStudent"
        txtSearchStudent.Size = New Size(711, 25)
        txtSearchStudent.TabIndex = 2
        ' 
        ' lblSearchStudent
        ' 
        lblSearchStudent.AutoSize = True
        lblSearchStudent.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblSearchStudent.ForeColor = Color.FromArgb(CByte(59), CByte(40), CByte(31))
        lblSearchStudent.Location = New Point(16, 52)
        lblSearchStudent.Name = "lblSearchStudent"
        lblSearchStudent.Size = New Size(88, 15)
        lblSearchStudent.TabIndex = 4
        lblSearchStudent.Text = "Search Student"
        ' 
        ' pnlStudentsHeader
        ' 
        pnlStudentsHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlStudentsHeader.Controls.Add(lblStudentsTitle)
        pnlStudentsHeader.Dock = DockStyle.Top
        pnlStudentsHeader.Location = New Point(0, 0)
        pnlStudentsHeader.Name = "pnlStudentsHeader"
        pnlStudentsHeader.Size = New Size(855, 38)
        pnlStudentsHeader.TabIndex = 5
        ' 
        ' lblStudentsTitle
        ' 
        lblStudentsTitle.AutoSize = True
        lblStudentsTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblStudentsTitle.ForeColor = Color.White
        lblStudentsTitle.Location = New Point(14, 8)
        lblStudentsTitle.Name = "lblStudentsTitle"
        lblStudentsTitle.Size = New Size(97, 21)
        lblStudentsTitle.TabIndex = 0
        lblStudentsTitle.Text = "Student List"
        ' 
        ' pnlSMSLogs
        ' 
        pnlSMSLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSMSLogs.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlSMSLogs.BorderStyle = BorderStyle.FixedSingle
        pnlSMSLogs.Controls.Add(dgvSMSLogs)
        pnlSMSLogs.Controls.Add(pnlSMSLogsHeader)
        pnlSMSLogs.Location = New Point(350, 401)
        pnlSMSLogs.Margin = New Padding(3, 2, 3, 2)
        pnlSMSLogs.Name = "pnlSMSLogs"
        pnlSMSLogs.Size = New Size(857, 261)
        pnlSMSLogs.TabIndex = 3
        ' 
        ' dgvSMSLogs
        ' 
        dgvSMSLogs.AllowUserToAddRows = False
        dgvSMSLogs.AllowUserToDeleteRows = False
        dgvSMSLogs.AllowUserToResizeRows = False
        dgvSMSLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvSMSLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSMSLogs.BackgroundColor = Color.White
        dgvSMSLogs.BorderStyle = BorderStyle.None
        dgvSMSLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSMSLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvSMSLogs.ColumnHeadersHeight = 34
        dgvSMSLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 8.5F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(50), CByte(35), CByte(28))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(52), CByte(32), CByte(23))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvSMSLogs.DefaultCellStyle = DataGridViewCellStyle4
        dgvSMSLogs.EnableHeadersVisualStyles = False
        dgvSMSLogs.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvSMSLogs.Location = New Point(18, 50)
        dgvSMSLogs.MultiSelect = False
        dgvSMSLogs.Name = "dgvSMSLogs"
        dgvSMSLogs.ReadOnly = True
        dgvSMSLogs.RowHeadersVisible = False
        dgvSMSLogs.RowTemplate.Height = 30
        dgvSMSLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSMSLogs.Size = New Size(818, 193)
        dgvSMSLogs.TabIndex = 1
        ' 
        ' pnlSMSLogsHeader
        ' 
        pnlSMSLogsHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlSMSLogsHeader.Controls.Add(lblSMSLogsTitle)
        pnlSMSLogsHeader.Dock = DockStyle.Top
        pnlSMSLogsHeader.Location = New Point(0, 0)
        pnlSMSLogsHeader.Name = "pnlSMSLogsHeader"
        pnlSMSLogsHeader.Size = New Size(855, 38)
        pnlSMSLogsHeader.TabIndex = 2
        ' 
        ' lblSMSLogsTitle
        ' 
        lblSMSLogsTitle.AutoSize = True
        lblSMSLogsTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblSMSLogsTitle.ForeColor = Color.White
        lblSMSLogsTitle.Location = New Point(14, 8)
        lblSMSLogsTitle.Name = "lblSMSLogsTitle"
        lblSMSLogsTitle.Size = New Size(82, 21)
        lblSMSLogsTitle.TabIndex = 0
        lblSMSLogsTitle.Text = "SMS Logs"
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummary.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlSummary.BorderStyle = BorderStyle.FixedSingle
        pnlSummary.Controls.Add(btnRefreshLogs)
        pnlSummary.Controls.Add(pnlFailed)
        pnlSummary.Controls.Add(pnlSent)
        pnlSummary.Controls.Add(pnlTotalLogs)
        pnlSummary.Controls.Add(lblSummaryTitle)
        pnlSummary.Location = New Point(18, 672)
        pnlSummary.Margin = New Padding(3, 2, 3, 2)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(1190, 83)
        pnlSummary.TabIndex = 4
        ' 
        ' btnRefreshLogs
        ' 
        btnRefreshLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefreshLogs.BackColor = Color.FromArgb(CByte(242), CByte(230), CByte(220))
        btnRefreshLogs.Cursor = Cursors.Hand
        btnRefreshLogs.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnRefreshLogs.FlatStyle = FlatStyle.Flat
        btnRefreshLogs.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        btnRefreshLogs.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnRefreshLogs.Location = New Point(1034, 4)
        btnRefreshLogs.Name = "btnRefreshLogs"
        btnRefreshLogs.Size = New Size(130, 22)
        btnRefreshLogs.TabIndex = 4
        btnRefreshLogs.Text = "Refresh Logs"
        btnRefreshLogs.UseVisualStyleBackColor = False
        ' 
        ' pnlFailed
        ' 
        pnlFailed.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlFailed.BackColor = Color.FromArgb(CByte(248), CByte(224), CByte(220))
        pnlFailed.Controls.Add(lblFailedCount)
        pnlFailed.Controls.Add(lblFailedTitle)
        pnlFailed.Location = New Point(866, 30)
        pnlFailed.Name = "pnlFailed"
        pnlFailed.Size = New Size(302, 41)
        pnlFailed.TabIndex = 3
        ' 
        ' lblFailedCount
        ' 
        lblFailedCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFailedCount.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblFailedCount.ForeColor = Color.FromArgb(CByte(170), CByte(45), CByte(45))
        lblFailedCount.Location = New Point(219, 5)
        lblFailedCount.Name = "lblFailedCount"
        lblFailedCount.Size = New Size(66, 30)
        lblFailedCount.TabIndex = 0
        lblFailedCount.Text = "0"
        lblFailedCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFailedTitle
        ' 
        lblFailedTitle.AutoSize = True
        lblFailedTitle.Font = New Font("Segoe UI", 9.5F)
        lblFailedTitle.Location = New Point(12, 6)
        lblFailedTitle.Name = "lblFailedTitle"
        lblFailedTitle.Size = New Size(42, 17)
        lblFailedTitle.TabIndex = 1
        lblFailedTitle.Text = "Failed"
        ' 
        ' pnlSent
        ' 
        pnlSent.Anchor = AnchorStyles.Top
        pnlSent.BackColor = Color.FromArgb(CByte(226), CByte(242), CByte(230))
        pnlSent.Controls.Add(lblSentCount)
        pnlSent.Controls.Add(lblSentTitle)
        pnlSent.Location = New Point(442, 30)
        pnlSent.Name = "pnlSent"
        pnlSent.Size = New Size(302, 41)
        pnlSent.TabIndex = 2
        ' 
        ' lblSentCount
        ' 
        lblSentCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblSentCount.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblSentCount.ForeColor = Color.FromArgb(CByte(40), CByte(100), CByte(60))
        lblSentCount.Location = New Point(219, 5)
        lblSentCount.Name = "lblSentCount"
        lblSentCount.Size = New Size(66, 30)
        lblSentCount.TabIndex = 0
        lblSentCount.Text = "0"
        lblSentCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSentTitle
        ' 
        lblSentTitle.AutoSize = True
        lblSentTitle.Font = New Font("Segoe UI", 9.5F)
        lblSentTitle.Location = New Point(12, 6)
        lblSentTitle.Name = "lblSentTitle"
        lblSentTitle.Size = New Size(33, 17)
        lblSentTitle.TabIndex = 1
        lblSentTitle.Text = "Sent"
        ' 
        ' pnlTotalLogs
        ' 
        pnlTotalLogs.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        pnlTotalLogs.Controls.Add(lblTotalLogs)
        pnlTotalLogs.Controls.Add(lblTotalLogsTitle)
        pnlTotalLogs.Location = New Point(18, 30)
        pnlTotalLogs.Name = "pnlTotalLogs"
        pnlTotalLogs.Size = New Size(302, 41)
        pnlTotalLogs.TabIndex = 1
        ' 
        ' lblTotalLogs
        ' 
        lblTotalLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalLogs.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTotalLogs.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTotalLogs.Location = New Point(219, 5)
        lblTotalLogs.Name = "lblTotalLogs"
        lblTotalLogs.Size = New Size(66, 30)
        lblTotalLogs.TabIndex = 0
        lblTotalLogs.Text = "0"
        lblTotalLogs.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalLogsTitle
        ' 
        lblTotalLogsTitle.AutoSize = True
        lblTotalLogsTitle.Font = New Font("Segoe UI", 9.5F)
        lblTotalLogsTitle.Location = New Point(12, 6)
        lblTotalLogsTitle.Name = "lblTotalLogsTitle"
        lblTotalLogsTitle.Size = New Size(68, 17)
        lblTotalLogsTitle.TabIndex = 1
        lblTotalLogsTitle.Text = "Total Logs"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.AutoSize = True
        lblSummaryTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblSummaryTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblSummaryTitle.Location = New Point(16, 8)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Size = New Size(69, 19)
        lblSummaryTitle.TabIndex = 5
        lblSummaryTitle.Text = "Summary"
        ' 
        ' timerClock
        ' 
        timerClock.Interval = 1000
        ' 
        ' UcSmsNotifications
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Controls.Add(pnlSummary)
        Controls.Add(pnlSMSLogs)
        Controls.Add(pnlStudents)
        Controls.Add(pnlSendSMS)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UcSmsNotifications"
        Size = New Size(1224, 770)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSendSMS.ResumeLayout(False)
        pnlSendSMS.PerformLayout()
        pnlSendSMSHeader.ResumeLayout(False)
        pnlSendSMSHeader.PerformLayout()
        pnlStudents.ResumeLayout(False)
        pnlStudents.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlStudentsHeader.ResumeLayout(False)
        pnlStudentsHeader.PerformLayout()
        pnlSMSLogs.ResumeLayout(False)
        CType(dgvSMSLogs, ComponentModel.ISupportInitialize).EndInit()
        pnlSMSLogsHeader.ResumeLayout(False)
        pnlSMSLogsHeader.PerformLayout()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        pnlFailed.ResumeLayout(False)
        pnlFailed.PerformLayout()
        pnlSent.ResumeLayout(False)
        pnlSent.PerformLayout()
        pnlTotalLogs.ResumeLayout(False)
        pnlTotalLogs.PerformLayout()
        ResumeLayout(False)

    End Sub


    '==================================================
    ' DECLARATIONS
    '==================================================

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label


    Friend WithEvents pnlSendSMS As Panel
    Friend WithEvents pnlSendSMSHeader As Panel
    Friend WithEvents lblSendSMSTitle As Label

    Friend WithEvents lblStudentInfoHeader As Label

    Friend WithEvents lblSelectedStudentCaption As Label
    Friend WithEvents lblSelectedStudent As Label

    Friend WithEvents lblYearCourseCaption As Label
    Friend WithEvents lblYearCourse As Label

    Friend WithEvents lblContactCaption As Label
    Friend WithEvents lblContactNumber As Label

    Friend WithEvents lblMessageHeader As Label
    Friend WithEvents lblMessageCaption As Label

    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblCharacterCount As Label
    Friend WithEvents lblMessageHint As Label

    Friend WithEvents btnSendSMS As Button
    Friend WithEvents btnClearMessage As Button


    Friend WithEvents pnlStudents As Panel
    Friend WithEvents pnlStudentsHeader As Panel
    Friend WithEvents lblStudentsTitle As Label

    Friend WithEvents lblSearchStudent As Label
    Friend WithEvents txtSearchStudent As TextBox

    Friend WithEvents dgvStudents As DataGridView

    Friend WithEvents colStudentId As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearCourse As DataGridViewTextBoxColumn


    Friend WithEvents pnlSMSLogs As Panel
    Friend WithEvents pnlSMSLogsHeader As Panel
    Friend WithEvents lblSMSLogsTitle As Label

    Friend WithEvents dgvSMSLogs As DataGridView

    Friend WithEvents colLogStudent As DataGridViewTextBoxColumn
    Friend WithEvents colLogContact As DataGridViewTextBoxColumn
    Friend WithEvents colLogType As DataGridViewTextBoxColumn
    Friend WithEvents colLogMessage As DataGridViewTextBoxColumn
    Friend WithEvents colLogSentAt As DataGridViewTextBoxColumn
    Friend WithEvents colLogStatus As DataGridViewTextBoxColumn


    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label

    Friend WithEvents pnlTotalLogs As Panel
    Friend WithEvents lblTotalLogsTitle As Label
    Friend WithEvents lblTotalLogs As Label

    Friend WithEvents pnlSent As Panel
    Friend WithEvents lblSentTitle As Label
    Friend WithEvents lblSentCount As Label

    Friend WithEvents pnlFailed As Panel
    Friend WithEvents lblFailedTitle As Label
    Friend WithEvents lblFailedCount As Label

    Friend WithEvents btnRefreshLogs As Button

    Friend WithEvents timerClock As Timer

End Class