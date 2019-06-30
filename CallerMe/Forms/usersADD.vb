Public Class usersADD
    Dim f As New functions

    Private Sub usersADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        Panel1.BackColor = My.Settings.datagridview_color
        Checketfont(My.Settings.datagridview_font)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ChecketAll(True)
    End Sub

    Private Sub ChecketAll(v As Boolean)
        acces_clients.Checked = v
        acces_numbersTelephone.Checked = v
        acces_adresses.Checked = v
        acces_drivers.Checked = v
        acces_vehicles.Checked = v
        acces_logs.Checked = v
        clients_add.Checked = v
        clients_edit.Checked = v
        clients_delete.Checked = v
        adresses_add.Checked = v
        adresses_edit.Checked = v
        adresses_delete.Checked = v
        telephone_add.Checked = v
        telephone_edit.Checked = v
        telephone_delete.Checked = v
        drivers_add.Checked = v
        drivers_edit.Checked = v
        drivers_delete.Checked = v
        vehicles_add.Checked = v
        vehicles_edit.Checked = v
        vehicles_delete.Checked = v
        properties.Checked = v
        logs_add.Checked = v
        logs_delete.Checked = v
        logs_clean.Checked = v
        user_access.Checked = v
        user_add.Checked = v
        user_edit.Checked = v
        user_delete.Checked = v
        user_permisos.Checked = v
        Delete_omitido.Checked = v
        Close_software.Checked = v
    End Sub

    Private Sub Checketfont(v As Font)
        acces_clients.Font = v
        acces_numbersTelephone.Font = v
        acces_adresses.Font = v
        acces_drivers.Font = v
        acces_vehicles.Font = v
        acces_logs.Font = v
        clients_add.Font = v
        clients_edit.Font = v
        clients_delete.Font = v
        adresses_add.Font = v
        adresses_edit.Font = v
        adresses_delete.Font = v
        telephone_add.Font = v
        telephone_edit.Font = v
        telephone_delete.Font = v
        drivers_add.Font = v
        drivers_edit.Font = v
        drivers_delete.Font = v
        vehicles_add.Font = v
        vehicles_edit.Font = v
        vehicles_delete.Font = v
        properties.Font = v
        logs_add.Font = v
        logs_delete.Font = v
        logs_clean.Font = v
        user_access.Font = v
        user_add.Font = v
        user_edit.Font = v
        user_delete.Font = v
        user_permisos.Font = v
        Delete_omitido.Font = v
        Close_software.Font = v
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ChecketAll(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TxtUsername.Text) = False And String.IsNullOrEmpty(TxtPassword.Text) = False Then
            If f.Users_ADD_Permisos(
                f.Users_ADD(TxtUsername, TxtPassword, TxtName),
                acces_clients,
                acces_numbersTelephone,
                acces_adresses,
                acces_drivers,
                acces_vehicles,
                acces_logs,
                clients_add,
                clients_edit,
                clients_delete,
                adresses_add,
                adresses_edit,
                adresses_delete,
                telephone_add,
                telephone_edit,
                telephone_delete,
                drivers_add,
                drivers_edit,
                drivers_delete,
                vehicles_add,
                vehicles_edit,
                vehicles_delete,
                properties,
                logs_add,
                logs_delete,
                logs_clean,
                user_access,
                user_add,
                user_edit,
                user_delete,
                user_permisos,
                Delete_omitido,
                Close_software) Then
                ChecketAll(False)
                TxtName.Text = ""
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            Else
                f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberExclamacion)
            End If
        Else
                f.Alert("Ingrese al menos un nombre de usuario", f.Alert_NumberCritical)
        End If
    End Sub
End Class