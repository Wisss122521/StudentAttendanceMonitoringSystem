Public Class AdminForm
    Private Sub AdminForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    'Private Sub lblQRCode_Click(sender As Object, e As EventArgs) Handles lblQRCode.Click

    '    pnlContent.Controls.Clear()

    '    Dim qrPage As New QrCodeGenerate()

    '    qrPage.Dock = DockStyle.Fill

    '    pnlContent.Controls.Add(qrPage)

    'End Subasdsadsadsad

    Private Sub LoadUserControl(uc As UserControl)

        pnlContent.Controls.Clear()

        uc.Dock = DockStyle.Fill

        pnlContent.Controls.Add(uc)

    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadUserControl(New QrCodeGenerate())
    End Sub
End Class