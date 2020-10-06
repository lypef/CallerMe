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
        Me.use_4_windows_second = New System.Windows.Forms.CheckBox()
        Me.use_4_windows = New System.Windows.Forms.CheckBox()
        Me.Use_Device = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.caller_3 = New System.Windows.Forms.CheckBox()
        Me.Omitir = New System.Windows.Forms.NumericUpDown()
        Me.caller_2 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Caller_1 = New System.Windows.Forms.CheckBox()
        Me.TimerInterval = New System.Windows.Forms.NumericUpDown()
        Me.Caller_0 = New System.Windows.Forms.CheckBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.FontDialog2 = New System.Windows.Forms.FontDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckGps = New System.Windows.Forms.CheckBox()
        Me.UrlApi = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.P_generalID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Use_Conmutador = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tablas_Height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Omitir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimerInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.TxtGuardar.Location = New System.Drawing.Point(496, 30)
        Me.TxtGuardar.Name = "TxtGuardar"
        Me.TxtGuardar.Size = New System.Drawing.Size(93, 33)
        Me.TxtGuardar.TabIndex = 100
        Me.TxtGuardar.Text = "Guardar"
        Me.TxtGuardar.UseVisualStyleBackColor = True
        '
        'TxtSalir
        '
        Me.TxtSalir.Location = New System.Drawing.Point(413, 30)
        Me.TxtSalir.Name = "TxtSalir"
        Me.TxtSalir.Size = New System.Drawing.Size(77, 33)
        Me.TxtSalir.TabIndex = 99
        Me.TxtSalir.Text = "Salir"
        Me.TxtSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(413, 69)
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
        Me.GroupBox2.Text = "DATA"
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
        Me.GroupBox3.Size = New System.Drawing.Size(292, 125)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TABLAS"
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
        Me.Label6.Location = New System.Drawing.Point(158, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Alto de filas"
        '
        'Tablas_Height
        '
        Me.Tablas_Height.Location = New System.Drawing.Point(223, 69)
        Me.Tablas_Height.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Tablas_Height.Name = "Tablas_Height"
        Me.Tablas_Height.Size = New System.Drawing.Size(57, 20)
        Me.Tablas_Height.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.use_4_windows_second)
        Me.GroupBox4.Controls.Add(Me.use_4_windows)
        Me.GroupBox4.Controls.Add(Me.Use_Device)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.caller_3)
        Me.GroupBox4.Controls.Add(Me.Omitir)
        Me.GroupBox4.Controls.Add(Me.caller_2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Caller_1)
        Me.GroupBox4.Controls.Add(Me.TimerInterval)
        Me.GroupBox4.Controls.Add(Me.Caller_0)
        Me.GroupBox4.Location = New System.Drawing.Point(460, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(445, 125)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CALLER ID"
        '
        'use_4_windows_second
        '
        Me.use_4_windows_second.AutoSize = True
        Me.use_4_windows_second.Location = New System.Drawing.Point(299, 92)
        Me.use_4_windows_second.Name = "use_4_windows_second"
        Me.use_4_windows_second.Size = New System.Drawing.Size(131, 17)
        Me.use_4_windows_second.TabIndex = 14
        Me.use_4_windows_second.Text = "Ventana de asistencia"
        Me.use_4_windows_second.UseVisualStyleBackColor = True
        '
        'use_4_windows
        '
        Me.use_4_windows.AutoSize = True
        Me.use_4_windows.Location = New System.Drawing.Point(145, 92)
        Me.use_4_windows.Name = "use_4_windows"
        Me.use_4_windows.Size = New System.Drawing.Size(156, 17)
        Me.use_4_windows.TabIndex = 13
        Me.use_4_windows.Text = "Ventana para 4 dispositivos"
        Me.use_4_windows.UseVisualStyleBackColor = True
        '
        'Use_Device
        '
        Me.Use_Device.AutoSize = True
        Me.Use_Device.Location = New System.Drawing.Point(34, 55)
        Me.Use_Device.Name = "Use_Device"
        Me.Use_Device.Size = New System.Drawing.Size(56, 17)
        Me.Use_Device.TabIndex = 12
        Me.Use_Device.Text = "USAR"
        Me.Use_Device.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(142, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Omitir llamada des pues de  ..."
        '
        'caller_3
        '
        Me.caller_3.AutoSize = True
        Me.caller_3.Location = New System.Drawing.Point(369, 43)
        Me.caller_3.Name = "caller_3"
        Me.caller_3.Size = New System.Drawing.Size(61, 17)
        Me.caller_3.TabIndex = 11
        Me.caller_3.Text = "Caller 4"
        Me.caller_3.UseVisualStyleBackColor = True
        '
        'Omitir
        '
        Me.Omitir.Location = New System.Drawing.Point(307, 67)
        Me.Omitir.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Omitir.Name = "Omitir"
        Me.Omitir.Size = New System.Drawing.Size(123, 20)
        Me.Omitir.TabIndex = 6
        Me.Omitir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'caller_2
        '
        Me.caller_2.AutoSize = True
        Me.caller_2.Location = New System.Drawing.Point(290, 43)
        Me.caller_2.Name = "caller_2"
        Me.caller_2.Size = New System.Drawing.Size(61, 17)
        Me.caller_2.TabIndex = 10
        Me.caller_2.Text = "Caller 3"
        Me.caller_2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(142, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Intervalo de comprobacion de llamada"
        '
        'Caller_1
        '
        Me.Caller_1.AutoSize = True
        Me.Caller_1.Location = New System.Drawing.Point(216, 43)
        Me.Caller_1.Name = "Caller_1"
        Me.Caller_1.Size = New System.Drawing.Size(61, 17)
        Me.Caller_1.TabIndex = 9
        Me.Caller_1.Text = "Caller 2"
        Me.Caller_1.UseVisualStyleBackColor = True
        '
        'TimerInterval
        '
        Me.TimerInterval.Location = New System.Drawing.Point(335, 17)
        Me.TimerInterval.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TimerInterval.Name = "TimerInterval"
        Me.TimerInterval.Size = New System.Drawing.Size(95, 20)
        Me.TimerInterval.TabIndex = 6
        Me.TimerInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Caller_0
        '
        Me.Caller_0.AutoSize = True
        Me.Caller_0.Location = New System.Drawing.Point(145, 43)
        Me.Caller_0.Name = "Caller_0"
        Me.Caller_0.Size = New System.Drawing.Size(61, 17)
        Me.Caller_0.TabIndex = 8
        Me.Caller_0.Text = "Caller 1"
        Me.Caller_0.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(286, 29)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 34)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Tipo de letra alertas"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckGps)
        Me.GroupBox5.Controls.Add(Me.UrlApi)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.P_generalID)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.TxtSalir)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.TxtGuardar)
        Me.GroupBox5.Location = New System.Drawing.Point(310, 281)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(595, 125)
        Me.GroupBox5.TabIndex = 102
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "WEB SERVICE & OTROS"
        '
        'CheckGps
        '
        Me.CheckGps.AutoSize = True
        Me.CheckGps.Location = New System.Drawing.Point(315, 78)
        Me.CheckGps.Name = "CheckGps"
        Me.CheckGps.Size = New System.Drawing.Size(81, 17)
        Me.CheckGps.TabIndex = 18
        Me.CheckGps.Text = "USAR GPS"
        Me.CheckGps.UseVisualStyleBackColor = True
        '
        'UrlApi
        '
        Me.UrlApi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlApi.Location = New System.Drawing.Point(51, 74)
        Me.UrlApi.Name = "UrlApi"
        Me.UrlApi.Size = New System.Drawing.Size(254, 22)
        Me.UrlApi.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Url APi"
        '
        'P_generalID
        '
        Me.P_generalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_generalID.Location = New System.Drawing.Point(104, 36)
        Me.P_generalID.Name = "P_generalID"
        Me.P_generalID.Size = New System.Drawing.Size(176, 22)
        Me.P_generalID.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Publico en general"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Use_Conmutador)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Location = New System.Drawing.Point(460, 150)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(445, 125)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CONMUTADOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(156, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Contraseña"
        '
        'Use_Conmutador
        '
        Me.Use_Conmutador.AutoSize = True
        Me.Use_Conmutador.Location = New System.Drawing.Point(34, 58)
        Me.Use_Conmutador.Name = "Use_Conmutador"
        Me.Use_Conmutador.Size = New System.Drawing.Size(56, 17)
        Me.Use_Conmutador.TabIndex = 12
        Me.Use_Conmutador.Text = "USAR"
        Me.Use_Conmutador.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(156, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(274, 22)
        Me.TextBox1.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(156, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Usuario"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TextBox2.Location = New System.Drawing.Point(156, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(274, 22)
        Me.TextBox2.TabIndex = 10
        '
        'Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 457)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
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
        CType(Me.Omitir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimerInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
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
    Friend WithEvents Label8 As Label
    Friend WithEvents TimerInterval As NumericUpDown
    Friend WithEvents Button8 As Button
    Friend WithEvents FontDialog2 As FontDialog
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents caller_3 As CheckBox
    Friend WithEvents caller_2 As CheckBox
    Friend WithEvents Caller_1 As CheckBox
    Friend WithEvents Caller_0 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents P_generalID As TextBox
    Friend WithEvents UrlApi As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckGps As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Omitir As NumericUpDown
    Friend WithEvents Use_Device As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Use_Conmutador As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents use_4_windows As CheckBox
    Friend WithEvents use_4_windows_second As CheckBox
End Class
