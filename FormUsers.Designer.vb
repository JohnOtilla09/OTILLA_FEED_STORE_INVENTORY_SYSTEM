<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsers
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exportBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.dgUserTable = New System.Windows.Forms.DataGridView()
        Me.searchButton = New FontAwesome.Sharp.IconButton()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgUserTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.exportBtn)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.addBtn)
        Me.Panel1.Controls.Add(Me.dgUserTable)
        Me.Panel1.Controls.Add(Me.searchButton)
        Me.Panel1.Controls.Add(Me.searchTxt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-22, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 673)
        Me.Panel1.TabIndex = 19
        '
        'exportBtn
        '
        Me.exportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.exportBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.exportBtn.Location = New System.Drawing.Point(689, 363)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(257, 65)
        Me.exportBtn.TabIndex = 24
        Me.exportBtn.Text = "Export"
        Me.exportBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(689, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(257, 65)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(689, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(257, 65)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.addBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addBtn.Location = New System.Drawing.Point(689, 150)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(257, 65)
        Me.addBtn.TabIndex = 21
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'dgUserTable
        '
        Me.dgUserTable.BackgroundColor = System.Drawing.Color.White
        Me.dgUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUserTable.Location = New System.Drawing.Point(63, 150)
        Me.dgUserTable.Name = "dgUserTable"
        Me.dgUserTable.RowHeadersWidth = 51
        Me.dgUserTable.RowTemplate.Height = 29
        Me.dgUserTable.Size = New System.Drawing.Size(575, 428)
        Me.dgUserTable.TabIndex = 20
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchButton.FlatAppearance.BorderSize = 0
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchButton.ForeColor = System.Drawing.Color.White
        Me.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.searchButton.IconColor = System.Drawing.Color.White
        Me.searchButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchButton.IconSize = 25
        Me.searchButton.Location = New System.Drawing.Point(304, 92)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(116, 41)
        Me.searchButton.TabIndex = 19
        Me.searchButton.Text = "Search"
        Me.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'searchTxt
        '
        Me.searchTxt.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchTxt.Location = New System.Drawing.Point(63, 99)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(235, 34)
        Me.searchTxt.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(404, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 36)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "User Accounts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(43, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 27)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Users"
        '
        'FormUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(993, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUsers"
        Me.Text = "FormUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgUserTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchButton As FontAwesome.Sharp.IconButton
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents dgUserTable As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents exportBtn As Button
End Class
