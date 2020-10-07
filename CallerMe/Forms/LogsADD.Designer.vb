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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WindowsDevice_0 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Vehiculos_0 = New System.Windows.Forms.NumericUpDown()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Combo_direcciones_0 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtClient_0 = New System.Windows.Forms.Label()
        Me.TxtAddDireccion_0 = New System.Windows.Forms.TextBox()
        Me.CbDireccionAdd_0 = New System.Windows.Forms.CheckBox()
        Me.TxtAddClient_0 = New System.Windows.Forms.TextBox()
        Me.CbAddClient_0 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.WindowsDevice_0.SuspendLayout()
        CType(Me.Vehiculos_0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.WindowsDevice_0)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 319)
        Me.Panel1.TabIndex = 17
        '
        'WindowsDevice_0
        '
        Me.WindowsDevice_0.Controls.Add(Me.Label5)
        Me.WindowsDevice_0.Controls.Add(Me.Vehiculos_0)
        Me.WindowsDevice_0.Controls.Add(Me.Button5)
        Me.WindowsDevice_0.Controls.Add(Me.Button4)
        Me.WindowsDevice_0.Controls.Add(Me.Combo_direcciones_0)
        Me.WindowsDevice_0.Controls.Add(Me.Button1)
        Me.WindowsDevice_0.Controls.Add(Me.Label2)
        Me.WindowsDevice_0.Controls.Add(Me.TxtClient_0)
        Me.WindowsDevice_0.Controls.Add(Me.TxtAddDireccion_0)
        Me.WindowsDevice_0.Controls.Add(Me.CbDireccionAdd_0)
        Me.WindowsDevice_0.Controls.Add(Me.TxtAddClient_0)
        Me.WindowsDevice_0.Controls.Add(Me.CbAddClient_0)
        Me.WindowsDevice_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowsDevice_0.Font = New System.Drawing.Font("Segoe UI Black", 10.25!, System.Drawing.FontStyle.Bold)
        Me.WindowsDevice_0.ForeColor = System.Drawing.Color.White
        Me.WindowsDevice_0.Location = New System.Drawing.Point(0, 0)
        Me.WindowsDevice_0.Name = "WindowsDevice_0"
        Me.WindowsDevice_0.Size = New System.Drawing.Size(327, 319)
        Me.WindowsDevice_0.TabIndex = 35
        Me.WindowsDevice_0.TabStop = False
        Me.WindowsDevice_0.Text = "No disponible"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Vehiculos"
        '
        'Vehiculos_0
        '
        Me.Vehiculos_0.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Vehiculos_0.Location = New System.Drawing.Point(267, 177)
        Me.Vehiculos_0.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Vehiculos_0.Name = "Vehiculos_0"
        Me.Vehiculos_0.Size = New System.Drawing.Size(52, 25)
        Me.Vehiculos_0.TabIndex = 32
        Me.Vehiculos_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Vehiculos_0.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(215, 240)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 33)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Observacion"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(10, 240)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(199, 33)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Combo_direcciones_0
        '
        Me.Combo_direcciones_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_direcciones_0.FormattingEnabled = True
        Me.Combo_direcciones_0.Location = New System.Drawing.Point(10, 74)
        Me.Combo_direcciones_0.Name = "Combo_direcciones_0"
        Me.Combo_direcciones_0.Size = New System.Drawing.Size(309, 27)
        Me.Combo_direcciones_0.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(10, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 33)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "SOLICITAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "DIRECCION:"
        '
        'TxtClient_0
        '
        Me.TxtClient_0.AutoSize = True
        Me.TxtClient_0.Location = New System.Drawing.Point(6, 26)
        Me.TxtClient_0.Name = "TxtClient_0"
        Me.TxtClient_0.Size = New System.Drawing.Size(77, 19)
        Me.TxtClient_0.TabIndex = 20
        Me.TxtClient_0.Text = "NOMBRE:"
        '
        'TxtAddDireccion_0
        '
        Me.TxtAddDireccion_0.Enabled = False
        Me.TxtAddDireccion_0.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddDireccion_0.Location = New System.Drawing.Point(10, 210)
        Me.TxtAddDireccion_0.Name = "TxtAddDireccion_0"
        Me.TxtAddDireccion_0.Size = New System.Drawing.Size(309, 25)
        Me.TxtAddDireccion_0.TabIndex = 18
        '
        'CbDireccionAdd_0
        '
        Me.CbDireccionAdd_0.AutoSize = True
        Me.CbDireccionAdd_0.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDireccionAdd_0.Location = New System.Drawing.Point(10, 183)
        Me.CbDireccionAdd_0.Name = "CbDireccionAdd_0"
        Me.CbDireccionAdd_0.Size = New System.Drawing.Size(99, 21)
        Me.CbDireccionAdd_0.TabIndex = 17
        Me.CbDireccionAdd_0.Text = "DIRECCION "
        Me.CbDireccionAdd_0.UseVisualStyleBackColor = True
        '
        'TxtAddClient_0
        '
        Me.TxtAddClient_0.Enabled = False
        Me.TxtAddClient_0.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddClient_0.Location = New System.Drawing.Point(10, 146)
        Me.TxtAddClient_0.Name = "TxtAddClient_0"
        Me.TxtAddClient_0.Size = New System.Drawing.Size(309, 25)
        Me.TxtAddClient_0.TabIndex = 16
        '
        'CbAddClient_0
        '
        Me.CbAddClient_0.AutoSize = True
        Me.CbAddClient_0.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAddClient_0.Location = New System.Drawing.Point(10, 119)
        Me.CbAddClient_0.Name = "CbAddClient_0"
        Me.CbAddClient_0.Size = New System.Drawing.Size(143, 21)
        Me.CbAddClient_0.TabIndex = 15
        Me.CbAddClient_0.Text = "CLIENTE | NOMBRE"
        Me.CbAddClient_0.UseVisualStyleBackColor = True
        '
        'LogsADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 319)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LogsADD"
        Me.Text = "LogsADD"
        Me.Panel1.ResumeLayout(False)
        Me.WindowsDevice_0.ResumeLayout(False)
        Me.WindowsDevice_0.PerformLayout()
        CType(Me.Vehiculos_0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WindowsDevice_0 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Vehiculos_0 As NumericUpDown
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Combo_direcciones_0 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtClient_0 As Label
    Friend WithEvents TxtAddDireccion_0 As TextBox
    Friend WithEvents CbDireccionAdd_0 As CheckBox
    Friend WithEvents TxtAddClient_0 As TextBox
    Friend WithEvents CbAddClient_0 As CheckBox
End Class
