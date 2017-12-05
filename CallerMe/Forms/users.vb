Public Class users
    Dim f As New functions

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.DataGridView_Model(Table_users)
    End Sub

    Private Sub users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Public Sub LoadINI()
        f.Users_DataGridViewSet("SELECT * FROM users ORDER by name asc", Table_users)
        functions.user_select = Nothing
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            LoadINI()
        End If

        If TabControl1.SelectedIndex = 1 Then
            If f.ReturnPermission(f.Permission_users_EDIT) And String.IsNullOrEmpty(functions.user_select) = False Then
                MsgBox("editar")
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_NoPermitido + "| Seleccione un usuario", f.Alert_NumberCritical)
            End If
        End If

        If TabControl1.SelectedIndex = 2 Then
            If f.ReturnPermission(f.Permission_users_PERMISOS) And String.IsNullOrEmpty(functions.user_select) = False Then
                MsgBox("permisos")
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_NoPermitido + "| Seleccione un usuario", f.Alert_NumberCritical)
            End If
        End If

    End Sub

    Private Sub Table_users_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table_users.CellDoubleClick
        If String.IsNullOrEmpty(Table_users.SelectedCells(0).Value) = False Then
            functions.user_select = Table_users.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert(f.Alert_Verifique_proceso, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_users_EDIT) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_users_PERMISOS) Then
            TabControl1.SelectedIndex = 2
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberCritical)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.ReturnPermission(f.Permission_users_DELETE) Then
            If (MsgBox("¿Esta seguro de eliminar el usuario # " + functions.user_select + " ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If functions.User_delete() Then
                    LoadINI()
                    f.Alert(f.Alert_ProcesoFinalizadoOK, f.Alert_NumberInformacion)
                Else
                    f.Alert(f.Alert_ProcesoFinalizadoNO, f.Alert_NumberCritical)
                End If
            End If
        Else
            f.Alert(f.Alert_NoPermitido, f.Alert_NumberExclamacion)
        End If
    End Sub
End Class