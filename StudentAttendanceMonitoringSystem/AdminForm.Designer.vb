<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm

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
        Panel1 = New Panel()
        Panel2 = New Panel()
        pnlIndicator = New Panel()
        lblDashboard = New Label()
        lblManageStudents = New Label()
        lblQRCode = New Label()
        lblReports = New Label()
        lblSMS = New Label()
        lblUserManagement = New Label()
        lblLogout = New Label()
        PictureBox1 = New PictureBox()
        pnlContent = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources._6a4fef6f_e247_4671_bc82_cbd6ced86108
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(220, 700)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(pnlIndicator)
        Panel2.Controls.Add(lblDashboard)
        Panel2.Controls.Add(lblManageStudents)
        Panel2.Controls.Add(lblQRCode)
        Panel2.Controls.Add(lblReports)
        Panel2.Controls.Add(lblSMS)
        Panel2.Controls.Add(lblUserManagement)
        Panel2.Controls.Add(lblLogout)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(220, 700)
        Panel2.TabIndex = 0
        ' 
        ' pnlIndicator
        ' 
        pnlIndicator.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        pnlIndicator.Location = New Point(0, 165)
        pnlIndicator.Name = "pnlIndicator"
        pnlIndicator.Size = New Size(5, 43)
        pnlIndicator.TabIndex = 10
        ' 
        ' lblDashboard
        ' 
        lblDashboard.BackColor = Color.FromArgb(CByte(103), CByte(60), CByte(36))
        lblDashboard.Cursor = Cursors.Hand
        lblDashboard.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(5, 165)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Padding = New Padding(18, 0, 0, 0)
        lblDashboard.Size = New Size(215, 43)
        lblDashboard.TabIndex = 1
        lblDashboard.Text = "Dashboard"
        lblDashboard.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblManageStudents
        ' 
        lblManageStudents.BackColor = Color.Transparent
        lblManageStudents.Cursor = Cursors.Hand
        lblManageStudents.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblManageStudents.ForeColor = Color.White
        lblManageStudents.Location = New Point(5, 210)
        lblManageStudents.Name = "lblManageStudents"
        lblManageStudents.Padding = New Padding(18, 0, 0, 0)
        lblManageStudents.Size = New Size(215, 43)
        lblManageStudents.TabIndex = 2
        lblManageStudents.Text = "Manage Students"
        lblManageStudents.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblQRCode
        ' 
        lblQRCode.BackColor = Color.Transparent
        lblQRCode.Cursor = Cursors.Hand
        lblQRCode.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblQRCode.ForeColor = Color.White
        lblQRCode.Location = New Point(5, 255)
        lblQRCode.Name = "lblQRCode"
        lblQRCode.Padding = New Padding(18, 0, 0, 0)
        lblQRCode.Size = New Size(215, 43)
        lblQRCode.TabIndex = 3
        lblQRCode.Text = "QR Code Management"
        lblQRCode.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblReports
        ' 
        lblReports.BackColor = Color.Transparent
        lblReports.Cursor = Cursors.Hand
        lblReports.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblReports.ForeColor = Color.White
        lblReports.Location = New Point(5, 300)
        lblReports.Name = "lblReports"
        lblReports.Padding = New Padding(18, 0, 0, 0)
        lblReports.Size = New Size(215, 43)
        lblReports.TabIndex = 4
        lblReports.Text = "Generate Reports"
        lblReports.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSMS
        ' 
        lblSMS.BackColor = Color.Transparent
        lblSMS.Cursor = Cursors.Hand
        lblSMS.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblSMS.ForeColor = Color.White
        lblSMS.Location = New Point(5, 345)
        lblSMS.Name = "lblSMS"
        lblSMS.Padding = New Padding(18, 0, 0, 0)
        lblSMS.Size = New Size(215, 43)
        lblSMS.TabIndex = 5
        lblSMS.Text = "SMS Notifications"
        lblSMS.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUserManagement
        ' 
        lblUserManagement.BackColor = Color.Transparent
        lblUserManagement.Cursor = Cursors.Hand
        lblUserManagement.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblUserManagement.ForeColor = Color.White
        lblUserManagement.Location = New Point(5, 390)
        lblUserManagement.Name = "lblUserManagement"
        lblUserManagement.Padding = New Padding(18, 0, 0, 0)
        lblUserManagement.Size = New Size(215, 43)
        lblUserManagement.TabIndex = 6
        lblUserManagement.Text = "User Management"
        lblUserManagement.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblLogout
        ' 
        lblLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblLogout.BackColor = Color.Transparent
        lblLogout.Cursor = Cursors.Hand
        lblLogout.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblLogout.ForeColor = Color.White
        lblLogout.Location = New Point(0, 640)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(220, 43)
        lblLogout.TabIndex = 7
        lblLogout.Text = "Log Out"
        lblLogout.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.ChatGPT_Image_Sep_11__2026__08_43_52_AM
        PictureBox1.Location = New Point(10, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 145)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(220, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1180, 700)
        pnlContent.TabIndex = 1
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        ClientSize = New Size(1400, 700)
        Controls.Add(pnlContent)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Monitoring System"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub


    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel

    Friend WithEvents PictureBox1 As PictureBox

    Friend WithEvents pnlIndicator As Panel

    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblManageStudents As Label
    Friend WithEvents lblQRCode As Label
    Friend WithEvents lblReports As Label
    Friend WithEvents lblSMS As Label
    Friend WithEvents lblUserManagement As Label

    Friend WithEvents lblLogout As Label

    Friend WithEvents pnlContent As Panel

End Class