Public Class classSchedule

    Private classID() As Integer
    Private semesterID() As Integer

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddClass.Click
        classScheduleAU.studentAction.Text = "Class Information / Add"
        classScheduleAU.btnUpdate.Enabled = False
        classScheduleAU.btnUpdate.Hide()
        classScheduleAU.btnSubmit.Enabled = True
        classScheduleAU.btnSubmit.Show()
        objSchedule = New ScheduleClass(-1)
        classScheduleAU.ShowDialog()
    End Sub

    Private Sub btnUpdateClass_Click(sender As Object, e As EventArgs) Handles btnUpdateClass.Click
        If lvClass.SelectedIndices.Count = 0 Then Exit Sub

        Dim sql As String
        Dim dsClass = New DataSet
        Dim dsDay = New DataSet
        Dim dsTime = New DataSet

        sql = "SELECT * FROM ClassScheduleView WHERE ClassScheduleID = " & classID(lvClass.SelectedIndices(0))

        If fillData(sql, dsClass, "tblClass") = True Then
            objSchedule = New ScheduleClass(classID(lvClass.SelectedIndices(0)))
            objSchedule.getClassScheduleID = dsClass.Tables("tblClass").Rows(0).Item("ClassScheduleID")
            objSchedule.getSubjectID = dsClass.Tables("tblClass").Rows(0).Item("SubjectID")
            objSchedule.getSubject = dsClass.Tables("tblClass").Rows(0).Item("Subject")

            sql = "SELECT Time FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(0).Item("TimeStartID").ToString
            fillData(sql, dsTime, "tblTime")

            objSchedule.getTimeStartID = dsClass.Tables("tblClass").Rows(0).Item("TimeStartID")
            objSchedule.getTimeStart = dsTime.Tables("tblTime").Rows(0).Item("Time")

            sql = "SELECT Time FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(0).Item("TimeEndID").ToString
            fillData(sql, dsTime, "tblTime")

            Dim timeEnd = dsTime.Tables("tblTime").Rows(0).Item("Time")

            objSchedule.getTimeEndID = dsClass.Tables("tblClass").Rows(0).Item("TimeEndID")
            objSchedule.getTimeEnd = dsTime.Tables("tblTime").Rows(0).Item("Time")

            objSchedule.getRoomID = dsClass.Tables("tblClass").Rows(0).Item("RoomID")
            objSchedule.getRoom = dsClass.Tables("tblClass").Rows(0).Item("Room")

            objSchedule.getSectionID = dsClass.Tables("tblClass").Rows(0).Item("SectionID")
            objSchedule.getSection = dsClass.Tables("tblClass").Rows(0).Item("Section")

            Dim name = dsClass.Tables("tblClass").Rows(0).Item("FirstName") & " " & dsClass.Tables("tblClass").Rows(0).Item("Surname")
            objSchedule.getInstructorID = dsClass.Tables("tblClass").Rows(0).Item("InstructorID")
            objSchedule.getName = name

            objSchedule.getsemesterID = dsClass.Tables("tblClass").Rows(0).Item("SemesterID")
            objSchedule.getSemester = dsClass.Tables("tblClass").Rows(0).Item("Semester")
            objSchedule.getAcademicYear = dsClass.Tables("tblClass").Rows(0).Item("AcademicYear")

            classScheduleAU.studentAction.Text = "Class Information / Update"
            classScheduleAU.btnSubmit.Enabled = False
            classScheduleAU.btnSubmit.Hide()
            classScheduleAU.btnUpdate.Enabled = True
            classScheduleAU.btnUpdate.Show()

            classScheduleAU.classID = objSchedule.getClassScheduleID

            classScheduleAU.ShowDialog()
        End If
    End Sub

    Private Sub btnDeleteClass_Click(sender As Object, e As EventArgs) Handles btnDeleteClass.Click
        If lvClass.SelectedIndices.Count = 0 Then Exit Sub

        If MsgBox("Are you sure that you want to delete this class?", vbQuestion + vbYesNo, systemName) = vbNo Then Exit Sub

        Dim sql As String
        sql = "UPDATE ClassSchedule SET IsDeleted = 'True' WHERE ClassScheduleID = " & classID(lvClass.SelectedIndices(0))

        If updateData(sql) = True Then
            listClassSchedule(Nothing, Nothing)
            MsgBox("Class has been deleted.", vbInformation + vbOKOnly, systemName)
        End If
    End Sub

    Private Sub classSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listClassSchedule(Nothing, Nothing)
        loadAcademicYear()
        loadSemester()
    End Sub

    Public Sub listClassSchedule(ByVal searchAY As String, ByVal searchSem As String)
        lvClass.Items.Clear()

        Dim sql As String
        Dim dsClass = New DataSet
        Dim dsDay = New DataSet
        Dim dsTime = New DataSet

        If searchAY = Nothing And searchSem = Nothing Then
            sql = "SELECT * FROM ClassScheduleView WHERE IsDeleted = 'False' AND AcademicYear = '" & objCurrent.getYear & "' AND Semester = '" & objCurrent.getSemester & "' ORDER BY FirstName, Subject ASC "
        Else
            sql = "SELECT * FROM ClassScheduleView WHERE (AcademicYear = '" & searchAY & "' AND Semester = '" & searchSem & "') AND  IsDeleted = 'False' ORDER BY FirstName, Subject ASC  "
        End If

        If fillData(sql, dsClass, "tblClass") = True Then
            If dsClass.Tables("tblClass").Rows.Count > 0 Then
                ReDim classID(dsClass.Tables("tblClass").Rows.Count - 1)
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

                    xItem.SubItems.Add(day)

                    sql = "SELECT Time FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeStartID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeStart = dsTime.Tables("tblTime").Rows(0).Item("Time")

                    sql = "SELECT Time FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeEndID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeEnd = dsTime.Tables("tblTime").Rows(0).Item("Time")

                    Dim time = timeStart & " - " & timeEnd

                    xItem.SubItems.Add(time)

                    xItem.SubItems.Add(dsClass.Tables("tblClass").Rows(i).Item("Room"))
                    xItem.SubItems.Add(dsClass.Tables("tblClass").Rows(i).Item("Section"))

                    Dim name = dsClass.Tables("tblClass").Rows(i).Item("FirstName") & " " & dsClass.Tables("tblClass").Rows(i).Item("Surname")
                    xItem.SubItems.Add(name)

                    xItem.SubItems.Add(dsClass.Tables("tblClass").Rows(i).Item("Semester"))
                    xItem.SubItems.Add(dsClass.Tables("tblClass").Rows(i).Item("AcademicYear"))

                    classID(i) = dsClass.Tables("tblClass").Rows(i).Item("ClassScheduleID")
                Next
                btnUpdateClass.Enabled = True
                btnDeleteClass.Enabled = True
            Else
                btnUpdateClass.Enabled = False
                btnDeleteClass.Enabled = False
            End If
        End If
    End Sub

    Private Sub loadSemester()
        cbSemester.Items.Clear()

        Dim sql As String
        Dim dsInstructor = New DataSet

        sql = "SELECT SemesterID, Semester FROM Semester "

        If fillData(sql, dsInstructor, "tblSemester") = True Then
            If dsInstructor.Tables("tblSemester").Rows.Count > 0 Then
                ReDim semesterID(dsInstructor.Tables("tblSemester").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsInstructor.Tables("tblSemester").Rows.Count - 1
                    cbSemester.Items.Add(dsInstructor.Tables("tblSemester").Rows(i).Item("Semester"))
                    semesterID(i) = dsInstructor.Tables("tblSemester").Rows(i).Item("SemesterID")
                Next
            End If
        End If
    End Sub

    Private Sub loadAcademicYear()
        cbAcademicYear.Items.Clear()

        Dim past = 2019
        Dim present = DateTime.Now.Year + 1

        For i = past To present
            Dim ay = i.ToString & " - " & (i + 1).ToString
            cbAcademicYear.Items.Add(ay)
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If checkFields() = False Then
            Exit Sub
        End If

        listClassSchedule(cbAcademicYear.Text, cbSemester.Text)
    End Sub

    Private Function checkFields()
        If cbAcademicYear.Text = "" Then
            MsgBox("Please select an Academic Year.", vbInformation + vbOKOnly, systemName)
            cbAcademicYear.Focus()
            Return False
        End If

        If cbSemester.Text = "" Then
            MsgBox("Please select a Semester.", vbInformation + vbOKOnly, systemName)
            cbSemester.Focus()
            Return False
        End If

        Return True
    End Function
End Class