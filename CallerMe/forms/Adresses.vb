Public Class Adresses
    Dim f As New functions

    Private Sub Adresses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.DataGridView_Model(DataGridView1)
    End Sub

    Public Sub Loader()
        f.Clients_DataGridViewSet("SELECT * FROM clients ORDER by nombre asc", DataGridView1)
        functions.Client = 0
    End Sub
End Class