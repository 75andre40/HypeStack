<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class ucFormChooser
    Inherits DevExpress.XtraEditors.XtraUserControl
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.tileBar = New DevExpress.XtraBars.Navigation.TileBar()
        Me.tileBarGroupTables = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tileBar
        '
        Me.tileBar.AllowDragTilesBetweenGroups = False
        Me.tileBar.AllowGlyphSkinning = True
        Me.tileBar.AllowSelectedItem = True
        Me.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.tileBar.AppearanceGroupText.Options.UseForeColor = True
        Me.tileBar.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tileBar.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tileBar.AppearanceItem.Hovered.Font = New System.Drawing.Font("Cascadia Code", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tileBar.AppearanceItem.Hovered.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.tileBar.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.White
        Me.tileBar.AppearanceItem.Hovered.Options.UseBackColor = True
        Me.tileBar.AppearanceItem.Hovered.Options.UseBorderColor = True
        Me.tileBar.AppearanceItem.Hovered.Options.UseFont = True
        Me.tileBar.AppearanceItem.Hovered.Options.UseForeColor = True
        Me.tileBar.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrange
        Me.tileBar.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrange
        Me.tileBar.AppearanceItem.Normal.Font = New System.Drawing.Font("Cascadia Code", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tileBar.AppearanceItem.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.tileBar.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White
        Me.tileBar.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileBar.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.tileBar.AppearanceItem.Normal.Options.UseFont = True
        Me.tileBar.AppearanceItem.Normal.Options.UseForeColor = True
        Me.tileBar.AppearanceItem.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tileBar.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tileBar.AppearanceItem.Pressed.Font = New System.Drawing.Font("Cascadia Code", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tileBar.AppearanceItem.Pressed.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.tileBar.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.White
        Me.tileBar.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.tileBar.AppearanceItem.Pressed.Options.UseBorderColor = True
        Me.tileBar.AppearanceItem.Pressed.Options.UseFont = True
        Me.tileBar.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.tileBar.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tileBar.AppearanceItem.Selected.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tileBar.AppearanceItem.Selected.Font = New System.Drawing.Font("Cascadia Code", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tileBar.AppearanceItem.Selected.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.tileBar.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White
        Me.tileBar.AppearanceItem.Selected.Options.UseBackColor = True
        Me.tileBar.AppearanceItem.Selected.Options.UseBorderColor = True
        Me.tileBar.AppearanceItem.Selected.Options.UseFont = True
        Me.tileBar.AppearanceItem.Selected.Options.UseForeColor = True
        Me.tileBar.BackColor = System.Drawing.Color.White
        Me.tileBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.tileBar.DropDownButtonWidth = 30
        Me.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.tileBar.Groups.Add(Me.tileBarGroupTables)
        Me.tileBar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tileBar.IndentBetweenGroups = 10
        Me.tileBar.IndentBetweenItems = 10
        Me.tileBar.ItemPadding = New System.Windows.Forms.Padding(8, 6, 12, 6)
        Me.tileBar.ItemSize = 40
        Me.tileBar.Location = New System.Drawing.Point(0, 0)
        Me.tileBar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tileBar.MaxId = 7
        Me.tileBar.MaximumSize = New System.Drawing.Size(0, 127)
        Me.tileBar.MinimumSize = New System.Drawing.Size(100, 90)
        Me.tileBar.Name = "tileBar"
        Me.tileBar.Padding = New System.Windows.Forms.Padding(29, 13, 29, 13)
        Me.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None
        Me.tileBar.SelectionBorderWidth = 2
        Me.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor
        Me.tileBar.ShowGroupText = False
        Me.tileBar.Size = New System.Drawing.Size(1169, 90)
        Me.tileBar.TabIndex = 1
        Me.tileBar.Text = "tileBar"
        Me.tileBar.WideTileWidth = 130
        '
        'tileBarGroupTables
        '
        Me.tileBarGroupTables.Name = "tileBarGroupTables"
        Me.tileBarGroupTables.Text = "Categoria"
        '
        'navigationFrame
        '
        Me.navigationFrame.BackgroundImage = Global.FCT_2021.My.Resources.Resources.LogoBackgroundPanel
        Me.navigationFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navigationFrame.Location = New System.Drawing.Point(0, 90)
        Me.navigationFrame.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.navigationFrame.Name = "navigationFrame"
        Me.navigationFrame.SelectedPage = Nothing
        Me.navigationFrame.Size = New System.Drawing.Size(1169, 621)
        Me.navigationFrame.TabIndex = 0
        Me.navigationFrame.Text = "navigationFrame"
        '
        'ucFormChooser
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.navigationFrame)
        Me.Controls.Add(Me.tileBar)
        Me.Name = "ucFormChooser"
        Me.Size = New System.Drawing.Size(1169, 711)
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents tileBar As DevExpress.XtraBars.Navigation.TileBar
    Private WithEvents navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
    Private WithEvents tileBarGroupTables As DevExpress.XtraBars.Navigation.TileBarGroup
End Class
