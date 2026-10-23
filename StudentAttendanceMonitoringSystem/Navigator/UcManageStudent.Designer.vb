<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcManageStudent

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
        ' STUDENT INFORMATION
        '==================================================
        Me.pnlStudentInfo = New System.Windows.Forms.Panel()
        Me.pnlStudentInfoHeader = New System.Windows.Forms.Panel()
        Me.lblStudentInfoTitle = New System.Windows.Forms.Label()

        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()

        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()

        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()

        Me.lblParentContact = New System.Windows.Forms.Label()
        Me.txtParentContact = New System.Windows.Forms.TextBox()

        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()

        '==================================================
        ' STUDENT LIST
        '==================================================
        Me.pnlStudents = New System.Windows.Forms.Panel()
        Me.pnlStudentsHeader = New System.Windows.Forms.Panel()
        Me.lblStudentsTitle = New System.Windows.Forms.Label()

        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()

        Me.lblFilterYear = New System.Windows.Forms.Label()
        Me.cboFilterYear = New System.Windows.Forms.ComboBox()

        Me.lblFilterCourse = New System.Windows.Forms.Label()
        Me.cboFilterCourse = New System.Windows.Forms.ComboBox()

        Me.dgvStudents = New System.Windows.Forms.DataGridView()

        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colParentContact = New System.Windows.Forms.DataGridViewTextBoxColumn()

        '==================================================
        ' SUMMARY
        '==================================================
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblSummaryTitle = New System.Windows.Forms.Label()

        Me.pnlTotalStudents = New System.Windows.Forms.Panel()
        Me.lblTotalStudentsTitle = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()

        Me.lblImportTitle = New System.Windows.Forms.Label()
        Me.lblImportDescription = New System.Windows.Forms.Label()
        Me.btnImportStudents = New System.Windows.Forms.Button()


        '==================================================
        ' SUSPEND
        '==================================================
        Me.pnlHeader.SuspendLayout()

        Me.pnlStudentInfo.SuspendLayout()
        Me.pnlStudentInfoHeader.SuspendLayout()

        Me.pnlStudents.SuspendLayout()
        Me.pnlStudentsHeader.SuspendLayout()

        CType(
            Me.dgvStudents,
            System.ComponentModel.ISupportInitialize
        ).BeginInit()

        Me.pnlSummary.SuspendLayout()
        Me.pnlTotalStudents.SuspendLayout()

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

        Me.pnlHeader.TabIndex = 0

        Me.pnlHeader.Controls.Add(Me.lblDateTime)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)

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
            New System.Drawing.Size(320, 44)

        Me.lblTitle.TabIndex = 0

        Me.lblTitle.Text =
            "Manage Students"


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
            New System.Drawing.Size(335, 20)

        Me.lblSubtitle.TabIndex = 1

        Me.lblSubtitle.Text =
            "Add, update, delete and manage student information"


        '==================================================
        ' pnlStudentInfo
        '==================================================
        Me.pnlStudentInfo.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlStudentInfo.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlStudentInfo.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlStudentInfo.Controls.Add(Me.btnClear)
        Me.pnlStudentInfo.Controls.Add(Me.btnDelete)
        Me.pnlStudentInfo.Controls.Add(Me.btnUpdate)
        Me.pnlStudentInfo.Controls.Add(Me.btnSave)

        Me.pnlStudentInfo.Controls.Add(Me.txtParentContact)
        Me.pnlStudentInfo.Controls.Add(Me.lblParentContact)

        Me.pnlStudentInfo.Controls.Add(Me.cboCourse)
        Me.pnlStudentInfo.Controls.Add(Me.lblCourse)

        Me.pnlStudentInfo.Controls.Add(Me.cboYearLevel)
        Me.pnlStudentInfo.Controls.Add(Me.lblYearLevel)

        Me.pnlStudentInfo.Controls.Add(Me.txtStudentName)
        Me.pnlStudentInfo.Controls.Add(Me.lblStudentName)

        Me.pnlStudentInfo.Controls.Add(Me.pnlStudentInfoHeader)

        Me.pnlStudentInfo.Location =
            New System.Drawing.Point(15, 100)

        Me.pnlStudentInfo.Name =
            "pnlStudentInfo"

        Me.pnlStudentInfo.Size =
            New System.Drawing.Size(420, 545)

        Me.pnlStudentInfo.TabIndex = 1


        '==================================================
        ' pnlStudentInfoHeader
        '==================================================
        Me.pnlStudentInfoHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlStudentInfoHeader.Controls.Add(
            Me.lblStudentInfoTitle
        )

        Me.pnlStudentInfoHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlStudentInfoHeader.Location =
            New System.Drawing.Point(0, 0)

        Me.pnlStudentInfoHeader.Name =
            "pnlStudentInfoHeader"

        Me.pnlStudentInfoHeader.Size =
            New System.Drawing.Size(418, 38)

        Me.pnlStudentInfoHeader.TabIndex = 0


        '==================================================
        ' lblStudentInfoTitle
        '==================================================
        Me.lblStudentInfoTitle.AutoSize = True

        Me.lblStudentInfoTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                11.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblStudentInfoTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblStudentInfoTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblStudentInfoTitle.Name =
            "lblStudentInfoTitle"

        Me.lblStudentInfoTitle.Size =
            New System.Drawing.Size(187, 25)

        Me.lblStudentInfoTitle.TabIndex = 0

        Me.lblStudentInfoTitle.Text =
            "Student Information"


        '==================================================
        ' lblStudentName
        '==================================================
        Me.lblStudentName.AutoSize = True

        Me.lblStudentName.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblStudentName.Location =
            New System.Drawing.Point(20, 63)

        Me.lblStudentName.Name =
            "lblStudentName"

        Me.lblStudentName.Size =
            New System.Drawing.Size(123, 20)

        Me.lblStudentName.TabIndex = 1

        Me.lblStudentName.Text =
            "Student Name *"


        '==================================================
        ' txtStudentName
        '==================================================
        Me.txtStudentName.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.txtStudentName.Font =
            New System.Drawing.Font(
                "Segoe UI",
                10.0!
            )

        Me.txtStudentName.Location =
            New System.Drawing.Point(22, 87)

        Me.txtStudentName.Name =
            "txtStudentName"

        Me.txtStudentName.Size =
            New System.Drawing.Size(373, 30)

        Me.txtStudentName.TabIndex = 2


        '==================================================
        ' lblYearLevel
        '==================================================
        Me.lblYearLevel.AutoSize = True

        Me.lblYearLevel.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblYearLevel.Location =
            New System.Drawing.Point(20, 135)

        Me.lblYearLevel.Name =
            "lblYearLevel"

        Me.lblYearLevel.Size =
            New System.Drawing.Size(91, 20)

        Me.lblYearLevel.TabIndex = 3

        Me.lblYearLevel.Text =
            "Year Level *"


        '==================================================
        ' cboYearLevel
        '==================================================
        Me.cboYearLevel.DropDownStyle =
            System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.cboYearLevel.Font =
            New System.Drawing.Font(
                "Segoe UI",
                10.0!
            )

        Me.cboYearLevel.FormattingEnabled =
            True

        Me.cboYearLevel.Location =
            New System.Drawing.Point(22, 159)

        Me.cboYearLevel.Name =
            "cboYearLevel"

        Me.cboYearLevel.Size =
            New System.Drawing.Size(373, 31)

        Me.cboYearLevel.TabIndex = 4


        '==================================================
        ' lblCourse
        '==================================================
        Me.lblCourse.AutoSize = True

        Me.lblCourse.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblCourse.Location =
            New System.Drawing.Point(20, 208)

        Me.lblCourse.Name =
            "lblCourse"

        Me.lblCourse.Size =
            New System.Drawing.Size(69, 20)

        Me.lblCourse.TabIndex = 5

        Me.lblCourse.Text =
            "Course *"


        '==================================================
        ' cboCourse
        '==================================================
        Me.cboCourse.DropDownStyle =
            System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.cboCourse.Font =
            New System.Drawing.Font(
                "Segoe UI",
                10.0!
            )

        Me.cboCourse.FormattingEnabled =
            True

        Me.cboCourse.Location =
            New System.Drawing.Point(22, 232)

        Me.cboCourse.Name =
            "cboCourse"

        Me.cboCourse.Size =
            New System.Drawing.Size(373, 31)

        Me.cboCourse.TabIndex = 6


        '==================================================
        ' lblParentContact
        '==================================================
        Me.lblParentContact.AutoSize = True

        Me.lblParentContact.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblParentContact.Location =
            New System.Drawing.Point(20, 281)

        Me.lblParentContact.Name =
            "lblParentContact"

        Me.lblParentContact.Size =
            New System.Drawing.Size(185, 20)

        Me.lblParentContact.TabIndex = 7

        Me.lblParentContact.Text =
            "Parent Contact Number"


        '==================================================
        ' txtParentContact
        '==================================================
        Me.txtParentContact.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.txtParentContact.Font =
            New System.Drawing.Font(
                "Segoe UI",
                10.0!
            )

        Me.txtParentContact.Location =
            New System.Drawing.Point(22, 305)

        Me.txtParentContact.Name =
            "txtParentContact"

        Me.txtParentContact.Size =
            New System.Drawing.Size(373, 30)

        Me.txtParentContact.TabIndex = 8


        '==================================================
        ' btnSave
        '==================================================
        Me.btnSave.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.btnSave.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnSave.FlatAppearance.BorderSize =
            0

        Me.btnSave.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnSave.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                10.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnSave.ForeColor =
            System.Drawing.Color.White

        Me.btnSave.Location =
            New System.Drawing.Point(22, 365)

        Me.btnSave.Name =
            "btnSave"

        Me.btnSave.Size =
            New System.Drawing.Size(373, 43)

        Me.btnSave.TabIndex = 9

        Me.btnSave.Text =
            "Add Student"

        Me.btnSave.UseVisualStyleBackColor =
            False


        '==================================================
        ' btnUpdate
        '==================================================
        Me.btnUpdate.BackColor =
            System.Drawing.Color.FromArgb(242, 230, 220)

        Me.btnUpdate.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnUpdate.Enabled =
            False

        Me.btnUpdate.FlatAppearance.BorderColor =
            System.Drawing.Color.FromArgb(205, 183, 167)

        Me.btnUpdate.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnUpdate.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnUpdate.ForeColor =
            System.Drawing.Color.FromArgb(75, 41, 24)

        Me.btnUpdate.Location =
            New System.Drawing.Point(22, 420)

        Me.btnUpdate.Name =
            "btnUpdate"

        Me.btnUpdate.Size =
            New System.Drawing.Size(117, 40)

        Me.btnUpdate.TabIndex = 10

        Me.btnUpdate.Text =
            "Update"

        Me.btnUpdate.UseVisualStyleBackColor =
            False


        '==================================================
        ' btnDelete
        '==================================================
        Me.btnDelete.BackColor =
            System.Drawing.Color.FromArgb(201, 75, 67)

        Me.btnDelete.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnDelete.Enabled =
            False

        Me.btnDelete.FlatAppearance.BorderSize =
            0

        Me.btnDelete.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnDelete.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnDelete.ForeColor =
            System.Drawing.Color.White

        Me.btnDelete.Location =
            New System.Drawing.Point(150, 420)

        Me.btnDelete.Name =
            "btnDelete"

        Me.btnDelete.Size =
            New System.Drawing.Size(117, 40)

        Me.btnDelete.TabIndex = 11

        Me.btnDelete.Text =
            "Delete"

        Me.btnDelete.UseVisualStyleBackColor =
            False


        '==================================================
        ' btnClear
        '==================================================
        Me.btnClear.BackColor =
            System.Drawing.Color.FromArgb(242, 230, 220)

        Me.btnClear.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnClear.FlatAppearance.BorderColor =
            System.Drawing.Color.FromArgb(205, 183, 167)

        Me.btnClear.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnClear.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnClear.ForeColor =
            System.Drawing.Color.FromArgb(75, 41, 24)

        Me.btnClear.Location =
            New System.Drawing.Point(278, 420)

        Me.btnClear.Name =
            "btnClear"

        Me.btnClear.Size =
            New System.Drawing.Size(117, 40)

        Me.btnClear.TabIndex = 12

        Me.btnClear.Text =
            "Clear"

        Me.btnClear.UseVisualStyleBackColor =
            False


        '==================================================
        ' pnlStudents
        '==================================================
        Me.pnlStudents.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlStudents.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlStudents.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlStudents.Controls.Add(Me.dgvStudents)

        Me.pnlStudents.Controls.Add(Me.cboFilterCourse)
        Me.pnlStudents.Controls.Add(Me.lblFilterCourse)

        Me.pnlStudents.Controls.Add(Me.cboFilterYear)
        Me.pnlStudents.Controls.Add(Me.lblFilterYear)

        Me.pnlStudents.Controls.Add(Me.txtSearch)
        Me.pnlStudents.Controls.Add(Me.lblSearch)

        Me.pnlStudents.Controls.Add(Me.pnlStudentsHeader)

        Me.pnlStudents.Location =
            New System.Drawing.Point(445, 100)

        Me.pnlStudents.Name =
            "pnlStudents"

        Me.pnlStudents.Size =
            New System.Drawing.Size(1000, 545)

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
            New System.Drawing.Size(998, 38)

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
        ' lblSearch
        '==================================================
        Me.lblSearch.AutoSize = True

        Me.lblSearch.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblSearch.Location =
            New System.Drawing.Point(17, 52)

        Me.lblSearch.Name =
            "lblSearch"

        Me.lblSearch.Size =
            New System.Drawing.Size(107, 20)

        Me.lblSearch.TabIndex = 1

        Me.lblSearch.Text =
            "Search Student"


        '==================================================
        ' txtSearch
        '==================================================
        Me.txtSearch.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Left Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.txtSearch.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.txtSearch.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.txtSearch.Location =
            New System.Drawing.Point(18, 75)

        Me.txtSearch.Name =
            "txtSearch"

        Me.txtSearch.Size =
            New System.Drawing.Size(520, 27)

        Me.txtSearch.TabIndex = 2


        '==================================================
        ' lblFilterYear
        '==================================================
        Me.lblFilterYear.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblFilterYear.AutoSize = True

        Me.lblFilterYear.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblFilterYear.Location =
            New System.Drawing.Point(557, 52)

        Me.lblFilterYear.Name =
            "lblFilterYear"

        Me.lblFilterYear.Size =
            New System.Drawing.Size(79, 20)

        Me.lblFilterYear.TabIndex = 3

        Me.lblFilterYear.Text =
            "Year Level"


        '==================================================
        ' cboFilterYear
        '==================================================
        Me.cboFilterYear.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.cboFilterYear.DropDownStyle =
            System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.cboFilterYear.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.cboFilterYear.FormattingEnabled =
            True

        Me.cboFilterYear.Location =
            New System.Drawing.Point(557, 75)

        Me.cboFilterYear.Name =
            "cboFilterYear"

        Me.cboFilterYear.Size =
            New System.Drawing.Size(195, 28)

        Me.cboFilterYear.TabIndex = 4


        '==================================================
        ' lblFilterCourse
        '==================================================
        Me.lblFilterCourse.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblFilterCourse.AutoSize = True

        Me.lblFilterCourse.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblFilterCourse.Location =
            New System.Drawing.Point(770, 52)

        Me.lblFilterCourse.Name =
            "lblFilterCourse"

        Me.lblFilterCourse.Size =
            New System.Drawing.Size(53, 20)

        Me.lblFilterCourse.TabIndex = 5

        Me.lblFilterCourse.Text =
            "Course"


        '==================================================
        ' cboFilterCourse
        '==================================================
        Me.cboFilterCourse.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.cboFilterCourse.DropDownStyle =
            System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.cboFilterCourse.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.cboFilterCourse.FormattingEnabled =
            True

        Me.cboFilterCourse.Location =
            New System.Drawing.Point(770, 75)

        Me.cboFilterCourse.Name =
            "cboFilterCourse"

        Me.cboFilterCourse.Size =
            New System.Drawing.Size(208, 28)

        Me.cboFilterCourse.TabIndex = 6


        '==================================================
        ' dgvStudents
        '==================================================
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AllowUserToResizeRows = False

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
            System.Windows.Forms.BorderStyle.None

        Me.dgvStudents.CellBorderStyle =
            System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        Me.dgvStudents.ColumnHeadersHeight =
            40

        Me.dgvStudents.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.dgvStudents.Columns.AddRange(
            New System.Windows.Forms.DataGridViewColumn() {
                Me.colStudentID,
                Me.colStudentName,
                Me.colYearLevel,
                Me.colCourse,
                Me.colParentContact
            }
        )

        Me.dgvStudents.EnableHeadersVisualStyles =
            False

        Me.dgvStudents.GridColor =
            System.Drawing.Color.FromArgb(225, 211, 201)

        Me.dgvStudents.Location =
            New System.Drawing.Point(18, 120)

        Me.dgvStudents.MultiSelect =
            False

        Me.dgvStudents.Name =
            "dgvStudents"

        Me.dgvStudents.ReadOnly =
            True

        Me.dgvStudents.RowHeadersVisible =
            False

        Me.dgvStudents.RowTemplate.Height =
            36

        Me.dgvStudents.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.dgvStudents.Size =
            New System.Drawing.Size(960, 400)

        Me.dgvStudents.TabIndex = 7


        '==================================================
        ' DATAGRIDVIEW HEADER STYLE
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
        ' DATAGRIDVIEW ROW STYLE
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
        ' colStudentID
        '==================================================
        Me.colStudentID.DataPropertyName =
            "student_id"

        Me.colStudentID.FillWeight =
            35.0!

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
            85.0!

        Me.colStudentName.HeaderText =
            "Student Name"

        Me.colStudentName.Name =
            "colStudentName"

        Me.colStudentName.ReadOnly =
            True


        '==================================================
        ' colYearLevel
        '==================================================
        Me.colYearLevel.DataPropertyName =
            "year_level"

        Me.colYearLevel.FillWeight =
            55.0!

        Me.colYearLevel.HeaderText =
            "Year Level"

        Me.colYearLevel.Name =
            "colYearLevel"

        Me.colYearLevel.ReadOnly =
            True


        '==================================================
        ' colCourse
        '==================================================
        Me.colCourse.DataPropertyName =
            "course"

        Me.colCourse.FillWeight =
            45.0!

        Me.colCourse.HeaderText =
            "Course"

        Me.colCourse.Name =
            "colCourse"

        Me.colCourse.ReadOnly =
            True


        '==================================================
        ' colParentContact
        '==================================================
        Me.colParentContact.DataPropertyName =
            "parent_contact_number"

        Me.colParentContact.FillWeight =
            75.0!

        Me.colParentContact.HeaderText =
            "Parent Contact"

        Me.colParentContact.Name =
            "colParentContact"

        Me.colParentContact.ReadOnly =
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

        Me.pnlSummary.Controls.Add(Me.btnImportStudents)

        Me.pnlSummary.Controls.Add(Me.lblImportDescription)
        Me.pnlSummary.Controls.Add(Me.lblImportTitle)

        Me.pnlSummary.Controls.Add(Me.pnlTotalStudents)
        Me.pnlSummary.Controls.Add(Me.lblSummaryTitle)

        Me.pnlSummary.Location =
            New System.Drawing.Point(15, 655)

        Me.pnlSummary.Name =
            "pnlSummary"

        Me.pnlSummary.Size =
            New System.Drawing.Size(1430, 110)

        Me.pnlSummary.TabIndex = 3


        '==================================================
        ' lblSummaryTitle
        '==================================================
        Me.lblSummaryTitle.AutoSize = True

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

        Me.lblSummaryTitle.TabIndex = 0

        Me.lblSummaryTitle.Text =
            "Summary"


        '==================================================
        ' pnlTotalStudents
        '==================================================
        Me.pnlTotalStudents.BackColor =
            System.Drawing.Color.FromArgb(245, 234, 223)

        Me.pnlTotalStudents.Controls.Add(Me.lblTotalStudents)
        Me.pnlTotalStudents.Controls.Add(Me.lblTotalStudentsTitle)

        Me.pnlTotalStudents.Location =
            New System.Drawing.Point(15, 40)

        Me.pnlTotalStudents.Name =
            "pnlTotalStudents"

        Me.pnlTotalStudents.Size =
            New System.Drawing.Size(330, 52)

        Me.pnlTotalStudents.TabIndex = 1


        '==================================================
        ' lblTotalStudentsTitle
        '==================================================
        Me.lblTotalStudentsTitle.AutoSize = True

        Me.lblTotalStudentsTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblTotalStudentsTitle.Location =
            New System.Drawing.Point(15, 15)

        Me.lblTotalStudentsTitle.Name =
            "lblTotalStudentsTitle"

        Me.lblTotalStudentsTitle.Size =
            New System.Drawing.Size(102, 20)

        Me.lblTotalStudentsTitle.TabIndex = 0

        Me.lblTotalStudentsTitle.Text =
            "Total Students"


        '==================================================
        ' lblTotalStudents
        '==================================================
        Me.lblTotalStudents.Font =
            New System.Drawing.Font(
                "Segoe UI",
                15.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblTotalStudents.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblTotalStudents.Location =
            New System.Drawing.Point(250, 7)

        Me.lblTotalStudents.Name =
            "lblTotalStudents"

        Me.lblTotalStudents.Size =
            New System.Drawing.Size(60, 35)

        Me.lblTotalStudents.TabIndex = 1

        Me.lblTotalStudents.Text =
            "0"

        Me.lblTotalStudents.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' lblImportTitle
        '==================================================
        Me.lblImportTitle.AutoSize = True

        Me.lblImportTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblImportTitle.ForeColor =
            System.Drawing.Color.FromArgb(68, 37, 22)

        Me.lblImportTitle.Location =
            New System.Drawing.Point(410, 42)

        Me.lblImportTitle.Name =
            "lblImportTitle"

        Me.lblImportTitle.Size =
            New System.Drawing.Size(171, 21)

        Me.lblImportTitle.TabIndex = 2

        Me.lblImportTitle.Text =
            "Bulk Student Import"


        '==================================================
        ' lblImportDescription
        '==================================================
        Me.lblImportDescription.AutoSize = True

        Me.lblImportDescription.Font =
            New System.Drawing.Font(
                "Segoe UI",
                8.5!
            )

        Me.lblImportDescription.ForeColor =
            System.Drawing.Color.DimGray

        Me.lblImportDescription.Location =
            New System.Drawing.Point(410, 67)

        Me.lblImportDescription.Name =
            "lblImportDescription"

        Me.lblImportDescription.Size =
            New System.Drawing.Size(337, 20)

        Me.lblImportDescription.TabIndex = 3

        Me.lblImportDescription.Text =
            "Import multiple student records from an Excel file."


        '==================================================
        ' btnImportStudents
        '==================================================
        Me.btnImportStudents.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.btnImportStudents.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.btnImportStudents.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnImportStudents.FlatAppearance.BorderSize =
            0

        Me.btnImportStudents.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnImportStudents.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnImportStudents.ForeColor =
            System.Drawing.Color.White

        Me.btnImportStudents.Location =
            New System.Drawing.Point(1100, 40)

        Me.btnImportStudents.Name =
            "btnImportStudents"

        Me.btnImportStudents.Size =
            New System.Drawing.Size(305, 52)

        Me.btnImportStudents.TabIndex = 4

        Me.btnImportStudents.Text =
            "Import Students from Excel"

        Me.btnImportStudents.UseVisualStyleBackColor =
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
        Me.timerClock.Interval =
         1000

        '==================================================
        ' ManageStudent
        '==================================================
        Me.AutoScaleDimensions =
            New System.Drawing.SizeF(8.0!, 20.0!)

        Me.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font

        Me.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlStudents)
        Me.Controls.Add(Me.pnlStudentInfo)
        Me.Controls.Add(Me.pnlHeader)

        Me.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.Name =
            "ManageStudent"

        Me.Size =
            New System.Drawing.Size(1460, 780)


        '==================================================
        ' RESUME
        '==================================================
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()

        Me.pnlStudentInfoHeader.ResumeLayout(False)
        Me.pnlStudentInfoHeader.PerformLayout()

        Me.pnlStudentInfo.ResumeLayout(False)
        Me.pnlStudentInfo.PerformLayout()

        Me.pnlStudentsHeader.ResumeLayout(False)
        Me.pnlStudentsHeader.PerformLayout()

        CType(
            Me.dgvStudents,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlStudents.ResumeLayout(False)
        Me.pnlStudents.PerformLayout()

        Me.pnlTotalStudents.ResumeLayout(False)
        Me.pnlTotalStudents.PerformLayout()

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

    Friend WithEvents pnlStudentInfo As Panel
    Friend WithEvents pnlStudentInfoHeader As Panel
    Friend WithEvents lblStudentInfoTitle As Label

    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox

    Friend WithEvents lblYearLevel As Label
    Friend WithEvents cboYearLevel As ComboBox

    Friend WithEvents lblCourse As Label
    Friend WithEvents cboCourse As ComboBox

    Friend WithEvents lblParentContact As Label
    Friend WithEvents txtParentContact As TextBox

    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents pnlStudents As Panel
    Friend WithEvents pnlStudentsHeader As Panel
    Friend WithEvents lblStudentsTitle As Label

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents lblFilterYear As Label
    Friend WithEvents cboFilterYear As ComboBox

    Friend WithEvents lblFilterCourse As Label
    Friend WithEvents cboFilterCourse As ComboBox

    Friend WithEvents dgvStudents As DataGridView

    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearLevel As DataGridViewTextBoxColumn
    Friend WithEvents colCourse As DataGridViewTextBoxColumn
    Friend WithEvents colParentContact As DataGridViewTextBoxColumn

    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label

    Friend WithEvents pnlTotalStudents As Panel
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents lblTotalStudents As Label

    Friend WithEvents lblImportTitle As Label
    Friend WithEvents lblImportDescription As Label

    Friend WithEvents btnImportStudents As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents timerClock As Timer

End Class