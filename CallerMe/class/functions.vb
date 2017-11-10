Public Class functions

    Dim Conexion As New Conexion
    Public Shared userID As Integer

    Public Sub forms_setmodel(ByVal form As Form)
        form.StartPosition = FormStartPosition.CenterScreen
        form.Icon = System.Drawing.Icon.FromHandle(My.Resources.ico.GetHicon())
        form.FormBorderStyle = FormBorderStyle.FixedToolWindow
        form.Text = "NOMBRE DE LA EMPRESA"
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
        Dim dato = Conexion.Conultar("select * from users where username = '" + username.Text + "' and password = '" + password.Text + "' ")

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

    Public Sub Alert(ByVal txt As String)
        MsgBox(txt.ToUpper(), MsgBoxStyle.Information, "Titulo")
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
End Class