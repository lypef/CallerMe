Public Class Use4WindowsSecond

    Dim f As New functions
    Dim sql As String
    Dim existencias = 0

    Public Sub load()
        f.forms_setmodel(Me)
        Me.MaximumSize = New Size(control.Desktop.Width, control.Desktop.Height)
        Me.MinimumSize = New Size(control.Desktop.Width, control.Desktop.Height)
        f.BotonesBackGroundBlue(Panel1)
        f.DataGridView_Model(Table)
        LoadIni()
        f.LastLogs_DataGridViewSet(Table_Logs)
    End Sub

    Public Sub LoadIni()
        sql = "SELECT r.id, c.nombre, t.numero, d.direccion, r.observacion, u.name, r.hora_llamada  FROM registros r, telephone_numbers t, users u, adresses d, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.client = c.id and r.asistido = 0 ORDER BY r.hora_llamada asc"
        f.Asistir_DataGridViewSet(sql, Table)
        f.LastLogs_DataGridViewSet(Table_Logs)
        existencias = f.LogsPendientes()
        Timer.Start()
    End Sub

    Private Sub Use4WindowsSecond_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.log_id = Table.SelectedCells(0).Value
            If f.LogsPendientesAsistido(functions.log_id) Then
                asistir_log()
            Else
                f.Alert("Este registro ya fue atendido", f.Alert_NumberExclamacion)
            End If

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        asistir_log()
    End Sub

    Private Sub asistir_log()
        Dim d = New AsistirLlamadaSecond
        d.loader_values(functions.log_id)
        d.Show()
    End Sub

    Private Sub Table_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellContentDoubleClick
        'If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
        'functions.log_id = Table.SelectedCells(0).Value
        'asistir_log()
        'Else
        'f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If existencias <> f.LogsPendientes() Then
            LoadIni()
        End If
    End Sub
End Class