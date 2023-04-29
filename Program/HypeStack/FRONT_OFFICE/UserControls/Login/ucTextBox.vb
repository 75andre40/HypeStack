Public Class ucTextBox

    Public Property GrayText As String
        Get
            Return lblGreyText.Text
        End Get
        Set(value As String)
            lblGreyText.Text = value
        End Set
    End Property

    Public Property PasswordChar As Char
        Get
            Return txtContent.PasswordChar
        End Get
        Set(value As Char)
            txtContent.PasswordChar = value
        End Set
    End Property

    Public Property MaxTextLengh As Integer
        Get
            Return txtContent.MaxLength
        End Get
        Set(value As Integer)
            txtContent.MaxLength = value
        End Set
    End Property

    Private Sub CheckTextChanged(sender As Object, e As EventArgs) Handles txtContent.TextChanged
        If txtContent.Text <> "" Then
            lblGreyText.Visible = False
        Else
            lblGreyText.Visible = True
        End If
    End Sub

    Private Sub GreyText_Click(sender As Object, e As EventArgs) Handles lblGreyText.Click
        txtContent.Focus()
    End Sub

    Private Sub TextGotFocus(sender As Object, e As EventArgs) Handles txtContent.Enter
        Me.BackgroundImage = My.Resources.TextBoxBGSelected
    End Sub

    Private Sub TextLostFocus(sender As Object, e As EventArgs) Handles txtContent.Leave
        Me.BackgroundImage = My.Resources.TextBoxBG
    End Sub

    Private Sub CheckKey(sender As Object, e As KeyEventArgs) Handles txtContent.KeyDown
        If e.KeyCode = Keys.Enter Then
            ClsLogin.LogIn_Action()
        End If
    End Sub

End Class
