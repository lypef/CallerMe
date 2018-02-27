Imports System.IO

Public Class Login
    Dim f As New functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login_action()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Directory.Exists(My.Settings.data_url) = False Then
                My.Computer.FileSystem.CreateDirectory(My.Settings.data_url)
            End If

            If Directory.Exists(My.Settings.data_url + functions.Data_clients) = False Then
                My.Computer.FileSystem.CreateDirectory(My.Settings.data_url + functions.Data_clients)
            End If

            If Directory.Exists(My.Settings.data_url + functions.Data_reports) = False Then
                My.Computer.FileSystem.CreateDirectory(My.Settings.data_url + functions.Data_reports)
            End If

            If Directory.Exists(My.Settings.data_url + functions.Data_drivers) = False Then
                My.Computer.FileSystem.CreateDirectory(My.Settings.data_url + functions.Data_drivers)
            End If

        Catch ex As Exception
            f.Alert(ex.Message, f.Alert_NumberCritical)
        End Try

        f.forms_setmodel(Me)
        TxtUsername.Text = My.Settings.login_username
        TxtPassword.Text = My.Settings.login_password
        If TxtPassword.Text.Length > 0 Then
            TxtPassword.Focus()
        Else
            TxtUsername.Focus()
        End If
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
        If (My.Settings.valid) Then
            If (f.Login(TxtUsername, TxtPassword)) Then

                If CheckBoxCred.Checked Then
                    My.Settings.login_username = TxtUsername.Text
                    My.Settings.login_password = TxtPassword.Text
                End If

                Me.Visible = False
                control.Show()
            Else
                f.Alert("Datos erroneos", f.Alert_NumberCritical)
            End If
        Else
            Me.Visible = False
            Dim form As New validate
            form.Show()
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

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class