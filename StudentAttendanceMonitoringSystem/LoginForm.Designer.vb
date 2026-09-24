<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        pnlLoginCard = New Panel()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblUsername = New Label()
        txtUsername = New TextBox()
        btnLogin = New Button()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        pnlLoginCard.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(984, 561)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(55), CByte(29), CByte(17))
        Panel2.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Sep_22__2026__01_35_50_PM__2_
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(486, 555)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(252), CByte(248), CByte(243))
        Panel3.Controls.Add(TableLayoutPanel2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(495, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(486, 555)
        Panel3.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.4639177F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 72.16495F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.3711338F))
        TableLayoutPanel2.Controls.Add(pnlLoginCard, 1, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 76F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel2.Size = New Size(486, 555)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.BackColor = Color.FromArgb(CByte(251), CByte(247), CByte(242))
        pnlLoginCard.Controls.Add(Panel1)
        pnlLoginCard.Dock = DockStyle.Fill
        pnlLoginCard.Location = New Point(85, 76)
        pnlLoginCard.Margin = New Padding(10)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Padding = New Padding(35)
        pnlLoginCard.Size = New Size(330, 401)
        pnlLoginCard.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblPassword)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(lblUsername)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(btnLogin)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(35, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(260, 331)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(81, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 6
        Label2.Text = "Sign in to continue"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 25)
        Label1.TabIndex = 5
        Label1.Text = "Welcome Back"
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Top
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(25, 183)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top
        txtPassword.Location = New Point(90, 175)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(147, 23)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.Top
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(22, 135)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top
        txtUsername.Location = New Point(88, 132)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(149, 23)
        txtUsername.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Top
        btnLogin.BackColor = Color.FromArgb(CByte(55), CByte(29), CByte(17))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(25, 267)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(212, 23)
        btnLogin.TabIndex = 0
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 561)
        Controls.Add(TableLayoutPanel1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Attendance Monitoring System"
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        pnlLoginCard.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
