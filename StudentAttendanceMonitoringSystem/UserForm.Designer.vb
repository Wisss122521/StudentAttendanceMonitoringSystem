<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label10 = New Label()
        dgvAttendance = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel4 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        txtQrCode = New TextBox()
        Panel7 = New Panel()
        lblYearLevel = New Label()
        lblParentNumber = New Label()
        Panel5 = New Panel()
        PictureBox3 = New PictureBox()
        lblTime = New Label()
        lblAttendance = New Label()
        lblStatus = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        lblStudentName = New Label()
        timerClock = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(247), CByte(242), CByte(237))
        Panel1.Controls.Add(lblDateTime)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1698, 94)
        Panel1.TabIndex = 0
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateTime.ImageAlign = ContentAlignment.MiddleLeft
        lblDateTime.Location = New Point(1158, 41)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(91, 25)
        lblDateTime.TabIndex = 1
        lblDateTime.Text = "lblDate"
        lblDateTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(353, 20)
        Label2.TabIndex = 3
        Label2.Text = "SCAN • RECORD • BUILD A STRENGTH TOMORROW"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(450, 56)
        Label1.TabIndex = 0
        Label1.Text = "Mark Attendance"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(242), CByte(237))
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(dgvAttendance)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 346)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1698, 479)
        Panel2.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 0)
        Label10.Margin = New Padding(3, 3, 3, 3)
        Label10.Name = "Label10"
        Label10.Size = New Size(178, 29)
        Label10.TabIndex = 1
        Label10.Text = "Recent Scans"
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.AllowUserToAddRows = False
        dgvAttendance.AllowUserToDeleteRows = False
        dgvAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAttendance.BackgroundColor = Color.FromArgb(CByte(251), CByte(247), CByte(242))
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvAttendance.Location = New Point(12, 35)
        dgvAttendance.MultiSelect = False
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.ReadOnly = True
        dgvAttendance.RowHeadersWidth = 51
        dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendance.Size = New Size(1674, 432)
        dgvAttendance.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.DataPropertyName = "attendance_id"
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.DataPropertyName = "students_id"
        Column2.HeaderText = "Student ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "attendance_date"
        Column3.HeaderText = "Date"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.DataPropertyName = "time_in"
        Column4.HeaderText = "Time In"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.DataPropertyName = "time_out"
        Column5.HeaderText = "Time Out"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 94)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1698, 252)
        Panel3.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(247), CByte(242), CByte(237))
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel7, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1698, 252)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(251), CByte(247), CByte(242))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(txtQrCode)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(12, 12)
        Panel4.Margin = New Padding(12, 12, 12, 12)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(20, 20, 20, 20)
        Panel4.Size = New Size(825, 228)
        Panel4.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(231, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(381, 20)
        Label5.TabIndex = 4
        Label5.Text = "Scan the QR Code or type the student ID and press Enter"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(257, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(333, 20)
        Label4.TabIndex = 3
        Label4.Text = "Scan the student's QR Code to record attendance"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.ErrorImage = My.Resources.Resources.qr_code_scan_icon
        PictureBox2.Image = My.Resources.Resources.qr_code_scan_icon
        PictureBox2.InitialImage = My.Resources.Resources.qr_code_scan_icon
        PictureBox2.Location = New Point(324, -87)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(171, 156)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(240, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(370, 56)
        Label3.TabIndex = 1
        Label3.Text = "Ready to Scan"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtQrCode
        ' 
        txtQrCode.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtQrCode.BackColor = Color.FromArgb(CByte(250), CByte(246), CByte(241))
        txtQrCode.CharacterCasing = CharacterCasing.Upper
        txtQrCode.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQrCode.Location = New Point(91, 192)
        txtQrCode.Multiline = True
        txtQrCode.Name = "txtQrCode"
        txtQrCode.PlaceholderText = "Scan QR Code here..."
        txtQrCode.RightToLeft = RightToLeft.No
        txtQrCode.Size = New Size(630, 41)
        txtQrCode.TabIndex = 0
        txtQrCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(251), CByte(247), CByte(242))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(lblYearLevel)
        Panel7.Controls.Add(lblParentNumber)
        Panel7.Controls.Add(Panel5)
        Panel7.Controls.Add(PictureBox1)
        Panel7.Controls.Add(Label7)
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(lblStudentName)
        Panel7.Dock = DockStyle.Fill
        Panel7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel7.Location = New Point(861, 12)
        Panel7.Margin = New Padding(12, 12, 12, 12)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(20, 20, 20, 20)
        Panel7.Size = New Size(825, 228)
        Panel7.TabIndex = 1
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.Anchor = AnchorStyles.None
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblYearLevel.Location = New Point(349, 98)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(195, 37)
        lblYearLevel.TabIndex = 11
        lblYearLevel.Text = "2nd Year - BSIT"
        ' 
        ' lblParentNumber
        ' 
        lblParentNumber.Anchor = AnchorStyles.None
        lblParentNumber.AutoSize = True
        lblParentNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblParentNumber.Location = New Point(349, 150)
        lblParentNumber.Name = "lblParentNumber"
        lblParentNumber.Size = New Size(182, 37)
        lblParentNumber.TabIndex = 10
        lblParentNumber.Text = "09217467275"
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = Color.OldLace
        Panel5.Controls.Add(PictureBox3)
        Panel5.Controls.Add(lblTime)
        Panel5.Controls.Add(lblAttendance)
        Panel5.Controls.Add(lblStatus)
        Panel5.Location = New Point(23, 104)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(777, 100)
        Panel5.TabIndex = 9
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox3.Image = My.Resources.Resources.right_arrow_6421_1024
        PictureBox3.Location = New Point(12, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(84, 76)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblTime.AutoSize = True
        lblTime.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(542, 32)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(130, 34)
        lblTime.TabIndex = 3
        lblTime.Text = "lblTime"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblAttendance.AutoSize = True
        lblAttendance.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendance.Location = New Point(109, 54)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(138, 21)
        lblAttendance.TabIndex = 8
        lblAttendance.Text = "                                "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(109, 20)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(149, 34)
        lblStatus.TabIndex = 4
        lblStatus.Text = "lblStatus"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Left
        PictureBox1.Image = My.Resources.Resources.user_3296_128
        PictureBox1.Location = New Point(33, -87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(155, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(42, 150)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 37)
        Label7.TabIndex = 6
        Label7.Text = "Parent Contact"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(42, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(228, 37)
        Label6.TabIndex = 5
        Label6.Text = "Year Level/Course"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.Anchor = AnchorStyles.Left
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentName.Location = New Point(206, -24)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(287, 38)
        lblStudentName.TabIndex = 2
        lblStudentName.Text = "lblStudentName"
        ' 
        ' timerClock
        ' 
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(232))
        ClientSize = New Size(1698, 825)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(1024, 650)
        Name = "UserForm"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "UserForm"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents timerClock As Timer
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQrCode As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAttendance As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblParentNumber As Label
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
End Class
