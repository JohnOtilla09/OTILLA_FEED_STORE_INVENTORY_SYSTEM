<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLandingPage
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
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.usersButton = New FontAwesome.Sharp.IconButton()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.logoutButton = New FontAwesome.Sharp.IconButton()
        Me.transactionButton = New FontAwesome.Sharp.IconButton()
        Me.inventoryButton = New FontAwesome.Sharp.IconButton()
        Me.salesButton = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dashboardButton = New FontAwesome.Sharp.IconButton()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SidePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.usersButton)
        Me.SidePanel.Controls.Add(Me.leftPanel)
        Me.SidePanel.Controls.Add(Me.logoutButton)
        Me.SidePanel.Controls.Add(Me.transactionButton)
        Me.SidePanel.Controls.Add(Me.inventoryButton)
        Me.SidePanel.Controls.Add(Me.salesButton)
        Me.SidePanel.Controls.Add(Me.Panel2)
        Me.SidePanel.Controls.Add(Me.dashboardButton)
        Me.SidePanel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.SidePanel.Location = New System.Drawing.Point(-7, -4)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(225, 757)
        Me.SidePanel.TabIndex = 0
        '
        'usersButton
        '
        Me.usersButton.FlatAppearance.BorderSize = 0
        Me.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersButton.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.usersButton.ForeColor = System.Drawing.Color.White
        Me.usersButton.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.usersButton.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.usersButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.usersButton.IconSize = 35
        Me.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usersButton.Location = New System.Drawing.Point(16, 318)
        Me.usersButton.Name = "usersButton"
        Me.usersButton.Size = New System.Drawing.Size(203, 65)
        Me.usersButton.TabIndex = 6
        Me.usersButton.Text = "Users"
        Me.usersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.usersButton.UseVisualStyleBackColor = True
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.leftPanel.Location = New System.Drawing.Point(4, 16)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(14, 65)
        Me.leftPanel.TabIndex = 0
        '
        'logoutButton
        '
        Me.logoutButton.FlatAppearance.BorderSize = 0
        Me.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logoutButton.ForeColor = System.Drawing.Color.White
        Me.logoutButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.logoutButton.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.logoutButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logoutButton.IconSize = 35
        Me.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutButton.Location = New System.Drawing.Point(19, 701)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(203, 53)
        Me.logoutButton.TabIndex = 1
        Me.logoutButton.Text = "Logout"
        Me.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'transactionButton
        '
        Me.transactionButton.FlatAppearance.BorderSize = 0
        Me.transactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.transactionButton.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.transactionButton.ForeColor = System.Drawing.Color.White
        Me.transactionButton.IconChar = FontAwesome.Sharp.IconChar.Handshake
        Me.transactionButton.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.transactionButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.transactionButton.IconSize = 35
        Me.transactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.transactionButton.Location = New System.Drawing.Point(16, 247)
        Me.transactionButton.Name = "transactionButton"
        Me.transactionButton.Size = New System.Drawing.Size(203, 65)
        Me.transactionButton.TabIndex = 2
        Me.transactionButton.Text = "Transaction"
        Me.transactionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.transactionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.transactionButton.UseVisualStyleBackColor = True
        '
        'inventoryButton
        '
        Me.inventoryButton.FlatAppearance.BorderSize = 0
        Me.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inventoryButton.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.inventoryButton.ForeColor = System.Drawing.Color.White
        Me.inventoryButton.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.inventoryButton.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.inventoryButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.inventoryButton.IconSize = 35
        Me.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventoryButton.Location = New System.Drawing.Point(16, 170)
        Me.inventoryButton.Name = "inventoryButton"
        Me.inventoryButton.Size = New System.Drawing.Size(203, 65)
        Me.inventoryButton.TabIndex = 3
        Me.inventoryButton.Text = "Inventory"
        Me.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.inventoryButton.UseVisualStyleBackColor = True
        '
        'salesButton
        '
        Me.salesButton.FlatAppearance.BorderSize = 0
        Me.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salesButton.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.salesButton.ForeColor = System.Drawing.Color.White
        Me.salesButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.salesButton.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.salesButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.salesButton.IconSize = 35
        Me.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salesButton.Location = New System.Drawing.Point(16, 93)
        Me.salesButton.Name = "salesButton"
        Me.salesButton.Size = New System.Drawing.Size(203, 65)
        Me.salesButton.TabIndex = 4
        Me.salesButton.Text = "Sales"
        Me.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.salesButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(371, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1071, 59)
        Me.Panel2.TabIndex = 1
        '
        'dashboardButton
        '
        Me.dashboardButton.FlatAppearance.BorderSize = 0
        Me.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardButton.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dashboardButton.ForeColor = System.Drawing.Color.White
        Me.dashboardButton.IconChar = FontAwesome.Sharp.IconChar.ChartColumn
        Me.dashboardButton.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.dashboardButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.dashboardButton.IconSize = 35
        Me.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardButton.Location = New System.Drawing.Point(16, 16)
        Me.dashboardButton.Name = "dashboardButton"
        Me.dashboardButton.Size = New System.Drawing.Size(203, 65)
        Me.dashboardButton.TabIndex = 0
        Me.dashboardButton.Text = "Dashboard"
        Me.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dashboardButton.UseVisualStyleBackColor = True
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.Location = New System.Drawing.Point(218, 42)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1019, 711)
        Me.PanelContainer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(236, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OTILLA FEED STORE INVENTORY SYSTEM"
        '
        'FormLandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 754)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.SidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FormLandingPage"
        Me.Text = "Dashboard"
        Me.SidePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SidePanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents logoutButton As FontAwesome.Sharp.IconButton
    Friend WithEvents transactionButton As FontAwesome.Sharp.IconButton
    Friend WithEvents inventoryButton As FontAwesome.Sharp.IconButton
    Friend WithEvents salesButton As FontAwesome.Sharp.IconButton
    Friend WithEvents dashboardButton As FontAwesome.Sharp.IconButton
    Friend WithEvents leftPanel As Panel
    Friend WithEvents usersButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
End Class
