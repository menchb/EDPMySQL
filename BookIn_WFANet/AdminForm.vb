Imports System.IO
Imports MySql.Data.MySqlClient
Public Class AdminForm
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                If String.IsNullOrEmpty(.UsernameTextBox.Text) = False And String.IsNullOrEmpty(.PasswordTextBox.Text) = False Then
                    strSQL = "Insert into `user` (username, password) values ('" _
                        & .UsernameTextBox.Text & "', MD5('" _
                        & .PasswordTextBox.Text & "'))"
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("User successfully added.")
                    Call Clear_Boxes()
                Else
                    MsgBox("Make sure to input username and password.")
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input username and password.")
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                If String.IsNullOrEmpty(.UsernameTextBox.Text) = False Then
                    strSQL = "Update `user` set username = '" & .UsernameTextBox.Text & "' where id = " & .IDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                End If
                If String.IsNullOrEmpty(.PasswordTextBox.Text) Then
                    strSQL = "Update `user` set password = '" & .PasswordTextBox.Text & "' where id = " & .IDTextBox.Text
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                End If
                MsgBox("User successfully updated.")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an id to find the user admin to update.")
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Delete from `user` where id = " & .IDTextBox.Text
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("User successfully deleted.")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an id to find the user admin to delete.")
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .IDTextBox.Text = ""
            .UsernameTextBox.Text = ""
            .PasswordTextBox.Text = ""
        End With
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        With Me
            .Hide()
            HomeForm.Show()
        End With
    End Sub

    Private Sub btnImportAdmin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportAdmin.Click
        Using ofd As New OpenFileDialog() With {.Filter = "CSV file|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of Admin) = New List(Of Admin)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    list.Add(New Admin() With {
                        .username = data(0),
                        .password = data(1),
                        .id = data(2)
                    })

                Next
                dgAdmin.DataSource = list
            End If
        End Using

        Call InsertToDB()
    End Sub

    Private Sub InsertToDB()

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                For i As Integer = 0 To dgAdmin.Rows.Count - 1 Step +1
                    mycmd = New MySqlCommand("Insert into user values (@username, @password, @id)", myconn)
                    mycmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = dgAdmin.Rows(i).Cells(0).Value.ToString()
                    mycmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = dgAdmin.Rows(i).Cells(1).Value.ToString()
                    mycmd.Parameters.Add("@id", MySqlDbType.Int64).Value = dgAdmin.Rows(i).Cells(2).Value.ToString()

                    'mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Admin successfully added.")
                Next
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try

            Disconnect_to_DB()
        End With


    End Sub

    Public sqlColumns As String = "username, password, id"
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
                dgAdmin.AutoSize = True
                .dgAdmin.Refresh()
                .dgAdmin.EndEdit()
                .dgAdmin.DataSource = mydatatable
                .dgAdmin.ReadOnly = True
                .dgAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub
    Private Sub frmDatagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from user")
    End Sub

    Private Sub btnExportAdmin_Click(sender As Object, e As EventArgs) Handles btnExportAdmin.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File | *.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgColumns As List(Of String) = dgAdmin.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.DataPropertyName).ToList()
                sw.WriteLine(String.Join(",", dgColumns))

                For Each row As DataGridViewRow In dgAdmin.Rows
                    Dim rowData As New List(Of String)
                    For Each column As DataGridViewColumn In dgAdmin.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next

                Process.Start(sfd.FileName)
            End Using
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from user")
    End Sub

End Class