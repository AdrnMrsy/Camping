Imports MySql.Data.MySqlClient

Public Class CamperInterface
    Private Sub CamperInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivitiesSelection()
    End Sub

    Private Sub dgvdata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdata.CellContentClick
        dgvclicksave(e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        UserProfile.Show()
    End Sub

    Private Sub FlowLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel.Paint

    End Sub
    Private _userID As Integer

    Public Property UserID() As Integer
        Get
            Return _userID
        End Get
        Set(ByVal value As Integer)
            _userID = value
        End Set
    End Property
End Class
