Public Class classScheduleAU

    Private subjectID() As Integer
    Private roomID() As Integer
    Private sectionID() As Integer
    Private instructorID() As Integer
    Private semesterID() As Integer
    Private timeStartID() As Integer
    Private timeEndID() As Integer
    Private dayID() As Integer

    Private timeStartSection() As Integer
    Private timeEndSection() As Integer

    Private passSubjectID As Integer
    Private passTimeStartID As Integer
    Private passTimeEndID As Integer
    Private passRoomID As Integer
    Private passSectionID As Integer
    Private passInstructorID As Integer
    Private passSemesterID As Integer

    Private passTimeStartSection As Integer
    Private passTimeEndSection As Integer

    Private day As String
    Private academicYear As String

    Public classID As Integer

    Private Sub classScheduleAU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listSubject(Nothing)
        loadRoom()
        loadSection()
        loadInstructor()
        loadAcademicYear()
        loadSemester()
        loadUpdateList()
    End Sub

    Private Sub lvSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSubject.SelectedIndexChanged
        If lvSubject.SelectedIndices.Count = 0 Then Exit Sub

        Dim sql As String
        Dim dsRoom = New DataSet

        sql = "SELECT Subject FROM Subject WHERE SubjectID = " & subjectID(lvSubject.SelectedIndices(0))

        If fillData(sql, dsRoom, "tblSubject") = True Then
            txtSubject.Text = dsRoom.Tables("tblSubject").Rows(0).Item("Subject")
            passSubjectID = subjectID(lvSubject.SelectedIndices(0))
        End If

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

    Private Sub cbTimeStart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTimeStart.SelectedIndexChanged
        passTimeStartID = timeStartID(cbTimeStart.SelectedIndex)
        passTimeStartSection = timeStartSection(cbTimeStart.SelectedIndex)

        loadTimeEnd(timeStartID(cbTimeStart.SelectedIndex), day)
    End Sub

    Private Sub cbTimeEnd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTimeEnd.SelectedIndexChanged
        passTimeEndID = timeEndID(cbTimeEnd.SelectedIndex)
        passTimeEndSection = timeEndSection(cbTimeEnd.SelectedIndex)
    End Sub

    Private Sub cbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoom.SelectedIndexChanged
        passRoomID = roomID(cbRoom.SelectedIndex)
    End Sub

    Private Sub cbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSection.SelectedIndexChanged
        passSectionID = sectionID(cbSection.SelectedIndex)
    End Sub

    Private Sub cbInstructor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInstructor.SelectedIndexChanged
        passInstructorID = instructorID(cbInstructor.SelectedIndex)
    End Sub

    Private Sub cbAcademicYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAcademicYear.SelectedIndexChanged
        academicYear = cbAcademicYear.Text
    End Sub

    Private Sub cbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        passSemesterID = semesterID(cbSemester.SelectedIndex)
    End Sub

    Public Sub listSubject(ByVal search As String)
        lvSubject.Items.Clear()

        Dim sql As String
        Dim dsSubject = New DataSet

        If search = Nothing Then
            sql = "SELECT * FROM SubjectView WHERE Department = '" & objUser.getUserType & "' AND IsDeleted = 'False' "
        Else
            sql = "SELECT * FROM SubjectView WHERE Department = '" & objUser.getUserType & "' AND ((Subject LIKE '%" & search & "%') OR (SubjectDescription LIKE '%" & search & "%')) AND IsDeleted = 'False' "
        End If

        If fillData(sql, dsSubject, "tblSubject") = True Then
            If dsSubject.Tables("tblSubject").Rows.Count > 0 Then
                ReDim subjectID(dsSubject.Tables("tblSubject").Rows.Count - 1)
                Dim i As Integer
                Dim xItem As ListViewItem

                For i = 0 To dsSubject.Tables("tblSubject").Rows.Count - 1
                    xItem = lvSubject.Items.Add(dsSubject.Tables("tblSubject").Rows(i).Item("Subject"))
                    xItem.SubItems.Add(dsSubject.Tables("tblSubject").Rows(i).Item("SubjectDescription"))

                    subjectID(i) = dsSubject.Tables("tblSubject").Rows(i).Item("SubjectID")
                Next
            End If
        End If
    End Sub

    Private Sub loadRoom()
        cbRoom.Items.Clear()

        Dim sql As String
        Dim dsRoom = New DataSet

        sql = "SELECT * FROM RoomView WHERE Department = '" & objUser.getUserType & "' AND IsDeleted = 'False' "

        If fillData(sql, dsRoom, "tblRoom") = True Then
            If dsRoom.Tables("tblRoom").Rows.Count > 0 Then
                ReDim roomID(dsRoom.Tables("tblRoom").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsRoom.Tables("tblRoom").Rows.Count - 1
                    cbRoom.Items.Add(dsRoom.Tables("tblRoom").Rows(i).Item("Room"))
                    roomID(i) = dsRoom.Tables("tblRoom").Rows(i).Item("RoomID")
                Next
            End If
        End If
    End Sub

    Private Sub loadSection()
        cbSection.Items.Clear()

        Dim sql As String
        Dim dsSection = New DataSet

        sql = "SELECT * FROM Section "

        If fillData(sql, dsSection, "tblSection") = True Then
            If dsSection.Tables("tblSection").Rows.Count > 0 Then
                ReDim sectionID(dsSection.Tables("tblSection").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsSection.Tables("tblSection").Rows.Count - 1
                    cbSection.Items.Add(dsSection.Tables("tblSection").Rows(i).Item("Section"))
                    sectionID(i) = dsSection.Tables("tblSection").Rows(i).Item("SectionID")
                Next
            End If
        End If
    End Sub

    Private Sub loadInstructor()
        cbInstructor.Items.Clear()

        Dim sql As String
        Dim dsInstructor = New DataSet

        sql = "SELECT * FROM InstructorView WHERE Department = '" & objUser.getUserType & "' AND IsDeleted = 'False' "

        If fillData(sql, dsInstructor, "tblInstructor") = True Then
            If dsInstructor.Tables("tblInstructor").Rows.Count > 0 Then
                ReDim instructorID(dsInstructor.Tables("tblInstructor").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsInstructor.Tables("tblInstructor").Rows.Count - 1
                    Dim name = dsInstructor.Tables("tblInstructor").Rows(i).Item("FirstName") & " " & dsInstructor.Tables("tblInstructor").Rows(i).Item("Surname")
                    cbInstructor.Items.Add(name)
                    instructorID(i) = dsInstructor.Tables("tblInstructor").Rows(i).Item("InstructorID")
                Next
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

        Dim pastYear = DateTime.Now.Year - 1
        Dim yearFuture = DateTime.Now.Year + 1

        Dim pastYearS = pastYear.ToString & " - " & DateTime.Now.Year.ToString
        Dim yearFutureS = DateTime.Now.Year.ToString & " - " & yearFuture.ToString

        cbAcademicYear.Items.Add(pastYearS)
        cbAcademicYear.Items.Add(yearFutureS)
    End Sub

    Private Sub loadTimeStart(ByVal check As String)
        cbTimeStart.Items.Clear()

        Dim sql As String
        Dim dsTimeStart = New DataSet

        If check = "MWF" Then
            sql = "SELECT * FROM Time WHERE TimeSection = 3 OR TimeSection = 1 AND TimeID != 14 "
        Else
            sql = "SELECT * FROM Time WHERE TimeSection = 3 OR TimeSection = 2 "
        End If


        If fillData(sql, dsTimeStart, "tblTimeStart") = True Then
            If dsTimeStart.Tables("tblTimeStart").Rows.Count > 0 Then
                ReDim timeStartID(dsTimeStart.Tables("tblTimeStart").Rows.Count - 1)
                ReDim timeStartSection(dsTimeStart.Tables("tblTimeStart").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsTimeStart.Tables("tblTimeStart").Rows.Count - 1
                    cbTimeStart.Items.Add(dsTimeStart.Tables("tblTimeStart").Rows(i).Item("Time"))

                    day = check
                    timeStartID(i) = dsTimeStart.Tables("tblTimeStart").Rows(i).Item("TimeID")
                    timeStartSection(i) = dsTimeStart.Tables("tblTimeStart").Rows(i).Item("TimeSection")
                Next
            End If
        End If
    End Sub

    Private Sub loadTimeEnd(ByVal timeStart As Integer, ByVal day As String)
        cbTimeEnd.Items.Clear()

        Dim sql As String
        Dim dsTimeEnd = New DataSet

        If day = "MWF" Then
            If timeStart = 1 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 2 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 4 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 5 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 6 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 8 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 9 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 10 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            ElseIf timeStart = 12 Then
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2"
            Else
                sql = "SELECT TOP 3 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 2 "
            End If

        Else
            sql = "SELECT TOP 2 * FROM Time WHERE TimeID > " & timeStart & "AND TimeSection != 1 "
        End If

        If fillData(sql, dsTimeEnd, "tblTimeEnd") = True Then
            If dsTimeEnd.Tables("tblTimeEnd").Rows.Count > 0 Then
                ReDim timeEndID(dsTimeEnd.Tables("tblTimeEnd").Rows.Count - 1)
                ReDim timeEndSection(dsTimeEnd.Tables("tblTimeEnd").Rows.Count - 1)

                Dim i As Integer

                For i = 0 To dsTimeEnd.Tables("tblTimeEnd").Rows.Count - 1
                    cbTimeEnd.Items.Add(dsTimeEnd.Tables("tblTimeEnd").Rows(i).Item("Time"))
                    timeEndID(i) = dsTimeEnd.Tables("tblTimeEnd").Rows(i).Item("TimeID")
                    timeEndSection(i) = dsTimeEnd.Tables("tblTimeEnd").Rows(i).Item("TimeSection")
                Next
            End If
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String

        Dim dsDay = New DataSet

        If checkRestriction("Add") = False Then
            Exit Sub
        End If

        sql = " 
                INSERT INTO ClassSchedule (SubjectID, TimeStartID, TimeEndID, RoomID, SectionID, InstructorID, SemesterID, AcademicYear) VALUES ('" & passSubjectID & "', '" & passTimeStartID & "', '" & passTimeEndID & "', '" & passRoomID & "', '" & passSectionID & "', '" & passInstructorID & "', '" & passSemesterID & "', '" & academicYear & "');
              "

        If updateData(sql) = True Then

            sql = " 
                SELECT ClassScheduleID FROM ClassSchedule WHERE SubjectID = " & passSubjectID & " AND TimeStartID = " & passTimeStartID & " AND TimeEndID = " & passTimeEndID & " AND RoomID = " & passRoomID & " AND InstructorID = " & passInstructorID & " AND SemesterID = " & passSemesterID & " AND AcademicYear = '" & academicYear & "'
              "

            If fillData(sql, dsDay, "tblDay") = True Then
                If dsDay.Tables("tblDay").Rows.Count > 0 Then
                    Dim count = 0
                    ReDim dayID(7)
                    Dim daySring As String = Nothing

                    If chbMon.Checked Then
                        dayID(count) = 1
                        count += 1
                        daySring = daySring & "M"
                    End If
                    If chbTue.Checked Then
                        dayID(count) = 2
                        count += 1
                        daySring = daySring & "T"
                    End If
                    If chbWed.Checked Then
                        dayID(count) = 3
                        count += 1
                        daySring = daySring & "W"
                    End If
                    If chbThu.Checked Then
                        dayID(count) = 4
                        count += 1
                        daySring = daySring & "Th"
                    End If
                    If chbFri.Checked Then
                        dayID(count) = 5
                        count += 1
                        daySring = daySring & "F"
                    End If
                    If chbSat.Checked Then
                        dayID(count) = 6
                        count += 1
                        daySring = daySring & "S"
                    End If
                    If chbSun.Checked Then
                        dayID(count) = 7
                        count += 1
                        daySring = daySring & "Su"
                    End If

                    For i = 0 To count - 1
                        sql = " 
                            INSERT INTO DaySchedule (ClassScheduleID, DayID) VALUES (" & dsDay.Tables("tblDay").Rows(0).Item("ClassScheduleID") & ", " & dayID(i) & ");
                          "
                        updateData(sql)
                    Next

                    sql = " 
                            INSERT INTO GroupDaySchedule (ClassScheduleID, GroupDay) VALUES (" & dsDay.Tables("tblDay").Rows(0).Item("ClassScheduleID") & ", '" & daySring & "');
                          "
                    updateData(sql)


                End If
            End If

            MsgBox("New Class added.", vbInformation + vbOKOnly, systemName)
            clear()
            classSchedule.listClassSchedule(Nothing, Nothing)
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If checkFields() = False Then
            Exit Sub
        End If

        If checkRestriction("Update") = False Then
            Exit Sub
        End If

        Dim sql As String

        If passSubjectID = 0 Then
            passSubjectID = objSchedule.getSubjectID
        End If

        sql = " 
                UPDATE ClassSchedule SET SubjectID = " & passSubjectID & ", TimeStartID = " & passTimeStartID & ", TimeEndID = " & passTimeEndID & ", RoomID = " & passRoomID & ", SectionID = " & passSectionID & ", InstructorID = " & passInstructorID & ", SemesterID = " & passSemesterID & ", AcademicYear = '" & cbAcademicYear.Text & "' WHERE ClassScheduleID = " & objSchedule.getClassScheduleID & ";
                DELETE FROM DaySchedule WHERE ClassScheduleID = " & objSchedule.getClassScheduleID & ";
              "

        If updateData(sql) = True Then

            Dim count = 0
            ReDim dayID(7)
            Dim daySring As String = Nothing

            If chbMon.Checked Then
                dayID(count) = 1
                count += 1
                daySring = daySring & "M"
            End If
            If chbTue.Checked Then
                dayID(count) = 2
                count += 1
                daySring = daySring & "T"
            End If
            If chbWed.Checked Then
                dayID(count) = 3
                count += 1
                daySring = daySring & "W"
            End If
            If chbThu.Checked Then
                dayID(count) = 4
                count += 1
                daySring = daySring & "Th"
            End If
            If chbFri.Checked Then
                dayID(count) = 5
                count += 1
                daySring = daySring & "F"
            End If
            If chbSat.Checked Then
                dayID(count) = 6
                count += 1
                daySring = daySring & "S"
            End If
            If chbSun.Checked Then
                dayID(count) = 7
                count += 1
                daySring = daySring & "Su"
            End If

            For i = 0 To count - 1
                sql = " 
                        INSERT INTO DaySchedule (ClassScheduleID, DayID) VALUES (" & objSchedule.getClassScheduleID & ", " & dayID(i) & ");
                      "
                updateData(sql)
            Next

            sql = " 
                    UPDATE GroupDaySchedule SET GroupDay = '" & daySring & "' WHERE ClassScheduleID =  " & objSchedule.getClassScheduleID & ";
                  "
            updateData(sql)

            MsgBox("Class Updated.", vbInformation + vbOKOnly, systemName)
            clear()
            classSchedule.listClassSchedule(Nothing, Nothing)
            Me.Dispose()
        End If
    End Sub

    Public Sub loadUpdateList()
        txtSubject.Text = objSchedule.getSubject

        Dim sql As String
        Dim dsDay = New DataSet

        sql = " 
                SELECT DayID FROM DaySchedule WHERE ClassScheduleID = " & objSchedule.getClassScheduleID & "
              "

        If fillData(sql, dsDay, "tblDay") = True Then
            If dsDay.Tables("tblDay").Rows.Count > 0 Then
                For i = 0 To dsDay.Tables("tblDay").Rows.Count - 1

                    If dsDay.Tables("tblDay").Rows(i).Item("DayID") = 1 Then
                        chbMon.Checked = True
                    End If
                    If dsDay.Tables("tblDay").Rows(i).Item("DayID") = 2 Then
                        chbTue.Checked = True
                    End If
                    If dsDay.Tables("tblDay").Rows(i).Item("DayID") = 3 Then
                        chbWed.Checked = True
                    End If
                    If dsDay.Tables("tblDay").Rows(i).Item("DayID") = 4 Then
                        chbThu.Checked = True
                    End If
                    If dsDay.Tables("tblDay").Rows(i).Item("DayID") = 5 Then
                        chbFri.Checked = True
                    End If
                    If dsDay.Tables("tblDay").Rows(i).Item("DayID") = 6 Then
                        chbSat.Checked = True
                    End If
                    If dsDay.Tables("tblDay").Rows(i).Item("DayID") = 7 Then
                        chbSun.Checked = True
                    End If
                Next
            End If
        End If


        'Needs to be set to a variable for it to work
        'objStudent.getGender does not work after using "genderCB = objStudent.getGender"
        Dim timeStartCB, timeEndCB, roomCB, sectionCB, instructorCB, academicYearCB, semesterCB As String
        timeStartCB = objSchedule.getTimeStart
        timeEndCB = objSchedule.getTimeEnd
        roomCB = objSchedule.getRoom
        sectionCB = objSchedule.getSection
        instructorCB = objSchedule.getName
        academicYearCB = objSchedule.getAcademicYear
        semesterCB = objSchedule.getSemester


        cbTimeStart.SelectedIndex = cbTimeStart.FindStringExact(timeStartCB)
        cbTimeEnd.SelectedIndex = cbTimeEnd.FindStringExact(timeEndCB)
        cbRoom.SelectedIndex = cbRoom.FindStringExact(roomCB)
        cbSection.SelectedIndex = cbSection.FindStringExact(sectionCB)
        cbInstructor.SelectedIndex = cbInstructor.FindStringExact(instructorCB)
        cbAcademicYear.SelectedIndex = cbAcademicYear.FindStringExact(academicYearCB)
        cbSemester.SelectedIndex = cbSemester.FindStringExact(semesterCB)
    End Sub

    Private Sub chbMon_CheckedChanged(sender As Object, e As EventArgs) Handles chbMon.CheckedChanged
        If chbMon.Checked Then
            chbTue.Checked = False
            chbThu.Checked = False
            chbSat.Checked = False
            chbSun.Checked = False
            chbTue.Enabled = False
            chbThu.Enabled = False
            chbSat.Enabled = False
            chbSun.Enabled = False
            loadTimeStart("MWF")
        Else
            chbTue.Enabled = True
            chbThu.Enabled = True
            chbSat.Enabled = True
            chbSun.Enabled = True
        End If
    End Sub

    Private Sub chbTue_CheckedChanged(sender As Object, e As EventArgs) Handles chbTue.CheckedChanged
        If chbTue.Checked Then
            chbMon.Checked = False
            chbWed.Checked = False
            chbFri.Checked = False
            chbSat.Checked = False
            chbSun.Checked = False
            chbMon.Enabled = False
            chbWed.Enabled = False
            chbFri.Enabled = False
            chbSat.Enabled = False
            chbSun.Enabled = False
            loadTimeStart("TTH")
        Else
            chbMon.Enabled = True
            chbWed.Enabled = True
            chbFri.Enabled = True
            chbSat.Enabled = True
            chbSun.Enabled = True
        End If
    End Sub

    Private Sub chbWed_CheckedChanged(sender As Object, e As EventArgs) Handles chbWed.CheckedChanged
        If chbWed.Checked Then
            chbTue.Checked = False
            chbThu.Checked = False
            chbSat.Checked = False
            chbSun.Checked = False
            chbTue.Enabled = False
            chbThu.Enabled = False
            chbSat.Enabled = False
            chbSun.Enabled = False
            loadTimeStart("MWF")
        Else
            chbTue.Enabled = True
            chbThu.Enabled = True
            chbSat.Enabled = True
            chbSun.Enabled = True
        End If
    End Sub

    Private Sub chbThu_CheckedChanged(sender As Object, e As EventArgs) Handles chbThu.CheckedChanged
        If chbThu.Checked Then
            chbMon.Checked = False
            chbWed.Checked = False
            chbFri.Checked = False
            chbSat.Checked = False
            chbSun.Checked = False
            chbMon.Enabled = False
            chbWed.Enabled = False
            chbFri.Enabled = False
            chbSat.Enabled = False
            chbSun.Enabled = False
            loadTimeStart("TTH")
        Else
            chbMon.Enabled = True
            chbWed.Enabled = True
            chbFri.Enabled = True
            chbSat.Enabled = True
            chbSun.Enabled = True
        End If
    End Sub

    Private Sub chbFri_CheckedChanged(sender As Object, e As EventArgs) Handles chbFri.CheckedChanged
        If chbFri.Checked Then
            chbTue.Checked = False
            chbThu.Checked = False
            chbSat.Checked = False
            chbSun.Checked = False
            chbTue.Enabled = False
            chbThu.Enabled = False
            chbSat.Enabled = False
            chbSun.Enabled = False
            loadTimeStart("MWF")
        Else
            chbTue.Enabled = True
            chbThu.Enabled = True
            chbSat.Enabled = True
            chbSun.Enabled = True
        End If
    End Sub

    Private Sub chbSat_CheckedChanged(sender As Object, e As EventArgs) Handles chbSat.CheckedChanged
        If chbSat.Checked Then
            chbMon.Checked = False
            chbWed.Checked = False
            chbFri.Checked = False
            chbTue.Checked = False
            chbThu.Checked = False
            chbMon.Enabled = False
            chbWed.Enabled = False
            chbFri.Enabled = False
            chbTue.Enabled = False
            chbThu.Enabled = False
            loadTimeStart("MWF")
        Else
            chbMon.Enabled = True
            chbWed.Enabled = True
            chbFri.Enabled = True
            chbTue.Enabled = True
            chbThu.Enabled = True
        End If
    End Sub

    Private Sub chbSun_CheckedChanged(sender As Object, e As EventArgs) Handles chbSun.CheckedChanged
        If chbSun.Checked Then
            chbMon.Checked = False
            chbWed.Checked = False
            chbFri.Checked = False
            chbTue.Checked = False
            chbThu.Checked = False
            chbMon.Enabled = False
            chbWed.Enabled = False
            chbFri.Enabled = False
            chbTue.Enabled = False
            chbThu.Enabled = False
            loadTimeStart("MWF")
        Else
            chbMon.Enabled = True
            chbWed.Enabled = True
            chbFri.Enabled = True
            chbTue.Enabled = True
            chbThu.Enabled = True
        End If
    End Sub


    Private Function checkFields()
        If txtSubject.Text = "" Then
            MsgBox("Please select a Subject.", vbInformation + vbOKOnly, systemName)
            txtSubject.Focus()
            Return False
        End If

        If chbMon.Checked.Equals(False) And chbTue.Checked.Equals(False) And chbWed.Checked.Equals(False) And chbThu.Checked.Equals(False) And chbFri.Checked.Equals(False) And chbSat.Checked.Equals(False) And chbSun.Checked.Equals(False) Then
            MsgBox("Please select a Day.", vbInformation + vbOKOnly, systemName)
            chbMon.Focus()
            Return False
        End If

        If cbTimeStart.Text = "" Then
            MsgBox("Please select a Time.", vbInformation + vbOKOnly, systemName)
            cbTimeStart.Focus()
            Return False
        End If

        If cbTimeEnd.Text = "" Then
            MsgBox("Please select a Time.", vbInformation + vbOKOnly, systemName)
            cbTimeEnd.Focus()
            Return False
        End If

        If cbRoom.Text = "" Then
            MsgBox("Please select a Room.", vbInformation + vbOKOnly, systemName)
            cbRoom.Focus()
            Return False
        End If

        If cbSection.Text = "" Then
            MsgBox("Please select a Section.", vbInformation + vbOKOnly, systemName)
            cbSection.Focus()
            Return False
        End If

        If cbInstructor.Text = "" Then
            MsgBox("Please select an Instructor.", vbInformation + vbOKOnly, systemName)
            cbInstructor.Focus()
            Return False
        End If

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

    Private Function checkRestriction(ByVal action As String)
        Dim sql As String

        Dim dsClass = New DataSet
        Dim dsTime = New DataSet
        Dim dsDay = New DataSet

        sql = "SELECT ClassScheduleID, SemesterID, AcademicYear FROM ClassScheduleView WHERE Subject = '" & txtSubject.Text & "' AND Section = '" & cbSection.Text & "' AND IsDeleted = 'False' "

        If action = "Update" Then
            sql = sql & "AND ClassScheduleID != " & objSchedule.getClassScheduleID
        End If

        If fillData(sql, dsClass, "tblClass") = True Then
            If dsClass.Tables("tblClass").Rows.Count > 0 Then
                For i = 0 To dsClass.Tables("tblClass").Rows.Count - 1
                    If dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                        MsgBox("Duplicate section! Please select another section.", vbInformation + vbOKOnly, systemName)
                        cbSection.Items.Clear()
                        loadSection()
                        Return False
                    End If
                Next
            End If
        End If

        sql = "SELECT ClassScheduleID, TimeStartID, TimeEndID, SemesterID, AcademicYear FROM ClassScheduleView WHERE Room = '" & cbRoom.Text & "' AND IsDeleted = 'False' "

        If action = "Update" Then
            sql = sql & "AND ClassScheduleID != " & objSchedule.getClassScheduleID
        End If

        If fillData(sql, dsClass, "tblClass") = True Then
            If dsClass.Tables("tblClass").Rows.Count > 0 Then
                Dim i As Integer

                For i = 0 To dsClass.Tables("tblClass").Rows.Count - 1
                    sql = "SELECT TimeID FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeStartID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeStart As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeID")

                    sql = "SELECT TimeID FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeEndID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeEnd As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeID")

                    sql = "SELECT Day FROM DayScheduleView WHERE ClassScheduleID = " & dsClass.Tables("tblClass").Rows(i).Item("ClassScheduleID").ToString
                    fillData(sql, dsDay, "tblDay")

                    Dim day = ""
                    For x = 0 To dsDay.Tables("tblDay").Rows.Count - 1
                        day = dsDay.Tables("tblDay").Rows(x).Item("Day")

                        If day = "M" And chbMon.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Room is already in use at this time. Please select other room or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbRoom.Items.Clear()
                            loadRoom()
                            Return False
                        End If

                        If day = "T" And chbTue.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Room is already in use at this time. Please select other room or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbRoom.Items.Clear()
                            loadRoom()
                            Return False
                        End If

                        If day = "W" And chbWed.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Room is already in use at this time. Please select other room or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbRoom.Items.Clear()
                            loadRoom()
                            Return False
                        End If

                        If day = "Th" And chbThu.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Room is already in use at this time. Please select other room or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbRoom.Items.Clear()
                            loadRoom()
                            Return False
                        End If

                        If day = "F" And chbFri.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Room is already in use at this time. Please select other room or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbRoom.Items.Clear()
                            loadRoom()
                            Return False
                        End If

                        If day = "S" And chbSat.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Room is already in use at this time. Please select other room or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbRoom.Items.Clear()
                            loadRoom()
                            Return False
                        End If

                        If day = "Su" And chbSun.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Room is already in use at this time. Please select other room or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbRoom.Items.Clear()
                            loadRoom()
                            Return False
                        End If
                    Next
                Next
            End If
        End If

        sql = "SELECT ClassScheduleID, TimeStartID, TimeEndID, SemesterID, AcademicYear FROM ClassScheduleView WHERE InstructorID = '" & passInstructorID & "' AND IsDeleted = 'False' "

        If action = "Update" Then
            sql = sql & "AND ClassScheduleID != " & objSchedule.getClassScheduleID
        End If

        If fillData(sql, dsClass, "tblClass") = True Then
            If dsClass.Tables("tblClass").Rows.Count > 0 Then
                Dim i As Integer
                Dim timeCount As Double = 0

                If passTimeStartSection = 1 And passTimeEndSection = 1 And (passTimeEndID - passTimeStartID = 2) Then
                    timeCount = timeCount + 1
                ElseIf (passTimeStartSection = 3 And passTimeEndSection = 2) Or (passTimeStartSection = 2 And passTimeEndSection = 3) Then
                    timeCount = timeCount + 1.5
                ElseIf (passTimeStartSection = 3 Or passTimeEndSection = 3) Or (passTimeStartSection = 2 Or passTimeEndSection = 2) Or (passTimeStartSection = 1 Or passTimeEndSection = 1) Then
                    timeCount = timeCount + 3
                ElseIf passTimeStartSection = 2 Or passTimeEndSection = 2 Then
                    timeCount = timeCount + 3
                Else
                    timeCount = timeCount + 1
                End If

                For i = 0 To dsClass.Tables("tblClass").Rows.Count - 1
                    sql = "SELECT TimeID, TimeSection FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeStartID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeStart As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeID")
                    Dim timeStartSection As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeSection")

                    sql = "SELECT TimeID, TimeSection FROM Time WHERE TimeID = " & dsClass.Tables("tblClass").Rows(i).Item("TimeEndID").ToString
                    fillData(sql, dsTime, "tblTime")

                    Dim timeEnd As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeID")
                    Dim timeEndSection As Integer = dsTime.Tables("tblTime").Rows(0).Item("TimeSection")

                    sql = "SELECT Day FROM DayScheduleView WHERE ClassScheduleID = " & dsClass.Tables("tblClass").Rows(i).Item("ClassScheduleID").ToString
                    fillData(sql, dsDay, "tblDay")

                    Dim timeDifference As Integer = timeEnd - timeStart

                    If timeStartSection = 1 And timeEndSection = 1 And (timeEnd - timeStart = 2) Then
                        timeCount = timeCount + 1
                    ElseIf (timeStartSection = 3 And timeEndSection = 2) Or (timeStartSection = 2 And timeEndSection = 3) Then
                        timeCount = timeCount + 1.5
                    ElseIf (timeStartSection = 3 Or timeEndSection = 3) Or (timeStartSection = 2 Or timeEndSection = 2) Or (timeStartSection = 1 Or timeEndSection = 1) Then
                        timeCount = timeCount + 3
                    ElseIf timeStartSection = 2 Or timeEndSection = 2 Then
                        timeCount = timeCount + 3
                    Else
                        timeCount = timeCount + 1
                    End If

                    Dim day = ""
                    For x = 0 To dsDay.Tables("tblDay").Rows.Count - 1
                        day = dsDay.Tables("tblDay").Rows(x).Item("Day")

                        If day = "M" And chbMon.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor is occupied at this time. Please select other Instructor or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "M" And chbMon.Checked And (timeDifference = 4 And passTimeStartID = timeEnd) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have 3 hours of class straight. Please select other time to resume.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "M" And chbMon.Checked And timeCount > 6 And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have not more than 6 hours a day. Please select other Instructor.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "T" And chbTue.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor is occupied at this time. Please select other Instructor or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "T" And chbMon.Checked And (timeDifference = 4 And passTimeStartID = timeEnd) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have 3 hours of class straight. Please select other time to resume.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "T" And chbMon.Checked And timeCount > 6 And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have not more than 6 hours a day. Please select other Instructor.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "W" And chbWed.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor is occupied at this time. Please select other Instructor or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "W" And chbMon.Checked And (timeDifference = 4 And passTimeStartID = timeEnd) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have 3 hours of class straight. Please select other time to resume.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "W" And chbMon.Checked And timeCount > 6 And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have not more than 6 hours a day. Please select other Instructor.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "Th" And chbThu.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor is occupied at this time. Please select other Instructor or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "Th" And chbMon.Checked And (timeDifference = 4 And passTimeStartID = timeEnd) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have 3 hours of class straight. Please select other time to resume.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "Th" And chbMon.Checked And timeCount > 6 And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have not more than 6 hours a day. Please select other Instructor.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "F" And chbFri.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor is occupied at this time. Please select other Instructor or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "F" And chbMon.Checked And (timeDifference = 4 And passTimeStartID = timeEnd) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have 3 hours of class straight. Please select other time to resume.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "F" And chbMon.Checked And timeCount > 6 And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have not more than 6 hours a day. Please select other Instructor.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "S" And chbSat.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor is occupied at this time. Please select other Instructor or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "S" And chbMon.Checked And (timeDifference = 4 And passTimeStartID = timeEnd) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have 3 hours of class straight. Please select other time to resume.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "S" And chbMon.Checked And timeCount > 6 And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have not more than 6 hours a day. Please select other Instructor.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "Su" And chbSun.Checked And ((passTimeStartID >= timeStart And passTimeStartID < timeEnd) Or (passTimeEndID > timeStart And passTimeEndID <= timeEnd)) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor is occupied at this time. Please select other Instructor or change the time.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "Su" And chbMon.Checked And (timeDifference = 4 And passTimeStartID = timeEnd) And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have 3 hours of class straight. Please select other time to resume.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If

                        If day = "Su" And chbMon.Checked And timeCount > 6 And dsClass.Tables("tblClass").Rows(i).Item("SemesterID") = passSemesterID And dsClass.Tables("tblClass").Rows(i).Item("AcademicYear").ToString = academicYear Then
                            MsgBox("Instructor can only have not more than 6 hours a day. Please select other Instructor.", vbInformation + vbOKOnly, systemName)
                            cbTimeStart.Items.Clear()
                            cbTimeEnd.Items.Clear()
                            cbInstructor.Items.Clear()
                            loadInstructor()
                            Return False
                        End If
                    Next
                Next
            End If
        End If

        Return True
    End Function

    Private Sub clear()
        txtSubject.Text = ""

        chbMon.Checked = False
        chbTue.Checked = False
        chbWed.Checked = False
        chbThu.Checked = False
        chbFri.Checked = False
        chbSat.Checked = False
        chbSun.Checked = False

        cbTimeStart.Items.Clear()
        cbTimeEnd.Items.Clear()
        cbRoom.Items.Clear()
        cbSection.Items.Clear()
        cbInstructor.Items.Clear()
        cbAcademicYear.Items.Clear()
        cbSemester.Items.Clear()

        loadRoom()
        loadSection()
        loadInstructor()
        loadAcademicYear()
        loadSemester()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        listSubject(txtSearch.Text)
    End Sub
End Class