Public Class Login
    Dim f As New functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (f.Login(Me)) Then
            Contenedor.Show()
        Else
            f.Alert("Datos erroneos")
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            If (f.Login(Me)) Then
                Contenedor.Show()
            Else
                f.Alert("Datos erroneos")
            End If

        End If
    End Sub

End Class