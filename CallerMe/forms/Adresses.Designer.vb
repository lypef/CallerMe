<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adresses
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtReferencia = New System.Windows.Forms.TextBox()
        Me.TxtKilometros = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(927, 435)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Table)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(919, 409)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Direcciones"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btn_add)
        Me.Panel3.Controls.Add(Me.btn_delete)
        Me.Panel3.Controls.Add(Me.btn_editar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 346)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(913, 60)
        Me.Panel3.TabIndex = 102
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
        Me.Btn_add.Location = New System.Drawing.Point(98, 3)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(193, 49)
        Me.Btn_add.TabIndex = 6
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
        Me.btn_delete.Location = New System.Drawing.Point(606, 3)
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
        Me.btn_editar.Location = New System.Drawing.Point(352, 3)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(193, 49)
        Me.btn_editar.TabIndex = 2
        Me.btn_editar.Text = "btn_editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'Table
        '
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(3, 3)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(913, 403)
        Me.Table.TabIndex = 101
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TxtReferencia)
        Me.TabPage2.Controls.Add(Me.TxtKilometros)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtDireccion)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(919, 409)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(777, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 29)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.Location = New System.Drawing.Point(568, 202)
        Me.TxtReferencia.Multiline = True
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(314, 57)
        Me.TxtReferencia.TabIndex = 105
        '
        'TxtKilometros
        '
        Me.TxtKilometros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKilometros.Location = New System.Drawing.Point(568, 296)
        Me.TxtKilometros.Name = "TxtKilometros"
        Me.TxtKilometros.Size = New System.Drawing.Size(203, 29)
        Me.TxtKilometros.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(570, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Kilometros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Referencia"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(568, 117)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(314, 57)
        Me.TxtDireccion.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(570, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Direccion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(560, 388)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 18)
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(560, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 75)
        Me.Panel1.TabIndex = 102
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(244, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 29)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Buscar cliente"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(10, 29)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(228, 29)
        Me.TxtSearch.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(557, 403)
        Me.DataGridView1.TabIndex = 101
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
        'Adresses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 435)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Adresses"
        Me.Text = "Adresses"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Table As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtReferencia As TextBox
    Friend WithEvents TxtKilometros As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents Btn_add As Button
End Class
