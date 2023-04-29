Public Class ucSquareButton

    Public Property ImageInput As Image
        Get
            Return picImage.Image
        End Get
        Set(value As Image)
            picImage.Image = value
        End Set
    End Property

    Private Sub ImageClick(sender As Object, e As EventArgs) Handles picImage.Click
        InvokeOnClick(Me, e)
    End Sub
End Class
