Public Class Clients_add
    Dim f As functions

    Private Sub Clients_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombre.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            Img.Image = Image.FromFile(file.FileName)

        End If
    End Sub
End Class