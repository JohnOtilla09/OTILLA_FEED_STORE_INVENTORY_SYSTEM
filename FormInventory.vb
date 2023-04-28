Imports System.IO
Imports MySql.Data.MySqlClient

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
        inventoryTable()

    End Sub

    Private Sub inventoryTable()
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        strSQL = "select products.prod_name as Product_Name, types.type as Type, products.brand as Brand, products.stock as Stocks, products.price as Price" &
                " from products" &
                " inner join types" &
                " on products.type_id = types.type_id"

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
                .dgInventoryTable.AutoSize = False
                .dgInventoryTable.Refresh()
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
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub exportBtn_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        Call importToExcel(Me.dgInventoryTable, "Product_Inventory.xlsx", 3)
    End Sub
End Class

