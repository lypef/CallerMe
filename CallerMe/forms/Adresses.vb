Public Class Adresses
    Dim f As New functions

    Private Sub Adresses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(Table)
    End Sub

    Public Sub Loader()
        f.Clients_AdresesDataGridViewSet("SELECT a.id, c.id, c.nombre, a.direccion, a.referencia, a.kms FROM adresses a, clients c where a.client = c.id order by a.id desc", Table)
        TabControl1.SelectedIndex = 0
        functions.Client = 0
    End Sub

    Public Sub Search(ByVal txt As String)
        f.Clients_AdresesDataGridViewSet("SELECT a.id, c.id, c.nombre, a.direccion, a.referencia, a.kms FROM adresses a, clients c where a.client = c.id and a.direccion like '%" + txt + "%' or a.client = c.id and a.referencia like '%" + txt + "%' or a.client = c.id and c.nombre like '%" + txt + "%' or a.client = c.id and c.nombre like '%" + txt + "' order by a.id desc", Table)
        functions.Client = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loader()
        End If

        If TabControl1.SelectedIndex = 1 Then
            If functions.Client <= 0 Then
                Loader()
            Else
                MsgBox("Editar")
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
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
End Class