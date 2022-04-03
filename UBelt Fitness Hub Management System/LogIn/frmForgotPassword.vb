Imports MySql.Data.MySqlClient
Public Class frmForgotPassword
    Public con As MySqlConnection = mysqldb()
    Public Sub Reset()
        txtUsername.Focus()
        txtUsername.Clear()
        cmbSecretQuestion.Text = ""
        txtSecretAnswer.Clear()
        chckboxSecretAnswer.Checked = False
    End Sub
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
    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
#Region "Validation"
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = True
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtSecretAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecretAnswer.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = True
            Else
                e.Handled = True
            End If
        End If
    End Sub
#End Region
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Reset()
        Me.Hide()
        frmLogIn.Show()
        frmLogIn.Reset()
    End Sub
End Class