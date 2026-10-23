<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        lblTime = New Label()
        lblStatus = New Label()
        lblStudentName = New Label()
        txtQrCode = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(lblTime)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(lblStudentName)
        Panel1.Controls.Add(txtQrCode)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(674, 458)
        Panel1.TabIndex = 0
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Location = New Point(114, 348)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(41, 15)
        lblTime.TabIndex = 3
        lblTime.Text = "Label1"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(234, 404)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(41, 15)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Label1"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Location = New Point(329, 404)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(41, 15)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "Label1"
        ' 
        ' txtQrCode
        ' 
        txtQrCode.Location = New Point(275, 345)
        txtQrCode.Name = "txtQrCode"
        txtQrCode.Size = New Size(317, 23)
        txtQrCode.TabIndex = 0
        txtQrCode.Text = "v"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "Dashboard"
        Size = New Size(674, 458)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtQrCode As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStudentName As Label

End Class
