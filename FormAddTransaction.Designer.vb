﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddTransaction
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
        addBtn = New Button()
        Label5 = New Label()
        Label4 = New Label()
        quantityTxt = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        prodTxt = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        amountTxt = New TextBox()
        dateTxt = New DateTimePicker()
        typeTxt = New ComboBox()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        IconPictureBox1.Location = New Point(14, 9)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(385, 433)
        IconPictureBox1.TabIndex = 24
        IconPictureBox1.TabStop = False
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        cancelBtn.ForeColor = Color.Black
        cancelBtn.Location = New Point(671, 382)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(116, 41)
        cancelBtn.TabIndex = 23
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = False
        ' 
        ' addBtn
        ' 
        addBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        addBtn.ForeColor = Color.Black
        addBtn.Location = New Point(444, 382)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(116, 41)
        addBtn.TabIndex = 22
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(444, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 23)
        Label5.TabIndex = 21
        Label5.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(444, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 23)
        Label4.TabIndex = 19
        Label4.Text = "Quantity"
        ' 
        ' quantityTxt
        ' 
        quantityTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        quantityTxt.Location = New Point(576, 192)
        quantityTxt.Name = "quantityTxt"
        quantityTxt.PlaceholderText = "Kilo"
        quantityTxt.Size = New Size(250, 30)
        quantityTxt.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AccessibleName = ""
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(444, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 23)
        Label3.TabIndex = 17
        Label3.Text = "Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(444, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 15
        Label2.Text = "Product"
        ' 
        ' prodTxt
        ' 
        prodTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        prodTxt.Location = New Point(576, 91)
        prodTxt.Name = "prodTxt"
        prodTxt.PlaceholderText = "L 300"
        prodTxt.Size = New Size(250, 30)
        prodTxt.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label1.Location = New Point(444, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 24)
        Label1.TabIndex = 13
        Label1.Text = "Add Transaction"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(444, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 23)
        Label6.TabIndex = 26
        Label6.Text = "Total amount"
        ' 
        ' amountTxt
        ' 
        amountTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        amountTxt.Location = New Point(576, 303)
        amountTxt.Name = "amountTxt"
        amountTxt.PlaceholderText = "70"
        amountTxt.Size = New Size(250, 30)
        amountTxt.TabIndex = 25
        ' 
        ' dateTxt
        ' 
        dateTxt.Location = New Point(576, 250)
        dateTxt.Name = "dateTxt"
        dateTxt.Size = New Size(250, 27)
        dateTxt.TabIndex = 27
        dateTxt.Value = New DateTime(2023, 5, 21, 9, 37, 55, 0)
        ' 
        ' typeTxt
        ' 
        typeTxt.DisplayMember = "jfb"
        typeTxt.FormattingEnabled = True
        typeTxt.Location = New Point(576, 142)
        typeTxt.Name = "typeTxt"
        typeTxt.Size = New Size(250, 28)
        typeTxt.TabIndex = 28
        ' 
        ' FormAddTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(858, 450)
        Controls.Add(typeTxt)
        Controls.Add(dateTxt)
        Controls.Add(Label6)
        Controls.Add(amountTxt)
        Controls.Add(IconPictureBox1)
        Controls.Add(cancelBtn)
        Controls.Add(addBtn)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(quantityTxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(prodTxt)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "FormAddTransaction"
        Text = "FormAddTransaction"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents quantityTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents prodTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents amountTxt As TextBox
    Friend WithEvents dateTxt As DateTimePicker
    Friend WithEvents typeTxt As ComboBox
End Class
