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

    Private Sub CRegisterBack_Click(sender As Object, e As EventArgs) Handles CRegisterBack.Click
        Me.Hide()
        CamperManagement.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SearchData()
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged

    End Sub
End Class