<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        dgBestSellingProductsTable = New DataGridView()
        Label5 = New Label()
        Panel1 = New Panel()
        exportBtn = New Button()
        Panel7 = New Panel()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Panel8 = New Panel()
        IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Panel9 = New Panel()
        IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Panel6 = New Panel()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Panel3 = New Panel()
        chickenLabel = New Label()
        Label10 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        doglabel = New Label()
        Label9 = New Label()
        Label3 = New Label()
        Panel5 = New Panel()
        catLabel = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        piglabel = New Label()
        Label7 = New Label()
        Label2 = New Label()
        CType(dgBestSellingProductsTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label1.Location = New Point(43, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 27)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' dgBestSellingProductsTable
        ' 
        dgBestSellingProductsTable.Anchor = AnchorStyles.Top
        dgBestSellingProductsTable.BackgroundColor = Color.White
        dgBestSellingProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgBestSellingProductsTable.DefaultCellStyle = DataGridViewCellStyle1
        dgBestSellingProductsTable.Location = New Point(53, 244)
        dgBestSellingProductsTable.Name = "dgBestSellingProductsTable"
        dgBestSellingProductsTable.RowHeadersWidth = 51
        dgBestSellingProductsTable.RowTemplate.Height = 29
        dgBestSellingProductsTable.Size = New Size(585, 347)
        dgBestSellingProductsTable.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(197), CByte(95), CByte(252))
        Label5.Location = New Point(384, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(254, 36)
        Label5.TabIndex = 7
        Label5.Text = "Best Selling Products"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(exportBtn)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dgBestSellingProductsTable)
        Panel1.Location = New Point(-12, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1093, 705)
        Panel1.TabIndex = 8
        ' 
        ' exportBtn
        ' 
        exportBtn.BackColor = Color.FromArgb(CByte(117), CByte(230), CByte(218))
        exportBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        exportBtn.Location = New Point(694, 244)
        exportBtn.Name = "exportBtn"
        exportBtn.Size = New Size(257, 65)
        exportBtn.TabIndex = 17
        exportBtn.Text = "Export"
        exportBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(IconPictureBox2)
        Panel7.Location = New Point(780, 25)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(91, 82)
        Panel7.TabIndex = 12
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.FromArgb(CByte(6), CByte(182), CByte(194))
        IconPictureBox2.BackgroundImage = My.Resources.Resources.cat_icon_25
        IconPictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox2.ForeColor = SystemColors.ControlText
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox2.IconColor = SystemColors.ControlText
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 82
        IconPictureBox2.Location = New Point(0, -3)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(91, 82)
        IconPictureBox2.TabIndex = 13
        IconPictureBox2.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(IconPictureBox3)
        Panel8.Location = New Point(547, 25)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(91, 82)
        Panel8.TabIndex = 12
        ' 
        ' IconPictureBox3
        ' 
        IconPictureBox3.BackColor = Color.FromArgb(CByte(222), CByte(67), CByte(60))
        IconPictureBox3.BackgroundImage = My.Resources.Resources.dog_24
        IconPictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox3.ForeColor = SystemColors.ControlText
        IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox3.IconColor = SystemColors.ControlText
        IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox3.IconSize = 82
        IconPictureBox3.Location = New Point(0, -3)
        IconPictureBox3.Name = "IconPictureBox3"
        IconPictureBox3.Size = New Size(91, 82)
        IconPictureBox3.TabIndex = 14
        IconPictureBox3.TabStop = False
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(IconPictureBox4)
        Panel9.Location = New Point(307, 25)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(91, 82)
        Panel9.TabIndex = 12
        ' 
        ' IconPictureBox4
        ' 
        IconPictureBox4.BackColor = Color.FromArgb(CByte(64), CByte(170), CByte(69))
        IconPictureBox4.BackgroundImage = My.Resources.Resources.chicken_icon_6
        IconPictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox4.ForeColor = SystemColors.ControlLightLight
        IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox4.IconColor = SystemColors.ControlLightLight
        IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox4.IconSize = 82
        IconPictureBox4.Location = New Point(3, 0)
        IconPictureBox4.Name = "IconPictureBox4"
        IconPictureBox4.Size = New Size(91, 82)
        IconPictureBox4.TabIndex = 15
        IconPictureBox4.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(IconPictureBox1)
        Panel6.Location = New Point(68, 25)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(91, 82)
        Panel6.TabIndex = 11
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(253), CByte(149), CByte(3))
        IconPictureBox1.BackgroundImage = My.Resources.Resources._459702
        IconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 82
        IconPictureBox1.Location = New Point(0, 0)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(91, 82)
        IconPictureBox1.TabIndex = 10
        IconPictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(chickenLabel)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(293, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(213, 112)
        Panel3.TabIndex = 9
        ' 
        ' chickenLabel
        ' 
        chickenLabel.AutoSize = True
        chickenLabel.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chickenLabel.Location = New Point(107, 76)
        chickenLabel.Name = "chickenLabel"
        chickenLabel.Size = New Size(21, 23)
        chickenLabel.TabIndex = 18
        chickenLabel.Text = "0"
        chickenLabel.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(17, 78)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 23)
        Label10.TabIndex = 17
        Label10.Text = "Amount:"
        Label10.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(107, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 23)
        Label4.TabIndex = 15
        Label4.Text = "CHICKEN"
        Label4.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(doglabel)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(532, 37)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(213, 112)
        Panel4.TabIndex = 9
        ' 
        ' doglabel
        ' 
        doglabel.AutoSize = True
        doglabel.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        doglabel.Location = New Point(113, 76)
        doglabel.Name = "doglabel"
        doglabel.Size = New Size(21, 23)
        doglabel.TabIndex = 19
        doglabel.Text = "0"
        doglabel.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(15, 78)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 23)
        Label9.TabIndex = 16
        Label9.Text = "Amount:"
        Label9.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(124, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 23)
        Label3.TabIndex = 14
        Label3.Text = "DOG"
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(catLabel)
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(765, 37)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(213, 112)
        Panel5.TabIndex = 9
        ' 
        ' catLabel
        ' 
        catLabel.AutoSize = True
        catLabel.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        catLabel.Location = New Point(112, 76)
        catLabel.Name = "catLabel"
        catLabel.Size = New Size(21, 23)
        catLabel.TabIndex = 20
        catLabel.Text = "0"
        catLabel.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(15, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 23)
        Label8.TabIndex = 15
        Label8.Text = "Amount:"
        Label8.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(127, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 26)
        Label6.TabIndex = 16
        Label6.Text = "CAT"
        Label6.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(piglabel)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(53, 37)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(213, 112)
        Panel2.TabIndex = 8
        ' 
        ' piglabel
        ' 
        piglabel.AutoSize = True
        piglabel.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        piglabel.Location = New Point(112, 76)
        piglabel.Name = "piglabel"
        piglabel.Size = New Size(21, 23)
        piglabel.TabIndex = 15
        piglabel.Text = "0"
        piglabel.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(13, 76)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 23)
        Label7.TabIndex = 14
        Label7.Text = "Amount:"
        Label7.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(127, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 23)
        Label2.TabIndex = 13
        Label2.Text = "PIG"
        Label2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1011, 673)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormHome"
        Text = "FormHome"
        CType(dgBestSellingProductsTable, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgBestSellingProductsTable As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents exportBtn As Button
    Friend WithEvents c As Label
    Friend WithEvents piglabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chickenLabel As Label
    Friend WithEvents doglabel As Label
    Friend WithEvents catLabel As Label
End Class
