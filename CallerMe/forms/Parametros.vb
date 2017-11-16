Imports MySql.Data.MySqlClient

Public Class Parametros
    Dim f As New functions

    Private Sub Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        Txt_DB_Servidor.Text = My.Settings.db_servidor
        Txt_DB_Username.Text = My.Settings.db_username
        Txt_DB_Password.Text = My.Settings.db_password
        Txt_DB_DB.Text = My.Settings.db_nameDB
        Txt_DB_Puerto.Text = My.Settings.db_puerto

        If f.IsFormOpen(control) Then
            TxtSalir.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles TxtSalir.Click
        Login.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TxtGuardar.Click
        My.Settings.db_servidor = Txt_DB_Servidor.Text
        My.Settings.db_username = Txt_DB_Username.Text
        My.Settings.db_password = Txt_DB_Password.Text
        My.Settings.db_nameDB = Txt_DB_DB.Text
        My.Settings.db_puerto = Txt_DB_Puerto.Text

        f.Alert("Configuracion actualizada", f.Alert_NumberInformacion)

        Application.Restart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim MysqlCommand As New MySqlCommand
            Dim MysqlConnString As String = "server=" + Txt_DB_Servidor.Text + "; user id=" + Txt_DB_Username.Text + "; password=" + Txt_DB_Password.Text + "; database=" + Txt_DB_DB.Text + "; Port=" + Txt_DB_Puerto.Text + ";"
            Dim MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)
            MysqlConexion.Open()
            MsgBox("Conexion existosa", MsgBoxStyle.Information, "Respuesta Conexion DB")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("No fue posible conectarse al servidor", MsgBoxStyle.Critical, "Respuesta Conexion DB")
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.login_username = ""
        My.Settings.login_password = ""

        f.Alert("Credencial eliminada", f.Alert_NumberInformacion)
        Application.Restart()
    End Sub

    Private Sub Parametros_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class