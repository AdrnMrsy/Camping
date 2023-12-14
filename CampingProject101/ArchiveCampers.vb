Public Class ArchiveCampers
    Private Sub lblbdate_Click(sender As Object, e As EventArgs) Handles lblbdate.Click

    End Sub

    Private Sub ArchiveCampers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayArchivesData()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        ViewCampers.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        EditCampers.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AddCamper.Show()
    End Sub
End Class