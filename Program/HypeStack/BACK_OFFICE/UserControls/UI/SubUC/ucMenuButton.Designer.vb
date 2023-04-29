<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenuButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblText = New System.Windows.Forms.Label()
        Me.pActive = New System.Windows.Forms.Panel()
        Me.picImage = New System.Windows.Forms.PictureBox()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblText.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblText.Location = New System.Drawing.Point(10, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(205, 150)
        Me.lblText.TabIndex = 5
        Me.lblText.Text = "Menu 1"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pActive
        '
        Me.pActive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pActive.BackColor = System.Drawing.Color.White
        Me.pActive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pActive.Location = New System.Drawing.Point(0, 0)
        Me.pActive.Name = "pActive"
        Me.pActive.Size = New System.Drawing.Size(10, 150)
        Me.pActive.TabIndex = 6
        '
        'picImage
        '
        Me.picImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picImage.BackColor = System.Drawing.Color.Transparent
        Me.picImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picImage.Location = New System.Drawing.Point(178, 5)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(35, 140)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 7
        Me.picImage.TabStop = False
        '
        'ucMenuButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.pActive)
        Me.Controls.Add(Me.lblText)
        Me.DoubleBuffered = True
        Me.Name = "ucMenuButton"
        Me.Size = New System.Drawing.Size(218, 150)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents pActive As Panel
    Friend WithEvents picImage As PictureBox
End Class
