Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormAddProduct
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim id = 0

        If typeTxt == 

        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Insert into"
            Catch ex As Exception

            End Try

        End With

        'Me.Hide()
        'MessageBox.Show("Product added successfully")
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
End Class