Imports System.ComponentModel
Public Class ucTextBoxUPDOWN

    Implements INotifyPropertyChanged

    Public Event ValueChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent ValueChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub


    Public Property aUnits As String
        Get
            Return lblUnits.Text
        End Get
        Set(value As String)
            lblUnits.Text = value
        End Set
    End Property

    Public Property aPlaceHolder As String
        Get
            Return lblText.Text
        End Get
        Set(value As String)
            lblText.Text = value
        End Set
    End Property

    Private WithEvents UP_DOWN As New NumericUpDown

    Public Property aNumericActualValue As Integer
        Get
            Return UP_DOWN.Value
        End Get
        Set(value As Integer)
            If value >= UP_DOWN.Minimum And value <= UP_DOWN.Maximum Then
                UP_DOWN.Value = value
            End If
        End Set
    End Property

    Public Property aNumericMinimumValue As Integer
        Get
            Return UP_DOWN.Minimum
        End Get
        Set(value As Integer)
            UP_DOWN.Minimum = value
        End Set
    End Property

    Public Property aNumericMaximumValue As Integer
        Get
            Return UP_DOWN.Maximum
        End Get
        Set(value As Integer)
            UP_DOWN.Maximum = value
        End Set
    End Property

    Public Property aReadOnlyInput As Boolean
        Get
            Return txtContent.ReadOnly
        End Get
        Set(value As Boolean)
            txtContent.ReadOnly = value
            picArrowUp.Visible = Not value
            picArrowDown.Visible = Not value
            If value Then
                lblUnits.ForeColor = Color.FromArgb(255, 80, 80, 80)
                txtContent.Appearance.ForeColor = Color.FromArgb(255, 80, 80, 80)
            Else
                txtContent.Appearance.ForeColor = Color.Black
                lblUnits.ForeColor = Color.Black

                If UP_DOWN.Value = UP_DOWN.Minimum Then
                    picArrowDown.Visible = False
                End If
                If UP_DOWN.Value = UP_DOWN.Maximum Then
                    picArrowUp.Visible = False
                End If

            End If
        End Set
    End Property

    Dim TextChangedValidator As Boolean = False

    Private Sub Up_Click(sender As Object, e As EventArgs) Handles picArrowUp.Click
        If Not UP_DOWN.Value >= UP_DOWN.Maximum And txtContent.ReadOnly = False Then
            UP_DOWN.Value += 1
        End If
    End Sub

    Private Sub Down_Click(sender As Object, e As EventArgs) Handles picArrowDown.Click
        If Not UP_DOWN.Value <= UP_DOWN.Minimum And txtContent.ReadOnly = False Then
            UP_DOWN.Value -= 1
        End If
    End Sub

    Private Sub UP_DOWN_Changed(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        If aReadOnlyInput = False Then

            If UP_DOWN.Value = UP_DOWN.Minimum Then
                picArrowDown.Visible = False
            Else
                picArrowDown.Visible = True
            End If

            If UP_DOWN.Value = UP_DOWN.Maximum Then
                picArrowUp.Visible = False
            Else
                picArrowUp.Visible = True
            End If

        End If

        txtContent.Text = CStr(UP_DOWN.Value)
        aNumericActualValue = UP_DOWN.Value

        OnPropertyChanged("aNumericActualValue")

    End Sub

    Private Sub Text_Changed(sender As Object, e As EventArgs)
        If TextChangedValidator = True Then
            Exit Sub
        End If
    End Sub

    Private Sub ucTextBoxUPDOWN_Load(sender As Object, e As EventArgs) Handles Me.Load
        UP_DOWN.Value = UP_DOWN.Maximum
        UP_DOWN.Value = UP_DOWN.Minimum
    End Sub
End Class
