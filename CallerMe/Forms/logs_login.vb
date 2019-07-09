Public Class logs_login
    Dim f As New functions
    Dim title_report As String = ""

    Private Sub logs_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        Me.MaximumSize = New Size(control.Desktop.Width, control.Desktop.Height)
        Me.MinimumSize = New Size(control.Desktop.Width, control.Desktop.Height)
        f.BotonesBackGroundBlue(Panel1)
        f.DataGridView_Model(Table)
        btn_numeros.Text = ""
        btn_delete.Text = ""
    End Sub

    Public Sub LoadInifecha(desde As DateTimePicker, hasta As DateTimePicker)
        'title_report = "REPORTE registros. desde: " + desde.Value.ToShortDateString + ", hasta: " + hasta.Value.ToShortDateString
        'f.Logs_DataGridViewSet_fecha("SELECT r.id, c.nombre, t.numero, d.direccion, u.name, v.modelo, dri.nombre, r.hora_llamada, r.atencion_llamada, r.finaliza_llamada  FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id ORDER BY id desc", Table, desde, hasta)

        Dim _desde = desde.Value.Year & "-" & desde.Value.Month & "-" & desde.Value.Day & " 00:00:00"
        Dim _hasta = hasta.Value.Year & "-" & hasta.Value.Month & "-" & hasta.Value.Day & " 23:59:59"

        title_report = "REPORTE registros. desde: " + desde.Value.ToShortDateString + ", hasta: " + hasta.Value.ToShortDateString
        f.LogsLogin_DataGridViewSet("SELECT l.id, u.name, l.fecha, if (l.login > 0, 'Inicio session','Cerro session') as login FROM logs_login l, users u where l.user_id = u.id and l.fecha >= '" + _desde + "' and l.fecha <= '" + _hasta + "' ORDER BY l.fecha desc", Table)
    End Sub

    Public Sub LoadIni()
        Dim desde = New DateTimePicker
        Dim hasta = New DateTimePicker

        desde.Value = DateTime.Now
        hasta.Value = DateTime.Now

        Dim _desde = desde.Value.Year & "-" & desde.Value.Month & "-" & desde.Value.Day & " 00:00:00"
        Dim _hasta = hasta.Value.Year & "-" & hasta.Value.Month & "-" & hasta.Value.Day & " 23:59:59"

        title_report = "REPORTE registros. desde: " + desde.Value.ToShortDateString + ", hasta: " + hasta.Value.ToShortDateString
        f.LogsLogin_DataGridViewSet("SELECT l.id, u.name, l.fecha, if (l.login > 0, 'Inicio session','Cerro session') as login FROM logs_login l, users u where l.user_id = u.id and l.fecha >= '" + _desde + "' and l.fecha <= '" + _hasta + "' ORDER BY l.fecha desc", Table)
    End Sub

    Private Sub btn_numeros_MouseEnter(sender As Object, e As EventArgs) Handles btn_numeros.MouseEnter
        f.Button_SetModel(btn_numeros, My.Resources.boton_g_pdf_efect)
    End Sub

    Private Sub btn_numeros_MouseLeave(sender As Object, e As EventArgs) Handles btn_numeros.MouseLeave
        f.Button_SetModel(btn_numeros, My.Resources.boton_g_pdf)
    End Sub

    Private Sub btn_delete_MouseEnter(sender As Object, e As EventArgs) Handles btn_delete.MouseEnter
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINARefecto)
    End Sub

    Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)
    End Sub

    Private Sub btn_numeros_Click(sender As Object, e As EventArgs) Handles btn_numeros.Click
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            f.GenReport(Table, title_report, True)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If f.ReturnPermission(f.Permission_Logs_DELETE) And functions.log_id > 0 Then
            If (MsgBox("¿Esta seguro de eliminar el regristro # " + functions.log_id + "?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Logslogin_delete() Then
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

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.log_id = Table.SelectedCells(0).Value
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.log_id = Table.SelectedCells(0).Value
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub
End Class