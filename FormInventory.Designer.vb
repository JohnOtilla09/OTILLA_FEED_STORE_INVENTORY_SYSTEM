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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        exportBtn = New Button()
        refreshBtn = New FontAwesome.Sharp.IconButton()
        deleteBtn = New Button()
        backUpBtn = New Button()
        searchButton = New FontAwesome.Sharp.IconButton()
        addBtn = New Button()
        searchTxt = New TextBox()
        updateBtn = New Button()
        Label5 = New Label()
        dgInventoryTable = New DataGridView()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(dgInventoryTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(exportBtn)
        Panel1.Controls.Add(refreshBtn)
        Panel1.Controls.Add(deleteBtn)
        Panel1.Controls.Add(backUpBtn)
        Panel1.Controls.Add(searchButton)
        Panel1.Controls.Add(addBtn)
        Panel1.Controls.Add(searchTxt)
        Panel1.Controls.Add(updateBtn)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dgInventoryTable)
        Panel1.Location = New Point(-23, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1293, 648)
        Panel1.TabIndex = 15
        ' 
        ' exportBtn
        ' 
        exportBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        exportBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        exportBtn.Location = New Point(729, 260)
        exportBtn.Name = "exportBtn"
        exportBtn.Size = New Size(257, 65)
        exportBtn.TabIndex = 20
        exportBtn.Text = "Export"
        exportBtn.UseVisualStyleBackColor = False
        ' 
        ' refreshBtn
        ' 
        refreshBtn.Cursor = Cursors.Hand
        refreshBtn.FlatAppearance.BorderSize = 0
        refreshBtn.FlatStyle = FlatStyle.Flat
        refreshBtn.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        refreshBtn.ForeColor = Color.White
        refreshBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate
        refreshBtn.IconColor = Color.White
        refreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        refreshBtn.IconSize = 25
        refreshBtn.Location = New Point(576, 86)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(116, 41)
        refreshBtn.TabIndex = 19
        refreshBtn.Text = "Refresh"
        refreshBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        deleteBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        deleteBtn.Location = New Point(729, 331)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(257, 65)
        deleteBtn.TabIndex = 18
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' backUpBtn
        ' 
        backUpBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        backUpBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        backUpBtn.Location = New Point(729, 402)
        backUpBtn.Name = "backUpBtn"
        backUpBtn.Size = New Size(257, 65)
        backUpBtn.TabIndex = 18
        backUpBtn.Text = "Backup Database"
        backUpBtn.UseVisualStyleBackColor = False
        ' 
        ' searchButton
        ' 
        searchButton.FlatAppearance.BorderSize = 0
        searchButton.FlatStyle = FlatStyle.Flat
        searchButton.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        searchButton.ForeColor = Color.White
        searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        searchButton.IconColor = Color.White
        searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        searchButton.IconSize = 25
        searchButton.Location = New Point(304, 89)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(116, 41)
        searchButton.TabIndex = 17
        searchButton.Text = "Search"
        searchButton.TextImageRelation = TextImageRelation.ImageBeforeText
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' addBtn
        ' 
        addBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        addBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        addBtn.Location = New Point(729, 118)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(257, 65)
        addBtn.TabIndex = 16
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' searchTxt
        ' 
        searchTxt.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        searchTxt.Location = New Point(63, 93)
        searchTxt.Name = "searchTxt"
        searchTxt.PlaceholderText = "Search products..."
        searchTxt.Size = New Size(235, 34)
        searchTxt.TabIndex = 16
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        updateBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        updateBtn.Location = New Point(729, 189)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(257, 65)
        updateBtn.TabIndex = 15
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label5.Location = New Point(430, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(222, 36)
        Label5.TabIndex = 12
        Label5.Text = "Product Inventory"
        ' 
        ' dgInventoryTable
        ' 
        dgInventoryTable.BackgroundColor = Color.White
        dgInventoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgInventoryTable.DefaultCellStyle = DataGridViewCellStyle1
        dgInventoryTable.Location = New Point(63, 136)
        dgInventoryTable.Name = "dgInventoryTable"
        dgInventoryTable.RowHeadersWidth = 51
        dgInventoryTable.RowTemplate.Height = 29
        dgInventoryTable.Size = New Size(629, 444)
        dgInventoryTable.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label2.Location = New Point(42, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 27)
        Label2.TabIndex = 14
        Label2.Text = "Inventory"
        ' 
        ' FormInventory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1011, 673)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormInventory"
        RightToLeftLayout = True
        Text = "FormInventory"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgInventoryTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents deleteBtn As Button
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents exportBtn As Button
End Class
