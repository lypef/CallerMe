Public Class Properties
    Dim f As New functions

    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Public Sub LoadParameters()
        TxtNombre.Text = f.ReturnEmpresa_Parametros(f.Empresa_Nombre)
        TxtDireccion.Text = f.ReturnEmpresa_Parametros(f.Empresa_Direccion)
        TxtRFC.Text = f.ReturnEmpresa_Parametros(f.Empresa_Rfc)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TxtNombre.Text) = False Then
            If functions.Parameters_Update(TxtNombre, TxtDireccion, TxtRFC) Then
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
            Else
                f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
            End If
        Else
            f.Alert("Ingrese al menos un nombre", f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Properties_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
    End Sub
End Class