<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Number_telephone
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
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Loader = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtRef = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoaderEdit = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtFijo = New System.Windows.Forms.RadioButton()
        Me.TxtMovil = New System.Windows.Forms.RadioButton()
        Me.TxtCompañia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table_EditClients = New System.Windows.Forms.DataGridView()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.LoaderEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Table_EditClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabla.Location = New System.Drawing.Point(3, 3)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(913, 402)
        Me.Tabla.TabIndex = 0
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
        'Loader
        '
        Me.Loader.Dock = System.Windows.Forms.DockStyle.Top
        Me.Loader.Location = New System.Drawing.Point(0, 0)
        Me.Loader.Name = "Loader"
        Me.Loader.Size = New System.Drawing.Size(927, 18)
        Me.Loader.TabIndex = 2
        Me.Loader.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(927, 434)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Tabla)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(919, 408)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Numeros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.TxtRef)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.LoaderEdit)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TxtFijo)
        Me.TabPage2.Controls.Add(Me.TxtMovil)
        Me.TabPage2.Controls.Add(Me.TxtCompañia)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtNumber)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Table_EditClients)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(919, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        '
        'TxtRef
        '
        Me.TxtRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(543, 248)
        Me.TxtRef.Multiline = True
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.Size = New System.Drawing.Size(356, 36)
        Me.TxtRef.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(545, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Referencia / Nota"
        '
        'LoaderEdit
        '
        Me.LoaderEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LoaderEdit.Location = New System.Drawing.Point(522, 387)
        Me.LoaderEdit.Name = "LoaderEdit"
        Me.LoaderEdit.Size = New System.Drawing.Size(394, 18)
        Me.LoaderEdit.TabIndex = 22
        Me.LoaderEdit.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(522, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 75)
        Me.Panel1.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Buscar cliente"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(9, 33)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(263, 29)
        Me.TxtSearch.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(779, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtFijo
        '
        Me.TxtFijo.AutoSize = True
        Me.TxtFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtFijo.Location = New System.Drawing.Point(721, 295)
        Me.TxtFijo.Name = "TxtFijo"
        Me.TxtFijo.Size = New System.Drawing.Size(52, 24)
        Me.TxtFijo.TabIndex = 7
        Me.TxtFijo.TabStop = True
        Me.TxtFijo.Text = "Fijo"
        Me.TxtFijo.UseVisualStyleBackColor = True
        '
        'TxtMovil
        '
        Me.TxtMovil.AutoSize = True
        Me.TxtMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtMovil.Location = New System.Drawing.Point(653, 295)
        Me.TxtMovil.Name = "TxtMovil"
        Me.TxtMovil.Size = New System.Drawing.Size(62, 24)
        Me.TxtMovil.TabIndex = 6
        Me.TxtMovil.TabStop = True
        Me.TxtMovil.Text = "Movil"
        Me.TxtMovil.UseVisualStyleBackColor = True
        '
        'TxtCompañia
        '
        Me.TxtCompañia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompañia.Location = New System.Drawing.Point(543, 189)
        Me.TxtCompañia.Name = "TxtCompañia"
        Me.TxtCompañia.Size = New System.Drawing.Size(356, 29)
        Me.TxtCompañia.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(545, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Compañia"
        '
        'TxtNumber
        '
        Me.TxtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumber.Location = New System.Drawing.Point(543, 130)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(356, 29)
        Me.TxtNumber.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(545, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Numero"
        '
        'Table_EditClients
        '
        Me.Table_EditClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_EditClients.Dock = System.Windows.Forms.DockStyle.Left
        Me.Table_EditClients.Location = New System.Drawing.Point(3, 3)
        Me.Table_EditClients.Name = "Table_EditClients"
        Me.Table_EditClients.Size = New System.Drawing.Size(519, 402)
        Me.Table_EditClients.TabIndex = 12
        '
        'Number_telephone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 457)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Loader)
        Me.Name = "Number_telephone"
        Me.Text = "Number_telephone"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.LoaderEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Table_EditClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabla As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Loader As PictureBox
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtRef As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LoaderEdit As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtFijo As RadioButton
    Friend WithEvents TxtMovil As RadioButton
    Friend WithEvents TxtCompañia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Table_EditClients As DataGridView
End Class
