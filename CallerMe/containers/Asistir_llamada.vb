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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Combo_direcciones.SelectedIndex > 0 And ComboVehiculos.SelectedIndex > 0 And Combo_Driver.SelectedIndex > 0 Then
            direccion_id = Combo_direcciones.SelectedItem.ToString.Substring(Combo_direcciones.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")
            vehiculo_id = ComboVehiculos.SelectedItem.ToString.Substring(ComboVehiculos.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")
            driver_id = Combo_Driver.SelectedItem.ToString.Substring(Combo_Driver.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

            If f.save_registroAutomatic(client_id, number_id, f_llamada, Asitir_llamada, DateTime.Now, direccion_id, vehiculo_id, driver_id) Then
                If caller = 0 Then
                    f.finalizarLlamada(caller)
                    control.TimerCero.Start()
                    Me.Dispose()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                ElseIf caller = 1 Then
                    f.finalizarLlamada(caller)
                    control.TimerUno.Start()
                    Me.Dispose()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                ElseIf caller = 2 Then
                    f.finalizarLlamada(caller)
                    control.TimerDOS.Start()
                    Me.Dispose()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                ElseIf caller = 3 Then
                    f.finalizarLlamada(caller)
                    control.TimerTres.Start()
                    Me.Dispose()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                End If
            Else
                f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
            End If
        Else
            f.Alert("Verifique sus opciones seleccionadas", f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Asistir_llamada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.BotonesBackGroundBlue(Panel1)
    End Sub

    Public Sub loadvalues()
        f.ComboBox_SetVehiculosConID(ComboVehiculos)
        Combo_Driver.Items.Add("Conductores")
        f.ComboBox_SetDriversConID(Combo_Driver)
        Combo_Driver.SelectedIndex = 0
        Client.Text = f.LoadNumberAsistencia(number, PictureBox1, Combo_direcciones, number_id, client_id) + " | " + number
        ubicar = True
        Me.StartPosition = FormStartPosition.WindowsDefaultLocation
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
End Class