Imports MySql.Data.MySqlClient

Public Class CamperInterface
    Private Sub CamperInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivitiesSelection()
    End Sub

    Private Sub dgvdata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdata.CellContentClick
        dgvclicksave(e)
    End Sub
End Class
