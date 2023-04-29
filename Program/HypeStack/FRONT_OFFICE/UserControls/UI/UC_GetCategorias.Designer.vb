<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_GetCategorias
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
        Me.Panel_Categoria = New System.Windows.Forms.Panel()
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Pic_Categoria = New System.Windows.Forms.PictureBox()
        Me.Panel_Categoria.SuspendLayout()
        CType(Me.Pic_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Categoria
        '
        Me.Panel_Categoria.Controls.Add(Me.Lbl_Nome)
        Me.Panel_Categoria.Controls.Add(Me.Pic_Categoria)
        Me.Panel_Categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Categoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Categoria.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Categoria.Name = "Panel_Categoria"
        Me.Panel_Categoria.Size = New System.Drawing.Size(150, 200)
        Me.Panel_Categoria.TabIndex = 0
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.Font = New System.Drawing.Font("Cascadia Code SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nome.Location = New System.Drawing.Point(4, 153)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(143, 45)
        Me.Lbl_Nome.TabIndex = 1
        Me.Lbl_Nome.Text = "Label1"
        Me.Lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_Categoria
        '
        Me.Pic_Categoria.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Categoria.Name = "Pic_Categoria"
        Me.Pic_Categoria.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Categoria.TabIndex = 0
        Me.Pic_Categoria.TabStop = False
        '
        'UC_GetCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel_Categoria)
        Me.Name = "UC_GetCategorias"
        Me.Size = New System.Drawing.Size(150, 200)
        Me.Panel_Categoria.ResumeLayout(False)
        CType(Me.Pic_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Categoria As Panel
    Friend WithEvents Pic_Categoria As PictureBox
    Friend WithEvents Lbl_Nome As Label
End Class
