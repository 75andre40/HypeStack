Public Class ucLongTextBoxWithLabel
    Public Property PlaceHolder As String
        Get
            Return lblText.Text
        End Get
        Set(value As String)
            lblText.Text = value
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
    Public Property TextInput As String
        Get
            Return txtContent.Text
        End Get
        Set(value As String)
            txtContent.Text = value
        End Set
    End Property

    Public Property ReadOnlyInput As Boolean
        Get
            Return txtContent.ReadOnly
        End Get
        Set(value As Boolean)
            If value Then
                txtContent.Appearance.ForeColor = Color.FromArgb(255, 80, 80, 80)
            Else
                txtContent.Appearance.ForeColor = Color.Black
            End If
            txtContent.ReadOnly = value
        End Set
    End Property
End Class
