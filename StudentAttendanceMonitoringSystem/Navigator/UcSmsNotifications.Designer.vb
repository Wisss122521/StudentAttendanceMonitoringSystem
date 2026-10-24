<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcSmsNotifications

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

        components = New ComponentModel.Container()

        '==================================================
        ' HEADER
        '==================================================
        pnlHeader = New Panel()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()

        '==================================================
        ' SEND SMS
        '==================================================
        pnlSendSMS = New Panel()
        pnlSendSMSHeader = New Panel()
        lblSendSMSTitle = New Label()

        lblStudentInfoHeader = New Label()

        lblSelectedStudentCaption = New Label()
        lblSelectedStudent = New Label()

        lblYearCourseCaption = New Label()
        lblYearCourse = New Label()

        lblContactCaption = New Label()
        lblContactNumber = New Label()

        lblMessageHeader = New Label()
        lblMessageCaption = New Label()

        txtMessage = New TextBox()
        lblCharacterCount = New Label()
        lblMessageHint = New Label()

        btnSendSMS = New Button()
        btnClearMessage = New Button()

        '==================================================
        ' STUDENTS
        '==================================================
        pnlStudents = New Panel()
        pnlStudentsHeader = New Panel()
        lblStudentsTitle = New Label()

        lblSearchStudent = New Label()
        txtSearchStudent = New TextBox()

        dgvStudents = New DataGridView()

        colStudentId = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colYearCourse = New DataGridViewTextBoxColumn()

        '==================================================
        ' SMS LOGS
        '==================================================
        pnlSMSLogs = New Panel()
        pnlSMSLogsHeader = New Panel()
        lblSMSLogsTitle = New Label()

        dgvSMSLogs = New DataGridView()

        colLogStudent = New DataGridViewTextBoxColumn()
        colLogContact = New DataGridViewTextBoxColumn()
        colLogType = New DataGridViewTextBoxColumn()
        colLogMessage = New DataGridViewTextBoxColumn()
        colLogSentAt = New DataGridViewTextBoxColumn()
        colLogStatus = New DataGridViewTextBoxColumn()

        '==================================================
        ' SUMMARY
        '==================================================
        pnlSummary = New Panel()
        lblSummaryTitle = New Label()

        pnlTotalLogs = New Panel()
        lblTotalLogsTitle = New Label()
        lblTotalLogs = New Label()

        pnlSent = New Panel()
        lblSentTitle = New Label()
        lblSentCount = New Label()

        pnlFailed = New Panel()
        lblFailedTitle = New Label()
        lblFailedCount = New Label()

        btnRefreshLogs = New Button()

        '==================================================
        ' TIMER
        '==================================================
        timerClock = New Timer(components)


        '==================================================
        ' SUSPEND
        '==================================================
        pnlHeader.SuspendLayout()

        pnlSendSMS.SuspendLayout()
        pnlSendSMSHeader.SuspendLayout()

        pnlStudents.SuspendLayout()
        pnlStudentsHeader.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()

        pnlSMSLogs.SuspendLayout()
        pnlSMSLogsHeader.SuspendLayout()
        CType(dgvSMSLogs, ComponentModel.ISupportInitialize).BeginInit()

        pnlSummary.SuspendLayout()

        pnlTotalLogs.SuspendLayout()
        pnlSent.SuspendLayout()
        pnlFailed.SuspendLayout()

        SuspendLayout()


        '==================================================
        ' pnlHeader
        ' MASTER SIZE: SAME AS USER MANAGEMENT
        '==================================================
        pnlHeader.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlHeader.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlHeader.BorderStyle =
            BorderStyle.FixedSingle

        pnlHeader.Controls.Add(lblDateTime)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)

        pnlHeader.Location =
            New Point(18, 14)

        pnlHeader.Margin =
            New Padding(3, 2, 3, 2)

        pnlHeader.Name =
            "pnlHeader"

        pnlHeader.Size =
            New Size(998, 68)

        pnlHeader.TabIndex =
            0


        '==================================================
        ' lblDateTime
        '==================================================
        lblDateTime.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblDateTime.Font =
            New Font(
                "Segoe UI Semibold",
                10.0F,
                FontStyle.Bold
            )

        lblDateTime.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblDateTime.Location =
            New Point(648, 24)

        lblDateTime.Name =
            "lblDateTime"

        lblDateTime.Size =
            New Size(324, 19)

        lblDateTime.TabIndex =
            2

        lblDateTime.Text =
            "Date | Time"

        lblDateTime.TextAlign =
            ContentAlignment.MiddleRight


        '==================================================
        ' lblSubtitle
        '==================================================
        lblSubtitle.AutoSize =
            True

        lblSubtitle.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        lblSubtitle.ForeColor =
            Color.FromArgb(117, 87, 71)

        lblSubtitle.Location =
            New Point(23, 44)

        lblSubtitle.Name =
            "lblSubtitle"

        lblSubtitle.TabIndex =
            1

        lblSubtitle.Text =
            "Send SMS to parents and view notification logs"


        '==================================================
        ' lblTitle
        '==================================================
        lblTitle.AutoSize =
            True

        lblTitle.Font =
            New Font(
                "Georgia",
                24.0F,
                FontStyle.Bold
            )

        lblTitle.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblTitle.Location =
            New Point(19, 10)

        lblTitle.Name =
            "lblTitle"

        lblTitle.TabIndex =
            0

        lblTitle.Text =
            "SMS Notifications"


        '==================================================
        ' pnlSendSMS
        ' SAME POSITION/SIZE AS USER INFORMATION
        '==================================================
        pnlSendSMS.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Left

        pnlSendSMS.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlSendSMS.BorderStyle =
            BorderStyle.FixedSingle

        pnlSendSMS.Controls.Add(btnClearMessage)
        pnlSendSMS.Controls.Add(btnSendSMS)

        pnlSendSMS.Controls.Add(lblCharacterCount)
        pnlSendSMS.Controls.Add(lblMessageHint)

        pnlSendSMS.Controls.Add(txtMessage)
        pnlSendSMS.Controls.Add(lblMessageCaption)
        pnlSendSMS.Controls.Add(lblMessageHeader)

        pnlSendSMS.Controls.Add(lblContactNumber)
        pnlSendSMS.Controls.Add(lblContactCaption)

        pnlSendSMS.Controls.Add(lblYearCourse)
        pnlSendSMS.Controls.Add(lblYearCourseCaption)

        pnlSendSMS.Controls.Add(lblSelectedStudent)
        pnlSendSMS.Controls.Add(lblSelectedStudentCaption)

        pnlSendSMS.Controls.Add(lblStudentInfoHeader)
        pnlSendSMS.Controls.Add(pnlSendSMSHeader)

        pnlSendSMS.Location =
            New Point(18, 90)

        pnlSendSMS.Margin =
            New Padding(3, 2, 3, 2)

        pnlSendSMS.Name =
            "pnlSendSMS"

        pnlSendSMS.Size =
            New Size(320, 342)

        pnlSendSMS.TabIndex =
            1


        '==================================================
        ' pnlSendSMSHeader
        '==================================================
        pnlSendSMSHeader.BackColor =
            Color.FromArgb(97, 55, 31)

        pnlSendSMSHeader.Controls.Add(
            lblSendSMSTitle
        )

        pnlSendSMSHeader.Dock =
            DockStyle.Top

        pnlSendSMSHeader.Location =
            New Point(0, 0)

        pnlSendSMSHeader.Name =
            "pnlSendSMSHeader"

        pnlSendSMSHeader.Size =
            New Size(318, 38)

        pnlSendSMSHeader.TabIndex =
            0


        '==================================================
        ' lblSendSMSTitle
        '==================================================
        lblSendSMSTitle.AutoSize =
            True

        lblSendSMSTitle.Font =
            New Font(
                "Segoe UI Semibold",
                12.0F,
                FontStyle.Bold
            )

        lblSendSMSTitle.ForeColor =
            Color.White

        lblSendSMSTitle.Location =
            New Point(14, 8)

        lblSendSMSTitle.Name =
            "lblSendSMSTitle"

        lblSendSMSTitle.Text =
            "Send SMS"


        '==================================================
        ' Student Information Header
        '==================================================
        lblStudentInfoHeader.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblStudentInfoHeader.BackColor =
            Color.FromArgb(247, 241, 236)

        lblStudentInfoHeader.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblStudentInfoHeader.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblStudentInfoHeader.Location =
            New Point(0, 38)

        lblStudentInfoHeader.Name =
            "lblStudentInfoHeader"

        lblStudentInfoHeader.Padding =
            New Padding(15, 0, 0, 0)

        lblStudentInfoHeader.Size =
            New Size(318, 26)

        lblStudentInfoHeader.Text =
            "Student Information"

        lblStudentInfoHeader.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' Selected Student
        '==================================================
        lblSelectedStudentCaption.AutoSize =
            True

        lblSelectedStudentCaption.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblSelectedStudentCaption.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblSelectedStudentCaption.Location =
            New Point(19, 68)

        lblSelectedStudentCaption.Name =
            "lblSelectedStudentCaption"

        lblSelectedStudentCaption.Text =
            "Selected Student"


        lblSelectedStudent.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblSelectedStudent.BackColor =
            Color.FromArgb(245, 245, 245)

        lblSelectedStudent.BorderStyle =
            BorderStyle.FixedSingle

        lblSelectedStudent.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        lblSelectedStudent.Location =
            New Point(22, 85)

        lblSelectedStudent.Name =
            "lblSelectedStudent"

        lblSelectedStudent.Padding =
            New Padding(6, 0, 0, 0)

        lblSelectedStudent.Size =
            New Size(274, 24)

        lblSelectedStudent.Text =
            "No student selected"

        lblSelectedStudent.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' Year / Course
        '==================================================
        lblYearCourseCaption.AutoSize =
            True

        lblYearCourseCaption.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblYearCourseCaption.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblYearCourseCaption.Location =
            New Point(19, 112)

        lblYearCourseCaption.Name =
            "lblYearCourseCaption"

        lblYearCourseCaption.Text =
            "Year / Course"


        lblYearCourse.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblYearCourse.BackColor =
            Color.FromArgb(245, 245, 245)

        lblYearCourse.BorderStyle =
            BorderStyle.FixedSingle

        lblYearCourse.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        lblYearCourse.Location =
            New Point(22, 129)

        lblYearCourse.Name =
            "lblYearCourse"

        lblYearCourse.Padding =
            New Padding(6, 0, 0, 0)

        lblYearCourse.Size =
            New Size(274, 24)

        lblYearCourse.Text =
            "-"

        lblYearCourse.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' Parent Contact Number
        '==================================================
        lblContactCaption.AutoSize =
            True

        lblContactCaption.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblContactCaption.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblContactCaption.Location =
            New Point(19, 156)

        lblContactCaption.Name =
            "lblContactCaption"

        lblContactCaption.Text =
            "Parent Contact Number"


        lblContactNumber.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblContactNumber.BackColor =
            Color.FromArgb(245, 245, 245)

        lblContactNumber.BorderStyle =
            BorderStyle.FixedSingle

        lblContactNumber.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        lblContactNumber.Location =
            New Point(22, 173)

        lblContactNumber.Name =
            "lblContactNumber"

        lblContactNumber.Padding =
            New Padding(6, 0, 0, 0)

        lblContactNumber.Size =
            New Size(274, 24)

        lblContactNumber.Text =
            "-"

        lblContactNumber.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' Message Header
        '==================================================
        lblMessageHeader.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblMessageHeader.BackColor =
            Color.FromArgb(247, 241, 236)

        lblMessageHeader.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblMessageHeader.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblMessageHeader.Location =
            New Point(0, 205)

        lblMessageHeader.Name =
            "lblMessageHeader"

        lblMessageHeader.Padding =
            New Padding(15, 0, 0, 0)

        lblMessageHeader.Size =
            New Size(318, 24)

        lblMessageHeader.Text =
            "Message Details"

        lblMessageHeader.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' Message Caption
        '==================================================
        lblMessageCaption.AutoSize =
            True

        lblMessageCaption.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblMessageCaption.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblMessageCaption.Location =
            New Point(19, 232)

        lblMessageCaption.Name =
            "lblMessageCaption"

        lblMessageCaption.Text =
            "Message Content *"


        '==================================================
        ' txtMessage
        '==================================================
        txtMessage.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        txtMessage.BorderStyle =
            BorderStyle.FixedSingle

        txtMessage.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        txtMessage.Location =
            New Point(22, 249)

        txtMessage.MaxLength =
            160

        txtMessage.Multiline =
            True

        txtMessage.Name =
            "txtMessage"

        txtMessage.ScrollBars =
            ScrollBars.Vertical

        txtMessage.Size =
            New Size(274, 41)

        txtMessage.TabIndex =
            10


        '==================================================
        ' Message Hint
        '==================================================
        lblMessageHint.AutoSize =
            True

        lblMessageHint.Font =
            New Font(
                "Segoe UI",
                7.5F
            )

        lblMessageHint.ForeColor =
            Color.DimGray

        lblMessageHint.Location =
            New Point(22, 293)

        lblMessageHint.Name =
            "lblMessageHint"

        lblMessageHint.Text =
            "Maximum 160 characters."


        '==================================================
        ' Character Count
        '==================================================
        lblCharacterCount.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblCharacterCount.Font =
            New Font(
                "Segoe UI",
                7.5F
            )

        lblCharacterCount.Location =
            New Point(191, 292)

        lblCharacterCount.Name =
            "lblCharacterCount"

        lblCharacterCount.Size =
            New Size(105, 16)

        lblCharacterCount.Text =
            "0 / 160"

        lblCharacterCount.TextAlign =
            ContentAlignment.MiddleRight


        '==================================================
        ' Send SMS Button
        '==================================================
        btnSendSMS.BackColor =
            Color.FromArgb(103, 60, 36)

        btnSendSMS.Cursor =
            Cursors.Hand

        btnSendSMS.FlatAppearance.BorderSize =
            0

        btnSendSMS.FlatStyle =
            FlatStyle.Flat

        btnSendSMS.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        btnSendSMS.ForeColor =
            Color.White

        btnSendSMS.Location =
            New Point(22, 310)

        btnSendSMS.Name =
            "btnSendSMS"

        btnSendSMS.Size =
            New Size(180, 26)

        btnSendSMS.TabIndex =
            13

        btnSendSMS.Text =
            "Send SMS"

        btnSendSMS.UseVisualStyleBackColor =
            False


        '==================================================
        ' Clear Button
        '==================================================
        btnClearMessage.BackColor =
            Color.FromArgb(242, 230, 220)

        btnClearMessage.Cursor =
            Cursors.Hand

        btnClearMessage.FlatAppearance.BorderColor =
            Color.FromArgb(205, 183, 167)

        btnClearMessage.FlatStyle =
            FlatStyle.Flat

        btnClearMessage.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        btnClearMessage.ForeColor =
            Color.FromArgb(75, 41, 24)

        btnClearMessage.Location =
            New Point(210, 310)

        btnClearMessage.Name =
            "btnClearMessage"

        btnClearMessage.Size =
            New Size(86, 26)

        btnClearMessage.TabIndex =
            14

        btnClearMessage.Text =
            "Clear"

        btnClearMessage.UseVisualStyleBackColor =
            False


        '==================================================
        ' pnlStudents
        ' SAME RIGHT COLUMN AS USER MANAGEMENT
        '==================================================
        pnlStudents.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlStudents.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlStudents.BorderStyle =
            BorderStyle.FixedSingle

        pnlStudents.Controls.Add(dgvStudents)
        pnlStudents.Controls.Add(txtSearchStudent)
        pnlStudents.Controls.Add(lblSearchStudent)
        pnlStudents.Controls.Add(pnlStudentsHeader)

        pnlStudents.Location =
            New Point(350, 90)

        pnlStudents.Margin =
            New Padding(3, 2, 3, 2)

        pnlStudents.Name =
            "pnlStudents"

        pnlStudents.Size =
            New Size(665, 180)

        pnlStudents.TabIndex =
            2


        '==================================================
        ' Student List Header
        '==================================================
        pnlStudentsHeader.BackColor =
            Color.FromArgb(97, 55, 31)

        pnlStudentsHeader.Controls.Add(
            lblStudentsTitle
        )

        pnlStudentsHeader.Dock =
            DockStyle.Top

        pnlStudentsHeader.Location =
            New Point(0, 0)

        pnlStudentsHeader.Name =
            "pnlStudentsHeader"

        pnlStudentsHeader.Size =
            New Size(663, 38)


        lblStudentsTitle.AutoSize =
            True

        lblStudentsTitle.Font =
            New Font(
                "Segoe UI Semibold",
                12.0F,
                FontStyle.Bold
            )

        lblStudentsTitle.ForeColor =
            Color.White

        lblStudentsTitle.Location =
            New Point(14, 8)

        lblStudentsTitle.Name =
            "lblStudentsTitle"

        lblStudentsTitle.Text =
            "Student List"


        '==================================================
        ' Search Student
        '==================================================
        lblSearchStudent.AutoSize =
            True

        lblSearchStudent.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblSearchStudent.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblSearchStudent.Location =
            New Point(16, 52)

        lblSearchStudent.Name =
            "lblSearchStudent"

        lblSearchStudent.Text =
            "Search Student"


        txtSearchStudent.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        txtSearchStudent.BorderStyle =
            BorderStyle.FixedSingle

        txtSearchStudent.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        txtSearchStudent.Location =
            New Point(125, 48)

        txtSearchStudent.Name =
            "txtSearchStudent"

        txtSearchStudent.Size =
            New Size(519, 25)

        txtSearchStudent.TabIndex =
            2


        '==================================================
        ' dgvStudents
        '==================================================
        dgvStudents.AllowUserToAddRows =
            False

        dgvStudents.AllowUserToDeleteRows =
            False

        dgvStudents.AllowUserToResizeRows =
            False

        dgvStudents.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        dgvStudents.AutoGenerateColumns =
            False

        dgvStudents.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvStudents.BackgroundColor =
            Color.White

        dgvStudents.BorderStyle =
            BorderStyle.None

        dgvStudents.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal

        dgvStudents.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvStudents.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(93, 50, 29)

        dgvStudents.ColumnHeadersDefaultCellStyle.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White

        dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            Color.FromArgb(93, 50, 29)

        dgvStudents.ColumnHeadersDefaultCellStyle.SelectionForeColor =
            Color.White

        dgvStudents.ColumnHeadersHeight =
            34

        dgvStudents.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        dgvStudents.Columns.AddRange(
            New DataGridViewColumn() {
                colStudentId,
                colStudentName,
                colYearCourse
            }
        )

        dgvStudents.DefaultCellStyle.BackColor =
            Color.White

        dgvStudents.DefaultCellStyle.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        dgvStudents.DefaultCellStyle.ForeColor =
            Color.FromArgb(50, 35, 28)

        dgvStudents.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(233, 216, 202)

        dgvStudents.DefaultCellStyle.SelectionForeColor =
            Color.FromArgb(52, 32, 23)

        dgvStudents.EnableHeadersVisualStyles =
            False

        dgvStudents.GridColor =
            Color.FromArgb(225, 211, 201)

        dgvStudents.Location =
            New Point(18, 82)

        dgvStudents.MultiSelect =
            False

        dgvStudents.Name =
            "dgvStudents"

        dgvStudents.ReadOnly =
            True

        dgvStudents.RowHeadersVisible =
            False

        dgvStudents.RowTemplate.Height =
            30

        dgvStudents.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvStudents.Size =
            New Size(626, 82)

        dgvStudents.TabIndex =
            3


        '==================================================
        ' Student Columns
        '==================================================
        colStudentId.DataPropertyName =
            "student_id"

        colStudentId.FillWeight =
            35.0F

        colStudentId.HeaderText =
            "Student ID"

        colStudentId.Name =
            "colStudentId"

        colStudentId.ReadOnly =
            True


        colStudentName.DataPropertyName =
            "student_name"

        colStudentName.FillWeight =
            90.0F

        colStudentName.HeaderText =
            "Student Name"

        colStudentName.Name =
            "colStudentName"

        colStudentName.ReadOnly =
            True


        colYearCourse.DataPropertyName =
            "year_course"

        colYearCourse.FillWeight =
            65.0F

        colYearCourse.HeaderText =
            "Year / Course"

        colYearCourse.Name =
            "colYearCourse"

        colYearCourse.ReadOnly =
            True


        '==================================================
        ' pnlSMSLogs
        '==================================================
        pnlSMSLogs.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlSMSLogs.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlSMSLogs.BorderStyle =
            BorderStyle.FixedSingle

        pnlSMSLogs.Controls.Add(dgvSMSLogs)
        pnlSMSLogs.Controls.Add(pnlSMSLogsHeader)

        pnlSMSLogs.Location =
            New Point(350, 280)

        pnlSMSLogs.Margin =
            New Padding(3, 2, 3, 2)

        pnlSMSLogs.Name =
            "pnlSMSLogs"

        pnlSMSLogs.Size =
            New Size(665, 152)

        pnlSMSLogs.TabIndex =
            3


        '==================================================
        ' SMS Logs Header
        '==================================================
        pnlSMSLogsHeader.BackColor =
            Color.FromArgb(97, 55, 31)

        pnlSMSLogsHeader.Controls.Add(
            lblSMSLogsTitle
        )

        pnlSMSLogsHeader.Dock =
            DockStyle.Top

        pnlSMSLogsHeader.Location =
            New Point(0, 0)

        pnlSMSLogsHeader.Name =
            "pnlSMSLogsHeader"

        pnlSMSLogsHeader.Size =
            New Size(663, 38)


        lblSMSLogsTitle.AutoSize =
            True

        lblSMSLogsTitle.Font =
            New Font(
                "Segoe UI Semibold",
                12.0F,
                FontStyle.Bold
            )

        lblSMSLogsTitle.ForeColor =
            Color.White

        lblSMSLogsTitle.Location =
            New Point(14, 8)

        lblSMSLogsTitle.Name =
            "lblSMSLogsTitle"

        lblSMSLogsTitle.Text =
            "SMS Logs"


        '==================================================
        ' dgvSMSLogs
        '==================================================
        dgvSMSLogs.AllowUserToAddRows =
            False

        dgvSMSLogs.AllowUserToDeleteRows =
            False

        dgvSMSLogs.AllowUserToResizeRows =
            False

        dgvSMSLogs.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        dgvSMSLogs.AutoGenerateColumns =
            False

        dgvSMSLogs.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvSMSLogs.BackgroundColor =
            Color.White

        dgvSMSLogs.BorderStyle =
            BorderStyle.None

        dgvSMSLogs.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal

        dgvSMSLogs.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvSMSLogs.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(93, 50, 29)

        dgvSMSLogs.ColumnHeadersDefaultCellStyle.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        dgvSMSLogs.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White

        dgvSMSLogs.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            Color.FromArgb(93, 50, 29)

        dgvSMSLogs.ColumnHeadersDefaultCellStyle.SelectionForeColor =
            Color.White

        dgvSMSLogs.ColumnHeadersHeight =
            34

        dgvSMSLogs.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        dgvSMSLogs.Columns.AddRange(
            New DataGridViewColumn() {
                colLogStudent,
                colLogContact,
                colLogType,
                colLogMessage,
                colLogSentAt,
                colLogStatus
            }
        )

        dgvSMSLogs.DefaultCellStyle.BackColor =
            Color.White

        dgvSMSLogs.DefaultCellStyle.Font =
            New Font(
                "Segoe UI",
                8.5F
            )

        dgvSMSLogs.DefaultCellStyle.ForeColor =
            Color.FromArgb(50, 35, 28)

        dgvSMSLogs.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(233, 216, 202)

        dgvSMSLogs.DefaultCellStyle.SelectionForeColor =
            Color.FromArgb(52, 32, 23)

        dgvSMSLogs.EnableHeadersVisualStyles =
            False

        dgvSMSLogs.GridColor =
            Color.FromArgb(225, 211, 201)

        dgvSMSLogs.Location =
            New Point(18, 50)

        dgvSMSLogs.MultiSelect =
            False

        dgvSMSLogs.Name =
            "dgvSMSLogs"

        dgvSMSLogs.ReadOnly =
            True

        dgvSMSLogs.RowHeadersVisible =
            False

        dgvSMSLogs.RowTemplate.Height =
            30

        dgvSMSLogs.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvSMSLogs.Size =
            New Size(626, 84)

        dgvSMSLogs.TabIndex =
            1


        '==================================================
        ' SMS Log Columns
        '==================================================
        colLogStudent.DataPropertyName =
            "student_name"

        colLogStudent.HeaderText =
            "Student Name"

        colLogStudent.Name =
            "colLogStudent"

        colLogStudent.FillWeight =
            65.0F

        colLogStudent.ReadOnly =
            True


        colLogContact.DataPropertyName =
            "contact_number"

        colLogContact.HeaderText =
            "Contact Number"

        colLogContact.Name =
            "colLogContact"

        colLogContact.FillWeight =
            55.0F

        colLogContact.ReadOnly =
            True


        colLogType.DataPropertyName =
            "sms_type"

        colLogType.HeaderText =
            "Type"

        colLogType.Name =
            "colLogType"

        colLogType.FillWeight =
            35.0F

        colLogType.ReadOnly =
            True


        colLogMessage.DataPropertyName =
            "message"

        colLogMessage.HeaderText =
            "Message"

        colLogMessage.Name =
            "colLogMessage"

        colLogMessage.FillWeight =
            125.0F

        colLogMessage.ReadOnly =
            True


        colLogSentAt.DataPropertyName =
            "sent_at"

        colLogSentAt.HeaderText =
            "Date & Time"

        colLogSentAt.Name =
            "colLogSentAt"

        colLogSentAt.FillWeight =
            70.0F

        colLogSentAt.ReadOnly =
            True


        colLogStatus.DataPropertyName =
            "status"

        colLogStatus.HeaderText =
            "Status"

        colLogStatus.Name =
            "colLogStatus"

        colLogStatus.FillWeight =
            38.0F

        colLogStatus.ReadOnly =
            True


        '==================================================
        ' pnlSummary
        ' EXACT SAME POSITION AS USER MANAGEMENT
        '==================================================
        pnlSummary.Anchor =
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlSummary.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlSummary.BorderStyle =
            BorderStyle.FixedSingle

        pnlSummary.Controls.Add(btnRefreshLogs)

        pnlSummary.Controls.Add(pnlFailed)
        pnlSummary.Controls.Add(pnlSent)
        pnlSummary.Controls.Add(pnlTotalLogs)

        pnlSummary.Controls.Add(lblSummaryTitle)

        pnlSummary.Location =
            New Point(18, 442)

        pnlSummary.Margin =
            New Padding(3, 2, 3, 2)

        pnlSummary.Name =
            "pnlSummary"

        pnlSummary.Size =
            New Size(998, 83)

        pnlSummary.TabIndex =
            4


        '==================================================
        ' Summary Title
        '==================================================
        lblSummaryTitle.AutoSize =
            True

        lblSummaryTitle.Font =
            New Font(
                "Segoe UI Semibold",
                10.5F,
                FontStyle.Bold
            )

        lblSummaryTitle.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblSummaryTitle.Location =
            New Point(16, 8)

        lblSummaryTitle.Name =
            "lblSummaryTitle"

        lblSummaryTitle.Text =
            "Summary"


        '==================================================
        ' Refresh Logs
        '==================================================
        btnRefreshLogs.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        btnRefreshLogs.BackColor =
            Color.FromArgb(242, 230, 220)

        btnRefreshLogs.Cursor =
            Cursors.Hand

        btnRefreshLogs.FlatAppearance.BorderColor =
            Color.FromArgb(205, 183, 167)

        btnRefreshLogs.FlatStyle =
            FlatStyle.Flat

        btnRefreshLogs.Font =
            New Font(
                "Segoe UI Semibold",
                8.0F,
                FontStyle.Bold
            )

        btnRefreshLogs.ForeColor =
            Color.FromArgb(75, 41, 24)

        btnRefreshLogs.Location =
            New Point(842, 4)

        btnRefreshLogs.Name =
            "btnRefreshLogs"

        btnRefreshLogs.Size =
            New Size(130, 22)

        btnRefreshLogs.TabIndex =
            4

        btnRefreshLogs.Text =
            "Refresh Logs"

        btnRefreshLogs.UseVisualStyleBackColor =
            False


        '==================================================
        ' Total Logs
        ' SAME SIZE/POSITION AS TOTAL USERS
        '==================================================
        pnlTotalLogs.BackColor =
            Color.FromArgb(245, 234, 223)

        pnlTotalLogs.Controls.Add(lblTotalLogs)
        pnlTotalLogs.Controls.Add(lblTotalLogsTitle)

        pnlTotalLogs.Location =
            New Point(18, 30)

        pnlTotalLogs.Name =
            "pnlTotalLogs"

        pnlTotalLogs.Size =
            New Size(302, 41)

        pnlTotalLogs.TabIndex =
            1


        lblTotalLogs.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblTotalLogs.Font =
            New Font(
                "Segoe UI",
                18.0F,
                FontStyle.Bold
            )

        lblTotalLogs.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblTotalLogs.Location =
            New Point(219, 5)

        lblTotalLogs.Name =
            "lblTotalLogs"

        lblTotalLogs.Size =
            New Size(66, 30)

        lblTotalLogs.Text =
            "0"

        lblTotalLogs.TextAlign =
            ContentAlignment.MiddleRight


        lblTotalLogsTitle.AutoSize =
            True

        lblTotalLogsTitle.Font =
            New Font(
                "Segoe UI",
                9.5F
            )

        lblTotalLogsTitle.Location =
            New Point(12, 6)

        lblTotalLogsTitle.Name =
            "lblTotalLogsTitle"

        lblTotalLogsTitle.Text =
            "Total Logs"


        '==================================================
        ' Sent
        ' SAME POSITION AS ADMIN ACCOUNTS
        '==================================================
        pnlSent.Anchor =
            AnchorStyles.Top

        pnlSent.BackColor =
            Color.FromArgb(226, 242, 230)

        pnlSent.Controls.Add(lblSentCount)
        pnlSent.Controls.Add(lblSentTitle)

        pnlSent.Location =
            New Point(346, 30)

        pnlSent.Name =
            "pnlSent"

        pnlSent.Size =
            New Size(302, 41)

        pnlSent.TabIndex =
            2


        lblSentCount.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblSentCount.Font =
            New Font(
                "Segoe UI",
                18.0F,
                FontStyle.Bold
            )

        lblSentCount.ForeColor =
            Color.FromArgb(40, 100, 60)

        lblSentCount.Location =
            New Point(219, 5)

        lblSentCount.Name =
            "lblSentCount"

        lblSentCount.Size =
            New Size(66, 30)

        lblSentCount.Text =
            "0"

        lblSentCount.TextAlign =
            ContentAlignment.MiddleRight


        lblSentTitle.AutoSize =
            True

        lblSentTitle.Font =
            New Font(
                "Segoe UI",
                9.5F
            )

        lblSentTitle.Location =
            New Point(12, 6)

        lblSentTitle.Name =
            "lblSentTitle"

        lblSentTitle.Text =
            "Sent"


        '==================================================
        ' Failed
        ' SAME POSITION AS GUARD ACCOUNTS
        '==================================================
        pnlFailed.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        pnlFailed.BackColor =
            Color.FromArgb(248, 224, 220)

        pnlFailed.Controls.Add(lblFailedCount)
        pnlFailed.Controls.Add(lblFailedTitle)

        pnlFailed.Location =
            New Point(674, 30)

        pnlFailed.Name =
            "pnlFailed"

        pnlFailed.Size =
            New Size(302, 41)

        pnlFailed.TabIndex =
            3


        lblFailedCount.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblFailedCount.Font =
            New Font(
                "Segoe UI",
                18.0F,
                FontStyle.Bold
            )

        lblFailedCount.ForeColor =
            Color.FromArgb(170, 45, 45)

        lblFailedCount.Location =
            New Point(219, 5)

        lblFailedCount.Name =
            "lblFailedCount"

        lblFailedCount.Size =
            New Size(66, 30)

        lblFailedCount.Text =
            "0"

        lblFailedCount.TextAlign =
            ContentAlignment.MiddleRight


        lblFailedTitle.AutoSize =
            True

        lblFailedTitle.Font =
            New Font(
                "Segoe UI",
                9.5F
            )

        lblFailedTitle.Location =
            New Point(12, 6)

        lblFailedTitle.Name =
            "lblFailedTitle"

        lblFailedTitle.Text =
            "Failed"


        '==================================================
        ' timerClock
        '==================================================
        timerClock.Interval =
            1000


        '==================================================
        ' UcSmsNotifications
        ' SAME BASE SIZE AS USER MANAGEMENT
        '==================================================
        AutoScaleDimensions =
            New SizeF(7.0F, 15.0F)

        AutoScaleMode =
            AutoScaleMode.Font

        BackColor =
            Color.FromArgb(247, 241, 236)

        Controls.Add(pnlSummary)
        Controls.Add(pnlSMSLogs)
        Controls.Add(pnlStudents)
        Controls.Add(pnlSendSMS)
        Controls.Add(pnlHeader)

        Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        Margin =
            New Padding(3, 2, 3, 2)

        Name =
            "UcSmsNotifications"

        Size =
            New Size(1032, 540)


        '==================================================
        ' RESUME
        '==================================================
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()

        pnlSendSMSHeader.ResumeLayout(False)
        pnlSendSMSHeader.PerformLayout()

        pnlSendSMS.ResumeLayout(False)
        pnlSendSMS.PerformLayout()

        pnlStudentsHeader.ResumeLayout(False)
        pnlStudentsHeader.PerformLayout()

        CType(
            dgvStudents,
            ComponentModel.ISupportInitialize
        ).EndInit()

        pnlStudents.ResumeLayout(False)
        pnlStudents.PerformLayout()

        pnlSMSLogsHeader.ResumeLayout(False)
        pnlSMSLogsHeader.PerformLayout()

        CType(
            dgvSMSLogs,
            ComponentModel.ISupportInitialize
        ).EndInit()

        pnlSMSLogs.ResumeLayout(False)

        pnlTotalLogs.ResumeLayout(False)
        pnlTotalLogs.PerformLayout()

        pnlSent.ResumeLayout(False)
        pnlSent.PerformLayout()

        pnlFailed.ResumeLayout(False)
        pnlFailed.PerformLayout()

        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()

        ResumeLayout(False)

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