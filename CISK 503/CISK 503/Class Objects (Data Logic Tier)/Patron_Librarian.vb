Imports CISK_503

Public Class Librarian
    Inherits Patron

    Public Sub New(pMySQL As MySQLDatabaseConnector, pUsername As String, pPassword As String)
        MyBase.New(pMySQL, pUsername, pPassword)
    End Sub

    Public Sub CreateAccount(pUsername As String, pPassword As String)
        Try
            MySQL.AddNewUser(pUsername, pPassword, Patron.AccountLevel.Patron)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Librarian {0}", MyBase.ToString())
    End Function
End Class