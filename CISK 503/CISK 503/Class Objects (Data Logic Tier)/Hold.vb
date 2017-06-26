Public Class Hold
    Dim _heldBy As Patron
    Dim _book As Book
    Dim _endHold As DateTime

    Public Sub New(pheld_by As Patron, pBook As Book)
        _heldBy = pheld_by
        _book = pBook
        _endHold = DateTime.Today.AddDays(7)

        ' This is creating a reservation (i.e. 7 day hold), so we need to update the database

    End Sub
    Public ReadOnly Property Book As Book
        Get
            Return _book
        End Get
    End Property
    Public ReadOnly Property Patron As Patron
        Get
            Return _heldBy
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
