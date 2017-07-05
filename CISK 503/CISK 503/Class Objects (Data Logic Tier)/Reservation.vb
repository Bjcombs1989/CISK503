Public Class Reservation
    Inherits ListViewItem

    Dim _reservedBy As Patron
    Dim _book As Book
    Dim _feesDue As Decimal
    Dim _dueDate As Date

    Public Sub New(pReserved_by As Patron, pBook As Book, Optional pDueDate As DateTime = Nothing, Optional pFeesDue As Double = 0)
        Text = pBook.Title
        SubItems.Add(pBook.Author)
        SubItems.Add(pReserved_by.UserName)

        _reservedBy = pReserved_by
        _book = pBook

        If pDueDate = Nothing Then
            _dueDate = DateTime.Today.AddDays(7)
        Else
            _dueDate = pDueDate
        End If

        SubItems.Add(_dueDate.ToShortDateString())
        SubItems.Add(String.Format("{0:c2}", pFeesDue))
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
