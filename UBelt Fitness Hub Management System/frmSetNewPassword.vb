Imports MySql.Data.MySqlClient

Public Class frmSetNewPassword
    Public UsernameGetter As String
    Public con As MySqlConnection = mysqldb()
    Private Sub frmSetNewPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
        End If
    End Sub
    Private Sub chckbox_ShowPassword1_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowPassword1.CheckedChanged
        If chckbox_ShowPassword1.Checked = False Then
            txtNewPassword.PasswordChar = "*"
            txtConfirmNewPassword.PasswordChar = "*"
        Else
            txtNewPassword.PasswordChar = ""
            txtConfirmNewPassword.PasswordChar = ""
        End If
        lblTitle.Focus()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtNewPassword.Text = "" Then
            MsgBox("No New Password Found!", MsgBoxStyle.Critical, "Error")
            txtNewPassword.Focus()
        ElseIf txtConfirmNewPassword.Text = "" Then
            MsgBox("No Confirm New Password Found!", MsgBoxStyle.Critical, "Error")
            txtConfirmNewPassword.Focus()
        Else
            Comparing()
        End If
    End Sub
    Private Sub Comparing()
        If Not txtNewPassword.Text = txtConfirmNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not the same!", MsgBoxStyle.Critical, "Error")
        ElseIf Not txtConfirmNewPassword.Text = txtNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not the same!", MsgBoxStyle.Critical, "Error")
        Else
            SettingANewPassword()
        End If
    End Sub
    Private Sub SettingANewPassword()
        Try
            con.Open()
            Dim query As String
            query = "UPDATE users SET Password = '" & txtConfirmNewPassword.Text & "' WHERE Username = '" & UsernameGetter & "'"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("SUCCESSFULLY UPDATED YOUR PASSWORD", MsgBoxStyle.Information, "ATTENTION")
            Me.Hide()
            Reset()
            frmLogIn.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class