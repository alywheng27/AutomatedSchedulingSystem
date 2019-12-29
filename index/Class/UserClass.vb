Public Class UserClass
    Private userID As Integer

    Private username As String
    Private userType As String
    Private name As String

    Public Sub New(ByVal value As Integer)
        userID = value
    End Sub

    Public Property getUserID As Integer
        Get
            Return userID
        End Get
        Set(value As Integer)
            userID = value
        End Set
    End Property

    Public Property getUsername As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property getUserType As String
        Get
            Return userType
        End Get
        Set(value As String)
            userType = value
        End Set
    End Property

    Public Property getName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

End Class