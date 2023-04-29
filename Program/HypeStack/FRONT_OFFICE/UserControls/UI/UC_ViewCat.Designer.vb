<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ViewCat
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
        Me.Panel_Cat = New System.Windows.Forms.FlowLayoutPanel()
        Me.Pic_Close = New System.Windows.Forms.PictureBox()
        Me.Panel_BackGround = New System.Windows.Forms.Panel()
        CType(Me.Pic_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_BackGround.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Cat
        '
        Me.Panel_Cat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_Cat.AutoScroll = True
        Me.Panel_Cat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Cat.Name = "Panel_Cat"
        Me.Panel_Cat.Size = New System.Drawing.Size(780, 210)
        Me.Panel_Cat.TabIndex = 0
        Me.Panel_Cat.WrapContents = False
        '
        'Pic_Close
        '
        Me.Pic_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_Close.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Close.Image = Global.FCT_2021.My.Resources.Resources.Close
        Me.Pic_Close.Location = New System.Drawing.Point(782, 3)
        Me.Pic_Close.Name = "Pic_Close"
        Me.Pic_Close.Size = New System.Drawing.Size(30, 30)
        Me.Pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Close.TabIndex = 1
        Me.Pic_Close.TabStop = False
        '
        'Panel_BackGround
        '
        Me.Panel_BackGround.Controls.Add(Me.Pic_Close)
        Me.Panel_BackGround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_BackGround.Location = New System.Drawing.Point(0, 0)
        Me.Panel_BackGround.Name = "Panel_BackGround"
        Me.Panel_BackGround.Size = New System.Drawing.Size(815, 210)
        Me.Panel_BackGround.TabIndex = 3
        '
        'UC_ViewCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel_Cat)
        Me.Controls.Add(Me.Panel_BackGround)
        Me.Name = "UC_ViewCat"
        Me.Size = New System.Drawing.Size(815, 210)
        CType(Me.Pic_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_BackGround.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Cat As FlowLayoutPanel
    Friend WithEvents Pic_Close As PictureBox
    Friend WithEvents Panel_BackGround As Panel
End Class
