Public Class EditCampers
    Private Sub EditCampers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ID_Click(sender As Object, e As EventArgs) Handles ID.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SearchData()
        Button8.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ArchiveData()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        ViewCampers.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AddCamper.Show()
    End Sub
End Class