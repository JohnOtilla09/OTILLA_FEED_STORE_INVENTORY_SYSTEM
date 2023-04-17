Public Class AddUsers
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Me.Hide()
        FormLandingPage.Show()
        MessageBox.Show("Welcome to OTILLA INVENTORY SYSTEM!")

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub AddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class