<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateTransaction
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
        typeTxt = New ComboBox()
        Label6 = New Label()
        amountTxt = New TextBox()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        cancelBtn = New Button()
        updateBtn = New Button()
        Label4 = New Label()
        quantityTxt = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        prodTxt = New TextBox()
        Label1 = New Label()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' typeTxt
        ' 
        typeTxt.DisplayMember = "jfb"
        typeTxt.FormattingEnabled = True
        typeTxt.Location = New Point(592, 156)
        typeTxt.Name = "typeTxt"
        typeTxt.Size = New Size(250, 28)
        typeTxt.TabIndex = 42
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(460, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 23)
        Label6.TabIndex = 40
        Label6.Text = "Total amount"
        ' 
        ' amountTxt
        ' 
        amountTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        amountTxt.Location = New Point(592, 258)
        amountTxt.Name = "amountTxt"
        amountTxt.PlaceholderText = "2500"
        amountTxt.Size = New Size(250, 30)
        amountTxt.TabIndex = 39
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.White
        IconPictureBox1.BackgroundImage = My.Resources.Resources.undraw_Plain_credit_card_re_c07w
        IconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 385
        IconPictureBox1.Location = New Point(30, 23)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(385, 433)
        IconPictureBox1.TabIndex = 38
        IconPictureBox1.TabStop = False
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        cancelBtn.ForeColor = Color.Black
        cancelBtn.Location = New Point(687, 337)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(116, 41)
        cancelBtn.TabIndex = 37
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        updateBtn.ForeColor = Color.Black
        updateBtn.Location = New Point(460, 337)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(116, 41)
        updateBtn.TabIndex = 36
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(460, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 23)
        Label4.TabIndex = 34
        Label4.Text = "Quantity"
        ' 
        ' quantityTxt
        ' 
        quantityTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        quantityTxt.Location = New Point(592, 206)
        quantityTxt.Name = "quantityTxt"
        quantityTxt.PlaceholderText = "Number of Sacks"
        quantityTxt.Size = New Size(250, 30)
        quantityTxt.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AccessibleName = ""
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(460, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 23)
        Label3.TabIndex = 32
        Label3.Text = "Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(460, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 31
        Label2.Text = "Product"
        ' 
        ' prodTxt
        ' 
        prodTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        prodTxt.Location = New Point(592, 105)
        prodTxt.Name = "prodTxt"
        prodTxt.PlaceholderText = "L 300"
        prodTxt.Size = New Size(250, 30)
        prodTxt.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label1.Location = New Point(555, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 24)
        Label1.TabIndex = 29
        Label1.Text = "Update Transaction"
        ' 
        ' FormUpdateTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(875, 476)
        Controls.Add(typeTxt)
        Controls.Add(Label6)
        Controls.Add(amountTxt)
        Controls.Add(IconPictureBox1)
        Controls.Add(cancelBtn)
        Controls.Add(updateBtn)
        Controls.Add(Label4)
        Controls.Add(quantityTxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(prodTxt)
        Controls.Add(Label1)
        Name = "FormUpdateTransaction"
        Text = "FormUpdateTransaction"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents typeTxt As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents amountTxt As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents quantityTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents prodTxt As TextBox
    Friend WithEvents Label1 As Label
End Class
