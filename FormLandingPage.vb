Imports FontAwesome.Sharp

Public Class FormLandingPage

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changeMenu("Home")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel With {
            .Size = New Size(7, 71)
        }
        SidePanel.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActiveButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(44, 62, 80)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
        End If

    End Sub

    Private Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(30, 39, 46)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White

        End If
    End Sub

    Private Sub addform(form As Form)
        PanelContainer.Controls.Clear()
        form.TopLevel = False
        form.TopMost = True
        form.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(form)
        form.Show()

    End Sub

    Public Sub changeMenu(menu As String)
        Select Case menu
            Case "Home"
                addform(FormHome)
            Case "Sales"
                addform(FormSales)
            Case "Inventory"
                addform(FormInventory)
            Case "Transaction"
                addform(FormTransaction)
            Case "Users"
                addform(FormUsers)
        End Select
    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub

    Private Sub dashboardButton_Click(sender As Object, e As EventArgs) Handles dashboardButton.Click
        changeMenu("Home")
        leftPanel.Height = dashboardButton.Height
        leftPanel.Top = dashboardButton.Top


    End Sub

    Private Sub salesButton_Click(sender As Object, e As EventArgs) Handles salesButton.Click
        changeMenu("Sales")
        leftPanel.Height = salesButton.Height
        leftPanel.Top = salesButton.Top
    End Sub

    Private Sub inventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        changeMenu("Inventory")
        leftPanel.Height = inventoryButton.Height
        leftPanel.Top = inventoryButton.Top
    End Sub

    Private Sub transactionButton_Click(sender As Object, e As EventArgs) Handles transactionButton.Click
        changeMenu("Transaction")
        leftPanel.Height = transactionButton.Height
        leftPanel.Top = transactionButton.Top
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Me.Close()
        Login.Show()
        Login.PasswordTextBox.Text = ""
        Login.UsernameTextBox.Text = ""
    End Sub

    Private Sub usersButton_Click(sender As Object, e As EventArgs) Handles usersButton.Click
        changeMenu("Users")
        leftPanel.Height = usersButton.Height
        leftPanel.Top = usersButton.Top
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class