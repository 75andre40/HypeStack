Imports System.Runtime.Remoting.Contexts
Imports Infragistics.Win.Misc
Public Class ucPasswords

    Private Lista_Entidades As New List(Of ClsEntidades)

    Private WithEvents UP_DOWN As New NumericUpDown

    Private Sub Load_UC(sender As Object, e As EventArgs) Handles MyBase.Load
        Up_Down_Entidade.Value = 0
        LoadAllEntities()
        UP_DOWN.Minimum = 1
        UP_DOWN.Value = 1
        btnDelCancel.Visible = False
        btnAddSave.Visible = False
    End Sub

    Private Sub RefreshCounter(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub LoadAllEntities()
        Lista_Entidades.Clear()
        Lista_Entidades = ClsEntidades.GetEntidadesByTipo("A")
        UP_DOWN.Maximum = Lista_Entidades.Count
        UP_DOWN.Value = 1
        LoadCurrentEntity()
    End Sub

    Private Sub LoadCurrentEntity()

        ucPasswords_Cod.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Cod_Entidade
        ucPasswords_Nome.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Nome
        ucPasswords_Senha.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Password


        lblCounter.Text = "A mostrar entidade " & UP_DOWN.Value & " de " & Lista_Entidades.Count

    End Sub

    Private Sub UP_DOWN_ValueChanged(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub ReadOnlyAll(x As Boolean)
        ucPasswords_Nome.ReadOnlyInput = x
        ucPasswords_Senha.ReadOnlyInput = x
        EditingVisuals(x)
    End Sub

    Private Sub FirstList(sender As Object, e As EventArgs) Handles btnFirst.Click
        UP_DOWN.Value = UP_DOWN.Minimum
    End Sub
    Private Sub BackList(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            UP_DOWN.Value -= 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub NextList(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            UP_DOWN.Value += 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LastList(sender As Object, e As EventArgs) Handles btnLast.Click
        UP_DOWN.Value = UP_DOWN.Maximum
    End Sub

    Private Sub EditingVisuals(x As Boolean)

        btnFirst.Visible = x
        btnLast.Visible = x
        btnNext.Visible = x
        btnBack.Visible = x
        btnEditar.Visible = x
        btnAddSave.Visible = Not x
        btnDelCancel.Visible = Not x


        If x Then
            btnAddSave.picImage.Image = My.Resources.AddDocumentIcon
            btnDelCancel.picImage.Image = My.Resources.DeleteIcon
        Else
            btnAddSave.picImage.Image = My.Resources.DisqueteIcon
            btnDelCancel.picImage.Image = My.Resources.CancelIcon
        End If
        Editing = Not x
    End Sub

    Private Sub EditarEntidade(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Not Editing Then

            ReadOnlyAll(False)

        End If
    End Sub

    Private Sub AddSave(sender As Object, e As EventArgs) Handles btnAddSave.Click
        Dim udaInfo As New UltraDesktopAlertShowWindowInfo
        udaInfo.ScreenPosition = ScreenPosition.BottomLeft

        udaInfo.Caption = "HypeStack"
        udaInfo.Image = My.Resources.CheckIcon

        If Editing Then

            Dim Message As MsgBoxStyle = MsgBox("Deseja guardar esta entidade?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                Dim EntidadeAtual As ClsEntidades = Lista_Entidades(UP_DOWN.Value - 1)


                With EntidadeAtual
                    .Cod_Entidade = ucPasswords_Cod.txtContent.Text
                    .Password = ucPasswords_Senha.txtContent.Text
                End With

                ClsEntidades.ModificaEntidadesPassword(EntidadeAtual)
                Dim Value As Integer = UP_DOWN.Value
                LoadAllEntities()
                UP_DOWN.Value = Value
                LoadCurrentEntity()

                udaInfo.Text = "Entidade editada com sucesso!"

                ReadOnlyAll(True)

                udaSaved.Show(udaInfo)
            End If
        End If

    End Sub



    Private Sub DelCancel(sender As Object, e As EventArgs) Handles btnDelCancel.Click
        Dim udaInfo As New UltraDesktopAlertShowWindowInfo
        udaInfo.Caption = "HypeStack"
        udaInfo.Image = My.Resources.CheckIcon
        udaInfo.ScreenPosition = ScreenPosition.BottomLeft

        If Editing Then
            Dim Message As MsgBoxStyle = MsgBox("Deseja cancelar as modificações?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                LoadCurrentEntity()
                ReadOnlyAll(True)
                lblCounter.Visible = True


            End If

        End If

    End Sub

    Private Sub LeftClick(sender As Object, e As EventArgs)
        If Not Up_Down_Entidade.Value = 0 Then
            Up_Down_Entidade.Value -= 1
            LoadAllEntities()
        End If
    End Sub

    Private Sub RightClick(sender As Object, e As EventArgs)
        If Not Up_Down_Entidade.Value = Up_Down_Entidade.Maximum Then
            Up_Down_Entidade.Value += 1
            LoadAllEntities()
        End If
    End Sub

    Private Sub VisiblesNavBar(x As Boolean)
        btnDelCancel.Visible = x
        btnAddSave.Visible = x
        btnEditar.Visible = x
        btnFirst.Visible = x
        btnLast.Visible = x
        btnBack.Visible = x
        btnNext.Visible = x
    End Sub
End Class
