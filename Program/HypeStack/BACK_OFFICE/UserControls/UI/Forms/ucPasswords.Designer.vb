<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPasswords
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
        Me.ucPasswords_Cod = New FCT_2021.ucTextBoxWithLabel()
        Me.ucPasswords_Senha = New FCT_2021.ucTextBoxWithLabel()
        Me.ucPasswords_Nome = New FCT_2021.ucTextBoxWithLabel()
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
        Me.lblCounter.Text = "A mostrar entidade 0 de 0"
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
        'ucPasswords_Cod
        '
        Me.ucPasswords_Cod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucPasswords_Cod.BackColor = System.Drawing.Color.White
        Me.ucPasswords_Cod.Location = New System.Drawing.Point(350, 366)
        Me.ucPasswords_Cod.MaxTextLengh = 3
        Me.ucPasswords_Cod.Name = "ucPasswords_Cod"
        Me.ucPasswords_Cod.PlaceHolder = "Código:"
        Me.ucPasswords_Cod.ReadOnlyInput = True
        Me.ucPasswords_Cod.Size = New System.Drawing.Size(232, 65)
        Me.ucPasswords_Cod.TabIndex = 0
        Me.ucPasswords_Cod.TextInput = ""
        Me.ucPasswords_Cod.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucPasswords_Senha
        '
        Me.ucPasswords_Senha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucPasswords_Senha.BackColor = System.Drawing.Color.White
        Me.ucPasswords_Senha.Location = New System.Drawing.Point(607, 367)
        Me.ucPasswords_Senha.MaxTextLengh = 30
        Me.ucPasswords_Senha.Name = "ucPasswords_Senha"
        Me.ucPasswords_Senha.PlaceHolder = "Password:"
        Me.ucPasswords_Senha.ReadOnlyInput = True
        Me.ucPasswords_Senha.Size = New System.Drawing.Size(222, 65)
        Me.ucPasswords_Senha.TabIndex = 15
        Me.ucPasswords_Senha.TextInput = ""
        Me.ucPasswords_Senha.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucPasswords_Nome
        '
        Me.ucPasswords_Nome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucPasswords_Nome.BackColor = System.Drawing.Color.White
        Me.ucPasswords_Nome.Location = New System.Drawing.Point(350, 296)
        Me.ucPasswords_Nome.MaxTextLengh = 30
        Me.ucPasswords_Nome.Name = "ucPasswords_Nome"
        Me.ucPasswords_Nome.PlaceHolder = "Nome:"
        Me.ucPasswords_Nome.ReadOnlyInput = True
        Me.ucPasswords_Nome.Size = New System.Drawing.Size(479, 65)
        Me.ucPasswords_Nome.TabIndex = 16
        Me.ucPasswords_Nome.TextInput = ""
        Me.ucPasswords_Nome.ValueRightToLeft = Infragistics.Win.HAlign.[Default]
        '
        'ucPasswords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ucPasswords_Nome)
        Me.Controls.Add(Me.ucPasswords_Senha)
        Me.Controls.Add(Me.pControlBox)
        Me.Controls.Add(Me.pStatusBar)
        Me.Controls.Add(Me.ucPasswords_Cod)
        Me.Name = "ucPasswords"
        Me.Size = New System.Drawing.Size(1169, 711)
        Me.pControlBox.ResumeLayout(False)
        Me.pControlBox.PerformLayout()
        CType(Me.udaSaved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucPasswords_Cod As ucTextBoxWithLabel
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
    Friend WithEvents ucPasswords_Senha As ucTextBoxWithLabel
    Friend WithEvents ucPasswords_Nome As ucTextBoxWithLabel
End Class
