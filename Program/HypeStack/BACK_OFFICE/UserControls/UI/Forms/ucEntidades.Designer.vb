<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucEntidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucEntidades))
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.pControlBox = New System.Windows.Forms.Panel()
        Me.pSearchBar = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchContent = New System.Windows.Forms.TextBox()
        Me.pFiltroEntidades = New System.Windows.Forms.Panel()
        Me.lblTextFiltro = New System.Windows.Forms.Label()
        Me.picLeftFiltro = New System.Windows.Forms.PictureBox()
        Me.picRightFiltro = New System.Windows.Forms.PictureBox()
        Me.btnDelCancel = New FCT_2021.ucSquareButton()
        Me.btnAddSave = New FCT_2021.ucSquareButton()
        Me.btnEditar = New FCT_2021.ucSquareButton()
        Me.btnLast = New FCT_2021.ucSquareButton()
        Me.btnNext = New FCT_2021.ucSquareButton()
        Me.btnBack = New FCT_2021.ucSquareButton()
        Me.btnFirst = New FCT_2021.ucSquareButton()
        Me.udaSaved = New Infragistics.Win.Misc.UltraDesktopAlert(Me.components)
        Me.pStatusBar = New System.Windows.Forms.Panel()
        Me.ofdUserImage = New System.Windows.Forms.OpenFileDialog()
        Me.ttHelpPicture = New System.Windows.Forms.ToolTip(Me.components)
        Me.picHelpPicture = New System.Windows.Forms.PictureBox()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.ucChangePicture = New FCT_2021.ucChangePictureBox()
        Me.ucEntidade_Tipo = New FCT_2021.ucComboBoxWithLabel()
        Me.ucEntidade_Telefone = New FCT_2021.ucTextBoxWithLabel()
        Me.ucEntidade_Email = New FCT_2021.ucTextBoxWithLabel()
        Me.ucEntidade_NIF = New FCT_2021.ucTextBoxWithLabel()
        Me.ucEntidade_Telemovel = New FCT_2021.ucTextBoxWithLabel()
        Me.ucEntidade_Pais = New FCT_2021.ucComboBoxWithLabel()
        Me.ucEntidade_Nome = New FCT_2021.ucTextBoxWithLabel()
        Me.ucEntidade_Cod = New FCT_2021.ucTextBoxWithLabel()
        Me.pControlBox.SuspendLayout()
        Me.pSearchBar.SuspendLayout()
        Me.pFiltroEntidades.SuspendLayout()
        CType(Me.picLeftFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pStatusBar.SuspendLayout()
        CType(Me.picHelpPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblCounter.Text = "A mostrar entidade 0 de 0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pControlBox
        '
        Me.pControlBox.BackColor = System.Drawing.Color.Transparent
        Me.pControlBox.Controls.Add(Me.pSearchBar)
        Me.pControlBox.Controls.Add(Me.pFiltroEntidades)
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
        Me.lblSearch.Text = "Procurar utilizador"
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
        'pFiltroEntidades
        '
        Me.pFiltroEntidades.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pFiltroEntidades.BackgroundImage = Global.FCT_2021.My.Resources.Resources.UserFilterBG
        Me.pFiltroEntidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pFiltroEntidades.Controls.Add(Me.lblTextFiltro)
        Me.pFiltroEntidades.Controls.Add(Me.picLeftFiltro)
        Me.pFiltroEntidades.Controls.Add(Me.picRightFiltro)
        Me.pFiltroEntidades.Location = New System.Drawing.Point(822, 7)
        Me.pFiltroEntidades.Name = "pFiltroEntidades"
        Me.pFiltroEntidades.Size = New System.Drawing.Size(310, 38)
        Me.pFiltroEntidades.TabIndex = 8
        '
        'lblTextFiltro
        '
        Me.lblTextFiltro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTextFiltro.Font = New System.Drawing.Font("Cascadia Code SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTextFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTextFiltro.Location = New System.Drawing.Point(39, 0)
        Me.lblTextFiltro.Name = "lblTextFiltro"
        Me.lblTextFiltro.Size = New System.Drawing.Size(232, 38)
        Me.lblTextFiltro.TabIndex = 5
        Me.lblTextFiltro.Text = "Clientes"
        Me.lblTextFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLeftFiltro
        '
        Me.picLeftFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picLeftFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLeftFiltro.Image = Global.FCT_2021.My.Resources.Resources.UserFilterArrowLeft
        Me.picLeftFiltro.Location = New System.Drawing.Point(0, 0)
        Me.picLeftFiltro.Name = "picLeftFiltro"
        Me.picLeftFiltro.Size = New System.Drawing.Size(38, 38)
        Me.picLeftFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeftFiltro.TabIndex = 4
        Me.picLeftFiltro.TabStop = False
        Me.picLeftFiltro.Visible = False
        '
        'picRightFiltro
        '
        Me.picRightFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picRightFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRightFiltro.Image = Global.FCT_2021.My.Resources.Resources.UserFilterArrowRight
        Me.picRightFiltro.Location = New System.Drawing.Point(272, 0)
        Me.picRightFiltro.Name = "picRightFiltro"
        Me.picRightFiltro.Size = New System.Drawing.Size(38, 38)
        Me.picRightFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRightFiltro.TabIndex = 3
        Me.picRightFiltro.TabStop = False
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
        'ofdUserImage
        '
        Me.ofdUserImage.FileName = "User.png"
        Me.ofdUserImage.Filter = "Imagens (*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG"
        Me.ofdUserImage.Title = "Escolha uma fotografia"
        '
        'ttHelpPicture
        '
        Me.ttHelpPicture.IsBalloon = True
        '
        'picHelpPicture
        '
        Me.picHelpPicture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picHelpPicture.Cursor = System.Windows.Forms.Cursors.Help
        Me.picHelpPicture.Image = Global.FCT_2021.My.Resources.Resources.Question
        Me.picHelpPicture.Location = New System.Drawing.Point(969, 460)
        Me.picHelpPicture.Name = "picHelpPicture"
        Me.picHelpPicture.Size = New System.Drawing.Size(25, 25)
        Me.picHelpPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHelpPicture.TabIndex = 17
        Me.picHelpPicture.TabStop = False
        Me.ttHelpPicture.SetToolTip(Me.picHelpPicture, "Apenas é possível adicionar fotografia de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "perfil se esta for um operador ou um a" &
        "dministrador." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'picUser
        '
        Me.picUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picUser.BackgroundImage = Global.FCT_2021.My.Resources.Resources.NoImage
        Me.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser.Image = Global.FCT_2021.My.Resources.Resources.PictureFrame
        Me.picUser.Location = New System.Drawing.Point(704, 143)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(290, 290)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 14
        Me.picUser.TabStop = False
        '
        'ucChangePicture
        '
        Me.ucChangePicture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucChangePicture.AutoSize = True
        Me.ucChangePicture.BackColor = System.Drawing.Color.Transparent
        Me.ucChangePicture.BackgroundImage = CType(resources.GetObject("ucChangePicture.BackgroundImage"), System.Drawing.Image)
        Me.ucChangePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ucChangePicture.Location = New System.Drawing.Point(739, 450)
        Me.ucChangePicture.Name = "ucChangePicture"
        Me.ucChangePicture.Size = New System.Drawing.Size(225, 42)
        Me.ucChangePicture.TabIndex = 8
        Me.ucChangePicture.TextInput = "Change Picture"
        Me.ucChangePicture.Visible = False
        '
        'ucEntidade_Tipo
        '
        Me.ucEntidade_Tipo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_Tipo.BackColor = System.Drawing.Color.White
        Me.ucEntidade_Tipo.DatasourceIdentifier = 1
        Me.ucEntidade_Tipo.Location = New System.Drawing.Point(405, 143)
        Me.ucEntidade_Tipo.Name = "ucEntidade_Tipo"
        Me.ucEntidade_Tipo.PlaceHolder = "Tipo de Entidade:"
        Me.ucEntidade_Tipo.ReadOnlyInput = True
        Me.ucEntidade_Tipo.Size = New System.Drawing.Size(235, 65)
        Me.ucEntidade_Tipo.TabIndex = 1
        '
        'ucEntidade_Telefone
        '
        Me.ucEntidade_Telefone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_Telefone.BackColor = System.Drawing.Color.White
        Me.ucEntidade_Telefone.Location = New System.Drawing.Point(402, 356)
        Me.ucEntidade_Telefone.MaxTextLengh = 9
        Me.ucEntidade_Telefone.Name = "ucEntidade_Telefone"
        Me.ucEntidade_Telefone.PlaceHolder = "Nº Telefone:"
        Me.ucEntidade_Telefone.ReadOnlyInput = True
        Me.ucEntidade_Telefone.Size = New System.Drawing.Size(238, 65)
        Me.ucEntidade_Telefone.TabIndex = 6
        Me.ucEntidade_Telefone.TextInput = ""
        Me.ucEntidade_Telefone.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucEntidade_Email
        '
        Me.ucEntidade_Email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_Email.BackColor = System.Drawing.Color.White
        Me.ucEntidade_Email.Location = New System.Drawing.Point(161, 429)
        Me.ucEntidade_Email.MaxTextLengh = 80
        Me.ucEntidade_Email.Name = "ucEntidade_Email"
        Me.ucEntidade_Email.PlaceHolder = "Email:"
        Me.ucEntidade_Email.ReadOnlyInput = True
        Me.ucEntidade_Email.Size = New System.Drawing.Size(479, 65)
        Me.ucEntidade_Email.TabIndex = 7
        Me.ucEntidade_Email.TextInput = ""
        Me.ucEntidade_Email.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucEntidade_NIF
        '
        Me.ucEntidade_NIF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_NIF.BackColor = System.Drawing.Color.White
        Me.ucEntidade_NIF.Location = New System.Drawing.Point(402, 285)
        Me.ucEntidade_NIF.MaxTextLengh = 9
        Me.ucEntidade_NIF.Name = "ucEntidade_NIF"
        Me.ucEntidade_NIF.PlaceHolder = "NIF:"
        Me.ucEntidade_NIF.ReadOnlyInput = True
        Me.ucEntidade_NIF.Size = New System.Drawing.Size(238, 65)
        Me.ucEntidade_NIF.TabIndex = 4
        Me.ucEntidade_NIF.TextInput = ""
        Me.ucEntidade_NIF.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucEntidade_Telemovel
        '
        Me.ucEntidade_Telemovel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_Telemovel.BackColor = System.Drawing.Color.White
        Me.ucEntidade_Telemovel.Location = New System.Drawing.Point(161, 356)
        Me.ucEntidade_Telemovel.MaxTextLengh = 9
        Me.ucEntidade_Telemovel.Name = "ucEntidade_Telemovel"
        Me.ucEntidade_Telemovel.PlaceHolder = "Nº Telemóvel:"
        Me.ucEntidade_Telemovel.ReadOnlyInput = True
        Me.ucEntidade_Telemovel.Size = New System.Drawing.Size(235, 65)
        Me.ucEntidade_Telemovel.TabIndex = 5
        Me.ucEntidade_Telemovel.TextInput = ""
        Me.ucEntidade_Telemovel.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucEntidade_Pais
        '
        Me.ucEntidade_Pais.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_Pais.BackColor = System.Drawing.Color.White
        Me.ucEntidade_Pais.DatasourceIdentifier = 2
        Me.ucEntidade_Pais.Location = New System.Drawing.Point(161, 285)
        Me.ucEntidade_Pais.Name = "ucEntidade_Pais"
        Me.ucEntidade_Pais.PlaceHolder = "País:"
        Me.ucEntidade_Pais.ReadOnlyInput = True
        Me.ucEntidade_Pais.Size = New System.Drawing.Size(235, 65)
        Me.ucEntidade_Pais.TabIndex = 3
        '
        'ucEntidade_Nome
        '
        Me.ucEntidade_Nome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_Nome.BackColor = System.Drawing.Color.White
        Me.ucEntidade_Nome.Location = New System.Drawing.Point(161, 214)
        Me.ucEntidade_Nome.MaxTextLengh = 80
        Me.ucEntidade_Nome.Name = "ucEntidade_Nome"
        Me.ucEntidade_Nome.PlaceHolder = "Nome:"
        Me.ucEntidade_Nome.ReadOnlyInput = True
        Me.ucEntidade_Nome.Size = New System.Drawing.Size(479, 65)
        Me.ucEntidade_Nome.TabIndex = 2
        Me.ucEntidade_Nome.TextInput = ""
        Me.ucEntidade_Nome.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucEntidade_Cod
        '
        Me.ucEntidade_Cod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucEntidade_Cod.BackColor = System.Drawing.Color.White
        Me.ucEntidade_Cod.Location = New System.Drawing.Point(161, 143)
        Me.ucEntidade_Cod.MaxTextLengh = 10
        Me.ucEntidade_Cod.Name = "ucEntidade_Cod"
        Me.ucEntidade_Cod.PlaceHolder = "Código:"
        Me.ucEntidade_Cod.ReadOnlyInput = True
        Me.ucEntidade_Cod.Size = New System.Drawing.Size(235, 65)
        Me.ucEntidade_Cod.TabIndex = 0
        Me.ucEntidade_Cod.TextInput = ""
        Me.ucEntidade_Cod.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.picHelpPicture)
        Me.Controls.Add(Me.ucChangePicture)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.pControlBox)
        Me.Controls.Add(Me.pStatusBar)
        Me.Controls.Add(Me.ucEntidade_Tipo)
        Me.Controls.Add(Me.ucEntidade_Telefone)
        Me.Controls.Add(Me.ucEntidade_Email)
        Me.Controls.Add(Me.ucEntidade_NIF)
        Me.Controls.Add(Me.ucEntidade_Telemovel)
        Me.Controls.Add(Me.ucEntidade_Pais)
        Me.Controls.Add(Me.ucEntidade_Nome)
        Me.Controls.Add(Me.ucEntidade_Cod)
        Me.Name = "ucEntidades"
        Me.Size = New System.Drawing.Size(1169, 711)
        Me.pControlBox.ResumeLayout(False)
        Me.pControlBox.PerformLayout()
        Me.pSearchBar.ResumeLayout(False)
        Me.pSearchBar.PerformLayout()
        Me.pFiltroEntidades.ResumeLayout(False)
        CType(Me.picLeftFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pStatusBar.ResumeLayout(False)
        CType(Me.picHelpPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucEntidade_Cod As ucTextBoxWithLabel
    Friend WithEvents ucEntidade_Nome As ucTextBoxWithLabel
    Friend WithEvents ucEntidade_Pais As ucComboBoxWithLabel
    Friend WithEvents ucEntidade_Telemovel As ucTextBoxWithLabel
    Friend WithEvents ucEntidade_NIF As ucTextBoxWithLabel
    Friend WithEvents ucEntidade_Email As ucTextBoxWithLabel
    Friend WithEvents ucEntidade_Telefone As ucTextBoxWithLabel
    Friend WithEvents ucEntidade_Tipo As ucComboBoxWithLabel
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
    Friend WithEvents picUser As PictureBox
    Friend WithEvents ucChangePicture As ucChangePictureBox
    Friend WithEvents ofdUserImage As OpenFileDialog
    Friend WithEvents pFiltroEntidades As Panel
    Friend WithEvents lblTextFiltro As Label
    Friend WithEvents picLeftFiltro As PictureBox
    Friend WithEvents picRightFiltro As PictureBox
    Friend WithEvents pSearchBar As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchContent As TextBox
    Friend WithEvents ttHelpPicture As ToolTip
    Friend WithEvents picHelpPicture As PictureBox
End Class
