Imports MySql.Data.MySqlClient

Public Class functions

    Dim Db As New Conexion
    Shared Db_shared As New Conexion

    Public Shared userID As String

    'Mensajes de alerta
    Public ReadOnly Alert_NoPermitido = "No permitido"

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


    Public Sub forms_setmodel(ByVal form As Form)
        form.Text = "NOMBRE DE LA EMPRESA - USUARIO: " + ReturnNameID(userID)
        form.Icon = System.Drawing.Icon.FromHandle(My.Resources.ico.GetHicon())
        form.FormBorderStyle = FormBorderStyle.Sizable
        form.MaximizeBox = False
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
        Return Db_shared.Ejecutar("INSERT INTO clients (nombre, fecha_nacimiento, direccion, referencia, correo_electronico, foto, razon_social, rfc) VALUES ('" + TxtNombre.Text.ToUpper + "', '" + (FechaNacimiento.Value.Year).ToString + "-" + (FechaNacimiento.Value.Month).ToString + "-" + (FechaNacimiento.Value.Day).ToString + "', '" + TxtDireccion.Text.ToUpper + "', '" + TxtReferencia.Text.ToUpper + "', '" + TxtCorreoElectronico.Text.ToUpper + "', '" + TxtFoto.Text.ToUpper + "', '" + TxtRazonSocial.Text.ToUpper + "', '" + TxtRfc.Text.ToUpper + "')")
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
End Class