Public Class Clientes
    Dim f As New functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (f.Login(Me)) Then
            MsgBox("Todo bien")
        End If

    End Sub
End Class