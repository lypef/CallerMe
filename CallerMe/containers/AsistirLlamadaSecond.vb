﻿Public Class AsistirLlamadaSecond

    Public Shared id_log As Int32 = 0
    Public Shared id_client As String = ""
    Public Shared id_direccion As String = ""

    Dim f As New functions

    Private Sub AsistirLlamadaSecond_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.BotonesBackGroundBlueForm(Me)
    End Sub

    Public Sub loader_values(id As String)
        id_log = id
        f.LoadValuesAsistirSecond(TxtCliente, TxtTelefono, TxtObservacion, id_log.ToString, CombDirecciones, id_client, id_direccion, TxtVehiculo, TxtConductor)

        TxtVehiculo.Select()

        'f.ComboBox_SetVehiculosConID(ComboVehiculos)
        'Combo_Driver.Items.Add("Conductores")
        'f.ComboBox_SetDriversConID(Combo_Driver)
        'Combo_Driver.SelectedIndex = 0
    End Sub

    Private Sub CbDireccionAdd_0_CheckedChanged(sender As Object, e As EventArgs) Handles CbDireccionAdd_0.CheckedChanged
        If CbDireccionAdd_0.Checked Then
            TxtAddDireccion.Enabled = True
            Button1.Enabled = True
        Else
            TxtAddDireccion.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If f.AddDireccionXpress(TxtAddDireccion, Integer.Parse(id_client)) Then

            TxtAddDireccion.Text = ""
            TxtAddDireccion.Enabled = False
            Button1.Enabled = False
            CbDireccionAdd_0.Checked = False

            f.LoadValuesAsistirSecond(TxtCliente, TxtTelefono, TxtObservacion, id_log.ToString, CombDirecciones, id_client, id_direccion, TxtVehiculo, TxtConductor)
            f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
        End If
    End Sub

    Private Sub TxtAddDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub ComboVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If ComboVehiculos.SelectedIndex > 0 Then
        ' f.SelectConductor(f.ReturnDriver_Vehicle(f.ListVehiculos.Item(ComboVehiculos.SelectedIndex)), Combo_Driver)
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BotonFinalizar()
    End Sub

    Private Sub BotonFinalizar()
        Dim direccion_id = CombDirecciones.SelectedItem.ToString.Substring(CombDirecciones.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")
        'Dim vehiculo_id = ComboVehiculos.SelectedItem.ToString.Substring(ComboVehiculos.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")
        'Dim driver_id = Combo_Driver.SelectedItem.ToString.Substring(Combo_Driver.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

        If f.log_second_update(direccion_id, TxtVehiculo, TxtConductor, id_log.ToString, TxtObservacion.Text) Then
            Use4WindowsSecond.LoadIni()
            Logs.LoadIni()
            Me.Dispose()
        End If
    End Sub

    Private Sub TxtVehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtVehiculo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BotonFinalizar()
        End If
    End Sub
End Class