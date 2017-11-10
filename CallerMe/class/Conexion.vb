Imports MySql.Data.MySqlClient

Public Class Conexion

    Dim Conexion = New MySqlConnection()
    Dim Conectar = "server=127.0.0.1; user id=root; password=; database=caller_me;"

    Public Function Conultar(ByVal sql As String)
        Dim dato As MySqlDataReader

        Try
            Conexion.close()
            Conexion.ConnectionString = Conectar
            Conexion.Open()
            Dim adapter As New MySqlDataAdapter
            Dim commando As New MySqlCommand
            commando.Connection = Conexion
            commando.CommandText = sql
            adapter.SelectCommand = commando
            dato = commando.ExecuteReader()
        Catch ex As Exception
            MsgBox("Imposible conectar a la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

        Return dato

    End Function

End Class