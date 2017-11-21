<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clients
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
        Me.components = New System.ComponentModel.Container()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckCamara = New System.Windows.Forms.CheckBox()
        Me.CheckImagen = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FechaNaci = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRfc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFoto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtReferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Loader = New System.Windows.Forms.PictureBox()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Table
        '
        Me.Table.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(3, 3)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(881, 335)
        Me.Table.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.VerMovimientosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(145, 70)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.edit_24
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.delete_24
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'VerMovimientosToolStripMenuItem
        '
        Me.VerMovimientosToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.movements_24
        Me.VerMovimientosToolStripMenuItem.Name = "VerMovimientosToolStripMenuItem"
        Me.VerMovimientosToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.VerMovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(895, 367)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Table)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(887, 341)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckCamara)
        Me.TabPage2.Controls.Add(Me.CheckImagen)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.FechaNaci)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TxtRfc)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtRazonSocial)
        Me.TabPage2.Controls.Add(Me.BtnFoto)
        Me.TabPage2.Controls.Add(Me.Foto)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TxtFoto)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtCorreoElectronico)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtReferencia)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtDireccion)
        Me.TabPage2.Controls.Add(Me.BtnAdd)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TxtNombre)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(887, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckCamara
        '
        Me.CheckCamara.AutoSize = True
        Me.CheckCamara.Location = New System.Drawing.Point(803, 153)
        Me.CheckCamara.Name = "CheckCamara"
        Me.CheckCamara.Size = New System.Drawing.Size(62, 17)
        Me.CheckCamara.TabIndex = 113
        Me.CheckCamara.Text = "Camara"
        Me.CheckCamara.UseVisualStyleBackColor = True
        '
        'CheckImagen
        '
        Me.CheckImagen.AutoSize = True
        Me.CheckImagen.Location = New System.Drawing.Point(723, 153)
        Me.CheckImagen.Name = "CheckImagen"
        Me.CheckImagen.Size = New System.Drawing.Size(61, 17)
        Me.CheckImagen.TabIndex = 111
        Me.CheckImagen.Text = "Imagen"
        Me.CheckImagen.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 20)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Fecha de nacimiento"
        '
        'FechaNaci
        '
        Me.FechaNaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FechaNaci.Location = New System.Drawing.Point(12, 122)
        Me.FechaNaci.Name = "FechaNaci"
        Me.FechaNaci.Size = New System.Drawing.Size(416, 29)
        Me.FechaNaci.TabIndex = 106
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(881, 18)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(445, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Rfc"
        '
        'TxtRfc
        '
        Me.TxtRfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRfc.Location = New System.Drawing.Point(449, 293)
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(416, 29)
        Me.TxtRfc.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(449, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Razon social"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRazonSocial.Location = New System.Drawing.Point(449, 234)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(416, 29)
        Me.TxtRazonSocial.TabIndex = 116
        '
        'BtnFoto
        '
        Me.BtnFoto.Location = New System.Drawing.Point(790, 175)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(75, 29)
        Me.BtnFoto.TabIndex = 115
        Me.BtnFoto.Text = "Examinar"
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'Foto
        '
        Me.Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Foto.Location = New System.Drawing.Point(12, 222)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(416, 113)
        Me.Foto.TabIndex = 121
        Me.Foto.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(449, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Foto / Imagen"
        '
        'TxtFoto
        '
        Me.TxtFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFoto.Location = New System.Drawing.Point(449, 175)
        Me.TxtFoto.Name = "TxtFoto"
        Me.TxtFoto.Size = New System.Drawing.Size(335, 29)
        Me.TxtFoto.TabIndex = 118
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(449, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Correo electronico"
        '
        'TxtCorreoElectronico
        '
        Me.TxtCorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreoElectronico.Location = New System.Drawing.Point(449, 116)
        Me.TxtCorreoElectronico.Name = "TxtCorreoElectronico"
        Me.TxtCorreoElectronico.Size = New System.Drawing.Size(416, 29)
        Me.TxtCorreoElectronico.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(449, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Referencia"
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.Location = New System.Drawing.Point(449, 57)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(416, 29)
        Me.TxtReferencia.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(12, 187)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(416, 29)
        Me.TxtDireccion.TabIndex = 107
        '
        'BtnAdd
        '
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(787, 26)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(78, 25)
        Me.BtnAdd.TabIndex = 120
        Me.BtnAdd.Text = "Actualizar"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(12, 57)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(416, 29)
        Me.TxtNombre.TabIndex = 104
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(887, 341)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Movimientos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Loader
        '
        Me.Loader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Loader.Dock = System.Windows.Forms.DockStyle.Top
        Me.Loader.Location = New System.Drawing.Point(0, 0)
        Me.Loader.Name = "Loader"
        Me.Loader.Size = New System.Drawing.Size(900, 18)
        Me.Loader.TabIndex = 102
        Me.Loader.TabStop = False
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 412)
        Me.Controls.Add(Me.Loader)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Clients"
        Me.Text = "Form2"
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Table As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerMovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Loader As PictureBox
    Friend WithEvents CheckCamara As CheckBox
    Friend WithEvents CheckImagen As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FechaNaci As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRfc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents BtnFoto As Button
    Friend WithEvents Foto As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFoto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreoElectronico As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtReferencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
End Class
