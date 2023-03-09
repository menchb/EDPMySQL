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

            Try
                If (String.IsNullOrEmpty(.ISBNTextBox.Text) = False) Then
                    strSQL = "Update order_line set isbn = " & .ISBNTextBox.Text & " where id = " & .OrderLineIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                End If
                If (String.IsNullOrEmpty(.CostEachTextBox.Text) = False) Then
                    strSQL = "Update order_line set cost_each = " & .CostEachTextBox.Text & " where id = " & .OrderLineIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                End If
                If (String.IsNullOrEmpty(.QuantityTextBox.Text) = False) Then
                    strSQL = "Update order_line set quantity = " & .QuantityTextBox.Text & " where id = " & .OrderLineIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                End If
                MsgBox("Order line successfully updated.")
                Call Clear_Boxes()

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

            Try
                If (String.IsNullOrEmpty(.CustomerIDTextBox.Text) = False) Then
                    strSQL = "Update `order` set customer_id = " & .CustomerIDTextBox.Text & " where order_id = " & .OrderIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()

                End If
                If (String.IsNullOrEmpty(.OrderFilledTextBox.Text) = False) Then
                    strSQL = "Update `order` set order_filled = " & .OrderFilledTextBox.Text & " where order_id = " & .OrderIDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                End If
                MsgBox("Order successfully updated.")
                Call Clear_Boxes()

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


End Class