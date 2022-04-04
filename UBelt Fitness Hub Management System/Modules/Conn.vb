Imports MySql.Data.MySqlClient
Module Conn
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=gymmdb")
    End Function
    Public con As MySqlConnection = mysqldb()
End Module
