<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTextBox
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
        Me.lblGreyText = New System.Windows.Forms.Label()
        Me.txtContent = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.txtContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGreyText
        '
        Me.lblGreyText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGreyText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblGreyText.Font = New System.Drawing.Font("Cascadia Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreyText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblGreyText.Location = New System.Drawing.Point(14, 5)
        Me.lblGreyText.Name = "lblGreyText"
        Me.lblGreyText.Size = New System.Drawing.Size(179, 31)
        Me.lblGreyText.TabIndex = 0
        Me.lblGreyText.Text = "Text"
        Me.lblGreyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContent
        '
        Me.txtContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Appearance1.BackColorDisabled = System.Drawing.Color.Transparent
        Appearance1.BackColorDisabled2 = System.Drawing.Color.Transparent
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.None
        Appearance1.BackHatchStyle = Infragistics.Win.BackHatchStyle.None
        Appearance1.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Appearance1.BorderColor = System.Drawing.Color.Transparent
        Appearance1.BorderColor2 = System.Drawing.Color.Transparent
        Appearance1.BorderColor3DBase = System.Drawing.Color.Transparent
        Me.txtContent.Appearance = Appearance1
        Me.txtContent.AutoSize = False
        Me.txtContent.BackColor = System.Drawing.Color.Transparent
        Me.txtContent.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtContent.Font = New System.Drawing.Font("Cascadia Code", 9.75!)
        Me.txtContent.Location = New System.Drawing.Point(9, 10)
        Me.txtContent.MaxLength = 50
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(205, 22)
        Me.txtContent.TabIndex = 1
        Me.txtContent.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ucTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.FCT_2021.My.Resources.Resources.TextBoxBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lblGreyText)
        Me.Controls.Add(Me.txtContent)
        Me.DoubleBuffered = True
        Me.Name = "ucTextBox"
        Me.Size = New System.Drawing.Size(225, 42)
        CType(Me.txtContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblGreyText As Label
    Friend WithEvents txtContent As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
