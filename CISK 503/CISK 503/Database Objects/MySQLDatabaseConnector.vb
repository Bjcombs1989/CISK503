Imports MySql.Data.MySqlClient

Public Class MySQLDatabaseConnector
    Dim conn As New MySqlConnection
    Dim DatabaseName As String = "combsan1_tamuct"
    Dim server As String = "www.combsandcombs.com"
    Dim userName As String = "combsan1_tamuct"
    Dim password As String = "gii{M[Ag$=gb"

    ' Constructor
    Public Sub New()
        ' Start by making sure the conn is closed
        If Not conn Is Nothing Then conn.Close()

        ' Create the connection string
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)

        ' Try to open the connection
        Try
            conn.Open()
        Catch ex As Exception
            Throw ex
        End Try



    End Sub

    ' Methods
    Sub ExecuteNonQuery(mySQL As String)
        Dim cmd As New MySqlCommand(mySQL, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub AddNewUser(username As String, password As String, level As UserAccount.AccountLevel)
        Dim sql As String = String.Format("INSERT INTO `User`(`Password`, `Username`, `Account_Level`)" &
                                          " VALUES ('{0}','{1}',{2})",
                                           password, username, level)

        ExecuteNonQuery(sql)
    End Sub

    Sub LoginUser(username As String, password As String)

    End Sub

    Sub ChangeAccountLevel(userID As Integer, newLevel As UserAccount.AccountLevel)

    End Sub

    ' Dispose
    Public Sub Dispose()
        conn.Close()
    End Sub

End Class
