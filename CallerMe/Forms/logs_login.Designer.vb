<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class logs_login
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
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_numeros = New System.Windows.Forms.Button()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Table
        '
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(0, 0)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(927, 379)
        Me.Table.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_numeros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 379)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 54)
        Me.Panel1.TabIndex = 9
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
        Me.btn_delete.Location = New System.Drawing.Point(722, 3)
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
        Me.btn_numeros.Location = New System.Drawing.Point(523, 3)
        Me.btn_numeros.Name = "btn_numeros"
        Me.btn_numeros.Size = New System.Drawing.Size(193, 49)
        Me.btn_numeros.TabIndex = 1
        Me.btn_numeros.Text = "btn_pdf"
        Me.btn_numeros.UseVisualStyleBackColor = False
        '
        'logs_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 433)
        Me.Controls.Add(Me.Table)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "logs_login"
        Me.Text = "logs_login"
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Table As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_numeros As Button
End Class
