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

    Function AddNewUser(username As String, password As String, level As UserAccount.AccountLevel) As AccountInfo
        ' return a new account information if add is successful
        Return New AccountInfo(1, UserAccount.AccountLevel.Administation)
        ' otherwise throw exception
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <exception cref="DatabaseExceptions.LoginFailedException">The Login Failed</exception>
    Function LoginUser(username As String, password As String) As AccountInfo
        ' return a new account information if login is successful
        Return New AccountInfo(1, UserAccount.AccountLevel.Administation)
        ' otherwise throw exception
        Throw New DatabaseExceptions.LoginFailedException()
    End Function

    Sub ChangeAccountLevel(userID As Integer, newLevel As UserAccount.AccountLevel)

    End Sub

    ' Dispose
    Public Sub Dispose()
        conn.Close()
    End Sub


    Public Class AccountInfo
        Public Sub New(pID As Integer, pLevel As UserAccount.AccountLevel)
            ID = pID
            Level = pLevel
        End Sub

        Public ID As Integer
        Public Level As UserAccount.AccountLevel
    End Class

    Public Class DatabaseExceptions
        Public Class LoginFailedException : Inherits Exception : End Class

    End Class

End Class
