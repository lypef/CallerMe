Public Class Reports

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = System.Drawing.Icon.FromHandle(My.Resources.ico.GetHicon())
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class