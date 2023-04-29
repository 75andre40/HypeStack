Imports System.ComponentModel
Imports System.Runtime.Remoting.Contexts
Imports Infragistics.Win.Misc
Public Class ucArtigos

    Private Lista_Artigos As New List(Of ClsArtigos)
    Private MinStock As Integer = 5

    Private WithEvents UP_DOWN As New NumericUpDown

    Private Sub Load_UC(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllArtigos()
        UP_DOWN.Minimum = 1
        UP_DOWN.Value = 1
    End Sub

    Private Sub RefreshCounter(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentArtigo()
    End Sub

    Private Sub LoadAllArtigos()
        Lista_Artigos.Clear()
        If MinStockFilter Then
            Lista_Artigos = ClsArtigos.GetArtigosByStock(MinStock)
        Else
            Lista_Artigos = ClsArtigos.GetArtigos()
        End If
        UP_DOWN.Maximum = Lista_Artigos.Count
        UP_DOWN.Value = 1
        LoadCurrentArtigo()
    End Sub

    Private Sub LoadCurrentArtigo()

        ucArtigo_Cod.txtContent.Text = Lista_Artigos(UP_DOWN.Value - 1).Cod_Artigo
        ucArtigo_Stock.txtContent.Text = Lista_Artigos(UP_DOWN.Value - 1).Stock
        ucArtigo_Designacao.txtContent.Text = Lista_Artigos(UP_DOWN.Value - 1).Designacao
        ucArtigo_Desc.txtContent.Text = Lista_Artigos(UP_DOWN.Value - 1).Descricao
        ucArtigo_PC.txtContent.Text = Lista_Artigos(UP_DOWN.Value - 1).Preco_Compra
        ucArtigo_PV.txtContent.Text = Lista_Artigos(UP_DOWN.Value - 1).Preco_Venda
        ucArtigo_Desconto.aNumericActualValue = Lista_Artigos(UP_DOWN.Value - 1).Desconto
        ucArtigo_PC.txtContent.Text += "€"
        ucArtigo_PV.txtContent.Text += "€"

        For x As Integer = 0 To ucArtigo_Categoria.cbContent.Rows.Count - 1
            If ucArtigo_Categoria.cbContent.Rows(x).Cells("Cod_Categoria").Text = Lista_Artigos(UP_DOWN.Value - 1).Cod_Categoria Then
                ucArtigo_Categoria.cbContent.SelectedRow = ucArtigo_Categoria.cbContent.Rows(x)
                Exit For
            End If
        Next

        For x As Integer = 0 To ucArtigo_SubCategoria.cbContent.Rows.Count - 1
            If ucArtigo_SubCategoria.cbContent.Rows(x).Cells("Cod_Sub_Categoria").Text = Lista_Artigos(UP_DOWN.Value - 1).Cod_Sub_Categoria Then
                ucArtigo_SubCategoria.cbContent.SelectedRow = ucArtigo_SubCategoria.cbContent.Rows(x)
                Exit For
            End If
        Next

        For x As Integer = 0 To ucArtigo_IVA.cbContent.Rows.Count - 1
            If ucArtigo_IVA.cbContent.Rows(x).Cells("Tipo_IVA").Text = Lista_Artigos(UP_DOWN.Value - 1).Tipo_IVA Then
                ucArtigo_IVA.cbContent.SelectedRow = ucArtigo_IVA.cbContent.Rows(x)
                Exit For
            End If
        Next


        lblCounter.Text = "A mostrar artigo " & UP_DOWN.Value & " de " & Lista_Artigos.Count

        Try
            picI1.BackgroundImage = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesArtigosPath & ucArtigo_Cod.txtContent.Text & "_1.jpg")
        Catch ex As Exception
            picI1.BackgroundImage = My.Resources.NoImage
        End Try

        Try
            picI2.BackgroundImage = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesArtigosPath & ucArtigo_Cod.txtContent.Text & "_2.jpg")
        Catch ex As Exception
            picI2.BackgroundImage = My.Resources.NoImage
        End Try

        Try
            picI3.BackgroundImage = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesArtigosPath & ucArtigo_Cod.txtContent.Text & "_3.jpg")
        Catch ex As Exception
            picI3.BackgroundImage = My.Resources.NoImage
        End Try


        If ucArtigo_Desconto.aNumericActualValue = 0 Then
            lblDiscountPrice.Visible = False
            picInfoPCD.Visible = False
        Else
            lblDiscountPrice.Visible = True
            picInfoPCD.Visible = True

            Dim DiscountRAW As Decimal = ucArtigo_Desconto.aNumericActualValue / 100 'Desconto em decimal

            Dim DiscountValue As Decimal = ucArtigo_PV.txtContent.Text * DiscountRAW 'Valor do desconto do produto

            Dim PriceWDiscount As Decimal = ucArtigo_PV.txtContent.Text - DiscountValue 'Valor do produto com desconto

            Dim PriceWDiscountIVA As Decimal = PriceWDiscount * (ucArtigo_IVA.cbContent.SelectedRow.Cells("Taxa_IVA").Text / 100 + 1) 'Valor do produto com desconto e IVA

            lblDiscountPrice.Text = Math.Round(PriceWDiscountIVA, 2) & "€"
        End If


        Dim IVA_RAW As Decimal = (ucArtigo_IVA.cbContent.SelectedRow.Cells("Taxa_IVA").Text / 100) + 1

        lblPrice.Text = Math.Round(CDec(ucArtigo_PV.txtContent.Text) * IVA_RAW, 2) & "€"

        If CInt(ucArtigo_Stock.txtContent.Text) <= 5 Then
            picWarning.Visible = True
        Else
            picWarning.Visible = False
        End If

    End Sub

    Private Sub UP_DOWN_ValueChanged(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentArtigo()
    End Sub

    Private Sub ReadOnlyAll(x As Boolean)
        ucArtigo_Cod.ReadOnlyInput = x
        ucArtigo_Stock.aReadOnlyInput = x
        ucArtigo_Designacao.ReadOnlyInput = x
        ucArtigo_Desc.ReadOnlyInput = x
        ucArtigo_Categoria.ReadOnlyInput = x
        ucArtigo_SubCategoria.ReadOnlyInput = x
        ucArtigo_IVA.ReadOnlyInput = x
        ucArtigo_PC.ReadOnlyInput = x
        ucArtigo_PV.ReadOnlyInput = x
        ucArtigo_Desconto.aReadOnlyInput = x
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
        picAprox.Visible = Not x
        lblPrice.Visible = x
        picInfoPSD.Visible = x
        pFiltroMinStock.Visible = x

        If x Then
            btnAddSave.picImage.Image = My.Resources.AddDocumentIcon
            btnDelCancel.picImage.Image = My.Resources.DeleteIcon
            If Not ucArtigo_Desconto.txtContent.Text = "0" Then
                lblDiscountPrice.Visible = True
                picInfoPCD.Visible = True
            End If
            picI1.Cursor = Cursors.Arrow
            picI2.Cursor = Cursors.Arrow
            picI3.Cursor = Cursors.Arrow
        Else
            btnAddSave.picImage.Image = My.Resources.DisqueteIcon
            btnDelCancel.picImage.Image = My.Resources.CancelIcon

            lblDiscountPrice.Visible = False
            picInfoPCD.Visible = False
            lblPrice.Visible = False
            picInfoPSD.Visible = False

            picI1.Cursor = Cursors.Hand
            picI2.Cursor = Cursors.Hand
            picI3.Cursor = Cursors.Hand
        End If
        Editing = Not x
    End Sub

    Private Sub EditarEntidade(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Not Editing Then

            ReadOnlyAll(False)
            picWarning.Visible = False

        End If
    End Sub

    Private Sub AddSave(sender As Object, e As EventArgs) Handles btnAddSave.Click
        Dim udaInfo As New UltraDesktopAlertShowWindowInfo
        udaInfo.ScreenPosition = ScreenPosition.BottomLeft

        udaInfo.Caption = "HypeStack"
        udaInfo.Image = My.Resources.CheckIcon

        If Editing Then

            'Validações

            Dim CheckPic1 As Boolean = ClsUtils.AreSameImage(picI1.BackgroundImage, My.Resources.NoImage)
            Dim CheckPic2 As Boolean = ClsUtils.AreSameImage(picI2.BackgroundImage, My.Resources.NoImage)
            Dim CheckPic3 As Boolean = ClsUtils.AreSameImage(picI3.BackgroundImage, My.Resources.NoImage)

            If CheckPic1 = True Or CheckPic2 = True Or CheckPic3 = True Then

                udaInfo.Image = My.Resources.WrongIcon
                udaInfo.Text = "Verifique os dados e tente novamente!"
                udaSaved.Show(udaInfo)

                Exit Sub
            End If
            'Validações

            Dim Message As MsgBoxStyle = MsgBox("Deseja guardar este artigo?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                Dim ArtigoAtual As ClsArtigos = Lista_Artigos(UP_DOWN.Value - 1)

                With ArtigoAtual
                    .Cod_Artigo = ClsArtigos.GetNovoCodigo
                    .Stock = ucArtigo_Stock.txtContent.Text
                    .Designacao = ucArtigo_Designacao.txtContent.Text
                    .Descricao = ucArtigo_Desc.txtContent.Text
                    .Cod_Categoria = ucArtigo_Categoria.cbContent.ActiveRow.Cells("Cod_Categoria").Value
                    .Cod_Sub_Categoria = ucArtigo_SubCategoria.cbContent.ActiveRow.Cells("Cod_Sub_Categoria").Value
                    .Tipo_IVA = ucArtigo_IVA.cbContent.ActiveRow.Cells("Tipo_IVA").Value
                    .Preco_Compra = ucArtigo_PC.txtContent.Text
                    .Preco_Venda = ucArtigo_PV.txtContent.Text
                    .Desconto = ucArtigo_Desconto.txtContent.Text
                End With




                If Adding = True Then
                    ClsArtigos.GravaArtigos(ArtigoAtual)

                    picI1.BackgroundImage.Save(ClsUtils.ImagesArtigosPath & ArtigoAtual.Cod_Artigo & "_1.jpg", Imaging.ImageFormat.Jpeg)
                    picI2.BackgroundImage.Save(ClsUtils.ImagesArtigosPath & ArtigoAtual.Cod_Artigo & "_2.jpg", Imaging.ImageFormat.Jpeg)
                    picI3.BackgroundImage.Save(ClsUtils.ImagesArtigosPath & ArtigoAtual.Cod_Artigo & "_3.jpg", Imaging.ImageFormat.Jpeg)


                    If txtSearchContent.Text <> "" Then
                        ClsArtigos.GetArtigoByNome(txtSearchContent.Text)
                    Else
                        If ArtigoAtual.Stock > MinStock And MinStockFilter = True Then
                            picFiltroStockMin.Image = My.Resources.FilterMinStockNo
                            MinStockFilter = False
                            Dim Message2 As MsgBoxStyle = MsgBox("O filtro de stock mínimo vai ser desativado.", MsgBoxStyle.OkOnly, "HypeStack")
                        End If
                        LoadAllArtigos()
                    End If
                    LoadCurrentArtigo()

                    UP_DOWN.Value = UP_DOWN.Maximum

                    udaInfo.Text = "Artigo adicionado com sucesso!"
                    Adding = False
                    lblCounter.Visible = True
                Else
                    ArtigoAtual.Cod_Artigo = ucArtigo_Cod.txtContent.Text
                    ClsArtigos.ModificaArtigos(ArtigoAtual)
                    If ChangedPic1 = True Then

                        ChangedPic1 = False
                        picI1.BackgroundImage.Save(ClsUtils.ImagesArtigosPath & ArtigoAtual.Cod_Artigo & "_1.jpg", Imaging.ImageFormat.Jpeg)

                    ElseIf ChangedPic2 = True Then

                        picI2.BackgroundImage.Save(ClsUtils.ImagesArtigosPath & ArtigoAtual.Cod_Artigo & "_2.jpg", Imaging.ImageFormat.Jpeg)
                        ChangedPic2 = False

                    ElseIf ChangedPic3 = True Then

                        picI3.BackgroundImage.Save(ClsUtils.ImagesArtigosPath & ArtigoAtual.Cod_Artigo & "_3.jpg", Imaging.ImageFormat.Jpeg)
                        ChangedPic3 = False

                    End If
                    If txtSearchContent.Text <> "" Then
                        ClsArtigos.GetArtigoByNome(txtSearchContent.Text)
                    Else
                        Dim Value As Integer = UP_DOWN.Value
                        LoadAllArtigos()
                        UP_DOWN.Value = Value
                    End If
                    LoadCurrentArtigo()

                    udaInfo.Text = "Artigo editado com sucesso!"
                End If

                ReadOnlyAll(True)

                udaSaved.Show(udaInfo)
                IsAdmin = False
            End If
        Else

            ReadOnlyAll(False)
            Adding = True
            lblCounter.Visible = False

            DefaultValues()
            ucArtigo_Cod.txtContent.Text = "Código Automático"

            picWarning.Visible = False

        End If

    End Sub


    'FUNÇÃO CORRETA
    Private Sub DelCancel(sender As Object, e As EventArgs) Handles btnDelCancel.Click
        Dim udaInfo As New UltraDesktopAlertShowWindowInfo
        udaInfo.Caption = "HypeStack"
        udaInfo.Image = My.Resources.CheckIcon
        udaInfo.ScreenPosition = ScreenPosition.BottomLeft

        If Editing Then
            Dim Message As MsgBoxStyle = MsgBox("Deseja cancelar as modificações?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                LoadCurrentArtigo()
                ReadOnlyAll(True)
                Adding = False
                lblCounter.Visible = True


            End If

        Else

            Dim Message As MsgBoxStyle = MsgBox("Deseja eliminar este artigo?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                ClsArtigos.ApagaArtigo(ucArtigo_Cod.txtContent.Text)

                If txtSearchContent.Text <> "" Then
                    txtSearchContent.Clear()
                End If

                Lista_Artigos.Clear()
                If MinStockFilter Then
                    Lista_Artigos = ClsArtigos.GetArtigosByStock(MinStock)
                Else
                    Lista_Artigos = ClsArtigos.GetArtigos()
                End If
                UP_DOWN.Maximum = Lista_Artigos.Count

                LoadCurrentArtigo()

                udaInfo.Text = "Artigo eliminado com sucesso!"
                udaSaved.Show(udaInfo)

            End If

        End If

    End Sub

    'FUNÇÃO CORRETA
    Private Sub ChangePic(sender As Object, e As EventArgs) Handles picI1.Click, picI2.Click, picI3.Click
        If ucArtigo_Designacao.ReadOnlyInput = False Then
            ofdProductImage.ShowDialog()
            Dim Path As String = ofdProductImage.FileName
            If Not Path = "Artigo.png" Then

                Dim ImageTemp As Image = ClsUtils.OrientedImageFromFile(Path)

                ImageTemp = ClsUtils.ResizeImage(ImageTemp)

                Select Case sender.tag
                    Case 1
                        picI1.BackgroundImage = ImageTemp
                        ChangedPic1 = True
                    Case 2
                        picI2.BackgroundImage = ImageTemp
                        ChangedPic2 = True
                    Case 3
                        picI3.BackgroundImage = ImageTemp
                        ChangedPic3 = True
                End Select

            End If
        End If
    End Sub

    'FUNÇÃO CORRETA
    Private Sub SearchLabelClick(sender As Object, e As EventArgs) Handles lblSearch.Click
        txtSearchContent.Focus()
    End Sub

    'FUNÇÃO CORRETA
    Private Sub LabelDisapear(sender As Object, e As EventArgs) Handles txtSearchContent.TextChanged
        If txtSearchContent.Text <> "" Then
            lblSearch.Visible = False
        Else
            lblSearch.Visible = True
        End If
    End Sub

    ''FUNÇÃO CORRETA
    Private Sub VisiblesNavBar(x As Boolean)
        btnDelCancel.Visible = x
        btnAddSave.Visible = x
        btnEditar.Visible = x
        btnFirst.Visible = x
        btnLast.Visible = x
        btnBack.Visible = x
        btnNext.Visible = x
    End Sub

    'FUNÇÃO CORRETA
    Private Sub SearchFilter(sender As Object, e As EventArgs) Handles txtSearchContent.TextChanged
        If txtSearchContent.Text <> "" Then
            Dim TempLista As New List(Of ClsArtigos)
            TempLista = ClsArtigos.GetArtigoByNome(txtSearchContent.Text)
            If TempLista.Count <> 0 Then

                Lista_Artigos.Clear()
                Lista_Artigos = TempLista
                UP_DOWN.Maximum = Lista_Artigos.Count
                UP_DOWN.Value = 1
                LoadCurrentArtigo()

                VisiblesNavBar(True)
            Else
                DefaultValues()
                lblCounter.Text = "A mostrar Artigo 0 de 0"
                VisiblesNavBar(False)
            End If

        Else
            LoadAllArtigos()
            VisiblesNavBar(True)
        End If
    End Sub

    'FUNÇÃO CORRETA
    Private Sub DefaultValues()
        ucArtigo_Cod.txtContent.Clear()
        ucArtigo_Designacao.txtContent.Clear()
        ucArtigo_Stock.txtContent.Text = "0"
        ucArtigo_Desc.txtContent.Clear()
        ucArtigo_Categoria.cbContent.SelectedRow = ucArtigo_Categoria.cbContent.Rows(0)
        ucArtigo_SubCategoria.cbContent.SelectedRow = ucArtigo_SubCategoria.cbContent.Rows(0)
        ucArtigo_IVA.cbContent.SelectedRow = ucArtigo_IVA.cbContent.Rows(3)
        ucArtigo_PC.txtContent.Text = "0,00€"
        ucArtigo_PV.txtContent.Text = "0,00€"
        picI1.BackgroundImage = My.Resources.NoImage
        picI2.BackgroundImage = My.Resources.NoImage
        picI3.BackgroundImage = My.Resources.NoImage
        ucArtigo_Desconto.aNumericActualValue = 0
    End Sub

    Private Sub Aprox(sender As Object, e As EventArgs) Handles picAprox.Click
        Dim pricePC As String = ucArtigo_PC.txtContent.Text
        Dim pricePCNumber As String

        For Each price As Char In pricePC
            If Not price = "€" Then
                If price = "." Then
                    pricePCNumber += ","
                    Continue For
                End If
                pricePCNumber += price
            End If
        Next

        ucArtigo_PV.txtContent.Text = pricePCNumber * 1.3
        ucArtigo_PV.txtContent.Text += "€"

    End Sub

    Private Sub ChangedCategoria(sender As Object, e As ControlEventArgs) Handles ucArtigo_Categoria.ControlAdded

        ucArtigo_SubCategoria.cbContent.DataSource = ClsSub_Categorias.GetSub_CategoriasByCategoria(ucArtigo_Categoria.cbContent.ActiveRow.Cells("Cod_Categoria").Text)

    End Sub

    Private Sub ucArtigos_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Finalize()
    End Sub

    Private Sub FiltroStockMin(sender As Object, e As EventArgs) Handles picFiltroStockMin.Click
        If picFiltroStockMin.Tag = 0 Then
            picFiltroStockMin.Tag = 1
            picFiltroStockMin.Image = My.Resources.FilterMinStockYes
            MinStockFilter = True
        Else
            picFiltroStockMin.Tag = 0
            picFiltroStockMin.Image = My.Resources.FilterMinStockNo
            MinStockFilter = False
        End If
        LoadAllArtigos()
    End Sub
End Class
