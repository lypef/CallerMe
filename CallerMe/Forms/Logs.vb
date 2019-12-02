Public Class Logs
    Dim f As New functions
    Dim title_report As String
    Dim pagina As Integer = 0
    Dim pagina_total As Integer = 0
    Dim sql As String

    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        Me.MaximumSize = New Size(control.Desktop.Width, control.Desktop.Height)
        Me.MinimumSize = New Size(control.Desktop.Width, control.Desktop.Height)
        f.BotonesBackGroundBlue(Panel1)
        f.DataGridView_Model(Table)
        Btn_add.Text = ""
        btn_numeros.Text = ""
        btn_editar.Text = ""
        btn_delete.Text = ""
    End Sub

    Public Sub LoadInifecha(desde As DateTimePicker, hasta As DateTimePicker)
        'title_report = "REPORTE registros. desde: " + desde.Value.ToShortDateString + ", hasta: " + hasta.Value.ToShortDateString
        'f.Logs_DataGridViewSet_fecha("SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id ORDER BY id desc", Table, desde, hasta)

        Dim _desde = desde.Value.Year & "-" & desde.Value.Month & "-" & desde.Value.Day & " 00:00:00"
        Dim _hasta = hasta.Value.Year & "-" & hasta.Value.Month & "-" & hasta.Value.Day & " 23:59:59"

        pagina = 0
        sql = "SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and  r.hora_llamada >= '" + _desde + "' and r.hora_llamada <= '" + _hasta + "' ORDER BY id desc "
        pagina_total = CInt(f.ReturnLogsTotal("SELECT  count(r.id) FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and  r.hora_llamada >= '" + _desde + "' and r.hora_llamada <= '" + _hasta + "' ORDER BY id desc") / 30)
        f.Logs_DataGridViewSet(sql + "LIMIT 0, 30", Table)
        title_report = "REPORTE registros. desde: " + desde.Value.ToShortDateString + ", hasta: " + hasta.Value.ToShortDateString + " | PAGINA: " + (pagina + 1).ToString + "   DE: " + pagina_total.ToString
    End Sub

    Public Sub LoadIni()
        pagina = 0
        Dim desde = New DateTimePicker
        Dim hasta = New DateTimePicker

        desde.Value = DateTime.Now
        hasta.Value = DateTime.Now

        Dim _desde = desde.Value.Year & "-" & desde.Value.Month & "-" & desde.Value.Day & " 00:00:00"
        Dim _hasta = hasta.Value.Year & "-" & hasta.Value.Month & "-" & hasta.Value.Day & " 23:59:59"

        sql = "SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and  r.hora_llamada >= '" + _desde + "' and r.hora_llamada <= '" + _hasta + "' ORDER BY r.id desc "
        pagina_total = CInt(f.ReturnLogsTotal("SELECT count(r.id) FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and  r.hora_llamada >= '" + _desde + "' and r.hora_llamada <= '" + _hasta + "' ORDER BY r.id desc") / 30)
        f.Logs_DataGridViewSet(sql + "LIMIT 0, 30", Table)
        title_report = "REPORTE registros. desde: " + desde.Value.ToShortDateString + ", hasta: " + hasta.Value.ToShortDateString + " | PAGINA: " + (pagina + 1).ToString + "   DE: " + pagina_total.ToString
    End Sub

    Public Sub LoadLogs_ChangPag()
        Dim pagina_ini As Integer

        If pagina < 1 Then
            pagina_ini = 0
            pagina = 0
        Else
            pagina_ini = (pagina * 30) - 1
        End If

        f.Logs_DataGridViewSet(sql + "LIMIT " + pagina_ini.ToString + ", 30", Table)
    End Sub

    Public Sub search(ByVal txt As String)
        title_report = "REPORTE registros. busqueda: " + txt
        f.Logs_DataGridViewSet("SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and c.nombre like '%" + txt + "%' or r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and t.numero like '%" + txt + "%' or r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and d.direccion like '%" + txt + "%' or r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and u.name like '%" + txt + "%' or r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and v.modelo like '%" + txt + "%' or r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and dri.nombre like '%" + txt + "%' ORDER BY id desc", Table)
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.log_id = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Logs_DELETE) Then
            If (MsgBox("¿Esta seguro de eliminar el regristro # " + functions.log_id + "?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Logs_delete() Then
                    LoadIni()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
        functions.log_id = 0
    End Sub

    Private Sub GenerarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox(":D")
    End Sub

    Private Sub ComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobanteToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            Dim d As New DataGridView
            f.Logs_DataGridViewSet("SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and r.id = " + functions.log_id + " ORDER BY r.id desc", d)
            f.GenReport(d, "REPORTE, registro folio: " + functions.log_id, True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If f.ReturnPermission(f.Permission_Logs_DELETE) And functions.log_id > 0 Then
            If (MsgBox("¿Esta seguro de eliminar el regristro # " + functions.log_id + "?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Logs_delete() Then
                    LoadIni()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
        functions.log_id = 0
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        If f.ReturnPermission(f.Permission_Logs_ADD) Then
            Dim form = New LogsADD
            form.LoadIni()
            f.AddForm_Desktop(form, control.Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Btn_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_add.MouseEnter
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR_EFECT)
    End Sub

    Private Sub Btn_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add.MouseLeave
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR)
    End Sub

    Private Sub btn_numeros_MouseEnter(sender As Object, e As EventArgs) Handles btn_numeros.MouseEnter
        f.Button_SetModel(btn_numeros, My.Resources.boton_g_pdf_efect)
    End Sub

    Private Sub btn_numeros_MouseLeave(sender As Object, e As EventArgs) Handles btn_numeros.MouseLeave
        f.Button_SetModel(btn_numeros, My.Resources.boton_g_pdf)
    End Sub

    Private Sub btn_numeros_Click(sender As Object, e As EventArgs) Handles btn_numeros.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            f.GenReport(Table, title_report, True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.log_id = Table.SelectedCells(0).Value
        End If
    End Sub

    Private Sub btn_delete_MouseEnter(sender As Object, e As EventArgs) Handles btn_delete.MouseEnter
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINARefecto)
    End Sub

    Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)
    End Sub

    Private Sub btn_editar_MouseEnter(sender As Object, e As EventArgs) Handles btn_editar.MouseEnter
        f.Button_SetModel(btn_editar, My.Resources.boton_ticket_efec)
    End Sub

    Private Sub btn_editar_MouseLeave(sender As Object, e As EventArgs) Handles btn_editar.MouseLeave
        f.Button_SetModel(btn_editar, My.Resources.boton_ticket)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) And functions.log_id > 0 Then
            Dim d As New DataGridView
            f.Logs_DataGridViewSet("SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and r.id = " + functions.log_id + " ORDER BY r.id desc", d)
            f.GenReport(d, "REPORTE, registro folio: " + functions.log_id, True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        pagina = pagina + 1
        LoadLogs_ChangPag()
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        pagina = pagina - 1
        LoadLogs_ChangPag()
    End Sub
End Class