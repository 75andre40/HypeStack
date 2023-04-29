<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucArtigos
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.pControlBox = New System.Windows.Forms.Panel()
        Me.pFiltroMinStock = New System.Windows.Forms.Panel()
        Me.picFiltroStockMin = New System.Windows.Forms.PictureBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.pSearchBar = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchContent = New System.Windows.Forms.TextBox()
        Me.udaSaved = New Infragistics.Win.Misc.UltraDesktopAlert(Me.components)
        Me.pStatusBar = New System.Windows.Forms.Panel()
        Me.ofdProductImage = New System.Windows.Forms.OpenFileDialog()
        Me.lblDiscountPrice = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.ttHelpPrice = New System.Windows.Forms.ToolTip(Me.components)
        Me.picInfoPSD = New System.Windows.Forms.PictureBox()
        Me.picInfoPCD = New System.Windows.Forms.PictureBox()
        Me.picWarning = New System.Windows.Forms.PictureBox()
        Me.picAprox = New System.Windows.Forms.PictureBox()
        Me.picI1 = New System.Windows.Forms.PictureBox()
        Me.picI2 = New System.Windows.Forms.PictureBox()
        Me.picI3 = New System.Windows.Forms.PictureBox()
        Me.ucArtigo_Desconto = New FCT_2021.ucTextBoxUPDOWN()
        Me.ucArtigo_Stock = New FCT_2021.ucTextBoxUPDOWN()
        Me.ucArtigo_Desc = New FCT_2021.ucLongTextBoxWithLabel()
        Me.ucArtigo_PV = New FCT_2021.ucTextBoxWithLabel()
        Me.ucArtigo_PC = New FCT_2021.ucTextBoxWithLabel()
        Me.ucArtigo_IVA = New FCT_2021.ucComboBoxWithLabel()
        Me.btnDelCancel = New FCT_2021.ucSquareButton()
        Me.btnAddSave = New FCT_2021.ucSquareButton()
        Me.btnEditar = New FCT_2021.ucSquareButton()
        Me.btnLast = New FCT_2021.ucSquareButton()
        Me.btnNext = New FCT_2021.ucSquareButton()
        Me.btnBack = New FCT_2021.ucSquareButton()
        Me.btnFirst = New FCT_2021.ucSquareButton()
        Me.ucArtigo_SubCategoria = New FCT_2021.ucComboBoxWithLabel()
        Me.ucArtigo_Categoria = New FCT_2021.ucComboBoxWithLabel()
        Me.ucArtigo_Designacao = New FCT_2021.ucTextBoxWithLabel()
        Me.ucArtigo_Cod = New FCT_2021.ucTextBoxWithLabel()
        Me.pControlBox.SuspendLayout()
        Me.pFiltroMinStock.SuspendLayout()
        CType(Me.picFiltroStockMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pSearchBar.SuspendLayout()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pStatusBar.SuspendLayout()
        CType(Me.picInfoPSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInfoPCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAprox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picI2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picI3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCounter
        '
        Me.lblCounter.BackColor = System.Drawing.Color.White
        Me.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCounter.Font = New System.Drawing.Font("Cascadia Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(0, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(1169, 43)
        Me.lblCounter.TabIndex = 0
        Me.lblCounter.Text = "A mostrar artigo 0 de 0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pControlBox
        '
        Me.pControlBox.BackColor = System.Drawing.Color.Transparent
        Me.pControlBox.Controls.Add(Me.pFiltroMinStock)
        Me.pControlBox.Controls.Add(Me.pSearchBar)
        Me.pControlBox.Controls.Add(Me.btnDelCancel)
        Me.pControlBox.Controls.Add(Me.btnAddSave)
        Me.pControlBox.Controls.Add(Me.btnEditar)
        Me.pControlBox.Controls.Add(Me.btnLast)
        Me.pControlBox.Controls.Add(Me.btnNext)
        Me.pControlBox.Controls.Add(Me.btnBack)
        Me.pControlBox.Controls.Add(Me.btnFirst)
        Me.pControlBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.pControlBox.Location = New System.Drawing.Point(0, 0)
        Me.pControlBox.Name = "pControlBox"
        Me.pControlBox.Size = New System.Drawing.Size(1169, 52)
        Me.pControlBox.TabIndex = 12
        '
        'pFiltroMinStock
        '
        Me.pFiltroMinStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pFiltroMinStock.BackgroundImage = Global.FCT_2021.My.Resources.Resources.UserFilterBG
        Me.pFiltroMinStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pFiltroMinStock.Controls.Add(Me.picFiltroStockMin)
        Me.pFiltroMinStock.Controls.Add(Me.lblFiltro)
        Me.pFiltroMinStock.Location = New System.Drawing.Point(828, 8)
        Me.pFiltroMinStock.Name = "pFiltroMinStock"
        Me.pFiltroMinStock.Size = New System.Drawing.Size(310, 38)
        Me.pFiltroMinStock.TabIndex = 10
        '
        'picFiltroStockMin
        '
        Me.picFiltroStockMin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picFiltroStockMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picFiltroStockMin.Image = Global.FCT_2021.My.Resources.Resources.FilterMinStockNo
        Me.picFiltroStockMin.Location = New System.Drawing.Point(0, 0)
        Me.picFiltroStockMin.Name = "picFiltroStockMin"
        Me.picFiltroStockMin.Size = New System.Drawing.Size(38, 38)
        Me.picFiltroStockMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFiltroStockMin.TabIndex = 31
        Me.picFiltroStockMin.TabStop = False
        Me.picFiltroStockMin.Tag = "0"
        '
        'lblFiltro
        '
        Me.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFiltro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblFiltro.Font = New System.Drawing.Font("Cascadia Code SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFiltro.Location = New System.Drawing.Point(40, 0)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(266, 37)
        Me.lblFiltro.TabIndex = 6
        Me.lblFiltro.Text = "Abaixo do stock mínimo"
        Me.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pSearchBar
        '
        Me.pSearchBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pSearchBar.BackgroundImage = Global.FCT_2021.My.Resources.Resources.UserFilterBG
        Me.pSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pSearchBar.Controls.Add(Me.lblSearch)
        Me.pSearchBar.Controls.Add(Me.txtSearchContent)
        Me.pSearchBar.Location = New System.Drawing.Point(31, 7)
        Me.pSearchBar.Name = "pSearchBar"
        Me.pSearchBar.Size = New System.Drawing.Size(310, 38)
        Me.pSearchBar.TabIndex = 9
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSearch.Font = New System.Drawing.Font("Cascadia Code SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.ForeColor = System.Drawing.Color.DarkGray
        Me.lblSearch.Location = New System.Drawing.Point(15, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(295, 38)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "Procurar artigo"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearchContent
        '
        Me.txtSearchContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtSearchContent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchContent.Font = New System.Drawing.Font("Cascadia Code SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearchContent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchContent.Location = New System.Drawing.Point(11, 9)
        Me.txtSearchContent.Name = "txtSearchContent"
        Me.txtSearchContent.Size = New System.Drawing.Size(288, 21)
        Me.txtSearchContent.TabIndex = 0
        '
        'udaSaved
        '
        Me.udaSaved.AnimationSpeed = Infragistics.Win.Misc.AnimationSpeed.Fast
        Me.udaSaved.AnimationStyleAutoClose = Infragistics.Win.Misc.AnimationStyle.FadeAndScroll
        Me.udaSaved.AnimationStyleShow = Infragistics.Win.Misc.AnimationStyle.FadeAndScroll
        Me.udaSaved.Opacity = 1.0!
        Me.udaSaved.Style = Infragistics.Win.Misc.DesktopAlertStyle.Office2007
        '
        'pStatusBar
        '
        Me.pStatusBar.BackColor = System.Drawing.Color.White
        Me.pStatusBar.Controls.Add(Me.lblCounter)
        Me.pStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pStatusBar.Location = New System.Drawing.Point(0, 668)
        Me.pStatusBar.Name = "pStatusBar"
        Me.pStatusBar.Size = New System.Drawing.Size(1169, 43)
        Me.pStatusBar.TabIndex = 11
        '
        'ofdProductImage
        '
        Me.ofdProductImage.FileName = "Artigo.png"
        Me.ofdProductImage.Filter = "Imagens (*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG"
        Me.ofdProductImage.Title = "Escolha uma fotografia"
        '
        'lblDiscountPrice
        '
        Me.lblDiscountPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDiscountPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscountPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDiscountPrice.Font = New System.Drawing.Font("Cascadia Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDiscountPrice.Location = New System.Drawing.Point(403, 594)
        Me.lblDiscountPrice.Name = "lblDiscountPrice"
        Me.lblDiscountPrice.Size = New System.Drawing.Size(101, 19)
        Me.lblDiscountPrice.TabIndex = 2
        Me.lblDiscountPrice.Text = "0€"
        Me.lblDiscountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPrice.Font = New System.Drawing.Font("Cascadia Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(294, 594)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(78, 19)
        Me.lblPrice.TabIndex = 27
        Me.lblPrice.Text = "0€"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttHelpPrice
        '
        Me.ttHelpPrice.IsBalloon = True
        '
        'picInfoPSD
        '
        Me.picInfoPSD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picInfoPSD.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picInfoPSD.Image = Global.FCT_2021.My.Resources.Resources.Question
        Me.picInfoPSD.Location = New System.Drawing.Point(378, 594)
        Me.picInfoPSD.Name = "picInfoPSD"
        Me.picInfoPSD.Size = New System.Drawing.Size(19, 19)
        Me.picInfoPSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfoPSD.TabIndex = 29
        Me.picInfoPSD.TabStop = False
        Me.ttHelpPrice.SetToolTip(Me.picInfoPSD, "Preço com IVA")
        '
        'picInfoPCD
        '
        Me.picInfoPCD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picInfoPCD.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picInfoPCD.Image = Global.FCT_2021.My.Resources.Resources.Question
        Me.picInfoPCD.Location = New System.Drawing.Point(510, 594)
        Me.picInfoPCD.Name = "picInfoPCD"
        Me.picInfoPCD.Size = New System.Drawing.Size(19, 19)
        Me.picInfoPCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfoPCD.TabIndex = 28
        Me.picInfoPCD.TabStop = False
        Me.ttHelpPrice.SetToolTip(Me.picInfoPCD, "Preço com IVA e Desconto")
        '
        'picWarning
        '
        Me.picWarning.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWarning.Image = Global.FCT_2021.My.Resources.Resources.WarningIcon
        Me.picWarning.Location = New System.Drawing.Point(535, 140)
        Me.picWarning.Name = "picWarning"
        Me.picWarning.Size = New System.Drawing.Size(40, 40)
        Me.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWarning.TabIndex = 30
        Me.picWarning.TabStop = False
        Me.picWarning.Visible = False
        '
        'picAprox
        '
        Me.picAprox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picAprox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picAprox.Image = Global.FCT_2021.My.Resources.Resources.AproximadamenteIgual
        Me.picAprox.Location = New System.Drawing.Point(299, 558)
        Me.picAprox.Name = "picAprox"
        Me.picAprox.Size = New System.Drawing.Size(19, 19)
        Me.picAprox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAprox.TabIndex = 26
        Me.picAprox.TabStop = False
        Me.picAprox.Visible = False
        '
        'picI1
        '
        Me.picI1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picI1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picI1.BackgroundImage = Global.FCT_2021.My.Resources.Resources.NoImage
        Me.picI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picI1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picI1.Image = Global.FCT_2021.My.Resources.Resources.PictureFrame
        Me.picI1.Location = New System.Drawing.Point(743, 129)
        Me.picI1.Name = "picI1"
        Me.picI1.Size = New System.Drawing.Size(260, 260)
        Me.picI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picI1.TabIndex = 18
        Me.picI1.TabStop = False
        Me.picI1.Tag = "1"
        '
        'picI2
        '
        Me.picI2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picI2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picI2.BackgroundImage = Global.FCT_2021.My.Resources.Resources.NoImage
        Me.picI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picI2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picI2.Image = Global.FCT_2021.My.Resources.Resources.PictureFrame
        Me.picI2.Location = New System.Drawing.Point(637, 395)
        Me.picI2.Name = "picI2"
        Me.picI2.Size = New System.Drawing.Size(225, 225)
        Me.picI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picI2.TabIndex = 16
        Me.picI2.TabStop = False
        Me.picI2.Tag = "2"
        '
        'picI3
        '
        Me.picI3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picI3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picI3.BackgroundImage = Global.FCT_2021.My.Resources.Resources.NoImage
        Me.picI3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picI3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picI3.Image = Global.FCT_2021.My.Resources.Resources.PictureFrame
        Me.picI3.Location = New System.Drawing.Point(898, 395)
        Me.picI3.Name = "picI3"
        Me.picI3.Size = New System.Drawing.Size(225, 225)
        Me.picI3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picI3.TabIndex = 14
        Me.picI3.TabStop = False
        Me.picI3.Tag = "3"
        '
        'ucArtigo_Desconto
        '
        Me.ucArtigo_Desconto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_Desconto.aNumericActualValue = 0
        Me.ucArtigo_Desconto.aNumericMaximumValue = 100
        Me.ucArtigo_Desconto.aNumericMinimumValue = 0
        Me.ucArtigo_Desconto.aPlaceHolder = "Desconto:"
        Me.ucArtigo_Desconto.aReadOnlyInput = True
        Me.ucArtigo_Desconto.aUnits = "%"
        Me.ucArtigo_Desconto.BackColor = System.Drawing.Color.White
        Me.ucArtigo_Desconto.Location = New System.Drawing.Point(403, 523)
        Me.ucArtigo_Desconto.Name = "ucArtigo_Desconto"
        Me.ucArtigo_Desconto.Size = New System.Drawing.Size(126, 65)
        Me.ucArtigo_Desconto.TabIndex = 25
        '
        'ucArtigo_Stock
        '
        Me.ucArtigo_Stock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_Stock.aNumericActualValue = 0
        Me.ucArtigo_Stock.aNumericMaximumValue = 999
        Me.ucArtigo_Stock.aNumericMinimumValue = 0
        Me.ucArtigo_Stock.aPlaceHolder = "Stock:"
        Me.ucArtigo_Stock.aReadOnlyInput = True
        Me.ucArtigo_Stock.aUnits = "Un"
        Me.ucArtigo_Stock.BackColor = System.Drawing.Color.White
        Me.ucArtigo_Stock.Location = New System.Drawing.Point(294, 115)
        Me.ucArtigo_Stock.Name = "ucArtigo_Stock"
        Me.ucArtigo_Stock.Size = New System.Drawing.Size(235, 65)
        Me.ucArtigo_Stock.TabIndex = 0
        '
        'ucArtigo_Desc
        '
        Me.ucArtigo_Desc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_Desc.BackColor = System.Drawing.Color.White
        Me.ucArtigo_Desc.Location = New System.Drawing.Point(53, 257)
        Me.ucArtigo_Desc.MaxTextLengh = 1000
        Me.ucArtigo_Desc.Name = "ucArtigo_Desc"
        Me.ucArtigo_Desc.PlaceHolder = "Descrição: "
        Me.ucArtigo_Desc.ReadOnlyInput = True
        Me.ucArtigo_Desc.Size = New System.Drawing.Size(476, 187)
        Me.ucArtigo_Desc.TabIndex = 23
        Me.ucArtigo_Desc.TextInput = ""
        '
        'ucArtigo_PV
        '
        Me.ucArtigo_PV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_PV.BackColor = System.Drawing.Color.White
        Me.ucArtigo_PV.Location = New System.Drawing.Point(294, 523)
        Me.ucArtigo_PV.MaxTextLengh = 9
        Me.ucArtigo_PV.Name = "ucArtigo_PV"
        Me.ucArtigo_PV.PlaceHolder = "Preço Venda:"
        Me.ucArtigo_PV.ReadOnlyInput = True
        Me.ucArtigo_PV.Size = New System.Drawing.Size(103, 65)
        Me.ucArtigo_PV.TabIndex = 22
        Me.ucArtigo_PV.Tag = "Price"
        Me.ucArtigo_PV.TextInput = ""
        Me.ucArtigo_PV.ValueRightToLeft = Infragistics.Win.HAlign.Right
        '
        'ucArtigo_PC
        '
        Me.ucArtigo_PC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_PC.BackColor = System.Drawing.Color.White
        Me.ucArtigo_PC.Location = New System.Drawing.Point(157, 523)
        Me.ucArtigo_PC.MaxTextLengh = 9
        Me.ucArtigo_PC.Name = "ucArtigo_PC"
        Me.ucArtigo_PC.PlaceHolder = "Preço Compra:"
        Me.ucArtigo_PC.ReadOnlyInput = True
        Me.ucArtigo_PC.Size = New System.Drawing.Size(131, 65)
        Me.ucArtigo_PC.TabIndex = 21
        Me.ucArtigo_PC.Tag = "Price"
        Me.ucArtigo_PC.TextInput = ""
        Me.ucArtigo_PC.ValueRightToLeft = Infragistics.Win.HAlign.Right
        '
        'ucArtigo_IVA
        '
        Me.ucArtigo_IVA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_IVA.BackColor = System.Drawing.Color.White
        Me.ucArtigo_IVA.DatasourceIdentifier = 5
        Me.ucArtigo_IVA.Location = New System.Drawing.Point(53, 523)
        Me.ucArtigo_IVA.Name = "ucArtigo_IVA"
        Me.ucArtigo_IVA.PlaceHolder = "IVA:"
        Me.ucArtigo_IVA.ReadOnlyInput = True
        Me.ucArtigo_IVA.Size = New System.Drawing.Size(98, 65)
        Me.ucArtigo_IVA.TabIndex = 20
        Me.ucArtigo_IVA.Tag = "99"
        '
        'btnDelCancel
        '
        Me.btnDelCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelCancel.AutoSize = True
        Me.btnDelCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnDelCancel.ImageInput = Global.FCT_2021.My.Resources.Resources.DeleteIcon
        Me.btnDelCancel.Location = New System.Drawing.Point(754, 6)
        Me.btnDelCancel.Name = "btnDelCancel"
        Me.btnDelCancel.Size = New System.Drawing.Size(40, 40)
        Me.btnDelCancel.TabIndex = 6
        Me.btnDelCancel.Tag = "1"
        '
        'btnAddSave
        '
        Me.btnAddSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddSave.AutoSize = True
        Me.btnAddSave.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSave.ImageInput = Global.FCT_2021.My.Resources.Resources.AddDocumentIcon
        Me.btnAddSave.Location = New System.Drawing.Point(704, 6)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(40, 40)
        Me.btnAddSave.TabIndex = 5
        Me.btnAddSave.Tag = "1"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditar.AutoSize = True
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.ImageInput = Global.FCT_2021.My.Resources.Resources.CreateIcon
        Me.btnEditar.Location = New System.Drawing.Point(649, 6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Tag = "1"
        '
        'btnLast
        '
        Me.btnLast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLast.AutoSize = True
        Me.btnLast.BackColor = System.Drawing.Color.Transparent
        Me.btnLast.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowsLast
        Me.btnLast.Location = New System.Drawing.Point(527, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(45, 45)
        Me.btnLast.TabIndex = 3
        Me.btnLast.Tag = "1"
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowRight
        Me.btnNext.Location = New System.Drawing.Point(476, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(45, 45)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Tag = "1"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.AutoSize = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowLeft
        Me.btnBack.Location = New System.Drawing.Point(425, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 45)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Tag = "1"
        '
        'btnFirst
        '
        Me.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFirst.AutoSize = True
        Me.btnFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnFirst.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowsFirst
        Me.btnFirst.Location = New System.Drawing.Point(374, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(45, 45)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Tag = "1"
        '
        'ucArtigo_SubCategoria
        '
        Me.ucArtigo_SubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_SubCategoria.BackColor = System.Drawing.Color.White
        Me.ucArtigo_SubCategoria.DatasourceIdentifier = 4
        Me.ucArtigo_SubCategoria.Location = New System.Drawing.Point(294, 450)
        Me.ucArtigo_SubCategoria.Name = "ucArtigo_SubCategoria"
        Me.ucArtigo_SubCategoria.PlaceHolder = "Sub-Categoria:"
        Me.ucArtigo_SubCategoria.ReadOnlyInput = True
        Me.ucArtigo_SubCategoria.Size = New System.Drawing.Size(235, 65)
        Me.ucArtigo_SubCategoria.TabIndex = 1
        Me.ucArtigo_SubCategoria.Tag = 1
        '
        'ucArtigo_Categoria
        '
        Me.ucArtigo_Categoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_Categoria.BackColor = System.Drawing.Color.White
        Me.ucArtigo_Categoria.DatasourceIdentifier = 3
        Me.ucArtigo_Categoria.Location = New System.Drawing.Point(53, 450)
        Me.ucArtigo_Categoria.Name = "ucArtigo_Categoria"
        Me.ucArtigo_Categoria.PlaceHolder = "Categoria:"
        Me.ucArtigo_Categoria.ReadOnlyInput = True
        Me.ucArtigo_Categoria.Size = New System.Drawing.Size(235, 65)
        Me.ucArtigo_Categoria.TabIndex = 3
        Me.ucArtigo_Categoria.Tag = 1
        '
        'ucArtigo_Designacao
        '
        Me.ucArtigo_Designacao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_Designacao.BackColor = System.Drawing.Color.White
        Me.ucArtigo_Designacao.Location = New System.Drawing.Point(50, 186)
        Me.ucArtigo_Designacao.MaxTextLengh = 60
        Me.ucArtigo_Designacao.Name = "ucArtigo_Designacao"
        Me.ucArtigo_Designacao.PlaceHolder = "Designação:"
        Me.ucArtigo_Designacao.ReadOnlyInput = True
        Me.ucArtigo_Designacao.Size = New System.Drawing.Size(479, 65)
        Me.ucArtigo_Designacao.TabIndex = 2
        Me.ucArtigo_Designacao.TextInput = ""
        Me.ucArtigo_Designacao.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucArtigo_Cod
        '
        Me.ucArtigo_Cod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucArtigo_Cod.BackColor = System.Drawing.Color.White
        Me.ucArtigo_Cod.Location = New System.Drawing.Point(50, 115)
        Me.ucArtigo_Cod.MaxTextLengh = 5
        Me.ucArtigo_Cod.Name = "ucArtigo_Cod"
        Me.ucArtigo_Cod.PlaceHolder = "Código:"
        Me.ucArtigo_Cod.ReadOnlyInput = True
        Me.ucArtigo_Cod.Size = New System.Drawing.Size(235, 65)
        Me.ucArtigo_Cod.TabIndex = 0
        Me.ucArtigo_Cod.TextInput = ""
        Me.ucArtigo_Cod.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucArtigos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.picWarning)
        Me.Controls.Add(Me.picInfoPSD)
        Me.Controls.Add(Me.picInfoPCD)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDiscountPrice)
        Me.Controls.Add(Me.picAprox)
        Me.Controls.Add(Me.ucArtigo_Desconto)
        Me.Controls.Add(Me.ucArtigo_Stock)
        Me.Controls.Add(Me.ucArtigo_Desc)
        Me.Controls.Add(Me.ucArtigo_PV)
        Me.Controls.Add(Me.ucArtigo_PC)
        Me.Controls.Add(Me.ucArtigo_IVA)
        Me.Controls.Add(Me.picI1)
        Me.Controls.Add(Me.picI2)
        Me.Controls.Add(Me.picI3)
        Me.Controls.Add(Me.pControlBox)
        Me.Controls.Add(Me.pStatusBar)
        Me.Controls.Add(Me.ucArtigo_SubCategoria)
        Me.Controls.Add(Me.ucArtigo_Categoria)
        Me.Controls.Add(Me.ucArtigo_Designacao)
        Me.Controls.Add(Me.ucArtigo_Cod)
        Me.Name = "ucArtigos"
        Me.Size = New System.Drawing.Size(1169, 711)
        Me.pControlBox.ResumeLayout(False)
        Me.pControlBox.PerformLayout()
        Me.pFiltroMinStock.ResumeLayout(False)
        CType(Me.picFiltroStockMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pSearchBar.ResumeLayout(False)
        Me.pSearchBar.PerformLayout()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pStatusBar.ResumeLayout(False)
        CType(Me.picInfoPSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInfoPCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAprox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picI2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picI3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucArtigo_Cod As ucTextBoxWithLabel
    Friend WithEvents ucArtigo_Designacao As ucTextBoxWithLabel
    Friend WithEvents ucArtigo_Categoria As ucComboBoxWithLabel
    Friend WithEvents ucArtigo_SubCategoria As ucComboBoxWithLabel
    Friend WithEvents lblCounter As Label
    Friend WithEvents pControlBox As Panel
    Friend WithEvents btnFirst As ucSquareButton
    Friend WithEvents btnLast As ucSquareButton
    Friend WithEvents btnNext As ucSquareButton
    Friend WithEvents btnBack As ucSquareButton
    Friend WithEvents btnDelCancel As ucSquareButton
    Friend WithEvents btnAddSave As ucSquareButton
    Friend WithEvents btnEditar As ucSquareButton
    Friend WithEvents udaSaved As Infragistics.Win.Misc.UltraDesktopAlert
    Friend WithEvents pStatusBar As Panel
    Friend WithEvents picI3 As PictureBox
    Friend WithEvents ofdProductImage As OpenFileDialog
    Friend WithEvents pSearchBar As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchContent As TextBox
    Friend WithEvents picI2 As PictureBox
    Friend WithEvents picI1 As PictureBox
    Friend WithEvents ucArtigo_PC As ucTextBoxWithLabel
    Friend WithEvents ucArtigo_Desc As ucLongTextBoxWithLabel
    Friend WithEvents ucArtigo_IVA As ucComboBoxWithLabel
    Friend WithEvents ucArtigo_Stock As ucTextBoxUPDOWN
    Friend WithEvents ucArtigo_PV As ucTextBoxWithLabel
    Friend WithEvents ucArtigo_Desconto As ucTextBoxUPDOWN
    Friend WithEvents picAprox As PictureBox
    Private WithEvents lblDiscountPrice As Label
    Private WithEvents lblPrice As Label
    Friend WithEvents picInfoPCD As PictureBox
    Friend WithEvents picInfoPSD As PictureBox
    Friend WithEvents ttHelpPrice As ToolTip
    Friend WithEvents pFiltroMinStock As Panel
    Friend WithEvents picWarning As PictureBox
    Friend WithEvents lblFiltro As Label
    Friend WithEvents picFiltroStockMin As PictureBox
End Class
