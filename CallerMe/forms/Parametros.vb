Imports MySql.Data.MySqlClient

Public Class Parametros
    Dim f As New functions
    Dim colorfondo As Color
    Dim colorselect As Color
    Dim tipo_font As Font

    Private Sub Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        Txt_DB_Servidor.Text = My.Settings.db_servidor
        Txt_DB_Username.Text = My.Settings.db_username
        Txt_DB_Password.Text = My.Settings.db_password
        Txt_DB_DB.Text = My.Settings.db_nameDB
        Txt_DB_Puerto.Text = My.Settings.db_puerto
        TxtUrlData.Text = My.Settings.data_url
        Tablas_Height.Value = My.Settings.datagridview_height
        Button4.BackColor = My.Settings.datagridview_color
        Button5.Font = My.Settings.datagridview_font
        Button6.BackColor = My.Settings.datagridview_selectrow
        tipo_font = My.Settings.datagridview_font
        colorselect = My.Settings.datagridview_selectrow


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
        My.Settings.data_url = TxtUrlData.Text
        My.Settings.datagridview_height = Tablas_Height.Value
        My.Settings.datagridview_color = colorfondo
        My.Settings.datagridview_font = tipo_font
        My.Settings.datagridview_selectrow = colorselect

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

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        f.RutaDataGET(TxtUrlData)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            colorfondo = ColorDialog1.Color
            Button4.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If FontDialog1.ShowDialog() = DialogResult.OK Then
            tipo_font = FontDialog1.Font
            Button5.Font = FontDialog1.Font
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            colorselect = ColorDialog1.Color
            Button6.BackColor = ColorDialog1.Color
        End If
    End Sub

End Class