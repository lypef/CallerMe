Public Class Vehicles
    Dim f As New functions

    Private Sub Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(Table)
        f.DataGridView_Model(Table_drivers)
        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height - Loader.Height
        Panel1.BackColor = My.Settings.datagridview_color
        TabControl1.SelectedIndex = 0
        functions.Vehicle_id = 0
        functions.Driver_id = 0
    End Sub

    Public Sub LoadVehicles()
        f.Vehicles_DataGridViewSet("SELECT v.id, v.modelo, v.placas, d.nombre, v.numero, v.caracteristicas, v.id_gps FROM vehicles v, drivers d WHERE v.driver = d.id ORDER by v.id desc", Table)
        f.Drivers_DataGridViewSet("SELECT * FROM drivers ORDER by nombre asc", Table_drivers)
        TabControl1.SelectedIndex = 0
        functions.Vehicle_id = 0
        functions.Driver_id = 0
    End Sub

    Public Sub Search(ByVal txt As String)
        f.Vehicles_DataGridViewSet("SELECT v.id, v.modelo, v.placas, d.nombre, v.numero, v.caracteristicas FROM vehicles v, drivers d WHERE v.driver = d.id and modelo LIKE '%" + txt + "%' or v.driver = d.id and placas LIKE '%" + txt + "%' or v.driver = d.id and d.nombre LIKE '%" + txt + "%' or v.driver = d.id and numero LIKE '%" + txt + "' or v.driver = d.id and caracteristicas LIKE '%" + txt + "%' ORDER by v.id desc", Table)
        TabControl1.SelectedIndex = 0
        functions.Vehicle_id = 0
        functions.Driver_id = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            functions.Vehicle_id = 0
        End If

        If TabControl1.SelectedIndex = 1 Then
            If f.ReturnPermission(f.Permission_Vehicle_EDIT) Then
                If functions.Vehicle_id > 0 Then
                    f.Vehicle_LoadUpdate(TxtModelo, TxtPlaca, TxtNumero, TxtCaracteristicas, Table_drivers, TxtGps)
                Else
                    TabControl1.SelectedIndex = 0
                End If
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
            End If
        End If
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            functions.Vehicle_id = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Vehicle_DELETE) Then
            functions.OnLoader(Loader)
            If (MsgBox("¿Esta seguro de eliminar el vehiculo # " + functions.Vehicle_id + vbNewLine + "(" + Table.SelectedCells(3).Value + ") ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Vehicle_delete() Then
                    LoadVehicles()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
            functions.OffLoader(Loader)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Vehicle_EDIT) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(TxtModelo.Text) = False Then
                functions.OnLoader(Loader)
                functions.Driver_id = Table_drivers.SelectedCells(0).Value
                If functions.Vehicle_UPDATE(TxtModelo, TxtPlaca, TxtNumero, TxtCaracteristicas, TxtGps) Then
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                    LoadVehicles()
                Else
                    f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
                End If
                functions.OffLoader(Loader)
            Else
                f.Alert("Modelo no puede se vacio", f.Alert_NumberCritical)
            End If
        Catch ex As Exception
            f.Alert(ex.Message, f.Alert_NumberCritical)
        End Try
    End Sub

    Private Sub Vehicles_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
    End Sub
End Class