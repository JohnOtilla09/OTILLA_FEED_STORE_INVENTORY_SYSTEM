Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class FormInventory

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        FormAddProduct.Show()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        FormUpdateProduct.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backUpBtn.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog() = DialogResult.OK Then
            Dim directoryPath As String = Path.GetDirectoryName(backup.FileName)
            Dim fileName As String = Path.GetFileName(backup.FileName)
            Dim cmd = "mysqldump -h localhost -u root -p123456789 otilla_store > " + directoryPath + "\" + fileName

            Dim batchFilePath As String = "D:\Data_Loading_Conversion_and_Backup\myfile.bat"
            Dim mysqldumpCommand As String = cmd

            Using writer As New StreamWriter(batchFilePath)
                writer.WriteLine(mysqldumpCommand)
            End Using

            Dim backupDatabase = Shell(batchFilePath)

            If backupDatabase Then
                MessageBox.Show("Backup is successful!")
            Else
                MessageBox.Show("Backup is not successful!")
            End If

        End If
    End Sub

    Private Sub FormInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSQL = "select products.prod_id as ID, products.prod_name as Product_Name, types.type as Type, products.brand as Brand, products.stock as Stocks, products.price as Price" &
                " from products" &
                " inner join types" &
                " on products.type_id = types.type_id"
        inventoryTable(strSQL)
    End Sub

    Function inventoryTable(strSQL As String)
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
                Disconnect_to_DB()
                mydataAdapter.Fill(mydatatable)
                .dgInventoryTable.AutoSize = False
                .dgInventoryTable.EndEdit()
                .dgInventoryTable.DataSource = mydatatable
                .dgInventoryTable.ReadOnly = True
                .dgInventoryTable.ScrollBars = ScrollBars.Both
                .dgInventoryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
        End With
    End Function

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        strSQL = "select products.prod_id as ID, products.prod_name as Product_Name, types.type as Type, products.brand as Brand, products.stock as Stocks, products.price as Price" &
                " from products" &
                " inner join types" &
                " on products.type_id = types.type_id"
        inventoryTable(strSQL)
    End Sub

    Private Sub dgInventoryTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInventoryTable.CellContentClick
        FormUpdateProduct.typeUpTxt.DropDownStyle = ComboBoxStyle.DropDownList
        FormUpdateProduct.typeUpTxt.Items.Add("Chicken")
        FormUpdateProduct.typeUpTxt.Items.Add("Pig")
        FormUpdateProduct.typeUpTxt.Items.Add("Dog")
        FormUpdateProduct.typeUpTxt.Items.Add("Cat")

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        MessageBox.Show(index)
        FormUpdateProduct.prod_id = selectedRow.Cells(0).Value.ToString()
        FormUpdateProduct.prodUpTxt.Text = selectedRow.Cells(1).Value.ToString()
        If FormUpdateProduct.typeUpTxt.Items.Contains(selectedRow.Cells(2).Value.ToString()) Then
            FormUpdateProduct.typeUpTxt.Items.Remove(selectedRow.Cells(2).Value.ToString())
            FormUpdateProduct.typeUpTxt.Items.Insert(0, selectedRow.Cells(2).Value.ToString())
            FormUpdateProduct.typeUpTxt.SelectedIndex = 0
        End If
        FormUpdateProduct.brandUpTxt.Text = selectedRow.Cells(3).Value.ToString()
        FormUpdateProduct.quantityUpTxt.Text = selectedRow.Cells(4).Value.ToString()
        FormUpdateProduct.priceUpTxt.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub exportBtn_Click_1(sender As Object, e As EventArgs) Handles exportBtn.Click
        Call importToExcel(Me.dgInventoryTable, "Product_Inventory.xlsx", 3)
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim id As String = FormUpdateProduct.prod_id

        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "DELETE FROM products WHERE prod_id = " & id
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Product deleted successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Disconnect_to_DB()

            strSQL = "select products.prod_id as ID, products.prod_name as Product_Name, types.type as Type, products.brand as Brand, products.stock as Stocks, products.price as Price" &
                " from products" &
                " inner join types" &
                " on products.type_id = types.type_id"
            inventoryTable(strSQL)
        End With
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim search = searchTxt.Text

        strSQL = "select * from products where prod_name = '" & search & "'"
        inventoryTable(strSQL)
    End Sub
End Class

