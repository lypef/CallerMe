Public Class Number_telephone
    Dim f As New functions

    Private Sub Number_telephone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.DataGridView_Model(Tabla)
        f.DataGridView_Model(Table_EditClients)
        Panel1.BackColor = My.Settings.datagridview_color
        f.BotonesBackGroundBlue(Panel3)
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR)
        f.Button_SetModel(btn_editar, My.Resources.Boton_editar)
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)
    End Sub

    Public Sub LoadClientes()
        f.Clients_Datagridview_Numbers("SELECT n.id, n.client, c.nombre, n.numero, n.compañia, n.fijo, n.movil FROM telephone_numbers n, clients c where n.client = c.id ORDER by n.id desc", Tabla)
        functions.Number_id = 0
        functions.Client = 0
        TabControl1.SelectedIndex = 0
    End Sub

    Public Sub Search(ByVal txt As String)
        f.Clients_Datagridview_Numbers("SELECT n.id, n.client, c.nombre, n.numero, n.compañia, n.fijo, n.movil FROM telephone_numbers n, clients c where n.client = c.id and c.nombre LIKE '%" + txt + "%' or n.client = c.id and n.compañia LIKE '%" + txt + "%' or n.client = c.id and n.numero LIKE '%" + txt + "%' ORDER by n.id desc", Tabla)
        functions.Number_id = 0
        functions.Client = 0
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Tabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellDoubleClick
        If String.IsNullOrEmpty(Tabla.SelectedCells(0).Value) = False Then
            functions.Number_id = Tabla.SelectedCells(0).Value
            functions.Client = Tabla.SelectedCells(1).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        delete()
    End Sub

    Private Sub delete()
        functions.OnLoader(control.Loader)
        If f.ReturnPermission(f.Permission_Telephone_delete) Then
            If (MsgBox("¿Eliminar numero: [ " + Tabla.SelectedCells(2).Value + " ]" + vbNewLine + "Cliente: (" + Tabla.SelectedCells(1).Value + ") ?" + vbNewLine + "Tenga en cuenta que si se elimina el numero puede causar anomalias en los registros", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Clients_NumberDelete(Tabla.SelectedCells(0).Value) Then
                    Me.LoadClientes()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
        functions.OffLoader(control.Loader)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            LoadClientes()
        End If

        If TabControl1.SelectedIndex = 1 Then
            If functions.Number_id > 0 Then
                f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", Table_EditClients)
                f.Client_NumberLoadUpdate(TxtNumber, TxtCompañia, TxtRef, TxtMovil, TxtFijo, Table_EditClients)
            Else
                TabControl1.SelectedIndex = 0
            End If
        End If

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Telephone_edit) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + TxtSearch.Text + "%' or correo_electronico LIKE '%" + TxtSearch.Text + "%' or rfc LIKE '%" + TxtSearch.Text + "%' OR razon_social LIKE '%" + TxtSearch.Text + "%' ORDER by nombre asc", Table_EditClients)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + TxtSearch.Text + "%' or correo_electronico LIKE '%" + TxtSearch.Text + "%' or rfc LIKE '%" + TxtSearch.Text + "%' OR razon_social LIKE '%" + TxtSearch.Text + "%' ORDER by nombre asc", Table_EditClients)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TxtNumber.Text) = False And f.ReturnPermission(f.Permission_Telephone_edit) Then
            functions.OnLoader(LoaderEdit)
            functions.Client = Table_EditClients.SelectedCells(0).Value
            If functions.Clients_NumberUPDATE(TxtNumber, TxtCompañia, TxtMovil, TxtFijo, TxtRef) Then
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                TabControl1.SelectedIndex = 0
            Else
                f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
            End If
            functions.OffLoader(LoaderEdit)
        Else
            f.Alert("Ingrese al menos un numero | No tiene permiso parea editar numeros", f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Number_telephone_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btn_numeros_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_editar_MouseLeave(sender As Object, e As EventArgs) Handles btn_editar.MouseLeave
        f.Button_SetModel(btn_editar, My.Resources.Boton_editar)
    End Sub

    Private Sub btn_editar_MouseEnter(sender As Object, e As EventArgs) Handles btn_editar.MouseEnter
        f.Button_SetModel(btn_editar, My.Resources.Boton_editarEfect)
    End Sub

    Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)
    End Sub

    Private Sub btn_delete_MouseEnter(sender As Object, e As EventArgs) Handles btn_delete.MouseEnter
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINARefecto)
    End Sub

    Private Sub Tabla_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Tabla.CellMouseClick
        functions.Number_id = Tabla.SelectedCells(0).Value
        functions.Client = Tabla.SelectedCells(1).Value
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If functions.Number_id > 0 And functions.Client > 0 Then
            If f.ReturnPermission(f.Permission_Telephone_edit) Then
                TabControl1.SelectedIndex = 1
            Else
                f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If functions.Number_id > 0 And functions.Client > 0 Then
            delete()
        End If
    End Sub

    Private Sub Btn_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add.MouseLeave
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR)
    End Sub

    Private Sub Btn_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_add.MouseEnter
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR_EFECT)
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        If f.ReturnPermission(f.Permission_Telephone_add) Then
            Number_telephoneADD.Loader()
            f.AddForm_Desktop(Number_telephoneADD, control.Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub
End Class