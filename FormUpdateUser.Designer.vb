<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateUser
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
        Label2 = New Label()
        usernameTxt = New TextBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label8 = New Label()
        addressTxt = New TextBox()
        Label9 = New Label()
        firstnameTxt = New TextBox()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        cancelBtn = New Button()
        updateBtn = New Button()
        Label3 = New Label()
        gmailTxt = New TextBox()
        Nam = New Label()
        lastnameTxt = New TextBox()
        Label1 = New Label()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(469, 306)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 23)
        Label2.TabIndex = 62
        Label2.Text = "Username"
        ' 
        ' usernameTxt
        ' 
        usernameTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        usernameTxt.Location = New Point(601, 299)
        usernameTxt.Name = "usernameTxt"
        usernameTxt.Size = New Size(231, 30)
        usernameTxt.TabIndex = 61
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label8
        ' 
        Label8.AccessibleName = ""
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(862, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 23)
        Label8.TabIndex = 60
        Label8.Text = "Address"
        ' 
        ' addressTxt
        ' 
        addressTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        addressTxt.Location = New Point(982, 101)
        addressTxt.Name = "addressTxt"
        addressTxt.Size = New Size(231, 30)
        addressTxt.TabIndex = 59
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(469, 164)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 23)
        Label9.TabIndex = 58
        Label9.Text = "Firstname"
        ' 
        ' firstnameTxt
        ' 
        firstnameTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        firstnameTxt.Location = New Point(601, 164)
        firstnameTxt.Name = "firstnameTxt"
        firstnameTxt.Size = New Size(231, 30)
        firstnameTxt.TabIndex = 57
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.White
        IconPictureBox1.BackgroundImage = My.Resources.Resources.undraw_fill_form_re_cwyf
        IconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 422
        IconPictureBox1.Location = New Point(22, 12)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(422, 456)
        IconPictureBox1.TabIndex = 56
        IconPictureBox1.TabStop = False
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        cancelBtn.ForeColor = Color.Black
        cancelBtn.Location = New Point(949, 365)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(116, 41)
        cancelBtn.TabIndex = 55
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        updateBtn.ForeColor = Color.Black
        updateBtn.Location = New Point(702, 365)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(116, 41)
        updateBtn.TabIndex = 54
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AccessibleName = ""
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(469, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 23)
        Label3.TabIndex = 52
        Label3.Text = "Gmail"
        ' 
        ' gmailTxt
        ' 
        gmailTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        gmailTxt.Location = New Point(601, 231)
        gmailTxt.Name = "gmailTxt"
        gmailTxt.Size = New Size(231, 30)
        gmailTxt.TabIndex = 51
        ' 
        ' Nam
        ' 
        Nam.AutoSize = True
        Nam.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Nam.Location = New Point(469, 104)
        Nam.Name = "Nam"
        Nam.Size = New Size(96, 23)
        Nam.TabIndex = 50
        Nam.Text = "Lastname"
        ' 
        ' lastnameTxt
        ' 
        lastnameTxt.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lastnameTxt.Location = New Point(601, 104)
        lastnameTxt.Name = "lastnameTxt"
        lastnameTxt.Size = New Size(231, 30)
        lastnameTxt.TabIndex = 49
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label1.Location = New Point(806, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 24)
        Label1.TabIndex = 48
        Label1.Text = "Update User"
        ' 
        ' FormUpdateUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1229, 483)
        Controls.Add(Label2)
        Controls.Add(usernameTxt)
        Controls.Add(Label8)
        Controls.Add(addressTxt)
        Controls.Add(Label9)
        Controls.Add(firstnameTxt)
        Controls.Add(IconPictureBox1)
        Controls.Add(cancelBtn)
        Controls.Add(updateBtn)
        Controls.Add(Label3)
        Controls.Add(gmailTxt)
        Controls.Add(Nam)
        Controls.Add(lastnameTxt)
        Controls.Add(Label1)
        Name = "FormUpdateUser"
        Text = "FormUpdateUser"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label8 As Label
    Friend WithEvents addressTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents firstnameTxt As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents gmailTxt As TextBox
    Friend WithEvents Nam As Label
    Friend WithEvents lastnameTxt As TextBox
    Friend WithEvents Label1 As Label
End Class
