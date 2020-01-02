Public Class settings

    Private semesterID() As Integer

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAcademicYear()
        loadSemester()
        loadUpdateList()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        checkFields()

        Dim sql As String

        sql = " 
                UPDATE CurrentYearSem SET CurrentYear = '" & cbAcademicYear.Text & "', CurrentSemester = '" & cbSemester.Text & "';
              "

        If updateData(sql) = True Then
            objCurrent.getYear = cbAcademicYear.Text
            objCurrent.getSemester = cbSemester.Text
            MsgBox("Current Academic Year and Semester Updated.", vbInformation + vbOKOnly, systemName)
            Me.Dispose()
        End If
    End Sub

    Private Sub checkFields()
        If cbAcademicYear.Text = "" Then
            MsgBox("Please select an Academic Year.", vbInformation + vbOKOnly, systemName)
            cbAcademicYear.Focus()
            Exit Sub
        End If

        If cbSemester.Text = "" Then
            MsgBox("Please select a Semester.", vbInformation + vbOKOnly, systemName)
            cbSemester.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()
    End Sub

    Public Sub loadUpdateList()
        Dim yearCB, semesterCB As String
        yearCB = objCurrent.getYear
        semesterCB = objCurrent.getSemester

        cbAcademicYear.SelectedIndex = cbAcademicYear.FindStringExact(yearCB)
        cbSemester.SelectedIndex = cbSemester.FindStringExact(semesterCB)
    End Sub
End Class