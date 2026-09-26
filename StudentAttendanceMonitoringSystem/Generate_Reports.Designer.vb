<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generate_Reports
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
        Panel5 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel6 = New Panel()
        btnReset = New Button()
        btnApplyFilter = New Button()
        cboCourse = New ComboBox()
        dtpTo = New DateTimePicker()
        dtpFrom = New DateTimePicker()
        txtSearch = New TextBox()
        Panel3 = New Panel()
        Panel9 = New Panel()
        btnGeneratePDF = New Button()
        btnGenerateExcel = New Button()
        lblNoTimeOut = New Label()
        lblComplete = New Label()
        lblTotalRecords = New Label()
        Panel4 = New Panel()
        Panel7 = New Panel()
        dgvAttendance = New DataGridView()
        Panel8 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel4.SuspendLayout()
        Panel7.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel1.Controls.Add(Panel5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(15)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(1011, 100)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(Label1)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(10, 10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(991, 80)
        Panel5.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(249, 15)
        Label2.TabIndex = 1
        Label2.Text = "View and generate student attendance reports"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 15)
        Label1.TabIndex = 0
        Label1.Text = "Attendance Reports"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel2.Controls.Add(Panel6)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 100)
        Panel2.Margin = New Padding(10)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(15)
        Panel2.Size = New Size(1011, 100)
        Panel2.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(btnReset)
        Panel6.Controls.Add(btnApplyFilter)
        Panel6.Controls.Add(cboCourse)
        Panel6.Controls.Add(dtpTo)
        Panel6.Controls.Add(dtpFrom)
        Panel6.Controls.Add(txtSearch)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(15, 15)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(981, 70)
        Panel6.TabIndex = 0
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(882, 3)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 8
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnApplyFilter
        ' 
        btnApplyFilter.Location = New Point(882, 32)
        btnApplyFilter.Name = "btnApplyFilter"
        btnApplyFilter.Size = New Size(75, 23)
        btnApplyFilter.TabIndex = 7
        btnApplyFilter.Text = "Apply"
        btnApplyFilter.UseVisualStyleBackColor = True
        ' 
        ' cboCourse
        ' 
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(711, 20)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(121, 23)
        cboCourse.TabIndex = 6
        ' 
        ' dtpTo
        ' 
        dtpTo.Location = New Point(474, 24)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(200, 23)
        dtpTo.TabIndex = 5
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Location = New Point(218, 15)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(200, 23)
        dtpFrom.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(32, 29)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel3.Controls.Add(Panel9)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 530)
        Panel3.Margin = New Padding(10)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(15)
        Panel3.Size = New Size(1011, 100)
        Panel3.TabIndex = 2
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(btnGeneratePDF)
        Panel9.Controls.Add(btnGenerateExcel)
        Panel9.Controls.Add(lblNoTimeOut)
        Panel9.Controls.Add(lblComplete)
        Panel9.Controls.Add(lblTotalRecords)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(15, 15)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(981, 70)
        Panel9.TabIndex = 0
        ' 
        ' btnGeneratePDF
        ' 
        btnGeneratePDF.Location = New Point(677, 36)
        btnGeneratePDF.Name = "btnGeneratePDF"
        btnGeneratePDF.Size = New Size(75, 23)
        btnGeneratePDF.TabIndex = 4
        btnGeneratePDF.Text = "btnGeneratePDF"
        btnGeneratePDF.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateExcel
        ' 
        btnGenerateExcel.Location = New Point(527, 30)
        btnGenerateExcel.Name = "btnGenerateExcel"
        btnGenerateExcel.Size = New Size(75, 23)
        btnGenerateExcel.TabIndex = 3
        btnGenerateExcel.Text = "btnGenerateExcel"
        ' 
        ' lblNoTimeOut
        ' 
        lblNoTimeOut.AutoSize = True
        lblNoTimeOut.Location = New Point(369, 32)
        lblNoTimeOut.Name = "lblNoTimeOut"
        lblNoTimeOut.Size = New Size(83, 15)
        lblNoTimeOut.TabIndex = 2
        lblNoTimeOut.Text = "lblNoTimeOut"
        ' 
        ' lblComplete
        ' 
        lblComplete.AutoSize = True
        lblComplete.Location = New Point(217, 28)
        lblComplete.Name = "lblComplete"
        lblComplete.Size = New Size(72, 15)
        lblComplete.TabIndex = 1
        lblComplete.Text = "lblComplete"
        ' 
        ' lblTotalRecords
        ' 
        lblTotalRecords.AutoSize = True
        lblTotalRecords.Location = New Point(39, 30)
        lblTotalRecords.Name = "lblTotalRecords"
        lblTotalRecords.Size = New Size(88, 15)
        lblTotalRecords.TabIndex = 0
        lblTotalRecords.Text = "lblTotalRecords"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel4.Controls.Add(Panel7)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 200)
        Panel4.Margin = New Padding(10)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(15)
        Panel4.Size = New Size(1011, 330)
        Panel4.TabIndex = 3
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(dgvAttendance)
        Panel7.Controls.Add(Panel8)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(15, 15)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(981, 300)
        Panel7.TabIndex = 2
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Dock = DockStyle.Fill
        dgvAttendance.Location = New Point(0, 42)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.Size = New Size(981, 258)
        dgvAttendance.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Label4)
        Panel8.Controls.Add(Label3)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(981, 42)
        Panel8.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(708, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 1
        Label4.Text = "Total Students:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 0
        Label3.Text = "Attendance Records"
        ' 
        ' Generate_Reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Generate_Reports"
        Size = New Size(1011, 630)
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents lblTotalRecords As Label
    Friend WithEvents lblComplete As Label
    Friend WithEvents lblNoTimeOut As Label
    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents btnGenerateExcel As Button

End Class
