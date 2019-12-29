Module SystemFunction
    Public Function makeFormAsMDIChild(frmName As Form, frmParent As Form) As Boolean
        Try
            frmName.MdiParent = frmParent
            makeFormAsMDIChild = True
        Catch ex As Exception
            makeFormAsMDIChild = False
            MessageBox.Show("error")
        End Try
    End Function
End Module
