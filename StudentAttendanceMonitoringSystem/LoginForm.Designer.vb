<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

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
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        lblQuote = New Label()
        lblMotto = New Label()
        pnlLineBottom = New Panel()
        lblSystemName = New Label()
        lblSchoolName = New Label()
        pnlLineTop = New Panel()
        picSchoolLogo = New PictureBox()
        Panel3 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        pnlLoginCard = New Panel()
        lblFooter = New Label()
        Panel1 = New Panel()
        pnlLoginLine = New Panel()
        lblLoginMessage = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        pnlLoginCard.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Size = New Size(1100, 650)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(55), CByte(29), CByte(17))
        Panel2.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Sep_22__2026__01_35_50_PM__2_
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(lblQuote)
        Panel2.Controls.Add(lblMotto)
        Panel2.Controls.Add(pnlLineBottom)
        Panel2.Controls.Add(lblSystemName)
        Panel2.Controls.Add(lblSchoolName)
        Panel2.Controls.Add(pnlLineTop)
        Panel2.Controls.Add(picSchoolLogo)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(550, 650)
        Panel2.TabIndex = 0
        ' 
        ' lblQuote
        ' 
        lblQuote.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblQuote.BackColor = Color.Transparent
        lblQuote.Font = New Font("Georgia", 9.5F, FontStyle.Italic)
        lblQuote.ForeColor = Color.FromArgb(CByte(235), CByte(220), CByte(205))
        lblQuote.Location = New Point(35, 545)
        lblQuote.Name = "lblQuote"
        lblQuote.Size = New Size(250, 60)
        lblQuote.TabIndex = 6
        lblQuote.Text = "Nurturing Minds," & vbCrLf & "Building Character"
        lblQuote.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblMotto
        ' 
        lblMotto.Anchor = AnchorStyles.Top
        lblMotto.BackColor = Color.Transparent
        lblMotto.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblMotto.ForeColor = Color.FromArgb(CByte(225), CByte(205), CByte(190))
        lblMotto.Location = New Point(98, 457)
        lblMotto.Name = "lblMotto"
        lblMotto.Size = New Size(350, 25)
        lblMotto.TabIndex = 5
        lblMotto.Text = "SAPIENTA ET MORALIS"
        lblMotto.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLineBottom
        ' 
        pnlLineBottom.Anchor = AnchorStyles.Top
        pnlLineBottom.BackColor = Color.FromArgb(CByte(190), CByte(165), CByte(145))
        pnlLineBottom.Location = New Point(158, 447)
        pnlLineBottom.Name = "pnlLineBottom"
        pnlLineBottom.Size = New Size(230, 1)
        pnlLineBottom.TabIndex = 4
        ' 
        ' lblSystemName
        ' 
        lblSystemName.Anchor = AnchorStyles.Top
        lblSystemName.BackColor = Color.Transparent
        lblSystemName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblSystemName.ForeColor = Color.FromArgb(CByte(225), CByte(205), CByte(190))
        lblSystemName.Location = New Point(68, 407)
        lblSystemName.Name = "lblSystemName"
        lblSystemName.Size = New Size(410, 25)
        lblSystemName.TabIndex = 3
        lblSystemName.Text = "STUDENT TIME-IN / TIME-OUT MONITORING SYSTEM"
        lblSystemName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSchoolName
        ' 
        lblSchoolName.Anchor = AnchorStyles.Top
        lblSchoolName.BackColor = Color.Transparent
        lblSchoolName.Font = New Font("Georgia", 17.0F, FontStyle.Bold)
        lblSchoolName.ForeColor = Color.FromArgb(CByte(255), CByte(245), CByte(232))
        lblSchoolName.Location = New Point(43, 362)
        lblSchoolName.Name = "lblSchoolName"
        lblSchoolName.Size = New Size(460, 42)
        lblSchoolName.TabIndex = 2
        lblSchoolName.Text = "Colegio de Sta. Teresa de Avila"
        lblSchoolName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLineTop
        ' 
        pnlLineTop.Anchor = AnchorStyles.Top
        pnlLineTop.BackColor = Color.FromArgb(CByte(190), CByte(165), CByte(145))
        pnlLineTop.Location = New Point(113, 347)
        pnlLineTop.Name = "pnlLineTop"
        pnlLineTop.Size = New Size(320, 1)
        pnlLineTop.TabIndex = 1
        ' 
        ' picSchoolLogo
        ' 
        picSchoolLogo.Anchor = AnchorStyles.Top
        picSchoolLogo.BackColor = Color.Transparent
        picSchoolLogo.BackgroundImageLayout = ImageLayout.Zoom
        picSchoolLogo.Image = My.Resources.Resources.Colegio_Sta__Teresa_de_Avila_Crest
        picSchoolLogo.Location = New Point(178, 142)
        picSchoolLogo.Name = "picSchoolLogo"
        picSchoolLogo.Size = New Size(190, 190)
        picSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        picSchoolLogo.TabIndex = 0
        picSchoolLogo.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        Panel3.Controls.Add(TableLayoutPanel2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(550, 0)
        Panel3.Margin = New Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(550, 650)
        Panel3.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 76.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.0F))
        TableLayoutPanel2.Controls.Add(pnlLoginCard, 1, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 68.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.0F))
        TableLayoutPanel2.Size = New Size(550, 650)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(252))
        pnlLoginCard.BorderStyle = BorderStyle.FixedSingle
        pnlLoginCard.Controls.Add(lblFooter)
        pnlLoginCard.Controls.Add(Panel1)
        pnlLoginCard.Dock = DockStyle.Fill
        pnlLoginCard.Location = New Point(78, 116)
        pnlLoginCard.Margin = New Padding(12)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Padding = New Padding(35)
        pnlLoginCard.Size = New Size(394, 418)
        pnlLoginCard.TabIndex = 0
        ' 
        ' lblFooter
        ' 
        lblFooter.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblFooter.Font = New Font("Segoe UI", 7.5F)
        lblFooter.ForeColor = Color.FromArgb(CByte(125), CByte(105), CByte(94))
        lblFooter.Location = New Point(55, 387)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(282, 25)
        lblFooter.TabIndex = 9
        lblFooter.Text = "COLEGIO DE STA. TERESA DE AVILA"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(pnlLoginLine)
        Panel1.Controls.Add(lblLoginMessage)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblUsername)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(lblPassword)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(btnLogin)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(35, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(322, 346)
        Panel1.TabIndex = 0
        ' 
        ' pnlLoginLine
        ' 
        pnlLoginLine.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLoginLine.BackColor = Color.FromArgb(CByte(205), CByte(183), CByte(167))
        pnlLoginLine.Location = New Point(20, 345)
        pnlLoginLine.Name = "pnlLoginLine"
        pnlLoginLine.Size = New Size(282, 1)
        pnlLoginLine.TabIndex = 8
        ' 
        ' lblLoginMessage
        ' 
        lblLoginMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblLoginMessage.Font = New Font("Segoe UI", 8.0F)
        lblLoginMessage.ForeColor = Color.FromArgb(CByte(190), CByte(50), CByte(45))
        lblLoginMessage.Location = New Point(20, 257)
        lblLoginMessage.Name = "lblLoginMessage"
        lblLoginMessage.Size = New Size(282, 22)
        lblLoginMessage.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.Font = New Font("Segoe UI", 9.5F)
        Label2.ForeColor = Color.FromArgb(CByte(110), CByte(92), CByte(82))
        Label2.Location = New Point(20, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(282, 25)
        Label2.TabIndex = 1
        Label2.Text = "Sign in to continue"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.Font = New Font("Georgia", 23.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        Label1.Location = New Point(20, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 45)
        Label1.TabIndex = 0
        Label1.Text = "Welcome Back"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblUsername.Location = New Point(15, 120)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(15, 145)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(292, 25)
        txtUsername.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(68), CByte(37), CByte(22))
        lblPassword.Location = New Point(15, 195)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(15, 220)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(292, 25)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnLogin.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(15, 290)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(292, 42)
        btnLogin.TabIndex = 7
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        ClientSize = New Size(1100, 650)
        Controls.Add(TableLayoutPanel1)
        MinimumSize = New Size(900, 550)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Time-In/Time-Out Monitoring System"
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        pnlLoginCard.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub


    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

    Friend WithEvents Panel2 As Panel
    Friend WithEvents picSchoolLogo As PictureBox

    Friend WithEvents pnlLineTop As Panel
    Friend WithEvents pnlLineBottom As Panel

    Friend WithEvents lblSchoolName As Label
    Friend WithEvents lblSystemName As Label
    Friend WithEvents lblMotto As Label
    Friend WithEvents lblQuote As Label

    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel

    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents Panel1 As Panel

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox

    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox

    Friend WithEvents lblLoginMessage As Label

    Friend WithEvents btnLogin As Button

    Friend WithEvents pnlLoginLine As Panel
    Friend WithEvents lblFooter As Label

End Class