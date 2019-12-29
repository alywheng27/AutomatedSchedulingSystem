Public Class ScheduleClass

    Private classScheduleID As Integer
    Private subjectID As Integer
    Private timeStartID As Integer
    Private timeEndID As Integer
    Private roomID As Integer
    Private sectionID As Integer
    Private instructorID As Integer
    Private semesterID As Integer

    Private subject As String
    Private timeStart As String
    Private timeEnd As String
    Private room As String
    Private section As String
    Private name As String
    Private semester As String
    Private academicYear As String

    Public Sub New(ByVal value As Integer)
        classScheduleID = value
    End Sub

    Public Property getClassScheduleID As Integer
        Get
            Return classScheduleID
        End Get
        Set(value As Integer)
            classScheduleID = value
        End Set
    End Property

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

    Public Property getTimeStartID As Integer
        Get
            Return timeStartID
        End Get
        Set(value As Integer)
            timeStartID = value
        End Set
    End Property

    Public Property getTimeStart As String
        Get
            Return timeStart
        End Get
        Set(value As String)
            timeStart = value
        End Set
    End Property

    Public Property getTimeEndID As Integer
        Get
            Return timeEndID
        End Get
        Set(value As Integer)
            timeEndID = value
        End Set
    End Property

    Public Property getTimeEnd As String
        Get
            Return timeEnd
        End Get
        Set(value As String)
            timeEnd = value
        End Set
    End Property

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

    Public Property getSectionID As Integer
        Get
            Return sectionID
        End Get
        Set(value As Integer)
            sectionID = value
        End Set
    End Property

    Public Property getSection As String
        Get
            Return section
        End Get
        Set(value As String)
            section = value
        End Set
    End Property

    Public Property getInstructorID As Integer
        Get
            Return instructorID
        End Get
        Set(value As Integer)
            instructorID = value
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

    Public Property getsemesterID As Integer
        Get
            Return semesterID
        End Get
        Set(value As Integer)
            semesterID = value
        End Set
    End Property

    Public Property getSemester As String
        Get
            Return semester
        End Get
        Set(value As String)
            semester = value
        End Set
    End Property

    Public Property getAcademicYear As String
        Get
            Return academicYear
        End Get
        Set(value As String)
            academicYear = value
        End Set
    End Property

End Class