Public Class control
    Dim f As New functions

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadforms()
        f.forms_setmodel(Me)
        f.Button_SetModel(Button_Clients, My.Resources.Btn_Clientes)
        f.Button_SetModel(Button_Registros, My.Resources.Btn_registros)
        f.Button_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos)
        f.Button_SetModel(Button_Ajustes, My.Resources.Btn_ajustes)

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
            f.GenReport(d, f.GenReportClients)
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
            f.GenReport(d, f.GenReportClients_DIRECCIONES)
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
            f.AddForm_Desktop(VehicleADD, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem3.Click
        If f.ReturnPermission(f.Permission_Access_drivers) Then
            Drivers.LoadDrivers()
            f.AddForm_Desktop(Drivers, Desktop)
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
            f.GenReport(d, f.GenReportClients_NUMEROS)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GenerarReporteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem2.Click
        If f.ReturnPermission(f.Permission_Access_drivers) Then
            Dim d As New DataGridView
            f.Drivers_DataGridViewSet("SELECT * FROM drivers ORDER by nombre asc", d)
            f.GenReport(d, f.GenReportClients_DRIVERS)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem4.Click
        If f.ReturnPermission(f.Permission_Access_vehicle) Then
            Vehicles.LoadVehicles()
            f.AddForm_Desktop(Vehicles, Desktop)
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
            f.Vehicles_DataGridViewSet("SELECT v.id, v.modelo, v.placas, d.nombre, v.numero, v.caracteristicas FROM vehicles v, drivers d WHERE v.driver = d.id ORDER by v.id desc", d)
            f.GenReport(d, f.GenReportDrivers_Vehicle)
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
            LogsADD.LoadIni()
            f.AddForm_Desktop(LogsADD, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub GestionarToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem5.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            Logs.LoadIni()
            f.AddForm_Desktop(Logs, Desktop)
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
            f.GenReport(d, f.GenReportLOGS)
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
            f.GenReport(d, f.GenReport_users)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub
End Class
