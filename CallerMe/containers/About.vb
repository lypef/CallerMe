﻿Public NotInheritable Class About
    Dim f As New functions

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Deployment.CurrentVersion.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description.Replace("%name_enterprise%", f.ReturnEmpresa_Parametros(f.Empresa_Nombre)).Replace("%direccion%", f.ReturnEmpresa_Parametros(f.Empresa_Direccion)).Replace("%rfc%", f.ReturnEmpresa_Parametros(f.Empresa_Rfc))
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
