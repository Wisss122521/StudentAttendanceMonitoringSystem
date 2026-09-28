<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SmsNotification
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel4 = New Panel()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        lblNotification = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel8 = New Panel()
        lblSelectedStudent = New Label()
        btnClearMessage = New Button()
        btnSendSMS = New Button()
        lblCharacterCount = New Label()
        txtMessage = New RichTextBox()
        lblMessageTitle = New Label()
        lblContactNumber = New Label()
        lblContactTitle = New Label()
        lblYearCourse = New Label()
        lblYearCourseTitle = New Label()
        lblSelectedStudentTitle = New Label()
        lblSendSMSTitle = New Label()
        Panel7 = New Panel()
        dgvStudents = New DataGridView()
        txtSearchStudent = New TextBox()
        lblStudentListTitle = New Label()
        Panel3 = New Panel()
        Panel6 = New Panel()
        dgvSMSLogs = New DataGridView()
        lblLogsTitle = New Label()
        colStudentName = New DataGridViewTextBoxColumn()
        colContact = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colMessage = New DataGridViewTextBoxColumn()
        colSentAt = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        CType(dgvSMSLogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(15)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(962, 100)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(lblDateTime)
        Panel4.Controls.Add(lblSubtitle)
        Panel4.Controls.Add(lblNotification)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(10, 10)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(942, 80)
        Panel4.TabIndex = 0
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Location = New Point(607, 33)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(70, 15)
        lblDateTime.TabIndex = 11
        lblDateTime.Text = "lblDateTime"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Location = New Point(19, 42)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(284, 15)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Send manual SMS notifications to parents/guardians"
        ' 
        ' lblNotification
        ' 
        lblNotification.AutoSize = True
        lblNotification.Location = New Point(16, 12)
        lblNotification.Name = "lblNotification"
        lblNotification.Size = New Size(70, 15)
        lblNotification.TabIndex = 0
        lblNotification.Text = "Notification"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel2.Controls.Add(Panel5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 100)
        Panel2.Margin = New Padding(15)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(962, 249)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Panel8)
        Panel5.Controls.Add(Panel7)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(10, 10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(942, 229)
        Panel5.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(lblSelectedStudent)
        Panel8.Controls.Add(btnClearMessage)
        Panel8.Controls.Add(btnSendSMS)
        Panel8.Controls.Add(lblCharacterCount)
        Panel8.Controls.Add(txtMessage)
        Panel8.Controls.Add(lblMessageTitle)
        Panel8.Controls.Add(lblContactNumber)
        Panel8.Controls.Add(lblContactTitle)
        Panel8.Controls.Add(lblYearCourse)
        Panel8.Controls.Add(lblYearCourseTitle)
        Panel8.Controls.Add(lblSelectedStudentTitle)
        Panel8.Controls.Add(lblSendSMSTitle)
        Panel8.Dock = DockStyle.Right
        Panel8.Location = New Point(471, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(471, 229)
        Panel8.TabIndex = 1
        ' 
        ' lblSelectedStudent
        ' 
        lblSelectedStudent.AutoSize = True
        lblSelectedStudent.Location = New Point(32, 58)
        lblSelectedStudent.Name = "lblSelectedStudent"
        lblSelectedStudent.Size = New Size(105, 15)
        lblSelectedStudent.TabIndex = 11
        lblSelectedStudent.Text = "lblSelectedStudent"
        ' 
        ' btnClearMessage
        ' 
        btnClearMessage.Location = New Point(286, 189)
        btnClearMessage.Name = "btnClearMessage"
        btnClearMessage.Size = New Size(75, 23)
        btnClearMessage.TabIndex = 10
        btnClearMessage.Text = "btnClearMessage"
        btnClearMessage.UseVisualStyleBackColor = True
        ' 
        ' btnSendSMS
        ' 
        btnSendSMS.Location = New Point(185, 183)
        btnSendSMS.Name = "btnSendSMS"
        btnSendSMS.Size = New Size(75, 23)
        btnSendSMS.TabIndex = 9
        btnSendSMS.Text = "Send sMS"
        btnSendSMS.UseVisualStyleBackColor = True
        ' 
        ' lblCharacterCount
        ' 
        lblCharacterCount.AutoSize = True
        lblCharacterCount.Location = New Point(190, 158)
        lblCharacterCount.Name = "lblCharacterCount"
        lblCharacterCount.Size = New Size(104, 15)
        lblCharacterCount.TabIndex = 8
        lblCharacterCount.Text = "lblCharacterCount"
        ' 
        ' txtMessage
        ' 
        txtMessage.Location = New Point(195, 52)
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(100, 96)
        txtMessage.TabIndex = 7
        txtMessage.Text = ""
        ' 
        ' lblMessageTitle
        ' 
        lblMessageTitle.AutoSize = True
        lblMessageTitle.Location = New Point(195, 25)
        lblMessageTitle.Name = "lblMessageTitle"
        lblMessageTitle.Size = New Size(88, 15)
        lblMessageTitle.TabIndex = 6
        lblMessageTitle.Text = "lblMessageTitle"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Location = New Point(31, 146)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(106, 15)
        lblContactNumber.TabIndex = 5
        lblContactNumber.Text = "lblContactNumber"
        ' 
        ' lblContactTitle
        ' 
        lblContactTitle.AutoSize = True
        lblContactTitle.Location = New Point(29, 121)
        lblContactTitle.Name = "lblContactTitle"
        lblContactTitle.Size = New Size(84, 15)
        lblContactTitle.TabIndex = 4
        lblContactTitle.Text = "lblContactTitle"
        ' 
        ' lblYearCourse
        ' 
        lblYearCourse.AutoSize = True
        lblYearCourse.Location = New Point(34, 103)
        lblYearCourse.Name = "lblYearCourse"
        lblYearCourse.Size = New Size(79, 15)
        lblYearCourse.TabIndex = 3
        lblYearCourse.Text = "lblYearCourse"
        ' 
        ' lblYearCourseTitle
        ' 
        lblYearCourseTitle.AutoSize = True
        lblYearCourseTitle.Location = New Point(29, 80)
        lblYearCourseTitle.Name = "lblYearCourseTitle"
        lblYearCourseTitle.Size = New Size(101, 15)
        lblYearCourseTitle.TabIndex = 2
        lblYearCourseTitle.Text = "lblYearCourseTitle"
        ' 
        ' lblSelectedStudentTitle
        ' 
        lblSelectedStudentTitle.AutoSize = True
        lblSelectedStudentTitle.Location = New Point(29, 32)
        lblSelectedStudentTitle.Name = "lblSelectedStudentTitle"
        lblSelectedStudentTitle.Size = New Size(127, 15)
        lblSelectedStudentTitle.TabIndex = 1
        lblSelectedStudentTitle.Text = "lblSelectedStudentTitle"
        ' 
        ' lblSendSMSTitle
        ' 
        lblSendSMSTitle.AutoSize = True
        lblSendSMSTitle.Location = New Point(22, 8)
        lblSendSMSTitle.Name = "lblSendSMSTitle"
        lblSendSMSTitle.Size = New Size(99, 15)
        lblSendSMSTitle.TabIndex = 0
        lblSendSMSTitle.Text = "Send Notification"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(dgvStudents)
        Panel7.Controls.Add(txtSearchStudent)
        Panel7.Controls.Add(lblStudentListTitle)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(465, 229)
        Panel7.TabIndex = 0
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(16, 52)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(407, 150)
        dgvStudents.TabIndex = 2
        ' 
        ' txtSearchStudent
        ' 
        txtSearchStudent.Location = New Point(91, 13)
        txtSearchStudent.Name = "txtSearchStudent"
        txtSearchStudent.Size = New Size(100, 23)
        txtSearchStudent.TabIndex = 1
        ' 
        ' lblStudentListTitle
        ' 
        lblStudentListTitle.AutoSize = True
        lblStudentListTitle.Location = New Point(16, 16)
        lblStudentListTitle.Name = "lblStudentListTitle"
        lblStudentListTitle.Size = New Size(69, 15)
        lblStudentListTitle.TabIndex = 0
        lblStudentListTitle.Text = "Student List"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel3.Controls.Add(Panel6)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 349)
        Panel3.Margin = New Padding(15)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10)
        Panel3.Size = New Size(962, 327)
        Panel3.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(dgvSMSLogs)
        Panel6.Controls.Add(lblLogsTitle)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(10, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(942, 307)
        Panel6.TabIndex = 0
        ' 
        ' dgvSMSLogs
        ' 
        dgvSMSLogs.AllowUserToAddRows = False
        dgvSMSLogs.AllowUserToDeleteRows = False
        dgvSMSLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSMSLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSMSLogs.Columns.AddRange(New DataGridViewColumn() {colStudentName, colContact, colType, colMessage, colSentAt, colStatus})
        dgvSMSLogs.Location = New Point(19, 38)
        dgvSMSLogs.MultiSelect = False
        dgvSMSLogs.Name = "dgvSMSLogs"
        dgvSMSLogs.ReadOnly = True
        dgvSMSLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSMSLogs.Size = New Size(887, 251)
        dgvSMSLogs.TabIndex = 1
        ' 
        ' lblLogsTitle
        ' 
        lblLogsTitle.AutoSize = True
        lblLogsTitle.Location = New Point(20, 6)
        lblLogsTitle.Name = "lblLogsTitle"
        lblLogsTitle.Size = New Size(67, 15)
        lblLogsTitle.TabIndex = 0
        lblLogsTitle.Text = "lblLogsTitle"
        ' 
        ' colStudentName
        ' 
        colStudentName.DataPropertyName = "student_name"
        colStudentName.HeaderText = "Student Name"
        colStudentName.Name = "colStudentName"
        colStudentName.ReadOnly = True
        ' 
        ' colContact
        ' 
        colContact.DataPropertyName = "contact_number"
        colContact.HeaderText = "Contact Number"
        colContact.Name = "colContact"
        colContact.ReadOnly = True
        ' 
        ' colType
        ' 
        colType.DataPropertyName = "sms_type"
        colType.HeaderText = "Type"
        colType.Name = "colType"
        colType.ReadOnly = True
        ' 
        ' colMessage
        ' 
        colMessage.DataPropertyName = "message"
        colMessage.HeaderText = "Message"
        colMessage.Name = "colMessage"
        colMessage.ReadOnly = True
        ' 
        ' colSentAt
        ' 
        colSentAt.DataPropertyName = "sent_at"
        colSentAt.HeaderText = "Date / Time"
        colSentAt.Name = "colSentAt"
        colSentAt.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.DataPropertyName = "status"
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' SmsNotification
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "SmsNotification"
        Size = New Size(962, 676)
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(dgvSMSLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblNotification As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents txtSearchStudent As TextBox
    Friend WithEvents lblStudentListTitle As Label
    Friend WithEvents btnClearMessage As Button
    Friend WithEvents btnSendSMS As Button
    Friend WithEvents lblCharacterCount As Label
    Friend WithEvents txtMessage As RichTextBox
    Friend WithEvents lblMessageTitle As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblContactTitle As Label
    Friend WithEvents lblYearCourse As Label
    Friend WithEvents lblYearCourseTitle As Label
    Friend WithEvents lblSelectedStudentTitle As Label
    Friend WithEvents lblSendSMSTitle As Label
    Friend WithEvents dgvSMSLogs As DataGridView
    Friend WithEvents lblLogsTitle As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblSelectedStudent As Label
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colContact As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colMessage As DataGridViewTextBoxColumn
    Friend WithEvents colSentAt As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn

End Class
