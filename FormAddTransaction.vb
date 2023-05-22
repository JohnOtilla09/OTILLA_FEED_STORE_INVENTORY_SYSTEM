Imports MySql.Data.MySqlClient

Public Class FormAddTransaction

    Public prod_id = 0

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim id = 0
        Dim proceed = 0
        Dim myreader As MySqlDataReader
        Dim prod_name = prodTxt.Text
        'Dim dateValue As Date = DateTime.Parse(dateTxt.Text)
        'Dim dateString As String = dateValue.ToString("yyyy-MM-dd")
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
                strSQL = "select prod_id as prod_id, type_id as type_id  from products where prod_name = '" & prod_name & "' and type_id = " & id
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()

                myreader = mycmd.ExecuteReader
                If myreader.HasRows Then
                    myreader.Read()
                    prod_id = myreader.GetString("prod_id")
                    proceed = 1
                Else
                    MessageBox.Show("No data found")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Disconnect_to_DB()

        End With

        If proceed = 1 Then
            With Me

                Call Connect_to_DB()
                Dim mycmd As New MySqlCommand

                If Login.id = 0 Then
                    id = AddUsers.id
                Else
                    id = Login.id
                End If

                Try
                    MessageBox.Show(DateString)
                    strSQL = "INSERT INTO transactions (user_id, date, prod_id, type_id, quantity, total_amount) values (" &
                        id & ", '" & dateTxt.Text & "', " & prod_id & ", " & id & ", " & quantityTxt.Text & ", " & amountTxt.Text & ")"
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MessageBox.Show("Transaction added successfully!")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                Disconnect_to_DB()

            End With
        End If

        Me.Hide()

    End Sub

    Private Sub FormAddTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        typeTxt.DropDownStyle = ComboBoxStyle.DropDownList
        typeTxt.Items.Add("Chicken")
        typeTxt.SelectedIndex = 0
        typeTxt.Items.Add("Pig")
        typeTxt.Items.Add("Dog")
        typeTxt.Items.Add("Cat")
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub quantityTxt_TextChanged(sender As Object, e As EventArgs) Handles quantityTxt.TextChanged
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub prodTxt_TextChanged(sender As Object, e As EventArgs) Handles prodTxt.TextChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub amountTxt_TextChanged(sender As Object, e As EventArgs) Handles amountTxt.TextChanged
    End Sub

    Private Sub dateTxt_ValueChanged(sender As Object, e As EventArgs) Handles dateTxt.ValueChanged
    End Sub

    Private Sub typeTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeTxt.SelectedIndexChanged
    End Sub
End Class