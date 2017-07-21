''' <summary>
''' This class will be used to manage the user account. 
''' </summary>
''' <date>2017-06-07</date>
''' <author>Brian Combs</author>
Public Class Patron
    Dim _username As String
    Dim _password As String
    Dim _id As Integer
    Dim _level As AccountLevel
    Dim _mysql As MySQLDatabaseConnector
    Protected _feesDue As Decimal

    ' Properties
    ''' <summary>
    ''' This property will be used to access the MySQL in the child objects
    ''' </summary>
    ''' <date>2017-06-26</date>
    ''' <author>Brian Combs</author>
    Public ReadOnly Property MySQL As MySQLDatabaseConnector
        Get
            Return _mysql
        End Get
    End Property
    ''' <summary>
    ''' This property will be used to access the username in the child objects
    ''' </summary>
    ''' <date>2017-06-26</date>
    ''' <author>Brian Combs</author>
    Public ReadOnly Property UserName As String
        Get
            Return _username
        End Get
    End Property
    ''' <summary>
    ''' This property will be used to access the password in the child objects
    ''' </summary>
    ''' <date>2017-06-26</date>
    ''' <author>Brian Combs</author>
    Public ReadOnly Property Password As String
        Get
            Return _password
        End Get
    End Property
    ''' <summary>
    ''' This property will be used to access the id in the child objects
    ''' </summary>
    ''' <date>2017-06-26</date>
    ''' <author>Brian Combs</author>
    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property
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

    ' Constructor(s)
    ''' <summary>
    ''' This constructor will be used to login to an existing account
    ''' </summary>
    ''' <param name="pUsername">The username of an existing account</param>
    ''' <param name="pPassword">The password of the account</param>
    ''' <date>2017-06-07</date>
    ''' <exception cref="InternalExceptions.LoginException"></exception>
    ''' <author>Brian Combs</author>
    Public Sub New(pMySQL As MySQLDatabaseConnector, pUsername As String, pPassword As String)
        ' Set the "Class" variables to the values of the parameters on the constructor
        _mysql = pMySQL
        _username = pUsername
        _password = pPassword
        ' Declare a variable to hold the data from the database and call the Login function
        Try
            Dim login As MySQLDatabaseConnector.AccountInfo = MySQL.LoginUser(_username, HashPassword(_password))

            If login Is Nothing Then
                Throw New InternalExceptions.LoginException()
            End If

            _id = login.ID
            _level = login.Level
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub New(pMySQL As MySQLDatabaseConnector, ID As Integer)
        Dim ac As MySQLDatabaseConnector.AccountInfo = pMySQL.GetUserInfo(ID)

        _id = ID
        _level = ac.Level
        _username = ac.Username
        _password = ac.Password
        _mysql = pMySQL

    End Sub
    ' Methods
    Public Function HashPassword(password As String) As String
        Return password & "hashed"
    End Function

    ''' <summary>
    ''' To string method
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return String.Format("{0}", _username)
    End Function

    ' A patron (or any of it's children) can Place Holds and Remove Holds where it is the patron on it
    Public Sub PlaceHold(book As Book)
        If Not book.IsAvailable Then
            Throw New ConstraintException("This book is not available to be placed on hold")
        End If

        Dim _hold As New Hold(Me, book)
        MySQL.AddHold(_hold)
        book.IsAvailable = False
    End Sub

    Public Overridable Sub RemoveHold(hold As Hold)
        If Not hold.Patron.ID = ID Then
            Throw New InternalExceptions.PermissionsNotSufficientException("You do not have permission to remove a hold for another user")
        End If

        MySQL.RemoveHold(hold)
        hold.Book.IsAvailable = True
    End Sub

    ' Internal
    ''' <summary>
    ''' This enum will be used to manage account permissions
    ''' </summary>
    ''' <date>2017-06-07</date>
    ''' <author>Brian Combs</author>
    Public Enum AccountLevel
        Patron = 0
        Librarian = 1
        Administation = 2
    End Enum

End Class
