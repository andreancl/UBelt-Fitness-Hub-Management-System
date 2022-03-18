Imports MySql.Data.MySqlClient

Public Class frmDashboard
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        crud.ExitSystem()
    End Sub
End Class