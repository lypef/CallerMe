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
        Me.Table_Clients = New System.Windows.Forms.DataGridView()
        Me.Combo_Telefonos = New System.Windows.Forms.ComboBox()
        Me.Combo_Users = New System.Windows.Forms.ComboBox()
        Me.Combo_direcciones = New System.Windows.Forms.ComboBox()
        Me.ComboVehiculos = New System.Windows.Forms.ComboBox()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Combo_Driver = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Image = New System.Windows.Forms.PictureBox()
        CType(Me.Table_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Table_Clients
        '
        Me.Table_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Clients.Dock = System.Windows.Forms.DockStyle.Left
        Me.Table_Clients.Location = New System.Drawing.Point(0, 0)
        Me.Table_Clients.Name = "Table_Clients"
        Me.Table_Clients.Size = New System.Drawing.Size(508, 436)
        Me.Table_Clients.TabIndex = 0
        '
        'Combo_Telefonos
        '
        Me.Combo_Telefonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Telefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Telefonos.FormattingEnabled = True
        Me.Combo_Telefonos.Location = New System.Drawing.Point(8, 44)
        Me.Combo_Telefonos.Name = "Combo_Telefonos"
        Me.Combo_Telefonos.Size = New System.Drawing.Size(197, 24)
        Me.Combo_Telefonos.TabIndex = 1
        '
        'Combo_Users
        '
        Me.Combo_Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Users.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Combo_Users.FormattingEnabled = True
        Me.Combo_Users.Location = New System.Drawing.Point(210, 44)
        Me.Combo_Users.Name = "Combo_Users"
        Me.Combo_Users.Size = New System.Drawing.Size(202, 24)
        Me.Combo_Users.TabIndex = 2
        '
        'Combo_direcciones
        '
        Me.Combo_direcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_direcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Combo_direcciones.FormattingEnabled = True
        Me.Combo_direcciones.Location = New System.Drawing.Point(8, 77)
        Me.Combo_direcciones.Name = "Combo_direcciones"
        Me.Combo_direcciones.Size = New System.Drawing.Size(405, 24)
        Me.Combo_direcciones.TabIndex = 3
        '
        'ComboVehiculos
        '
        Me.ComboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ComboVehiculos.FormattingEnabled = True
        Me.ComboVehiculos.Location = New System.Drawing.Point(8, 110)
        Me.ComboVehiculos.Name = "ComboVehiculos"
        Me.ComboVehiculos.Size = New System.Drawing.Size(405, 24)
        Me.ComboVehiculos.TabIndex = 4
        '
        'Fecha
        '
        Me.Fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Fecha.Location = New System.Drawing.Point(7, 197)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(321, 20)
        Me.Fecha.TabIndex = 5
        Me.Fecha.Value = New Date(2017, 12, 3, 22, 52, 56, 0)
        '
        'Combo_Driver
        '
        Me.Combo_Driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Combo_Driver.FormattingEnabled = True
        Me.Combo_Driver.Location = New System.Drawing.Point(8, 143)
        Me.Combo_Driver.Name = "Combo_Driver"
        Me.Combo_Driver.Size = New System.Drawing.Size(405, 24)
        Me.Combo_Driver.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha de llamada"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.Combo_direcciones)
        Me.Panel1.Controls.Add(Me.Combo_Telefonos)
        Me.Panel1.Controls.Add(Me.Combo_Users)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Fecha)
        Me.Panel1.Controls.Add(Me.Combo_Driver)
        Me.Panel1.Controls.Add(Me.ComboVehiculos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(508, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 252)
        Me.Panel1.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(337, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(8, 9)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(320, 22)
        Me.TxtSearch.TabIndex = 19
        '
        'Image
        '
        Me.Image.Dock = System.Windows.Forms.DockStyle.Top
        Me.Image.Location = New System.Drawing.Point(508, 0)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(418, 178)
        Me.Image.TabIndex = 18
        Me.Image.TabStop = False
        '
        'LogsADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 436)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Table_Clients)
        Me.Name = "LogsADD"
        Me.Text = "LogsADD"
        CType(Me.Table_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Table_Clients As DataGridView
    Friend WithEvents Combo_Telefonos As ComboBox
    Friend WithEvents Combo_Users As ComboBox
    Friend WithEvents Combo_direcciones As ComboBox
    Friend WithEvents ComboVehiculos As ComboBox
    Friend WithEvents Fecha As DateTimePicker
    Friend WithEvents Combo_Driver As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Image As PictureBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
