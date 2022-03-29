Imports MySql.Data.MySqlClient
Public Class frmForgotPassword
    Public con As MySqlConnection = mysqldb()
    Private Sub chckboxSecretAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxSecretAnswer.CheckedChanged
        If chckboxSecretAnswer.Checked = False Then
            txtSecretAnswer.PasswordChar = "*"
        Else
            txtSecretAnswer.PasswordChar = ""
        End If
        lblTitle.Select()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtUsername.Text = "" And cmbSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up account details!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Select()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Select()
        ElseIf cmbSecretQuestion.Text = "" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "ATTENTION")
            cmbSecretQuestion.Select()
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtSecretAnswer.Select()
        Else
            Try
                con.Open()
                Dim query As String
                query = "SELECT * FROM users where BINARY Username= '" & txtUsername.Text & "' and BINARY SecretQuestion = '" & cmbSecretQuestion.Text & "' and BINARY SecretAnswer = '" & txtSecretAnswer.Text & "' "
                cmd = New MySqlCommand(query, con)
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    frmSetNewPassword.UsernameGetter = dr.Item("Username")
                    con.Close()
                    dr.Close()
                    Reset()
                    Me.Hide()
                    frmSetNewPassword.Show()
                Else
                    MsgBox("Your details is incorrect!", MsgBoxStyle.Critical, "ATTENTION")
                    dr.Close()
                    con.Close()
                    txtSecretAnswer.Clear()
                    txtSecretAnswer.Focus()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        con.Open()
        Dim query As String
        query = "SELECT * FROM users where Username= '" & txtUsername.Text & "' "
        cmd = New MySqlCommand(query, con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            cmbSecretQuestion.Text = dr("SecretQuestion").ToString
        Else
            cmbSecretQuestion.Text = ""
        End If
        con.Close()
    End Sub
End Class