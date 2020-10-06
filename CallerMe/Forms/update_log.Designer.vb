<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_log
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_vehi = New System.Windows.Forms.Label()
        Me.TxtConductor = New System.Windows.Forms.TextBox()
        Me.TxtVehiculos = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.label_vehi)
        Me.GroupBox3.Controls.Add(Me.TxtConductor)
        Me.GroupBox3.Controls.Add(Me.TxtVehiculos)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(347, 224)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACTUALIZAR INFORMACION"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(10, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 40)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(121, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 40)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "ACTUALIZAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(7, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CONDUCTOR:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label_vehi
        '
        Me.label_vehi.AutoSize = True
        Me.label_vehi.ForeColor = System.Drawing.Color.DimGray
        Me.label_vehi.Location = New System.Drawing.Point(6, 37)
        Me.label_vehi.Name = "label_vehi"
        Me.label_vehi.Size = New System.Drawing.Size(89, 20)
        Me.label_vehi.TabIndex = 30
        Me.label_vehi.Text = "VEHICULO:"
        Me.label_vehi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtConductor
        '
        Me.TxtConductor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConductor.Location = New System.Drawing.Point(11, 129)
        Me.TxtConductor.Name = "TxtConductor"
        Me.TxtConductor.Size = New System.Drawing.Size(324, 25)
        Me.TxtConductor.TabIndex = 29
        '
        'TxtVehiculos
        '
        Me.TxtVehiculos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVehiculos.Location = New System.Drawing.Point(11, 60)
        Me.TxtVehiculos.Name = "TxtVehiculos"
        Me.TxtVehiculos.Size = New System.Drawing.Size(324, 25)
        Me.TxtVehiculos.TabIndex = 28
        '
        'update_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 224)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "update_log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update_log"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents label_vehi As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Public WithEvents TxtConductor As TextBox
    Public WithEvents TxtVehiculos As TextBox
End Class
