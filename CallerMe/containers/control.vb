Imports System.Runtime.InteropServices
Imports System.Text

Public Class control
    Dim f As New functions

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.BotonesBackGroundBlue(MenuPanel)
        loadforms()
        f.forms_setmodel(Me)
        f.Button_SetModel(Button_Clients, My.Resources.Btn_Clientes)
        f.Button_SetModel(Button_Registros, My.Resources.Btn_registros)
        f.Button_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos)
        f.Button_SetModel(Button_Ajustes, My.Resources.Btn_ajustes)

        If (String.IsNullOrEmpty(My.Settings.caller_0_number) = False) Then
            MenuLine0.Text = My.Settings.caller_0_number
        End If


        If (String.IsNullOrEmpty(My.Settings.caller_1_number) = False) Then
            MenuLine1.Text = My.Settings.caller_1_number
        End If

        If (String.IsNullOrEmpty(My.Settings.caller_2_number) = False) Then
            MenuLine2.Text = My.Settings.caller_2_number
        End If

        If (String.IsNullOrEmpty(My.Settings.caller_3_number) = False) Then
            MenuLine3.Text = My.Settings.caller_3_number
        End If

        If (My.Settings.caller_0 = False) Then
            MenuLine0.Enabled = False
        End If

        If (My.Settings.caller_1 = False) Then
            MenuLine1.Enabled = False
        End If

        If (My.Settings.caller_2 = False) Then
            MenuLine2.Enabled = False
        End If

        If (My.Settings.caller_3 = False) Then
            MenuLine3.Enabled = False
        End If

        f.AD101_SetBusy(0, 1)
        f.AD101_SetBusy(1, 1)
        f.AD101_SetBusy(2, 1)
        f.AD101_SetBusy(3, 1)
        Try
            If f.AD101_InitDevice(Handle.ToInt32()) = 0 Then
                Return
            End If
        Catch ex As Exception
            f.Alert(ex.Message, f.Alert_NumberExclamacion)
        End Try

        f.AD101_GetDevice()

        f.AD101_SetLED(0, My.Settings.caller_luz)
        f.AD101_SetLED(1, My.Settings.caller_luz)
        f.AD101_SetLED(2, My.Settings.caller_luz)
        f.AD101_SetLED(3, My.Settings.caller_luz)
        loadTimer()
    End Sub

    Private Sub loadTimer()
        TimerCero.Stop()
        TimerUno.Stop()
        TimerDOS.Stop()
        TimerTres.Stop()

        If (My.Settings.caller_0) Then
            TimerCero.Interval = My.Settings.timer_intervalo
            TimerCero.Start()
        End If

        If (My.Settings.caller_1) Then
            TimerUno.Interval = My.Settings.timer_intervalo
            TimerUno.Start()
        End If

        If (My.Settings.caller_2) Then
            TimerDOS.Interval = My.Settings.timer_intervalo
            TimerDOS.Start()
        End If

        If (My.Settings.caller_3) Then
            TimerTres.Interval = My.Settings.timer_intervalo
            TimerTres.Start()
        End If
    End Sub

    Private Sub loadforms()
        f.AddForm_Desktop(Adresses, Desktop)
        f.AddForm_Desktop(AdressesADD, Desktop)
        f.AddForm_Desktop(Clients, Desktop)
        f.AddForm_Desktop(Clients_add, Desktop)
        f.AddForm_Desktop(Drivers, Desktop)
        f.AddForm_Desktop(DriversADD, Desktop)
        f.AddForm_Desktop(Logs, Desktop)
        f.AddForm_Desktop(LogsADD, Desktop)
        f.AddForm_Desktop(Number_telephone, Desktop)
        f.AddForm_Desktop(Number_telephoneADD, Desktop)
        f.AddForm_Desktop(Parametros, Desktop)
        f.AddForm_Desktop(Properties, Desktop)
        f.AddForm_Desktop(users, Desktop)
        f.AddForm_Desktop(usersADD, Desktop)
        f.AddForm_Desktop(VehicleADD, Desktop)
        f.AddForm_Desktop(Vehicles, Desktop)
        Desktop.Controls.Clear()
    End Sub

    Private Sub Button_Clients_MouseEnter(sender As Object, e As EventArgs) Handles Button_Clients.MouseEnter
        f.Button_Hover_SetModel(Button_Clients, My.Resources.Btn_Clientes_Efecto)
    End Sub

    Private Sub Button_Registros_MouseEnter(sender As Object, e As EventArgs) Handles Button_Registros.MouseEnter
        f.Button_Hover_SetModel(Button_Registros, My.Resources.Btn_registros_efct)
    End Sub

    Private Sub Button_Vehiculos_MouseEnter(sender As Object, e As EventArgs) Handles Button_Vehiculo.MouseEnter
        f.Button_Hover_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos_efct)
    End Sub

    Private Sub Button_ajustes_MouseEnter(sender As Object, e As EventArgs) Handles Button_Ajustes.MouseEnter
        f.Button_Hover_SetModel(Button_Ajustes, My.Resources.Btn_ajustes_efct)
    End Sub

    Private Sub Button_Clients_MouseLeave(sender As Object, e As EventArgs) Handles Button_Clients.MouseLeave
        f.Button_SetModel(Button_Clients, My.Resources.Btn_Clientes)
    End Sub

    Private Sub Button_Registros_MouseLeave(sender As Object, e As EventArgs) Handles Button_Registros.MouseLeave
        f.Button_SetModel(Button_Registros, My.Resources.Btn_registros)
    End Sub

    Private Sub Button_Vehiculos_MouseLeave(sender As Object, e As EventArgs) Handles Button_Vehiculo.MouseLeave
        f.Button_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos)
    End Sub

    Private Sub Button_ajustes_MouseLeave(sender As Object, e As EventArgs) Handles Button_Ajustes.MouseLeave
        f.Button_SetModel(Button_Ajustes, My.Resources.Btn_ajustes)
    End Sub

    Private Sub Button_Clients_Click(sender As Object, e As EventArgs) Handles Button_Clients.Click
        If f.ReturnPermission(f.Permission_Access_Clients) Then
            Clients.LoadClientes()
            f.AddForm_Desktop(Clients, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        f.AddForm_Desktop(Parametros, Desktop)
    End Sub

    Private Sub Button_Ajustes_Click(sender As Object, e As EventArgs) Handles Button_Ajustes.Click
        f.AddForm_Desktop(Parametros, Desktop)
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub control_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Adresses_add) Then
            AdressesADD.Loader()
            f.AddForm_Desktop(AdressesADD, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub NumerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumerosToolStripMenuItem.Click

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Telephone_add) Then
            Number_telephoneADD.Loader()
            f.AddForm_Desktop(Number_telephoneADD, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        If f.ReturnPermission(f.Permission_Clients_add) Then
            f.AddForm_Desktop(Clients_add, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem3.Click
        If f.ReturnPermission(f.Permission_Access_Clients) Then
            Clients.SearchClientes(InputBox("Ingrese algun dato para realizar el filtro de busqueda", "NOMBRE DE LA EMPRESA - USUARIO"))
            f.AddForm_Desktop(Clients, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem2.Click
        If f.ReturnPermission(f.Permission_Access_Clients) Then
            Clients.LoadClientes()
            f.AddForm_Desktop(Clients, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem1.Click
        If f.ReturnPermission(f.Permission_Telephone_Access) Then
            Number_telephone.LoadClientes()
            f.AddForm_Desktop(Number_telephone, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem2.Click
        If f.ReturnPermission(f.Permission_Telephone_Access) Then
            Number_telephone.Search(InputBox("Ingrese algun dato para realizar el filtro de busqueda", "NOMBRE DE LA EMPRESA - USUARIO"))
            f.AddForm_Desktop(Number_telephone, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GenerarReporteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem1.Click
        If f.ReturnPermission(f.Permission_Access_Clients) Then
            Dim d As New DataGridView
            f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", d)
            f.GenReport(d, "REPORTE CLIENTES", True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Access_adress) Then
            Adresses.Loader()
            f.AddForm_Desktop(Adresses, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        If f.ReturnPermission(f.Permission_Access_adress) Then
            Adresses.Search(InputBox("Ingrese algun dato para realizar el filtro de busqueda", "NOMBRE DE LA EMPRESA - USUARIO"))
            f.AddForm_Desktop(Adresses, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        If f.ReturnPermission(f.Permission_Access_adress) Then
            Dim d As New DataGridView
            f.Clients_AdresesDataGridViewSet("SELECT a.id, c.id, c.nombre, a.direccion, a.referencia, a.kms FROM adresses a, clients c where a.client = c.id order by a.id desc", d)
            f.GenReport(d, "REPORTE DIRECCIONES", True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem2.Click
        If f.ReturnPermission(f.Permission_Drivers_ADD) Then
            f.AddForm_Desktop(DriversADD, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem3.Click
        If f.ReturnPermission(f.Permission_Vehicle_ADD) Then
            Dim form As New VehicleADD
            f.AddForm_Desktop(form, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem3.Click
        If f.ReturnPermission(f.Permission_Access_drivers) Then
            Dim form = New Drivers
            form.LoadDrivers()
            f.AddForm_Desktop(form, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Access_drivers) Then
            Drivers.SearchDrivers(InputBox("Ingrese algun dato para realizar el filtro de busqueda", "NOMBRE DE LA EMPRESA - USUARIO"))
            f.AddForm_Desktop(Drivers, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GenerarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Telephone_Access) Then
            Dim d As New DataGridView
            f.Clients_Datagridview_Numbers("SELECT n.id, n.client, c.nombre, n.numero, n.compañia, n.fijo, n.movil FROM telephone_numbers n, clients c where n.client = c.id ORDER by n.id desc", d)
            f.GenReport(d, "REPORTE numeros de CLIENTES", True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GenerarReporteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem2.Click
        If f.ReturnPermission(f.Permission_Access_drivers) Then
            Dim d As New DataGridView
            f.Drivers_DataGridViewSet("SELECT * FROM drivers ORDER by nombre asc", d)
            f.GenReport(d, "REPORTE conductores", True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem4.Click
        If f.ReturnPermission(f.Permission_Access_vehicle) Then
            Dim form = New Vehicles
            form.LoadVehicles()
            f.AddForm_Desktop(form, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Button_Vehiculo_Click(sender As Object, e As EventArgs) Handles Button_Vehiculo.Click
        If f.ReturnPermission(f.Permission_Access_vehicle) Then
            Vehicles.LoadVehicles()
            f.AddForm_Desktop(Vehicles, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Access_vehicle) Then
            Vehicles.Search(InputBox("Ingrese algun dato para realizar el filtro de busqueda", "NOMBRE DE LA EMPRESA - USUARIO"))
            f.AddForm_Desktop(Vehicles, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GenerarReporteToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem3.Click
        If f.ReturnPermission(f.Permission_Access_vehicle) Then
            Dim d As New DataGridView
            f.Vehicles_DataGridViewSet("SELECT v.id, v.modelo, v.placas, d.nombre, v.numero, v.caracteristicas, v.id_gps FROM vehicles v, drivers d WHERE v.driver = d.id ORDER by v.id desc", d)
            f.GenReport(d, "REPORTE conductores y vehiculos", True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        If f.ReturnPermission(f.Permission_Access_properties) Then
            Properties.LoadParameters()
            f.AddForm_Desktop(Properties, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If f.ReturnPermission(f.Permission_Logs_ADD) Then
            Dim form = New LogsADD
            form.LoadIni()
            f.AddForm_Desktop(form, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Button_Registros_Click(sender As Object, e As EventArgs) Handles Button_Registros.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            Logs.LoadIni()
            f.AddForm_Desktop(Logs, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            Logs.search(InputBox("Ingrese algun dato para realizar el filtro de busqueda", "NOMBRE DE LA EMPRESA - USUARIO"))
            f.AddForm_Desktop(Logs, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GenerarReporteToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem4.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            Dim d As New DataGridView
            f.Logs_DataGridViewSet("SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id ORDER BY id desc", d)
            f.GenReport(d, "REPORTE registros", True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub


    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Logs_CLEAN) Then
            If (MsgBox("¿Esta seguro de limpiar todo los registros - TODOS LOS REGISTROS SERAN ELIMINADOS ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Logs_clean() Then
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem6.Click
        If f.ReturnPermission(f.Permission_Access_users) Then
            users.LoadINI()
            f.AddForm_Desktop(users, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_users_ADD) Then
            f.AddForm_Desktop(usersADD, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GenerarReporteToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem5.Click
        If f.ReturnPermission(f.Permission_Access_users) Then
            Dim d As New DataGridView
            f.Users_DataGridViewSet("SELECT id, username, name FROM users ORDER by name asc", d)
            f.GenReport(d, "REPORTE usuarios", True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub TimerDevice0_Tick(sender As Object, e As EventArgs) Handles TimerCero.Tick
        Dim Device0 = f.ComprobarLlamada(0).ToString
        If (String.IsNullOrEmpty(Device0) = False) Then
            TimerCero.Stop()
            Dim form As New LlamadaEntrante
            form.Numero.Text = Device0
            form.caller = 0
            form.f_llamada = DateTime.Now
            form.LoadNumber()
            form.Show()
        End If
    End Sub

    Private Sub OcupadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcupadaToolStripMenuItem.Click
        f.AD101_SetBusy(0, 0)
    End Sub

    Private Sub OcupadaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OcupadaToolStripMenuItem1.Click
        f.AD101_SetBusy(1, 0)
    End Sub

    Private Sub OcupadaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OcupadaToolStripMenuItem2.Click
        f.AD101_SetBusy(2, 0)
    End Sub

    Private Sub OcupadaToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles OcupadaToolStripMenuItem3.Click
        f.AD101_SetBusy(3, 0)
    End Sub

    Private Sub DisponibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisponibleToolStripMenuItem.Click
        f.AD101_SetBusy(0, 1)
        loadTimer()
    End Sub

    Private Sub DisponibleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisponibleToolStripMenuItem1.Click
        f.AD101_SetBusy(1, 1)
        loadTimer()
    End Sub

    Private Sub DisponibleToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DisponibleToolStripMenuItem2.Click
        f.AD101_SetBusy(2, 1)
        loadTimer()
    End Sub

    Private Sub DisponibleToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DisponibleToolStripMenuItem3.Click
        f.AD101_SetBusy(3, 1)
        loadTimer()
    End Sub

    Private Sub TimerUno_Tick(sender As Object, e As EventArgs) Handles TimerUno.Tick
        Dim Caller = 1
        Dim Device0 = f.ComprobarLlamada(Caller).ToString
        If (String.IsNullOrEmpty(Device0) = False) Then
            TimerUno.Stop()
            Dim form As New LlamadaEntrante
            form.Numero.Text = Device0
            form.caller = Caller
            form.f_llamada = DateTime.Now
            form.LoadNumber()
            form.Show()
        End If
    End Sub

    Private Sub TimerDOS_Tick(sender As Object, e As EventArgs) Handles TimerDOS.Tick
        Dim Caller = 2
        Dim Device0 = f.ComprobarLlamada(Caller).ToString
        If (String.IsNullOrEmpty(Device0) = False) Then
            TimerDOS.Stop()
            Dim form As New LlamadaEntrante
            form.Numero.Text = Device0
            form.caller = Caller
            form.f_llamada = DateTime.Now
            form.LoadNumber()
            form.Show()
        End If
    End Sub

    Private Sub TimerTres_Tick(sender As Object, e As EventArgs) Handles TimerTres.Tick
        Dim Caller = 3
        Dim Device0 = f.ComprobarLlamada(Caller).ToString
        If (String.IsNullOrEmpty(Device0) = False) Then
            TimerTres.Stop()
            Dim form As New LlamadaEntrante
            form.Numero.Text = Device0
            form.caller = Caller
            form.f_llamada = DateTime.Now
            form.LoadNumber()
            form.Show()
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem7.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            Logs.LoadIni()
            f.AddForm_Desktop(Logs, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub PorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorFechaToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            select_fecha.ini()
            select_fecha.Show()
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub
End Class
