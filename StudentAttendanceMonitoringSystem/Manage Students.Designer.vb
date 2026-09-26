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
        Panel1 = New Panel()
        Panel4 = New Panel()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel3 = New Panel()
        Panel6 = New Panel()
        lblNotification = New Label()
        lblSubtitle = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel4.Controls.Add(lblSubtitle)
        Panel4.Controls.Add(lblNotification)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(10, 10)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(942, 80)
        Panel4.TabIndex = 0
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
        Panel2.Size = New Size(962, 100)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(10, 10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(942, 80)
        Panel5.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(240))
        Panel3.Controls.Add(Panel6)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 200)
        Panel3.Margin = New Padding(15)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10)
        Panel3.Size = New Size(962, 476)
        Panel3.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(10, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(942, 456)
        Panel6.TabIndex = 0
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
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Location = New Point(19, 42)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(284, 15)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Send manual SMS notifications to parents/guardians"
        ' 
        ' Manage_Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Manage_Students"
        Size = New Size(962, 676)
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
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

End Class
