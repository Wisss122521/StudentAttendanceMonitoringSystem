<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcGenerateReport

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
        '==================================================
        ' TIMER
        '==================================================
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.timerClock = New System.Windows.Forms.Timer()

        '==================================================
        ' HEADER
        '==================================================
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()

        '==================================================
        ' FILTER PANEL
        '==================================================
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.pnlFiltersHeader = New System.Windows.Forms.Panel()
        Me.lblFiltersTitle = New System.Windows.Forms.Label()

        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()

        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()

        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()

        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()

        Me.btnApplyFilter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()

        '==================================================
        ' RECORDS PANEL
        '==================================================
        Me.pnlRecords = New System.Windows.Forms.Panel()
        Me.pnlRecordsHeader = New System.Windows.Forms.Panel()
        Me.lblRecordsTitle = New System.Windows.Forms.Label()

        Me.dgvAttendance = New System.Windows.Forms.DataGridView()

        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()

        '==================================================
        ' SUMMARY
        '==================================================
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblSummaryTitle = New System.Windows.Forms.Label()

        Me.pnlTotalRecords = New System.Windows.Forms.Panel()
        Me.lblTotalRecordsTitle = New System.Windows.Forms.Label()
        Me.lblTotalRecords = New System.Windows.Forms.Label()

        Me.pnlComplete = New System.Windows.Forms.Panel()
        Me.lblCompleteTitle = New System.Windows.Forms.Label()
        Me.lblComplete = New System.Windows.Forms.Label()

        Me.pnlNoTimeOut = New System.Windows.Forms.Panel()
        Me.lblNoTimeOutTitle = New System.Windows.Forms.Label()
        Me.lblNoTimeOut = New System.Windows.Forms.Label()

        Me.btnGenerateExcel = New System.Windows.Forms.Button()
        Me.btnGeneratePDF = New System.Windows.Forms.Button()


        '==================================================
        ' SUSPEND
        '==================================================
        Me.pnlHeader.SuspendLayout()

        Me.pnlFilters.SuspendLayout()
        Me.pnlFiltersHeader.SuspendLayout()

        Me.pnlRecords.SuspendLayout()
        Me.pnlRecordsHeader.SuspendLayout()

        CType(
            Me.dgvAttendance,
            System.ComponentModel.ISupportInitialize
        ).BeginInit()

        Me.pnlSummary.SuspendLayout()
        Me.pnlTotalRecords.SuspendLayout()
        Me.pnlComplete.SuspendLayout()
        Me.pnlNoTimeOut.SuspendLayout()

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

        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)

        Me.pnlHeader.Location =
            New System.Drawing.Point(15, 15)

        Me.pnlHeader.Name =
            "pnlHeader"

        Me.pnlHeader.Size =
            New System.Drawing.Size(1430, 75)

        Me.pnlHeader.TabIndex =
            0

        Me.pnlHeader.Controls.Add(Me.lblDateTime)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)

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
            New System.Drawing.Point(20, 8)

        Me.lblTitle.Name =
            "lblTitle"

        Me.lblTitle.Size =
            New System.Drawing.Size(390, 44)

        Me.lblTitle.TabIndex =
            0

        Me.lblTitle.Text =
            "Student Entry/Exit Reports"


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
            New System.Drawing.Point(23, 49)

        Me.lblSubtitle.Name =
            "lblSubtitle"

        Me.lblSubtitle.Size =
            New System.Drawing.Size(345, 20)

        Me.lblSubtitle.TabIndex =
            1

        Me.lblSubtitle.Text =
            "View, filter and generate student entry/exit reports"


        '==================================================
        ' pnlFilters
        '==================================================
        Me.pnlFilters.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlFilters.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlFilters.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlFilters.Controls.Add(Me.btnReset)
        Me.pnlFilters.Controls.Add(Me.btnApplyFilter)

        Me.pnlFilters.Controls.Add(Me.cboCourse)
        Me.pnlFilters.Controls.Add(Me.lblCourse)

        Me.pnlFilters.Controls.Add(Me.dtpTo)
        Me.pnlFilters.Controls.Add(Me.lblDateTo)

        Me.pnlFilters.Controls.Add(Me.dtpFrom)
        Me.pnlFilters.Controls.Add(Me.lblDateFrom)

        Me.pnlFilters.Controls.Add(Me.txtSearch)
        Me.pnlFilters.Controls.Add(Me.lblSearch)

        Me.pnlFilters.Controls.Add(Me.pnlFiltersHeader)

        Me.pnlFilters.Location =
            New System.Drawing.Point(15, 100)

        Me.pnlFilters.Name =
            "pnlFilters"

        Me.pnlFilters.Size =
            New System.Drawing.Size(1430, 125)

        Me.pnlFilters.TabIndex =
            1


        '==================================================
        ' pnlFiltersHeader
        '==================================================
        Me.pnlFiltersHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlFiltersHeader.Controls.Add(
            Me.lblFiltersTitle
        )

        Me.pnlFiltersHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlFiltersHeader.Location =
            New System.Drawing.Point(0, 0)

        Me.pnlFiltersHeader.Name =
            "pnlFiltersHeader"

        Me.pnlFiltersHeader.Size =
            New System.Drawing.Size(1428, 38)

        Me.pnlFiltersHeader.TabIndex =
            0


        '==================================================
        ' lblFiltersTitle
        '==================================================
        Me.lblFiltersTitle.AutoSize =
            True

        Me.lblFiltersTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                11.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblFiltersTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblFiltersTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblFiltersTitle.Name =
            "lblFiltersTitle"

        Me.lblFiltersTitle.Size =
            New System.Drawing.Size(128, 25)

        Me.lblFiltersTitle.TabIndex =
            0

        Me.lblFiltersTitle.Text =
            "Report Filters"


        '==================================================
        ' lblSearch
        '==================================================
        Me.lblSearch.AutoSize =
            True

        Me.lblSearch.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSearch.Location =
            New System.Drawing.Point(18, 51)

        Me.lblSearch.Name =
            "lblSearch"

        Me.lblSearch.Size =
            New System.Drawing.Size(107, 20)

        Me.lblSearch.TabIndex =
            1

        Me.lblSearch.Text =
            "Search Student"


        '==================================================
        ' txtSearch
        '==================================================
        Me.txtSearch.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.txtSearch.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.txtSearch.Location =
            New System.Drawing.Point(20, 75)

        Me.txtSearch.Name =
            "txtSearch"

        Me.txtSearch.Size =
            New System.Drawing.Size(300, 27)

        Me.txtSearch.TabIndex =
            2


        '==================================================
        ' lblDateFrom
        '==================================================
        Me.lblDateFrom.AutoSize =
            True

        Me.lblDateFrom.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblDateFrom.Location =
            New System.Drawing.Point(350, 51)

        Me.lblDateFrom.Name =
            "lblDateFrom"

        Me.lblDateFrom.Size =
            New System.Drawing.Size(78, 20)

        Me.lblDateFrom.TabIndex =
            3

        Me.lblDateFrom.Text =
            "Date From"


        '==================================================
        ' dtpFrom
        '==================================================
        Me.dtpFrom.CustomFormat =
            "MMMM dd, yyyy"

        Me.dtpFrom.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.dtpFrom.Format =
            System.Windows.Forms.DateTimePickerFormat.Custom

        Me.dtpFrom.Location =
            New System.Drawing.Point(350, 75)

        Me.dtpFrom.Name =
            "dtpFrom"

        Me.dtpFrom.Size =
            New System.Drawing.Size(220, 27)

        Me.dtpFrom.TabIndex =
            4


        '==================================================
        ' lblDateTo
        '==================================================
        Me.lblDateTo.AutoSize =
            True

        Me.lblDateTo.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblDateTo.Location =
            New System.Drawing.Point(600, 51)

        Me.lblDateTo.Name =
            "lblDateTo"

        Me.lblDateTo.Size =
            New System.Drawing.Size(58, 20)

        Me.lblDateTo.TabIndex =
            5

        Me.lblDateTo.Text =
            "Date To"


        '==================================================
        ' dtpTo
        '==================================================
        Me.dtpTo.CustomFormat =
            "MMMM dd, yyyy"

        Me.dtpTo.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.dtpTo.Format =
            System.Windows.Forms.DateTimePickerFormat.Custom

        Me.dtpTo.Location =
            New System.Drawing.Point(600, 75)

        Me.dtpTo.Name =
            "dtpTo"

        Me.dtpTo.Size =
            New System.Drawing.Size(220, 27)

        Me.dtpTo.TabIndex =
            6


        '==================================================
        ' lblCourse
        '==================================================
        Me.lblCourse.AutoSize =
            True

        Me.lblCourse.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblCourse.Location =
            New System.Drawing.Point(850, 51)

        Me.lblCourse.Name =
            "lblCourse"

        Me.lblCourse.Size =
            New System.Drawing.Size(53, 20)

        Me.lblCourse.TabIndex =
            7

        Me.lblCourse.Text =
            "Course"


        '==================================================
        ' cboCourse
        '==================================================
        Me.cboCourse.DropDownStyle =
            System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.cboCourse.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.cboCourse.FormattingEnabled =
            True

        Me.cboCourse.Location =
            New System.Drawing.Point(850, 75)

        Me.cboCourse.Name =
            "cboCourse"

        Me.cboCourse.Size =
            New System.Drawing.Size(180, 28)

        Me.cboCourse.TabIndex =
            8


        '==================================================
        ' btnApplyFilter
        '==================================================
        Me.btnApplyFilter.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.btnApplyFilter.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnApplyFilter.FlatAppearance.BorderSize =
            0

        Me.btnApplyFilter.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnApplyFilter.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnApplyFilter.ForeColor =
            System.Drawing.Color.White

        Me.btnApplyFilter.Location =
            New System.Drawing.Point(1065, 66)

        Me.btnApplyFilter.Name =
            "btnApplyFilter"

        Me.btnApplyFilter.Size =
            New System.Drawing.Size(150, 38)

        Me.btnApplyFilter.TabIndex =
            9

        Me.btnApplyFilter.Text =
            "Apply Filter"

        Me.btnApplyFilter.UseVisualStyleBackColor =
            False


        '==================================================
        ' btnReset
        '==================================================
        Me.btnReset.BackColor =
            System.Drawing.Color.FromArgb(242, 230, 220)

        Me.btnReset.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnReset.FlatAppearance.BorderColor =
            System.Drawing.Color.FromArgb(205, 183, 167)

        Me.btnReset.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnReset.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnReset.ForeColor =
            System.Drawing.Color.FromArgb(75, 41, 24)

        Me.btnReset.Location =
            New System.Drawing.Point(1225, 66)

        Me.btnReset.Name =
            "btnReset"

        Me.btnReset.Size =
            New System.Drawing.Size(180, 38)

        Me.btnReset.TabIndex =
            10

        Me.btnReset.Text =
            "Reset Filters"

        Me.btnReset.UseVisualStyleBackColor =
            False

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

        Me.lblDateTime.TabIndex =
        2

        Me.lblDateTime.Text =
        "Date | Time"

        Me.lblDateTime.TextAlign =
        System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' timerClock
        '==================================================
        Me.timerClock.Interval = 1000

        '==================================================
        ' pnlRecords
        '==================================================
        Me.pnlRecords.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlRecords.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlRecords.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlRecords.Controls.Add(Me.dgvAttendance)
        Me.pnlRecords.Controls.Add(Me.pnlRecordsHeader)

        Me.pnlRecords.Location =
            New System.Drawing.Point(15, 235)

        Me.pnlRecords.Name =
            "pnlRecords"

        Me.pnlRecords.Size =
            New System.Drawing.Size(1430, 400)

        Me.pnlRecords.TabIndex =
            2


        '==================================================
        ' pnlRecordsHeader
        '==================================================
        Me.pnlRecordsHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlRecordsHeader.Controls.Add(
            Me.lblRecordsTitle
        )

        Me.pnlRecordsHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlRecordsHeader.Location =
            New System.Drawing.Point(0, 0)

        Me.pnlRecordsHeader.Name =
            "pnlRecordsHeader"

        Me.pnlRecordsHeader.Size =
            New System.Drawing.Size(1428, 38)

        Me.pnlRecordsHeader.TabIndex =
            0


        '==================================================
        ' lblRecordsTitle
        '==================================================
        Me.lblRecordsTitle.AutoSize =
            True

        Me.lblRecordsTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                11.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblRecordsTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblRecordsTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblRecordsTitle.Name =
            "lblRecordsTitle"

        Me.lblRecordsTitle.Size =
            New System.Drawing.Size(178, 25)

        Me.lblRecordsTitle.TabIndex =
            0

        Me.lblRecordsTitle.Text =
            "Entry / Exit Records"


        '==================================================
        ' dgvAttendance
        '==================================================
        Me.dgvAttendance.AllowUserToAddRows =
            False

        Me.dgvAttendance.AllowUserToDeleteRows =
            False

        Me.dgvAttendance.AllowUserToResizeRows =
            False

        Me.dgvAttendance.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.dgvAttendance.AutoGenerateColumns =
            False

        Me.dgvAttendance.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvAttendance.BackgroundColor =
            System.Drawing.Color.White

        Me.dgvAttendance.BorderStyle =
            System.Windows.Forms.BorderStyle.None

        Me.dgvAttendance.CellBorderStyle =
            System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        Me.dgvAttendance.ColumnHeadersHeight =
            40

        Me.dgvAttendance.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.dgvAttendance.Columns.AddRange(
            New System.Windows.Forms.DataGridViewColumn() {
                Me.colStudentID,
                Me.colStudentName,
                Me.colYearCourse,
                Me.colDate,
                Me.colTimeIn,
                Me.colTimeOut
            }
        )

        Me.dgvAttendance.EnableHeadersVisualStyles =
            False

        Me.dgvAttendance.GridColor =
            System.Drawing.Color.FromArgb(225, 211, 201)

        Me.dgvAttendance.Location =
            New System.Drawing.Point(18, 55)

        Me.dgvAttendance.MultiSelect =
            False

        Me.dgvAttendance.Name =
            "dgvAttendance"

        Me.dgvAttendance.ReadOnly =
            True

        Me.dgvAttendance.RowHeadersVisible =
            False

        Me.dgvAttendance.RowTemplate.Height =
            36

        Me.dgvAttendance.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.dgvAttendance.Size =
            New System.Drawing.Size(1390, 325)

        Me.dgvAttendance.TabIndex =
            1


        '==================================================
        ' dgvAttendance HEADER STYLE
        '==================================================
        Me.dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor =
            System.Drawing.Color.White

        Me.dgvAttendance.ColumnHeadersDefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.dgvAttendance.ColumnHeadersDefaultCellStyle.Alignment =
            System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter


        '==================================================
        ' dgvAttendance ROW STYLE
        '==================================================
        Me.dgvAttendance.DefaultCellStyle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.dgvAttendance.DefaultCellStyle.BackColor =
            System.Drawing.Color.White

        Me.dgvAttendance.DefaultCellStyle.ForeColor =
            System.Drawing.Color.FromArgb(50, 35, 28)

        Me.dgvAttendance.DefaultCellStyle.SelectionBackColor =
            System.Drawing.Color.FromArgb(233, 216, 202)

        Me.dgvAttendance.DefaultCellStyle.SelectionForeColor =
            System.Drawing.Color.FromArgb(52, 32, 23)


        '==================================================
        ' colStudentID
        '==================================================
        Me.colStudentID.DataPropertyName =
            "student_id"

        Me.colStudentID.FillWeight =
            40.0!

        Me.colStudentID.HeaderText =
            "Student ID"

        Me.colStudentID.Name =
            "colStudentID"

        Me.colStudentID.ReadOnly =
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
            70.0!

        Me.colYearCourse.HeaderText =
            "Year / Course"

        Me.colYearCourse.Name =
            "colYearCourse"

        Me.colYearCourse.ReadOnly =
            True


        '==================================================
        ' colDate
        '==================================================
        Me.colDate.DataPropertyName =
            "attendance_date"

        Me.colDate.FillWeight =
            55.0!

        Me.colDate.HeaderText =
            "Date"

        Me.colDate.Name =
            "colDate"

        Me.colDate.ReadOnly =
            True

        Me.colDate.DefaultCellStyle.Format =
            "MM/dd/yyyy"


        '==================================================
        ' colTimeIn
        '==================================================
        Me.colTimeIn.DataPropertyName =
            "time_in"

        Me.colTimeIn.FillWeight =
            50.0!

        Me.colTimeIn.HeaderText =
            "Time In"

        Me.colTimeIn.Name =
            "colTimeIn"

        Me.colTimeIn.ReadOnly =
            True


        '==================================================
        ' colTimeOut
        '==================================================
        Me.colTimeOut.DataPropertyName =
            "time_out"

        Me.colTimeOut.FillWeight =
            50.0!

        Me.colTimeOut.HeaderText =
            "Time Out"

        Me.colTimeOut.Name =
            "colTimeOut"

        Me.colTimeOut.ReadOnly =
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

        Me.pnlSummary.Controls.Add(Me.btnGeneratePDF)
        Me.pnlSummary.Controls.Add(Me.btnGenerateExcel)

        Me.pnlSummary.Controls.Add(Me.pnlNoTimeOut)
        Me.pnlSummary.Controls.Add(Me.pnlComplete)
        Me.pnlSummary.Controls.Add(Me.pnlTotalRecords)

        Me.pnlSummary.Controls.Add(Me.lblSummaryTitle)

        Me.pnlSummary.Location =
            New System.Drawing.Point(15, 645)

        Me.pnlSummary.Name =
            "pnlSummary"

        Me.pnlSummary.Size =
            New System.Drawing.Size(1430, 120)

        Me.pnlSummary.TabIndex =
            3


        '==================================================
        ' lblSummaryTitle
        '==================================================
        Me.lblSummaryTitle.AutoSize =
            True

        Me.lblSummaryTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSummaryTitle.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblSummaryTitle.Location =
            New System.Drawing.Point(15, 8)

        Me.lblSummaryTitle.Name =
            "lblSummaryTitle"

        Me.lblSummaryTitle.Size =
            New System.Drawing.Size(81, 21)

        Me.lblSummaryTitle.TabIndex =
            0

        Me.lblSummaryTitle.Text =
            "Summary"


        '==================================================
        ' pnlTotalRecords
        '==================================================
        Me.pnlTotalRecords.BackColor =
            System.Drawing.Color.FromArgb(245, 234, 223)

        Me.pnlTotalRecords.Controls.Add(Me.lblTotalRecords)
        Me.pnlTotalRecords.Controls.Add(Me.lblTotalRecordsTitle)

        Me.pnlTotalRecords.Location =
            New System.Drawing.Point(15, 42)

        Me.pnlTotalRecords.Name =
            "pnlTotalRecords"

        Me.pnlTotalRecords.Size =
            New System.Drawing.Size(270, 58)

        Me.pnlTotalRecords.TabIndex =
            1


        '==================================================
        ' lblTotalRecordsTitle
        '==================================================
        Me.lblTotalRecordsTitle.AutoSize =
            True

        Me.lblTotalRecordsTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblTotalRecordsTitle.Location =
            New System.Drawing.Point(14, 18)

        Me.lblTotalRecordsTitle.Name =
            "lblTotalRecordsTitle"

        Me.lblTotalRecordsTitle.Size =
            New System.Drawing.Size(95, 20)

        Me.lblTotalRecordsTitle.TabIndex =
            0

        Me.lblTotalRecordsTitle.Text =
            "Total Records"


        '==================================================
        ' lblTotalRecords
        '==================================================
        Me.lblTotalRecords.Font =
            New System.Drawing.Font(
                "Segoe UI",
                15.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTotalRecords.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblTotalRecords.Location =
            New System.Drawing.Point(205, 10)

        Me.lblTotalRecords.Name =
            "lblTotalRecords"

        Me.lblTotalRecords.Size =
            New System.Drawing.Size(50, 35)

        Me.lblTotalRecords.TabIndex =
            1

        Me.lblTotalRecords.Text =
            "0"

        Me.lblTotalRecords.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' pnlComplete
        '==================================================
        Me.pnlComplete.BackColor =
            System.Drawing.Color.FromArgb(226, 242, 230)

        Me.pnlComplete.Controls.Add(Me.lblComplete)
        Me.pnlComplete.Controls.Add(Me.lblCompleteTitle)

        Me.pnlComplete.Location =
            New System.Drawing.Point(305, 42)

        Me.pnlComplete.Name =
            "pnlComplete"

        Me.pnlComplete.Size =
            New System.Drawing.Size(290, 58)

        Me.pnlComplete.TabIndex =
            2


        '==================================================
        ' lblCompleteTitle
        '==================================================
        Me.lblCompleteTitle.AutoSize =
            True

        Me.lblCompleteTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblCompleteTitle.Location =
            New System.Drawing.Point(14, 18)

        Me.lblCompleteTitle.Name =
            "lblCompleteTitle"

        Me.lblCompleteTitle.Size =
            New System.Drawing.Size(139, 20)

        Me.lblCompleteTitle.TabIndex =
            0

        Me.lblCompleteTitle.Text =
            "Complete Entry / Exit"


        '==================================================
        ' lblComplete
        '==================================================
        Me.lblComplete.Font =
            New System.Drawing.Font(
                "Segoe UI",
                15.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblComplete.ForeColor =
            System.Drawing.Color.FromArgb(40, 100, 60)

        Me.lblComplete.Location =
            New System.Drawing.Point(225, 10)

        Me.lblComplete.Name =
            "lblComplete"

        Me.lblComplete.Size =
            New System.Drawing.Size(50, 35)

        Me.lblComplete.TabIndex =
            1

        Me.lblComplete.Text =
            "0"

        Me.lblComplete.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' pnlNoTimeOut
        '==================================================
        Me.pnlNoTimeOut.BackColor =
            System.Drawing.Color.FromArgb(248, 224, 220)

        Me.pnlNoTimeOut.Controls.Add(Me.lblNoTimeOut)
        Me.pnlNoTimeOut.Controls.Add(Me.lblNoTimeOutTitle)

        Me.pnlNoTimeOut.Location =
            New System.Drawing.Point(615, 42)

        Me.pnlNoTimeOut.Name =
            "pnlNoTimeOut"

        Me.pnlNoTimeOut.Size =
            New System.Drawing.Size(270, 58)

        Me.pnlNoTimeOut.TabIndex =
            3


        '==================================================
        ' lblNoTimeOutTitle
        '==================================================
        Me.lblNoTimeOutTitle.AutoSize =
            True

        Me.lblNoTimeOutTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblNoTimeOutTitle.Location =
            New System.Drawing.Point(14, 18)

        Me.lblNoTimeOutTitle.Name =
            "lblNoTimeOutTitle"

        Me.lblNoTimeOutTitle.Size =
            New System.Drawing.Size(110, 20)

        Me.lblNoTimeOutTitle.TabIndex =
            0

        Me.lblNoTimeOutTitle.Text =
            "No Exit Record"


        '==================================================
        ' lblNoTimeOut
        '==================================================
        Me.lblNoTimeOut.Font =
            New System.Drawing.Font(
                "Segoe UI",
                15.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblNoTimeOut.ForeColor =
            System.Drawing.Color.FromArgb(170, 45, 45)

        Me.lblNoTimeOut.Location =
            New System.Drawing.Point(205, 10)

        Me.lblNoTimeOut.Name =
            "lblNoTimeOut"

        Me.lblNoTimeOut.Size =
            New System.Drawing.Size(50, 35)

        Me.lblNoTimeOut.TabIndex =
            1

        Me.lblNoTimeOut.Text =
            "0"

        Me.lblNoTimeOut.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' btnGenerateExcel
        '==================================================
        Me.btnGenerateExcel.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.btnGenerateExcel.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.btnGenerateExcel.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnGenerateExcel.FlatAppearance.BorderSize =
            0

        Me.btnGenerateExcel.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnGenerateExcel.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnGenerateExcel.ForeColor =
            System.Drawing.Color.White

        Me.btnGenerateExcel.Location =
            New System.Drawing.Point(1025, 42)

        Me.btnGenerateExcel.Name =
            "btnGenerateExcel"

        Me.btnGenerateExcel.Size =
            New System.Drawing.Size(180, 58)

        Me.btnGenerateExcel.TabIndex =
            4

        Me.btnGenerateExcel.Text =
            "Generate Excel"

        Me.btnGenerateExcel.UseVisualStyleBackColor =
            False


        '==================================================
        ' btnGeneratePDF
        '==================================================
        Me.btnGeneratePDF.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.btnGeneratePDF.BackColor =
            System.Drawing.Color.FromArgb(242, 230, 220)

        Me.btnGeneratePDF.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnGeneratePDF.FlatAppearance.BorderColor =
            System.Drawing.Color.FromArgb(205, 183, 167)

        Me.btnGeneratePDF.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnGeneratePDF.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnGeneratePDF.ForeColor =
            System.Drawing.Color.FromArgb(75, 41, 24)

        Me.btnGeneratePDF.Location =
            New System.Drawing.Point(1220, 42)

        Me.btnGeneratePDF.Name =
            "btnGeneratePDF"

        Me.btnGeneratePDF.Size =
            New System.Drawing.Size(185, 58)

        Me.btnGeneratePDF.TabIndex =
            5

        Me.btnGeneratePDF.Text =
            "Generate PDF"

        Me.btnGeneratePDF.UseVisualStyleBackColor =
            False


        '==================================================
        ' Generate_Reports
        '==================================================
        Me.AutoScaleDimensions =
            New System.Drawing.SizeF(8.0!, 20.0!)

        Me.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font

        Me.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlRecords)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.pnlHeader)

        Me.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.Name =
            "Generate_Reports"

        Me.Size =
            New System.Drawing.Size(1460, 780)


        '==================================================
        ' RESUME
        '==================================================
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()

        Me.pnlFiltersHeader.ResumeLayout(False)
        Me.pnlFiltersHeader.PerformLayout()

        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()

        Me.pnlRecordsHeader.ResumeLayout(False)
        Me.pnlRecordsHeader.PerformLayout()

        CType(
            Me.dgvAttendance,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlRecords.ResumeLayout(False)

        Me.pnlTotalRecords.ResumeLayout(False)
        Me.pnlTotalRecords.PerformLayout()

        Me.pnlComplete.ResumeLayout(False)
        Me.pnlComplete.PerformLayout()

        Me.pnlNoTimeOut.ResumeLayout(False)
        Me.pnlNoTimeOut.PerformLayout()

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

    Friend WithEvents pnlFilters As Panel
    Friend WithEvents pnlFiltersHeader As Panel
    Friend WithEvents lblFiltersTitle As Label

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents lblDateFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker

    Friend WithEvents lblDateTo As Label
    Friend WithEvents dtpTo As DateTimePicker

    Friend WithEvents lblCourse As Label
    Friend WithEvents cboCourse As ComboBox

    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents btnReset As Button

    Friend WithEvents pnlRecords As Panel
    Friend WithEvents pnlRecordsHeader As Panel
    Friend WithEvents lblRecordsTitle As Label

    Friend WithEvents dgvAttendance As DataGridView

    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearCourse As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colTimeOut As DataGridViewTextBoxColumn

    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label

    Friend WithEvents pnlTotalRecords As Panel
    Friend WithEvents lblTotalRecordsTitle As Label
    Friend WithEvents lblTotalRecords As Label

    Friend WithEvents pnlComplete As Panel
    Friend WithEvents lblCompleteTitle As Label
    Friend WithEvents lblComplete As Label

    Friend WithEvents pnlNoTimeOut As Panel
    Friend WithEvents lblNoTimeOutTitle As Label
    Friend WithEvents lblNoTimeOut As Label

    Friend WithEvents btnGenerateExcel As Button
    Friend WithEvents btnGeneratePDF As Button

    Friend WithEvents lblDateTime As Label
    Friend WithEvents timerClock As Timer

End Class