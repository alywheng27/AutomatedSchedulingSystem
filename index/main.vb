
Public Class btnUser

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        index.Show()
        Me.Dispose()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        If makeFormAsMDIChild(student, Me) = True Then
            student.Show()
            student.Focus()
        End If
        instructor.Dispose()
        subject.Dispose()
        room.Dispose()
        classSchedule.Dispose()
        classRegistration.Dispose()
        teachingLoad.Dispose()
    End Sub

    Private Sub btnInstructor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        If makeFormAsMDIChild(instructor, Me) = True Then
            instructor.Show()
            instructor.Focus()
        End If
        student.Dispose()
        subject.Dispose()
        room.Dispose()
        classSchedule.Dispose()
        classRegistration.Dispose()
        teachingLoad.Dispose()
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        If makeFormAsMDIChild(subject, Me) = True Then
            subject.Show()
            subject.Focus()
        End If
        student.Dispose()
        instructor.Dispose()
        room.Dispose()
        classSchedule.Dispose()
        classRegistration.Dispose()
        teachingLoad.Dispose()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        If makeFormAsMDIChild(room, Me) = True Then
            room.Show()
            room.Focus()
        End If
        student.Dispose()
        instructor.Dispose()
        subject.Dispose()
        classSchedule.Dispose()
        classRegistration.Dispose()
        teachingLoad.Dispose()
    End Sub

    Private Sub btnClassSchedule_Click(sender As Object, e As EventArgs) Handles btnClassSchedule.Click
        If makeFormAsMDIChild(classSchedule, Me) = True Then
            classSchedule.Show()
            classSchedule.Focus()
        End If
        student.Dispose()
        instructor.Dispose()
        subject.Dispose()
        room.Dispose()
        classRegistration.Dispose()
        teachingLoad.Dispose()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If makeFormAsMDIChild(classRegistration, Me) = True Then
            classRegistration.Show()
            classRegistration.Focus()
        End If
        student.Dispose()
        instructor.Dispose()
        subject.Dispose()
        room.Dispose()
        classSchedule.Dispose()
        teachingLoad.Dispose()
    End Sub

    Private Sub btnMasterList_Click(sender As Object, e As EventArgs) Handles btnMasterList.Click
        If makeFormAsMDIChild(teachingLoad, Me) = True Then
            teachingLoad.Show()
            teachingLoad.Focus()
        End If
        student.Dispose()
        instructor.Dispose()
        subject.Dispose()
        room.Dispose()
        classSchedule.Dispose()
        classRegistration.Dispose()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If makeFormAsMDIChild(classRegistration, Me) = True Then
            classRegistration.Show()
            classRegistration.Focus()
        End If
        student.Dispose()
        instructor.Dispose()
        subject.Dispose()
        room.Dispose()
        classSchedule.Dispose()
        teachingLoad.Dispose()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        settings.Show()
        settings.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userAccount.Show()
        userAccount.Focus()
    End Sub
End Class