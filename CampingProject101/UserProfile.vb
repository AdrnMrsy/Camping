Public Class UserProfile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
        txtconfirmPassword.Enabled = True
        txtconfirmPassword.Visible = True
        Label8.Visible = True

        PopulateDataToTextBoxescamper()

        btnupd.Enabled = True
        btnupd.Visible = True
        Button8.Enabled = False
        Button8.Visible = False
        btncancel.Enabled = True
        btncancel.Visible = True

    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        EditDataCamper()
        Button8.Enabled = True
        Button8.Visible = True
        btnupd.Enabled = False
        btnupd.Visible = False
        txtconfirmPassword.Enabled = False
        txtconfirmPassword.Visible = False
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
        PopulateDataToLabelCamper()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        CamperInterface.Show()
    End Sub

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchDataCamper()
    End Sub
    Private _userID As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        camperactivities.Show()
    End Sub

    Public Property UserID() As Integer
        Get
            Return _userID
        End Get
        Set(ByVal value As Integer)
            _userID = value
        End Set
    End Property
End Class