Imports System.IO
Imports MySql.Data.MySqlClient

Public Class functions

    Dim Db As New Conexion
    Shared Db_shared As New Conexion

    Public Shared userID As String
    Public Shared Client As String

    'Mensajes de alerta
    Public ReadOnly Alert_NoPermitido = "Acceso No permitido"
    Public ReadOnly Alert_ProcesoFinalizadoOK = "Proceso finalizado con exito"
    Public ReadOnly Alert_ProcesoFinalizadoNO = "Proceso finalizado SIN exito"
    Public ReadOnly Alert_Verifique_proceso = "Verifique el proceso"

    'Numeros de alerta
    Public ReadOnly Alert_NumberInformacion = 64
    Public ReadOnly Alert_NumberCritical = 16
    Public ReadOnly Alert_NumberExclamacion = 48

    'Variables permisos de usuario
    Public ReadOnly Permission_Access_Clients = "acces_clients"
    Public ReadOnly Permission_Access_registros = "acces_registros"
    Public ReadOnly Permission_Access_vehiculos = "acces_vehiculos"
    Public ReadOnly Permission_Access_ajustes = "acces_ajustes"
    Public ReadOnly Permission_Clients_add = "clients_add"
    Public ReadOnly Permission_Clients_edit = "clients_edit"
    Public ReadOnly Permission_Clients_delete = "clients_delete"
    Public ReadOnly Permission_Adresses_add = "adresses_add"
    Public ReadOnly Permission_Adresses_edit = "adresses_edit"
    Public ReadOnly Permission_Adresses_delete = "adresses_delete"

    'Otras variables
    Public Shared ReadOnly Data_clients = "\clients"
    Public Shared ReadOnly Data_reports = "\reports"
    Public Shared ReadOnly Clients_ImgDefault = "\Default.jpg"


    Public Sub forms_setmodel(ByVal form As Form)
        form.Text = "NOMBRE DE LA EMPRESA - USUARIO: " + ReturnNameID(userID)
        form.Icon = System.Drawing.Icon.FromHandle(My.Resources.ico.GetHicon())
        form.FormBorderStyle = FormBorderStyle.Sizable
        form.MaximizeBox = False
        form.MaximumSize = New Size(form.Width, form.Height)
        form.MinimumSize = New Size(form.Width, form.Height)
        form.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub Button_SetModel(ByVal boton As Button, ByVal imagen As Bitmap)
        boton.BackgroundImage = imagen
        boton.Height = My.Resources.Btn_Clientes.Height
        boton.Width = My.Resources.Btn_Clientes.Width
        boton.FlatStyle = FlatStyle.Flat
        boton.BackgroundImageLayout = ImageLayout.Center
        boton.BackColor = Color.Transparent
        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseDownBackColor = Color.Transparent
        boton.FlatAppearance.MouseOverBackColor = Color.Transparent
        boton.Text = ""
    End Sub

    Public Sub Button_Hover_SetModel(ByVal boton As Button, ByVal imagen As Bitmap)
        boton.BackgroundImage = imagen
        boton.Height = My.Resources.Btn_Clientes.Height
        boton.Width = My.Resources.Btn_Clientes.Width
        boton.FlatStyle = FlatStyle.Flat
        boton.BackgroundImageLayout = ImageLayout.Center
        boton.BackColor = Color.Transparent
        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseDownBackColor = Color.Transparent
        boton.FlatAppearance.MouseOverBackColor = Color.Transparent
        boton.Text = ""
    End Sub

    Public Sub AddForm_Desktop(ByVal form As Form, ByVal Desktop As Panel)
        Desktop.Controls.Clear()
        Desktop.BorderStyle = BorderStyle.None
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Desktop.Controls.Add(form)
        form.Show()
    End Sub

    Public Function Login(ByVal username As TextBox, ByVal password As TextBox)
        Dim r = False
        Dim dato = Db.Consult("select * from users where username = '" + username.Text + "' and password = '" + password.Text + "' ")

        If dato.hasrows Then
            Do While dato.Read()
                userID = dato.GetString(0)
                r = True
            Loop
        Else
            r = False
        End If

        Return r
    End Function

    Public Sub Alert(ByVal txt As String, ByVal style As Integer)
        MsgBox(txt.ToUpper(), style, "Titulo")
    End Sub

    Public Sub OpenConfig()
        Parametros.Show()
    End Sub

    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ReturnNameID(ByVal id As String)
        Dim r = ""
        If (id > 0) Then

            Dim dato = Db.Consult("select name from users where id =  '" + id + "'  ")

            If dato.Read() Then
                r = dato.GetString(0)
            End If
        End If
        Return r.ToUpper()
    End Function

    Public Function ReturnPermission(ByVal campo As String)
        Dim r = False
        Dim dato = Db.Consult("select " + campo + " from permissions where user_id =  '" + userID + "'  ")

        If dato.Read() Then
            r = dato.GetBoolean(0)
        End If

        Return r
    End Function

    Public Function ReturnNameClient()
        Dim r = ""
        Dim dato = Db.Consult("select nombre from clients where id =  " + Client + "  ")

        If dato.Read() Then
            r = dato.GetString(0)
        End If

        Return r
    End Function



    Public Shared Function OpenFileSetPictureBox(ByVal Img As PictureBox, ByVal loader As PictureBox)
        OnLoader(loader)
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            Img.Image = Image.FromFile(file.FileName)
            Img.SizeMode = PictureBoxSizeMode.Zoom
        End If
        OffLoader(loader)
        Return file.FileName.Replace("\", "/")
    End Function

    Public Shared Sub OnLoader(ByVal img As PictureBox)
        img.Image = My.Resources.loader
        img.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Public Shared Sub OffLoader(ByVal img As PictureBox)
        img.Image = Nothing
    End Sub

    Public Shared Function Clients_add(ByVal TxtNombre As TextBox, ByVal FechaNacimiento As DateTimePicker, ByVal TxtDireccion As TextBox, ByVal TxtReferencia As TextBox, ByVal TxtCorreoElectronico As TextBox, ByVal TxtFoto As TextBox, ByVal TxtRazonSocial As TextBox, ByVal TxtRfc As TextBox) As Boolean
        Dim ruta As String
        ruta = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
        ruta = ruta.Replace("\", "/")

        Try
            My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_clients + ruta)
        Catch ex As Exception

        End Try

        Return Db_shared.Ejecutar("INSERT INTO clients (nombre, fecha_nacimiento, direccion, referencia, correo_electronico, foto, razon_social, rfc) VALUES ('" + TxtNombre.Text.ToUpper + "', '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', '" + TxtDireccion.Text.ToUpper + "', '" + TxtReferencia.Text.ToUpper + "', '" + TxtCorreoElectronico.Text.ToUpper + "', '" + ruta + "', '" + TxtRazonSocial.Text.ToUpper + "', '" + TxtRfc.Text.ToUpper + "')")
    End Function

    Public Shared Sub TextBox_clean(ByVal txt As TextBox)
        txt.Text = ""
    End Sub

    Public Sub RutaDataGET(ByVal txt As TextBox)
        Dim folder As New FolderBrowserDialog
        If folder.ShowDialog() = DialogResult.OK Then
            txt.Text = folder.SelectedPath
        End If
    End Sub

    Public Sub DataGridView_Model(ByVal d As DataGridView)
        d.RowHeadersVisible = False
        d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        d.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.datagridview_color
        d.DefaultCellStyle.SelectionBackColor = My.Settings.datagridview_selectrow
        d.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        d.RowTemplate.Height = My.Settings.datagridview_height
        d.DefaultCellStyle.Font = My.Settings.datagridview_font
        d.AllowUserToResizeRows = False
        d.ReadOnly = True
    End Sub

    Public Sub Clients_DataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("nombre", "Nombre")
        t.Columns.Add("	fecha_nacimiento", "Cumpleaños")
        t.Columns.Add("	direccion", "Direccion")
        t.Columns.Add("	referencia", "Referencia")
        t.Columns.Add("	correo_electronico", "Correo electronico")
        t.Columns.Add("	razon_social", "R. social")
        t.Columns.Add("	rfc", "Rfc")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(7), dato.GetString(8))
            Loop
        End If

    End Sub

    Public Shared Function Clients_delete() As Boolean
        Return Db_shared.Ejecutar("delete from clients where id = " + Client + " ")
    End Function

    Public Function Client_LoadUpdate(ByVal nombre As TextBox, ByVal f_nacimiento As DateTimePicker, ByVal direccion As TextBox, ByVal referencia As TextBox, ByVal Correo_electronico As TextBox, ByVal url_foto As TextBox, ByVal Razon_social As TextBox, ByVal Rfc As TextBox, ByVal foto As PictureBox)
        Dim url_FotoActual As String
        url_FotoActual = ""
        Dim dato = Db.Consult("select * from clients where id =  '" + Client + "'  ")

        If dato.Read() Then
            nombre.Text = dato.GetString(1)
            f_nacimiento.Value = dato.GetString(2)
            direccion.Text = dato.GetString(3)
            referencia.Text = dato.GetString(4)
            Correo_electronico.Text = dato.GetString(5)
            url_foto.Text = dato.GetString(6)
            foto.SizeMode = PictureBoxSizeMode.Zoom

            If File.Exists(My.Settings.data_url + Data_clients + dato.GetString(6)) Then
                url_FotoActual = My.Settings.data_url + Data_clients + dato.GetString(6)
                foto.Image = Image.FromFile(url_FotoActual)
            Else
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
            End If

            Razon_social.Text = dato.GetString(7)
            Rfc.Text = dato.GetString(8)
        End If
        Return url_FotoActual
    End Function

    Public Shared Function Client_Update(ByVal TxtNombre As TextBox, ByVal FechaNacimiento As DateTimePicker, ByVal TxtDireccion As TextBox, ByVal TxtReferencia As TextBox, ByVal TxtCorreoElectronico As TextBox, ByVal TxtFoto As TextBox, ByVal TxtRazonSocial As TextBox, ByVal TxtRfc As TextBox, ByVal FotoActual As String) As Boolean
        Dim foto_tmp As String = FotoActual
        If FotoActual <> TxtFoto.Text Then
            foto_tmp = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
            foto_tmp = foto_tmp.Replace("\", "/")

            Try
                My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_clients + foto_tmp)
                My.Computer.FileSystem.DeleteFile(My.Settings.data_url + Data_clients + FotoActual)
            Catch ex As Exception

            End Try
        End If

        Return Db_shared.Ejecutar("UPDATE clients SET nombre = '" + TxtNombre.Text.ToUpper + "' , fecha_nacimiento = '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "' , direccion = '" + TxtDireccion.Text.ToUpper + "', referencia = '" + TxtReferencia.Text.ToUpper + "', correo_electronico = '" + TxtCorreoElectronico.Text.ToUpper + "', foto = '" + foto_tmp + "', razon_social = '" + TxtRazonSocial.Text.ToUpper + "', rfc = '" + TxtRfc.Text.ToUpper + "' WHERE id =  " + Client + " ")
    End Function



End Class