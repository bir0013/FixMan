<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditUser
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
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbInventoryBlock = New System.Windows.Forms.RadioButton()
        Me.rdbInventoryView = New System.Windows.Forms.RadioButton()
        Me.rdbInventoryEdit = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rdbEventView = New System.Windows.Forms.RadioButton()
        Me.rdbEventBlock = New System.Windows.Forms.RadioButton()
        Me.rdbEventEdit = New System.Windows.Forms.RadioButton()
        Me.lblPriveliges = New System.Windows.Forms.Label()
        Me.pnlPriveliges = New System.Windows.Forms.Panel()
        Me.chkUserEdit = New System.Windows.Forms.CheckBox()
        Me.chkShowConfirm = New System.Windows.Forms.CheckBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlPriveliges.SuspendLayout()
        Me.pnlUserInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(140, 410)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 30
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(130, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(95, 24)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "Edit User"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.rdbInventoryBlock)
        Me.Panel2.Controls.Add(Me.rdbInventoryView)
        Me.Panel2.Controls.Add(Me.rdbInventoryEdit)
        Me.Panel2.Location = New System.Drawing.Point(16, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(87, 112)
        Me.Panel2.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Inventory:"
        '
        'rdbInventoryBlock
        '
        Me.rdbInventoryBlock.AutoSize = True
        Me.rdbInventoryBlock.Location = New System.Drawing.Point(5, 83)
        Me.rdbInventoryBlock.Name = "rdbInventoryBlock"
        Me.rdbInventoryBlock.Size = New System.Drawing.Size(76, 17)
        Me.rdbInventoryBlock.TabIndex = 6
        Me.rdbInventoryBlock.TabStop = True
        Me.rdbInventoryBlock.Text = "No access"
        Me.rdbInventoryBlock.UseVisualStyleBackColor = True
        '
        'rdbInventoryView
        '
        Me.rdbInventoryView.AutoSize = True
        Me.rdbInventoryView.Location = New System.Drawing.Point(5, 60)
        Me.rdbInventoryView.Name = "rdbInventoryView"
        Me.rdbInventoryView.Size = New System.Drawing.Size(69, 17)
        Me.rdbInventoryView.TabIndex = 5
        Me.rdbInventoryView.TabStop = True
        Me.rdbInventoryView.Text = "Can view"
        Me.rdbInventoryView.UseVisualStyleBackColor = True
        '
        'rdbInventoryEdit
        '
        Me.rdbInventoryEdit.AutoSize = True
        Me.rdbInventoryEdit.Location = New System.Drawing.Point(5, 37)
        Me.rdbInventoryEdit.Name = "rdbInventoryEdit"
        Me.rdbInventoryEdit.Size = New System.Drawing.Size(64, 17)
        Me.rdbInventoryEdit.TabIndex = 4
        Me.rdbInventoryEdit.TabStop = True
        Me.rdbInventoryEdit.Text = "Can edit"
        Me.rdbInventoryEdit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.rdbEventView)
        Me.Panel1.Controls.Add(Me.rdbEventBlock)
        Me.Panel1.Controls.Add(Me.rdbEventEdit)
        Me.Panel1.Location = New System.Drawing.Point(109, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 112)
        Me.Panel1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Event:"
        '
        'rdbEventView
        '
        Me.rdbEventView.AutoSize = True
        Me.rdbEventView.Location = New System.Drawing.Point(5, 62)
        Me.rdbEventView.Name = "rdbEventView"
        Me.rdbEventView.Size = New System.Drawing.Size(69, 17)
        Me.rdbEventView.TabIndex = 8
        Me.rdbEventView.TabStop = True
        Me.rdbEventView.Text = "Can view"
        Me.rdbEventView.UseVisualStyleBackColor = True
        '
        'rdbEventBlock
        '
        Me.rdbEventBlock.AutoSize = True
        Me.rdbEventBlock.Location = New System.Drawing.Point(5, 85)
        Me.rdbEventBlock.Name = "rdbEventBlock"
        Me.rdbEventBlock.Size = New System.Drawing.Size(76, 17)
        Me.rdbEventBlock.TabIndex = 9
        Me.rdbEventBlock.TabStop = True
        Me.rdbEventBlock.Text = "No access"
        Me.rdbEventBlock.UseVisualStyleBackColor = True
        '
        'rdbEventEdit
        '
        Me.rdbEventEdit.AutoSize = True
        Me.rdbEventEdit.Location = New System.Drawing.Point(5, 39)
        Me.rdbEventEdit.Name = "rdbEventEdit"
        Me.rdbEventEdit.Size = New System.Drawing.Size(64, 17)
        Me.rdbEventEdit.TabIndex = 7
        Me.rdbEventEdit.TabStop = True
        Me.rdbEventEdit.Text = "Can edit"
        Me.rdbEventEdit.UseVisualStyleBackColor = True
        '
        'lblPriveliges
        '
        Me.lblPriveliges.AutoSize = True
        Me.lblPriveliges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriveliges.Location = New System.Drawing.Point(69, 9)
        Me.lblPriveliges.Name = "lblPriveliges"
        Me.lblPriveliges.Size = New System.Drawing.Size(71, 18)
        Me.lblPriveliges.TabIndex = 18
        Me.lblPriveliges.Text = "Priveliges"
        '
        'pnlPriveliges
        '
        Me.pnlPriveliges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPriveliges.Controls.Add(Me.Panel2)
        Me.pnlPriveliges.Controls.Add(Me.Panel1)
        Me.pnlPriveliges.Controls.Add(Me.lblPriveliges)
        Me.pnlPriveliges.Controls.Add(Me.chkUserEdit)
        Me.pnlPriveliges.Location = New System.Drawing.Point(73, 216)
        Me.pnlPriveliges.Name = "pnlPriveliges"
        Me.pnlPriveliges.Size = New System.Drawing.Size(209, 187)
        Me.pnlPriveliges.TabIndex = 27
        '
        'chkUserEdit
        '
        Me.chkUserEdit.AutoSize = True
        Me.chkUserEdit.Location = New System.Drawing.Point(61, 159)
        Me.chkUserEdit.Name = "chkUserEdit"
        Me.chkUserEdit.Size = New System.Drawing.Size(99, 17)
        Me.chkUserEdit.TabIndex = 21
        Me.chkUserEdit.Text = "Can edit users?"
        Me.chkUserEdit.UseVisualStyleBackColor = True
        '
        'chkShowConfirm
        '
        Me.chkShowConfirm.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowConfirm.BackColor = System.Drawing.SystemColors.Menu
        Me.chkShowConfirm.BackgroundImage = Global.FixMan.My.Resources.Resources.showpass
        Me.chkShowConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkShowConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.chkShowConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowConfirm.Location = New System.Drawing.Point(312, 132)
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
        Me.chkShowPass.Location = New System.Drawing.Point(312, 106)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(18, 12)
        Me.chkShowPass.TabIndex = 26
        Me.chkShowPass.UseVisualStyleBackColor = False
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(111, 12)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(118, 18)
        Me.lblUserInfo.TabIndex = 17
        Me.lblUserInfo.Text = "User Information"
        '
        'pnlUserInfo
        '
        Me.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUserInfo.Controls.Add(Me.chkShowConfirm)
        Me.pnlUserInfo.Controls.Add(Me.chkShowPass)
        Me.pnlUserInfo.Controls.Add(Me.lblUserInfo)
        Me.pnlUserInfo.Controls.Add(Me.txtUsername)
        Me.pnlUserInfo.Controls.Add(Me.txtFullName)
        Me.pnlUserInfo.Controls.Add(Me.txtPassword)
        Me.pnlUserInfo.Controls.Add(Me.txtConfirmPassword)
        Me.pnlUserInfo.Controls.Add(Me.Label4)
        Me.pnlUserInfo.Controls.Add(Me.Label1)
        Me.pnlUserInfo.Controls.Add(Me.Label3)
        Me.pnlUserInfo.Controls.Add(Me.lblFullName)
        Me.pnlUserInfo.Location = New System.Drawing.Point(7, 44)
        Me.pnlUserInfo.Name = "pnlUserInfo"
        Me.pnlUserInfo.Size = New System.Drawing.Size(341, 166)
        Me.pnlUserInfo.TabIndex = 26
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(106, 47)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(201, 20)
        Me.txtUsername.TabIndex = 0
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(106, 73)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(201, 20)
        Me.txtFullName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(106, 103)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(201, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(106, 129)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(201, 20)
        Me.txtConfirmPassword.TabIndex = 3
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Confirm password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Password:"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(47, 77)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(55, 13)
        Me.lblFullName.TabIndex = 14
        Me.lblFullName.Text = "Full name:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(271, 410)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlPriveliges)
        Me.Controls.Add(Me.pnlUserInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditUser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlPriveliges.ResumeLayout(False)
        Me.pnlPriveliges.PerformLayout()
        Me.pnlUserInfo.ResumeLayout(False)
        Me.pnlUserInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChange As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents rdbInventoryBlock As RadioButton
    Friend WithEvents rdbInventoryView As RadioButton
    Friend WithEvents rdbInventoryEdit As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents rdbEventView As RadioButton
    Friend WithEvents rdbEventBlock As RadioButton
    Friend WithEvents rdbEventEdit As RadioButton
    Friend WithEvents lblPriveliges As Label
    Friend WithEvents pnlPriveliges As Panel
    Friend WithEvents chkUserEdit As CheckBox
    Friend WithEvents chkShowConfirm As CheckBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents pnlUserInfo As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnCancel As Button
End Class
