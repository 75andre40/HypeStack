Public Class ucMenuButton

    Public Property TextInput As String
        Get
            Return lblText.Text
        End Get
        Set(value As String)
            lblText.Text = value
        End Set
    End Property

    Public Property ButtonIcon As Image
        Get
            Return picImage.Image
        End Get
        Set(value As Image)
            picImage.Image = value
        End Set
    End Property

    Public Property Purpose As Integer
        Get
            Return pActive.Tag
        End Get
        Set(value As Integer)
            pActive.Tag = value
        End Set
    End Property

    Public Property ColorActive As Color
        Get
            Return pActive.BackColor
        End Get
        Set(value As Color)
            pActive.BackColor = value
        End Set
    End Property

    Public Property Active As Boolean
        Get
            Return ActiveV
        End Get
        Set(value As Boolean)
            ActiveV = value
            If value Then
                ColorActive = Color.Orange
                lblText.Width = 199
                lblText.Location = New Point(16, 0)
                Me.Size = New Size(218, 45)
            Else
                ColorActive = Color.White
                lblText.Width = 205
                lblText.Location = New Point(10, 0)
                Me.Size = New Size(218, 45)
            End If
        End Set
    End Property

    Public ActiveV As Boolean = False


    Private Sub ButtonMouseEnter(sender As Object, e As EventArgs) Handles lblText.MouseEnter, picImage.MouseEnter, pActive.MouseEnter
        Me.BackgroundImage = My.Resources.ButtonSideMenuHover
    End Sub

    Private Sub ButtonMouseLeave(sender As Object, e As EventArgs) Handles lblText.MouseLeave, picImage.MouseLeave, pActive.MouseLeave
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub ButtonMouseDown(sender As Object, e As MouseEventArgs) Handles lblText.MouseDown, picImage.MouseDown, pActive.MouseDown
        Me.BackgroundImage = My.Resources.ButtonSideMenuClick
    End Sub

    Private Sub ButtonMouseUp(sender As Object, e As MouseEventArgs) Handles lblText.MouseUp, picImage.MouseUp, pActive.MouseUp
        Me.BackgroundImage = My.Resources.ButtonSideMenuHover
    End Sub

    Private Sub Click_Action(sender As Object, e As EventArgs) Handles lblText.Click, pActive.Click, picImage.Click
        Dim Message As MsgBoxStyle = vbOK

        If Editing = True Then
            Message = MsgBox("Quaisquer mudanças efetuadas não guardadas irão ser perdidas." & vbCrLf & "Continuar?", MsgBoxStyle.OkCancel, "HypeStack")
        End If
        If Message = vbOK Then


            frmUI.pContent.Controls.Clear()
            Editing = False
            Adding = False
            MinStockFilter = False

            Dim ActiveControl As Control
            frmUI.ActiveChangerButtons(False)
            Select Case pActive.Tag
                Case 0 'Admin
                    TempUCBefore = frmUI.btnAdministracao
                    ActiveControl = New ucFormChooser
                    frmUI.pContent.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                    frmUI.btnAdministracao.Active = True
                Case 1 'Geral
                    TempUCBefore = frmUI.btnGeral
                    ActiveControl = New ucFormChooser
                    frmUI.pContent.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                    frmUI.btnGeral.Active = True
                Case 2 'Artigos
                    TempUCBefore = frmUI.btnArtigos
                    ActiveControl = New ucFormChooser
                    frmUI.pContent.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                    frmUI.btnArtigos.Active = True
                Case 3 'Outros
                    TempUCBefore = frmUI.btnOutros
                    ActiveControl = New ucFormChooser
                    frmUI.pContent.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                    frmUI.btnOutros.Active = True
            End Select


        End If
    End Sub
End Class
