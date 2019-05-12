Public Class LogsADD
    Dim f As New functions

    Public Sub LoadIni()
        f.DataGridView_Model(Table_Clients)
        f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by id desc LIMIT 0, 40", Table_Clients)
        f.ComboBox_SetUsers(Combo_Users)
        f.ComboBox_SetVehiculos(ComboVehiculos)
        f.ComboBox_SetDrivers(Combo_Driver)

        Combo_Telefonos.Items.Add("NUMEROS DE TELEFONO")
        Combo_direcciones.Items.Add("DIRECCIONES")
        Combo_Driver.Items.Add("CONDUCTORES")
        Combo_Telefonos.SelectedIndex = 0
        Combo_direcciones.SelectedIndex = 0
        Combo_Driver.SelectedIndex = 0
        Image.Image = Nothing
        Table_Clients.ClearSelection()
    End Sub

    Private Sub LogsADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = My.Settings.datagridview_color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search()
    End Sub

    Private Sub Search()
        If String.IsNullOrWhiteSpace(TxtSearch.Text) Then
            f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by id desc LIMIT 0, 40", Table_Clients)
        Else
            Dim txt As String = TxtSearch.Text
            f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + txt + "%' or correo_electronico LIKE '%" + txt + "%' or rfc LIKE '%" + txt + "%' OR razon_social LIKE '%" + txt + "%' ORDER by nombre asc", Table_Clients)
            Table_Clients.ClearSelection()
        End If
    End Sub

    Private Sub Table_Clients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table_Clients.CellClick
        If String.IsNullOrEmpty(Table_Clients.SelectedCells(0).Value) = False Then
            functions.Client = Table_Clients.SelectedCells(0).Value
            f.ListNumeros.Clear()
            f.ListDireccion.Clear()
            f.ListConductor.Clear()
            f.ComboBox_SetNumeros_Client(Combo_Telefonos)
            f.ComboBox_SetDireccion_Client(Combo_direcciones)
            f.ComboBox_SetDrivers(Combo_Driver)
            f.Picturebox_SetImageClient(Image)
        End If
    End Sub

    Private Sub Table_Clients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table_Clients.CellDoubleClick
        If String.IsNullOrEmpty(Table_Clients.SelectedCells(0).Value) = False Then
            functions.Client = Table_Clients.SelectedCells(0).Value
            f.ListNumeros.Clear()
            f.ListDireccion.Clear()
            f.ListConductor.Clear()
            f.ComboBox_SetNumeros_Client(Combo_Telefonos)
            f.ComboBox_SetDireccion_Client(Combo_direcciones)
            f.ComboBox_SetDrivers(Combo_Driver)
            f.Picturebox_SetImageClient(Image)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Combo_Telefonos.SelectedIndex > 0 And Combo_Users.SelectedIndex > 0 And Combo_direcciones.SelectedIndex > 0 And ComboVehiculos.SelectedIndex > 0 And Combo_Driver.SelectedIndex > 0 Then
            If f.save_registroMANUAL(Combo_Telefonos, Combo_Users, Combo_direcciones, ComboVehiculos, Combo_Driver, Fecha) Then
                functions.Client = 0
                f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                LoadIni()
            Else
                f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
            End If
        Else
            f.Alert("Verifique su informacion", f.Alert_NumberCritical)
        End If

    End Sub

    Private Sub Table_Clients_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Table_Clients.KeyPress
        If String.IsNullOrEmpty(Table_Clients.SelectedCells(0).Value) = False Then
            functions.Client = Table_Clients.SelectedCells(0).Value
            f.ComboBox_SetNumeros_Client(Combo_Telefonos)
            f.ComboBox_SetDireccion_Client(Combo_direcciones)
            f.ComboBox_SetDrivers(Combo_Driver)
            f.Picturebox_SetImageClient(Image)
        End If
    End Sub

    Private Sub ComboVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboVehiculos.SelectedIndexChanged
        If ComboVehiculos.SelectedIndex > 0 Then
            f.SelectConductor(f.ReturnDriver_Vehicle(f.ListVehiculos.Item(ComboVehiculos.SelectedIndex)), Combo_Driver)
        End If
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Search()
        End If
    End Sub
End Class