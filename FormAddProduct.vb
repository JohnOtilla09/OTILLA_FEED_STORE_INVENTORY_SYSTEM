Public Class FormAddProduct
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.Hide()
        MessageBox.Show("Product added successfully")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
    End Sub
End Class