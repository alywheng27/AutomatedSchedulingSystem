Public Class roomAU

    Private departmentID() As Integer

    Private department As Integer

    Public roomID As Integer

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

    Private Sub roomAU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDepartment()
        loadUpdateList()
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
        checkFields()

        Dim sql As String
        Dim dsRoom = New DataSet

        sql = "SELECT RoomID FROM Room WHERE Room = '" & txtRoom.Text & "' AND IsDeleted = 'False' "

        If fillData(sql, dsRoom, "tblStudent") = True Then
            If dsRoom.Tables("tblStudent").Rows.Count > 0 Then
                MsgBox("Room already exist.", vbInformation + vbOKOnly, systemName)
                txtRoom.Text = ""
                Exit Sub
            End If
        End If

        txtRoom.Text = StrConv(txtRoom.Text, VbStrConv.ProperCase)

        sql = " 
                INSERT INTO Room (Room, DepartmentID) VALUES ('" & txtRoom.Text & "', " & department & ");
              "

        If updateData(sql) = True Then
            MsgBox("New Room added.", vbInformation + vbOKOnly, systemName)
            clear()
            room.listRoom(Nothing)
        End If
    End Sub

    Private Sub checkFields()
        If txtRoom.Text = "" Then
            MsgBox("Please enter Room.", vbInformation + vbOKOnly, systemName)
            txtRoom.Focus()
            Exit Sub
        End If

        If cbDepartment.Text = "" Then
            MsgBox("Please select Department.", vbInformation + vbOKOnly, systemName)
            cbDepartment.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub clear()
        txtRoom.Text = ""
        cbDepartment.Items.Clear()

        loadDepartment()
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        objRoom = New RoomClass(departmentID(cbDepartment.SelectedIndex))
        department = objRoom.getDepartmentID
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        checkFields()

        Dim sql As String

        sql = " 
                UPDATE Room SET Room = '" & txtRoom.Text & "', DepartmentID = " & department & " WHERE RoomID = " & roomID & " ;
              "

        If updateData(sql) = True Then
            MsgBox("Room Updated.", vbInformation + vbOKOnly, systemName)
            clear()
            room.listRoom(Nothing)
            Me.Dispose()
        End If
    End Sub

    Public Sub loadUpdateList()
        txtRoom.Text = objRoom.getRoom

        Dim departmentCB As String
        departmentCB = objRoom.getDepartment

        cbDepartment.SelectedIndex = cbDepartment.FindStringExact(departmentCB)

    End Sub
End Class