Imports System.Threading

Public Class frmLoginProgressBar

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblBemVindo.Text = "Bem-vindo, " & ClsEntidadeAtual.Nome & "!"
        ClsUtils.Corners(Me)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Close()
    End Sub
End Class