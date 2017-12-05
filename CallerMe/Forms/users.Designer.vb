<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Table_users = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.user_edit = New System.Windows.Forms.CheckBox()
        Me.user_delete = New System.Windows.Forms.CheckBox()
        Me.user_permisos = New System.Windows.Forms.CheckBox()
        Me.vehicles_delete = New System.Windows.Forms.CheckBox()
        Me.properties = New System.Windows.Forms.CheckBox()
        Me.user_access = New System.Windows.Forms.CheckBox()
        Me.adresses_delete = New System.Windows.Forms.CheckBox()
        Me.user_add = New System.Windows.Forms.CheckBox()
        Me.vehicles_edit = New System.Windows.Forms.CheckBox()
        Me.logs_clean = New System.Windows.Forms.CheckBox()
        Me.drivers_delete = New System.Windows.Forms.CheckBox()
        Me.adresses_edit = New System.Windows.Forms.CheckBox()
        Me.telephone_delete = New System.Windows.Forms.CheckBox()
        Me.vehicles_add = New System.Windows.Forms.CheckBox()
        Me.logs_delete = New System.Windows.Forms.CheckBox()
        Me.drivers_edit = New System.Windows.Forms.CheckBox()
        Me.adresses_add = New System.Windows.Forms.CheckBox()
        Me.telephone_edit = New System.Windows.Forms.CheckBox()
        Me.clients_edit = New System.Windows.Forms.CheckBox()
        Me.logs_add = New System.Windows.Forms.CheckBox()
        Me.drivers_add = New System.Windows.Forms.CheckBox()
        Me.telephone_add = New System.Windows.Forms.CheckBox()
        Me.clients_delete = New System.Windows.Forms.CheckBox()
        Me.clients_add = New System.Windows.Forms.CheckBox()
        Me.acces_logs = New System.Windows.Forms.CheckBox()
        Me.acces_vehicles = New System.Windows.Forms.CheckBox()
        Me.acces_drivers = New System.Windows.Forms.CheckBox()
        Me.acces_adresses = New System.Windows.Forms.CheckBox()
        Me.acces_numbersTelephone = New System.Windows.Forms.CheckBox()
        Me.acces_clients = New System.Windows.Forms.CheckBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Table_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(924, 452)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Table_users)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(916, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Usuarios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Table_users
        '
        Me.Table_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table_users.Location = New System.Drawing.Point(3, 3)
        Me.Table_users.Name = "Table_users"
        Me.Table_users.Size = New System.Drawing.Size(910, 420)
        Me.Table_users.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.TxtName)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtPassword)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtUsername)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(916, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 38)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.user_edit)
        Me.Panel1.Controls.Add(Me.user_delete)
        Me.Panel1.Controls.Add(Me.user_permisos)
        Me.Panel1.Controls.Add(Me.vehicles_delete)
        Me.Panel1.Controls.Add(Me.properties)
        Me.Panel1.Controls.Add(Me.user_access)
        Me.Panel1.Controls.Add(Me.adresses_delete)
        Me.Panel1.Controls.Add(Me.user_add)
        Me.Panel1.Controls.Add(Me.vehicles_edit)
        Me.Panel1.Controls.Add(Me.logs_clean)
        Me.Panel1.Controls.Add(Me.drivers_delete)
        Me.Panel1.Controls.Add(Me.adresses_edit)
        Me.Panel1.Controls.Add(Me.telephone_delete)
        Me.Panel1.Controls.Add(Me.vehicles_add)
        Me.Panel1.Controls.Add(Me.logs_delete)
        Me.Panel1.Controls.Add(Me.drivers_edit)
        Me.Panel1.Controls.Add(Me.adresses_add)
        Me.Panel1.Controls.Add(Me.telephone_edit)
        Me.Panel1.Controls.Add(Me.clients_edit)
        Me.Panel1.Controls.Add(Me.logs_add)
        Me.Panel1.Controls.Add(Me.drivers_add)
        Me.Panel1.Controls.Add(Me.telephone_add)
        Me.Panel1.Controls.Add(Me.clients_delete)
        Me.Panel1.Controls.Add(Me.clients_add)
        Me.Panel1.Controls.Add(Me.acces_logs)
        Me.Panel1.Controls.Add(Me.acces_vehicles)
        Me.Panel1.Controls.Add(Me.acces_drivers)
        Me.Panel1.Controls.Add(Me.acces_adresses)
        Me.Panel1.Controls.Add(Me.acces_numbersTelephone)
        Me.Panel1.Controls.Add(Me.acces_clients)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(321, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 420)
        Me.Panel1.TabIndex = 108
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(163, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 38)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Ninguno"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Todos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'user_edit
        '
        Me.user_edit.AutoSize = True
        Me.user_edit.Location = New System.Drawing.Point(302, 248)
        Me.user_edit.Name = "user_edit"
        Me.user_edit.Size = New System.Drawing.Size(53, 17)
        Me.user_edit.TabIndex = 29
        Me.user_edit.Text = "Editar"
        Me.user_edit.UseVisualStyleBackColor = True
        '
        'user_delete
        '
        Me.user_delete.AutoSize = True
        Me.user_delete.Location = New System.Drawing.Point(302, 294)
        Me.user_delete.Name = "user_delete"
        Me.user_delete.Size = New System.Drawing.Size(62, 17)
        Me.user_delete.TabIndex = 28
        Me.user_delete.Text = "Eliminar"
        Me.user_delete.UseVisualStyleBackColor = True
        '
        'user_permisos
        '
        Me.user_permisos.AutoSize = True
        Me.user_permisos.Location = New System.Drawing.Point(302, 271)
        Me.user_permisos.Name = "user_permisos"
        Me.user_permisos.Size = New System.Drawing.Size(97, 17)
        Me.user_permisos.TabIndex = 27
        Me.user_permisos.Text = "Editar permisos"
        Me.user_permisos.UseVisualStyleBackColor = True
        '
        'vehicles_delete
        '
        Me.vehicles_delete.AutoSize = True
        Me.vehicles_delete.Location = New System.Drawing.Point(124, 277)
        Me.vehicles_delete.Name = "vehicles_delete"
        Me.vehicles_delete.Size = New System.Drawing.Size(62, 17)
        Me.vehicles_delete.TabIndex = 26
        Me.vehicles_delete.Text = "Eliminar"
        Me.vehicles_delete.UseVisualStyleBackColor = True
        '
        'properties
        '
        Me.properties.AutoSize = True
        Me.properties.Location = New System.Drawing.Point(441, 202)
        Me.properties.Name = "properties"
        Me.properties.Size = New System.Drawing.Size(123, 17)
        Me.properties.TabIndex = 25
        Me.properties.Text = "Acceso propiedades"
        Me.properties.UseVisualStyleBackColor = True
        '
        'user_access
        '
        Me.user_access.AutoSize = True
        Me.user_access.Location = New System.Drawing.Point(302, 202)
        Me.user_access.Name = "user_access"
        Me.user_access.Size = New System.Drawing.Size(104, 17)
        Me.user_access.TabIndex = 24
        Me.user_access.Text = "Acceso usuarios"
        Me.user_access.UseVisualStyleBackColor = True
        '
        'adresses_delete
        '
        Me.adresses_delete.AutoSize = True
        Me.adresses_delete.Location = New System.Drawing.Point(302, 148)
        Me.adresses_delete.Name = "adresses_delete"
        Me.adresses_delete.Size = New System.Drawing.Size(62, 17)
        Me.adresses_delete.TabIndex = 23
        Me.adresses_delete.Text = "Eliminar"
        Me.adresses_delete.UseVisualStyleBackColor = True
        '
        'user_add
        '
        Me.user_add.AutoSize = True
        Me.user_add.Location = New System.Drawing.Point(302, 225)
        Me.user_add.Name = "user_add"
        Me.user_add.Size = New System.Drawing.Size(63, 17)
        Me.user_add.TabIndex = 22
        Me.user_add.Text = "Agregar"
        Me.user_add.UseVisualStyleBackColor = True
        '
        'vehicles_edit
        '
        Me.vehicles_edit.AutoSize = True
        Me.vehicles_edit.Location = New System.Drawing.Point(124, 252)
        Me.vehicles_edit.Name = "vehicles_edit"
        Me.vehicles_edit.Size = New System.Drawing.Size(53, 17)
        Me.vehicles_edit.TabIndex = 21
        Me.vehicles_edit.Text = "Editar"
        Me.vehicles_edit.UseVisualStyleBackColor = True
        '
        'logs_clean
        '
        Me.logs_clean.AutoSize = True
        Me.logs_clean.Location = New System.Drawing.Point(13, 274)
        Me.logs_clean.Name = "logs_clean"
        Me.logs_clean.Size = New System.Drawing.Size(77, 17)
        Me.logs_clean.TabIndex = 20
        Me.logs_clean.Text = "Limpiar DB"
        Me.logs_clean.UseVisualStyleBackColor = True
        '
        'drivers_delete
        '
        Me.drivers_delete.AutoSize = True
        Me.drivers_delete.Location = New System.Drawing.Point(441, 151)
        Me.drivers_delete.Name = "drivers_delete"
        Me.drivers_delete.Size = New System.Drawing.Size(62, 17)
        Me.drivers_delete.TabIndex = 19
        Me.drivers_delete.Text = "Eliminar"
        Me.drivers_delete.UseVisualStyleBackColor = True
        '
        'adresses_edit
        '
        Me.adresses_edit.AutoSize = True
        Me.adresses_edit.Location = New System.Drawing.Point(302, 124)
        Me.adresses_edit.Name = "adresses_edit"
        Me.adresses_edit.Size = New System.Drawing.Size(53, 17)
        Me.adresses_edit.TabIndex = 18
        Me.adresses_edit.Text = "Editar"
        Me.adresses_edit.UseVisualStyleBackColor = True
        '
        'telephone_delete
        '
        Me.telephone_delete.AutoSize = True
        Me.telephone_delete.Location = New System.Drawing.Point(124, 145)
        Me.telephone_delete.Name = "telephone_delete"
        Me.telephone_delete.Size = New System.Drawing.Size(62, 17)
        Me.telephone_delete.TabIndex = 17
        Me.telephone_delete.Text = "Eliminar"
        Me.telephone_delete.UseVisualStyleBackColor = True
        '
        'vehicles_add
        '
        Me.vehicles_add.AutoSize = True
        Me.vehicles_add.Location = New System.Drawing.Point(124, 227)
        Me.vehicles_add.Name = "vehicles_add"
        Me.vehicles_add.Size = New System.Drawing.Size(63, 17)
        Me.vehicles_add.TabIndex = 16
        Me.vehicles_add.Text = "Agregar"
        Me.vehicles_add.UseVisualStyleBackColor = True
        '
        'logs_delete
        '
        Me.logs_delete.AutoSize = True
        Me.logs_delete.Location = New System.Drawing.Point(13, 250)
        Me.logs_delete.Name = "logs_delete"
        Me.logs_delete.Size = New System.Drawing.Size(62, 17)
        Me.logs_delete.TabIndex = 15
        Me.logs_delete.Text = "Eliminar"
        Me.logs_delete.UseVisualStyleBackColor = True
        '
        'drivers_edit
        '
        Me.drivers_edit.AutoSize = True
        Me.drivers_edit.Location = New System.Drawing.Point(441, 126)
        Me.drivers_edit.Name = "drivers_edit"
        Me.drivers_edit.Size = New System.Drawing.Size(53, 17)
        Me.drivers_edit.TabIndex = 14
        Me.drivers_edit.Text = "Editar"
        Me.drivers_edit.UseVisualStyleBackColor = True
        '
        'adresses_add
        '
        Me.adresses_add.AutoSize = True
        Me.adresses_add.Location = New System.Drawing.Point(302, 100)
        Me.adresses_add.Name = "adresses_add"
        Me.adresses_add.Size = New System.Drawing.Size(63, 17)
        Me.adresses_add.TabIndex = 13
        Me.adresses_add.Text = "Agregar"
        Me.adresses_add.UseVisualStyleBackColor = True
        '
        'telephone_edit
        '
        Me.telephone_edit.AutoSize = True
        Me.telephone_edit.Location = New System.Drawing.Point(124, 122)
        Me.telephone_edit.Name = "telephone_edit"
        Me.telephone_edit.Size = New System.Drawing.Size(53, 17)
        Me.telephone_edit.TabIndex = 12
        Me.telephone_edit.Text = "Editar"
        Me.telephone_edit.UseVisualStyleBackColor = True
        '
        'clients_edit
        '
        Me.clients_edit.AutoSize = True
        Me.clients_edit.Location = New System.Drawing.Point(13, 122)
        Me.clients_edit.Name = "clients_edit"
        Me.clients_edit.Size = New System.Drawing.Size(53, 17)
        Me.clients_edit.TabIndex = 11
        Me.clients_edit.Text = "Editar"
        Me.clients_edit.UseVisualStyleBackColor = True
        '
        'logs_add
        '
        Me.logs_add.AutoSize = True
        Me.logs_add.Location = New System.Drawing.Point(13, 226)
        Me.logs_add.Name = "logs_add"
        Me.logs_add.Size = New System.Drawing.Size(63, 17)
        Me.logs_add.TabIndex = 10
        Me.logs_add.Text = "Agregar"
        Me.logs_add.UseVisualStyleBackColor = True
        '
        'drivers_add
        '
        Me.drivers_add.AutoSize = True
        Me.drivers_add.Location = New System.Drawing.Point(441, 101)
        Me.drivers_add.Name = "drivers_add"
        Me.drivers_add.Size = New System.Drawing.Size(63, 17)
        Me.drivers_add.TabIndex = 9
        Me.drivers_add.Text = "Agregar"
        Me.drivers_add.UseVisualStyleBackColor = True
        '
        'telephone_add
        '
        Me.telephone_add.AutoSize = True
        Me.telephone_add.Location = New System.Drawing.Point(124, 99)
        Me.telephone_add.Name = "telephone_add"
        Me.telephone_add.Size = New System.Drawing.Size(63, 17)
        Me.telephone_add.TabIndex = 8
        Me.telephone_add.Text = "Agregar"
        Me.telephone_add.UseVisualStyleBackColor = True
        '
        'clients_delete
        '
        Me.clients_delete.AutoSize = True
        Me.clients_delete.Location = New System.Drawing.Point(13, 145)
        Me.clients_delete.Name = "clients_delete"
        Me.clients_delete.Size = New System.Drawing.Size(62, 17)
        Me.clients_delete.TabIndex = 7
        Me.clients_delete.Text = "Eliminar"
        Me.clients_delete.UseVisualStyleBackColor = True
        '
        'clients_add
        '
        Me.clients_add.AutoSize = True
        Me.clients_add.Location = New System.Drawing.Point(13, 99)
        Me.clients_add.Name = "clients_add"
        Me.clients_add.Size = New System.Drawing.Size(63, 17)
        Me.clients_add.TabIndex = 6
        Me.clients_add.Text = "Agregar"
        Me.clients_add.UseVisualStyleBackColor = True
        '
        'acces_logs
        '
        Me.acces_logs.AutoSize = True
        Me.acces_logs.Location = New System.Drawing.Point(13, 202)
        Me.acces_logs.Name = "acces_logs"
        Me.acces_logs.Size = New System.Drawing.Size(104, 17)
        Me.acces_logs.TabIndex = 5
        Me.acces_logs.Text = "Acceso registros"
        Me.acces_logs.UseVisualStyleBackColor = True
        '
        'acces_vehicles
        '
        Me.acces_vehicles.AutoSize = True
        Me.acces_vehicles.Location = New System.Drawing.Point(124, 202)
        Me.acces_vehicles.Name = "acces_vehicles"
        Me.acces_vehicles.Size = New System.Drawing.Size(110, 17)
        Me.acces_vehicles.TabIndex = 4
        Me.acces_vehicles.Text = "Acceso vehiculos"
        Me.acces_vehicles.UseVisualStyleBackColor = True
        '
        'acces_drivers
        '
        Me.acces_drivers.AutoSize = True
        Me.acces_drivers.Location = New System.Drawing.Point(441, 76)
        Me.acces_drivers.Name = "acces_drivers"
        Me.acces_drivers.Size = New System.Drawing.Size(124, 17)
        Me.acces_drivers.TabIndex = 3
        Me.acces_drivers.Text = "Acceso conductores"
        Me.acces_drivers.UseVisualStyleBackColor = True
        '
        'acces_adresses
        '
        Me.acces_adresses.AutoSize = True
        Me.acces_adresses.Location = New System.Drawing.Point(302, 76)
        Me.acces_adresses.Name = "acces_adresses"
        Me.acces_adresses.Size = New System.Drawing.Size(119, 17)
        Me.acces_adresses.TabIndex = 2
        Me.acces_adresses.Text = "Acceso direcciones"
        Me.acces_adresses.UseVisualStyleBackColor = True
        '
        'acces_numbersTelephone
        '
        Me.acces_numbersTelephone.AutoSize = True
        Me.acces_numbersTelephone.Location = New System.Drawing.Point(124, 76)
        Me.acces_numbersTelephone.Name = "acces_numbersTelephone"
        Me.acces_numbersTelephone.Size = New System.Drawing.Size(167, 17)
        Me.acces_numbersTelephone.TabIndex = 1
        Me.acces_numbersTelephone.Text = "Accceso numeros de telefono"
        Me.acces_numbersTelephone.UseVisualStyleBackColor = True
        '
        'acces_clients
        '
        Me.acces_clients.AutoSize = True
        Me.acces_clients.Location = New System.Drawing.Point(13, 76)
        Me.acces_clients.Name = "acces_clients"
        Me.acces_clients.Size = New System.Drawing.Size(101, 17)
        Me.acces_clients.TabIndex = 0
        Me.acces_clients.Text = "Acceso clientes"
        Me.acces_clients.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(8, 76)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(304, 29)
        Me.TxtName.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Nombre de usuario"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(8, 202)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(304, 29)
        Me.TxtPassword.TabIndex = 103
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Contraseña"
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(8, 139)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(304, 29)
        Me.TxtUsername.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Username"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.edit_24
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.delete_24
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 457)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "users"
        Me.Text = "users"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Table_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Table_users As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents user_edit As CheckBox
    Friend WithEvents user_delete As CheckBox
    Friend WithEvents user_permisos As CheckBox
    Friend WithEvents vehicles_delete As CheckBox
    Friend WithEvents properties As CheckBox
    Friend WithEvents user_access As CheckBox
    Friend WithEvents adresses_delete As CheckBox
    Friend WithEvents user_add As CheckBox
    Friend WithEvents vehicles_edit As CheckBox
    Friend WithEvents logs_clean As CheckBox
    Friend WithEvents drivers_delete As CheckBox
    Friend WithEvents adresses_edit As CheckBox
    Friend WithEvents telephone_delete As CheckBox
    Friend WithEvents vehicles_add As CheckBox
    Friend WithEvents logs_delete As CheckBox
    Friend WithEvents drivers_edit As CheckBox
    Friend WithEvents adresses_add As CheckBox
    Friend WithEvents telephone_edit As CheckBox
    Friend WithEvents clients_edit As CheckBox
    Friend WithEvents logs_add As CheckBox
    Friend WithEvents drivers_add As CheckBox
    Friend WithEvents telephone_add As CheckBox
    Friend WithEvents clients_delete As CheckBox
    Friend WithEvents clients_add As CheckBox
    Friend WithEvents acces_logs As CheckBox
    Friend WithEvents acces_vehicles As CheckBox
    Friend WithEvents acces_drivers As CheckBox
    Friend WithEvents acces_adresses As CheckBox
    Friend WithEvents acces_numbersTelephone As CheckBox
    Friend WithEvents acces_clients As CheckBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
End Class
