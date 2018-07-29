<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddFix2
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.lblImagePrompt = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.lblImageLocation = New System.Windows.Forms.Label()
        Me.lblManufacturerPrompt = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.dgdColours = New System.Windows.Forms.DataGridView()
        Me.dgdGobos = New System.Windows.Forms.DataGridView()
        Me.lstControl = New System.Windows.Forms.ListBox()
        Me.cmbBeamType = New System.Windows.Forms.ComboBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.nudColourTemp = New System.Windows.Forms.NumericUpDown()
        Me.txtControl = New System.Windows.Forms.TextBox()
        Me.btnAddControl = New System.Windows.Forms.Button()
        Me.lstEffects = New System.Windows.Forms.ListBox()
        Me.nudPowerDraw = New System.Windows.Forms.NumericUpDown()
        Me.lblTypePrompt = New System.Windows.Forms.Label()
        Me.lblBeamType = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblColourTempPrompt = New System.Windows.Forms.Label()
        Me.lblControlPrompt = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblColoursPrompt = New System.Windows.Forms.Label()
        Me.lblGoboPrompt = New System.Windows.Forms.Label()
        Me.lblEffectsPrompt = New System.Windows.Forms.Label()
        Me.lblBeamAnglePrompt = New System.Windows.Forms.Label()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.lblNotesPrompt = New System.Windows.Forms.Label()
        Me.lblBASep = New System.Windows.Forms.Label()
        Me.nudBeamAngleFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudBeamAngleTo = New System.Windows.Forms.NumericUpDown()
        Me.chkAutoZoom = New System.Windows.Forms.CheckBox()
        Me.pnlBeamType = New System.Windows.Forms.Panel()
        Me.pnlBeamAngle = New System.Windows.Forms.Panel()
        Me.pnlSource = New System.Windows.Forms.Panel()
        Me.pnlColourTemp = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnColourText = New System.Windows.Forms.Button()
        Me.btnColourImage = New System.Windows.Forms.Button()
        Me.btnColourRemove = New System.Windows.Forms.Button()
        Me.btnGoboRemove = New System.Windows.Forms.Button()
        Me.btnGoboImage = New System.Windows.Forms.Button()
        Me.btnGoboText = New System.Windows.Forms.Button()
        Me.pnlPowerDraw = New System.Windows.Forms.Panel()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.pnlManufacturer = New System.Windows.Forms.Panel()
        Me.pnlModel = New System.Windows.Forms.Panel()
        Me.pnlType = New System.Windows.Forms.Panel()
        Me.pnlColours = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtEffects = New System.Windows.Forms.TextBox()
        Me.btnAddEffect = New System.Windows.Forms.Button()
        Me.pnlGobos = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.dlgOpenImage = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdColours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdGobos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColourTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPowerDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBeamAngleFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBeamAngleTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBeamType.SuspendLayout()
        Me.pnlBeamAngle.SuspendLayout()
        Me.pnlSource.SuspendLayout()
        Me.pnlColourTemp.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlPowerDraw.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        Me.pnlManufacturer.SuspendLayout()
        Me.pnlModel.SuspendLayout()
        Me.pnlType.SuspendLayout()
        Me.pnlColours.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.pnlGobos.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1069, 509)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(988, 509)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(7, 228)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(75, 23)
        Me.btnAddImage.TabIndex = 0
        Me.btnAddImage.Text = "Add Image"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'lblImagePrompt
        '
        Me.lblImagePrompt.AutoSize = True
        Me.lblImagePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagePrompt.Location = New System.Drawing.Point(7, 6)
        Me.lblImagePrompt.Name = "lblImagePrompt"
        Me.lblImagePrompt.Size = New System.Drawing.Size(49, 16)
        Me.lblImagePrompt.TabIndex = 25
        Me.lblImagePrompt.Text = "Image:"
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(7, 25)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(222, 197)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 4
        Me.picImage.TabStop = False
        '
        'lblImageLocation
        '
        Me.lblImageLocation.Location = New System.Drawing.Point(7, 257)
        Me.lblImageLocation.Name = "lblImageLocation"
        Me.lblImageLocation.Size = New System.Drawing.Size(221, 19)
        Me.lblImageLocation.TabIndex = 26
        Me.lblImageLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblManufacturerPrompt
        '
        Me.lblManufacturerPrompt.AutoSize = True
        Me.lblManufacturerPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturerPrompt.Location = New System.Drawing.Point(3, 5)
        Me.lblManufacturerPrompt.Name = "lblManufacturerPrompt"
        Me.lblManufacturerPrompt.Size = New System.Drawing.Size(88, 16)
        Me.lblManufacturerPrompt.TabIndex = 27
        Me.lblManufacturerPrompt.Text = "Manufacturer:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(6, 4)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(49, 16)
        Me.lblModel.TabIndex = 28
        Me.lblModel.Text = "Model:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(515, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Add Fixture"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(6, 24)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(222, 20)
        Me.txtManufacturer.TabIndex = 1
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(6, 23)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(222, 20)
        Me.txtModel.TabIndex = 2
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(4, 23)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(222, 21)
        Me.cmbType.TabIndex = 4
        '
        'dgdColours
        '
        Me.dgdColours.AllowUserToAddRows = False
        Me.dgdColours.AllowUserToDeleteRows = False
        Me.dgdColours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdColours.Location = New System.Drawing.Point(9, 22)
        Me.dgdColours.Name = "dgdColours"
        Me.dgdColours.RowHeadersWidth = 10
        Me.dgdColours.Size = New System.Drawing.Size(314, 150)
        Me.dgdColours.TabIndex = 38
        Me.dgdColours.TabStop = False
        '
        'dgdGobos
        '
        Me.dgdGobos.AllowUserToAddRows = False
        Me.dgdGobos.AllowUserToDeleteRows = False
        Me.dgdGobos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdGobos.Location = New System.Drawing.Point(9, 20)
        Me.dgdGobos.Name = "dgdGobos"
        Me.dgdGobos.RowHeadersWidth = 10
        Me.dgdGobos.Size = New System.Drawing.Size(314, 150)
        Me.dgdGobos.TabIndex = 39
        Me.dgdGobos.TabStop = False
        '
        'lstControl
        '
        Me.lstControl.FormattingEnabled = True
        Me.lstControl.Location = New System.Drawing.Point(6, 48)
        Me.lstControl.Name = "lstControl"
        Me.lstControl.Size = New System.Drawing.Size(220, 95)
        Me.lstControl.TabIndex = 35
        Me.lstControl.TabStop = False
        '
        'cmbBeamType
        '
        Me.cmbBeamType.FormattingEnabled = True
        Me.cmbBeamType.Location = New System.Drawing.Point(5, 25)
        Me.cmbBeamType.Name = "cmbBeamType"
        Me.cmbBeamType.Size = New System.Drawing.Size(220, 21)
        Me.cmbBeamType.TabIndex = 5
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(6, 26)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(222, 20)
        Me.txtSource.TabIndex = 3
        '
        'nudColourTemp
        '
        Me.nudColourTemp.Location = New System.Drawing.Point(6, 27)
        Me.nudColourTemp.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudColourTemp.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudColourTemp.Name = "nudColourTemp"
        Me.nudColourTemp.Size = New System.Drawing.Size(220, 20)
        Me.nudColourTemp.TabIndex = 10
        Me.nudColourTemp.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'txtControl
        '
        Me.txtControl.Location = New System.Drawing.Point(6, 22)
        Me.txtControl.Name = "txtControl"
        Me.txtControl.Size = New System.Drawing.Size(139, 20)
        Me.txtControl.TabIndex = 11
        '
        'btnAddControl
        '
        Me.btnAddControl.Location = New System.Drawing.Point(151, 22)
        Me.btnAddControl.Name = "btnAddControl"
        Me.btnAddControl.Size = New System.Drawing.Size(75, 20)
        Me.btnAddControl.TabIndex = 12
        Me.btnAddControl.Text = "Add"
        Me.btnAddControl.UseVisualStyleBackColor = True
        '
        'lstEffects
        '
        Me.lstEffects.FormattingEnabled = True
        Me.lstEffects.Location = New System.Drawing.Point(10, 52)
        Me.lstEffects.Name = "lstEffects"
        Me.lstEffects.Size = New System.Drawing.Size(240, 212)
        Me.lstEffects.TabIndex = 41
        Me.lstEffects.TabStop = False
        '
        'nudPowerDraw
        '
        Me.nudPowerDraw.Location = New System.Drawing.Point(7, 24)
        Me.nudPowerDraw.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudPowerDraw.Name = "nudPowerDraw"
        Me.nudPowerDraw.Size = New System.Drawing.Size(220, 20)
        Me.nudPowerDraw.TabIndex = 13
        '
        'lblTypePrompt
        '
        Me.lblTypePrompt.AutoSize = True
        Me.lblTypePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypePrompt.Location = New System.Drawing.Point(6, 5)
        Me.lblTypePrompt.Name = "lblTypePrompt"
        Me.lblTypePrompt.Size = New System.Drawing.Size(43, 16)
        Me.lblTypePrompt.TabIndex = 30
        Me.lblTypePrompt.Text = "Type:"
        '
        'lblBeamType
        '
        Me.lblBeamType.AutoSize = True
        Me.lblBeamType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeamType.Location = New System.Drawing.Point(6, 6)
        Me.lblBeamType.Name = "lblBeamType"
        Me.lblBeamType.Size = New System.Drawing.Size(101, 16)
        Me.lblBeamType.TabIndex = 31
        Me.lblBeamType.Text = "Optical System:"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.Location = New System.Drawing.Point(6, 7)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(85, 16)
        Me.lblSource.TabIndex = 29
        Me.lblSource.Text = "Light Source:"
        '
        'lblColourTempPrompt
        '
        Me.lblColourTempPrompt.AutoSize = True
        Me.lblColourTempPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourTempPrompt.Location = New System.Drawing.Point(6, 7)
        Me.lblColourTempPrompt.Name = "lblColourTempPrompt"
        Me.lblColourTempPrompt.Size = New System.Drawing.Size(151, 16)
        Me.lblColourTempPrompt.TabIndex = 33
        Me.lblColourTempPrompt.Text = "Colour Temp. (At Open):"
        '
        'lblControlPrompt
        '
        Me.lblControlPrompt.AutoSize = True
        Me.lblControlPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlPrompt.Location = New System.Drawing.Point(6, 4)
        Me.lblControlPrompt.Name = "lblControlPrompt"
        Me.lblControlPrompt.Size = New System.Drawing.Size(113, 16)
        Me.lblControlPrompt.TabIndex = 34
        Me.lblControlPrompt.Text = "Control Protocols:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Total Power Draw:"
        '
        'lblColoursPrompt
        '
        Me.lblColoursPrompt.AutoSize = True
        Me.lblColoursPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColoursPrompt.Location = New System.Drawing.Point(9, 3)
        Me.lblColoursPrompt.Name = "lblColoursPrompt"
        Me.lblColoursPrompt.Size = New System.Drawing.Size(57, 16)
        Me.lblColoursPrompt.TabIndex = 37
        Me.lblColoursPrompt.Text = "Colours:"
        '
        'lblGoboPrompt
        '
        Me.lblGoboPrompt.AutoSize = True
        Me.lblGoboPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoboPrompt.Location = New System.Drawing.Point(9, 4)
        Me.lblGoboPrompt.Name = "lblGoboPrompt"
        Me.lblGoboPrompt.Size = New System.Drawing.Size(52, 16)
        Me.lblGoboPrompt.TabIndex = 29
        Me.lblGoboPrompt.Text = "Gobos:"
        '
        'lblEffectsPrompt
        '
        Me.lblEffectsPrompt.AutoSize = True
        Me.lblEffectsPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEffectsPrompt.Location = New System.Drawing.Point(10, 5)
        Me.lblEffectsPrompt.Name = "lblEffectsPrompt"
        Me.lblEffectsPrompt.Size = New System.Drawing.Size(51, 16)
        Me.lblEffectsPrompt.TabIndex = 40
        Me.lblEffectsPrompt.Text = "Effects:"
        '
        'lblBeamAnglePrompt
        '
        Me.lblBeamAnglePrompt.AutoSize = True
        Me.lblBeamAnglePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeamAnglePrompt.Location = New System.Drawing.Point(5, 7)
        Me.lblBeamAnglePrompt.Name = "lblBeamAnglePrompt"
        Me.lblBeamAnglePrompt.Size = New System.Drawing.Size(85, 16)
        Me.lblBeamAnglePrompt.TabIndex = 32
        Me.lblBeamAnglePrompt.Text = "Beam Angle:"
        '
        'rtbNotes
        '
        Me.rtbNotes.AcceptsTab = True
        Me.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbNotes.BulletIndent = 1
        Me.rtbNotes.Location = New System.Drawing.Point(10, 24)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(240, 140)
        Me.rtbNotes.TabIndex = 22
        Me.rtbNotes.Text = ""
        '
        'lblNotesPrompt
        '
        Me.lblNotesPrompt.AutoSize = True
        Me.lblNotesPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotesPrompt.Location = New System.Drawing.Point(10, 5)
        Me.lblNotesPrompt.Name = "lblNotesPrompt"
        Me.lblNotesPrompt.Size = New System.Drawing.Size(82, 16)
        Me.lblNotesPrompt.TabIndex = 42
        Me.lblNotesPrompt.Text = "Other Notes:"
        '
        'lblBASep
        '
        Me.lblBASep.AutoSize = True
        Me.lblBASep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBASep.Location = New System.Drawing.Point(110, 30)
        Me.lblBASep.Name = "lblBASep"
        Me.lblBASep.Size = New System.Drawing.Size(12, 16)
        Me.lblBASep.TabIndex = 34
        Me.lblBASep.Text = "-"
        Me.lblBASep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudBeamAngleFrom
        '
        Me.nudBeamAngleFrom.Location = New System.Drawing.Point(5, 28)
        Me.nudBeamAngleFrom.Name = "nudBeamAngleFrom"
        Me.nudBeamAngleFrom.Size = New System.Drawing.Size(98, 20)
        Me.nudBeamAngleFrom.TabIndex = 7
        '
        'nudBeamAngleTo
        '
        Me.nudBeamAngleTo.Location = New System.Drawing.Point(127, 28)
        Me.nudBeamAngleTo.Name = "nudBeamAngleTo"
        Me.nudBeamAngleTo.Size = New System.Drawing.Size(98, 20)
        Me.nudBeamAngleTo.TabIndex = 8
        '
        'chkAutoZoom
        '
        Me.chkAutoZoom.AutoSize = True
        Me.chkAutoZoom.Location = New System.Drawing.Point(5, 54)
        Me.chkAutoZoom.Name = "chkAutoZoom"
        Me.chkAutoZoom.Size = New System.Drawing.Size(113, 17)
        Me.chkAutoZoom.TabIndex = 9
        Me.chkAutoZoom.Text = "Automated Zoom?"
        Me.chkAutoZoom.UseVisualStyleBackColor = True
        '
        'pnlBeamType
        '
        Me.pnlBeamType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBeamType.Controls.Add(Me.cmbBeamType)
        Me.pnlBeamType.Controls.Add(Me.lblBeamType)
        Me.pnlBeamType.Location = New System.Drawing.Point(271, 104)
        Me.pnlBeamType.Name = "pnlBeamType"
        Me.pnlBeamType.Size = New System.Drawing.Size(231, 55)
        Me.pnlBeamType.TabIndex = 48
        '
        'pnlBeamAngle
        '
        Me.pnlBeamAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBeamAngle.Controls.Add(Me.nudBeamAngleFrom)
        Me.pnlBeamAngle.Controls.Add(Me.lblBeamAnglePrompt)
        Me.pnlBeamAngle.Controls.Add(Me.chkAutoZoom)
        Me.pnlBeamAngle.Controls.Add(Me.lblBASep)
        Me.pnlBeamAngle.Controls.Add(Me.nudBeamAngleTo)
        Me.pnlBeamAngle.Location = New System.Drawing.Point(271, 165)
        Me.pnlBeamAngle.Name = "pnlBeamAngle"
        Me.pnlBeamAngle.Size = New System.Drawing.Size(231, 82)
        Me.pnlBeamAngle.TabIndex = 49
        '
        'pnlSource
        '
        Me.pnlSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSource.Controls.Add(Me.lblSource)
        Me.pnlSource.Controls.Add(Me.txtSource)
        Me.pnlSource.Location = New System.Drawing.Point(16, 453)
        Me.pnlSource.Name = "pnlSource"
        Me.pnlSource.Size = New System.Drawing.Size(236, 57)
        Me.pnlSource.TabIndex = 46
        '
        'pnlColourTemp
        '
        Me.pnlColourTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColourTemp.Controls.Add(Me.lblColourTempPrompt)
        Me.pnlColourTemp.Controls.Add(Me.nudColourTemp)
        Me.pnlColourTemp.Location = New System.Drawing.Point(271, 253)
        Me.pnlColourTemp.Name = "pnlColourTemp"
        Me.pnlColourTemp.Size = New System.Drawing.Size(231, 59)
        Me.pnlColourTemp.TabIndex = 50
        '
        'pnlControl
        '
        Me.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControl.Controls.Add(Me.lstControl)
        Me.pnlControl.Controls.Add(Me.txtControl)
        Me.pnlControl.Controls.Add(Me.btnAddControl)
        Me.pnlControl.Controls.Add(Me.lblControlPrompt)
        Me.pnlControl.Location = New System.Drawing.Point(271, 318)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(231, 155)
        Me.pnlControl.TabIndex = 51
        '
        'btnColourText
        '
        Me.btnColourText.Location = New System.Drawing.Point(9, 178)
        Me.btnColourText.Name = "btnColourText"
        Me.btnColourText.Size = New System.Drawing.Size(75, 23)
        Me.btnColourText.TabIndex = 14
        Me.btnColourText.Text = "Add Text"
        Me.btnColourText.UseVisualStyleBackColor = True
        '
        'btnColourImage
        '
        Me.btnColourImage.Location = New System.Drawing.Point(90, 178)
        Me.btnColourImage.Name = "btnColourImage"
        Me.btnColourImage.Size = New System.Drawing.Size(75, 23)
        Me.btnColourImage.TabIndex = 15
        Me.btnColourImage.Text = "Add Image"
        Me.btnColourImage.UseVisualStyleBackColor = True
        '
        'btnColourRemove
        '
        Me.btnColourRemove.Location = New System.Drawing.Point(171, 178)
        Me.btnColourRemove.Name = "btnColourRemove"
        Me.btnColourRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnColourRemove.TabIndex = 16
        Me.btnColourRemove.Text = "Remove Cell"
        Me.btnColourRemove.UseVisualStyleBackColor = True
        '
        'btnGoboRemove
        '
        Me.btnGoboRemove.Location = New System.Drawing.Point(171, 176)
        Me.btnGoboRemove.Name = "btnGoboRemove"
        Me.btnGoboRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnGoboRemove.TabIndex = 19
        Me.btnGoboRemove.Text = "Remove Cell"
        Me.btnGoboRemove.UseVisualStyleBackColor = True
        '
        'btnGoboImage
        '
        Me.btnGoboImage.Location = New System.Drawing.Point(90, 176)
        Me.btnGoboImage.Name = "btnGoboImage"
        Me.btnGoboImage.Size = New System.Drawing.Size(75, 23)
        Me.btnGoboImage.TabIndex = 18
        Me.btnGoboImage.Text = "Add Image"
        Me.btnGoboImage.UseVisualStyleBackColor = True
        '
        'btnGoboText
        '
        Me.btnGoboText.Location = New System.Drawing.Point(9, 176)
        Me.btnGoboText.Name = "btnGoboText"
        Me.btnGoboText.Size = New System.Drawing.Size(75, 23)
        Me.btnGoboText.TabIndex = 17
        Me.btnGoboText.Text = "Add Text"
        Me.btnGoboText.UseVisualStyleBackColor = True
        '
        'pnlPowerDraw
        '
        Me.pnlPowerDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPowerDraw.Controls.Add(Me.Label11)
        Me.pnlPowerDraw.Controls.Add(Me.nudPowerDraw)
        Me.pnlPowerDraw.Location = New System.Drawing.Point(271, 479)
        Me.pnlPowerDraw.Name = "pnlPowerDraw"
        Me.pnlPowerDraw.Size = New System.Drawing.Size(231, 53)
        Me.pnlPowerDraw.TabIndex = 52
        '
        'pnlImage
        '
        Me.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlImage.Controls.Add(Me.picImage)
        Me.pnlImage.Controls.Add(Me.btnAddImage)
        Me.pnlImage.Controls.Add(Me.lblImagePrompt)
        Me.pnlImage.Controls.Add(Me.lblImageLocation)
        Me.pnlImage.Location = New System.Drawing.Point(16, 42)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(236, 285)
        Me.pnlImage.TabIndex = 43
        '
        'pnlManufacturer
        '
        Me.pnlManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlManufacturer.Controls.Add(Me.lblManufacturerPrompt)
        Me.pnlManufacturer.Controls.Add(Me.txtManufacturer)
        Me.pnlManufacturer.Location = New System.Drawing.Point(16, 333)
        Me.pnlManufacturer.Name = "pnlManufacturer"
        Me.pnlManufacturer.Size = New System.Drawing.Size(236, 56)
        Me.pnlManufacturer.TabIndex = 44
        '
        'pnlModel
        '
        Me.pnlModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlModel.Controls.Add(Me.txtModel)
        Me.pnlModel.Controls.Add(Me.lblModel)
        Me.pnlModel.Location = New System.Drawing.Point(16, 395)
        Me.pnlModel.Name = "pnlModel"
        Me.pnlModel.Size = New System.Drawing.Size(236, 52)
        Me.pnlModel.TabIndex = 45
        '
        'pnlType
        '
        Me.pnlType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlType.Controls.Add(Me.lblTypePrompt)
        Me.pnlType.Controls.Add(Me.cmbType)
        Me.pnlType.Location = New System.Drawing.Point(271, 42)
        Me.pnlType.Name = "pnlType"
        Me.pnlType.Size = New System.Drawing.Size(231, 56)
        Me.pnlType.TabIndex = 47
        '
        'pnlColours
        '
        Me.pnlColours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColours.Controls.Add(Me.dgdColours)
        Me.pnlColours.Controls.Add(Me.lblColoursPrompt)
        Me.pnlColours.Controls.Add(Me.btnColourText)
        Me.pnlColours.Controls.Add(Me.btnColourImage)
        Me.pnlColours.Controls.Add(Me.btnColourRemove)
        Me.pnlColours.Location = New System.Drawing.Point(523, 42)
        Me.pnlColours.Name = "pnlColours"
        Me.pnlColours.Size = New System.Drawing.Size(333, 208)
        Me.pnlColours.TabIndex = 53
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.txtEffects)
        Me.Panel12.Controls.Add(Me.btnAddEffect)
        Me.Panel12.Controls.Add(Me.lstEffects)
        Me.Panel12.Controls.Add(Me.lblEffectsPrompt)
        Me.Panel12.Location = New System.Drawing.Point(875, 42)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(260, 273)
        Me.Panel12.TabIndex = 55
        '
        'txtEffects
        '
        Me.txtEffects.Location = New System.Drawing.Point(10, 26)
        Me.txtEffects.Name = "txtEffects"
        Me.txtEffects.Size = New System.Drawing.Size(159, 20)
        Me.txtEffects.TabIndex = 20
        '
        'btnAddEffect
        '
        Me.btnAddEffect.Location = New System.Drawing.Point(175, 26)
        Me.btnAddEffect.Name = "btnAddEffect"
        Me.btnAddEffect.Size = New System.Drawing.Size(75, 20)
        Me.btnAddEffect.TabIndex = 21
        Me.btnAddEffect.Text = "Add"
        Me.btnAddEffect.UseVisualStyleBackColor = True
        '
        'pnlGobos
        '
        Me.pnlGobos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGobos.Controls.Add(Me.dgdGobos)
        Me.pnlGobos.Controls.Add(Me.lblGoboPrompt)
        Me.pnlGobos.Controls.Add(Me.btnGoboText)
        Me.pnlGobos.Controls.Add(Me.btnGoboImage)
        Me.pnlGobos.Controls.Add(Me.btnGoboRemove)
        Me.pnlGobos.Location = New System.Drawing.Point(523, 256)
        Me.pnlGobos.Name = "pnlGobos"
        Me.pnlGobos.Size = New System.Drawing.Size(333, 208)
        Me.pnlGobos.TabIndex = 54
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.rtbNotes)
        Me.Panel14.Controls.Add(Me.lblNotesPrompt)
        Me.Panel14.Location = New System.Drawing.Point(875, 321)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(260, 176)
        Me.Panel14.TabIndex = 56
        '
        'dlgOpenImage
        '
        Me.dlgOpenImage.Filter = "Image Files|*.BMP; *.JPG;*.JPEG;*.GIF;*.WMF;*.PNG|All Files|*.*"
        Me.dlgOpenImage.Title = "Select an image"
        '
        'frmAddFix2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 540)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.pnlGobos)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.pnlColours)
        Me.Controls.Add(Me.pnlType)
        Me.Controls.Add(Me.pnlModel)
        Me.Controls.Add(Me.pnlManufacturer)
        Me.Controls.Add(Me.pnlImage)
        Me.Controls.Add(Me.pnlPowerDraw)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.pnlColourTemp)
        Me.Controls.Add(Me.pnlSource)
        Me.Controls.Add(Me.pnlBeamAngle)
        Me.Controls.Add(Me.pnlBeamType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmAddFix2"
        Me.Text = "Add Fixture"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdColours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdGobos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColourTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPowerDraw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBeamAngleFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBeamAngleTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBeamType.ResumeLayout(False)
        Me.pnlBeamType.PerformLayout()
        Me.pnlBeamAngle.ResumeLayout(False)
        Me.pnlBeamAngle.PerformLayout()
        Me.pnlSource.ResumeLayout(False)
        Me.pnlSource.PerformLayout()
        Me.pnlColourTemp.ResumeLayout(False)
        Me.pnlColourTemp.PerformLayout()
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.pnlPowerDraw.ResumeLayout(False)
        Me.pnlPowerDraw.PerformLayout()
        Me.pnlImage.ResumeLayout(False)
        Me.pnlImage.PerformLayout()
        Me.pnlManufacturer.ResumeLayout(False)
        Me.pnlManufacturer.PerformLayout()
        Me.pnlModel.ResumeLayout(False)
        Me.pnlModel.PerformLayout()
        Me.pnlType.ResumeLayout(False)
        Me.pnlType.PerformLayout()
        Me.pnlColours.ResumeLayout(False)
        Me.pnlColours.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.pnlGobos.ResumeLayout(False)
        Me.pnlGobos.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAddImage As Button
    Friend WithEvents lblImagePrompt As Label
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblImageLocation As Label
    Friend WithEvents lblManufacturerPrompt As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents dgdColours As DataGridView
    Friend WithEvents dgdGobos As DataGridView
    Friend WithEvents lstControl As ListBox
    Friend WithEvents cmbBeamType As ComboBox
    Friend WithEvents txtSource As TextBox
    Friend WithEvents nudColourTemp As NumericUpDown
    Friend WithEvents txtControl As TextBox
    Friend WithEvents btnAddControl As Button
    Friend WithEvents lstEffects As ListBox
    Friend WithEvents nudPowerDraw As NumericUpDown
    Friend WithEvents lblTypePrompt As Label
    Friend WithEvents lblBeamType As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents lblColourTempPrompt As Label
    Friend WithEvents lblControlPrompt As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblColoursPrompt As Label
    Friend WithEvents lblGoboPrompt As Label
    Friend WithEvents lblEffectsPrompt As Label
    Friend WithEvents lblBeamAnglePrompt As Label
    Friend WithEvents rtbNotes As RichTextBox
    Friend WithEvents lblNotesPrompt As Label
    Friend WithEvents lblBASep As Label
    Friend WithEvents nudBeamAngleFrom As NumericUpDown
    Friend WithEvents nudBeamAngleTo As NumericUpDown
    Friend WithEvents chkAutoZoom As CheckBox
    Friend WithEvents pnlBeamType As Panel
    Friend WithEvents pnlBeamAngle As Panel
    Friend WithEvents pnlSource As Panel
    Friend WithEvents pnlColourTemp As Panel
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnColourText As Button
    Friend WithEvents btnColourImage As Button
    Friend WithEvents btnColourRemove As Button
    Friend WithEvents btnGoboRemove As Button
    Friend WithEvents btnGoboImage As Button
    Friend WithEvents btnGoboText As Button
    Friend WithEvents pnlPowerDraw As Panel
    Friend WithEvents pnlImage As Panel
    Friend WithEvents pnlManufacturer As Panel
    Friend WithEvents pnlModel As Panel
    Friend WithEvents pnlType As Panel
    Friend WithEvents pnlColours As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents pnlGobos As Panel
    Friend WithEvents txtEffects As TextBox
    Friend WithEvents btnAddEffect As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents dlgOpenImage As OpenFileDialog
End Class
