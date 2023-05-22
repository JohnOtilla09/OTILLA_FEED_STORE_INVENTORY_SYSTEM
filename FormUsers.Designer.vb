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
        Panel1 = New Panel()
        refreshBtn = New FontAwesome.Sharp.IconButton()
        exportBtn = New Button()
        deleteBtn = New Button()
        updateBtn = New Button()
        dgUserTable = New DataGridView()
        searchButton = New FontAwesome.Sharp.IconButton()
        searchTxt = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(dgUserTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(refreshBtn)
        Panel1.Controls.Add(exportBtn)
        Panel1.Controls.Add(deleteBtn)
        Panel1.Controls.Add(updateBtn)
        Panel1.Controls.Add(dgUserTable)
        Panel1.Controls.Add(searchButton)
        Panel1.Controls.Add(searchTxt)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(-22, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1011, 673)
        Panel1.TabIndex = 19
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
        refreshBtn.Location = New Point(522, 92)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(116, 41)
        refreshBtn.TabIndex = 25
        refreshBtn.Text = "Refresh"
        refreshBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' exportBtn
        ' 
        exportBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        exportBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        exportBtn.Location = New Point(693, 292)
        exportBtn.Name = "exportBtn"
        exportBtn.Size = New Size(257, 65)
        exportBtn.TabIndex = 24
        exportBtn.Text = "Export"
        exportBtn.UseVisualStyleBackColor = False
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        deleteBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        deleteBtn.Location = New Point(693, 221)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(257, 65)
        deleteBtn.TabIndex = 23
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        updateBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        updateBtn.Location = New Point(693, 150)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(257, 65)
        updateBtn.TabIndex = 22
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' dgUserTable
        ' 
        dgUserTable.BackgroundColor = Color.White
        dgUserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgUserTable.Location = New Point(63, 150)
        dgUserTable.Name = "dgUserTable"
        dgUserTable.RowHeadersWidth = 51
        dgUserTable.RowTemplate.Height = 29
        dgUserTable.Size = New Size(575, 428)
        dgUserTable.TabIndex = 20
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
        searchButton.Location = New Point(304, 92)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(116, 41)
        searchButton.TabIndex = 19
        searchButton.Text = "Search"
        searchButton.TextImageRelation = TextImageRelation.ImageBeforeText
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' searchTxt
        ' 
        searchTxt.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        searchTxt.Location = New Point(63, 99)
        searchTxt.Name = "searchTxt"
        searchTxt.Size = New Size(235, 34)
        searchTxt.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label5.Location = New Point(404, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(169, 36)
        Label5.TabIndex = 12
        Label5.Text = "User Accounts"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label2.Location = New Point(43, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 27)
        Label2.TabIndex = 18
        Label2.Text = "Users"
        ' 
        ' FormUsers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(993, 651)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormUsers"
        Text = "FormUsers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgUserTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchButton As FontAwesome.Sharp.IconButton
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents dgUserTable As DataGridView
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents exportBtn As Button
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
End Class
