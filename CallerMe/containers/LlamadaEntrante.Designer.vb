<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlamadaEntrante
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
        Me.Numero = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Asistir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Client = New System.Windows.Forms.Label()
        Me.Company = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.Label()
        Me.ref = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumberLine = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numero
        '
        Me.Numero.AutoSize = True
        Me.Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.Location = New System.Drawing.Point(216, 37)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(47, 15)
        Me.Numero.TabIndex = 0
        Me.Numero.Text = "01800"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Calls.My.Resources.Resources.call_128
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 131)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Asistir
        '
        Me.Asistir.Location = New System.Drawing.Point(429, 120)
        Me.Asistir.Name = "Asistir"
        Me.Asistir.Size = New System.Drawing.Size(75, 23)
        Me.Asistir.TabIndex = 2
        Me.Asistir.Text = "Asistir"
        Me.Asistir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Omitir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.Client.AutoSize = True
        Me.Client.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client.Location = New System.Drawing.Point(152, 12)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(135, 16)
        Me.Client.TabIndex = 4
        Me.Client.Text = "Nombre de cliente"
        '
        'Company
        '
        Me.Company.AutoSize = True
        Me.Company.Location = New System.Drawing.Point(154, 60)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(51, 13)
        Me.Company.TabIndex = 5
        Me.Company.Text = "Company"
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.Location = New System.Drawing.Point(154, 81)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(73, 13)
        Me.Type.TabIndex = 6
        Me.Type.Text = "Tipo fijo/movil"
        '
        'ref
        '
        Me.ref.AutoSize = True
        Me.ref.Location = New System.Drawing.Point(154, 102)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(60, 13)
        Me.ref.TabIndex = 7
        Me.ref.Text = "Comentario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Numero:"
        '
        'NumberLine
        '
        Me.NumberLine.AutoSize = True
        Me.NumberLine.Location = New System.Drawing.Point(154, 123)
        Me.NumberLine.Name = "NumberLine"
        Me.NumberLine.Size = New System.Drawing.Size(36, 13)
        Me.NumberLine.TabIndex = 9
        Me.NumberLine.Text = "Linea:"
        '
        'LlamadaEntrante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 150)
        Me.Controls.Add(Me.NumberLine)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.Client)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Asistir)
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
    Friend WithEvents Asistir As Button
    Friend WithEvents Button1 As Button
    Public WithEvents Client As Label
    Public WithEvents Company As Label
    Public WithEvents Type As Label
    Public WithEvents ref As Label
    Public WithEvents Label1 As Label
    Public WithEvents NumberLine As Label
End Class
