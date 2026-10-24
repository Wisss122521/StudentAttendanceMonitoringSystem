<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcManageStudent

    Inherits System.Windows.Forms.UserControl


    '==================================================
    ' DISPOSE
    '==================================================
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


    '==================================================
    ' INITIALIZE COMPONENT
    '==================================================
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
        ' STUDENT INFORMATION
        '==================================================
        pnlStudentInfo = New Panel()
        pnlStudentInfoHeader = New Panel()
        lblStudentInfoTitle = New Label()

        lblStudentName = New Label()
        txtStudentName = New TextBox()

        lblYearLevel = New Label()
        cboYearLevel = New ComboBox()

        lblCourse = New Label()
        cboCourse = New ComboBox()

        lblParentContact = New Label()
        txtParentContact = New TextBox()

        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()

        '==================================================
        ' STUDENT LIST
        '==================================================
        pnlStudents = New Panel()
        pnlStudentsHeader = New Panel()
        lblStudentsTitle = New Label()

        lblSearch = New Label()
        txtSearch = New TextBox()

        lblFilterYear = New Label()
        cboFilterYear = New ComboBox()

        lblFilterCourse = New Label()
        cboFilterCourse = New ComboBox()

        dgvStudents = New DataGridView()

        colStudentID = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colYearLevel = New DataGridViewTextBoxColumn()
        colCourse = New DataGridViewTextBoxColumn()
        colParentContact = New DataGridViewTextBoxColumn()

        '==================================================
        ' SUMMARY
        '==================================================
        pnlSummary = New Panel()
        lblSummaryTitle = New Label()

        pnlTotalStudents = New Panel()
        lblTotalStudentsTitle = New Label()
        lblTotalStudents = New Label()

        lblImportTitle = New Label()
        lblImportDescription = New Label()
        btnImportStudents = New Button()

        '==================================================
        ' TIMER
        '==================================================
        timerClock = New Timer(components)


        '==================================================
        ' SUSPEND LAYOUT
        '==================================================
        pnlHeader.SuspendLayout()

        pnlStudentInfo.SuspendLayout()
        pnlStudentInfoHeader.SuspendLayout()

        pnlStudents.SuspendLayout()
        pnlStudentsHeader.SuspendLayout()

        CType(
            dgvStudents,
            ComponentModel.ISupportInitialize
        ).BeginInit()

        pnlSummary.SuspendLayout()
        pnlTotalStudents.SuspendLayout()

        SuspendLayout()


        '==================================================
        ' pnlHeader
        ' MASTER NAVIGATOR HEADER
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
            "Add, update, delete and manage student information"


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
            "Manage Students"


        '==================================================
        ' pnlStudentInfo
        ' SAME LEFT COLUMN AS USER MANAGEMENT
        '==================================================
        pnlStudentInfo.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Left

        pnlStudentInfo.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlStudentInfo.BorderStyle =
            BorderStyle.FixedSingle

        pnlStudentInfo.Controls.Add(btnClear)
        pnlStudentInfo.Controls.Add(btnDelete)
        pnlStudentInfo.Controls.Add(btnUpdate)
        pnlStudentInfo.Controls.Add(btnSave)

        pnlStudentInfo.Controls.Add(txtParentContact)
        pnlStudentInfo.Controls.Add(lblParentContact)

        pnlStudentInfo.Controls.Add(cboCourse)
        pnlStudentInfo.Controls.Add(lblCourse)

        pnlStudentInfo.Controls.Add(cboYearLevel)
        pnlStudentInfo.Controls.Add(lblYearLevel)

        pnlStudentInfo.Controls.Add(txtStudentName)
        pnlStudentInfo.Controls.Add(lblStudentName)

        pnlStudentInfo.Controls.Add(pnlStudentInfoHeader)

        pnlStudentInfo.Location =
            New Point(18, 90)

        pnlStudentInfo.Margin =
            New Padding(3, 2, 3, 2)

        pnlStudentInfo.Name =
            "pnlStudentInfo"

        pnlStudentInfo.Size =
            New Size(320, 342)

        pnlStudentInfo.TabIndex =
            1


        '==================================================
        ' pnlStudentInfoHeader
        '==================================================
        pnlStudentInfoHeader.BackColor =
            Color.FromArgb(97, 55, 31)

        pnlStudentInfoHeader.Controls.Add(
            lblStudentInfoTitle
        )

        pnlStudentInfoHeader.Dock =
            DockStyle.Top

        pnlStudentInfoHeader.Location =
            New Point(0, 0)

        pnlStudentInfoHeader.Margin =
            New Padding(3, 2, 3, 2)

        pnlStudentInfoHeader.Name =
            "pnlStudentInfoHeader"

        pnlStudentInfoHeader.Size =
            New Size(318, 38)

        pnlStudentInfoHeader.TabIndex =
            0


        '==================================================
        ' lblStudentInfoTitle
        '==================================================
        lblStudentInfoTitle.AutoSize =
            True

        lblStudentInfoTitle.Font =
            New Font(
                "Segoe UI Semibold",
                12.0F,
                FontStyle.Bold
            )

        lblStudentInfoTitle.ForeColor =
            Color.White

        lblStudentInfoTitle.Location =
            New Point(14, 8)

        lblStudentInfoTitle.Name =
            "lblStudentInfoTitle"

        lblStudentInfoTitle.TabIndex =
            0

        lblStudentInfoTitle.Text =
            "Student Information"


        '==================================================
        ' STUDENT NAME
        '==================================================
        lblStudentName.AutoSize =
            True

        lblStudentName.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        lblStudentName.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblStudentName.Location =
            New Point(19, 52)

        lblStudentName.Name =
            "lblStudentName"

        lblStudentName.TabIndex =
            1

        lblStudentName.Text =
            "Student Name *"


        txtStudentName.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        txtStudentName.BorderStyle =
            BorderStyle.FixedSingle

        txtStudentName.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        txtStudentName.Location =
            New Point(22, 71)

        txtStudentName.Margin =
            New Padding(3, 2, 3, 2)

        txtStudentName.Name =
            "txtStudentName"

        txtStudentName.Size =
            New Size(274, 25)

        txtStudentName.TabIndex =
            2


        '==================================================
        ' YEAR LEVEL
        '==================================================
        lblYearLevel.AutoSize =
            True

        lblYearLevel.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        lblYearLevel.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblYearLevel.Location =
            New Point(19, 105)

        lblYearLevel.Name =
            "lblYearLevel"

        lblYearLevel.TabIndex =
            3

        lblYearLevel.Text =
            "Year Level *"


        cboYearLevel.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        cboYearLevel.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboYearLevel.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        cboYearLevel.FormattingEnabled =
            True

        cboYearLevel.Location =
            New Point(22, 124)

        cboYearLevel.Margin =
            New Padding(3, 2, 3, 2)

        cboYearLevel.Name =
            "cboYearLevel"

        cboYearLevel.Size =
            New Size(274, 25)

        cboYearLevel.TabIndex =
            4


        '==================================================
        ' COURSE
        '==================================================
        lblCourse.AutoSize =
            True

        lblCourse.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        lblCourse.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblCourse.Location =
            New Point(19, 158)

        lblCourse.Name =
            "lblCourse"

        lblCourse.TabIndex =
            5

        lblCourse.Text =
            "Course *"


        cboCourse.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        cboCourse.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboCourse.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        cboCourse.FormattingEnabled =
            True

        cboCourse.Location =
            New Point(22, 176)

        cboCourse.Margin =
            New Padding(3, 2, 3, 2)

        cboCourse.Name =
            "cboCourse"

        cboCourse.Size =
            New Size(274, 25)

        cboCourse.TabIndex =
            6


        '==================================================
        ' PARENT CONTACT
        '==================================================
        lblParentContact.AutoSize =
            True

        lblParentContact.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        lblParentContact.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblParentContact.Location =
            New Point(19, 210)

        lblParentContact.Name =
            "lblParentContact"

        lblParentContact.TabIndex =
            7

        lblParentContact.Text =
            "Parent Contact Number"


        txtParentContact.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        txtParentContact.BorderStyle =
            BorderStyle.FixedSingle

        txtParentContact.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        txtParentContact.Location =
            New Point(22, 229)

        txtParentContact.Margin =
            New Padding(3, 2, 3, 2)

        txtParentContact.Name =
            "txtParentContact"

        txtParentContact.Size =
            New Size(274, 25)

        txtParentContact.TabIndex =
            8


        '==================================================
        ' ADD STUDENT BUTTON
        '==================================================
        btnSave.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        btnSave.BackColor =
            Color.FromArgb(103, 60, 36)

        btnSave.Cursor =
            Cursors.Hand

        btnSave.FlatAppearance.BorderSize =
            0

        btnSave.FlatStyle =
            FlatStyle.Flat

        btnSave.Font =
            New Font(
                "Segoe UI Semibold",
                10.0F,
                FontStyle.Bold
            )

        btnSave.ForeColor =
            Color.White

        btnSave.Location =
            New Point(22, 266)

        btnSave.Margin =
            New Padding(3, 2, 3, 2)

        btnSave.Name =
            "btnSave"

        btnSave.Size =
            New Size(274, 30)

        btnSave.TabIndex =
            9

        btnSave.Text =
            "Add Student"

        btnSave.UseVisualStyleBackColor =
            False


        '==================================================
        ' UPDATE BUTTON
        '==================================================
        btnUpdate.BackColor =
            Color.FromArgb(242, 230, 220)

        btnUpdate.Cursor =
            Cursors.Hand

        btnUpdate.Enabled =
            False

        btnUpdate.FlatAppearance.BorderColor =
            Color.FromArgb(205, 183, 167)

        btnUpdate.FlatStyle =
            FlatStyle.Flat

        btnUpdate.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        btnUpdate.ForeColor =
            Color.FromArgb(75, 41, 24)

        btnUpdate.Location =
            New Point(22, 304)

        btnUpdate.Margin =
            New Padding(3, 2, 3, 2)

        btnUpdate.Name =
            "btnUpdate"

        btnUpdate.Size =
            New Size(86, 26)

        btnUpdate.TabIndex =
            10

        btnUpdate.Text =
            "Update"

        btnUpdate.UseVisualStyleBackColor =
            False


        '==================================================
        ' DELETE BUTTON
        '==================================================
        btnDelete.BackColor =
            Color.FromArgb(201, 75, 67)

        btnDelete.Cursor =
            Cursors.Hand

        btnDelete.Enabled =
            False

        btnDelete.FlatAppearance.BorderSize =
            0

        btnDelete.FlatStyle =
            FlatStyle.Flat

        btnDelete.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        btnDelete.ForeColor =
            Color.White

        btnDelete.Location =
            New Point(116, 304)

        btnDelete.Margin =
            New Padding(3, 2, 3, 2)

        btnDelete.Name =
            "btnDelete"

        btnDelete.Size =
            New Size(86, 26)

        btnDelete.TabIndex =
            11

        btnDelete.Text =
            "Delete"

        btnDelete.UseVisualStyleBackColor =
            False


        '==================================================
        ' CLEAR BUTTON
        '==================================================
        btnClear.BackColor =
            Color.FromArgb(242, 230, 220)

        btnClear.Cursor =
            Cursors.Hand

        btnClear.FlatAppearance.BorderColor =
            Color.FromArgb(205, 183, 167)

        btnClear.FlatStyle =
            FlatStyle.Flat

        btnClear.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        btnClear.ForeColor =
            Color.FromArgb(75, 41, 24)

        btnClear.Location =
            New Point(210, 304)

        btnClear.Margin =
            New Padding(3, 2, 3, 2)

        btnClear.Name =
            "btnClear"

        btnClear.Size =
            New Size(86, 26)

        btnClear.TabIndex =
            12

        btnClear.Text =
            "Clear"

        btnClear.UseVisualStyleBackColor =
            False


        '==================================================
        ' pnlStudents
        ' SAME RIGHT COLUMN AS USER MANAGEMENT
        '==================================================
        pnlStudents.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlStudents.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlStudents.BorderStyle =
            BorderStyle.FixedSingle

        pnlStudents.Controls.Add(dgvStudents)

        pnlStudents.Controls.Add(cboFilterCourse)
        pnlStudents.Controls.Add(lblFilterCourse)

        pnlStudents.Controls.Add(cboFilterYear)
        pnlStudents.Controls.Add(lblFilterYear)

        pnlStudents.Controls.Add(txtSearch)
        pnlStudents.Controls.Add(lblSearch)

        pnlStudents.Controls.Add(pnlStudentsHeader)

        pnlStudents.Location =
            New Point(350, 90)

        pnlStudents.Margin =
            New Padding(3, 2, 3, 2)

        pnlStudents.Name =
            "pnlStudents"

        pnlStudents.Size =
            New Size(665, 342)

        pnlStudents.TabIndex =
            2


        '==================================================
        ' pnlStudentsHeader
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

        pnlStudentsHeader.Margin =
            New Padding(3, 2, 3, 2)

        pnlStudentsHeader.Name =
            "pnlStudentsHeader"

        pnlStudentsHeader.Size =
            New Size(663, 38)

        pnlStudentsHeader.TabIndex =
            0


        '==================================================
        ' lblStudentsTitle
        '==================================================
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

        lblStudentsTitle.TabIndex =
            0

        lblStudentsTitle.Text =
            "Student List"


        '==================================================
        ' SEARCH LABEL
        '==================================================
        lblSearch.AutoSize =
            True

        lblSearch.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblSearch.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblSearch.Location =
            New Point(16, 50)

        lblSearch.Name =
            "lblSearch"

        lblSearch.TabIndex =
            1

        lblSearch.Text =
            "Search Student"


        '==================================================
        ' SEARCH TEXTBOX
        '==================================================
        txtSearch.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        txtSearch.BorderStyle =
            BorderStyle.FixedSingle

        txtSearch.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        txtSearch.Location =
            New Point(18, 69)

        txtSearch.Margin =
            New Padding(3, 2, 3, 2)

        txtSearch.Name =
            "txtSearch"

        txtSearch.Size =
            New Size(245, 25)

        txtSearch.TabIndex =
            2


        '==================================================
        ' YEAR FILTER LABEL
        '==================================================
        lblFilterYear.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblFilterYear.AutoSize =
            True

        lblFilterYear.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblFilterYear.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblFilterYear.Location =
            New Point(281, 50)

        lblFilterYear.Name =
            "lblFilterYear"

        lblFilterYear.TabIndex =
            3

        lblFilterYear.Text =
            "Year Level"


        '==================================================
        ' YEAR FILTER
        '==================================================
        cboFilterYear.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        cboFilterYear.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboFilterYear.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        cboFilterYear.FormattingEnabled =
            True

        cboFilterYear.Location =
            New Point(281, 69)

        cboFilterYear.Margin =
            New Padding(3, 2, 3, 2)

        cboFilterYear.Name =
            "cboFilterYear"

        cboFilterYear.Size =
            New Size(165, 25)

        cboFilterYear.TabIndex =
            4


        '==================================================
        ' COURSE FILTER LABEL
        '==================================================
        lblFilterCourse.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblFilterCourse.AutoSize =
            True

        lblFilterCourse.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblFilterCourse.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblFilterCourse.Location =
            New Point(464, 50)

        lblFilterCourse.Name =
            "lblFilterCourse"

        lblFilterCourse.TabIndex =
            5

        lblFilterCourse.Text =
            "Course"


        '==================================================
        ' COURSE FILTER
        '==================================================
        cboFilterCourse.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        cboFilterCourse.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboFilterCourse.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        cboFilterCourse.FormattingEnabled =
            True

        cboFilterCourse.Location =
            New Point(464, 69)

        cboFilterCourse.Margin =
            New Padding(3, 2, 3, 2)

        cboFilterCourse.Name =
            "cboFilterCourse"

        cboFilterCourse.Size =
            New Size(180, 25)

        cboFilterCourse.TabIndex =
            6


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
                10.0F,
                FontStyle.Bold
            )

        dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White

        dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            Color.FromArgb(93, 50, 29)

        dgvStudents.ColumnHeadersDefaultCellStyle.SelectionForeColor =
            Color.White

        dgvStudents.ColumnHeadersDefaultCellStyle.WrapMode =
            DataGridViewTriState.True

        dgvStudents.ColumnHeadersHeight =
            42

        dgvStudents.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        dgvStudents.Columns.AddRange(
            New DataGridViewColumn() {
                colStudentID,
                colStudentName,
                colYearLevel,
                colCourse,
                colParentContact
            }
        )

        dgvStudents.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleLeft

        dgvStudents.DefaultCellStyle.BackColor =
            Color.White

        dgvStudents.DefaultCellStyle.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        dgvStudents.DefaultCellStyle.ForeColor =
            Color.FromArgb(50, 35, 28)

        dgvStudents.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(233, 216, 202)

        dgvStudents.DefaultCellStyle.SelectionForeColor =
            Color.FromArgb(52, 32, 23)

        dgvStudents.DefaultCellStyle.WrapMode =
            DataGridViewTriState.False

        dgvStudents.EnableHeadersVisualStyles =
            False

        dgvStudents.GridColor =
            Color.FromArgb(225, 211, 201)

        dgvStudents.Location =
            New Point(18, 109)

        dgvStudents.Margin =
            New Padding(3, 2, 3, 2)

        dgvStudents.MultiSelect =
            False

        dgvStudents.Name =
            "dgvStudents"

        dgvStudents.ReadOnly =
            True

        dgvStudents.RowHeadersVisible =
            False

        dgvStudents.RowTemplate.Height =
            38

        dgvStudents.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvStudents.Size =
            New Size(626, 214)

        dgvStudents.TabIndex =
            7


        '==================================================
        ' STUDENT ID COLUMN
        '==================================================
        colStudentID.DataPropertyName =
            "student_id"

        colStudentID.FillWeight =
            40.0F

        colStudentID.HeaderText =
            "Student ID"

        colStudentID.Name =
            "colStudentID"

        colStudentID.ReadOnly =
            True


        '==================================================
        ' STUDENT NAME COLUMN
        '==================================================
        colStudentName.DataPropertyName =
            "student_name"

        colStudentName.FillWeight =
            100.0F

        colStudentName.HeaderText =
            "Student Name"

        colStudentName.Name =
            "colStudentName"

        colStudentName.ReadOnly =
            True


        '==================================================
        ' YEAR LEVEL COLUMN
        '==================================================
        colYearLevel.DataPropertyName =
            "year_level"

        colYearLevel.FillWeight =
            55.0F

        colYearLevel.HeaderText =
            "Year Level"

        colYearLevel.Name =
            "colYearLevel"

        colYearLevel.ReadOnly =
            True


        '==================================================
        ' COURSE COLUMN
        '==================================================
        colCourse.DataPropertyName =
            "course"

        colCourse.FillWeight =
            55.0F

        colCourse.HeaderText =
            "Course"

        colCourse.Name =
            "colCourse"

        colCourse.ReadOnly =
            True


        '==================================================
        ' PARENT CONTACT COLUMN
        '==================================================
        colParentContact.DataPropertyName =
            "parent_contact_number"

        colParentContact.FillWeight =
            80.0F

        colParentContact.HeaderText =
            "Parent Contact"

        colParentContact.Name =
            "colParentContact"

        colParentContact.ReadOnly =
            True


        '==================================================
        ' pnlSummary
        ' SAME MASTER POSITION
        '==================================================
        pnlSummary.Anchor =
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlSummary.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlSummary.BorderStyle =
            BorderStyle.FixedSingle

        pnlSummary.Controls.Add(btnImportStudents)
        pnlSummary.Controls.Add(lblImportDescription)
        pnlSummary.Controls.Add(lblImportTitle)

        pnlSummary.Controls.Add(pnlTotalStudents)
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
            3


        '==================================================
        ' lblSummaryTitle
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

        lblSummaryTitle.TabIndex =
            0

        lblSummaryTitle.Text =
            "Summary"


        '==================================================
        ' TOTAL STUDENTS CARD
        ' SAME SIZE AS USER MANAGEMENT SUMMARY CARD
        '==================================================
        pnlTotalStudents.BackColor =
            Color.FromArgb(245, 234, 223)

        pnlTotalStudents.Controls.Add(lblTotalStudents)
        pnlTotalStudents.Controls.Add(lblTotalStudentsTitle)

        pnlTotalStudents.Location =
            New Point(18, 30)

        pnlTotalStudents.Margin =
            New Padding(3, 2, 3, 2)

        pnlTotalStudents.Name =
            "pnlTotalStudents"

        pnlTotalStudents.Size =
            New Size(302, 41)

        pnlTotalStudents.TabIndex =
            1


        '==================================================
        ' TOTAL STUDENTS TITLE
        '==================================================
        lblTotalStudentsTitle.AutoSize =
            True

        lblTotalStudentsTitle.Font =
            New Font(
                "Segoe UI",
                9.5F
            )

        lblTotalStudentsTitle.Location =
            New Point(12, 6)

        lblTotalStudentsTitle.Name =
            "lblTotalStudentsTitle"

        lblTotalStudentsTitle.TabIndex =
            0

        lblTotalStudentsTitle.Text =
            "Total Students"


        '==================================================
        ' TOTAL STUDENTS COUNT
        '==================================================
        lblTotalStudents.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblTotalStudents.Font =
            New Font(
                "Segoe UI",
                18.0F,
                FontStyle.Bold
            )

        lblTotalStudents.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblTotalStudents.Location =
            New Point(219, 5)

        lblTotalStudents.Name =
            "lblTotalStudents"

        lblTotalStudents.Size =
            New Size(66, 30)

        lblTotalStudents.TabIndex =
            1

        lblTotalStudents.Text =
            "0"

        lblTotalStudents.TextAlign =
            ContentAlignment.MiddleRight


        '==================================================
        ' IMPORT TITLE
        '==================================================
        lblImportTitle.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblImportTitle.AutoSize =
            True

        lblImportTitle.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        lblImportTitle.ForeColor =
            Color.FromArgb(68, 37, 22)

        lblImportTitle.Location =
            New Point(455, 33)

        lblImportTitle.Name =
            "lblImportTitle"

        lblImportTitle.TabIndex =
            2

        lblImportTitle.Text =
            "Bulk Student Import"


        '==================================================
        ' IMPORT DESCRIPTION
        '==================================================
        lblImportDescription.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblImportDescription.AutoSize =
            True

        lblImportDescription.Font =
            New Font(
                "Segoe UI",
                8.0F
            )

        lblImportDescription.ForeColor =
            Color.DimGray

        lblImportDescription.Location =
            New Point(455, 52)

        lblImportDescription.Name =
            "lblImportDescription"

        lblImportDescription.TabIndex =
            3

        lblImportDescription.Text =
            "Import multiple students from Excel."


        '==================================================
        ' IMPORT STUDENTS BUTTON
        '==================================================
        btnImportStudents.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        btnImportStudents.BackColor =
            Color.FromArgb(103, 60, 36)

        btnImportStudents.Cursor =
            Cursors.Hand

        btnImportStudents.FlatAppearance.BorderSize =
            0

        btnImportStudents.FlatStyle =
            FlatStyle.Flat

        btnImportStudents.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        btnImportStudents.ForeColor =
            Color.White

        btnImportStudents.Location =
            New Point(752, 30)

        btnImportStudents.Margin =
            New Padding(3, 2, 3, 2)

        btnImportStudents.Name =
            "btnImportStudents"

        btnImportStudents.Size =
            New Size(220, 41)

        btnImportStudents.TabIndex =
            4

        btnImportStudents.Text =
            "Import Students from Excel"

        btnImportStudents.UseVisualStyleBackColor =
            False


        '==================================================
        ' TIMER
        '==================================================
        timerClock.Interval =
            1000


        '==================================================
        ' UcManageStudent
        ' MASTER NAVIGATOR SIZE
        '==================================================
        AutoScaleDimensions =
            New SizeF(7.0F, 15.0F)

        AutoScaleMode =
            AutoScaleMode.Font

        BackColor =
            Color.FromArgb(247, 241, 236)

        Controls.Add(pnlSummary)
        Controls.Add(pnlStudents)
        Controls.Add(pnlStudentInfo)
        Controls.Add(pnlHeader)

        Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        Margin =
            New Padding(3, 2, 3, 2)

        Name =
            "UcManageStudent"

        Size =
            New Size(1032, 540)


        '==================================================
        ' RESUME LAYOUT
        '==================================================
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()

        pnlStudentInfoHeader.ResumeLayout(False)
        pnlStudentInfoHeader.PerformLayout()

        pnlStudentInfo.ResumeLayout(False)
        pnlStudentInfo.PerformLayout()

        pnlStudentsHeader.ResumeLayout(False)
        pnlStudentsHeader.PerformLayout()

        CType(
            dgvStudents,
            ComponentModel.ISupportInitialize
        ).EndInit()

        pnlStudents.ResumeLayout(False)
        pnlStudents.PerformLayout()

        pnlTotalStudents.ResumeLayout(False)
        pnlTotalStudents.PerformLayout()

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

    Friend WithEvents timerClock As Timer

End Class