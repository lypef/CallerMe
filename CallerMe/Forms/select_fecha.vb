Public Class select_fecha
    Dim f As New functions
    Public logs_omitir As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If logs_omitir Then
            _Action_Omitir()
        Else
            _Action()
        End If

    End Sub

    Private Sub _Action()
        Logs.LoadInifecha(Desde, Hasta)
        f.AddForm_Desktop(Logs, control.Desktop)
        Me.Dispose()
    End Sub

    Private Sub _Action_Omitir()
        If f.ReturnPermission(f.Permission_Access_LOGS) Then
            LogsOmitidas.LoadInifecha(Desde, Hasta)
            f.AddForm_Desktop(LogsOmitidas, control.Desktop)
            Me.Dispose()
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Public Sub ini()
        Desde.Value = DateTime.Now
        Hasta.Value = DateTime.Now
    End Sub

    Private Sub Desde_KeyDown(sender As Object, e As KeyEventArgs) Handles Desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            _Action()
        End If
    End Sub

    Private Sub Hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles Hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            _Action()
        End If
    End Sub
End Class