Imports MySql.Data.MySqlClient

Public Class FormUpdateUser

    Public user_id = 0
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "UPDATE users SET " &
                        "lastname = '" & lastnameTxt.Text & "', firstname = '" & firstnameTxt.Text & "', gmail = '" & gmailTxt.Text & "', username = '" & usernameTxt.Text & "', address = '" & addressTxt.Text & "' WHERE user_id = " & user_id
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("User updated successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Disconnect_to_DB()

            lastnameTxt.Text = ""
            firstnameTxt.Text = ""
            gmailTxt.Text = ""
            usernameTxt.Text = ""
            addressTxt.Text = ""

            Me.Hide()

        End With
    End Sub
End Class