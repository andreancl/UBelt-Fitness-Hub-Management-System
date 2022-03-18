Imports MySql.Data.MySqlClient
Public Class frmLogIn
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub chckboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPassword.CheckedChanged
        If chckboxShowPassword.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
        lblUsername.Select()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM users where Username= '" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "' "
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            If count = 1 Then
                frmDashboard.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password. Please Try Again")
            Else
                MessageBox.Show("Invalid Username and Password.")
            End If
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub
End Class
