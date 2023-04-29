Imports System.Runtime.Remoting.Contexts
Imports Infragistics.Win.Misc
Public Class ucSubCategorias

    Private Lista_SubCategorias As New List(Of ClsSub_Categorias)

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
        Lista_SubCategorias.Clear()
        Lista_SubCategorias = ClsSub_Categorias.GetSub_Categorias
        UP_DOWN.Maximum = Lista_SubCategorias.Count
        UP_DOWN.Value = 1
        LoadCurrentEntity()
    End Sub

    Private Sub LoadCurrentEntity()

        ucSubCatg_Cod.TextInput = Lista_SubCategorias(UP_DOWN.Value - 1).Cod_Sub_Categoria
        ucSubCatg_Designacao.TextInput = Lista_SubCategorias(UP_DOWN.Value - 1).Designacao


        For x As Integer = 0 To ucSubCatg_CATG.cbContent.Rows.Count - 1
            If ucSubCatg_CATG.cbContent.Rows(x).Cells("Cod_Categoria").Text = Lista_SubCategorias(UP_DOWN.Value - 1).Cod_Categoria Then
                ucSubCatg_CATG.cbContent.SelectedRow = ucSubCatg_CATG.cbContent.Rows(x)
                Exit For
            End If
        Next


        lblCounter.Text = "A mostrar sub-categoria " & UP_DOWN.Value & " de " & Lista_SubCategorias.Count
        ucChangePicture.Tag = Lista_SubCategorias(UP_DOWN.Value - 1).Cod_Sub_Categoria

        Try
            picUser.BackgroundImage = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesSubCategoriasPath & ucChangePicture.Tag & ".png")
        Catch ex As Exception
            picUser.BackgroundImage = My.Resources.NoImage
        End Try
    End Sub

    Private Sub UP_DOWN_ValueChanged(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub ReadOnlyAll(x As Boolean)
        ucSubCatg_Designacao.ReadOnlyInput = x
        ucChangePicture.Visible = Not x
        ucSubCatg_CATG.ReadOnlyInput = x
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
        pSearchBar.Visible = x

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

            Dim Message As MsgBoxStyle = MsgBox("Deseja guardar esta sub-categoria?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                Dim SubCategoriaAtual As ClsSub_Categorias = Lista_SubCategorias(UP_DOWN.Value - 1)


                With SubCategoriaAtual
                    .Imagem = .Cod_Sub_Categoria & ".png"
                    .Cod_Sub_Categoria = ClsSub_Categorias.GetNovoCodigo
                    .Cod_Categoria = ucSubCatg_CATG.cbContent.ActiveRow.Cells("Cod_Categoria").Value
                    .Designacao = ucSubCatg_Designacao.txtContent.Text
                End With




                If Adding = True Then
                    ClsSub_Categorias.GravaSub_Categorias(SubCategoriaAtual)

                    If ofdUserImage.FileName <> "Sub-Categoria.png" Then
                        picUser.BackgroundImage.Save(ClsUtils.ImagesSubCategoriasPath & SubCategoriaAtual.Cod_Categoria & ".png", Imaging.ImageFormat.Png)
                    End If


                    If txtSearchContent.Text <> "" Then
                        ClsSub_Categorias.GetSub_CategoriasByNome(txtSearchContent.Text)
                    Else
                        LoadAllEntities()
                    End If
                    LoadCurrentEntity()

                    UP_DOWN.Value = UP_DOWN.Maximum

                    udaInfo.Text = "Sub-Categoria adicionada com sucesso!"
                    Adding = False
                    lblCounter.Visible = True
                Else
                    SubCategoriaAtual.Cod_Sub_Categoria = ucSubCatg_Cod.txtContent.Text
                    ClsSub_Categorias.ModificaSub_Categorias(SubCategoriaAtual)
                    If ChangedPic = True Then
                        ChangedPic = False
                        picUser.BackgroundImage.Save(ClsUtils.ImagesSubCategoriasPath & SubCategoriaAtual.Cod_Categoria & ".png", Imaging.ImageFormat.Png)
                    End If
                    If txtSearchContent.Text <> "" Then
                        ClsSub_Categorias.GetSub_CategoriasByNome(txtSearchContent.Text)
                    Else
                        Dim Value As Integer = UP_DOWN.Value
                        LoadAllEntities()
                        UP_DOWN.Value = Value
                    End If
                    LoadCurrentEntity()

                    udaInfo.Text = "Sub-Categoria editada com sucesso!"
                End If

                ReadOnlyAll(True)

                udaSaved.Show(udaInfo)
                IsAdmin = False
            End If
        Else

            ReadOnlyAll(False)
            Adding = True
            lblCounter.Visible = False

            ucSubCatg_Cod.txtContent.Text = "Código Automático"
            ucSubCatg_Designacao.txtContent.Clear()
            ucSubCatg_CATG.cbContent.SelectedRow = ucSubCatg_CATG.cbContent.Rows(0)
            picUser.BackgroundImage = My.Resources.NoImage

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

            Dim Message As MsgBoxStyle = MsgBox("Deseja eliminar esta sub-categoria?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                ClsSub_Categorias.ApagaSub_Categorias(ucSubCatg_Cod.txtContent.Value)

                If txtSearchContent.Text <> "" Then
                    txtSearchContent.Clear()
                End If

                Lista_SubCategorias.Clear()
                Lista_SubCategorias = ClsSub_Categorias.GetSub_Categorias
                UP_DOWN.Maximum = Lista_SubCategorias.Count

                LoadCurrentEntity()

                udaInfo.Text = "Sub-Categoria eliminada com sucesso!"
                udaSaved.Show(udaInfo)

            End If

        End If

    End Sub

    Private Sub ChangePic(sender As Object, e As EventArgs) Handles ucChangePicture.Click
        ofdUserImage.ShowDialog()
        Dim Path As String = ofdUserImage.FileName
        If Not Path = "Sub-Categoria.png" Then
            ChangedPic = True

            Dim ImageTemp As Image = ClsUtils.OrientedImageFromFile(Path)

            ImageTemp = ClsUtils.ResizeImage(ImageTemp)
            picUser.BackgroundImage = ImageTemp

        End If
    End Sub

    Private Sub SearchLabelClick(sender As Object, e As EventArgs) Handles lblSearch.Click
        txtSearchContent.Focus()
    End Sub
    Private Sub LabelDisapear(sender As Object, e As EventArgs) Handles txtSearchContent.TextChanged
        If txtSearchContent.Text <> "" Then
            lblSearch.Visible = False
        Else
            lblSearch.Visible = True
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

    Private Sub SearchFilter(sender As Object, e As EventArgs) Handles txtSearchContent.TextChanged
        If txtSearchContent.Text <> "" Then
            Dim TempLista As New List(Of ClsSub_Categorias)
            TempLista = ClsSub_Categorias.GetSub_CategoriasByNome(txtSearchContent.Text)
            If TempLista.Count <> 0 Then

                Lista_SubCategorias.Clear()
                Lista_SubCategorias = TempLista
                UP_DOWN.Maximum = Lista_SubCategorias.Count
                UP_DOWN.Value = 1
                LoadCurrentEntity()

                VisiblesNavBar(True)
            Else
                ucSubCatg_Cod.txtContent.Clear()
                ucSubCatg_Designacao.txtContent.Clear()
                ucSubCatg_CATG.cbContent.SelectedRow = ucSubCatg_CATG.cbContent.Rows(0)
                picUser.BackgroundImage = My.Resources.NoImage
                lblCounter.Text = "A mostrar sub-categoria 0 de 0"
                VisiblesNavBar(False)
            End If

        Else
            LoadAllEntities()
            VisiblesNavBar(True)
        End If
    End Sub
End Class
