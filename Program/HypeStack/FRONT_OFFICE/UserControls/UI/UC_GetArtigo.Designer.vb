<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_GetArtigo
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
        Me.Panel_Artigo = New System.Windows.Forms.Panel()
        Me.Lbl_Euro2 = New System.Windows.Forms.Label()
        Me.Lbl_Preco = New System.Windows.Forms.Label()
        Me.Lbl_Euro = New System.Windows.Forms.Label()
        Me.Lbl_Stock = New System.Windows.Forms.Label()
        Me.Pic_Add = New System.Windows.Forms.PictureBox()
        Me.CMS_Add = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TxtMenu_Qtd = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnMenu_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMenu_Remover = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMenu_Adicionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMenu_Cancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_PrecoDesconto = New System.Windows.Forms.Label()
        Me.Lbl_Descricao = New System.Windows.Forms.Label()
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Pic_Artigo = New System.Windows.Forms.PictureBox()
        Me.TT_AddInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel_Artigo.SuspendLayout()
        CType(Me.Pic_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_Add.SuspendLayout()
        CType(Me.Pic_Artigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Artigo
        '
        Me.Panel_Artigo.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Artigo.Controls.Add(Me.Lbl_Euro2)
        Me.Panel_Artigo.Controls.Add(Me.Lbl_Preco)
        Me.Panel_Artigo.Controls.Add(Me.Lbl_Euro)
        Me.Panel_Artigo.Controls.Add(Me.Lbl_Stock)
        Me.Panel_Artigo.Controls.Add(Me.Pic_Add)
        Me.Panel_Artigo.Controls.Add(Me.Lbl_PrecoDesconto)
        Me.Panel_Artigo.Controls.Add(Me.Lbl_Descricao)
        Me.Panel_Artigo.Controls.Add(Me.Lbl_Nome)
        Me.Panel_Artigo.Controls.Add(Me.Pic_Artigo)
        Me.Panel_Artigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Artigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Artigo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Artigo.Name = "Panel_Artigo"
        Me.Panel_Artigo.Size = New System.Drawing.Size(215, 374)
        Me.Panel_Artigo.TabIndex = 0
        '
        'Lbl_Euro2
        '
        Me.Lbl_Euro2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Euro2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Euro2.Font = New System.Drawing.Font("Cascadia Code", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Euro2.Location = New System.Drawing.Point(192, 329)
        Me.Lbl_Euro2.Name = "Lbl_Euro2"
        Me.Lbl_Euro2.Size = New System.Drawing.Size(19, 21)
        Me.Lbl_Euro2.TabIndex = 8
        Me.Lbl_Euro2.Text = "€"
        Me.Lbl_Euro2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_Preco
        '
        Me.Lbl_Preco.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Preco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Preco.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Preco.Location = New System.Drawing.Point(78, 346)
        Me.Lbl_Preco.Name = "Lbl_Preco"
        Me.Lbl_Preco.Size = New System.Drawing.Size(117, 21)
        Me.Lbl_Preco.TabIndex = 4
        Me.Lbl_Preco.Text = "Label1"
        Me.Lbl_Preco.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_Euro
        '
        Me.Lbl_Euro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Euro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Euro.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Euro.Location = New System.Drawing.Point(192, 346)
        Me.Lbl_Euro.Name = "Lbl_Euro"
        Me.Lbl_Euro.Size = New System.Drawing.Size(19, 21)
        Me.Lbl_Euro.TabIndex = 7
        Me.Lbl_Euro.Text = "€"
        Me.Lbl_Euro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_Stock
        '
        Me.Lbl_Stock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Stock.AutoSize = True
        Me.Lbl_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Stock.Font = New System.Drawing.Font("Cascadia Code", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Stock.Location = New System.Drawing.Point(7, 319)
        Me.Lbl_Stock.Name = "Lbl_Stock"
        Me.Lbl_Stock.Size = New System.Drawing.Size(49, 16)
        Me.Lbl_Stock.TabIndex = 3
        Me.Lbl_Stock.Text = "Label1"
        '
        'Pic_Add
        '
        Me.Pic_Add.ContextMenuStrip = Me.CMS_Add
        Me.Pic_Add.Location = New System.Drawing.Point(16, 342)
        Me.Pic_Add.Name = "Pic_Add"
        Me.Pic_Add.Size = New System.Drawing.Size(22, 20)
        Me.Pic_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Add.TabIndex = 6
        Me.Pic_Add.TabStop = False
        Me.TT_AddInfo.SetToolTip(Me.Pic_Add, "Clique com o butão direito" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " para adicionar mais de um artigo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de uma só vez" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'CMS_Add
        '
        Me.CMS_Add.AutoClose = False
        Me.CMS_Add.AutoSize = False
        Me.CMS_Add.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtMenu_Qtd, Me.ToolStripSeparator1, Me.BtnMenu_Add, Me.BtnMenu_Remover, Me.BtnMenu_Adicionar, Me.BtnMenu_Cancelar})
        Me.CMS_Add.Name = "CMS_Add"
        Me.CMS_Add.ShowImageMargin = False
        Me.CMS_Add.Size = New System.Drawing.Size(120, 130)
        Me.CMS_Add.Text = "Adicionar Artigo"
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
        'BtnMenu_Add
        '
        Me.BtnMenu_Add.Name = "BtnMenu_Add"
        Me.BtnMenu_Add.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_Add.Text = "               +"
        '
        'BtnMenu_Remover
        '
        Me.BtnMenu_Remover.Name = "BtnMenu_Remover"
        Me.BtnMenu_Remover.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_Remover.Text = "               -"
        '
        'BtnMenu_Adicionar
        '
        Me.BtnMenu_Adicionar.Name = "BtnMenu_Adicionar"
        Me.BtnMenu_Adicionar.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_Adicionar.Text = "        Confirmar"
        '
        'BtnMenu_Cancelar
        '
        Me.BtnMenu_Cancelar.Name = "BtnMenu_Cancelar"
        Me.BtnMenu_Cancelar.Size = New System.Drawing.Size(135, 22)
        Me.BtnMenu_Cancelar.Text = "         Cancelar"
        '
        'Lbl_PrecoDesconto
        '
        Me.Lbl_PrecoDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_PrecoDesconto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_PrecoDesconto.Font = New System.Drawing.Font("Cascadia Code", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PrecoDesconto.Location = New System.Drawing.Point(82, 328)
        Me.Lbl_PrecoDesconto.Name = "Lbl_PrecoDesconto"
        Me.Lbl_PrecoDesconto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_PrecoDesconto.Size = New System.Drawing.Size(113, 18)
        Me.Lbl_PrecoDesconto.TabIndex = 5
        Me.Lbl_PrecoDesconto.Text = "0"
        Me.Lbl_PrecoDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Descricao
        '
        Me.Lbl_Descricao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Descricao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Descricao.Font = New System.Drawing.Font("Cascadia Code", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Descricao.Location = New System.Drawing.Point(7, 266)
        Me.Lbl_Descricao.Name = "Lbl_Descricao"
        Me.Lbl_Descricao.Size = New System.Drawing.Size(197, 46)
        Me.Lbl_Descricao.TabIndex = 2
        Me.Lbl_Descricao.Text = "Label1"
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Nome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Nome.Font = New System.Drawing.Font("Cascadia Code", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nome.Location = New System.Drawing.Point(7, 207)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(198, 47)
        Me.Lbl_Nome.TabIndex = 1
        Me.Lbl_Nome.Text = "Label1"
        '
        'Pic_Artigo
        '
        Me.Pic_Artigo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_Artigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Artigo.Location = New System.Drawing.Point(10, 9)
        Me.Pic_Artigo.Name = "Pic_Artigo"
        Me.Pic_Artigo.Size = New System.Drawing.Size(195, 195)
        Me.Pic_Artigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Artigo.TabIndex = 0
        Me.Pic_Artigo.TabStop = False
        '
        'UC_GetArtigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Artigo)
        Me.DoubleBuffered = True
        Me.Name = "UC_GetArtigo"
        Me.Size = New System.Drawing.Size(215, 374)
        Me.TT_AddInfo.SetToolTip(Me, "Clique com o butão direito" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para adicionar mais de um artigo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de uma só vez")
        Me.Panel_Artigo.ResumeLayout(False)
        Me.Panel_Artigo.PerformLayout()
        CType(Me.Pic_Add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_Add.ResumeLayout(False)
        Me.CMS_Add.PerformLayout()
        CType(Me.Pic_Artigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Artigo As Panel
    Friend WithEvents Pic_Artigo As PictureBox
    Friend WithEvents Lbl_PrecoDesconto As Label
    Friend WithEvents Lbl_Preco As Label
    Friend WithEvents Lbl_Stock As Label
    Friend WithEvents Lbl_Descricao As Label
    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Pic_Add As PictureBox
    Friend WithEvents Lbl_Euro As Label
    Friend WithEvents Lbl_Euro2 As Label
    Friend WithEvents TT_AddInfo As ToolTip
    Friend WithEvents CMS_Add As ContextMenuStrip
    Friend WithEvents TxtMenu_Qtd As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox5 As ToolStripTextBox
    Friend WithEvents BtnMenu_Add As ToolStripMenuItem
    Friend WithEvents BtnMenu_Remover As ToolStripMenuItem
    Friend WithEvents BtnMenu_Adicionar As ToolStripMenuItem
    Friend WithEvents BtnMenu_Cancelar As ToolStripMenuItem
End Class
