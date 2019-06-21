<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogsADD
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
        Me.Combo_Users = New System.Windows.Forms.ComboBox()
        Me.Combo_direcciones = New System.Windows.Forms.ComboBox()
        Me.ComboVehiculos = New System.Windows.Forms.ComboBox()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Combo_Driver = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.foto = New System.Windows.Forms.PictureBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cliente_name = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Combo_Users
        '
        Me.Combo_Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Users.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.12727!)
        Me.Combo_Users.FormattingEnabled = True
        Me.Combo_Users.Location = New System.Drawing.Point(542, 108)
        Me.Combo_Users.Name = "Combo_Users"
        Me.Combo_Users.Size = New System.Drawing.Size(372, 28)
        Me.Combo_Users.TabIndex = 2
        '
        'Combo_direcciones
        '
        Me.Combo_direcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_direcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_direcciones.FormattingEnabled = True
        Me.Combo_direcciones.Location = New System.Drawing.Point(587, 68)
        Me.Combo_direcciones.Name = "Combo_direcciones"
        Me.Combo_direcciones.Size = New System.Drawing.Size(327, 28)
        Me.Combo_direcciones.TabIndex = 3
        '
        'ComboVehiculos
        '
        Me.ComboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboVehiculos.FormattingEnabled = True
        Me.ComboVehiculos.Location = New System.Drawing.Point(566, 148)
        Me.ComboVehiculos.Name = "ComboVehiculos"
        Me.ComboVehiculos.Size = New System.Drawing.Size(348, 28)
        Me.ComboVehiculos.TabIndex = 4
        '
        'Fecha
        '
        Me.Fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.12727!)
        Me.Fecha.Location = New System.Drawing.Point(642, 228)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(272, 27)
        Me.Fecha.TabIndex = 5
        Me.Fecha.Value = New Date(2017, 12, 3, 22, 52, 56, 0)
        '
        'Combo_Driver
        '
        Me.Combo_Driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.12727!)
        Me.Combo_Driver.FormattingEnabled = True
        Me.Combo_Driver.Location = New System.Drawing.Point(599, 188)
        Me.Combo_Driver.Name = "Combo_Driver"
        Me.Combo_Driver.Size = New System.Drawing.Size(315, 28)
        Me.Combo_Driver.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(444, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "FECHA DE LLAMADA:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cliente_name)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.foto)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.Combo_direcciones)
        Me.Panel1.Controls.Add(Me.Combo_Users)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Fecha)
        Me.Panel1.Controls.Add(Me.Combo_Driver)
        Me.Panel1.Controls.Add(Me.ComboVehiculos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 436)
        Me.Panel1.TabIndex = 17
        '
        'foto
        '
        Me.foto.Location = New System.Drawing.Point(12, 12)
        Me.foto.Name = "foto"
        Me.foto.Size = New System.Drawing.Size(418, 297)
        Me.foto.TabIndex = 18
        Me.foto.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(448, 273)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(466, 36)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "GUARDAR"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(777, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(448, 16)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(320, 28)
        Me.TxtSearch.TabIndex = 19
        Me.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(444, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "DIRECCIONES:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(444, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "USUARIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "VEHICULOS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "CONDUCTORES:"
        '
        'cliente_name
        '
        Me.cliente_name.AutoSize = True
        Me.cliente_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.21818!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente_name.Location = New System.Drawing.Point(5, 367)
        Me.cliente_name.Name = "cliente_name"
        Me.cliente_name.Size = New System.Drawing.Size(911, 42)
        Me.cliente_name.TabIndex = 26
        Me.cliente_name.Text = "FRANCISCO EDUARDO ASCENCIO DOMINGUEZ"
        Me.cliente_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogsADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 436)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LogsADD"
        Me.Text = "LogsADD"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Combo_Users As ComboBox
    Friend WithEvents Combo_direcciones As ComboBox
    Friend WithEvents ComboVehiculos As ComboBox
    Friend WithEvents Fecha As DateTimePicker
    Friend WithEvents Combo_Driver As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents foto As PictureBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cliente_name As Label
End Class
