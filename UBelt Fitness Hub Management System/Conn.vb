Imports MySql.Data.MySqlClient
Module Conn
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=nicole062419;database=gymdb")
    End Function
    Public conn As MySqlConnection = mysqldb()
End Module
