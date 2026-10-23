<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcQrCode

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
        ' STUDENT LIST
        '==================================================
        Me.pnlStudents = New System.Windows.Forms.Panel()
        Me.pnlStudentsHeader = New System.Windows.Forms.Panel()
        Me.lblStudentsTitle = New System.Windows.Forms.Label()

        Me.lblSearchStudent = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()

        Me.lblQRStatusFilter = New System.Windows.Forms.Label()
        Me.cboQRStatus = New System.Windows.Forms.ComboBox()

        Me.dgvStudents = New System.Windows.Forms.DataGridView()

        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQRStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()

        '==================================================
        ' QR PREVIEW
        '==================================================
        Me.pnlPreview = New System.Windows.Forms.Panel()
        Me.pnlPreviewHeader = New System.Windows.Forms.Panel()
        Me.lblPreviewTitle = New System.Windows.Forms.Label()

        Me.picQRCode = New System.Windows.Forms.PictureBox()

        Me.lblStudentNameCaption = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()

        Me.lblStudentIDCaption = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()

        Me.lblYearCourseCaption = New System.Windows.Forms.Label()
        Me.lblYearCourse = New System.Windows.Forms.Label()

        Me.lblQRStatusCaption = New System.Windows.Forms.Label()
        Me.lblQRStatus = New System.Windows.Forms.Label()

        Me.btnGenerateQR = New System.Windows.Forms.Button()
        Me.btnDownloadQR = New System.Windows.Forms.Button()

        '==================================================
        ' SUMMARY
        '==================================================
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblSummaryTitle = New System.Windows.Forms.Label()

        Me.pnlTotalStudents = New System.Windows.Forms.Panel()
        Me.lblTotalStudentsTitle = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()

        Me.pnlGenerated = New System.Windows.Forms.Panel()
        Me.lblGeneratedTitle = New System.Windows.Forms.Label()
        Me.lblGeneratedCount = New System.Windows.Forms.Label()

        Me.pnlNotGenerated = New System.Windows.Forms.Panel()
        Me.lblNotGeneratedTitle = New System.Windows.Forms.Label()
        Me.lblNotGeneratedCount = New System.Windows.Forms.Label()

        Me.btnGenerateMissing = New System.Windows.Forms.Button()

        Me.timerClock = New System.Windows.Forms.Timer(Me.components)


        '==================================================
        ' SUSPEND
        '==================================================
        Me.pnlHeader.SuspendLayout()

        Me.pnlStudents.SuspendLayout()
        Me.pnlStudentsHeader.SuspendLayout()

        CType(Me.dgvStudents,
            System.ComponentModel.ISupportInitialize).BeginInit()

        Me.pnlPreview.SuspendLayout()
        Me.pnlPreviewHeader.SuspendLayout()

        CType(Me.picQRCode,
            System.ComponentModel.ISupportInitialize).BeginInit()

        Me.pnlSummary.SuspendLayout()

        Me.pnlTotalStudents.SuspendLayout()
        Me.pnlGenerated.SuspendLayout()
        Me.pnlNotGenerated.SuspendLayout()

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
            New System.Drawing.Size(400, 44)

        Me.lblTitle.TabIndex = 0

        Me.lblTitle.Text =
            "QR Code Management"


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
            "Generate and manage student QR codes"


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
            "Friday, October 23, 2026   |   06:52:11 PM"

        Me.lblDateTime.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


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
        Me.pnlStudents.Controls.Add(Me.cboQRStatus)
        Me.pnlStudents.Controls.Add(Me.lblQRStatusFilter)
        Me.pnlStudents.Controls.Add(Me.txtSearch)
        Me.pnlStudents.Controls.Add(Me.lblSearchStudent)
        Me.pnlStudents.Controls.Add(Me.pnlStudentsHeader)

        Me.pnlStudents.Location =
            New System.Drawing.Point(15, 100)

        Me.pnlStudents.Name =
            "pnlStudents"

        Me.pnlStudents.Size =
            New System.Drawing.Size(940, 545)

        Me.pnlStudents.TabIndex = 1


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
            New System.Drawing.Size(938, 38)

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
            New System.Drawing.Point(17, 52)

        Me.lblSearchStudent.Name =
            "lblSearchStudent"

        Me.lblSearchStudent.Size =
            New System.Drawing.Size(107, 20)

        Me.lblSearchStudent.TabIndex = 1

        Me.lblSearchStudent.Text =
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
            New System.Drawing.Size(670, 27)

        Me.txtSearch.TabIndex = 2


        '==================================================
        ' lblQRStatusFilter
        '==================================================
        Me.lblQRStatusFilter.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.lblQRStatusFilter.AutoSize = True

        Me.lblQRStatusFilter.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQRStatusFilter.Location =
            New System.Drawing.Point(713, 52)

        Me.lblQRStatusFilter.Name =
            "lblQRStatusFilter"

        Me.lblQRStatusFilter.Size =
            New System.Drawing.Size(75, 20)

        Me.lblQRStatusFilter.TabIndex = 3

        Me.lblQRStatusFilter.Text =
            "QR Status"


        '==================================================
        ' cboQRStatus
        '==================================================
        Me.cboQRStatus.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.cboQRStatus.DropDownStyle =
            System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.cboQRStatus.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.cboQRStatus.FormattingEnabled =
            True

        Me.cboQRStatus.Items.AddRange(
            New Object() {
                "All",
                "Generated",
                "Not Generated"
            }
        )

        Me.cboQRStatus.Location =
            New System.Drawing.Point(713, 75)

        Me.cboQRStatus.Name =
            "cboQRStatus"

        Me.cboQRStatus.Size =
            New System.Drawing.Size(205, 28)

        Me.cboQRStatus.TabIndex = 4


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

        Me.dgvStudents.AutoGenerateColumns = False

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
                Me.colYearCourse,
                Me.colQRStatus
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
            New System.Drawing.Size(900, 400)

        Me.dgvStudents.TabIndex = 5


        '==================================================
        ' dgv HEADER
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
        ' dgv ROW
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
            "students_id"

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
            "students_name"

        Me.colStudentName.FillWeight =
            85.0!

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
        ' colQRStatus
        '==================================================
        Me.colQRStatus.DataPropertyName =
            "qr_status"

        Me.colQRStatus.FillWeight =
            55.0!

        Me.colQRStatus.HeaderText =
            "QR Status"

        Me.colQRStatus.Name =
            "colQRStatus"

        Me.colQRStatus.ReadOnly =
            True


        '==================================================
        ' pnlPreview
        '==================================================
        Me.pnlPreview.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Bottom Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.pnlPreview.BackColor =
            System.Drawing.Color.FromArgb(255, 253, 252)

        Me.pnlPreview.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.pnlPreview.Controls.Add(Me.btnDownloadQR)
        Me.pnlPreview.Controls.Add(Me.btnGenerateQR)

        Me.pnlPreview.Controls.Add(Me.lblQRStatus)
        Me.pnlPreview.Controls.Add(Me.lblQRStatusCaption)

        Me.pnlPreview.Controls.Add(Me.lblYearCourse)
        Me.pnlPreview.Controls.Add(Me.lblYearCourseCaption)

        Me.pnlPreview.Controls.Add(Me.lblStudentID)
        Me.pnlPreview.Controls.Add(Me.lblStudentIDCaption)

        Me.pnlPreview.Controls.Add(Me.lblStudentName)
        Me.pnlPreview.Controls.Add(Me.lblStudentNameCaption)

        Me.pnlPreview.Controls.Add(Me.picQRCode)
        Me.pnlPreview.Controls.Add(Me.pnlPreviewHeader)

        Me.pnlPreview.Location =
            New System.Drawing.Point(965, 100)

        Me.pnlPreview.Name =
            "pnlPreview"

        Me.pnlPreview.Size =
            New System.Drawing.Size(480, 545)

        Me.pnlPreview.TabIndex = 2


        '==================================================
        ' pnlPreviewHeader
        '==================================================
        Me.pnlPreviewHeader.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.pnlPreviewHeader.Controls.Add(
            Me.lblPreviewTitle
        )

        Me.pnlPreviewHeader.Dock =
            System.Windows.Forms.DockStyle.Top

        Me.pnlPreviewHeader.Location =
            New System.Drawing.Point(0, 0)

        Me.pnlPreviewHeader.Name =
            "pnlPreviewHeader"

        Me.pnlPreviewHeader.Size =
            New System.Drawing.Size(478, 38)

        Me.pnlPreviewHeader.TabIndex = 0


        '==================================================
        ' lblPreviewTitle
        '==================================================
        Me.lblPreviewTitle.AutoSize = True

        Me.lblPreviewTitle.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                11.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblPreviewTitle.ForeColor =
            System.Drawing.Color.White

        Me.lblPreviewTitle.Location =
            New System.Drawing.Point(15, 7)

        Me.lblPreviewTitle.Name =
            "lblPreviewTitle"

        Me.lblPreviewTitle.Size =
            New System.Drawing.Size(110, 25)

        Me.lblPreviewTitle.TabIndex = 0

        Me.lblPreviewTitle.Text =
            "QR Preview"


        '==================================================
        ' picQRCode
        '==================================================
        Me.picQRCode.BackColor =
            System.Drawing.Color.White

        Me.picQRCode.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.picQRCode.Location =
            New System.Drawing.Point(140, 65)

        Me.picQRCode.Name =
            "picQRCode"

        Me.picQRCode.Size =
            New System.Drawing.Size(200, 200)

        Me.picQRCode.SizeMode =
            System.Windows.Forms.PictureBoxSizeMode.Zoom

        Me.picQRCode.TabIndex = 1

        Me.picQRCode.TabStop =
            False


        '==================================================
        ' lblStudentNameCaption
        '==================================================
        Me.lblStudentNameCaption.AutoSize = True

        Me.lblStudentNameCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblStudentNameCaption.Location =
            New System.Drawing.Point(30, 290)

        Me.lblStudentNameCaption.Name =
            "lblStudentNameCaption"

        Me.lblStudentNameCaption.Size =
            New System.Drawing.Size(102, 20)

        Me.lblStudentNameCaption.TabIndex = 2

        Me.lblStudentNameCaption.Text =
            "Student Name"


        '==================================================
        ' lblStudentName
        '==================================================
        Me.lblStudentName.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.lblStudentName.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblStudentName.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblStudentName.Location =
            New System.Drawing.Point(30, 313)

        Me.lblStudentName.Name =
            "lblStudentName"

        Me.lblStudentName.Padding =
            New System.Windows.Forms.Padding(8, 0, 0, 0)

        Me.lblStudentName.Size =
            New System.Drawing.Size(418, 30)

        Me.lblStudentName.TabIndex = 3

        Me.lblStudentName.Text =
            "Select a student"

        Me.lblStudentName.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblStudentIDCaption
        '==================================================
        Me.lblStudentIDCaption.AutoSize = True

        Me.lblStudentIDCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblStudentIDCaption.Location =
            New System.Drawing.Point(30, 355)

        Me.lblStudentIDCaption.Name =
            "lblStudentIDCaption"

        Me.lblStudentIDCaption.Size =
            New System.Drawing.Size(79, 20)

        Me.lblStudentIDCaption.TabIndex = 4

        Me.lblStudentIDCaption.Text =
            "Student ID"


        '==================================================
        ' lblStudentID
        '==================================================
        Me.lblStudentID.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.lblStudentID.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblStudentID.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblStudentID.Location =
            New System.Drawing.Point(30, 378)

        Me.lblStudentID.Name =
            "lblStudentID"

        Me.lblStudentID.Padding =
            New System.Windows.Forms.Padding(8, 0, 0, 0)

        Me.lblStudentID.Size =
            New System.Drawing.Size(120, 30)

        Me.lblStudentID.TabIndex = 5

        Me.lblStudentID.Text =
            "-"

        Me.lblStudentID.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblYearCourseCaption
        '==================================================
        Me.lblYearCourseCaption.AutoSize = True

        Me.lblYearCourseCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblYearCourseCaption.Location =
            New System.Drawing.Point(165, 355)

        Me.lblYearCourseCaption.Name =
            "lblYearCourseCaption"

        Me.lblYearCourseCaption.Size =
            New System.Drawing.Size(104, 20)

        Me.lblYearCourseCaption.TabIndex = 6

        Me.lblYearCourseCaption.Text =
            "Year / Course"


        '==================================================
        ' lblYearCourse
        '==================================================
        Me.lblYearCourse.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.lblYearCourse.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblYearCourse.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblYearCourse.Location =
            New System.Drawing.Point(165, 378)

        Me.lblYearCourse.Name =
            "lblYearCourse"

        Me.lblYearCourse.Padding =
            New System.Windows.Forms.Padding(8, 0, 0, 0)

        Me.lblYearCourse.Size =
            New System.Drawing.Size(283, 30)

        Me.lblYearCourse.TabIndex = 7

        Me.lblYearCourse.Text =
            "-"

        Me.lblYearCourse.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' lblQRStatusCaption
        '==================================================
        Me.lblQRStatusCaption.AutoSize = True

        Me.lblQRStatusCaption.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                8.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQRStatusCaption.Location =
            New System.Drawing.Point(30, 420)

        Me.lblQRStatusCaption.Name =
            "lblQRStatusCaption"

        Me.lblQRStatusCaption.Size =
            New System.Drawing.Size(72, 20)

        Me.lblQRStatusCaption.TabIndex = 8

        Me.lblQRStatusCaption.Text =
            "QR Status"


        '==================================================
        ' lblQRStatus
        '==================================================
        Me.lblQRStatus.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.lblQRStatus.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblQRStatus.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblQRStatus.Location =
            New System.Drawing.Point(30, 443)

        Me.lblQRStatus.Name =
            "lblQRStatus"

        Me.lblQRStatus.Padding =
            New System.Windows.Forms.Padding(8, 0, 0, 0)

        Me.lblQRStatus.Size =
            New System.Drawing.Size(418, 30)

        Me.lblQRStatus.TabIndex = 9

        Me.lblQRStatus.Text =
            "-"

        Me.lblQRStatus.TextAlign =
            System.Drawing.ContentAlignment.MiddleLeft


        '==================================================
        ' btnGenerateQR
        '==================================================
        Me.btnGenerateQR.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.btnGenerateQR.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnGenerateQR.FlatAppearance.BorderSize =
            0

        Me.btnGenerateQR.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnGenerateQR.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnGenerateQR.ForeColor =
            System.Drawing.Color.White

        Me.btnGenerateQR.Location =
            New System.Drawing.Point(30, 490)

        Me.btnGenerateQR.Name =
            "btnGenerateQR"

        Me.btnGenerateQR.Size =
            New System.Drawing.Size(260, 40)

        Me.btnGenerateQR.TabIndex = 10

        Me.btnGenerateQR.Text =
            "Generate QR Code"

        Me.btnGenerateQR.UseVisualStyleBackColor =
            False


        '==================================================
        ' btnDownloadQR
        '==================================================
        Me.btnDownloadQR.BackColor =
            System.Drawing.Color.FromArgb(242, 230, 220)

        Me.btnDownloadQR.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnDownloadQR.Enabled =
            False

        Me.btnDownloadQR.FlatAppearance.BorderColor =
            System.Drawing.Color.FromArgb(205, 183, 167)

        Me.btnDownloadQR.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnDownloadQR.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnDownloadQR.ForeColor =
            System.Drawing.Color.FromArgb(75, 41, 24)

        Me.btnDownloadQR.Location =
            New System.Drawing.Point(300, 490)

        Me.btnDownloadQR.Name =
            "btnDownloadQR"

        Me.btnDownloadQR.Size =
            New System.Drawing.Size(148, 40)

        Me.btnDownloadQR.TabIndex = 11

        Me.btnDownloadQR.Text =
            "Download"

        Me.btnDownloadQR.UseVisualStyleBackColor =
            False


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

        Me.pnlSummary.Controls.Add(Me.btnGenerateMissing)

        Me.pnlSummary.Controls.Add(Me.pnlNotGenerated)
        Me.pnlSummary.Controls.Add(Me.pnlGenerated)
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
            New System.Drawing.Size(280, 52)

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
            New System.Drawing.Point(12, 15)

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
            New System.Drawing.Point(210, 7)

        Me.lblTotalStudents.Name =
            "lblTotalStudents"

        Me.lblTotalStudents.Size =
            New System.Drawing.Size(55, 35)

        Me.lblTotalStudents.TabIndex = 1

        Me.lblTotalStudents.Text =
            "0"

        Me.lblTotalStudents.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' pnlGenerated
        '==================================================
        Me.pnlGenerated.BackColor =
            System.Drawing.Color.FromArgb(226, 242, 230)

        Me.pnlGenerated.Controls.Add(Me.lblGeneratedCount)
        Me.pnlGenerated.Controls.Add(Me.lblGeneratedTitle)

        Me.pnlGenerated.Location =
            New System.Drawing.Point(320, 40)

        Me.pnlGenerated.Name =
            "pnlGenerated"

        Me.pnlGenerated.Size =
            New System.Drawing.Size(280, 52)

        Me.pnlGenerated.TabIndex = 2


        '==================================================
        ' lblGeneratedTitle
        '==================================================
        Me.lblGeneratedTitle.AutoSize = True

        Me.lblGeneratedTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblGeneratedTitle.Location =
            New System.Drawing.Point(12, 15)

        Me.lblGeneratedTitle.Name =
            "lblGeneratedTitle"

        Me.lblGeneratedTitle.Size =
            New System.Drawing.Size(78, 20)

        Me.lblGeneratedTitle.TabIndex = 0

        Me.lblGeneratedTitle.Text =
            "Generated"


        '==================================================
        ' lblGeneratedCount
        '==================================================
        Me.lblGeneratedCount.Font =
            New System.Drawing.Font(
                "Segoe UI",
                15.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblGeneratedCount.ForeColor =
            System.Drawing.Color.FromArgb(40, 100, 60)

        Me.lblGeneratedCount.Location =
            New System.Drawing.Point(210, 7)

        Me.lblGeneratedCount.Name =
            "lblGeneratedCount"

        Me.lblGeneratedCount.Size =
            New System.Drawing.Size(55, 35)

        Me.lblGeneratedCount.TabIndex = 1

        Me.lblGeneratedCount.Text =
            "0"

        Me.lblGeneratedCount.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' pnlNotGenerated
        '==================================================
        Me.pnlNotGenerated.BackColor =
            System.Drawing.Color.FromArgb(248, 224, 220)

        Me.pnlNotGenerated.Controls.Add(Me.lblNotGeneratedCount)
        Me.pnlNotGenerated.Controls.Add(Me.lblNotGeneratedTitle)

        Me.pnlNotGenerated.Location =
            New System.Drawing.Point(625, 40)

        Me.pnlNotGenerated.Name =
            "pnlNotGenerated"

        Me.pnlNotGenerated.Size =
            New System.Drawing.Size(280, 52)

        Me.pnlNotGenerated.TabIndex = 3


        '==================================================
        ' lblNotGeneratedTitle
        '==================================================
        Me.lblNotGeneratedTitle.AutoSize = True

        Me.lblNotGeneratedTitle.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.lblNotGeneratedTitle.Location =
            New System.Drawing.Point(12, 15)

        Me.lblNotGeneratedTitle.Name =
            "lblNotGeneratedTitle"

        Me.lblNotGeneratedTitle.Size =
            New System.Drawing.Size(107, 20)

        Me.lblNotGeneratedTitle.TabIndex = 0

        Me.lblNotGeneratedTitle.Text =
            "Not Generated"


        '==================================================
        ' lblNotGeneratedCount
        '==================================================
        Me.lblNotGeneratedCount.Font =
            New System.Drawing.Font(
                "Segoe UI",
                15.0!,
                System.Drawing.FontStyle.Bold
            )

        Me.lblNotGeneratedCount.ForeColor =
            System.Drawing.Color.FromArgb(170, 45, 45)

        Me.lblNotGeneratedCount.Location =
            New System.Drawing.Point(210, 7)

        Me.lblNotGeneratedCount.Name =
            "lblNotGeneratedCount"

        Me.lblNotGeneratedCount.Size =
            New System.Drawing.Size(55, 35)

        Me.lblNotGeneratedCount.TabIndex = 1

        Me.lblNotGeneratedCount.Text =
            "0"

        Me.lblNotGeneratedCount.TextAlign =
            System.Drawing.ContentAlignment.MiddleRight


        '==================================================
        ' btnGenerateMissing
        '==================================================
        Me.btnGenerateMissing.Anchor =
            CType(
                System.Windows.Forms.AnchorStyles.Top Or
                System.Windows.Forms.AnchorStyles.Right,
                System.Windows.Forms.AnchorStyles
            )

        Me.btnGenerateMissing.BackColor =
            System.Drawing.Color.FromArgb(103, 60, 36)

        Me.btnGenerateMissing.Cursor =
            System.Windows.Forms.Cursors.Hand

        Me.btnGenerateMissing.FlatAppearance.BorderSize =
            0

        Me.btnGenerateMissing.FlatStyle =
            System.Windows.Forms.FlatStyle.Flat

        Me.btnGenerateMissing.Font =
            New System.Drawing.Font(
                "Segoe UI Semibold",
                9.5!,
                System.Drawing.FontStyle.Bold
            )

        Me.btnGenerateMissing.ForeColor =
            System.Drawing.Color.White

        Me.btnGenerateMissing.Location =
            New System.Drawing.Point(1100, 40)

        Me.btnGenerateMissing.Name =
            "btnGenerateMissing"

        Me.btnGenerateMissing.Size =
            New System.Drawing.Size(305, 52)

        Me.btnGenerateMissing.TabIndex = 4

        Me.btnGenerateMissing.Text =
            "Generate All Missing QR Codes"

        Me.btnGenerateMissing.UseVisualStyleBackColor =
            False


        '==================================================
        ' timerClock
        '==================================================
        Me.timerClock.Interval =
            1000


        '==================================================
        ' QrCodeGenerate
        '==================================================
        Me.AutoScaleDimensions =
            New System.Drawing.SizeF(8.0!, 20.0!)

        Me.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font

        Me.BackColor =
            System.Drawing.Color.FromArgb(247, 241, 236)

        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlPreview)
        Me.Controls.Add(Me.pnlStudents)
        Me.Controls.Add(Me.pnlHeader)

        Me.Font =
            New System.Drawing.Font(
                "Segoe UI",
                9.0!
            )

        Me.Name =
            "QrCodeGenerate"

        Me.Size =
            New System.Drawing.Size(1460, 780)


        '==================================================
        ' RESUME
        '==================================================
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()

        Me.pnlStudentsHeader.ResumeLayout(False)
        Me.pnlStudentsHeader.PerformLayout()

        CType(
            Me.dgvStudents,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlStudents.ResumeLayout(False)
        Me.pnlStudents.PerformLayout()

        Me.pnlPreviewHeader.ResumeLayout(False)
        Me.pnlPreviewHeader.PerformLayout()

        CType(
            Me.picQRCode,
            System.ComponentModel.ISupportInitialize
        ).EndInit()

        Me.pnlPreview.ResumeLayout(False)
        Me.pnlPreview.PerformLayout()

        Me.pnlTotalStudents.ResumeLayout(False)
        Me.pnlTotalStudents.PerformLayout()

        Me.pnlGenerated.ResumeLayout(False)
        Me.pnlGenerated.PerformLayout()

        Me.pnlNotGenerated.ResumeLayout(False)
        Me.pnlNotGenerated.PerformLayout()

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

    Friend WithEvents pnlStudents As Panel
    Friend WithEvents pnlStudentsHeader As Panel
    Friend WithEvents lblStudentsTitle As Label

    Friend WithEvents lblSearchStudent As Label
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents lblQRStatusFilter As Label
    Friend WithEvents cboQRStatus As ComboBox

    Friend WithEvents dgvStudents As DataGridView

    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colYearCourse As DataGridViewTextBoxColumn
    Friend WithEvents colQRStatus As DataGridViewTextBoxColumn

    Friend WithEvents pnlPreview As Panel
    Friend WithEvents pnlPreviewHeader As Panel
    Friend WithEvents lblPreviewTitle As Label

    Friend WithEvents picQRCode As PictureBox

    Friend WithEvents lblStudentNameCaption As Label
    Friend WithEvents lblStudentName As Label

    Friend WithEvents lblStudentIDCaption As Label
    Friend WithEvents lblStudentID As Label

    Friend WithEvents lblYearCourseCaption As Label
    Friend WithEvents lblYearCourse As Label

    Friend WithEvents lblQRStatusCaption As Label
    Friend WithEvents lblQRStatus As Label

    Friend WithEvents btnGenerateQR As Button
    Friend WithEvents btnDownloadQR As Button

    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label

    Friend WithEvents pnlTotalStudents As Panel
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents lblTotalStudents As Label

    Friend WithEvents pnlGenerated As Panel
    Friend WithEvents lblGeneratedTitle As Label
    Friend WithEvents lblGeneratedCount As Label

    Friend WithEvents pnlNotGenerated As Panel
    Friend WithEvents lblNotGeneratedTitle As Label
    Friend WithEvents lblNotGeneratedCount As Label

    Friend WithEvents btnGenerateMissing As Button

    Friend WithEvents timerClock As Timer

End Class