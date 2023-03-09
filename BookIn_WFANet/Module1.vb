Imports MySql.Data.MySqlClient
Module Module1
    Public myconn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String
    Public strSQL As String

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=MyNewPass;" _
            & "database=bookin"
        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()

        Catch ex As Mysql.Data.MySqlClient.MySqlException
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
End Module
