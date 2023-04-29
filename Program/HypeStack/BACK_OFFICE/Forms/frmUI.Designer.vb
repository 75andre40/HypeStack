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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUI))
        Me.pSideMenu = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblWatch = New System.Windows.Forms.Label()
        Me.lblPersonName = New System.Windows.Forms.Label()
        Me.tmrDate = New System.Windows.Forms.Timer(Me.components)
        Me.pContent = New System.Windows.Forms.Panel()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.btnAdministracao = New FCT_2021.ucMenuButton()
        Me.btnArtigos = New FCT_2021.ucMenuButton()
        Me.btnOutros = New FCT_2021.ucMenuButton()
        Me.btnGeral = New FCT_2021.ucMenuButton()
        Me.pSideMenu.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pSideMenu
        '
        Me.pSideMenu.BackColor = System.Drawing.Color.Transparent
        Me.pSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pSideMenu.Controls.Add(Me.picUser)
        Me.pSideMenu.Controls.Add(Me.lblDate)
        Me.pSideMenu.Controls.Add(Me.lblWatch)
        Me.pSideMenu.Controls.Add(Me.lblPersonName)
        Me.pSideMenu.Controls.Add(Me.btnAdministracao)
        Me.pSideMenu.Controls.Add(Me.btnArtigos)
        Me.pSideMenu.Controls.Add(Me.btnOutros)
        Me.pSideMenu.Controls.Add(Me.btnGeral)
        Me.pSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.pSideMenu.Name = "pSideMenu"
        Me.pSideMenu.Size = New System.Drawing.Size(221, 711)
        Me.pSideMenu.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblDate.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(0, 587)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(215, 26)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "00:00:00"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWatch
        '
        Me.lblWatch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWatch.BackColor = System.Drawing.Color.Transparent
        Me.lblWatch.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblWatch.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWatch.Location = New System.Drawing.Point(0, 554)
        Me.lblWatch.Name = "lblWatch"
        Me.lblWatch.Size = New System.Drawing.Size(215, 33)
        Me.lblWatch.TabIndex = 12
        Me.lblWatch.Text = "00:00:00"
        Me.lblWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonName
        '
        Me.lblPersonName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPersonName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblPersonName.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPersonName.Location = New System.Drawing.Point(0, 403)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(215, 55)
        Me.lblPersonName.TabIndex = 6
        Me.lblPersonName.Text = "Person Name"
        Me.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrDate
        '
        '
        'pContent
        '
        Me.pContent.AutoSize = True
        Me.pContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pContent.BackColor = System.Drawing.Color.Transparent
        Me.pContent.BackgroundImage = Global.FCT_2021.My.Resources.Resources.LogoBackgroundPanel
        Me.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContent.Location = New System.Drawing.Point(221, 0)
        Me.pContent.Name = "pContent"
        Me.pContent.Size = New System.Drawing.Size(1163, 711)
        Me.pContent.TabIndex = 3
        '
        'picUser
        '
        Me.picUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picUser.BackgroundImage = Global.FCT_2021.My.Resources.Resources.NoImage
        Me.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser.Image = Global.FCT_2021.My.Resources.Resources.PictureFrame
        Me.picUser.Location = New System.Drawing.Point(70, 461)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(80, 80)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 15
        Me.picUser.TabStop = False
        '
        'btnAdministracao
        '
        Me.btnAdministracao.Active = False
        Me.btnAdministracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdministracao.AutoSize = True
        Me.btnAdministracao.BackColor = System.Drawing.Color.White
        Me.btnAdministracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdministracao.ButtonIcon = Global.FCT_2021.My.Resources.Resources.AdminIcon
        Me.btnAdministracao.ColorActive = System.Drawing.Color.White
        Me.btnAdministracao.Location = New System.Drawing.Point(0, 666)
        Me.btnAdministracao.Name = "btnAdministracao"
        Me.btnAdministracao.Purpose = 0
        Me.btnAdministracao.Size = New System.Drawing.Size(218, 45)
        Me.btnAdministracao.TabIndex = 4
        Me.btnAdministracao.TextInput = "Administração"
        '
        'btnArtigos
        '
        Me.btnArtigos.Active = False
        Me.btnArtigos.AutoSize = True
        Me.btnArtigos.BackColor = System.Drawing.Color.White
        Me.btnArtigos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArtigos.ButtonIcon = Global.FCT_2021.My.Resources.Resources.BoxIcon
        Me.btnArtigos.ColorActive = System.Drawing.Color.White
        Me.btnArtigos.Location = New System.Drawing.Point(0, 45)
        Me.btnArtigos.Name = "btnArtigos"
        Me.btnArtigos.Purpose = 2
        Me.btnArtigos.Size = New System.Drawing.Size(218, 45)
        Me.btnArtigos.TabIndex = 3
        Me.btnArtigos.TextInput = "Artigos"
        '
        'btnOutros
        '
        Me.btnOutros.Active = False
        Me.btnOutros.AutoSize = True
        Me.btnOutros.BackColor = System.Drawing.Color.White
        Me.btnOutros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOutros.ButtonIcon = Global.FCT_2021.My.Resources.Resources.IVA
        Me.btnOutros.ColorActive = System.Drawing.Color.White
        Me.btnOutros.Location = New System.Drawing.Point(0, 90)
        Me.btnOutros.Name = "btnOutros"
        Me.btnOutros.Purpose = 3
        Me.btnOutros.Size = New System.Drawing.Size(218, 45)
        Me.btnOutros.TabIndex = 1
        Me.btnOutros.TextInput = "Outros"
        '
        'btnGeral
        '
        Me.btnGeral.Active = False
        Me.btnGeral.AutoSize = True
        Me.btnGeral.BackColor = System.Drawing.Color.White
        Me.btnGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGeral.ButtonIcon = Global.FCT_2021.My.Resources.Resources.DocumentIcon
        Me.btnGeral.ColorActive = System.Drawing.Color.White
        Me.btnGeral.Location = New System.Drawing.Point(0, 0)
        Me.btnGeral.Name = "btnGeral"
        Me.btnGeral.Purpose = 1
        Me.btnGeral.Size = New System.Drawing.Size(218, 45)
        Me.btnGeral.TabIndex = 0
        Me.btnGeral.TextInput = "Geral"
        '
        'frmUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1384, 711)
        Me.Controls.Add(Me.pContent)
        Me.Controls.Add(Me.pSideMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(2000, 1100)
        Me.MinimumSize = New System.Drawing.Size(1400, 700)
        Me.Name = "frmUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HypeStack"
        Me.pSideMenu.ResumeLayout(False)
        Me.pSideMenu.PerformLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pSideMenu As Panel
    Friend WithEvents btnGeral As ucMenuButton
    Friend WithEvents btnArtigos As ucMenuButton
    Friend WithEvents pContent As Panel
    Friend WithEvents btnAdministracao As ucMenuButton
    Friend WithEvents lblPersonName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblWatch As Label
    Friend WithEvents tmrDate As Timer
    Friend WithEvents picUser As PictureBox
    Friend WithEvents btnOutros As ucMenuButton
End Class
