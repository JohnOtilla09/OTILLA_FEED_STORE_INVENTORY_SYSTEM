Imports MySql.Data.MySqlClient

Public Class FormUsers
    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            strSQL = "select user_id as ID, lastname as Lastname, firstname as Firstname, gmail as Gmails, username as Username, address from users"
            displayUsers(strSQL)
        End With
    End Sub

    Private Sub displayUsers(strSQL As String)
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        Connect_to_DB()
        With Me
            Try
                mycommand.Connection = myconn
                mycommand.CommandText = strSQL
                myreader = mycommand.ExecuteReader
                mydatatable = New DataTable

                myreader.Close()
                mydataAdapter.SelectCommand = mycommand

                mydataAdapter.Fill(mydatatable)
                .dgUserTable.AutoSize = False
                .dgUserTable.Refresh()
                .dgUserTable.EndEdit()
                .dgUserTable.DataSource = mydatatable
                .dgUserTable.ReadOnly = True
                .dgUserTable.ScrollBars = ScrollBars.Both
                .dgUserTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub exportBtn_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        Call importToExcel(Me.dgUserTable, "Users.xlsx", 5)
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        FormUpdateUser.Show()
    End Sub

    Private Sub dgUserTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUserTable.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgUserTable.Rows(index)
        MessageBox.Show(index)
        FormUpdateUser.user_id = selectedRow.Cells(0).Value.ToString()
        FormUpdateUser.lastnameTxt.Text = selectedRow.Cells(1).Value.ToString()
        FormUpdateUser.firstnameTxt.Text = selectedRow.Cells(2).Value.ToString()
        FormUpdateUser.gmailTxt.Text = selectedRow.Cells(3).Value.ToString()
        FormUpdateUser.usernameTxt.Text = selectedRow.Cells(4).Value.ToString()
        FormUpdateUser.addressTxt.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        strSQL = "select user_id as ID, lastname as Lastname, firstname as Firstname, gmail as Gmails, username as Username, address from users"
        displayUsers(strSQL)
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim id As String = FormUpdateUser.user_id

        If id = Login.id Or id = AddUsers.id Then
            MessageBox.Show("You are longin.")
        Else
            With Me

                Call Connect_to_DB()
                Dim mycmd As New MySqlCommand
                Try
                    strSQL = "DELETE FROM users WHERE user_id = " & id
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MessageBox.Show("Product deleted successfully")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                Disconnect_to_DB()

                strSQL = "select user_id as ID, lastname as Lastname, firstname as Firstname, gmail as Gmails, username as Username, address from users"
                displayUsers(strSQL)
            End With
        End If
    End Sub
End Class