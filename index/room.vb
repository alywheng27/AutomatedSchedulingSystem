Public Class room

    Private roomID() As Integer

    Private Sub room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listRoom(Nothing)
    End Sub

    Public Sub listRoom(ByVal search As String)
        lvRoom.Items.Clear()

        Dim sql As String
        Dim dsRoom = New DataSet

        If search = Nothing Then
            sql = "SELECT * FROM RoomView WHERE Department = '" & objUser.getUserType & "' AND IsDeleted = 'False' "
        Else
            sql = "SELECT * FROM RoomView WHERE Department = '" & objUser.getUserType & "' AND (Room LIKE '%" & search & "%') AND IsDeleted = 'False' "
        End If

        If fillData(sql, dsRoom, "tblRoom") = True Then
            If dsRoom.Tables("tblRoom").Rows.Count > 0 Then
                ReDim roomID(dsRoom.Tables("tblRoom").Rows.Count - 1)
                Dim i As Integer
                Dim xItem As ListViewItem

                For i = 0 To dsRoom.Tables("tblRoom").Rows.Count - 1
                    xItem = lvRoom.Items.Add(dsRoom.Tables("tblRoom").Rows(i).Item("Room"))
                    xItem.SubItems.Add(dsRoom.Tables("tblRoom").Rows(i).Item("Department"))

                    roomID(i) = dsRoom.Tables("tblRoom").Rows(i).Item("RoomID")
                Next
                btnUpdateRoom.Enabled = True
                btnDeleteRoom.Enabled = True
            Else
                btnUpdateRoom.Enabled = False
                btnDeleteRoom.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        roomAU.studentAction.Text = "Room Information / Add"
        roomAU.btnUpdate.Enabled = False
        roomAU.btnUpdate.Hide()
        roomAU.btnSubmit.Enabled = True
        roomAU.btnSubmit.Show()
        objRoom = New RoomClass(-1)
        roomAU.ShowDialog()
    End Sub

    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click
        If lvRoom.SelectedIndices.Count = 0 Then Exit Sub

        If MsgBox("Are you sure that you want to delete this room?", vbQuestion + vbYesNo, systemName) = vbNo Then Exit Sub

        Dim sql As String
        sql = "UPDATE Room SET IsDeleted = 'True' WHERE RoomID = " & roomID(lvRoom.SelectedIndices(0))

        If updateData(sql) = True Then
            listRoom(Nothing)
            MsgBox("Room has been deleted.", vbInformation + vbOKOnly, systemName)
        End If
    End Sub

    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        If lvRoom.SelectedIndices.Count = 0 Then Exit Sub

        Dim sql As String
        Dim dsRoom = New DataSet

        sql = "SELECT * FROM RoomView WHERE RoomID = " & roomID(lvRoom.SelectedIndices(0))

        If fillData(sql, dsRoom, "tblRoom") = True Then
            objRoom = New RoomClass(roomID(lvRoom.SelectedIndices(0)))
            objRoom.getRoomID = dsRoom.Tables("tblRoom").Rows(0).Item("RoomID")
            objRoom.getRoom = dsRoom.Tables("tblRoom").Rows(0).Item("Room")
            objRoom.getDepartment = dsRoom.Tables("tblRoom").Rows(0).Item("Department")

            roomAU.studentAction.Text = "Room Information / Update"
            roomAU.btnSubmit.Enabled = False
            roomAU.btnSubmit.Hide()
            roomAU.btnUpdate.Enabled = True
            roomAU.btnUpdate.Show()

            roomAU.roomID = objRoom.getRoomID

            roomAU.ShowDialog()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        listRoom(txtSearch.Text)
    End Sub
End Class