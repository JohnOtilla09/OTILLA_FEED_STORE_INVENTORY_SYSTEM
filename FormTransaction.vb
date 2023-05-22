Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

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

        strSQL = "select transactions.transact_id as ID, users.firstname as Firstname, transactions.date  as Date, products.prod_name as Product_Name, types.type Type, transactions.quantity as Quantity, transactions.total_amount as Total" &
                " from transactions" &
                " inner join users" &
                " on transactions.user_id = users.user_id" &
                " inner join products" &
                " on transactions.prod_id = products.prod_id" &
                " inner join types" &
                " on transactions.type_id = types.type_id"
        transactionTable(strSQL)

    End Sub

    Private Sub transactionTable(strSQL As String)
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

                Disconnect_to_DB()
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
        End With

    End Sub

    Private Sub FormTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSQL = "select transactions.transact_id as ID, users.firstname as Firstname, transactions.date  as Date, products.prod_name as Product_Name, types.type Type, transactions.quantity as Quantity, transactions.total_amount as Total" &
                " from transactions" &
                " inner join users" &
                " on transactions.user_id = users.user_id" &
                " inner join products" &
                " on transactions.prod_id = products.prod_id" &
                " inner join types" &
                " on transactions.type_id = types.type_id"
        transactionTable(strSQL)
    End Sub

    Private Sub exportBtn_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        Call importToExcel(Me.dgTransactionReport, "Product_Transactions.xlsx", 4)
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        strSQL = "select transactions.transact_id as ID, users.firstname as Firstname, transactions.date  as Date, products.prod_name as Product_Name, types.type Type, transactions.quantity as Quantity, transactions.total_amount as Total" &
                " from transactions" &
                " inner join users" &
                " on transactions.user_id = users.user_id" &
                " inner join products" &
                " on transactions.prod_id = products.prod_id" &
                " inner join types" &
                " on transactions.type_id = types.type_id"
        transactionTable(strSQL)
    End Sub

    Private Sub dgTransactionReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTransactionReport.CellContentClick
        FormUpdateTransaction.typeTxt.DropDownStyle = ComboBoxStyle.DropDownList
        FormUpdateTransaction.typeTxt.Items.Add("Chicken")
        FormUpdateTransaction.typeTxt.Items.Add("Pig")
        FormUpdateTransaction.typeTxt.Items.Add("Dog")
        FormUpdateTransaction.typeTxt.Items.Add("Cat")

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        MessageBox.Show(index)
        FormUpdateTransaction.transact_id = selectedRow.Cells(0).Value.ToString()
        FormUpdateTransaction.prodTxt.Text = selectedRow.Cells(3).Value.ToString()
        If FormUpdateTransaction.typeTxt.Items.Contains(selectedRow.Cells(4).Value.ToString()) Then
            FormUpdateTransaction.typeTxt.Items.Remove(selectedRow.Cells(4).Value.ToString())
            FormUpdateTransaction.typeTxt.Items.Insert(0, selectedRow.Cells(4).Value.ToString())
            FormUpdateTransaction.typeTxt.SelectedIndex = 0
        End If
        FormUpdateTransaction.quantityTxt.Text = selectedRow.Cells(5).Value.ToString()
        FormUpdateTransaction.amountTxt.Text = selectedRow.Cells(6).Value.ToString()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        FormUpdateTransaction.Show()

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim transact_id = FormUpdateTransaction.transact_id

        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "DELETE FROM transactions WHERE transact_id = " & transact_id
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Transaction deleted successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Disconnect_to_DB()

            strSQL = "select transactions.transact_id as ID, users.firstname as Firstname, transactions.date  as Date, products.prod_name as Product_Name, types.type Type, transactions.quantity as Quantity, transactions.total_amount as Total" &
                " from transactions" &
                " inner join users" &
                " on transactions.user_id = users.user_id" &
                " inner join products" &
                " on transactions.prod_id = products.prod_id" &
                " inner join types" &
                " on transactions.type_id = types.type_id"
            transactionTable(strSQL)
        End With
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim search = searchTxt.Text

        strSQL = "select * from transactions where date = '" & search & "'"
        transactionTable(strSQL)
    End Sub
End Class