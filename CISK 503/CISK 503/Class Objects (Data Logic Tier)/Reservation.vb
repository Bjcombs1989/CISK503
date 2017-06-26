Public Class Reservation
    Dim _reservedBy As Patron
    Dim _book As Book
    Dim _feesDue As Decimal
    Dim _dueDate As Date

    Public Sub New(pReserved_by As Patron, pBook As Book)
        _reservedBy = pReserved_by
        _book = pBook
        _dueDate = DateTime.Today.AddDays(7)

        ' This is creating a reservation (i.e. 7 day hold), so we need to update the database

    End Sub

    ' Properties
    Public ReadOnly Property DaysLate As Integer
        Get
            If _dueDate < DateTime.Today Then
                Return DateTime.Today.Subtract(_dueDate).TotalDays
            Else
                Return 0
            End If
        End Get
    End Property

    ' Methods
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public ReadOnly Property Book As Book
        Get
            Return _book
        End Get
    End Property
End Class
