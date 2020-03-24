Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class subjectAU

    Public subjectID As String

    Private departmentID() As Integer

    Private department As Integer

    Private Sub subjectAU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDepartment()
        loadUpdateList()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String
        Dim dsSubject = New DataSet

        txtDescripion.Text = StrConv(txtDescripion.Text, VbStrConv.ProperCase)

        sql = "SELECT SubjectID FROM Subject WHERE Subject = '" & txtSubject.Text & "' AND SubjectDescription = '" & txtDescripion.Text & "' AND DepartmentID = '" & department & "' AND IsDeleted = 'False' "

        If fillData(sql, dsSubject, "tblSubject") = True Then
            If dsSubject.Tables("tblSubject").Rows.Count > 0 Then
                MsgBox("Subject already exist.", vbInformation + vbOKOnly, systemName)
                txtSubject.Text = ""
                Exit Sub
            End If
        End If

        'sql = "SELECT SubjectID FROM Subject WHERE SubjectDescription = '" & txtDescripion.Text & "' AND IsDeleted = 'False' "

        'If fillData(sql, dsSubject, "tblSubject") = True Then
        '    If dsSubject.Tables("tblSubject").Rows.Count > 0 Then
        '        MsgBox("Description already exist.", vbInformation + vbOKOnly, systemName)
        '        txtDescripion.Text = ""
        '        Exit Sub
        '    End If
        'End If

        CN = New SqlConnection("Data Source=DESKTOP-C4499M6;Initial Catalog=trac-ass;User Id=cyberaly27;Password=teleport300L!;")

        sql = " 
                INSERT INTO Subject (Subject, SubjectDescription, Unit, LectureUnit, LabUnit, DepartmentID) VALUES (@subject, @description, @unit, @lecUnit, @labUnit, @department);
              "
        Try
            CN.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(sql, CN)
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@description", txtDescripion.Text)
            cmd.Parameters.AddWithValue("@unit", txtUnit.Text)
            cmd.Parameters.AddWithValue("@lecUnit", txtLecUnit.Text)
            cmd.Parameters.AddWithValue("@labUnit", txtLabUnit.Text)
            cmd.Parameters.AddWithValue("@department", department)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            CN.Close()

            MsgBox("New Subject added.", vbInformation + vbOKOnly, systemName)
            clear()
            subject.listSubject(Nothing)

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.ToString, vbExclamation + vbOKOnly, systemName)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If checkFields() = False Then
            Exit Sub
        End If

        Dim sql As String

        CN = New SqlConnection("Data Source=DESKTOP-C4499M6;Initial Catalog=trac-ass;User Id=cyberaly27;Password=teleport300L!;")

        sql = " 
                UPDATE Subject SET Subject = @subject, SubjectDescription = @description, Unit = @unit, LectureUnit = @lecUnit, LabUnit = @labUnit, DepartmentID = @department WHERE SubjectID = " & subjectID & " ;
              "

        Try
            CN.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(sql, CN)
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@description", txtDescripion.Text)
            cmd.Parameters.AddWithValue("@unit", txtUnit.Text)
            cmd.Parameters.AddWithValue("@lecUnit", txtLecUnit.Text)
            cmd.Parameters.AddWithValue("@labUnit", txtLabUnit.Text)
            cmd.Parameters.AddWithValue("@department", department)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            CN.Close()

            MsgBox("Subject Updated.", vbInformation + vbOKOnly, systemName)
            clear()
            subject.listSubject(Nothing)
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.ToString, vbExclamation + vbOKOnly, systemName)
        End Try
    End Sub

    Private Function checkFields()
        If txtSubject.Text = "" Then
            MsgBox("Please enter a Subject.", vbInformation + vbOKOnly, systemName)
            txtSubject.Focus()
            Return False
        End If

        If txtDescripion.Text = "" Then
            MsgBox("Please enter a Description.", vbInformation + vbOKOnly, systemName)
            txtDescripion.Focus()
            Return False
        End If

        If txtUnit.Text = "" Then
            MsgBox("Please enter a Unit.", vbInformation + vbOKOnly, systemName)
            txtUnit.Focus()
            Return False
        End If

        If txtLecUnit.Text = "" Then
            MsgBox("Please enter a LecUnit.", vbInformation + vbOKOnly, systemName)
            txtLecUnit.Focus()
            Return False
        End If

        If txtLabUnit.Text = "" Then
            MsgBox("Please enter a LabUnit.", vbInformation + vbOKOnly, systemName)
            txtLabUnit.Focus()
            Return False
        End If

        If cbDepartment.Text = "" Then
            MsgBox("Please select a Department.", vbInformation + vbOKOnly, systemName)
            cbDepartment.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub clear()
        txtSubject.Text = ""
        txtDescripion.Text = ""
        txtUnit.Text = ""
        txtLecUnit.Text = ""
        txtLabUnit.Text = ""

        cbDepartment.Items.Clear()
        loadDepartment()
    End Sub

    Public Sub loadUpdateList()
        txtSubject.Text = objSubject.getSubject
        txtDescripion.Text = objSubject.getDescription
        txtUnit.Text = objSubject.getUnit
        txtLecUnit.Text = objSubject.getLecUnit
        txtLabUnit.Text = objSubject.getLabUnit
        cbDepartment.Text = objSubject.getDepartment
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        objSubject = New SubjectClass(departmentID(cbDepartment.SelectedIndex))
        department = objSubject.getDepartmentID
    End Sub

End Class
