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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <param name="level"></param>
    ''' <exception cref="InternalExceptions.AddAccountException"></exception>
    ''' <returns></returns>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Function AddNewUser(username As String, password As String, level As Patron.AccountLevel) As AccountInfo
        Dim cmd As New MySqlCommand("INSERT INTO `User` (`Password`, `Username`, `Account_Level`) VALUES (@password, @username, @level); SELECT LAST_INSERT_ID();", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@password", password)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@level", Convert.ToInt32(level))

        Try
            ' return a new account information if add is successful
            Return New AccountInfo(Convert.ToInt32(cmd.ExecuteScalar()), level)
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions.AddAccountException(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <exception cref="InternalExceptions.LoginException">The Login Failed</exception>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Function LoginUser(username As String, password As String) As AccountInfo
        Dim cmd As New MySqlCommand("SELECT `ID`, `Account_Level` FROM `User` WHERE `Password` LIKE @password AND `Username` LIKE @username", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@password", password)
        cmd.Parameters.AddWithValue("@username", username)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim accountInfo As AccountInfo = Nothing

            While reader.Read()
                accountInfo = New AccountInfo()
                accountInfo.ID = reader.GetInt32("ID")
                accountInfo.Level = reader.GetInt32("Account_Level")
            End While

            reader.Close()

            Return accountInfo
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions(ex.Message)
        End Try
    End Function

    Sub ChangeAccountLevel(userID As Integer, newLevel As Patron.AccountLevel)

    End Sub

    Sub AddHold(pHold As Hold)
        Throw New NotImplementedException()
    End Sub
    Sub RemoveHold(pHold As Hold)
        Throw New NotImplementedException()
    End Sub

    Sub AddReservation(pReservation As Reservation)
        Throw New NotImplementedException()
    End Sub
    Sub RemoveReservation(pReservation As Reservation)
        Throw New NotImplementedException()
    End Sub

    Public Function GetLateFee(days_late As Integer) As Decimal
        Dim daily_fee As Decimal

        ' Get fee from database and assign it to daily_fee
        Throw New NotImplementedException()

        Return daily_fee * days_late
    End Function

    Public Function ListGenres() As KeyValuePair(Of Integer, String)()
        Dim genres As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))()
        Dim cmd As New MySqlCommand("SELECT `ID`, `Name` FROM `Genre` ORDER BY `Name`", conn)
        cmd.Prepare()

        genres.Add(New KeyValuePair(Of Integer, String)(-1, ""))

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                genres.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32("ID"), reader.GetString("Name")))
            End While

            reader.Close()
        Catch ex As Exception
            Throw ex
        End Try

        Return genres.ToArray()
    End Function

    Public Function GetBook(isbn As Book.ISBN) As Dictionary(Of String, String)
        ' Create the data row
        Dim info As Dictionary(Of String, String) = New Dictionary(Of String, String)()

        ' Create the command
        Dim cmd As New MySqlCommand("SELECT Book.ID AS ISBN, Book.Name AS Title, Genre.Name AS Genre, Author.Name AS Author, Publisher.Name AS Publisher
                                     FROM Book 
                                         JOIN Author ON Book.Author = Author.ID
                                         JOIN Genre ON Book.Genre = Genre.ID
                                         JOIN Publisher ON Book.Publisher = Publisher.ID
                                     WHERE Book.ID = @isbn", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@isbn", isbn)

        ' Execute the command
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Loop through reader
        While reader.Read()
            info.Add("ISBN", reader.GetString("ISBN"))
            info.Add("Title", reader.GetString("Title"))
            info.Add("Genre", reader.GetString("Genre"))
            info.Add("Author", reader.GetString("Author"))
            info.Add("Publisher", reader.GetString("Publisher"))
            'info.Add("Reserved", reader.GetString("Reserved"))
        End While

        reader.Close()

        Return info
    End Function


    Public Function ListBooks() As DataTable
        ' Create the data table
        Dim table As DataTable = New DataTable()
        table.Columns.Add("ISBN", GetType(String))
        table.Columns.Add("Title", GetType(String))
        table.Columns.Add("Genre", GetType(String))
        table.Columns.Add("Author", GetType(String))
        table.Columns.Add("Publisher", GetType(String))
        table.Columns.Add("Status", GetType(String))
        table.Columns.Add("Check Out", GetType(String))
        table.Columns.Add("Place Hold", GetType(String))
        Dim dc As DataColumn = New DataColumn("a", GetType(Button), "", MappingType.Element)

        ' Create the command
        Dim cmd As New MySqlCommand("SELECT Book.ID AS ISBN, Book.Name AS Title, Genre.Name AS Genre, Author.Name AS Author, Publisher.Name AS Publisher
                                     FROM Book 
                                     JOIN Author ON Book.Author = Author.ID
                                     JOIN Genre ON Book.Genre = Genre.ID
                                     JOIN Publisher ON Book.Publisher = Publisher.ID", conn)
        cmd.Prepare()

        ' Execute the command
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Loop through reader
        While reader.Read()
            table.Rows.Add(reader.GetString("ISBN"), reader.GetString("Title"), reader.GetString("Genre"),
                           reader.GetString("Author"), reader.GetString("Publisher"), "Reserved", "", "")
        End While

        reader.Close()

        Return table
    End Function

    ' Dispose
    Public Sub Dispose()
        conn.Close()
    End Sub


    Public Class AccountInfo
        Public Sub New() : End Sub
        Public Sub New(pID As Integer, pLevel As Patron.AccountLevel)
            ID = pID
            Level = pLevel
        End Sub

        Public ID As Integer
        Public Level As Patron.AccountLevel
    End Class

End Class
