Public Class PersonClass
    Private studentID As Integer
    Private departmentID As Integer
    Private courseID As Integer
    Private majorID As Integer
    Private yearLevelID As Integer
    Private genderID As Integer
    Private civilStatusID As Integer

    Private studentIDNumber As String
    Private instructorIDNumber As String
    Private photoLocation As String
    Private firstName As String
    Private middleName As String
    Private surname As String
    Private extensionName As String
    Private yearLevel As String
    Private gender As String
    Private civilStatus As String
    Private department As String
    Private course As String
    Private major As String
    Private dateOfBirth As String
    Private placeOfBirth As String
    Private contactNumber As String
    Private emailAddress As String
    Private homeAddress As String
    Private permanentAddress As String

    Public Sub New(ByVal value As Integer)
        studentID = value
        departmentID = value
        courseID = value
        majorID = value
        yearLevelID = value
        genderID = value
        civilStatusID = value
    End Sub

    Public Property getStudentIDNumber As String
        Get
            Return studentIDNumber
        End Get
        Set(value As String)
            studentIDNumber = value
        End Set
    End Property

    Public Property getInstructorIDNumber As String
        Get
            Return instructorIDNumber
        End Get
        Set(value As String)
            instructorIDNumber = value
        End Set
    End Property

    Public Property getPhotoLocation As String
        Get
            Return photoLocation
        End Get
        Set(value As String)
            photoLocation = value
        End Set
    End Property

    Public Property getFirstName As String
        Get
            Return firstName
        End Get
        Set(value As String)
            firstName = value
        End Set
    End Property

    Public Property getMiddleName As String
        Get
            Return middleName
        End Get
        Set(value As String)
            middleName = value
        End Set
    End Property

    Public Property getSurname As String
        Get
            Return surname
        End Get
        Set(value As String)
            surname = value
        End Set
    End Property

    Public Property getExtensionName As String
        Get
            Return extensionName
        End Get
        Set(value As String)
            extensionName = value
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

    Public Property getCourseID As Integer
        Get
            Return courseID
        End Get
        Set(value As Integer)
            courseID = value
        End Set
    End Property

    Public Property getCourse As String
        Get
            Return course
        End Get
        Set(value As String)
            course = value
        End Set
    End Property

    Public Property getMajorID As Integer
        Get
            Return majorID
        End Get
        Set(value As Integer)
            majorID = value
        End Set
    End Property

    Public Property getMajor As String
        Get
            Return major
        End Get
        Set(value As String)
            major = value
        End Set
    End Property

    Public Property getYearLevelID As Integer
        Get
            Return yearLevelID
        End Get
        Set(value As Integer)
            yearLevelID = value
        End Set
    End Property

    Public Property getYearLevel As String
        Get
            Return yearLevel
        End Get
        Set(value As String)
            yearLevel = value
        End Set
    End Property

    Public Property getGenderID As Integer
        Get
            Return genderID
        End Get
        Set(value As Integer)
            genderID = value
        End Set
    End Property

    Public Property getGender As String
        Get
            Return gender
        End Get
        Set(value As String)
            gender = value
        End Set
    End Property

    Public Property getCivilSatusID As Integer
        Get
            Return civilStatusID
        End Get
        Set(value As Integer)
            civilStatusID = value
        End Set
    End Property

    Public Property getCivilStatus As String
        Get
            Return civilStatus
        End Get
        Set(value As String)
            civilStatus = value
        End Set
    End Property

    Public Property getDateOfBirth As String
        Get
            Return dateOfBirth
        End Get
        Set(value As String)
            dateOfBirth = value
        End Set
    End Property

    Public Property getPlaceOfBirth As String
        Get
            Return placeOfBirth
        End Get
        Set(value As String)
            placeOfBirth = value
        End Set
    End Property

    Public Property getContactNumber As String
        Get
            Return contactNumber
        End Get
        Set(value As String)
            contactNumber = value
        End Set
    End Property

    Public Property getEmailAddress As String
        Get
            Return emailAddress
        End Get
        Set(value As String)
            emailAddress = value
        End Set
    End Property

    Public Property getHomeAddress As String
        Get
            Return homeAddress
        End Get
        Set(value As String)
            homeAddress = value
        End Set
    End Property

    Public Property getPermanentAddress As String
        Get
            Return permanentAddress
        End Get
        Set(value As String)
            permanentAddress = value
        End Set
    End Property
End Class
