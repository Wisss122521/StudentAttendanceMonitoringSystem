<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QrCodeGenerate
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        cboQRStatus = New ComboBox()
        txtSearch = New TextBox()
        Panel3 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel6 = New Panel()
        btnGenerateMissing = New Button()
        btnGenerateQR = New Button()
        Panel7 = New Panel()
        lblNotGeneratedCount = New Label()
        lblGeneratedCount = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel4 = New Panel()
        dgvStudents = New DataGridView()
        colStudentID = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colYearCourse = New DataGridViewTextBoxColumn()
        colQRStatus = New DataGridViewTextBoxColumn()
        lblStudentList = New Label()
        Panel5 = New Panel()
        picQRCode = New PictureBox()
        btnPrintQR = New Button()
        btnDownloadQR = New Button()
        lblQRStatus = New Label()
        lblYearCourse = New Label()
        lblStudentID = New Label()
        lblStudentName = New Label()
        lblQRPreviewTitle = New Label()
        timerClock = New Timer(components)
        lblTotalStudents = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(picQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel1.Controls.Add(lblDateTime)
        Panel1.Controls.Add(lblSubtitle)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1368, 100)
        Panel1.TabIndex = 0
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateTime.ImageAlign = ContentAlignment.MiddleLeft
        lblDateTime.Location = New Point(794, 44)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(91, 25)
        lblDateTime.TabIndex = 2
        lblDateTime.Text = "lblDate"
        lblDateTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.Location = New Point(10, 66)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(280, 20)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Generate and Manage Student QR Codes"
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(10, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(443, 43)
        lblTitle.TabIndex = 0
        lblTitle.Text = "QR Code Management"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(cboQRStatus)
        Panel2.Controls.Add(txtSearch)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1368, 100)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(678, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 3
        Label2.Text = "QR Status"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 2
        Label1.Text = "Search Student"
        ' 
        ' cboQRStatus
        ' 
        cboQRStatus.FormattingEnabled = True
        cboQRStatus.Location = New Point(742, 45)
        cboQRStatus.Name = "cboQRStatus"
        cboQRStatus.Size = New Size(121, 23)
        cboQRStatus.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(235, 40)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel2)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 589)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1368, 100)
        Panel3.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.White
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        TableLayoutPanel2.Controls.Add(Panel6, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel7, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel2.Size = New Size(1368, 100)
        TableLayoutPanel2.Size = New Size(970, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(btnGenerateMissing)
        Panel6.Controls.Add(btnGenerateQR)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(3, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(951, 94)
        Panel6.TabIndex = 0
        ' 
        ' btnGenerateMissing
        ' 
        btnGenerateMissing.Location = New Point(554, 37)
        btnGenerateMissing.Name = "btnGenerateMissing"
        btnGenerateMissing.Size = New Size(216, 23)
        btnGenerateMissing.TabIndex = 0
        btnGenerateMissing.Text = "Generate All Missing QR Codes"
        btnGenerateMissing.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateQR
        ' 
        btnGenerateQR.Location = New Point(59, 37)
        btnGenerateQR.Name = "btnGenerateQR"
        btnGenerateQR.Size = New Size(218, 23)
        btnGenerateQR.TabIndex = 5
        btnGenerateQR.Text = "Generate Selected QR Code(s)"
        btnGenerateQR.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(lblNotGeneratedCount)
        Panel7.Controls.Add(lblGeneratedCount)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(960, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(405, 94)
        Panel7.TabIndex = 1
        ' 
        ' lblNotGeneratedCount
        ' 
        lblNotGeneratedCount.AutoSize = True
        lblNotGeneratedCount.Location = New Point(181, 39)
        lblNotGeneratedCount.Name = "lblNotGeneratedCount"
        lblNotGeneratedCount.Size = New Size(127, 15)
        lblNotGeneratedCount.TabIndex = 1
        lblNotGeneratedCount.Text = "lblNotGeneratedCount"
        ' 
        ' lblGeneratedCount
        ' 
        lblGeneratedCount.AutoSize = True
        lblGeneratedCount.Location = New Point(30, 37)
        lblGeneratedCount.Name = "lblGeneratedCount"
        lblGeneratedCount.Size = New Size(107, 15)
        lblGeneratedCount.TabIndex = 0
        lblGeneratedCount.Text = "lblGeneratedCount"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 68.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.0F))
        TableLayoutPanel1.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel5, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 200)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(1368, 389)
        TableLayoutPanel1.Size = New Size(970, 389)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(lblTotalStudents)
        Panel4.Controls.Add(dgvStudents)
        Panel4.Controls.Add(lblStudentList)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(10, 10)
        Panel4.Margin = New Padding(10)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(15)
        Panel4.Size = New Size(910, 369)
        Panel4.TabIndex = 0
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = Color.FromArgb(CByte(251), CByte(247), CByte(242))
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {colStudentID, colStudentName, colYearCourse, colQRStatus})
        dgvStudents.Location = New Point(17, 75)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(588, 199)
        dgvStudents.TabIndex = 1
        ' 
        ' colStudentID
        ' 
        colStudentID.DataPropertyName = "students_id"
        colStudentID.HeaderText = "Student ID"
        colStudentID.Name = "colStudentID"
        colStudentID.ReadOnly = True
        ' 
        ' colStudentName
        ' 
        colStudentName.DataPropertyName = "students_name"
        colStudentName.HeaderText = "Student Name"
        colStudentName.Name = "colStudentName"
        colStudentName.ReadOnly = True
        ' 
        ' colYearCourse
        ' 
        colYearCourse.DataPropertyName = "year_course"
        colYearCourse.HeaderText = "Year / Course"
        colYearCourse.Name = "colYearCourse"
        colYearCourse.ReadOnly = True
        ' 
        ' colQRStatus
        ' 
        colQRStatus.DataPropertyName = "qr_status"
        colQRStatus.HeaderText = "qr_status"
        colQRStatus.Name = "colQRStatus"
        colQRStatus.ReadOnly = True
        ' 
        ' lblStudentList
        ' 
        lblStudentList.AutoSize = True
        lblStudentList.Location = New Point(17, 15)
        lblStudentList.Name = "lblStudentList"
        lblStudentList.Size = New Size(69, 15)
        lblStudentList.TabIndex = 0
        lblStudentList.Text = "Student List"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(picQRCode)
        Panel5.Controls.Add(btnPrintQR)
        Panel5.Controls.Add(btnDownloadQR)
        Panel5.Controls.Add(lblQRStatus)
        Panel5.Controls.Add(lblYearCourse)
        Panel5.Controls.Add(lblStudentID)
        Panel5.Controls.Add(lblStudentName)
        Panel5.Controls.Add(lblQRPreviewTitle)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(940, 10)
        Panel5.Margin = New Padding(10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(418, 369)
        Panel5.TabIndex = 1
        ' 
        ' picQRCode
        ' 
        picQRCode.BackgroundImageLayout = ImageLayout.Zoom
        picQRCode.Location = New Point(133, 15)
        picQRCode.Name = "picQRCode"
        picQRCode.Size = New Size(145, 166)
        picQRCode.SizeMode = PictureBoxSizeMode.Zoom
        picQRCode.TabIndex = 8
        picQRCode.TabStop = False
        ' 
        ' btnPrintQR
        ' 
        btnPrintQR.Location = New Point(304, 320)
        btnPrintQR.Name = "btnPrintQR"
        btnPrintQR.Size = New Size(75, 23)
        btnPrintQR.TabIndex = 7
        btnPrintQR.Text = "Print QR"
        btnPrintQR.UseVisualStyleBackColor = True
        ' 
        ' btnDownloadQR
        ' 
        btnDownloadQR.Location = New Point(22, 320)
        btnDownloadQR.Name = "btnDownloadQR"
        btnDownloadQR.Size = New Size(75, 23)
        btnDownloadQR.TabIndex = 6
        btnDownloadQR.Text = "Download QR"
        btnDownloadQR.UseVisualStyleBackColor = True
        ' 
        ' lblQRStatus
        ' 
        lblQRStatus.AutoSize = True
        lblQRStatus.Location = New Point(50, 281)
        lblQRStatus.Name = "lblQRStatus"
        lblQRStatus.Size = New Size(68, 15)
        lblQRStatus.TabIndex = 4
        lblQRStatus.Text = "lblQRStatus"
        ' 
        ' lblYearCourse
        ' 
        lblYearCourse.AutoSize = True
        lblYearCourse.Location = New Point(51, 242)
        lblYearCourse.Name = "lblYearCourse"
        lblYearCourse.Size = New Size(79, 15)
        lblYearCourse.TabIndex = 3
        lblYearCourse.Text = "lblYearCourse"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Location = New Point(53, 224)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(72, 15)
        lblStudentID.TabIndex = 2
        lblStudentID.Text = "lblStudentID"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Location = New Point(50, 202)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(93, 15)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "lblStudentName"
        ' 
        ' lblQRPreviewTitle
        ' 
        lblQRPreviewTitle.AutoSize = True
        lblQRPreviewTitle.Location = New Point(18, 21)
        lblQRPreviewTitle.Name = "lblQRPreviewTitle"
        lblQRPreviewTitle.Size = New Size(86, 15)
        lblQRPreviewTitle.TabIndex = 0
        lblQRPreviewTitle.Text = "QRPreviewTitle"
        ' 
        ' timerClock
        ' 
        ' 
        ' lblTotalStudents
        ' 
        lblTotalStudents.AutoSize = True
        lblTotalStudents.Location = New Point(488, 15)
        lblTotalStudents.Name = "lblTotalStudents"
        lblTotalStudents.Size = New Size(91, 15)
        lblTotalStudents.TabIndex = 2
        lblTotalStudents.Text = "lblTotalStudents"
        ' 
        ' QrCodeGenerate
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(242), CByte(237))
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "QrCodeGenerate"
        Size = New Size(1368, 689)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(picQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cboQRStatus As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblStudentList As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents btnPrintQR As Button
    Friend WithEvents btnDownloadQR As Button
    Friend WithEvents btnGenerateQR As Button
    Friend WithEvents lblQRStatus As Label
    Friend WithEvents lblYearCourse As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblQRPreviewTitle As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblGeneratedCount As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnGenerateMissing As Button
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents timerClock As Timer
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearCourse As DataGridViewTextBoxColumn
    Friend WithEvents colQRStatus As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNotGeneratedCount As Label
    Friend WithEvents lblTotalStudents As Label

End Class
