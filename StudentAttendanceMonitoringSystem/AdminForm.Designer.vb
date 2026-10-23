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

        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()

        Me.PictureBox1 = New System.Windows.Forms.PictureBox()

        Me.pnlIndicator = New System.Windows.Forms.Panel()

        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblManageStudents = New System.Windows.Forms.Label()
        Me.lblQRCode = New System.Windows.Forms.Label()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.lblSMS = New System.Windows.Forms.Label()
        Me.lblUserManagement = New System.Windows.Forms.Label()

        Me.lblLogout = New System.Windows.Forms.Label()

        Me.pnlContent = New System.Windows.Forms.Panel()


        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()

        CType(
            Me.PictureBox1,
            System.ComponentModel.ISupportInitialize
        ).BeginInit()

        Me.SuspendLayout()


        '==================================================
        ' Panel1 - SIDEBAR
        '==================================================
        Me.Panel1.BackgroundImage =
            My.Resources.Resources._6a4fef6f_e247_4671_bc82_cbd6ced86108

        Me.Panel1.BackgroundImageLayout =
            System.Windows.Forms.ImageLayout.Stretch

        Me.Panel1.Controls.Add(Me.Panel2)

        Me.Panel1.Dock =
            System.Windows.Forms.DockStyle.Left

        Me.Panel1.Location =
            New System.Drawing.Point(0, 0)

        Me.Panel1.Name =
            "Panel1"

        Me.Panel1.Size =
            New System.Drawing.Size(220, 700)

        Me.Panel1.TabIndex =
            0


        '==================================================
        ' Panel2
        '==================================================
        Me.Panel2.BackColor =
            System.Drawing.Color.Transparent

        Me.Panel2.Controls.Add(Me.pnlIndicator)

        Me.Panel2.Controls.Add(Me.lblDashboard)
        Me.Panel2.Controls.Add(Me.lblManageStudents)
        Me.Panel2.Controls.Add(Me.lblQRCode)
        Me.Panel2.Controls.Add(Me.lblReports)
        Me.Panel2.Controls.Add(Me.lblSMS)
        Me.Panel2.Controls.Add(Me.lblUserManagement)

        Me.Panel2.Controls.Add(Me.lblLogout)

        Me.Panel2.Controls.Add(Me.PictureBox1)

        Me.Panel2.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.Panel2.Location =
            New System.Drawing.Point(0, 0)

        Me.Panel2.Name =
            "Panel2"

        Me.Panel2.Size =
            New System.Drawing.Size(220, 700)

        Me.Panel2.TabIndex =
            0


        '==================================================
        ' PictureBox1 - SCHOOL LOGO
        '==================================================
        Me.PictureBox1.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.PictureBox1.BackColor =
            System.Drawing.Color.Transparent

        Me.PictureBox1.Image =
            My.Resources.Resources.ChatGPT_Image_Sep_11__2026__08_43_52_AM

        Me.PictureBox1.Location =
            New System.Drawing.Point(10, 5)

        Me.PictureBox1.Name =
            "PictureBox1"

        Me.PictureBox1.Size =
            New System.Drawing.Size(200, 145)

        Me.PictureBox1.SizeMode =
            System.Windows.Forms.PictureBoxSizeMode.Zoom

        Me.PictureBox1.TabIndex =
            0

        Me.PictureBox1.TabStop =
            False


        '==================================================
        ' pnlIndicator
        '==================================================
        Me.pnlIndicator.BackColor =
            System.Drawing.Color.FromArgb(245, 234, 223)

        Me.pnlIndicator.Location =
            New System.Drawing.Point(0, 165)

        Me.pnlIndicator.Name =
            "pnlIndicator"

        Me.pnlIndicator.Size =
            New System.Drawing.Size(5, 43)

        Me.pnlIndicator.TabIndex =
            10


        '==================================================
        ' lblDashboard
        '==================================================
        Me.lblDashboard.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.lblDashboard.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.lblDashboard.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblDashboard.ForeColor =
            System.Drawing.Color.White

        Me.lblDashboard.Location =
            New System.Drawing.Point(5, 165)

        Me.lblDashboard.Name =
            "lblDashboard"

        Me.lblDashboard.Padding =
            New System.Windows.Forms.Padding(18, 0, 0, 0)

        Me.lblDashboard.Size =
            New System.Drawing.Size(215, 43)

        Me.lblDashboard.TabIndex =
            1

        Me.lblDashboard.Text =
            "Dashboard"

        Me.lblDashboard.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblManageStudents
        '==================================================
        Me.lblManageStudents.BackColor =
            System.Drawing.Color.Transparent

        Me.lblManageStudents.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.lblManageStudents.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblManageStudents.ForeColor =
            System.Drawing.Color.White

        Me.lblManageStudents.Location =
            New System.Drawing.Point(5, 210)

        Me.lblManageStudents.Name =
            "lblManageStudents"

        Me.lblManageStudents.Padding =
            New System.Windows.Forms.Padding(18, 0, 0, 0)

        Me.lblManageStudents.Size =
            New System.Drawing.Size(215, 43)

        Me.lblManageStudents.TabIndex =
            2

        Me.lblManageStudents.Text =
            "Manage Students"

        Me.lblManageStudents.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblQRCode
        '==================================================
        Me.lblQRCode.BackColor =
            System.Drawing.Color.Transparent

        Me.lblQRCode.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.lblQRCode.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQRCode.ForeColor =
            System.Drawing.Color.White

        Me.lblQRCode.Location =
            New System.Drawing.Point(5, 255)

        Me.lblQRCode.Name =
            "lblQRCode"

        Me.lblQRCode.Padding =
            New System.Windows.Forms.Padding(18, 0, 0, 0)

        Me.lblQRCode.Size =
            New System.Drawing.Size(215, 43)

        Me.lblQRCode.TabIndex =
            3

        Me.lblQRCode.Text =
            "QR Code Management"

        Me.lblQRCode.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblReports
        '==================================================
        Me.lblReports.BackColor =
            System.Drawing.Color.Transparent

        Me.lblReports.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.lblReports.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblReports.ForeColor =
            System.Drawing.Color.White

        Me.lblReports.Location =
            New System.Drawing.Point(5, 300)

        Me.lblReports.Name =
            "lblReports"

        Me.lblReports.Padding =
            New System.Windows.Forms.Padding(18, 0, 0, 0)

        Me.lblReports.Size =
            New System.Drawing.Size(215, 43)

        Me.lblReports.TabIndex =
            4

        Me.lblReports.Text =
            "Generate Reports"

        Me.lblReports.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblSMS
        '==================================================
        Me.lblSMS.BackColor =
            System.Drawing.Color.Transparent

        Me.lblSMS.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.lblSMS.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSMS.ForeColor =
            System.Drawing.Color.White

        Me.lblSMS.Location =
            New System.Drawing.Point(5, 345)

        Me.lblSMS.Name =
            "lblSMS"

        Me.lblSMS.Padding =
            New System.Windows.Forms.Padding(18, 0, 0, 0)

        Me.lblSMS.Size =
            New System.Drawing.Size(215, 43)

        Me.lblSMS.TabIndex =
            5

        Me.lblSMS.Text =
            "SMS Notifications"

        Me.lblSMS.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblUserManagement
        '==================================================
        Me.lblUserManagement.BackColor =
            System.Drawing.Color.Transparent

        Me.lblUserManagement.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.lblUserManagement.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblUserManagement.ForeColor =
            System.Drawing.Color.White

        Me.lblUserManagement.Location =
            New System.Drawing.Point(5, 390)

        Me.lblUserManagement.Name =
            "lblUserManagement"

        Me.lblUserManagement.Padding =
            New System.Windows.Forms.Padding(18, 0, 0, 0)

        Me.lblUserManagement.Size =
            New System.Drawing.Size(215, 43)

        Me.lblUserManagement.TabIndex =
            6

        Me.lblUserManagement.Text =
            "User Management"

        Me.lblUserManagement.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblLogout
        '==================================================
        Me.lblLogout.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblLogout.BackColor =
            System.Drawing.Color.Transparent

        Me.lblLogout.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.lblLogout.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblLogout.ForeColor =
            System.Drawing.Color.White

        Me.lblLogout.Location =
            New System.Drawing.Point(5, 640)

        Me.lblLogout.Name =
            "lblLogout"

        Me.lblLogout.Padding =
            New System.Windows.Forms.Padding(18, 0, 0, 0)

        Me.lblLogout.Size =
            New System.Drawing.Size(215, 43)

        Me.lblLogout.TabIndex =
            7

        Me.lblLogout.Text =
            "Log Out"

        Me.lblLogout.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' pnlContent
        '==================================================
        Me.pnlContent.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.pnlContent.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlContent.Location =
            New System.Drawing.Point(220, 0)

        Me.pnlContent.Name =
            "pnlContent"

        Me.pnlContent.Size =
            New System.Drawing.Size(1180, 700)

        Me.pnlContent.TabIndex =
            1


        '==================================================
        ' AdminForm
        '==================================================
        Me.AutoScaleDimensions =
            New System.Drawing.SizeF(7.0!, 15.0!)

        Me.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font

        Me.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.ClientSize =
            New System.Drawing.Size(1400, 700)

        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.Panel1)

        Me.FormBorderStyle =
            System.Windows.Forms.FormBorderStyle.None

        Me.Name =
            "AdminForm"

        Me.StartPosition =
            System.Windows.Forms.FormStartPosition.CenterScreen

        Me.Text =
            "Student Monitoring System"

        Me.WindowState =
            System.Windows.Forms.FormWindowState.Maximized


        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)

        CType(
            Me.PictureBox1,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.ResumeLayout(False)

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