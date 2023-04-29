<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_DetalhesArtigo
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
        Me.Panel_Artigo = New System.Windows.Forms.Panel()
        Me.Panel_BackDesc = New System.Windows.Forms.Panel()
        Me.Panel_Descricao = New System.Windows.Forms.Panel()
        Me.Lbl_Descricao = New System.Windows.Forms.Label()
        Me.Panel_Utils = New System.Windows.Forms.Panel()
        Me.Lbl_Stock = New System.Windows.Forms.Label()
        Me.Lbl_PrecoDesconto = New System.Windows.Forms.Label()
        Me.Lbl_Preco = New System.Windows.Forms.Label()
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Panel_Info = New System.Windows.Forms.Panel()
        Me.BtnVoltar = New System.Windows.Forms.PictureBox()
        Me.Pic_3 = New System.Windows.Forms.PictureBox()
        Me.Pic_2 = New System.Windows.Forms.PictureBox()
        Me.Pic_1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Artigo.SuspendLayout()
        Me.Panel_BackDesc.SuspendLayout()
        Me.Panel_Descricao.SuspendLayout()
        Me.Panel_Utils.SuspendLayout()
        Me.Panel_Info.SuspendLayout()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Artigo
        '
        Me.Panel_Artigo.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Artigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Artigo.Controls.Add(Me.Panel_BackDesc)
        Me.Panel_Artigo.Controls.Add(Me.Panel_Utils)
        Me.Panel_Artigo.Controls.Add(Me.Panel_Info)
        Me.Panel_Artigo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Artigo.Name = "Panel_Artigo"
        Me.Panel_Artigo.Size = New System.Drawing.Size(752, 385)
        Me.Panel_Artigo.TabIndex = 0
        '
        'Panel_BackDesc
        '
        Me.Panel_BackDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_BackDesc.BackColor = System.Drawing.Color.Transparent
        Me.Panel_BackDesc.BackgroundImage = Global.FCT_2021.My.Resources.Resources.PanelBackground
        Me.Panel_BackDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_BackDesc.Controls.Add(Me.Panel_Descricao)
        Me.Panel_BackDesc.Location = New System.Drawing.Point(480, 197)
        Me.Panel_BackDesc.Name = "Panel_BackDesc"
        Me.Panel_BackDesc.Size = New System.Drawing.Size(267, 183)
        Me.Panel_BackDesc.TabIndex = 2
        '
        'Panel_Descricao
        '
        Me.Panel_Descricao.AutoScroll = True
        Me.Panel_Descricao.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Descricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Descricao.Controls.Add(Me.Lbl_Descricao)
        Me.Panel_Descricao.Location = New System.Drawing.Point(3, 4)
        Me.Panel_Descricao.Name = "Panel_Descricao"
        Me.Panel_Descricao.Size = New System.Drawing.Size(260, 170)
        Me.Panel_Descricao.TabIndex = 0
        '
        'Lbl_Descricao
        '
        Me.Lbl_Descricao.AutoSize = True
        Me.Lbl_Descricao.Font = New System.Drawing.Font("Cascadia Code", 9.75!)
        Me.Lbl_Descricao.Location = New System.Drawing.Point(2, 4)
        Me.Lbl_Descricao.Name = "Lbl_Descricao"
        Me.Lbl_Descricao.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_Descricao.TabIndex = 1
        Me.Lbl_Descricao.Text = "Label2"
        '
        'Panel_Utils
        '
        Me.Panel_Utils.Controls.Add(Me.Lbl_Stock)
        Me.Panel_Utils.Controls.Add(Me.Lbl_PrecoDesconto)
        Me.Panel_Utils.Controls.Add(Me.Lbl_Preco)
        Me.Panel_Utils.Controls.Add(Me.Lbl_Nome)
        Me.Panel_Utils.Location = New System.Drawing.Point(480, 3)
        Me.Panel_Utils.Name = "Panel_Utils"
        Me.Panel_Utils.Size = New System.Drawing.Size(267, 188)
        Me.Panel_Utils.TabIndex = 1
        '
        'Lbl_Stock
        '
        Me.Lbl_Stock.AutoSize = True
        Me.Lbl_Stock.Font = New System.Drawing.Font("Cascadia Code", 9.75!)
        Me.Lbl_Stock.Location = New System.Drawing.Point(5, 159)
        Me.Lbl_Stock.Name = "Lbl_Stock"
        Me.Lbl_Stock.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_Stock.TabIndex = 0
        Me.Lbl_Stock.Text = "Label2"
        '
        'Lbl_PrecoDesconto
        '
        Me.Lbl_PrecoDesconto.AutoSize = True
        Me.Lbl_PrecoDesconto.Font = New System.Drawing.Font("Cascadia Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PrecoDesconto.Location = New System.Drawing.Point(5, 75)
        Me.Lbl_PrecoDesconto.Name = "Lbl_PrecoDesconto"
        Me.Lbl_PrecoDesconto.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_PrecoDesconto.TabIndex = 1
        Me.Lbl_PrecoDesconto.Text = "Label1"
        '
        'Lbl_Preco
        '
        Me.Lbl_Preco.AutoSize = True
        Me.Lbl_Preco.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Preco.Location = New System.Drawing.Point(3, 92)
        Me.Lbl_Preco.Name = "Lbl_Preco"
        Me.Lbl_Preco.Size = New System.Drawing.Size(78, 25)
        Me.Lbl_Preco.TabIndex = 4
        Me.Lbl_Preco.Text = "Label1"
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nome.Location = New System.Drawing.Point(3, 4)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(256, 65)
        Me.Lbl_Nome.TabIndex = 3
        Me.Lbl_Nome.Text = "Label1"
        '
        'Panel_Info
        '
        Me.Panel_Info.AutoScroll = True
        Me.Panel_Info.Controls.Add(Me.BtnVoltar)
        Me.Panel_Info.Controls.Add(Me.Pic_3)
        Me.Panel_Info.Controls.Add(Me.Pic_2)
        Me.Panel_Info.Controls.Add(Me.Pic_1)
        Me.Panel_Info.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Info.Name = "Panel_Info"
        Me.Panel_Info.Size = New System.Drawing.Size(471, 377)
        Me.Panel_Info.TabIndex = 0
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVoltar.Image = Global.FCT_2021.My.Resources.Resources.BackButton
        Me.BtnVoltar.Location = New System.Drawing.Point(418, 323)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(45, 45)
        Me.BtnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnVoltar.TabIndex = 3
        Me.BtnVoltar.TabStop = False
        '
        'Pic_3
        '
        Me.Pic_3.Location = New System.Drawing.Point(318, 159)
        Me.Pic_3.Name = "Pic_3"
        Me.Pic_3.Size = New System.Drawing.Size(145, 145)
        Me.Pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_3.TabIndex = 2
        Me.Pic_3.TabStop = False
        '
        'Pic_2
        '
        Me.Pic_2.Location = New System.Drawing.Point(318, 4)
        Me.Pic_2.Name = "Pic_2"
        Me.Pic_2.Size = New System.Drawing.Size(145, 145)
        Me.Pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_2.TabIndex = 1
        Me.Pic_2.TabStop = False
        '
        'Pic_1
        '
        Me.Pic_1.Location = New System.Drawing.Point(9, 4)
        Me.Pic_1.Name = "Pic_1"
        Me.Pic_1.Size = New System.Drawing.Size(300, 300)
        Me.Pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_1.TabIndex = 0
        Me.Pic_1.TabStop = False
        '
        'UC_DetalhesArtigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Artigo)
        Me.DoubleBuffered = True
        Me.Name = "UC_DetalhesArtigo"
        Me.Size = New System.Drawing.Size(753, 387)
        Me.Panel_Artigo.ResumeLayout(False)
        Me.Panel_BackDesc.ResumeLayout(False)
        Me.Panel_Descricao.ResumeLayout(False)
        Me.Panel_Descricao.PerformLayout()
        Me.Panel_Utils.ResumeLayout(False)
        Me.Panel_Utils.PerformLayout()
        Me.Panel_Info.ResumeLayout(False)
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Artigo As Panel
    Friend WithEvents Panel_Utils As Panel
    Friend WithEvents Panel_Info As Panel
    Friend WithEvents Pic_1 As PictureBox
    Friend WithEvents Lbl_Preco As Label
    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Pic_3 As PictureBox
    Friend WithEvents Pic_2 As PictureBox
    Friend WithEvents Lbl_Stock As Label
    Friend WithEvents Lbl_PrecoDesconto As Label
    Friend WithEvents BtnVoltar As PictureBox
    Friend WithEvents Panel_Descricao As Panel
    Friend WithEvents Lbl_Descricao As Label
    Friend WithEvents Panel_BackDesc As Panel
End Class
