<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateProduct
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
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        cancelBtn = New Button()
        Label5 = New Label()
        priceUpTxt = New TextBox()
        Label4 = New Label()
        quantityUpTxt = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        prodUpTxt = New TextBox()
        updateButton = New Button()
        typeUpTxt = New ComboBox()
        Brand = New Label()
        brandUpTxt = New TextBox()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.White
        IconPictureBox1.BackgroundImage = My.Resources.Resources.undraw_Update_re_swkp
        IconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 385
        IconPictureBox1.Location = New Point(17, 35)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(385, 433)
        IconPictureBox1.TabIndex = 24
        IconPictureBox1.TabStop = False
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        cancelBtn.ForeColor = Color.Black
        cancelBtn.Location = New Point(691, 404)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(116, 41)
        cancelBtn.TabIndex = 23
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(464, 349)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 23)
        Label5.TabIndex = 21
        Label5.Text = "Price"
        ' 
        ' priceUpTxt
        ' 
        priceUpTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        priceUpTxt.Location = New Point(576, 342)
        priceUpTxt.Name = "priceUpTxt"
        priceUpTxt.PlaceholderText = "2500"
        priceUpTxt.Size = New Size(231, 30)
        priceUpTxt.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(464, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 23)
        Label4.TabIndex = 19
        Label4.Text = "Quantity"
        ' 
        ' quantityUpTxt
        ' 
        quantityUpTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        quantityUpTxt.Location = New Point(576, 286)
        quantityUpTxt.Name = "quantityUpTxt"
        quantityUpTxt.PlaceholderText = "Number of Sack"
        quantityUpTxt.Size = New Size(231, 30)
        quantityUpTxt.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AccessibleName = ""
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(464, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 23)
        Label3.TabIndex = 17
        Label3.Text = "Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(499, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 23)
        Label2.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label1.Location = New Point(555, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 24)
        Label1.TabIndex = 13
        Label1.Text = "Update Product"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(464, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 23)
        Label6.TabIndex = 26
        Label6.Text = "Product"
        ' 
        ' prodUpTxt
        ' 
        prodUpTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        prodUpTxt.Location = New Point(576, 134)
        prodUpTxt.Name = "prodUpTxt"
        prodUpTxt.PlaceholderText = "L 300"
        prodUpTxt.Size = New Size(231, 30)
        prodUpTxt.TabIndex = 25
        ' 
        ' updateButton
        ' 
        updateButton.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        updateButton.ForeColor = Color.Black
        updateButton.Location = New Point(464, 404)
        updateButton.Name = "updateButton"
        updateButton.Size = New Size(116, 41)
        updateButton.TabIndex = 27
        updateButton.Text = "Update"
        updateButton.UseVisualStyleBackColor = False
        ' 
        ' typeUpTxt
        ' 
        typeUpTxt.FormattingEnabled = True
        typeUpTxt.Location = New Point(576, 183)
        typeUpTxt.Name = "typeUpTxt"
        typeUpTxt.Size = New Size(231, 28)
        typeUpTxt.TabIndex = 28
        ' 
        ' Brand
        ' 
        Brand.AutoSize = True
        Brand.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Brand.Location = New Point(464, 234)
        Brand.Name = "Brand"
        Brand.Size = New Size(62, 23)
        Brand.TabIndex = 30
        Brand.Text = "Brand"
        ' 
        ' brandUpTxt
        ' 
        brandUpTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        brandUpTxt.Location = New Point(576, 230)
        brandUpTxt.Name = "brandUpTxt"
        brandUpTxt.PlaceholderText = "BMEG"
        brandUpTxt.Size = New Size(231, 30)
        brandUpTxt.TabIndex = 29
        ' 
        ' FormUpdateProduct
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(890, 512)
        Controls.Add(Brand)
        Controls.Add(brandUpTxt)
        Controls.Add(typeUpTxt)
        Controls.Add(updateButton)
        Controls.Add(Label6)
        Controls.Add(prodUpTxt)
        Controls.Add(IconPictureBox1)
        Controls.Add(cancelBtn)
        Controls.Add(Label5)
        Controls.Add(priceUpTxt)
        Controls.Add(Label4)
        Controls.Add(quantityUpTxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "FormUpdateProduct"
        Text = "FormUpdateProduct"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents priceUpTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents quantityUpTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents prodUpTxt As TextBox
    Friend WithEvents updateButton As Button
    Friend WithEvents typeUpTxt As ComboBox
    Friend WithEvents Brand As Label
    Friend WithEvents brandUpTxt As TextBox
End Class
