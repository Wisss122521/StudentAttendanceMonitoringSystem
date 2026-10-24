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

        components = New ComponentModel.Container()

        '==================================================
        ' HEADER
        '==================================================
        pnlHeader = New Panel()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()

        '==================================================
        ' STUDENT LIST
        '==================================================
        pnlStudents = New Panel()
        pnlStudentsHeader = New Panel()
        lblStudentsTitle = New Label()

        lblSearchStudent = New Label()
        txtSearch = New TextBox()

        lblQRStatusFilter = New Label()
        cboQRStatus = New ComboBox()

        dgvStudents = New DataGridView()

        colStudentID = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colYearCourse = New DataGridViewTextBoxColumn()
        colQRStatus = New DataGridViewTextBoxColumn()

        '==================================================
        ' QR PREVIEW
        '==================================================
        pnlPreview = New Panel()
        pnlPreviewHeader = New Panel()
        lblPreviewTitle = New Label()

        picQRCode = New PictureBox()

        lblStudentNameCaption = New Label()
        lblStudentName = New Label()

        lblStudentIDCaption = New Label()
        lblStudentID = New Label()

        lblYearCourseCaption = New Label()
        lblYearCourse = New Label()

        lblQRStatusCaption = New Label()
        lblQRStatus = New Label()

        btnGenerateQR = New Button()
        btnDownloadQR = New Button()

        '==================================================
        ' SUMMARY
        '==================================================
        pnlSummary = New Panel()
        lblSummaryTitle = New Label()

        pnlTotalStudents = New Panel()
        lblTotalStudentsTitle = New Label()
        lblTotalStudents = New Label()

        pnlGenerated = New Panel()
        lblGeneratedTitle = New Label()
        lblGeneratedCount = New Label()

        pnlNotGenerated = New Panel()
        lblNotGeneratedTitle = New Label()
        lblNotGeneratedCount = New Label()

        btnGenerateMissing = New Button()

        '==================================================
        ' TIMER
        '==================================================
        timerClock = New Timer(components)


        '==================================================
        ' SUSPEND LAYOUT
        '==================================================
        pnlHeader.SuspendLayout()

        pnlStudents.SuspendLayout()
        pnlStudentsHeader.SuspendLayout()

        CType(
            dgvStudents,
            ComponentModel.ISupportInitialize
        ).BeginInit()

        pnlPreview.SuspendLayout()
        pnlPreviewHeader.SuspendLayout()

        CType(
            picQRCode,
            ComponentModel.ISupportInitialize
        ).BeginInit()

        pnlSummary.SuspendLayout()

        pnlTotalStudents.SuspendLayout()
        pnlGenerated.SuspendLayout()
        pnlNotGenerated.SuspendLayout()

        SuspendLayout()


        '==================================================
        ' pnlHeader
        ' MASTER HEADER
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
            "Generate and manage student QR codes"


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
            "QR Code Management"


        '==================================================
        ' pnlStudents
        ' WIDE LEFT PANEL
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
        pnlStudents.Controls.Add(cboQRStatus)
        pnlStudents.Controls.Add(lblQRStatusFilter)
        pnlStudents.Controls.Add(txtSearch)
        pnlStudents.Controls.Add(lblSearchStudent)
        pnlStudents.Controls.Add(pnlStudentsHeader)

        pnlStudents.Location =
            New Point(18, 90)

        pnlStudents.Margin =
            New Padding(3, 2, 3, 2)

        pnlStudents.Name =
            "pnlStudents"

        pnlStudents.Size =
            New Size(665, 342)

        pnlStudents.TabIndex =
            1


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
        ' lblSearchStudent
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
            New Point(16, 50)

        lblSearchStudent.Name =
            "lblSearchStudent"

        lblSearchStudent.TabIndex =
            1

        lblSearchStudent.Text =
            "Search Student"


        '==================================================
        ' txtSearch
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
            New Size(425, 25)

        txtSearch.TabIndex =
            2


        '==================================================
        ' lblQRStatusFilter
        '==================================================
        lblQRStatusFilter.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblQRStatusFilter.AutoSize =
            True

        lblQRStatusFilter.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblQRStatusFilter.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblQRStatusFilter.Location =
            New Point(464, 50)

        lblQRStatusFilter.Name =
            "lblQRStatusFilter"

        lblQRStatusFilter.TabIndex =
            3

        lblQRStatusFilter.Text =
            "QR Status"


        '==================================================
        ' cboQRStatus
        '==================================================
        cboQRStatus.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        cboQRStatus.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboQRStatus.Font =
            New Font(
                "Segoe UI",
                10.0F
            )

        cboQRStatus.FormattingEnabled =
            True

        cboQRStatus.Items.AddRange(
            New Object() {
                "All",
                "Generated",
                "Not Generated"
            }
        )

        cboQRStatus.Location =
            New Point(464, 69)

        cboQRStatus.Margin =
            New Padding(3, 2, 3, 2)

        cboQRStatus.Name =
            "cboQRStatus"

        cboQRStatus.Size =
            New Size(180, 25)

        cboQRStatus.TabIndex =
            4


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

        dgvStudents.ColumnHeadersHeight =
            42

        dgvStudents.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        dgvStudents.Columns.AddRange(
            New DataGridViewColumn() {
                colStudentID,
                colStudentName,
                colYearCourse,
                colQRStatus
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
            5


        '==================================================
        ' STUDENT ID COLUMN
        '==================================================
        colStudentID.DataPropertyName =
            "students_id"

        colStudentID.FillWeight =
            35.0F

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
            "students_name"

        colStudentName.FillWeight =
            85.0F

        colStudentName.HeaderText =
            "Student Name"

        colStudentName.Name =
            "colStudentName"

        colStudentName.ReadOnly =
            True


        '==================================================
        ' YEAR / COURSE COLUMN
        '==================================================
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
        ' QR STATUS COLUMN
        '==================================================
        colQRStatus.DataPropertyName =
            "qr_status"

        colQRStatus.FillWeight =
            55.0F

        colQRStatus.HeaderText =
            "QR Status"

        colQRStatus.Name =
            "colQRStatus"

        colQRStatus.ReadOnly =
            True


        '==================================================
        ' pnlPreview
        ' RIGHT PANEL
        '==================================================
        pnlPreview.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Right

        pnlPreview.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlPreview.BorderStyle =
            BorderStyle.FixedSingle

        pnlPreview.Controls.Add(btnDownloadQR)
        pnlPreview.Controls.Add(btnGenerateQR)

        pnlPreview.Controls.Add(lblQRStatus)
        pnlPreview.Controls.Add(lblQRStatusCaption)

        pnlPreview.Controls.Add(lblYearCourse)
        pnlPreview.Controls.Add(lblYearCourseCaption)

        pnlPreview.Controls.Add(lblStudentID)
        pnlPreview.Controls.Add(lblStudentIDCaption)

        pnlPreview.Controls.Add(lblStudentName)
        pnlPreview.Controls.Add(lblStudentNameCaption)

        pnlPreview.Controls.Add(picQRCode)
        pnlPreview.Controls.Add(pnlPreviewHeader)

        pnlPreview.Location =
            New Point(695, 90)

        pnlPreview.Margin =
            New Padding(3, 2, 3, 2)

        pnlPreview.Name =
            "pnlPreview"

        pnlPreview.Size =
            New Size(320, 342)

        pnlPreview.TabIndex =
            2


        '==================================================
        ' pnlPreviewHeader
        '==================================================
        pnlPreviewHeader.BackColor =
            Color.FromArgb(97, 55, 31)

        pnlPreviewHeader.Controls.Add(
            lblPreviewTitle
        )

        pnlPreviewHeader.Dock =
            DockStyle.Top

        pnlPreviewHeader.Location =
            New Point(0, 0)

        pnlPreviewHeader.Name =
            "pnlPreviewHeader"

        pnlPreviewHeader.Size =
            New Size(318, 38)

        pnlPreviewHeader.TabIndex =
            0


        '==================================================
        ' lblPreviewTitle
        '==================================================
        lblPreviewTitle.AutoSize =
            True

        lblPreviewTitle.Font =
            New Font(
                "Segoe UI Semibold",
                12.0F,
                FontStyle.Bold
            )

        lblPreviewTitle.ForeColor =
            Color.White

        lblPreviewTitle.Location =
            New Point(14, 8)

        lblPreviewTitle.Name =
            "lblPreviewTitle"

        lblPreviewTitle.TabIndex =
            0

        lblPreviewTitle.Text =
            "QR Preview"


        '==================================================
        ' picQRCode
        '==================================================
        picQRCode.BackColor =
            Color.White

        picQRCode.BorderStyle =
            BorderStyle.FixedSingle

        picQRCode.Location =
            New Point(104, 48)

        picQRCode.Name =
            "picQRCode"

        picQRCode.Size =
            New Size(110, 110)

        picQRCode.SizeMode =
            PictureBoxSizeMode.Zoom

        picQRCode.TabIndex =
            1

        picQRCode.TabStop =
            False


        '==================================================
        ' STUDENT NAME
        '==================================================
        lblStudentNameCaption.AutoSize =
            True

        lblStudentNameCaption.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblStudentNameCaption.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblStudentNameCaption.Location =
            New Point(19, 164)

        lblStudentNameCaption.Name =
            "lblStudentNameCaption"

        lblStudentNameCaption.Text =
            "Student Name"


        lblStudentName.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblStudentName.BackColor =
            Color.FromArgb(247, 241, 236)

        lblStudentName.BorderStyle =
            BorderStyle.FixedSingle

        lblStudentName.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        lblStudentName.Location =
            New Point(22, 181)

        lblStudentName.Name =
            "lblStudentName"

        lblStudentName.Padding =
            New Padding(6, 0, 0, 0)

        lblStudentName.Size =
            New Size(274, 24)

        lblStudentName.Text =
            "Select a student"

        lblStudentName.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' STUDENT ID
        '==================================================
        lblStudentIDCaption.AutoSize =
            True

        lblStudentIDCaption.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblStudentIDCaption.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblStudentIDCaption.Location =
            New Point(19, 208)

        lblStudentIDCaption.Name =
            "lblStudentIDCaption"

        lblStudentIDCaption.Text =
            "Student ID"


        lblStudentID.BackColor =
            Color.FromArgb(247, 241, 236)

        lblStudentID.BorderStyle =
            BorderStyle.FixedSingle

        lblStudentID.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        lblStudentID.Location =
            New Point(22, 225)

        lblStudentID.Name =
            "lblStudentID"

        lblStudentID.Padding =
            New Padding(6, 0, 0, 0)

        lblStudentID.Size =
            New Size(86, 24)

        lblStudentID.Text =
            "-"

        lblStudentID.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' YEAR / COURSE
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
            New Point(116, 208)

        lblYearCourseCaption.Name =
            "lblYearCourseCaption"

        lblYearCourseCaption.Text =
            "Year / Course"


        lblYearCourse.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblYearCourse.BackColor =
            Color.FromArgb(247, 241, 236)

        lblYearCourse.BorderStyle =
            BorderStyle.FixedSingle

        lblYearCourse.Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        lblYearCourse.Location =
            New Point(116, 225)

        lblYearCourse.Name =
            "lblYearCourse"

        lblYearCourse.Padding =
            New Padding(6, 0, 0, 0)

        lblYearCourse.Size =
            New Size(180, 24)

        lblYearCourse.Text =
            "-"

        lblYearCourse.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' QR STATUS
        '==================================================
        lblQRStatusCaption.AutoSize =
            True

        lblQRStatusCaption.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblQRStatusCaption.ForeColor =
            Color.FromArgb(59, 40, 31)

        lblQRStatusCaption.Location =
            New Point(19, 252)

        lblQRStatusCaption.Name =
            "lblQRStatusCaption"

        lblQRStatusCaption.Text =
            "QR Status"


        lblQRStatus.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblQRStatus.BackColor =
            Color.FromArgb(247, 241, 236)

        lblQRStatus.BorderStyle =
            BorderStyle.FixedSingle

        lblQRStatus.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        lblQRStatus.Location =
            New Point(22, 269)

        lblQRStatus.Name =
            "lblQRStatus"

        lblQRStatus.Padding =
            New Padding(6, 0, 0, 0)

        lblQRStatus.Size =
            New Size(274, 24)

        lblQRStatus.Text =
            "-"

        lblQRStatus.TextAlign =
            ContentAlignment.MiddleLeft


        '==================================================
        ' GENERATE QR
        '==================================================
        btnGenerateQR.BackColor =
            Color.FromArgb(103, 60, 36)

        btnGenerateQR.Cursor =
            Cursors.Hand

        btnGenerateQR.FlatAppearance.BorderSize =
            0

        btnGenerateQR.FlatStyle =
            FlatStyle.Flat

        btnGenerateQR.Font =
            New Font(
                "Segoe UI Semibold",
                9.5F,
                FontStyle.Bold
            )

        btnGenerateQR.ForeColor =
            Color.White

        btnGenerateQR.Location =
            New Point(22, 304)

        btnGenerateQR.Name =
            "btnGenerateQR"

        btnGenerateQR.Size =
            New Size(180, 26)

        btnGenerateQR.TabIndex =
            10

        btnGenerateQR.Text =
            "Generate QR Code"

        btnGenerateQR.UseVisualStyleBackColor =
            False


        '==================================================
        ' DOWNLOAD QR
        '==================================================
        btnDownloadQR.BackColor =
            Color.FromArgb(242, 230, 220)

        btnDownloadQR.Cursor =
            Cursors.Hand

        btnDownloadQR.Enabled =
            False

        btnDownloadQR.FlatAppearance.BorderColor =
            Color.FromArgb(205, 183, 167)

        btnDownloadQR.FlatStyle =
            FlatStyle.Flat

        btnDownloadQR.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        btnDownloadQR.ForeColor =
            Color.FromArgb(75, 41, 24)

        btnDownloadQR.Location =
            New Point(210, 304)

        btnDownloadQR.Name =
            "btnDownloadQR"

        btnDownloadQR.Size =
            New Size(86, 26)

        btnDownloadQR.TabIndex =
            11

        btnDownloadQR.Text =
            "Download"

        btnDownloadQR.UseVisualStyleBackColor =
            False


        '==================================================
        ' SUMMARY PANEL
        ' EXACT SAME MASTER POSITION
        '==================================================
        pnlSummary.Anchor =
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlSummary.BackColor =
            Color.FromArgb(255, 253, 252)

        pnlSummary.BorderStyle =
            BorderStyle.FixedSingle

        pnlSummary.Controls.Add(btnGenerateMissing)

        pnlSummary.Controls.Add(pnlNotGenerated)
        pnlSummary.Controls.Add(pnlGenerated)
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
        ' SUMMARY TITLE
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
        ' GENERATE ALL MISSING BUTTON
        '==================================================
        btnGenerateMissing.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        btnGenerateMissing.BackColor =
            Color.FromArgb(103, 60, 36)

        btnGenerateMissing.Cursor =
            Cursors.Hand

        btnGenerateMissing.FlatAppearance.BorderSize =
            0

        btnGenerateMissing.FlatStyle =
            FlatStyle.Flat

        btnGenerateMissing.Font =
            New Font(
                "Segoe UI Semibold",
                8.0F,
                FontStyle.Bold
            )

        btnGenerateMissing.ForeColor =
            Color.White

        btnGenerateMissing.Location =
            New Point(792, 4)

        btnGenerateMissing.Name =
            "btnGenerateMissing"

        btnGenerateMissing.Size =
            New Size(180, 22)

        btnGenerateMissing.TabIndex =
            4

        btnGenerateMissing.Text =
            "Generate All Missing QR"

        btnGenerateMissing.UseVisualStyleBackColor =
            False


        '==================================================
        ' TOTAL STUDENTS CARD
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
        ' GENERATED CARD
        '==================================================
        pnlGenerated.Anchor =
            AnchorStyles.Top

        pnlGenerated.BackColor =
            Color.FromArgb(226, 242, 230)

        pnlGenerated.Controls.Add(lblGeneratedCount)
        pnlGenerated.Controls.Add(lblGeneratedTitle)

        pnlGenerated.Location =
            New Point(346, 30)

        pnlGenerated.Margin =
            New Padding(3, 2, 3, 2)

        pnlGenerated.Name =
            "pnlGenerated"

        pnlGenerated.Size =
            New Size(302, 41)

        pnlGenerated.TabIndex =
            2


        lblGeneratedCount.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblGeneratedCount.Font =
            New Font(
                "Segoe UI",
                18.0F,
                FontStyle.Bold
            )

        lblGeneratedCount.ForeColor =
            Color.FromArgb(40, 100, 60)

        lblGeneratedCount.Location =
            New Point(219, 5)

        lblGeneratedCount.Name =
            "lblGeneratedCount"

        lblGeneratedCount.Size =
            New Size(66, 30)

        lblGeneratedCount.TabIndex =
            1

        lblGeneratedCount.Text =
            "0"

        lblGeneratedCount.TextAlign =
            ContentAlignment.MiddleRight


        lblGeneratedTitle.AutoSize =
            True

        lblGeneratedTitle.Font =
            New Font(
                "Segoe UI",
                9.5F
            )

        lblGeneratedTitle.Location =
            New Point(12, 6)

        lblGeneratedTitle.Name =
            "lblGeneratedTitle"

        lblGeneratedTitle.TabIndex =
            0

        lblGeneratedTitle.Text =
            "Generated"


        '==================================================
        ' NOT GENERATED CARD
        '==================================================
        pnlNotGenerated.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        pnlNotGenerated.BackColor =
            Color.FromArgb(248, 224, 220)

        pnlNotGenerated.Controls.Add(lblNotGeneratedCount)
        pnlNotGenerated.Controls.Add(lblNotGeneratedTitle)

        pnlNotGenerated.Location =
            New Point(674, 30)

        pnlNotGenerated.Margin =
            New Padding(3, 2, 3, 2)

        pnlNotGenerated.Name =
            "pnlNotGenerated"

        pnlNotGenerated.Size =
            New Size(302, 41)

        pnlNotGenerated.TabIndex =
            3


        lblNotGeneratedCount.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Right

        lblNotGeneratedCount.Font =
            New Font(
                "Segoe UI",
                18.0F,
                FontStyle.Bold
            )

        lblNotGeneratedCount.ForeColor =
            Color.FromArgb(170, 45, 45)

        lblNotGeneratedCount.Location =
            New Point(219, 5)

        lblNotGeneratedCount.Name =
            "lblNotGeneratedCount"

        lblNotGeneratedCount.Size =
            New Size(66, 30)

        lblNotGeneratedCount.TabIndex =
            1

        lblNotGeneratedCount.Text =
            "0"

        lblNotGeneratedCount.TextAlign =
            ContentAlignment.MiddleRight


        lblNotGeneratedTitle.AutoSize =
            True

        lblNotGeneratedTitle.Font =
            New Font(
                "Segoe UI",
                9.5F
            )

        lblNotGeneratedTitle.Location =
            New Point(12, 6)

        lblNotGeneratedTitle.Name =
            "lblNotGeneratedTitle"

        lblNotGeneratedTitle.TabIndex =
            0

        lblNotGeneratedTitle.Text =
            "Not Generated"


        '==================================================
        ' TIMER
        '==================================================
        timerClock.Interval =
            1000


        '==================================================
        ' UcQrCode
        ' MASTER USERCONTROL SIZE
        '==================================================
        AutoScaleDimensions =
            New SizeF(7.0F, 15.0F)

        AutoScaleMode =
            AutoScaleMode.Font

        BackColor =
            Color.FromArgb(247, 241, 236)

        Controls.Add(pnlSummary)
        Controls.Add(pnlPreview)
        Controls.Add(pnlStudents)
        Controls.Add(pnlHeader)

        Font =
            New Font(
                "Segoe UI",
                9.0F
            )

        Margin =
            New Padding(3, 2, 3, 2)

        Name =
            "UcQrCode"

        Size =
            New Size(1032, 540)


        '==================================================
        ' RESUME LAYOUT
        '==================================================
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()

        pnlStudentsHeader.ResumeLayout(False)
        pnlStudentsHeader.PerformLayout()

        CType(
            dgvStudents,
            ComponentModel.ISupportInitialize
        ).EndInit()

        pnlStudents.ResumeLayout(False)
        pnlStudents.PerformLayout()

        pnlPreviewHeader.ResumeLayout(False)
        pnlPreviewHeader.PerformLayout()

        CType(
            picQRCode,
            ComponentModel.ISupportInitialize
        ).EndInit()

        pnlPreview.ResumeLayout(False)
        pnlPreview.PerformLayout()

        pnlTotalStudents.ResumeLayout(False)
        pnlTotalStudents.PerformLayout()

        pnlGenerated.ResumeLayout(False)
        pnlGenerated.PerformLayout()

        pnlNotGenerated.ResumeLayout(False)
        pnlNotGenerated.PerformLayout()

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