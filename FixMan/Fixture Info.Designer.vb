﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lstEffects = New System.Windows.Forms.ListBox()
        Me.lstControl = New System.Windows.Forms.ListBox()
        Me.dgdGobos = New System.Windows.Forms.DataGridView()
        Me.dgdColours = New System.Windows.Forms.DataGridView()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabTabs = New System.Windows.Forms.TabControl()
        Me.lstDocuments = New System.Windows.Forms.ListBox()
        Me.tabManual.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        CType(Me.dgdGobos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdColours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabManual
        '
        Me.tabManual.Controls.Add(Me.lstDocuments)
        Me.tabManual.Controls.Add(Me.WebBrowser1)
        Me.tabManual.Location = New System.Drawing.Point(4, 22)
        Me.tabManual.Name = "tabManual"
        Me.tabManual.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManual.Size = New System.Drawing.Size(889, 508)
        Me.tabManual.TabIndex = 4
        Me.tabManual.Text = "Documentation"
        Me.tabManual.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(722, 512)
        Me.WebBrowser1.TabIndex = 0
        '
        'tabSummary
        '
        Me.tabSummary.Controls.Add(Me.Label2)
        Me.tabSummary.Controls.Add(Me.RichTextBox1)
        Me.tabSummary.Controls.Add(Me.lstEffects)
        Me.tabSummary.Controls.Add(Me.lstControl)
        Me.tabSummary.Controls.Add(Me.dgdGobos)
        Me.tabSummary.Controls.Add(Me.dgdColours)
        Me.tabSummary.Controls.Add(Me.picImage)
        Me.tabSummary.Controls.Add(Me.Label23)
        Me.tabSummary.Controls.Add(Me.Label22)
        Me.tabSummary.Controls.Add(Me.Label21)
        Me.tabSummary.Controls.Add(Me.Label20)
        Me.tabSummary.Controls.Add(Me.Label19)
        Me.tabSummary.Controls.Add(Me.Label17)
        Me.tabSummary.Controls.Add(Me.Label16)
        Me.tabSummary.Controls.Add(Me.Label15)
        Me.tabSummary.Controls.Add(Me.Label14)
        Me.tabSummary.Controls.Add(Me.Label13)
        Me.tabSummary.Controls.Add(Me.Label12)
        Me.tabSummary.Controls.Add(Me.Label11)
        Me.tabSummary.Controls.Add(Me.Label10)
        Me.tabSummary.Controls.Add(Me.Label9)
        Me.tabSummary.Controls.Add(Me.Label8)
        Me.tabSummary.Controls.Add(Me.Label7)
        Me.tabSummary.Controls.Add(Me.Label6)
        Me.tabSummary.Controls.Add(Me.Label5)
        Me.tabSummary.Controls.Add(Me.Label4)
        Me.tabSummary.Controls.Add(Me.Label3)
        Me.tabSummary.Controls.Add(Me.Label1)
        Me.tabSummary.Location = New System.Drawing.Point(4, 22)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(889, 508)
        Me.tabSummary.TabIndex = 0
        Me.tabSummary.Text = "Summary"
        Me.tabSummary.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Notes:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(559, 391)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(314, 103)
        Me.RichTextBox1.TabIndex = 44
        Me.RichTextBox1.Text = ""
        '
        'lstEffects
        '
        Me.lstEffects.FormattingEnabled = True
        Me.lstEffects.Location = New System.Drawing.Point(308, 360)
        Me.lstEffects.Name = "lstEffects"
        Me.lstEffects.Size = New System.Drawing.Size(229, 134)
        Me.lstEffects.TabIndex = 43
        '
        'lstControl
        '
        Me.lstControl.FormattingEnabled = True
        Me.lstControl.Location = New System.Drawing.Point(308, 211)
        Me.lstControl.Name = "lstControl"
        Me.lstControl.Size = New System.Drawing.Size(229, 69)
        Me.lstControl.TabIndex = 42
        '
        'dgdGobos
        '
        Me.dgdGobos.AllowUserToAddRows = False
        Me.dgdGobos.AllowUserToDeleteRows = False
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
        Me.dgdColours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdColours.Location = New System.Drawing.Point(559, 30)
        Me.dgdColours.Name = "dgdColours"
        Me.dgdColours.RowHeadersWidth = 10
        Me.dgdColours.Size = New System.Drawing.Size(314, 150)
        Me.dgdColours.TabIndex = 40
        Me.dgdColours.TabStop = False
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(16, 27)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(269, 283)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 24
        Me.picImage.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(305, 344)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Effects:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(556, 192)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Gobos:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(556, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Colours:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(305, 310)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Label20"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(305, 297)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Total Power Draw:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(305, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Beam Type:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(305, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(305, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Control Protocols:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(305, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(305, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Open Colour Temp.:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(305, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(305, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Light Source:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(305, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(305, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Beam Angle:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 438)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Model:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Manufacturer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Image:"
        '
        'tabTabs
        '
        Me.tabTabs.Controls.Add(Me.tabSummary)
        Me.tabTabs.Controls.Add(Me.tabManual)
        Me.tabTabs.Location = New System.Drawing.Point(5, 4)
        Me.tabTabs.Name = "tabTabs"
        Me.tabTabs.SelectedIndex = 0
        Me.tabTabs.Size = New System.Drawing.Size(897, 534)
        Me.tabTabs.TabIndex = 0
        '
        'lstDocuments
        '
        Me.lstDocuments.FormattingEnabled = True
        Me.lstDocuments.Location = New System.Drawing.Point(723, 0)
        Me.lstDocuments.Name = "lstDocuments"
        Me.lstDocuments.Size = New System.Drawing.Size(166, 511)
        Me.lstDocuments.TabIndex = 1
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
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabManual As TabPage
    Friend WithEvents tabSummary As TabPage
    Friend WithEvents picImage As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tabTabs As TabControl
    Friend WithEvents dgdGobos As DataGridView
    Friend WithEvents dgdColours As DataGridView
    Friend WithEvents lstEffects As ListBox
    Friend WithEvents lstControl As ListBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents lstDocuments As ListBox
End Class
