<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddProduct
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prodTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quantityTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.typeTxt = New System.Windows.Forms.TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(442, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Product"
        '
        'prodTxt
        '
        Me.prodTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.prodTxt.Location = New System.Drawing.Point(554, 117)
        Me.prodTxt.Name = "prodTxt"
        Me.prodTxt.PlaceholderText = "Enter product"
        Me.prodTxt.Size = New System.Drawing.Size(231, 30)
        Me.prodTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(442, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product"
        '
        'Label3
        '
        Me.Label3.AccessibleName = ""
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(442, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(442, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantity"
        '
        'quantityTxt
        '
        Me.quantityTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.quantityTxt.Location = New System.Drawing.Point(554, 246)
        Me.quantityTxt.Name = "quantityTxt"
        Me.quantityTxt.PlaceholderText = "Per sack"
        Me.quantityTxt.Size = New System.Drawing.Size(231, 30)
        Me.quantityTxt.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(442, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.Location = New System.Drawing.Point(554, 313)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(231, 30)
        Me.TextBox4.TabIndex = 7
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.addBtn.ForeColor = System.Drawing.Color.Black
        Me.addBtn.Location = New System.Drawing.Point(442, 381)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(116, 41)
        Me.addBtn.TabIndex = 9
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cancelBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelBtn.Location = New System.Drawing.Point(669, 381)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(116, 41)
        Me.cancelBtn.TabIndex = 10
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'typeTxt
        '
        Me.typeTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.typeTxt.Location = New System.Drawing.Point(554, 179)
        Me.typeTxt.Name = "typeTxt"
        Me.typeTxt.PlaceholderText = "Pig, Cat, Dog, Chicken"
        Me.typeTxt.Size = New System.Drawing.Size(231, 30)
        Me.typeTxt.TabIndex = 3
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.White
        Me.IconPictureBox1.BackgroundImage = Global.Otilla_Inventory.My.Resources.Resources.undraw_add_information_j2wg
        Me.IconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 385
        Me.IconPictureBox1.Location = New System.Drawing.Point(12, 39)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(385, 433)
        Me.IconPictureBox1.TabIndex = 12
        Me.IconPictureBox1.TabStop = False
        '
        'FormAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 512)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.quantityTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.typeTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prodTxt)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FormAddProduct"
        Me.Text = "FormAddProduct"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents prodTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents quantityTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents typeTxt As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
