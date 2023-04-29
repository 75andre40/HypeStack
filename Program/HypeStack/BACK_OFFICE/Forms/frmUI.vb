Public Class frmUI
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Me.Closing
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tmrDate.Start()

        lblPersonName.Text = ClsEntidadeAtual.Nome

    End Sub

    Private Sub TimerDate(sender As Object, e As EventArgs) Handles tmrDate.Tick
        lblWatch.Text = Format(Date.Now, "HH:mm:ss")
        lblDate.Text = Format(Date.Now, "dd/MM/yyyy")
    End Sub

    Public Shared Sub ActiveChangerButtons(ByVal x As Boolean)
        With frmUI
            .btnAdministracao.Active = x
            .btnGeral.Active = x
            .btnArtigos.Active = x
            .btnOutros.Active = x
        End With
    End Sub
End Class