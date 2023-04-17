Imports System.IO
Imports MySql.Data.MySqlClient
Public Class OrderForm

    Private Sub btnAddOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOrder.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            Try
                strSQL = "Insert into `order` (customer_id, order_date) values (" _
                    & .CustomerIDTextBox.Text & ", " _
                    & "(select curdate()))"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                Try
                    strSQL = "Select order_id from `order` order by order_id desc limit 1"
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    myreader = mycmd.ExecuteReader()
                    If myreader.HasRows Then
                        While myreader.Read()
                            MsgBox("Order successfully added. Order ID: " & myreader.GetString("order_id"))
                        End While

                        Call Clear_Boxes()
                    End If
                Catch ex As MySqlException
                    MsgBox(ex.Number & " " & ex.Message)
                End Try
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input the customer's id to add their new order.")
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub


    Private Sub btnAddOrderLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOrderLine.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            Try
                If String.IsNullOrEmpty(.ISBNTextBox.Text) = False And
                    String.IsNullOrEmpty(.OrderIDTextBox.Text) = False _
                    And String.IsNullOrEmpty(.CostEachTextBox.Text) = False _
                    And String.IsNullOrEmpty(.QuantityTextBox.Text) = False Then
                    strSQL = "Insert into `order_line` (ISBN, order_id, cost_each, quantity, cost_line) values (" _
                        & .ISBNTextBox.Text & ", " _
                        & .OrderIDTextBox.Text & ", " _
                        & .CostEachTextBox.Text & ", " _
                        & .QuantityTextBox.Text & ", " _
                        & (CInt(.CostEachTextBox.Text) * CInt(.QuantityTextBox.Text)) & ")"
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    Try
                        strSQL = "Select id from `order_line` order by id desc limit 1"
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        myreader = mycmd.ExecuteReader()
                        If myreader.HasRows Then
                            While myreader.Read()
                                MsgBox("Order successfully added. Order Line ID: " & myreader.GetString("id"))
                            End While

                            Call Clear_Boxes()
                        End If
                    Catch ex As MySqlException
                        MsgBox(ex.Number & " " & ex.Message)
                    End Try
                Else
                    MsgBox("Make sure to input an isbn, order id, cost or price, and quantity to add a new order line to an order.")
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an isbn, order id, cost or price, and quantity to add a new order line to an order.")
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub
    Private Sub btnUpdateOrderLine_Click(sender As Object, e As EventArgs) Handles btnUpdateOrderLine.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim updated As Integer = 0

            Try
                If (String.IsNullOrEmpty(.ISBNTextBox.Text) = False) Then
                    strSQL = "Update order_line set isbn = " & .ISBNTextBox.Text & " where id = " & .OrderLineIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    updated = 1
                End If
                If (String.IsNullOrEmpty(.CostEachTextBox.Text) = False) Then
                    strSQL = "Update order_line set cost_each = " & .CostEachTextBox.Text & " where id = " & .OrderLineIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    updated = 1
                End If
                If (String.IsNullOrEmpty(.QuantityTextBox.Text) = False) Then
                    strSQL = "Update order_line set quantity = " & .QuantityTextBox.Text & " where id = " & .OrderLineIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    updated = 1
                End If
                If updated Then
                    MsgBox("Order line successfully updated.")
                    Call Clear_Boxes()
                Else
                    MsgBox("Make sure to input an order line id to find the order line and a data to update.")
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an order line id to find the order line to update.")
            End Try

            Call Disconnect_to_DB()

        End With
    End Sub

    Private Sub btnDeleteOrderLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOrderLine.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Delete from order_line where id = " & .OrderLineIDTextBox.Text
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Order line succssfully deleted.")
                Call Clear_Boxes()

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an order line id to find the order line to delete.")
            End Try

            Call Disconnect_to_DB()


        End With
    End Sub

    Private Sub btnUpdateOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateOrder.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim updated As Integer = 0

            Try
                If (String.IsNullOrEmpty(.CustomerIDTextBox.Text) = False) Then
                    strSQL = "Update `order` set customer_id = " & .CustomerIDTextBox.Text & " where order_id = " & .OrderIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    updated = 1
                End If
                If (String.IsNullOrEmpty(.OrderFilledTextBox.Text) = False) Then
                    strSQL = "Update `order` set order_filled = " & .OrderFilledTextBox.Text & " where order_id = " & .OrderIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    updated = 1
                End If

                If updated Then
                    MsgBox("Order successfully updated.")
                    Call Clear_Boxes()
                Else
                    MsgBox("Make sure to input an order id to find the order and a data to update.")
                End If


            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an order id to find the order to update.")
            End Try
            Call Disconnect_to_DB()
        End With
    End Sub
    Private Sub btnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOrder.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Delete from `order` where order_id = " & .OrderIDTextBox.Text
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Order succssfully deleted.")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an order id to find the order to delete.")
            End Try
            Call Disconnect_to_DB()
        End With
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .OrderIDTextBox.Text = ""
            .CustomerIDTextBox.Text = ""
            .OrderFilledTextBox.Text = ""
            .OrderLineIDTextBox.Text = ""
            .ISBNTextBox.Text = ""
            .CostEachTextBox.Text = ""
            .QuantityTextBox.Text = ""
        End With
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        With Me
            .Hide()
            HomeForm.Show()
        End With
    End Sub

    Private Sub btnImportOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportOrder.Click
        Using ofd As New OpenFileDialog() With {.Filter = "CSV file|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of Order) = New List(Of Order)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    list.Add(New Order() With {
                        .order_id = data(0),
                        .CUSTOMER_ID = data(1),
                        .ORDER_DATE = data(2),
                        .ORDER_FILLED = data(3)
                    })

                Next
                dgOrder.DataSource = list
            End If
        End Using

        Call InsertToDB()
    End Sub

    Private Sub InsertToDB()
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                For i As Integer = 0 To dgOrder.Rows.Count - 1 Step +1
                    mycmd = New MySqlCommand("Insert into `order` values (@order_id, @CUSTOMER_ID, @ORDER_DATE, @ORDER_FILLED)", myconn)
                    mycmd.Parameters.Add("@order_id", MySqlDbType.Int64).Value = dgOrder.Rows(i).Cells(0).Value.ToString()
                    mycmd.Parameters.Add("@CUSTOMER_ID", MySqlDbType.Int64).Value = dgOrder.Rows(i).Cells(1).Value.ToString()
                    mycmd.Parameters.Add("@ORDER_DATE", MySqlDbType.Date).Value = dgOrder.Rows(i).Cells(2).Value.ToString()
                    mycmd.Parameters.Add("@ORDER_FILLED", MySqlDbType.Int64).Value = dgOrder.Rows(i).Cells(3).Value.ToString()
                    mycmd.ExecuteNonQuery()
                    MsgBox("Order successfully added.")
                Next
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Public sqlColumns As String = "order_id, CUSTOMER_ID, ORDER_DATE, ORDER_FILLED"

    Private Sub Load_Data_to_Grid(ByVal strsql As String)
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable
        Connect_to_DB()
        With Me
            Try
                mycommand.Connection = myconn
                mycommand.CommandText = strsql
                myreader = mycommand.ExecuteReader
                mydatatable = New DataTable
                myreader.Close()
                mydataAdapter.SelectCommand = mycommand
                mydataAdapter.Fill(mydatatable)
                dgOrder.AutoSize = True
                .dgOrder.Refresh()
                .dgOrder.EndEdit()
                .dgOrder.DataSource = mydatatable
                .dgOrder.ReadOnly = True
                .dgOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                '.dgOrder.Columns("ORDER_DATE").DefaultCellStyle.Format = "d"


            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub frmDatagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from `order`")
    End Sub

    Private Sub btnExportOrder_Click(sender As Object, e As EventArgs) Handles btnExportOrder.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File | *.csv"
        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgColumns As List(Of String) = dgOrder.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.DataPropertyName).ToList()
                sw.WriteLine(String.Join(",", dgColumns))
                For Each row As DataGridViewRow In dgOrder.Rows
                    Dim rowData As New List(Of String)
                    For Each column As DataGridViewColumn In dgOrder.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next
                Process.Start(sfd.FileName)
            End Using
        End If
    End Sub

    Private Sub btnReloadOrder_Click(sender As Object, e As EventArgs) Handles btnReloadOrder.Click
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from `order`")
    End Sub

    Private Sub btnImportOrderLine_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportOrderLine.Click
        Using ofd As New OpenFileDialog() With {.Filter = "CSV file|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of OrderLine) = New List(Of OrderLine)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    list.Add(New OrderLine() With {
                        .ID = data(0),
                        .ISBN = data(1),
                        .ORDER_ID = data(2),
                        .COST_EACH = data(3),
                        .COST_LINE = data(4),
                        .QUANTITY = data(5)
                    })

                Next
                dgOrderLine.DataSource = list
            End If
        End Using

        Call InsertToDB2()
    End Sub

    Private Sub InsertToDB2()
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                For i As Integer = 0 To dgOrderLine.Rows.Count - 1 Step +1
                    mycmd = New MySqlCommand("Insert into order_line values (@ID, @ISBN, @ORDER_ID, @COST_EACH, @COST_LINE, @QUANTITY)", myconn)
                    mycmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = dgOrderLine.Rows(i).Cells(0).Value.ToString()
                    mycmd.Parameters.Add("@ISBN", MySqlDbType.Int64).Value = dgOrderLine.Rows(i).Cells(1).Value.ToString()
                    mycmd.Parameters.Add("@ORDER_ID", MySqlDbType.Int64).Value = dgOrderLine.Rows(i).Cells(2).Value.ToString()
                    mycmd.Parameters.Add("@COST_EACH", MySqlDbType.Int64).Value = dgOrderLine.Rows(i).Cells(3).Value.ToString()
                    mycmd.Parameters.Add("@COST_LINE", MySqlDbType.Int64).Value = dgOrderLine.Rows(i).Cells(4).Value.ToString()
                    mycmd.Parameters.Add("@QUANTITY", MySqlDbType.Int64).Value = dgOrderLine.Rows(i).Cells(5).Value.ToString()
                    mycmd.ExecuteNonQuery()
                    MsgBox("Order Line successfully added.")
                Next
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Public sqlColumns2 As String = "ID, ISBN, ORDER_ID, COST_EACH, COST_LINE, QUANTITY"

    Private Sub Load_Data_to_Grid2(ByVal strsql As String)
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable
        Connect_to_DB()
        With Me
            Try
                mycommand.Connection = myconn
                mycommand.CommandText = strsql
                myreader = mycommand.ExecuteReader
                mydatatable = New DataTable
                myreader.Close()
                mydataAdapter.SelectCommand = mycommand
                mydataAdapter.Fill(mydatatable)
                dgOrderLine.AutoSize = True
                .dgOrderLine.Refresh()
                .dgOrderLine.EndEdit()
                .dgOrderLine.DataSource = mydatatable
                .dgOrderLine.ReadOnly = True
                .dgOrderLine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub frmDatagrid_Load2(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_to_Grid2("select " & Me.sqlColumns2 & " from order_line")
    End Sub

    Private Sub btnExportOrderLine_Click(sender As Object, e As EventArgs) Handles btnExportOrderLine.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File | *.csv"
        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgColumns As List(Of String) = dgOrderLine.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.DataPropertyName).ToList()
                sw.WriteLine(String.Join(",", dgColumns))
                For Each row As DataGridViewRow In dgOrderLine.Rows
                    Dim rowData As New List(Of String)
                    For Each column As DataGridViewColumn In dgOrderLine.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next
                Process.Start(sfd.FileName)
            End Using
        End If
    End Sub

    Private Sub btnReloadOrderLine_Click(sender As Object, e As EventArgs) Handles btnReloadOrderLine.Click
        Call Load_Data_to_Grid2("select " & Me.sqlColumns2 & " from order_line")
    End Sub
End Class