Public Class validate
    Dim f As New functions
    Private Sub validate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If f.ValidarLicence(TextBox1) Then
            f.Alert("Licencia activada con exito.", f.Alert_NumberInformacion)
            My.Settings.valid = True
            Login.Visible = True
            Me.Dispose()
        Else
            f.Alert("Licencia no valida, contactenos.", f.Alert_NumberCritical)
            Button1.Enabled = True
        End If
    End Sub
End Class