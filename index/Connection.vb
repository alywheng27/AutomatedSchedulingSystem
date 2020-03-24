
Imports System.Data.OleDb
Imports System.Data.SqlClient

Module modDBOperations

    Public dbDataSource As String
    Public dbUsername As String
    Public dbPassword As String

    'Public conSTR As String = ("Provider=Microsoft.ACE.OLEDB.12.0;;Data Source== " & Environment.CurrentDirectory & "\mitshsdb.accdb;")
    'Private conSTR As String = ("Provider=sqloledb;Data Source=HYDROXENCH-PC\HYDROSQL;Initial Catalog=istatistikaData;User Id=hydroxench;Password=12345;")

    Public CN As SqlConnection

    Public Function dbConnect() As Boolean
        On Error GoTo err

        'Dim dbProvider As String
        'Dim dbSource As String

        'dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        'dbSource = "Data Source = " & Environment.CurrentDirectory & "\a.accdb"

        'CN = New SqlConnection("Data Source=Hydroxench-PC\HYDROSQL;Initial Catalog=quizData;User Id=hydroxench;Password=12345;")
        CN = New SqlConnection("Data Source=DESKTOP-C4499M6;Initial Catalog=trac-ass;User Id=cyberaly27;Password=teleport300L!;")

        'CN.ConnectionString = dbProvider & dbSource
        'CN.ConnectionString = conSTR

        If CN.State = ConnectionState.Open Then
            CN.Close()
        End If

        CN.Open()

        Return True
        Exit Function
err:
        MsgBox(Err.Description)
        Return False
    End Function


    Public Function fillData(ByRef sql As String, ByRef dtaSet As DataSet, ByRef tblName As String) As Boolean
        'Dim da As OleDb.OleDbDataAdapter
        Dim da As SqlDataAdapter

        dtaSet.Reset()

        If dbConnect() = True Then
            'da = New OleDb.OleDbDataAdapter(sql, CN)
            da = New SqlDataAdapter(sql, CN)
            da.Fill(dtaSet, tblName)

            CN.Close()
            fillData = True
        Else

            fillData = False
            MessageBox.Show("Cannot connect to database. Please try again.", systemName)

        End If

    End Function


    'Function to save data to database

    Public Function updateData(ByVal sql As String) As Boolean
        Try
            updateData = False

            If dbConnect() = True Then
                'Dim cmd As OleDb.OleDbCommand
                'cmd = New OleDb.OleDbCommand(sql, CN)

                Dim cmd As SqlCommand
                cmd = New SqlCommand(sql, CN)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                CN.Close()
                updateData = True
            End If

        Catch ex As Exception
            updateData = False

            MsgBox(ex.Message & vbNewLine & ex.ToString, vbExclamation + vbOKOnly, systemName)
        End Try

    End Function


    Public Function updateData(ByVal sql As String, ByVal imgParam As SqlParameter) As Boolean
        Try
            updateData = False

            If dbConnect() = True Then
                'Dim cmd As OleDb.OleDbCommand
                'cmd = New OleDb.OleDbCommand(sql, CN)
                Dim cmd As SqlCommand
                cmd = New SqlCommand(sql, CN)

                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                CN.Close()
                updateData = True
            End If

        Catch ex As Exception
            updateData = False

            MsgBox(ex.Message, vbExclamation + vbOKOnly, systemName)
        End Try

    End Function

    'Function to delete field in database specifying table name, field name and key
    Public Function deleteRecord(ByVal tableName As String, ByVal fieldName As String, ByVal key As Integer) As Boolean
        Dim flag As Boolean = False
        Try
            Dim sql As String
            sql = "DELETE FROM " & tableName & " WHERE " & fieldName & " = " & key

            If updateData(sql) = True Then
                flag = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation + vbOKOnly, systemName)
        End Try

        Return flag
    End Function
End Module

