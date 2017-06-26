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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="book"></param>
    ''' <param name="user"></param>
    ''' <returns></returns>
    ''' <exception cref="InternalExceptions"></exception>
    ''' <exception cref="ConstraintException"></exception>
    ''' <date>2017-06-26</date>
    ''' <author>Brian Combs</author>
    Public Function CheckOutBook(book As Book, user As Patron) As Reservation
        ' First make sure the book is available to check out
        If Not book.IsAvailable Then
            Throw New ConstraintException("This book is not available for check out")
        End If

        ' Create the reservation and add it to the database
        Dim reservation As New Reservation(user, book)
        MySQL.AddReservation(reservation)
        reservation.Book.IsAvailable = False

        ' Return the reservation for presentation on the GUI
        Return reservation
    End Function

    Public Sub CheckInBook(reservation As Reservation)
        ' First remove the reservation from the database
        MySQL.RemoveReservation(reservation)
        ' Remove the reservation from the book
        reservation.Book.IsAvailable = True

        ' Then check if it was late
        If reservation.DaysLate > 0 Then
            _feesDue += MySQL.GetLateFee(reservation.DaysLate)
        End If
    End Sub

    Public Overloads Sub PlaceHold(book As Book, user As Patron)
        If Not book.IsAvailable Then
            Throw New ConstraintException("This book is not available to be placed on hold")
        End If

        Dim _hold As New Hold(user, book)
        MySQL.AddHold(_hold)
        book.IsAvailable = False
    End Sub

    Public Overrides Sub RemoveHold(hold As Hold)
        MySQL.RemoveHold(hold)
        hold.Book.IsAvailable = True
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Librarian {0}", MyBase.ToString())
    End Function
End Class