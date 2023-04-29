Imports Infragistics.Win.UltraWinGrid
Public Class frmUI

    Public Shared mDoc As New ClsDoc

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim actual_text As String = ""

    Dim mListaTipo_Doc As List(Of ClsTipos_Doc) = ClsTipos_Doc.GetTipos_DocByESC("S")
    Dim mListaTipo_Pagamento As List(Of ClsTipos_Pagamento) = ClsTipos_Pagamento.GetTipos_Pagamento
    Dim mEmpresa As List(Of ClsEmpresas) = ClsEmpresas.GetEmpresas
    Dim mCliente As New ClsEntidades
    Dim mTipo_Doc As New ClsTipos_Doc
    Dim mTipo_Pagamento As New ClsTipos_Pagamento
    Dim mArtigo As New ClsArtigos

    Public Shared mTotais As New ClsTotais

    Public Shared mRowVazia As UltraGridRow
    Public Shared mRowRepetida As UltraGridRow

    Dim mIndex_Cliente As Integer = 0
    Dim mIndex_TipoDoc As Integer = 0
    Dim mIndex_TipoPagamento As Integer = 0

    Public Shared menuAberto As ContextMenuStrip = Nothing

    Private Sub Close_Form_Button(sender As Object, e As EventArgs) Handles Me.Closing
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub frmUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        mDoc = New ClsDoc


        FrmTransparente.Show()
        FrmTransparente.Visible = False

        Me.Icon = My.Resources.LogoCircleIco
        Me.MaximumSize = New Size(screenWidth, screenHeight)

        Panel_ViewArt.Dock = DockStyle.Bottom And DockStyle.Right



        Config_UGLinhas()
        Config_UCTipoDoc()
        Config_UG_QI()
        Config_UC_NumCliente()
        Load_UTCTabelas()
        Config_UCTipoPagamento()


        UC_TipoDoc.SelectedRow = UC_TipoDoc.Rows(0)
        UC_TipoDoc_AfterCloseUp()

    End Sub

    Private Sub Load_Rows()
        UG_Linhas.DataSource = mDoc.Linhas
        Display_UG_QI()
    End Sub

    Private Sub Btn_Categorias_Click(sender As Object, e As EventArgs) Handles Btn_Categorias.Click

        ListaArtigos_Mode = "Categorias"
        FrmDialog.Size = New Size(815, 210)

        FrmTransparente.Size = Me.Size
        FrmTransparente.Location = Me.Location

        FrmTransparente.Visible = True

        FrmDialog.StartPosition = FormStartPosition.CenterParent
        FrmDialog.ShowDialog()

        Reset_Txt()
        Pic_LimpaFiltros.Visible = True

    End Sub

    Private Sub Btn_SubCategorias_Click(sender As Object, e As EventArgs) Handles Btn_SubCategorias.Click

        ListaArtigos_Mode = "SubCategorias"
        FrmDialog.Size = New Size(815, 210)

        FrmTransparente.Size = Me.Size
        FrmTransparente.Location = Me.Location

        FrmTransparente.Visible = True

        FrmDialog.StartPosition = FormStartPosition.CenterParent
        FrmDialog.ShowDialog()

        Reset_Txt()

    End Sub

    Private Sub Txt_Search_GotFocus(sender As Object, e As EventArgs) Handles Txt_Search.Enter, Txt_Search.GotFocus
        Txt_Search.Text = ""
        Timer_Delay.Start()
    End Sub

    Private Sub Txt_Search_LostFocus(sender As Object, e As EventArgs) Handles Txt_Search.LostFocus
        If Txt_Search.Text = "" Then
            Reset_Txt()
        End If
        Timer_Delay.Stop()
    End Sub

    Private Sub Reset_Txt()
        Txt_Search.Text = "Procurar:"
        actual_text = ""
        Timer_Delay.Stop()
    End Sub

    Private Sub SearchInLista()

        If Txt_Search.Text = "" And Btn_SubCategorias.Enabled = False Then
            Me.Panel_ViewArt.BackgroundImage = My.Resources.LogoWhite
            If Btn_SubCategorias.Enabled = False Then
                Me.Panel_ViewArt.Controls.Clear()
            End If
            Exit Sub
        ElseIf Txt_Search.Text = actual_text Then
            Exit Sub
        End If

        Me.Panel_ViewArt.Controls.Clear()
        'Lbl_Categoria.Visible = False
        'Lbl_SubCat.Visible = False
        'Btn_SubCategorias.Enabled = False

        ListaArtigos_Mode = "Pesquisa"
        Me.Panel_ViewArt.BackgroundImage = Nothing

        Dim ViewArt As New UC_ViewArt
        Me.Panel_ViewArt.Controls.Add(ViewArt)
        ViewArt.Dock = DockStyle.Fill

        If Txt_Search.Text <> "" And Txt_Search.Text <> "Procurar:" Then
            Pic_LimpaFiltros.Visible = True
        End If

    End Sub

    Private Sub Timer_Delay_Tick(sender As Object, e As EventArgs) Handles Timer_Delay.Tick
        If Txt_Search.Text = "" Then
            Exit Sub
        End If
        SearchInLista()
        actual_text = Txt_Search.Text
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Timer_Delay.Stop()
        Timer_Delay.Start()
    End Sub

    Private Sub frmUI_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Try
            UG_Linhas.DisplayLayout.Bands(0).Columns("Designacao").Width = 323 + (Me.Width - 1360)
            UG_Linhas.Width = 625 + (Me.Width - 1360)
            UG_Linhas.Refresh()
            Panel_UGLinhas.Width = 627 + (Me.Width - 1360)
            UTC_Tabelas.Width = 627 + (Me.Width - 1360)

            With UG_QI.DisplayLayout.Bands(0)
                .Columns("Taxa_IVA").Width = 239 + ((Me.Width - 1360) / 3)
                .Columns("strS_IVA").Width = 239 + ((Me.Width - 1360) / 3)
                .Columns("strV_IVA").Width = 240 + ((Me.Width - 1360) / 3)
            End With

            UG_QI.Width = 719 + (Me.Width - 1360)
            UG_QI.Refresh()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CMS_Qtd_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS_Qtd.Opening
        If Not menuAberto Is Nothing Then
            menuAberto.Close()
        End If
        menuAberto = CMS_Qtd

        TxtMenu_Qtd.Text = UG_Linhas.ActiveRow.Cells("strQuantidade").Value
    End Sub

    Private Sub BtnMenu_More_Click(sender As Object, e As EventArgs) Handles BtnMenu_More.Click
        Dim Qtd As Integer
        Qtd = CInt(TxtMenu_Qtd.Text)

        If Qtd = mArtigo.Stock Then
            Exit Sub
        Else
            TxtMenu_Qtd.Text = Qtd + 1
        End If
    End Sub

    Private Sub BtnMenu_Less_Click(sender As Object, e As EventArgs) Handles BtnMenu_Less.Click
        Dim Qtd As Integer
        Qtd = CInt(TxtMenu_Qtd.Text)

        If Qtd = 1 Then
            Exit Sub
        Else
            TxtMenu_Qtd.Text = Qtd - 1
        End If

    End Sub

    Private Sub BtnMenu_Confirmar_Click(sender As Object, e As EventArgs) Handles BtnMenu_Confirmar.Click
        Dim Qtd As Integer
        Qtd = CInt(TxtMenu_Qtd.Text)


        Change_Linha()
        CMS_Qtd.Close()
    End Sub

    Private Sub Change_Linha()
        Dim mArtigo As New List(Of ClsArtigos)

        mArtigo = mListaArtigos.FindAll(Function(x) _
    x.Cod_Artigo.Contains(UC_GetArtigo.Cod_Artigo))

        If mArtigo.Item(0).Stock >= TxtMenu_Qtd.Text Then
            UG_Linhas.ActiveRow.Cells("strQuantidade").Value = TxtMenu_Qtd.Text
            mDoc.Linhas(UG_Linhas.ActiveRow.Index).Quantidade = TxtMenu_Qtd.Text
        Else
            MsgBox("A quantidade desejada não está desponivel!")
        End If



    End Sub

    Private Sub BtnMenu_Cancelar_Click(sender As Object, e As EventArgs) Handles BtnMenu_Cancelar.Click
        CMS_Qtd.Close()
    End Sub

    Private Sub CMS_Qtd_Closed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles CMS_Qtd.Closed
        menuAberto = Nothing
    End Sub

    Private Sub UG_Linhas_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles UG_Linhas.InitializeLayout
        e.Layout.Bands(0).Columns("strQuantidade").CellClickAction = CellClickAction.RowSelect
    End Sub

    Private Sub UG_Linhas_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles UG_Linhas.MouseUp
        If e.Button = MouseButtons.Left And UG_Linhas.ActiveRow.Cells("Cod_Artigo").Value <> "" Then
            Dim cell As UltraGridCell = UG_Linhas.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y)).GetContext(GetType(UltraGridCell))

            If cell IsNot Nothing AndAlso cell.Column.Key = "strQuantidade" Then
                CMS_Qtd.Show(MousePosition)
            End If
        End If
    End Sub

    Private Sub Config_UGLinhas()
        UG_Linhas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select
        UG_Linhas.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        UG_Linhas.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.FromArgb(250, 170, 3)
        UG_Linhas.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.FromArgb(250, 170, 3)
        UG_Linhas.DisplayLayout.Override.SelectedCellAppearance.BackColor = Color.White
        UG_Linhas.DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.White
        UG_Linhas.DisplayLayout.Override.SelectedCellAppearance.ForeColor = Color.Black
        UG_Linhas.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black



        UG_Linhas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        UG_Linhas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.Horizontal


        With UG_Linhas.DisplayLayout.Bands(0)
            .Columns("Num_Doc").Hidden = True
            .Columns("Num_Linha").Hidden = False
            .Columns("Quantidade").Hidden = True
            .Columns("P_Final").Hidden = True
            .Columns("Taxa_Desconto").Hidden = False
            .Columns("Designacao").Hidden = False
            .Columns("strP_Final").Hidden = False
            .Columns("strQuantidade").Hidden = False
            .Columns("P_Unitario").Hidden = True
            .Columns("P_CDesconto").Hidden = True
            .Columns("Taxa_Iva").Hidden = True
            .Columns("FLG_Ativo").Hidden = True
            .Columns("Cod_Artigo").Hidden = True
            .Columns("Str_PUnitario").Hidden = True
            .Columns("Str_TaxaIva").Hidden = True

            With .Columns("Num_Linha")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Nº."
                .Width = 30

            End With

            With .Columns("strQuantidade")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Qtd"
                .Width = 40
            End With

            With .Columns("strP_Final")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Preço"
                .Width = 75
            End With

            With .Columns("Taxa_Desconto")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Desconto"
                .Width = 90
            End With

            With .Columns("Designacao")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Artigo"
                .Width = 323
            End With

            With .Columns("Limpa")
                .Hidden = False
                .CellActivation = Activation.AllowEdit
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Apagar"
                .Width = 50
            End With

        End With
    End Sub

    Private Sub Config_UCTipoDoc()
        UC_TipoDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select
        UC_TipoDoc.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None

        UC_TipoDoc.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.FromArgb(250, 170, 3)
        UC_TipoDoc.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.FromArgb(250, 170, 3)


        With UC_TipoDoc.DisplayLayout.Bands(0)
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

            With .Columns("Descritivo_Impressao")
                .Hidden = False
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Descritico de Impressão"
                .Width = 200
            End With

        End With

        UC_TipoDoc.DataSource = mListaTipo_Doc.FindAll(Function(x) _
    x.FLG_ESC.Contains("S"))
        UC_TipoDoc.DisplayMember = "Descritivo_Impressao"

        UC_TipoDoc.Text = ""
    End Sub

    Private Sub Config_UCTipoPagamento()
        UC_TipoPagamento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select
        UC_TipoPagamento.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None

        UC_TipoPagamento.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.FromArgb(250, 170, 3)
        UC_TipoPagamento.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.FromArgb(250, 170, 3)


        With UC_TipoPagamento.DisplayLayout.Bands(0)
            .Columns("Cod_Tipo_Pagamento").Hidden = True
            .Columns("Imagem").Hidden = True
            .Columns("Flg_Ativo").Hidden = True

            With .Columns("Tipo_Pagamento")
                .Hidden = False
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Método de Pagamento"
                .Width = 200
            End With

        End With

        UC_TipoPagamento.DataSource = mListaTipo_Pagamento
        UC_TipoPagamento.DisplayMember = "Tipo_Pagamento"

        UC_TipoPagamento.Rows(0).Selected = True

        UC_TipoPagamento.Text = ""
    End Sub

    Private Sub disable_buttons(x As Boolean)
        Btn_Categorias.Enabled = Not x
        Btn_SubCategorias.Enabled = Not x
        Lbl_Categoria.Visible = Not x
        Lbl_SubCat.Visible = Not x
        Txt_Search.Enabled = Not x
        If x = True Then
            Txt_Search.Text = "Procurar:"
        End If
    End Sub

    Private Sub Limpa_TtxtTotais()
        Txt_TotalDesc.Text = ""
        Txt_TotalIliquido.Text = ""
        Txt_TotalIVA.Text = ""
        Txt_TotalPagar.Text = ""
        UC_TipoPagamento.Text = ""
        Pic_MPagamento.Image = Nothing
    End Sub

    Private Sub UC_TipoDoc_AfterCloseUp() Handles UC_TipoDoc.AfterCloseUp, UC_TipoDoc.Leave
        Dim contador As Integer
        Dim result As DialogResult

        If UC_TipoDoc.ActiveRow Is Nothing Then
            If mTipo_Doc.Descritivo_Impressao <> "" Then
                UC_TipoDoc.Text = mTipo_Doc.Descritivo_Impressao
            End If
            Exit Sub
        End If

        If UC_TipoDoc.ActiveRow.Cells("Descritivo_Impressao").Text <> mTipo_Doc.Descritivo_Impressao And mTipo_Doc.Descritivo_Impressao <> Nothing Then
            If mCliente.Cod_Entidade = Nothing And mDoc.Linhas(0).Designacao = "" Then
                result = DialogResult.Yes
            ElseIf mDoc.Linhas(0).Designacao = "" And mCliente.Cod_Entidade <> Nothing Then
                result = MessageBox.Show("Deseja alterar o tipo de decumento? O cliente selecionado será removido!", "Hypestack", MessageBoxButtons.YesNo)
            ElseIf mCliente.Cod_Entidade <> Nothing And mDoc.Linhas(0).Designacao <> "" Then
                result = MessageBox.Show("Deseja alterar o tipo de decumento? Os artigos adicionados ao carrinho e o cliente selecionado serão removidos!", "Hypestack", MessageBoxButtons.YesNo)
            End If

            If result = DialogResult.Yes Then

                mDoc = New ClsDoc

                If Not UC_TipoDoc.ActiveRow Is Nothing Then
                    mIndex_TipoDoc = UC_TipoDoc.ActiveRow.Index
                End If

                Limpa_Cliente()
                Limpa_Totais()
                mDoc.QI = Nothing

                Panel_ViewArt.Controls.Clear()
                Panel_ViewArt.BackgroundImage = My.Resources.LogoWhite

                disable_buttons(True)

            ElseIf result = DialogResult.No Then
                UC_TipoDoc.Text = mTipo_Doc.Descritivo_Impressao
            End If
        End If


        mIndex_TipoDoc = UC_TipoDoc.ActiveRow.Index

        UC_TipoDoc.Rows(mIndex_TipoDoc).Selected = True
        mTipo_Doc = mListaTipo_Doc.Item(mIndex_TipoDoc)


        contador = mTipo_Doc.Contador


        Txt_Doc.Text = mTipo_Doc.FLG_Tipo_Doc + (contador + 1).ToString("0000") + "/" + mEmpresa.Item(0).Ano_Trabalho

        'UC_NumCliente.Rows(mIndex_Cliente).Selected = True

        UC_NumCliente.Enabled = True

        If mCliente.Cod_Entidade = Nothing Then
            UC_NumCliente.Text = ""
        End If


        mDoc.Num_Doc = Txt_Doc.Text

        Load_Rows()

    End Sub
    Private Sub UC_TipoPagamento_AfterCloseUp(sender As Object, e As EventArgs) Handles UC_TipoPagamento.AfterCloseUp, UC_TipoPagamento.Leave

        If Not UC_TipoPagamento.ActiveRow Is Nothing Then
            mIndex_TipoPagamento = UC_TipoPagamento.ActiveRow.Index
        End If


        UC_TipoPagamento.Rows(mIndex_TipoPagamento).Selected = True
        mTipo_Pagamento = mListaTipo_Pagamento.Item(mIndex_TipoPagamento)

        mDoc.Tipo_Pagamento = mTipo_Pagamento.Tipo_Pagamento

        Try
            Pic_MPagamento.Image = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesMetodosPagamento + mTipo_Pagamento.Imagem)
        Catch ex As Exception
            Pic_MPagamento.Image = My.Resources.NoImage
        End Try

    End Sub

    Private Sub Config_UC_NumCliente()
        UC_NumCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select
        UC_NumCliente.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None

        UC_NumCliente.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.FromArgb(250, 170, 3)
        UC_NumCliente.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.FromArgb(250, 170, 3)

        UC_NumCliente.DataSource = mListaClientes
        UC_NumCliente.DisplayMember = "Cod_Entidade"

        With UC_NumCliente.DisplayLayout.Bands(0)
            .Columns("FLG_Entidade").Hidden = True
            .Columns("Cod_Pais").Hidden = True
            .Columns("Utilizador").Hidden = True
            .Columns("Password").Hidden = True
            .Columns("FLG_Ativo").Hidden = True
            .Columns("Num_Telefone").Hidden = True
            .Columns("Num_Telemovel").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Nif").Hidden = True
            .Columns("Data_Registo").Hidden = True

            With .Columns("Cod_Entidade")
                .Hidden = False
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "N.º"
                .Width = 30
            End With

            With .Columns("Nome")
                .Hidden = False
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Nome"
                .Width = 200
            End With

        End With
    End Sub

    Private Sub Config_UG_QI()
        UG_QI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select
        UG_QI.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        UG_QI.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.FromArgb(250, 170, 3)
        UG_QI.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.FromArgb(250, 170, 3)
        UG_QI.DisplayLayout.Override.SelectedCellAppearance.BackColor = Color.White
        UG_QI.DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.White
        UG_QI.DisplayLayout.Override.SelectedCellAppearance.ForeColor = Color.Black
        UG_QI.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black



        UG_QI.DisplayLayout.EmptyRowSettings.ShowEmptyRows = False
        UG_QI.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.Horizontal


        With UG_QI.DisplayLayout.Bands(0)
            .Columns("Num_Doc").Hidden = True
            .Columns("Tipo_Iva").Hidden = True
            .Columns("V_Iva").Hidden = True
            .Columns("S_Iva").Hidden = True

            With .Columns("Taxa_IVA")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Taxa de IVA"
                .Width = 207
            End With

            With .Columns("strS_IVA")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Sujeito a IVA"
                .Width = 208
            End With

            With .Columns("strV_IVA")
                .Hidden = False
                .CellActivation = Activation.NoEdit
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Caption = "Valor do IVA"
                .Width = 208
            End With

        End With
    End Sub


    Sub Display_UG_QI()
        mDoc.QI = ClsQI.GetQI(mDoc.Linhas)

        UG_QI.DataSource = mDoc.QI
    End Sub

    Private Sub UC_NumCliente_AfterCloseUp(sender As Object, e As EventArgs) Handles UC_NumCliente.AfterCloseUp, UC_NumCliente.Leave
        If mCliente.Cod_Entidade.ToString <> UC_NumCliente.Text And mCliente.Cod_Entidade <> Nothing Then
            Dim result As DialogResult
            If mDoc.Linhas(0).Designacao = "" Then
                result = DialogResult.Yes
            Else
                result = MessageBox.Show("Deseja alterar o cliente? Os artigos adicionados ao carrinho serão removidos!", "Hypestack", MessageBoxButtons.YesNo)
            End If

            If result = DialogResult.Yes Then

                If Not UC_NumCliente.ActiveRow Is Nothing Then
                    mIndex_Cliente = UC_NumCliente.ActiveRow.Index
                End If

                mDoc = New ClsDoc
                mDoc.Num_Doc = Txt_Doc.Text

                Panel_ViewArt.Controls.Clear()
                Panel_ViewArt.BackgroundImage = My.Resources.LogoWhite


                disable_buttons(True)

                Limpa_Totais()
                mDoc.QI = Nothing
                Load_Rows()

            ElseIf result = DialogResult.No Then
                UC_NumCliente.Text = mCliente.Cod_Entidade

            End If
        End If
        Load_Cliente()
    End Sub



    Private Sub Load_Cliente()

        If Not UC_NumCliente.ActiveRow Is Nothing Then
            mIndex_Cliente = UC_NumCliente.ActiveRow.Index
        End If

        UC_NumCliente.Rows(mIndex_Cliente).Selected = True
        mCliente = mListaClientes(mIndex_Cliente)

        Txt_Nome.Text = mCliente.Nome
        Txt_Telefone.Text = mCliente.Num_Telefone
        Txt_Telemovel.Text = mCliente.Num_Telemovel
        Txt_NIF.Text = mCliente.NIF
        Txt_Email.Text = mCliente.Email

        Txt_Search.Enabled = True
        Panel_TxtSearch.Enabled = True
        Btn_Categorias.Enabled = True
        UTC_Tabelas.Enabled = True
        mDoc.Cod_Entidade = mCliente.Cod_Entidade

    End Sub

    Private Sub Limpa_Cliente()
        mIndex_Cliente = 0

        UC_NumCliente.Rows(mIndex_Cliente).Selected = True

        UC_NumCliente.Text = ""
        Txt_Nome.Text = ""
        Txt_Telefone.Text = ""
        Txt_Telemovel.Text = ""
        Txt_NIF.Text = ""
        Txt_Email.Text = ""

        mCliente = New ClsEntidades

        Txt_Search.Enabled = False
        Btn_Categorias.Enabled = False
        UTC_Tabelas.Enabled = False

    End Sub

    Private Sub Limpa_Totais()
        Txt_TotalIliquido.Text = ""
        Txt_TotalDesc.Text = ""
        Txt_TotalIVA.Text = ""
        Txt_TotalPagar.Text = ""
    End Sub

    Private Sub Load_UTCTabelas()
        UTC_Tabelas.Enabled = False
        UTC_Tabelas.Tabs(0).Text = "Carrinho"
        UTC_Tabelas.Tabs(1).Text = "IVA"
        UTC_Tabelas.Tabs(2).Text = "Finalizar Pedido"
    End Sub

    Public Shared Function Valida_Artigo() As Boolean
        Dim mReturn As Boolean = False
        Dim mCod_Artigo As String = UC_GetArtigo.Cod_Artigo

        For Each pLinhas As ClsLinhas In mDoc.Linhas
            If pLinhas.Cod_Artigo = mCod_Artigo And mCod_Artigo <> "" Then

                frmUI.mRowRepetida = frmUI.UG_Linhas.Rows(pLinhas.Num_Linha)

                mReturn = True
                Exit For
            End If
        Next

        Return mReturn
    End Function

    Public Shared Function Valida_Qtd() As Boolean
        Dim mReturn As Boolean = False
        Dim mArtigo As New List(Of ClsArtigos)
        Dim mIndex As Integer = mRowRepetida.Index

        mArtigo = mListaArtigos.FindAll(Function(x) _
    x.Cod_Artigo.Contains(UC_GetArtigo.Cod_Artigo))

        If mArtigo.Item(0).Stock > frmUI.UG_Linhas.Rows(mIndex).Cells("Quantidade").Value Then
            mReturn = True
        End If

        Return mReturn
    End Function

    Public Shared Sub Valida_Linha()

        For Each pLinhas As ClsLinhas In mDoc.Linhas
            If pLinhas.Designacao = "" Then

                frmUI.mRowVazia = frmUI.UG_Linhas.Rows(pLinhas.Num_Linha - 1)
                Exit For
            End If
        Next

    End Sub

    Private Sub UG_Linhas_CellChange(sender As Object, e As CellEventArgs) Handles UG_Linhas.CellChange

        If UG_Linhas.ActiveRow Is Nothing Then
            Exit Sub
        End If

        Dim mIndex As Integer = UG_Linhas.ActiveRow.Index

        If UG_Linhas.ActiveRow.Cells("Limpa").Value = False Then
            mDoc.Linhas(mIndex) = New ClsLinhas(mDoc.Num_Doc, mIndex + 1)
            UG_Linhas.ActiveRow.Cells("Limpa").Value = False
        End If

        UG_Linhas.ActiveRow.Update()
        UG_Linhas.DataSource = mDoc.Linhas
        UG_Linhas.Refresh()


        mTotais = New ClsTotais(mDoc.Linhas)

        Txt_TotalIliquido.Text = mTotais.Total_Iliquido & "€"
        Txt_TotalDesc.Text = mTotais.Total_Descontos & "€"
        Txt_TotalIVA.Text = mTotais.Total_IVA & "€"
        Txt_TotalPagar.Text = mTotais.Total_A_Pagar & "€"

        mDoc.QI = ClsQI.GetQI(mDoc.Linhas)
        Display_UG_QI()
    End Sub

    Sub Grava_Doc()
        mDoc.FLG_Tipo_Doc = mTipo_Doc.FLG_Tipo_Doc
        mDoc.Designacao = mTipo_Doc.Designacao & "-" & mDoc.Num_Doc
        mDoc.Totais = mTotais

        If Not ClsGrava.Grava_Documento(mDoc, mTipo_Doc) Then
            MsgBox("Documento nao gravado")
        Else
            MsgBox("Documento Gravado")
        End If
    End Sub

    Sub Novo_Doc()
        mDoc = New ClsDoc
        Txt_Doc.Text = mTipo_Doc.FLG_Tipo_Doc + (mTipo_Doc.Contador + 1).ToString("0000") + "/" + mEmpresa.Item(0).Ano_Trabalho
        Load_Rows()
        mTipo_Doc = mListaTipo_Doc(0)
        UC_TipoDoc.Focus()
        mCliente = mListaClientes(0)
        Limpa_Cliente()
        disable_buttons(True)
        Limpa_TtxtTotais()
        Panel_ViewArt.Controls.Clear()
        Panel_ViewArt.BackgroundImage = My.Resources.LogoWhite
        UTC_Tabelas.SelectedTab = UTC_Tabelas.Tabs(0)
        Display_UG_QI()
    End Sub

    Private Sub Btn_Gravar_Click(sender As Object, e As EventArgs) Handles Btn_Gravar.Click
        If mDoc.Linhas Is Nothing Or mDoc.Cod_Entidade = Nothing Or UC_TipoPagamento.Text = Nothing Then
            MsgBox("Erro ao gravar ducomento! Porfavor veja se inseriu todos os dados necessários.")
            Exit Sub
        End If
        Grava_Doc()
        Novo_Doc()
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        If mDoc.Linhas Is Nothing Or mDoc.Cod_Entidade = Nothing Or UC_TipoPagamento.Text = Nothing Then
            MsgBox("Erro ao gravar ducomento! Porfavor veja se inseriu todos os dados necessários.")
            Exit Sub
        End If
        Grava_Doc()
        Dim mxrFAT As New xrFat
        Dim mxrQI As New xrQI

        With mxrFAT
            .ObjectDataSource1.Parameters(0).Value = mDoc.Num_Doc
        End With

        With mxrQI
            .ObjectDataSource1.Parameters(0).Value = mDoc.Num_Doc
        End With



        Dim mfrm As New frmReport
        mfrm.DV1.DocumentSource = mxrFAT
        mfrm.ShowDialog()
        Novo_Doc()
    End Sub

    Private Sub Pic_LimpaFiltros_Click(sender As Object, e As EventArgs) Handles Pic_LimpaFiltros.Click
        UC_ViewCat.Categoria_Selct = ""
        UC_ViewCat.SubCategoria_Selct = ""
        Txt_Search.Text = "Procurar:"
        Btn_Categorias.Focus()
        Lbl_Categoria.Visible = False
        Lbl_SubCat.Visible = False
        Panel_ViewArt.BackgroundImage = My.Resources.LogoWhite

        Me.Panel_ViewArt.Controls.Clear()

        Btn_SubCategorias.Enabled = False
        Pic_LimpaFiltros.Visible = False
    End Sub

    Private Sub NumCliente_TextChanged(sender As Object, e As EventArgs) Handles UC_NumCliente.TextChanged
        Txt_NCliente.Text = UC_NumCliente.Text
    End Sub

    Private Sub NumCliente_Arrow(sender As Object, e As EventArgs) Handles picArrow_NCliente.Click
        UC_NumCliente.Focus()
        SendKeys.Send("{F4}")
    End Sub

    Private Sub NumCliente_CheckDroppedDownCombo(sender As Object, e As EventArgs) Handles UC_NumCliente.AfterDropDown, UC_NumCliente.AfterCloseUp
        If UC_NumCliente.IsDroppedDown Then
            picArrow_NCliente.Image = My.Resources.LineIcon
        Else
            picArrow_NCliente.Image = My.Resources.ArrowDownIcon
        End If
    End Sub

    Private Sub TipoDoc_TextChanged(sender As Object, e As EventArgs) Handles UC_TipoDoc.TextChanged
        Txt_TipoDoc.Text = UC_TipoDoc.Text
    End Sub

    Private Sub TipoDoc_Arrow(sender As Object, e As EventArgs) Handles picArrowTD.Click
        UC_TipoDoc.Focus()
        SendKeys.Send("{F4}")
    End Sub

    Private Sub TipoDoc_CheckDroppedDownCombo(sender As Object, e As EventArgs) Handles UC_TipoDoc.AfterDropDown, UC_TipoDoc.AfterCloseUp
        If UC_TipoDoc.IsDroppedDown Then
            picArrowTD.Image = My.Resources.LineIcon
        Else
            picArrowTD.Image = My.Resources.ArrowDownIcon
        End If
    End Sub


End Class