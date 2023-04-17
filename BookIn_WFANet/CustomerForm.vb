Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CustomerForm

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Insert into customer (first_name, last_name, city, province, zip, phone, email) values ('" _
                    & .FirstNameTextBox.Text & "', '" _
                    & .LastNameTextBox.Text & "', '" _
                    & .CityTextBox.Text & "', '" _
                    & .ProvinceTextBox.Text & "', " _
                    & .ZIPTextBox.Text & ", '" _
                    & .PhoneTextBox.Text & "', '" _
                    & .EmailTextBox.Text & "')"

                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Customer successfully added.")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input the customer's first name, last name, city, province, zip, phone, and email.")
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        With Me

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            Try
                strSQL = "Select * from customer where id = " & .IDTextBox.Text
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                myreader = mycmd.ExecuteReader()

                If myreader.HasRows Then
                    myreader.Close()
                    If (String.IsNullOrEmpty(FirstNameTextBox.Text) = False) Then
                        strSQL = "Update customer set first_name= '" & .FirstNameTextBox.Text & "' where id = " & .IDTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(LastNameTextBox.Text) = False) Then
                        strSQL = "Update customer set last_name = " & .LastNameTextBox.Text & " where id = " & .IDTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(CityTextBox.Text) = False) Then
                        strSQL = "Update customer set city = " & CityTextBox.Text & " where id = " & .IDTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(ProvinceTextBox.Text) = False) Then
                        strSQL = "Update customer set province = " & ProvinceTextBox.Text & " where id = " & .IDTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(ZIPTextBox.Text) = False) Then
                        strSQL = "Update customer set zip = " & ZIPTextBox.Text & " where id = " & .IDTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(PhoneTextBox.Text) = False) Then
                        strSQL = "Update customer set phone = " & PhoneTextBox.Text & " where id = " & .IDTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(EmailTextBox.Text) = False) Then
                        strSQL = "Update customer set email = " & EmailTextBox.Text & " where id = " & .IDTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.ExecuteNonQuery()
                    End If
                    MsgBox("Customer successfully updated.")
                    Call Clear_Boxes()
                Else
                    MsgBox("Unknown ID")
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an id to find the customer to update.")
            End Try

            Call Disconnect_to_DB()
        End With

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Delete from customer where id = " & .IDTextBox.Text
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()

                MsgBox("Customer successfully deleted.")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an id to find the customer to delete.")
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .IDTextBox.Text = ""
            .FirstNameTextBox.Text = ""
            .LastNameTextBox.Text = ""
            .CityTextBox.Text = ""
            .ProvinceTextBox.Text = ""
            .ZIPTextBox.Text = ""
            .PhoneTextBox.Text = ""
            .EmailTextBox.Text = ""
        End With
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        With Me
            .Hide()
            HomeForm.Show()
        End With
    End Sub

    Private Sub btnImportCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportCustomer.Click
        Using ofd As New OpenFileDialog() With {.Filter = "CSV file|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of Customer) = New List(Of Customer)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    list.Add(New Customer() With {
                        .ID = data(0),
                        .FIRST_NAME = data(1),
                        .LAST_NAME = data(2),
                        .CITY = data(3),
                        .PROVINCE = data(4),
                        .ZIP = data(5),
                        .PHONE = data(6),
                        .EMAIL = data(7),
                        .TOTAL_SPENT = data(8)
                    })


                Next
                dgCustomer.DataSource = list
            End If
        End Using

        Call InsertToDB()
    End Sub

    Private Sub InsertToDB()

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                For i As Integer = 0 To dgCustomer.Rows.Count - 1 Step +1
                    mycmd = New MySqlCommand("Insert into customer values (@ID, @FIRST_NAME, @LAST_NAME, @CITY, @PROVINCE, @ZIP, @PHONE, @EMAIL, @TOTAL_SPENT)", myconn)
                    mycmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = dgCustomer.Rows(i).Cells(0).Value.ToString()
                    mycmd.Parameters.Add("@FIRST_NAME", MySqlDbType.VarChar).Value = dgCustomer.Rows(i).Cells(1).Value.ToString()
                    mycmd.Parameters.Add("@LAST_NAME", MySqlDbType.VarChar).Value = dgCustomer.Rows(i).Cells(2).Value.ToString()
                    mycmd.Parameters.Add("@CITY", MySqlDbType.VarChar).Value = dgCustomer.Rows(i).Cells(3).Value.ToString()
                    mycmd.Parameters.Add("@PROVINCE", MySqlDbType.VarChar).Value = dgCustomer.Rows(i).Cells(4).Value.ToString()
                    mycmd.Parameters.Add("@ZIP", MySqlDbType.Int64).Value = dgCustomer.Rows(i).Cells(5).Value.ToString()
                    mycmd.Parameters.Add("@PHONE", MySqlDbType.VarChar).Value = dgCustomer.Rows(i).Cells(6).Value.ToString()
                    mycmd.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = dgCustomer.Rows(i).Cells(7).Value.ToString()
                    mycmd.Parameters.Add("@TOTAL_SPENT", MySqlDbType.Double).Value = dgCustomer.Rows(i).Cells(8).Value.ToString()

                    'mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Customer successfully added.")
                Next
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try

            Disconnect_to_DB()
        End With


    End Sub

    Public sqlColumns As String = "id, first_name, last_name, city, province, zip, phone, email, total_spent"
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
                dgCustomer.AutoSize = True
                .dgCustomer.Refresh()
                .dgCustomer.EndEdit()
                .dgCustomer.DataSource = mydatatable
                .dgCustomer.ReadOnly = True
                .dgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub
    Private Sub frmDatagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from customer")
    End Sub

    Private Sub btnExportCustomer_Click(sender As Object, e As EventArgs) Handles btnExportCustomer.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File | *.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgColumns As List(Of String) = dgCustomer.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.DataPropertyName).ToList()
                sw.WriteLine(String.Join(",", dgColumns))

                For Each row As DataGridViewRow In dgCustomer.Rows
                    Dim rowData As New List(Of String)
                    For Each column As DataGridViewColumn In dgCustomer.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next

                Process.Start(sfd.FileName)
            End Using
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from customer")
    End Sub

End Class