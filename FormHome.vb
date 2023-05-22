Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            Try
                strSQL = "SELECT total_income FROM total_icome_per_type_of_animal_foods"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                myreader = mycmd.ExecuteReader()

                Dim incomeArray As New List(Of Integer)() ' Create a list to store the values

                If myreader.HasRows Then
                    While myreader.Read()
                        Dim amount As Integer = myreader("total_income")
                        incomeArray.Add(amount) ' Add the value to the list
                    End While
                End If

                chickenLabel.Text = incomeArray(0)
                piglabel.Text = incomeArray(1)
                doglabel.Text = incomeArray(2)
                catLabel.Text = incomeArray(3)

                myreader.Close()
                mycmd.Dispose()
                myconn.Close()

                Dim incomeArrayAsArray() As Integer = incomeArray.ToArray()

                For Each amount As Integer In incomeArrayAsArray
                    Console.WriteLine("Amount: " & amount)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End With

        displayBestSellingProducts()
    End Sub

    Private Sub displayBestSellingProducts()
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        strSQL = "SELECT products.prod_name Product_Name, types.type as Type, products.price as Price, total_income_per_products.quantity_sold as Quantity_Sold, greatest(total_income_per_products.total_product_income, 0) as Total_Sales" &
                " FROM total_income_per_products" &
                " INNER JOIN products ON products.prod_id = total_income_per_products.prod_id" &
                " INNER JOIN types ON types.type_id = products.type_id" &
                " WHERE total_income_per_products.quantity_sold > 0" &
                " order by Total_Sales desc" &
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
                .dgBestSellingProductsTable.ScrollBars = ScrollBars.Both
                .dgBestSellingProductsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub exportBtn_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        Call importToExcel(Me.dgBestSellingProductsTable, "Best_Selling_Products.xlsx", 1)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class