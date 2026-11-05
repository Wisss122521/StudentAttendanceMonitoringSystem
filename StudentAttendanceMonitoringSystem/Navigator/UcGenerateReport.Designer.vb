<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcGenerateReport

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
        lblDateTime = New Label()
        timerClock = New Timer(components)
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlFilters = New Panel()
        btnReset = New Button()
        btnApplyFilter = New Button()
        cboCourse = New ComboBox()
        lblCourse = New Label()
        dtpTo = New DateTimePicker()
        lblDateTo = New Label()
        dtpFrom = New DateTimePicker()
        lblDateFrom = New Label()
        txtSearch = New TextBox()
        lblSearch = New Label()
        pnlFiltersHeader = New Panel()
        lblFiltersTitle = New Label()
        pnlRecords = New Panel()
        dgvAttendance = New DataGridView()
        pnlRecordsHeader = New Panel()
        lblRecordsTitle = New Label()
        pnlSummary = New Panel()
        btnGeneratePDF = New Button()
        btnGenerateExcel = New Button()
        pnlNoTimeOut = New Panel()
        picNoTimeOutIcon = New PictureBox()
        lblNoTimeOut = New Label()
        lblNoTimeOutTitle = New Label()
        pnlComplete = New Panel()
        picCompleteIcon = New PictureBox()
        lblComplete = New Label()
        lblCompleteTitle = New Label()
        pnlTotalRecords = New Panel()
        picTotalRecordsIcon = New PictureBox()
        lblTotalRecords = New Label()
        lblTotalRecordsTitle = New Label()
        lblSummaryTitle = New Label()
        pnlHeader.SuspendLayout()
        pnlFilters.SuspendLayout()
        pnlFiltersHeader.SuspendLayout()
        pnlRecords.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        pnlRecordsHeader.SuspendLayout()
        pnlSummary.SuspendLayout()
        pnlNoTimeOut.SuspendLayout()
        CType(picNoTimeOutIcon, ComponentModel.ISupportInitialize).BeginInit()
        pnlComplete.SuspendLayout()
        CType(picCompleteIcon, ComponentModel.ISupportInitialize).BeginInit()
        pnlTotalRecords.SuspendLayout()
        CType(picTotalRecordsIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' timerClock
        ' 
        timerClock.Interval = 1000
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
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(998, 68)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        lblSubtitle.Location = New Point(23, 44)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(318, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "View, filter and generate student entry/exit reports"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 24.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTitle.Location = New Point(19, 6)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(468, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Student Entry/Exit Reports"
        ' 
        ' pnlFilters
        ' 
        pnlFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFilters.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlFilters.BorderStyle = BorderStyle.FixedSingle
        pnlFilters.Controls.Add(btnReset)
        pnlFilters.Controls.Add(btnApplyFilter)
        pnlFilters.Controls.Add(cboCourse)
        pnlFilters.Controls.Add(lblCourse)
        pnlFilters.Controls.Add(dtpTo)
        pnlFilters.Controls.Add(lblDateTo)
        pnlFilters.Controls.Add(dtpFrom)
        pnlFilters.Controls.Add(lblDateFrom)
        pnlFilters.Controls.Add(txtSearch)
        pnlFilters.Controls.Add(lblSearch)
        pnlFilters.Controls.Add(pnlFiltersHeader)
        pnlFilters.Location = New Point(18, 90)
        pnlFilters.Name = "pnlFilters"
        pnlFilters.Size = New Size(998, 92)
        pnlFilters.TabIndex = 1
        ' 
        ' btnReset
        ' 
        btnReset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnReset.BackColor = Color.FromArgb(CByte(242), CByte(230), CByte(220))
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnReset.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnReset.Location = New Point(884, 56)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 30)
        btnReset.TabIndex = 10
        btnReset.Text = "Reset Filters"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnApplyFilter
        ' 
        btnApplyFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnApplyFilter.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        btnApplyFilter.Cursor = Cursors.Hand
        btnApplyFilter.FlatAppearance.BorderSize = 0
        btnApplyFilter.FlatStyle = FlatStyle.Flat
        btnApplyFilter.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnApplyFilter.ForeColor = Color.White
        btnApplyFilter.Location = New Point(786, 56)
        btnApplyFilter.Name = "btnApplyFilter"
        btnApplyFilter.Size = New Size(90, 30)
        btnApplyFilter.TabIndex = 9
        btnApplyFilter.Text = "Apply Filter"
        btnApplyFilter.UseVisualStyleBackColor = False
        ' 
        ' cboCourse
        ' 
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.Font = New Font("Segoe UI", 9.0F)
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(639, 61)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(130, 23)
        cboCourse.TabIndex = 8
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblCourse.Location = New Point(639, 43)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(43, 15)
        lblCourse.TabIndex = 7
        lblCourse.Text = "Course"
        ' 
        ' dtpTo
        ' 
        dtpTo.CustomFormat = "MMMM dd, yyyy"
        dtpTo.Font = New Font("Segoe UI", 9.0F)
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.Location = New Point(442, 61)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(180, 23)
        dtpTo.TabIndex = 6
        ' 
        ' lblDateTo
        ' 
        lblDateTo.AutoSize = True
        lblDateTo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDateTo.Location = New Point(442, 43)
        lblDateTo.Name = "lblDateTo"
        lblDateTo.Size = New Size(48, 15)
        lblDateTo.TabIndex = 5
        lblDateTo.Text = "Date To"
        ' 
        ' dtpFrom
        ' 
        dtpFrom.CustomFormat = "MMMM dd, yyyy"
        dtpFrom.Font = New Font("Segoe UI", 9.0F)
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.Location = New Point(245, 61)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(180, 23)
        dtpFrom.TabIndex = 4
        ' 
        ' lblDateFrom
        ' 
        lblDateFrom.AutoSize = True
        lblDateFrom.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDateFrom.Location = New Point(245, 43)
        lblDateFrom.Name = "lblDateFrom"
        lblDateFrom.Size = New Size(63, 15)
        lblDateFrom.TabIndex = 3
        lblDateFrom.Text = "Date From"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.0F)
        txtSearch.Location = New Point(18, 61)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(210, 23)
        txtSearch.TabIndex = 2
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblSearch.Location = New Point(18, 43)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(88, 15)
        lblSearch.TabIndex = 1
        lblSearch.Text = "Search Student"
        ' 
        ' pnlFiltersHeader
        ' 
        pnlFiltersHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlFiltersHeader.Controls.Add(lblFiltersTitle)
        pnlFiltersHeader.Dock = DockStyle.Top
        pnlFiltersHeader.Location = New Point(0, 0)
        pnlFiltersHeader.Name = "pnlFiltersHeader"
        pnlFiltersHeader.Size = New Size(996, 38)
        pnlFiltersHeader.TabIndex = 0
        ' 
        ' lblFiltersTitle
        ' 
        lblFiltersTitle.AutoSize = True
        lblFiltersTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblFiltersTitle.ForeColor = Color.White
        lblFiltersTitle.Location = New Point(14, 8)
        lblFiltersTitle.Name = "lblFiltersTitle"
        lblFiltersTitle.Size = New Size(109, 21)
        lblFiltersTitle.TabIndex = 0
        lblFiltersTitle.Text = "Report Filters"
        ' 
        ' pnlRecords
        ' 
        pnlRecords.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRecords.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlRecords.BorderStyle = BorderStyle.FixedSingle
        pnlRecords.Controls.Add(dgvAttendance)
        pnlRecords.Controls.Add(pnlRecordsHeader)
        pnlRecords.Location = New Point(18, 192)
        pnlRecords.Name = "pnlRecords"
        pnlRecords.Size = New Size(998, 301)
        pnlRecords.TabIndex = 2
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.AllowUserToAddRows = False
        dgvAttendance.AllowUserToDeleteRows = False
        dgvAttendance.AllowUserToResizeRows = False
        dgvAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAttendance.BackgroundColor = Color.White
        dgvAttendance.BorderStyle = BorderStyle.None
        dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAttendance.ColumnHeadersHeight = 42
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(50), CByte(35), CByte(28))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(52), CByte(32), CByte(23))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvAttendance.DefaultCellStyle = DataGridViewCellStyle2
        dgvAttendance.EnableHeadersVisualStyles = False
        dgvAttendance.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvAttendance.Location = New Point(18, 50)
        dgvAttendance.MultiSelect = False
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.ReadOnly = True
        dgvAttendance.RowHeadersVisible = False
        dgvAttendance.RowTemplate.Height = 38
        dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendance.Size = New Size(960, 232)
        dgvAttendance.TabIndex = 1
        ' 
        ' pnlRecordsHeader
        ' 
        pnlRecordsHeader.BackColor = Color.FromArgb(CByte(97), CByte(55), CByte(31))
        pnlRecordsHeader.Controls.Add(lblRecordsTitle)
        pnlRecordsHeader.Dock = DockStyle.Top
        pnlRecordsHeader.Location = New Point(0, 0)
        pnlRecordsHeader.Name = "pnlRecordsHeader"
        pnlRecordsHeader.Size = New Size(996, 38)
        pnlRecordsHeader.TabIndex = 0
        ' 
        ' lblRecordsTitle
        ' 
        lblRecordsTitle.AutoSize = True
        lblRecordsTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblRecordsTitle.ForeColor = Color.White
        lblRecordsTitle.Location = New Point(14, 8)
        lblRecordsTitle.Name = "lblRecordsTitle"
        lblRecordsTitle.Size = New Size(153, 21)
        lblRecordsTitle.TabIndex = 0
        lblRecordsTitle.Text = "Entry / Exit Records"
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummary.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlSummary.BorderStyle = BorderStyle.FixedSingle
        pnlSummary.Controls.Add(btnGeneratePDF)
        pnlSummary.Controls.Add(btnGenerateExcel)
        pnlSummary.Controls.Add(pnlNoTimeOut)
        pnlSummary.Controls.Add(pnlComplete)
        pnlSummary.Controls.Add(pnlTotalRecords)
        pnlSummary.Controls.Add(lblSummaryTitle)
        pnlSummary.Location = New Point(18, 499)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(998, 108)
        pnlSummary.TabIndex = 3
        ' 
        ' btnGeneratePDF
        ' 
        btnGeneratePDF.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGeneratePDF.BackColor = Color.FromArgb(CByte(242), CByte(230), CByte(220))
        btnGeneratePDF.Cursor = Cursors.Hand
        btnGeneratePDF.FlatAppearance.BorderColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        btnGeneratePDF.FlatStyle = FlatStyle.Flat
        btnGeneratePDF.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnGeneratePDF.ForeColor = Color.FromArgb(CByte(75), CByte(41), CByte(24))
        btnGeneratePDF.Location = New Point(844, 30)
        btnGeneratePDF.Name = "btnGeneratePDF"
        btnGeneratePDF.Size = New Size(128, 41)
        btnGeneratePDF.TabIndex = 5
        btnGeneratePDF.Text = "Generate PDF"
        btnGeneratePDF.UseVisualStyleBackColor = False
        ' 
        ' btnGenerateExcel
        ' 
        btnGenerateExcel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGenerateExcel.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        btnGenerateExcel.Cursor = Cursors.Hand
        btnGenerateExcel.FlatAppearance.BorderSize = 0
        btnGenerateExcel.FlatStyle = FlatStyle.Flat
        btnGenerateExcel.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnGenerateExcel.ForeColor = Color.White
        btnGenerateExcel.Location = New Point(708, 30)
        btnGenerateExcel.Name = "btnGenerateExcel"
        btnGenerateExcel.Size = New Size(128, 41)
        btnGenerateExcel.TabIndex = 4
        btnGenerateExcel.Text = "Generate Excel"
        btnGenerateExcel.UseVisualStyleBackColor = False
        ' 
        ' pnlNoTimeOut
        ' 
        pnlNoTimeOut.BackColor = Color.FromArgb(CByte(248), CByte(224), CByte(220))
        pnlNoTimeOut.Controls.Add(picNoTimeOutIcon)
        pnlNoTimeOut.Controls.Add(lblNoTimeOut)
        pnlNoTimeOut.Controls.Add(lblNoTimeOutTitle)
        pnlNoTimeOut.Location = New Point(454, 30)
        pnlNoTimeOut.Name = "pnlNoTimeOut"
        pnlNoTimeOut.Size = New Size(210, 60)
        pnlNoTimeOut.TabIndex = 3
        ' 
        ' picNoTimeOutIcon
        ' 
        picNoTimeOutIcon.BackColor = Color.Transparent
        picNoTimeOutIcon.Image = My.Resources.Resources.dashboard_no_exit
        picNoTimeOutIcon.Location = New Point(1, 0)
        picNoTimeOutIcon.Name = "picNoTimeOutIcon"
        picNoTimeOutIcon.Size = New Size(60, 60)
        picNoTimeOutIcon.SizeMode = PictureBoxSizeMode.Zoom
        picNoTimeOutIcon.TabIndex = 2
        picNoTimeOutIcon.TabStop = False
        ' 
        ' lblNoTimeOut
        ' 
        lblNoTimeOut.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblNoTimeOut.ForeColor = Color.FromArgb(CByte(170), CByte(45), CByte(45))
        lblNoTimeOut.Location = New Point(62, 31)
        lblNoTimeOut.Name = "lblNoTimeOut"
        lblNoTimeOut.Size = New Size(145, 24)
        lblNoTimeOut.TabIndex = 1
        lblNoTimeOut.Text = "0"
        lblNoTimeOut.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNoTimeOutTitle
        ' 
        lblNoTimeOutTitle.AutoSize = True
        lblNoTimeOutTitle.Font = New Font("Segoe UI", 8.5F)
        lblNoTimeOutTitle.ForeColor = Color.FromArgb(CByte(120), CByte(55), CByte(55))
        lblNoTimeOutTitle.Location = New Point(67, 15)
        lblNoTimeOutTitle.Name = "lblNoTimeOutTitle"
        lblNoTimeOutTitle.Size = New Size(85, 15)
        lblNoTimeOutTitle.TabIndex = 0
        lblNoTimeOutTitle.Text = "No Exit Record"
        ' 
        ' pnlComplete
        ' 
        pnlComplete.BackColor = Color.FromArgb(CByte(226), CByte(242), CByte(230))
        pnlComplete.Controls.Add(picCompleteIcon)
        pnlComplete.Controls.Add(lblComplete)
        pnlComplete.Controls.Add(lblCompleteTitle)
        pnlComplete.Location = New Point(236, 30)
        pnlComplete.Name = "pnlComplete"
        pnlComplete.Size = New Size(210, 60)
        pnlComplete.TabIndex = 2
        ' 
        ' picCompleteIcon
        ' 
        picCompleteIcon.BackColor = Color.Transparent
        picCompleteIcon.Image = My.Resources.Resources.dashboard_entry
        picCompleteIcon.Location = New Point(1, 0)
        picCompleteIcon.Name = "picCompleteIcon"
        picCompleteIcon.Size = New Size(60, 60)
        picCompleteIcon.SizeMode = PictureBoxSizeMode.Zoom
        picCompleteIcon.TabIndex = 2
        picCompleteIcon.TabStop = False
        ' 
        ' lblComplete
        ' 
        lblComplete.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblComplete.ForeColor = Color.FromArgb(CByte(40), CByte(100), CByte(60))
        lblComplete.Location = New Point(62, 31)
        lblComplete.Name = "lblComplete"
        lblComplete.Size = New Size(145, 24)
        lblComplete.TabIndex = 1
        lblComplete.Text = "0"
        lblComplete.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCompleteTitle
        ' 
        lblCompleteTitle.AutoSize = True
        lblCompleteTitle.Font = New Font("Segoe UI", 8.5F)
        lblCompleteTitle.ForeColor = Color.FromArgb(CByte(50), CByte(90), CByte(60))
        lblCompleteTitle.Location = New Point(67, 15)
        lblCompleteTitle.Name = "lblCompleteTitle"
        lblCompleteTitle.Size = New Size(119, 15)
        lblCompleteTitle.TabIndex = 0
        lblCompleteTitle.Text = "Complete Entry / Exit"
        ' 
        ' pnlTotalRecords
        ' 
        pnlTotalRecords.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        pnlTotalRecords.Controls.Add(picTotalRecordsIcon)
        pnlTotalRecords.Controls.Add(lblTotalRecords)
        pnlTotalRecords.Controls.Add(lblTotalRecordsTitle)
        pnlTotalRecords.Location = New Point(18, 30)
        pnlTotalRecords.Name = "pnlTotalRecords"
        pnlTotalRecords.Size = New Size(210, 60)
        pnlTotalRecords.TabIndex = 1
        ' 
        ' picTotalRecordsIcon
        ' 
        picTotalRecordsIcon.BackColor = Color.Transparent
        picTotalRecordsIcon.BackgroundImageLayout = ImageLayout.Zoom
        picTotalRecordsIcon.Image = My.Resources.Resources.dashboard_students
        picTotalRecordsIcon.Location = New Point(1, 0)
        picTotalRecordsIcon.Name = "picTotalRecordsIcon"
        picTotalRecordsIcon.Size = New Size(60, 60)
        picTotalRecordsIcon.SizeMode = PictureBoxSizeMode.Zoom
        picTotalRecordsIcon.TabIndex = 2
        picTotalRecordsIcon.TabStop = False
        ' 
        ' lblTotalRecords
        ' 
        lblTotalRecords.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblTotalRecords.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTotalRecords.Location = New Point(63, 31)
        lblTotalRecords.Name = "lblTotalRecords"
        lblTotalRecords.Size = New Size(144, 24)
        lblTotalRecords.TabIndex = 1
        lblTotalRecords.Text = "0"
        lblTotalRecords.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTotalRecordsTitle
        ' 
        lblTotalRecordsTitle.AutoSize = True
        lblTotalRecordsTitle.Font = New Font("Segoe UI", 8.5F)
        lblTotalRecordsTitle.ForeColor = Color.FromArgb(CByte(75), CByte(54), CByte(43))
        lblTotalRecordsTitle.Location = New Point(66, 15)
        lblTotalRecordsTitle.Name = "lblTotalRecordsTitle"
        lblTotalRecordsTitle.Size = New Size(77, 15)
        lblTotalRecordsTitle.TabIndex = 0
        lblTotalRecordsTitle.Text = "Total Records"
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
        ' UcGenerateReport
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Controls.Add(pnlSummary)
        Controls.Add(pnlRecords)
        Controls.Add(pnlFilters)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        Name = "UcGenerateReport"
        Size = New Size(1032, 622)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFilters.ResumeLayout(False)
        pnlFilters.PerformLayout()
        pnlFiltersHeader.ResumeLayout(False)
        pnlFiltersHeader.PerformLayout()
        pnlRecords.ResumeLayout(False)
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        pnlRecordsHeader.ResumeLayout(False)
        pnlRecordsHeader.PerformLayout()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        pnlNoTimeOut.ResumeLayout(False)
        pnlNoTimeOut.PerformLayout()
        CType(picNoTimeOutIcon, ComponentModel.ISupportInitialize).EndInit()
        pnlComplete.ResumeLayout(False)
        pnlComplete.PerformLayout()
        CType(picCompleteIcon, ComponentModel.ISupportInitialize).EndInit()
        pnlTotalRecords.ResumeLayout(False)
        pnlTotalRecords.PerformLayout()
        CType(picTotalRecordsIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub


    '==================================================
    ' DECLARATIONS
    '==================================================

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label


    Friend WithEvents pnlFilters As Panel
    Friend WithEvents pnlFiltersHeader As Panel
    Friend WithEvents lblFiltersTitle As Label


    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox


    Friend WithEvents lblDateFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker


    Friend WithEvents lblDateTo As Label
    Friend WithEvents dtpTo As DateTimePicker


    Friend WithEvents lblCourse As Label
    Friend WithEvents cboCourse As ComboBox


    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents btnReset As Button


    Friend WithEvents pnlRecords As Panel
    Friend WithEvents pnlRecordsHeader As Panel
    Friend WithEvents lblRecordsTitle As Label


    Friend WithEvents dgvAttendance As DataGridView


    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearCourse As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colTimeOut As DataGridViewTextBoxColumn


    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label


    Friend WithEvents pnlTotalRecords As Panel
    Friend WithEvents picTotalRecordsIcon As PictureBox
    Friend WithEvents lblTotalRecordsTitle As Label
    Friend WithEvents lblTotalRecords As Label


    Friend WithEvents pnlComplete As Panel
    Friend WithEvents picCompleteIcon As PictureBox
    Friend WithEvents lblCompleteTitle As Label
    Friend WithEvents lblComplete As Label


    Friend WithEvents pnlNoTimeOut As Panel
    Friend WithEvents picNoTimeOutIcon As PictureBox
    Friend WithEvents lblNoTimeOutTitle As Label
    Friend WithEvents lblNoTimeOut As Label


    Friend WithEvents btnGenerateExcel As Button
    Friend WithEvents btnGeneratePDF As Button


    Friend WithEvents lblDateTime As Label
    Friend WithEvents timerClock As Timer

End Class