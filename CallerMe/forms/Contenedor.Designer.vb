﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contenedor
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
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PapelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Desktop = New System.Windows.Forms.Panel()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.Button_Ajustes = New System.Windows.Forms.Button()
        Me.Button_Vehiculo = New System.Windows.Forms.Button()
        Me.Button_Registros = New System.Windows.Forms.Button()
        Me.Button_Clients = New System.Windows.Forms.Button()
        Me.Btn_clientes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_registros = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_vehiculos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_ajustes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.Btn_clientes.SuspendLayout()
        Me.Btn_registros.SuspendLayout()
        Me.Btn_vehiculos.SuspendLayout()
        Me.Btn_ajustes.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'PapelToolStripMenuItem
        '
        Me.PapelToolStripMenuItem.Name = "PapelToolStripMenuItem"
        Me.PapelToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.PapelToolStripMenuItem.Text = "Papel"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.CallerMe.My.Resources.Resources.background
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Desktop)
        Me.Panel1.Controls.Add(Me.Menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 531)
        Me.Panel1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.CallerMe.My.Resources.Resources.separador
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(0, 96)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(916, 3)
        Me.Panel4.TabIndex = 5
        '
        'Desktop
        '
        Me.Desktop.BackColor = System.Drawing.Color.Transparent
        Me.Desktop.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Desktop.Location = New System.Drawing.Point(0, 99)
        Me.Desktop.Name = "Desktop"
        Me.Desktop.Size = New System.Drawing.Size(916, 432)
        Me.Desktop.TabIndex = 4
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.Transparent
        Me.Menu.Controls.Add(Me.Button_Ajustes)
        Me.Menu.Controls.Add(Me.Button_Vehiculo)
        Me.Menu.Controls.Add(Me.Button_Registros)
        Me.Menu.Controls.Add(Me.Button_Clients)
        Me.Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(916, 96)
        Me.Menu.TabIndex = 3
        '
        'Button_Ajustes
        '
        Me.Button_Ajustes.BackColor = System.Drawing.Color.Transparent
        Me.Button_Ajustes.BackgroundImage = Global.CallerMe.My.Resources.Resources.Btn_ajustes
        Me.Button_Ajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Ajustes.ContextMenuStrip = Me.Btn_ajustes
        Me.Button_Ajustes.FlatAppearance.BorderSize = 0
        Me.Button_Ajustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Ajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ajustes.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Ajustes.Location = New System.Drawing.Point(683, 6)
        Me.Button_Ajustes.Name = "Button_Ajustes"
        Me.Button_Ajustes.Size = New System.Drawing.Size(216, 84)
        Me.Button_Ajustes.TabIndex = 3
        Me.Button_Ajustes.Text = "Button3"
        Me.Button_Ajustes.UseVisualStyleBackColor = False
        '
        'Button_Vehiculo
        '
        Me.Button_Vehiculo.BackColor = System.Drawing.Color.Transparent
        Me.Button_Vehiculo.BackgroundImage = Global.CallerMe.My.Resources.Resources.Btn_vehiculos
        Me.Button_Vehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Vehiculo.ContextMenuStrip = Me.Btn_vehiculos
        Me.Button_Vehiculo.FlatAppearance.BorderSize = 0
        Me.Button_Vehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Vehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Vehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Vehiculo.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Vehiculo.Location = New System.Drawing.Point(461, 6)
        Me.Button_Vehiculo.Name = "Button_Vehiculo"
        Me.Button_Vehiculo.Size = New System.Drawing.Size(216, 84)
        Me.Button_Vehiculo.TabIndex = 2
        Me.Button_Vehiculo.Text = "Button3"
        Me.Button_Vehiculo.UseVisualStyleBackColor = False
        '
        'Button_Registros
        '
        Me.Button_Registros.BackColor = System.Drawing.Color.Transparent
        Me.Button_Registros.BackgroundImage = Global.CallerMe.My.Resources.Resources.Btn_registros
        Me.Button_Registros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Registros.ContextMenuStrip = Me.Btn_registros
        Me.Button_Registros.FlatAppearance.BorderSize = 0
        Me.Button_Registros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Registros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Registros.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Registros.Location = New System.Drawing.Point(239, 6)
        Me.Button_Registros.Name = "Button_Registros"
        Me.Button_Registros.Size = New System.Drawing.Size(216, 84)
        Me.Button_Registros.TabIndex = 1
        Me.Button_Registros.Text = "Button2"
        Me.Button_Registros.UseVisualStyleBackColor = False
        '
        'Button_Clients
        '
        Me.Button_Clients.BackColor = System.Drawing.Color.Transparent
        Me.Button_Clients.BackgroundImage = Global.CallerMe.My.Resources.Resources.Btn_Clientes
        Me.Button_Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Clients.ContextMenuStrip = Me.Btn_clientes
        Me.Button_Clients.FlatAppearance.BorderSize = 0
        Me.Button_Clients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clients.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Clients.Location = New System.Drawing.Point(17, 6)
        Me.Button_Clients.Name = "Button_Clients"
        Me.Button_Clients.Size = New System.Drawing.Size(216, 84)
        Me.Button_Clients.TabIndex = 0
        Me.Button_Clients.Text = "Button1"
        Me.Button_Clients.UseVisualStyleBackColor = False
        '
        'Btn_clientes
        '
        Me.Btn_clientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_clientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.ConsultarClientesToolStripMenuItem})
        Me.Btn_clientes.Name = "Btn_clientes"
        Me.Btn_clientes.Size = New System.Drawing.Size(169, 48)
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar cliente"
        '
        'ConsultarClientesToolStripMenuItem
        '
        Me.ConsultarClientesToolStripMenuItem.Name = "ConsultarClientesToolStripMenuItem"
        Me.ConsultarClientesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ConsultarClientesToolStripMenuItem.Text = "Consultar clientes"
        '
        'Btn_registros
        '
        Me.Btn_registros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.Btn_registros.Name = "ContextMenuStrip1"
        Me.Btn_registros.Size = New System.Drawing.Size(174, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItem1.Text = "Agregar registro"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItem2.Text = "Consultar registros"
        '
        'Btn_vehiculos
        '
        Me.Btn_vehiculos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.Btn_vehiculos.Name = "ContextMenuStrip1"
        Me.Btn_vehiculos.Size = New System.Drawing.Size(179, 48)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuItem3.Text = "Agregar vehiculo"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuItem4.Text = "Consultar vehiculos"
        '
        'Btn_ajustes
        '
        Me.Btn_ajustes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.Btn_ajustes.Name = "ContextMenuStrip1"
        Me.Btn_ajustes.Size = New System.Drawing.Size(143, 48)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem5.Text = "Ajustes"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem6.Text = "Otros ajustes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(916, 531)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "FORM"
        Me.Panel1.ResumeLayout(False)
        Me.Menu.ResumeLayout(False)
        Me.Btn_clientes.ResumeLayout(False)
        Me.Btn_registros.ResumeLayout(False)
        Me.Btn_vehiculos.ResumeLayout(False)
        Me.Btn_ajustes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PapelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Clients As Button
    Friend WithEvents Button_Vehiculo As Button
    Friend WithEvents Button_Registros As Button
    Friend WithEvents Menu As Panel
    Friend WithEvents Button_Ajustes As Button
    Friend WithEvents Desktop As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_clientes As ContextMenuStrip
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_registros As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Btn_vehiculos As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Btn_ajustes As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
End Class