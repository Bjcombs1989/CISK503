Imports CISK_503
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

    ' Accounts
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

    Function GetUserInfo(id As Integer) As AccountInfo
        Dim ac As New AccountInfo()
        Dim cmd As New MySqlCommand("SELECT * FROM `User` WHERE `ID` = @id", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@id", id)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim accountInfo As AccountInfo = Nothing

            While reader.Read()
                accountInfo = New AccountInfo()
                accountInfo.ID = reader.GetInt32("ID")
                accountInfo.Level = reader.GetInt32("Account_Level")
                accountInfo.Username = reader.GetString("Username")
                accountInfo.Password = reader.GetString("Password")
                DateTime.TryParse(reader.GetString("Created_Date"), accountInfo.Created_Date)
            End While

            reader.Close()

            Return accountInfo
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions(ex.Message)
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
        Dim cmd As New MySqlCommand("SELECT `ID`, `Account_Level`, `Created_Date` FROM `User` WHERE `Password` LIKE @password AND `Username` LIKE @username", conn)
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
                DateTime.TryParse(reader.GetString("Created_Date"), accountInfo.Created_Date)
            End While

            reader.Close()

            Return accountInfo
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions(ex.Message)
        End Try
    End Function

    Public Sub UpdateLevel(user As Patron, new_level As Patron.AccountLevel)
        Dim cmd As New MySqlCommand("UPDATE `User` SET `Account_Level` = @level WHERE `ID` = @id", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@id", user.ID)
        cmd.Parameters.AddWithValue("@level", Convert.ToInt32(new_level))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdatePassword(user As Patron, new_password As String)
        Dim cmd As New MySqlCommand("UPDATE `User` SET `Password` = @password WHERE `ID` = @id", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@password", user.HashPassword(new_password))
        cmd.Parameters.AddWithValue("@id", user.ID)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DeleteAccount(user As Patron)
        Dim cmd As New MySqlCommand("DELETE FROM `User` WHERE `ID` = @id", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@id", user.ID)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdateUsername(user As Patron, new_username As String)
        Dim cmd As New MySqlCommand("UPDATE `User` SET `Username` = @username WHERE `ID` = @id", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@username", new_username)
        cmd.Parameters.AddWithValue("@id", user.ID)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    ' Holds
    Sub AddHold(pHold As Hold)
        Dim cmd As New MySqlCommand("INSERT INTO `Hold` (`Book`, `User`, `Hold_Until`) VALUES (@book, @user, @date);", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@book", pHold.Book.BookISBN)
        cmd.Parameters.AddWithValue("@user", pHold.Patron.ID)
        cmd.Parameters.AddWithValue("@date", pHold.HeldTill.ToString("yyyy-MM-dd"))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions(ex.Message)
        End Try
    End Sub
    Sub RemoveHold(pHold As Hold)
        Dim cmd As New MySqlCommand("DELETE FROM `Hold` WHERE `Book` = @book AND `User` = @user AND `Hold_Until` = @date", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@book", pHold.Book.BookISBN)
        cmd.Parameters.AddWithValue("@user", pHold.Patron.ID)
        cmd.Parameters.AddWithValue("@date", pHold.HeldTill.ToString("yyyy-MM-dd"))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions(ex.Message)
        End Try
    End Sub

    ' Reservations
    Sub AddReservation(pReservation As Reservation)
        Dim cmd As New MySqlCommand("INSERT INTO `Reservations` (`Book`, `User`, `Due_Date`, `Late_Fees`) VALUES (@book, @user, @date, 0);", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@book", pReservation.Book.BookISBN)
        cmd.Parameters.AddWithValue("@user", pReservation.Patron.ID)
        cmd.Parameters.AddWithValue("@date", pReservation.DueDate.ToString("yyyy-MM-dd"))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions(ex.Message)
        End Try
    End Sub
    Sub RemoveReservation(pReservation As Reservation)
        Dim cmd As New MySqlCommand("DELETE FROM `Reservations` WHERE `Book` = @book AND `User` = @user AND `Due_Date` = @date", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@book", pReservation.Book.BookISBN)
        cmd.Parameters.AddWithValue("@user", pReservation.Patron.ID)
        cmd.Parameters.AddWithValue("@date", pReservation.DueDate.ToString("yyyy-MM-dd"))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' otherwise throw exception
            Throw New InternalExceptions(ex.Message)
        End Try
    End Sub

    ' Get and List Methods
    Public Function ListUserAccounts() As Patron()
        Dim ids As List(Of Integer) = New List(Of Integer)
        Dim list As List(Of Patron) = New List(Of Patron)
        Dim reader As MySqlDataReader = Nothing
        Dim cmd As New MySqlCommand("SELECT `ID` FROM `User`", conn)
        cmd.Prepare()

        Try
            reader = cmd.ExecuteReader()

            While reader.Read()
                ids.Add(reader.GetInt32("ID"))
            End While

            reader.Close()

            For Each id As Integer In ids
                list.Add(New Patron(Me, id))
            Next

        Catch ex As Exception
            Throw ex
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try

        Return list.ToArray()
    End Function

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
        Dim reader As MySqlDataReader = Nothing

        Try
            reader = cmd.ExecuteReader()

            While reader.Read()
                genres.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32("ID"), reader.GetString("Name")))
            End While

            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try

        Return genres.ToArray()
    End Function

    Public Function ListAuthors() As KeyValuePair(Of Integer, String)()
        Dim genres As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))()
        Dim cmd As New MySqlCommand("SELECT `ID`, `Name` FROM `Author` ORDER BY `Name`", conn)
        cmd.Prepare()

        genres.Add(New KeyValuePair(Of Integer, String)(-1, ""))
        Dim reader As MySqlDataReader = Nothing

        Try
            reader = cmd.ExecuteReader()

            While reader.Read()
                genres.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32("ID"), reader.GetString("Name")))
            End While

            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try

        Return genres.ToArray()
    End Function

    Public Function ListPublishers() As KeyValuePair(Of Integer, String)()
        Dim genres As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))()
        Dim cmd As New MySqlCommand("SELECT `ID`, `Name` FROM `Publisher` ORDER BY `Name`", conn)
        cmd.Prepare()

        genres.Add(New KeyValuePair(Of Integer, String)(-1, ""))
        Dim reader As MySqlDataReader = Nothing

        Try
            reader = cmd.ExecuteReader()

            While reader.Read()
                genres.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32("ID"), reader.GetString("Name")))
            End While

            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try

        Return genres.ToArray()
    End Function

    Public Function GetReservations(Optional user As Patron = Nothing) As Reservation()
        Dim reseravations As List(Of Reservation) = New List(Of Reservation)()
        Dim books As List(Of ReservationInfo) = New List(Of ReservationInfo)()
        Dim cmd As New MySqlCommand("SELECT * FROM `Reservations`", conn)
        cmd.Prepare()

        If Not user Is Nothing Then
            cmd = New MySqlCommand("SELECT * FROM `Reservations` WHERE `User` = @userID", conn)
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@userID", user.ID)
        End If


        Dim reader As MySqlDataReader = Nothing

        Try
            reader = cmd.ExecuteReader()

            While reader.Read()
                books.Add(New ReservationInfo(reader.GetString("Book"), reader.GetInt32("User"), reader.GetDateTime("Due_Date"), reader.GetDecimal("Late_Fees")))
            End While

            reader.Close()

            For Each b As ReservationInfo In books
                Dim res As Reservation
                Dim book As Book
                Dim held_by As Patron

                If user Is Nothing Then
                    held_by = New Patron(Me, b.user)
                Else
                    held_by = user
                End If

                ' Set the variables to their instances
                book = New Book(Me, New Book.ISBN(b.isbn))
                res = New Reservation(held_by, book, b.due, b.amount)

                ' Add the reservation to the list
                reseravations.Add(res)
            Next
            ' Declare the variables


        Catch ex As Exception
            Throw ex
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try

        Return reseravations.ToArray()
    End Function

    Public Function GetReservationsWithBalance(Optional user As Patron = Nothing) As Reservation()
        Dim reseravations As Reservation() = GetReservations(user)
        Return reseravations.Where(Function(res) res.FeesDue > 0).ToArray()
    End Function

    Public Function GetHolds(Optional user As Patron = Nothing) As Hold()
        Dim reseravations As List(Of Hold) = New List(Of Hold)()
        Dim books As List(Of ReservationInfo) = New List(Of ReservationInfo)()
        Dim reader As MySqlDataReader = Nothing

        Dim cmd As New MySqlCommand("SELECT * FROM `Hold` WHERE `Hold_Until` >= SYSDATE()", conn)
        cmd.Prepare()

        If Not user Is Nothing Then
            cmd = New MySqlCommand("SELECT * FROM `Hold` WHERE `User` = @userID", conn)
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@userID", user.ID)
        End If

        'Try
        reader = cmd.ExecuteReader()

        While reader.Read()
            books.Add(New ReservationInfo(reader.GetString("Book"), reader.GetInt32("User"), reader.GetDateTime("Hold_Until"), 0))
        End While

        reader.Close()

        For Each b As ReservationInfo In books
            Dim res As Hold
            Dim book As Book
            Dim held_by As Patron

            If user Is Nothing Then
                held_by = New Patron(Me, b.user)
            Else
                held_by = user
            End If

            ' Set the variables to their instances
            book = New Book(Me, New Book.ISBN(b.isbn))
            res = New Hold(held_by, book, b.due)

            ' Add the reservation to the list
            reseravations.Add(res)
        Next
        ' Declare the variables


        'Catch ex As Exception
        '    Throw ex
        'Finally
        '    If Not reader Is Nothing Then reader.Close()
        'End Try

        Return reseravations.ToArray()
    End Function

    Public Function GetBook(isbn As Book.ISBN) As Dictionary(Of String, String)
        ' Create the data row
        Dim info As Dictionary(Of String, String) = New Dictionary(Of String, String)()

        ' Create the command
        Dim cmd As New MySqlCommand("SELECT Book.ID AS ISBN, Book.Name AS Title, Genre.Name AS Genre, 
                                        Author.Name AS Author, Publisher.Name AS Publisher, 
		                                (select count(*) from Hold where book = @isbn and hold_until < sysdate()) As 'Hold', 
		                                (select count(*) from Reservations where book = @isbn and due_date < sysdate()) As 'Reservation'
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
            info.Add("Hold", reader.GetString("Hold"))
            info.Add("Reservation", reader.GetString("Reservation"))
        End While

        reader.Close()

        ' Add info regarding Hold

        Dim cmdHold As New MySqlCommand("select * from Hold where book = @isbn and hold_until < sysdate()", conn)
        cmdHold.Prepare()
        cmdHold.Parameters.AddWithValue("@isbn", isbn)
        ' Execute the command
        Dim readerHold As MySqlDataReader = cmdHold.ExecuteReader()
        ' Loop through reader
        While readerHold.Read()
            info.Add("Hold_Until", readerHold.GetString("Hold_Until"))
            info.Add("Hold_User", readerHold.GetString("User"))
        End While
        readerHold.Close()

        ' Add info regarding Reservation

        Dim cmdRes As New MySqlCommand("select * from Reservations where book = @isbn and due_date < sysdate()", conn)
        cmdRes.Prepare()
        cmdRes.Parameters.AddWithValue("@isbn", isbn)
        ' Execute the command
        Dim readerRes As MySqlDataReader = cmdRes.ExecuteReader()
        ' Loop through reader
        While readerRes.Read()
            info.Add("Due_Date", readerRes.GetString("Due_Date"))
            info.Add("Late_Fees", readerRes.GetString("Late_Fees"))
            info.Add("Res_User", readerRes.GetString("User"))
        End While
        readerRes.Close()

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
                           reader.GetString("Author"), reader.GetString("Publisher"))
        End While

        reader.Close()

        Return table
    End Function

    Public Function ListUsers() As KeyValuePair(Of Integer, String)()
        Dim list As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))
        Dim reader As MySqlDataReader = Nothing
        Dim cmd As New MySqlCommand("SELECT `ID`, `Username` FROM `User`", conn)
        cmd.Prepare()

        list.Add(New KeyValuePair(Of Integer, String)(-1, ""))

        Try
            reader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32("ID"), reader.GetString("Username")))
            End While

            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try


        Return list.ToArray()
    End Function

    ' Catalog 
    Public Sub AddAuthor(author As String)
        Dim cmd As New MySqlCommand("INSERT INTO `Author` (Name) VALUES (@Author); ", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@Author", author)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AddGenre(Genre As String)
        Dim cmd As New MySqlCommand("INSERT INTO Genre (Name) VALUES (@Genre)", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@Genre", Genre)

        Dim id As Integer

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AddPublisher(Publisher As String)
        Dim cmd As New MySqlCommand("INSERT INTO `Publisher` (Name) VALUES (@Publisher);", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@Publisher", Publisher)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function AddBook(title As String, genre As Integer, publisher As Integer, author As Integer, patron As Patron) As String
        ' Create the command
        Dim cmd As New MySqlCommand("INSERT INTO Book (Name, Genre, Author, Publisher, User) VALUES (@name, @genre, @author, @publisher, @user); SELECT LAST_INSERT_ID(); ", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@name", title)
        cmd.Parameters.AddWithValue("@genre", genre)
        cmd.Parameters.AddWithValue("@author", author)
        cmd.Parameters.AddWithValue("@publisher", publisher)
        cmd.Parameters.AddWithValue("@user", patron.ID)

        ' Execute the command
        Try
            Dim id As Integer = cmd.ExecuteScalar()
            Return id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub UpdateBook(book As Book, title As String, genre As Integer, publisher As Integer, author As Integer)
        ' Create the command
        Dim cmd As New MySqlCommand("UPDATE Book SET Name = @name, Genre = @genre, Author = @author, Publisher = @publisher WHERE ID = @isbn ", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@isbn", book.BookISBN)
        cmd.Parameters.AddWithValue("@name", title)
        cmd.Parameters.AddWithValue("@genre", genre)
        cmd.Parameters.AddWithValue("@author", author)
        cmd.Parameters.AddWithValue("@publisher", publisher)

        ' Execute the command
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ' Dispose
    Public Sub Dispose()
        conn.Close()
    End Sub

    ' Internal Classes
    Public Class AccountInfo
        Public Sub New() : End Sub
        Public Sub New(pID As Integer, pLevel As Patron.AccountLevel)
            ID = pID
            Level = pLevel
        End Sub

        Public ID As Integer
        Public Level As Patron.AccountLevel
        Public Username As String
        Public Password As String
        Public Created_Date As DateTime
    End Class

    Public Class ReservationInfo
        Public isbn As String
        Public due As DateTime
        Public user As Integer
        Public amount As Decimal

        Public Sub New(isbn As String, user As Integer, due As DateTime, amount As Decimal)
            Me.isbn = isbn
            Me.due = due
            Me.user = user
            Me.amount = amount
        End Sub
    End Class

End Class
