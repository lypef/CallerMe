Public Class LlamadaEntrante
    Public caller As Integer

    Dim f As New functions
    Private Sub LlamadaEntrante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Private Sub Asistir_Click(sender As Object, e As EventArgs) Handles Asistir.Click
        Clients.LoadClientes()
        f.AddForm_Desktop(Clients, control.Desktop)
        control.Timer0.Stop()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f.AD101_SetBusy(caller, 0)
        System.Threading.Thread.Sleep(250)
        f.AD101_SetBusy(caller, 1)
        control.Timer0.Stop()
        control.Timer0.Start()
        Me.Dispose()
    End Sub

    Public Sub LoadNumber()
        Client.Text = f.LoadNumber(Numero, Company, Client, Type, ref, PictureBox1)
        If caller = 0 Then
            NumberLine.Text = "Linea: " + My.Settings.caller_0_number
        ElseIf caller = 1 Then
            NumberLine.Text = "Linea: " + My.Settings.caller_1_number
        ElseIf caller = 2 Then
            NumberLine.Text = "Linea: " + My.Settings.caller_2_number
        ElseIf caller = 3 Then
            NumberLine.Text = "Linea: " + My.Settings.caller_3_number
        End If
    End Sub
End Class