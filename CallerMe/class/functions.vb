Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports Microsoft.Win32
Imports System.Threading
Imports System.ComponentModel

Public Class functions

    Dim Db As New Conexion
    Dim Licence As New validateLicence
    Shared Db_shared As New Conexion

    Public Shared userID As String
    Public Shared Client As String
    Public Shared Number_id As String
    Public Shared Adress_id As String
    Public Shared Driver_id As String
    Public Shared Vehicle_id As String
    Public Shared log_id As String
    Public Shared log_id_omitidas As String
    Public Shared user_select As String

    'ultimos numeros en llamar
    Public Shared LastNumber0 As String = ""
    Public Shared LastNumber1 As String = ""
    Public Shared LastNumber2 As String = ""
    Public Shared LastNumber3 As String = ""

    'Valores set numero telefono caller
    Public Shared NumberDevice_0_set As Boolean = False
    Public Shared NumberDevice_1_set As Boolean = False
    Public Shared NumberDevice_2_set As Boolean = False
    Public Shared NumberDevice_3_set As Boolean = False

    'Listas 
    Public ListNumeros As New List(Of Integer)

    Public Sub OmitirLlamadaDb(f_llamada As DateTime, numero As String)
        Db.Ejecutar("INSERT INTO `registros_omitidos` (`cliente`, `numero`, `f_llamada`, `usuario`) VALUES ('" + ReturnClientID(numero) + "', '" + numero + "', '" + ReturnDateFormatString(f_llamada) + "', " + userID + ");")
    End Sub

    Public Sub finalizarLlamada(caller As Integer)
        AD101_SetBusy(caller, 0)
        System.Threading.Thread.Sleep(250)
        AD101_SetBusy(caller, 1)
        If caller = 0 Then
            control.Device0 = ""
        End If
    End Sub

    Dim ListUsuarios As New List(Of Integer)
    Public ListDireccion As New List(Of Integer)
    Public ListVehiculos As New List(Of Integer)
    Public ListConductor As New List(Of Integer)

    'Propiedades parametros
    Public ReadOnly Empresa_Nombre As String = "name_enterprise"
    Public ReadOnly Empresa_Direccion As String = "direccion"
    Public ReadOnly Empresa_Rfc As String = "rfc"

    'Mensajes de alerta
    Public ReadOnly Alert_NoPermitido As String = "Acceso No permitido"
    Public ReadOnly Alert_ProcesoFinalizadoOK As String = "Proceso finalizado con exito"


    Public ReadOnly Alert_ProcesoFinalizadoNO As String = "Proceso finalizado SIN exito"
    Public ReadOnly Alert_Verifique_proceso As String = "Verifique el proceso"
    Public ReadOnly Alert_seleccione_item As String = "Seleccione un item"

    'Numeros de alerta
    Public ReadOnly Alert_NumberInformacion As Integer = 64
    Public ReadOnly Alert_NumberCritical As Integer = 16
    Public ReadOnly Alert_NumberExclamacion As Integer = 48

    'Variables permisos de usuario
    Public ReadOnly Permission_Access_Clients As String = "acces_clients"
    Public ReadOnly Permission_Access_registros As String = "acces_registros"
    Public ReadOnly Permission_Access_vehiculos As String = "acces_vehiculos"
    Public ReadOnly Permission_Access_ajustes As String = "acces_ajustes"
    Public ReadOnly Permission_Access_adress As String = "acces_adresses"
    Public ReadOnly Permission_Access_drivers As String = "acces_drivers"
    Public ReadOnly Permission_Access_vehicle As String = "acces_vehicles"
    Public ReadOnly Permission_Access_properties As String = "properties"
    Public ReadOnly Permission_Access_LOGS As String = "acces_logs"
    Public ReadOnly Permission_Access_users As String = "user_access"

    Public ReadOnly Permission_Clients_add As String = "clients_add"
    Public ReadOnly Permission_Clients_edit As String = "clients_edit"
    Public ReadOnly Permission_Clients_delete As String = "clients_delete"
    Public ReadOnly Permission_Adresses_add As String = "adresses_add"
    Public ReadOnly Permission_Adresses_edit As String = "adresses_edit"
    Public ReadOnly Permission_Adresses_delete As String = "adresses_delete"
    Public ReadOnly Permission_Telephone_add As String = "telephone_add"
    Public ReadOnly Permission_Telephone_edit As String = "telephone_edit"
    Public ReadOnly Permission_Telephone_delete As String = "telephone_delete"
    Public ReadOnly Permission_Telephone_Access As String = "acces_numbersTelephone"
    Public ReadOnly Permission_Drivers_ADD As String = "drivers_add"
    Public ReadOnly Permission_Drivers_EDIT As String = "drivers_edit"
    Public ReadOnly Permission_Drivers_DELETE As String = "drivers_delete"
    Public ReadOnly Permission_Vehicle_ADD As String = "vehicles_add"
    Public ReadOnly Permission_Vehicle_EDIT As String = "vehicles_edit"
    Public ReadOnly Permission_Vehicle_DELETE As String = "vehicles_delete"
    Public ReadOnly Permission_Logs_ADD As String = "logs_add"
    Public ReadOnly Permission_Logs_EDIT As String = "logs_edit"
    Public ReadOnly Permission_Logs_DELETE As String = "logs_delete"
    Public ReadOnly Permission_Logs_CLEAN As String = "logs_clean"
    Public ReadOnly Permission_users_ADD As String = "user_add"
    Public ReadOnly Permission_users_EDIT As String = "user_edit"
    Public ReadOnly Permission_users_DELETE As String = "user_delete"
    Public ReadOnly Permission_users_PERMISOS As String = "user_permisos"
    Public ReadOnly Permission_omitos_delete As String = "delete_omitido"
    Public ReadOnly Permission_close_software As String = "close_software"


    'Variables permisos de usuario
    Public ReadOnly GenReportClients As Integer = 1

    Public ReadOnly GenReportClients_NUMEROS As Integer = 2
    Public ReadOnly GenReportClients_DIRECCIONES As Integer = 3
    Public ReadOnly GenReportClients_DRIVERS As Integer = 4
    Public ReadOnly GenReportDrivers_Vehicle As Integer = 5
    Public ReadOnly GenReportLOGS As Integer = 6
    Public ReadOnly GenReport_users As Integer = 7

    'Otras variables
    Public Shared ReadOnly Data_clients As String = "\clients"
    Public Shared ReadOnly Data_reports As String = "\reports"
    Public Shared ReadOnly Data_drivers As String = "\drivers"
    Public Shared ReadOnly Clients_ImgDefault As String = "\default.png"


    Public Sub forms_setmodel(ByVal form As Form)
        form.Text = ReturnEmpresa_Parametros(Empresa_Nombre) + " - USUARIO: " + ReturnNameID(userID)
        form.Icon = System.Drawing.Icon.FromHandle(My.Resources.ico.GetHicon())
        form.FormBorderStyle = FormBorderStyle.Sizable
        form.MaximizeBox = False
        form.MaximumSize = New Size(form.Width, form.Height)
        form.MinimumSize = New Size(form.Width, form.Height)
        form.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub Button_SetModel(ByVal boton As Button, ByVal imagen As Bitmap)
        boton.BackgroundImage = imagen
        'boton.Height = My.Resources.Btn_Clientes.Height
        'boton.Width = My.Resources.Btn_Clientes.Width
        boton.FlatStyle = FlatStyle.Flat
        boton.BackgroundImageLayout = ImageLayout.Center
        boton.BackColor = Color.Transparent
        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseDownBackColor = Color.Transparent
        boton.FlatAppearance.MouseOverBackColor = Color.Transparent
        boton.Text = ""
    End Sub

    Public Sub BotonesBackGroundBlue(ByVal panel As Panel)
        panel.BackColor = Color.FromArgb(26, 67, 129)
    End Sub

    Public Sub FormBackColor(ByVal f As Form)
        f.BackColor = Color.FromArgb(26, 67, 129)
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

    Public Sub DesktopClean(ByVal Desktop As Panel)
        Desktop.Controls.Clear()
        Desktop.BorderStyle = BorderStyle.None
    End Sub

    Public Sub AddForm_Desktop(ByVal form As Form, ByVal Desktop As Panel)
        Desktop.Controls.Clear()
        Desktop.BorderStyle = BorderStyle.None
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        Desktop.Controls.Add(form)
        form.Show()
    End Sub

    Public Function Login(ByVal username As TextBox, ByVal password As TextBox) As Boolean
        Dim r = False
        Dim dato = Db.Consult("select * from users where username = '" + username.Text + "' and password = '" + EncriptMD5(password.Text) + "' ")


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
        If (style = Alert_NumberInformacion) Then
            MessageBox.Show(txt,
            Empresa_Nombre,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1)
        ElseIf (style = Alert_NumberCritical) Then
            MessageBox.Show(txt,
            Empresa_Nombre,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1)
        ElseIf (style = Alert_NumberExclamacion) Then
            MessageBox.Show(txt,
            Empresa_Nombre,
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1)
        End If
        'AlertContainer.Show()
        'AlertContainer.style(style)
        'AlertContainer.TextBoxMensaje.Text = txt.ToUpper()
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

    Public Function ReturnPermission(ByVal campo As String) As Boolean
        Dim r = False
        Dim dato = Db.Consult("select " + campo + " from permissions where user_id =  '" + userID + "'  ")

        If dato.Read() Then
            r = dato.GetBoolean(0)
        End If

        Return r
    End Function

    Public Function ReturnEmpresa_Parametros(ByVal t As String) As String
        Dim r = ""
        Dim dato = Db.Consult("select " + t + " from properties where id =  1 ")

        If dato.Read() Then
            r = dato.GetString(0)
        End If

        Return r.ToUpper
    End Function

    Public Function ReturnNameClient()
        Dim r = ""
        Dim dato = Db.Consult("select nombre from clients where id =  " + Client + "  ")

        If dato.Read() Then
            r = dato.GetString(0)
        End If

        Return r
    End Function

    Public Function ReturnUsername() As String
        Dim r = ""
        Dim dato = Db.Consult("select name from users where id =  " + userID + "  ")

        If dato.Read() Then
            r = dato.GetString(0)
        End If

        Return r
    End Function

    Public Function ReturnPasswordActual(id As String) As String
        Dim r = ""
        Dim dato = Db.Consult("select password from users where id =  " + id + "  ")

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

    Public Sub Users_DataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("username", "Username")
        t.Columns.Add("Nombre", "Nombre")
        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(3))
            Loop
        End If

    End Sub

    Public Sub Logs_DataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("client", "Cliente")
        t.Columns.Add("numero", "Numero")
        t.Columns.Add("direccion", "Direccion")
        t.Columns.Add("atendio", "Atendio")
        t.Columns.Add("modelo", "Vehiculo")
        t.Columns.Add("driver", "Conductor")
        t.Columns.Add("hour_llamada", "Fecha llamada")
        t.Columns.Add("hour_atencion", "Llamada atendida")
        t.Columns.Add("hour_finaliza", "Llamada finalizada")


        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6), dato.GetString(7), dato.GetString(8), dato.GetString(9))
            Loop
        End If

    End Sub

    Public Sub LogsOmitidos_DataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("client", "CLIENTE")
        t.Columns.Add("numero", "NUMERO")
        t.Columns.Add("hour_llamada", "FECHA LLAMADA")
        t.Columns.Add("atendio", "ATENDIO")
        t.Columns.Add("estatus", "ESTATUS")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5))
            Loop
        End If

    End Sub

    Public Sub Logs_DataGridViewSet_fecha(ByVal sql As String, ByVal t As DataGridView, F_desde As DateTimePicker, f_hasta As DateTimePicker)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("client", "Cliente")
        t.Columns.Add("numero", "Numero")
        t.Columns.Add("direccion", "Direccion")
        t.Columns.Add("atendio", "Atendio")
        t.Columns.Add("modelo", "Vehiculo")
        t.Columns.Add("driver", "Conductor")
        t.Columns.Add("hour_llamada", "Fecha llamada")
        t.Columns.Add("hour_atencion", "Llamada atendida")
        t.Columns.Add("hour_finaliza", "Llamada finalizada")

        Dim tmp1 = New DateTime(F_desde.Value.Year, F_desde.Value.Month, F_desde.Value.Day, 0, 0, 0)
        F_desde.Value = tmp1
        Dim tmp2 = New DateTime(f_hasta.Value.Year, f_hasta.Value.Month, f_hasta.Value.Day, 23, 59, 59)
        f_hasta.Value = tmp2

        If dato.HasRows Then
            Do While dato.Read()
                Dim FechaDB = New DateTime()
                FechaDB = Convert.ToDateTime(dato.GetString(7))

                If FechaDB.CompareTo(Convert.ToDateTime(F_desde.Value)) >= 0 And FechaDB.CompareTo(Convert.ToDateTime(f_hasta.Value)) <= 0 Then
                    t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6), dato.GetString(7), dato.GetString(8), dato.GetString(9))
                End If

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

    Public Sub Vehicles_DataGridViewSet(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("modelo", "Modelo")
        t.Columns.Add("placa", "Matricula")
        t.Columns.Add("conductor", "Conductor")
        t.Columns.Add("Numero", "Numero")
        t.Columns.Add("caracteristica", "Caracteristica")
        t.Columns.Add("id_gps", "Gps")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6))
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

    Public Shared Function Logs_clean() As Boolean
        Return Db_shared.Ejecutar("truncate registros")
    End Function

    Public Shared Function Logs_delete() As Boolean
        Return Db_shared.Ejecutar("delete from registros where id = " + log_id + " ")
    End Function

    Public Shared Function Logs_delete_omitidas() As Boolean
        Return Db_shared.Ejecutar("delete from registros_omitidos where id = " + log_id_omitidas + " ")
    End Function

    Public Shared Function Vehicle_delete() As Boolean
        Return Db_shared.Ejecutar("delete from vehicles where id = " + Vehicle_id + " ")
    End Function

    Public Shared Function Driver_delete() As Boolean
        Return Db_shared.Ejecutar("delete from drivers where id = " + Driver_id + " ")
    End Function

    Public Shared Function User_delete() As Boolean
        Return Db_shared.Ejecutar("delete from users where id = " + user_select + " ")
    End Function

    Public Shared Function Clients_AdressDELETE() As Boolean
        Return Db_shared.Ejecutar("delete from adresses where id = " + Adress_id + " ")
    End Function

    Public Shared Function Clients_NumberDelete(ByVal id_number As String) As Boolean
        Return Db_shared.Ejecutar("delete from telephone_numbers where id = " + id_number + " ")
    End Function

    Public Shared Function Clients_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from clients where id = " + Client + " ")
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

    Public Sub Vehicle_LoadUpdate(ByVal TxtModelo As TextBox, ByVal TxtMatricula As TextBox, ByVal TxtNumeroUnidad As TextBox, ByVal TxtCaracteristicas As TextBox, ByVal t As DataGridView, ByVal TxtGps As TextBox)
        Dim dato = Db.Consult("select * from vehicles where id =  '" + Vehicle_id + "'  ")

        If dato.Read() Then
            TxtModelo.Text = dato.GetString(1)
            TxtMatricula.Text = dato.GetString(2)
            Driver_id = dato.GetString(3)
            TxtNumeroUnidad.Text = dato.GetString(4)
            TxtCaracteristicas.Text = dato.GetString(5)
            TxtGps.Text = dato.GetString(6)
            For Each row As DataGridViewRow In t.Rows
                If t.Item(0, row.Index).Value = Driver_id Then
                    t.CurrentCell = t.Rows(row.Index).Cells(0)
                End If
            Next

        End If
    End Sub

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

    Public Shared Function Parameters_Update(ByVal TxtNombre As TextBox, ByVal TxtDireccion As TextBox, ByVal TxtRFC As TextBox) As Boolean
        Return Db_shared.Ejecutar("UPDATE properties SET name_enterprise = '" + TxtNombre.Text.ToUpper + "' , direccion = '" + TxtDireccion.Text.ToUpper + "', rfc = '" + TxtRFC.Text.ToUpper + "' WHERE id =  1 ")
    End Function

    Public Shared Function Client_AdressUPDATE(ByVal TxtDireccion As TextBox, ByVal TxtReferencia As TextBox, ByVal TxtKm As TextBox) As Boolean
        Return Db_shared.Ejecutar("UPDATE adresses SET client = " + Client + ", direccion = '" + TxtDireccion.Text.ToUpper + "', referencia = '" + TxtReferencia.Text.ToUpper + "', kms = " + TxtKm.Text + " WHERE id = " + Adress_id + " ")
    End Function

    Public Shared Function Vehicle_UPDATE(ByVal TxtModelo As TextBox, ByVal TxtPlaca As TextBox, ByVal TxtNumero As TextBox, ByVal TxtCaracteristicas As TextBox, ByVal TxtGps As TextBox) As Boolean
        Return Db_shared.Ejecutar("UPDATE vehicles SET modelo = '" + TxtModelo.Text.ToUpper + "', placas = '" + TxtPlaca.Text.ToUpper + "', driver = " + Driver_id + ", numero = '" + TxtNumero.Text.ToUpper + "', caracteristicas = '" + TxtCaracteristicas.Text.ToUpper + "', id_gps  = '" + TxtGps.Text.ToUpper + "' WHERE id = " + Vehicle_id + "  ")
    End Function

    Public Shared Function Clients_NumberADD(ByVal TxtNumero As TextBox, ByVal TxtCompañia As TextBox, ByVal TxtMovil As RadioButton, ByVal Txtfijo As RadioButton, ByVal TxtRef As TextBox) As Boolean
        If TxtMovil.Checked Then
            Return Db_shared.Ejecutar("INSERT INTO telephone_numbers (client, numero, compañia, fijo, movil, ref_note) VALUES (" + Client + ", '" + TxtNumero.Text.Replace(" ", "") + "', '" + TxtCompañia.Text.ToUpper + "', '0', '1', '" + TxtRef.Text.ToUpper + "' )")
        Else
            Return Db_shared.Ejecutar("INSERT INTO telephone_numbers (client, numero, compañia, fijo, movil, ref_note) VALUES (" + Client + ", '" + TxtNumero.Text.Replace(" ", "") + "', '" + TxtCompañia.Text.ToUpper + "', '1', '0', '" + TxtRef.Text.ToUpper + "' )")
        End If
    End Function

    Public Shared Function Drivers_ADD(ByVal Txtmodelo As TextBox, ByVal TxtPlaca As TextBox, ByVal TxtNumero As TextBox, ByVal TxtCaracteristicas As TextBox, ByVal TxtGps As TextBox) As Boolean
        Return Db_shared.Ejecutar("INSERT INTO vehicles (modelo, placas, driver, numero, caracteristicas,id_gps ) VALUES ('" + Txtmodelo.Text.ToUpper + "', '" + TxtPlaca.Text.ToUpper + "', " + Driver_id + ", '" + TxtNumero.Text.ToUpper + "', '" + TxtCaracteristicas.Text.ToUpper + "', '" + TxtGps.Text.ToUpper + "')")
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

    Public Sub GenReport(ByVal t As DataGridView, cadena As String, rotate As Boolean)
        Dim filename = My.Settings.data_url + "\report_tmp.pdf"

        Dim doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER)
        If rotate Then
            doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER.Rotate)
        End If

        Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create))
        doc.AddTitle("REPORTE CLTA - CALLER")
        doc.AddCreator("clta")
        doc.Open()

        If File.Exists(My.Settings.report_image) Then
            Dim fs = New FileStream(My.Settings.report_image, FileMode.Open, FileAccess.Read)
            Dim imagen = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), iTextSharp.text.BaseColor.WHITE)
            imagen.ScaleToFit(140, 140)
            imagen.Alignment = iTextSharp.text.Element.ALIGN_RIGHT
            Dim logo = New iTextSharp.text.Chunk(imagen, 375, -98)
            If rotate Then
                logo = New iTextSharp.text.Chunk(imagen, 500, -98)
            End If
            doc.Add(logo)
        End If

        Dim _standardFontTitle = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFontSubTitle = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFont = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFontCell = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)

        doc.Add(New iTextSharp.text.Paragraph(ReturnEmpresa_Parametros(Empresa_Nombre), _standardFontTitle))
        doc.Add(New iTextSharp.text.Paragraph("DOCUMENTO: " + cadena.ToUpper, _standardFontSubTitle))
        doc.Add(New iTextSharp.text.Paragraph("FECHA Y HORA DE GENERACION: " + DateTime.Now.ToString, _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("DIRECCION: " + ReturnEmpresa_Parametros(Empresa_Direccion), _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("RFC: " + ReturnEmpresa_Parametros(Empresa_Rfc), _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("USUARIO QUE GENERO: " + ReturnUsername(), _standardFont))

        doc.Add(iTextSharp.text.Chunk.NEWLINE)

        Dim tabla = New iTextSharp.text.pdf.PdfPTable(t.ColumnCount)
        tabla.WidthPercentage = 100

        'Adding Header row
        For Each column As DataGridViewColumn In t.Columns
            Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(column.HeaderText.ToUpper, _standardFontTitle))
            tabla.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In t.Rows
            For Each cell As DataGridViewCell In row.Cells
                If String.IsNullOrEmpty(cell.Value) = False Then
                    Dim tmp = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(cell.Value.ToString(), _standardFontCell))
                    tabla.AddCell(tmp)
                End If
            Next
        Next

        Dim ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("CONCEPTO", _standardFont))
        ClId.BorderWidth = 0
        ClId.BorderWidthBottom = 0.75F


        tabla.AddCell(ClId)

        ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("ssssss", _standardFont))
        ClId.BorderWidth = 0
        tabla.AddCell(ClId)

        doc.Add(tabla)

        Dim _FontFooter = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)
        Dim footer = New iTextSharp.text.Paragraph("WWW.CYBERCHOAPAS.COM", _FontFooter)
        footer.Alignment = 1
        doc.Add(footer)

        doc.Close()
        writer.Close()
        Dim prc = New System.Diagnostics.Process()
        prc.StartInfo.FileName = filename
        prc.Start()
    End Sub

    Public Sub ComboBox_SetNumeros_Client(ByVal c As ComboBox)
        c.Items.Clear()
        Dim dato = Db.Consult("SELECT * FROM telephone_numbers where client = " + Client + " ")
        c.Items.Add("Numeros de telefono")
        ListNumeros.Add(0)
        If dato.HasRows Then
            Do While dato.Read()
                c.Items.Add(dato.GetString(2))
                ListNumeros.Add(dato.GetString(0))
            Loop
        End If
        c.SelectedIndex = 0
    End Sub

    Public Sub ComboBox_SetDireccion_Client(ByVal c As ComboBox)
        c.Items.Clear()
        Dim dato = Db.Consult("SELECT * FROM adresses where client = " + Client + " order by id desc ")
        c.Items.Add("DIRECCIONES")
        ListDireccion.Add(0)
        If dato.HasRows Then
            Do While dato.Read()
                c.Items.Add(dato.GetString(2))
                ListDireccion.Add(dato.GetString(0))
            Loop
        End If
        If c.Items.Count > 1 Then
            c.SelectedIndex = 1
        End If

    End Sub

    Public Sub ComboBox_SetDrivers(ByVal c As ComboBox)
        c.Items.Clear()
        Dim dato = Db.Consult("SELECT * FROM drivers ORDER by nombre asc")
        c.Items.Add("CONDUCTORES")
        ListConductor.Add(0)
        If dato.HasRows Then
            Do While dato.Read()
                c.Items.Add(dato.GetString(1))
                ListConductor.Add(dato.GetString(0))
            Loop
        End If
        c.SelectedIndex = 0
    End Sub

    Public Sub ComboBox_SetDriversConID(ByVal c As ComboBox)
        ListConductor.Clear()
        c.Items.Clear()
        Dim dato = Db.Consult("SELECT * FROM drivers ORDER by nombre asc")
        c.Items.Add("Conductores")
        ListConductor.Add(0)
        If dato.HasRows Then
            Do While dato.Read()
                c.Items.Add(dato.GetString(1) + " [" + dato.GetString(0) + "]")
                ListConductor.Add(dato.GetString(0))
            Loop
        End If
        c.SelectedIndex = 0
    End Sub

    Public Sub ComboBox_SetUsers(ByVal c As ComboBox)
        c.Items.Clear()
        Dim dato = Db.Consult("SELECT id, name FROM users")
        c.Items.Add("USUARIOS")
        ListUsuarios.Add(0)
        If dato.HasRows Then
            Do While dato.Read()
                c.Items.Add(dato.GetString(1))
                ListUsuarios.Add(dato.GetString(0))
            Loop
        End If
        c.SelectedIndex = 0
    End Sub

    Public Sub ComboBox_SetVehiculos(ByVal c As ComboBox)
        c.Items.Clear()
        Dim dato = Db.Consult("SELECT id, modelo FROM vehicles")
        c.Items.Add("VEHICULOS")
        ListVehiculos.Add(0)
        If dato.HasRows Then
            Do While dato.Read()
                c.Items.Add(dato.GetString(1))
                ListVehiculos.Add(dato.GetString(0))
            Loop
        End If
        c.SelectedIndex = 0
    End Sub

    Public Sub ComboBox_SetVehiculosConID(ByVal c As ComboBox)
        ListVehiculos.Clear()
        ListVehiculos.Add(0)
        c.Items.Clear()
        Dim dato = Db.Consult("SELECT id, modelo FROM vehicles")
        c.Items.Add("Vehiculos")

        If dato.HasRows Then
            Do While dato.Read()
                c.Items.Add(dato.GetString(1) + " [" + dato.GetString(0) + "]")
                ListVehiculos.Add(dato.GetString(0))
            Loop
        End If
        c.SelectedIndex = 0
    End Sub

    Public Sub Picturebox_SetImageClient(ByVal p As PictureBox)

        Dim dato = Db.Consult("select foto from clients where id =  " + Client + "  ")

        If dato.Read() Then
            Try
                If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + dato.GetString(0)) Then
                    p.Image = Image.FromFile(My.Settings.data_url + Data_clients + dato.GetString(0))
                Else
                    p.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
                End If
            Catch ex As Exception
                Alert(ex.Message, Alert_NumberCritical)
            End Try
        End If
        p.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Public Function save_registroMANUAL(ByVal usuario As ComboBox, ByVal direccion As ComboBox, ByVal vehiculo As ComboBox, ByVal driver As ComboBox, ByVal fecha As DateTimePicker)
        Dim cliente = Client
        Dim numero = Number_id
        Dim _usuario = ListUsuarios.Item(usuario.SelectedIndex).ToString
        Dim _direccion = ListDireccion.Item(direccion.SelectedIndex).ToString
        Dim _vehiculo = ListVehiculos.Item(vehiculo.SelectedIndex).ToString
        Dim _conductor = ListConductor.Item(driver.SelectedIndex).ToString
        Dim hora_llamada = (fecha.Value.Year).ToString + "-" + (fecha.Value.Month).ToString + "-" + (fecha.Value.Day).ToString
        Dim AtencionLlamada = (fecha.Value.Year).ToString + "-" + (fecha.Value.Month).ToString + "-" + (fecha.Value.Day).ToString
        Dim FinalizaLlamada = (fecha.Value.Year).ToString + "-" + (fecha.Value.Month).ToString + "-" + (fecha.Value.Day).ToString
        Return Db_shared.Ejecutar("INSERT INTO registros (client, telefono, hora_llamada, atencion_llamada, finaliza_llamada, usuario, direccion, vehicle, driver) VALUES (" + cliente + ", " + numero + ", '" + hora_llamada + "', '" + AtencionLlamada + "', '" + FinalizaLlamada + "', " + _usuario + ", " + _direccion + ", " + _vehiculo + ", " + _conductor + ")")

    End Function

    Public Function save_registroAutomatic(ByVal client As Integer, ByVal telefono As String, ByVal hora_llamada As Date, ByVal atencion_llamada As Date, ByVal finaliza_llamada As Date, ByVal direccion As Integer, ByVal vehiculo As Integer, ByVal driver As Integer)
        Return Db_shared.Ejecutar("INSERT INTO registros (client, telefono, hora_llamada, atencion_llamada, finaliza_llamada, usuario, direccion, vehicle, driver) VALUES ('" + client.ToString + "', '" + telefono.ToString + "', '" + ReturnDateFormatString(hora_llamada) + "', '" + ReturnDateFormatString(atencion_llamada) + "', '" + ReturnDateFormatString(finaliza_llamada) + "', '" + userID.ToString + "', '" + direccion.ToString + "', '" + vehiculo.ToString + "', '" + driver.ToString + "')")
    End Function

    Private Function ReturnDateFormatString(ByVal fecha As Date) As String
        Return fecha.Year.ToString + "-" + fecha.Month.ToString + "-" + fecha.Day.ToString + " " + fecha.Hour.ToString + ":" + fecha.Minute.ToString + ":" + fecha.Second.ToString
    End Function


    Public Function Users_ADD(ByVal username As TextBox, ByVal password As TextBox, ByVal name As TextBox)
        Dim r As Boolean = Db_shared.Ejecutar("INSERT INTO users (username, password, name) VALUES ('" + username.Text + "', '" + EncriptMD5(password.Text) + "', '" + name.Text.ToUpper + "')")
        If r Then
            Return User_MAXID()
        Else
            Return 0
        End If
    End Function

    Public Function Users_ADD_Permisos(
        ByVal user As String,
        ByVal acces_clients As CheckBox,
        ByVal acces_numbersTelephone As CheckBox,
        ByVal acces_adresses As CheckBox,
        ByVal acces_drivers As CheckBox,
        ByVal acces_vehicles As CheckBox,
        ByVal acces_logs As CheckBox,
        ByVal Clients_add As CheckBox,
        ByVal clients_edit As CheckBox,
        ByVal Clients_DELETE As CheckBox,
        ByVal adresses_add As CheckBox,
        ByVal adresses_edit As CheckBox,
        ByVal adresses_delete As CheckBox,
        ByVal telephone_add As CheckBox,
        ByVal telephone_edit As CheckBox,
        ByVal telephone_delete As CheckBox,
        ByVal Drivers_add As CheckBox,
        ByVal drivers_edit As CheckBox,
        ByVal drivers_delete As CheckBox,
        ByVal vehicles_add As CheckBox,
        ByVal vehicles_edit As CheckBox,
        ByVal vehicles_delete As CheckBox,
        ByVal Properties As CheckBox,
        ByVal logs_add As CheckBox,
        ByVal Logs_delete As CheckBox,
        ByVal Logs_clean As CheckBox,
        ByVal user_access As CheckBox,
        ByVal user_add As CheckBox,
        ByVal user_edit As CheckBox,
        ByVal User_delete As CheckBox,
        ByVal user_permisos As CheckBox,
        ByVal delete_oimitido As CheckBox,
        ByVal close_software As CheckBox)
        Return Db_shared.Ejecutar("INSERT INTO `permissions` (`user_id`, `acces_clients`, `acces_numbersTelephone`, `acces_adresses`, `acces_drivers`, `acces_vehicles`, `acces_logs`, `clients_add`, `clients_edit`, `clients_delete`, `adresses_add`, `adresses_edit`, `adresses_delete`, `telephone_add`, `telephone_edit`, `telephone_delete`, `drivers_add`, `drivers_edit`, `drivers_delete`, `vehicles_add`, `vehicles_edit`, `vehicles_delete`, `properties`, `logs_add`, `logs_delete`, `logs_clean`, `user_access`, `user_add`, `user_edit`, `user_delete`, `user_permisos`, `delete_omitido`, `close_software`) VALUES (" + user + ", " + CheckBox_RETURNSTATUS(acces_clients) + ", " + CheckBox_RETURNSTATUS(acces_numbersTelephone) + ", " + CheckBox_RETURNSTATUS(acces_adresses) + ", " + CheckBox_RETURNSTATUS(acces_drivers) + ", " + CheckBox_RETURNSTATUS(acces_vehicles) + ", " + CheckBox_RETURNSTATUS(acces_logs) + ", " + CheckBox_RETURNSTATUS(Clients_add) + ", " + CheckBox_RETURNSTATUS(clients_edit) + ", " + CheckBox_RETURNSTATUS(Clients_DELETE) + ", " + CheckBox_RETURNSTATUS(adresses_add) + ", " + CheckBox_RETURNSTATUS(adresses_edit) + ", " + CheckBox_RETURNSTATUS(adresses_delete) + ", " + CheckBox_RETURNSTATUS(telephone_add) + ", " + CheckBox_RETURNSTATUS(telephone_edit) + ", " + CheckBox_RETURNSTATUS(telephone_delete) + ", " + CheckBox_RETURNSTATUS(Drivers_add) + ", " + CheckBox_RETURNSTATUS(drivers_edit) + ", " + CheckBox_RETURNSTATUS(drivers_delete) + ", " + CheckBox_RETURNSTATUS(vehicles_add) + ", " + CheckBox_RETURNSTATUS(vehicles_edit) + ", " + CheckBox_RETURNSTATUS(vehicles_delete) + ", " + CheckBox_RETURNSTATUS(Properties) + ", " + CheckBox_RETURNSTATUS(logs_add) + ", " + CheckBox_RETURNSTATUS(Logs_delete) + ", " + CheckBox_RETURNSTATUS(Logs_clean) + ", " + CheckBox_RETURNSTATUS(user_access) + ", " + CheckBox_RETURNSTATUS(user_add) + ", " + CheckBox_RETURNSTATUS(user_edit) + ", " + CheckBox_RETURNSTATUS(User_delete) + ", " + CheckBox_RETURNSTATUS(user_permisos) + ", " + CheckBox_RETURNSTATUS(delete_oimitido) + ", " + CheckBox_RETURNSTATUS(close_software) + ")")
    End Function

    Private Function CheckBox_RETURNSTATUS(ByVal c As CheckBox)
        Dim r As String
        If c.Checked Then
            r = 1
        Else
            r = 0
        End If
        Return r
    End Function

    Public Function User_MAXID() As Integer
        Dim dato = Db.Consult("SELECT MAX(id) AS id FROM users")
        If dato.Read() Then
            Return dato.GetString(0)
        Else
            Return 0
        End If
    End Function

    Public Sub values_permisos(
        ByVal TxtUsername As TextBox,
        ByVal TxtPassword As TextBox,
        ByVal TxtName As TextBox,
        ByVal acces_clients As CheckBox,
        ByVal acces_numbersTelephone As CheckBox,
        ByVal acces_adresses As CheckBox,
        ByVal acces_drivers As CheckBox,
        ByVal acces_vehicles As CheckBox,
        ByVal acces_logs As CheckBox,
        ByVal Clients_add As CheckBox,
        ByVal clients_edit As CheckBox,
        ByVal Clients_DELETE As CheckBox,
        ByVal adresses_add As CheckBox,
        ByVal adresses_edit As CheckBox,
        ByVal adresses_delete As CheckBox,
        ByVal telephone_add As CheckBox,
        ByVal telephone_edit As CheckBox,
        ByVal telephone_delete As CheckBox,
        ByVal Drivers_add As CheckBox,
        ByVal drivers_edit As CheckBox,
        ByVal drivers_delete As CheckBox,
        ByVal vehicles_add As CheckBox,
        ByVal vehicles_edit As CheckBox,
        ByVal vehicles_delete As CheckBox,
        ByVal Properties As CheckBox,
        ByVal logs_add As CheckBox,
        ByVal Logs_delete As CheckBox,
        ByVal Logs_clean As CheckBox,
        ByVal user_access As CheckBox,
        ByVal user_add As CheckBox,
        ByVal user_edit As CheckBox,
        ByVal User_delete As CheckBox,
        ByVal user_permisos As CheckBox,
        ByVal delete_omitidos As CheckBox,
        ByVal close_software As CheckBox)

        Dim d = Db.Consult("SELECT * FROM users where id = " + user_select + " ")
        If d.Read() Then
            TxtUsername.Text = d.GetString(1)
            TxtPassword.Text = d.GetString(2)
            TxtName.Text = d.GetString(3)
        End If

        Dim p = Db.Consult("SELECT * FROM permissions where user_id = " + user_select + " ")
        If p.Read() Then
            acces_clients.Checked = p.GetBoolean(1)
            acces_numbersTelephone.Checked = p.GetBoolean(2)
            acces_adresses.Checked = p.GetBoolean(3)
            acces_drivers.Checked = p.GetBoolean(4)
            acces_vehicles.Checked = p.GetBoolean(5)
            acces_logs.Checked = p.GetBoolean(6)
            Clients_add.Checked = p.GetBoolean(7)
            clients_edit.Checked = p.GetBoolean(8)
            Clients_DELETE.Checked = p.GetBoolean(9)
            adresses_add.Checked = p.GetBoolean(10)
            adresses_edit.Checked = p.GetBoolean(11)
            adresses_delete.Checked = p.GetBoolean(12)
            telephone_add.Checked = p.GetBoolean(13)
            telephone_edit.Checked = p.GetBoolean(14)
            telephone_delete.Checked = p.GetBoolean(15)
            Drivers_add.Checked = p.GetBoolean(16)
            drivers_edit.Checked = p.GetBoolean(17)
            drivers_delete.Checked = p.GetBoolean(18)
            vehicles_add.Checked = p.GetBoolean(19)
            vehicles_edit.Checked = p.GetBoolean(20)
            vehicles_delete.Checked = p.GetBoolean(21)
            Properties.Checked = p.GetBoolean(22)
            logs_add.Checked = p.GetBoolean(23)
            Logs_delete.Checked = p.GetBoolean(24)
            Logs_clean.Checked = p.GetBoolean(25)
            user_access.Checked = p.GetBoolean(26)
            user_add.Checked = p.GetBoolean(27)
            user_edit.Checked = p.GetBoolean(28)
            User_delete.Checked = p.GetBoolean(29)
            user_permisos.Checked = p.GetBoolean(30)
            delete_omitidos.Checked = p.GetBoolean(31)
            close_software.Checked = p.GetBoolean(32)
        End If
    End Sub

    Public Function User_Update_Values(ByVal TxtUsername As TextBox, ByVal TxtPassword As TextBox, ByVal TxtName As TextBox)
        If ReturnPasswordActual(user_select) = TxtPassword.Text Then
            Return Db_shared.Ejecutar("UPDATE users SET username = '" + TxtUsername.Text + "', name = '" + TxtName.Text.ToUpper + "' WHERE id = " + user_select + " ")
        Else
            Return Db_shared.Ejecutar("UPDATE users SET username = '" + TxtUsername.Text + "', password = '" + EncriptMD5(TxtPassword.Text) + "', name = '" + TxtName.Text.ToUpper + "' WHERE id = " + user_select + " ")
        End If


    End Function

    Public Function User_Update_Permisos(
        ByVal acces_clients As CheckBox,
        ByVal acces_numbersTelephone As CheckBox,
        ByVal acces_adresses As CheckBox,
        ByVal acces_drivers As CheckBox,
        ByVal acces_vehicles As CheckBox,
        ByVal acces_logs As CheckBox,
        ByVal Clients_add As CheckBox,
        ByVal clients_edit As CheckBox,
        ByVal Clients_DELETE As CheckBox,
        ByVal adresses_add As CheckBox,
        ByVal adresses_edit As CheckBox,
        ByVal adresses_delete As CheckBox,
        ByVal telephone_add As CheckBox,
        ByVal telephone_edit As CheckBox,
        ByVal telephone_delete As CheckBox,
        ByVal Drivers_add As CheckBox,
        ByVal drivers_edit As CheckBox,
        ByVal drivers_delete As CheckBox,
        ByVal vehicles_add As CheckBox,
        ByVal vehicles_edit As CheckBox,
        ByVal vehicles_delete As CheckBox,
        ByVal Properties As CheckBox,
        ByVal logs_add As CheckBox,
        ByVal Logs_delete As CheckBox,
        ByVal Logs_clean As CheckBox,
        ByVal user_access As CheckBox,
        ByVal user_add As CheckBox,
        ByVal user_edit As CheckBox,
        ByVal User_delete As CheckBox,
        ByVal user_permisos As CheckBox,
        ByVal delete_omitidas As CheckBox,
        ByVal close_software As CheckBox)
        Return Db_shared.Ejecutar("UPDATE permissions SET acces_clients = '" + CheckBox_RETURNSTATUS(acces_clients) + "', acces_numbersTelephone = '" + CheckBox_RETURNSTATUS(acces_numbersTelephone) + "', acces_adresses = '" + CheckBox_RETURNSTATUS(acces_adresses) + "', acces_drivers = '" + CheckBox_RETURNSTATUS(acces_drivers) + "', acces_vehicles = '" + CheckBox_RETURNSTATUS(acces_vehicles) + "', acces_logs = '" + CheckBox_RETURNSTATUS(acces_logs) + "', clients_add = '" + CheckBox_RETURNSTATUS(Clients_add) + "', clients_edit = '" + CheckBox_RETURNSTATUS(clients_edit) + "', clients_delete = '" + CheckBox_RETURNSTATUS(Clients_DELETE) + "', adresses_add = '" + CheckBox_RETURNSTATUS(adresses_add) + "', adresses_edit = '" + CheckBox_RETURNSTATUS(adresses_edit) + "', adresses_delete = '" + CheckBox_RETURNSTATUS(adresses_delete) + "', telephone_add = '" + CheckBox_RETURNSTATUS(telephone_add) + "', telephone_edit = '" + CheckBox_RETURNSTATUS(telephone_edit) + "', telephone_delete = '" + CheckBox_RETURNSTATUS(telephone_delete) + "', drivers_add = '" + CheckBox_RETURNSTATUS(Drivers_add) + "', drivers_edit = '" + CheckBox_RETURNSTATUS(drivers_edit) + "', drivers_delete = '" + CheckBox_RETURNSTATUS(drivers_delete) + "', vehicles_add = '" + CheckBox_RETURNSTATUS(vehicles_add) + "', vehicles_edit = '" + CheckBox_RETURNSTATUS(vehicles_edit) + "', vehicles_delete = '" + CheckBox_RETURNSTATUS(vehicles_delete) + "', properties = '" + CheckBox_RETURNSTATUS(Properties) + "', logs_add = '" + CheckBox_RETURNSTATUS(logs_add) + "', logs_delete = '" + CheckBox_RETURNSTATUS(Logs_delete) + "', logs_clean = '" + CheckBox_RETURNSTATUS(Logs_clean) + "', user_access = '" + CheckBox_RETURNSTATUS(user_access) + "', user_add = '" + CheckBox_RETURNSTATUS(user_add) + "', user_edit = '" + CheckBox_RETURNSTATUS(user_edit) + "', user_delete = '" + CheckBox_RETURNSTATUS(User_delete) + "', user_permisos = '" + CheckBox_RETURNSTATUS(user_permisos) + "', delete_omitido = '" + CheckBox_RETURNSTATUS(delete_omitidas) + "', close_software = '" + CheckBox_RETURNSTATUS(close_software) + "' WHERE user_id = " + user_select + " ")
    End Function

    'Caller id
    Public Structure AD101DEVICEPARAMETER
        Public nRingOn As Integer
        Public nRingOff As Integer
        Public nHookOn As Integer
        Public nHookOff As Integer
        Public nStopCID As Integer
        Public nNoLine As Integer
        ' Add this parameter in new AD101(MCU Version is 6.0)
    End Structure

    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_InitDevice")>
    Public Shared Function AD101_InitDevice(ByVal hWnd As Integer) As Integer
    End Function

    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetDevice")>
    Public Shared Function AD101_GetDevice() As Integer
    End Function

    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetCPUVersion", CharSet:=CharSet.Ansi)>
    Public Shared Function AD101_GetCPUVersion(ByVal nLine As Integer, ByVal szCPUVersion As StringBuilder) As Integer
    End Function

    ' Start reading cpu id of device 
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_ReadCPUID")>
    Public Shared Function AD101_ReadCPUID(ByVal nLine As Integer) As Integer
    End Function

    ' Get readed cpu id of device 
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetCPUID", CharSet:=CharSet.Ansi)>
    Public Shared Function AD101_GetCPUID(ByVal nLine As Integer, ByVal szCPUID As StringBuilder) As Integer
    End Function



    ' Get caller id number  
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetCallerID", CharSet:=CharSet.Ansi)>
    Public Shared Function AD101_GetCallerID(ByVal nLine As Integer, ByVal szCallerIDBuffer As StringBuilder, ByVal szName As StringBuilder, ByVal szTime As StringBuilder) As Integer
    End Function

    ' Get dialed number 
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetDialDigit", CharSet:=CharSet.Ansi)>
    Public Shared Function AD101_GetDialDigit(ByVal nLine As Integer, ByVal szDialDigitBuffer As StringBuilder) As Integer
    End Function


    ' Get collateral phone dialed number 
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetCollateralDialDigit", CharSet:=CharSet.Ansi)>
    Public Shared Function AD101_GetCollateralDialDigit(ByVal nLine As Integer, ByVal szDialDigitBuffer As StringBuilder) As Integer
    End Function



    ' Get last line state 
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetState")>
    Public Shared Function AD101_GetState(ByVal nLine As Integer) As Integer
    End Function

    ' Get ring count
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetRingIndex")>
    Public Shared Function AD101_GetRingIndex(ByVal nLine As Integer) As Integer
    End Function

    ' Get talking time
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetTalkTime")>
    Public Shared Function AD101_GetTalkTime(ByVal nLine As Integer) As Integer
    End Function


    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetParameter")>
    Public Shared Function AD101_GetParameter(ByVal nLine As Integer, ByRef tagParameter As AD101DEVICEPARAMETER) As Integer
    End Function

    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_ReadParameter")>
    Public Shared Function AD101_ReadParameter(ByVal nLine As Integer) As Integer
    End Function

    ' Set systematic parameter  
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_SetParameter")>
    Public Shared Function AD101_SetParameter(ByVal nLine As Integer, ByRef tagParameter As AD101DEVICEPARAMETER) As Integer
    End Function

    ' Free devices 

    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_FreeDevice")>
    Public Shared Sub AD101_FreeDevice()
    End Sub

    ' Get current AD101 device count
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_GetCurDevCount")>
    Public Shared Function AD101_GetCurDevCount() As Integer
    End Function

    ' Change handle of window that uses to receive message
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_ChangeWindowHandle")>
    Public Shared Function AD101_ChangeWindowHandle(ByVal hWnd As Integer) As Integer
    End Function

    ' Show or don't show collateral phone dialed number
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_ShowCollateralPhoneDialed")>
    Public Shared Sub AD101_ShowCollateralPhoneDialed(ByVal bShow As Boolean)
    End Sub

    ' Control led 
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_SetLED")>
    Public Shared Function AD101_SetLED(ByVal nLine As Integer, ByVal enumLed As Integer) As Integer
    End Function


    ' Control line connected with ad101 device to busy or idel
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_SetBusy")>
    Public Shared Function AD101_SetBusy(ByVal nLine As Integer, ByVal enumLineBusy As Integer) As Integer
    End Function

    ' Set line to start talking than start timer
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_SetLineStartTalk")>
    Public Shared Function AD101_SetLineStartTalk(ByVal nLine As Integer) As Integer
    End Function


    ' Set time to start talking after dialed number 
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_SetDialOutStartTalkingTime")>
    Public Shared Function AD101_SetDialOutStartTalkingTime(ByVal nSecond As Integer) As Integer
    End Function


    ' Set ring end time
    <DllImport("C:\AD101Device.dll", EntryPoint:="AD101_SetRingOffTime")>
    Public Shared Function AD101_SetRingOffTime(ByVal nSecond As Integer) As Integer
    End Function

    Public Function AsignarNombreLinea(ByVal Device As Integer)
        Dim szCPUID As New StringBuilder(128)

        If Device = 0 And NumberDevice_0_set = False Then
            AD101_GetCPUID(Device, szCPUID)
            AsignarNumeroDeviceID(Device, szCPUID.ToString)
        ElseIf Device = 1 And NumberDevice_1_set = False Then
            AD101_GetCPUID(Device, szCPUID)
            AsignarNumeroDeviceID(Device, szCPUID.ToString)
        ElseIf Device = 2 And NumberDevice_2_set = False Then
            AD101_GetCPUID(Device, szCPUID)
            AsignarNumeroDeviceID(Device, szCPUID.ToString)
        ElseIf Device = 3 And NumberDevice_3_set = False Then
            AD101_GetCPUID(Device, szCPUID)
            AsignarNumeroDeviceID(Device, szCPUID.ToString)
        End If

    End Function

    Public Function ComprobarLlamada(ByVal Device As Integer) As String
        Dim r As String = ""

        Dim szCallerID As New StringBuilder(128)
        Dim szName As New StringBuilder(128)
        Dim szTime As New StringBuilder(128)
        AD101_GetCallerID(Device, szCallerID, szName, szTime)

        If Device = 0 Then
            If String.IsNullOrEmpty(szCallerID.ToString) = False Then
                If szCallerID.ToString <> LastNumber0 Then
                    r = szCallerID.ToString
                End If
            End If
        ElseIf Device = 1 Then
            If String.IsNullOrEmpty(szCallerID.ToString) = False Then
                If szCallerID.ToString <> LastNumber1 Then
                    r = szCallerID.ToString
                End If
            End If
        ElseIf Device = 2 Then
            If String.IsNullOrEmpty(szCallerID.ToString) = False Then
                If szCallerID.ToString <> LastNumber2 Then
                    r = szCallerID.ToString
                End If
            End If
        ElseIf Device = 3 Then
            If String.IsNullOrEmpty(szCallerID.ToString) = False Then
                If szCallerID.ToString <> LastNumber3 Then
                    r = szCallerID.ToString
                End If
            End If
        End If

        Return r
    End Function

    Private Function AsignarNumeroDeviceID(ByVal Device As Integer, ByVal szCPUID As String)
        Dim name_line = ""

        If szCPUID = My.Settings.id_device0.ToString Then
            name_line = My.Settings.caller_0_number
        ElseIf szCPUID = My.Settings.id_device1.ToString Then
            name_line = My.Settings.caller_1_number
        ElseIf szCPUID = My.Settings.id_device2.ToString Then
            name_line = My.Settings.caller_2_number
        ElseIf szCPUID = My.Settings.id_device3.ToString Then
            name_line = My.Settings.caller_3_number
        Else
            name_line = szCPUID
        End If

        If Device = 0 Then
            control.MenuLine0.Text = name_line
        ElseIf Device = 1 Then
            control.MenuLine1.Text = name_line
        ElseIf Device = 2 Then
            control.MenuLine2.Text = name_line
        ElseIf Device = 3 Then
            control.MenuLine3.Text = name_line
        End If

        If Device = 0 Then
            NumberDevice_0_set = True
        ElseIf Device = 1 Then
            NumberDevice_1_set = True
        ElseIf Device = 2 Then
            NumberDevice_2_set = True
        ElseIf Device = 3 Then
            NumberDevice_3_set = True
        End If
    End Function

    Public Function LoadNumber(ByVal number As Label, ByVal company As Label, ByVal client As Label, ByVal type As Label, ByVal ref As Label, ByVal foto As PictureBox) As String
        Dim result = ""
        Dim r = Db.Consult("SELECT t.id, t.compañia, c.nombre, t.ref_note, t.fijo, t.movil, c.foto FROM telephone_numbers t, clients c where t.client = c.id and  numero = " + number.Text + " ")
        If r.Read() Then
            company.Text = "Compañia: " + r.GetString(1)
            result = r.GetString(2)

            If (r.Getboolean(4)) Then
                type.Text = "Telefono fijo"
            End If

            If (r.Getboolean(5)) Then
                type.Text = "Telefono movil"
            End If

            ref.Text = "Observacion: " + r.GetString(3)

            foto.SizeMode = PictureBoxSizeMode.Zoom
            If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + r.GetString(6)) Then
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + r.GetString(6))
            Else
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
            End If

        Else
            result = "Desconocido"
        End If
        Return result
    End Function

    Public Function LoadNumber_Manual(ByRef number As String, ByVal foto As PictureBox, ByVal nombre_cliente As Label) As String
        Dim result = False
        Dim r = Db.Consult("SELECT c.nombre, c.foto, c.id, t.id FROM telephone_numbers t, clients c where t.client = c.id and  numero = " + number + " ")

        If r.Read() Then

            nombre_cliente.Text = r.GetString(0)

            foto.SizeMode = PictureBoxSizeMode.Zoom
            If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + r.GetString(1)) Then
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + r.GetString(1))
            Else
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
            End If

            result = True

            Client = r.GetString(2)
            Number_id = r.GetString(3)
        End If

        Return result
    End Function

    Public Function LoadNumberAsistencia(ByVal number As String, ByVal foto As PictureBox, ByVal direcciones As ComboBox, ByRef number_id As String, ByRef client_id As Integer) As String
        direcciones.Items.Clear()
        Dim result = ""
        Dim r = Db.Consult("SELECT c.id, c.nombre, c.foto, t.id FROM telephone_numbers t, clients c where t.client = c.id and  t.numero = '" + number + "' ")
        If r.Read() Then
            client_id = r.GetString(0)
            number_id = r.GetString(3)
            result = r.GetString(1)

            foto.SizeMode = PictureBoxSizeMode.Zoom
            If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + r.GetString(2)) Then
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + r.GetString(2))
            Else
                foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
            End If
            Dim p = Db.Consult("SELECT id, direccion, kms FROM adresses WHERE client = '" + r.GetString(0) + "' ")
            direcciones.Items.Add("Direcciones")
            If p.HasRows Then
                Do While p.Read()
                    direcciones.Items.Add(p.GetString(1) + " - kms: (" + p.GetString(2) + ") ID: [" + p.GetString(0) + "]")
                Loop
            End If
            direcciones.SelectedIndex = 0
        Else
            'Publico en general
            Dim p_g = Db.Consult("SELECT c.id, c.nombre, c.foto, t.id FROM telephone_numbers t, clients c where t.client = c.id and  t.numero = '" + My.Settings.pg_id + "' ")
            If p_g.Read() Then
                client_id = p_g.GetString(0)
                number_id = p_g.GetString(3)
                result = p_g.GetString(1)

                foto.SizeMode = PictureBoxSizeMode.Zoom
                If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + p_g.GetString(2)) Then
                    foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + p_g.GetString(2))
                Else
                    foto.Image = Image.FromFile(My.Settings.data_url + Data_clients + Clients_ImgDefault)
                End If

                Dim p_d = Db.Consult("SELECT c.id, a.id, c.nombre, a.direccion, a.kms FROM adresses a, clients c where a.client = c.id and c.id = '" + client_id.ToString + "'")
                direcciones.Items.Add("Direcciones")
                If p_d.HasRows Then
                    Do While p_d.Read()
                        direcciones.Items.Add(p_d.GetString(3) + " - kms: (" + p_d.GetString(4) + ") ID: [" + p_d.GetString(1) + "]")
                    Loop
                End If
                direcciones.SelectedIndex = 0
            End If
        End If

        direcciones.SelectedIndex = direcciones.Items.Count - 1

        Return result
    End Function

    Public Function ReturnClientID(ByVal number As String) As String
        Dim result = ""
        Dim r = Db.Consult("SELECT c.id FROM telephone_numbers t, clients c where t.client = c.id and  t.numero = '" + number + "' ")
        If r.Read() Then
            result = r.GetString(0)
        Else
            'Publico en general
            Dim p_g = Db.Consult("SELECT c.id FROM telephone_numbers t, clients c where t.client = c.id and  t.numero = '" + My.Settings.pg_id + "' ")
            If p_g.Read() Then
                result = p_g.GetString(0)
            End If
        End If
        Return result
    End Function

    Public Function ValidarLicence(ByVal code As TextBox) As Boolean
        Dim resultado As New Boolean
        resultado = False
        Dim r = Licence.Consult("SELECT status FROM licence where licence = '" + code.Text + "' and status = 0")
        If r.Read() Then
            resultado = Licence.Ejecutar("update licence set status = 1 where licence = '" + code.Text + "' ")
        End If
        Return resultado
    End Function

    Private Function EncriptMD5(ByVal password As String) As String
        Dim PasConMd5 = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(password.Replace(" ", ""))

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return PasConMd5
    End Function

    Public Function Vehicle_GetGPS(driver As Integer, Wb As WebBrowser) As Boolean
        Wb.Refresh()
        Dim r = False
        Dim nombre, idGps, modelo, placa, numero As String

        VehicleReturn_IdGps_Name(driver, idGps, nombre, modelo, placa, numero)
        Dim latitude As String
        Dim longitud As String
        Dim fecha As String

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create(My.Settings.ws_gps), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim json As JObject = JObject.Parse(rawresp)

        For Each Row In json
            Dim arr = Row.ToString.Split("""")
            Dim gpstmp As String

            For count = 0 To arr.Length - 1
                If arr(count).ToString.Replace(" ", "") = "id_gps" Then
                    gpstmp = arr(count + 2)
                End If
                If arr(count).ToString.Replace(" ", "") = "longitud" Then
                    longitud = arr(count + 1)
                End If
                If arr(count).ToString.Replace(" ", "") = "latitud" Then
                    latitude = arr(count + 1)
                End If
                If arr(count).ToString.Replace(" ", "") = "fecha_gps" Then
                    fecha = arr(count + 2)
                End If
                If gpstmp <> idGps Then
                    latitude = ""
                    longitud = ""
                    fecha = ""
                Else
                    latitude = latitude.Replace(":", "").Replace(",", "").Replace(" ", "")
                    longitud = longitud.Replace(":", "").Replace(",", "").Replace(" ", "")
                End If
            Next

        Next

        If VerificaNavegador() And String.IsNullOrEmpty(latitude) = False Then
            Wb.DocumentText =
            "<!DOCTYPE html>
            <html>
                <head>
                <title>Showing pixel and tile coordinates</title>
                <meta name='viewport' content='initial-scale=1.0'>
                <meta charset='utf-8'>
                <style>
                    /* Always set the map height explicitly to define the size of the div
                    * element that contains the map. */
                    #map {
                    height: 100%;
                    }
                    /* Optional: Makes the sample page fill the window. */
                    html, body {
                    height: 100%;
                    margin: 0;
                    padding: 0;
                    }
                </style>
                </head>
                <body>
                <div id='map'></div>
                <script>
                    function initMap() {
                    var chicago = new google.maps.LatLng(" + latitude + ", " + longitud + ");

                    var map = new google.maps.Map(document.getElementById('map'), {
                        center: chicago,
                        zoom: 17
                    });

                    var coordInfoWindow = new google.maps.InfoWindow();
                    coordInfoWindow.setContent(createInfoWindowContent(chicago, map.getZoom()));
                    coordInfoWindow.setPosition(chicago);
                    coordInfoWindow.open(map);

                    map.addListener('zoom_changed', function() {
                        coordInfoWindow.setContent(createInfoWindowContent(chicago, map.getZoom()));
                        coordInfoWindow.open(map);
                    });
                    }

                    var TILE_SIZE = 256;

                    function createInfoWindowContent(latLng, zoom) {
                    var scale = 1 << zoom;

                    var worldCoordinate = project(latLng);

                    var pixelCoordinate = new google.maps.Point(
                        Math.floor(worldCoordinate.x * scale),
                        Math.floor(worldCoordinate.y * scale));

                    var tileCoordinate = new google.maps.Point(
                        Math.floor(worldCoordinate.x * scale / TILE_SIZE),
                        Math.floor(worldCoordinate.y * scale / TILE_SIZE));

                    return [
                        '" + nombre + "',
                        'Modelo: " + modelo + " #" + numero + "',
                        'Matricula: " + placa + "',
                        'Ultima ubicacion: " + fecha + "',
                        'Zoom: ' + zoom
                    ].join('<br>');
                    }

                    // The mapping between latitude, longitude and pixels is defined by the web
                    // mercator projection.
                    function project(latLng) {
                    var siny = Math.sin(latLng.lat() * Math.PI / 180);

                    // Truncating to 0.9999 effectively limits latitude to 89.189. This is
                    // about a third of a tile past the edge of the world tile.
                    siny = Math.min(Math.max(siny, -0.9999), 0.9999);

                    return new google.maps.Point(
                        TILE_SIZE * (0.5 + latLng.lng() / 360),
                        TILE_SIZE * (0.5 - Math.log((1 + siny) / (1 - siny)) / (4 * Math.PI)));
                    }
                </script>
                <script async defer
                src='https://maps.googleapis.com/maps/api/js?key=AIzaSyB0theeomcG72Ewe3QKbRxc9BqbCfQxlus &callback=initMap'>
                </script>
                </body>
            </html>"
            r = True
        Else
            r = False
        End If

        Return r
    End Function

    Public Function VehicleReturn_IdGps_Name(driver As Integer, ByRef id_gps As String, ByRef nombre As String, ByRef modelo As String, ByRef placa As String, ByRef numero As String) As String
        Dim r As String
        Dim dato = Db.Consult("SELECT d.nombre, v.id_gps, v.modelo, v.placas, v.numero FROM drivers d, vehicles v WHERE v.driver = d.id and d.id = '" + driver.ToString + "'")

        If dato.Read() Then
            nombre = dato.GetString(0)
            id_gps = dato.GetString(1)
            modelo = dato.GetString(2)
            placa = dato.GetString(3)
            numero = dato.GetString(4)
        End If

        Return r
    End Function

    Private Function VerificaNavegador() As Boolean
        Dim versaoNavegador As Integer, RegVal As Integer
        Try
            ' Ontener version IE
            Using Wb As New WebBrowser()
                versaoNavegador = Wb.Version.Major
            End Using

            ' Define version IE
            If versaoNavegador >= 11 Then
                RegVal = 11001
            ElseIf versaoNavegador = 10 Then
                RegVal = 10001
            ElseIf versaoNavegador = 9 Then
                RegVal = 9999
            ElseIf versaoNavegador = 8 Then
                RegVal = 8888
            Else
                RegVal = 7000
            End If

            ' define a chave atual
            Dim Key As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
            Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord)
            Key.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ReturnDriver_Vehicle(var As Integer) As Integer
        Dim dato = Db.Consult("SELECT driver FROM vehicles where id = '" + var.ToString + "' ")
        If dato.Read() Then
            Return dato.GetString(0)
        Else
            Return 0
        End If
    End Function

    Public Sub SelectConductor(conductor As Integer, c As ComboBox)
        For i = 0 To ListConductor.Count - 1
            If ListConductor.Item(i) = conductor Then
                c.SelectedIndex = i
            End If
        Next i
    End Sub

    Public Function AddClientXpress(ByVal txt As TextBox, ByVal tel As String) As Boolean
        Dim r As Boolean = False

        Dim id = NextIDClients()
        Dim add_client = Db.Ejecutar("INSERT INTO `clients` (`id`, `nombre`, `fecha_nacimiento`, `correo_electronico`, `foto`, `razon_social`, `rfc`) VALUES ('" + id.ToString + "', '" + txt.Text + "', '1992-01-24', '', '', '', '');")

        If add_client Then
            r = Db.Ejecutar("INSERT INTO `telephone_numbers` (`id`, `client`, `numero`, `compañia`, `ref_note`, `fijo`, `movil`) VALUES (NULL, '" + id.ToString + "', '" + tel + "', '', '', '0', '1');")
        End If

        Return r
    End Function

    Public Function AddDireccionXpress(ByVal txt As TextBox, ByVal client As Integer) As Boolean
        Return Db.Ejecutar("INSERT INTO `adresses` (`id`, `client`, `direccion`, `referencia`, `kms`) VALUES (NULL, '" + client.ToString + "', '" + txt.Text + "', '', '1');")
    End Function

    Public Function NextIDClients() As Integer
        Dim r As Integer

        Dim dato = Db.Consult("SELECT (MAX(id)+1) AS id FROM clients")

        If dato.Read() Then
            r = dato.GetString(0)
        End If

        Return r
    End Function

    Public Sub LastLogs_DataGridViewSet(ByVal t As DataGridView)
        DataGridView_Model(t)
        Dim sql = "SELECT c.nombre, t.numero, d.direccion, dri.nombre FROM registros r, telephone_numbers t, users u, adresses d, vehicles v, drivers dri, clients c WHERE r.telefono = t.id and r.usuario = u.id and r.direccion = d.id and r.vehicle = v.id and r.driver = dri.id and r.client = c.id and r.usuario = '" + userID.ToString + "' ORDER BY r.id desc limit 0,15"
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(Sql)

        t.Columns.Add("client", "CLIENTE")
        t.Columns.Add("numero", "NUMERO")
        t.Columns.Add("direccion", "DIRECCION")
        t.Columns.Add("driver", "CONDUCTOR")


        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3))
            Loop
        End If

    End Sub

End Class