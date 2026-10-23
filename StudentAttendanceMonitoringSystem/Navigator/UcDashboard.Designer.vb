<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcDashboard

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
        ' HEADER
        '==================================================
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()

        '==================================================
        ' STATISTICS
        '==================================================
        Me.tlpStats = New System.Windows.Forms.TableLayoutPanel()

        Me.pnlTotalStudents = New System.Windows.Forms.Panel()
        Me.lblTotalStudentsTitle = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()

        Me.pnlQRGenerated = New System.Windows.Forms.Panel()
        Me.lblQRGeneratedTitle = New System.Windows.Forms.Label()
        Me.lblQRGenerated = New System.Windows.Forms.Label()

        Me.pnlTodayEntry = New System.Windows.Forms.Panel()
        Me.lblTodayEntryTitle = New System.Windows.Forms.Label()
        Me.lblTodayEntry = New System.Windows.Forms.Label()

        Me.pnlTodayExit = New System.Windows.Forms.Panel()
        Me.lblTodayExitTitle = New System.Windows.Forms.Label()
        Me.lblTodayExit = New System.Windows.Forms.Label()

        '==================================================
        ' MIDDLE
        '==================================================
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        '==================================================
        ' ENTRY EXIT
        '==================================================
        Me.pnlRecentEntryExit = New System.Windows.Forms.Panel()
        Me.pnlRecentEntryExitHeader = New System.Windows.Forms.Panel()
        Me.lblRecentEntryExitTitle = New System.Windows.Forms.Label()

        Me.dgvRecentEntryExit = New System.Windows.Forms.DataGridView()

        Me.colEntryStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEntryStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEntryYearCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEntryTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEntryTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()

        '==================================================
        ' SMS
        '==================================================
        Me.pnlRecentSMS = New System.Windows.Forms.Panel()
        Me.pnlRecentSMSHeader = New System.Windows.Forms.Panel()
        Me.lblRecentSMSTitle = New System.Windows.Forms.Label()

        Me.dgvRecentSMS = New System.Windows.Forms.DataGridView()

        Me.colSMSStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSMSType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSMSSentAt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSMSStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()

        '==================================================
        ' QUICK OVERVIEW
        '==================================================
        Me.pnlQuickOverview = New System.Windows.Forms.Panel()
        Me.lblQuickOverviewTitle = New System.Windows.Forms.Label()

        Me.tlpQuickOverview = New System.Windows.Forms.TableLayoutPanel()

        Me.pnlQRNotGenerated = New System.Windows.Forms.Panel()
        Me.lblQRNotGeneratedTitle = New System.Windows.Forms.Label()
        Me.lblQRNotGenerated = New System.Windows.Forms.Label()

        Me.pnlNoExitToday = New System.Windows.Forms.Panel()
        Me.lblNoExitTodayTitle = New System.Windows.Forms.Label()
        Me.lblNoExitToday = New System.Windows.Forms.Label()

        Me.pnlFailedSMS = New System.Windows.Forms.Panel()
        Me.lblFailedSMSTitle = New System.Windows.Forms.Label()
        Me.lblFailedSMS = New System.Windows.Forms.Label()

        '==================================================
        ' TIMER
        '==================================================
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)


        '==================================================
        ' SUSPEND
        '==================================================
        Me.pnlHeader.SuspendLayout()

        Me.tlpStats.SuspendLayout()

        Me.pnlTotalStudents.SuspendLayout()
        Me.pnlQRGenerated.SuspendLayout()
        Me.pnlTodayEntry.SuspendLayout()
        Me.pnlTodayExit.SuspendLayout()

        Me.tlpMiddle.SuspendLayout()

        Me.pnlRecentEntryExit.SuspendLayout()
        Me.pnlRecentEntryExitHeader.SuspendLayout()

        CType(
            Me.dgvRecentEntryExit,
            System.ComponentModel.ISupportInitialize
        ).BeginInit()

        Me.pnlRecentSMS.SuspendLayout()
        Me.pnlRecentSMSHeader.SuspendLayout()

        CType(
            Me.dgvRecentSMS,
            System.ComponentModel.ISupportInitialize
        ).BeginInit()

        Me.pnlQuickOverview.SuspendLayout()
        Me.tlpQuickOverview.SuspendLayout()

        Me.pnlQRNotGenerated.SuspendLayout()
        Me.pnlNoExitToday.SuspendLayout()
        Me.pnlFailedSMS.SuspendLayout()

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

        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblDateTime)

        Me.pnlHeader.Location =
            New System.Drawing.Point(15, 15)

        Me.pnlHeader.Name =
            "pnlHeader"

        Me.pnlHeader.Size =
            New System.Drawing.Size(1430, 75)

        Me.pnlHeader.TabIndex =
            0


        '==================================================
        ' lblTitle
        '==================================================
        Me.lblTitle.AutoSize =
            True

        Me.lblTitle.Font =
            New System.Drawing.Font(
                "Georgia",
                23.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTitle.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblTitle.Location =
            New System.Drawing.Point(20, 6)

        Me.lblTitle.Name =
            "lblTitle"

        Me.lblTitle.Size =
            New System.Drawing.Size(220, 44)

        Me.lblTitle.TabIndex =
            0

        Me.lblTitle.Text =
            "Dashboard"


        '==================================================
        ' lblSubtitle
        '==================================================
        Me.lblSubtitle.AutoSize =
            True

        Me.lblSubtitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblSubtitle.ForeColor =
            System.Drawing.Color.FromArgb(117, 87, 71)

        Me.lblSubtitle.Location =
            New System.Drawing.Point(23, 48)

        Me.lblSubtitle.Name =
            "lblSubtitle"

        Me.lblSubtitle.Size =
            New System.Drawing.Size(360, 20)

        Me.lblSubtitle.TabIndex =
            1

        Me.lblSubtitle.Text =
            "Overview of student entry/exit monitoring system"


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
            New System.Drawing.Point(845, 24)

        Me.lblDateTime.Name =
            "lblDateTime"

        Me.lblDateTime.Size =
            New System.Drawing.Size(550, 25)

        Me.lblDateTime.TabIndex =
            2

        Me.lblDateTime.Text =
            "Friday, October 23, 2026   |   08:00:00 PM"

        Me.lblDateTime.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' tlpStats
        '==================================================
        Me.tlpStats.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.tlpStats.ColumnCount =
            4

        Me.tlpStats.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                25.0!
            )
        )

        Me.tlpStats.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                25.0!
            )
        )

        Me.tlpStats.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                25.0!
            )
        )

        Me.tlpStats.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                25.0!
            )
        )

        Me.tlpStats.Controls.Add(
            Me.pnlTotalStudents,
            0,
            0
        )

        Me.tlpStats.Controls.Add(
            Me.pnlQRGenerated,
            1,
            0
        )

        Me.tlpStats.Controls.Add(
            Me.pnlTodayEntry,
            2,
            0
        )

        Me.tlpStats.Controls.Add(
            Me.pnlTodayExit,
            3,
            0
        )

        Me.tlpStats.Location =
            New System.Drawing.Point(15, 100)

        Me.tlpStats.Margin =
            New System.Windows.Forms.Padding(0)

        Me.tlpStats.Name =
            "tlpStats"

        Me.tlpStats.RowCount =
            1

        Me.tlpStats.RowStyles.Add(
            New System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Percent,
                100.0!
            )
        )

        Me.tlpStats.Size =
            New System.Drawing.Size(1430, 110)

        Me.tlpStats.TabIndex =
            1


        '==================================================
        ' pnlTotalStudents
        '==================================================
        Me.pnlTotalStudents.BackColor =
            System.Drawing.Color.FromArgb(245, 234, 223)

        Me.pnlTotalStudents.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlTotalStudents.Controls.Add(Me.lblTotalStudentsTitle)
        Me.pnlTotalStudents.Controls.Add(Me.lblTotalStudents)

        Me.pnlTotalStudents.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlTotalStudents.Margin =
            New System.Windows.Forms.Padding(0, 0, 8, 0)

        Me.pnlTotalStudents.Name =
            "pnlTotalStudents"

        Me.pnlTotalStudents.TabIndex =
            0


        Me.lblTotalStudentsTitle.AutoSize =
            True

        Me.lblTotalStudentsTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTotalStudentsTitle.ForeColor =
            System.Drawing.Color.FromArgb(75, 54, 43)

        Me.lblTotalStudentsTitle.Location =
            New System.Drawing.Point(18, 15)

        Me.lblTotalStudentsTitle.Text =
            "Total Students"


        Me.lblTotalStudents.Font =
            New System.Drawing.Font(
                "Segoe UI",
                26.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTotalStudents.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblTotalStudents.Location =
            New System.Drawing.Point(17, 40)

        Me.lblTotalStudents.Name =
            "lblTotalStudents"

        Me.lblTotalStudents.Size =
            New System.Drawing.Size(220, 52)

        Me.lblTotalStudents.Text =
            "0"


        '==================================================
        ' pnlQRGenerated
        '==================================================
        Me.pnlQRGenerated.BackColor =
            System.Drawing.Color.FromArgb(226, 242, 230)

        Me.pnlQRGenerated.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlQRGenerated.Controls.Add(Me.lblQRGeneratedTitle)
        Me.pnlQRGenerated.Controls.Add(Me.lblQRGenerated)

        Me.pnlQRGenerated.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlQRGenerated.Margin =
            New System.Windows.Forms.Padding(4, 0, 4, 0)

        Me.pnlQRGenerated.Name =
            "pnlQRGenerated"


        Me.lblQRGeneratedTitle.AutoSize =
            True

        Me.lblQRGeneratedTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQRGeneratedTitle.ForeColor =
            System.Drawing.Color.FromArgb(50, 90, 60)

        Me.lblQRGeneratedTitle.Location =
            New System.Drawing.Point(18, 15)

        Me.lblQRGeneratedTitle.Text =
            "QR Generated"


        Me.lblQRGenerated.Font =
            New System.Drawing.Font(
                "Segoe UI",
                26.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQRGenerated.ForeColor =
            System.Drawing.Color.FromArgb(40, 100, 60)

        Me.lblQRGenerated.Location =
            New System.Drawing.Point(17, 40)

        Me.lblQRGenerated.Name =
            "lblQRGenerated"

        Me.lblQRGenerated.Size =
            New System.Drawing.Size(220, 52)

        Me.lblQRGenerated.Text =
            "0"


        '==================================================
        ' pnlTodayEntry
        '==================================================
        Me.pnlTodayEntry.BackColor =
            System.Drawing.Color.FromArgb(232, 238, 248)

        Me.pnlTodayEntry.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlTodayEntry.Controls.Add(Me.lblTodayEntryTitle)
        Me.pnlTodayEntry.Controls.Add(Me.lblTodayEntry)

        Me.pnlTodayEntry.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlTodayEntry.Margin =
            New System.Windows.Forms.Padding(4, 0, 4, 0)


        Me.lblTodayEntryTitle.AutoSize =
            True

        Me.lblTodayEntryTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTodayEntryTitle.ForeColor =
            System.Drawing.Color.FromArgb(50, 70, 100)

        Me.lblTodayEntryTitle.Location =
            New System.Drawing.Point(18, 15)

        Me.lblTodayEntryTitle.Text =
            "Today's Entry"


        Me.lblTodayEntry.Font =
            New System.Drawing.Font(
                "Segoe UI",
                26.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTodayEntry.ForeColor =
            System.Drawing.Color.FromArgb(50, 70, 100)

        Me.lblTodayEntry.Location =
            New System.Drawing.Point(17, 40)

        Me.lblTodayEntry.Name =
            "lblTodayEntry"

        Me.lblTodayEntry.Size =
            New System.Drawing.Size(220, 52)

        Me.lblTodayEntry.Text =
            "0"


        '==================================================
        ' pnlTodayExit
        '==================================================
        Me.pnlTodayExit.BackColor =
            System.Drawing.Color.FromArgb(248, 224, 220)

        Me.pnlTodayExit.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlTodayExit.Controls.Add(Me.lblTodayExitTitle)
        Me.pnlTodayExit.Controls.Add(Me.lblTodayExit)

        Me.pnlTodayExit.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlTodayExit.Margin =
            New System.Windows.Forms.Padding(8, 0, 0, 0)


        Me.lblTodayExitTitle.AutoSize =
            True

        Me.lblTodayExitTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTodayExitTitle.ForeColor =
            System.Drawing.Color.FromArgb(150, 55, 55)

        Me.lblTodayExitTitle.Location =
            New System.Drawing.Point(18, 15)

        Me.lblTodayExitTitle.Text =
            "Today's Exit"


        Me.lblTodayExit.Font =
            New System.Drawing.Font(
                "Segoe UI",
                26.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTodayExit.ForeColor =
            System.Drawing.Color.FromArgb(170, 45, 45)

        Me.lblTodayExit.Location =
            New System.Drawing.Point(17, 40)

        Me.lblTodayExit.Name =
            "lblTodayExit"

        Me.lblTodayExit.Size =
            New System.Drawing.Size(220, 52)

        Me.lblTodayExit.Text =
            "0"


        '==================================================
        ' tlpMiddle
        '==================================================
        Me.tlpMiddle.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.tlpMiddle.ColumnCount =
            2

        Me.tlpMiddle.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                62.0!
            )
        )

        Me.tlpMiddle.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                38.0!
            )
        )

        Me.tlpMiddle.Controls.Add(
            Me.pnlRecentEntryExit,
            0,
            0
        )

        Me.tlpMiddle.Controls.Add(
            Me.pnlRecentSMS,
            1,
            0
        )

        Me.tlpMiddle.Location =
            New System.Drawing.Point(15, 220)

        Me.tlpMiddle.Margin =
            New System.Windows.Forms.Padding(0)

        Me.tlpMiddle.Name =
            "tlpMiddle"

        Me.tlpMiddle.RowCount =
            1

        Me.tlpMiddle.RowStyles.Add(
            New System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Percent,
                100.0!
            )
        )

        Me.tlpMiddle.Size =
            New System.Drawing.Size(1430, 390)

        Me.tlpMiddle.TabIndex =
            2


        '==================================================
        ' ENTRY EXIT PANEL
        '==================================================
        Me.pnlRecentEntryExit.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlRecentEntryExit.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlRecentEntryExit.Controls.Add(Me.dgvRecentEntryExit)
        Me.pnlRecentEntryExit.Controls.Add(Me.pnlRecentEntryExitHeader)

        Me.pnlRecentEntryExit.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlRecentEntryExit.Margin =
            New System.Windows.Forms.Padding(0, 0, 5, 0)


        Me.pnlRecentEntryExitHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlRecentEntryExitHeader.Controls.Add(
            Me.lblRecentEntryExitTitle
        )

        Me.pnlRecentEntryExitHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlRecentEntryExitHeader.Height =
            38


        Me.lblRecentEntryExitTitle.AutoSize =
            True

        Me.lblRecentEntryExitTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblRecentEntryExitTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblRecentEntryExitTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblRecentEntryExitTitle.Text =
            "Recent Entry / Exit Records"


        '==================================================
        ' dgvRecentEntryExit
        '==================================================
        Me.dgvRecentEntryExit.AllowUserToAddRows =
            False

        Me.dgvRecentEntryExit.AllowUserToDeleteRows =
            False

        Me.dgvRecentEntryExit.AllowUserToResizeRows =
            False

        Me.dgvRecentEntryExit.AutoGenerateColumns =
            False

        Me.dgvRecentEntryExit.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvRecentEntryExit.BackgroundColor =
            System.Drawing.Color.White

        Me.dgvRecentEntryExit.BorderStyle =
            System.Windows.Forms.BorderStyle.None

        Me.dgvRecentEntryExit.CellBorderStyle =
            System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        Me.dgvRecentEntryExit.ColumnHeadersHeight =
            40

        Me.dgvRecentEntryExit.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.dgvRecentEntryExit.Columns.AddRange(
            New System.Windows.Forms.DataGridViewColumn() {
                Me.colEntryStudentID,
                Me.colEntryStudentName,
                Me.colEntryYearCourse,
                Me.colEntryTimeIn,
                Me.colEntryTimeOut
            }
        )

        Me.dgvRecentEntryExit.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.dgvRecentEntryExit.EnableHeadersVisualStyles =
            False

        Me.dgvRecentEntryExit.GridColor =
            System.Drawing.Color.FromArgb(225, 211, 201)

        Me.dgvRecentEntryExit.MultiSelect =
            False

        Me.dgvRecentEntryExit.ReadOnly =
            True

        Me.dgvRecentEntryExit.RowHeadersVisible =
            False

        Me.dgvRecentEntryExit.RowTemplate.Height =
            35

        Me.dgvRecentEntryExit.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect


        Me.dgvRecentEntryExit.ColumnHeadersDefaultCellStyle.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.dgvRecentEntryExit.ColumnHeadersDefaultCellStyle.ForeColor =
            System.Drawing.Color.White

        Me.dgvRecentEntryExit.ColumnHeadersDefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.dgvRecentEntryExit.ColumnHeadersDefaultCellStyle.Alignment =
            System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter


        Me.dgvRecentEntryExit.DefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.5!
            )

        Me.dgvRecentEntryExit.DefaultCellStyle.SelectionBackColor =
            System.Drawing.Color.FromArgb(233, 216, 202)

        Me.dgvRecentEntryExit.DefaultCellStyle.SelectionForeColor =
            System.Drawing.Color.FromArgb(52, 32, 23)


        '==================================================
        ' ENTRY EXIT COLUMNS
        '==================================================
        Me.colEntryStudentID.DataPropertyName =
            "student_id"

        Me.colEntryStudentID.FillWeight =
            60.0!

        Me.colEntryStudentID.HeaderText =
            "Student ID"

        Me.colEntryStudentID.Name =
            "colEntryStudentID"


        Me.colEntryStudentName.DataPropertyName =
            "student_name"

        Me.colEntryStudentName.FillWeight =
            120.0!

        Me.colEntryStudentName.HeaderText =
            "Student Name"

        Me.colEntryStudentName.Name =
            "colEntryStudentName"


        Me.colEntryYearCourse.DataPropertyName =
            "year_course"

        Me.colEntryYearCourse.FillWeight =
            90.0!

        Me.colEntryYearCourse.HeaderText =
            "Year / Course"

        Me.colEntryYearCourse.Name =
            "colEntryYearCourse"


        Me.colEntryTimeIn.DataPropertyName =
            "time_in"

        Me.colEntryTimeIn.FillWeight =
            70.0!

        Me.colEntryTimeIn.HeaderText =
            "Time In"

        Me.colEntryTimeIn.Name =
            "colEntryTimeIn"


        Me.colEntryTimeOut.DataPropertyName =
            "time_out"

        Me.colEntryTimeOut.FillWeight =
            70.0!

        Me.colEntryTimeOut.HeaderText =
            "Time Out"

        Me.colEntryTimeOut.Name =
            "colEntryTimeOut"


        '==================================================
        ' SMS PANEL
        '==================================================
        Me.pnlRecentSMS.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlRecentSMS.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlRecentSMS.Controls.Add(Me.dgvRecentSMS)
        Me.pnlRecentSMS.Controls.Add(Me.pnlRecentSMSHeader)

        Me.pnlRecentSMS.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlRecentSMS.Margin =
            New System.Windows.Forms.Padding(5, 0, 0, 0)


        Me.pnlRecentSMSHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlRecentSMSHeader.Controls.Add(
            Me.lblRecentSMSTitle
        )

        Me.pnlRecentSMSHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlRecentSMSHeader.Height =
            38


        Me.lblRecentSMSTitle.AutoSize =
            True

        Me.lblRecentSMSTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblRecentSMSTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblRecentSMSTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblRecentSMSTitle.Text =
            "Recent SMS Notifications"


        '==================================================
        ' dgvRecentSMS
        '==================================================
        Me.dgvRecentSMS.AllowUserToAddRows =
            False

        Me.dgvRecentSMS.AllowUserToDeleteRows =
            False

        Me.dgvRecentSMS.AllowUserToResizeRows =
            False

        Me.dgvRecentSMS.AutoGenerateColumns =
            False

        Me.dgvRecentSMS.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvRecentSMS.BackgroundColor =
            System.Drawing.Color.White

        Me.dgvRecentSMS.BorderStyle =
            System.Windows.Forms.BorderStyle.None

        Me.dgvRecentSMS.CellBorderStyle =
            System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        Me.dgvRecentSMS.ColumnHeadersHeight =
            40

        Me.dgvRecentSMS.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.dgvRecentSMS.Columns.AddRange(
            New System.Windows.Forms.DataGridViewColumn() {
                Me.colSMSStudent,
                Me.colSMSType,
                Me.colSMSSentAt,
                Me.colSMSStatus
            }
        )

        Me.dgvRecentSMS.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.dgvRecentSMS.EnableHeadersVisualStyles =
            False

        Me.dgvRecentSMS.GridColor =
            System.Drawing.Color.FromArgb(225, 211, 201)

        Me.dgvRecentSMS.MultiSelect =
            False

        Me.dgvRecentSMS.ReadOnly =
            True

        Me.dgvRecentSMS.RowHeadersVisible =
            False

        Me.dgvRecentSMS.RowTemplate.Height =
            35

        Me.dgvRecentSMS.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect


        Me.dgvRecentSMS.ColumnHeadersDefaultCellStyle.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.dgvRecentSMS.ColumnHeadersDefaultCellStyle.ForeColor =
            System.Drawing.Color.White

        Me.dgvRecentSMS.ColumnHeadersDefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.dgvRecentSMS.ColumnHeadersDefaultCellStyle.Alignment =
            System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter


        Me.dgvRecentSMS.DefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.0!
            )

        Me.dgvRecentSMS.DefaultCellStyle.SelectionBackColor =
            System.Drawing.Color.FromArgb(233, 216, 202)

        Me.dgvRecentSMS.DefaultCellStyle.SelectionForeColor =
            System.Drawing.Color.FromArgb(52, 32, 23)


        '==================================================
        ' SMS COLUMNS
        '==================================================
        Me.colSMSStudent.DataPropertyName =
            "student_name"

        Me.colSMSStudent.FillWeight =
            100.0!

        Me.colSMSStudent.HeaderText =
            "Student"

        Me.colSMSStudent.Name =
            "colSMSStudent"


        Me.colSMSType.DataPropertyName =
            "sms_type"

        Me.colSMSType.FillWeight =
            55.0!

        Me.colSMSType.HeaderText =
            "Type"

        Me.colSMSType.Name =
            "colSMSType"


        Me.colSMSSentAt.DataPropertyName =
            "sent_at"

        Me.colSMSSentAt.FillWeight =
            90.0!

        Me.colSMSSentAt.HeaderText =
            "Date / Time"

        Me.colSMSSentAt.Name =
            "colSMSSentAt"


        Me.colSMSStatus.DataPropertyName =
            "status"

        Me.colSMSStatus.FillWeight =
            55.0!

        Me.colSMSStatus.HeaderText =
            "Status"

        Me.colSMSStatus.Name =
            "colSMSStatus"


        '==================================================
        ' QUICK OVERVIEW
        '==================================================
        Me.pnlQuickOverview.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlQuickOverview.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlQuickOverview.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlQuickOverview.Controls.Add(Me.lblQuickOverviewTitle)
        Me.pnlQuickOverview.Controls.Add(Me.tlpQuickOverview)

        Me.pnlQuickOverview.Location =
            New System.Drawing.Point(15, 620)

        Me.pnlQuickOverview.Name =
            "pnlQuickOverview"

        Me.pnlQuickOverview.Size =
            New System.Drawing.Size(1430, 145)


        Me.lblQuickOverviewTitle.AutoSize =
            True

        Me.lblQuickOverviewTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQuickOverviewTitle.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblQuickOverviewTitle.Location =
            New System.Drawing.Point(15, 8)

        Me.lblQuickOverviewTitle.Text =
            "Quick Overview"


        '==================================================
        ' tlpQuickOverview
        '==================================================
        Me.tlpQuickOverview.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.tlpQuickOverview.ColumnCount =
            3

        Me.tlpQuickOverview.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                33.33333!
            )
        )

        Me.tlpQuickOverview.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                33.33333!
            )
        )

        Me.tlpQuickOverview.ColumnStyles.Add(
            New System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent,
                33.33334!
            )
        )

        Me.tlpQuickOverview.Controls.Add(
            Me.pnlQRNotGenerated,
            0,
            0
        )

        Me.tlpQuickOverview.Controls.Add(
            Me.pnlNoExitToday,
            1,
            0
        )

        Me.tlpQuickOverview.Controls.Add(
            Me.pnlFailedSMS,
            2,
            0
        )

        Me.tlpQuickOverview.Location =
            New System.Drawing.Point(15, 40)

        Me.tlpQuickOverview.Name =
            "tlpQuickOverview"

        Me.tlpQuickOverview.RowCount =
            1

        Me.tlpQuickOverview.RowStyles.Add(
            New System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Percent,
                100.0!
            )
        )

        Me.tlpQuickOverview.Size =
            New System.Drawing.Size(1398, 85)


        '==================================================
        ' QR NOT GENERATED
        '==================================================
        Me.pnlQRNotGenerated.BackColor =
            System.Drawing.Color.FromArgb(245, 234, 223)

        Me.pnlQRNotGenerated.Controls.Add(Me.lblQRNotGeneratedTitle)
        Me.pnlQRNotGenerated.Controls.Add(Me.lblQRNotGenerated)

        Me.pnlQRNotGenerated.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlQRNotGenerated.Margin =
            New System.Windows.Forms.Padding(0, 0, 7, 0)


        Me.lblQRNotGeneratedTitle.AutoSize =
            True

        Me.lblQRNotGeneratedTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.5!
            )

        Me.lblQRNotGeneratedTitle.Location =
            New System.Drawing.Point(18, 25)

        Me.lblQRNotGeneratedTitle.Text =
            "QR Not Generated"


        Me.lblQRNotGenerated.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblQRNotGenerated.Font =
            New System.Drawing.Font(
                "Segoe UI",
                18.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQRNotGenerated.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblQRNotGenerated.Location =
            New System.Drawing.Point(365, 17)

        Me.lblQRNotGenerated.Name =
            "lblQRNotGenerated"

        Me.lblQRNotGenerated.Size =
            New System.Drawing.Size(70, 45)

        Me.lblQRNotGenerated.Text =
            "0"

        Me.lblQRNotGenerated.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' NO EXIT TODAY
        '==================================================
        Me.pnlNoExitToday.BackColor =
            System.Drawing.Color.FromArgb(248, 224, 220)

        Me.pnlNoExitToday.Controls.Add(Me.lblNoExitTodayTitle)
        Me.pnlNoExitToday.Controls.Add(Me.lblNoExitToday)

        Me.pnlNoExitToday.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlNoExitToday.Margin =
            New System.Windows.Forms.Padding(4, 0, 4, 0)


        Me.lblNoExitTodayTitle.AutoSize =
            True

        Me.lblNoExitTodayTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.5!
            )

        Me.lblNoExitTodayTitle.Location =
            New System.Drawing.Point(18, 25)

        Me.lblNoExitTodayTitle.Text =
            "No Exit Record Today"


        Me.lblNoExitToday.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblNoExitToday.Font =
            New System.Drawing.Font(
                "Segoe UI",
                18.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblNoExitToday.ForeColor =
            System.Drawing.Color.FromArgb(170, 45, 45)

        Me.lblNoExitToday.Location =
            New System.Drawing.Point(365, 17)

        Me.lblNoExitToday.Name =
            "lblNoExitToday"

        Me.lblNoExitToday.Size =
            New System.Drawing.Size(70, 45)

        Me.lblNoExitToday.Text =
            "0"

        Me.lblNoExitToday.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' FAILED SMS
        '==================================================
        Me.pnlFailedSMS.BackColor =
            System.Drawing.Color.FromArgb(248, 224, 220)

        Me.pnlFailedSMS.Controls.Add(Me.lblFailedSMSTitle)
        Me.pnlFailedSMS.Controls.Add(Me.lblFailedSMS)

        Me.pnlFailedSMS.Dock =
            System.Windows.Forms.DockStyle.Fill

        Me.pnlFailedSMS.Margin =
            New System.Windows.Forms.Padding(7, 0, 0, 0)


        Me.lblFailedSMSTitle.AutoSize =
            True

        Me.lblFailedSMSTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.5!
            )

        Me.lblFailedSMSTitle.Location =
            New System.Drawing.Point(18, 25)

        Me.lblFailedSMSTitle.Text =
            "Failed SMS"


        Me.lblFailedSMS.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblFailedSMS.Font =
            New System.Drawing.Font(
                "Segoe UI",
                18.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblFailedSMS.ForeColor =
            System.Drawing.Color.FromArgb(170, 45, 45)

        Me.lblFailedSMS.Location =
            New System.Drawing.Point(365, 17)

        Me.lblFailedSMS.Name =
            "lblFailedSMS"

        Me.lblFailedSMS.Size =
            New System.Drawing.Size(70, 45)

        Me.lblFailedSMS.Text =
            "0"

        Me.lblFailedSMS.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' TIMER
        '==================================================
        Me.timerClock.Enabled =
            True

        Me.timerClock.Interval =
            1000


        '==================================================
        ' UcDashboard
        '==================================================
        Me.AutoScaleDimensions =
            New System.Drawing.SizeF(8.0!, 20.0!)

        Me.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font

        Me.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.Controls.Add(Me.pnlQuickOverview)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Controls.Add(Me.tlpStats)
        Me.Controls.Add(Me.pnlHeader)

        Me.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.Name =
            "UcDashboard"

        Me.Size =
            New System.Drawing.Size(1460, 780)


        '==================================================
        ' RESUME
        '==================================================
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()

        Me.pnlTotalStudents.ResumeLayout(False)
        Me.pnlTotalStudents.PerformLayout()

        Me.pnlQRGenerated.ResumeLayout(False)
        Me.pnlQRGenerated.PerformLayout()

        Me.pnlTodayEntry.ResumeLayout(False)
        Me.pnlTodayEntry.PerformLayout()

        Me.pnlTodayExit.ResumeLayout(False)
        Me.pnlTodayExit.PerformLayout()

        Me.tlpStats.ResumeLayout(False)

        Me.pnlRecentEntryExitHeader.ResumeLayout(False)
        Me.pnlRecentEntryExitHeader.PerformLayout()

        CType(
            Me.dgvRecentEntryExit,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlRecentEntryExit.ResumeLayout(False)

        Me.pnlRecentSMSHeader.ResumeLayout(False)
        Me.pnlRecentSMSHeader.PerformLayout()

        CType(
            Me.dgvRecentSMS,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlRecentSMS.ResumeLayout(False)

        Me.tlpMiddle.ResumeLayout(False)

        Me.pnlQRNotGenerated.ResumeLayout(False)
        Me.pnlQRNotGenerated.PerformLayout()

        Me.pnlNoExitToday.ResumeLayout(False)
        Me.pnlNoExitToday.PerformLayout()

        Me.pnlFailedSMS.ResumeLayout(False)
        Me.pnlFailedSMS.PerformLayout()

        Me.tlpQuickOverview.ResumeLayout(False)

        Me.pnlQuickOverview.ResumeLayout(False)
        Me.pnlQuickOverview.PerformLayout()

        Me.ResumeLayout(False)

    End Sub


    '==================================================
    ' DECLARATIONS
    '==================================================

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label

    Friend WithEvents tlpStats As TableLayoutPanel

    Friend WithEvents pnlTotalStudents As Panel
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents lblTotalStudents As Label

    Friend WithEvents pnlQRGenerated As Panel
    Friend WithEvents lblQRGeneratedTitle As Label
    Friend WithEvents lblQRGenerated As Label

    Friend WithEvents pnlTodayEntry As Panel
    Friend WithEvents lblTodayEntryTitle As Label
    Friend WithEvents lblTodayEntry As Label

    Friend WithEvents pnlTodayExit As Panel
    Friend WithEvents lblTodayExitTitle As Label
    Friend WithEvents lblTodayExit As Label

    Friend WithEvents tlpMiddle As TableLayoutPanel

    Friend WithEvents pnlRecentEntryExit As Panel
    Friend WithEvents pnlRecentEntryExitHeader As Panel
    Friend WithEvents lblRecentEntryExitTitle As Label

    Friend WithEvents dgvRecentEntryExit As DataGridView

    Friend WithEvents colEntryStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colEntryStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colEntryYearCourse As DataGridViewTextBoxColumn
    Friend WithEvents colEntryTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colEntryTimeOut As DataGridViewTextBoxColumn

    Friend WithEvents pnlRecentSMS As Panel
    Friend WithEvents pnlRecentSMSHeader As Panel
    Friend WithEvents lblRecentSMSTitle As Label

    Friend WithEvents dgvRecentSMS As DataGridView

    Friend WithEvents colSMSStudent As DataGridViewTextBoxColumn
    Friend WithEvents colSMSType As DataGridViewTextBoxColumn
    Friend WithEvents colSMSSentAt As DataGridViewTextBoxColumn
    Friend WithEvents colSMSStatus As DataGridViewTextBoxColumn

    Friend WithEvents pnlQuickOverview As Panel
    Friend WithEvents lblQuickOverviewTitle As Label

    Friend WithEvents tlpQuickOverview As TableLayoutPanel

    Friend WithEvents pnlQRNotGenerated As Panel
    Friend WithEvents lblQRNotGeneratedTitle As Label
    Friend WithEvents lblQRNotGenerated As Label

    Friend WithEvents pnlNoExitToday As Panel
    Friend WithEvents lblNoExitTodayTitle As Label
    Friend WithEvents lblNoExitToday As Label

    Friend WithEvents pnlFailedSMS As Panel
    Friend WithEvents lblFailedSMSTitle As Label
    Friend WithEvents lblFailedSMS As Label

    Friend WithEvents timerClock As Timer

End Class