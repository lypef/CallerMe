Public Class update_log

    Dim f As New functions

    Public Shared id As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If f.Update_log(TxtVehiculos, TxtConductor, id) Then
            f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            Logs.LoadIni()
            Me.Dispose()
        Else
            f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
        End If
    End Sub
End Class