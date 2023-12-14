Public Class EditCampers
    Private Sub EditCampers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ID_Click(sender As Object, e As EventArgs) Handles ID.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtUsername.Visible = True
        txtPassword.Visible = True
        txtFullName.Visible = True
        txtAddress.Visible = True
        txtAge.Visible = True
        txtPhoneNum.Visible = True
        txtuserid.Visible = True
        txtdate.Visible = True
        txtBirthday.Visible = True

        lblname.Visible = False
        lblpass.Visible = False
        lblnumber.Visible = False
        lblfname.Visible = False
        lblid.Visible = False
        lblage.Visible = False
        lblbdate.Visible = False
        lbljdate.Visible = False
        lbladdress.Visible = False



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtUsername.Visible = False
        txtPassword.Visible = False
        txtFullName.Visible = False
        txtAddress.Visible = False
        txtAge.Visible = False
        txtPhoneNum.Visible = False
        txtuserid.Visible = False
        txtdate.Visible = False
        txtBirthday.Visible = False
        lblname.Visible = True
        lblpass.Visible = True
        lblnumber.Visible = True
        lblfname.Visible = True
        lblid.Visible = True
        lblage.Visible = True
        lblbdate.Visible = True
        lbljdate.Visible = True
        lbladdress.Visible = True
        Label8.Visible = False
        Label8.Enabled = False
        SearchData()


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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        ArchiveCampers.Show()
    End Sub
End Class