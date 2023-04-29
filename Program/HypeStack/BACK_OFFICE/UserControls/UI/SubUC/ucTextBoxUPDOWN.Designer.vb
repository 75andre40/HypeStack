<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTextBoxUPDOWN
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtContent = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.picArrowDown = New System.Windows.Forms.PictureBox()
        Me.picArrowUp = New System.Windows.Forms.PictureBox()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        CType(Me.txtContent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrowDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblText.Font = New System.Drawing.Font("Cascadia Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(225, 24)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Text"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnits
        '
        Me.lblUnits.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUnits.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUnits.Font = New System.Drawing.Font("Cascadia Code", 9.75!)
        Me.lblUnits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUnits.Location = New System.Drawing.Point(167, 37)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(24, 20)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "Un"
        '
        'txtContent
        '
        Me.txtContent.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.TextHAlignAsString = "Right"
        Appearance1.TextVAlignAsString = "Middle"
        Me.txtContent.Appearance = Appearance1
        Me.txtContent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContent.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtContent.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(9, 37)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(159, 20)
        Me.txtContent.TabIndex = 6
        Me.txtContent.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.txtContent.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'picArrowDown
        '
        Me.picArrowDown.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picArrowDown.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picArrowDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picArrowDown.Image = Global.FCT_2021.My.Resources.Resources.ArrowDown
        Me.picArrowDown.Location = New System.Drawing.Point(197, 45)
        Me.picArrowDown.Name = "picArrowDown"
        Me.picArrowDown.Size = New System.Drawing.Size(25, 16)
        Me.picArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrowDown.TabIndex = 4
        Me.picArrowDown.TabStop = False
        '
        'picArrowUp
        '
        Me.picArrowUp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picArrowUp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picArrowUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picArrowUp.Image = Global.FCT_2021.My.Resources.Resources.ArrowUP
        Me.picArrowUp.Location = New System.Drawing.Point(197, 27)
        Me.picArrowUp.Name = "picArrowUp"
        Me.picArrowUp.Size = New System.Drawing.Size(25, 16)
        Me.picArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrowUp.TabIndex = 3
        Me.picArrowUp.TabStop = False
        '
        'picBackground
        '
        Me.picBackground.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBackground.Image = Global.FCT_2021.My.Resources.Resources.TextBoxBG
        Me.picBackground.Location = New System.Drawing.Point(0, 23)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(225, 42)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'ucTextBoxUPDOWN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.picArrowDown)
        Me.Controls.Add(Me.picArrowUp)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "ucTextBoxUPDOWN"
        Me.Size = New System.Drawing.Size(225, 65)
        CType(Me.txtContent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrowDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Private WithEvents lblText As Label
    Friend WithEvents picArrowUp As PictureBox
    Friend WithEvents picArrowDown As PictureBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtContent As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
