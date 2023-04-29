Public Class ucComboBoxWithLabel

    Public Event TextChangedCustom As EventHandler(Of TextChangedEventArgs)
    Public Property PlaceHolder As String
        Get
            Return lblText.Text
        End Get
        Set(value As String)
            lblText.Text = value
        End Set
    End Property

    Public Property DatasourceIdentifier As Integer
        Get
            Return cbContent.Tag
        End Get
        Set(value As Integer)
            cbContent.Tag = value
        End Set
    End Property
    Public Property ReadOnlyInput As Boolean
        Get
            Return cbContent.ReadOnly
        End Get
        Set(value As Boolean)
            If value Then
                lblInfo.ForeColor = Color.FromArgb(255, 80, 80, 80)
                picArrow.Visible = False
            Else
                cbContent.Appearance.ForeColor = Color.Black
                lblInfo.ForeColor = Color.Black
                picArrow.Visible = True
            End If
            cbContent.ReadOnly = value
        End Set
    End Property
    Private Sub ContentChanged(sender As Object, e As EventArgs) Handles lblInfo.TextChanged
        InvokeLostFocus(Me, e)
        Dim args As New TextChangedEventArgs(lblInfo.Text)
        RaiseEvent TextChangedCustom(Me, args)
    End Sub

    Private Sub LoadUC() Handles MyBase.Load, MyBase.Resize
        SetDataSource(DatasourceIdentifier)
    End Sub

    Public Sub SetDataSource(identifier As Integer)
        Select Case identifier
            Case 1
                ClsTipoEntidade.ApplyTipoEntidade()
                cbContent.DataSource = ClsTipoEntidade.TipoEntidade
                cbContent.DisplayLayout.Bands(0).Columns("Valor").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("Cod").Hidden = True
            Case 2
                cbContent.DataSource = ClsPaises.GetPaises()
                cbContent.DisplayLayout.Bands(0).Columns("Cod_Pais").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("FLG_Ativo").Hidden = True
            Case 3
                cbContent.DataSource = ClsCategorias.GetCategorias()
                cbContent.DisplayLayout.Bands(0).Columns("Cod_Categoria").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("Imagem").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("FLG_Ativo").Hidden = True
            Case 4
                cbContent.DataSource = ClsSub_Categorias.GetSub_Categorias()
                cbContent.DisplayLayout.Bands(0).Columns("Cod_Sub_Categoria").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("Cod_Categoria").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("Imagem").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("FLG_Ativo").Hidden = True
            Case 5
                cbContent.DataSource = ClsIVA.GetIVA()
                cbContent.DisplayLayout.Bands(0).Columns("Cod_IVA").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("Tipo_IVA").Hidden = True
                cbContent.DisplayLayout.Bands(0).Columns("FLG_Ativo").Hidden = True
            Case 6
                cbContent.DataSource = ClsTipos_Doc.GetTipos_Doc()
                With cbContent.DisplayLayout.Bands(0)
                    .Columns("FLG_Tipo_Doc").Hidden = True
                    .Columns("Designacao").Hidden = True
                    .Columns("FLG_ESC").Hidden = True
                    .Columns("FLG_DC").Hidden = True
                    .Columns("FLG_Entidade").Hidden = True
                    .Columns("FLG_Venda").Hidden = True
                    .Columns("FLG_Compra").Hidden = True
                    .Columns("FLG_Stock").Hidden = True
                    .Columns("FLG_Ativo").Hidden = True
                    .Columns("Cod_Serie").Hidden = True
                    .Columns("Contador").Hidden = True
                End With
                cbContent.DisplayMember = "Descritivo_Impressao"
                cbContent.SelectedRow = cbContent.Rows(0)
        End Select
    End Sub

    Private Sub ArrowClick(sender As Object, e As EventArgs) Handles picArrow.Click, MyBase.Enter
        cbContent.Focus()
        SendKeys.Send("{F4}")
    End Sub

    Private Sub CheckDroppedDownCombo(sender As Object, e As EventArgs) Handles cbContent.AfterDropDown, cbContent.AfterCloseUp
        If cbContent.IsDroppedDown Then
            picArrow.Image = My.Resources.LineIcon
        Else
            picArrow.Image = My.Resources.ArrowDownIcon
        End If
    End Sub

    Private Sub ComboContentChanged(sender As Object, e As EventArgs) Handles cbContent.TextChanged
        If cbContent.Tag = 3 Then
            Dim tempcontrol As New Label
            tempcontrol.Text = ""

            Me.Controls.Add(tempcontrol)
            Me.Controls.Remove(tempcontrol)
        End If

        Select Case cbContent.Tag
            Case 1
                lblInfo.Text = cbContent.ActiveRow.Cells("Descritivo").Text
            Case 2
                lblInfo.Text = cbContent.ActiveRow.Cells("Pais").Text
            Case 3
                lblInfo.Text = cbContent.ActiveRow.Cells("Designacao").Text
            Case 4
                If cbContent.ActiveRow Is Nothing Then
                    cbContent.SelectedRow = cbContent.Rows(0)
                End If
                lblInfo.Text = cbContent.ActiveRow.Cells("Designacao").Text
            Case 5
                lblInfo.Text = cbContent.ActiveRow.Cells("Taxa_IVA").Text
            Case 6
                lblInfo.Text = cbContent.ActiveRow.Cells("Descritivo_Impressao").Text
        End Select


    End Sub
End Class
