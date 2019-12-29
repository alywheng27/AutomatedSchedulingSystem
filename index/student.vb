Public Class student
    Private studentID() As Integer

    Public Sub listStudent(ByVal search As String)
        lvStudent.Items.Clear()

        Dim sql As String
        Dim dsStudent = New DataSet

        If search = Nothing Then
            sql = "SELECT * FROM StudentView WHERE Department = '" & objUser.getUserType & "' AND IsDeleted = 'False' "
        Else
            sql = "SELECT * FROM StudentView WHERE Department = '" & objUser.getUserType & "' AND (Surname LIKE '%" & search & "%' OR FirstName LIKE '%" & search & "%' OR StudentIDNumber LIKE '%" & search & "%') AND IsDeleted = 'False' "
        End If

        If fillData(sql, dsStudent, "tblStudent") = True Then
            If dsStudent.Tables("tblStudent").Rows.Count > 0 Then
                ReDim studentID(dsStudent.Tables("tblStudent").Rows.Count - 1)
                Dim i As Integer
                Dim xItem As ListViewItem

                For i = 0 To dsStudent.Tables("tblStudent").Rows.Count - 1
                    xItem = lvStudent.Items.Add(dsStudent.Tables("tblStudent").Rows(i).Item("StudentIDNumber"))

                    Dim name = dsStudent.Tables("tblStudent").Rows(i).Item("Surname") & ", " & dsStudent.Tables("tblStudent").Rows(i).Item("FirstName") & " " & dsStudent.Tables("tblStudent").Rows(i).Item("ExtensionName") & " " & dsStudent.Tables("tblStudent").Rows(i).Item("MiddleInitial") & "."
                    xItem.SubItems.Add(name)

                    xItem.SubItems.Add(dsStudent.Tables("tblStudent").Rows(i).Item("Course"))
                    xItem.SubItems.Add(dsStudent.Tables("tblStudent").Rows(i).Item("YearLevel"))
                    xItem.SubItems.Add(dsStudent.Tables("tblStudent").Rows(i).Item("Gender"))

                    studentID(i) = dsStudent.Tables("tblStudent").Rows(i).Item("StudentID")
                Next
                btnUpdateStudent.Enabled = True
                btnDeleteStudent.Enabled = True
            Else
                btnUpdateStudent.Enabled = False
                btnDeleteStudent.Enabled = False
            End If
        End If
    End Sub

    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listStudent(Nothing)
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        studentAU.studentAction.Text = "Student Information / Add"
        studentAU.btnUpdate.Enabled = False
        studentAU.btnUpdate.Hide()
        studentAU.btnSubmit.Enabled = True
        studentAU.btnSubmit.Show()
        objStudent = New PersonClass(-1)
        studentAU.ShowDialog()
    End Sub

    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        If lvStudent.SelectedIndices.Count = 0 Then Exit Sub

        If MsgBox("Are you sure that you want to delete this student?", vbQuestion + vbYesNo, systemName) = vbNo Then Exit Sub

        Dim sql As String
        sql = "UPDATE Student SET IsDeleted = 'True' WHERE StudentID = " & studentID(lvStudent.SelectedIndices(0))

        If updateData(sql) = True Then
            listStudent(Nothing)
            MsgBox("Student has been deleted.", vbInformation + vbOKOnly, systemName)
        End If
    End Sub

    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        If lvStudent.SelectedIndices.Count = 0 Then Exit Sub

        Dim sql As String
        Dim dsStudent = New DataSet

        sql = "SELECT * FROM StudentView WHERE StudentID = " & studentID(lvStudent.SelectedIndices(0))

        If fillData(sql, dsStudent, "tlbStudent") = True Then
            objStudent = New PersonClass(studentID(lvStudent.SelectedIndices(0)))
            objStudent.getStudentIDNumber = dsStudent.Tables("tlbStudent").Rows(0).Item("StudentIDNumber")
            objStudent.getPhotoLocation = dsStudent.Tables("tlbStudent").Rows(0).Item("PhotoLocation")
            objStudent.getFirstName = dsStudent.Tables("tlbStudent").Rows(0).Item("FirstName")
            objStudent.getMiddleName = dsStudent.Tables("tlbStudent").Rows(0).Item("MiddleInitial")
            objStudent.getSurname = dsStudent.Tables("tlbStudent").Rows(0).Item("Surname")
            objStudent.getExtensionName = dsStudent.Tables("tlbStudent").Rows(0).Item("ExtensionName")
            objStudent.getGender = dsStudent.Tables("tlbStudent").Rows(0).Item("Gender")
            objStudent.getCivilStatus = dsStudent.Tables("tlbStudent").Rows(0).Item("CivilStatus")
            objStudent.getYearLevel = dsStudent.Tables("tlbStudent").Rows(0).Item("YearLevel")
            objStudent.getDepartment = dsStudent.Tables("tlbStudent").Rows(0).Item("Department")
            objStudent.getCourse = dsStudent.Tables("tlbStudent").Rows(0).Item("Course")
            objStudent.getMajor = dsStudent.Tables("tlbStudent").Rows(0).Item("Major")
            objStudent.getContactNumber = dsStudent.Tables("tlbStudent").Rows(0).Item("ContactNumber")
            objStudent.getEmailAddress = dsStudent.Tables("tlbStudent").Rows(0).Item("EmailAddress")
            objStudent.getHomeAddress = dsStudent.Tables("tlbStudent").Rows(0).Item("HomeAddress")
            objStudent.getPermanentAddress = dsStudent.Tables("tlbStudent").Rows(0).Item("PermanentAddress")

            studentAU.studentAction.Text = "Student Information / Update"
            studentAU.btnSubmit.Enabled = False
            studentAU.btnSubmit.Hide()
            studentAU.btnUpdate.Enabled = True
            studentAU.btnUpdate.Show()

            studentAU.studentIDNumber = objStudent.getStudentIDNumber

            studentAU.ShowDialog()
        End If
    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        listStudent(txtSearch.Text)
    End Sub
End Class