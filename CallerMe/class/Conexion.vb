﻿Imports MySql.Data.MySqlClient

Public Class Conexion

    Dim Conexion = New MySqlConnection()
    Dim Conectar = "server=" + My.Settings.db_servidor + "; user id=" + My.Settings.db_username + "; password=" + My.Settings.db_password + "; database=" + My.Settings.db_nameDB + "; Port=" + My.Settings.db_puerto + ";"

    Public Function Consult(ByVal sql As String)
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
            dato = Nothing
            MsgBox("Imposible conectar a la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

        Return dato

    End Function

    Public Function Ejecutar(ByVal sql As String)
        Try
            Conexion.close()
            Conexion.ConnectionString = Conectar
            Conexion.Open()
            Dim commando As New MySqlCommand
            commando.Connection = Conexion
            commando.CommandText = sql
            commando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class