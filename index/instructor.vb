Public Class instructor

    Private instructorID() As Integer

    Private Sub instructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listInstructor(Nothing)
    End Sub

    Public Sub listInstructor(ByVal search As String)
        lvInstructor.Items.Clear()

        Dim sql As String
        Dim dsInstructor = New DataSet

        If search = Nothing Then
            sql = "SELECT * FROM InstructorView WHERE Department = '" & objUser.getUserType & "' AND IsDeleted = 'False' ORDER BY Surname ASC "
        Else
            sql = "SELECT * FROM InstructorView WHERE Department = '" & objUser.getUserType & "' AND (Surname LIKE '%" & search & "%' OR FirstName LIKE '%" & search & "%' OR StudentIDNumber LIKE '%" & search & "%') AND IsDeleted = 'False' ORDER BY Surname ASC "
        End If

        If fillData(sql, dsInstructor, "tblInstructor") = True Then
            If dsInstructor.Tables("tblInstructor").Rows.Count > 0 Then
                ReDim instructorID(dsInstructor.Tables("tblInstructor").Rows.Count - 1)
                Dim i As Integer
                Dim xItem As ListViewItem

                For i = 0 To dsInstructor.Tables("tblInstructor").Rows.Count - 1
                    xItem = lvInstructor.Items.Add(dsInstructor.Tables("tblInstructor").Rows(i).Item("InstructorIDNumber"))

                    Dim name = dsInstructor.Tables("tblInstructor").Rows(i).Item("Surname") & ", " & dsInstructor.Tables("tblInstructor").Rows(i).Item("FirstName") & " " & dsInstructor.Tables("tblInstructor").Rows(i).Item("ExtensionName") & " " & dsInstructor.Tables("tblInstructor").Rows(i).Item("MiddleInitial") & "."
                    xItem.SubItems.Add(name)

                    xItem.SubItems.Add(dsInstructor.Tables("tblInstructor").Rows(i).Item("Department"))
                    xItem.SubItems.Add(dsInstructor.Tables("tblInstructor").Rows(i).Item("Gender"))

                    instructorID(i) = dsInstructor.Tables("tblInstructor").Rows(i).Item("InstructorID")
                Next
                btnUpdateInstructor.Enabled = True
                btnDeleteInstructor.Enabled = True
            Else
                btnUpdateInstructor.Enabled = False
                btnDeleteInstructor.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAddInstructor_Click(sender As Object, e As EventArgs) Handles btnAddInstructor.Click
        instructorAU.studentAction.Text = "Instructor Information / Add"
        instructorAU.btnUpdate.Enabled = False
        instructorAU.btnUpdate.Hide()
        instructorAU.btnSubmit.Enabled = True
        instructorAU.btnSubmit.Show()
        objStudent = New PersonClass(-1)
        instructorAU.ShowDialog()
    End Sub

    Private Sub btnUpdateInstructor_Click(sender As Object, e As EventArgs) Handles btnUpdateInstructor.Click
        If lvInstructor.SelectedIndices.Count = 0 Then Exit Sub

        Dim sql As String
        Dim dsInstructor = New DataSet

        sql = "SELECT * FROM InstructorView WHERE InstructorID = " & instructorID(lvInstructor.SelectedIndices(0))

        If fillData(sql, dsInstructor, "tblInstructor") = True Then
            objStudent = New PersonClass(instructorID(lvInstructor.SelectedIndices(0)))
            objStudent.getInstructorIDNumber = dsInstructor.Tables("tblInstructor").Rows(0).Item("InstructorIDNumber")
            objStudent.getPhotoLocation = dsInstructor.Tables("tblInstructor").Rows(0).Item("PhotoLocation")
            objStudent.getFirstName = dsInstructor.Tables("tblInstructor").Rows(0).Item("FirstName")
            objStudent.getMiddleName = dsInstructor.Tables("tblInstructor").Rows(0).Item("MiddleInitial")
            objStudent.getSurname = dsInstructor.Tables("tblInstructor").Rows(0).Item("Surname")
            objStudent.getExtensionName = dsInstructor.Tables("tblInstructor").Rows(0).Item("ExtensionName")
            objStudent.getGender = dsInstructor.Tables("tblInstructor").Rows(0).Item("Gender")
            objStudent.getCivilStatus = dsInstructor.Tables("tblInstructor").Rows(0).Item("CivilStatus")
            objStudent.getDepartment = dsInstructor.Tables("tblInstructor").Rows(0).Item("Department")
            objStudent.getContactNumber = dsInstructor.Tables("tblInstructor").Rows(0).Item("ContactNumber")
            objStudent.getEmailAddress = dsInstructor.Tables("tblInstructor").Rows(0).Item("EmailAddress")
            objStudent.getHomeAddress = dsInstructor.Tables("tblInstructor").Rows(0).Item("HomeAddress")
            objStudent.getPermanentAddress = dsInstructor.Tables("tblInstructor").Rows(0).Item("PermanentAddress")

            instructorAU.studentAction.Text = "Instructor Information / Update"
            instructorAU.btnSubmit.Enabled = False
            instructorAU.btnSubmit.Hide()
            instructorAU.btnUpdate.Enabled = True
            instructorAU.btnUpdate.Show()

            instructorAU.instructorIDNumber = objStudent.getInstructorIDNumber

            instructorAU.ShowDialog()
        End If
    End Sub

    Private Sub btnDeleteInstructor_Click(sender As Object, e As EventArgs) Handles btnDeleteInstructor.Click
        If lvInstructor.SelectedIndices.Count = 0 Then Exit Sub

        If MsgBox("Are you sure that you want to delete this instructor?", vbQuestion + vbYesNo, systemName) = vbNo Then Exit Sub

        Dim sql As String
        sql = "UPDATE Instructor SET IsDeleted = 'True' WHERE InstructorID = " & instructorID(lvInstructor.SelectedIndices(0))

        If updateData(sql) = True Then
            listInstructor(Nothing)
            MsgBox("Instructor has been deleted.", vbInformation + vbOKOnly, systemName)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        listInstructor(txtSearch.Text)
    End Sub
End Class