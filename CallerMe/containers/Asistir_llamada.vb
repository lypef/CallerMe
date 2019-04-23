Public Class Asistir_llamada
    Dim f As New functions
    Public caller As Integer
    Public client_id As Integer
    Public number As String
    Public number_id As String
    Public direccion_id As String
    Public vehiculo_id As String
    Public driver_id As String
    Public f_llamada As Date
    Public Asitir_llamada As Date
    Dim ubicar As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Asistir_llamada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.BotonesBackGroundBlue(Panel1)
        f.Button_SetModel(btn_ADD_INFO, My.Resources.ASISTIR_LLAMADA_AGREGAR)
        f.Button_SetModel(BtnRecargar, My.Resources.r_valores)
        f.Button_SetModel(BtnCancelar, My.Resources.cancelar)
        f.Button_SetModel(Btn_GuardarDb, My.Resources.guardar)
    End Sub

    Public Sub loadvalues()
        TxtAddClient.Enabled = False
        TxtAddDireccion.Enabled = False
        TxtAddClient.Text = ""
        TxtAddDireccion.Text = ""
        CbAddClient.Checked = False
        CbDireccionAdd.Checked = False

        f.ComboBox_SetVehiculosConID(ComboVehiculos)
        Combo_Driver.Items.Add("Conductores")
        f.ComboBox_SetDriversConID(Combo_Driver)
        Combo_Driver.SelectedIndex = 0
        GB_EXISTENTE.Text = f.LoadNumberAsistencia(number, PictureBox1, Combo_direcciones, number_id, client_id) + " | " + number
        f.LastLogs_DataGridViewSet(Table_Logs)
        ubicar = True
        Me.StartPosition = FormStartPosition.WindowsDefaultLocation
    End Sub

    Public Sub loadvalues_sub()
        GB_EXISTENTE.Text = f.LoadNumberAsistencia(number, PictureBox1, Combo_direcciones, number_id, client_id) + " | " + number
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If caller = 0 Then
            f.finalizarLlamada(caller)
            control.TimerCero.Start()
            Me.Dispose()
        ElseIf caller = 1 Then
            f.finalizarLlamada(caller)
            control.TimerUno.Start()
            Me.Dispose()
        ElseIf caller = 2 Then
            f.finalizarLlamada(caller)
            control.TimerDOS.Start()
            Me.Dispose()
        ElseIf caller = 3 Then
            f.finalizarLlamada(caller)
            control.TimerTres.Start()
            Me.Dispose()
        End If
        f.OmitirLlamadaDb(f_llamada, number)
    End Sub

    Private Sub Asistir_llamada_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If caller = 0 Then
            f.finalizarLlamada(caller)
            control.TimerCero.Start()
        ElseIf caller = 1 Then
            f.finalizarLlamada(caller)
            control.TimerUno.Start()
        ElseIf caller = 2 Then
            f.finalizarLlamada(caller)
            control.TimerDOS.Start()
        ElseIf caller = 3 Then
            f.finalizarLlamada(caller)
            control.TimerTres.Start()
        End If
        f.OmitirLlamadaDb(f_llamada, number)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnRecargar.Click
        loadvalues()
    End Sub

    Private Sub Combo_Driver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Driver.SelectedIndexChanged
        If ubicar Then
            If My.Settings.use_gps Then
                Dim id = Combo_Driver.SelectedItem.ToString.Substring(Combo_Driver.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")
                If f.Vehicle_GetGPS(Convert.ToInt32(id), Wb) = False Then
                    f.Alert("Error no definido", f.Alert_NumberExclamacion)
                End If
            End If
        End If
    End Sub

    Private Sub ComboVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboVehiculos.SelectedIndexChanged
        If ComboVehiculos.SelectedIndex > 0 Then
            f.SelectConductor(f.ReturnDriver_Vehicle(f.ListVehiculos.Item(ComboVehiculos.SelectedIndex)), Combo_Driver)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CbAddClient.CheckedChanged
        If CbAddClient.Checked Then
            TxtAddClient.Enabled = True
            TxtAddClient.Text = "CLIENTE SIN NOMBRE"
            TxtAddClient.Focus()
        Else
            TxtAddClient.Text = ""
            TxtAddClient.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CbDireccionAdd.CheckedChanged
        If CbDireccionAdd.Checked Then
            TxtAddDireccion.Enabled = True
            TxtAddDireccion.Focus()
        Else
            TxtAddDireccion.Text = ""
            TxtAddDireccion.Enabled = False
        End If
    End Sub

    Private Sub btn_ADD_INFO_MouseEnter(sender As Object, e As EventArgs) Handles btn_ADD_INFO.MouseEnter
        f.Button_SetModel(btn_ADD_INFO, My.Resources.ASISTIR_LLAMADA_AGREGAR_EFECT)
    End Sub

    Private Sub btn_ADD_INFO_MouseLeave(sender As Object, e As EventArgs) Handles btn_ADD_INFO.MouseLeave
        f.Button_SetModel(btn_ADD_INFO, My.Resources.ASISTIR_LLAMADA_AGREGAR)
    End Sub

    Private Sub BtnRecargar_MouseEnter(sender As Object, e As EventArgs) Handles BtnRecargar.MouseEnter
        f.Button_SetModel(BtnRecargar, My.Resources.r_valores_efect)
    End Sub

    Private Sub BtnRecargar_MouseLeave(sender As Object, e As EventArgs) Handles BtnRecargar.MouseLeave
        f.Button_SetModel(BtnRecargar, My.Resources.r_valores)
    End Sub

    Private Sub BtnCancelar_MouseEnter(sender As Object, e As EventArgs) Handles BtnCancelar.MouseEnter
        f.Button_SetModel(BtnCancelar, My.Resources.cancelar_efect)
    End Sub

    Private Sub BtnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancelar.MouseLeave
        f.Button_SetModel(BtnCancelar, My.Resources.cancelar)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btn_GuardarDb.Click
        If Combo_direcciones.SelectedIndex > 0 And ComboVehiculos.SelectedIndex > 0 And Combo_Driver.SelectedIndex > 0 Then
            direccion_id = Combo_direcciones.SelectedItem.ToString.Substring(Combo_direcciones.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")
            vehiculo_id = ComboVehiculos.SelectedItem.ToString.Substring(ComboVehiculos.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")
            driver_id = Combo_Driver.SelectedItem.ToString.Substring(Combo_Driver.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

            If f.save_registroAutomatic(client_id, number_id, f_llamada, Asitir_llamada, DateTime.Now, direccion_id, vehiculo_id, driver_id) Then
                If caller = 0 Then
                    f.finalizarLlamada(caller)
                    control.TimerCero.Start()
                    Me.Dispose()
                    'f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                ElseIf caller = 1 Then
                    f.finalizarLlamada(caller)
                    control.TimerUno.Start()
                    Me.Dispose()
                    'f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                ElseIf caller = 2 Then
                    f.finalizarLlamada(caller)
                    control.TimerDOS.Start()
                    Me.Dispose()
                    'f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                ElseIf caller = 3 Then
                    f.finalizarLlamada(caller)
                    control.TimerTres.Start()
                    Me.Dispose()
                    'f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                End If
            Else
                f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
            End If

            'Se actualiza form logs, hoy
            If f.ReturnPermission(f.Permission_Access_LOGS) Then
                Logs.LoadIni()
            End If

        Else
            f.Alert("Verifique sus opciones seleccionadas", f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Btn_GuardarDb_MouseEnter(sender As Object, e As EventArgs) Handles Btn_GuardarDb.MouseEnter
        f.Button_SetModel(Btn_GuardarDb, My.Resources.guardar_efect)
    End Sub

    Private Sub Btn_GuardarDb_MouseLeave(sender As Object, e As EventArgs) Handles Btn_GuardarDb.MouseLeave
        f.Button_SetModel(Btn_GuardarDb, My.Resources.guardar)
    End Sub

    Private Sub btn_ADD_INFO_Click(sender As Object, e As EventArgs) Handles btn_ADD_INFO.Click
        If CbAddClient.Checked And CbDireccionAdd.Checked = False Then
            'Se agrega solo el cliente
            If f.AddClientXpress(TxtAddClient, number) Then
                loadvalues()
            End If
        ElseIf CbAddClient.Checked = False And CbDireccionAdd.Checked Then
            'Se agrega solo la direccion
            If f.AddDireccionXpress(TxtAddDireccion, client_id) Then
                loadvalues()
            End If
        ElseIf CbAddClient.Checked And CbDireccionAdd.Checked Then
            'Se agrega direccion y cliente
            If f.AddClientXpress(TxtAddClient, number) Then
                loadvalues_sub()

                If f.AddDireccionXpress(TxtAddDireccion, client_id) Then
                    loadvalues()
                End If
            End If
        End If
    End Sub
End Class