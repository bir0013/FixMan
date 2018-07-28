<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventView
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
        Me.tabTabs = New System.Windows.Forms.TabControl()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.tabFixSheet = New System.Windows.Forms.TabPage()
        Me.tabTeam = New System.Windows.Forms.TabPage()
        Me.tabTimeline = New System.Windows.Forms.TabPage()
        Me.tabFiles = New System.Windows.Forms.TabPage()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tabTabs.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabTabs
        '
        Me.tabTabs.Controls.Add(Me.tabSummary)
        Me.tabTabs.Controls.Add(Me.tabFixSheet)
        Me.tabTabs.Controls.Add(Me.tabTeam)
        Me.tabTabs.Controls.Add(Me.tabTimeline)
        Me.tabTabs.Controls.Add(Me.tabFiles)
        Me.tabTabs.Location = New System.Drawing.Point(1, 3)
        Me.tabTabs.Name = "tabTabs"
        Me.tabTabs.SelectedIndex = 0
        Me.tabTabs.Size = New System.Drawing.Size(1144, 651)
        Me.tabTabs.TabIndex = 0
        '
        'tabSummary
        '
        Me.tabSummary.Controls.Add(Me.pnlSummary)
        Me.tabSummary.Location = New System.Drawing.Point(4, 22)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(1136, 625)
        Me.tabSummary.TabIndex = 0
        Me.tabSummary.Text = "Summary"
        Me.tabSummary.UseVisualStyleBackColor = True
        '
        'tabFixSheet
        '
        Me.tabFixSheet.Location = New System.Drawing.Point(4, 22)
        Me.tabFixSheet.Name = "tabFixSheet"
        Me.tabFixSheet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFixSheet.Size = New System.Drawing.Size(1136, 625)
        Me.tabFixSheet.TabIndex = 1
        Me.tabFixSheet.Text = "Fixture Sheet"
        Me.tabFixSheet.UseVisualStyleBackColor = True
        '
        'tabTeam
        '
        Me.tabTeam.Location = New System.Drawing.Point(4, 22)
        Me.tabTeam.Name = "tabTeam"
        Me.tabTeam.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTeam.Size = New System.Drawing.Size(937, 625)
        Me.tabTeam.TabIndex = 2
        Me.tabTeam.Text = "Team"
        Me.tabTeam.UseVisualStyleBackColor = True
        '
        'tabTimeline
        '
        Me.tabTimeline.Location = New System.Drawing.Point(4, 22)
        Me.tabTimeline.Name = "tabTimeline"
        Me.tabTimeline.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTimeline.Size = New System.Drawing.Size(937, 625)
        Me.tabTimeline.TabIndex = 3
        Me.tabTimeline.Text = "Timeline"
        Me.tabTimeline.UseVisualStyleBackColor = True
        '
        'tabFiles
        '
        Me.tabFiles.Location = New System.Drawing.Point(4, 22)
        Me.tabFiles.Name = "tabFiles"
        Me.tabFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFiles.Size = New System.Drawing.Size(937, 625)
        Me.tabFiles.TabIndex = 4
        Me.tabFiles.Text = "Files"
        Me.tabFiles.UseVisualStyleBackColor = True
        '
        'pnlSummary
        '
        Me.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSummary.Location = New System.Drawing.Point(6, 6)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Size = New System.Drawing.Size(365, 613)
        Me.pnlSummary.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(820, 656)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Event"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(901, 656)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Open Event"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(982, 656)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New Event"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1063, 656)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmEventView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 686)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.tabTabs)
        Me.Name = "frmEventView"
        Me.Text = "*ASSIGN NAME OF CURRENT EVENT HERE*"
        Me.tabTabs.ResumeLayout(False)
        Me.tabSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabTabs As TabControl
    Friend WithEvents tabSummary As TabPage
    Friend WithEvents tabFixSheet As TabPage
    Friend WithEvents tabTeam As TabPage
    Friend WithEvents tabTimeline As TabPage
    Friend WithEvents tabFiles As TabPage
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnClose As Button
End Class
