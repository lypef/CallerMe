<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clients_add
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFoto = New System.Windows.Forms.TextBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRfc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Loader = New System.Windows.Forms.PictureBox()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.FechaNaci = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckImagen = New System.Windows.Forms.CheckBox()
        Me.CheckCamara = New System.Windows.Forms.CheckBox()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(34, 54)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(416, 29)
        Me.TxtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'BtnAdd
        '
        Me.BtnAdd.Image = Global.Calls.My.Resources.Resources.new_48
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(786, 229)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(102, 52)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "Agregar"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Correo electronico"
        '
        'TxtCorreoElectronico
        '
        Me.TxtCorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreoElectronico.Location = New System.Drawing.Point(34, 184)
        Me.TxtCorreoElectronico.Name = "TxtCorreoElectronico"
        Me.TxtCorreoElectronico.Size = New System.Drawing.Size(416, 29)
        Me.TxtCorreoElectronico.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Foto / Imagen"
        '
        'TxtFoto
        '
        Me.TxtFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFoto.Location = New System.Drawing.Point(472, 57)
        Me.TxtFoto.Name = "TxtFoto"
        Me.TxtFoto.Size = New System.Drawing.Size(335, 29)
        Me.TxtFoto.TabIndex = 10
        '
        'BtnFoto
        '
        Me.BtnFoto.Location = New System.Drawing.Point(813, 57)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(75, 29)
        Me.BtnFoto.TabIndex = 8
        Me.BtnFoto.Text = "Examinar"
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(468, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Rfc"
        '
        'TxtRfc
        '
        Me.TxtRfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRfc.Location = New System.Drawing.Point(472, 184)
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(416, 29)
        Me.TxtRfc.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(472, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Razon social"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRazonSocial.Location = New System.Drawing.Point(472, 119)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(416, 29)
        Me.TxtRazonSocial.TabIndex = 9
        '
        'Loader
        '
        Me.Loader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Loader.Dock = System.Windows.Forms.DockStyle.Top
        Me.Loader.Location = New System.Drawing.Point(0, 0)
        Me.Loader.Name = "Loader"
        Me.Loader.Size = New System.Drawing.Size(927, 18)
        Me.Loader.TabIndex = 101
        Me.Loader.TabStop = False
        '
        'Foto
        '
        Me.Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Foto.Location = New System.Drawing.Point(33, 219)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(416, 229)
        Me.Foto.TabIndex = 11
        Me.Foto.TabStop = False
        '
        'FechaNaci
        '
        Me.FechaNaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FechaNaci.Location = New System.Drawing.Point(34, 119)
        Me.FechaNaci.Name = "FechaNaci"
        Me.FechaNaci.Size = New System.Drawing.Size(416, 29)
        Me.FechaNaci.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Fecha de nacimiento"
        '
        'CheckImagen
        '
        Me.CheckImagen.AutoSize = True
        Me.CheckImagen.Location = New System.Drawing.Point(746, 35)
        Me.CheckImagen.Name = "CheckImagen"
        Me.CheckImagen.Size = New System.Drawing.Size(61, 17)
        Me.CheckImagen.TabIndex = 6
        Me.CheckImagen.Text = "Imagen"
        Me.CheckImagen.UseVisualStyleBackColor = True
        '
        'CheckCamara
        '
        Me.CheckCamara.AutoSize = True
        Me.CheckCamara.Location = New System.Drawing.Point(826, 35)
        Me.CheckCamara.Name = "CheckCamara"
        Me.CheckCamara.Size = New System.Drawing.Size(62, 17)
        Me.CheckCamara.TabIndex = 7
        Me.CheckCamara.Text = "Camara"
        Me.CheckCamara.UseVisualStyleBackColor = True
        '
        'Clients_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 457)
        Me.Controls.Add(Me.CheckCamara)
        Me.Controls.Add(Me.CheckImagen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FechaNaci)
        Me.Controls.Add(Me.Loader)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtRfc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.BtnFoto)
        Me.Controls.Add(Me.Foto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtFoto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCorreoElectronico)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Name = "Clients_add"
        Me.Text = "Clients_add"
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreoElectronico As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFoto As TextBox
    Friend WithEvents Foto As PictureBox
    Friend WithEvents BtnFoto As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRfc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents Loader As PictureBox
    Friend WithEvents FechaNaci As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckImagen As CheckBox
    Friend WithEvents CheckCamara As CheckBox
End Class
