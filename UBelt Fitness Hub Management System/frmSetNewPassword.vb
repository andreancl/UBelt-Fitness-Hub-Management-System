Imports MySql.Data.MySqlClient

Public Class frmSetNewPassword
    Public con As MySqlConnection = mysqldb()
    Public UsernameGetter As String
    Public Sub Reset()
        txtNewPassword.Select()
        txtNewPassword.Clear()
        txtConfirmNewPassword.Clear()
        chckbox_ShowPassword1.Checked = False
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "BACK" Then
            Reset()
            frmForgotPassword.Show()
            frmForgotPassword.Reset()
            Me.Hide()
        Else
            Dim question As String
            question = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If question = vbYes Then
                Reset()
                frmForgotPassword.Show()
                frmForgotPassword.Reset()
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub frmSetNewPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub frmSetNewPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
        End If
    End Sub
    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtConfirmNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        If txtNewPassword.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
End Class