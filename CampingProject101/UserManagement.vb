Public Class UserManagement
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        AdminInterface.Show()
    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usercamperDisplayData()
        userstaffDisplayData()
        DisplayTotalusermanagement()
        DisplayTotalStaffusermanagement()
        DisplayTotalCamperusermanagement()
    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotalusers.Click

    End Sub
End Class