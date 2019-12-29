Public Class classRegistration

    Private enrolledID() As Integer
    Private classID() As Integer
    Private subject() As String
    Private timeStartID() As Integer
    Private timeEndID() As Integer
    Private days() As String

    Private studentID As Integer = Nothing

    Private Sub classRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listClass(Nothing)
    End Sub

    Public Sub listClass(ByVal search As String)
        lvClass.Items.Clear()

        Dim sql As String
        Dim dsClass = New DataSet
        Dim dsDay = New DataSet
        Dim dsTime = New DataSet

        If search = Nothing Then
            sql = "SELECT * FROM ClassScheduleView WHERE IsDeleted = 'False' "
        Else
            sql = "SELECT * FROM ClassScheduleView WHERE Subject LIKE '%" & search & "%' AND IsDeleted = 'False' "
        End If

        If fillData(sql, dsClass, "tblClass") = True Then
            If dsClass.Tables("tblClass").Rows.Count > 0 Then
                ReDim classID(dsClass.Tables("tblClass").Rows.Count - 1)
                ReDim subject(dsClass.Tables("tblClass").Rows.Count - 1)
                ReDim timeStartID(dsClass.Tables("tblClass").Rows.Count - 1)
                ReDim timeEndID(dsClass.Tables("tblClass").Rows.Count - 1)
                ReDim days(dsClass.Tables("tblClass").Rows.Count - 1)

                Dim i As Integer
                Dim xItem As ListViewItem

                For i = 0 To dsClass.Tables("tblClass").Rows.Count - 1
                    xItem = lvClass.Items.Add(dsClass.Tables("tblClass").Rows(i).Item("Subject"))

                    sql = "SELECT Day FROM DayScheduleView WHERE ClassScheduleID = " & dsClass.Tables("tblClass").Rows(i).Item("ClassScheduleID").ToString
                    fillData(sql, dsDay, "tblDay")

                    Dim day = ""
                    For x = 0 To dsDay.Tables("tblDay").Rows.Count - 1
                        day = day & dsDay.Tables("tblDay").Rows(x).Item("Day")
                    Next

                    sql = "SELECT Time FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeStartID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeStart = dsTime.Tables("tblTime").Rows(0).Item("Time")

                    sql = "SELECT Time FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeEndID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeEnd = dsTime.Tables("tblTime").Rows(0).Item("Time")

                    Dim time = timeStart & " - " & timeEnd

                    xItem.SubItems.Add(time & " " & day)

                    xItem.SubItems.Add(dsClass.Tables("tblClass").Rows(i).Item("Section"))
                    xItem.SubItems.Add(dsClass.Tables("tblClass").Rows(i).Item("Room"))

                    subject(i) = dsClass.Tables("tblClass").Rows(i).Item("Subject")
                    classID(i) = dsClass.Tables("tblClass").Rows(i).Item("ClassScheduleID")
                    timeStartID(i) = dsClass.Tables("tblClass").Rows(i).Item("TimeStartID")
                    timeEndID(i) = dsClass.Tables("tblClass").Rows(i).Item("TimeEndID")
                    days(i) = day
                Next
            End If
        End If
    End Sub

    Public Sub listEnrolled(ByVal searchStudent As Integer, ByVal search As String)
        lvEnrolled.Items.Clear()

        Dim sql As String
        Dim dsRegister = New DataSet
        Dim dsDay = New DataSet
        Dim dsTime = New DataSet



        If search = Nothing Then
            sql = "SELECT * FROM ClassRegistrationView WHERE StudentID = " & searchStudent & " AND IsDeleted = 'False' "
        Else
            sql = "SELECT * FROM ClassRegistrationView WHERE StudentID = " & searchStudent & " AND Subject LIKE '%" & search & "%' AND IsDeleted = 'False' "
        End If

        If fillData(sql, dsRegister, "tblRegister") = True Then
            If dsRegister.Tables("tblRegister").Rows.Count > 0 Then
                ReDim enrolledID(dsRegister.Tables("tblRegister").Rows.Count - 1)
                Dim i As Integer
                Dim xItem As ListViewItem

                For i = 0 To dsRegister.Tables("tblRegister").Rows.Count - 1
                    xItem = lvEnrolled.Items.Add(dsRegister.Tables("tblRegister").Rows(i).Item("Subject"))

                    sql = "SELECT Day FROM DayScheduleView WHERE ClassScheduleID = " & dsRegister.Tables("tblRegister").Rows(i).Item("ClassScheduleID").ToString
                    fillData(sql, dsDay, "tblDay")

                    Dim day = ""
                    For x = 0 To dsDay.Tables("tblDay").Rows.Count - 1
                        day = day & dsDay.Tables("tblDay").Rows(x).Item("Day")
                    Next

                    sql = "SELECT Time FROM Time WHERE TimeID = " & dsRegister.Tables("tblRegister").Rows(i).Item("TimeStartID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeStart = dsTime.Tables("tblTime").Rows(0).Item("Time")

                    sql = "SELECT Time FROM Time WHERE TimeID = " & dsRegister.Tables("tblRegister").Rows(i).Item("TimeEndID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeEnd = dsTime.Tables("tblTime").Rows(0).Item("Time")

                    Dim time = timeStart & " - " & timeEnd

                    xItem.SubItems.Add(time & " " & day)

                    xItem.SubItems.Add(dsRegister.Tables("tblRegister").Rows(i).Item("Section"))
                    xItem.SubItems.Add(dsRegister.Tables("tblRegister").Rows(i).Item("Room"))

                    enrolledID(i) = dsRegister.Tables("tblRegister").Rows(i).Item("ClassRegistrationID")
                Next

            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If checkfields() = False Then
            Exit Sub
        End If

        Dim sql As String
        Dim dsStudent = New DataSet

        Dim studentIDNumber As String = txtIDNumber.Text & "-" & txtIDNumber2.Text
        sql = "SELECT * FROM StudentView WHERE StudentIDNumber = '" & studentIDNumber & "' AND IsDeleted = 'False' "

        If fillData(sql, dsStudent, "tblStudent") = True Then
            If dsStudent.Tables("tblStudent").Rows.Count > 0 Then
                Dim name As String = dsStudent.Tables("tblStudent").Rows(0).Item("Surname") & ", " & dsStudent.Tables("tblStudent").Rows(0).Item("FirstName") & " " & dsStudent.Tables("tblStudent").Rows(0).Item("ExtensionName") & " " & dsStudent.Tables("tblStudent").Rows(0).Item("MiddleInitial")

                txtName.Text = name
                txtGender.Text = dsStudent.Tables("tblStudent").Rows(0).Item("Gender")
                txtYearLevel.Text = dsStudent.Tables("tblStudent").Rows(0).Item("YearLevel")
                txtCourse.Text = dsStudent.Tables("tblStudent").Rows(0).Item("Course")
                txtMajor.Text = dsStudent.Tables("tblStudent").Rows(0).Item("Major")

                studentImage.Image = Image.FromFile(dsStudent.Tables("tblStudent").Rows(0).Item("PhotoLocation"))
                studentImage.BackgroundImage = Nothing

                studentID = dsStudent.Tables("tblStudent").Rows(0).Item("StudentID")
                listEnrolled(studentID, Nothing)
            Else
                MsgBox("No result found.", vbInformation + vbOKOnly, systemName)
                clear()

            End If
        End If
    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs) Handles txtSubject.TextChanged
        listClass(txtSubject.Text)
    End Sub

    Private Sub txtEnrolledSubject_TextChanged(sender As Object, e As EventArgs) Handles txtEnrolledSubject.TextChanged
        listEnrolled(studentID, txtEnrolledSubject.Text)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If lvClass.SelectedIndices.Count = 0 Then Exit Sub

        If studentID = Nothing Then
            MsgBox("Please enter a Student.", vbInformation + vbOKOnly, systemName)
            txtIDNumber.Focus()
            Exit Sub
        End If

        Dim sql As String

        Dim dsRegister = New DataSet
        Dim dsTime = New DataSet
        Dim dsDay = New DataSet

        sql = "SELECT ClassRegistrationID FROM ClassRegistrationView WHERE StudentID = '" & studentID & "' AND Subject = '" & subject(lvClass.SelectedIndices(0)) & "' AND IsDeleted = 'False' "

        If fillData(sql, dsRegister, "tblRegister") = True Then
            If dsRegister.Tables("tblRegister").Rows.Count > 0 Then
                MsgBox("Subject already enrolled! Please select another Subject.", vbInformation + vbOKOnly, systemName)
                Exit Sub
            End If
        End If

        sql = "SELECT ClassScheduleID, TimeStartID, TimeEndID FROM ClassRegistrationView WHERE StudentID = '" & studentID & "' AND IsDeleted = 'False' "

        If fillData(sql, dsRegister, "tblRegister") = True Then
            If dsRegister.Tables("tblRegister").Rows.Count > 0 Then
                For i = 0 To dsRegister.Tables("tblRegister").Rows.Count - 1
                    sql = "SELECT TimeID, TimeSection FROM Time WHERE TimeID = " & dsRegister.Tables("tblRegister").Rows(i).Item("TimeStartID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeStart As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeID")
                    Dim timeStartSection As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeSection")

                    sql = "SELECT TimeID, TimeSection FROM Time WHERE TimeID = " & dsRegister.Tables("tblRegister").Rows(i).Item("TimeEndID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeEnd As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeID")
                    Dim timeEndSection As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeSection")

                    sql = "SELECT Day FROM DayScheduleView WHERE ClassScheduleID = " & dsRegister.Tables("tblRegister").Rows(i).Item("ClassScheduleID").ToString
                    fillData(sql, dsDay, "tblDay")

                    Dim timeDifference As Integer = timeEnd - timeStart

                    Dim day = ""
                    For x = 0 To dsDay.Tables("tblDay").Rows.Count - 1
                        day = dsDay.Tables("tblDay").Rows(x).Item("Day")

                        Dim dayCheck As Boolean = False

                        If days(lvClass.SelectedIndices(0)).Contains(day) Then
                            dayCheck = True
                        End If

                        If day = "T" And days(lvClass.SelectedIndices(0)) = "Th" Then
                            dayCheck = False
                        ElseIf day = "S" And days(lvClass.SelectedIndices(0)) = "Su" Then
                            dayCheck = False
                        End If

                        If dayCheck And ((timeStartID(lvClass.SelectedIndices(0)) >= timeStart And timeStartID(lvClass.SelectedIndices(0)) < timeEnd) Or (timeEndID(lvClass.SelectedIndices(0)) > timeStart And timeEndID(lvClass.SelectedIndices(0)) <= timeEnd)) Then
                            MsgBox("This Time/Day have conflicts with the schedule. Please select other Schedule.", vbInformation + vbOKOnly, systemName)
                            Exit Sub
                        End If
                    Next

                Next
            End If
        End If

        sql = " 
                INSERT INTO ClassRegistration (StudentID, ClassScheduleID) VALUES ('" & studentID & "', " & classID(lvClass.SelectedIndices(0)) & ");
              "

        If updateData(sql) = True Then
            listEnrolled(studentID, Nothing)
            MsgBox("Subject Enrolled.", vbInformation + vbOKOnly, systemName)
        End If
    End Sub

    Private Function checkfields()
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

        Return True
    End Function

    Private Sub clear()
        txtName.Text = ""
        txtGender.Text = ""
        txtYearLevel.Text = ""
        txtCourse.Text = ""
        txtMajor.Text = ""

        studentImage.Image = Nothing
        studentImage.BackgroundImage = Nothing
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lvEnrolled.SelectedIndices.Count = 0 Then Exit Sub

        If MsgBox("Are you sure that you want to remove this class?", vbQuestion + vbYesNo, systemName) = vbNo Then Exit Sub

        Dim sql As String
        sql = "UPDATE ClassRegistration SET IsDeleted = 'True' WHERE ClassRegistrationID = " & enrolledID(lvEnrolled.SelectedIndices(0))

        If updateData(sql) = True Then
            listEnrolled(studentID, Nothing)
            MsgBox("Class has been Removed.", vbInformation + vbOKOnly, systemName)
        End If
    End Sub
End Class