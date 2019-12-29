Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms


Public Class teachingLoad

    Private classID() As Integer

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        listClassSchedule()
    End Sub

    Public Sub listClassSchedule()
        lvClass.Items.Clear()

        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String
        Dim dsClass = New DataSet
        Dim dsDay = New DataSet
        Dim dsTime = New DataSet

        Dim idNumber = txtIDNumber.Text & "-" & txtIDNumber2.Text & "-" & txtIDNumber3.Text

        sql = "SELECT * FROM ClassScheduleView WHERE InstructorIDNumber = '" & idNumber & "' AND IsDeleted = 'False' "

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
            Else
                MsgBox("No result found.", vbInformation + vbOKOnly, systemName)
            End If
        End If
    End Sub

    Private Sub btnAddClass_Click(sender As Object, e As EventArgs) Handles btnPrintMasterList.Click
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

            sql = "SELECT Day FROM DayScheduleView WHERE ClassScheduleID = " & dsClass.Tables("tblClass").Rows(0).Item("ClassScheduleID").ToString
            fillData(sql, dsDay, "tblDay")

            Dim day = ""
            For x = 0 To dsDay.Tables("tblDay").Rows.Count - 1
                day = day & dsDay.Tables("tblDay").Rows(x).Item("Day")
            Next

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

            Dim name = dsClass.Tables("tblClass").Rows(0).Item("Surname") & ", " & dsClass.Tables("tblClass").Rows(0).Item("FirstName") & " " & dsClass.Tables("tblClass").Rows(0).Item("ExtensionName") & " " & dsClass.Tables("tblClass").Rows(0).Item("MiddleInitial")
            objSchedule.getInstructorID = dsClass.Tables("tblClass").Rows(0).Item("InstructorID")
            objSchedule.getName = name

            objSchedule.getsemesterID = dsClass.Tables("tblClass").Rows(0).Item("SemesterID")
            objSchedule.getSemester = dsClass.Tables("tblClass").Rows(0).Item("Semester")
            objSchedule.getAcademicYear = dsClass.Tables("tblClass").Rows(0).Item("AcademicYear")

            Dim schedule = objSchedule.getTimeStart & " - " & objSchedule.getTimeEnd & " " & day


            Dim Department As New ReportParameter("Department", StrConv(objUser.getUserType, VbStrConv.ProperCase))
            Dim Name1 As New ReportParameter("Name", StrConv(name, VbStrConv.ProperCase))
            Dim Subject As New ReportParameter("Subject", StrConv(objSchedule.getSubject, VbStrConv.ProperCase))
            Dim Description As New ReportParameter("Description", StrConv(dsClass.Tables("tblClass").Rows(0).Item("SubjectDescription"), VbStrConv.ProperCase))
            Dim Schedule1 As New ReportParameter("Schedule", schedule)
            Dim LecUnits As New ReportParameter("LecUnits", StrConv(dsClass.Tables("tblClass").Rows(0).Item("LectureUnit"), VbStrConv.ProperCase))
            Dim LabUnits As New ReportParameter("LabUnits", StrConv(dsClass.Tables("tblClass").Rows(0).Item("LabUnit"), VbStrConv.ProperCase))
            Dim Room As New ReportParameter("Room", StrConv(objSchedule.getRoom, VbStrConv.ProperCase))

            masterList.rvMasterList.LocalReport.SetParameters(Department)
            masterList.rvMasterList.LocalReport.SetParameters(Name1)
            masterList.rvMasterList.LocalReport.SetParameters(Subject)
            masterList.rvMasterList.LocalReport.SetParameters(Description)
            masterList.rvMasterList.LocalReport.SetParameters(Schedule1)
            masterList.rvMasterList.LocalReport.SetParameters(LecUnits)
            masterList.rvMasterList.LocalReport.SetParameters(LabUnits)
            masterList.rvMasterList.LocalReport.SetParameters(Room)

            masterList.ClassRegistrationViewTableAdapter.Fill(masterList.masterListDataSet.ClassRegistrationView, objSchedule.getClassScheduleID)
            masterList.rvMasterList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            masterList.rvMasterList.RefreshReport()
            masterList.ShowDialog()

        End If

        '------------------------------------------------------------------------------------------

    End Sub

    Private Function checkFields()
        If txtIDNumber.Text = "" Then
            MsgBox("Please your ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber.Focus()
            Return False
        End If

        If txtIDNumber2.Text = "" Then
            MsgBox("Please your ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber2.Focus()
            Return False
        End If

        If txtIDNumber3.Text = "" Then
            MsgBox("Please your ID Number.", vbInformation + vbOKOnly, systemName)
            txtIDNumber3.Focus()
            Return False
        End If

        Return True

    End Function
End Class