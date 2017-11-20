Public Class Clients
    Dim f As New functions

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(Table)
        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height - Loader.Height
        LoadClientes()
    End Sub

    Public Sub LoadClientes()
        f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", Table)
        TabControl1.SelectedIndex = 0
    End Sub

    Public Sub SearchClientes(ByVal txt As String)
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + txt + "%' or direccion LIKE '%" + txt + "%' or correo_electronico LIKE '%" + txt + "%' or rfc LIKE '%" + txt + "%' OR razon_social LIKE '%" + txt + "%' ORDER by nombre asc", Table)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.Client = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Clients_edit) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            If f.ReturnPermission(f.Permission_Clients_edit) Then
                MsgBox("Cargar valores")
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
            End If
        End If

        If TabControl1.SelectedIndex = 2 Then
            MsgBox("Cargar valores movimientos")
        End If

    End Sub

    Private Sub VerMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerMovimientosToolStripMenuItem.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        functions.OnLoader(Loader)
        If (MsgBox("¿Esta seguro de eliminar el cliente # " + functions.Client + vbNewLine + "(" + f.ReturnNameClient() + ") ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
            If functions.Clients_delete() Then
                f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", Table)
                f.Alert(f.Alert_procesofinalizadoOK, f.Alert_NumberInformacion)
            Else
                f.Alert(f.Alert_procesofinalizadoNO, f.Alert_NumberCritical)
            End If
        End If
        functions.OffLoader(Loader)
    End Sub
End Class