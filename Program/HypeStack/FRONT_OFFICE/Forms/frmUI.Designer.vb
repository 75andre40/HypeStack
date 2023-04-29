<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsLinhas", -1)
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Doc")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Linha")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Artigo")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quantidade")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strQuantidade")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strP_Final")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("P_Unitario")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("P_CDesconto")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_Iva")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("P_Final")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_Desconto")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Designacao")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Limpa")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsTipos_Doc", -1)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Tipo_Doc")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Designacao")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo_Impressao")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_ESC")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_DC")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Entidade")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Venda")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Compra")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Stock")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Serie")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUI))
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel_UGLinhas = New System.Windows.Forms.Panel()
        Me.UG_Linhas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UG_QI = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Pic_MPagamento = New System.Windows.Forms.PictureBox()
        Me.UC_TipoPagamento = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Btn_Gravar = New System.Windows.Forms.Button()
        Me.Panel_Totais = New System.Windows.Forms.Panel()
        Me.Txt_TotalIliquido = New System.Windows.Forms.TextBox()
        Me.Lbl_TotalIliquido = New System.Windows.Forms.Label()
        Me.Txt_TotalPagar = New System.Windows.Forms.TextBox()
        Me.Txt_TotalIVA = New System.Windows.Forms.TextBox()
        Me.Txt_TotalDesc = New System.Windows.Forms.TextBox()
        Me.Lbl_TotalPagar = New System.Windows.Forms.Label()
        Me.Lbl_TotalIVA = New System.Windows.Forms.Label()
        Me.Lbl_TotalDesc = New System.Windows.Forms.Label()
        Me.Lbl_Totais = New System.Windows.Forms.Label()
        Me.Panel_ViewArt = New System.Windows.Forms.Panel()
        Me.Lbl_Categoria = New System.Windows.Forms.Label()
        Me.Lbl_SubCat = New System.Windows.Forms.Label()
        Me.Timer_Delay = New System.Windows.Forms.Timer(Me.components)
        Me.UC_TipoDoc = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.LblDoc = New System.Windows.Forms.Label()
        Me.Panel_Cliente = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_NCliente = New DevExpress.XtraEditors.TextEdit()
        Me.picArrow_NCliente = New System.Windows.Forms.PictureBox()
        Me.Panel_TxtNome = New System.Windows.Forms.Panel()
        Me.Txt_Nome = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_TxtTelefone = New System.Windows.Forms.Panel()
        Me.Txt_Telefone = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_TxtTelemovel = New System.Windows.Forms.Panel()
        Me.Txt_Telemovel = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_TxtNif = New System.Windows.Forms.Panel()
        Me.Txt_Email = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_txtEmail = New System.Windows.Forms.Panel()
        Me.Txt_NIF = New DevExpress.XtraEditors.TextEdit()
        Me.Lbl_Nif = New System.Windows.Forms.Label()
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Lbl_Telemovel = New System.Windows.Forms.Label()
        Me.Lbl_Telefone = New System.Windows.Forms.Label()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.Lbl_NumCliente = New System.Windows.Forms.Label()
        Me.UC_NumCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Txt_Doc = New DevExpress.XtraEditors.TextEdit()
        Me.UTC_Tabelas = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.CMS_Qtd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TxtMenu_Qtd = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnMenu_More = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMenu_Less = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMenu_Confirmar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMenu_Cancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Categorias = New System.Windows.Forms.Label()
        Me.Btn_SubCategorias = New System.Windows.Forms.Label()
        Me.Panel_TxtSearch = New System.Windows.Forms.Panel()
        Me.Txt_Search = New DevExpress.XtraEditors.TextEdit()
        Me.Pic_LimpaFiltros = New System.Windows.Forms.PictureBox()
        Me.Panel_TxtDoc = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picArrowTD = New System.Windows.Forms.PictureBox()
        Me.Txt_TipoDoc = New DevExpress.XtraEditors.TextEdit()
        Me.ClsLinhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClsQIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClsTiposPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClsTiposDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel_UGLinhas.SuspendLayout()
        CType(Me.UG_Linhas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UG_QI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Pic_MPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UC_TipoPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Totais.SuspendLayout()
        CType(Me.UC_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Cliente.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Txt_NCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrow_NCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TxtNome.SuspendLayout()
        CType(Me.Txt_Nome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TxtTelefone.SuspendLayout()
        CType(Me.Txt_Telefone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TxtTelemovel.SuspendLayout()
        CType(Me.Txt_Telemovel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TxtNif.SuspendLayout()
        CType(Me.Txt_Email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_txtEmail.SuspendLayout()
        CType(Me.Txt_NIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UC_NumCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Doc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UTC_Tabelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UTC_Tabelas.SuspendLayout()
        Me.CMS_Qtd.SuspendLayout()
        Me.Panel_TxtSearch.SuspendLayout()
        CType(Me.Txt_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_LimpaFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TxtDoc.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picArrowTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_TipoDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsLinhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsQIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsTiposPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsTiposDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel_UGLinhas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(625, 214)
        '
        'Panel_UGLinhas
        '
        Me.Panel_UGLinhas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_UGLinhas.BackColor = System.Drawing.Color.White
        Me.Panel_UGLinhas.Controls.Add(Me.UG_Linhas)
        Me.Panel_UGLinhas.Location = New System.Drawing.Point(0, 0)
        Me.Panel_UGLinhas.Name = "Panel_UGLinhas"
        Me.Panel_UGLinhas.Size = New System.Drawing.Size(625, 215)
        Me.Panel_UGLinhas.TabIndex = 7
        '
        'UG_Linhas
        '
        Me.UG_Linhas.DataSource = Me.ClsLinhasBindingSource
        UltraGridColumn75.Header.VisiblePosition = 0
        UltraGridColumn76.Header.VisiblePosition = 1
        UltraGridColumn77.Header.VisiblePosition = 2
        UltraGridColumn78.Header.VisiblePosition = 4
        UltraGridColumn79.Header.VisiblePosition = 5
        UltraGridColumn80.Header.VisiblePosition = 10
        UltraGridColumn81.Header.VisiblePosition = 8
        UltraGridColumn82.Header.VisiblePosition = 9
        UltraGridColumn83.Header.VisiblePosition = 7
        UltraGridColumn84.Header.VisiblePosition = 11
        UltraGridColumn85.Header.VisiblePosition = 6
        UltraGridColumn86.Header.VisiblePosition = 3
        UltraGridColumn87.Header.VisiblePosition = 12
        UltraGridColumn88.Header.VisiblePosition = 13
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88})
        Me.UG_Linhas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UG_Linhas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UG_Linhas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UG_Linhas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.UG_Linhas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UG_Linhas.DisplayLayout.MaxColScrollRegions = 1
        Me.UG_Linhas.DisplayLayout.MaxRowScrollRegions = 1
        Me.UG_Linhas.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UG_Linhas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.UG_Linhas.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.UG_Linhas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UG_Linhas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UG_Linhas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UG_Linhas.DisplayLayout.Override.CellPadding = 0
        Me.UG_Linhas.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Me.UG_Linhas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UG_Linhas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UG_Linhas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.UG_Linhas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UG_Linhas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UG_Linhas.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UG_Linhas.Location = New System.Drawing.Point(-1, 0)
        Me.UG_Linhas.Name = "UG_Linhas"
        Me.UG_Linhas.Size = New System.Drawing.Size(627, 214)
        Me.UG_Linhas.TabIndex = 0
        Me.UG_Linhas.Text = "UltraGrid1"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UG_QI)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(625, 214)
        '
        'UG_QI
        '
        Me.UG_QI.DataSource = Me.ClsQIBindingSource
        Me.UG_QI.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UG_QI.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UG_QI.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UG_QI.DisplayLayout.MaxColScrollRegions = 1
        Me.UG_QI.DisplayLayout.MaxRowScrollRegions = 1
        Me.UG_QI.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UG_QI.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UG_QI.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UG_QI.DisplayLayout.Override.CellPadding = 0
        Me.UG_QI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UG_QI.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UG_QI.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.UG_QI.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UG_QI.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UG_QI.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UG_QI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UG_QI.Location = New System.Drawing.Point(0, 0)
        Me.UG_QI.Name = "UG_QI"
        Me.UG_QI.Size = New System.Drawing.Size(625, 214)
        Me.UG_QI.TabIndex = 0
        Me.UG_QI.Text = "UltraGrid1"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Pic_MPagamento)
        Me.UltraTabPageControl3.Controls.Add(Me.UC_TipoPagamento)
        Me.UltraTabPageControl3.Controls.Add(Me.Btn_Imprimir)
        Me.UltraTabPageControl3.Controls.Add(Me.Btn_Gravar)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel_Totais)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(625, 214)
        '
        'Pic_MPagamento
        '
        Me.Pic_MPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_MPagamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pic_MPagamento.Location = New System.Drawing.Point(473, 40)
        Me.Pic_MPagamento.Name = "Pic_MPagamento"
        Me.Pic_MPagamento.Size = New System.Drawing.Size(100, 78)
        Me.Pic_MPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_MPagamento.TabIndex = 16
        Me.Pic_MPagamento.TabStop = False
        '
        'UC_TipoPagamento
        '
        Me.UC_TipoPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_TipoPagamento.DataSource = Me.ClsTiposPagamentoBindingSource
        Me.UC_TipoPagamento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UC_TipoPagamento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UC_TipoPagamento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UC_TipoPagamento.DisplayLayout.MaxColScrollRegions = 1
        Me.UC_TipoPagamento.DisplayLayout.MaxRowScrollRegions = 1
        Me.UC_TipoPagamento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UC_TipoPagamento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UC_TipoPagamento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UC_TipoPagamento.DisplayLayout.Override.CellPadding = 0
        Me.UC_TipoPagamento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UC_TipoPagamento.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UC_TipoPagamento.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.UC_TipoPagamento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UC_TipoPagamento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UC_TipoPagamento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UC_TipoPagamento.Location = New System.Drawing.Point(336, 69)
        Me.UC_TipoPagamento.Name = "UC_TipoPagamento"
        Me.UC_TipoPagamento.Size = New System.Drawing.Size(94, 23)
        Me.UC_TipoPagamento.TabIndex = 15
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Location = New System.Drawing.Point(479, 144)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(94, 31)
        Me.Btn_Imprimir.TabIndex = 14
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Btn_Gravar
        '
        Me.Btn_Gravar.Location = New System.Drawing.Point(336, 144)
        Me.Btn_Gravar.Name = "Btn_Gravar"
        Me.Btn_Gravar.Size = New System.Drawing.Size(94, 29)
        Me.Btn_Gravar.TabIndex = 13
        Me.Btn_Gravar.Text = "Gravar"
        Me.Btn_Gravar.UseVisualStyleBackColor = True
        '
        'Panel_Totais
        '
        Me.Panel_Totais.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Totais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Totais.Controls.Add(Me.Txt_TotalIliquido)
        Me.Panel_Totais.Controls.Add(Me.Lbl_TotalIliquido)
        Me.Panel_Totais.Controls.Add(Me.Txt_TotalPagar)
        Me.Panel_Totais.Controls.Add(Me.Txt_TotalIVA)
        Me.Panel_Totais.Controls.Add(Me.Txt_TotalDesc)
        Me.Panel_Totais.Controls.Add(Me.Lbl_TotalPagar)
        Me.Panel_Totais.Controls.Add(Me.Lbl_TotalIVA)
        Me.Panel_Totais.Controls.Add(Me.Lbl_TotalDesc)
        Me.Panel_Totais.Controls.Add(Me.Lbl_Totais)
        Me.Panel_Totais.Location = New System.Drawing.Point(26, 33)
        Me.Panel_Totais.Name = "Panel_Totais"
        Me.Panel_Totais.Size = New System.Drawing.Size(269, 147)
        Me.Panel_Totais.TabIndex = 0
        '
        'Txt_TotalIliquido
        '
        Me.Txt_TotalIliquido.Enabled = False
        Me.Txt_TotalIliquido.Location = New System.Drawing.Point(140, 36)
        Me.Txt_TotalIliquido.Name = "Txt_TotalIliquido"
        Me.Txt_TotalIliquido.ReadOnly = True
        Me.Txt_TotalIliquido.Size = New System.Drawing.Size(113, 20)
        Me.Txt_TotalIliquido.TabIndex = 21
        Me.Txt_TotalIliquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl_TotalIliquido
        '
        Me.Lbl_TotalIliquido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalIliquido.AutoSize = True
        Me.Lbl_TotalIliquido.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalIliquido.Location = New System.Drawing.Point(15, 36)
        Me.Lbl_TotalIliquido.Name = "Lbl_TotalIliquido"
        Me.Lbl_TotalIliquido.Size = New System.Drawing.Size(112, 16)
        Me.Lbl_TotalIliquido.TabIndex = 20
        Me.Lbl_TotalIliquido.Text = "Total Ilíquido:"
        '
        'Txt_TotalPagar
        '
        Me.Txt_TotalPagar.Enabled = False
        Me.Txt_TotalPagar.Location = New System.Drawing.Point(140, 117)
        Me.Txt_TotalPagar.Name = "Txt_TotalPagar"
        Me.Txt_TotalPagar.ReadOnly = True
        Me.Txt_TotalPagar.Size = New System.Drawing.Size(113, 20)
        Me.Txt_TotalPagar.TabIndex = 19
        Me.Txt_TotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_TotalIVA
        '
        Me.Txt_TotalIVA.Enabled = False
        Me.Txt_TotalIVA.Location = New System.Drawing.Point(140, 89)
        Me.Txt_TotalIVA.Name = "Txt_TotalIVA"
        Me.Txt_TotalIVA.ReadOnly = True
        Me.Txt_TotalIVA.Size = New System.Drawing.Size(113, 20)
        Me.Txt_TotalIVA.TabIndex = 18
        Me.Txt_TotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_TotalDesc
        '
        Me.Txt_TotalDesc.Enabled = False
        Me.Txt_TotalDesc.Location = New System.Drawing.Point(140, 61)
        Me.Txt_TotalDesc.Name = "Txt_TotalDesc"
        Me.Txt_TotalDesc.ReadOnly = True
        Me.Txt_TotalDesc.Size = New System.Drawing.Size(113, 20)
        Me.Txt_TotalDesc.TabIndex = 17
        Me.Txt_TotalDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl_TotalPagar
        '
        Me.Lbl_TotalPagar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalPagar.AutoSize = True
        Me.Lbl_TotalPagar.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalPagar.Location = New System.Drawing.Point(29, 117)
        Me.Lbl_TotalPagar.Name = "Lbl_TotalPagar"
        Me.Lbl_TotalPagar.Size = New System.Drawing.Size(105, 16)
        Me.Lbl_TotalPagar.TabIndex = 3
        Me.Lbl_TotalPagar.Text = "Total a pagar:"
        '
        'Lbl_TotalIVA
        '
        Me.Lbl_TotalIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalIVA.AutoSize = True
        Me.Lbl_TotalIVA.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalIVA.Location = New System.Drawing.Point(57, 89)
        Me.Lbl_TotalIVA.Name = "Lbl_TotalIVA"
        Me.Lbl_TotalIVA.Size = New System.Drawing.Size(77, 16)
        Me.Lbl_TotalIVA.TabIndex = 2
        Me.Lbl_TotalIVA.Text = "Total IVA:"
        '
        'Lbl_TotalDesc
        '
        Me.Lbl_TotalDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalDesc.AutoSize = True
        Me.Lbl_TotalDesc.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalDesc.Location = New System.Drawing.Point(15, 61)
        Me.Lbl_TotalDesc.Name = "Lbl_TotalDesc"
        Me.Lbl_TotalDesc.Size = New System.Drawing.Size(119, 16)
        Me.Lbl_TotalDesc.TabIndex = 1
        Me.Lbl_TotalDesc.Text = "Total Descontos:"
        '
        'Lbl_Totais
        '
        Me.Lbl_Totais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Totais.AutoSize = True
        Me.Lbl_Totais.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Totais.Location = New System.Drawing.Point(3, 3)
        Me.Lbl_Totais.Name = "Lbl_Totais"
        Me.Lbl_Totais.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_Totais.TabIndex = 0
        Me.Lbl_Totais.Text = "Totais"
        '
        'Panel_ViewArt
        '
        Me.Panel_ViewArt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_ViewArt.BackColor = System.Drawing.Color.Transparent
        Me.Panel_ViewArt.BackgroundImage = Global.FCT_2021.My.Resources.Resources.LogoWhite
        Me.Panel_ViewArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_ViewArt.Location = New System.Drawing.Point(0, 253)
        Me.Panel_ViewArt.Name = "Panel_ViewArt"
        Me.Panel_ViewArt.Size = New System.Drawing.Size(1344, 377)
        Me.Panel_ViewArt.TabIndex = 0
        '
        'Lbl_Categoria
        '
        Me.Lbl_Categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Categoria.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Categoria.Location = New System.Drawing.Point(1073, 119)
        Me.Lbl_Categoria.Name = "Lbl_Categoria"
        Me.Lbl_Categoria.Size = New System.Drawing.Size(254, 17)
        Me.Lbl_Categoria.TabIndex = 3
        Me.Lbl_Categoria.Text = "Label1"
        Me.Lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_Categoria.Visible = False
        '
        'Lbl_SubCat
        '
        Me.Lbl_SubCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_SubCat.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SubCat.Location = New System.Drawing.Point(1073, 148)
        Me.Lbl_SubCat.Name = "Lbl_SubCat"
        Me.Lbl_SubCat.Size = New System.Drawing.Size(254, 17)
        Me.Lbl_SubCat.TabIndex = 4
        Me.Lbl_SubCat.Text = "Label2"
        Me.Lbl_SubCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_SubCat.Visible = False
        '
        'Timer_Delay
        '
        Me.Timer_Delay.Interval = 800
        '
        'UC_TipoDoc
        '
        Me.UC_TipoDoc.DataSource = Me.ClsTiposDocBindingSource
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn90.Header.VisiblePosition = 1
        UltraGridColumn91.Header.VisiblePosition = 2
        UltraGridColumn92.Header.VisiblePosition = 3
        UltraGridColumn93.Header.VisiblePosition = 4
        UltraGridColumn94.Header.VisiblePosition = 5
        UltraGridColumn95.Header.VisiblePosition = 6
        UltraGridColumn96.Header.VisiblePosition = 7
        UltraGridColumn97.Header.VisiblePosition = 8
        UltraGridColumn98.Header.VisiblePosition = 9
        UltraGridColumn99.Header.VisiblePosition = 10
        UltraGridColumn100.Header.VisiblePosition = 11
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100})
        Me.UC_TipoDoc.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UC_TipoDoc.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UC_TipoDoc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UC_TipoDoc.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UC_TipoDoc.DisplayLayout.MaxColScrollRegions = 1
        Me.UC_TipoDoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.UC_TipoDoc.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UC_TipoDoc.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UC_TipoDoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UC_TipoDoc.DisplayLayout.Override.CellPadding = 0
        Me.UC_TipoDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UC_TipoDoc.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UC_TipoDoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.UC_TipoDoc.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UC_TipoDoc.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UC_TipoDoc.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UC_TipoDoc.DisplayMember = "FLG_Tipo_Doc"
        Me.UC_TipoDoc.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.UC_TipoDoc.LimitToList = True
        Me.UC_TipoDoc.Location = New System.Drawing.Point(27, 12)
        Me.UC_TipoDoc.Name = "UC_TipoDoc"
        Me.UC_TipoDoc.Size = New System.Drawing.Size(134, 23)
        Me.UC_TipoDoc.TabIndex = 2
        '
        'LblDoc
        '
        Me.LblDoc.AutoSize = True
        Me.LblDoc.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblDoc.Location = New System.Drawing.Point(258, 13)
        Me.LblDoc.Name = "LblDoc"
        Me.LblDoc.Size = New System.Drawing.Size(40, 17)
        Me.LblDoc.TabIndex = 0
        Me.LblDoc.Text = "Doc:"
        '
        'Panel_Cliente
        '
        Me.Panel_Cliente.Controls.Add(Me.Panel1)
        Me.Panel_Cliente.Controls.Add(Me.Panel_TxtNome)
        Me.Panel_Cliente.Controls.Add(Me.Panel_TxtTelefone)
        Me.Panel_Cliente.Controls.Add(Me.Panel_TxtTelemovel)
        Me.Panel_Cliente.Controls.Add(Me.Panel_TxtNif)
        Me.Panel_Cliente.Controls.Add(Me.Panel_txtEmail)
        Me.Panel_Cliente.Controls.Add(Me.Lbl_Nif)
        Me.Panel_Cliente.Controls.Add(Me.Lbl_Nome)
        Me.Panel_Cliente.Controls.Add(Me.Lbl_Telemovel)
        Me.Panel_Cliente.Controls.Add(Me.Lbl_Telefone)
        Me.Panel_Cliente.Controls.Add(Me.Lbl_Email)
        Me.Panel_Cliente.Controls.Add(Me.Lbl_NumCliente)
        Me.Panel_Cliente.Controls.Add(Me.UC_NumCliente)
        Me.Panel_Cliente.Location = New System.Drawing.Point(12, 76)
        Me.Panel_Cliente.Name = "Panel_Cliente"
        Me.Panel_Cliente.Size = New System.Drawing.Size(395, 170)
        Me.Panel_Cliente.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Txt_NCliente)
        Me.Panel1.Controls.Add(Me.picArrow_NCliente)
        Me.Panel1.Location = New System.Drawing.Point(13, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 26)
        Me.Panel1.TabIndex = 24
        '
        'Txt_NCliente
        '
        Me.Txt_NCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_NCliente.EditValue = ""
        Me.Txt_NCliente.Enabled = False
        Me.Txt_NCliente.Location = New System.Drawing.Point(3, 3)
        Me.Txt_NCliente.Name = "Txt_NCliente"
        Me.Txt_NCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_NCliente.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_NCliente.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_NCliente.Properties.Appearance.Options.UseFont = True
        Me.Txt_NCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_NCliente.Size = New System.Drawing.Size(85, 20)
        Me.Txt_NCliente.TabIndex = 20
        '
        'picArrow_NCliente
        '
        Me.picArrow_NCliente.BackColor = System.Drawing.Color.Transparent
        Me.picArrow_NCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picArrow_NCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picArrow_NCliente.Image = Global.FCT_2021.My.Resources.Resources.ArrowDownIcon
        Me.picArrow_NCliente.Location = New System.Drawing.Point(96, 1)
        Me.picArrow_NCliente.Name = "picArrow_NCliente"
        Me.picArrow_NCliente.Size = New System.Drawing.Size(24, 24)
        Me.picArrow_NCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrow_NCliente.TabIndex = 18
        Me.picArrow_NCliente.TabStop = False
        '
        'Panel_TxtNome
        '
        Me.Panel_TxtNome.BackColor = System.Drawing.Color.Transparent
        Me.Panel_TxtNome.BackgroundImage = CType(resources.GetObject("Panel_TxtNome.BackgroundImage"), System.Drawing.Image)
        Me.Panel_TxtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TxtNome.Controls.Add(Me.Txt_Nome)
        Me.Panel_TxtNome.Enabled = False
        Me.Panel_TxtNome.Location = New System.Drawing.Point(180, 25)
        Me.Panel_TxtNome.Name = "Panel_TxtNome"
        Me.Panel_TxtNome.Size = New System.Drawing.Size(201, 26)
        Me.Panel_TxtNome.TabIndex = 23
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Nome.EditValue = ""
        Me.Txt_Nome.Enabled = False
        Me.Txt_Nome.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_Nome.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_Nome.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_Nome.Properties.Appearance.Options.UseFont = True
        Me.Txt_Nome.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_Nome.Size = New System.Drawing.Size(192, 20)
        Me.Txt_Nome.TabIndex = 18
        '
        'Panel_TxtTelefone
        '
        Me.Panel_TxtTelefone.BackColor = System.Drawing.Color.Transparent
        Me.Panel_TxtTelefone.BackgroundImage = CType(resources.GetObject("Panel_TxtTelefone.BackgroundImage"), System.Drawing.Image)
        Me.Panel_TxtTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TxtTelefone.Controls.Add(Me.Txt_Telefone)
        Me.Panel_TxtTelefone.Enabled = False
        Me.Panel_TxtTelefone.Location = New System.Drawing.Point(180, 78)
        Me.Panel_TxtTelefone.Name = "Panel_TxtTelefone"
        Me.Panel_TxtTelefone.Size = New System.Drawing.Size(201, 26)
        Me.Panel_TxtTelefone.TabIndex = 22
        '
        'Txt_Telefone
        '
        Me.Txt_Telefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Telefone.EditValue = ""
        Me.Txt_Telefone.Enabled = False
        Me.Txt_Telefone.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Telefone.Name = "Txt_Telefone"
        Me.Txt_Telefone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_Telefone.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_Telefone.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_Telefone.Properties.Appearance.Options.UseFont = True
        Me.Txt_Telefone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_Telefone.Size = New System.Drawing.Size(192, 20)
        Me.Txt_Telefone.TabIndex = 18
        '
        'Panel_TxtTelemovel
        '
        Me.Panel_TxtTelemovel.BackColor = System.Drawing.Color.Transparent
        Me.Panel_TxtTelemovel.BackgroundImage = CType(resources.GetObject("Panel_TxtTelemovel.BackgroundImage"), System.Drawing.Image)
        Me.Panel_TxtTelemovel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TxtTelemovel.Controls.Add(Me.Txt_Telemovel)
        Me.Panel_TxtTelemovel.Enabled = False
        Me.Panel_TxtTelemovel.Location = New System.Drawing.Point(12, 78)
        Me.Panel_TxtTelemovel.Name = "Panel_TxtTelemovel"
        Me.Panel_TxtTelemovel.Size = New System.Drawing.Size(125, 26)
        Me.Panel_TxtTelemovel.TabIndex = 21
        '
        'Txt_Telemovel
        '
        Me.Txt_Telemovel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Telemovel.EditValue = ""
        Me.Txt_Telemovel.Enabled = False
        Me.Txt_Telemovel.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Telemovel.Name = "Txt_Telemovel"
        Me.Txt_Telemovel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_Telemovel.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_Telemovel.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_Telemovel.Properties.Appearance.Options.UseFont = True
        Me.Txt_Telemovel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_Telemovel.Size = New System.Drawing.Size(116, 20)
        Me.Txt_Telemovel.TabIndex = 18
        '
        'Panel_TxtNif
        '
        Me.Panel_TxtNif.BackColor = System.Drawing.Color.Transparent
        Me.Panel_TxtNif.BackgroundImage = CType(resources.GetObject("Panel_TxtNif.BackgroundImage"), System.Drawing.Image)
        Me.Panel_TxtNif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TxtNif.Controls.Add(Me.Txt_Email)
        Me.Panel_TxtNif.Enabled = False
        Me.Panel_TxtNif.Location = New System.Drawing.Point(180, 135)
        Me.Panel_TxtNif.Name = "Panel_TxtNif"
        Me.Panel_TxtNif.Size = New System.Drawing.Size(201, 26)
        Me.Panel_TxtNif.TabIndex = 20
        '
        'Txt_Email
        '
        Me.Txt_Email.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Email.EditValue = ""
        Me.Txt_Email.Enabled = False
        Me.Txt_Email.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_Email.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_Email.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_Email.Properties.Appearance.Options.UseFont = True
        Me.Txt_Email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_Email.Size = New System.Drawing.Size(192, 20)
        Me.Txt_Email.TabIndex = 18
        '
        'Panel_txtEmail
        '
        Me.Panel_txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.Panel_txtEmail.BackgroundImage = CType(resources.GetObject("Panel_txtEmail.BackgroundImage"), System.Drawing.Image)
        Me.Panel_txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_txtEmail.Controls.Add(Me.Txt_NIF)
        Me.Panel_txtEmail.Enabled = False
        Me.Panel_txtEmail.Location = New System.Drawing.Point(12, 135)
        Me.Panel_txtEmail.Name = "Panel_txtEmail"
        Me.Panel_txtEmail.Size = New System.Drawing.Size(125, 26)
        Me.Panel_txtEmail.TabIndex = 17
        '
        'Txt_NIF
        '
        Me.Txt_NIF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_NIF.EditValue = ""
        Me.Txt_NIF.Enabled = False
        Me.Txt_NIF.Location = New System.Drawing.Point(3, 3)
        Me.Txt_NIF.Name = "Txt_NIF"
        Me.Txt_NIF.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_NIF.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_NIF.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_NIF.Properties.Appearance.Options.UseFont = True
        Me.Txt_NIF.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_NIF.Size = New System.Drawing.Size(116, 20)
        Me.Txt_NIF.TabIndex = 18
        '
        'Lbl_Nif
        '
        Me.Lbl_Nif.AutoSize = True
        Me.Lbl_Nif.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Nif.Location = New System.Drawing.Point(180, 113)
        Me.Lbl_Nif.Name = "Lbl_Nif"
        Me.Lbl_Nif.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_Nif.TabIndex = 19
        Me.Lbl_Nif.Text = "Email: "
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.AutoSize = True
        Me.Lbl_Nome.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Nome.Location = New System.Drawing.Point(177, 5)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(48, 17)
        Me.Lbl_Nome.TabIndex = 11
        Me.Lbl_Nome.Text = "Nome:"
        '
        'Lbl_Telemovel
        '
        Me.Lbl_Telemovel.AutoSize = True
        Me.Lbl_Telemovel.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telemovel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Telemovel.Location = New System.Drawing.Point(9, 58)
        Me.Lbl_Telemovel.Name = "Lbl_Telemovel"
        Me.Lbl_Telemovel.Size = New System.Drawing.Size(128, 17)
        Me.Lbl_Telemovel.TabIndex = 13
        Me.Lbl_Telemovel.Text = "Num. Telemóvel:"
        '
        'Lbl_Telefone
        '
        Me.Lbl_Telefone.AutoSize = True
        Me.Lbl_Telefone.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Telefone.Location = New System.Drawing.Point(177, 58)
        Me.Lbl_Telefone.Name = "Lbl_Telefone"
        Me.Lbl_Telefone.Size = New System.Drawing.Size(120, 17)
        Me.Lbl_Telefone.TabIndex = 15
        Me.Lbl_Telefone.Text = "Num. Telefone:"
        '
        'Lbl_Email
        '
        Me.Lbl_Email.AutoSize = True
        Me.Lbl_Email.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Email.Location = New System.Drawing.Point(10, 113)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_Email.TabIndex = 17
        Me.Lbl_Email.Text = "NIF:"
        '
        'Lbl_NumCliente
        '
        Me.Lbl_NumCliente.AutoSize = True
        Me.Lbl_NumCliente.Font = New System.Drawing.Font("Cascadia Code SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NumCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_NumCliente.Location = New System.Drawing.Point(9, 5)
        Me.Lbl_NumCliente.Name = "Lbl_NumCliente"
        Me.Lbl_NumCliente.Size = New System.Drawing.Size(112, 17)
        Me.Lbl_NumCliente.TabIndex = 10
        Me.Lbl_NumCliente.Text = "Num. Cliente:"
        '
        'UC_NumCliente
        '
        Me.UC_NumCliente.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UC_NumCliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UC_NumCliente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UC_NumCliente.DisplayLayout.MaxColScrollRegions = 1
        Me.UC_NumCliente.DisplayLayout.MaxRowScrollRegions = 1
        Me.UC_NumCliente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UC_NumCliente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UC_NumCliente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UC_NumCliente.DisplayLayout.Override.CellPadding = 0
        Me.UC_NumCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UC_NumCliente.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UC_NumCliente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.UC_NumCliente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UC_NumCliente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UC_NumCliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UC_NumCliente.Enabled = False
        Me.UC_NumCliente.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.UC_NumCliente.LimitToList = True
        Me.UC_NumCliente.Location = New System.Drawing.Point(20, 27)
        Me.UC_NumCliente.MaxDropDownItems = 5
        Me.UC_NumCliente.Name = "UC_NumCliente"
        Me.UC_NumCliente.Size = New System.Drawing.Size(81, 23)
        Me.UC_NumCliente.TabIndex = 0
        '
        'Txt_Doc
        '
        Me.Txt_Doc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Doc.EditValue = ""
        Me.Txt_Doc.Enabled = False
        Me.Txt_Doc.Location = New System.Drawing.Point(4, 3)
        Me.Txt_Doc.Name = "Txt_Doc"
        Me.Txt_Doc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_Doc.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_Doc.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_Doc.Properties.Appearance.Options.UseFont = True
        Me.Txt_Doc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_Doc.Size = New System.Drawing.Size(88, 20)
        Me.Txt_Doc.TabIndex = 15
        '
        'UTC_Tabelas
        '
        Me.UTC_Tabelas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UTC_Tabelas.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UTC_Tabelas.Controls.Add(Me.UltraTabPageControl1)
        Me.UTC_Tabelas.Controls.Add(Me.UltraTabPageControl2)
        Me.UTC_Tabelas.Controls.Add(Me.UltraTabPageControl3)
        Me.UTC_Tabelas.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.UTC_Tabelas.Location = New System.Drawing.Point(425, 9)
        Me.UTC_Tabelas.Name = "UTC_Tabelas"
        Me.UTC_Tabelas.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UTC_Tabelas.Size = New System.Drawing.Size(627, 237)
        Me.UTC_Tabelas.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.UTC_Tabelas.TabIndex = 6
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "tab1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "tab2"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "tab3"
        Me.UTC_Tabelas.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(625, 214)
        '
        'CMS_Qtd
        '
        Me.CMS_Qtd.AutoClose = False
        Me.CMS_Qtd.AutoSize = False
        Me.CMS_Qtd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtMenu_Qtd, Me.ToolStripSeparator1, Me.BtnMenu_More, Me.BtnMenu_Less, Me.BtnMenu_Confirmar, Me.BtnMenu_Cancelar})
        Me.CMS_Qtd.Name = "CMS_Qtd"
        Me.CMS_Qtd.ShowImageMargin = False
        Me.CMS_Qtd.Size = New System.Drawing.Size(120, 130)
        '
        'TxtMenu_Qtd
        '
        Me.TxtMenu_Qtd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtMenu_Qtd.Name = "TxtMenu_Qtd"
        Me.TxtMenu_Qtd.Size = New System.Drawing.Size(100, 23)
        Me.TxtMenu_Qtd.Text = "1"
        Me.TxtMenu_Qtd.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(116, 6)
        '
        'BtnMenu_More
        '
        Me.BtnMenu_More.Name = "BtnMenu_More"
        Me.BtnMenu_More.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_More.Text = "               +"
        '
        'BtnMenu_Less
        '
        Me.BtnMenu_Less.Name = "BtnMenu_Less"
        Me.BtnMenu_Less.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_Less.Text = "               -"
        '
        'BtnMenu_Confirmar
        '
        Me.BtnMenu_Confirmar.Name = "BtnMenu_Confirmar"
        Me.BtnMenu_Confirmar.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_Confirmar.Text = "        Confirmar"
        '
        'BtnMenu_Cancelar
        '
        Me.BtnMenu_Cancelar.Name = "BtnMenu_Cancelar"
        Me.BtnMenu_Cancelar.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_Cancelar.Text = "         Cancelar"
        '
        'Btn_Categorias
        '
        Me.Btn_Categorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Categorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Categorias.Enabled = False
        Me.Btn_Categorias.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Btn_Categorias.Image = CType(resources.GetObject("Btn_Categorias.Image"), System.Drawing.Image)
        Me.Btn_Categorias.Location = New System.Drawing.Point(1070, 36)
        Me.Btn_Categorias.Name = "Btn_Categorias"
        Me.Btn_Categorias.Size = New System.Drawing.Size(110, 29)
        Me.Btn_Categorias.TabIndex = 3
        Me.Btn_Categorias.Text = "Categorias"
        Me.Btn_Categorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_SubCategorias
        '
        Me.Btn_SubCategorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_SubCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SubCategorias.Enabled = False
        Me.Btn_SubCategorias.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Btn_SubCategorias.Image = CType(resources.GetObject("Btn_SubCategorias.Image"), System.Drawing.Image)
        Me.Btn_SubCategorias.Location = New System.Drawing.Point(1217, 36)
        Me.Btn_SubCategorias.Name = "Btn_SubCategorias"
        Me.Btn_SubCategorias.Size = New System.Drawing.Size(110, 29)
        Me.Btn_SubCategorias.TabIndex = 4
        Me.Btn_SubCategorias.Text = "SubCategorias"
        Me.Btn_SubCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_TxtSearch
        '
        Me.Panel_TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_TxtSearch.BackColor = System.Drawing.Color.Transparent
        Me.Panel_TxtSearch.BackgroundImage = Global.FCT_2021.My.Resources.Resources.TextBox_Search
        Me.Panel_TxtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TxtSearch.Controls.Add(Me.Txt_Search)
        Me.Panel_TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel_TxtSearch.Enabled = False
        Me.Panel_TxtSearch.Location = New System.Drawing.Point(1073, 221)
        Me.Panel_TxtSearch.Name = "Panel_TxtSearch"
        Me.Panel_TxtSearch.Size = New System.Drawing.Size(254, 25)
        Me.Panel_TxtSearch.TabIndex = 13
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.EditValue = "Procurar:"
        Me.Txt_Search.Enabled = False
        Me.Txt_Search.Location = New System.Drawing.Point(3, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_Search.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_Search.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_Search.Properties.Appearance.Options.UseFont = True
        Me.Txt_Search.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_Search.Size = New System.Drawing.Size(248, 20)
        Me.Txt_Search.TabIndex = 12
        '
        'Pic_LimpaFiltros
        '
        Me.Pic_LimpaFiltros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_LimpaFiltros.BackColor = System.Drawing.Color.Transparent
        Me.Pic_LimpaFiltros.BackgroundImage = CType(resources.GetObject("Pic_LimpaFiltros.BackgroundImage"), System.Drawing.Image)
        Me.Pic_LimpaFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_LimpaFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_LimpaFiltros.Location = New System.Drawing.Point(1185, 38)
        Me.Pic_LimpaFiltros.Name = "Pic_LimpaFiltros"
        Me.Pic_LimpaFiltros.Size = New System.Drawing.Size(25, 25)
        Me.Pic_LimpaFiltros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_LimpaFiltros.TabIndex = 14
        Me.Pic_LimpaFiltros.TabStop = False
        Me.Pic_LimpaFiltros.Visible = False
        '
        'Panel_TxtDoc
        '
        Me.Panel_TxtDoc.BackColor = System.Drawing.Color.Transparent
        Me.Panel_TxtDoc.BackgroundImage = CType(resources.GetObject("Panel_TxtDoc.BackgroundImage"), System.Drawing.Image)
        Me.Panel_TxtDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TxtDoc.Controls.Add(Me.Txt_Doc)
        Me.Panel_TxtDoc.Enabled = False
        Me.Panel_TxtDoc.Location = New System.Drawing.Point(297, 9)
        Me.Panel_TxtDoc.Name = "Panel_TxtDoc"
        Me.Panel_TxtDoc.Size = New System.Drawing.Size(96, 26)
        Me.Panel_TxtDoc.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.picArrowTD)
        Me.Panel2.Controls.Add(Me.Txt_TipoDoc)
        Me.Panel2.Location = New System.Drawing.Point(24, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 26)
        Me.Panel2.TabIndex = 25
        '
        'picArrowTD
        '
        Me.picArrowTD.BackColor = System.Drawing.Color.Transparent
        Me.picArrowTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picArrowTD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picArrowTD.Image = Global.FCT_2021.My.Resources.Resources.ArrowDownIcon
        Me.picArrowTD.Location = New System.Drawing.Point(173, 1)
        Me.picArrowTD.Name = "picArrowTD"
        Me.picArrowTD.Size = New System.Drawing.Size(24, 24)
        Me.picArrowTD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrowTD.TabIndex = 18
        Me.picArrowTD.TabStop = False
        '
        'Txt_TipoDoc
        '
        Me.Txt_TipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_TipoDoc.EditValue = ""
        Me.Txt_TipoDoc.Enabled = False
        Me.Txt_TipoDoc.Location = New System.Drawing.Point(4, 3)
        Me.Txt_TipoDoc.Name = "Txt_TipoDoc"
        Me.Txt_TipoDoc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Txt_TipoDoc.Properties.Appearance.Font = New System.Drawing.Font("Cascadia Code SemiBold", 8.25!)
        Me.Txt_TipoDoc.Properties.Appearance.Options.UseBackColor = True
        Me.Txt_TipoDoc.Properties.Appearance.Options.UseFont = True
        Me.Txt_TipoDoc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_TipoDoc.Size = New System.Drawing.Size(163, 20)
        Me.Txt_TipoDoc.TabIndex = 19
        '
        'ClsLinhasBindingSource
        '
        Me.ClsLinhasBindingSource.DataSource = GetType(FCT_2021.ClsLinhas)
        '
        'ClsQIBindingSource
        '
        Me.ClsQIBindingSource.DataSource = GetType(FCT_2021.ClsQI)
        '
        'ClsTiposPagamentoBindingSource
        '
        Me.ClsTiposPagamentoBindingSource.DataSource = GetType(FCT_2021.ClsTipos_Pagamento)
        '
        'ClsTiposDocBindingSource
        '
        Me.ClsTiposDocBindingSource.DataSource = GetType(FCT_2021.ClsTipos_Doc)
        '
        'frmUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 632)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Cliente)
        Me.Controls.Add(Me.Panel_TxtDoc)
        Me.Controls.Add(Me.Pic_LimpaFiltros)
        Me.Controls.Add(Me.Panel_TxtSearch)
        Me.Controls.Add(Me.Btn_SubCategorias)
        Me.Controls.Add(Me.Btn_Categorias)
        Me.Controls.Add(Me.UTC_Tabelas)
        Me.Controls.Add(Me.LblDoc)
        Me.Controls.Add(Me.UC_TipoDoc)
        Me.Controls.Add(Me.Lbl_SubCat)
        Me.Controls.Add(Me.Lbl_Categoria)
        Me.Controls.Add(Me.Panel_ViewArt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MinimumSize = New System.Drawing.Size(1360, 671)
        Me.Name = "frmUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " HypeStack"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel_UGLinhas.ResumeLayout(False)
        CType(Me.UG_Linhas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UG_QI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.Pic_MPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UC_TipoPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Totais.ResumeLayout(False)
        Me.Panel_Totais.PerformLayout()
        CType(Me.UC_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Cliente.ResumeLayout(False)
        Me.Panel_Cliente.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Txt_NCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrow_NCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TxtNome.ResumeLayout(False)
        CType(Me.Txt_Nome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TxtTelefone.ResumeLayout(False)
        CType(Me.Txt_Telefone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TxtTelemovel.ResumeLayout(False)
        CType(Me.Txt_Telemovel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TxtNif.ResumeLayout(False)
        CType(Me.Txt_Email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_txtEmail.ResumeLayout(False)
        CType(Me.Txt_NIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UC_NumCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Doc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UTC_Tabelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UTC_Tabelas.ResumeLayout(False)
        Me.CMS_Qtd.ResumeLayout(False)
        Me.CMS_Qtd.PerformLayout()
        Me.Panel_TxtSearch.ResumeLayout(False)
        CType(Me.Txt_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_LimpaFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TxtDoc.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.picArrowTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_TipoDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsLinhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsQIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsTiposPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsTiposDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_ViewArt As Panel
    Friend WithEvents Lbl_Categoria As Label
    Friend WithEvents Lbl_SubCat As Label
    Friend WithEvents Timer_Delay As Timer
    Friend WithEvents Panel_UGLinhas As Panel
    Friend WithEvents UG_Linhas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ClsLinhasBindingSource As BindingSource
    Friend WithEvents UC_TipoDoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ClsTiposDocBindingSource As BindingSource
    Friend WithEvents LblDoc As Label
    Friend WithEvents Panel_Cliente As Panel
    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Lbl_NumCliente As Label
    Friend WithEvents Lbl_Telefone As Label
    Friend WithEvents Lbl_Telemovel As Label
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents Lbl_Nif As Label
    Friend WithEvents UC_NumCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UTC_Tabelas As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel_Totais As Panel
    Friend WithEvents Lbl_TotalPagar As Label
    Friend WithEvents Lbl_TotalIVA As Label
    Friend WithEvents Lbl_TotalDesc As Label
    Friend WithEvents Lbl_Totais As Label
    Friend WithEvents Txt_TotalPagar As TextBox
    Friend WithEvents Txt_TotalIVA As TextBox
    Friend WithEvents Txt_TotalDesc As TextBox
    Friend WithEvents Txt_TotalIliquido As TextBox
    Friend WithEvents Lbl_TotalIliquido As Label
    Friend WithEvents UG_QI As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ClsQIBindingSource As BindingSource
    Friend WithEvents Btn_Gravar As Button
    Friend WithEvents UC_TipoPagamento As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Pic_MPagamento As PictureBox
    Friend WithEvents ClsTiposPagamentoBindingSource As BindingSource
    Friend WithEvents CMS_Qtd As ContextMenuStrip
    Friend WithEvents TxtMenu_Qtd As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnMenu_More As ToolStripMenuItem
    Friend WithEvents BtnMenu_Less As ToolStripMenuItem
    Friend WithEvents BtnMenu_Confirmar As ToolStripMenuItem
    Friend WithEvents BtnMenu_Cancelar As ToolStripMenuItem
    Friend WithEvents Btn_Categorias As Label
    Friend WithEvents Btn_SubCategorias As Label
    Friend WithEvents Panel_TxtSearch As Panel
    Friend WithEvents Txt_Search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Pic_LimpaFiltros As PictureBox
    Friend WithEvents Txt_Doc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel_txtEmail As Panel
    Friend WithEvents Panel_TxtDoc As Panel
    Friend WithEvents Txt_NIF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel_TxtNome As Panel
    Friend WithEvents Txt_Nome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel_TxtTelefone As Panel
    Friend WithEvents Txt_Telefone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel_TxtTelemovel As Panel
    Friend WithEvents Txt_Telemovel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel_TxtNif As Panel
    Friend WithEvents Txt_Email As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picArrow_NCliente As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picArrowTD As PictureBox
    Friend WithEvents Txt_TipoDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Txt_NCliente As DevExpress.XtraEditors.TextEdit
End Class
