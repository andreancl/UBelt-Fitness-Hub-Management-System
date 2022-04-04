Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
    Public Sub LogIn(ByVal username As Object, ByVal password As Object)
        Try
            con.Open()
            Dim query As String
            query = "SELECT UserTypeId FROM users where BINARY Username= '" & username & "' and BINARY Password = '" & password & "' "
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.HasRows() Then
                dr.Read()
                If dr("UserTypeId") = "1" Then
                    frmDashboard.lblUserName.Text = "Admin"
                    With frmDashboard
                        .btnMembers.Visible = False
                        .btnAttendance.Visible = False
                        .btnLogHistory.Visible = True
                        .btnSettings.Visible = True
                        .btnLogOut.Visible = True
                        .btnLogOut.Text = "   Log Out"
                    End With
                    frmDashboard.Show()
                    showForm(frmLogHistory)
                    frmLogIn.Hide()
                Else
                    frmDashboard.lblUserName.Text = "User"
                    With frmDashboard
                        .btnMembers.Visible = True
                        .btnAttendance.Visible = True
                        .btnLogHistory.Visible = False
                        .btnSettings.Visible = False
                        .btnLogOut.Visible = True
                        .btnLogOut.Text = "   Log Out"
                    End With
                    frmDashboard.Show()
                    showForm(frmMembers)
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
