Public Class VehicleADD
    Dim f As New functions

    Private Sub VehicleADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(DataGridView1)
        f.Drivers_DataGridViewSet("SELECT * FROM drivers ORDER by nombre asc", DataGridView1)
        Panel1.BackColor = My.Settings.datagridview_color
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        Dim txt = TxtSearch.Text
        f.Drivers_DataGridViewSet("SELECT * FROM drivers where nombre LIKE '%" + txt + "%' or correl_electronico LIKE '%" + txt + "%' or licencia_conducir LIKE '%" + txt + "%' ORDER by nombre asc", DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txt = TxtSearch.Text
        f.Drivers_DataGridViewSet("SELECT * FROM drivers where nombre LIKE '%" + txt + "%' or correl_electronico LIKE '%" + txt + "%' or licencia_conducir LIKE '%" + txt + "%' ORDER by nombre asc", DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(TxtModelo.Text) = False Then
                functions.Driver_id = DataGridView1.SelectedCells(0).Value
                functions.OnLoader(PictureBox1)
                If functions.Drivers_ADD(TxtModelo, TxtPlaca, TxtNumero, TxtCaracteristicas, TxtGps) Then
                    f.Alert("Vehiculo agregado con exito", f.Alert_NumberInformacion)
                    functions.TextBox_clean(TxtModelo)
                    functions.TextBox_clean(TxtPlaca)
                    functions.TextBox_clean(TxtNumero)
                    functions.TextBox_clean(TxtCaracteristicas)
                    functions.TextBox_clean(TxtGps)
                    functions.Driver_id = 0
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub VehicleADD_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
    End Sub
End Class