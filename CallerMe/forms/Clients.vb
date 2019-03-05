Public Class Clients
    Dim f As New functions
    Dim foto_actualStatic As String

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(Table)
        f.DataGridView_Model(ViewNumbers)
        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height
        LoadClientes()
        functions.Client = 0
        TxtFoto.Enabled = False
        CheckImagen.Checked = True
        f.BotonesBackGroundBlue(Panel1)
        TabControl1.Height = control.Desktop.Height

        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR)
        f.Button_SetModel(btn_numeros, My.Resources.Boton_VerNumeros)
        f.Button_SetModel(btn_editar, My.Resources.Boton_editar)
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)

    End Sub

    Public Sub LoadClientes()
        f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", Table)
        TabControl1.SelectedIndex = 0
        functions.Client = 0
    End Sub

    Public Sub SearchClientes(ByVal txt As String)
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + txt + "%' or correo_electronico LIKE '%" + txt + "%' or rfc LIKE '%" + txt + "%' OR razon_social LIKE '%" + txt + "%' ORDER by nombre asc", Table)
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
            TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            functions.Client = 0
        End If

        If TabControl1.SelectedIndex = 1 Then
            If f.ReturnPermission(f.Permission_Clients_edit) Then
                If functions.Client > 0 Then
                    foto_actualStatic = f.Client_LoadUpdate(TxtNombre, FechaNaci, TxtCorreoElectronico, TxtFoto, TxtRazonSocial, TxtRfc, Foto)
                Else
                    TabControl1.SelectedIndex = 0
                End If
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
            End If
        End If

        If TabControl1.SelectedIndex = 2 Then
            If functions.Client > 0 Then
                f.Clients_Datagridview_Numbers("SELECT n.id, c.id, c.nombre, n.numero, n.compañia, n.fijo, n.movil FROM telephone_numbers n, clients c where n.client = c.id and n.client = " + functions.Client + " ORDER by n.id desc", ViewNumbers)
            Else
                TabControl1.SelectedIndex = 0
            End If
        End If

    End Sub

    Private Sub VerMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerMovimientosToolStripMenuItem.Click
        TabControl1.SelectedIndex = 2
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

            Dim tmp = functions.OpenFileSetPictureBox(Foto, control.Loader)
            If String.IsNullOrEmpty(tmp) = False Then
                TxtFoto.Text = tmp
            End If

        ElseIf CheckCamara.Checked Then
            MsgBox("Tomar foto Con camara No listo")
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrEmpty(TxtNombre.Text) = False Then
            functions.OnLoader(control.Loader)
            If functions.Client_Update(TxtNombre, FechaNaci, TxtCorreoElectronico, TxtFoto, TxtRazonSocial, TxtRfc, foto_actualStatic) Then
                f.Alert("Cliente actualizado con exito", f.Alert_NumberInformacion)
                functions.TextBox_clean(TxtNombre)
                functions.TextBox_clean(TxtCorreoElectronico)
                functions.TextBox_clean(TxtFoto)
                functions.TextBox_clean(TxtRazonSocial)
                functions.TextBox_clean(TxtRfc)
                Foto.Image = Nothing
                LoadClientes()
            Else
                f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
            End If
            functions.OffLoader(control.Loader)
        Else
            f.Alert("Ingrese al menos un nombre", f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Foto.Image = Image.FromFile(My.Settings.data_url + functions.Data_clients + functions.Clients_ImgDefault)
        Foto.SizeMode = PictureBoxSizeMode.Zoom
        TxtFoto.Text = "/Ninguna"
    End Sub

    Private Sub Clients_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        delete()
    End Sub

    Private Sub btn_numeros_MouseLeave(sender As Object, e As EventArgs) Handles btn_numeros.MouseLeave
        f.Button_SetModel(btn_numeros, My.Resources.Boton_VerNumeros)
    End Sub

    Private Sub btn_numeros_MouseEnter(sender As Object, e As EventArgs) Handles btn_numeros.MouseEnter
        f.Button_SetModel(btn_numeros, My.Resources.Boton_VerNumeros_Efect)
    End Sub

    Private Sub btn_editar_MouseEnter(sender As Object, e As EventArgs) Handles btn_editar.MouseEnter
        f.Button_SetModel(btn_editar, My.Resources.Boton_editarEfect)
    End Sub

    Private Sub btn_editar_MouseLeave(sender As Object, e As EventArgs) Handles btn_editar.MouseLeave
        f.Button_SetModel(btn_editar, My.Resources.Boton_editar)
    End Sub

    Private Sub btn_delete_MouseEnter(sender As Object, e As EventArgs) Handles btn_delete.MouseEnter
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINARefecto)
    End Sub

    Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
        f.Button_SetModel(btn_delete, My.Resources.Boton_eLIMINAR)
    End Sub

    Private Sub btn_numeros_Click(sender As Object, e As EventArgs) Handles btn_numeros.Click
        If functions.Client > 0 Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If functions.Client > 0 Then
            If f.ReturnPermission(f.Permission_Clients_edit) Then
                TabControl1.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If functions.Client > 0 Then
            delete()
        End If
    End Sub

    Private Sub delete()
        If f.ReturnPermission(f.Permission_Clients_delete) Then
            If (MsgBox("¿Esta seguro de eliminar el cliente # " + functions.Client + " ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Clients_DELETE Then
                    LoadClientes()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        functions.Client = Table.SelectedCells(0).Value
    End Sub

    Private Sub Btn_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add.MouseLeave
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR)
    End Sub

    Private Sub Btn_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_add.MouseEnter
        f.Button_SetModel(Btn_add, My.Resources.Boton_AGREGAR_EFECT)
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        If f.ReturnPermission(f.Permission_Clients_add) Then
            f.AddForm_Desktop(Clients_add, control.Desktop)
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub
End Class