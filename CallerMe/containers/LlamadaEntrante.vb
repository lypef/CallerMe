Public Class LlamadaEntrante
    Public caller As Integer
    Public f_llamada As Date

    Dim f As New functions
    Private Sub LlamadaEntrante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.Button_SetModel(btn_omitir, My.Resources.Boton_omitir)
        f.Button_SetModel(btn_asistir, My.Resources.Boton_ASISTIR)
    End Sub

    Private Sub Asistir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub omitir()
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
    End Sub

    Public Sub LoadNumber()
        Client.Text = f.LoadNumber(Numero, Company, Client, Type, ref, PictureBox1)

        If caller = 0 Then
            NumberLine.Text = "Linea: " + control.MenuLine0.Text
        ElseIf caller = 1 Then
            NumberLine.Text = "Linea: " + control.MenuLine1.Text
        ElseIf caller = 2 Then
            NumberLine.Text = "Linea: " + control.MenuLine2.Text
        ElseIf caller = 3 Then
            NumberLine.Text = "Linea: " + control.MenuLine3.Text
        End If

        Timer1.Enabled = True
        Timer1.Interval = Convert.ToInt32(My.Settings.omitir_llamada)
        Timer1.Start()
    End Sub

    Private Sub LlamadaEntrante_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        omitir()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        omitir()
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles btn_asistir.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_omitir.Click
        omitir()
    End Sub

    Private Sub btn_omitir_MouseLeave(sender As Object, e As EventArgs) Handles btn_omitir.MouseLeave
        f.Button_SetModel(btn_omitir, My.Resources.Boton_omitir)
    End Sub

    Private Sub btn_omitir_MouseEnter(sender As Object, e As EventArgs) Handles btn_omitir.MouseEnter
        f.Button_SetModel(btn_omitir, My.Resources.Boton_omitir_efect)
    End Sub

    Private Sub btn_asistir_MouseLeave(sender As Object, e As EventArgs) Handles btn_asistir.MouseLeave
        f.Button_SetModel(btn_asistir, My.Resources.Boton_ASISTIR)
    End Sub

    Private Sub btn_asistir_MouseEnter(sender As Object, e As EventArgs) Handles btn_asistir.MouseEnter
        f.Button_SetModel(btn_asistir, My.Resources.Boton_ASISTIR_EFECT)
    End Sub
End Class