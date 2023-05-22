Imports MySql.Data.MySqlClient
Public Class AddUsers

    Public id = 0
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Dim myreader As MySqlDataReader

        If passwordTxt.Text = confirmTxt.Text And lastnameTxt.Text IsNot "" And firstnameTxt.Text IsNot "" And gmailTxt.Text IsNot "" And usernameTxt.Text IsNot "" And birthdayTxt.Text IsNot "" And addressTxt.Text IsNot "" And passwordTxt.Text IsNot "" And confirmTxt.Text IsNot "" Then

            Dim dateValue As Date = DateTime.Parse(birthdayTxt.Text)
            Dim birthday As String = dateValue.ToString("yyyy-MM-dd")


            With Me

                Call Connect_to_DB()
                Dim mycmd As New MySqlCommand

                Try
                    strSQL = "INSERT INTO users (role_id, lastname, firstname, gmail, username, birthday, address, password) VALUES (" &
                          2 & ", '" & lastnameTxt.Text & "', '" & firstnameTxt.Text & "', '" & gmailTxt.Text & "', '" & usernameTxt.Text & "', '" & birthday & "', '" & addressTxt.Text & "', '" & passwordTxt.Text & "')"
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                Disconnect_to_DB()
                Call Connect_to_DB()

                strSQL = "select max(transact_id) as id from transactions"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()

                myreader = mycmd.ExecuteReader
                If myreader.HasRows Then
                    myreader.Read()
                    id = myreader.GetString("id")
                    Call Disconnect_to_DB()
                    .Hide()
                    FormLandingPage.Show()
                    MessageBox.Show("Welcome to OTILLA FEED STORE INVENTORY SYSTEM!")
                End If

            End With

        Else

            MessageBox.Show("Invalid Input")

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles addressTxt.TextChanged

    End Sub

    Private Sub AddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class