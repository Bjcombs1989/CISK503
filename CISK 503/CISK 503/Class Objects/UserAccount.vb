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
    ''' 
    ''' </summary>
    ''' <param name="pUsername"></param>
    ''' <param name="pPassword"></param>
    ''' <date>2017-06-07</date>
    ''' <author>Brian Combs</author>
    Public Sub New(ByRef mysql As MySQLDatabaseConnector, ByVal pUsername As String, ByVal pPassword As String)
        ' Set the "Class" variables to the values of the parameters on the constructor
        _username = pUsername
        _password = pPassword
        ' Declare a variable to hold the data from the database and call the Login function
        Try
            Dim login As MySQLDatabaseConnector.AccountInfo = mysql.LoginUser(_username, HashPassword(_password))
        Catch ex As MySQLDatabaseConnector.DatabaseExceptions.LoginFailedException

        Catch ex As Exception

        End Try

        ' Check if the user account was returned, if not, throw a new exception
        If Not login Then
            Throw New ApplicationException("Login Failed")
        End If
        ' Get the first row of the data returned
        Dim row As DataRow = Data.Rows(0)
        _id = Integer.Parse(row("id"))
        _level = Integer.Parse(row("account_level")) ' This gets the int value of the account level and converts to the enum

    End Sub

    ''' <summary>
    ''' This constructor will be used to create a new accoutn
    ''' </summary>
    ''' <param name="pUsername"></param>
    ''' <param name="pPassword"></param>
    ''' <param name="pLevel"></param>
    ''' <date>2017-06-07</date>
    ''' <author>Brian Combs</author>
    Public Sub New(pUsername As String, pPassword As String, pLevel As AccountLevel)
        ' Set the "Class" variables to the values of the parameters on the constructor
        _username = pUsername
        _password = pPassword
        _level = pLevel
        ' Declare a database variable
        Dim db = New LibraryDataSetTableAdapters.UserAccountTableAdapter()
        ' Add the new user to the database and get the ID back from the function
        _id = db.AddNewUser(_username, HashPassword(_password), _level)
    End Sub

    ''' <summary>
    ''' This method will be used to change the permissions on this account
    ''' </summary>
    ''' <param name="authorized_account"></param>
    ''' <param name="new_level"></param>
    Public Sub UpdateLevel(authorized_account As UserAccount, new_level As AccountLevel)
        If authorized_account.Level = AccountLevel.Administation Then
            ' Declare a database variable
            Dim db = New LibraryDataSetTableAdapters.UserAccountTableAdapter()
            ' Update the database
            db.UpdateLevel(new_level, _id)
            ' Update this instance of the class
            _level = new_level
        Else
            Throw New ApplicationException("Account not authorized to update account type")
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
        Dim data() As Byte = System.Text.Encoding.Unicode.GetBytes(password)
        Dim result() As Byte

        Dim sha As New System.Security.Cryptography.SHA1CryptoServiceProvider()

        result = sha.ComputeHash(data)

        Return result.ToString()
    End Function

    ''' <summary>
    ''' This enum will be used to manage account permissions
    ''' </summary>
    ''' <date>2017-06-07</date>
    ''' <author>Brian Combs</author>
    Public Enum AccountLevel
        User = 0
        Circulation = 1
        Administation = 2
    End Enum
End Class
