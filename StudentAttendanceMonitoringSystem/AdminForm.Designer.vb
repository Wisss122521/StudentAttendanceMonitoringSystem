<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        PictureBox1 = New PictureBox()
        pnlContent = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources._6a4fef6f_e247_4671_bc82_cbd6ced86108
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 611)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 611)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ChatGPT_Image_Sep_11__2026__08_43_52_AM
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' pnlContent
        ' 
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(200, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(808, 611)
        pnlContent.TabIndex = 1
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(241), CByte(232))
        ClientSize = New Size(1008, 611)
        Controls.Add(pnlContent)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminForm"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "AdminForm"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlContent As Panel
End Class
