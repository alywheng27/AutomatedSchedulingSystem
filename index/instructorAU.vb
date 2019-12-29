Public Class instructorAU

    Private genderID() As Integer
    Private civilStatusID() As Integer
    Private departmentID() As Integer


    Private gender As Integer
    Private civilStatus As Integer
    Private department As Integer

    Public instructorIDNumber As String

    Dim a As New OpenFileDialog

    Dim photo As String
    Dim path As String

    Dim hour = DateTime.Now.Hour
    Dim minute = DateTime.Now.Minute
    Dim second = DateTime.Now.Second
    Dim year = DateTime.Now.Year
    Dim time = hour & minute & second & "-" & year

    Private Sub instructorAU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGender()
        loadCivilStatus()
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

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        objStudent = New PersonClass(departmentID(cbDepartment.SelectedIndex))
        department = objStudent.getDepartmentID
    End Sub

    Private Sub cbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged
        objStudent = New PersonClass(genderID(cbGender.SelectedIndex))
        gender = objStudent.getGenderID
    End Sub

    Private Sub cbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCivilStatus.SelectedIndexChanged
        objStudent = New PersonClass(civilStatusID(cbCivilStatus.SelectedIndex))
        civilStatus = objStudent.getCivilSatusID
    End Sub

    Public Sub loadUpdateList()
        If objStudent.getPhotoLocation <> "" Then
            studentImage.Image = Image.FromFile(objStudent.getPhotoLocation)
            studentImage.BackgroundImage = Nothing
        End If

        If objStudent.getInstructorIDNumber <> Nothing Then
            Dim length = objStudent.getInstructorIDNumber.Length
            Dim pos = objStudent.getInstructorIDNumber.IndexOf("-")
            Dim id1 = objStudent.getInstructorIDNumber.Substring(0, pos)
            Dim id2 = objStudent.getInstructorIDNumber.Substring(pos + 1, length - pos - 1)
            Dim pos2 = id2.IndexOf("-")
            id2 = objStudent.getInstructorIDNumber.Substring(pos + 1, pos2)
            Dim id3 = objStudent.getInstructorIDNumber.Substring(pos2 + 1, length - pos2 - 1)
            Dim pos3 = id3.IndexOf("-")
            Dim length2 = id3.Length
            objStudent.getInstructorIDNumber = id3.Substring(pos3 + 1, length2 - pos3 - 1)
            Dim pos4 = objStudent.getInstructorIDNumber.IndexOf("-")
            id3 = objStudent.getInstructorIDNumber.Substring(0, pos4)
            Dim length3 = objStudent.getInstructorIDNumber.Length
            Dim id4 = objStudent.getInstructorIDNumber.Substring(pos4 + 1, length3 - pos4 - 1)

            txtIDNumber.Text = id1
            txtIDNumber2.Text = id2
            txtIDNumber3.Text = id3
            txtIDNumber4.Text = id4
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
        Dim genderCB, civilStatusCB, departmentCB As String
        genderCB = objStudent.getGender
        civilStatusCB = objStudent.getCivilStatus
        departmentCB = objStudent.getDepartment

        cbGender.SelectedIndex = cbGender.FindStringExact(genderCB)
        cbCivilStatus.SelectedIndex = cbCivilStatus.FindStringExact(civilStatusCB)
        cbDepartment.SelectedIndex = cbDepartment.FindStringExact(departmentCB)
    End Sub

    Private Function checkFields()
        If txtIDNumber.Text = "" Then
            MsgBox("Please enter ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber.Focus()
            Return False
        End If

        If txtIDNumber2.Text = "" Then
            MsgBox("Please enter ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber2.Focus()
            Return False
        End If

        If txtIDNumber3.Text = "" Then
            MsgBox("Please enter ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber3.Focus()
            Return False
        End If

        If txtIDNumber4.Text = "" Then
            MsgBox("Please enter ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber4.Focus()
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

        If cbDepartment.Text = "" Then
            MsgBox("Please select Department.", vbInformation + vbOKOnly, systemName)
            cbDepartment.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub clear()
        txtIDNumber.Text = ""
        txtIDNumber2.Text = ""
        txtIDNumber3.Text = ""
        txtIDNumber4.Text = ""
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
        cbDepartment.Items.Clear()

        loadGender()
        loadCivilStatus()
        loadDepartment()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If a.FileName = Nothing Then
            a.FileName = My.Application.Info.DirectoryPath & "/img/Default Img/default_img.png"
        End If

        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String
        Dim dsInstructor = New DataSet

        Dim idNumber = txtIDNumber.Text & "-" & txtIDNumber2.Text & "-" & txtIDNumber3.Text & "-" & txtIDNumber4.Text

        sql = "SELECT InstructorIDNumber FROM Instructor WHERE InstructorIDNumber = '" & idNumber & "' AND IsDeleted = 'False' "

        If fillData(sql, dsInstructor, "tblInstructor") = True Then
            If dsInstructor.Tables("tblInstructor").Rows.Count > 0 Then
                MsgBox("ID Number already exist.", vbInformation + vbOKOnly, systemName)
                txtIDNumber.Text = ""
                txtIDNumber2.Text = ""
                txtIDNumber3.Text = ""
                txtIDNumber4.Text = ""
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
        path = My.Application.Info.DirectoryPath & "/img/Instructor Img/" & photo

        sql = " 
                INSERT INTO Photo (PhotoID, PhotoLocation) VALUES ('" & idNumber & "', '" & path & "');
                INSERT INTO NameUser (NameID, FirstName, MiddleInitial, Surname, ExtensionName) VALUES ('" & idNumber & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & txtSurname.Text & "', '" & txtExtensionName.Text & "');
                INSERT INTO Contact (ContactID, ContactNumber, EmailAddress) VALUES ('" & idNumber & "', '" & txtContactNumber.Text & "', '" & txtEmailAddress.Text & "');
                INSERT INTO AddressUser (AddressID, HomeAddress, PermanentAddress) VALUES ('" & idNumber & "', '" & txtHomeAddress.Text & "', '" & txtPermanentAddress.Text & "');
                INSERT INTO Instructor (InstructorIDNumber, DepartmentID, GenderID, CivilStatusID) VALUES ('" & idNumber & "', '" & department & "', '" & gender & "', '" & civilStatus & "');
              "

        If updateData(sql) = True Then
            IO.File.Copy(a.FileName, path)
            MsgBox("New Instructor added.", vbInformation + vbOKOnly, systemName)
            clear()
            instructor.listInstructor(Nothing)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String

        Dim idNumber = txtIDNumber.Text & "-" & txtIDNumber2.Text & "-" & txtIDNumber3.Text & "-" & txtIDNumber4.Text

        txtFirstName.Text = StrConv(txtFirstName.Text, VbStrConv.ProperCase)
        txtMiddleName.Text = StrConv(txtMiddleName.Text, VbStrConv.ProperCase)
        txtSurname.Text = StrConv(txtSurname.Text, VbStrConv.ProperCase)
        txtExtensionName.Text = StrConv(txtExtensionName.Text, VbStrConv.ProperCase)

        txtHomeAddress.Text = StrConv(txtHomeAddress.Text, VbStrConv.ProperCase)
        txtPermanentAddress.Text = StrConv(txtPermanentAddress.Text, VbStrConv.ProperCase)

        sql = " 
                UPDATE Photo SET PhotoID = '" & idNumber & "' WHERE PhotoID = '" & instructorIDNumber & "' ;
                UPDATE NameUser SET NameID = '" & idNumber & "', FirstName = '" & txtFirstName.Text & "', MiddleInitial = '" & txtMiddleName.Text & "', Surname = '" & txtSurname.Text & "', ExtensionName = '" & txtExtensionName.Text & "' WHERE NameID = '" & instructorIDNumber & "' ;
                UPDATE Contact SET ContactID = '" & idNumber & "', ContactNumber = '" & txtContactNumber.Text & "', EmailAddress = '" & txtEmailAddress.Text & "' WHERE ContactID = '" & instructorIDNumber & "' ;
                UPDATE AddressUser SET AddressID = '" & idNumber & "', HomeAddress = '" & txtHomeAddress.Text & "', PermanentAddress = '" & txtPermanentAddress.Text & "' WHERE AddressID = '" & instructorIDNumber & "' ;
                UPDATE Instructor SET InstructorIDNumber = '" & idNumber & "', DepartmentID = '" & department & "', GenderID = '" & gender & "', CivilStatusID = '" & civilStatus & "' WHERE InstructorIDNumber = '" & instructorIDNumber & "' ;
              "

        photo = idNumber & "-" & txtFirstName.Text & txtSurname.Text & "-" & time & ".jpg"
        path = My.Application.Info.DirectoryPath & "/img/Instructor Img/" & photo

        If a.FileName <> Nothing Then
            sql = sql & "UPDATE Photo SET PhotoID = '" & idNumber & "', PhotoLocation = '" & path & "' WHERE PhotoID = '" & instructorIDNumber & "' ;"
            IO.File.Copy(a.FileName, path)
        End If

        If updateData(sql) = True Then
            MsgBox("Instructor updated.", vbInformation + vbOKOnly, systemName)
            clear()
            instructor.listInstructor(Nothing)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
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