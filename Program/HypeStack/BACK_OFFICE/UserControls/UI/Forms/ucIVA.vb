Imports System.Runtime.Remoting.Contexts
Imports Infragistics.Win.Misc
Public Class ucIVA

    Private Lista_IVA As New List(Of ClsIVA)

    Private WithEvents UP_DOWN As New NumericUpDown

    Private Sub Load_UC(sender As Object, e As EventArgs) Handles MyBase.Load
        Up_Down_Entidade.Value = 0
        LoadAllEntities()
        UP_DOWN.Minimum = 1
        UP_DOWN.Value = 1
    End Sub

    Private Sub RefreshCounter(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub LoadAllEntities()
        Lista_IVA.Clear()
        Lista_IVA = ClsIVA.GetIVA()
        UP_DOWN.Maximum = Lista_IVA.Count
        UP_DOWN.Value = 1
        LoadCurrentEntity()
    End Sub

    Private Sub LoadCurrentEntity()

        ucIVA_Cod.TextInput = Lista_IVA(UP_DOWN.Value - 1).Cod_IVA
        ucIVA_Designacao.TextInput = Lista_IVA(UP_DOWN.Value - 1).Designacao
        ucIVA_Taxa.TextInput = Lista_IVA(UP_DOWN.Value - 1).Taxa_IVA
        ucIVA_Tipo.TextInput = Lista_IVA(UP_DOWN.Value - 1).Tipo_IVA


        lblCounter.Text = "A mostrar IVA " & UP_DOWN.Value & " de " & Lista_IVA.Count

    End Sub

    Private Sub UP_DOWN_ValueChanged(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub ReadOnlyAll(x As Boolean)
        'ucIVA_Cod.ReadOnlyInput = x
        ucIVA_Designacao.ReadOnlyInput = x
        ucIVA_Taxa.ReadOnlyInput = x
        ucIVA_Tipo.ReadOnlyInput = x
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

            Dim Message As MsgBoxStyle = MsgBox("Deseja guardar este IVA?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                Dim IVAAtual As Clsiva = Lista_IVA(UP_DOWN.Value - 1)


                With IVAAtual
                    .Designacao = ucIVA_Designacao.txtContent.Text
                    .Taxa_IVA = ucIVA_Taxa.txtContent.Text
                    .Tipo_IVA = ucIVA_Tipo.txtContent.Text
                    .Cod_IVA = ucIVA_Cod.txtContent.Text
                End With




                If Adding = True Then

                    IVAAtual.Cod_IVA = ClsIVA.GetNovoCodigo

                    ClsIVA.GravaIVA(IVAAtual)

                    LoadAllEntities()

                    UP_DOWN.Value = UP_DOWN.Maximum

                    udaInfo.Text = "IVA adicionado com sucesso!"
                    Adding = False
                    lblCounter.Visible = True
                Else
                    ClsIVA.ModificaIVA(IVAAtual)
                    Dim Value As Integer = UP_DOWN.Value
                    LoadAllEntities()
                    UP_DOWN.Value = Value
                    LoadCurrentEntity()

                    udaInfo.Text = "IVA editado com sucesso!"
                End If

                ReadOnlyAll(True)

                udaSaved.Show(udaInfo)
            End If
        Else

            ReadOnlyAll(False)
            Adding = True
            lblCounter.Visible = False

            ucIVA_Cod.txtContent.Text = "Código Automático"
            ucIVA_Designacao.txtContent.Clear()
            ucIVA_Taxa.txtContent.Clear()
            ucIVA_Tipo.txtContent.Clear()

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
                Adding = False
                lblCounter.Visible = True


            End If

        Else

            Dim Message As MsgBoxStyle = MsgBox("Deseja eliminar este IVA?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                ClsIVA.ApagaIVA(ucIVA_Cod.txtContent.Value)

                Lista_IVA.Clear()
                Lista_IVA = ClsIVA.GetIVA()
                UP_DOWN.Maximum = Lista_IVA.Count

                LoadCurrentEntity()

                udaInfo.Text = "IVA eliminado com sucesso!"
                udaSaved.Show(udaInfo)

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
