Imports System.IO
Imports MySql.Data.MySqlClient

Public Class BookForm
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            ' TODO: If publisher is empty (book is self-published), write 0 instead of NULL.

            Try
                ' Insert book info to database
                If String.IsNullOrEmpty(.ISBNTextBox.Text) = False And
                    String.IsNullOrEmpty(.TitleTextBox.Text) = False _
                    And String.IsNullOrEmpty(.PublicationYearTextBox.Text) = False _
                    And String.IsNullOrEmpty(.StocksTextBox.Text) = False _
                    And String.IsNullOrEmpty(.RetailPriceTextBox.Text) = False Then

                    Try
                        strSQL = "Insert into book values (" _
                        & .ISBNTextBox.Text & ", '" _
                        & .TitleTextBox.Text & "', " _
                        & .PublicationYearTextBox.Text & ", " _
                        & .RetailPriceTextBox.Text & ", " _
                        & .StocksTextBox.Text & ", " _
                        & GetAuthorID() & ", " _
                        & GetPublisherID() & ")"

                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                        MsgBox("Book successfully added.")
                        Call Clear_Boxes()
                    Catch ex As MySqlException
                        MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                               & "Make sure to input isbn, title, publication year, retail price, stocks, author, and publisher.")
                    End Try
                Else
                    MsgBox("Make sure to input isbn, title, publication year, retail price, stocks, author, and publisher.")
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
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
                strSQL = "Select * from book where isbn = " & .ISBNTextBox.Text
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                myreader = mycmd.ExecuteReader()

                If myreader.HasRows Then
                    myreader.Close()
                    If (String.IsNullOrEmpty(TitleTextBox.Text) = False) Then
                        strSQL = "Update book set title = '" & .TitleTextBox.Text & "' where isbn = " & .ISBNTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(PublicationYearTextBox.Text) = False) Then
                        strSQL = "Update book set publication_year = " & .PublicationYearTextBox.Text & " where isbn = " & .ISBNTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(RetailPriceTextBox.Text) = False) Then
                        strSQL = "Update book set retail_price = " & RetailPriceTextBox.Text & " where isbn = " & .ISBNTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(StocksTextBox.Text) = False) Then
                        strSQL = "Update book set stocks = " & StocksTextBox.Text & " where isbn = " & .ISBNTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(AuthorTextBox.Text) = False) Then
                        strSQL = "Update book set author_id = " & GetAuthorID() & " where isbn = " & .ISBNTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    If (String.IsNullOrEmpty(PublisherTextBox.Text) = False) Then
                        strSQL = "Update book set publisher_id = " & GetPublisherID() & " where isbn = " & .ISBNTextBox.Text
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    End If
                    MsgBox("Book successfully updated.")
                    Call Clear_Boxes()
                Else
                    MsgBox("Unknown ISBN")
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an isbn to find the book to update.")
            End Try

            Call Disconnect_to_DB()
        End With

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Delete from book where isbn = " & .ISBNTextBox.Text
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()

                MsgBox("Book successfully deleted.")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message & vbCrLf & vbCrLf _
                       & "Make sure to input an isbn to find the book to delete.")
            End Try


            Call Disconnect_to_DB()
        End With
    End Sub

    Function GetAuthorID() As Integer
        With Me

            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            Dim authorFound As Boolean = False
            Dim authorID As Integer

            While authorFound = False
                strSQL = "Select * from author where author_name = '" & .AuthorTextBox.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                myreader = mycmd.ExecuteReader


                If myreader.HasRows Then
                    'if author is found get id and store into variable
                    While myreader.Read
                        authorID = myreader.GetString("ID")
                    End While
                    authorFound = True
                    myreader.Close()
                Else
                    'if not found, create author
                    Try
                        myreader.Close()
                        strSQL = "Insert into author (AUTHOR_NAME) values('" _
                                & .AuthorTextBox.Text & "')"
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    Catch ex As MySqlException
                        MsgBox(ex.Number & " " & ex.Message)
                    End Try
                End If
            End While

            Return authorID
        End With

    End Function

    Function GetPublisherID() As Integer
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            Dim publisherFound As Boolean = False
            Dim publisherID As Integer

            While publisherFound = False
                strSQL = "Select * from publisher where publisher_name = '" & .PublisherTextBox.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                myreader = mycmd.ExecuteReader
                If myreader.HasRows Then
                    'if publisher is found get id and store into variable
                    While myreader.Read
                        publisherID = myreader.GetString("ID")
                    End While
                    publisherFound = True
                    myreader.Close()
                Else
                    'if not found, create publisher
                    Try
                        myreader.Close()
                        strSQL = "Insert into publisher (publisher_NAME) values('" _
                        & .PublisherTextBox.Text & "')"
                        mycmd.CommandText = strSQL
                        mycmd.Connection = myconn
                        mycmd.ExecuteNonQuery()
                    Catch ex As MySqlException
                        MsgBox(ex.Number & " " & ex.Message)
                    End Try
                End If
            End While

            Return publisherID
        End With
    End Function

    Private Sub Clear_Boxes()
        With Me
            .ISBNTextBox.Text = ""
            .TitleTextBox.Text = ""
            .PublicationYearTextBox.Text = ""
            .RetailPriceTextBox.Text = ""
            .StocksTextBox.Text = ""
            .AuthorTextBox.Text = ""
            .PublisherTextBox.Text = ""
        End With
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        With Me
            .Hide()
            HomeForm.Show()
        End With
    End Sub


    Private Sub btnImportBook_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportBook.Click
        Using ofd As New OpenFileDialog() With {.Filter = "CSV file|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of Book) = New List(Of Book)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    list.Add(New Book() With {
                        .ISBN = data(0),
                        .TITLE = data(1),
                        .PUBLICATION_YEAR = data(2),
                        .RETAIL_PRICE = data(3),
                        .STOCKS = data(4),
                        .AUTHOR_ID = data(5),
                        .PUBLISHER_ID = data(6)
                            })
                Next
                'BookBindingSource.DataSource = list
                dgBook.DataSource = list
            End If
        End Using

        Call InsertToDB()
    End Sub

    Private Sub InsertToDB()
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                For i As Integer = 0 To dgBook.Rows.Count - 1 Step +1
                    mycmd = New MySqlCommand("Insert into book values (@ISBN, @TITLE, @PUBLICATION_YEAR, @RETAIL_PRICE, @STOCKS, @AUTHOR_ID, @PUBLISHER_ID)", myconn)
                    mycmd.Parameters.Add("@ISBN", MySqlDbType.Int64).Value = dgBook.Rows(i).Cells(0).Value.ToString()
                    mycmd.Parameters.Add("@TITLE", MySqlDbType.VarChar).Value = dgBook.Rows(i).Cells(1).Value.ToString()
                    mycmd.Parameters.Add("@PUBLICATION_YEAR", MySqlDbType.Int64).Value = dgBook.Rows(i).Cells(2).Value.ToString()
                    mycmd.Parameters.Add("@RETAIL_PRICE", MySqlDbType.Int64).Value = dgBook.Rows(i).Cells(3).Value.ToString()
                    mycmd.Parameters.Add("@STOCKS", MySqlDbType.Int64).Value = dgBook.Rows(i).Cells(4).Value.ToString()
                    mycmd.Parameters.Add("@AUTHOR_ID", MySqlDbType.Int64).Value = dgBook.Rows(i).Cells(5).Value.ToString()
                    mycmd.Parameters.Add("@PUBLISHER_ID", MySqlDbType.Int64).Value = dgBook.Rows(i).Cells(6).Value.ToString()
                    mycmd.ExecuteNonQuery()
                    MsgBox("Book successfully added.")
                Next
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Public sqlColumns As String = "isbn, title, publication_year, retail_price, stocks, author_id, publisher_id"

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
                dgBook.AutoSize = True
                .dgBook.Refresh()
                .dgBook.EndEdit()
                .dgBook.DataSource = mydatatable
                .dgBook.ReadOnly = True
                .dgBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub
    Private Sub frmDatagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from book")
    End Sub

    Private Sub btnExportBook_Click(sender As Object, e As EventArgs) Handles btnExportBook.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File | *.csv"
        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgColumns As List(Of String) = dgBook.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.DataPropertyName).ToList()
                sw.WriteLine(String.Join(",", dgColumns))
                For Each row As DataGridViewRow In dgBook.Rows
                    Dim rowData As New List(Of String)
                    For Each column As DataGridViewColumn In dgBook.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next
                Process.Start(sfd.FileName)
            End Using
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from book")
    End Sub
End Class