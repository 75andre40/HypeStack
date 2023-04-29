<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel_Dialog = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Panel_Dialog
        '
        Me.Panel_Dialog.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Dialog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Dialog.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Dialog.Name = "Panel_Dialog"
        Me.Panel_Dialog.Size = New System.Drawing.Size(758, 391)
        Me.Panel_Dialog.TabIndex = 0
        '
        'FrmDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(758, 391)
        Me.Controls.Add(Me.Panel_Dialog)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDialog"
        Me.Text = "FrmDialog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Dialog As FlowLayoutPanel
End Class
