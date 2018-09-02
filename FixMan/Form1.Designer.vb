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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabase))
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewStoreroomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadStoreroomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveStoreroomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmAddFixture = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmRemoveFixture = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmViewFixture = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmSearchFixture = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ctxStoreroom = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAddFixture = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRemoveFixture = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmViewFixture = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSearchStoreroom = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlStoreroom = New System.Windows.Forms.Panel()
        Me.btnNewStoreroom = New System.Windows.Forms.Button()
        Me.lblCurrentStoreroom = New System.Windows.Forms.Label()
        Me.lblStoreroom = New System.Windows.Forms.Label()
        Me.btnLoadStoreroom = New System.Windows.Forms.Button()
        Me.btnSaveStoreroom = New System.Windows.Forms.Button()
        Me.btnSearchFixture = New System.Windows.Forms.Button()
        Me.btnViewFixture = New System.Windows.Forms.Button()
        Me.btnRemoveFixture = New System.Windows.Forms.Button()
        Me.btnAddFixture = New System.Windows.Forms.Button()
        Me.pnlEvent = New System.Windows.Forms.Panel()
        Me.btnNewEvent = New System.Windows.Forms.Button()
        Me.lblCurrentEvent = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.btnLoadEvent = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnOpenTeamRoster = New System.Windows.Forms.Button()
        Me.btnOpenFixSheet = New System.Windows.Forms.Button()
        Me.btnOpenEventMan = New System.Windows.Forms.Button()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.dlgOpenStoreroom = New System.Windows.Forms.OpenFileDialog()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.dlgSaveStoreroom = New System.Windows.Forms.SaveFileDialog()
        Me.mnuMenuStrip.SuspendLayout()
        CType(Me.dgdStoreroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxStoreroom.SuspendLayout()
        Me.pnlStoreroom.SuspendLayout()
        Me.pnlEvent.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(1003, 24)
        Me.mnuMenuStrip.TabIndex = 0
        Me.mnuMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewStoreroomToolStripMenuItem, Me.LoadStoreroomToolStripMenuItem, Me.SaveStoreroomToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewStoreroomToolStripMenuItem
        '
        Me.NewStoreroomToolStripMenuItem.Name = "NewStoreroomToolStripMenuItem"
        Me.NewStoreroomToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NewStoreroomToolStripMenuItem.Text = "New Storeroom"
        '
        'LoadStoreroomToolStripMenuItem
        '
        Me.LoadStoreroomToolStripMenuItem.Name = "LoadStoreroomToolStripMenuItem"
        Me.LoadStoreroomToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LoadStoreroomToolStripMenuItem.Text = "Load Storeroom"
        '
        'SaveStoreroomToolStripMenuItem
        '
        Me.SaveStoreroomToolStripMenuItem.Name = "SaveStoreroomToolStripMenuItem"
        Me.SaveStoreroomToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SaveStoreroomToolStripMenuItem.Text = "Save Storeroom"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msmAddFixture, Me.msmRemoveFixture, Me.msmViewFixture, Me.msmSearchFixture, Me.UsersToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'msmAddFixture
        '
        Me.msmAddFixture.Name = "msmAddFixture"
        Me.msmAddFixture.Size = New System.Drawing.Size(243, 22)
        Me.msmAddFixture.Text = "Add Fixture to Storeroom"
        '
        'msmRemoveFixture
        '
        Me.msmRemoveFixture.Name = "msmRemoveFixture"
        Me.msmRemoveFixture.Size = New System.Drawing.Size(243, 22)
        Me.msmRemoveFixture.Text = "Remove Fixture from Storeroom"
        '
        'msmViewFixture
        '
        Me.msmViewFixture.Name = "msmViewFixture"
        Me.msmViewFixture.Size = New System.Drawing.Size(243, 22)
        Me.msmViewFixture.Text = "View Selected Fixture"
        '
        'msmSearchFixture
        '
        Me.msmSearchFixture.Name = "msmSearchFixture"
        Me.msmSearchFixture.Size = New System.Drawing.Size(243, 22)
        Me.msmSearchFixture.Text = "Search Storeroom"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.UsersToolStripMenuItem.Text = "Edit Users"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HelpToolStripMenuItem.Text = "About"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Location = New System.Drawing.Point(835, 624)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(916, 624)
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
        Me.dgdStoreroom.ContextMenuStrip = Me.ctxStoreroom
        Me.dgdStoreroom.Location = New System.Drawing.Point(190, 37)
        Me.dgdStoreroom.Name = "dgdStoreroom"
        Me.dgdStoreroom.RowTemplate.Height = 55
        Me.dgdStoreroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdStoreroom.Size = New System.Drawing.Size(801, 578)
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
        Me.FixType.Width = 120
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
        Me.FixPower.Width = 88
        '
        'FixQty
        '
        Me.FixQty.HeaderText = "Qty."
        Me.FixQty.Name = "FixQty"
        Me.FixQty.Width = 50
        '
        'ctxStoreroom
        '
        Me.ctxStoreroom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAddFixture, Me.tsmRemoveFixture, Me.tsmViewFixture, Me.tsmSearchStoreroom})
        Me.ctxStoreroom.Name = "ContextMenuStrip1"
        Me.ctxStoreroom.Size = New System.Drawing.Size(204, 92)
        '
        'tsmAddFixture
        '
        Me.tsmAddFixture.Name = "tsmAddFixture"
        Me.tsmAddFixture.Size = New System.Drawing.Size(203, 22)
        Me.tsmAddFixture.Text = "Add Fixture"
        '
        'tsmRemoveFixture
        '
        Me.tsmRemoveFixture.Name = "tsmRemoveFixture"
        Me.tsmRemoveFixture.Size = New System.Drawing.Size(203, 22)
        Me.tsmRemoveFixture.Text = "Remove Fixture"
        '
        'tsmViewFixture
        '
        Me.tsmViewFixture.Name = "tsmViewFixture"
        Me.tsmViewFixture.Size = New System.Drawing.Size(203, 22)
        Me.tsmViewFixture.Text = "View Fixture Information"
        '
        'tsmSearchStoreroom
        '
        Me.tsmSearchStoreroom.Name = "tsmSearchStoreroom"
        Me.tsmSearchStoreroom.Size = New System.Drawing.Size(203, 22)
        Me.tsmSearchStoreroom.Text = "Search Storeroom"
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
        Me.pnlStoreroom.Size = New System.Drawing.Size(170, 386)
        Me.pnlStoreroom.TabIndex = 4
        '
        'btnNewStoreroom
        '
        Me.btnNewStoreroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewStoreroom.Location = New System.Drawing.Point(50, 326)
        Me.btnNewStoreroom.Name = "btnNewStoreroom"
        Me.btnNewStoreroom.Size = New System.Drawing.Size(75, 47)
        Me.btnNewStoreroom.TabIndex = 13
        Me.btnNewStoreroom.Text = "New"
        Me.btnNewStoreroom.UseVisualStyleBackColor = True
        '
        'lblCurrentStoreroom
        '
        Me.lblCurrentStoreroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentStoreroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStoreroom.Location = New System.Drawing.Point(7, 20)
        Me.lblCurrentStoreroom.Name = "lblCurrentStoreroom"
        Me.lblCurrentStoreroom.Size = New System.Drawing.Size(156, 34)
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
        Me.btnLoadStoreroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadStoreroom.Location = New System.Drawing.Point(88, 273)
        Me.btnLoadStoreroom.Name = "btnLoadStoreroom"
        Me.btnLoadStoreroom.Size = New System.Drawing.Size(75, 47)
        Me.btnLoadStoreroom.TabIndex = 11
        Me.btnLoadStoreroom.Text = "Load"
        Me.btnLoadStoreroom.UseVisualStyleBackColor = True
        '
        'btnSaveStoreroom
        '
        Me.btnSaveStoreroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveStoreroom.Location = New System.Drawing.Point(7, 273)
        Me.btnSaveStoreroom.Name = "btnSaveStoreroom"
        Me.btnSaveStoreroom.Size = New System.Drawing.Size(75, 47)
        Me.btnSaveStoreroom.TabIndex = 10
        Me.btnSaveStoreroom.Text = "Save"
        Me.btnSaveStoreroom.UseVisualStyleBackColor = True
        '
        'btnSearchFixture
        '
        Me.btnSearchFixture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFixture.Location = New System.Drawing.Point(7, 220)
        Me.btnSearchFixture.Name = "btnSearchFixture"
        Me.btnSearchFixture.Size = New System.Drawing.Size(156, 47)
        Me.btnSearchFixture.TabIndex = 9
        Me.btnSearchFixture.Text = "Search Storeroom"
        Me.btnSearchFixture.UseVisualStyleBackColor = True
        '
        'btnViewFixture
        '
        Me.btnViewFixture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewFixture.Location = New System.Drawing.Point(7, 166)
        Me.btnViewFixture.Name = "btnViewFixture"
        Me.btnViewFixture.Size = New System.Drawing.Size(156, 47)
        Me.btnViewFixture.TabIndex = 8
        Me.btnViewFixture.Text = "View Fixture Info"
        Me.btnViewFixture.UseVisualStyleBackColor = True
        '
        'btnRemoveFixture
        '
        Me.btnRemoveFixture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFixture.Location = New System.Drawing.Point(7, 113)
        Me.btnRemoveFixture.Name = "btnRemoveFixture"
        Me.btnRemoveFixture.Size = New System.Drawing.Size(156, 47)
        Me.btnRemoveFixture.TabIndex = 7
        Me.btnRemoveFixture.Text = "Remove Fixture"
        Me.btnRemoveFixture.UseVisualStyleBackColor = True
        '
        'btnAddFixture
        '
        Me.btnAddFixture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFixture.Location = New System.Drawing.Point(7, 60)
        Me.btnAddFixture.Name = "btnAddFixture"
        Me.btnAddFixture.Size = New System.Drawing.Size(156, 47)
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
        Me.pnlEvent.Location = New System.Drawing.Point(14, 464)
        Me.pnlEvent.Name = "pnlEvent"
        Me.pnlEvent.Size = New System.Drawing.Size(170, 193)
        Me.pnlEvent.TabIndex = 5
        Me.pnlEvent.Visible = False
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
        Me.lblCurrentUser.Location = New System.Drawing.Point(216, 629)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(613, 18)
        Me.lblCurrentUser.TabIndex = 18
        Me.lblCurrentUser.Text = "**TO BE USED FOR CURRENT LOGIN**"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dlgOpenStoreroom
        '
        Me.dlgOpenStoreroom.Title = "Open Storeroom"
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
        'dlgSaveStoreroom
        '
        Me.dlgSaveStoreroom.DefaultExt = "xml"
        Me.dlgSaveStoreroom.Filter = """XML Files|*.xml"""
        Me.dlgSaveStoreroom.Title = "Save Storeroom"
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 658)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Controls.Add(Me.pnlEvent)
        Me.Controls.Add(Me.pnlStoreroom)
        Me.Controls.Add(Me.dgdStoreroom)
        Me.Controls.Add(Me.lblCurrentUser)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.picLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMenuStrip
        Me.Name = "frmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FixMan"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        CType(Me.dgdStoreroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxStoreroom.ResumeLayout(False)
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
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents dlgOpenStoreroom As OpenFileDialog
    Friend WithEvents btnNewStoreroom As Button
    Friend WithEvents btnNewEvent As Button
    Friend WithEvents NewStoreroomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadStoreroomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveStoreroomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msmAddFixture As ToolStripMenuItem
    Friend WithEvents msmRemoveFixture As ToolStripMenuItem
    Friend WithEvents msmViewFixture As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ctxStoreroom As ContextMenuStrip
    Friend WithEvents tsmAddFixture As ToolStripMenuItem
    Friend WithEvents tsmRemoveFixture As ToolStripMenuItem
    Friend WithEvents tsmViewFixture As ToolStripMenuItem
    Friend WithEvents FixImage As DataGridViewImageColumn
    Friend WithEvents FixManufacturer As DataGridViewTextBoxColumn
    Friend WithEvents FixModel As DataGridViewTextBoxColumn
    Friend WithEvents FixSource As DataGridViewTextBoxColumn
    Friend WithEvents FixType As DataGridViewTextBoxColumn
    Friend WithEvents FixOptics As DataGridViewTextBoxColumn
    Friend WithEvents FixPower As DataGridViewTextBoxColumn
    Friend WithEvents FixQty As DataGridViewTextBoxColumn
    Friend WithEvents msmSearchFixture As ToolStripMenuItem
    Friend WithEvents tsmSearchStoreroom As ToolStripMenuItem
    Friend WithEvents dlgSaveStoreroom As SaveFileDialog
End Class
