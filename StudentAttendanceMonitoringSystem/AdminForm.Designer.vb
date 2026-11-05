<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm

    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)

        Try

            If disposing AndAlso
               components IsNot Nothing Then

                components.Dispose()

            End If

        Finally

            MyBase.Dispose(disposing)

        End Try

    End Sub


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        tsBrand = New ToolStripLabel()
        mnuDashboard = New ToolStripMenuItem()
        mnuManageStudents = New ToolStripMenuItem()
        mnuQRCode = New ToolStripMenuItem()
        mnuReports = New ToolStripMenuItem()
        mnuSMS = New ToolStripMenuItem()
        mnuUserManagement = New ToolStripMenuItem()
        mnuLogout = New ToolStripMenuItem()
        pnlContent = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(72), CByte(40), CByte(24))
        MenuStrip1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {tsBrand, mnuDashboard, mnuManageStudents, mnuQRCode, mnuReports, mnuSMS, mnuUserManagement, mnuLogout})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(12, 0, 12, 0)
        MenuStrip1.ShowItemToolTips = True
        MenuStrip1.Size = New Size(1400, 58)
        MenuStrip1.TabIndex = 0
        ' 
        ' tsBrand
        ' 
        tsBrand.AutoSize = False
        tsBrand.Font = New Font("Georgia", 14.5F, FontStyle.Bold)
        tsBrand.ForeColor = Color.White
        tsBrand.Margin = New Padding(4, 0, 28, 0)
        tsBrand.Name = "tsBrand"
        tsBrand.Size = New Size(325, 58)
        tsBrand.Text = "Student Monitoring Entry/Exit"
        tsBrand.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' mnuDashboard
        ' 
        mnuDashboard.AutoSize = False
        mnuDashboard.BackColor = Color.FromArgb(CByte(245), CByte(234), CByte(223))
        mnuDashboard.ForeColor = Color.FromArgb(CByte(72), CByte(40), CByte(24))
        mnuDashboard.Name = "mnuDashboard"
        mnuDashboard.Padding = New Padding(10, 0, 10, 0)
        mnuDashboard.Size = New Size(105, 58)
        mnuDashboard.Text = "Dashboard"
        mnuDashboard.ToolTipText = "Open Dashboard"
        ' 
        ' mnuManageStudents
        ' 
        mnuManageStudents.AutoSize = False
        mnuManageStudents.BackColor = Color.Transparent
        mnuManageStudents.ForeColor = Color.White
        mnuManageStudents.Name = "mnuManageStudents"
        mnuManageStudents.Padding = New Padding(10, 0, 10, 0)
        mnuManageStudents.Size = New Size(145, 58)
        mnuManageStudents.Text = "Manage Students"
        mnuManageStudents.ToolTipText = "Manage student information"
        ' 
        ' mnuQRCode
        ' 
        mnuQRCode.AutoSize = False
        mnuQRCode.BackColor = Color.Transparent
        mnuQRCode.ForeColor = Color.White
        mnuQRCode.Name = "mnuQRCode"
        mnuQRCode.Padding = New Padding(10, 0, 10, 0)
        mnuQRCode.Size = New Size(170, 58)
        mnuQRCode.Text = "QR Code Management"
        mnuQRCode.ToolTipText = "Generate and manage QR Codes"
        ' 
        ' mnuReports
        ' 
        mnuReports.AutoSize = False
        mnuReports.BackColor = Color.Transparent
        mnuReports.ForeColor = Color.White
        mnuReports.Name = "mnuReports"
        mnuReports.Padding = New Padding(10, 0, 10, 0)
        mnuReports.Size = New Size(140, 58)
        mnuReports.Text = "Generate Reports"
        mnuReports.ToolTipText = "Generate student entry and exit reports"
        ' 
        ' mnuSMS
        ' 
        mnuSMS.AutoSize = False
        mnuSMS.BackColor = Color.Transparent
        mnuSMS.ForeColor = Color.White
        mnuSMS.Name = "mnuSMS"
        mnuSMS.Padding = New Padding(10, 0, 10, 0)
        mnuSMS.Size = New Size(150, 58)
        mnuSMS.Text = "SMS Notifications"
        mnuSMS.ToolTipText = "View and send SMS notifications"
        ' 
        ' mnuUserManagement
        ' 
        mnuUserManagement.AutoSize = False
        mnuUserManagement.BackColor = Color.Transparent
        mnuUserManagement.ForeColor = Color.White
        mnuUserManagement.Name = "mnuUserManagement"
        mnuUserManagement.Padding = New Padding(10, 0, 10, 0)
        mnuUserManagement.Size = New Size(155, 58)
        mnuUserManagement.Text = "User Management"
        mnuUserManagement.ToolTipText = "Manage system accounts"
        ' 
        ' mnuLogout
        ' 
        mnuLogout.Alignment = ToolStripItemAlignment.Right
        mnuLogout.AutoSize = False
        mnuLogout.BackColor = Color.FromArgb(CByte(92), CByte(47), CByte(28))
        mnuLogout.ForeColor = Color.White
        mnuLogout.Margin = New Padding(8, 8, 2, 8)
        mnuLogout.Name = "mnuLogout"
        mnuLogout.Padding = New Padding(8, 0, 8, 0)
        mnuLogout.Size = New Size(100, 42)
        mnuLogout.Text = "Log Out"
        mnuLogout.ToolTipText = "Log out of the system"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 58)
        pnlContent.Margin = New Padding(0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1400, 642)
        pnlContent.TabIndex = 1
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(236))
        ClientSize = New Size(1400, 700)
        Controls.Add(pnlContent)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(1100, 650)
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Monitoring System"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub


    Friend WithEvents MenuStrip1 As MenuStrip

    Friend WithEvents tsBrand As ToolStripLabel

    Friend WithEvents mnuDashboard As ToolStripMenuItem
    Friend WithEvents mnuManageStudents As ToolStripMenuItem
    Friend WithEvents mnuQRCode As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents mnuSMS As ToolStripMenuItem
    Friend WithEvents mnuUserManagement As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem

    Friend WithEvents pnlContent As Panel

End Class