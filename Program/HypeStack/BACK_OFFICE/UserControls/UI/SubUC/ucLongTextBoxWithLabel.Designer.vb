<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucLongTextBoxWithLabel
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtContent = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        CType(Me.txtContent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblText.Font = New System.Drawing.Font("Cascadia Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(340, 24)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Text"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContent
        '
        Me.txtContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContent.Appearance = Appearance1
        Me.txtContent.AutoSize = False
        Me.txtContent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContent.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtContent.Font = New System.Drawing.Font("Cascadia Code", 9.75!)
        Me.txtContent.Location = New System.Drawing.Point(13, 40)
        Me.txtContent.MaxLength = 50
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(315, 85)
        Me.txtContent.TabIndex = 2
        Me.txtContent.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'picBackground
        '
        Me.picBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBackground.Image = Global.FCT_2021.My.Resources.Resources.LongTextBoxBG
        Me.picBackground.Location = New System.Drawing.Point(0, 27)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(340, 110)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'ucLongTextBoxWithLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "ucLongTextBoxWithLabel"
        Me.Size = New System.Drawing.Size(340, 137)
        CType(Me.txtContent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBackground As PictureBox
    Private WithEvents lblText As Label
    Friend WithEvents txtContent As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
