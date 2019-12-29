Public Class studentAU
    Private genderID() As Integer
    Private civilStatusID() As Integer
    Private yearLevelID() As Integer
    Private departmentID() As Integer
    Private courseID() As Integer
    Private majorID() As Integer

    Private gender As Integer
    Private civilStatus As Integer
    Private yearLevel As Integer
    Private department As Integer
    Private course As Integer
    Private major As Integer

    Public studentIDNumber As String

    Dim a As New OpenFileDialog

    Dim photo As String
    Dim path As String

    Dim hour = DateTime.Now.Hour
    Dim minute = DateTime.Now.Minute
    Dim second = DateTime.Now.Second
    Dim year = DateTime.Now.Year
    Dim time = hour & minute & second & "-" & year

    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGender()
        loadCivilStatus()
        loadYearLevel()
        loadDepartment()
        loadUpdateList()
    End Sub

    Private Sub loadGender()
        cbGender.Items.Clear()

        Dim sql As String
        Dim dsGender = New DataSet

        sql = "SELECT * FROM Gender"

        If fillData(sql, dsGender, "tlbGender") = True Then
            If dsGender.Tables("tlbGender").Rows.Count > 0 Then
                ReDim genderID(dsGender.Tables("tlbGender").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsGender.Tables("tlbGender").Rows.Count - 1
                    cbGender.Items.Add(dsGender.Tables("tlbGender").Rows(i).Item("Gender"))
                    genderID(i) = dsGender.Tables("tlbGender").Rows(i).Item("GenderID")
                Next
            End If
        End If
    End Sub

    Private Sub loadCivilStatus()
        cbCivilStatus.Items.Clear()

        Dim sql As String
        Dim dsCivilStatus = New DataSet

        sql = "SELECT * FROM CivilStatus"

        If fillData(sql, dsCivilStatus, "tlbCivilStatus") = True Then
            If dsCivilStatus.Tables("tlbCivilStatus").Rows.Count > 0 Then
                ReDim civilStatusID(dsCivilStatus.Tables("tlbCivilStatus").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsCivilStatus.Tables("tlbCivilStatus").Rows.Count - 1
                    cbCivilStatus.Items.Add(dsCivilStatus.Tables("tlbCivilStatus").Rows(i).Item("CivilStatus"))
                    civilStatusID(i) = dsCivilStatus.Tables("tlbCivilStatus").Rows(i).Item("CivilStatusID")
                Next
            End If
        End If
    End Sub

    Private Sub loadYearLevel()
        cbYearLevel.Items.Clear()

        Dim sql As String
        Dim dsYearLevel = New DataSet

        sql = "SELECT * FROM YearLevel"

        If fillData(sql, dsYearLevel, "tlbYearLevel") = True Then
            If dsYearLevel.Tables("tlbYearLevel").Rows.Count > 0 Then
                ReDim yearLevelID(dsYearLevel.Tables("tlbYearLevel").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsYearLevel.Tables("tlbYearLevel").Rows.Count - 1
                    cbYearLevel.Items.Add(dsYearLevel.Tables("tlbYearLevel").Rows(i).Item("YearLevel"))
                    yearLevelID(i) = dsYearLevel.Tables("tlbYearLevel").Rows(i).Item("YearLevelID")
                Next
            End If
        End If
    End Sub

    Private Sub loadDepartment()
        cbDepartment.Items.Clear()

        Dim sql As String
        Dim dsDepartment = New DataSet

        sql = "SELECT * FROM Department"

        If fillData(sql, dsDepartment, "tlbDepartment") = True Then
            If dsDepartment.Tables("tlbDepartment").Rows.Count > 0 Then
                ReDim departmentID(dsDepartment.Tables("tlbDepartment").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsDepartment.Tables("tlbDepartment").Rows.Count - 1
                    cbDepartment.Items.Add(dsDepartment.Tables("tlbDepartment").Rows(i).Item("Department"))
                    departmentID(i) = dsDepartment.Tables("tlbDepartment").Rows(i).Item("DepartmentID")
                Next
            End If
        End If
    End Sub

    Private Sub loadCourse(ByVal departmentID As Integer)
        cbCourse.Items.Clear()

        Dim sql As String
        Dim dsCourse = New DataSet

        sql = "SELECT * FROM Course WHERE DepartmentID = " & departmentID

        If fillData(sql, dsCourse, "tlbCourse") = True Then
            If dsCourse.Tables("tlbCourse").Rows.Count > 0 Then
                ReDim courseID(dsCourse.Tables("tlbCourse").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsCourse.Tables("tlbCourse").Rows.Count - 1
                    cbCourse.Items.Add(dsCourse.Tables("tlbCourse").Rows(i).Item("Course"))
                    courseID(i) = dsCourse.Tables("tlbCourse").Rows(i).Item("CourseID")
                Next
            End If
        End If
    End Sub

    Private Sub loadMajor(ByVal courseID As Integer)
        cbMajor.Items.Clear()

        Dim sql As String
        Dim dsMajor = New DataSet

        sql = "SELECT * FROM Major WHERE CourseID = " & courseID

        If fillData(sql, dsMajor, "tlbMajor") = True Then
            If dsMajor.Tables("tlbMajor").Rows.Count > 0 Then
                ReDim majorID(dsMajor.Tables("tlbMajor").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsMajor.Tables("tlbMajor").Rows.Count - 1
                    cbMajor.Items.Add(dsMajor.Tables("tlbMajor").Rows(i).Item("Major"))
                    majorID(i) = dsMajor.Tables("tlbMajor").Rows(i).Item("MajorID")
                Next
            End If
        End If
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        objStudent = New PersonClass(departmentID(cbDepartment.SelectedIndex))
        objStudent.getDepartment = cbDepartment.Text
        department = objStudent.getDepartmentID

        loadCourse(objStudent.getDepartmentID)
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        objStudent = New PersonClass(courseID(cbCourse.SelectedIndex))
        objStudent.getCourse = cbCourse.Text
        course = objStudent.getCourseID

        loadMajor(objStudent.getCourseID)
    End Sub

    Private Sub cbMajor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMajor.SelectedIndexChanged
        objStudent = New PersonClass(majorID(cbMajor.SelectedIndex))
        major = objStudent.getMajorID
    End Sub

    Private Sub cbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged
        objStudent = New PersonClass(genderID(cbGender.SelectedIndex))
        gender = objStudent.getGenderID
    End Sub

    Private Sub cbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCivilStatus.SelectedIndexChanged
        objStudent = New PersonClass(civilStatusID(cbCivilStatus.SelectedIndex))
        civilStatus = objStudent.getCivilSatusID
    End Sub

    Private Sub cbYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYearLevel.SelectedIndexChanged
        objStudent = New PersonClass(yearLevelID(cbYearLevel.SelectedIndex))
        yearLevel = objStudent.getYearLevelID
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If a.FileName = Nothing Then
            a.FileName = My.Application.Info.DirectoryPath & "/img/Default Img/default_img.png"
        End If

        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String
        Dim dsStudent = New DataSet

        Dim idNumber = txtIDNumber.Text & "-" & txtIDNumber2.Text

        sql = "SELECT StudentIDNumber FROM Student WHERE StudentIDNumber = '" & idNumber & "' AND IsDeleted = 'False' "

        If fillData(sql, dsStudent, "tblStudent") = True Then
            If dsStudent.Tables("tblStudent").Rows.Count > 0 Then
                MsgBox("ID Number already exist.", vbInformation + vbOKOnly, systemName)
                txtIDNumber.Text = ""
                txtIDNumber2.Text = ""
                Exit Sub
            End If
        End If

        txtFirstName.Text = StrConv(txtFirstName.Text, VbStrConv.ProperCase)
        txtMiddleName.Text = StrConv(txtMiddleName.Text, VbStrConv.ProperCase)
        txtSurname.Text = StrConv(txtSurname.Text, VbStrConv.ProperCase)
        txtExtensionName.Text = StrConv(txtExtensionName.Text, VbStrConv.ProperCase)

        txtHomeAddress.Text = StrConv(txtHomeAddress.Text, VbStrConv.ProperCase)
        txtPermanentAddress.Text = StrConv(txtPermanentAddress.Text, VbStrConv.ProperCase)

        photo = idNumber & "-" & txtFirstName.Text & txtSurname.Text & "-" & time & ".jpg"
        path = My.Application.Info.DirectoryPath & "/img/Student Img/" & photo

        If major = 0 Then
            major = 1
        End If

        sql = " 
                INSERT INTO Photo (PhotoID, PhotoLocation) VALUES ('" & idNumber & "', '" & path & "');
                INSERT INTO NameUser (NameID, FirstName, MiddleInitial, Surname, ExtensionName) VALUES ('" & idNumber & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & txtSurname.Text & "', '" & txtExtensionName.Text & "');
                INSERT INTO Contact (ContactID, ContactNumber, EmailAddress) VALUES ('" & idNumber & "', '" & txtContactNumber.Text & "', '" & txtEmailAddress.Text & "');
                INSERT INTO AddressUser (AddressID, HomeAddress, PermanentAddress) VALUES ('" & idNumber & "', '" & txtHomeAddress.Text & "', '" & txtPermanentAddress.Text & "');
                INSERT INTO Student (StudentIDNumber, DepartmentID, CourseID, MajorID, YearLevelID, GenderID, CivilStatusID) VALUES ('" & idNumber & "', '" & department & "', '" & course & "', '" & major & "', '" & yearLevel & "', '" & gender & "', '" & civilStatus & "');
              "

        If updateData(sql) = True Then
            IO.File.Copy(a.FileName, path)
            MsgBox("New Student added.", vbInformation + vbOKOnly, systemName)
            clear()
            student.listStudent(Nothing)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String

        Dim idNumber = txtIDNumber.Text & "-" & txtIDNumber2.Text

        txtFirstName.Text = StrConv(txtFirstName.Text, VbStrConv.ProperCase)
        txtMiddleName.Text = StrConv(txtMiddleName.Text, VbStrConv.ProperCase)
        txtSurname.Text = StrConv(txtSurname.Text, VbStrConv.ProperCase)
        txtExtensionName.Text = StrConv(txtExtensionName.Text, VbStrConv.ProperCase)

        txtHomeAddress.Text = StrConv(txtHomeAddress.Text, VbStrConv.ProperCase)
        txtPermanentAddress.Text = StrConv(txtPermanentAddress.Text, VbStrConv.ProperCase)

        If major = 0 Then
            major = 1
        End If

        sql = " 
                UPDATE Photo SET PhotoID = '" & idNumber & "' WHERE PhotoID = '" & studentIDNumber & "' ;
                UPDATE NameUser SET NameID = '" & idNumber & "', FirstName = '" & txtFirstName.Text & "', MiddleInitial = '" & txtMiddleName.Text & "', Surname = '" & txtSurname.Text & "', ExtensionName = '" & txtExtensionName.Text & "' WHERE NameID = '" & studentIDNumber & "' ;
                UPDATE Contact SET ContactID = '" & idNumber & "', ContactNumber = '" & txtContactNumber.Text & "', EmailAddress = '" & txtEmailAddress.Text & "' WHERE ContactID = '" & studentIDNumber & "' ;
                UPDATE AddressUser SET AddressID = '" & idNumber & "', HomeAddress = '" & txtHomeAddress.Text & "', PermanentAddress = '" & txtPermanentAddress.Text & "' WHERE AddressID = '" & studentIDNumber & "' ;
                UPDATE Student SET StudentIDNumber = '" & idNumber & "', DepartmentID = '" & department & "', CourseID = '" & course & "', MajorID = '" & major & "', YearLevelID = '" & yearLevel & "', GenderID = '" & gender & "', CivilStatusID = '" & civilStatus & "' WHERE StudentIDNumber = '" & studentIDNumber & "' ;
              "

        photo = idNumber & "-" & txtFirstName.Text & txtSurname.Text & "-" & time & ".jpg"
        path = My.Application.Info.DirectoryPath & "/img/Student Img/" & photo

        If a.FileName <> Nothing Then
            sql = sql & "UPDATE Photo SET PhotoID = '" & idNumber & "', PhotoLocation = '" & path & "' WHERE PhotoID = '" & studentIDNumber & "' ;"
            IO.File.Copy(a.FileName, path)
        End If

        If updateData(sql) = True Then
            MsgBox("Student updated.", vbInformation + vbOKOnly, systemName)
            clear()
            student.listStudent(Nothing)
            Me.Dispose()
        End If
    End Sub

    Private Sub clear()
        txtIDNumber.Text = ""
        txtIDNumber2.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtSurname.Text = ""
        txtExtensionName.Text = ""
        txtContactNumber.Text = ""
        txtEmailAddress.Text = ""
        txtHomeAddress.Text = ""
        txtPermanentAddress.Text = ""

        cbGender.Items.Clear()
        cbCivilStatus.Items.Clear()
        cbYearLevel.Items.Clear()
        cbDepartment.Items.Clear()
        cbCourse.Items.Clear()
        cbMajor.Items.Clear()

        loadGender()
        loadCivilStatus()
        loadYearLevel()
        loadDepartment()
    End Sub

    Public Sub loadUpdateList()
        If objStudent.getPhotoLocation <> "" Then
            studentImage.Image = Image.FromFile(objStudent.getPhotoLocation)
            studentImage.BackgroundImage = Nothing
        End If

        If objStudent.getStudentIDNumber <> Nothing Then
            Dim length = objStudent.getStudentIDNumber.Length
            Dim pos = objStudent.getStudentIDNumber.IndexOf("-")
            Dim id1 = objStudent.getStudentIDNumber.Substring(0, pos)
            Dim id2 = objStudent.getStudentIDNumber.Substring(pos + 1, length - pos - 1)
            txtIDNumber.Text = id1
            txtIDNumber2.Text = id2
        End If


        txtFirstName.Text = objStudent.getFirstName
        txtMiddleName.Text = objStudent.getMiddleName
        txtSurname.Text = objStudent.getSurname
        txtExtensionName.Text = objStudent.getExtensionName
        txtContactNumber.Text = objStudent.getContactNumber
        txtEmailAddress.Text = objStudent.getEmailAddress
        txtHomeAddress.Text = objStudent.getHomeAddress
        txtPermanentAddress.Text = objStudent.getPermanentAddress

        'Needs to be set to a variable for it to work
        'objStudent.getGender does not work after using "genderCB = objStudent.getGender"
        Dim genderCB, civilStatusCB, yearLevelCB, departmentCB, courseCB, majorCB As String
        genderCB = objStudent.getGender
        civilStatusCB = objStudent.getCivilStatus
        yearLevelCB = objStudent.getYearLevel
        departmentCB = objStudent.getDepartment
        courseCB = objStudent.getCourse
        majorCB = objStudent.getMajor

        cbGender.SelectedIndex = cbGender.FindStringExact(genderCB)
        cbCivilStatus.SelectedIndex = cbCivilStatus.FindStringExact(civilStatusCB)
        cbYearLevel.SelectedIndex = cbYearLevel.FindStringExact(yearLevelCB)
        cbDepartment.SelectedIndex = cbDepartment.FindStringExact(departmentCB)
        cbCourse.SelectedIndex = cbCourse.FindStringExact(courseCB)
        cbMajor.SelectedIndex = cbMajor.FindStringExact(majorCB)


    End Sub

    Private Function checkFields()
        If txtIDNumber.Text = "" Then
            MsgBox("Please enter ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber.Focus()
            Return False
        End If

        If txtIDNumber2.Text = "" Then
            MsgBox("Please enter ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber.Focus()
            Return False
        End If

        If txtFirstName.Text = "" Then
            MsgBox("Please enter First Name.", vbInformation + vbOKOnly, systemName)
            txtFirstName.Focus()
            Return False
        End If

        If txtMiddleName.Text = "" Then
            MsgBox("Please enter Middle Name.", vbInformation + vbOKOnly, systemName)
            txtMiddleName.Focus()
            Return False
        End If

        If txtSurname.Text = "" Then
            MsgBox("Please enter Surname.", vbInformation + vbOKOnly, systemName)
            txtSurname.Focus()
            Return False
        End If

        If cbGender.Text = "" Then
            MsgBox("Please select Gender.", vbInformation + vbOKOnly, systemName)
            cbGender.Focus()
            Return False
        End If

        If cbCivilStatus.Text = "" Then
            MsgBox("Please select Civil Status.", vbInformation + vbOKOnly, systemName)
            cbCivilStatus.Focus()
            Return False
        End If

        If cbYearLevel.Text = "" Then
            MsgBox("Please select Year Level.", vbInformation + vbOKOnly, systemName)
            cbYearLevel.Focus()
            Return False
        End If

        If cbDepartment.Text = "" Then
            MsgBox("Please select Department.", vbInformation + vbOKOnly, systemName)
            cbDepartment.Focus()
            Return False
        End If

        If cbCourse.Text = "" Then
            MsgBox("Please select Course.", vbInformation + vbOKOnly, systemName)
            cbCourse.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        Try

            Dim picLocation As String

            a.Filter = Nothing
            picLocation = a.FileName
            a.ShowDialog()

            If a.FileName = Nothing Then
                Exit Sub
            End If

            ' PicEmployee1.Visible = False

            studentImage.Image = Image.FromFile(a.FileName)
            studentImage.BackgroundImage = Nothing

            'PDSNewPersonnelForm.picEmployee.Image = Image.FromFile(a.FileName)
            'PDSNewPersonnelForm.picEmployee.BackgroundImage = Nothing

            'DashboardForm.picEmployee.Image = Image.FromFile(a.FileName)
            'DashboardForm.picEmployee.BackgroundImage = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, systemName)
            Exit Sub

        End Try
    End Sub
End Class