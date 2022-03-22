Imports MySql.Data.MySqlClient

Public Class frmDashboard
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        crud.ExitSystem()
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        closeChildForm()
        showForm(frmMembers)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        closeChildForm()
        showForm(frmAttendance)
    End Sub
End Class