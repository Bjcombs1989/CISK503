Public Class Book
    Dim _mysql As MySQLDatabaseConnector
    Dim _isbn As ISBN
    Dim _title As String
    Dim _genre As String
    Dim _publisher As String
    Dim _author As String
    Dim _available As Boolean
    Dim _hold As Hold
    Dim _reservation As Reservation

    ' Constructor(s)
    Public Sub New(pMySQL As MySQLDatabaseConnector, isbn As Book.ISBN, title As String, genre As Integer, publisher As Integer, author As Integer)
        ' This constructor will be used when creating a new database record
        _mysql = pMySQL

        ' Insert this record into the database and fill in the properties

    End Sub

    Public Sub New(pMySQL As MySQLDatabaseConnector, isbn As Book.ISBN)
        ' This constructor will be used when creating a new book object based on a database record
        _mysql = pMySQL

        ' Search the database for this ISBN, return the data row and fill in the properties
        Dim info As Dictionary(Of String, String) = _mysql.GetBook(isbn)
        _isbn = isbn
        _title = info("Title")
        _genre = info("Genre")
        _author = info("Author")
        _publisher = info("Publisher")

    End Sub

    ' Properties
    Public Property IsAvailable As Boolean
        Get
            Return _available
        End Get
        Set(value As Boolean)
            _available = value
        End Set
    End Property

    Public ReadOnly Property Title As String
        Get
            Return _title
        End Get
    End Property
    Public ReadOnly Property Genre As String
        Get
            Return _genre
        End Get
    End Property
    Public ReadOnly Property Author As String
        Get
            Return _author
        End Get
    End Property
    Public ReadOnly Property Publisher As String
        Get
            Return _publisher
        End Get
    End Property



    ' Methods


    Public Overrides Function ToString() As String
        Return String.Format("{0}, ISBN: {1}, Author: {2}, Publisher: {3}, Author: {4}", _title, _isbn, _author, _publisher, _author)
    End Function


    ' Internal Class
    Public Class ISBN
        Dim _isbn As String

        Public Sub New(isbn As String)
            _isbn = isbn
        End Sub

        Public Overrides Function ToString() As String
            Return _isbn
        End Function
    End Class

End Class
