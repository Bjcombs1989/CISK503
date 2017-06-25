Public Class DatabaseExceptions
    Inherits ApplicationException

    Public Class LoginException
        Inherits ApplicationException
        Public Sub New(Optional message As String = "The login failed")
            MyBase.New(message)
        End Sub
    End Class



End Class
