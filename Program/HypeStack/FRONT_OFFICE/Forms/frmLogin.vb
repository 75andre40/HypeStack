Public Class frmLogin

    'Mover a janela

    Dim Draggable As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer

    Private Sub DragMouseDown(sender As Object, e As MouseEventArgs) Handles pDragForm.MouseDown, lblFormName.MouseDown
        Draggable = True
        MouseX = Cursor.Position.X - Me.Left
        MouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub DragMouseMove(sender As Object, e As MouseEventArgs) Handles pDragForm.MouseMove, lblFormName.MouseMove
        If Draggable Then
            Me.Top = Cursor.Position.Y - MouseY
            Me.Left = Cursor.Position.X - MouseX
        End If
    End Sub
    Private Sub DragMouseUp(sender As Object, e As MouseEventArgs) Handles pDragForm.MouseUp, lblFormName.MouseUp
        Draggable = False
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Corners(Me)
    End Sub

    Private Sub Close_Form_Button(sender As Object, e As EventArgs) Handles picCloseForm.Click
        End
    End Sub

    Private Sub Minimize_Form_Button(sender As Object, e As EventArgs) Handles picMinimizeForm.Click
        For Form_Opacity As Single = 1.0! To 0 Step -0.2!
            Me.Opacity = Form_Opacity
            System.Threading.Thread.Sleep(15)
        Next

        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 1.0
    End Sub

    Private Sub FailedLoginTick(sender As Object, e As EventArgs) Handles tmrLoginFailed.Tick
        lblLoginFailed.Visible = False
    End Sub

    Private Sub txtPassword_Load(sender As Object, e As EventArgs) Handles txtPassword.Load

    End Sub
End Class