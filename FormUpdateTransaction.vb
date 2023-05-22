Imports MySql.Data.MySqlClient

Public Class FormUpdateTransaction

    Public transact_id = 0
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim id = 0

        If typeTxt.Text = "Chicken" Then
            id = 1
        ElseIf typeTxt.Text = "Pig" Then
            id = 2
        ElseIf typeTxt.Text = "Dog" Then
            id = 3
        ElseIf typeTxt.Text = "Cat" Then
            id = 4
        End If

        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "UPDATE transactions SET " &
                    "quantity = " & quantityTxt.Text & ", total_amount = " & amountTxt.Text & " WHERE prod_id = " & transact_id & ""
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Transaction update successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Disconnect_to_DB()

        End With

        prodTxt.Clear()
        quantityTxt.Clear()
        amountTxt.Clear()

        Me.Hide()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        prodTxt.Clear()
        typeTxt.Dispose()
        quantityTxt.Clear()
        amountTxt.Clear()
        Me.Hide()
    End Sub

    Private Sub FormUpdateTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prodTxt.ReadOnly = True
    End Sub
End Class