Public Class Hold
    Inherits ListViewItem

    Dim _heldBy As Patron
    Dim _book As Book
    Dim _endHold As DateTime

    Public Sub New(pheld_by As Patron, pBook As Book, Optional pEndHold As DateTime = Nothing)
        Text = pBook.Title
        SubItems.Add(pBook.Author)
        SubItems.Add(pheld_by.UserName)

        _heldBy = pheld_by
        _book = pBook

        If (pEndHold = Nothing) Then
            _endHold = DateTime.Today.AddDays(7)
        Else
            _endHold = pEndHold
        End If

        SubItems.Add(_endHold.ToShortDateString())
        SubItems.Add("")

        If _endHold < DateTime.Today Then
            SubItems.Add("Hold Expired")
        Else
            SubItems.Add("Held")
        End If
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

    Public ReadOnly Property HeldTill As DateTime
        Get
            Return _endHold
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
