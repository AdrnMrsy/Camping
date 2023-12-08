Public Class AdminInterface
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnCampmng_Click(sender As Object, e As EventArgs) Handles btncampmng.Click
        Me.Hide()
        ViewCampers.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        logout()
    End Sub



    Private Sub AdminInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTotalCampersadmin()
        DisplayTotalActivities()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        ActivityCreation.Show()

    End Sub
End Class