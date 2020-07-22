Public Class use_4_windows

    Dim f As New functions
    Public Shared Device0 As String = ""
    Public Shared Device1 As String = ""
    Public Shared Device2 As String = ""
    Public Shared Device3 As String = ""

    Dim number_id_0 As String
    Dim client_id_0 As Integer
    Dim number_0 As String
    Dim observacion_0 As String
    Dim f_llamada_0 As Date
    Dim Asitir_llamada_0 As Date

    Dim number_id_1 As String
    Dim client_id_1 As Integer
    Dim number_1 As String
    Dim observacion_1 As String
    Dim f_llamada_1 As Date
    Dim Asitir_llamada_1 As Date

    Dim number_id_2 As String
    Dim client_id_2 As Integer
    Dim number_2 As String
    Dim observacion_2 As String
    Dim f_llamada_2 As Date
    Dim Asitir_llamada_2 As Date

    Dim number_id_3 As String
    Dim client_id_3 As Integer
    Dim number_3 As String
    Dim observacion_3 As String
    Dim f_llamada_3 As Date
    Dim Asitir_llamada_3 As Date

    Private Sub use_4_windows_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        f.BotonesBackGroundBlueForm(Me)
        f.AD101_GetDevice()
        Try
            If f.AD101_InitDevice(Handle.ToInt32()) = 0 Then
                Return
            End If
        Catch ex As Exception
            f.Alert(ex.Message, f.Alert_NumberExclamacion)
        End Try

        If My.Settings.caller_0 Then
            f.AD101_SetBusy(0, 1)
        End If

        If My.Settings.caller_1 Then
            f.AD101_SetBusy(1, 1)
        End If

        If My.Settings.caller_2 Then
            f.AD101_SetBusy(2, 1)
        End If

        If My.Settings.caller_3 Then
            f.AD101_SetBusy(3, 1)
        End If

        'loadTimer()

        WindowsDevice_0.Enabled = False
        WindowsDevice_0.Text = "No disponible"

        WindowsDevice_1.Enabled = False
        WindowsDevice_1.Text = "No disponible"

        WindowsDevice_2.Enabled = False
        WindowsDevice_2.Text = "No disponible"

        WindowsDevice_3.Enabled = False
        WindowsDevice_3.Text = "No disponible"
    End Sub

    Private Sub loadTimer()
        TimerCero.Stop()
        TimerUno.Stop()
        TimerDOS.Stop()
        TimerTres.Stop()

        If My.Settings.caller_0 Then
            TimerCero.Interval = My.Settings.timer_intervalo
            TimerCero.Start()
        End If

        If My.Settings.caller_1 Then
            TimerUno.Interval = My.Settings.timer_intervalo
            TimerUno.Start()
        End If

        If My.Settings.caller_2 Then
            TimerDOS.Interval = My.Settings.timer_intervalo
            TimerDOS.Start()
        End If

        If My.Settings.caller_3 Then
            TimerTres.Interval = My.Settings.timer_intervalo
            TimerTres.Start()
        End If
    End Sub

    Private Sub TimerCero_Tick(sender As Object, e As EventArgs) Handles TimerCero.Tick
        LoadValues_0()
    End Sub

    Private Sub TimerUno_Tick(sender As Object, e As EventArgs) Handles TimerUno.Tick
        LoadValues_1()
    End Sub

    Private Sub TimerDos_Tick(sender As Object, e As EventArgs) Handles TimerDos.Tick
        LoadValues_2()
    End Sub

    Private Sub Timertres_Tick(sender As Object, e As EventArgs) Handles Timertres.Tick
        LoadValues_3()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LoadValues_0()
    End Sub

    Private Sub LoadValues_0()
        Try
            CbAddClient_0.Checked = False
            CbDireccionAdd_0.Checked = False
            TxtAddClient_0.Text = ""
            TxtAddDireccion_0.Text = ""

            Dim Device = f.ComprobarLlamada(0).ToString
            'Dim Device = "01800"

            If (String.IsNullOrEmpty(Device) = False) Then

                TimerCero.Stop()
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
    End Sub

    Private Sub LoadValues_1()
        Try
            CbAddClient_1.Checked = False
            CbDireccionAdd_1.Checked = False
            TxtAddClient_1.Text = ""
            TxtAddDireccion_1.Text = ""

            Dim Device = f.ComprobarLlamada(1).ToString
            'Dim Device = "01800"

            If (String.IsNullOrEmpty(Device) = False) Then

                TimerUno.Stop()
                functions.LastNumber1 = Device
                number_1 = Device
                TxtClient_1.Text = f.LoadNumberAsistencia4Windows(number_1, Combo_direcciones_1, number_id_1, client_id_1)

                f_llamada_1 = DateTime.Now
                Asitir_llamada_1 = DateTime.Now

                WindowsDevice_1.Text = "NUMERO: " + number_1
                WindowsDevice_1.Enabled = True
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ". Control.vb linea 177")
            End Try
    End Sub

    Private Sub Clean_1()
        observacion_1 = ""
        CbAddClient_1.Checked = False
        CbDireccionAdd_1.Checked = False
        TxtAddClient_1.Text = ""
        TxtAddDireccion_1.Text = ""
        WindowsDevice_1.Enabled = False
        WindowsDevice_1.Text = "No disponible"
        TxtClient_1.Text = "NOMBRE:"
        Combo_direcciones_1.Items.Clear()
    End Sub

    Private Sub LoadValues_2()
        Try
            CbAddClient_2.Checked = False
            CbDireccionAdd_2.Checked = False
            TxtAddClient_2.Text = ""
            TxtAddDireccion_2.Text = ""

            Dim Device = f.ComprobarLlamada(2).ToString
            'Dim Device = "01800"

            If (String.IsNullOrEmpty(Device) = False) Then

                TimerDos.Stop()
                functions.LastNumber2 = Device
                number_2 = Device
                TxtClient_2.Text = f.LoadNumberAsistencia4Windows(number_2, Combo_direcciones_2, number_id_2, client_id_2)

                f_llamada_2 = DateTime.Now
                Asitir_llamada_2 = DateTime.Now

                WindowsDevice_2.Text = "NUMERO: " + number_2
                WindowsDevice_2.Enabled = True
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ". Control.vb linea 214")
        End Try
    End Sub

    Private Sub Clean_2()
        observacion_2 = ""
        CbAddClient_2.Checked = False
        CbDireccionAdd_2.Checked = False
        TxtAddClient_2.Text = ""
        TxtAddDireccion_2.Text = ""
        WindowsDevice_2.Enabled = False
        WindowsDevice_2.Text = "No disponible"
        TxtClient_2.Text = "NOMBRE:"
        Combo_direcciones_2.Items.Clear()
    End Sub

    Private Sub LoadValues_3()
        Try
            CbAddClient_3.Checked = False
            CbDireccionAdd_3.Checked = False
            TxtAddClient_3.Text = ""
            TxtAddDireccion_3.Text = ""

            Dim Device = f.ComprobarLlamada(3).ToString
            'Dim Device = "01800"

            If (String.IsNullOrEmpty(Device) = False) Then

                Timertres.Stop()
                functions.LastNumber3 = Device
                number_3 = Device
                TxtClient_3.Text = f.LoadNumberAsistencia4Windows(number_3, Combo_direcciones_3, number_id_3, client_id_3)

                f_llamada_3 = DateTime.Now
                Asitir_llamada_3 = DateTime.Now

                WindowsDevice_3.Text = "NUMERO: " + number_3
                WindowsDevice_3.Enabled = True
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ". Control.vb linea 214")
        End Try
    End Sub

    Private Sub Clean_3()
        observacion_3 = ""
        CbAddClient_3.Checked = False
        CbDireccionAdd_3.Checked = False
        TxtAddClient_3.Text = ""
        TxtAddDireccion_3.Text = ""
        WindowsDevice_3.Enabled = False
        WindowsDevice_3.Text = "No disponible"
        TxtClient_3.Text = "NOMBRE:"
        Combo_direcciones_3.Items.Clear()
    End Sub

    Private Sub CbAddClient_CheckedChanged(sender As Object, e As EventArgs) Handles CbAddClient_0.CheckedChanged
        If CbAddClient_0.Checked Then
            If client_id_0 = 1 Then
                TxtAddClient_0.Enabled = True
                TxtAddClient_0.Text = "CLIENTE SIN NOMBRE"
                TxtAddClient_0.Focus()
            Else
                CbAddClient_0.Checked = False
                f.Alert("Este numero ya tiene un cliente asignado, Solo podra ingresar una direccion.", f.Alert_NumberExclamacion)
            End If
        Else
            TxtAddClient_0.Text = ""
            TxtAddClient_0.Enabled = False
        End If
    End Sub

    Private Sub CbDireccionAdd_CheckedChanged(sender As Object, e As EventArgs) Handles CbDireccionAdd_0.CheckedChanged
        If CbDireccionAdd_0.Checked Then
            TxtAddDireccion_0.Enabled = True
            TxtAddDireccion_0.Focus()
        Else
            TxtAddDireccion_0.Text = ""
            TxtAddDireccion_0.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        add_ciente_direccion_0()
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

    Private Sub add_ciente_direccion_1()
        If CbAddClient_1.Checked And CbDireccionAdd_1.Checked = False Then
            'Se agrega solo el cliente
            If f.AddClientXpress(TxtAddClient_1, number_1) Then
                TxtClient_1.Text = f.LoadNumberAsistencia4Windows(number_1, Combo_direcciones_1, number_id_1, client_id_1)
                CbAddClient_1.Checked = False
                CbDireccionAdd_1.Checked = False
                TxtAddClient_1.Text = ""
                TxtAddDireccion_1.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        ElseIf CbAddClient_1.Checked = False And CbDireccionAdd_1.Checked Then
            'Se agrega solo la direccion
            If f.AddDireccionXpress(TxtAddDireccion_1, client_id_1) Then
                TxtClient_1.Text = f.LoadNumberAsistencia4Windows(number_1, Combo_direcciones_1, number_id_1, client_id_1)
                CbAddClient_1.Checked = False
                CbDireccionAdd_1.Checked = False
                TxtAddClient_1.Text = ""
                TxtAddDireccion_1.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            End If
        ElseIf CbAddClient_1.Checked And CbDireccionAdd_1.Checked Then
            'Se agrega direccion y cliente
            If f.AddClientXpress(TxtAddClient_1, number_1) Then
                If f.AddDireccionXpress(TxtAddDireccion_1, f.LastIDClients()) Then
                    TxtClient_1.Text = f.LoadNumberAsistencia4Windows(number_1, Combo_direcciones_1, number_id_0, client_id_1)
                    CbAddClient_1.Checked = False
                    CbDireccionAdd_1.Checked = False
                    TxtAddClient_1.Text = ""
                    TxtAddDireccion_1.Text = ""
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                End If
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        End If
    End Sub

    Private Sub add_ciente_direccion_2()
        If CbAddClient_2.Checked And CbDireccionAdd_2.Checked = False Then
            'Se agrega solo el cliente
            If f.AddClientXpress(TxtAddClient_2, number_2) Then
                TxtClient_2.Text = f.LoadNumberAsistencia4Windows(number_2, Combo_direcciones_2, number_id_2, client_id_2)
                CbAddClient_2.Checked = False
                CbDireccionAdd_2.Checked = False
                TxtAddClient_2.Text = ""
                TxtAddDireccion_2.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        ElseIf CbAddClient_2.Checked = False And CbDireccionAdd_2.Checked Then
            'Se agrega solo la direccion
            If f.AddDireccionXpress(TxtAddDireccion_2, client_id_2) Then
                TxtClient_2.Text = f.LoadNumberAsistencia4Windows(number_2, Combo_direcciones_2, number_id_2, client_id_2)
                CbAddClient_2.Checked = False
                CbDireccionAdd_2.Checked = False
                TxtAddClient_2.Text = ""
                TxtAddDireccion_2.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            End If
        ElseIf CbAddClient_2.Checked And CbDireccionAdd_2.Checked Then
            'Se agrega direccion y cliente
            If f.AddClientXpress(TxtAddClient_2, number_2) Then
                If f.AddDireccionXpress(TxtAddDireccion_2, f.LastIDClients()) Then
                    TxtClient_2.Text = f.LoadNumberAsistencia4Windows(number_2, Combo_direcciones_2, number_id_2, client_id_2)
                    CbAddClient_2.Checked = False
                    CbDireccionAdd_2.Checked = False
                    TxtAddClient_2.Text = ""
                    TxtAddDireccion_2.Text = ""
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                End If
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        End If
    End Sub

    Private Sub add_ciente_direccion_3()
        If CbAddClient_3.Checked And CbDireccionAdd_3.Checked = False Then
            'Se agrega solo el cliente
            If f.AddClientXpress(TxtAddClient_3, number_3) Then
                TxtClient_3.Text = f.LoadNumberAsistencia4Windows(number_3, Combo_direcciones_3, number_id_3, client_id_3)
                CbAddClient_3.Checked = False
                CbDireccionAdd_3.Checked = False
                TxtAddClient_3.Text = ""
                TxtAddDireccion_3.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        ElseIf CbAddClient_3.Checked = False And CbDireccionAdd_3.Checked Then
            'Se agrega solo la direccion
            If f.AddDireccionXpress(TxtAddDireccion_3, client_id_3) Then
                TxtClient_3.Text = f.LoadNumberAsistencia4Windows(number_3, Combo_direcciones_3, number_id_3, client_id_3)
                CbAddClient_3.Checked = False
                CbDireccionAdd_3.Checked = False
                TxtAddClient_3.Text = ""
                TxtAddDireccion_3.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            End If
        ElseIf CbAddClient_3.Checked And CbDireccionAdd_3.Checked Then
            'Se agrega direccion y cliente
            If f.AddClientXpress(TxtAddClient_3, number_3) Then
                If f.AddDireccionXpress(TxtAddDireccion_3, f.LastIDClients()) Then
                    TxtClient_3.Text = f.LoadNumberAsistencia4Windows(number_3, Combo_direcciones_3, number_id_3, client_id_3)
                    CbAddClient_3.Checked = False
                    CbDireccionAdd_3.Checked = False
                    TxtAddClient_3.Text = ""
                    TxtAddDireccion_3.Text = ""
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                End If
            Else
                f.Alert("El cliente ya existe", f.Alert_NumberExclamacion)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clean_0()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myValue As String = InputBox("Ingrese comentario", "Observacion")

        If String.IsNullOrEmpty(myValue) = False Then
            observacion_0 = myValue
        End If

    End Sub

    Private Sub TxtAddDireccion_0_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddDireccion_0.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_0()
        End If
    End Sub

    Private Sub TxtAddClient_0_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddClient_0.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_0()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        add_ciente_direccion_1()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myValue As String = InputBox("Ingrese comentario", "Observacion")

        If String.IsNullOrEmpty(myValue) = False Then
            observacion_1 = myValue
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Clean_1()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        add_ciente_direccion_2()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim myValue As String = InputBox("Ingrese comentario", "Observacion")

        If String.IsNullOrEmpty(myValue) = False Then
            observacion_2 = myValue
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Clean_2()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If client_id_3 = 1 Then
            If (String.IsNullOrEmpty(TxtAddClient_3.Text) = False And String.IsNullOrEmpty(TxtAddDireccion_3.Text) = False) Then
                add_ciente_direccion_3()
            Else
                f.Alert("Debe agregar una direccion para clientes nuevos", f.Alert_NumberExclamacion)
            End If
        Else
            add_ciente_direccion_3()
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim myValue As String = InputBox("Ingrese comentario", "Observacion")

        If String.IsNullOrEmpty(myValue) = False Then
            observacion_3 = myValue
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Clean_3()
    End Sub

    Private Sub CbAddClient_1_CheckedChanged(sender As Object, e As EventArgs) Handles CbAddClient_1.CheckedChanged
        If CbAddClient_1.Checked Then
            If client_id_1 = 1 Then
                TxtAddClient_1.Enabled = True
                TxtAddClient_1.Text = "CLIENTE SIN NOMBRE"
                TxtAddClient_1.Focus()
            Else
                CbAddClient_1.Checked = False
                f.Alert("Este numero ya tiene un cliente asignado, Solo podra ingresar una direccion.", f.Alert_NumberExclamacion)
            End If
        Else
            TxtAddClient_1.Text = ""
            TxtAddClient_1.Enabled = False
        End If
    End Sub

    Private Sub CbAddClient_2_CheckedChanged(sender As Object, e As EventArgs) Handles CbAddClient_2.CheckedChanged
        If CbAddClient_2.Checked Then
            If client_id_2 = 1 Then
                TxtAddClient_2.Enabled = True
                TxtAddClient_2.Text = "CLIENTE SIN NOMBRE"
                TxtAddClient_2.Focus()
            Else
                CbAddClient_2.Checked = False
                f.Alert("Este numero ya tiene un cliente asignado, Solo podra ingresar una direccion.", f.Alert_NumberExclamacion)
            End If
        Else
            TxtAddClient_2.Text = ""
            TxtAddClient_2.Enabled = False
        End If
    End Sub

    Private Sub CbAddClient_3_CheckedChanged(sender As Object, e As EventArgs) Handles CbAddClient_3.CheckedChanged
        If CbAddClient_3.Checked Then
            If client_id_3 = 1 Then
                TxtAddClient_3.Enabled = True
                TxtAddClient_3.Text = "CLIENTE SIN NOMBRE"
                TxtAddClient_3.Focus()
            Else
                CbAddClient_3.Checked = False
                f.Alert("Este numero ya tiene un cliente asignado, Solo podra ingresar una direccion.", f.Alert_NumberExclamacion)
            End If
        Else
            TxtAddClient_3.Text = ""
            TxtAddClient_3.Enabled = False
        End If
    End Sub

    Private Sub CbDireccionAdd_1_CheckedChanged(sender As Object, e As EventArgs) Handles CbDireccionAdd_1.CheckedChanged
        If CbDireccionAdd_1.Checked Then
            TxtAddDireccion_1.Enabled = True
            TxtAddDireccion_1.Focus()
        Else
            TxtAddDireccion_1.Text = ""
            TxtAddDireccion_1.Enabled = False
        End If
    End Sub

    Private Sub CbDireccionAdd_2_CheckedChanged(sender As Object, e As EventArgs) Handles CbDireccionAdd_2.CheckedChanged
        If CbDireccionAdd_2.Checked Then
            TxtAddDireccion_2.Enabled = True
            TxtAddDireccion_2.Focus()
        Else
            TxtAddDireccion_2.Text = ""
            TxtAddDireccion_2.Enabled = False
        End If
    End Sub

    Private Sub CbDireccionAdd_3_CheckedChanged(sender As Object, e As EventArgs) Handles CbDireccionAdd_3.CheckedChanged
        If CbDireccionAdd_3.Checked Then
            TxtAddDireccion_3.Enabled = True
            TxtAddDireccion_3.Focus()
        Else
            TxtAddDireccion_3.Text = ""
            TxtAddDireccion_3.Enabled = False
        End If
    End Sub

    Private Sub TxtAddClient_1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddClient_1.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_1()
        End If
    End Sub

    Private Sub TxtAddDireccion_1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddDireccion_1.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_1()
        End If
    End Sub

    Private Sub TxtAddClient_2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddClient_2.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_2()
        End If
    End Sub

    Private Sub TxtAddDireccion_2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddDireccion_2.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_2()
        End If
    End Sub

    Private Sub TxtAddClient_3_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddClient_3.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_3()
        End If
    End Sub

    Private Sub TxtAddDireccion_3_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddDireccion_3.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_ciente_direccion_3()
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Try
            CbAddClient_0.Checked = False
            CbDireccionAdd_0.Checked = False
            TxtAddClient_0.Text = ""
            TxtAddDireccion_0.Text = ""

            Dim Device = "9231200505"

            If (String.IsNullOrEmpty(Device) = False) Then

                TimerCero.Stop()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Combo_direcciones_0.SelectedIndex > 0 Then

                Dim direccion_id = Combo_direcciones_0.SelectedItem.ToString.Substring(Combo_direcciones_0.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

                If f.save_registroAutomaticOne(client_id_0, number_id_0, f_llamada_0, Asitir_llamada_0, DateTime.Now, direccion_id) Then

                    Dim r As DialogResult = MessageBox.Show("Solicitud enviada. Desea finaliza la llamada ?", "Proceso correcto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If r = 6 Then
                        f.finalizarLlamada(0)
                        Clean_0()
                        TimerCero.Start()
                    End If

                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberInformacion)
                End If
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ", En Asistir llamada")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            If Combo_direcciones_1.SelectedIndex > 0 Then

                Dim direccion_id = Combo_direcciones_1.SelectedItem.ToString.Substring(Combo_direcciones_1.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

                If f.save_registroAutomaticOne(client_id_1, number_id_1, f_llamada_1, Asitir_llamada_1, DateTime.Now, direccion_id) Then

                    Dim r As DialogResult = MessageBox.Show("Solicitud enviada. Desea finaliza la llamada ?", "Proceso correcto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If r = 6 Then
                        f.finalizarLlamada(1)
                        Clean_1()
                        TimerUno.Start()
                    End If

                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberInformacion)
                End If
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ", En Asistir llamada")
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            If Combo_direcciones_2.SelectedIndex > 0 Then

                Dim direccion_id = Combo_direcciones_2.SelectedItem.ToString.Substring(Combo_direcciones_2.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

                If f.save_registroAutomaticOne(client_id_2, number_id_2, f_llamada_2, Asitir_llamada_2, DateTime.Now, direccion_id) Then

                    Dim r As DialogResult = MessageBox.Show("Solicitud enviada. Desea finaliza la llamada ?", "Proceso correcto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If r = 6 Then
                        f.finalizarLlamada(2)
                        Clean_2()
                        TimerDos.Start()
                    End If

                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberInformacion)
                End If
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ", En Asistir llamada")
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            If Combo_direcciones_3.SelectedIndex > 0 Then

                Dim direccion_id = Combo_direcciones_3.SelectedItem.ToString.Substring(Combo_direcciones_3.SelectedItem.ToString.IndexOf("[") + 1).Replace("]", "")

                If f.save_registroAutomaticOne(client_id_3, number_id_3, f_llamada_3, Asitir_llamada_3, DateTime.Now, direccion_id) Then

                    Dim r As DialogResult = MessageBox.Show("Solicitud enviada. Desea finaliza la llamada ?", "Proceso correcto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If r = 6 Then
                        f.finalizarLlamada(3)
                        Clean_3()
                        Timertres.Start()
                    End If

                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberInformacion)
                End If
            End If
        Catch ex As Exception
            f.LogError(ex.Message + ", En Asistir llamada")
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        f.finalizarLlamada(0)
        Clean_0()
        TimerCero.Start()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        f.finalizarLlamada(1)
        Clean_1()
        TimerUno.Start()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        f.finalizarLlamada(2)
        Clean_2()
        TimerDos.Start()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        f.finalizarLlamada(3)
        Clean_3()
        Timertres.Start()
    End Sub

    Private Sub use_4_windows_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        control.use_4_windows = False
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs)
        Try
            CbAddClient_0.Checked = False
            CbDireccionAdd_0.Checked = False
            TxtAddClient_0.Text = ""
            TxtAddDireccion_0.Text = ""

            Dim Device = "92312005055"

            If (String.IsNullOrEmpty(Device) = False) Then

                TimerCero.Stop()
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
End Class