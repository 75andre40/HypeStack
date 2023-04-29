<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pDragForm = New System.Windows.Forms.Panel()
        Me.picMinimizeForm = New System.Windows.Forms.PictureBox()
        Me.picCloseForm = New System.Windows.Forms.PictureBox()
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.lblLoginFailed = New System.Windows.Forms.Label()
        Me.tmrLoginFailed = New System.Windows.Forms.Timer(Me.components)
        Me.btnSubmit = New FCT_2021.ucButton()
        Me.txtPassword = New FCT_2021.ucTextBox()
        Me.txtUser = New FCT_2021.ucTextBox()
        Me.pDragForm.SuspendLayout()
        CType(Me.picMinimizeForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCloseForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pDragForm
        '
        Me.pDragForm.BackColor = System.Drawing.Color.Transparent
        Me.pDragForm.Controls.Add(Me.picMinimizeForm)
        Me.pDragForm.Controls.Add(Me.picCloseForm)
        Me.pDragForm.Controls.Add(Me.lblFormName)
        Me.pDragForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pDragForm.Location = New System.Drawing.Point(0, 0)
        Me.pDragForm.Name = "pDragForm"
        Me.pDragForm.Size = New System.Drawing.Size(1000, 28)
        Me.pDragForm.TabIndex = 0
        '
        'picMinimizeForm
        '
        Me.picMinimizeForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picMinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimizeForm.Image = Global.FCT_2021.My.Resources.Resources.Minimize
        Me.picMinimizeForm.Location = New System.Drawing.Point(946, 2)
        Me.picMinimizeForm.Name = "picMinimizeForm"
        Me.picMinimizeForm.Size = New System.Drawing.Size(24, 24)
        Me.picMinimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinimizeForm.TabIndex = 1
        Me.picMinimizeForm.TabStop = False
        '
        'picCloseForm
        '
        Me.picCloseForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picCloseForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCloseForm.Image = Global.FCT_2021.My.Resources.Resources.Close
        Me.picCloseForm.Location = New System.Drawing.Point(974, 2)
        Me.picCloseForm.Name = "picCloseForm"
        Me.picCloseForm.Size = New System.Drawing.Size(24, 24)
        Me.picCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCloseForm.TabIndex = 0
        Me.picCloseForm.TabStop = False
        '
        'lblFormName
        '
        Me.lblFormName.Font = New System.Drawing.Font("Cascadia Code SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormName.Location = New System.Drawing.Point(0, 0)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(1000, 28)
        Me.lblFormName.TabIndex = 2
        Me.lblFormName.Text = "HypeStack"
        Me.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogIn
        '
        Me.lblLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lblLogIn.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(492, 189)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(354, 51)
        Me.lblLogIn.TabIndex = 3
        Me.lblLogIn.Text = "Log-In"
        Me.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoginFailed
        '
        Me.lblLoginFailed.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginFailed.Font = New System.Drawing.Font("Cascadia Code", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginFailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLoginFailed.Location = New System.Drawing.Point(498, 456)
        Me.lblLoginFailed.Name = "lblLoginFailed"
        Me.lblLoginFailed.Size = New System.Drawing.Size(348, 20)
        Me.lblLoginFailed.TabIndex = 7
        Me.lblLoginFailed.Text = "Credenciais incorretas ou inexistentes!"
        Me.lblLoginFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginFailed.Visible = False
        '
        'tmrLoginFailed
        '
        Me.tmrLoginFailed.Interval = 3000
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BackgroundImage = CType(resources.GetObject("btnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Location = New System.Drawing.Point(557, 390)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(225, 42)
        Me.btnSubmit.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BackgroundImage = CType(resources.GetObject("txtPassword.BackgroundImage"), System.Drawing.Image)
        Me.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtPassword.GrayText = "Password"
        Me.txtPassword.Location = New System.Drawing.Point(557, 310)
        Me.txtPassword.MaxTextLengh = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(225, 42)
        Me.txtPassword.TabIndex = 5
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.BackgroundImage = CType(resources.GetObject("txtUser.BackgroundImage"), System.Drawing.Image)
        Me.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUser.GrayText = "Utilizador"
        Me.txtUser.Location = New System.Drawing.Point(557, 252)
        Me.txtUser.MaxTextLengh = 20
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.Size = New System.Drawing.Size(225, 42)
        Me.txtUser.TabIndex = 4
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FCT_2021.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLoginFailed)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblLogIn)
        Me.Controls.Add(Me.pDragForm)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HypeStack"
        Me.pDragForm.ResumeLayout(False)
        CType(Me.picMinimizeForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCloseForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pDragForm As Panel
    Friend WithEvents picCloseForm As PictureBox
    Friend WithEvents picMinimizeForm As PictureBox
    Friend WithEvents lblFormName As Label
    Friend WithEvents lblLogIn As Label
    Friend WithEvents txtUser As ucTextBox
    Friend WithEvents txtPassword As ucTextBox
    Friend WithEvents btnSubmit As ucButton
    Friend WithEvents lblLoginFailed As Label
    Friend WithEvents tmrLoginFailed As Timer
End Class
