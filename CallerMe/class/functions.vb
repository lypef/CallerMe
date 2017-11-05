Public Class functions

    Public Sub SetModelForm(ByVal form As Form)
        form.StartPosition = 1
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
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Desktop.Controls.Add(form)
        form.Show()
    End Sub

    Public Function Login()
        Return MsgBox("Inicio de session")
    End Function

End Class