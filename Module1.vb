﻿Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Module Module1
    Public myconn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String
    Public strSQL As String

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=123456789;" _
                    & "database=otilla_store"
        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        myconn.Close()
        myconn.Dispose()
    End Sub

    Public Sub importToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String, ByVal page As Integer)
        Dim currentDate As DateTime = DateTime.Now
        Dim strpassword As String = "123456789"
        Dim xlsPath As String = "D:\Github Clone\OTILLA_FEED_STORE_INVENTORY_SYSTEM\dataXls\Template\"
        Dim xlsFiles As String = "D:\Github Clone\OTILLA_FEED_STORE_INVENTORY_SYSTEM\dataXls\"

        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)

        xlsSheet = xlsWB.Worksheets(1)
        'xlsCell = xlsSheet.Range("A1")
        'xlsSheet.Cells(3, 1) = strfilter
        Dim x, y As Integer
        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                xlsSheet.Cells(x + 4, y + 1) = mydg.Rows(x).Cells(y).Value
            Next
        Next
        With xlsSheet.Range(convertToLetters(1) & 4, convertToLetters(mydg.ColumnCount) & x + 3)
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            .EntireColumn.AutoFit() ' Auto-fit columns
        End With

        'xlsSheet.Cells(1, 1) = "Mike"
        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentDate.ToString("MM-dd-yyyy hh-mm-ss") & ".xlsx"
        MsgBox(myfilename & " is successfully exported!")
        xlsSheet.Protect(strpassword)
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False

        If page = 1 Then
            xlsFiles &= "Best_Selling_Products\"
            xlsWB.SaveAs(xlsFiles & myfilename)
            xlsApp.Quit()
            releaseObject(xlsApp)
            releaseObject(xlsWB)
            releaseObject(xlsSheet)
        ElseIf page = 2 Then
            xlsFiles &= "Product_Sales\"
            xlsWB.SaveAs(xlsFiles & myfilename)
            xlsApp.Quit()
            releaseObject(xlsApp)
            releaseObject(xlsWB)
            releaseObject(xlsSheet)
        ElseIf page = 3 Then
            xlsFiles &= "Product_Inventory\"
            xlsWB.SaveAs(xlsFiles & myfilename)
            xlsApp.Quit()
            releaseObject(xlsApp)
            releaseObject(xlsWB)
            releaseObject(xlsSheet)
        ElseIf page = 4 Then
            xlsFiles &= "Product_Transactions\"
            xlsWB.SaveAs(xlsFiles & myfilename)
            xlsApp.Quit()
            releaseObject(xlsApp)
            releaseObject(xlsWB)
            releaseObject(xlsSheet)
        ElseIf page = 5 Then
            xlsFiles &= "Users\"
            xlsWB.SaveAs(xlsFiles & myfilename)
            xlsApp.Quit()
            releaseObject(xlsApp)
            releaseObject(xlsWB)
            releaseObject(xlsSheet)
        End If



    End Sub

    Public Function convertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If

        Return result

    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
