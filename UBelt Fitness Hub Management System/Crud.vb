Imports MySql.Data.MySqlClient
Module crud
    Public con As MySqlConnection = mysqldb()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public ds As New DataSet
    Public query As String
    Public result As String
    Public add As String
    Public edit As String

    Public Function ExitSystem()
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to log out?", "Gym Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
        End
    End Function
End Module