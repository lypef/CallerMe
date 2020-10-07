Public Class LogsADD
    Dim f As New functions

    Dim number_id_0 As String
    Dim client_id_0 As Integer
    Dim number_0 As String
    Dim observacion_0 As String
    Dim f_llamada_0 As Date
    Dim Asitir_llamada_0 As Date

    Private Sub LogsADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.BotonesBackGroundBlueForm(Me)
    End Sub

    Public Sub LoadValues_0(Number As String)
        Try
            CbAddClient_0.Checked = False
            CbDireccionAdd_0.Checked = False
            TxtAddClient_0.Text = ""
            TxtAddDireccion_0.Text = ""

            'Dim Device = f.ComprobarLlamada(0).ToString
            Dim Device = Number

            If (String.IsNullOrEmpty(Device) = False) Then

                functions.LastNumber0 = Device
                number_0 = Device
                TxtClient_0.Text = f.LoadNumberAsistencia4Windows(number_0, Combo_direcciones_0, number_id_0, client_id_0)

                f_llamada_0 = DateTime.Now
                Asitir_llamada_0 = DateTime.Now

                WindowsDevice_0.Text = "NUMERO: " + number_0
                WindowsDevice_0.Enabled = True
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ". Control.vb linea 115")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        add_ciente_direccion_0()
    End Sub

    Private Sub CbAddClient_0_CheckedChanged(sender As Object, e As EventArgs) Handles CbAddClient_0.CheckedChanged
        If CbAddClient_0.Checked Then
            If client_id_0 = 1 Then
                TxtAddClient_0.Enabled = True
                TxtAddClient_0.Text = "CLIENTE SIN NOMBRE"
                TxtAddClient_0.Focus()

                CbDireccionAdd_0.Checked = True
                TxtAddDireccion_0.Enabled = True
                TxtAddDireccion_0.Text = "ESCRIBA UNA DIRECCION"
            Else
                CbAddClient_0.Checked = False
                f.Alert("Este numero ya tiene un cliente asignado, Solo podra ingresar una direccion.", f.Alert_NumberExclamacion)
            End If
        Else
            TxtAddClient_0.Text = ""
            TxtAddClient_0.Enabled = False
        End If
    End Sub

    Private Sub TxtAddClient_0_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddClient_0.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_0()
        End If
    End Sub

    Private Sub CbDireccionAdd_0_CheckedChanged(sender As Object, e As EventArgs) Handles CbDireccionAdd_0.CheckedChanged
        If CbDireccionAdd_0.Checked Then
            TxtAddDireccion_0.Enabled = True
            TxtAddDireccion_0.Focus()
        Else
            TxtAddDireccion_0.Text = ""
            TxtAddDireccion_0.Enabled = False
        End If
    End Sub

    Private Sub TxtAddDireccion_0_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddDireccion_0.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_0()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myValue As String = InputBox("Ingrese comentario", "Observacion")

        If String.IsNullOrEmpty(myValue) = False Then
            observacion_0 = myValue
        End If
    End Sub

    Private Sub Clean_0()
        observacion_0 = ""
        CbAddClient_0.Checked = False
        CbDireccionAdd_0.Checked = False
        TxtAddClient_0.Text = ""
        TxtAddDireccion_0.Text = ""
        WindowsDevice_0.Enabled = False
        WindowsDevice_0.Text = "No disponible"
        TxtClient_0.Text = "NOMBRE:"
        Combo_direcciones_0.Items.Clear()
        Vehiculos_0.Value = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Combo_direcciones_0.SelectedIndex > 0 Then

                Dim direccion_id = Combo_direcciones_0.SelectedItem.ToString.Substring(Combo_direcciones_0.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

                If f.save_registroAutomaticOne(client_id_0, number_id_0, f_llamada_0, Asitir_llamada_0, DateTime.Now, direccion_id, observacion_0, Vehiculos_0.Value) Then

                    Dim r As DialogResult = MessageBox.Show("Solicitud enviada.", "Proceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Clean_0()
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberInformacion)
                End If
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ", En Asistir llamada")
        End Try
    End Sub

    Private Sub add_ciente_direccion_0()
        If CbAddClient_0.Checked And CbDireccionAdd_0.Checked = False Then
            'Se agrega solo el cliente
            If f.AddClientXpress(TxtAddClient_0, number_0) Then
                TxtClient_0.Text = f.LoadNumberAsistencia4Windows(number_0, Combo_direcciones_0, number_id_0, client_id_0)
                CbAddClient_0.Checked = False
                CbDireccionAdd_0.Checked = False
                TxtAddClient_0.Text = ""
                TxtAddDireccion_0.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        ElseIf CbAddClient_0.Checked = False And CbDireccionAdd_0.Checked Then
            'Se agrega solo la direccion
            If f.AddDireccionXpress(TxtAddDireccion_0, client_id_0) Then
                TxtClient_0.Text = f.LoadNumberAsistencia4Windows(number_0, Combo_direcciones_0, number_id_0, client_id_0)
                CbAddClient_0.Checked = False
                CbDireccionAdd_0.Checked = False
                TxtAddClient_0.Text = ""
                TxtAddDireccion_0.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            End If
        ElseIf CbAddClient_0.Checked And CbDireccionAdd_0.Checked Then
            'Se agrega direccion y cliente
            If f.AddClientXpress(TxtAddClient_0, number_0) Then
                If f.AddDireccionXpress(TxtAddDireccion_0, f.LastIDClients()) Then
                    TxtClient_0.Text = f.LoadNumberAsistencia4Windows(number_0, Combo_direcciones_0, number_id_0, client_id_0)
                    CbAddClient_0.Checked = False
                    CbDireccionAdd_0.Checked = False
                    TxtAddClient_0.Text = ""
                    TxtAddDireccion_0.Text = ""
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                End If
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        End If
    End Sub

End Class