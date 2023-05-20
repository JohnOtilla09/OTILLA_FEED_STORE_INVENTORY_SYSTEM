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
        Label1 = New Label()
        prodTxt = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        quantityTxt = New TextBox()
        Label5 = New Label()
        priceTxt = New TextBox()
        addBtn = New Button()
        cancelBtn = New Button()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        typeTxt = New ComboBox()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label1.Location = New Point(442, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 24)
        Label1.TabIndex = 0
        Label1.Text = "Add Product"
        ' 
        ' prodTxt
        ' 
        prodTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        prodTxt.Location = New Point(554, 117)
        prodTxt.Name = "prodTxt"
        prodTxt.PlaceholderText = "Enter product"
        prodTxt.Size = New Size(231, 30)
        prodTxt.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(442, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 2
        Label2.Text = "Product"
        ' 
        ' Label3
        ' 
        Label3.AccessibleName = ""
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(442, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 23)
        Label3.TabIndex = 4
        Label3.Text = "Type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(442, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 23)
        Label4.TabIndex = 6
        Label4.Text = "Quantity"
        ' 
        ' quantityTxt
        ' 
        quantityTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        quantityTxt.Location = New Point(544, 246)
        quantityTxt.Name = "quantityTxt"
        quantityTxt.PlaceholderText = "Per sack"
        quantityTxt.Size = New Size(241, 30)
        quantityTxt.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(442, 313)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 23)
        Label5.TabIndex = 8
        Label5.Text = "Price"
        ' 
        ' priceTxt
        ' 
        priceTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        priceTxt.Location = New Point(554, 313)
        priceTxt.Name = "priceTxt"
        priceTxt.Size = New Size(231, 30)
        priceTxt.TabIndex = 7
        ' 
        ' addBtn
        ' 
        addBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        addBtn.ForeColor = Color.Black
        addBtn.Location = New Point(442, 381)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(116, 41)
        addBtn.TabIndex = 9
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        cancelBtn.ForeColor = Color.Black
        cancelBtn.Location = New Point(669, 381)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(116, 41)
        cancelBtn.TabIndex = 10
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = False
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.White
        IconPictureBox1.BackgroundImage = My.Resources.Resources.undraw_add_information_j2wg
        IconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 385
        IconPictureBox1.Location = New Point(12, 39)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(385, 433)
        IconPictureBox1.TabIndex = 12
        IconPictureBox1.TabStop = False
        ' 
        ' typeTxt
        ' 
        typeTxt.DisplayMember = "jfb"
        typeTxt.FormattingEnabled = True
        typeTxt.Location = New Point(554, 183)
        typeTxt.Name = "typeTxt"
        typeTxt.Size = New Size(231, 28)
        typeTxt.TabIndex = 13
        ' 
        ' FormAddProduct
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(826, 512)
        Controls.Add(typeTxt)
        Controls.Add(IconPictureBox1)
        Controls.Add(cancelBtn)
        Controls.Add(addBtn)
        Controls.Add(Label5)
        Controls.Add(priceTxt)
        Controls.Add(Label4)
        Controls.Add(quantityTxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(prodTxt)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "FormAddProduct"
        Text = "FormAddProduct"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents prodTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents quantityTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents priceTxt As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents typeTxt As ComboBox
End Class
