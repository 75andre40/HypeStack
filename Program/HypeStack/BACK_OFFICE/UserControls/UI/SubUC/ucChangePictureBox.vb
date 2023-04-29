Public Class ucChangePictureBox

    Public Property TextInput As String
        Get
            Return lblText.Text
        End Get
        Set(value As String)
            lblText.Text = value
        End Set
    End Property

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

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles lblText.Click
        InvokeOnClick(Me, e)
    End Sub
End Class
