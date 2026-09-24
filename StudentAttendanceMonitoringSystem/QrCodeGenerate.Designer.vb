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
        Panel1 = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
        Panel2 = New Panel()
        cboQRStatus = New ComboBox()
        txtSearch = New TextBox()
        Panel3 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel6 = New Panel()
        lblSummary = New Label()
        Panel7 = New Panel()
        btnGenerateMissing = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel4 = New Panel()
        dgvStudents = New DataGridView()
        lblStudentList = New Label()
        Panel5 = New Panel()
        picQRCode = New PictureBox()
        btnPrintQR = New Button()
        btnDownloadQR = New Button()
        btnGenerateQR = New Button()
        lblQRStatus = New Label()
        lblYearCourse = New Label()
        lblStudentID = New Label()
        lblStudentName = New Label()
        lblQRPreviewTitle = New Label()
        colStudentID = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colYearCourse = New DataGridViewTextBoxColumn()
        colQRStatus = New DataGridViewTextBoxColumn()
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
        Panel1.Controls.Add(lblSubtitle)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(970, 100)
        Panel1.TabIndex = 0
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Location = New Point(14, 48)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(219, 15)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Generate and manage student QR codes"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(10, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(128, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "QR Code Management"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cboQRStatus)
        Panel2.Controls.Add(txtSearch)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(970, 100)
        Panel2.TabIndex = 1
        ' 
        ' cboQRStatus
        ' 
        cboQRStatus.FormattingEnabled = True
        cboQRStatus.Location = New Point(416, 40)
        cboQRStatus.Name = "cboQRStatus"
        cboQRStatus.Size = New Size(121, 23)
        cboQRStatus.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(37, 41)
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
        Panel3.Size = New Size(970, 100)
        Panel3.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(Panel6, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel7, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(970, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(lblSummary)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(3, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(673, 94)
        Panel6.TabIndex = 0
        ' 
        ' lblSummary
        ' 
        lblSummary.AutoSize = True
        lblSummary.Location = New Point(89, 29)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(71, 15)
        lblSummary.TabIndex = 0
        lblSummary.Text = "lblSummary"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(btnGenerateMissing)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(682, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(285, 94)
        Panel7.TabIndex = 1
        ' 
        ' btnGenerateMissing
        ' 
        btnGenerateMissing.Location = New Point(75, 29)
        btnGenerateMissing.Name = "btnGenerateMissing"
        btnGenerateMissing.Size = New Size(75, 23)
        btnGenerateMissing.TabIndex = 0
        btnGenerateMissing.Text = "btnGenerateMissing"
        btnGenerateMissing.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 68F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32F))
        TableLayoutPanel1.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel5, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 200)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(970, 389)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(251), CByte(247), CByte(242))
        Panel4.Controls.Add(dgvStudents)
        Panel4.Controls.Add(lblStudentList)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(10, 10)
        Panel4.Margin = New Padding(10)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(15)
        Panel4.Size = New Size(639, 369)
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
        Panel5.Controls.Add(picQRCode)
        Panel5.Controls.Add(btnPrintQR)
        Panel5.Controls.Add(btnDownloadQR)
        Panel5.Controls.Add(btnGenerateQR)
        Panel5.Controls.Add(lblQRStatus)
        Panel5.Controls.Add(lblYearCourse)
        Panel5.Controls.Add(lblStudentID)
        Panel5.Controls.Add(lblStudentName)
        Panel5.Controls.Add(lblQRPreviewTitle)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(669, 10)
        Panel5.Margin = New Padding(10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(291, 369)
        Panel5.TabIndex = 1
        ' 
        ' picQRCode
        ' 
        picQRCode.BackgroundImageLayout = ImageLayout.Zoom
        picQRCode.Location = New Point(116, 37)
        picQRCode.Name = "picQRCode"
        picQRCode.Size = New Size(145, 166)
        picQRCode.SizeMode = PictureBoxSizeMode.Zoom
        picQRCode.TabIndex = 8
        picQRCode.TabStop = False
        ' 
        ' btnPrintQR
        ' 
        btnPrintQR.Location = New Point(133, 251)
        btnPrintQR.Name = "btnPrintQR"
        btnPrintQR.Size = New Size(75, 23)
        btnPrintQR.TabIndex = 7
        btnPrintQR.Text = "btnPrintQR"
        btnPrintQR.UseVisualStyleBackColor = True
        ' 
        ' btnDownloadQR
        ' 
        btnDownloadQR.Location = New Point(17, 264)
        btnDownloadQR.Name = "btnDownloadQR"
        btnDownloadQR.Size = New Size(75, 23)
        btnDownloadQR.TabIndex = 6
        btnDownloadQR.Text = "btnDownloadQR"
        btnDownloadQR.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateQR
        ' 
        btnGenerateQR.Location = New Point(14, 233)
        btnGenerateQR.Name = "btnGenerateQR"
        btnGenerateQR.Size = New Size(75, 23)
        btnGenerateQR.TabIndex = 5
        btnGenerateQR.Text = "btnGenerateQR"
        btnGenerateQR.UseVisualStyleBackColor = True
        ' 
        ' lblQRStatus
        ' 
        lblQRStatus.AutoSize = True
        lblQRStatus.Location = New Point(17, 132)
        lblQRStatus.Name = "lblQRStatus"
        lblQRStatus.Size = New Size(68, 15)
        lblQRStatus.TabIndex = 4
        lblQRStatus.Text = "lblQRStatus"
        ' 
        ' lblYearCourse
        ' 
        lblYearCourse.AutoSize = True
        lblYearCourse.Location = New Point(18, 93)
        lblYearCourse.Name = "lblYearCourse"
        lblYearCourse.Size = New Size(79, 15)
        lblYearCourse.TabIndex = 3
        lblYearCourse.Text = "lblYearCourse"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Location = New Point(20, 75)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(72, 15)
        lblStudentID.TabIndex = 2
        lblStudentID.Text = "lblStudentID"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Location = New Point(17, 53)
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
        lblQRPreviewTitle.Size = New Size(87, 15)
        lblQRPreviewTitle.TabIndex = 0
        lblQRPreviewTitle.Text = "QRPreviewTitle"
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
        ' QrCodeGenerate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "QrCodeGenerate"
        Size = New Size(970, 689)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
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
    Friend WithEvents lblSummary As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnGenerateMissing As Button
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearCourse As DataGridViewTextBoxColumn
    Friend WithEvents colQRStatus As DataGridViewTextBoxColumn

End Class
