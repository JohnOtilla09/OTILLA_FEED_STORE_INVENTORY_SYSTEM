<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventory
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.backUpBtn = New System.Windows.Forms.Button()
        Me.searchButton = New FontAwesome.Sharp.IconButton()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgInventoryTable = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgInventoryTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.backUpBtn)
        Me.Panel1.Controls.Add(Me.searchButton)
        Me.Panel1.Controls.Add(Me.addBtn)
        Me.Panel1.Controls.Add(Me.searchTxt)
        Me.Panel1.Controls.Add(Me.updateBtn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgInventoryTable)
        Me.Panel1.Location = New System.Drawing.Point(-23, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1293, 648)
        Me.Panel1.TabIndex = 15
        '
        'backUpBtn
        '
        Me.backUpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.backUpBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.backUpBtn.Location = New System.Drawing.Point(729, 260)
        Me.backUpBtn.Name = "backUpBtn"
        Me.backUpBtn.Size = New System.Drawing.Size(257, 65)
        Me.backUpBtn.TabIndex = 18
        Me.backUpBtn.Text = "Backup Database"
        Me.backUpBtn.UseVisualStyleBackColor = False
        '
        'searchButton
        '
        Me.searchButton.FlatAppearance.BorderSize = 0
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.searchButton.IconColor = System.Drawing.Color.Black
        Me.searchButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchButton.IconSize = 25
        Me.searchButton.Location = New System.Drawing.Point(397, 68)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(116, 41)
        Me.searchButton.TabIndex = 17
        Me.searchButton.Text = "Search"
        Me.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.addBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addBtn.Location = New System.Drawing.Point(729, 118)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(257, 65)
        Me.addBtn.TabIndex = 16
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'searchTxt
        '
        Me.searchTxt.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchTxt.Location = New System.Drawing.Point(156, 72)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(235, 34)
        Me.searchTxt.TabIndex = 16
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.updateBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.updateBtn.Location = New System.Drawing.Point(729, 189)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(257, 65)
        Me.updateBtn.TabIndex = 15
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(430, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Product Inventory"
        '
        'dgInventoryTable
        '
        Me.dgInventoryTable.BackgroundColor = System.Drawing.Color.White
        Me.dgInventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInventoryTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgInventoryTable.Location = New System.Drawing.Point(156, 118)
        Me.dgInventoryTable.Name = "dgInventoryTable"
        Me.dgInventoryTable.RowHeadersWidth = 51
        Me.dgInventoryTable.RowTemplate.Height = 29
        Me.dgInventoryTable.Size = New System.Drawing.Size(536, 463)
        Me.dgInventoryTable.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Inventory"
        '
        'FormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1011, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInventory"
        Me.Text = "FormInventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgInventoryTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents dgInventoryTable As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents searchButton As FontAwesome.Sharp.IconButton
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents backUpBtn As Button
End Class
