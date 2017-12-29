<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parametros
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_DB_Puerto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_DB_DB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_DB_Password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_DB_Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_DB_Servidor = New System.Windows.Forms.TextBox()
        Me.TxtGuardar = New System.Windows.Forms.Button()
        Me.TxtSalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLogoReport = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtUrlData = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tablas_Height = New System.Windows.Forms.NumericUpDown()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxLEd = New System.Windows.Forms.ComboBox()
        Me.TimerInterval = New System.Windows.Forms.NumericUpDown()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.FontDialog2 = New System.Windows.Forms.FontDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tablas_Height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TimerInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Puerto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_DB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Password)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Servidor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 263)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BASE DE DATOS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Probar coneccion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Puerto"
        '
        'Txt_DB_Puerto
        '
        Me.Txt_DB_Puerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_Puerto.Location = New System.Drawing.Point(6, 191)
        Me.Txt_DB_Puerto.Name = "Txt_DB_Puerto"
        Me.Txt_DB_Puerto.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Puerto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Base de datos"
        '
        'Txt_DB_DB
        '
        Me.Txt_DB_DB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_DB.Location = New System.Drawing.Point(6, 152)
        Me.Txt_DB_DB.Name = "Txt_DB_DB"
        Me.Txt_DB_DB.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_DB.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'Txt_DB_Password
        '
        Me.Txt_DB_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_Password.Location = New System.Drawing.Point(6, 113)
        Me.Txt_DB_Password.Name = "Txt_DB_Password"
        Me.Txt_DB_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_DB_Password.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Password.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'Txt_DB_Username
        '
        Me.Txt_DB_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_Username.Location = New System.Drawing.Point(6, 74)
        Me.Txt_DB_Username.Name = "Txt_DB_Username"
        Me.Txt_DB_Username.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Username.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servidor"
        '
        'Txt_DB_Servidor
        '
        Me.Txt_DB_Servidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DB_Servidor.Location = New System.Drawing.Point(6, 35)
        Me.Txt_DB_Servidor.Name = "Txt_DB_Servidor"
        Me.Txt_DB_Servidor.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Servidor.TabIndex = 1
        '
        'TxtGuardar
        '
        Me.TxtGuardar.Location = New System.Drawing.Point(822, 303)
        Me.TxtGuardar.Name = "TxtGuardar"
        Me.TxtGuardar.Size = New System.Drawing.Size(93, 33)
        Me.TxtGuardar.TabIndex = 100
        Me.TxtGuardar.Text = "Guardar"
        Me.TxtGuardar.UseVisualStyleBackColor = True
        '
        'TxtSalir
        '
        Me.TxtSalir.Location = New System.Drawing.Point(739, 303)
        Me.TxtSalir.Name = "TxtSalir"
        Me.TxtSalir.Size = New System.Drawing.Size(77, 33)
        Me.TxtSalir.TabIndex = 99
        Me.TxtSalir.Text = "Salir"
        Me.TxtSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(739, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 33)
        Me.Button2.TabIndex = 101
        Me.Button2.Text = "Eliminar credencial guardada"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtLogoReport)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtUrlData)
        Me.GroupBox2.Location = New System.Drawing.Point(201, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 263)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 195)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(241, 33)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Seleccionar logo"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Logo reportes"
        '
        'TxtLogoReport
        '
        Me.TxtLogoReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLogoReport.Location = New System.Drawing.Point(6, 163)
        Me.TxtLogoReport.Name = "TxtLogoReport"
        Me.TxtLogoReport.Size = New System.Drawing.Size(241, 26)
        Me.TxtLogoReport.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(241, 33)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Seleccionar carpeta"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Donde se guardan los datos"
        '
        'TxtUrlData
        '
        Me.TxtUrlData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUrlData.Location = New System.Drawing.Point(6, 35)
        Me.TxtUrlData.Name = "TxtUrlData"
        Me.TxtUrlData.Size = New System.Drawing.Size(241, 26)
        Me.TxtUrlData.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Tablas_Height)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 281)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 100)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tablas"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(157, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 34)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Color de seleccion"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(17, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 34)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Tipo de letra"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(17, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 34)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Color de fondo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Alto de filas"
        '
        'Tablas_Height
        '
        Me.Tablas_Height.Location = New System.Drawing.Point(223, 69)
        Me.Tablas_Height.Name = "Tablas_Height"
        Me.Tablas_Height.Size = New System.Drawing.Size(57, 20)
        Me.Tablas_Height.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.ComboBoxLEd)
        Me.GroupBox4.Controls.Add(Me.TimerInterval)
        Me.GroupBox4.Location = New System.Drawing.Point(460, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(253, 263)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Identificador de llamadas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Intervalo de comprobacion de llamada"
        '
        'ComboBoxLEd
        '
        Me.ComboBoxLEd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBoxLEd.FormattingEnabled = True
        Me.ComboBoxLEd.Items.AddRange(New Object() {"MODO LUZ LED", "LED APAGADO", "ROJA SIEMPRE", "VERDE SIEMPRE", "AMARILLA SIEMPRE", "ROJA INTERMITENTE DESPACIO", "VERDE INTERMITENTE DESPACIO", "AMARILLA INTERMITENTE DESPACIO", "ROJA INTERMITENTE RAPIDO", "VERDE INTERMITENTE RAPIDO", "AMARILLA INTERMITENTE RAPIDO"})
        Me.ComboBoxLEd.Location = New System.Drawing.Point(10, 35)
        Me.ComboBoxLEd.Name = "ComboBoxLEd"
        Me.ComboBoxLEd.Size = New System.Drawing.Size(238, 28)
        Me.ComboBoxLEd.TabIndex = 4
        '
        'TimerInterval
        '
        Me.TimerInterval.Location = New System.Drawing.Point(10, 98)
        Me.TimerInterval.Name = "TimerInterval"
        Me.TimerInterval.Size = New System.Drawing.Size(238, 20)
        Me.TimerInterval.TabIndex = 6
        Me.TimerInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 22)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(176, 34)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Tipo de letra alertas"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Location = New System.Drawing.Point(310, 281)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(403, 100)
        Me.GroupBox5.TabIndex = 102
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Otros"
        '
        'Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 457)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtSalir)
        Me.Controls.Add(Me.TxtGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Parametros"
        Me.Text = "config"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tablas_Height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TimerInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_DB_Puerto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_DB_DB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_DB_Password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_DB_Username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_DB_Servidor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtGuardar As Button
    Friend WithEvents TxtSalir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtUrlData As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tablas_Height As NumericUpDown
    Friend WithEvents Button4 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLogoReport As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBoxLEd As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TimerInterval As NumericUpDown
    Friend WithEvents Button8 As Button
    Friend WithEvents FontDialog2 As FontDialog
    Friend WithEvents GroupBox5 As GroupBox
End Class
