<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertContainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertContainer))
        Me.TextBoxMensaje = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Boton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxMensaje
        '
        Me.TextBoxMensaje.Location = New System.Drawing.Point(143, 9)
        Me.TextBoxMensaje.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxMensaje.Multiline = True
        Me.TextBoxMensaje.Name = "TextBoxMensaje"
        Me.TextBoxMensaje.ReadOnly = True
        Me.TextBoxMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMensaje.Size = New System.Drawing.Size(270, 94)
        Me.TextBoxMensaje.TabIndex = 1
        Me.TextBoxMensaje.TabStop = False
        Me.TextBoxMensaje.Text = resources.GetString("TextBoxMensaje.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Calls.My.Resources.Resources.information_128
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 129)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Boton
        '
        Me.Boton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Boton.Location = New System.Drawing.Point(143, 109)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(270, 29)
        Me.Boton.TabIndex = 3
        Me.Boton.Text = "Aceptar"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'AlertContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 147)
        Me.Controls.Add(Me.Boton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AlertContainer"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutBox1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents TextBoxMensaje As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Boton As Button
End Class
