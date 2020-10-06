Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Parametros
    Dim f As New functions
    Dim colorfondo As Color
    Dim colorselect As Color
    Dim tipo_font As Font
    Dim tipo_font_alert As Font

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
        FontDialog1.Font = My.Settings.datagridview_font

        Button8.Font = My.Settings.font_alertas
        FontDialog2.Font = My.Settings.font_alertas

        Button6.BackColor = My.Settings.datagridview_selectrow
        tipo_font = My.Settings.datagridview_font
        tipo_font_alert = My.Settings.font_alertas
        colorselect = My.Settings.datagridview_selectrow
        TxtLogoReport.Text = My.Settings.report_image
        TimerInterval.Minimum = 250
        TimerInterval.Maximum = 2000
        TimerInterval.Value = My.Settings.timer_intervalo
        Caller_0.Checked = My.Settings.caller_0
        Caller_1.Checked = My.Settings.caller_1
        caller_2.Checked = My.Settings.caller_2
        caller_3.Checked = My.Settings.caller_3


        P_generalID.Text = My.Settings.pg_id
        UrlApi.Text = My.Settings.ws_gps
        CheckGps.Checked = My.Settings.use_gps

        If f.IsFormOpen(control) Then
            TxtSalir.Enabled = False
        End If
        Omitir.Value = My.Settings.omitir_llamada
        Use_Device.Checked = My.Settings.use_device
        Use_Conmutador.Checked = My.Settings.use_conmutador
        use_4_windows.Checked = My.Settings.use_4_windows
        use_4_windows_second.Checked = My.Settings.use_4_windows_second
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
        My.Settings.datagridview_height = CInt(Tablas_Height.Value)
        My.Settings.datagridview_color = colorfondo
        My.Settings.datagridview_font = tipo_font
        My.Settings.font_alertas = tipo_font_alert
        My.Settings.datagridview_selectrow = colorselect
        My.Settings.report_image = TxtLogoReport.Text
        My.Settings.timer_intervalo = CInt(TimerInterval.Value)
        My.Settings.caller_0 = Caller_0.Checked
        My.Settings.caller_1 = Caller_1.Checked
        My.Settings.caller_2 = caller_2.Checked
        My.Settings.caller_3 = caller_3.Checked
        My.Settings.pg_id = P_generalID.Text
        My.Settings.ws_gps = UrlApi.Text
        My.Settings.use_gps = CheckGps.Checked
        My.Settings.omitir_llamada = Omitir.Value
        My.Settings.use_device = Use_Device.Checked
        My.Settings.use_conmutador = Use_Conmutador.Checked
        My.Settings.use_4_windows = use_4_windows.Checked
        My.Settings.use_4_windows_second = use_4_windows_second.Checked

        My.Settings.Save()

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Logo |*.jpg;*.jpeg;*.png;*.gif;*.tif;"
        If file.ShowDialog() = DialogResult.OK Then
            Dim fs As FileStream = New System.IO.FileStream(file.FileName, FileMode.Open, FileAccess.Read)
            TxtLogoReport.Text = file.FileName.Replace("\", "/")
            fs.Close()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If FontDialog2.ShowDialog() = DialogResult.OK Then
            tipo_font_alert = FontDialog2.Font
            Button8.Font = FontDialog2.Font
        End If
    End Sub

    Private Sub Use_Device_CheckedChanged(sender As Object, e As EventArgs) Handles Use_Device.CheckedChanged
        If Use_Device.Checked Then
            Use_Conmutador.Checked = False
        End If
    End Sub

    Private Sub Use_Conmutador_CheckedChanged(sender As Object, e As EventArgs) Handles Use_Conmutador.CheckedChanged
        If Use_Conmutador.Checked Then
            Use_Device.Checked = False
        End If
    End Sub

    Private Sub use_4_windows_second_CheckedChanged(sender As Object, e As EventArgs) Handles use_4_windows_second.CheckedChanged
        If use_4_windows_second.Checked Then
            Caller_0.Checked = False
            Caller_1.Checked = False
            caller_2.Checked = False
            caller_3.Checked = False
            use_4_windows.Checked = False
        End If
    End Sub

    Private Sub use_4_windows_CheckedChanged(sender As Object, e As EventArgs) Handles use_4_windows.CheckedChanged
        If use_4_windows.Checked Then
            use_4_windows_second.Checked = False
        End If
    End Sub
End Class