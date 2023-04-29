<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCategorias))
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.pControlBox = New System.Windows.Forms.Panel()
        Me.pSearchBar = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchContent = New System.Windows.Forms.TextBox()
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
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.ucChangePicture = New FCT_2021.ucChangePictureBox()
        Me.ucCategorias_Designacao = New FCT_2021.ucTextBoxWithLabel()
        Me.ucCategorias_Cod = New FCT_2021.ucTextBoxWithLabel()
        Me.pControlBox.SuspendLayout()
        Me.pSearchBar.SuspendLayout()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pStatusBar.SuspendLayout()
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
        Me.lblCounter.Text = "A mostrar categoria 0 de 0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pControlBox
        '
        Me.pControlBox.BackColor = System.Drawing.Color.Transparent
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
        Me.lblSearch.Text = "Procurar categoria"
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
        'picUser
        '
        Me.picUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picUser.BackgroundImage = Global.FCT_2021.My.Resources.Resources.NoImage
        Me.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser.Image = Global.FCT_2021.My.Resources.Resources.PictureFrame
        Me.picUser.Location = New System.Drawing.Point(704, 186)
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
        Me.ucChangePicture.Location = New System.Drawing.Point(739, 493)
        Me.ucChangePicture.Name = "ucChangePicture"
        Me.ucChangePicture.Size = New System.Drawing.Size(225, 42)
        Me.ucChangePicture.TabIndex = 8
        Me.ucChangePicture.TextInput = "Change Picture"
        Me.ucChangePicture.Visible = False
        '
        'ucCategorias_Designacao
        '
        Me.ucCategorias_Designacao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucCategorias_Designacao.BackColor = System.Drawing.Color.White
        Me.ucCategorias_Designacao.Location = New System.Drawing.Point(156, 344)
        Me.ucCategorias_Designacao.MaxTextLengh = 30
        Me.ucCategorias_Designacao.Name = "ucCategorias_Designacao"
        Me.ucCategorias_Designacao.PlaceHolder = "Designação:"
        Me.ucCategorias_Designacao.ReadOnlyInput = True
        Me.ucCategorias_Designacao.Size = New System.Drawing.Size(479, 65)
        Me.ucCategorias_Designacao.TabIndex = 2
        Me.ucCategorias_Designacao.TextInput = ""
        Me.ucCategorias_Designacao.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucCategorias_Cod
        '
        Me.ucCategorias_Cod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucCategorias_Cod.BackColor = System.Drawing.Color.White
        Me.ucCategorias_Cod.Location = New System.Drawing.Point(156, 273)
        Me.ucCategorias_Cod.MaxTextLengh = 6
        Me.ucCategorias_Cod.Name = "ucCategorias_Cod"
        Me.ucCategorias_Cod.PlaceHolder = "Código:"
        Me.ucCategorias_Cod.ReadOnlyInput = True
        Me.ucCategorias_Cod.Size = New System.Drawing.Size(479, 65)
        Me.ucCategorias_Cod.TabIndex = 0
        Me.ucCategorias_Cod.TextInput = ""
        Me.ucCategorias_Cod.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ucChangePicture)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.pControlBox)
        Me.Controls.Add(Me.pStatusBar)
        Me.Controls.Add(Me.ucCategorias_Designacao)
        Me.Controls.Add(Me.ucCategorias_Cod)
        Me.Name = "ucCategorias"
        Me.Size = New System.Drawing.Size(1169, 711)
        Me.pControlBox.ResumeLayout(False)
        Me.pControlBox.PerformLayout()
        Me.pSearchBar.ResumeLayout(False)
        Me.pSearchBar.PerformLayout()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pStatusBar.ResumeLayout(False)
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucCategorias_Cod As ucTextBoxWithLabel
    Friend WithEvents ucCategorias_Designacao As ucTextBoxWithLabel
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
    Friend WithEvents pSearchBar As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchContent As TextBox
    Friend WithEvents ttHelpPicture As ToolTip
End Class
