<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_ViewArt
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
        Me.Panel_Artigos = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Panel_Artigos
        '
        Me.Panel_Artigos.AutoScroll = True
        Me.Panel_Artigos.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Artigos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Artigos.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Artigos.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Artigos.Name = "Panel_Artigos"
        Me.Panel_Artigos.Size = New System.Drawing.Size(1344, 437)
        Me.Panel_Artigos.TabIndex = 0
        '
        'UC_ViewArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Artigos)
        Me.DoubleBuffered = True
        Me.Name = "UC_ViewArt"
        Me.Size = New System.Drawing.Size(1344, 437)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Artigos As FlowLayoutPanel
End Class
