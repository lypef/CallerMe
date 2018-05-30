Public Class LlamadaEntrante
    Public caller As Integer
    Public f_llamada As Date

    Dim f As New functions
    Private Sub LlamadaEntrante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Private Sub Asistir_Click(sender As Object, e As EventArgs) Handles Asistir.Click
        If caller = 0 Then
            control.TimerCero.Stop()
        ElseIf caller = 1 Then
            control.TimerUno.Stop()
        ElseIf caller = 2 Then
            control.TimerDOS.Stop()
        ElseIf caller = 3 Then
            control.TimerTres.Stop()
        End If

        Dim a As New Asistir_llamada
        a.caller = caller
        a.number = Numero.Text
        a.f_llamada = f_llamada
        a.Asitir_llamada = DateTime.Now
        a.loadvalues()
        a.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.omitir_colgar Then
            If caller = 0 Then
                control.TimerCero.Stop()
                f.finalizarLlamada(caller)
                control.TimerCero.Start()
                Me.Dispose()
            ElseIf caller = 1 Then
                control.TimerUno.Stop()
                f.finalizarLlamada(caller)
                control.TimerUno.Start()
                Me.Dispose()
            ElseIf caller = 2 Then
                control.TimerDOS.Stop()
                f.finalizarLlamada(caller)
                control.TimerDOS.Start()
                Me.Dispose()
            ElseIf caller = 3 Then
                control.TimerTres.Stop()
                f.finalizarLlamada(caller)
                control.TimerTres.Start()
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If


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