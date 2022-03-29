﻿Public Class frmDashboard
    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        closeChildForm()
        showForm(frmMembers)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        closeChildForm()
        showForm(frmAttendance)
    End Sub

    Private Sub btnLogHistory_Click(sender As Object, e As EventArgs) Handles btnLogHistory.Click
        closeChildForm()
        showForm(frmLogHistory)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        closeChildForm()
        showForm(frmSettings)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        btnLogOut.Text = MessageBox.Show("Are you sure you want to logout?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If btnLogOut.Text = DialogResult.Yes Then
            Me.Hide()
            Reset()
            frmLogIn.Show()
            frmLogIn.Reset()
        End If
        btnLogOut.Text = "Logout"
    End Sub
End Class