Imports MySql.Data.MySqlClient

Public Class FormUsers
    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            displayUsers()
        End With
    End Sub

    Private Sub displayUsers()
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        strSQL = "select lastname, firstname, gmail, birthday, address from users"

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


End Class