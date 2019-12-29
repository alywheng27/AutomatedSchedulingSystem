Public Class index
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        login()
    End Sub

    Private Sub login()
        If username.Text = "" Then
            MsgBox("Please enter your username.", vbInformation + vbOKOnly, systemName)
            username.Focus()
            Exit Sub
        End If

        If password.Text = "" Then
            MsgBox("Please enter your password.", vbInformation + vbOKOnly, systemName)
            password.Focus()
            Exit Sub
        End If

        Dim sql As String
        Dim dsUser = New DataSet

        sql = "SELECT * FROM UserView WHERE Username = '" & username.Text & "'"

        If fillData(sql, dsUser, "tblUser") = True Then
            If dsUser.Tables("tblUser").Rows.Count > 0 Then
                If dsUser.Tables("tblUser").Rows(0).Item("Password") = password.Text Then
                    objUser = New UserClass(dsUser.Tables("tblUser").Rows(0).Item("UserID"))
                    objUser.getUsername = dsUser.Tables("tblUser").Rows(0).Item("Username")
                    objUser.getUserType = dsUser.Tables("tblUser").Rows(0).Item("UserType")
                    main.Show()

                    Me.Dispose()
                Else
                    MsgBox("Username or password is incorrect.", vbInformation + vbOKOnly, systemName)
                    password.Text = ""
                    password.SelectAll()
                    password.Focus()
                End If
            Else
                MsgBox("Username or password is incorrect.", vbInformation + vbOKOnly, systemName)
                password.Text = ""
                username.SelectAll()
                username.Focus()
            End If
        End If

        dsUser.Dispose()
    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            login()
        End If
    End Sub

End Class
