<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        txtStudentName = New TextBox()
        cboCourse = New ComboBox()
        cboYearLevel = New ComboBox()
        txtParentContact = New TextBox()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        txtSearch = New TextBox()
        cboFilterYear = New ComboBox()
        cboFilterCourse = New ComboBox()
        btnImportStudents = New Button()
        dgvStudents = New DataGridView()
        lblTotalStudents = New Label()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1026, 100)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1026, 100)
        Panel2.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel3, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel4, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 100)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1026, 565)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnClear)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(txtParentContact)
        Panel3.Controls.Add(cboYearLevel)
        Panel3.Controls.Add(cboCourse)
        Panel3.Controls.Add(txtStudentName)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(507, 559)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(lblTotalStudents)
        Panel4.Controls.Add(dgvStudents)
        Panel4.Controls.Add(btnImportStudents)
        Panel4.Controls.Add(cboFilterCourse)
        Panel4.Controls.Add(cboFilterYear)
        Panel4.Controls.Add(txtSearch)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(516, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(507, 559)
        Panel4.TabIndex = 1
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Location = New Point(57, 63)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(100, 23)
        txtStudentName.TabIndex = 0
        ' 
        ' cboCourse
        ' 
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(55, 97)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(121, 23)
        cboCourse.TabIndex = 1
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Location = New Point(53, 135)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(121, 23)
        cboYearLevel.TabIndex = 2
        ' 
        ' txtParentContact
        ' 
        txtParentContact.Location = New Point(54, 173)
        txtParentContact.Name = "txtParentContact"
        txtParentContact.Size = New Size(100, 23)
        txtParentContact.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(48, 236)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 4
        btnSave.Text = "btnSave"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(58, 277)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "btnUpdate"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(52, 320)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 6
        btnDelete.Text = "btnDelete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(51, 365)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 7
        btnClear.Text = "btnClear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(61, 59)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 0
        ' 
        ' cboFilterYear
        ' 
        cboFilterYear.FormattingEnabled = True
        cboFilterYear.Location = New Point(58, 121)
        cboFilterYear.Name = "cboFilterYear"
        cboFilterYear.Size = New Size(121, 23)
        cboFilterYear.TabIndex = 1
        ' 
        ' cboFilterCourse
        ' 
        cboFilterCourse.FormattingEnabled = True
        cboFilterCourse.Location = New Point(69, 168)
        cboFilterCourse.Name = "cboFilterCourse"
        cboFilterCourse.Size = New Size(121, 23)
        cboFilterCourse.TabIndex = 2
        ' 
        ' btnImportStudents
        ' 
        btnImportStudents.Location = New Point(78, 243)
        btnImportStudents.Name = "btnImportStudents"
        btnImportStudents.Size = New Size(75, 23)
        btnImportStudents.TabIndex = 3
        btnImportStudents.Text = "IMport"
        btnImportStudents.UseVisualStyleBackColor = True
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(67, 306)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.Size = New Size(240, 150)
        dgvStudents.TabIndex = 4
        ' 
        ' lblTotalStudents
        ' 
        lblTotalStudents.AutoSize = True
        lblTotalStudents.Location = New Point(270, 484)
        lblTotalStudents.Name = "lblTotalStudents"
        lblTotalStudents.Size = New Size(91, 15)
        lblTotalStudents.TabIndex = 5
        lblTotalStudents.Text = "lblTotalStudents"
        ' 
        ' ManageStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        Name = "ManageStudent"
        Size = New Size(1026, 665)
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtParentContact As TextBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents btnImportStudents As Button
    Friend WithEvents cboFilterCourse As ComboBox
    Friend WithEvents cboFilterYear As ComboBox
    Friend WithEvents txtSearch As TextBox

End Class
