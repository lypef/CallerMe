Public Class Login
    Dim f As New functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login_action()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        TxtUsername.Focus()
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login_action()
        End If

        If e.KeyCode = Keys.F12 Then
            Me.Visible = False
            f.OpenConfig()
        End If

    End Sub

    Private Sub login_action()
        If (f.Login(TxtUsername, TxtPassword)) Then
            Me.Visible = False
            Contenedor.Show()
        Else
            f.Alert("Datos erroneos")
        End If
    End Sub

    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsername.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.Visible = False
            f.OpenConfig()
        End If

        If e.KeyCode = Keys.Enter Then
            TxtPassword.Focus()
        End If
    End Sub

End Class