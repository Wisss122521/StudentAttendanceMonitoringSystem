Public Class AdminForm

    Private currentNavigation As ToolStripMenuItem


    '==================================================
    ' COLORS
    '==================================================
    Private ReadOnly menuBackground As Color =
        Color.FromArgb(72, 40, 24)

    Private ReadOnly activeBackground As Color =
        Color.FromArgb(245, 234, 223)

    Private ReadOnly activeForeground As Color =
        Color.FromArgb(72, 40, 24)

    Private ReadOnly hoverBackground As Color =
        Color.FromArgb(103, 60, 36)


    '==================================================
    ' FORM LOAD
    '==================================================
    Private Sub AdminForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles Me.Load

        Me.DoubleBuffered = True


        ' Custom MenuStrip colors
        MenuStrip1.Renderer =
            New ToolStripProfessionalRenderer(
                New AdminMenuColorTable()
            )


        OpenPage(
            New UcDashboard(),
            mnuDashboard
        )

    End Sub


    '==================================================
    ' LOAD USER CONTROL
    '==================================================
    Private Sub LoadUserControl(
        uc As UserControl
    )

        pnlContent.SuspendLayout()


        Try

            ' Dispose current page
            While pnlContent.Controls.Count > 0

                Dim oldControl As Control =
                    pnlContent.Controls(0)

                pnlContent.Controls.RemoveAt(0)

                oldControl.Dispose()

            End While


            uc.Dock =
                DockStyle.Fill

            uc.Margin =
                New Padding(0)

            pnlContent.Controls.Add(
                uc
            )

            uc.BringToFront()


        Finally

            pnlContent.ResumeLayout()

        End Try

    End Sub


    '==================================================
    ' OPEN PAGE
    '==================================================
    Private Sub OpenPage(
        uc As UserControl,
        nav As ToolStripMenuItem
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
        selectedItem As ToolStripMenuItem
    )

        ResetNavigation()


        selectedItem.BackColor =
            activeBackground

        selectedItem.ForeColor =
            activeForeground


        currentNavigation =
            selectedItem

    End Sub


    '==================================================
    ' RESET NAVIGATION
    '==================================================
    Private Sub ResetNavigation()

        Dim navItems As ToolStripMenuItem() = {
            mnuDashboard,
            mnuManageStudents,
            mnuQRCode,
            mnuReports,
            mnuSMS,
            mnuUserManagement
        }


        For Each nav As ToolStripMenuItem In navItems

            nav.BackColor =
                Color.Transparent

            nav.ForeColor =
                Color.White

        Next

    End Sub


    '==================================================
    ' DASHBOARD
    '==================================================
    Private Sub mnuDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuDashboard.Click

        OpenPage(
            New UcDashboard(),
            mnuDashboard
        )

    End Sub


    '==================================================
    ' MANAGE STUDENTS
    '==================================================
    Private Sub mnuManageStudents_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuManageStudents.Click

        OpenPage(
            New UcManageStudent(),
            mnuManageStudents
        )

    End Sub


    '==================================================
    ' QR CODE
    '==================================================
    Private Sub mnuQRCode_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuQRCode.Click

        OpenPage(
            New UcQrCode(),
            mnuQRCode
        )

    End Sub


    '==================================================
    ' REPORTS
    '==================================================
    Private Sub mnuReports_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuReports.Click

        OpenPage(
            New UcGenerateReport(),
            mnuReports
        )

    End Sub


    '==================================================
    ' SMS
    '==================================================
    Private Sub mnuSMS_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuSMS.Click

        OpenPage(
            New UcSmsNotifications(),
            mnuSMS
        )

    End Sub


    '==================================================
    ' USER MANAGEMENT
    '==================================================
    Private Sub mnuUserManagement_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuUserManagement.Click

        OpenPage(
            New UcUserManagement(),
            mnuUserManagement
        )

    End Sub


    '==================================================
    ' LOG OUT
    '==================================================
    Private Sub mnuLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuLogout.Click

        Dim result As DialogResult =
            MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If result =
           DialogResult.Yes Then

            Me.Close()

        End If

    End Sub


    '==================================================
    ' NAVIGATION HOVER
    '==================================================
    Private Sub Navigation_MouseEnter(
        sender As Object,
        e As EventArgs
    ) Handles mnuDashboard.MouseEnter,
              mnuManageStudents.MouseEnter,
              mnuQRCode.MouseEnter,
              mnuReports.MouseEnter,
              mnuSMS.MouseEnter,
              mnuUserManagement.MouseEnter

        Dim nav As ToolStripMenuItem =
            DirectCast(
                sender,
                ToolStripMenuItem
            )


        If nav IsNot currentNavigation Then

            nav.BackColor =
                hoverBackground

            nav.ForeColor =
                Color.White

        End If

    End Sub


    '==================================================
    ' NAVIGATION MOUSE LEAVE
    '==================================================
    Private Sub Navigation_MouseLeave(
        sender As Object,
        e As EventArgs
    ) Handles mnuDashboard.MouseLeave,
              mnuManageStudents.MouseLeave,
              mnuQRCode.MouseLeave,
              mnuReports.MouseLeave,
              mnuSMS.MouseLeave,
              mnuUserManagement.MouseLeave

        Dim nav As ToolStripMenuItem =
            DirectCast(
                sender,
                ToolStripMenuItem
            )


        If nav Is currentNavigation Then

            nav.BackColor =
                activeBackground

            nav.ForeColor =
                activeForeground

        Else

            nav.BackColor =
                Color.Transparent

            nav.ForeColor =
                Color.White

        End If

    End Sub


    '==================================================
    ' LOGOUT HOVER
    '==================================================
    Private Sub mnuLogout_MouseEnter(
        sender As Object,
        e As EventArgs
    ) Handles mnuLogout.MouseEnter

        mnuLogout.BackColor =
            Color.FromArgb(123, 55, 37)

        mnuLogout.ForeColor =
            Color.White

    End Sub


    Private Sub mnuLogout_MouseLeave(
        sender As Object,
        e As EventArgs
    ) Handles mnuLogout.MouseLeave

        mnuLogout.BackColor =
            Color.FromArgb(92, 47, 28)

        mnuLogout.ForeColor =
            Color.White

    End Sub


    '==================================================
    ' MENU COLOR TABLE
    '==================================================
    Private Class AdminMenuColorTable

        Inherits ProfessionalColorTable


        Public Overrides ReadOnly Property MenuStripGradientBegin As Color
            Get
                Return Color.FromArgb(
                    72,
                    40,
                    24
                )
            End Get
        End Property


        Public Overrides ReadOnly Property MenuStripGradientEnd As Color
            Get
                Return Color.FromArgb(
                    72,
                    40,
                    24
                )
            End Get
        End Property


        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return Color.FromArgb(
                    103,
                    60,
                    36
                )
            End Get
        End Property


        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return Color.FromArgb(
                    103,
                    60,
                    36
                )
            End Get
        End Property


        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
            Get
                Return Color.FromArgb(
                    103,
                    60,
                    36
                )
            End Get
        End Property


        Public Overrides ReadOnly Property MenuItemPressedGradientMiddle As Color
            Get
                Return Color.FromArgb(
                    103,
                    60,
                    36
                )
            End Get
        End Property


        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
            Get
                Return Color.FromArgb(
                    103,
                    60,
                    36
                )
            End Get
        End Property


        Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
            Get
                Return Color.FromArgb(
                    247,
                    241,
                    236
                )
            End Get
        End Property

    End Class


End Class