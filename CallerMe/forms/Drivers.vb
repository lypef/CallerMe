Public Class Drivers
    Dim f As New functions
    Dim foto_actualStatic As String

    Private Sub Drivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(Table)
        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height - Loader.Height
        TabControl1.SelectedIndex = 0
        functions.Driver_id = 0
        TxtFoto.Enabled = False
        CheckImagen.Checked = True
    End Sub

    Public Sub LoadDrivers()
        f.Drivers_DataGridViewSet("SELECT * FROM drivers ORDER by nombre asc", Table)
        TabControl1.SelectedIndex = 0
        functions.Driver_id = 0
    End Sub

    Public Sub SearchDrivers(ByVal txt As String)
        f.Drivers_DataGridViewSet("SELECT * FROM drivers where nombre LIKE '%" + txt + "%' or correl_electronico LIKE '%" + txt + "%' or licencia_conducir LIKE '%" + txt + "%' ORDER by nombre asc", Table)
        TabControl1.SelectedIndex = 0
        functions.Client = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            functions.Driver_id = 0
        End If

        If TabControl1.SelectedIndex = 1 Then
            If f.ReturnPermission(f.Permission_Drivers_EDIT) Then
                If functions.Driver_id > 0 Then
                    foto_actualStatic = f.Driver_LoadUpdate(TxtNombre, FechaNaci, TxtCorreoElectronico, TxtFoto, TxtLicConductor, Foto, TxtTelefono)
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
            functions.Driver_id = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Drivers_DELETE) Then
            functions.OnLoader(Loader)
            If (MsgBox("¿Esta seguro de eliminar el conductor # " + functions.Driver_id + vbNewLine + "(" + f.ReturnNameDriver() + ") ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.Driver_delete() Then
                    f.Drivers_DataGridViewSet("SELECT * FROM drivers ORDER by nombre asc", Table)
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

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_Drivers_EDIT) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Foto.Image = Image.FromFile(My.Settings.data_url + functions.Data_clients + functions.Clients_ImgDefault)
        Foto.SizeMode = PictureBoxSizeMode.Zoom
        TxtFoto.Text = "/Ninguna"
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrEmpty(TxtNombre.Text) = False Then
            functions.OnLoader(Loader)
            If functions.Driver_Update(TxtNombre, FechaNaci, TxtCorreoElectronico, TxtFoto, TxtLicConductor, foto_actualStatic, TxtTelefono) Then
                f.Alert("Conductor actualizado con exito", f.Alert_NumberInformacion)
                functions.TextBox_clean(TxtNombre)
                functions.TextBox_clean(TxtCorreoElectronico)
                functions.TextBox_clean(TxtFoto)
                Foto.Image = Nothing
                LoadDrivers()
            Else
                f.Alert("Error, verifique sus datos", f.Alert_NumberCritical)
            End If
            functions.OffLoader(Loader)
        Else
            f.Alert("Ingrese al menos un nombre", f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub Drivers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
    End Sub
End Class