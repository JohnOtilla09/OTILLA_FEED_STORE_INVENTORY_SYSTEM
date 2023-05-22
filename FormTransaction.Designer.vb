<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaction
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        refreshBtn = New FontAwesome.Sharp.IconButton()
        deleteBtn = New Button()
        exportBtn = New Button()
        updateBtn = New Button()
        uploadBtn = New Button()
        searchButton = New FontAwesome.Sharp.IconButton()
        addBtn = New Button()
        searchTxt = New TextBox()
        Label5 = New Label()
        dgTransactionReport = New DataGridView()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(dgTransactionReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(refreshBtn)
        Panel1.Controls.Add(deleteBtn)
        Panel1.Controls.Add(exportBtn)
        Panel1.Controls.Add(updateBtn)
        Panel1.Controls.Add(uploadBtn)
        Panel1.Controls.Add(searchButton)
        Panel1.Controls.Add(addBtn)
        Panel1.Controls.Add(searchTxt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dgTransactionReport)
        Panel1.Location = New Point(-24, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1293, 648)
        Panel1.TabIndex = 17
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
        refreshBtn.Location = New Point(555, 83)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(116, 41)
        refreshBtn.TabIndex = 23
        refreshBtn.Text = "Refresh"
        refreshBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        deleteBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        deleteBtn.Location = New Point(728, 264)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(257, 65)
        deleteBtn.TabIndex = 22
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' exportBtn
        ' 
        exportBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        exportBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        exportBtn.Location = New Point(728, 406)
        exportBtn.Name = "exportBtn"
        exportBtn.Size = New Size(257, 65)
        exportBtn.TabIndex = 19
        exportBtn.Text = "Export"
        exportBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        updateBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        updateBtn.Location = New Point(728, 193)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(257, 65)
        updateBtn.TabIndex = 21
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' uploadBtn
        ' 
        uploadBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        uploadBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        uploadBtn.Location = New Point(728, 335)
        uploadBtn.Name = "uploadBtn"
        uploadBtn.Size = New Size(257, 65)
        uploadBtn.TabIndex = 20
        uploadBtn.Text = "Import"
        uploadBtn.UseVisualStyleBackColor = False
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = SystemColors.ActiveCaptionText
        searchButton.FlatAppearance.BorderSize = 0
        searchButton.FlatStyle = FlatStyle.Flat
        searchButton.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        searchButton.ForeColor = Color.White
        searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        searchButton.IconColor = Color.White
        searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        searchButton.IconSize = 25
        searchButton.Location = New Point(316, 83)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(116, 41)
        searchButton.TabIndex = 19
        searchButton.Text = "Search"
        searchButton.TextImageRelation = TextImageRelation.ImageBeforeText
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' addBtn
        ' 
        addBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        addBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        addBtn.Location = New Point(728, 122)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(257, 65)
        addBtn.TabIndex = 16
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' searchTxt
        ' 
        searchTxt.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        searchTxt.Location = New Point(75, 87)
        searchTxt.Name = "searchTxt"
        searchTxt.PlaceholderText = "Search date..."
        searchTxt.Size = New Size(235, 34)
        searchTxt.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label5.Location = New Point(420, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(262, 36)
        Label5.TabIndex = 12
        Label5.Text = "Customer Transaction"
        ' 
        ' dgTransactionReport
        ' 
        dgTransactionReport.BackgroundColor = Color.White
        dgTransactionReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgTransactionReport.DefaultCellStyle = DataGridViewCellStyle1
        dgTransactionReport.Location = New Point(75, 142)
        dgTransactionReport.Name = "dgTransactionReport"
        dgTransactionReport.RowHeadersWidth = 51
        dgTransactionReport.RowTemplate.Height = 29
        dgTransactionReport.Size = New Size(596, 415)
        dgTransactionReport.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label2.Location = New Point(41, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 27)
        Label2.TabIndex = 16
        Label2.Text = "Transaction"
        ' 
        ' FormTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1011, 673)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormTransaction"
        Text = "FormTransaction"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgTransactionReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgTransactionReport As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents searchButton As FontAwesome.Sharp.IconButton
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents uploadBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents exportBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents deleteBtn As Button
End Class
