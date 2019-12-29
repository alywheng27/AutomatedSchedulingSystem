Public Class RoomClass
    Private roomID As Integer
    Private departmentID As Integer

    Private room As String
    Private department As String

    Public Sub New(ByVal value As Integer)
        roomID = value
        departmentID = value
    End Sub

    Public Property getRoomID As Integer
        Get
            Return roomID
        End Get
        Set(value As Integer)
            roomID = value
        End Set
    End Property

    Public Property getRoom As String
        Get
            Return room
        End Get
        Set(value As String)
            room = value
        End Set
    End Property

    Public Property getDepartmentID As Integer
        Get
            Return departmentID
        End Get
        Set(value As Integer)
            departmentID = value
        End Set
    End Property

    Public Property getDepartment As String
        Get
            Return department
        End Get
        Set(value As String)
            department = value
        End Set
    End Property

End Class