Public Class Login
    Dim f As New functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (f.Login()) Then
            Contenedor.Show()
        End If

    End Sub

End Class