Public Class control
    Dim f As New functions

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.Button_SetModel(Button_Clients, My.Resources.Btn_Clientes)
        f.Button_SetModel(Button_Registros, My.Resources.Btn_registros)
        f.Button_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos)
        f.Button_SetModel(Button_Ajustes, My.Resources.Btn_ajustes)
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

    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem2.Click
        If f.ReturnPermission(f.Permission_Drivers_ADD) Then
            f.AddForm_Desktop(DriversADD, Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem3.Click
        If f.ReturnPermission(f.Permission_Access_vehicle) Then
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
End Class
