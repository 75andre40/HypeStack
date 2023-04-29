Imports System.Runtime.Remoting.Contexts
Imports Infragistics.Win.Misc
Public Class ucEntidades

    Private Lista_Entidades As New List(Of ClsEntidades)

    Private WithEvents UP_DOWN As New NumericUpDown

    Private Sub Load_UC(sender As Object, e As EventArgs) Handles MyBase.Load
        Up_Down_Entidade.Value = 0
        ClsTipoEntidade.ApplyTipoEntidade()
        LoadAllEntities()
        UP_DOWN.Minimum = 1
        UP_DOWN.Value = 1
    End Sub

    Private Sub RefreshCounter(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub LoadAllEntities()
        Lista_Entidades.Clear()
        Lista_Entidades = ClsEntidades.GetEntidadesByTipo(ClsTipoEntidade.TipoEntidade(Up_Down_Entidade.Value).Valor)
        UP_DOWN.Maximum = Lista_Entidades.Count
        UP_DOWN.Value = 1
        LoadCurrentEntity()
    End Sub

    Private Sub LoadCurrentEntity()

        ucEntidade_Cod.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Cod_Entidade
        ucEntidade_Nome.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Nome
        ucEntidade_NIF.TextInput = Lista_Entidades(UP_DOWN.Value - 1).NIF
        ucEntidade_Telemovel.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Num_Telemovel
        ucEntidade_Telefone.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Num_Telefone
        ucEntidade_Email.TextInput = Lista_Entidades(UP_DOWN.Value - 1).Email

        For x As Integer = 0 To ucEntidade_Tipo.cbContent.Rows.Count - 1
            If ucEntidade_Tipo.cbContent.Rows(x).Cells("Valor").Text = Lista_Entidades(UP_DOWN.Value - 1).FLG_Entidade Then
                ucEntidade_Tipo.cbContent.SelectedRow = ucEntidade_Tipo.cbContent.Rows(x)
                Exit For
            End If
        Next

        For x As Integer = 0 To ucEntidade_Pais.cbContent.Rows.Count - 1
            If ucEntidade_Pais.cbContent.Rows(x).Cells("Cod_Pais").Text = Lista_Entidades(UP_DOWN.Value - 1).Cod_Pais Then
                ucEntidade_Pais.cbContent.SelectedRow = ucEntidade_Pais.cbContent.Rows(x)
                Exit For
            End If
        Next


        lblCounter.Text = "A mostrar entidade " & UP_DOWN.Value & " de " & Lista_Entidades.Count
        ucChangePicture.Tag = Lista_Entidades(UP_DOWN.Value - 1).Cod_Entidade

        Try
            If ucEntidade_Tipo.cbContent.ActiveRow.Cells("Cod").Value > 1 Then
                picUser.BackgroundImage = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesUsersPath & ucChangePicture.Tag & ".jpg")
            Else
                picUser.BackgroundImage = My.Resources.NoImage
            End If
        Catch ex As Exception
            picUser.BackgroundImage = My.Resources.NoImage
        End Try
    End Sub

    Private Sub UP_DOWN_ValueChanged(sender As Object, e As EventArgs) Handles UP_DOWN.ValueChanged
        LoadCurrentEntity()
    End Sub

    Private Sub ReadOnlyAll(x As Boolean)
        ucEntidade_Email.ReadOnlyInput = x
        ucEntidade_NIF.ReadOnlyInput = x
        ucEntidade_Nome.ReadOnlyInput = x
        ucEntidade_Pais.ReadOnlyInput = x
        ucEntidade_Telefone.ReadOnlyInput = x
        ucEntidade_Telemovel.ReadOnlyInput = x
        ucEntidade_Tipo.ReadOnlyInput = x
        If ucEntidade_Tipo.cbContent.ActiveRow.Cells("Cod").Value > 1 Then
            ucChangePicture.Visible = Not x
        End If
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
        If txtSearchContent.Text = "" Then
            pFiltroEntidades.Visible = x
        End If
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
        OldType = ucEntidade_Tipo.cbContent.ActiveRow.Cells("Valor").Value
    End Sub
    Private Sub TipoEntidade_Changed(sender As Object, e As EventArgs) Handles ucEntidade_Tipo.LostFocus
        If ucEntidade_Tipo.cbContent.ActiveRow.Cells("Cod").Value > 1 And Editing = True Then
            ucChangePicture.Visible = True
        Else
            ucChangePicture.Visible = False
        End If
    End Sub

    Private Sub AddSave(sender As Object, e As EventArgs) Handles btnAddSave.Click
        Dim udaInfo As New UltraDesktopAlertShowWindowInfo
        udaInfo.ScreenPosition = ScreenPosition.BottomLeft

        udaInfo.Caption = "HypeStack"
        udaInfo.Image = My.Resources.CheckIcon

        If Editing Then

            'Validações
            Dim CheckTelemovel As Boolean = ClsUtils.CheckTelemovel(ucEntidade_Telemovel.txtContent.Text)
            Dim CheckTelefone As Boolean = ClsUtils.CheckTelefone(ucEntidade_Telefone.txtContent.Text)
            Dim CheckNIF As Boolean = ClsUtils.CheckNIF(ucEntidade_NIF.txtContent.Text)
            Dim CheckEmail As Boolean = ClsUtils.CheckEmail(ucEntidade_Email.txtContent.Text)

            If CheckTelemovel = False Or CheckTelefone = False Or CheckNIF = False Or CheckEmail = False Then


                udaInfo.Image = My.Resources.WrongIcon
                udaInfo.Text = "Verifique os dados e tente novamente!"
                udaSaved.Show(udaInfo)

                Exit Sub
            End If
            'Validações

            Dim Message As MsgBoxStyle = MsgBox("Deseja guardar esta entidade?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                Dim EntidadeAtual As ClsEntidades = Lista_Entidades(UP_DOWN.Value - 1)


                With EntidadeAtual
                    .FLG_Entidade = ucEntidade_Tipo.cbContent.ActiveRow.Cells("Valor").Value
                    .Nome = ucEntidade_Nome.txtContent.Text
                    .Cod_Pais = ucEntidade_Pais.cbContent.ActiveRow.Cells("Cod_Pais").Value
                    .NIF = ucEntidade_NIF.txtContent.Text
                    .Num_Telemovel = ucEntidade_Telemovel.txtContent.Text
                    .Num_Telefone = ucEntidade_Telefone.txtContent.Text
                    .Email = ucEntidade_Email.txtContent.Text

                    If .FLG_Entidade = "A" And Not Adding Then IsAdmin = True

                    If Adding Then
                        IsAdmin = False
                        .Cod_Entidade = 0
                        .Data_Registo = Date.Now
                    End If
                    If IsAdmin Then
                        .Utilizador = .Cod_Entidade
                        .Password = "1"
                    Else
                        .Utilizador = ""
                        .Password = ""
                    End If
                End With




                If Adding Then
                    ClsEntidades.GravaEntidades(EntidadeAtual)

                    Dim TempListaEntidades As List(Of ClsEntidades) = ClsEntidades.GetEntidades
                    EntidadeAtual.Cod_Entidade = TempListaEntidades(TempListaEntidades.Count - 1).Cod_Entidade


                    If ucEntidade_Tipo.cbContent.ActiveRow.Cells("Cod").Value > 1 And ofdUserImage.FileName <> "User.png" Then
                        picUser.BackgroundImage.Save(ClsUtils.ImagesUsersPath & EntidadeAtual.Cod_Entidade & ".jpg", Imaging.ImageFormat.Jpeg)
                    End If


                    If txtSearchContent.Text <> "" Then
                        ClsEntidades.GetEntidadesByNome(txtSearchContent.Text)
                    Else
                        LoadAllEntities()
                    End If
                    LoadCurrentEntity()

                    If EntidadeAtual.FLG_Entidade = "A" Then
                        EntidadeAtual.Password = "1"
                        EntidadeAtual.Utilizador = EntidadeAtual.Cod_Entidade
                        ClsEntidades.ModificaEntidades(EntidadeAtual)
                    End If

                    'ClsEntidades.ApagaEntidades(ucEntidade_Cod.txtContent.Value)

                    UP_DOWN.Value = UP_DOWN.Maximum

                    udaInfo.Text = "Entidade adicionada com sucesso!"
                    Adding = False
                    lblCounter.Visible = True
                Else
                    ClsEntidades.ModificaEntidades(EntidadeAtual)
                        If ucEntidade_Tipo.cbContent.ActiveRow.Cells("Cod").Value > 1 And ChangedPic = True Then
                            ChangedPic = False
                            picUser.BackgroundImage.Save(ClsUtils.ImagesUsersPath & EntidadeAtual.Cod_Entidade & ".jpg", Imaging.ImageFormat.Jpeg)
                        End If
                        If txtSearchContent.Text <> "" Then
                            ClsEntidades.GetEntidadesByNome(txtSearchContent.Text)
                        Else
                        Dim Value As Integer = UP_DOWN.Value
                        LoadAllEntities()
                        UP_DOWN.Value = Value
                    End If
                        LoadCurrentEntity()

                        udaInfo.Text = "Entidade editada com sucesso!"
                    End If

                    ReadOnlyAll(True)

                    udaSaved.Show(udaInfo)
                    IsAdmin = False
                End If
            Else

            ReadOnlyAll(False)
            Adding = True
            lblCounter.Visible = False

            ucEntidade_Cod.txtContent.Text = "Código Automático"
            ucEntidade_Nome.txtContent.Clear()
            ucEntidade_NIF.txtContent.Clear()
            ucEntidade_Telemovel.txtContent.Clear()
            ucEntidade_Telefone.txtContent.Clear()
            ucEntidade_Email.txtContent.Clear()
            picUser.BackgroundImage = My.Resources.NoImage
            ucEntidade_Pais.cbContent.SelectedRow = ucEntidade_Pais.cbContent.Rows(179)
            ucEntidade_Tipo.cbContent.SelectedRow = ucEntidade_Tipo.cbContent.Rows(0)
            ucChangePicture.Visible = False

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

            Dim Message As MsgBoxStyle = MsgBox("Deseja eliminar esta entidade?", MsgBoxStyle.OkCancel, "HypeStack")

            If Message = vbOK Then

                Dim EntidadeTipoAtual As String = ucEntidade_Tipo.cbContent.ActiveRow.Cells("Valor").Value

                ClsEntidades.ApagaEntidades(ucEntidade_Cod.txtContent.Value, EntidadeTipoAtual)

                If txtSearchContent.Text <> "" Then
                    txtSearchContent.Clear()
                End If

                Lista_Entidades.Clear()
                Lista_Entidades = ClsEntidades.GetEntidadesByTipo(ClsTipoEntidade.TipoEntidade(Up_Down_Entidade.Value).Valor)
                UP_DOWN.Maximum = Lista_Entidades.Count

                LoadCurrentEntity()

                udaInfo.Text = "Entidade eliminada com sucesso!"
                udaSaved.Show(udaInfo)

            End If

        End If

    End Sub

    Private Sub LeftClick(sender As Object, e As EventArgs) Handles picLeftFiltro.Click
        If Not Up_Down_Entidade.Value = 0 Then
            Up_Down_Entidade.Value -= 1
            lblTextFiltro.Text = ClsTipoEntidade.TipoEntidade(Up_Down_Entidade.Value).Descritivo
            LoadAllEntities()
        End If

        If Up_Down_Entidade.Value = Up_Down_Entidade.Minimum Then
            picLeftFiltro.Visible = False
        End If

        picRightFiltro.Visible = True
    End Sub

    Private Sub RightClick(sender As Object, e As EventArgs) Handles picRightFiltro.Click
        If Not Up_Down_Entidade.Value = Up_Down_Entidade.Maximum Then
            Up_Down_Entidade.Value += 1
            lblTextFiltro.Text = ClsTipoEntidade.TipoEntidade(Up_Down_Entidade.Value).Descritivo
            LoadAllEntities()
        End If

        If Up_Down_Entidade.Value = Up_Down_Entidade.Maximum Then
            picRightFiltro.Visible = False
        End If

        picLeftFiltro.Visible = True
    End Sub

    Private Sub ChangePic(sender As Object, e As EventArgs) Handles ucChangePicture.Click
        ofdUserImage.ShowDialog()
        Dim Path As String = ofdUserImage.FileName
        If Not Path = "User.png" Then
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
            Dim TempLista As New List(Of ClsEntidades)
            TempLista = ClsEntidades.GetEntidadesByNome(txtSearchContent.Text)
            If TempLista.Count <> 0 Then
                pFiltroEntidades.Visible = False

                Lista_Entidades.Clear()
                Lista_Entidades = TempLista
                UP_DOWN.Maximum = Lista_Entidades.Count
                UP_DOWN.Value = 1
                LoadCurrentEntity()

                VisiblesNavBar(True)
            Else
                ucEntidade_Cod.txtContent.Clear()
                ucEntidade_Nome.txtContent.Clear()
                ucEntidade_NIF.txtContent.Clear()
                ucEntidade_Telemovel.txtContent.Clear()
                ucEntidade_Telefone.txtContent.Clear()
                ucEntidade_Email.txtContent.Clear()
                picUser.BackgroundImage = My.Resources.NoImage
                ucEntidade_Pais.cbContent.SelectedRow = ucEntidade_Pais.cbContent.Rows(179)
                ucEntidade_Tipo.cbContent.SelectedRow = ucEntidade_Tipo.cbContent.Rows(0)
                lblCounter.Text = "A mostrar entidade 0 de 0"
                VisiblesNavBar(False)
            End If

        Else
            LoadAllEntities()
            pFiltroEntidades.Visible = True
            VisiblesNavBar(True)
        End If
    End Sub
End Class
