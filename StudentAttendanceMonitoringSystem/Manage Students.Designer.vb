<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Students
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
        Status = New DataGridViewTextBoxColumn()
        Qr_Code_Data = New DataGridViewTextBoxColumn()
        Parent_Contact = New DataGridViewTextBoxColumn()
        Classes = New DataGridViewTextBoxColumn()
        Sex = New DataGridViewTextBoxColumn()
        Student_Name = New DataGridViewTextBoxColumn()
        Student_Id = New DataGridViewTextBoxColumn()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox6 = New TextBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Status
        ' 
        Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Status.HeaderText = "Status"
        Status.Name = "Status"
        ' 
        ' Qr_Code_Data
        ' 
        Qr_Code_Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Qr_Code_Data.HeaderText = "Qr_Code_Data"
        Qr_Code_Data.Name = "Qr_Code_Data"
        ' 
        ' Parent_Contact
        ' 
        Parent_Contact.HeaderText = "Parent_Contact"
        Parent_Contact.Name = "Parent_Contact"
        ' 
        ' Classes
        ' 
        Classes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Classes.HeaderText = "Class"
        Classes.Name = "Classes"
        ' 
        ' Sex
        ' 
        Sex.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Sex.HeaderText = "Sex"
        Sex.Name = "Sex"
        ' 
        ' Student_Name
        ' 
        Student_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Student_Name.HeaderText = "Student_Name"
        Student_Name.Name = "Student_Name"
        ' 
        ' Student_Id
        ' 
        Student_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Student_Id.HeaderText = "Student_Id"
        Student_Id.Name = "Student_Id"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Student_Id, Student_Name, Sex, Classes, Parent_Contact, Qr_Code_Data, Status})
        DataGridView1.Location = New Point(0, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(965, 445)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(962, 40)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.search
        PictureBox1.Location = New Point(931, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 27)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Right
        TextBox1.Location = New Point(797, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(128, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(745, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 0
        Label2.Text = "SEARCH:"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(ComboBox2)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 40)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(962, 169)
        Panel3.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top
        Button4.Location = New Point(543, 114)
        Button4.Name = "Button4"
        Button4.Size = New Size(101, 23)
        Button4.TabIndex = 15
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top
        Button3.Location = New Point(543, 85)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 23)
        Button3.TabIndex = 14
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.Location = New Point(543, 56)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 23)
        Button2.TabIndex = 13
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.Location = New Point(543, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 23)
        Button1.TabIndex = 12
        Button1.Text = "IMPORT CSV"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(368, 96)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(141, 23)
        ComboBox2.TabIndex = 11
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(368, 38)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(141, 23)
        ComboBox1.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TextBox6.Location = New Point(368, 125)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(141, 23)
        TextBox6.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TextBox4.Location = New Point(368, 67)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(141, 23)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TextBox2.Location = New Point(368, 10)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(141, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(228, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 25)
        Label7.TabIndex = 4
        Label7.Text = "QR Code Data:"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(303, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 25)
        Label6.TabIndex = 3
        Label6.Text = "Class:"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(243, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 21)
        Label5.TabIndex = 2
        Label5.Text = "Parent Number:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(317, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 25)
        Label4.TabIndex = 1
        Label4.Text = "Sex:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(269, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 25)
        Label3.TabIndex = 0
        Label3.Text = "Fullname:"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(DataGridView1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 209)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(962, 467)
        Panel4.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 1
        Label1.Text = "TOTAL STUDENTS"
        ' 
        ' Manage_Students
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Name = "Manage_Students"
        Size = New Size(962, 676)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Qr_Code_Data As DataGridViewTextBoxColumn
    Friend WithEvents Parent_Contact As DataGridViewTextBoxColumn
    Friend WithEvents Classes As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents Student_Name As DataGridViewTextBoxColumn
    Friend WithEvents Student_Id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label

End Class
