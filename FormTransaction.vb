Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class FormTransaction
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        FormAddTransaction.Show()
    End Sub

    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .Filter = "Text Files (*.csv)|*.csv|All Files (*.*)|*.*",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            Dim path As String = filePath.Replace("\", "/")

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Load DATA INFILE '" & path & "' INTO TABLE transactions " &
                         "FIELDS TERMINATED BY ',' " &
                         "LINES TERMINATED BY '\r\n' " &
                         "IGNORE 1 LINES"

                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Data uploaded successfully")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Disconnect_to_DB()
        End If
        transactionTable()

    End Sub

    Private Sub transactionTable()
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        strSQL = "select users.firstname, transactions.date, products.prod_name, types.type, transactions.quantity, transactions.total_amount" &
                " from transactions" &
                " inner join users" &
                " on transactions.user_id = users.user_id" &
                " inner join products" &
                " on transactions.prod_id = products.prod_id" &
                " inner join types" &
                " on transactions.type_id = types.type_id"

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
                .dgTransactionReport.AutoSize = False
                .dgTransactionReport.Refresh()
                .dgTransactionReport.EndEdit()
                .dgTransactionReport.DataSource = mydatatable
                .dgTransactionReport.ReadOnly = True
                .dgTransactionReport.ScrollBars = ScrollBars.Both
                .dgTransactionReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With

    End Sub

    Private Sub FormTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transactionTable()
    End Sub
End Class