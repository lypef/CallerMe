Imports System.IO

Public NotInheritable Class AlertContainer

    Dim f As New functions

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = f.ReturnEmpresa_Parametros(f.Empresa_Nombre)
        Icon = System.Drawing.Icon.FromHandle(My.Resources.ico.GetHicon())
        TextBoxMensaje.Font = My.Settings.font_alertas
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub AlertContainer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Public Sub style(style As Integer)
        If (style = f.Alert_NumberInformacion) Then
            PictureBox1.Image = My.Resources.information_128
        ElseIf (style = f.Alert_NumberCritical) Then
            PictureBox1.Image = My.Resources.critical_128
        ElseIf (style = f.Alert_NumberExclamacion) Then
            PictureBox1.Image = My.Resources.exclamacion_128
        End If
    End Sub

    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Me.Dispose()
    End Sub
End Class
