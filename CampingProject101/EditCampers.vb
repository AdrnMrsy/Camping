Public Class EditCampers
    Private Sub EditCampers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ID_Click(sender As Object, e As EventArgs) Handles ID.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtcamperid.Visible = True
        txtUsername.Visible = True
        txtPassword.Visible = True
        txtFullName.Visible = True
        txtAddress.Visible = True
        txtAge.Visible = True
        txtPhoneNum.Visible = True
        txtuserid.Visible = True
        txtdate.Visible = True
        txtBirthday.Visible = True
        txtcamperid.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtFullName.Enabled = True
        txtAddress.Enabled = True
        txtAge.Enabled = True
        txtPhoneNum.Enabled = True
        txtuserid.Enabled = True
        txtdate.Enabled = True
        txtBirthday.Enabled = True

        lblcamperid.Visible = False
        lblname.Visible = False
        lblpass.Visible = False
        lblnumber.Visible = False
        lblfname.Visible = False
        lblid.Visible = False
        lblage.Visible = False
        lblbdate.Visible = False
        lbljdate.Visible = False
        lbladdress.Visible = False
        Label8.Enabled = True
        Label8.Enabled = True

        PopulateDataToTextBoxes()

        btnupd.Enabled = True
        btnupd.Visible = True
        Button8.Enabled = False
        Button8.Visible = False
        Button3.Enabled = True
        Button3.Visible = True
        btncancel.Enabled = True
        btncancel.Visible = True

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtcamperid.Visible = False
        txtUsername.Visible = False
        txtPassword.Visible = False
        txtFullName.Visible = False
        txtAddress.Visible = False
        txtAge.Visible = False
        txtPhoneNum.Visible = False
        txtuserid.Visible = False
        txtdate.Visible = False
        txtBirthday.Visible = False
        txtcamperid.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtFullName.Enabled = False
        txtAddress.Enabled = False
        txtAge.Enabled = False
        txtPhoneNum.Enabled = False
        txtuserid.Enabled = False
        txtdate.Enabled = False
        txtBirthday.Enabled = False

        lblname.Visible = True
        lblpass.Visible = True
        lblnumber.Visible = True
        lblfname.Visible = True
        lblid.Visible = True
        lblage.Visible = True
        lblbdate.Visible = True
        lbljdate.Visible = True
        lbladdress.Visible = True
        lblcamperid.Visible = True

        Label8.Visible = False
        Label8.Enabled = False

        Button8.Enabled = True
        Button8.Visible = True
        btnupd.Enabled = False
        btnupd.Visible = False
        Button3.Enabled = False
        Button3.Visible = False
        Label8.Enabled = False
        Label8.Enabled = False
        btncancel.Enabled = False
        btncancel.Visible = False
        SearchData()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ArchiveData()
        Button3.Enabled = False
        Button3.Visible = False
        Button8.Enabled = False
        Button8.Visible = False
        Label8.Enabled = False
        Label8.Enabled = False
        btncancel.Enabled = False
        btncancel.Visible = False
        btnupd.Enabled = False
        btnupd.Visible = False




        txtcamperid.Visible = False
        txtUsername.Visible = False
        txtPassword.Visible = False
        txtFullName.Visible = False
        txtAddress.Visible = False
        txtAge.Visible = False
        txtPhoneNum.Visible = False
        txtuserid.Visible = False
        txtdate.Visible = False
        txtBirthday.Visible = False

        txtcamperid.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtFullName.Enabled = False
        txtAddress.Enabled = False
        txtAge.Enabled = False
        txtPhoneNum.Enabled = False
        txtuserid.Enabled = False
        txtdate.Enabled = False
        txtBirthday.Enabled = False


        lblname.Visible = True
        lblpass.Visible = True
        lblnumber.Visible = True
        lblfname.Visible = True
        lblid.Visible = True
        lblage.Visible = True
        lblbdate.Visible = True
        lbljdate.Visible = True
        lbladdress.Visible = True
        lblcamperid.Visible = True
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

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        EditData()
        Button8.Enabled = True
        Button8.Visible = True
        btnupd.Enabled = False
        btnupd.Visible = False
        Button3.Enabled = False
        Button3.Visible = False
        Label8.Enabled = False
        Label8.Enabled = False
        btncancel.Enabled = False
        btncancel.Visible = False

        txtcamperid.Visible = False
        txtUsername.Visible = False
        txtPassword.Visible = False
        txtFullName.Visible = False
        txtAddress.Visible = False
        txtAge.Visible = False
        txtPhoneNum.Visible = False
        txtuserid.Visible = False
        txtdate.Visible = False
        txtBirthday.Visible = False

        txtcamperid.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtFullName.Enabled = False
        txtAddress.Enabled = False
        txtAge.Enabled = False
        txtPhoneNum.Enabled = False
        txtuserid.Enabled = False
        txtdate.Enabled = False
        txtBirthday.Enabled = False


        lblname.Visible = True
        lblpass.Visible = True
        lblnumber.Visible = True
        lblfname.Visible = True
        lblid.Visible = True
        lblage.Visible = True
        lblbdate.Visible = True
        lbljdate.Visible = True
        lbladdress.Visible = True
        lblcamperid.Visible = True
        PopulateDataToLabel()

    End Sub


    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Button8.Enabled = True
        Button8.Visible = True
        btncancel.Enabled = False
        btncancel.Visible = False
        Button3.Enabled = False
        Button3.Visible = False
        btnupd.Enabled = False
        btnupd.Visible = False
        Label8.Enabled = False
        Label8.Enabled = False

        txtcamperid.Visible = False
        txtUsername.Visible = False
        txtPassword.Visible = False
        txtFullName.Visible = False
        txtAddress.Visible = False
        txtAge.Visible = False
        txtPhoneNum.Visible = False
        txtuserid.Visible = False
        txtdate.Visible = False
        txtBirthday.Visible = False

        txtcamperid.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtFullName.Enabled = False
        txtAddress.Enabled = False
        txtAge.Enabled = False
        txtPhoneNum.Enabled = False
        txtuserid.Enabled = False
        txtdate.Enabled = False
        txtBirthday.Enabled = False


        lblname.Visible = True
        lblpass.Visible = True
        lblnumber.Visible = True
        lblfname.Visible = True
        lblid.Visible = True
        lblage.Visible = True
        lblbdate.Visible = True
        lbljdate.Visible = True
        lbladdress.Visible = True
        lblcamperid.Visible = True
        PopulateDataToLabel()
    End Sub
End Class