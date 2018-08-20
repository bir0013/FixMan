<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.chkShowConfirm = New System.Windows.Forms.CheckBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlUserInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to FixMan! "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To get started, create your user account."
        '
        'pnlUserInfo
        '
        Me.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUserInfo.Controls.Add(Me.chkShowConfirm)
        Me.pnlUserInfo.Controls.Add(Me.chkShowPass)
        Me.pnlUserInfo.Controls.Add(Me.txtUsername)
        Me.pnlUserInfo.Controls.Add(Me.txtFullName)
        Me.pnlUserInfo.Controls.Add(Me.txtPassword)
        Me.pnlUserInfo.Controls.Add(Me.txtConfirmPassword)
        Me.pnlUserInfo.Controls.Add(Me.Label4)
        Me.pnlUserInfo.Controls.Add(Me.Label3)
        Me.pnlUserInfo.Controls.Add(Me.Label5)
        Me.pnlUserInfo.Controls.Add(Me.lblFullName)
        Me.pnlUserInfo.Location = New System.Drawing.Point(12, 91)
        Me.pnlUserInfo.Name = "pnlUserInfo"
        Me.pnlUserInfo.Size = New System.Drawing.Size(341, 133)
        Me.pnlUserInfo.TabIndex = 21
        '
        'chkShowConfirm
        '
        Me.chkShowConfirm.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowConfirm.BackColor = System.Drawing.SystemColors.Menu
        Me.chkShowConfirm.BackgroundImage = Global.FixMan.My.Resources.Resources.showpass
        Me.chkShowConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkShowConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.chkShowConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowConfirm.Location = New System.Drawing.Point(312, 98)
        Me.chkShowConfirm.Name = "chkShowConfirm"
        Me.chkShowConfirm.Size = New System.Drawing.Size(18, 12)
        Me.chkShowConfirm.TabIndex = 27
        Me.chkShowConfirm.UseVisualStyleBackColor = False
        '
        'chkShowPass
        '
        Me.chkShowPass.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowPass.BackColor = System.Drawing.SystemColors.Menu
        Me.chkShowPass.BackgroundImage = Global.FixMan.My.Resources.Resources.showpass
        Me.chkShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkShowPass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.chkShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPass.Location = New System.Drawing.Point(312, 72)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(18, 12)
        Me.chkShowPass.TabIndex = 26
        Me.chkShowPass.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(106, 13)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(201, 20)
        Me.txtUsername.TabIndex = 0
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(106, 39)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(201, 20)
        Me.txtFullName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(106, 69)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(201, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(106, 95)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(201, 20)
        Me.txtConfirmPassword.TabIndex = 3
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Confirm password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Password:"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(47, 43)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(55, 13)
        Me.lblFullName.TabIndex = 14
        Me.lblFullName.Text = "Full name:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(143, 254)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSetup
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 289)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pnlUserInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSetup"
        Me.Text = "FirstTimeSetup"
        Me.pnlUserInfo.ResumeLayout(False)
        Me.pnlUserInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlUserInfo As Panel
    Friend WithEvents chkShowConfirm As CheckBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
End Class
