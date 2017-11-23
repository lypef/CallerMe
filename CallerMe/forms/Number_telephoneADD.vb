Public Class Number_telephoneADD
    Dim f As New functions

    Private Sub Telephone_numbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(DataGridView1)
        Panel1.BackColor = My.Settings.datagridview_color
        TxtMovil.Checked = true
    End Sub

    Public Sub Loader()
        f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", DataGridView1)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + TxtSearch.Text + "%' or correo_electronico LIKE '%" + TxtSearch.Text + "%' or rfc LIKE '%" + TxtSearch.Text + "%' OR razon_social LIKE '%" + TxtSearch.Text + "%' ORDER by nombre asc", DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + TxtSearch.Text + "%' or correo_electronico LIKE '%" + TxtSearch.Text + "%' or rfc LIKE '%" + TxtSearch.Text + "%' OR razon_social LIKE '%" + TxtSearch.Text + "%' ORDER by nombre asc", DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(TxtNumber.Text) = False Then
                functions.Client = DataGridView1.SelectedCells(0).Value
                functions.OnLoader(PictureBox1)
                If functions.Clients_NumberADD(TxtNumber, TxtCompañia, TxtMovil, TxtFijo, TxtRef) Then
                    f.Alert("Numero agregado con exito", f.Alert_NumberInformacion)
                    functions.TextBox_clean(TxtNumber)
                    functions.TextBox_clean(TxtCompañia)
                    functions.Client = 0
                Else
                    f.Alert("Error, verifique sus datos, es posible que el numero ya exista", f.Alert_NumberCritical)
                End If
                functions.OffLoader(PictureBox1)
            Else
                f.Alert("Ingrese al menos un nombre", f.Alert_NumberCritical)
            End If
        Catch ex As Exception
            f.Alert(ex.Message, f.Alert_NumberCritical)
        End Try
    End Sub
End Class