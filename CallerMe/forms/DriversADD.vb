Public Class DriversADD
    Dim f As New functions

    Private Sub DriversADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombre.Focus()
        TxtFoto.Enabled = False
        CheckImagen.Checked = True
    End Sub

    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click
        If CheckImagen.Checked Then
            Dim tmp = functions.OpenFileSetPictureBox(Foto, Loader)
            If String.IsNullOrEmpty(tmp) = False Then
                TxtFoto.Text = tmp
            End If
        ElseIf CheckCamara.Checked Then
            MsgBox("Tomar foto Con camara No listo")
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrEmpty(TxtNombre.Text) = False Then
            functions.OnLoader(Loader)
            If functions.Drivers_add(TxtNombre, FechaNaci, TxtCorreoElectronico, TxtFoto, TxtRazonSocial, TxtTelefono) Then
                f.Alert("Conductor agregado con exito", f.Alert_NumberInformacion)
                functions.TextBox_clean(TxtNombre)
                functions.TextBox_clean(TxtCorreoElectronico)
                functions.TextBox_clean(TxtFoto)
                functions.TextBox_clean(TxtRazonSocial)
                Foto.Image = Nothing
            Else
                f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
            End If
            functions.OffLoader(Loader)
        Else
            f.Alert("Ingrese al menos un nombre", f.Alert_NumberCritical)
        End If
    End Sub

End Class