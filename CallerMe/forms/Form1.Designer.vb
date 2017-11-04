<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PapelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Vehiculo = New System.Windows.Forms.Button()
        Me.Button_Registros = New System.Windows.Forms.Button()
        Me.Button_Clients = New System.Windows.Forms.Button()
        Me.ARCHIVOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(916, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.Panel1.Controls.Add(Me.Button_Vehiculo)
        Me.Panel1.Controls.Add(Me.Button_Registros)
        Me.Panel1.Controls.Add(Me.Button_Clients)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 528)
        Me.Panel1.TabIndex = 2
        '
        'Button_Vehiculo
        '
        Me.Button_Vehiculo.BackColor = System.Drawing.Color.Transparent
        Me.Button_Vehiculo.BackgroundImage = Global.CallerMe.My.Resources.Resources.Btn_vehiculos_efct
        Me.Button_Vehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Vehiculo.FlatAppearance.BorderSize = 0
        Me.Button_Vehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Vehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Vehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Vehiculo.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Vehiculo.Location = New System.Drawing.Point(586, 63)
        Me.Button_Vehiculo.Name = "Button_Vehiculo"
        Me.Button_Vehiculo.Size = New System.Drawing.Size(210, 216)
        Me.Button_Vehiculo.TabIndex = 2
        Me.Button_Vehiculo.Text = "Button3"
        Me.Button_Vehiculo.UseVisualStyleBackColor = False
        '
        'Button_Registros
        '
        Me.Button_Registros.BackColor = System.Drawing.Color.Transparent
        Me.Button_Registros.BackgroundImage = Global.CallerMe.My.Resources.Resources.Btn_registros
        Me.Button_Registros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Registros.FlatAppearance.BorderSize = 0
        Me.Button_Registros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Registros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Registros.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Registros.Location = New System.Drawing.Point(351, 63)
        Me.Button_Registros.Name = "Button_Registros"
        Me.Button_Registros.Size = New System.Drawing.Size(210, 216)
        Me.Button_Registros.TabIndex = 1
        Me.Button_Registros.Text = "Button2"
        Me.Button_Registros.UseVisualStyleBackColor = False
        '
        'Button_Clients
        '
        Me.Button_Clients.BackColor = System.Drawing.Color.Transparent
        Me.Button_Clients.BackgroundImage = Global.CallerMe.My.Resources.Resources.Btn_Clientes
        Me.Button_Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Clients.FlatAppearance.BorderSize = 0
        Me.Button_Clients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clients.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Clients.Location = New System.Drawing.Point(124, 63)
        Me.Button_Clients.Name = "Button_Clients"
        Me.Button_Clients.Size = New System.Drawing.Size(210, 216)
        Me.Button_Clients.TabIndex = 0
        Me.Button_Clients.Text = "Button1"
        Me.Button_Clients.UseVisualStyleBackColor = False
        '
        'ARCHIVOToolStripMenuItem1
        '
        Me.ARCHIVOToolStripMenuItem1.Name = "ARCHIVOToolStripMenuItem1"
        Me.ARCHIVOToolStripMenuItem1.Size = New System.Drawing.Size(68, 20)
        Me.ARCHIVOToolStripMenuItem1.Text = "aRCHIVO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(916, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "FORM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PapelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Clients As Button
    Friend WithEvents Button_Vehiculo As Button
    Friend WithEvents Button_Registros As Button
    Friend WithEvents ARCHIVOToolStripMenuItem1 As ToolStripMenuItem
End Class
