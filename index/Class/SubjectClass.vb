Public Class SubjectClass
    Private subjectID As Integer
    Private departmentID As Integer

    Private subject As String
    Private description As String
    Private lecUnit As String
    Private labUnit As String
    Private department As String

    Public Sub New(ByVal value As Integer)
        subjectID = value
        departmentID = value
    End Sub

    Public Property getSubjectID As Integer
        Get
            Return subjectID
        End Get
        Set(value As Integer)
            subjectID = value
        End Set
    End Property

    Public Property getSubject As String
        Get
            Return subject
        End Get
        Set(value As String)
            subject = value
        End Set
    End Property

    Public Property getDescription As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property

    Public Property getLecUnit As String
        Get
            Return lecUnit
        End Get
        Set(value As String)
            lecUnit = value
        End Set
    End Property

    Public Property getLabUnit As String
        Get
            Return labUnit
        End Get
        Set(value As String)
            labUnit = value
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