Public Class Clients_add
    Dim f As New functions

    Private Sub Clients_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombre.Focus()
        TxtFoto.Enabled = False
        CheckImagen.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrEmpty(TxtNombre.Text) = False Then
            functions.OnLoader(Loader)
            If functions.Clients_add(TxtNombre, FechaNaci, TxtCorreoElectronico, TxtFoto, TxtRazonSocial, TxtRfc) Then
                f.Alert("Cliente agregado con exito", f.Alert_NumberInformacion)
                functions.TextBox_clean(TxtNombre)
                functions.TextBox_clean(TxtCorreoElectronico)
                functions.TextBox_clean(TxtFoto)
                functions.TextBox_clean(TxtRazonSocial)
                functions.TextBox_clean(TxtRfc)
                Foto.Image = Nothing
            Else
                f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
            End If
            functions.OffLoader(Loader)
        Else
            f.Alert("Ingrese al menos un nombre", f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click
        If CheckImagen.Checked Then
            Dim tmp = functions.OpenFileSetPictureBox(Foto, Loader)
            If String.IsNullOrEmpty(tmp) = False Then
                TxtFoto.Text = tmp
            End If
        ElseIf CheckCamara.Checked Then
            MsgBox("Tomar foto Con camara No listo")
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TxtReferencia_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TxtImagen_TextChanged(sender As Object, e As EventArgs) Handles TxtFoto.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckImagen.CheckedChanged
        If CheckImagen.Checked = False Then
            CheckCamara.Checked = True
        End If

        If CheckImagen.Checked Then
            CheckCamara.Checked = False
            BtnFoto.Text = "Examinar"
            Foto.Image = Nothing
            TxtFoto.Text = ""
        End If
    End Sub

    Private Sub CheckCamara_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCamara.CheckedChanged
        If CheckCamara.Checked = False Then
            CheckImagen.Checked = True
        End If

        If CheckCamara.Checked Then
            CheckImagen.Checked = False
            BtnFoto.Text = "Tomar foto"
            Foto.Image = Nothing
            TxtFoto.Text = ""
        End If
    End Sub

    Private Sub Clients_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
    End Sub
End Class