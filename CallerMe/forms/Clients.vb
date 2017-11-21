Public Class Clients
    Dim f As New functions
    Dim foto_actualStatic As String

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(Table)
        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height - Loader.Height
        LoadClientes()
        functions.Client = 0
        TxtFoto.Enabled = False
        CheckImagen.Checked = True
    End Sub

    Public Sub LoadClientes()
        f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", Table)
        TabControl1.SelectedIndex = 0
        functions.Client = 0
    End Sub

    Public Sub SearchClientes(ByVal txt As String)
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + txt + "%' or direccion LIKE '%" + txt + "%' or correo_electronico LIKE '%" + txt + "%' or rfc LIKE '%" + txt + "%' OR razon_social LIKE '%" + txt + "%' ORDER by nombre asc", Table)
        TabControl1.SelectedIndex = 0
        functions.Client = 0
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
            foto_actualStatic = f.Client_LoadUpdate(TxtNombre, FechaNaci, TxtDireccion, TxtReferencia, TxtCorreoElectronico, TxtFoto, TxtRazonSocial, TxtRfc, Foto)
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            functions.Client = 0
        End If

        If TabControl1.SelectedIndex = 1 Then
            If f.ReturnPermission(f.Permission_Clients_edit) Then
                If functions.Client <= 0 Then
                    TabControl1.SelectedIndex = 0
                End If
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
            End If
        End If

        If TabControl1.SelectedIndex = 2 Then
            If functions.Client > 0 Then
                MsgBox("Cargar Movimientos")
            Else
                TabControl1.SelectedIndex = 0
            End If
        End If

    End Sub

    Private Sub VerMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerMovimientosToolStripMenuItem.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Clients_delete) Then
            functions.OnLoader(Loader)
            If (MsgBox("¿Esta seguro de eliminar el cliente # " + functions.Client + vbNewLine + "(" + f.ReturnNameClient() + ") ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Clients_delete() Then
                    f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", Table)
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

    Private Sub CheckImagen_CheckedChanged(sender As Object, e As EventArgs) Handles CheckImagen.CheckedChanged
        If CheckImagen.Checked = False Then
            CheckCamara.Checked = True
        End If

        If CheckImagen.Checked Then
            CheckCamara.Checked = False
            BtnFoto.Text = "Examinar"
            Foto.Image = Nothing
            TxtFoto.Text = ""
        End If
    End Sub

    Private Sub CheckCamara_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCamara.CheckedChanged
        If CheckCamara.Checked = False Then
            CheckImagen.Checked = True
        End If

        If CheckCamara.Checked Then
            CheckImagen.Checked = False
            BtnFoto.Text = "Tomar foto"
            Foto.Image = Nothing
            TxtFoto.Text = ""
        End If
    End Sub

    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click
        If CheckImagen.Checked Then

            Dim tmp = functions.OpenFileSetPictureBox(Foto, Loader)
            If String.IsNullOrEmpty(tmp) = False Then
                TxtFoto.Text = tmp
            End If

        ElseIf CheckCamara.Checked Then
            MsgBox("Tomar foto Con camara No listo")
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrEmpty(TxtNombre.Text) = False Then
            functions.OnLoader(Loader)
            If functions.Client_Update(TxtNombre, FechaNaci, TxtDireccion, TxtReferencia, TxtCorreoElectronico, TxtFoto, TxtRazonSocial, TxtRfc, foto_actualStatic) Then
                f.Alert("Cliente actualizado con exito", f.Alert_NumberInformacion)
                functions.TextBox_clean(TxtNombre)
                functions.TextBox_clean(TxtDireccion)
                functions.TextBox_clean(TxtReferencia)
                functions.TextBox_clean(TxtCorreoElectronico)
                functions.TextBox_clean(TxtFoto)
                functions.TextBox_clean(TxtRazonSocial)
                functions.TextBox_clean(TxtRfc)
                Foto.Image = Nothing
                LoadClientes()
            Else
                f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
            End If
            functions.OffLoader(Loader)
        Else
            f.Alert("Ingrese al menos un nombre", f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class