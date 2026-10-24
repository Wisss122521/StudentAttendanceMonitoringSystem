<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcDashboard

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
        lblTitle = New Label()
        lblSubtitle = New Label()
        lblDateTime = New Label()
        tlpStats = New TableLayoutPanel()
        pnlTotalStudents = New Panel()
        lblTotalStudentsTitle = New Label()
        lblTotalStudents = New Label()
        pnlQRGenerated = New Panel()
        lblQRGeneratedTitle = New Label()
        lblQRGenerated = New Label()
        pnlTodayEntry = New Panel()
        lblTodayEntryTitle = New Label()
        lblTodayEntry = New Label()
        pnlTodayExit = New Panel()
        lblTodayExitTitle = New Label()
        lblTodayExit = New Label()
        tlpMiddle = New TableLayoutPanel()
        pnlRecentEntryExit = New Panel()
        dgvRecentEntryExit = New DataGridView()
        pnlRecentEntryExitHeader = New Panel()
        lblRecentEntryExitTitle = New Label()
        pnlRecentSMS = New Panel()
        dgvRecentSMS = New DataGridView()
        pnlRecentSMSHeader = New Panel()
        lblRecentSMSTitle = New Label()
        pnlQuickOverview = New Panel()
        lblQuickOverviewTitle = New Label()
        tlpQuickOverview = New TableLayoutPanel()
        pnlQRNotGenerated = New Panel()
        lblQRNotGeneratedTitle = New Label()
        lblQRNotGenerated = New Label()
        pnlNoExitToday = New Panel()
        lblNoExitTodayTitle = New Label()
        lblNoExitToday = New Label()
        pnlFailedSMS = New Panel()
        lblFailedSMSTitle = New Label()
        lblFailedSMS = New Label()
        timerClock = New Timer(components)
        pnlHeader.SuspendLayout()
        tlpStats.SuspendLayout()
        pnlTotalStudents.SuspendLayout()
        pnlQRGenerated.SuspendLayout()
        pnlTodayEntry.SuspendLayout()
        pnlTodayExit.SuspendLayout()
        tlpMiddle.SuspendLayout()
        pnlRecentEntryExit.SuspendLayout()
        CType(dgvRecentEntryExit, ComponentModel.ISupportInitialize).BeginInit()
        pnlRecentEntryExitHeader.SuspendLayout()
        pnlRecentSMS.SuspendLayout()
        CType(dgvRecentSMS, ComponentModel.ISupportInitialize).BeginInit()
        pnlRecentSMSHeader.SuspendLayout()
        pnlQuickOverview.SuspendLayout()
        tlpQuickOverview.SuspendLayout()
        pnlQRNotGenerated.SuspendLayout()
        pnlNoExitToday.SuspendLayout()
        pnlFailedSMS.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlHeader.BorderStyle = BorderStyle.FixedSingle
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblDateTime)
        pnlHeader.Location = New Point(18, 14)
        pnlHeader.Margin = New Padding(3, 2, 3, 2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(998, 68)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 24F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTitle.Location = New Point(19, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(199, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Dashboard"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        lblSubtitle.Location = New Point(23, 44)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(314, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Overview of student entry/exit monitoring system"
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
        lblDateTime.Text = "Friday, October 23, 2026   |   08:00:00 PM"
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tlpStats
        ' 
        tlpStats.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tlpStats.ColumnCount = 4
        tlpStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpStats.Controls.Add(pnlTotalStudents, 0, 0)
        tlpStats.Controls.Add(pnlQRGenerated, 1, 0)
        tlpStats.Controls.Add(pnlTodayEntry, 2, 0)
        tlpStats.Controls.Add(pnlTodayExit, 3, 0)
        tlpStats.Location = New Point(18, 90)
        tlpStats.Margin = New Padding(0)
        tlpStats.Name = "tlpStats"
        tlpStats.RowCount = 1
        tlpStats.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpStats.Size = New Size(998, 82)
        tlpStats.TabIndex = 1
        ' 
        ' pnlTotalStudents
        ' 
        pnlTotalStudents.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        pnlTotalStudents.BorderStyle = BorderStyle.FixedSingle
        pnlTotalStudents.Controls.Add(lblTotalStudentsTitle)
        pnlTotalStudents.Controls.Add(lblTotalStudents)
        pnlTotalStudents.Dock = DockStyle.Fill
        pnlTotalStudents.Location = New Point(0, 0)
        pnlTotalStudents.Margin = New Padding(0, 0, 7, 0)
        pnlTotalStudents.Name = "pnlTotalStudents"
        pnlTotalStudents.Size = New Size(242, 82)
        pnlTotalStudents.TabIndex = 0
        ' 
        ' lblTotalStudentsTitle
        ' 
        lblTotalStudentsTitle.AutoSize = True
        lblTotalStudentsTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblTotalStudentsTitle.ForeColor = Color.FromArgb(CByte(75), CByte(54), CByte(43))
        lblTotalStudentsTitle.Location = New Point(16, 11)
        lblTotalStudentsTitle.Name = "lblTotalStudentsTitle"
        lblTotalStudentsTitle.Size = New Size(95, 17)
        lblTotalStudentsTitle.TabIndex = 0
        lblTotalStudentsTitle.Text = "Total Students"
        ' 
        ' lblTotalStudents
        ' 
        lblTotalStudents.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTotalStudents.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTotalStudents.Location = New Point(15, 30)
        lblTotalStudents.Name = "lblTotalStudents"
        lblTotalStudents.Size = New Size(192, 39)
        lblTotalStudents.TabIndex = 1
        lblTotalStudents.Text = "0"
        ' 
        ' pnlQRGenerated
        ' 
        pnlQRGenerated.BackColor = Color.FromArgb(CByte(226), CByte(242), CByte(230))
        pnlQRGenerated.BorderStyle = BorderStyle.FixedSingle
        pnlQRGenerated.Controls.Add(lblQRGeneratedTitle)
        pnlQRGenerated.Controls.Add(lblQRGenerated)
        pnlQRGenerated.Dock = DockStyle.Fill
        pnlQRGenerated.Location = New Point(253, 0)
        pnlQRGenerated.Margin = New Padding(4, 0, 4, 0)
        pnlQRGenerated.Name = "pnlQRGenerated"
        pnlQRGenerated.Size = New Size(241, 82)
        pnlQRGenerated.TabIndex = 1
        ' 
        ' lblQRGeneratedTitle
        ' 
        lblQRGeneratedTitle.AutoSize = True
        lblQRGeneratedTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblQRGeneratedTitle.ForeColor = Color.FromArgb(CByte(50), CByte(90), CByte(60))
        lblQRGeneratedTitle.Location = New Point(16, 11)
        lblQRGeneratedTitle.Name = "lblQRGeneratedTitle"
        lblQRGeneratedTitle.Size = New Size(93, 17)
        lblQRGeneratedTitle.TabIndex = 0
        lblQRGeneratedTitle.Text = "QR Generated"
        ' 
        ' lblQRGenerated
        ' 
        lblQRGenerated.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblQRGenerated.ForeColor = Color.FromArgb(CByte(40), CByte(100), CByte(60))
        lblQRGenerated.Location = New Point(15, 30)
        lblQRGenerated.Name = "lblQRGenerated"
        lblQRGenerated.Size = New Size(192, 39)
        lblQRGenerated.TabIndex = 1
        lblQRGenerated.Text = "0"
        ' 
        ' pnlTodayEntry
        ' 
        pnlTodayEntry.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(248))
        pnlTodayEntry.BorderStyle = BorderStyle.FixedSingle
        pnlTodayEntry.Controls.Add(lblTodayEntryTitle)
        pnlTodayEntry.Controls.Add(lblTodayEntry)
        pnlTodayEntry.Dock = DockStyle.Fill
        pnlTodayEntry.Location = New Point(502, 0)
        pnlTodayEntry.Margin = New Padding(4, 0, 4, 0)
        pnlTodayEntry.Name = "pnlTodayEntry"
        pnlTodayEntry.Size = New Size(241, 82)
        pnlTodayEntry.TabIndex = 2
        ' 
        ' lblTodayEntryTitle
        ' 
        lblTodayEntryTitle.AutoSize = True
        lblTodayEntryTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblTodayEntryTitle.ForeColor = Color.FromArgb(CByte(50), CByte(70), CByte(100))
        lblTodayEntryTitle.Location = New Point(16, 11)
        lblTodayEntryTitle.Name = "lblTodayEntryTitle"
        lblTodayEntryTitle.Size = New Size(153, 17)
        lblTodayEntryTitle.TabIndex = 0
        lblTodayEntryTitle.Text = "Students Entered Today"
        ' 
        ' lblTodayEntry
        ' 
        lblTodayEntry.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTodayEntry.ForeColor = Color.FromArgb(CByte(50), CByte(70), CByte(100))
        lblTodayEntry.Location = New Point(15, 30)
        lblTodayEntry.Name = "lblTodayEntry"
        lblTodayEntry.Size = New Size(192, 39)
        lblTodayEntry.TabIndex = 1
        lblTodayEntry.Text = "0"
        ' 
        ' pnlTodayExit
        ' 
        pnlTodayExit.BackColor = Color.FromArgb(CByte(248), CByte(224), CByte(220))
        pnlTodayExit.BorderStyle = BorderStyle.FixedSingle
        pnlTodayExit.Controls.Add(lblTodayExitTitle)
        pnlTodayExit.Controls.Add(lblTodayExit)
        pnlTodayExit.Dock = DockStyle.Fill
        pnlTodayExit.Location = New Point(754, 0)
        pnlTodayExit.Margin = New Padding(7, 0, 0, 0)
        pnlTodayExit.Name = "pnlTodayExit"
        pnlTodayExit.Size = New Size(244, 82)
        pnlTodayExit.TabIndex = 3
        ' 
        ' lblTodayExitTitle
        ' 
        lblTodayExitTitle.AutoSize = True
        lblTodayExitTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblTodayExitTitle.ForeColor = Color.FromArgb(CByte(150), CByte(55), CByte(55))
        lblTodayExitTitle.Location = New Point(16, 11)
        lblTodayExitTitle.Name = "lblTodayExitTitle"
        lblTodayExitTitle.Size = New Size(143, 17)
        lblTodayExitTitle.TabIndex = 0
        lblTodayExitTitle.Text = "Students Exited Today"
        ' 
        ' lblTodayExit
        ' 
        lblTodayExit.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTodayExit.ForeColor = Color.FromArgb(CByte(170), CByte(45), CByte(45))
        lblTodayExit.Location = New Point(15, 30)
        lblTodayExit.Name = "lblTodayExit"
        lblTodayExit.Size = New Size(192, 39)
        lblTodayExit.TabIndex = 1
        lblTodayExit.Text = "0"
        ' 
        ' tlpMiddle
        ' 
        tlpMiddle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpMiddle.ColumnCount = 2
        tlpMiddle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 62F))
        tlpMiddle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38F))
        tlpMiddle.Controls.Add(pnlRecentEntryExit, 0, 0)
        tlpMiddle.Controls.Add(pnlRecentSMS, 1, 0)
        tlpMiddle.Location = New Point(18, 182)
        tlpMiddle.Margin = New Padding(0)
        tlpMiddle.Name = "tlpMiddle"
        tlpMiddle.RowCount = 1
        tlpMiddle.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMiddle.Size = New Size(998, 250)
        tlpMiddle.TabIndex = 2
        ' 
        ' pnlRecentEntryExit
        ' 
        pnlRecentEntryExit.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlRecentEntryExit.BorderStyle = BorderStyle.FixedSingle
        pnlRecentEntryExit.Controls.Add(dgvRecentEntryExit)
        pnlRecentEntryExit.Controls.Add(pnlRecentEntryExitHeader)
        pnlRecentEntryExit.Dock = DockStyle.Fill
        pnlRecentEntryExit.Location = New Point(0, 0)
        pnlRecentEntryExit.Margin = New Padding(0, 0, 4, 0)
        pnlRecentEntryExit.Name = "pnlRecentEntryExit"
        pnlRecentEntryExit.Size = New Size(614, 250)
        pnlRecentEntryExit.TabIndex = 0
        ' 
        ' dgvRecentEntryExit
        ' 
        dgvRecentEntryExit.AllowUserToAddRows = False
        dgvRecentEntryExit.AllowUserToDeleteRows = False
        dgvRecentEntryExit.AllowUserToResizeRows = False
        dgvRecentEntryExit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentEntryExit.BackgroundColor = Color.White
        dgvRecentEntryExit.BorderStyle = BorderStyle.None
        dgvRecentEntryExit.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRecentEntryExit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRecentEntryExit.ColumnHeadersHeight = 42
        dgvRecentEntryExit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(52), CByte(32), CByte(23))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRecentEntryExit.DefaultCellStyle = DataGridViewCellStyle2
        dgvRecentEntryExit.Dock = DockStyle.Fill
        dgvRecentEntryExit.EnableHeadersVisualStyles = False
        dgvRecentEntryExit.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvRecentEntryExit.Location = New Point(0, 38)
        dgvRecentEntryExit.Margin = New Padding(3, 2, 3, 2)
        dgvRecentEntryExit.MultiSelect = False
        dgvRecentEntryExit.Name = "dgvRecentEntryExit"
        dgvRecentEntryExit.ReadOnly = True
        dgvRecentEntryExit.RowHeadersVisible = False
        dgvRecentEntryExit.RowTemplate.Height = 38
        dgvRecentEntryExit.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentEntryExit.Size = New Size(612, 210)
        dgvRecentEntryExit.TabIndex = 0
        ' 
        ' pnlRecentEntryExitHeader
        ' 
        pnlRecentEntryExitHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlRecentEntryExitHeader.Controls.Add(lblRecentEntryExitTitle)
        pnlRecentEntryExitHeader.Dock = DockStyle.Top
        pnlRecentEntryExitHeader.Location = New Point(0, 0)
        pnlRecentEntryExitHeader.Margin = New Padding(3, 2, 3, 2)
        pnlRecentEntryExitHeader.Name = "pnlRecentEntryExitHeader"
        pnlRecentEntryExitHeader.Size = New Size(612, 38)
        pnlRecentEntryExitHeader.TabIndex = 1
        ' 
        ' lblRecentEntryExitTitle
        ' 
        lblRecentEntryExitTitle.AutoSize = True
        lblRecentEntryExitTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblRecentEntryExitTitle.ForeColor = Color.White
        lblRecentEntryExitTitle.Location = New Point(14, 8)
        lblRecentEntryExitTitle.Name = "lblRecentEntryExitTitle"
        lblRecentEntryExitTitle.Size = New Size(208, 21)
        lblRecentEntryExitTitle.TabIndex = 0
        lblRecentEntryExitTitle.Text = "Recent Entry / Exit Records"
        ' 
        ' pnlRecentSMS
        ' 
        pnlRecentSMS.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlRecentSMS.BorderStyle = BorderStyle.FixedSingle
        pnlRecentSMS.Controls.Add(dgvRecentSMS)
        pnlRecentSMS.Controls.Add(pnlRecentSMSHeader)
        pnlRecentSMS.Dock = DockStyle.Fill
        pnlRecentSMS.Location = New Point(622, 0)
        pnlRecentSMS.Margin = New Padding(4, 0, 0, 0)
        pnlRecentSMS.Name = "pnlRecentSMS"
        pnlRecentSMS.Size = New Size(376, 250)
        pnlRecentSMS.TabIndex = 1
        ' 
        ' dgvRecentSMS
        ' 
        dgvRecentSMS.AllowUserToAddRows = False
        dgvRecentSMS.AllowUserToDeleteRows = False
        dgvRecentSMS.AllowUserToResizeRows = False
        dgvRecentSMS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentSMS.BackgroundColor = Color.White
        dgvRecentSMS.BorderStyle = BorderStyle.None
        dgvRecentSMS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvRecentSMS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvRecentSMS.ColumnHeadersHeight = 42
        dgvRecentSMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(52), CByte(32), CByte(23))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvRecentSMS.DefaultCellStyle = DataGridViewCellStyle4
        dgvRecentSMS.Dock = DockStyle.Fill
        dgvRecentSMS.EnableHeadersVisualStyles = False
        dgvRecentSMS.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvRecentSMS.Location = New Point(0, 38)
        dgvRecentSMS.Margin = New Padding(3, 2, 3, 2)
        dgvRecentSMS.MultiSelect = False
        dgvRecentSMS.Name = "dgvRecentSMS"
        dgvRecentSMS.ReadOnly = True
        dgvRecentSMS.RowHeadersVisible = False
        dgvRecentSMS.RowTemplate.Height = 38
        dgvRecentSMS.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentSMS.Size = New Size(374, 210)
        dgvRecentSMS.TabIndex = 0
        ' 
        ' pnlRecentSMSHeader
        ' 
        pnlRecentSMSHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlRecentSMSHeader.Controls.Add(lblRecentSMSTitle)
        pnlRecentSMSHeader.Dock = DockStyle.Top
        pnlRecentSMSHeader.Location = New Point(0, 0)
        pnlRecentSMSHeader.Margin = New Padding(3, 2, 3, 2)
        pnlRecentSMSHeader.Name = "pnlRecentSMSHeader"
        pnlRecentSMSHeader.Size = New Size(374, 38)
        pnlRecentSMSHeader.TabIndex = 1
        ' 
        ' lblRecentSMSTitle
        ' 
        lblRecentSMSTitle.AutoSize = True
        lblRecentSMSTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblRecentSMSTitle.ForeColor = Color.White
        lblRecentSMSTitle.Location = New Point(14, 8)
        lblRecentSMSTitle.Name = "lblRecentSMSTitle"
        lblRecentSMSTitle.Size = New Size(196, 21)
        lblRecentSMSTitle.TabIndex = 0
        lblRecentSMSTitle.Text = "Recent SMS Notifications"
        ' 
        ' pnlQuickOverview
        ' 
        pnlQuickOverview.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlQuickOverview.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlQuickOverview.BorderStyle = BorderStyle.FixedSingle
        pnlQuickOverview.Controls.Add(lblQuickOverviewTitle)
        pnlQuickOverview.Controls.Add(tlpQuickOverview)
        pnlQuickOverview.Location = New Point(18, 442)
        pnlQuickOverview.Margin = New Padding(3, 2, 3, 2)
        pnlQuickOverview.Name = "pnlQuickOverview"
        pnlQuickOverview.Size = New Size(998, 83)
        pnlQuickOverview.TabIndex = 0
        ' 
        ' lblQuickOverviewTitle
        ' 
        lblQuickOverviewTitle.AutoSize = True
        lblQuickOverviewTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblQuickOverviewTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblQuickOverviewTitle.Location = New Point(16, 8)
        lblQuickOverviewTitle.Name = "lblQuickOverviewTitle"
        lblQuickOverviewTitle.Size = New Size(110, 19)
        lblQuickOverviewTitle.TabIndex = 0
        lblQuickOverviewTitle.Text = "Quick Overview"
        ' 
        ' tlpQuickOverview
        ' 
        tlpQuickOverview.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpQuickOverview.ColumnCount = 5
        tlpQuickOverview.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 302F))
        tlpQuickOverview.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        tlpQuickOverview.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 302F))
        tlpQuickOverview.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        tlpQuickOverview.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 302F))
        tlpQuickOverview.Controls.Add(pnlQRNotGenerated, 0, 0)
        tlpQuickOverview.Controls.Add(pnlNoExitToday, 2, 0)
        tlpQuickOverview.Controls.Add(pnlFailedSMS, 4, 0)
        tlpQuickOverview.Location = New Point(18, 30)
        tlpQuickOverview.Margin = New Padding(3, 2, 3, 2)
        tlpQuickOverview.Name = "tlpQuickOverview"
        tlpQuickOverview.RowCount = 1
        tlpQuickOverview.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpQuickOverview.Size = New Size(958, 41)
        tlpQuickOverview.TabIndex = 1
        ' 
        ' pnlQRNotGenerated
        ' 
        pnlQRNotGenerated.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        pnlQRNotGenerated.Controls.Add(lblQRNotGeneratedTitle)
        pnlQRNotGenerated.Controls.Add(lblQRNotGenerated)
        pnlQRNotGenerated.Dock = DockStyle.Fill
        pnlQRNotGenerated.Location = New Point(0, 0)
        pnlQRNotGenerated.Margin = New Padding(0)
        pnlQRNotGenerated.Name = "pnlQRNotGenerated"
        pnlQRNotGenerated.Size = New Size(302, 41)
        pnlQRNotGenerated.TabIndex = 0
        ' 
        ' lblQRNotGeneratedTitle
        ' 
        lblQRNotGeneratedTitle.AutoSize = True
        lblQRNotGeneratedTitle.Font = New Font("Segoe UI", 9.5F)
        lblQRNotGeneratedTitle.Location = New Point(12, 6)
        lblQRNotGeneratedTitle.Name = "lblQRNotGeneratedTitle"
        lblQRNotGeneratedTitle.Size = New Size(117, 17)
        lblQRNotGeneratedTitle.TabIndex = 0
        lblQRNotGeneratedTitle.Text = "QR Not Generated"
        ' 
        ' lblQRNotGenerated
        ' 
        lblQRNotGenerated.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblQRNotGenerated.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblQRNotGenerated.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblQRNotGenerated.Location = New Point(230, 5)
        lblQRNotGenerated.Name = "lblQRNotGenerated"
        lblQRNotGenerated.Size = New Size(60, 30)
        lblQRNotGenerated.TabIndex = 1
        lblQRNotGenerated.Text = "0"
        lblQRNotGenerated.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlNoExitToday
        ' 
        pnlNoExitToday.BackColor = Color.FromArgb(CByte(248), CByte(224), CByte(220))
        pnlNoExitToday.Controls.Add(lblNoExitTodayTitle)
        pnlNoExitToday.Controls.Add(lblNoExitToday)
        pnlNoExitToday.Dock = DockStyle.Fill
        pnlNoExitToday.Location = New Point(328, 0)
        pnlNoExitToday.Margin = New Padding(0)
        pnlNoExitToday.Name = "pnlNoExitToday"
        pnlNoExitToday.Size = New Size(302, 41)
        pnlNoExitToday.TabIndex = 1
        ' 
        ' lblNoExitTodayTitle
        ' 
        lblNoExitTodayTitle.AutoSize = True
        lblNoExitTodayTitle.Font = New Font("Segoe UI", 9.5F)
        lblNoExitTodayTitle.Location = New Point(12, 6)
        lblNoExitTodayTitle.Name = "lblNoExitTodayTitle"
        lblNoExitTodayTitle.Size = New Size(89, 17)
        lblNoExitTodayTitle.TabIndex = 0
        lblNoExitTodayTitle.Text = "No Exit Today"
        ' 
        ' lblNoExitToday
        ' 
        lblNoExitToday.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblNoExitToday.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblNoExitToday.ForeColor = Color.FromArgb(CByte(170), CByte(45), CByte(45))
        lblNoExitToday.Location = New Point(230, 5)
        lblNoExitToday.Name = "lblNoExitToday"
        lblNoExitToday.Size = New Size(60, 30)
        lblNoExitToday.TabIndex = 1
        lblNoExitToday.Text = "0"
        lblNoExitToday.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlFailedSMS
        ' 
        pnlFailedSMS.BackColor = Color.FromArgb(CByte(248), CByte(224), CByte(220))
        pnlFailedSMS.Controls.Add(lblFailedSMSTitle)
        pnlFailedSMS.Controls.Add(lblFailedSMS)
        pnlFailedSMS.Dock = DockStyle.Fill
        pnlFailedSMS.Location = New Point(656, 0)
        pnlFailedSMS.Margin = New Padding(0)
        pnlFailedSMS.Name = "pnlFailedSMS"
        pnlFailedSMS.Size = New Size(302, 41)
        pnlFailedSMS.TabIndex = 2
        ' 
        ' lblFailedSMSTitle
        ' 
        lblFailedSMSTitle.AutoSize = True
        lblFailedSMSTitle.Font = New Font("Segoe UI", 9.5F)
        lblFailedSMSTitle.Location = New Point(12, 6)
        lblFailedSMSTitle.Name = "lblFailedSMSTitle"
        lblFailedSMSTitle.Size = New Size(72, 17)
        lblFailedSMSTitle.TabIndex = 0
        lblFailedSMSTitle.Text = "Failed SMS"
        ' 
        ' lblFailedSMS
        ' 
        lblFailedSMS.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFailedSMS.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblFailedSMS.ForeColor = Color.FromArgb(CByte(170), CByte(45), CByte(45))
        lblFailedSMS.Location = New Point(230, 5)
        lblFailedSMS.Name = "lblFailedSMS"
        lblFailedSMS.Size = New Size(60, 30)
        lblFailedSMS.TabIndex = 1
        lblFailedSMS.Text = "0"
        lblFailedSMS.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' timerClock
        ' 
        timerClock.Enabled = True
        timerClock.Interval = 1000
        ' 
        ' UcDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Controls.Add(pnlQuickOverview)
        Controls.Add(tlpMiddle)
        Controls.Add(tlpStats)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UcDashboard"
        Size = New Size(1032, 540)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        tlpStats.ResumeLayout(False)
        pnlTotalStudents.ResumeLayout(False)
        pnlTotalStudents.PerformLayout()
        pnlQRGenerated.ResumeLayout(False)
        pnlQRGenerated.PerformLayout()
        pnlTodayEntry.ResumeLayout(False)
        pnlTodayEntry.PerformLayout()
        pnlTodayExit.ResumeLayout(False)
        pnlTodayExit.PerformLayout()
        tlpMiddle.ResumeLayout(False)
        pnlRecentEntryExit.ResumeLayout(False)
        CType(dgvRecentEntryExit, ComponentModel.ISupportInitialize).EndInit()
        pnlRecentEntryExitHeader.ResumeLayout(False)
        pnlRecentEntryExitHeader.PerformLayout()
        pnlRecentSMS.ResumeLayout(False)
        CType(dgvRecentSMS, ComponentModel.ISupportInitialize).EndInit()
        pnlRecentSMSHeader.ResumeLayout(False)
        pnlRecentSMSHeader.PerformLayout()
        pnlQuickOverview.ResumeLayout(False)
        pnlQuickOverview.PerformLayout()
        tlpQuickOverview.ResumeLayout(False)
        pnlQRNotGenerated.ResumeLayout(False)
        pnlQRNotGenerated.PerformLayout()
        pnlNoExitToday.ResumeLayout(False)
        pnlNoExitToday.PerformLayout()
        pnlFailedSMS.ResumeLayout(False)
        pnlFailedSMS.PerformLayout()
        ResumeLayout(False)

    End Sub


    '==================================================
    ' DECLARATIONS
    '==================================================

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label

    Friend WithEvents tlpStats As TableLayoutPanel

    Friend WithEvents pnlTotalStudents As Panel
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents lblTotalStudents As Label

    Friend WithEvents pnlQRGenerated As Panel
    Friend WithEvents lblQRGeneratedTitle As Label
    Friend WithEvents lblQRGenerated As Label

    Friend WithEvents pnlTodayEntry As Panel
    Friend WithEvents lblTodayEntryTitle As Label
    Friend WithEvents lblTodayEntry As Label

    Friend WithEvents pnlTodayExit As Panel
    Friend WithEvents lblTodayExitTitle As Label
    Friend WithEvents lblTodayExit As Label

    Friend WithEvents tlpMiddle As TableLayoutPanel

    Friend WithEvents pnlRecentEntryExit As Panel
    Friend WithEvents pnlRecentEntryExitHeader As Panel
    Friend WithEvents lblRecentEntryExitTitle As Label

    Friend WithEvents dgvRecentEntryExit As DataGridView

    Friend WithEvents colEntryStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colEntryStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colEntryYearCourse As DataGridViewTextBoxColumn
    Friend WithEvents colEntryTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colEntryTimeOut As DataGridViewTextBoxColumn

    Friend WithEvents pnlRecentSMS As Panel
    Friend WithEvents pnlRecentSMSHeader As Panel
    Friend WithEvents lblRecentSMSTitle As Label

    Friend WithEvents dgvRecentSMS As DataGridView

    Friend WithEvents colSMSStudent As DataGridViewTextBoxColumn
    Friend WithEvents colSMSType As DataGridViewTextBoxColumn
    Friend WithEvents colSMSSentAt As DataGridViewTextBoxColumn
    Friend WithEvents colSMSStatus As DataGridViewTextBoxColumn

    Friend WithEvents pnlQuickOverview As Panel
    Friend WithEvents lblQuickOverviewTitle As Label

    Friend WithEvents tlpQuickOverview As TableLayoutPanel

    Friend WithEvents pnlQRNotGenerated As Panel
    Friend WithEvents lblQRNotGeneratedTitle As Label
    Friend WithEvents lblQRNotGenerated As Label

    Friend WithEvents pnlNoExitToday As Panel
    Friend WithEvents lblNoExitTodayTitle As Label
    Friend WithEvents lblNoExitToday As Label

    Friend WithEvents pnlFailedSMS As Panel
    Friend WithEvents lblFailedSMSTitle As Label
    Friend WithEvents lblFailedSMS As Label

    Friend WithEvents timerClock As Timer

End Class