<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LlamadaEntrante
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
        Me.Numero = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Client = New System.Windows.Forms.Label()
        Me.Company = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.Label()
        Me.ref = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumberLine = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_asistir = New System.Windows.Forms.Button()
        Me.btn_omitir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numero
        '
        Me.Numero.AutoSize = True
        Me.Numero.BackColor = System.Drawing.Color.Transparent
        Me.Numero.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.ForeColor = System.Drawing.Color.White
        Me.Numero.Location = New System.Drawing.Point(260, 66)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(54, 20)
        Me.Numero.TabIndex = 0
        Me.Numero.Text = "01800"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Calls.My.Resources.Resources.call_128
        Me.PictureBox1.Location = New System.Drawing.Point(40, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 131)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Client
        '
        Me.Client.AutoSize = True
        Me.Client.BackColor = System.Drawing.Color.Transparent
        Me.Client.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client.ForeColor = System.Drawing.Color.White
        Me.Client.Location = New System.Drawing.Point(181, 41)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(138, 20)
        Me.Client.TabIndex = 4
        Me.Client.Text = "Nombre de cliente"
        '
        'Company
        '
        Me.Company.AutoSize = True
        Me.Company.BackColor = System.Drawing.Color.Transparent
        Me.Company.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company.ForeColor = System.Drawing.Color.White
        Me.Company.Location = New System.Drawing.Point(182, 89)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(59, 15)
        Me.Company.TabIndex = 5
        Me.Company.Text = "Company"
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.BackColor = System.Drawing.Color.Transparent
        Me.Type.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type.ForeColor = System.Drawing.Color.White
        Me.Type.Location = New System.Drawing.Point(182, 110)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(86, 15)
        Me.Type.TabIndex = 6
        Me.Type.Text = "Tipo fijo/movil"
        '
        'ref
        '
        Me.ref.AutoSize = True
        Me.ref.BackColor = System.Drawing.Color.Transparent
        Me.ref.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.ForeColor = System.Drawing.Color.White
        Me.ref.Location = New System.Drawing.Point(182, 131)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(70, 15)
        Me.ref.TabIndex = 7
        Me.ref.Text = "Comentario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(183, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Numero:"
        '
        'NumberLine
        '
        Me.NumberLine.AutoSize = True
        Me.NumberLine.BackColor = System.Drawing.Color.Transparent
        Me.NumberLine.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberLine.ForeColor = System.Drawing.Color.White
        Me.NumberLine.Location = New System.Drawing.Point(182, 152)
        Me.NumberLine.Name = "NumberLine"
        Me.NumberLine.Size = New System.Drawing.Size(38, 15)
        Me.NumberLine.TabIndex = 9
        Me.NumberLine.Text = "Linea:"
        '
        'Timer1
        '
        '
        'btn_asistir
        '
        Me.btn_asistir.BackColor = System.Drawing.Color.Transparent
        Me.btn_asistir.BackgroundImage = Global.Calls.My.Resources.Resources.Boton_ASISTIR
        Me.btn_asistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_asistir.FlatAppearance.BorderSize = 0
        Me.btn_asistir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_asistir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_asistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_asistir.ForeColor = System.Drawing.Color.Maroon
        Me.btn_asistir.Location = New System.Drawing.Point(288, 202)
        Me.btn_asistir.Name = "btn_asistir"
        Me.btn_asistir.Size = New System.Drawing.Size(193, 49)
        Me.btn_asistir.TabIndex = 10
        Me.btn_asistir.Text = "Button2"
        Me.btn_asistir.UseVisualStyleBackColor = False
        '
        'btn_omitir
        '
        Me.btn_omitir.BackColor = System.Drawing.Color.Transparent
        Me.btn_omitir.BackgroundImage = Global.Calls.My.Resources.Resources.Boton_omitir
        Me.btn_omitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_omitir.FlatAppearance.BorderSize = 0
        Me.btn_omitir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_omitir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_omitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_omitir.ForeColor = System.Drawing.Color.Maroon
        Me.btn_omitir.Location = New System.Drawing.Point(75, 202)
        Me.btn_omitir.Name = "btn_omitir"
        Me.btn_omitir.Size = New System.Drawing.Size(193, 49)
        Me.btn_omitir.TabIndex = 11
        Me.btn_omitir.Text = "Button2"
        Me.btn_omitir.UseVisualStyleBackColor = False
        '
        'LlamadaEntrante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Calls.My.Resources.Resources.btn_llamada_entrante
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(561, 278)
        Me.Controls.Add(Me.btn_omitir)
        Me.Controls.Add(Me.btn_asistir)
        Me.Controls.Add(Me.NumberLine)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.Client)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Numero)
        Me.Name = "LlamadaEntrante"
        Me.Text = "LlamadaEntrante"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Numero As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Client As Label
    Public WithEvents Company As Label
    Public WithEvents Type As Label
    Public WithEvents ref As Label
    Public WithEvents Label1 As Label
    Public WithEvents NumberLine As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_asistir As Button
    Friend WithEvents btn_omitir As Button
End Class
