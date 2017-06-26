Public Class Administrator
    Inherits Librarian

    Public Sub New(pMySQL As MySQLDatabaseConnector, pUsername As String, pPassword As String)
        MyBase.New(pMySQL, pUsername, pPassword)
    End Sub

    Public Overloads Sub CreateAccount(pUsername As String, pPassword As String, pLevel As Patron.AccountLevel)
        Try
            MySQL.AddNewUser(pUsername, pPassword, pLevel)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub UpdateLevel(account_to_change As Patron, new_level As AccountLevel)
        Try
            MySQL.ChangeAccountLevel(account_to_change.ID, new_level)
        Catch ex As InternalExceptions
            Throw ex
        End Try
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Administrator {0}", MyBase.ToString())
    End Function
End Class
