<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SmsNotifications

    Inherits System.Windows.Forms.UserControl

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

        Me.components = New System.ComponentModel.Container()

        '==================================================
        ' MAIN CONTROLS
        '==================================================
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()

        '==================================================
        ' SEND SMS PANEL
        '==================================================
        Me.pnlSendSMS = New System.Windows.Forms.Panel()
        Me.pnlSendSMSHeader = New System.Windows.Forms.Panel()
        Me.lblSendSMSTitle = New System.Windows.Forms.Label()

        Me.lblStudentInfoHeader = New System.Windows.Forms.Label()

        Me.lblSelectedStudentCaption = New System.Windows.Forms.Label()
        Me.lblSelectedStudent = New System.Windows.Forms.Label()

        Me.lblYearCourseCaption = New System.Windows.Forms.Label()
        Me.lblYearCourse = New System.Windows.Forms.Label()

        Me.lblContactCaption = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()

        Me.lblMessageHeader = New System.Windows.Forms.Label()
        Me.lblMessageCaption = New System.Windows.Forms.Label()

        Me.txtMessage = New System.Windows.Forms.TextBox()

        Me.lblCharacterCount = New System.Windows.Forms.Label()
        Me.lblMessageHint = New System.Windows.Forms.Label()

        Me.btnSendSMS = New System.Windows.Forms.Button()
        Me.btnClearMessage = New System.Windows.Forms.Button()

        '==================================================
        ' STUDENT LIST PANEL
        '==================================================
        Me.pnlStudents = New System.Windows.Forms.Panel()
        Me.pnlStudentsHeader = New System.Windows.Forms.Panel()
        Me.lblStudentsTitle = New System.Windows.Forms.Label()

        Me.lblSearchStudent = New System.Windows.Forms.Label()
        Me.txtSearchStudent = New System.Windows.Forms.TextBox()

        Me.dgvStudents = New System.Windows.Forms.DataGridView()

        Me.colStudentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()

        '==================================================
        ' SMS LOGS PANEL
        '==================================================
        Me.pnlSMSLogs = New System.Windows.Forms.Panel()
        Me.pnlSMSLogsHeader = New System.Windows.Forms.Panel()
        Me.lblSMSLogsTitle = New System.Windows.Forms.Label()

        Me.dgvSMSLogs = New System.Windows.Forms.DataGridView()

        Me.colLogStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLogContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLogType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLogMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLogSentAt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLogStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()

        '==================================================
        ' SUMMARY
        '==================================================
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblSummaryTitle = New System.Windows.Forms.Label()

        Me.pnlTotalLogs = New System.Windows.Forms.Panel()
        Me.lblTotalLogsTitle = New System.Windows.Forms.Label()
        Me.lblTotalLogs = New System.Windows.Forms.Label()

        Me.pnlSent = New System.Windows.Forms.Panel()
        Me.lblSentTitle = New System.Windows.Forms.Label()
        Me.lblSentCount = New System.Windows.Forms.Label()

        Me.pnlFailed = New System.Windows.Forms.Panel()
        Me.lblFailedTitle = New System.Windows.Forms.Label()
        Me.lblFailedCount = New System.Windows.Forms.Label()

        Me.btnRefreshLogs = New System.Windows.Forms.Button()

        Me.timerClock = New System.Windows.Forms.Timer(Me.components)


        '==================================================
        ' SUSPEND
        '==================================================
        Me.pnlHeader.SuspendLayout()

        Me.pnlSendSMS.SuspendLayout()
        Me.pnlSendSMSHeader.SuspendLayout()

        Me.pnlStudents.SuspendLayout()
        Me.pnlStudentsHeader.SuspendLayout()

        CType(Me.dgvStudents,
            System.ComponentModel.ISupportInitialize).BeginInit()

        Me.pnlSMSLogs.SuspendLayout()
        Me.pnlSMSLogsHeader.SuspendLayout()

        CType(Me.dgvSMSLogs,
            System.ComponentModel.ISupportInitialize).BeginInit()

        Me.pnlSummary.SuspendLayout()
        Me.pnlTotalLogs.SuspendLayout()
        Me.pnlSent.SuspendLayout()
        Me.pnlFailed.SuspendLayout()

        Me.SuspendLayout()


        '==================================================
        ' pnlHeader
        '==================================================
        Me.pnlHeader.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlHeader.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlHeader.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlHeader.Controls.Add(Me.lblDateTime)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)

        Me.pnlHeader.Location =
            New System.Drawing.Point(15, 15)

        Me.pnlHeader.Name =
            "pnlHeader"

        Me.pnlHeader.Size =
            New System.Drawing.Size(1430, 75)

        Me.pnlHeader.TabIndex = 0


        '==================================================
        ' lblTitle
        '==================================================
        Me.lblTitle.AutoSize = True

        Me.lblTitle.Font =
            New System.Drawing.Font(
                "Georgia",
                23.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTitle.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblTitle.Location =
            New System.Drawing.Point(20, 8)

        Me.lblTitle.Name =
            "lblTitle"

        Me.lblTitle.Size =
            New System.Drawing.Size(300, 44)

        Me.lblTitle.TabIndex = 0

        Me.lblTitle.Text =
            "SMS Notifications"


        '==================================================
        ' lblSubtitle
        '==================================================
        Me.lblSubtitle.AutoSize = True

        Me.lblSubtitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblSubtitle.ForeColor =
            System.Drawing.Color.FromArgb(117, 87, 71)

        Me.lblSubtitle.Location =
            New System.Drawing.Point(23, 49)

        Me.lblSubtitle.Name =
            "lblSubtitle"

        Me.lblSubtitle.Size =
            New System.Drawing.Size(310, 20)

        Me.lblSubtitle.TabIndex = 1

        Me.lblSubtitle.Text =
            "Send SMS to parents and view notification logs"


        '==================================================
        ' lblDateTime
        '==================================================
        Me.lblDateTime.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblDateTime.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblDateTime.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblDateTime.Location =
            New System.Drawing.Point(930, 25)

        Me.lblDateTime.Name =
            "lblDateTime"

        Me.lblDateTime.Size =
            New System.Drawing.Size(470, 25)

        Me.lblDateTime.TabIndex = 2

        Me.lblDateTime.Text =
            "Friday, October 23, 2026   |   06:17:23 PM"

        Me.lblDateTime.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' pnlSendSMS
        '==================================================
        Me.pnlSendSMS.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlSendSMS.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlSendSMS.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlSendSMS.Controls.Add(Me.btnClearMessage)
        Me.pnlSendSMS.Controls.Add(Me.btnSendSMS)

        Me.pnlSendSMS.Controls.Add(Me.lblMessageHint)
        Me.pnlSendSMS.Controls.Add(Me.lblCharacterCount)
        Me.pnlSendSMS.Controls.Add(Me.txtMessage)
        Me.pnlSendSMS.Controls.Add(Me.lblMessageCaption)
        Me.pnlSendSMS.Controls.Add(Me.lblMessageHeader)

        Me.pnlSendSMS.Controls.Add(Me.lblContactNumber)
        Me.pnlSendSMS.Controls.Add(Me.lblContactCaption)

        Me.pnlSendSMS.Controls.Add(Me.lblYearCourse)
        Me.pnlSendSMS.Controls.Add(Me.lblYearCourseCaption)

        Me.pnlSendSMS.Controls.Add(Me.lblSelectedStudent)
        Me.pnlSendSMS.Controls.Add(Me.lblSelectedStudentCaption)

        Me.pnlSendSMS.Controls.Add(Me.lblStudentInfoHeader)

        Me.pnlSendSMS.Controls.Add(Me.pnlSendSMSHeader)

        Me.pnlSendSMS.Location =
            New System.Drawing.Point(15, 100)

        Me.pnlSendSMS.Name =
            "pnlSendSMS"

        Me.pnlSendSMS.Size =
            New System.Drawing.Size(430, 570)

        Me.pnlSendSMS.TabIndex = 1


        '==================================================
        ' pnlSendSMSHeader
        '==================================================
        Me.pnlSendSMSHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlSendSMSHeader.Controls.Add(
            Me.lblSendSMSTitle
        )

        Me.pnlSendSMSHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlSendSMSHeader.Location =
            New System.Drawing.Point(0, 0)

        Me.pnlSendSMSHeader.Name =
            "pnlSendSMSHeader"

        Me.pnlSendSMSHeader.Size =
            New System.Drawing.Size(428, 38)

        Me.pnlSendSMSHeader.TabIndex = 0


        '==================================================
        ' lblSendSMSTitle
        '==================================================
        Me.lblSendSMSTitle.AutoSize = True

        Me.lblSendSMSTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                11.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSendSMSTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblSendSMSTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblSendSMSTitle.Name =
            "lblSendSMSTitle"

        Me.lblSendSMSTitle.Size =
            New System.Drawing.Size(91, 25)

        Me.lblSendSMSTitle.TabIndex = 0

        Me.lblSendSMSTitle.Text =
            "Send SMS"


        '==================================================
        ' lblStudentInfoHeader
        '==================================================
        Me.lblStudentInfoHeader.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblStudentInfoHeader.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.lblStudentInfoHeader.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblStudentInfoHeader.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblStudentInfoHeader.Location =
            New System.Drawing.Point(0, 38)

        Me.lblStudentInfoHeader.Name =
            "lblStudentInfoHeader"

        Me.lblStudentInfoHeader.Padding =
            New System.Windows.Forms.Padding(15, 0, 0, 0)

        Me.lblStudentInfoHeader.Size =
            New System.Drawing.Size(428, 34)

        Me.lblStudentInfoHeader.TabIndex = 1

        Me.lblStudentInfoHeader.Text =
            "Student Information"

        Me.lblStudentInfoHeader.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblSelectedStudentCaption
        '==================================================
        Me.lblSelectedStudentCaption.AutoSize = True

        Me.lblSelectedStudentCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSelectedStudentCaption.Location =
            New System.Drawing.Point(18, 85)

        Me.lblSelectedStudentCaption.Name =
            "lblSelectedStudentCaption"

        Me.lblSelectedStudentCaption.Size =
            New System.Drawing.Size(126, 20)

        Me.lblSelectedStudentCaption.TabIndex = 2

        Me.lblSelectedStudentCaption.Text =
            "Selected Student"


        '==================================================
        ' lblSelectedStudent
        '==================================================
        Me.lblSelectedStudent.BackColor =
            System.Drawing.Color.FromArgb(245, 245, 245)

        Me.lblSelectedStudent.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblSelectedStudent.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.5!
            )

        Me.lblSelectedStudent.Location =
            New System.Drawing.Point(20, 108)

        Me.lblSelectedStudent.Name =
            "lblSelectedStudent"

        Me.lblSelectedStudent.Padding =
            New System.Windows.Forms.Padding(8, 0, 0, 0)

        Me.lblSelectedStudent.Size =
            New System.Drawing.Size(385, 32)

        Me.lblSelectedStudent.TabIndex = 3

        Me.lblSelectedStudent.Text =
            "No student selected"

        Me.lblSelectedStudent.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblYearCourseCaption
        '==================================================
        Me.lblYearCourseCaption.AutoSize = True

        Me.lblYearCourseCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblYearCourseCaption.Location =
            New System.Drawing.Point(18, 151)

        Me.lblYearCourseCaption.Name =
            "lblYearCourseCaption"

        Me.lblYearCourseCaption.Size =
            New System.Drawing.Size(109, 20)

        Me.lblYearCourseCaption.TabIndex = 4

        Me.lblYearCourseCaption.Text =
            "Year / Course"


        '==================================================
        ' lblYearCourse
        '==================================================
        Me.lblYearCourse.BackColor =
            System.Drawing.Color.FromArgb(245, 245, 245)

        Me.lblYearCourse.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblYearCourse.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.5!
            )

        Me.lblYearCourse.Location =
            New System.Drawing.Point(20, 174)

        Me.lblYearCourse.Name =
            "lblYearCourse"

        Me.lblYearCourse.Padding =
            New System.Windows.Forms.Padding(8, 0, 0, 0)

        Me.lblYearCourse.Size =
            New System.Drawing.Size(385, 32)

        Me.lblYearCourse.TabIndex = 5

        Me.lblYearCourse.Text =
            "-"

        Me.lblYearCourse.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblContactCaption
        '==================================================
        Me.lblContactCaption.AutoSize = True

        Me.lblContactCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblContactCaption.Location =
            New System.Drawing.Point(18, 217)

        Me.lblContactCaption.Name =
            "lblContactCaption"

        Me.lblContactCaption.Size =
            New System.Drawing.Size(175, 20)

        Me.lblContactCaption.TabIndex = 6

        Me.lblContactCaption.Text =
            "Parent Contact Number"


        '==================================================
        ' lblContactNumber
        '==================================================
        Me.lblContactNumber.BackColor =
            System.Drawing.Color.FromArgb(245, 245, 245)

        Me.lblContactNumber.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblContactNumber.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.5!
            )

        Me.lblContactNumber.Location =
            New System.Drawing.Point(20, 240)

        Me.lblContactNumber.Name =
            "lblContactNumber"

        Me.lblContactNumber.Padding =
            New System.Windows.Forms.Padding(8, 0, 0, 0)

        Me.lblContactNumber.Size =
            New System.Drawing.Size(385, 32)

        Me.lblContactNumber.TabIndex = 7

        Me.lblContactNumber.Text =
            "-"

        Me.lblContactNumber.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblMessageHeader
        '==================================================
        Me.lblMessageHeader.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblMessageHeader.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.lblMessageHeader.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblMessageHeader.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblMessageHeader.Location =
            New System.Drawing.Point(0, 288)

        Me.lblMessageHeader.Name =
            "lblMessageHeader"

        Me.lblMessageHeader.Padding =
            New System.Windows.Forms.Padding(15, 0, 0, 0)

        Me.lblMessageHeader.Size =
            New System.Drawing.Size(428, 34)

        Me.lblMessageHeader.TabIndex = 8

        Me.lblMessageHeader.Text =
            "Message Details"

        Me.lblMessageHeader.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblMessageCaption
        '==================================================
        Me.lblMessageCaption.AutoSize = True

        Me.lblMessageCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblMessageCaption.Location =
            New System.Drawing.Point(18, 334)

        Me.lblMessageCaption.Name =
            "lblMessageCaption"

        Me.lblMessageCaption.Size =
            New System.Drawing.Size(140, 20)

        Me.lblMessageCaption.TabIndex = 9

        Me.lblMessageCaption.Text =
            "Message Content *"


        '==================================================
        ' txtMessage
        '==================================================
        Me.txtMessage.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.txtMessage.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.txtMessage.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.5!
            )

        Me.txtMessage.Location =
            New System.Drawing.Point(20, 359)

        Me.txtMessage.MaxLength =
            160

        Me.txtMessage.Multiline =
            True

        Me.txtMessage.Name =
            "txtMessage"

        Me.txtMessage.ScrollBars =
            System.Windows.Forms.ScrollBars.Vertical

        Me.txtMessage.Size =
            New System.Drawing.Size(385, 100)

        Me.txtMessage.TabIndex = 10


        '==================================================
        ' lblCharacterCount
        '==================================================
        Me.lblCharacterCount.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.5!
            )

        Me.lblCharacterCount.Location =
            New System.Drawing.Point(280, 462)

        Me.lblCharacterCount.Name =
            "lblCharacterCount"

        Me.lblCharacterCount.Size =
            New System.Drawing.Size(125, 22)

        Me.lblCharacterCount.TabIndex = 11

        Me.lblCharacterCount.Text =
            "Characters: 0 / 160"

        Me.lblCharacterCount.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' lblMessageHint
        '==================================================
        Me.lblMessageHint.AutoSize = True

        Me.lblMessageHint.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.0!
            )

        Me.lblMessageHint.ForeColor =
            System.Drawing.Color.DimGray

        Me.lblMessageHint.Location =
            New System.Drawing.Point(20, 468)

        Me.lblMessageHint.Name =
            "lblMessageHint"

        Me.lblMessageHint.Size =
            New System.Drawing.Size(211, 19)

        Me.lblMessageHint.TabIndex = 12

        Me.lblMessageHint.Text =
            "Maximum of 160 characters."


        '==================================================
        ' btnSendSMS
        '==================================================
        Me.btnSendSMS.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.btnSendSMS.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnSendSMS.FlatAppearance.BorderSize =
            0

        Me.btnSendSMS.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnSendSMS.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnSendSMS.ForeColor =
            System.Drawing.Color.White

        Me.btnSendSMS.Location =
            New System.Drawing.Point(20, 505)

        Me.btnSendSMS.Name =
            "btnSendSMS"

        Me.btnSendSMS.Size =
            New System.Drawing.Size(245, 43)

        Me.btnSendSMS.TabIndex = 13

        Me.btnSendSMS.Text =
            "Send SMS"

        Me.btnSendSMS.UseVisualStyleBackColor =
            False


        '==================================================
        ' btnClearMessage
        '==================================================
        Me.btnClearMessage.BackColor =
            System.Drawing.Color.FromArgb(242, 230, 220)

        Me.btnClearMessage.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnClearMessage.FlatAppearance.BorderColor =
            System.Drawing.Color.FromArgb(205, 183, 167)

        Me.btnClearMessage.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnClearMessage.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnClearMessage.ForeColor =
            System.Drawing.Color.FromArgb(75, 41, 24)

        Me.btnClearMessage.Location =
            New System.Drawing.Point(275, 505)

        Me.btnClearMessage.Name =
            "btnClearMessage"

        Me.btnClearMessage.Size =
            New System.Drawing.Size(130, 43)

        Me.btnClearMessage.TabIndex = 14

        Me.btnClearMessage.Text =
            "Clear"

        Me.btnClearMessage.UseVisualStyleBackColor =
            False


        '==================================================
        ' pnlStudents
        '==================================================
        Me.pnlStudents.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlStudents.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlStudents.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlStudents.Controls.Add(Me.dgvStudents)
        Me.pnlStudents.Controls.Add(Me.txtSearchStudent)
        Me.pnlStudents.Controls.Add(Me.lblSearchStudent)
        Me.pnlStudents.Controls.Add(Me.pnlStudentsHeader)

        Me.pnlStudents.Location =
            New System.Drawing.Point(455, 100)

        Me.pnlStudents.Name =
            "pnlStudents"

        Me.pnlStudents.Size =
            New System.Drawing.Size(990, 315)

        Me.pnlStudents.TabIndex = 2


        '==================================================
        ' pnlStudentsHeader
        '==================================================
        Me.pnlStudentsHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlStudentsHeader.Controls.Add(
            Me.lblStudentsTitle
        )

        Me.pnlStudentsHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlStudentsHeader.Location =
            New System.Drawing.Point(0, 0)

        Me.pnlStudentsHeader.Name =
            "pnlStudentsHeader"

        Me.pnlStudentsHeader.Size =
            New System.Drawing.Size(988, 38)

        Me.pnlStudentsHeader.TabIndex = 0


        '==================================================
        ' lblStudentsTitle
        '==================================================
        Me.lblStudentsTitle.AutoSize = True

        Me.lblStudentsTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                11.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblStudentsTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblStudentsTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblStudentsTitle.Name =
            "lblStudentsTitle"

        Me.lblStudentsTitle.Size =
            New System.Drawing.Size(114, 25)

        Me.lblStudentsTitle.TabIndex = 0

        Me.lblStudentsTitle.Text =
            "Student List"


        '==================================================
        ' lblSearchStudent
        '==================================================
        Me.lblSearchStudent.AutoSize = True

        Me.lblSearchStudent.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSearchStudent.Location =
            New System.Drawing.Point(16, 49)

        Me.lblSearchStudent.Name =
            "lblSearchStudent"

        Me.lblSearchStudent.Size =
            New System.Drawing.Size(107, 20)

        Me.lblSearchStudent.TabIndex = 1

        Me.lblSearchStudent.Text =
            "Search Student"


        '==================================================
        ' txtSearchStudent
        '==================================================
        Me.txtSearchStudent.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.txtSearchStudent.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.txtSearchStudent.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.txtSearchStudent.Location =
            New System.Drawing.Point(18, 71)

        Me.txtSearchStudent.Name =
            "txtSearchStudent"

        Me.txtSearchStudent.Size =
            New System.Drawing.Size(950, 27)

        Me.txtSearchStudent.TabIndex = 2


        '==================================================
        ' dgvStudents
        '==================================================
        Me.dgvStudents.AllowUserToAddRows =
            False

        Me.dgvStudents.AllowUserToDeleteRows =
            False

        Me.dgvStudents.AllowUserToResizeRows =
            False

        Me.dgvStudents.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.dgvStudents.AutoGenerateColumns =
            False

        Me.dgvStudents.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvStudents.BackgroundColor =
            System.Drawing.Color.White

        Me.dgvStudents.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.dgvStudents.CellBorderStyle =
            System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        Me.dgvStudents.ColumnHeadersHeight =
            38

        Me.dgvStudents.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.dgvStudents.Columns.AddRange(
            New System.Windows.Forms.DataGridViewColumn() {
                Me.colStudentId,
                Me.colStudentName,
                Me.colYearCourse
            }
        )

        Me.dgvStudents.EnableHeadersVisualStyles =
            False

        Me.dgvStudents.GridColor =
            System.Drawing.Color.FromArgb(225, 211, 201)

        Me.dgvStudents.Location =
            New System.Drawing.Point(18, 110)

        Me.dgvStudents.MultiSelect =
            False

        Me.dgvStudents.Name =
            "dgvStudents"

        Me.dgvStudents.ReadOnly =
            True

        Me.dgvStudents.RowHeadersVisible =
            False

        Me.dgvStudents.RowTemplate.Height =
            34

        Me.dgvStudents.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.dgvStudents.Size =
            New System.Drawing.Size(950, 185)

        Me.dgvStudents.TabIndex = 3


        '==================================================
        ' dgvStudents HEADER STYLE
        '==================================================
        Me.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor =
            System.Drawing.Color.White

        Me.dgvStudents.ColumnHeadersDefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.dgvStudents.ColumnHeadersDefaultCellStyle.Alignment =
            System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter


        '==================================================
        ' dgvStudents ROW STYLE
        '==================================================
        Me.dgvStudents.DefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.dgvStudents.DefaultCellStyle.BackColor =
            System.Drawing.Color.White

        Me.dgvStudents.DefaultCellStyle.ForeColor =
            System.Drawing.Color.FromArgb(50, 35, 28)

        Me.dgvStudents.DefaultCellStyle.SelectionBackColor =
            System.Drawing.Color.FromArgb(233, 216, 202)

        Me.dgvStudents.DefaultCellStyle.SelectionForeColor =
            System.Drawing.Color.FromArgb(52, 32, 23)


        '==================================================
        ' colStudentId
        '==================================================
        Me.colStudentId.DataPropertyName =
            "student_id"

        Me.colStudentId.FillWeight =
            35.0!

        Me.colStudentId.HeaderText =
            "Student ID"

        Me.colStudentId.Name =
            "colStudentId"

        Me.colStudentId.ReadOnly =
            True


        '==================================================
        ' colStudentName
        '==================================================
        Me.colStudentName.DataPropertyName =
            "student_name"

        Me.colStudentName.FillWeight =
            90.0!

        Me.colStudentName.HeaderText =
            "Student Name"

        Me.colStudentName.Name =
            "colStudentName"

        Me.colStudentName.ReadOnly =
            True


        '==================================================
        ' colYearCourse
        '==================================================
        Me.colYearCourse.DataPropertyName =
            "year_course"

        Me.colYearCourse.FillWeight =
            65.0!

        Me.colYearCourse.HeaderText =
            "Year / Course"

        Me.colYearCourse.Name =
            "colYearCourse"

        Me.colYearCourse.ReadOnly =
            True


        '==================================================
        ' pnlSMSLogs
        '==================================================
        Me.pnlSMSLogs.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlSMSLogs.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlSMSLogs.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlSMSLogs.Controls.Add(Me.dgvSMSLogs)
        Me.pnlSMSLogs.Controls.Add(Me.pnlSMSLogsHeader)

        Me.pnlSMSLogs.Location =
            New System.Drawing.Point(455, 425)

        Me.pnlSMSLogs.Name =
            "pnlSMSLogs"

        Me.pnlSMSLogs.Size =
            New System.Drawing.Size(990, 245)

        Me.pnlSMSLogs.TabIndex = 3


        '==================================================
        ' pnlSMSLogsHeader
        '==================================================
        Me.pnlSMSLogsHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlSMSLogsHeader.Controls.Add(
            Me.lblSMSLogsTitle
        )

        Me.pnlSMSLogsHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlSMSLogsHeader.Location =
            New System.Drawing.Point(0, 0)

        Me.pnlSMSLogsHeader.Name =
            "pnlSMSLogsHeader"

        Me.pnlSMSLogsHeader.Size =
            New System.Drawing.Size(988, 38)

        Me.pnlSMSLogsHeader.TabIndex = 0


        '==================================================
        ' lblSMSLogsTitle
        '==================================================
        Me.lblSMSLogsTitle.AutoSize = True

        Me.lblSMSLogsTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                11.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSMSLogsTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblSMSLogsTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblSMSLogsTitle.Name =
            "lblSMSLogsTitle"

        Me.lblSMSLogsTitle.Size =
            New System.Drawing.Size(92, 25)

        Me.lblSMSLogsTitle.TabIndex = 0

        Me.lblSMSLogsTitle.Text =
            "SMS Logs"


        '==================================================
        ' dgvSMSLogs
        '==================================================
        Me.dgvSMSLogs.AllowUserToAddRows =
            False

        Me.dgvSMSLogs.AllowUserToDeleteRows =
            False

        Me.dgvSMSLogs.AllowUserToResizeRows =
            False

        Me.dgvSMSLogs.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.dgvSMSLogs.AutoGenerateColumns =
            False

        Me.dgvSMSLogs.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvSMSLogs.BackgroundColor =
            System.Drawing.Color.White

        Me.dgvSMSLogs.BorderStyle =
            System.Windows.Forms.BorderStyle.None

        Me.dgvSMSLogs.CellBorderStyle =
            System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        Me.dgvSMSLogs.ColumnHeadersHeight =
            38

        Me.dgvSMSLogs.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.dgvSMSLogs.Columns.AddRange(
            New System.Windows.Forms.DataGridViewColumn() {
                Me.colLogStudent,
                Me.colLogContact,
                Me.colLogType,
                Me.colLogMessage,
                Me.colLogSentAt,
                Me.colLogStatus
            }
        )

        Me.dgvSMSLogs.EnableHeadersVisualStyles =
            False

        Me.dgvSMSLogs.GridColor =
            System.Drawing.Color.FromArgb(225, 211, 201)

        Me.dgvSMSLogs.Location =
            New System.Drawing.Point(15, 53)

        Me.dgvSMSLogs.MultiSelect =
            False

        Me.dgvSMSLogs.Name =
            "dgvSMSLogs"

        Me.dgvSMSLogs.ReadOnly =
            True

        Me.dgvSMSLogs.RowHeadersVisible =
            False

        Me.dgvSMSLogs.RowTemplate.Height =
            32

        Me.dgvSMSLogs.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.dgvSMSLogs.Size =
            New System.Drawing.Size(958, 175)

        Me.dgvSMSLogs.TabIndex = 1


        '==================================================
        ' SMS LOG HEADER STYLE
        '==================================================
        Me.dgvSMSLogs.ColumnHeadersDefaultCellStyle.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.dgvSMSLogs.ColumnHeadersDefaultCellStyle.ForeColor =
            System.Drawing.Color.White

        Me.dgvSMSLogs.ColumnHeadersDefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.dgvSMSLogs.ColumnHeadersDefaultCellStyle.Alignment =
            System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter


        '==================================================
        ' SMS LOG ROW STYLE
        '==================================================
        Me.dgvSMSLogs.DefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.5!
            )

        Me.dgvSMSLogs.DefaultCellStyle.BackColor =
            System.Drawing.Color.White

        Me.dgvSMSLogs.DefaultCellStyle.ForeColor =
            System.Drawing.Color.FromArgb(50, 35, 28)

        Me.dgvSMSLogs.DefaultCellStyle.SelectionBackColor =
            System.Drawing.Color.FromArgb(233, 216, 202)

        Me.dgvSMSLogs.DefaultCellStyle.SelectionForeColor =
            System.Drawing.Color.FromArgb(52, 32, 23)


        '==================================================
        ' SMS LOG COLUMNS
        '==================================================
        Me.colLogStudent.DataPropertyName =
            "student_name"

        Me.colLogStudent.HeaderText =
            "Student Name"

        Me.colLogStudent.Name =
            "colLogStudent"

        Me.colLogStudent.FillWeight =
            65.0!

        Me.colLogStudent.ReadOnly =
            True


        Me.colLogContact.DataPropertyName =
            "contact_number"

        Me.colLogContact.HeaderText =
            "Contact Number"

        Me.colLogContact.Name =
            "colLogContact"

        Me.colLogContact.FillWeight =
            55.0!

        Me.colLogContact.ReadOnly =
            True


        Me.colLogType.DataPropertyName =
            "sms_type"

        Me.colLogType.HeaderText =
            "Type"

        Me.colLogType.Name =
            "colLogType"

        Me.colLogType.FillWeight =
            35.0!

        Me.colLogType.ReadOnly =
            True


        Me.colLogMessage.DataPropertyName =
            "message"

        Me.colLogMessage.HeaderText =
            "Message"

        Me.colLogMessage.Name =
            "colLogMessage"

        Me.colLogMessage.FillWeight =
            125.0!

        Me.colLogMessage.ReadOnly =
            True


        Me.colLogSentAt.DataPropertyName =
            "sent_at"

        Me.colLogSentAt.HeaderText =
            "Date & Time"

        Me.colLogSentAt.Name =
            "colLogSentAt"

        Me.colLogSentAt.FillWeight =
            70.0!

        Me.colLogSentAt.ReadOnly =
            True


        Me.colLogStatus.DataPropertyName =
            "status"

        Me.colLogStatus.HeaderText =
            "Status"

        Me.colLogStatus.Name =
            "colLogStatus"

        Me.colLogStatus.FillWeight =
            38.0!

        Me.colLogStatus.ReadOnly =
            True


        '==================================================
        ' pnlSummary
        '==================================================
        Me.pnlSummary.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlSummary.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlSummary.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlSummary.Controls.Add(Me.btnRefreshLogs)

        Me.pnlSummary.Controls.Add(Me.pnlFailed)
        Me.pnlSummary.Controls.Add(Me.pnlSent)
        Me.pnlSummary.Controls.Add(Me.pnlTotalLogs)

        Me.pnlSummary.Controls.Add(Me.lblSummaryTitle)

        Me.pnlSummary.Location =
            New System.Drawing.Point(15, 682)

        Me.pnlSummary.Name =
            "pnlSummary"

        Me.pnlSummary.Size =
            New System.Drawing.Size(1430, 83)

        Me.pnlSummary.TabIndex = 4


        '==================================================
        ' lblSummaryTitle
        '==================================================
        Me.lblSummaryTitle.AutoSize = True

        Me.lblSummaryTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSummaryTitle.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblSummaryTitle.Location =
            New System.Drawing.Point(15, 6)

        Me.lblSummaryTitle.Name =
            "lblSummaryTitle"

        Me.lblSummaryTitle.Size =
            New System.Drawing.Size(75, 20)

        Me.lblSummaryTitle.TabIndex = 0

        Me.lblSummaryTitle.Text =
            "Summary"


        '==================================================
        ' pnlTotalLogs
        '==================================================
        Me.pnlTotalLogs.BackColor =
            System.Drawing.Color.FromArgb(245, 234, 223)

        Me.pnlTotalLogs.Controls.Add(Me.lblTotalLogs)
        Me.pnlTotalLogs.Controls.Add(Me.lblTotalLogsTitle)

        Me.pnlTotalLogs.Location =
            New System.Drawing.Point(15, 32)

        Me.pnlTotalLogs.Name =
            "pnlTotalLogs"

        Me.pnlTotalLogs.Size =
            New System.Drawing.Size(310, 38)

        Me.pnlTotalLogs.TabIndex = 1


        Me.lblTotalLogsTitle.AutoSize =
            True

        Me.lblTotalLogsTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.5!
            )

        Me.lblTotalLogsTitle.Location =
            New System.Drawing.Point(12, 9)

        Me.lblTotalLogsTitle.Name =
            "lblTotalLogsTitle"

        Me.lblTotalLogsTitle.Size =
            New System.Drawing.Size(71, 20)

        Me.lblTotalLogsTitle.TabIndex = 0

        Me.lblTotalLogsTitle.Text =
            "Total Logs"


        Me.lblTotalLogs.Font =
            New System.Drawing.Font(
                "Segoe UI",
                13.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTotalLogs.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblTotalLogs.Location =
            New System.Drawing.Point(240, 4)

        Me.lblTotalLogs.Name =
            "lblTotalLogs"

        Me.lblTotalLogs.Size =
            New System.Drawing.Size(55, 30)

        Me.lblTotalLogs.TabIndex = 1

        Me.lblTotalLogs.Text =
            "0"

        Me.lblTotalLogs.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' pnlSent
        '==================================================
        Me.pnlSent.Anchor =
            System.Windows.Forms.AnchorStyles.Top

        Me.pnlSent.BackColor =
            System.Drawing.Color.FromArgb(226, 242, 230)

        Me.pnlSent.Controls.Add(Me.lblSentCount)
        Me.pnlSent.Controls.Add(Me.lblSentTitle)

        Me.pnlSent.Location =
            New System.Drawing.Point(430, 32)

        Me.pnlSent.Name =
            "pnlSent"

        Me.pnlSent.Size =
            New System.Drawing.Size(310, 38)

        Me.pnlSent.TabIndex = 2


        Me.lblSentTitle.AutoSize =
            True

        Me.lblSentTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.5!
            )

        Me.lblSentTitle.Location =
            New System.Drawing.Point(12, 9)

        Me.lblSentTitle.Name =
            "lblSentTitle"

        Me.lblSentTitle.Size =
            New System.Drawing.Size(37, 20)

        Me.lblSentTitle.TabIndex = 0

        Me.lblSentTitle.Text =
            "Sent"


        Me.lblSentCount.Font =
            New System.Drawing.Font(
                "Segoe UI",
                13.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSentCount.ForeColor =
            System.Drawing.Color.FromArgb(40, 100, 60)

        Me.lblSentCount.Location =
            New System.Drawing.Point(240, 4)

        Me.lblSentCount.Name =
            "lblSentCount"

        Me.lblSentCount.Size =
            New System.Drawing.Size(55, 30)

        Me.lblSentCount.TabIndex = 1

        Me.lblSentCount.Text =
            "0"

        Me.lblSentCount.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' pnlFailed
        '==================================================
        Me.pnlFailed.Anchor =
            System.Windows.Forms.AnchorStyles.Top

        Me.pnlFailed.BackColor =
            System.Drawing.Color.FromArgb(248, 224, 220)

        Me.pnlFailed.Controls.Add(Me.lblFailedCount)
        Me.pnlFailed.Controls.Add(Me.lblFailedTitle)

        Me.pnlFailed.Location =
            New System.Drawing.Point(845, 32)

        Me.pnlFailed.Name =
            "pnlFailed"

        Me.pnlFailed.Size =
            New System.Drawing.Size(310, 38)

        Me.pnlFailed.TabIndex = 3


        Me.lblFailedTitle.AutoSize =
            True

        Me.lblFailedTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.5!
            )

        Me.lblFailedTitle.Location =
            New System.Drawing.Point(12, 9)

        Me.lblFailedTitle.Name =
            "lblFailedTitle"

        Me.lblFailedTitle.Size =
            New System.Drawing.Size(46, 20)

        Me.lblFailedTitle.TabIndex = 0

        Me.lblFailedTitle.Text =
            "Failed"


        Me.lblFailedCount.Font =
            New System.Drawing.Font(
                "Segoe UI",
                13.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblFailedCount.ForeColor =
            System.Drawing.Color.FromArgb(170, 45, 45)

        Me.lblFailedCount.Location =
            New System.Drawing.Point(240, 4)

        Me.lblFailedCount.Name =
            "lblFailedCount"

        Me.lblFailedCount.Size =
            New System.Drawing.Size(55, 30)

        Me.lblFailedCount.TabIndex = 1

        Me.lblFailedCount.Text =
            "0"

        Me.lblFailedCount.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' btnRefreshLogs
        '==================================================
        Me.btnRefreshLogs.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.btnRefreshLogs.BackColor =
            System.Drawing.Color.FromArgb(242, 230, 220)

        Me.btnRefreshLogs.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnRefreshLogs.FlatAppearance.BorderColor =
            System.Drawing.Color.FromArgb(205, 183, 167)

        Me.btnRefreshLogs.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnRefreshLogs.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnRefreshLogs.ForeColor =
            System.Drawing.Color.FromArgb(75, 41, 24)

        Me.btnRefreshLogs.Location =
            New System.Drawing.Point(1240, 31)

        Me.btnRefreshLogs.Name =
            "btnRefreshLogs"

        Me.btnRefreshLogs.Size =
            New System.Drawing.Size(170, 39)

        Me.btnRefreshLogs.TabIndex = 4

        Me.btnRefreshLogs.Text =
            "Refresh Logs"

        Me.btnRefreshLogs.UseVisualStyleBackColor =
            False


        '==================================================
        ' timerClock
        '==================================================
        Me.timerClock.Interval =
            1000


        '==================================================
        ' SmsNotification
        '==================================================
        Me.AutoScaleDimensions =
            New System.Drawing.SizeF(8.0!, 20.0!)

        Me.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font

        Me.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlSMSLogs)
        Me.Controls.Add(Me.pnlStudents)
        Me.Controls.Add(Me.pnlSendSMS)
        Me.Controls.Add(Me.pnlHeader)

        Me.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.Name =
            "SmsNotification"

        Me.Size =
            New System.Drawing.Size(1460, 780)


        '==================================================
        ' RESUME
        '==================================================
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()

        Me.pnlSendSMSHeader.ResumeLayout(False)
        Me.pnlSendSMSHeader.PerformLayout()

        Me.pnlSendSMS.ResumeLayout(False)
        Me.pnlSendSMS.PerformLayout()

        Me.pnlStudentsHeader.ResumeLayout(False)
        Me.pnlStudentsHeader.PerformLayout()

        CType(
            Me.dgvStudents,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlStudents.ResumeLayout(False)
        Me.pnlStudents.PerformLayout()

        Me.pnlSMSLogsHeader.ResumeLayout(False)
        Me.pnlSMSLogsHeader.PerformLayout()

        CType(
            Me.dgvSMSLogs,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlSMSLogs.ResumeLayout(False)

        Me.pnlTotalLogs.ResumeLayout(False)
        Me.pnlTotalLogs.PerformLayout()

        Me.pnlSent.ResumeLayout(False)
        Me.pnlSent.PerformLayout()

        Me.pnlFailed.ResumeLayout(False)
        Me.pnlFailed.PerformLayout()

        Me.pnlSummary.ResumeLayout(False)
        Me.pnlSummary.PerformLayout()

        Me.ResumeLayout(False)

    End Sub


    '==================================================
    ' DECLARATIONS
    '==================================================

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label

    Friend WithEvents pnlSendSMS As Panel
    Friend WithEvents pnlSendSMSHeader As Panel
    Friend WithEvents lblSendSMSTitle As Label

    Friend WithEvents lblStudentInfoHeader As Label

    Friend WithEvents lblSelectedStudentCaption As Label
    Friend WithEvents lblSelectedStudent As Label

    Friend WithEvents lblYearCourseCaption As Label
    Friend WithEvents lblYearCourse As Label

    Friend WithEvents lblContactCaption As Label
    Friend WithEvents lblContactNumber As Label

    Friend WithEvents lblMessageHeader As Label
    Friend WithEvents lblMessageCaption As Label

    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblCharacterCount As Label
    Friend WithEvents lblMessageHint As Label

    Friend WithEvents btnSendSMS As Button
    Friend WithEvents btnClearMessage As Button

    Friend WithEvents pnlStudents As Panel
    Friend WithEvents pnlStudentsHeader As Panel
    Friend WithEvents lblStudentsTitle As Label

    Friend WithEvents lblSearchStudent As Label
    Friend WithEvents txtSearchStudent As TextBox

    Friend WithEvents dgvStudents As DataGridView

    Friend WithEvents colStudentId As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearCourse As DataGridViewTextBoxColumn

    Friend WithEvents pnlSMSLogs As Panel
    Friend WithEvents pnlSMSLogsHeader As Panel
    Friend WithEvents lblSMSLogsTitle As Label

    Friend WithEvents dgvSMSLogs As DataGridView

    Friend WithEvents colLogStudent As DataGridViewTextBoxColumn
    Friend WithEvents colLogContact As DataGridViewTextBoxColumn
    Friend WithEvents colLogType As DataGridViewTextBoxColumn
    Friend WithEvents colLogMessage As DataGridViewTextBoxColumn
    Friend WithEvents colLogSentAt As DataGridViewTextBoxColumn
    Friend WithEvents colLogStatus As DataGridViewTextBoxColumn

    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label

    Friend WithEvents pnlTotalLogs As Panel
    Friend WithEvents lblTotalLogsTitle As Label
    Friend WithEvents lblTotalLogs As Label

    Friend WithEvents pnlSent As Panel
    Friend WithEvents lblSentTitle As Label
    Friend WithEvents lblSentCount As Label

    Friend WithEvents pnlFailed As Panel
    Friend WithEvents lblFailedTitle As Label
    Friend WithEvents lblFailedCount As Label

    Friend WithEvents btnRefreshLogs As Button

    Friend WithEvents timerClock As Timer

End Class