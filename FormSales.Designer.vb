<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSales
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label5 = New Label()
        dgSalesTable = New DataGridView()
        Label2 = New Label()
        Panel1 = New Panel()
        exportBtn = New Button()
        searchButton = New FontAwesome.Sharp.IconButton()
        searchTxt = New TextBox()
        refreshBtn = New FontAwesome.Sharp.IconButton()
        CType(dgSalesTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(45, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 23)
        Label1.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label5.Location = New Point(454, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(169, 36)
        Label5.TabIndex = 12
        Label5.Text = "Product Sales"
        ' 
        ' dgSalesTable
        ' 
        dgSalesTable.BackgroundColor = Color.White
        dgSalesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgSalesTable.DefaultCellStyle = DataGridViewCellStyle2
        dgSalesTable.Location = New Point(66, 141)
        dgSalesTable.Name = "dgSalesTable"
        dgSalesTable.RowHeadersWidth = 51
        dgSalesTable.RowTemplate.Height = 29
        dgSalesTable.Size = New Size(570, 441)
        dgSalesTable.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label2.Location = New Point(45, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 27)
        Label2.TabIndex = 9
        Label2.Text = "Sales"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(refreshBtn)
        Panel1.Controls.Add(exportBtn)
        Panel1.Controls.Add(searchButton)
        Panel1.Controls.Add(searchTxt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dgSalesTable)
        Panel1.Location = New Point(-23, 61)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1096, 648)
        Panel1.TabIndex = 13
        ' 
        ' exportBtn
        ' 
        exportBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        exportBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        exportBtn.Location = New Point(697, 141)
        exportBtn.Name = "exportBtn"
        exportBtn.Size = New Size(257, 65)
        exportBtn.TabIndex = 18
        exportBtn.Text = "Export"
        exportBtn.UseVisualStyleBackColor = False
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
        searchButton.Location = New Point(307, 83)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(116, 41)
        searchButton.TabIndex = 14
        searchButton.Text = "Search"
        searchButton.TextImageRelation = TextImageRelation.ImageBeforeText
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' searchTxt
        ' 
        searchTxt.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        searchTxt.Location = New Point(66, 90)
        searchTxt.Name = "searchTxt"
        searchTxt.PlaceholderText = "Product name..."
        searchTxt.Size = New Size(235, 34)
        searchTxt.TabIndex = 13
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
        refreshBtn.Location = New Point(507, 94)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(116, 41)
        refreshBtn.TabIndex = 20
        refreshBtn.Text = "Refresh"
        refreshBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' FormSales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1011, 673)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormSales"
        Text = "FormSales"
        CType(dgSalesTable, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgSalesTable As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents searchButton As FontAwesome.Sharp.IconButton
    Friend WithEvents exportBtn As Button
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
End Class
