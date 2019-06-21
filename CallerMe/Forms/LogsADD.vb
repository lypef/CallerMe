Public Class LogsADD
    Dim f As New functions

    Public Sub LoadIni()
        f.ComboBox_SetUsers(Combo_Users)
        f.ComboBox_SetVehiculos(ComboVehiculos)
        f.ComboBox_SetDrivers(Combo_Driver)
        Combo_direcciones.Items.Add("DIRECCIONES")
        Combo_Driver.Items.Add("CONDUCTORES")
        Combo_direcciones.SelectedIndex = 0
        Combo_Driver.SelectedIndex = 0
        foto.Image = Nothing

        Combo_direcciones.Enabled = False
        Combo_Users.Enabled = False
        ComboVehiculos.Enabled = False
        Combo_Driver.Enabled = False
        Fecha.Enabled = False
        btn_save.Enabled = False

        foto.SizeMode = PictureBoxSizeMode.Zoom
        foto.Image = Image.FromFile(My.Settings.data_url + functions.Data_clients + functions.Clients_ImgDefault)

        cliente_name.Text = ""
        Fecha.Value = DateTime.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search()
    End Sub

    Private Sub Search()
        TxtSearch.Text = TxtSearch.Text.Replace(" ", "")
        If f.IsDecimal(TxtSearch) Then

            'Buscar numero
            If f.LoadNumber_Manual(TxtSearch.Text, foto, cliente_name) Then
                Combo_direcciones.Enabled = True
                Combo_Users.Enabled = True
                ComboVehiculos.Enabled = True
                Combo_Driver.Enabled = True
                Fecha.Enabled = True
                btn_save.Enabled = True
                f.ComboBox_SetDireccion_Client(Combo_direcciones)
            Else
                Combo_direcciones.Enabled = False
                Combo_Users.Enabled = False
                ComboVehiculos.Enabled = False
                Combo_Driver.Enabled = False
                Fecha.Enabled = False
                btn_save.Enabled = False
                f.Alert("El numero no esta registrado", f.Alert_NumberExclamacion)
            End If

        Else
            Combo_direcciones.Enabled = False
            Combo_Users.Enabled = False
            ComboVehiculos.Enabled = False
            Combo_Driver.Enabled = False
            Fecha.Enabled = False
            btn_save.Enabled = False
            f.Alert("Numero no valido", f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Table_Clients_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Table_Clients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Combo_direcciones.SelectedIndex > 0 And Combo_Users.SelectedIndex > 0 And ComboVehiculos.SelectedIndex > 0 And Combo_Driver.SelectedIndex > 0 Then
            If f.save_registroMANUAL(Combo_Users, Combo_direcciones, ComboVehiculos, Combo_Driver, Fecha) Then
                functions.Client = 0
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                LoadIni()
            Else
                f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
            End If
        Else
            f.Alert("Verifique su informacion", f.Alert_NumberCritical)
        End If
        'If Combo_Telefonos.SelectedIndex > 0 And Combo_Users.SelectedIndex > 0 And Combo_direcciones.SelectedIndex > 0 And ComboVehiculos.SelectedIndex > 0 And Combo_Driver.SelectedIndex > 0 Then
        'If f.save_registroMANUAL(Combo_Telefonos, Combo_Users, Combo_direcciones, ComboVehiculos, Combo_Driver, Fecha) Then
        'functions.Client = 0
        'f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
        'LoadIni()
        'Else
        'f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
        'End If
        'Else
        'f.Alert("Verifique su informacion", f.Alert_NumberCritical)
        'End If
    End Sub

    Private Sub Table_Clients_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub ComboVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboVehiculos.SelectedIndexChanged
        If ComboVehiculos.SelectedIndex > 0 Then
            f.SelectConductor(f.ReturnDriver_Vehicle(f.ListVehiculos.Item(ComboVehiculos.SelectedIndex)), Combo_Driver)
        End If
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Search()
        End If
    End Sub
End Class