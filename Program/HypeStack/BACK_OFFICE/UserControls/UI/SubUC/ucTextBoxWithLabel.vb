Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ucTextBoxWithLabel

    Public Event TextChangedCustom As EventHandler(Of TextChangedEventArgs)

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

    Public Property ValueRightToLeft As Infragistics.Win.HAlign
        Get
            Return txtContent.Appearance.TextHAlign
        End Get
        Set(value As Infragistics.Win.HAlign)
            txtContent.Appearance.TextHAlign = value
        End Set
    End Property

    Private Sub Text_LostFocus(sender As Object, e As EventArgs) Handles txtContent.Leave
        If Me.Tag = "Price" Then
            Dim Validate As Boolean = False
            For Each price As Char In txtContent.Text
                If price = "€" Then
                    Validate = True
                End If
            Next

            If Validate = False Then txtContent.Text += "€"
        End If
    End Sub

    Private Sub Text_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtContent.KeyPress
        Dim ContainsComma As Integer = 0

        Dim strPrice As String = txtContent.Text

        For Each charsPrice As Char In strPrice
            If charsPrice = "," Then
                ContainsComma += 1
            End If
        Next

        If Me.Tag = "Price" Then

            If Asc(e.KeyChar) <> 8 Then

                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 OrElse Asc(e.KeyChar) = 44 Then

                    If Asc(e.KeyChar) = 44 And ContainsComma = 0 Then
                        Exit Sub
                    End If

                    e.Handled = True
                End If

            End If
        End If

    End Sub
    Private Sub txtContent_TextChanged(sender As Object, e As EventArgs) Handles txtContent.TextChanged
        Dim args As New TextChangedEventArgs(txtContent.Text)
        RaiseEvent TextChangedCustom(Me, args)
    End Sub
End Class
