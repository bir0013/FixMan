<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.txtSearchTerm = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgdSearchResult = New System.Windows.Forms.DataGridView()
        Me.FixImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FixManufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixModel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixOptics = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixPower = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ttpMain = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgdSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearchTerm
        '
        Me.txtSearchTerm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearchTerm.Location = New System.Drawing.Point(16, 18)
        Me.txtSearchTerm.Name = "txtSearchTerm"
        Me.txtSearchTerm.Size = New System.Drawing.Size(250, 20)
        Me.txtSearchTerm.TabIndex = 1
        Me.ttpMain.SetToolTip(Me.txtSearchTerm, "This searches all fields that exist in the display grid that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you can see in the " &
        "storeroom view window.")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Location = New System.Drawing.Point(272, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.ttpMain.SetToolTip(Me.btnSearch, "This searches all fields that exist in the display grid that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you can see in the " &
        "storeroom view window." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgdSearchResult
        '
        Me.dgdSearchResult.AllowUserToAddRows = False
        Me.dgdSearchResult.AllowUserToDeleteRows = False
        Me.dgdSearchResult.AllowUserToOrderColumns = True
        Me.dgdSearchResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdSearchResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FixImage, Me.FixManufacturer, Me.FixModel, Me.FixSource, Me.FixType, Me.FixOptics, Me.FixPower, Me.FixQty})
        Me.dgdSearchResult.Location = New System.Drawing.Point(12, 134)
        Me.dgdSearchResult.Name = "dgdSearchResult"
        Me.dgdSearchResult.RowTemplate.Height = 55
        Me.dgdSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdSearchResult.Size = New System.Drawing.Size(806, 374)
        Me.dgdSearchResult.TabIndex = 3
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search Storeroom"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSearchTerm)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Location = New System.Drawing.Point(234, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 59)
        Me.Panel1.TabIndex = 6
        '
        'ttpMain
        '
        Me.ttpMain.ToolTipTitle = "Info"
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 520)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdSearchResult)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Storeroom"
        CType(Me.dgdSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchTerm As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgdSearchResult As DataGridView
    Friend WithEvents FixImage As DataGridViewImageColumn
    Friend WithEvents FixManufacturer As DataGridViewTextBoxColumn
    Friend WithEvents FixModel As DataGridViewTextBoxColumn
    Friend WithEvents FixSource As DataGridViewTextBoxColumn
    Friend WithEvents FixType As DataGridViewTextBoxColumn
    Friend WithEvents FixOptics As DataGridViewTextBoxColumn
    Friend WithEvents FixPower As DataGridViewTextBoxColumn
    Friend WithEvents FixQty As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ttpMain As ToolTip
End Class
