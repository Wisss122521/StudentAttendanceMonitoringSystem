<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanelMain = New TableLayoutPanel()
        Panel1 = New Panel()
        Button1 = New Button()
        lblDateTime = New Label()
        Label2 = New Label()
        Label1 = New Label()
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
        Panel2 = New Panel()
        Label10 = New Label()
        dgvAttendance = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        timerClock = New Timer(components)
        TableLayoutPanelMain.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanelMain
        ' 
        TableLayoutPanelMain.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        TableLayoutPanelMain.ColumnCount = 1
        TableLayoutPanelMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanelMain.Controls.Add(Panel1, 0, 0)
        TableLayoutPanelMain.Controls.Add(Panel3, 0, 1)
        TableLayoutPanelMain.Controls.Add(Panel2, 0, 2)
        TableLayoutPanelMain.Dock = DockStyle.Fill
        TableLayoutPanelMain.Location = New Point(0, 0)
        TableLayoutPanelMain.Margin = New Padding(0)
        TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        TableLayoutPanelMain.RowCount = 3
        TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 100.0F))
        TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 338.0F))
        TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanelMain.Size = New Size(1698, 825)
        TableLayoutPanelMain.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(lblDateTime)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 10, 20, 8)
        Panel1.Size = New Size(1698, 100)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(82), CByte(46), CByte(28))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(122), CByte(73), CByte(45))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1550, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 32)
        Button1.TabIndex = 3
        Button1.Text = "LOG OUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.Font = New Font("Georgia", 14.5F, FontStyle.Bold)
        lblDateTime.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblDateTime.Location = New Point(905, 50)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(775, 34)
        lblDateTime.TabIndex = 2
        lblDateTime.Text = "Wednesday, November 04, 2026  |  10:15:52 PM"
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 10.0F)
        Label2.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        Label2.Location = New Point(24, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(600, 23)
        Label2.TabIndex = 1
        Label2.Text = "SCAN • RECORD • MONITOR STUDENT ENTRY AND EXIT"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Georgia", 28.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        Label1.Location = New Point(20, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(650, 46)
        Label1.TabIndex = 0
        Label1.Text = "Mark Attendance"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Panel3.Controls.Add(TableLayoutPanel1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 100)
        Panel3.Margin = New Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1698, 338)
        Panel3.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel7, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Size = New Size(1698, 338)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(txtQrCode)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(18, 12)
        Panel4.Margin = New Padding(18, 12, 9, 12)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(822, 314)
        Panel4.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.Font = New Font("Segoe UI", 9.5F)
        Label5.ForeColor = Color.FromArgb(CByte(135), CByte(111), CByte(96))
        Label5.Location = New Point(20, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(780, 23)
        Label5.TabIndex = 4
        Label5.Text = "Keep the cursor in the scan box. The QR scanner will submit the code automatically."
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.Font = New Font("Segoe UI", 10.5F)
        Label4.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        Label4.Location = New Point(20, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(780, 24)
        Label4.TabIndex = 2
        Label4.Text = "Scan the student's QR Code to record Time-In or Time-Out"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = My.Resources.Resources.qr_code_scan_icon
        PictureBox2.Location = New Point(353, 18)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 105)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.Font = New Font("Georgia", 25.0F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        Label3.Location = New Point(20, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(780, 43)
        Label3.TabIndex = 1
        Label3.Text = "Ready to Scan"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtQrCode
        ' 
        txtQrCode.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtQrCode.BackColor = Color.White
        txtQrCode.BorderStyle = BorderStyle.FixedSingle
        txtQrCode.CharacterCasing = CharacterCasing.Upper
        txtQrCode.Font = New Font("Segoe UI", 14.0F)
        txtQrCode.Location = New Point(90, 207)
        txtQrCode.Name = "txtQrCode"
        txtQrCode.PlaceholderText = "Scan QR Code here..."
        txtQrCode.Size = New Size(640, 32)
        txtQrCode.TabIndex = 0
        txtQrCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(lblYearLevel)
        Panel7.Controls.Add(lblParentNumber)
        Panel7.Controls.Add(Panel5)
        Panel7.Controls.Add(PictureBox1)
        Panel7.Controls.Add(Label7)
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(lblStudentName)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(858, 12)
        Panel7.Margin = New Padding(9, 12, 18, 12)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(822, 314)
        Panel7.TabIndex = 1
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblYearLevel.Font = New Font("Segoe UI", 12.0F)
        lblYearLevel.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblYearLevel.Location = New Point(375, 91)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(415, 25)
        lblYearLevel.TabIndex = 3
        lblYearLevel.Text = "-"
        ' 
        ' lblParentNumber
        ' 
        lblParentNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblParentNumber.Font = New Font("Segoe UI", 12.0F)
        lblParentNumber.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblParentNumber.Location = New Point(375, 133)
        lblParentNumber.Name = "lblParentNumber"
        lblParentNumber.Size = New Size(415, 25)
        lblParentNumber.TabIndex = 5
        lblParentNumber.Text = "-"
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = Color.FromArgb(CByte(253), CByte(247), CByte(234))
        Panel5.Controls.Add(PictureBox3)
        Panel5.Controls.Add(lblTime)
        Panel5.Controls.Add(lblAttendance)
        Panel5.Controls.Add(lblStatus)
        Panel5.Location = New Point(24, 197)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(772, 91)
        Panel5.TabIndex = 6
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Left
        PictureBox3.Image = My.Resources.Resources.right_arrow_6421_1024
        PictureBox3.Location = New Point(16, 17)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(55, 55)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTime.Font = New Font("Georgia", 17.0F, FontStyle.Bold)
        lblTime.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblTime.Location = New Point(520, 25)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(230, 38)
        lblTime.TabIndex = 3
        lblTime.Text = "--:--:--"
        lblTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblAttendance
        ' 
        lblAttendance.Font = New Font("Segoe UI", 10.0F)
        lblAttendance.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        lblAttendance.Location = New Point(91, 49)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(430, 25)
        lblAttendance.TabIndex = 2
        lblAttendance.Text = "Waiting for QR Code scan..."
        lblAttendance.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Georgia", 18.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblStatus.Location = New Point(90, 14)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(330, 34)
        lblStatus.TabIndex = 1
        lblStatus.Text = "READY"
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user_3296_128
        PictureBox1.Location = New Point(28, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 125)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        Label7.Location = New Point(180, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(180, 25)
        Label7.TabIndex = 4
        Label7.Text = "Parent Contact"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(117), CByte(87), CByte(71))
        Label6.Location = New Point(180, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(180, 25)
        Label6.TabIndex = 2
        Label6.Text = "Year Level / Course"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStudentName.Font = New Font("Georgia", 21.0F, FontStyle.Bold)
        lblStudentName.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblStudentName.Location = New Point(180, 31)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(610, 42)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "No student scanned"
        lblStudentName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(dgvAttendance)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 438)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(18, 8, 18, 16)
        Panel2.Size = New Size(1698, 387)
        Panel2.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.Font = New Font("Georgia", 16.0F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        Label10.Location = New Point(18, 8)
        Label10.Name = "Label10"
        Label10.Size = New Size(1662, 34)
        Label10.TabIndex = 0
        Label10.Text = "Recent Scans"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.AllowUserToAddRows = False
        dgvAttendance.AllowUserToDeleteRows = False
        dgvAttendance.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(252), CByte(249), CByte(246))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        dgvAttendance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAttendance.BackgroundColor = Color.White
        dgvAttendance.BorderStyle = BorderStyle.None
        dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle5.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(93), CByte(50), CByte(29))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvAttendance.ColumnHeadersHeight = 42
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAttendance.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        DataGridViewCellStyle6.Padding = New Padding(4, 0, 4, 0)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(233), CByte(216), CByte(202))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvAttendance.DefaultCellStyle = DataGridViewCellStyle6
        dgvAttendance.EnableHeadersVisualStyles = False
        dgvAttendance.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(201))
        dgvAttendance.Location = New Point(18, 48)
        dgvAttendance.MultiSelect = False
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.ReadOnly = True
        dgvAttendance.RowHeadersVisible = False
        dgvAttendance.RowTemplate.Height = 38
        dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendance.Size = New Size(1662, 320)
        dgvAttendance.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "attendance_id"
        Column1.HeaderText = "Record ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "students_id"
        Column2.FillWeight = 26.0F
        Column2.HeaderText = "Student ID"
        Column2.MinimumWidth = 100
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "attendance_date"
        Column3.FillWeight = 28.0F
        Column3.HeaderText = "Date"
        Column3.MinimumWidth = 120
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "time_in"
        Column4.FillWeight = 23.0F
        Column4.HeaderText = "Time In"
        Column4.MinimumWidth = 120
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "time_out"
        Column5.FillWeight = 23.0F
        Column5.HeaderText = "Time Out"
        Column5.MinimumWidth = 120
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' timerClock
        ' 
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        ClientSize = New Size(1698, 825)
        Controls.Add(TableLayoutPanelMain)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(1024, 650)
        Name = "UserForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Attendance Monitoring"
        WindowState = FormWindowState.Maximized
        TableLayoutPanelMain.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub


    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtQrCode As TextBox

    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblStudentName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblParentNumber As Label
    Friend WithEvents PictureBox1 As PictureBox

    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblTime As Label

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvAttendance As DataGridView

    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn

    Friend WithEvents timerClock As Timer

End Class