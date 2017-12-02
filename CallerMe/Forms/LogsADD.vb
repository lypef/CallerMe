Public Class LogsADD
    Dim f As New functions

    Public Sub LoadIni()
        'functions.llamada_NumeroEntrante = "9231200505"

        If String.IsNullOrEmpty(functions.llamada_NumeroEntrante) Then
            'Numero vacio
            f.DataGridView_Model(Table_Clients)
            f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", Table_Clients)
            f.ComboBox_SetUsers(Combo_Users)
            f.ComboBox_SetVehiculos(ComboVehiculos)
        Else
            'Existe numero
        End If
    End Sub

    Private Sub LogsADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = My.Settings.datagridview_color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt As String = TxtSearch.Text
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + txt + "%' or correo_electronico LIKE '%" + txt + "%' or rfc LIKE '%" + txt + "%' OR razon_social LIKE '%" + txt + "%' ORDER by nombre asc", Table_Clients)
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        Dim txt As String = TxtSearch.Text
        f.Clients_DataGridViewSet("SELECT * FROM clients where nombre LIKE '%" + txt + "%' or correo_electronico LIKE '%" + txt + "%' or rfc LIKE '%" + txt + "%' OR razon_social LIKE '%" + txt + "%' ORDER by nombre asc", Table_Clients)
        Table_Clients.ClearSelection()
    End Sub

    Private Sub Table_Clients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table_Clients.CellClick
        If String.IsNullOrEmpty(Table_Clients.SelectedCells(0).Value) = False Then
            functions.Client = Table_Clients.SelectedCells(0).Value
            f.ComboBox_SetNumeros_Client(Combo_Telefonos)
            f.Picturebox_SetImageClient(Image)
        End If
    End Sub

    Private Sub Table_Clients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table_Clients.CellDoubleClick
        If String.IsNullOrEmpty(Table_Clients.SelectedCells(0).Value) = False Then
            functions.Client = Table_Clients.SelectedCells(0).Value
            f.ComboBox_SetNumeros_Client(Combo_Telefonos)
            f.Picturebox_SetImageClient(Image)
        End If
    End Sub
End Class