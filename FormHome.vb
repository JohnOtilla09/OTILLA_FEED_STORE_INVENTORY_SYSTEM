

Imports MySql.Data.MySqlClient

Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayBestSellingProducts()
    End Sub

    Private Sub displayBestSellingProducts()
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        strSQL = "SELECT products.prod_name, types.type, products.price, total_income_per_products.quantity_sold, greatest(total_income_per_products.total_product_income, 0) as total" &
                " FROM total_income_per_products" &
                " INNER JOIN products ON products.prod_id = total_income_per_products.prod_id" &
                " INNER JOIN types ON types.type_id = products.type_id" &
                " WHERE total_income_per_products.quantity_sold > 0" &
                " order by total desc" &
                " LIMIT 10"

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
                .dgBestSellingProductsTable.AutoSize = False
                .dgBestSellingProductsTable.Refresh()
                .dgBestSellingProductsTable.EndEdit()
                .dgBestSellingProductsTable.DataSource = mydatatable
                .dgBestSellingProductsTable.ReadOnly = True
                .dgBestSellingProductsTable.ScrollBars = ScrollBars.Vertical
                .dgBestSellingProductsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub
End Class