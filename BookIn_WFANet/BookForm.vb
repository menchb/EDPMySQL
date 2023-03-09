Imports MySql.Data.MySqlClient

Public Class BookForm
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                ' Insert book info to database
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
End Class