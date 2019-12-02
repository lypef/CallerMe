<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logs
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
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_numeros = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Table
        '
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(0, 0)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(927, 379)
        Me.Table.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.ComprobanteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 52)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.delete_24
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ComprobanteToolStripMenuItem
        '
        Me.ComprobanteToolStripMenuItem.Image = Global.Calls.My.Resources.Resources.ticket_16
        Me.ComprobanteToolStripMenuItem.Name = "ComprobanteToolStripMenuItem"
        Me.ComprobanteToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.ComprobanteToolStripMenuItem.Text = "Comprobante"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnNext)
        Me.Panel1.Controls.Add(Me.Btn_Back)
        Me.Panel1.Controls.Add(Me.Btn_add)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_numeros)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 379)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 54)
        Me.Panel1.TabIndex = 5
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
        Me.Btn_add.Location = New System.Drawing.Point(10, 2)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(193, 49)
        Me.Btn_add.TabIndex = 4
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
        Me.btn_delete.Location = New System.Drawing.Point(607, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(193, 49)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "btn_delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_numeros
        '
        Me.btn_numeros.BackColor = System.Drawing.Color.Transparent
        Me.btn_numeros.BackgroundImage = Global.Calls.My.Resources.Resources.boton_g_pdf
        Me.btn_numeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_numeros.FlatAppearance.BorderSize = 0
        Me.btn_numeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_numeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_numeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_numeros.ForeColor = System.Drawing.Color.Maroon
        Me.btn_numeros.Location = New System.Drawing.Point(209, 2)
        Me.btn_numeros.Name = "btn_numeros"
        Me.btn_numeros.Size = New System.Drawing.Size(193, 49)
        Me.btn_numeros.TabIndex = 1
        Me.btn_numeros.Text = "btn_pdf"
        Me.btn_numeros.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.btn_editar.BackgroundImage = Global.Calls.My.Resources.Resources.boton_ticket
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.ForeColor = System.Drawing.Color.Maroon
        Me.btn_editar.Location = New System.Drawing.Point(408, 2)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(193, 49)
        Me.btn_editar.TabIndex = 2
        Me.btn_editar.Text = "btn_editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Table)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 433)
        Me.Panel2.TabIndex = 6
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
        Me.BtnNext.Location = New System.Drawing.Point(862, 1)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(51, 49)
        Me.BtnNext.TabIndex = 8
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
        Me.Btn_Back.Location = New System.Drawing.Point(805, 1)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(51, 49)
        Me.Btn_Back.TabIndex = 7
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 433)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Logs"
        Me.Text = "Logs"
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobanteToolStripMenuItem As ToolStripMenuItem
    Public WithEvents Table As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_numeros As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnNext As Button
    Friend WithEvents Btn_Back As Button
End Class
