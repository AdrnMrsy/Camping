Public Class AdminInterface
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnCampmng_Click(sender As Object, e As EventArgs) Handles btncampmng.Click
        Me.Hide()
        CamperManagement.Show()

    End Sub
End Class