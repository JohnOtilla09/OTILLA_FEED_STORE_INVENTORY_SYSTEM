Public Class FormAddTransaction

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.Hide()
        MessageBox.Show("Transaction added successfully")
    End Sub
End Class