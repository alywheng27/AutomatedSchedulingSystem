Public Class subject

    Private subjectID() As Integer

    Private Sub subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listSubject(Nothing)
    End Sub

    Public Sub listSubject(ByVal search As String)
        lvSubject.Items.Clear()

        Dim sql As String
        Dim dsSubject = New DataSet

        If search = Nothing Then
            sql = "SELECT * FROM SubjectView WHERE Department = '" & objUser.getUserType & "' AND IsDeleted = 'False' ORDER BY Subject ASC "
        Else
            sql = "SELECT * FROM SubjectView WHERE Department = '" & objUser.getUserType & "' AND (Subject LIKE '%" & search & "%' OR SubjectDescription LIKE '%" & search & "%') AND IsDeleted = 'False' ORDER BY Subject ASC "
        End If

        If fillData(sql, dsSubject, "tblSubject") = True Then
            If dsSubject.Tables("tblSubject").Rows.Count > 0 Then
                ReDim subjectID(dsSubject.Tables("tblSubject").Rows.Count - 1)
                Dim i As Integer
                Dim xItem As ListViewItem

                For i = 0 To dsSubject.Tables("tblSubject").Rows.Count - 1
                    xItem = lvSubject.Items.Add(dsSubject.Tables("tblSubject").Rows(i).Item("Subject"))
                    xItem.SubItems.Add(dsSubject.Tables("tblSubject").Rows(i).Item("SubjectDescription"))
                    xItem.SubItems.Add(dsSubject.Tables("tblSubject").Rows(i).Item("Unit"))
                    xItem.SubItems.Add(dsSubject.Tables("tblSubject").Rows(i).Item("LectureUnit"))
                    xItem.SubItems.Add(dsSubject.Tables("tblSubject").Rows(i).Item("LabUnit"))

                    subjectID(i) = dsSubject.Tables("tblSubject").Rows(i).Item("SubjectID")
                Next
                btnUpdateSubject.Enabled = True
                btnDeleteSubject.Enabled = True
            Else
                btnUpdateSubject.Enabled = False
                btnDeleteSubject.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        subjectAU.studentAction.Text = "Subject Information / Add"
        subjectAU.btnUpdate.Enabled = False
        subjectAU.btnUpdate.Hide()
        subjectAU.btnSubmit.Enabled = True
        subjectAU.btnSubmit.Show()
        objSubject = New SubjectClass(-1)
        subjectAU.ShowDialog()
    End Sub

    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click
        If lvSubject.SelectedIndices.Count = 0 Then Exit Sub

        Dim sql As String
        Dim dsSubject = New DataSet

        sql = "SELECT * FROM SubjectView WHERE SubjectID = " & subjectID(lvSubject.SelectedIndices(0))

        If fillData(sql, dsSubject, "tblSubject") = True Then
            objSubject = New SubjectClass(subjectID(lvSubject.SelectedIndices(0)))
            objSubject.getSubjectID = dsSubject.Tables("tblSubject").Rows(0).Item("SubjectID")
            objSubject.getSubject = dsSubject.Tables("tblSubject").Rows(0).Item("Subject")
            objSubject.getDescription = dsSubject.Tables("tblSubject").Rows(0).Item("SubjectDescription")
            objSubject.getUnit = dsSubject.Tables("tblSubject").Rows(0).Item("Unit")
            objSubject.getLecUnit = dsSubject.Tables("tblSubject").Rows(0).Item("LectureUnit")
            objSubject.getLabUnit = dsSubject.Tables("tblSubject").Rows(0).Item("LabUnit")
            objSubject.getDepartment = dsSubject.Tables("tblSubject").Rows(0).Item("Department")

            subjectAU.studentAction.Text = "Subject Information / Update"
            subjectAU.btnSubmit.Enabled = False
            subjectAU.btnSubmit.Hide()
            subjectAU.btnUpdate.Enabled = True
            subjectAU.btnUpdate.Show()

            subjectAU.subjectID = objSubject.getSubjectID

            subjectAU.ShowDialog()
        End If
    End Sub

    Private Sub btnDeleteSubject_Click(sender As Object, e As EventArgs) Handles btnDeleteSubject.Click
        If lvSubject.SelectedIndices.Count = 0 Then Exit Sub

        If MsgBox("Are you sure that you want to delete this subject?", vbQuestion + vbYesNo, systemName) = vbNo Then Exit Sub

        Dim sql As String
        sql = "UPDATE Subject SET IsDeleted = 'True' WHERE SubjectID = " & subjectID(lvSubject.SelectedIndices(0))

        If updateData(sql) = True Then
            listSubject(Nothing)
            MsgBox("Subject has been deleted.", vbInformation + vbOKOnly, systemName)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        listSubject(txtSearch.Text)
    End Sub
End Class