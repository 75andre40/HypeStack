<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSeries
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.pControlBox = New System.Windows.Forms.Panel()
        Me.pFiltroEntidades = New System.Windows.Forms.Panel()
        Me.lblTextFiltro = New System.Windows.Forms.Label()
        Me.picAnoAnterior = New System.Windows.Forms.PictureBox()
        Me.picAnoSeguinte = New System.Windows.Forms.PictureBox()
        Me.ugDoc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.btnIrAnoAtual = New FCT_2021.ucSquareButton()
        Me.btnAtualizarAno = New FCT_2021.ucSquareButton()
        Me.pControlBox.SuspendLayout()
        Me.pFiltroEntidades.SuspendLayout()
        CType(Me.picAnoAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnoSeguinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pControlBox
        '
        Me.pControlBox.BackColor = System.Drawing.Color.Transparent
        Me.pControlBox.Controls.Add(Me.btnIrAnoAtual)
        Me.pControlBox.Controls.Add(Me.pFiltroEntidades)
        Me.pControlBox.Controls.Add(Me.btnAtualizarAno)
        Me.pControlBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.pControlBox.Location = New System.Drawing.Point(0, 0)
        Me.pControlBox.Name = "pControlBox"
        Me.pControlBox.Size = New System.Drawing.Size(1169, 59)
        Me.pControlBox.TabIndex = 12
        '
        'pFiltroEntidades
        '
        Me.pFiltroEntidades.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pFiltroEntidades.BackgroundImage = Global.FCT_2021.My.Resources.Resources.UserFilterBG
        Me.pFiltroEntidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pFiltroEntidades.Controls.Add(Me.lblTextFiltro)
        Me.pFiltroEntidades.Controls.Add(Me.picAnoAnterior)
        Me.pFiltroEntidades.Controls.Add(Me.picAnoSeguinte)
        Me.pFiltroEntidades.Location = New System.Drawing.Point(494, 10)
        Me.pFiltroEntidades.Name = "pFiltroEntidades"
        Me.pFiltroEntidades.Size = New System.Drawing.Size(180, 38)
        Me.pFiltroEntidades.TabIndex = 33
        '
        'lblTextFiltro
        '
        Me.lblTextFiltro.Font = New System.Drawing.Font("Cascadia Code SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTextFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTextFiltro.Location = New System.Drawing.Point(38, 0)
        Me.lblTextFiltro.Name = "lblTextFiltro"
        Me.lblTextFiltro.Size = New System.Drawing.Size(104, 38)
        Me.lblTextFiltro.TabIndex = 5
        Me.lblTextFiltro.Text = "2023"
        Me.lblTextFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picAnoAnterior
        '
        Me.picAnoAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAnoAnterior.Dock = System.Windows.Forms.DockStyle.Left
        Me.picAnoAnterior.Image = Global.FCT_2021.My.Resources.Resources.UserFilterArrowLeft
        Me.picAnoAnterior.Location = New System.Drawing.Point(0, 0)
        Me.picAnoAnterior.Name = "picAnoAnterior"
        Me.picAnoAnterior.Size = New System.Drawing.Size(38, 38)
        Me.picAnoAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAnoAnterior.TabIndex = 4
        Me.picAnoAnterior.TabStop = False
        '
        'picAnoSeguinte
        '
        Me.picAnoSeguinte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAnoSeguinte.Dock = System.Windows.Forms.DockStyle.Right
        Me.picAnoSeguinte.Image = Global.FCT_2021.My.Resources.Resources.UserFilterArrowRight
        Me.picAnoSeguinte.Location = New System.Drawing.Point(142, 0)
        Me.picAnoSeguinte.Name = "picAnoSeguinte"
        Me.picAnoSeguinte.Size = New System.Drawing.Size(38, 38)
        Me.picAnoSeguinte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAnoSeguinte.TabIndex = 3
        Me.picAnoSeguinte.TabStop = False
        Me.picAnoSeguinte.Visible = False
        '
        'ugDoc
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugDoc.DisplayLayout.Appearance = Appearance1
        Me.ugDoc.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugDoc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugDoc.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugDoc.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugDoc.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugDoc.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugDoc.DisplayLayout.MaxColScrollRegions = 1
        Me.ugDoc.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugDoc.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugDoc.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugDoc.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugDoc.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugDoc.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugDoc.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugDoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugDoc.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugDoc.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugDoc.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugDoc.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugDoc.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugDoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugDoc.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugDoc.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugDoc.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugDoc.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugDoc.Location = New System.Drawing.Point(0, 59)
        Me.ugDoc.Name = "ugDoc"
        Me.ugDoc.Size = New System.Drawing.Size(1169, 652)
        Me.ugDoc.TabIndex = 31
        Me.ugDoc.Text = "ugDocs"
        Me.ugDoc.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnIrAnoAtual
        '
        Me.btnIrAnoAtual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIrAnoAtual.AutoSize = True
        Me.btnIrAnoAtual.BackColor = System.Drawing.Color.Transparent
        Me.btnIrAnoAtual.ImageInput = Global.FCT_2021.My.Resources.Resources.AnoAtual
        Me.btnIrAnoAtual.Location = New System.Drawing.Point(680, 10)
        Me.btnIrAnoAtual.Name = "btnIrAnoAtual"
        Me.btnIrAnoAtual.Size = New System.Drawing.Size(38, 38)
        Me.btnIrAnoAtual.TabIndex = 34
        Me.btnIrAnoAtual.Tag = "1"
        '
        'btnAtualizarAno
        '
        Me.btnAtualizarAno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAtualizarAno.AutoSize = True
        Me.btnAtualizarAno.BackColor = System.Drawing.Color.Transparent
        Me.btnAtualizarAno.ImageInput = Global.FCT_2021.My.Resources.Resources.NovoAno1
        Me.btnAtualizarAno.Location = New System.Drawing.Point(450, 10)
        Me.btnAtualizarAno.Name = "btnAtualizarAno"
        Me.btnAtualizarAno.Size = New System.Drawing.Size(38, 38)
        Me.btnAtualizarAno.TabIndex = 3
        Me.btnAtualizarAno.Tag = "1"
        '
        'ucSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ugDoc)
        Me.Controls.Add(Me.pControlBox)
        Me.Name = "ucSeries"
        Me.Size = New System.Drawing.Size(1169, 711)
        Me.pControlBox.ResumeLayout(False)
        Me.pControlBox.PerformLayout()
        Me.pFiltroEntidades.ResumeLayout(False)
        CType(Me.picAnoAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnoSeguinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pControlBox As Panel
    Friend WithEvents btnAtualizarAno As ucSquareButton
    Friend WithEvents ugDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents pFiltroEntidades As Panel
    Friend WithEvents lblTextFiltro As Label
    Friend WithEvents picAnoAnterior As PictureBox
    Friend WithEvents picAnoSeguinte As PictureBox
    Friend WithEvents btnIrAnoAtual As ucSquareButton
End Class
