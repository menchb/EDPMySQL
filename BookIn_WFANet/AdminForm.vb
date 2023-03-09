Imports MySql.Data.MySqlClient
Public Class AdminForm
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Insert into `user` (username, password) values ('" _
                    & .UsernameTextBox.Text & "', MD5('" _
                    & .PasswordTextBox.Text & "'))"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("User successfully added.")
                Call Clear_Boxes()

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
End Class