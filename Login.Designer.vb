<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        Label2 = New Label()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(344, 110)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(344, 182)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTextBox.Location = New Point(346, 130)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(276, 39)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTextBox.Location = New Point(346, 202)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(276, 39)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        OK.Location = New Point(346, 264)
        OK.Name = "OK"
        OK.Size = New Size(116, 41)
        OK.TabIndex = 4
        OK.Text = "Login"
        OK.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(506, 264)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(116, 41)
        Cancel.TabIndex = 5
        Cancel.Text = "Register"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label2.Location = New Point(455, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 24)
        Label2.TabIndex = 7
        Label2.Text = "Login"
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.White
        IconPictureBox1.BackgroundImage = My.Resources.Resources.otilla_feed_store_logo
        IconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 433
        IconPictureBox1.Location = New Point(-113, -50)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(551, 433)
        IconPictureBox1.TabIndex = 8
        IconPictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = Cancel
        ClientSize = New Size(660, 337)
        Controls.Add(Label2)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(IconPictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
