Public Class userAccount
    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        checkFields()

        Dim sql As String

        sql = " 
                UPDATE UserAccount SET Username = '" & txtUsername.Text & "', Password = '" & txtPassword.Text & "' WHERE UserTypeID = " & objUser.getUserTypeID & " ;
              "

        If updateData(sql) = True Then
            MsgBox("Username and Password has been Updated.", vbInformation + vbOKOnly, systemName)
            Me.Dispose()
        End If
    End Sub

    Private Sub checkFields()
        If txtUsername.Text = "" Then
            MsgBox("Please enter a new username.", vbInformation + vbOKOnly, systemName)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MsgBox("Please a new password.", vbInformation + vbOKOnly, systemName)
            txtPassword.Focus()
            Exit Sub
        End If
    End Sub
End Class