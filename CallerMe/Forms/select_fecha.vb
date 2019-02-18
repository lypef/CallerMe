Public Class select_fecha
    Dim f As New functions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _Action()
    End Sub

    Private Sub _Action()
        Logs.LoadInifecha(Desde, Hasta)
        f.AddForm_Desktop(Logs, control.Desktop)
        Me.Dispose()
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