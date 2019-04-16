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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboVehiculos = New System.Windows.Forms.ComboBox()
        Me.Combo_Driver = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtAddDireccion = New System.Windows.Forms.TextBox()
        Me.CbDireccionAdd = New System.Windows.Forms.CheckBox()
        Me.TxtAddClient = New System.Windows.Forms.TextBox()
        Me.CbAddClient = New System.Windows.Forms.CheckBox()
        Me.GB_EXISTENTE = New System.Windows.Forms.GroupBox()
        Me.Combo_direcciones = New System.Windows.Forms.ComboBox()
        Me.Wb = New System.Windows.Forms.WebBrowser()
        Me.Btn_GuardarDb = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_ADD_INFO = New System.Windows.Forms.Button()
        Me.BtnRecargar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Table_Logs = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_EXISTENTE.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Logs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Table_Logs)
        Me.Panel1.Controls.Add(Me.Btn_GuardarDb)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnRecargar)
        Me.Panel1.Controls.Add(Me.GB_EXISTENTE)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 445)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboVehiculos)
        Me.GroupBox3.Controls.Add(Me.Combo_Driver)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 229)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(743, 69)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELECCIONAR VEHICULO Y CONDUCTOR"
        '
        'ComboVehiculos
        '
        Me.ComboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboVehiculos.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ComboVehiculos.FormattingEnabled = True
        Me.ComboVehiculos.Location = New System.Drawing.Point(6, 27)
        Me.ComboVehiculos.Name = "ComboVehiculos"
        Me.ComboVehiculos.Size = New System.Drawing.Size(367, 28)
        Me.ComboVehiculos.TabIndex = 25
        '
        'Combo_Driver
        '
        Me.Combo_Driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Driver.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Combo_Driver.FormattingEnabled = True
        Me.Combo_Driver.Location = New System.Drawing.Point(386, 27)
        Me.Combo_Driver.Name = "Combo_Driver"
        Me.Combo_Driver.Size = New System.Drawing.Size(351, 28)
        Me.Combo_Driver.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 211)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FOTOGRAFIA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_ADD_INFO)
        Me.GroupBox1.Controls.Add(Me.TxtAddDireccion)
        Me.GroupBox1.Controls.Add(Me.CbDireccionAdd)
        Me.GroupBox1.Controls.Add(Me.TxtAddClient)
        Me.GroupBox1.Controls.Add(Me.CbAddClient)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 10.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(233, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 141)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NUEVA INFORMACION"
        '
        'TxtAddDireccion
        '
        Me.TxtAddDireccion.Enabled = False
        Me.TxtAddDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddDireccion.Location = New System.Drawing.Point(175, 51)
        Me.TxtAddDireccion.Name = "TxtAddDireccion"
        Me.TxtAddDireccion.Size = New System.Drawing.Size(341, 25)
        Me.TxtAddDireccion.TabIndex = 18
        '
        'CbDireccionAdd
        '
        Me.CbDireccionAdd.AutoSize = True
        Me.CbDireccionAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDireccionAdd.Location = New System.Drawing.Point(7, 51)
        Me.CbDireccionAdd.Name = "CbDireccionAdd"
        Me.CbDireccionAdd.Size = New System.Drawing.Size(162, 21)
        Me.CbDireccionAdd.TabIndex = 17
        Me.CbDireccionAdd.Text = "DIRECCION | NOMBRE"
        Me.CbDireccionAdd.UseVisualStyleBackColor = True
        '
        'TxtAddClient
        '
        Me.TxtAddClient.Enabled = False
        Me.TxtAddClient.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddClient.Location = New System.Drawing.Point(149, 20)
        Me.TxtAddClient.Name = "TxtAddClient"
        Me.TxtAddClient.Size = New System.Drawing.Size(367, 25)
        Me.TxtAddClient.TabIndex = 16
        '
        'CbAddClient
        '
        Me.CbAddClient.AutoSize = True
        Me.CbAddClient.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAddClient.Location = New System.Drawing.Point(7, 22)
        Me.CbAddClient.Name = "CbAddClient"
        Me.CbAddClient.Size = New System.Drawing.Size(143, 21)
        Me.CbAddClient.TabIndex = 15
        Me.CbAddClient.Text = "CLIENTE | NOMBRE"
        Me.CbAddClient.UseVisualStyleBackColor = True
        '
        'GB_EXISTENTE
        '
        Me.GB_EXISTENTE.Controls.Add(Me.Combo_direcciones)
        Me.GB_EXISTENTE.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_EXISTENTE.ForeColor = System.Drawing.Color.White
        Me.GB_EXISTENTE.Location = New System.Drawing.Point(233, 12)
        Me.GB_EXISTENTE.Name = "GB_EXISTENTE"
        Me.GB_EXISTENTE.Size = New System.Drawing.Size(522, 64)
        Me.GB_EXISTENTE.TabIndex = 32
        Me.GB_EXISTENTE.TabStop = False
        Me.GB_EXISTENTE.Text = "Direcciones existentes"
        '
        'Combo_direcciones
        '
        Me.Combo_direcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_direcciones.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_direcciones.FormattingEnabled = True
        Me.Combo_direcciones.Location = New System.Drawing.Point(7, 24)
        Me.Combo_direcciones.Name = "Combo_direcciones"
        Me.Combo_direcciones.Size = New System.Drawing.Size(509, 28)
        Me.Combo_direcciones.TabIndex = 24
        '
        'Wb
        '
        Me.Wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wb.Location = New System.Drawing.Point(0, 445)
        Me.Wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Wb.Name = "Wb"
        Me.Wb.Size = New System.Drawing.Size(767, 195)
        Me.Wb.TabIndex = 3
        '
        'Btn_GuardarDb
        '
        Me.Btn_GuardarDb.BackgroundImage = Global.Calls.My.Resources.Resources.guardar
        Me.Btn_GuardarDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_GuardarDb.FlatAppearance.BorderSize = 0
        Me.Btn_GuardarDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GuardarDb.Location = New System.Drawing.Point(626, 302)
        Me.Btn_GuardarDb.Name = "Btn_GuardarDb"
        Me.Btn_GuardarDb.Size = New System.Drawing.Size(126, 39)
        Me.Btn_GuardarDb.TabIndex = 33
        Me.Btn_GuardarDb.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 184)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'btn_ADD_INFO
        '
        Me.btn_ADD_INFO.BackColor = System.Drawing.Color.Transparent
        Me.btn_ADD_INFO.BackgroundImage = Global.Calls.My.Resources.Resources.ASISTIR_LLAMADA_AGREGAR
        Me.btn_ADD_INFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ADD_INFO.FlatAppearance.BorderSize = 0
        Me.btn_ADD_INFO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_ADD_INFO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_ADD_INFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ADD_INFO.ForeColor = System.Drawing.Color.Maroon
        Me.btn_ADD_INFO.Location = New System.Drawing.Point(7, 82)
        Me.btn_ADD_INFO.Name = "btn_ADD_INFO"
        Me.btn_ADD_INFO.Size = New System.Drawing.Size(509, 56)
        Me.btn_ADD_INFO.TabIndex = 19
        Me.btn_ADD_INFO.UseVisualStyleBackColor = False
        '
        'BtnRecargar
        '
        Me.BtnRecargar.BackgroundImage = Global.Calls.My.Resources.Resources.r_valores
        Me.BtnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRecargar.FlatAppearance.BorderSize = 0
        Me.BtnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecargar.Location = New System.Drawing.Point(626, 347)
        Me.BtnRecargar.Name = "BtnRecargar"
        Me.BtnRecargar.Size = New System.Drawing.Size(126, 39)
        Me.BtnRecargar.TabIndex = 30
        Me.BtnRecargar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.Calls.My.Resources.Resources.cancelar
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(626, 392)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(126, 39)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Table_Logs
        '
        Me.Table_Logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Logs.Location = New System.Drawing.Point(12, 302)
        Me.Table_Logs.Name = "Table_Logs"
        Me.Table_Logs.Size = New System.Drawing.Size(608, 129)
        Me.Table_Logs.TabIndex = 34
        '
        'Asistir_llamada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 640)
        Me.Controls.Add(Me.Wb)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Asistir_llamada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistir_llamada"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_EXISTENTE.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Logs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Combo_direcciones As ComboBox
    Friend WithEvents Combo_Driver As ComboBox
    Friend WithEvents ComboVehiculos As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnRecargar As Button
    Friend WithEvents Wb As WebBrowser
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GB_EXISTENTE As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtAddClient As TextBox
    Friend WithEvents CbAddClient As CheckBox
    Friend WithEvents CbDireccionAdd As CheckBox
    Friend WithEvents TxtAddDireccion As TextBox
    Friend WithEvents btn_ADD_INFO As Button
    Friend WithEvents Btn_GuardarDb As Button
    Friend WithEvents Table_Logs As DataGridView
End Class
