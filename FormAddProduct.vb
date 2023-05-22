Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormAddProduct
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
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
                strSQL = "INSERT INTO products (type_id, prod_name, brand, stock, price) VALUES (" &
                      id & ", '" & prodTxt.Text & "', '" & brandTxt.Text & "', " &
                      quantityTxt.Text & ", " & priceTxt.Text & ")"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Disconnect_to_DB()

        End With

        prodTxt.Clear()
        brandTxt.Clear()
        quantityTxt.Clear()
        priceTxt.Clear()

        Me.Hide()
        MessageBox.Show("Product Successfully Added!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
    End Sub

    Private Sub FormAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        typeTxt.DropDownStyle = ComboBoxStyle.DropDownList
        typeTxt.Items.Add("Chicken")
        typeTxt.SelectedIndex = 0
        typeTxt.Items.Add("Pig")
        typeTxt.Items.Add("Dog")
        typeTxt.Items.Add("Cat")

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub priceTxt_TextChanged(sender As Object, e As EventArgs) Handles priceTxt.TextChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub typeTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeTxt.SelectedIndexChanged

    End Sub
End Class