Public Class AdressesADD
    Dim f As New functions

    Private Sub AdressesADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(DataGridView1)
        Panel1.BackColor = My.Settings.datagridview_color
    End Sub

    Public Sub Loader()
        f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", DataGridView1)
        functions.Client = 0
        TxtNombre.Text = ""
        TxtReferencia.Text = ""
        TxtKilometros.Text = ""
        TxtSearch.Text = ""
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + TxtSearch.Text + "%' or correo_electronico LIKE '%" + TxtSearch.Text + "%' or rfc LIKE '%" + TxtSearch.Text + "%' OR razon_social LIKE '%" + TxtSearch.Text + "%' ORDER by nombre asc", DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + TxtSearch.Text + "%' or correo_electronico LIKE '%" + TxtSearch.Text + "%' or rfc LIKE '%" + TxtSearch.Text + "%' OR razon_social LIKE '%" + TxtSearch.Text + "%' ORDER by nombre asc", DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtKilometros.Text = TxtKilometros.Text.Replace(",", ".")
        Try
            If String.IsNullOrEmpty(TxtNombre.Text) = False And f.IsDecimal(TxtKilometros) Then
                functions.Client = DataGridView1.SelectedCells(0).Value
                functions.OnLoader(PictureBox1)
                If functions.Clients_AdressADD(TxtNombre, TxtReferencia, TxtKilometros) Then
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                    Loader()
                Else
                    f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
                End If
                functions.OffLoader(PictureBox1)
            Else
                f.Alert("Ingrese al menos una direccion | Verifique que los kilometros sean solo numeros", f.Alert_NumberCritical)
            End If
        Catch ex As Exception
            f.Alert(ex.Message, f.Alert_NumberCritical)
        End Try
    End Sub
End Class