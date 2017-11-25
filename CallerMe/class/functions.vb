Imports system.io
Imports MySql.Data.MySqlClient

Public Class functions

    Dim Db As New Conexion
    Shared Db_shared As New Conexion

    Public Shared userID As String
    Public Shared Client As String
    Public Shared Number_id As String
    Public Shared Adress_id As String
    Public Shared Driver_id As String

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
    Public ReadOnly Permission_Access_adress = "acces_adresses"
    Public ReadOnly Permission_Access_drivers = "acces_drivers"
    Public ReadOnly Permission_Access_vehicle = "acces_vehicles"

    Public ReadOnly Permission_Clients_add = "clients_add"
    Public ReadOnly Permission_Clients_edit = "clients_edit"
    Public ReadOnly Permission_Clients_delete = "clients_delete"
    Public ReadOnly Permission_Adresses_add = "adresses_add"
    Public ReadOnly Permission_Adresses_edit = "adresses_edit"
    Public ReadOnly Permission_Adresses_delete = "adresses_delete"
    Public ReadOnly Permission_Telephone_add = "telephone_add"
    Public ReadOnly Permission_Telephone_edit = "telephone_edit"
    Public ReadOnly Permission_Telephone_delete = "telephone_delete"
    Public ReadOnly Permission_Telephone_Access = "acces_numbersTelephone"
    Public ReadOnly Permission_Drivers_ADD = "drivers_add"
    Public ReadOnly Permission_Drivers_EDIT = "drivers_edit"
    Public ReadOnly Permission_Drivers_DELETE = "drivers_delete"
    Public ReadOnly Permission_Vehicle_ADD = "vehicles_add"
    Public ReadOnly Permission_Vehicle_EDIT = "vehicles_edit"
    Public ReadOnly Permission_Vehicle_DELETE = "vehicles_delete"


    'Otras variables
    Public Shared ReadOnly Data_clients = "\clients"
    Public Shared ReadOnly Data_reports = "\reports"
    Public Shared ReadOnly Data_drivers = "\drivers"
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

    Public Function ReturnNameDriver()
        Dim r = ""
        Dim dato = Db.Consult("select nombre from drivers where id =  " + Driver_id + "  ")

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
            Dim fs As FileStream = New System.IO.FileStream(file.FileName, FileMode.Open, FileAccess.Read)
            Img.Image = Image.FromStream(fs)
            Img.SizeMode = PictureBoxSizeMode.Zoom
            fs.Close()
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

    Public Shared Function Clients_add(ByVal TxtNombre As TextBox, ByVal FechaNacimiento As DateTimePicker, ByVal TxtCorreoElectronico As TextBox, ByVal TxtFoto As TextBox, ByVal TxtRazonSocial As TextBox, ByVal TxtRfc As TextBox) As Boolean
        Dim ruta As String
        ruta = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
        ruta = ruta.Replace("\", "/")

        Try
            My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_clients + ruta)
        Catch ex As Exception

        End Try

        Return Db_shared.Ejecutar("INSERT INTO clients (nombre, fecha_nacimiento, correo_electronico, foto, razon_social, rfc) VALUES ('" + TxtNombre.Text.ToUpper + "', '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', '" + TxtCorreoElectronico.Text.ToUpper + "', '" + ruta + "', '" + TxtRazonSocial.Text.ToUpper + "', '" + TxtRfc.Text.ToUpper + "')")
    End Function

    Public Shared Function Drivers_add(ByVal TxtNombre As TextBox, ByVal FechaNacimiento As DateTimePicker, ByVal TxtCorreoElectronico As TextBox, ByVal TxtFoto As TextBox, ByVal Lic_Conducir As TextBox, ByVal TxtTelefono As TextBox) As Boolean
        Dim ruta As String
        ruta = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
        ruta = ruta.Replace("\", "/")

        Try
            My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_drivers + ruta)
        Catch ex As Exception

        End Try

        Return Db_shared.Ejecutar("INSERT INTO drivers (nombre, fecha_nacimiento, licencia_conducir, correl_electronico, foto, movil) VALUES ('" + TxtNombre.Text.ToUpper + "', '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', '" + Lic_Conducir.Text.ToUpper + "', '" + TxtCorreoElectronico.Text + "', '" + ruta + "', '" + TxtTelefono.Text.ToUpper + "' )")
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
        d.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        d.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Public Sub Clients_DataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("nombre", "Nombre")
        t.Columns.Add("	fecha_nacimiento", "Cumpleaños")
        t.Columns.Add("	correo_electronico", "Correo electronico")
        t.Columns.Add("	razon_social", "R. social")
        t.Columns.Add("	rfc", "Rfc")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(5), dato.GetString(6))
            Loop
        End If

    End Sub

    Public Sub Drivers_DataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("nombre", "Nombre")
        t.Columns.Add("	fecha_nacimiento", "Fecha de nacimiento")
        t.Columns.Add("licencia_conducir", "Licencia")
        t.Columns.Add("movil", "Telefono")
        t.Columns.Add("correl_electronico", "Correo electronico")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(6), dato.GetString(4))
            Loop
        End If

    End Sub

    Public Sub Clients_AdresesDataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID direccion")
        t.Columns.Add("id", "ID cliente")
        t.Columns.Add("client", "Cliente")
        t.Columns.Add("direccion", "Direccion")
        t.Columns.Add("ref", "Referencia")
        t.Columns.Add("kms", "Kilometros")
        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5))
            Loop
        End If

    End Sub

    Public Shared Function Clients_delete() As Boolean
        Return Db_shared.Ejecutar("delete from clients where id = " + Client + " ")
    End Function

    Public Shared Function Driver_delete() As Boolean
        Return Db_shared.Ejecutar("delete from drivers where id = " + Driver_id + " ")
    End Function

    Public Shared Function Clients_AdressDELETE() As Boolean
        Return Db_shared.Ejecutar("delete from adresses where id = " + Adress_id + " ")
    End Function

    Public Shared Function Clients_NumberDelete(ByVal id_number As String) As Boolean
        Return Db_shared.Ejecutar("delete from telephone_numbers where id = " + id_number + " ")
    End Function

    Public Function Client_LoadUpdate(ByVal nombre As TextBox, ByVal f_nacimiento As DateTimePicker, ByVal Correo_electronico As TextBox, ByVal url_foto As TextBox, ByVal Razon_social As TextBox, ByVal Rfc As TextBox, ByVal foto As PictureBox)
        Dim url_FotoActual As String
        url_FotoActual = ""
        Dim dato = Db.Consult("select * from clients where id =  '" + Client + "'  ")

        If dato.Read() Then
            nombre.Text = dato.GetString(1)
            f_nacimiento.Value = dato.GetString(2)
            Correo_electronico.Text = dato.GetString(3)
            url_foto.Text = dato.GetString(4)
            foto.SizeMode = PictureBoxSizeMode.Zoom

            If File.Exists(My.Settings.data_url + Data_clients + dato.GetString(4)) Then
                url_FotoActual = My.Settings.data_url + Data_clients + dato.GetString(4)
                Dim fs As FileStream = New System.IO.FileStream(url_FotoActual, FileMode.Open, FileAccess.Read)
                foto.Image = Image.FromStream(fs)
                fs.Close()
            Else
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
            End If

            Razon_social.Text = dato.GetString(5)
            Rfc.Text = dato.GetString(6)
        End If
        Return url_FotoActual
    End Function

    Public Function Driver_LoadUpdate(ByVal nombre As TextBox, ByVal f_nacimiento As DateTimePicker, ByVal Correo_electronico As TextBox, ByVal url_foto As TextBox, ByVal TxtLicConducir As TextBox, ByVal foto As PictureBox, ByVal TxtTelefono As TextBox)
        Dim url_FotoActual As String
        url_FotoActual = ""
        Dim dato = Db.Consult("select * from drivers where id =  '" + Driver_id + "'  ")

        If dato.Read() Then
            nombre.Text = dato.GetString(1)
            f_nacimiento.Value = dato.GetString(2)
            TxtLicConducir.Text = dato.GetString(3)
            Correo_electronico.Text = dato.GetString(4)
            url_foto.Text = dato.GetString(5)
            foto.SizeMode = PictureBoxSizeMode.Zoom

            If File.Exists(My.Settings.data_url + Data_drivers + dato.GetString(5)) Then
                url_FotoActual = My.Settings.data_url + Data_drivers + dato.GetString(5)
                Dim fs As FileStream = New System.IO.FileStream(url_FotoActual, FileMode.Open, FileAccess.Read)
                foto.Image = Image.FromStream(fs)
                fs.Close()
            Else
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
            End If
            TxtTelefono.Text = dato.GetString(6)
        End If
        Return url_FotoActual
    End Function

    Public Shared Function Client_Update(ByVal TxtNombre As TextBox, ByVal FechaNacimiento As DateTimePicker, ByVal TxtCorreoElectronico As TextBox, ByVal TxtFoto As TextBox, ByVal TxtRazonSocial As TextBox, ByVal TxtRfc As TextBox, ByVal FotoActual As String) As Boolean
        Dim foto_tmp As String = FotoActual
        If My.Computer.FileSystem.FileExists(FotoActual) = False Then
            Try
                foto_tmp = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
                foto_tmp = foto_tmp.Replace("\", "/")

                If My.Computer.FileSystem.FileExists(TxtFoto.Text) Then
                    My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_clients + foto_tmp)
                End If
                Return Db_shared.Ejecutar("UPDATE clients SET nombre = '" + TxtNombre.Text.ToUpper + "' , fecha_nacimiento = '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', correo_electronico = '" + TxtCorreoElectronico.Text.ToUpper + "', foto = '" + foto_tmp + "', razon_social = '" + TxtRazonSocial.Text.ToUpper + "', rfc = '" + TxtRfc.Text.ToUpper + "' WHERE id =  " + Client + " ")
            Catch ex As Exception
                MsgBox(ex.Message, 16)
                Return False
            End Try
        Else
            If foto_tmp <> My.Settings.data_url + Data_clients + TxtFoto.Text Then
                Try
                    foto_tmp = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
                    foto_tmp = foto_tmp.Replace("\", "/")

                    If TxtFoto.Text <> "/Ninguna" Then
                        My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_clients + foto_tmp)
                    End If
                    My.Computer.FileSystem.DeleteFile(FotoActual)
                    Return Db_shared.Ejecutar("UPDATE clients SET nombre = '" + TxtNombre.Text.ToUpper + "' , fecha_nacimiento = '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', correo_electronico = '" + TxtCorreoElectronico.Text.ToUpper + "', foto = '" + foto_tmp + "', razon_social = '" + TxtRazonSocial.Text.ToUpper + "', rfc = '" + TxtRfc.Text.ToUpper + "' WHERE id =  " + Client + " ")
                Catch ex As Exception
                    MsgBox(ex.Message, 16)
                    Return False
                End Try
            Else
                Return Db_shared.Ejecutar("UPDATE clients SET nombre = '" + TxtNombre.Text.ToUpper + "' , fecha_nacimiento = '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', correo_electronico = '" + TxtCorreoElectronico.Text.ToUpper + "', razon_social = '" + TxtRazonSocial.Text.ToUpper + "', rfc = '" + TxtRfc.Text.ToUpper + "' WHERE id =  " + Client + " ")
            End If
        End If
    End Function

    Public Shared Function Driver_Update(ByVal TxtNombre As TextBox, ByVal FechaNacimiento As DateTimePicker, ByVal TxtCorreoElectronico As TextBox, ByVal TxtFoto As TextBox, ByVal TxtlicConductor As TextBox, ByVal FotoActual As String, ByVal TxtTelefono As TextBox) As Boolean
        Dim foto_tmp As String = FotoActual

        If My.Computer.FileSystem.FileExists(FotoActual) = False Then
            Try
                foto_tmp = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
                foto_tmp = foto_tmp.Replace("\", "/")

                If My.Computer.FileSystem.FileExists(TxtFoto.Text) Then
                    My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_drivers + foto_tmp)
                End If
                Return Db_shared.Ejecutar("UPDATE drivers SET nombre = '" + TxtNombre.Text.ToUpper + "' , fecha_nacimiento = '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', correl_electronico = '" + TxtCorreoElectronico.Text.ToUpper + "', foto = '" + foto_tmp + "', licencia_conducir = '" + TxtlicConductor.Text.ToUpper + "', movil = '" + TxtTelefono.Text.ToUpper + "' WHERE id =  " + Driver_id + " ")
            Catch ex As Exception
                MsgBox(ex.Message, 16)
                Return False
            End Try
        Else
            If foto_tmp <> My.Settings.data_url + Data_drivers + TxtFoto.Text Then
                Try
                    foto_tmp = "/" + userID + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(TxtFoto.Text)
                    foto_tmp = foto_tmp.Replace("\", "/")

                    If TxtFoto.Text <> "/Ninguna" Then
                        My.Computer.FileSystem.CopyFile(TxtFoto.Text, My.Settings.data_url + Data_drivers + foto_tmp)
                    End If
                    My.Computer.FileSystem.DeleteFile(FotoActual)
                    Return Db_shared.Ejecutar("UPDATE drivers SET nombre = '" + TxtNombre.Text.ToUpper + "' , fecha_nacimiento = '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', correl_electronico = '" + TxtCorreoElectronico.Text.ToUpper + "', foto = '" + foto_tmp + "', licencia_conducir = '" + TxtlicConductor.Text.ToUpper + "', movil = '" + TxtTelefono.Text.ToUpper + "' WHERE id =  " + Driver_id + " ")
                Catch ex As Exception
                    MsgBox(ex.Message, 16)
                    Return False
                End Try
            Else
                Return Db_shared.Ejecutar("UPDATE drivers SET nombre = '" + TxtNombre.Text.ToUpper + "' , fecha_nacimiento = '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', correl_electronico = '" + TxtCorreoElectronico.Text.ToUpper + "', licencia_conducir = '" + TxtlicConductor.Text.ToUpper + "', movil = '" + TxtTelefono.Text.ToUpper + "' WHERE id =  " + Driver_id + " ")
            End If
        End If
    End Function

    Public Shared Function Client_AdressUPDATE(ByVal TxtDireccion As TextBox, ByVal TxtReferencia As TextBox, ByVal TxtKm As TextBox) As Boolean
        Return Db_shared.Ejecutar("UPDATE adresses SET client = " + Client + ", direccion = '" + TxtDireccion.Text.ToUpper + "', referencia = '" + TxtReferencia.Text.ToUpper + "', kms = " + TxtKm.Text + " WHERE id = " + Adress_id + " ")
    End Function

    Public Shared Function Clients_NumberADD(ByVal TxtNumero As TextBox, ByVal TxtCompañia As TextBox, ByVal TxtMovil As RadioButton, ByVal Txtfijo As RadioButton, ByVal TxtRef As TextBox) As Boolean
        If TxtMovil.Checked Then
            Return Db_shared.Ejecutar("INSERT INTO telephone_numbers (client, numero, compañia, fijo, movil, ref_note) VALUES (" + Client + ", '" + TxtNumero.Text.Replace(" ", "") + "', '" + TxtCompañia.Text.ToUpper + "', '0', '1', '" + TxtRef.Text.ToUpper + "' )")
        Else
            Return Db_shared.Ejecutar("INSERT INTO telephone_numbers (client, numero, compañia, fijo, movil, ref_note) VALUES (" + Client + ", '" + TxtNumero.Text.Replace(" ", "") + "', '" + TxtCompañia.Text.ToUpper + "', '1', '0', '" + TxtRef.Text.ToUpper + "' )")
        End If
    End Function

    Public Sub Clients_Datagridview_Numbers(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID_Numero")
        t.Columns.Add("id", "ID_Cliente")
        t.Columns.Add("client", "Cliente")
        t.Columns.Add("number", "Numero")
        t.Columns.Add("company", "Compañia")
        t.Columns.Add("Type", "Tipo linea")

        If dato.HasRows Then
            Do While dato.Read()
                If dato.GetBoolean(5) Then
                    t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), "FIJA")
                Else
                    t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), "MOVIL")
                End If

            Loop
        End If

    End Sub

    Public Sub Client_NumberLoadUpdate(ByVal numero As TextBox, ByVal compañia As TextBox, ByVal ref As TextBox, ByVal movil As RadioButton, ByVal fijo As RadioButton, ByVal t As DataGridView)
        Dim dato = Db.Consult("SELECT * FROM telephone_numbers where id = '" + Number_id + "' ")

        If dato.Read() Then
            numero.Text = dato.GetString(2)
            compañia.Text = dato.GetString(3)
            ref.Text = dato.GetString(4)
            fijo.Checked = dato.GetBoolean(5)
            movil.Checked = dato.GetBoolean(6)

            For Each row As DataGridViewRow In t.Rows
                If t.Item(0, row.Index).Value = Client Then
                    t.CurrentCell = t.Rows(row.Index).Cells(0)
                End If
            Next

        End If
    End Sub

    Public Sub Client_AdressesLoadUpdate(ByVal TxtDireccion As TextBox, ByVal TxtReferencia As TextBox, ByVal TxtKm As TextBox, ByVal t As DataGridView)
        Dim dato = Db.Consult("SELECT * FROM adresses where id = '" + Adress_id + "' ")

        If dato.Read() Then
            TxtDireccion.Text = dato.GetString(2)
            TxtReferencia.Text = dato.GetString(3)
            TxtKm.Text = dato.GetString(4)

            For Each row As DataGridViewRow In t.Rows
                If t.Item(0, row.Index).Value = Client Then
                    t.CurrentCell = t.Rows(row.Index).Cells(0)
                End If
            Next

        End If
    End Sub

    Public Shared Function Clients_NumberUPDATE(ByVal TxtNumero As TextBox, ByVal TxtCompañia As TextBox, ByVal TxtMovil As RadioButton, ByVal Txtfijo As RadioButton, ByVal TxtRef As TextBox) As Boolean
        If TxtMovil.Checked Then
            Return Db_shared.Ejecutar("UPDATE telephone_numbers SET client = '" + Client + "',  numero = '" + TxtNumero.Text.Replace(" ", "") + "', compañia = '" + TxtCompañia.Text.ToUpper + "', ref_note = '" + TxtRef.Text.ToUpper + "', fijo = '0', movil = '1' WHERE id = " + Number_id + " ")
        Else
            Return Db_shared.Ejecutar("UPDATE telephone_numbers SET client = '" + Client + "', numero = '" + TxtNumero.Text.Replace(" ", "") + "', compañia = '" + TxtCompañia.Text.ToUpper + "', ref_note = '" + TxtRef.Text.ToUpper + "', fijo = '1', movil = '0' WHERE id = " + Number_id + " ")
        End If
    End Function

    Public Shared Function Clients_AdressADD(ByVal TxtDireccion As TextBox, ByVal TxtReferencia As TextBox, ByVal TxtKilometros As TextBox) As Boolean
        Return Db_shared.Ejecutar("INSERT INTO adresses (client, direccion, referencia, kms) VALUES (" + Client + ", '" + TxtDireccion.Text.ToUpper + "', '" + TxtReferencia.Text.ToUpper + "', " + TxtKilometros.Text + ")")
    End Function

    Public Function IsDecimal(ByVal numero As TextBox) As Boolean
        Try
            Return Decimal.Parse(numero.Text)
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class