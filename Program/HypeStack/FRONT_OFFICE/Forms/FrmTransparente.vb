Public Class FrmTransparente
    Private Sub FrmTransparente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = frmUI.Location
        Me.ShowInTaskbar = False
    End Sub
End Class