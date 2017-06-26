Public Class Book
    Dim _mysql As MySQLDatabaseConnector
    Dim _isbn As ISBN
    Dim _title As String
    Dim _genre As KeyValuePair(Of Integer, String)
    Dim _publisher As KeyValuePair(Of Integer, String)
    Dim _author As KeyValuePair(Of Integer, String)
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

    ' Methods


    Public Overrides Function ToString() As String
        Return String.Format("{0}, ISBN: {1}, Author: {2}, Publisher: {3}, Author: {4}", _title, _isbn, _author.Value, _publisher.Value, _author.Value)
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
