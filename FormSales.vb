﻿Imports MySql.Data.MySqlClient

Public Class FormSales
    Private Sub FormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSQL = "SELECT products.prod_name as Product_Name, types.type as Type, products.price as Price, total_income_per_products.quantity_sold as Quantity_Sold, total_income_per_products.total_product_income as Total_Sales" &
            " FROM total_income_per_products" &
            " INNER JOIN products ON products.prod_id = total_income_per_products.prod_id" &
            " INNER JOIN types ON types.type_id = products.type_id" &
            " WHERE total_income_per_products.quantity_sold > 0" &
            " ORDER BY products.prod_name ASC"
        salesTable(strSQL)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        strSQL = "SELECT products.prod_name as Product_Name, types.type as Type, products.price as Price, total_income_per_products.quantity_sold as Quantity_Sold, total_income_per_products.total_product_income as Total_Sales" &
            " FROM total_income_per_products" &
            " INNER JOIN products ON products.prod_id = total_income_per_products.prod_id" &
            " INNER JOIN types ON types.type_id = products.type_id" &
            " WHERE total_income_per_products.quantity_sold > 0" &
            " ORDER BY products.prod_name ASC"
        salesTable(strSQL)
    End Sub

    Private Sub salesTable(strSQL As String)
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
                .dgSalesTable.AutoSize = False
                .dgSalesTable.Refresh()
                .dgSalesTable.EndEdit()
                .dgSalesTable.DataSource = mydatatable
                .dgSalesTable.ReadOnly = True
                .dgSalesTable.ScrollBars = ScrollBars.Both
                .dgSalesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub exportBtn_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        Call importToExcel(Me.dgSalesTable, "Product_Sales.xlsx", 2)
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim search = searchTxt.Text
        strSQL = "SELECT products.prod_name as Product_Name, types.type as Type, products.price as Price, total_income_per_products.quantity_sold as Quantity_Sold, total_income_per_products.total_product_income as Total_Sales" &
            " FROM total_income_per_products" &
            " INNER JOIN products ON products.prod_id = total_income_per_products.prod_id" &
            " INNER JOIN types ON types.type_id = products.type_id" &
            " WHERE total_income_per_products.quantity_sold > 0 AND products.prod_name = '" & search & "'" &
            " ORDER BY products.prod_name ASC"
        salesTable(strSQL)
    End Sub
End Class