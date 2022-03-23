Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
    Public Sub LogIn(ByVal username As Object, ByVal password As Object)
        Try
            con.Open()
            Dim query As String
            query = "SELECT UserTypeId FROM users where Username= '" & username & "' and Password = '" & password & "' "
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.HasRows() Then
                dr.Read()
                If dr("UserTypeId") = "1" Then
                    frmDashboard.lblUserName.Text = "Admin"
                    With frmDashboard
                        .btnDashboard.Visible = True
                        .btnMembers.Visible = True
                        .btnAttendance.Visible = True
                        .btnSettings.Visible = True
                    End With
                    frmDashboard.Show()
                    frmLogIn.Hide()
                Else
                    frmDashboard.lblUserName.Text = "User"
                      With frmDashboard
                        .btnDashboard.Visible = True
                        .btnMembers.Visible = True
                        .btnAttendance.Visible = True
                        .btnSettings.Visible = False
                    End With
                    frmDashboard.Show()
                    frmLogIn.Hide()
                End If
            End If
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
End Module
