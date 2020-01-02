Public Class CurrentClass
    Private year As String
    Private semester As String

    Public Property getSemester As String
        Get
            Return semester
        End Get
        Set(value As String)
            semester = value
        End Set
    End Property

    Public Property getYear As String
        Get
            Return year
        End Get
        Set(value As String)
            year = value
        End Set
    End Property

End Class