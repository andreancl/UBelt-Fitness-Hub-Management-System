Imports MySql.Data.MySqlClient

Public Class frmLogIn
    Public con As MySqlConnection = mysqldb()
    Public Sub Reset()
        txtUsername.Select()
        chckboxShowPassword.Checked = False
        txtUsername.Clear()
        txtPassword.Clear()
        AcceptButton = btnLogin
    End Sub
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

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtPassword.Focus()
        Else
            If Not UserExists() Then
                MsgBox("Wrong Username/Password!", MsgBoxStyle.Critical, "ATTENTION")
            End If
            LogIn(txtUsername.Text, txtPassword.Text)
        End If
    End Sub
    Private Function UserExists() As Boolean
        Dim Result As Boolean = False
        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM users where BINARY Username= '" & txtUsername.Text & "' and BINARY Password = '" & txtPassword.Text & "' "
            cmd = New MySqlCommand(query, con)
            If cmd.ExecuteScalar() > 0 Then Result = True
            cmd.Dispose()
        Catch ex As Exception
        Finally
            con.close()
        End Try
        Return Result
    End Function

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Me.Hide()
        frmForgotPassword.Show()
    End Sub
End Class
