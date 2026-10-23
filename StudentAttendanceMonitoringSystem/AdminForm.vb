Imports QRCoder

Public Class AdminForm

    Private currentNavigation As Label


    '==================================================
    ' FORM LOAD
    '==================================================
    Private Sub AdminForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles Me.Load

        Me.DoubleBuffered = True

        OpenPage(
            New UcDashboard(),
            lblDashboard
        )

    End Sub


    '==================================================
    ' FORM CLOSED
    '==================================================
    Private Sub AdminForm_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles Me.FormClosed

        Application.Exit()

    End Sub


    '==================================================
    ' LOAD USER CONTROL
    '==================================================
    Private Sub LoadUserControl(
        uc As UserControl
    )

        pnlContent.SuspendLayout()


        ' Dispose old UserControl
        For Each ctrl As Control In
            pnlContent.Controls

            ctrl.Dispose()

        Next


        pnlContent.Controls.Clear()


        uc.Dock =
            DockStyle.Fill

        uc.Margin =
            New Padding(0)

        pnlContent.Controls.Add(
            uc
        )

        uc.BringToFront()


        pnlContent.ResumeLayout()

    End Sub


    '==================================================
    ' OPEN PAGE
    '==================================================
    Private Sub OpenPage(
        uc As UserControl,
        nav As Label
    )

        LoadUserControl(
            uc
        )

        SetActiveNavigation(
            nav
        )

    End Sub


    '==================================================
    ' ACTIVE NAVIGATION
    '==================================================
    Private Sub SetActiveNavigation(
        selectedLabel As Label
    )

        ' Reset all labels
        ResetNavigation()


        selectedLabel.BackColor =
            Color.FromArgb(
                103,
                60,
                36
            )

        selectedLabel.ForeColor =
            Color.White


        pnlIndicator.Top =
            selectedLabel.Top

        pnlIndicator.Height =
            selectedLabel.Height

        pnlIndicator.Visible =
            True

        pnlIndicator.BringToFront()


        currentNavigation =
            selectedLabel

    End Sub


    '==================================================
    ' RESET NAVIGATION
    '==================================================
    Private Sub ResetNavigation()

        Dim navItems As Label() = {
            lblDashboard,
            lblManageStudents,
            lblQRCode,
            lblReports,
            lblSMS,
            lblUserManagement
        }


        For Each nav As Label In navItems

            nav.BackColor =
                Color.Transparent

            nav.ForeColor =
                Color.White

        Next

    End Sub


    '==================================================
    ' DASHBOARD
    '==================================================
    Private Sub lblDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles lblDashboard.Click

        OpenPage(
            New UcDashboard(),
            lblDashboard
        )

    End Sub


    '==================================================
    ' MANAGE STUDENTS
    '==================================================
    Private Sub lblManageStudents_Click(
        sender As Object,
        e As EventArgs
    ) Handles lblManageStudents.Click

        OpenPage(
            New UcManageStudent(),
            lblManageStudents
        )

    End Sub


    '==================================================
    ' QR CODE
    '==================================================
    Private Sub lblQRCode_Click(
        sender As Object,
        e As EventArgs
    ) Handles lblQRCode.Click

        OpenPage(
            New UcQrCode(),
            lblQRCode
        )

    End Sub


    '==================================================
    ' REPORTS
    '==================================================
    Private Sub lblReports_Click(
        sender As Object,
        e As EventArgs
    ) Handles lblReports.Click

        OpenPage(
            New UcGenerateReport(),
            lblReports
        )

    End Sub


    '==================================================
    ' SMS
    '==================================================
    Private Sub lblSMS_Click(
        sender As Object,
        e As EventArgs
    ) Handles lblSMS.Click

        OpenPage(
            New SmsNotifications(),
            lblSMS
        )

    End Sub


    '==================================================
    ' USER MANAGEMENT
    '==================================================
    Private Sub lblUserManagement_Click(
        sender As Object,
        e As EventArgs
    ) Handles lblUserManagement.Click

        OpenPage(
            New UserManagement(),
            lblUserManagement
        )

    End Sub


    '==================================================
    ' LOG OUT
    '==================================================
    Private Sub lblLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles lblLogout.Click

        Dim result As DialogResult =
        MessageBox.Show(
            "Are you sure you want to log out?",
            "Log Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            Dim login As New LoginForm()

            login.Show()

            Me.Hide()

        End If

    End Sub


    '==================================================
    ' HOVER EFFECTS
    '==================================================
    Private Sub Navigation_MouseEnter(
    sender As Object,
    e As EventArgs
    ) Handles lblDashboard.MouseEnter,
              lblManageStudents.MouseEnter,
              lblQRCode.MouseEnter,
              lblReports.MouseEnter,
              lblSMS.MouseEnter,
              lblUserManagement.MouseEnter,
              lblLogout.MouseEnter

        Dim nav As Label =
        DirectCast(sender, Label)

        If nav IsNot currentNavigation Then

            nav.BackColor =
            Color.FromArgb(120, 72, 45)

        End If

    End Sub


    Private Sub Navigation_MouseLeave(
        sender As Object,
        e As EventArgs
    ) Handles lblDashboard.MouseLeave,
              lblManageStudents.MouseLeave,
              lblQRCode.MouseLeave,
              lblReports.MouseLeave,
              lblSMS.MouseLeave,
              lblUserManagement.MouseLeave,
              lblLogout.MouseLeave

        Dim nav As Label =
        DirectCast(sender, Label)

        If nav IsNot currentNavigation Then
            nav.BackColor = Color.Transparent
        End If

    End Sub

End Class