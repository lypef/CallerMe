Public Class Contenedor
    Dim f As New functions

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.SetModelForm(Me)
        f.Button_SetModel(Button_Clients, My.Resources.Btn_Clientes)
        f.Button_SetModel(Button_Registros, My.Resources.Btn_registros)
        f.Button_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos)
        f.Button_SetModel(Button_Ajustes, My.Resources.Btn_ajustes)
        f.AddForm_Desktop(Clientes, Desktop)
    End Sub

    Private Sub Button_Clients_MouseEnter(sender As Object, e As EventArgs) Handles Button_Clients.MouseEnter
        f.Button_Hover_SetModel(Button_Clients, My.Resources.Btn_Clientes_Efecto)
    End Sub

    Private Sub Button_Registros_MouseEnter(sender As Object, e As EventArgs) Handles Button_Registros.MouseEnter
        f.Button_Hover_SetModel(Button_Registros, My.Resources.Btn_registros_efct)
    End Sub

    Private Sub Button_Vehiculos_MouseEnter(sender As Object, e As EventArgs) Handles Button_Vehiculo.MouseEnter
        f.Button_Hover_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos_efct)
    End Sub

    Private Sub Button_ajustes_MouseEnter(sender As Object, e As EventArgs) Handles Button_Ajustes.MouseEnter
        f.Button_Hover_SetModel(Button_Ajustes, My.Resources.Btn_ajustes_efct)
    End Sub

    Private Sub Button_Clients_MouseLeave(sender As Object, e As EventArgs) Handles Button_Clients.MouseLeave
        f.Button_SetModel(Button_Clients, My.Resources.Btn_Clientes)
    End Sub

    Private Sub Button_Registros_MouseLeave(sender As Object, e As EventArgs) Handles Button_Registros.MouseLeave
        f.Button_SetModel(Button_Registros, My.Resources.Btn_registros)
    End Sub

    Private Sub Button_Vehiculos_MouseLeave(sender As Object, e As EventArgs) Handles Button_Vehiculo.MouseLeave
        f.Button_SetModel(Button_Vehiculo, My.Resources.Btn_vehiculos)
    End Sub

    Private Sub Button_ajustes_MouseLeave(sender As Object, e As EventArgs) Handles Button_Ajustes.MouseLeave
        f.Button_SetModel(Button_Ajustes, My.Resources.Btn_ajustes)
    End Sub

End Class
