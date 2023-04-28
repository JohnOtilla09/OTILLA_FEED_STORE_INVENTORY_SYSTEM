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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgSalesTable = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exportBtn = New System.Windows.Forms.Button()
        Me.searchButton = New FontAwesome.Sharp.IconButton()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        CType(Me.dgSalesTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(45, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(454, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 36)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Product Sales"
        '
        'dgSalesTable
        '
        Me.dgSalesTable.BackgroundColor = System.Drawing.Color.White
        Me.dgSalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSalesTable.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgSalesTable.Location = New System.Drawing.Point(66, 141)
        Me.dgSalesTable.Name = "dgSalesTable"
        Me.dgSalesTable.RowHeadersWidth = 51
        Me.dgSalesTable.RowTemplate.Height = 29
        Me.dgSalesTable.Size = New System.Drawing.Size(570, 441)
        Me.dgSalesTable.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sales"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.exportBtn)
        Me.Panel1.Controls.Add(Me.searchButton)
        Me.Panel1.Controls.Add(Me.searchTxt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgSalesTable)
        Me.Panel1.Location = New System.Drawing.Point(-23, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 648)
        Me.Panel1.TabIndex = 13
        '
        'exportBtn
        '
        Me.exportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.exportBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.exportBtn.Location = New System.Drawing.Point(697, 141)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(257, 65)
        Me.exportBtn.TabIndex = 18
        Me.exportBtn.Text = "Export"
        Me.exportBtn.UseVisualStyleBackColor = False
        '
        'searchButton
        '
        Me.searchButton.FlatAppearance.BorderSize = 0
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchButton.ForeColor = System.Drawing.Color.White
        Me.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.searchButton.IconColor = System.Drawing.Color.White
        Me.searchButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchButton.IconSize = 25
        Me.searchButton.Location = New System.Drawing.Point(307, 83)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(116, 41)
        Me.searchButton.TabIndex = 14
        Me.searchButton.Text = "Search"
        Me.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTxt
        '
        Me.searchTxt.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchTxt.Location = New System.Drawing.Point(66, 90)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(235, 34)
        Me.searchTxt.TabIndex = 13
        '
        'FormSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1011, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSales"
        Me.Text = "FormSales"
        CType(Me.dgSalesTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgSalesTable As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents searchButton As FontAwesome.Sharp.IconButton
    Friend WithEvents exportBtn As Button
End Class
