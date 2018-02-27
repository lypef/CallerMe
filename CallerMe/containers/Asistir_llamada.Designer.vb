<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Asistir_llamada
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Client = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Combo_direcciones = New System.Windows.Forms.ComboBox()
        Me.Combo_Driver = New System.Windows.Forms.ComboBox()
        Me.ComboVehiculos = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Client)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Combo_direcciones)
        Me.Panel1.Controls.Add(Me.Combo_Driver)
        Me.Panel1.Controls.Add(Me.ComboVehiculos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 273)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(137, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Recargar valores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.Client.AutoSize = True
        Me.Client.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client.Location = New System.Drawing.Point(12, 125)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(135, 16)
        Me.Client.TabIndex = 29
        Me.Client.Text = "Nombre de cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 109)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Combo_direcciones
        '
        Me.Combo_direcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_direcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Combo_direcciones.FormattingEnabled = True
        Me.Combo_direcciones.Location = New System.Drawing.Point(15, 145)
        Me.Combo_direcciones.Name = "Combo_direcciones"
        Me.Combo_direcciones.Size = New System.Drawing.Size(405, 24)
        Me.Combo_direcciones.TabIndex = 24
        '
        'Combo_Driver
        '
        Me.Combo_Driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Combo_Driver.FormattingEnabled = True
        Me.Combo_Driver.Location = New System.Drawing.Point(15, 211)
        Me.Combo_Driver.Name = "Combo_Driver"
        Me.Combo_Driver.Size = New System.Drawing.Size(405, 24)
        Me.Combo_Driver.TabIndex = 27
        '
        'ComboVehiculos
        '
        Me.ComboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ComboVehiculos.FormattingEnabled = True
        Me.ComboVehiculos.Location = New System.Drawing.Point(15, 178)
        Me.ComboVehiculos.Name = "ComboVehiculos"
        Me.ComboVehiculos.Size = New System.Drawing.Size(405, 24)
        Me.ComboVehiculos.TabIndex = 25
        '
        'Asistir_llamada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 273)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Asistir_llamada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistir_llamada"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Combo_direcciones As ComboBox
    Friend WithEvents Combo_Driver As ComboBox
    Friend WithEvents ComboVehiculos As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Client As Label
    Friend WithEvents Button3 As Button
End Class
