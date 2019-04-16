<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Drivers
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckCamara = New System.Windows.Forms.CheckBox()
        Me.CheckImagen = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FechaNaci = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLicConductor = New System.Windows.Forms.TextBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFoto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(926, 434)
        Me.TabControl1.TabIndex = 103
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Table)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(918, 408)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conductores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnNext)
        Me.Panel2.Controls.Add(Me.Btn_Back)
        Me.Panel2.Controls.Add(Me.Btn_add)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_editar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 352)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(912, 53)
        Me.Panel2.TabIndex = 5
        '
        'Btn_add
        '
        Me.Btn_add.BackColor = System.Drawing.Color.Transparent
        Me.Btn_add.BackgroundImage = Global.Calls.My.Resources.Resources.Boton_AGREGAR
        Me.Btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_add.FlatAppearance.BorderSize = 0
        Me.Btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_add.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_add.Location = New System.Drawing.Point(53, 2)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(193, 49)
        Me.Btn_add.TabIndex = 7
        Me.Btn_add.Text = "Button2"
        Me.Btn_add.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BackgroundImage = Global.Calls.My.Resources.Resources.Boton_eLIMINAR
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.Maroon
        Me.btn_delete.Location = New System.Drawing.Point(517, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(193, 49)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "btn_delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.btn_editar.BackgroundImage = Global.Calls.My.Resources.Resources.Boton_editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.ForeColor = System.Drawing.Color.Maroon
        Me.btn_editar.Location = New System.Drawing.Point(288, 2)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(193, 49)
        Me.btn_editar.TabIndex = 2
        Me.btn_editar.Text = "btn_editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'Table
        '
        Me.Table.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Table.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Location = New System.Drawing.Point(3, 3)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(912, 345)
        Me.Table.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtTelefono)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.CheckCamara)
        Me.TabPage2.Controls.Add(Me.CheckImagen)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.FechaNaci)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtLicConductor)
        Me.TabPage2.Controls.Add(Me.BtnFoto)
        Me.TabPage2.Controls.Add(Me.Foto)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TxtFoto)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtCorreoElectronico)
        Me.TabPage2.Controls.Add(Me.BtnAdd)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TxtNombre)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(918, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(465, 172)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(416, 29)
        Me.TxtTelefono.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(725, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Ninguna"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckCamara
        '
        Me.CheckCamara.AutoSize = True
        Me.CheckCamara.Location = New System.Drawing.Point(819, 24)
        Me.CheckCamara.Name = "CheckCamara"
        Me.CheckCamara.Size = New System.Drawing.Size(62, 17)
        Me.CheckCamara.TabIndex = 5
        Me.CheckCamara.Text = "Camara"
        Me.CheckCamara.UseVisualStyleBackColor = True
        '
        'CheckImagen
        '
        Me.CheckImagen.AutoSize = True
        Me.CheckImagen.Location = New System.Drawing.Point(739, 24)
        Me.CheckImagen.Name = "CheckImagen"
        Me.CheckImagen.Size = New System.Drawing.Size(61, 17)
        Me.CheckImagen.TabIndex = 4
        Me.CheckImagen.Text = "Imagen"
        Me.CheckImagen.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 20)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "Fecha de nacimiento"
        '
        'FechaNaci
        '
        Me.FechaNaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FechaNaci.Location = New System.Drawing.Point(27, 108)
        Me.FechaNaci.Name = "FechaNaci"
        Me.FechaNaci.Size = New System.Drawing.Size(416, 29)
        Me.FechaNaci.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(465, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 20)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Licencia de conducir"
        '
        'TxtLicConductor
        '
        Me.TxtLicConductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLicConductor.Location = New System.Drawing.Point(465, 108)
        Me.TxtLicConductor.Name = "TxtLicConductor"
        Me.TxtLicConductor.Size = New System.Drawing.Size(416, 29)
        Me.TxtLicConductor.TabIndex = 9
        '
        'BtnFoto
        '
        Me.BtnFoto.Location = New System.Drawing.Point(806, 43)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(75, 29)
        Me.BtnFoto.TabIndex = 8
        Me.BtnFoto.Text = "Examinar"
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'Foto
        '
        Me.Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Foto.Location = New System.Drawing.Point(26, 208)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(416, 118)
        Me.Foto.TabIndex = 134
        Me.Foto.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(465, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Foto / Imagen"
        '
        'TxtFoto
        '
        Me.TxtFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFoto.Location = New System.Drawing.Point(465, 43)
        Me.TxtFoto.Name = "TxtFoto"
        Me.TxtFoto.Size = New System.Drawing.Size(254, 29)
        Me.TxtFoto.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Correo electronico"
        '
        'TxtCorreoElectronico
        '
        Me.TxtCorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreoElectronico.Location = New System.Drawing.Point(27, 173)
        Me.TxtCorreoElectronico.Name = "TxtCorreoElectronico"
        Me.TxtCorreoElectronico.Size = New System.Drawing.Size(416, 29)
        Me.TxtCorreoElectronico.TabIndex = 3
        '
        'BtnAdd
        '
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(763, 208)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(118, 52)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "Actualizar"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(27, 43)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(416, 29)
        Me.TxtNombre.TabIndex = 1
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
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.delete_24
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 434)
        Me.Panel1.TabIndex = 104
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Transparent
        Me.BtnNext.BackgroundImage = Global.Calls.My.Resources.Resources.btn_next
        Me.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNext.Location = New System.Drawing.Point(802, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(51, 49)
        Me.BtnNext.TabIndex = 10
        Me.BtnNext.Text = "Button3"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'Btn_Back
        '
        Me.Btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Back.BackgroundImage = Global.Calls.My.Resources.Resources.btn_back
        Me.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Back.FlatAppearance.BorderSize = 0
        Me.Btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_Back.Location = New System.Drawing.Point(745, 2)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(51, 49)
        Me.Btn_Back.TabIndex = 9
        Me.Btn_Back.Text = "Button2"
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'Drivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Drivers"
        Me.Text = "Drivers"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Table As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckCamara As CheckBox
    Friend WithEvents CheckImagen As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FechaNaci As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLicConductor As TextBox
    Friend WithEvents BtnFoto As Button
    Friend WithEvents Foto As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFoto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreoElectronico As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents Btn_add As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents Btn_Back As Button
End Class
