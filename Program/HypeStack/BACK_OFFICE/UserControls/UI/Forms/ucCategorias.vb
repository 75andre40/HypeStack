Imports System.Runtime.Remoting.Contexts
Imports Infragistics.Win.Misc
Public Class ucCategorias

    Private Lista_Categorias As New List(Of ClsCategorias)

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
        Lista_Categorias.Clear()
        Lista_Categorias = ClsCategorias.GetCategorias
        UP_DOWN.Maximum = Lista_Categorias.Count
        UP_DOWN.Value = 1
        LoadCurrentEntity()
    End Sub

    Private Sub LoadCurrentEntity()

        ucCategorias_Cod.TextInput = Lista_Categorias(UP_DOWN.Value - 1).Cod_Categoria
        ucCategorias_Designacao.TextInput = Lista_Categorias(UP_DOWN.Value - 1).Designacao


        lblCounter.Text = "A mostrar categoria " & UP_DOWN.Value & " de " & Lista_Categorias.Count
        ucChangePicture.Tag = Lista_Categorias(UP_DOWN.Value - 1).Cod_Categoria

        Try
            picUser.BackgroundImage = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesCategoriasPath & ucChangePicture.Tag & ".png")
        Catch ex As Exception
            picUser.BackgroundImage = My.Resources.NoImage
        End Try
    End Sub

    Private Sub UP_DOWN_ValueChanged(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub ReadOnlyAll(x As Boolean)
        ucCategorias_Designacao.ReadOnlyInput = x
        ucChangePicture.Visible = Not x
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

            Dim Message As MsgBoxStyle = MsgBox("Deseja guardar esta categoria?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                Dim CategoriaAtual As ClsCategorias = Lista_Categorias(UP_DOWN.Value - 1)


                With CategoriaAtual
                    .Imagem = .Cod_Categoria & ".png"
                    .Cod_Categoria = ClsCategorias.GetNovoCodigo
                    .Designacao = ucCategorias_Designacao.txtContent.Text
                End With




                If Adding = True Then
                    ClsCategorias.GravaCategorias(CategoriaAtual)

                    If ofdUserImage.FileName <> "Categoria.png" Then
                        picUser.BackgroundImage.Save(ClsUtils.ImagesCategoriasPath & CategoriaAtual.Cod_Categoria & ".png", Imaging.ImageFormat.Png)
                    End If


                    If txtSearchContent.Text <> "" Then
                        ClsCategorias.GetCategoriasByNome(txtSearchContent.Text)
                    Else
                        LoadAllEntities()
                    End If
                    LoadCurrentEntity()

                    UP_DOWN.Value = UP_DOWN.Maximum

                    udaInfo.Text = "Categoria adicionada com sucesso!"
                    Adding = False
                    lblCounter.Visible = True
                Else
                    CategoriaAtual.Cod_Categoria = ucCategorias_Cod.txtContent.Text
                    ClsCategorias.ModificaCategorias(CategoriaAtual)
                    If ChangedPic = True Then
                        ChangedPic = False
                        picUser.BackgroundImage.Save(ClsUtils.ImagesCategoriasPath & CategoriaAtual.Cod_Categoria & ".png", Imaging.ImageFormat.Png)
                    End If
                    If txtSearchContent.Text <> "" Then
                        ClsCategorias.GetCategoriasByNome(txtSearchContent.Text)
                    Else
                        Dim Value As Integer = UP_DOWN.Value
                        LoadAllEntities()
                        UP_DOWN.Value = Value
                    End If
                    LoadCurrentEntity()

                    udaInfo.Text = "Categoria editada com sucesso!"
                End If

                ReadOnlyAll(True)

                udaSaved.Show(udaInfo)
                IsAdmin = False
            End If
        Else

            ReadOnlyAll(False)
            Adding = True
            lblCounter.Visible = False

            ucCategorias_Cod.txtContent.Text = "Código Automático"
            ucCategorias_Designacao.txtContent.Clear()
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

            Dim Message As MsgBoxStyle = MsgBox("Deseja eliminar esta categoria?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                ClsCategorias.ApagaCategorias(ucCategorias_Cod.txtContent.Value)

                If txtSearchContent.Text <> "" Then
                    txtSearchContent.Clear()
                End If

                Lista_Categorias.Clear()
                Lista_Categorias = ClsCategorias.GetCategorias
                UP_DOWN.Maximum = Lista_Categorias.Count

                LoadCurrentEntity()

                udaInfo.Text = "Categoria eliminada com sucesso!"
                udaSaved.Show(udaInfo)

            End If

        End If

    End Sub

    Private Sub ChangePic(sender As Object, e As EventArgs) Handles ucChangePicture.Click
        ofdUserImage.ShowDialog()
        Dim Path As String = ofdUserImage.FileName
        If Not Path = "Categoria.png" Then
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
            Dim TempLista As New List(Of ClsCategorias)
            TempLista = ClsCategorias.GetCategoriasByNome(txtSearchContent.Text)
            If TempLista.Count <> 0 Then

                Lista_Categorias.Clear()
                Lista_Categorias = TempLista
                UP_DOWN.Maximum = Lista_Categorias.Count
                UP_DOWN.Value = 1
                LoadCurrentEntity()

                VisiblesNavBar(True)
            Else
                ucCategorias_Cod.txtContent.Clear()
                ucCategorias_Designacao.txtContent.Clear()
                picUser.BackgroundImage = My.Resources.NoImage
                lblCounter.Text = "A mostrar categoria 0 de 0"
                VisiblesNavBar(False)
            End If

        Else
            LoadAllEntities()
            VisiblesNavBar(True)
        End If
    End Sub
End Class
