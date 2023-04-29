<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucIVA
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.pControlBox = New System.Windows.Forms.Panel()
        Me.btnDelCancel = New FCT_2021.ucSquareButton()
        Me.btnAddSave = New FCT_2021.ucSquareButton()
        Me.btnEditar = New FCT_2021.ucSquareButton()
        Me.btnLast = New FCT_2021.ucSquareButton()
        Me.btnNext = New FCT_2021.ucSquareButton()
        Me.btnBack = New FCT_2021.ucSquareButton()
        Me.btnFirst = New FCT_2021.ucSquareButton()
        Me.udaSaved = New Infragistics.Win.Misc.UltraDesktopAlert(Me.components)
        Me.pStatusBar = New System.Windows.Forms.Panel()
        Me.ucIVA_Designacao = New FCT_2021.ucTextBoxWithLabel()
        Me.ucIVA_Cod = New FCT_2021.ucTextBoxWithLabel()
        Me.ucIVA_Taxa = New FCT_2021.ucTextBoxWithLabel()
        Me.ucIVA_Tipo = New FCT_2021.ucTextBoxWithLabel()
        Me.pControlBox.SuspendLayout()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCounter
        '
        Me.lblCounter.BackColor = System.Drawing.Color.White
        Me.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCounter.Font = New System.Drawing.Font("Cascadia Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(0, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(1169, 43)
        Me.lblCounter.TabIndex = 0
        Me.lblCounter.Text = "A mostrar IVA 0 de 0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pControlBox
        '
        Me.pControlBox.BackColor = System.Drawing.Color.Transparent
        Me.pControlBox.Controls.Add(Me.btnDelCancel)
        Me.pControlBox.Controls.Add(Me.btnAddSave)
        Me.pControlBox.Controls.Add(Me.btnEditar)
        Me.pControlBox.Controls.Add(Me.btnLast)
        Me.pControlBox.Controls.Add(Me.btnNext)
        Me.pControlBox.Controls.Add(Me.btnBack)
        Me.pControlBox.Controls.Add(Me.btnFirst)
        Me.pControlBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.pControlBox.Location = New System.Drawing.Point(0, 0)
        Me.pControlBox.Name = "pControlBox"
        Me.pControlBox.Size = New System.Drawing.Size(1169, 52)
        Me.pControlBox.TabIndex = 12
        '
        'btnDelCancel
        '
        Me.btnDelCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelCancel.AutoSize = True
        Me.btnDelCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnDelCancel.ImageInput = Global.FCT_2021.My.Resources.Resources.DeleteIcon
        Me.btnDelCancel.Location = New System.Drawing.Point(754, 6)
        Me.btnDelCancel.Name = "btnDelCancel"
        Me.btnDelCancel.Size = New System.Drawing.Size(40, 40)
        Me.btnDelCancel.TabIndex = 6
        Me.btnDelCancel.Tag = "1"
        '
        'btnAddSave
        '
        Me.btnAddSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddSave.AutoSize = True
        Me.btnAddSave.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSave.ImageInput = Global.FCT_2021.My.Resources.Resources.AddDocumentIcon
        Me.btnAddSave.Location = New System.Drawing.Point(704, 6)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(40, 40)
        Me.btnAddSave.TabIndex = 5
        Me.btnAddSave.Tag = "1"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditar.AutoSize = True
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.ImageInput = Global.FCT_2021.My.Resources.Resources.CreateIcon
        Me.btnEditar.Location = New System.Drawing.Point(649, 6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Tag = "1"
        '
        'btnLast
        '
        Me.btnLast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLast.AutoSize = True
        Me.btnLast.BackColor = System.Drawing.Color.Transparent
        Me.btnLast.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowsLast
        Me.btnLast.Location = New System.Drawing.Point(527, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(45, 45)
        Me.btnLast.TabIndex = 3
        Me.btnLast.Tag = "1"
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowRight
        Me.btnNext.Location = New System.Drawing.Point(476, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(45, 45)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Tag = "1"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.AutoSize = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowLeft
        Me.btnBack.Location = New System.Drawing.Point(425, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 45)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Tag = "1"
        '
        'btnFirst
        '
        Me.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFirst.AutoSize = True
        Me.btnFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnFirst.ImageInput = Global.FCT_2021.My.Resources.Resources.ArrowsFirst
        Me.btnFirst.Location = New System.Drawing.Point(374, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(45, 45)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Tag = "1"
        '
        'udaSaved
        '
        Me.udaSaved.AnimationSpeed = Infragistics.Win.Misc.AnimationSpeed.Fast
        Me.udaSaved.AnimationStyleAutoClose = Infragistics.Win.Misc.AnimationStyle.FadeAndScroll
        Me.udaSaved.AnimationStyleShow = Infragistics.Win.Misc.AnimationStyle.FadeAndScroll
        Me.udaSaved.Opacity = 1.0!
        Me.udaSaved.Style = Infragistics.Win.Misc.DesktopAlertStyle.Office2007
        '
        'pStatusBar
        '
        Me.pStatusBar.BackColor = System.Drawing.Color.White
        Me.pStatusBar.Controls.Add(Me.lblCounter)
        Me.pStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pStatusBar.Location = New System.Drawing.Point(0, 668)
        Me.pStatusBar.Name = "pStatusBar"
        Me.pStatusBar.Size = New System.Drawing.Size(1169, 43)
        Me.pStatusBar.TabIndex = 11
        '
        'ucIVA_Designacao
        '
        Me.ucIVA_Designacao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucIVA_Designacao.BackColor = System.Drawing.Color.White
        Me.ucIVA_Designacao.Location = New System.Drawing.Point(350, 370)
        Me.ucIVA_Designacao.MaxTextLengh = 30
        Me.ucIVA_Designacao.Name = "ucIVA_Designacao"
        Me.ucIVA_Designacao.PlaceHolder = "Designação:"
        Me.ucIVA_Designacao.ReadOnlyInput = True
        Me.ucIVA_Designacao.Size = New System.Drawing.Size(479, 65)
        Me.ucIVA_Designacao.TabIndex = 2
        Me.ucIVA_Designacao.TextInput = ""
        Me.ucIVA_Designacao.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucIVA_Cod
        '
        Me.ucIVA_Cod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucIVA_Cod.BackColor = System.Drawing.Color.White
        Me.ucIVA_Cod.Location = New System.Drawing.Point(350, 299)
        Me.ucIVA_Cod.MaxTextLengh = 3
        Me.ucIVA_Cod.Name = "ucIVA_Cod"
        Me.ucIVA_Cod.PlaceHolder = "Código:"
        Me.ucIVA_Cod.ReadOnlyInput = True
        Me.ucIVA_Cod.Size = New System.Drawing.Size(156, 65)
        Me.ucIVA_Cod.TabIndex = 0
        Me.ucIVA_Cod.TextInput = ""
        Me.ucIVA_Cod.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucIVA_Taxa
        '
        Me.ucIVA_Taxa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucIVA_Taxa.BackColor = System.Drawing.Color.White
        Me.ucIVA_Taxa.Location = New System.Drawing.Point(512, 300)
        Me.ucIVA_Taxa.MaxTextLengh = 3
        Me.ucIVA_Taxa.Name = "ucIVA_Taxa"
        Me.ucIVA_Taxa.PlaceHolder = "Taxa %:"
        Me.ucIVA_Taxa.ReadOnlyInput = True
        Me.ucIVA_Taxa.Size = New System.Drawing.Size(151, 65)
        Me.ucIVA_Taxa.TabIndex = 13
        Me.ucIVA_Taxa.TextInput = ""
        Me.ucIVA_Taxa.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucIVA_Tipo
        '
        Me.ucIVA_Tipo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucIVA_Tipo.BackColor = System.Drawing.Color.White
        Me.ucIVA_Tipo.Location = New System.Drawing.Point(669, 299)
        Me.ucIVA_Tipo.MaxTextLengh = 1
        Me.ucIVA_Tipo.Name = "ucIVA_Tipo"
        Me.ucIVA_Tipo.PlaceHolder = "Tipo:"
        Me.ucIVA_Tipo.ReadOnlyInput = True
        Me.ucIVA_Tipo.Size = New System.Drawing.Size(160, 65)
        Me.ucIVA_Tipo.TabIndex = 14
        Me.ucIVA_Tipo.TextInput = ""
        Me.ucIVA_Tipo.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ucIVA_Tipo)
        Me.Controls.Add(Me.ucIVA_Taxa)
        Me.Controls.Add(Me.pControlBox)
        Me.Controls.Add(Me.pStatusBar)
        Me.Controls.Add(Me.ucIVA_Designacao)
        Me.Controls.Add(Me.ucIVA_Cod)
        Me.Name = "ucIVA"
        Me.Size = New System.Drawing.Size(1169, 711)
        Me.pControlBox.ResumeLayout(False)
        Me.pControlBox.PerformLayout()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucIVA_Cod As ucTextBoxWithLabel
    Friend WithEvents ucIVA_Designacao As ucTextBoxWithLabel
    Friend WithEvents lblCounter As Label
    Friend WithEvents pControlBox As Panel
    Friend WithEvents btnFirst As ucSquareButton
    Friend WithEvents btnLast As ucSquareButton
    Friend WithEvents btnNext As ucSquareButton
    Friend WithEvents btnBack As ucSquareButton
    Friend WithEvents btnDelCancel As ucSquareButton
    Friend WithEvents btnAddSave As ucSquareButton
    Friend WithEvents btnEditar As ucSquareButton
    Friend WithEvents udaSaved As Infragistics.Win.Misc.UltraDesktopAlert
    Friend WithEvents pStatusBar As Panel
    Friend WithEvents ucIVA_Taxa As ucTextBoxWithLabel
    Friend WithEvents ucIVA_Tipo As ucTextBoxWithLabel
End Class
