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
                       & "Make sure to input an id to find the customer to update.")
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
End Class