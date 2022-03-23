Imports MySql.Data.MySqlClient

Public Class frmLogIn
    Public con As MySqlConnection = mysqldb()
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

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        LogIn(txtUsername.Text, txtPassword.Text)
        If Not UserExists() Then
            MsgBox("User does not exist!")
        End If
    End Sub
    Private Function UserExists() As Boolean
        Dim Result As Boolean = False
        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM users where Username= '" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "' "
            cmd = New MySqlCommand(query, con)
            If cmd.ExecuteScalar() > 0 Then Result = True
            cmd.Dispose()
        Catch ex As Exception
        Finally
            con.close()
        End Try
        Return Result
    End Function
End Class
