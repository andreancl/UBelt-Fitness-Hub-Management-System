Imports MySql.Data.MySqlClient
Module crud
    Public con As MySqlConnection = mysqldb()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public ds As New DataSet
    Public query As String
    Public result As String
    Public add As String
    Public edit As String
    
#Region "crud"
    Public Sub reloadtxt(ByVal query As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = query
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(query, con)
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message & "log")
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub create(ByVal query As String, ByVal msgsuccess As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = query
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
                Else
                    MsgBox("Success")
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message & " create")
        End Try
        con.Close()
    End Sub
    Public Sub createNoMsg(ByVal sqlquery As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sqlquery
                cmd.ExecuteNonQuery()

            End With
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "createNoMsg")
        End Try
    End Sub

    Public Sub updates(ByVal query As String, ByVal msgsuccess As String)
        Try
            con.Open()
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = query
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
                Else
                    MsgBox("Updated!")
                End If
            End With
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "updates")
        End Try
    End Sub

    Public Sub reloadDgv(ByVal query As String, ByVal dgv As DataGridView)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = query
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(query, con)
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message & "reloadDtg")
        End Try

        con.Close()
        da.Dispose()
    End Sub

    Public Sub deletes(ByVal query As String, ByVal msgsuccess As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = query
            End With
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
            Else
                MsgBox("Deleted!")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Module