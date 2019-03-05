Public Class users
    Dim f As New functions

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(Table_users)
        Panel1.BackColor = My.Settings.datagridview_color
        f.BotonesBackGroundBlue(Panel2)
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR)
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)
        f.Button_SetModel(btn_editar, My.Resources.Boton_editar)
    End Sub

    Private Sub users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Public Sub LoadINI()
        f.Users_DataGridViewSet("SELECT * FROM users ORDER by name asc", Table_users)
        functions.user_select = Nothing
        ChecketAll(False)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            LoadINI()
        End If

        If TabControl1.SelectedIndex = 1 Then
            If f.ReturnPermission(f.Permission_users_EDIT) And String.IsNullOrEmpty(functions.user_select) = False Then
                f.values_permisos(
                TxtUsername,
                TxtPassword,
                TxtName,
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
                user_permisos)
                If f.ReturnPermission(f.Permission_users_PERMISOS) = False Then
                    f.Alert("No puede editar los permisos", f.Alert_NumberExclamacion)
                End If
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_NoPermitido + "| Seleccione un usuario", f.Alert_NumberCritical)
            End If
        End If
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
    End Sub

    Private Sub Table_users_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table_users.CellDoubleClick
        If String.IsNullOrEmpty(Table_users.SelectedCells(0).Value) = False Then
            functions.user_select = Table_users.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        editar()
    End Sub

    Private Sub editar()
        If f.ReturnPermission(f.Permission_users_EDIT) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If f.ReturnPermission(f.Permission_users_PERMISOS) Then
            TabControl1.SelectedIndex = 2
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        delete
    End Sub

    Private Sub delete()
        If f.ReturnPermission(f.Permission_users_DELETE) Then
            If (MsgBox("¿Esta seguro de eliminar el usuario # " + functions.user_select + " ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.User_delete() Then
                    LoadINI()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If f.ReturnPermission(f.Permission_users_PERMISOS) Then
            ChecketAll(True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If f.ReturnPermission(f.Permission_users_PERMISOS) Then
            ChecketAll(False)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TxtUsername.Text) = False And String.IsNullOrEmpty(TxtPassword.Text) = False Then
            If f.ReturnPermission(f.Permission_users_PERMISOS) Then
                'Datos y permisos
                If f.User_Update_Values(TxtUsername, TxtPassword, TxtName) Then
                    If f.User_Update_Permisos(
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
                        user_permisos) Then
                        f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                        TabControl1.SelectedIndex = 0
                    Else
                        f.Alert("No se actualizron los permisos", f.Alert_NumberCritical)
                    End If
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            Else
                'Solo datos
                If f.User_Update_Values(TxtUsername, TxtPassword, TxtName) Then
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                    TabControl1.SelectedIndex = 0
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert("Ingrese al menos un nombre de usuario", f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Btn_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add.MouseLeave
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR)
    End Sub

    Private Sub Btn_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_add.MouseEnter
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR_EFECT)
    End Sub

    Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)
    End Sub

    Private Sub btn_delete_MouseEnter(sender As Object, e As EventArgs) Handles btn_delete.MouseEnter
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINARefecto)
    End Sub

    Private Sub btn_editar_MouseLeave(sender As Object, e As EventArgs) Handles btn_editar.MouseLeave
        f.Button_SetModel(btn_editar, My.Resources.Boton_editar)
    End Sub

    Private Sub btn_editar_MouseEnter(sender As Object, e As EventArgs) Handles btn_editar.MouseEnter
        f.Button_SetModel(btn_editar, My.Resources.Boton_editarEfect)
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        If f.ReturnPermission(f.Permission_users_ADD) Then
            f.AddForm_Desktop(usersADD, control.Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Table_users_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table_users.CellMouseClick
        functions.user_select = Table_users.SelectedCells(0).Value
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If functions.user_select > 0 Then
            editar()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If functions.user_select > 0 Then
            delete()
        End If
    End Sub
End Class