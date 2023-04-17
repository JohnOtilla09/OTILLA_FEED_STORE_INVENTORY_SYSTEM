Imports MySql.Data.MySqlClient

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()
        AddUsers.Show()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from users where username = '" _
                & .UsernameTextBox.Text & "' and password = md5('" _
                & .PasswordTextBox.Text & "')"

            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                Call Disconnect_to_DB()
                .Hide()
                FormLandingPage.Show()
                MessageBox.Show("Welcome to OTILLA FEED STORE INVENTORY SYSTEM!")
            Else
                MessageBox.Show("Invalid username or password")
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            End If
        End With
    End Sub
End Class
