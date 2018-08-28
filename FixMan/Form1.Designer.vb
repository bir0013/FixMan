<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgdStoreroom = New System.Windows.Forms.DataGridView()
        Me.FixImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FixManufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixModel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixOptics = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixPower = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlStoreroom = New System.Windows.Forms.Panel()
        Me.lblCurrentStoreroom = New System.Windows.Forms.Label()
        Me.lblStoreroom = New System.Windows.Forms.Label()
        Me.btnLoadStoreroom = New System.Windows.Forms.Button()
        Me.btnSaveStoreroom = New System.Windows.Forms.Button()
        Me.btnSearchFixture = New System.Windows.Forms.Button()
        Me.btnViewFixture = New System.Windows.Forms.Button()
        Me.btnRemoveFixture = New System.Windows.Forms.Button()
        Me.btnAddFixture = New System.Windows.Forms.Button()
        Me.pnlEvent = New System.Windows.Forms.Panel()
        Me.lblCurrentEvent = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.btnLoadEvent = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnOpenTeamRoster = New System.Windows.Forms.Button()
        Me.btnOpenFixSheet = New System.Windows.Forms.Button()
        Me.btnOpenEventMan = New System.Windows.Forms.Button()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.dlgOpenStoreroom = New System.Windows.Forms.OpenFileDialog()
        Me.btnNewStoreroom = New System.Windows.Forms.Button()
        Me.btnNewEvent = New System.Windows.Forms.Button()
        Me.mnuMenuStrip.SuspendLayout()
        CType(Me.dgdStoreroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStoreroom.SuspendLayout()
        Me.pnlEvent.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(1003, 24)
        Me.mnuMenuStrip.TabIndex = 0
        Me.mnuMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Location = New System.Drawing.Point(835, 625)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(916, 625)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgdStoreroom
        '
        Me.dgdStoreroom.AllowUserToAddRows = False
        Me.dgdStoreroom.AllowUserToDeleteRows = False
        Me.dgdStoreroom.AllowUserToOrderColumns = True
        Me.dgdStoreroom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdStoreroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdStoreroom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FixImage, Me.FixManufacturer, Me.FixModel, Me.FixSource, Me.FixType, Me.FixOptics, Me.FixPower, Me.FixQty})
        Me.dgdStoreroom.Location = New System.Drawing.Point(190, 37)
        Me.dgdStoreroom.Name = "dgdStoreroom"
        Me.dgdStoreroom.RowTemplate.Height = 55
        Me.dgdStoreroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdStoreroom.Size = New System.Drawing.Size(803, 582)
        Me.dgdStoreroom.TabIndex = 3
        '
        'FixImage
        '
        Me.FixImage.HeaderText = "Image"
        Me.FixImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.FixImage.Name = "FixImage"
        '
        'FixManufacturer
        '
        Me.FixManufacturer.HeaderText = "Manufacturer"
        Me.FixManufacturer.Name = "FixManufacturer"
        Me.FixManufacturer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FixModel
        '
        Me.FixModel.HeaderText = "Model"
        Me.FixModel.Name = "FixModel"
        Me.FixModel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FixSource
        '
        Me.FixSource.HeaderText = "Light Source"
        Me.FixSource.Name = "FixSource"
        '
        'FixType
        '
        Me.FixType.HeaderText = "Type"
        Me.FixType.Name = "FixType"
        Me.FixType.Width = 110
        '
        'FixOptics
        '
        Me.FixOptics.HeaderText = "Optic Type"
        Me.FixOptics.Name = "FixOptics"
        '
        'FixPower
        '
        Me.FixPower.HeaderText = "Total Power Draw"
        Me.FixPower.Name = "FixPower"
        '
        'FixQty
        '
        Me.FixQty.HeaderText = "Qty."
        Me.FixQty.Name = "FixQty"
        Me.FixQty.Width = 50
        '
        'pnlStoreroom
        '
        Me.pnlStoreroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStoreroom.Controls.Add(Me.btnNewStoreroom)
        Me.pnlStoreroom.Controls.Add(Me.lblCurrentStoreroom)
        Me.pnlStoreroom.Controls.Add(Me.lblStoreroom)
        Me.pnlStoreroom.Controls.Add(Me.btnLoadStoreroom)
        Me.pnlStoreroom.Controls.Add(Me.btnSaveStoreroom)
        Me.pnlStoreroom.Controls.Add(Me.btnSearchFixture)
        Me.pnlStoreroom.Controls.Add(Me.btnViewFixture)
        Me.pnlStoreroom.Controls.Add(Me.btnRemoveFixture)
        Me.pnlStoreroom.Controls.Add(Me.btnAddFixture)
        Me.pnlStoreroom.Location = New System.Drawing.Point(11, 37)
        Me.pnlStoreroom.Name = "pnlStoreroom"
        Me.pnlStoreroom.Size = New System.Drawing.Size(170, 222)
        Me.pnlStoreroom.TabIndex = 4
        '
        'lblCurrentStoreroom
        '
        Me.lblCurrentStoreroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentStoreroom.Location = New System.Drawing.Point(7, 20)
        Me.lblCurrentStoreroom.Name = "lblCurrentStoreroom"
        Me.lblCurrentStoreroom.Size = New System.Drawing.Size(156, 23)
        Me.lblCurrentStoreroom.TabIndex = 12
        Me.lblCurrentStoreroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStoreroom
        '
        Me.lblStoreroom.AutoSize = True
        Me.lblStoreroom.Location = New System.Drawing.Point(5, 1)
        Me.lblStoreroom.Name = "lblStoreroom"
        Me.lblStoreroom.Size = New System.Drawing.Size(55, 13)
        Me.lblStoreroom.TabIndex = 6
        Me.lblStoreroom.Text = "Storeroom"
        '
        'btnLoadStoreroom
        '
        Me.btnLoadStoreroom.Location = New System.Drawing.Point(88, 162)
        Me.btnLoadStoreroom.Name = "btnLoadStoreroom"
        Me.btnLoadStoreroom.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadStoreroom.TabIndex = 11
        Me.btnLoadStoreroom.Text = "Load"
        Me.btnLoadStoreroom.UseVisualStyleBackColor = True
        '
        'btnSaveStoreroom
        '
        Me.btnSaveStoreroom.Location = New System.Drawing.Point(7, 162)
        Me.btnSaveStoreroom.Name = "btnSaveStoreroom"
        Me.btnSaveStoreroom.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveStoreroom.TabIndex = 10
        Me.btnSaveStoreroom.Text = "Save"
        Me.btnSaveStoreroom.UseVisualStyleBackColor = True
        '
        'btnSearchFixture
        '
        Me.btnSearchFixture.Location = New System.Drawing.Point(7, 133)
        Me.btnSearchFixture.Name = "btnSearchFixture"
        Me.btnSearchFixture.Size = New System.Drawing.Size(156, 23)
        Me.btnSearchFixture.TabIndex = 9
        Me.btnSearchFixture.Text = "Search Fixture"
        Me.btnSearchFixture.UseVisualStyleBackColor = True
        '
        'btnViewFixture
        '
        Me.btnViewFixture.Location = New System.Drawing.Point(7, 104)
        Me.btnViewFixture.Name = "btnViewFixture"
        Me.btnViewFixture.Size = New System.Drawing.Size(156, 23)
        Me.btnViewFixture.TabIndex = 8
        Me.btnViewFixture.Text = "View Fixture"
        Me.btnViewFixture.UseVisualStyleBackColor = True
        '
        'btnRemoveFixture
        '
        Me.btnRemoveFixture.Location = New System.Drawing.Point(7, 75)
        Me.btnRemoveFixture.Name = "btnRemoveFixture"
        Me.btnRemoveFixture.Size = New System.Drawing.Size(156, 23)
        Me.btnRemoveFixture.TabIndex = 7
        Me.btnRemoveFixture.Text = "Remove Fixture"
        Me.btnRemoveFixture.UseVisualStyleBackColor = True
        '
        'btnAddFixture
        '
        Me.btnAddFixture.Location = New System.Drawing.Point(7, 46)
        Me.btnAddFixture.Name = "btnAddFixture"
        Me.btnAddFixture.Size = New System.Drawing.Size(156, 23)
        Me.btnAddFixture.TabIndex = 6
        Me.btnAddFixture.Text = "Add Fixture"
        Me.btnAddFixture.UseVisualStyleBackColor = True
        '
        'pnlEvent
        '
        Me.pnlEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEvent.Controls.Add(Me.btnNewEvent)
        Me.pnlEvent.Controls.Add(Me.lblCurrentEvent)
        Me.pnlEvent.Controls.Add(Me.lblEvent)
        Me.pnlEvent.Controls.Add(Me.btnLoadEvent)
        Me.pnlEvent.Controls.Add(Me.btnSaveEvent)
        Me.pnlEvent.Controls.Add(Me.btnOpenTeamRoster)
        Me.pnlEvent.Controls.Add(Me.btnOpenFixSheet)
        Me.pnlEvent.Controls.Add(Me.btnOpenEventMan)
        Me.pnlEvent.Location = New System.Drawing.Point(11, 265)
        Me.pnlEvent.Name = "pnlEvent"
        Me.pnlEvent.Size = New System.Drawing.Size(170, 193)
        Me.pnlEvent.TabIndex = 5
        '
        'lblCurrentEvent
        '
        Me.lblCurrentEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentEvent.Location = New System.Drawing.Point(7, 22)
        Me.lblCurrentEvent.Name = "lblCurrentEvent"
        Me.lblCurrentEvent.Size = New System.Drawing.Size(156, 23)
        Me.lblCurrentEvent.TabIndex = 17
        Me.lblCurrentEvent.Text = "*TO BE USED FOR EVENT*"
        Me.lblCurrentEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Location = New System.Drawing.Point(4, 3)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(35, 13)
        Me.lblEvent.TabIndex = 13
        Me.lblEvent.Text = "Event"
        '
        'btnLoadEvent
        '
        Me.btnLoadEvent.Location = New System.Drawing.Point(89, 135)
        Me.btnLoadEvent.Name = "btnLoadEvent"
        Me.btnLoadEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadEvent.TabIndex = 16
        Me.btnLoadEvent.Text = "Load"
        Me.btnLoadEvent.UseVisualStyleBackColor = True
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(7, 135)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveEvent.TabIndex = 15
        Me.btnSaveEvent.Text = "Save"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'btnOpenTeamRoster
        '
        Me.btnOpenTeamRoster.Location = New System.Drawing.Point(7, 106)
        Me.btnOpenTeamRoster.Name = "btnOpenTeamRoster"
        Me.btnOpenTeamRoster.Size = New System.Drawing.Size(156, 23)
        Me.btnOpenTeamRoster.TabIndex = 14
        Me.btnOpenTeamRoster.Text = "Open Team Roster"
        Me.btnOpenTeamRoster.UseVisualStyleBackColor = True
        '
        'btnOpenFixSheet
        '
        Me.btnOpenFixSheet.Location = New System.Drawing.Point(7, 77)
        Me.btnOpenFixSheet.Name = "btnOpenFixSheet"
        Me.btnOpenFixSheet.Size = New System.Drawing.Size(156, 23)
        Me.btnOpenFixSheet.TabIndex = 13
        Me.btnOpenFixSheet.Text = "Open Fixture Sheet"
        Me.btnOpenFixSheet.UseVisualStyleBackColor = True
        '
        'btnOpenEventMan
        '
        Me.btnOpenEventMan.Location = New System.Drawing.Point(7, 48)
        Me.btnOpenEventMan.Name = "btnOpenEventMan"
        Me.btnOpenEventMan.Size = New System.Drawing.Size(156, 23)
        Me.btnOpenEventMan.TabIndex = 12
        Me.btnOpenEventMan.Text = "Open Event Manager"
        Me.btnOpenEventMan.UseVisualStyleBackColor = True
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Location = New System.Drawing.Point(624, 630)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(205, 13)
        Me.lblCurrentUser.TabIndex = 18
        Me.lblCurrentUser.Text = "**TO BE USED FOR CURRENT LOGIN**"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picLogo
        '
        Me.picLogo.Image = Global.FixMan.My.Resources.Resources.FixMan22
        Me.picLogo.Location = New System.Drawing.Point(-1, 464)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(197, 197)
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = False
        '
        'dlgOpenStoreroom
        '
        Me.dlgOpenStoreroom.FileName = "OpenFileDialog1"
        '
        'btnNewStoreroom
        '
        Me.btnNewStoreroom.Location = New System.Drawing.Point(47, 191)
        Me.btnNewStoreroom.Name = "btnNewStoreroom"
        Me.btnNewStoreroom.Size = New System.Drawing.Size(75, 23)
        Me.btnNewStoreroom.TabIndex = 13
        Me.btnNewStoreroom.Text = "New"
        Me.btnNewStoreroom.UseVisualStyleBackColor = True
        '
        'btnNewEvent
        '
        Me.btnNewEvent.Location = New System.Drawing.Point(47, 164)
        Me.btnNewEvent.Name = "btnNewEvent"
        Me.btnNewEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnNewEvent.TabIndex = 14
        Me.btnNewEvent.Text = "New"
        Me.btnNewEvent.UseVisualStyleBackColor = True
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 660)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Controls.Add(Me.pnlEvent)
        Me.Controls.Add(Me.pnlStoreroom)
        Me.Controls.Add(Me.dgdStoreroom)
        Me.Controls.Add(Me.lblCurrentUser)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.picLogo)
        Me.MainMenuStrip = Me.mnuMenuStrip
        Me.Name = "frmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FixMan"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        CType(Me.dgdStoreroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStoreroom.ResumeLayout(False)
        Me.pnlStoreroom.PerformLayout()
        Me.pnlEvent.ResumeLayout(False)
        Me.pnlEvent.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dgdStoreroom As DataGridView
    Friend WithEvents pnlStoreroom As Panel
    Friend WithEvents pnlEvent As Panel
    Friend WithEvents btnLoadStoreroom As Button
    Friend WithEvents btnSaveStoreroom As Button
    Friend WithEvents btnSearchFixture As Button
    Friend WithEvents btnViewFixture As Button
    Friend WithEvents btnRemoveFixture As Button
    Friend WithEvents btnAddFixture As Button
    Friend WithEvents btnLoadEvent As Button
    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents btnOpenTeamRoster As Button
    Friend WithEvents btnOpenFixSheet As Button
    Friend WithEvents btnOpenEventMan As Button
    Friend WithEvents lblCurrentStoreroom As Label
    Friend WithEvents lblStoreroom As Label
    Friend WithEvents lblCurrentEvent As Label
    Friend WithEvents lblEvent As Label
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents dlgOpenStoreroom As OpenFileDialog
    Friend WithEvents FixImage As DataGridViewImageColumn
    Friend WithEvents FixManufacturer As DataGridViewTextBoxColumn
    Friend WithEvents FixModel As DataGridViewTextBoxColumn
    Friend WithEvents FixSource As DataGridViewTextBoxColumn
    Friend WithEvents FixType As DataGridViewTextBoxColumn
    Friend WithEvents FixOptics As DataGridViewTextBoxColumn
    Friend WithEvents FixPower As DataGridViewTextBoxColumn
    Friend WithEvents FixQty As DataGridViewTextBoxColumn
    Friend WithEvents btnNewStoreroom As Button
    Friend WithEvents btnNewEvent As Button
End Class
