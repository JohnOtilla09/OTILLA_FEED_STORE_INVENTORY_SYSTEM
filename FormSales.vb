Imports MySql.Data.MySqlClient

Public Class FormSales
    Private Sub FormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        salesTable()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub salesTable()
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        strSQL = "SELECT products.prod_name, types.type, products.price, total_income_per_products.quantity_sold, total_income_per_products.total_product_income" &
                " FROM total_income_per_products" &
                " INNER JOIN products ON products.prod_id = total_income_per_products.prod_id" &
                " INNER JOIN types ON types.type_id = products.type_id" &
                " WHERE total_income_per_products.quantity_sold > 0"

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
                .dgSalesTable.AutoSize = False
                .dgSalesTable.Refresh()
                .dgSalesTable.EndEdit()
                .dgSalesTable.DataSource = mydatatable
                .dgSalesTable.ReadOnly = True
                .dgSalesTable.ScrollBars = ScrollBars.Vertical
                .dgSalesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub
End Class