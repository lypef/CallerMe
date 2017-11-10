Public Class Parametros
    Dim f As New functions

    Private Sub Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(My.Settings.Properties("puerto_db").DefaultValue)
    End Sub
End Class