<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFixtureInfo
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
        Me.tabManual = New System.Windows.Forms.TabPage()
        Me.lstDocuments = New System.Windows.Forms.ListBox()
        Me.webDocViewer = New System.Windows.Forms.WebBrowser()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.lblNotesPrompt = New System.Windows.Forms.Label()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.lstEffects = New System.Windows.Forms.ListBox()
        Me.lstControl = New System.Windows.Forms.ListBox()
        Me.dgdGobos = New System.Windows.Forms.DataGridView()
        Me.dgdColours = New System.Windows.Forms.DataGridView()
        Me.lblEffectPrompt = New System.Windows.Forms.Label()
        Me.lblGoboPrompt = New System.Windows.Forms.Label()
        Me.lblColourPrompt = New System.Windows.Forms.Label()
        Me.lblTPD = New System.Windows.Forms.Label()
        Me.lblTPDPrompt = New System.Windows.Forms.Label()
        Me.lblBeamPrompt = New System.Windows.Forms.Label()
        Me.lblColourTemp = New System.Windows.Forms.Label()
        Me.lblControlPrompt = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblColourTempPrompt = New System.Windows.Forms.Label()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.lblSourcePrompt = New System.Windows.Forms.Label()
        Me.lblBeam = New System.Windows.Forms.Label()
        Me.lblAnglePrompt = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblTypePrompt = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblModelPrompt = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblManufacturerPrompt = New System.Windows.Forms.Label()
        Me.lblImagePrompt = New System.Windows.Forms.Label()
        Me.tabTabs = New System.Windows.Forms.TabControl()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.tabManual.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        CType(Me.dgdGobos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdColours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTabs.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabManual
        '
        Me.tabManual.Controls.Add(Me.lstDocuments)
        Me.tabManual.Controls.Add(Me.webDocViewer)
        Me.tabManual.Location = New System.Drawing.Point(4, 22)
        Me.tabManual.Name = "tabManual"
        Me.tabManual.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManual.Size = New System.Drawing.Size(889, 508)
        Me.tabManual.TabIndex = 4
        Me.tabManual.Text = "Documentation"
        Me.tabManual.UseVisualStyleBackColor = True
        '
        'lstDocuments
        '
        Me.lstDocuments.FormattingEnabled = True
        Me.lstDocuments.Location = New System.Drawing.Point(723, -1)
        Me.lstDocuments.Name = "lstDocuments"
        Me.lstDocuments.Size = New System.Drawing.Size(166, 511)
        Me.lstDocuments.TabIndex = 1
        '
        'webDocViewer
        '
        Me.webDocViewer.Location = New System.Drawing.Point(0, 0)
        Me.webDocViewer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webDocViewer.Name = "webDocViewer"
        Me.webDocViewer.Size = New System.Drawing.Size(722, 512)
        Me.webDocViewer.TabIndex = 0
        '
        'tabSummary
        '
        Me.tabSummary.Controls.Add(Me.lblNotesPrompt)
        Me.tabSummary.Controls.Add(Me.rtbNotes)
        Me.tabSummary.Controls.Add(Me.lstEffects)
        Me.tabSummary.Controls.Add(Me.lstControl)
        Me.tabSummary.Controls.Add(Me.dgdGobos)
        Me.tabSummary.Controls.Add(Me.dgdColours)
        Me.tabSummary.Controls.Add(Me.picImage)
        Me.tabSummary.Controls.Add(Me.lblEffectPrompt)
        Me.tabSummary.Controls.Add(Me.lblGoboPrompt)
        Me.tabSummary.Controls.Add(Me.lblColourPrompt)
        Me.tabSummary.Controls.Add(Me.lblTPD)
        Me.tabSummary.Controls.Add(Me.lblTPDPrompt)
        Me.tabSummary.Controls.Add(Me.lblBeamPrompt)
        Me.tabSummary.Controls.Add(Me.lblColourTemp)
        Me.tabSummary.Controls.Add(Me.lblControlPrompt)
        Me.tabSummary.Controls.Add(Me.lblSource)
        Me.tabSummary.Controls.Add(Me.lblColourTempPrompt)
        Me.tabSummary.Controls.Add(Me.lblAngle)
        Me.tabSummary.Controls.Add(Me.lblSourcePrompt)
        Me.tabSummary.Controls.Add(Me.lblBeam)
        Me.tabSummary.Controls.Add(Me.lblAnglePrompt)
        Me.tabSummary.Controls.Add(Me.lblType)
        Me.tabSummary.Controls.Add(Me.lblTypePrompt)
        Me.tabSummary.Controls.Add(Me.lblModel)
        Me.tabSummary.Controls.Add(Me.lblModelPrompt)
        Me.tabSummary.Controls.Add(Me.lblManufacturer)
        Me.tabSummary.Controls.Add(Me.lblManufacturerPrompt)
        Me.tabSummary.Controls.Add(Me.lblImagePrompt)
        Me.tabSummary.Location = New System.Drawing.Point(4, 22)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(889, 508)
        Me.tabSummary.TabIndex = 0
        Me.tabSummary.Text = "Summary"
        Me.tabSummary.UseVisualStyleBackColor = True
        '
        'lblNotesPrompt
        '
        Me.lblNotesPrompt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotesPrompt.AutoSize = True
        Me.lblNotesPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotesPrompt.Location = New System.Drawing.Point(556, 371)
        Me.lblNotesPrompt.Name = "lblNotesPrompt"
        Me.lblNotesPrompt.Size = New System.Drawing.Size(53, 16)
        Me.lblNotesPrompt.TabIndex = 45
        Me.lblNotesPrompt.Text = "Notes:"
        '
        'rtbNotes
        '
        Me.rtbNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbNotes.Location = New System.Drawing.Point(559, 391)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.ReadOnly = True
        Me.rtbNotes.Size = New System.Drawing.Size(314, 103)
        Me.rtbNotes.TabIndex = 44
        Me.rtbNotes.Text = ""
        '
        'lstEffects
        '
        Me.lstEffects.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstEffects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEffects.FormattingEnabled = True
        Me.lstEffects.ItemHeight = 16
        Me.lstEffects.Location = New System.Drawing.Point(308, 360)
        Me.lstEffects.Name = "lstEffects"
        Me.lstEffects.Size = New System.Drawing.Size(229, 132)
        Me.lstEffects.TabIndex = 43
        '
        'lstControl
        '
        Me.lstControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstControl.FormattingEnabled = True
        Me.lstControl.ItemHeight = 16
        Me.lstControl.Location = New System.Drawing.Point(308, 211)
        Me.lstControl.Name = "lstControl"
        Me.lstControl.Size = New System.Drawing.Size(229, 68)
        Me.lstControl.TabIndex = 42
        '
        'dgdGobos
        '
        Me.dgdGobos.AllowUserToAddRows = False
        Me.dgdGobos.AllowUserToDeleteRows = False
        Me.dgdGobos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdGobos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdGobos.Location = New System.Drawing.Point(559, 208)
        Me.dgdGobos.Name = "dgdGobos"
        Me.dgdGobos.RowHeadersWidth = 10
        Me.dgdGobos.Size = New System.Drawing.Size(314, 150)
        Me.dgdGobos.TabIndex = 41
        Me.dgdGobos.TabStop = False
        '
        'dgdColours
        '
        Me.dgdColours.AllowUserToAddRows = False
        Me.dgdColours.AllowUserToDeleteRows = False
        Me.dgdColours.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdColours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdColours.Location = New System.Drawing.Point(559, 30)
        Me.dgdColours.Name = "dgdColours"
        Me.dgdColours.RowHeadersWidth = 10
        Me.dgdColours.Size = New System.Drawing.Size(314, 150)
        Me.dgdColours.TabIndex = 40
        Me.dgdColours.TabStop = False
        '
        'lblEffectPrompt
        '
        Me.lblEffectPrompt.AutoSize = True
        Me.lblEffectPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEffectPrompt.Location = New System.Drawing.Point(305, 340)
        Me.lblEffectPrompt.Name = "lblEffectPrompt"
        Me.lblEffectPrompt.Size = New System.Drawing.Size(59, 16)
        Me.lblEffectPrompt.TabIndex = 22
        Me.lblEffectPrompt.Text = "Effects:"
        '
        'lblGoboPrompt
        '
        Me.lblGoboPrompt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoboPrompt.AutoSize = True
        Me.lblGoboPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoboPrompt.Location = New System.Drawing.Point(556, 188)
        Me.lblGoboPrompt.Name = "lblGoboPrompt"
        Me.lblGoboPrompt.Size = New System.Drawing.Size(58, 16)
        Me.lblGoboPrompt.TabIndex = 21
        Me.lblGoboPrompt.Text = "Gobos:"
        '
        'lblColourPrompt
        '
        Me.lblColourPrompt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColourPrompt.AutoSize = True
        Me.lblColourPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourPrompt.Location = New System.Drawing.Point(556, 10)
        Me.lblColourPrompt.Name = "lblColourPrompt"
        Me.lblColourPrompt.Size = New System.Drawing.Size(65, 16)
        Me.lblColourPrompt.TabIndex = 20
        Me.lblColourPrompt.Text = "Colours:"
        '
        'lblTPD
        '
        Me.lblTPD.AutoSize = True
        Me.lblTPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPD.Location = New System.Drawing.Point(305, 310)
        Me.lblTPD.Name = "lblTPD"
        Me.lblTPD.Size = New System.Drawing.Size(56, 16)
        Me.lblTPD.TabIndex = 19
        Me.lblTPD.Text = "Label20"
        '
        'lblTPDPrompt
        '
        Me.lblTPDPrompt.AutoSize = True
        Me.lblTPDPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPDPrompt.Location = New System.Drawing.Point(305, 293)
        Me.lblTPDPrompt.Name = "lblTPDPrompt"
        Me.lblTPDPrompt.Size = New System.Drawing.Size(134, 16)
        Me.lblTPDPrompt.TabIndex = 18
        Me.lblTPDPrompt.Text = "Total Power Draw:"
        '
        'lblBeamPrompt
        '
        Me.lblBeamPrompt.AutoSize = True
        Me.lblBeamPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeamPrompt.Location = New System.Drawing.Point(305, 10)
        Me.lblBeamPrompt.Name = "lblBeamPrompt"
        Me.lblBeamPrompt.Size = New System.Drawing.Size(116, 16)
        Me.lblBeamPrompt.TabIndex = 16
        Me.lblBeamPrompt.Text = "Optical System:"
        '
        'lblColourTemp
        '
        Me.lblColourTemp.AutoSize = True
        Me.lblColourTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourTemp.Location = New System.Drawing.Point(305, 158)
        Me.lblColourTemp.Name = "lblColourTemp"
        Me.lblColourTemp.Size = New System.Drawing.Size(56, 16)
        Me.lblColourTemp.TabIndex = 15
        Me.lblColourTemp.Text = "Label16"
        '
        'lblControlPrompt
        '
        Me.lblControlPrompt.AutoSize = True
        Me.lblControlPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlPrompt.Location = New System.Drawing.Point(305, 190)
        Me.lblControlPrompt.Name = "lblControlPrompt"
        Me.lblControlPrompt.Size = New System.Drawing.Size(131, 16)
        Me.lblControlPrompt.TabIndex = 14
        Me.lblControlPrompt.Text = "Control Protocols:"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.Location = New System.Drawing.Point(305, 110)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(56, 16)
        Me.lblSource.TabIndex = 13
        Me.lblSource.Text = "Label14"
        '
        'lblColourTempPrompt
        '
        Me.lblColourTempPrompt.AutoSize = True
        Me.lblColourTempPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourTempPrompt.Location = New System.Drawing.Point(305, 140)
        Me.lblColourTempPrompt.Name = "lblColourTempPrompt"
        Me.lblColourTempPrompt.Size = New System.Drawing.Size(146, 16)
        Me.lblColourTempPrompt.TabIndex = 12
        Me.lblColourTempPrompt.Text = "Open Colour Temp.:"
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle.Location = New System.Drawing.Point(305, 67)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(56, 16)
        Me.lblAngle.TabIndex = 11
        Me.lblAngle.Text = "Label12"
        '
        'lblSourcePrompt
        '
        Me.lblSourcePrompt.AutoSize = True
        Me.lblSourcePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSourcePrompt.Location = New System.Drawing.Point(305, 93)
        Me.lblSourcePrompt.Name = "lblSourcePrompt"
        Me.lblSourcePrompt.Size = New System.Drawing.Size(98, 16)
        Me.lblSourcePrompt.TabIndex = 10
        Me.lblSourcePrompt.Text = "Light Source:"
        '
        'lblBeam
        '
        Me.lblBeam.AutoSize = True
        Me.lblBeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeam.Location = New System.Drawing.Point(305, 27)
        Me.lblBeam.Name = "lblBeam"
        Me.lblBeam.Size = New System.Drawing.Size(56, 16)
        Me.lblBeam.TabIndex = 9
        Me.lblBeam.Text = "Label10"
        '
        'lblAnglePrompt
        '
        Me.lblAnglePrompt.AutoSize = True
        Me.lblAnglePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnglePrompt.Location = New System.Drawing.Point(305, 50)
        Me.lblAnglePrompt.Name = "lblAnglePrompt"
        Me.lblAnglePrompt.Size = New System.Drawing.Size(96, 16)
        Me.lblAnglePrompt.TabIndex = 8
        Me.lblAnglePrompt.Text = "Beam Angle:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(13, 438)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(49, 16)
        Me.lblType.TabIndex = 7
        Me.lblType.Text = "Label8"
        '
        'lblTypePrompt
        '
        Me.lblTypePrompt.AutoSize = True
        Me.lblTypePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypePrompt.Location = New System.Drawing.Point(13, 421)
        Me.lblTypePrompt.Name = "lblTypePrompt"
        Me.lblTypePrompt.Size = New System.Drawing.Size(48, 16)
        Me.lblTypePrompt.TabIndex = 6
        Me.lblTypePrompt.Text = "Type:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(13, 391)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(49, 16)
        Me.lblModel.TabIndex = 5
        Me.lblModel.Text = "Label6"
        '
        'lblModelPrompt
        '
        Me.lblModelPrompt.AutoSize = True
        Me.lblModelPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelPrompt.Location = New System.Drawing.Point(13, 374)
        Me.lblModelPrompt.Name = "lblModelPrompt"
        Me.lblModelPrompt.Size = New System.Drawing.Size(55, 16)
        Me.lblModelPrompt.TabIndex = 4
        Me.lblModelPrompt.Text = "Model:"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.Location = New System.Drawing.Point(13, 344)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(49, 16)
        Me.lblManufacturer.TabIndex = 3
        Me.lblManufacturer.Text = "Label4"
        '
        'lblManufacturerPrompt
        '
        Me.lblManufacturerPrompt.AutoSize = True
        Me.lblManufacturerPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturerPrompt.Location = New System.Drawing.Point(13, 327)
        Me.lblManufacturerPrompt.Name = "lblManufacturerPrompt"
        Me.lblManufacturerPrompt.Size = New System.Drawing.Size(101, 16)
        Me.lblManufacturerPrompt.TabIndex = 2
        Me.lblManufacturerPrompt.Text = "Manufacturer:"
        '
        'lblImagePrompt
        '
        Me.lblImagePrompt.AutoSize = True
        Me.lblImagePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagePrompt.Location = New System.Drawing.Point(13, 7)
        Me.lblImagePrompt.Name = "lblImagePrompt"
        Me.lblImagePrompt.Size = New System.Drawing.Size(55, 16)
        Me.lblImagePrompt.TabIndex = 0
        Me.lblImagePrompt.Text = "Image:"
        '
        'tabTabs
        '
        Me.tabTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTabs.Controls.Add(Me.tabSummary)
        Me.tabTabs.Controls.Add(Me.tabManual)
        Me.tabTabs.Location = New System.Drawing.Point(5, 4)
        Me.tabTabs.Name = "tabTabs"
        Me.tabTabs.SelectedIndex = 0
        Me.tabTabs.Size = New System.Drawing.Size(897, 534)
        Me.tabTabs.TabIndex = 0
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(16, 27)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(269, 283)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 24
        Me.picImage.TabStop = False
        '
        'frmFixtureInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 541)
        Me.Controls.Add(Me.tabTabs)
        Me.Name = "frmFixtureInfo"
        Me.Text = "*ASSIGN NAME OF CURRENT FIXTURE HERE*"
        Me.tabManual.ResumeLayout(False)
        Me.tabSummary.ResumeLayout(False)
        Me.tabSummary.PerformLayout()
        CType(Me.dgdGobos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdColours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTabs.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabManual As TabPage
    Friend WithEvents tabSummary As TabPage
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblEffectPrompt As Label
    Friend WithEvents lblGoboPrompt As Label
    Friend WithEvents lblColourPrompt As Label
    Friend WithEvents lblTPD As Label
    Friend WithEvents lblTPDPrompt As Label
    Friend WithEvents lblBeamPrompt As Label
    Friend WithEvents lblColourTemp As Label
    Friend WithEvents lblControlPrompt As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents lblColourTempPrompt As Label
    Friend WithEvents lblAngle As Label
    Friend WithEvents lblSourcePrompt As Label
    Friend WithEvents lblBeam As Label
    Friend WithEvents lblAnglePrompt As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblTypePrompt As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblModelPrompt As Label
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents lblManufacturerPrompt As Label
    Friend WithEvents lblImagePrompt As Label
    Friend WithEvents tabTabs As TabControl
    Friend WithEvents dgdGobos As DataGridView
    Friend WithEvents dgdColours As DataGridView
    Friend WithEvents lstEffects As ListBox
    Friend WithEvents lstControl As ListBox
    Friend WithEvents rtbNotes As RichTextBox
    Friend WithEvents lblNotesPrompt As Label
    Friend WithEvents webDocViewer As WebBrowser
    Friend WithEvents lstDocuments As ListBox
End Class
