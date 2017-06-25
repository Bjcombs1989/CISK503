''' <summary>
''' This class will be used to manage the user account. 
''' </summary>
''' <date>2017-06-07</date>
''' <author>Brian Combs</author>
Public Class UserAccount
    Dim _username As String
    Dim _password As String
    Dim _id As Integer
    Dim _level As AccountLevel
    Dim mysql As MySQLDatabaseConnector

    ''' <summary>
    ''' This property will be read only and shows the other 
    ''' parts of the program the account level, but doesn't 
    ''' allow them to modify it
    ''' </summary>
    ''' <returns>The AccountLevel that is assigned to the account</returns>
    ''' <date>2017-06-07</date>
    ''' <author>Brian Combs</author>
    Public ReadOnly Property Level As AccountLevel
        Get
            Return _level
        End Get
    End Property

    ''' <summary>
    ''' This constructor will be used to login to an existing account
    ''' </summary>
    ''' <param name="pUsername">The username of an existing account</param>
    ''' <param name="pPassword">The password of the account</param>
    ''' <date>2017-06-07</date>
    ''' <exception cref="DatabaseException.LoginException"></exception>
    ''' <author>Brian Combs</author>
    Public Sub New(pMySQL As MySQLDatabaseConnector, pUsername As String, pPassword As String)
        ' Set the "Class" variables to the values of the parameters on the constructor
        mysql = pMySQL
        _username = pUsername
        _password = pPassword
        ' Declare a variable to hold the data from the database and call the Login function
        Try
            Dim login As MySQLDatabaseConnector.AccountInfo = mysql.LoginUser(_username, HashPassword(_password))

            If login Is Nothing Then
                Throw New DatabaseException.LoginException()
            End If

            _id = login.ID
            _level = login.Level
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    ''' <summary>
    ''' This constructor will be used to create a new accoutn
    ''' </summary>
    ''' <param name="pUsername"></param>
    ''' <param name="pPassword"></param>
    ''' <param name="pLevel"></param>
    ''' <date>2017-06-07</date>
    ''' 
    ''' <author>Brian Combs</author>
    Public Sub New(pMySQL As MySQLDatabaseConnector, pUsername As String, pPassword As String, pLevel As AccountLevel)
        ' Set the "Class" variables to the values of the parameters on the constructor
        mysql = pMySQL
        _username = pUsername
        _password = pPassword
        _level = pLevel

        ' Declare a variable to hold the data from the database and call the Login function
        Try
            Dim login As MySQLDatabaseConnector.AccountInfo = mysql.AddNewUser(_username, HashPassword(_password), _level)
            _id = login.ID
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' This method will be used to change the permissions on this account
    ''' </summary>
    ''' <param name="authorized_account"></param>
    ''' <param name="new_level"></param>
    Public Sub UpdateLevel(authorized_account As UserAccount, new_level As AccountLevel)
        If authorized_account.Level = AccountLevel.Administation Then
            ' Declare a database variable
            Try
                mysql.ChangeAccountLevel(authorized_account._id, new_level)
                _level = new_level
            Catch ex As DatabaseException

            End Try
            ' Update this instance of the class
        Else
            Throw New DatabaseException.PermissionsNotSufficientException("Account not authorized to update account type")
        End If

    End Sub


    ''' <summary>
    ''' This function hashes the password using the SHA1 algorithm
    ''' </summary>
    ''' <param name="password">Plain Text Password</param>
    ''' <returns>SHA1 Hash of Password</returns>
    ''' <date>2017-06-07</date>
    ''' <author>Brian Combs</author>
    Private Function HashPassword(password As String) As String
        Return password & "hashed"
    End Function

    ''' <summary>
    ''' This enum will be used to manage account permissions
    ''' </summary>
    ''' <date>2017-06-07</date>
    ''' <author>Brian Combs</author>
    Public Enum AccountLevel
        Patron = 0
        Circulation = 1
        Administation = 2
    End Enum
End Class
