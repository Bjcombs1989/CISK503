Public Class DatabaseException
    Inherits ApplicationException
    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

    Public Class LoginException
        Inherits ApplicationException
        Public Sub New(Optional message As String = "The login failed")
            MyBase.New(message)
        End Sub
    End Class

    Public Class AddAccountException
        Inherits ApplicationException
        Public Sub New(Optional message As String = "Adding the account failed")
            MyBase.New(message)
        End Sub
    End Class

    Public Class PermissionsNotSufficientException
        Inherits ApplicationException
        Public Sub New(Optional message As String = "The referring account does not have sufficient permissions")
            MyBase.New(message)
        End Sub
    End Class



End Class
