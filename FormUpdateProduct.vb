Imports MySql.Data.MySqlClient

Public Class FormUpdateProduct

    Public Dim prod_id = 0

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        prodUpTxt.Clear()
        typeUpTxt.Dispose()
        brandUpTxt.Clear()
        quantityUpTxt.Clear()
        priceUpTxt.Clear()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim id = 0

        If typeUpTxt.Text = "Chicken" Then
            id = 1
        ElseIf typeUpTxt.Text = "Pig" Then
            id = 2
        ElseIf typeUpTxt.Text = "Dog" Then
            id = 3
        ElseIf typeUpTxt.Text = "Cat" Then
            id = 4
        End If

        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "UPDATE products SET " &
                    "type_id = " & id & ", prod_name = '" & prodUpTxt.Text & "', brand = '" & brandUpTxt.Text & "', stock = " & quantityUpTxt.Text & ", price = " & priceUpTxt.Text & " WHERE prod_id = '" & prod_id & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Product update successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Disconnect_to_DB()

        End With

        prodUpTxt.Clear()
        typeUpTxt.Dispose()
        brandUpTxt.Clear()
        quantityUpTxt.Clear()
        priceUpTxt.Clear()

        Me.Hide()
    End Sub
End Class