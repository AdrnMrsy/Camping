Public Class AddCamper
    Private Sub AddCamper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CamperRegister_Click(sender As Object, e As EventArgs) Handles CamperRegister.Click, btnAdd.Click
        For Each Item As Control In Me.Controls
            If (TypeOf Item Is TextBox) Then
                If (Item.Text = "") Then
                    MsgBox("All Fields are required")
                    Return
                End If

            End If
        Next
        AddCampers()
    End Sub



    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        ViewCampers.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        EditCampers.Show()
    End Sub
End Class