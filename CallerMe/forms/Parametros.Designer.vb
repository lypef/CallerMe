﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.GroupBox1.SuspendLayout()
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
        Me.TxtGuardar.Location = New System.Drawing.Point(795, 309)
        Me.TxtGuardar.Name = "TxtGuardar"
        Me.TxtGuardar.Size = New System.Drawing.Size(93, 33)
        Me.TxtGuardar.TabIndex = 100
        Me.TxtGuardar.Text = "Guardar"
        Me.TxtGuardar.UseVisualStyleBackColor = True
        '
        'TxtSalir
        '
        Me.TxtSalir.Location = New System.Drawing.Point(712, 309)
        Me.TxtSalir.Name = "TxtSalir"
        Me.TxtSalir.Size = New System.Drawing.Size(77, 33)
        Me.TxtSalir.TabIndex = 99
        Me.TxtSalir.Text = "Salir"
        Me.TxtSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(712, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 33)
        Me.Button2.TabIndex = 101
        Me.Button2.Text = "Eliminar credencial guardada"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 393)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtSalir)
        Me.Controls.Add(Me.TxtGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Parametros"
        Me.Text = "config"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
