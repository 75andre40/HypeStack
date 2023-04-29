Public Class ucChangePicture
    Private Sub ButtonMouseEnter(sender As Object, e As EventArgs) Handles lblText.MouseEnter, Me.MouseEnter
        Me.BackgroundImage = My.Resources.ButtonSubmitHover
    End Sub

    Private Sub ButtonMouseLeave(sender As Object, e As EventArgs) Handles lblText.MouseLeave, Me.MouseLeave
        Me.BackgroundImage = My.Resources.ButtonSubmit
    End Sub

    Private Sub ButtonMouseDown(sender As Object, e As MouseEventArgs) Handles lblText.MouseDown, Me.MouseDown
        Me.BackgroundImage = My.Resources.ButtonSubmitClick
    End Sub

    Private Sub ButtonMouseUp(sender As Object, e As MouseEventArgs) Handles lblText.MouseUp, Me.MouseUp
        Me.BackgroundImage = My.Resources.ButtonSubmit
    End Sub

    Private Sub ClickAction(sender As Object, e As EventArgs) Handles lblText.Click, Me.Click
        ClsLogin.LogIn_Action()
    End Sub
End Class
