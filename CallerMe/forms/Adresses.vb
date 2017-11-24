Public Class Adresses
    Dim f As New functions

    Private Sub Adresses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = My.Settings.datagridview_color
        f.DataGridView_Model(Table)
        f.DataGridView_Model(DataGridView1)
    End Sub

    Public Sub Loader()
        f.Clients_AdresesDataGridViewSet("SELECT a.id, c.id, c.nombre, a.direccion, a.referencia, a.kms FROM adresses a, clients c where a.client = c.id order by a.id desc", Table)
        TabControl1.SelectedIndex = 0
        functions.Client = 0
        functions.Adress_id = 0
        TxtDireccion.Text = ""
        TxtReferencia.Text = ""
        TxtKilometros.Text = ""
        TxtSearch.Text = ""
    End Sub

    Public Sub Search(ByVal txt As String)
        f.Clients_AdresesDataGridViewSet("SELECT a.id, c.id, c.nombre, a.direccion, a.referencia, a.kms FROM adresses a, clients c where a.client = c.id and a.direccion like '%" + txt + "%' or a.client = c.id and a.referencia like '%" + txt + "%' or a.client = c.id and c.nombre like '%" + txt + "%' or a.client = c.id and c.nombre like '%" + txt + "' order by a.id desc", Table)
        TabControl1.SelectedIndex = 0
        functions.Client = 0
        functions.Adress_id = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loader()
        End If

        If TabControl1.SelectedIndex = 1 Then
            If functions.Client <= 0 Or functions.Adress_id <= 0 Then
                Loader()
            Else
                If f.ReturnPermission(f.Permission_Adresses_edit) Then
                    f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", DataGridView1)
                    f.Client_AdressesLoadUpdate(TxtDireccion, TxtReferencia, TxtKilometros, DataGridView1)
                Else
                    f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.Adress_id = Table.SelectedCells(0).Value
            functions.Client = Table.SelectedCells(1).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Adresses_delete) Then
            functions.OnLoader(loader1)
            functions.Adress_id = Table.SelectedCells(0).Value
            If (MsgBox("¿Esta seguro de eliminar la direccion" + vbNewLine + Table.SelectedCells(3).Value + vbNewLine + "DE: (" + f.ReturnNameClient() + ") ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Clients_AdressDELETE() Then
                    Loader()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
            functions.OffLoader(loader1)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Adresses_edit) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
        End If
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
            If String.IsNullOrEmpty(TxtDireccion.Text) = False And f.IsDecimal(TxtKilometros) Then
                functions.Client = DataGridView1.SelectedCells(0).Value
                functions.OnLoader(PictureBox1)
                If functions.Client_AdressUPDATE(TxtDireccion, TxtReferencia, TxtKilometros) Then
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