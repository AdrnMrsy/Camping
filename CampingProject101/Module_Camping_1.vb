Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Crypto.Generators

Module Module_Camping_1
    Dim con As New MySqlConnection
    Dim reader, reader2 As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim mysqlcmd2 As New MySqlCommand
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim sqlquery2 As String
    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "camping"
        uname = "root"
        pwd = "adrian999"
        ' check if connection if open
        If Not con Is Nothing Then
            con.Close() 'close dbconnection
            con.ConnectionString = "server =" & host & "; user id = " & uname & "; password = " & pwd & "; database =" & dbname & ""
            Try
                ' open connection
                con.Open()
                MessageBox.Show("Connected")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Public Sub logout()
        AdminInterface.Hide()
        Camping_Login.Show()
        con.Close()
    End Sub

    Public Function GetUserID(username As String) As Integer
        Dim userId As Integer = -1 ' Default value if user ID is not found

        Try

            Dim sqlQuery As String = "SELECT AccountID FROM accounts WHERE Username = @username"
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@username", username)

                Dim result As Object = mysqlcmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    userId = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return userId
    End Function
    Public Function GetcamperID(accountid As Integer) As Integer
        Dim userId As Integer = -1 ' Default value if user ID is not found

        Try

            Dim sqlQuery As String = "SELECT camperid FROM campers WHERE accountid = @accountid"
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@accountid", accountid)

                Dim result As Object = mysqlcmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    userId = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return userId
    End Function


    Public Sub Login()
        Dim username, password As String
        username = Camping_Login.txtuser.Text
        password = Camping_Login.txtpass.Text
        Dim role As String = GetUserRole(username)
        Dim userId As Integer = GetUserID(username)
        Try

            Dim sqlQuery As String = "SELECT * FROM accounts WHERE Username = @username AND Password = @password"
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@username", username)
                mysqlcmd.Parameters.AddWithValue("@password", password)

                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader
                    If reader.Read Then
                        If role = "Camper" Then
                            WelcomeCamper.Show()
                            UserProfile.UserID = userId
                            CamperInterface.UserID = userId
                            camperactivities.userid = userId
                            Camping_Login.Hide()
                        ElseIf role = "Admin" Then
                            WelcomeAdmin.Show()
                            Camping_Login.Hide()
                        ElseIf role = "Staff" Then
                            WelcomeStaff.Show()
                            Camping_Login.Hide()
                        End If
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
        End Try
    End Sub

    Public Function GetUserRole(username As String) As String
        Dim query As String = "SELECT Account_Type FROM Accounts WHERE Username=@Username;"
        Using command As New MySqlCommand(query, con)
            command.Parameters.AddWithValue("@Username", username)
            Try
                Dim role As Object = command.ExecuteScalar()
                If role IsNot Nothing Then
                    Return role.ToString()
                Else
                    Return "Unknown"
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return "Unknown"
            Finally
            End Try
        End Using
    End Function

    Public Sub Camper_Registry()
        Dim username, password, confirmpassword, fullname, age, birthday, phonenumber, address As String

        ' SET TO STRING FOR TEXTBOXES
        username = Camper_Registration.txtUsername.Text
        password = Camper_Registration.txtPassword.Text
        confirmpassword = Camper_Registration.txtconfirmPassword.Text
        fullname = Camper_Registration.txtFullName.Text
        age = Camper_Registration.txtAge.Text
        birthday = Camper_Registration.txtBirthday.Text
        phonenumber = Camper_Registration.txtPhoneNum.Text
        address = Camper_Registration.txtAddress.Text
        Dim fourDigitID As Integer = New Random().Next(1000, 10000)
        Dim copyid As Integer = fourDigitID
        sqlquery = "INSERT INTO camping.campers(Name, Age, Birthday, Phone_Num, Address, AccountID) 
                    VALUES (@fullname, @age, @birthday, @phonenumber, @address, @copyid)"
        sqlquery2 = "INSERT INTO camping.accounts(AccountID, Username, Password, Account_Type) 
                    VALUES (@fourDigitID, @username, @password, 'Camper')"
        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)
        ' PARAMETER VALUES
        ' FOR CAMPERS
        mysqlcmd.Parameters.AddWithValue("@fullname", fullname)
        mysqlcmd.Parameters.AddWithValue("@age", age)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        mysqlcmd.Parameters.AddWithValue("@copyid", copyid)
        ' FOR ACCOUNTS
        mysqlcmd2.Parameters.AddWithValue("@fourdigitID", fourDigitID)
        mysqlcmd2.Parameters.AddWithValue("@username", username)
        mysqlcmd2.Parameters.AddWithValue("@password", password)
        If password = confirmpassword Then
            Try
                ' execute query commadn
                mysqlcmd.ExecuteNonQuery()
                mysqlcmd2.ExecuteNonQuery()
                MsgBox("Registered Successfully")
                Camper_Registration.Hide()
                Camping_Login.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                TextClear()
            End Try
        Else
            MessageBox.Show("Confirm Password does not match!")
        End If
    End Sub
    Public Sub AddCampers()
        Dim username, password, confirmpassword, fullname, age, birthday, phonenumber, address As String

        ' SET TO STRING FOR TEXTBOXES
        username = AddCamper.txtUsername.Text
        password = AddCamper.txtPassword.Text
        confirmpassword = AddCamper.txtconfirmPassword.Text
        fullname = AddCamper.txtFullName.Text
        age = AddCamper.txtAge.Text
        birthday = AddCamper.txtBirthday.Text
        phonenumber = AddCamper.txtPhoneNum.Text
        address = AddCamper.txtAddress.Text
        Dim fourDigitID As Integer = New Random().Next(1000, 10000)
        Dim copyid As Integer = fourDigitID
        sqlquery = "INSERT INTO camping.campers(Name, Age, Birthday, Phone_Num, Address, AccountID) 
                    VALUES (@fullname, @age, @birthday, @phonenumber, @address, @copyid)"
        sqlquery2 = "INSERT INTO camping.accounts(AccountID, Username, Password, Account_Type) 
                    VALUES (@fourDigitID, @username, @password, 'Camper')"
        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)
        ' PARAMETER VALUES
        ' FOR CAMPERS
        mysqlcmd.Parameters.AddWithValue("@fullname", fullname)
        mysqlcmd.Parameters.AddWithValue("@age", age)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        mysqlcmd.Parameters.AddWithValue("@copyid", copyid)
        ' FOR ACCOUNTS
        mysqlcmd2.Parameters.AddWithValue("@fourdigitID", fourDigitID)
        mysqlcmd2.Parameters.AddWithValue("@username", username)
        mysqlcmd2.Parameters.AddWithValue("@password", password)
        If password = confirmpassword Then
            Try
                ' execute query commadn
                mysqlcmd.ExecuteNonQuery()
                mysqlcmd2.ExecuteNonQuery()
                MsgBox("Registered Successfully")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                TextClear()
            End Try
        Else
            MessageBox.Show("Confirm Password does not match!")
        End If
    End Sub
    Public Sub Staff_Registry()
        Dim username, password, confirmpassword, fullname, age, birthday, phonenumber, address As String

        ' SET TO STRING FOR TEXTBOXES
        username = Staff_Registration.txtusername.Text
        password = Staff_Registration.txtpassword.Text
        confirmpassword = Staff_Registration.txtconfirmpassword.Text
        fullname = Staff_Registration.txtfullname.Text
        age = Staff_Registration.txtage.Text
        birthday = Staff_Registration.txtbirthday.Text
        phonenumber = Staff_Registration.txtpassword.Text
        address = Staff_Registration.txtaddress.Text
        Dim fourDigitID As Integer = New Random().Next(1000, 10000)
        Dim copyid As Integer = fourDigitID
        sqlquery = "INSERT INTO camping.staff(Name, Age, Birthday, Phone_Num, Address, AccountID) 
                    VALUES (@fullname, @age, @birthday, @phonenumber, @address, @copyid)"
        sqlquery2 = "INSERT INTO camping.accounts(AccountID, Username, Password, Account_Type) 
                    VALUES (@fourDigitID, @username, @password, 'Staff')"
        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)
        ' PARAMETER VALUES
        ' FOR CAMPERS
        mysqlcmd.Parameters.AddWithValue("@fullname", fullname)
        mysqlcmd.Parameters.AddWithValue("@age", age)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        mysqlcmd.Parameters.AddWithValue("@copyid", copyid)
        ' FOR ACCOUNTS
        mysqlcmd2.Parameters.AddWithValue("@fourdigitID", fourDigitID)
        mysqlcmd2.Parameters.AddWithValue("@username", username)
        mysqlcmd2.Parameters.AddWithValue("@password", password)
        If password = confirmpassword Then
            Try
                ' execute query commadn
                mysqlcmd.ExecuteNonQuery()
                mysqlcmd2.ExecuteNonQuery()
                MsgBox("Registered Successfully")
                Staff_Registration.Hide()
                Camping_Login.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally

            End Try
        Else
            MessageBox.Show("Confirm Password does not match!")
        End If
    End Sub
    Public Sub Admin_Registry()
        Dim username, password, confirmpassword, fullname, age, birthday, phonenumber, address As String

        ' SET TO STRING FOR TEXTBOXES
        username = Admin_Registration.txtUSERNAME.Text
        password = Admin_Registration.txtPASS.Text
        confirmpassword = Admin_Registration.txtCONFIRMPASS.Text
        fullname = Admin_Registration.txtFULLNAME.Text
        age = Admin_Registration.txtAGE.Text
        birthday = Admin_Registration.txtBIRTHDAY.Text
        phonenumber = Admin_Registration.txtPHONENUM.Text
        address = Admin_Registration.txtADDRESS.Text
        Dim fourDigitID As Integer = New Random().Next(1000, 10000)
        Dim copyid As Integer = fourDigitID
        sqlquery = "INSERT INTO camping.admin(Name, Age, Birthday, Phone_Num, Address, AccountID) 
                    VALUES (@fullname, @age, @birthday, @phonenumber, @address, @copyid)"
        sqlquery2 = "INSERT INTO camping.accounts(AccountID, Username, Password, Account_Type) 
                    VALUES (@fourDigitID, @username, @password, 'Admin')"
        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)
        ' PARAMETER VALUES
        ' FOR CAMPERS
        mysqlcmd.Parameters.AddWithValue("@fullname", fullname)
        mysqlcmd.Parameters.AddWithValue("@age", age)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        mysqlcmd.Parameters.AddWithValue("@copyid", copyid)
        ' FOR ACCOUNTS
        mysqlcmd2.Parameters.AddWithValue("@fourdigitID", fourDigitID)
        mysqlcmd2.Parameters.AddWithValue("@username", username)
        mysqlcmd2.Parameters.AddWithValue("@password", password)
        If password = confirmpassword Then
            Try
                ' execute query commadn
                mysqlcmd.ExecuteNonQuery()
                mysqlcmd2.ExecuteNonQuery()
                MsgBox("Registered Successfully")
                Admin_Registration.Hide()
                Camping_Login.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                TextClear()
            End Try
        Else
            MessageBox.Show("Confirm Password does not match!")
        End If
    End Sub
    Sub TextClear()
        ' For Campers
        Camper_Registration.txtUsername.Clear()
        Camper_Registration.txtPassword.Clear()
        Camper_Registration.txtconfirmPassword.Clear()
        Camper_Registration.txtFullName.Clear()
        Camper_Registration.txtAge.Clear()
        Camper_Registration.txtBirthday.Clear()
        Camper_Registration.txtPhoneNum.Clear()
        Camper_Registration.txtAddress.Clear()
        ' For Staff
        Staff_Registration.txtusername.Clear()
        Staff_Registration.txtpassword.Clear()
        Staff_Registration.txtconfirmpassword.Clear()
        Staff_Registration.txtfullname.Clear()
        Staff_Registration.txtage.Clear()
        Staff_Registration.txtbirthday.Clear()
        Staff_Registration.txtpassword.Clear()
        Staff_Registration.txtaddress.Clear()
        ' For Admin
        Admin_Registration.txtUSERNAME.Clear()
        Admin_Registration.txtPASS.Clear()
        Admin_Registration.txtCONFIRMPASS.Clear()
        Admin_Registration.txtFULLNAME.Clear()
        Admin_Registration.txtAGE.Clear()
        Admin_Registration.txtBIRTHDAY.Clear()
        Admin_Registration.txtPHONENUM.Clear()
        Admin_Registration.txtADDRESS.Clear()

    End Sub
    Public Sub EditData()
        Dim id As String
        id = EditCampers.txtid.Text

        ' Assume the new values are taken from the corresponding textboxes in EditCampers form
        Dim newcamperid As Integer = Convert.ToInt32(EditCampers.txtcamperid.Text)
        Dim newName As String = EditCampers.txtFullName.Text
        Dim newAge As Integer = Convert.ToInt32(EditCampers.txtAge.Text)
        Dim newUsername As String = EditCampers.txtUsername.Text
        Dim newPassword As String = EditCampers.txtPassword.Text
        Dim newPhoneNum As String = EditCampers.txtPhoneNum.Text
        Dim newAddress As String = EditCampers.txtAddress.Text
        Dim newBirthday As Date = Convert.ToDateTime(EditCampers.txtBirthday.Text)

        sqlquery = "UPDATE campers 
                SET camperid = @newcamperid, Name = @newName, Age = @newAge, Phone_Num = @newPhoneNum, Address = @newAddress, Birthday = @newBirthday
                WHERE AccountID = @id;"

        ' Update accounts table if needed
        Dim sqlquery2 As String = "UPDATE accounts 
                               SET Username = @newUsername, Password = @newPassword
                               WHERE AccountID = @id;"

        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)

        ' PARAMETER VALUES
        mysqlcmd.Parameters.AddWithValue("@newcamperid", newcamperid)
        mysqlcmd.Parameters.AddWithValue("@newName", newName)
        mysqlcmd.Parameters.AddWithValue("@newAge", newAge)
        mysqlcmd.Parameters.AddWithValue("@newPhoneNum", newPhoneNum)
        mysqlcmd.Parameters.AddWithValue("@newAddress", newAddress)
        mysqlcmd.Parameters.AddWithValue("@newBirthday", newBirthday)
        mysqlcmd.Parameters.AddWithValue("@id", id)

        ' Parameters for accounts table
        mysqlcmd2.Parameters.AddWithValue("@newUsername", newUsername)
        mysqlcmd2.Parameters.AddWithValue("@newPassword", newPassword)
        mysqlcmd2.Parameters.AddWithValue("@id", id)

        Try
            ' Use transactions for better consistency
            Using trans As MySqlTransaction = con.BeginTransaction()
                Try
                    ' Execute update commands
                    mysqlcmd.ExecuteNonQuery()
                    mysqlcmd2.ExecuteNonQuery()

                    ' Commit the transaction if everything is successful
                    trans.Commit()
                    MsgBox("Record updated successfully")

                Catch ex As Exception
                    ' Roll back the transaction if an error occurs
                    trans.Rollback()
                    MsgBox("Error updating record: " & ex.Message)
                End Try
            End Using

        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message)
        End Try
    End Sub
    Public Sub EditDataCamper()

        Dim id As String
        id = UserProfile.UserID

        ' Assume the new values are taken from the corresponding textboxes in EditCampers form
        Dim newcamperid As Integer = Convert.ToInt32(UserProfile.txtcamperid.Text)
        Dim newName As String = UserProfile.txtFullName.Text
        Dim newAge As Integer = Convert.ToInt32(UserProfile.txtAge.Text)
        Dim newUsername As String = UserProfile.txtUsername.Text
        Dim newPassword As String = UserProfile.txtPassword.Text
        Dim newPhoneNum As String = UserProfile.txtPhoneNum.Text
        Dim newAddress As String = UserProfile.txtAddress.Text
        Dim newBirthday As Date = Convert.ToDateTime(UserProfile.txtBirthday.Text)

        sqlquery = "UPDATE campers 
                SET camperid = @newcamperid, Name = @newName, Age = @newAge, Phone_Num = @newPhoneNum, Address = @newAddress, Birthday = @newBirthday
                WHERE AccountID = @id;"

        ' Update accounts table if needed
        Dim sqlquery2 As String = "UPDATE accounts 
                               SET Username = @newUsername, Password = @newPassword
                               WHERE AccountID = @id;"

        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)

        ' PARAMETER VALUES
        mysqlcmd.Parameters.AddWithValue("@newcamperid", newcamperid)
        mysqlcmd.Parameters.AddWithValue("@newName", newName)
        mysqlcmd.Parameters.AddWithValue("@newAge", newAge)
        mysqlcmd.Parameters.AddWithValue("@newPhoneNum", newPhoneNum)
        mysqlcmd.Parameters.AddWithValue("@newAddress", newAddress)
        mysqlcmd.Parameters.AddWithValue("@newBirthday", newBirthday)
        mysqlcmd.Parameters.AddWithValue("@id", id)

        ' Parameters for accounts table
        mysqlcmd2.Parameters.AddWithValue("@newUsername", newUsername)
        mysqlcmd2.Parameters.AddWithValue("@newPassword", newPassword)
        mysqlcmd2.Parameters.AddWithValue("@id", id)

        Try
            ' Use transactions for better consistency
            Using trans As MySqlTransaction = con.BeginTransaction()
                Try
                    ' Execute update commands
                    mysqlcmd.ExecuteNonQuery()
                    mysqlcmd2.ExecuteNonQuery()

                    ' Commit the transaction if everything is successful
                    trans.Commit()
                    MsgBox("Record updated successfully")

                Catch ex As Exception
                    ' Roll back the transaction if an error occurs
                    trans.Rollback()
                    MsgBox("Error updating record: " & ex.Message)
                End Try
            End Using

        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message)
        End Try
    End Sub

    Public Sub PopulateDataToTextBoxes()
        ' Assuming you have labels lblcamperid, lblfname, lblage, lblname, lblpass, lblnumber, lbladdress, lblbdate, lbljdate, lblid
        EditCampers.txtCamperID.Text = EditCampers.lblcamperid.Text
        EditCampers.txtFullName.Text = EditCampers.lblfname.Text
        EditCampers.txtAge.Text = EditCampers.lblage.Text
        EditCampers.txtUsername.Text = EditCampers.lblname.Text
        EditCampers.txtPassword.Text = EditCampers.lblpass.Text
        EditCampers.txtPhoneNum.Text = EditCampers.lblnumber.Text
        EditCampers.txtAddress.Text = EditCampers.lbladdress.Text
        EditCampers.txtBirthday.Text = EditCampers.lblbdate.Text
        EditCampers.txtdate.Text = EditCampers.lbljdate.Text
        EditCampers.txtuserid.Text = EditCampers.lblid.Text
        ' Assuming lblid is a label to display AccountID; if you want to include it in the TextBoxes, you can add it to the appropriate TextBox
    End Sub
    Public Sub PopulateDataToTextBoxescamper()
        ' Assuming you have labels lblcamperid, lblfname, lblage, lblname, lblpass, lblnumber, lbladdress, lblbdate, lbljdate, lblid
        UserProfile.txtcamperid.Text = UserProfile.lblcamperid.Text
        UserProfile.txtFullName.Text = UserProfile.lblfname.Text
        UserProfile.txtAge.Text = UserProfile.lblage.Text
        UserProfile.txtUsername.Text = UserProfile.lblname.Text
        UserProfile.txtPassword.Text = UserProfile.lblpass.Text
        UserProfile.txtPhoneNum.Text = UserProfile.lblnumber.Text
        UserProfile.txtAddress.Text = UserProfile.lbladdress.Text
        UserProfile.txtBirthday.Text = UserProfile.lblbdate.Text
        UserProfile.txtdate.Text = UserProfile.lbljdate.Text
        UserProfile.txtuserid.Text = UserProfile.lblid.Text
        ' Assuming lblid is a label to display AccountID; if you want to include it in the TextBoxes, you can add it to the appropriate TextBox
    End Sub
    Public Sub PopulateDataToLabel()
        ' Assuming you have labels lblcamperid, lblfname, lblage, lblname, lblpass, lblnumber, lbladdress, lblbdate, lbljdate, lblid
        EditCampers.lblcamperid.Text = EditCampers.txtcamperid.Text
        EditCampers.lblfname.Text = EditCampers.txtFullName.Text
        EditCampers.lblage.Text = EditCampers.txtAge.Text
        EditCampers.lblname.Text = EditCampers.txtUsername.Text
        EditCampers.lblpass.Text = EditCampers.txtPassword.Text
        EditCampers.lblnumber.Text = EditCampers.txtPhoneNum.Text
        EditCampers.lbladdress.Text = EditCampers.txtAddress.Text
        EditCampers.lblbdate.Text = EditCampers.txtBirthday.Text
        EditCampers.lbljdate.Text = EditCampers.txtdate.Text
        EditCampers.lblid.Text = EditCampers.txtuserid.Text
        ' Assuming lblid is a label to display AccountID; if you want to include it in the TextBoxes, you can add it to the appropriate TextBox
    End Sub
    Public Sub PopulateDataToLabelcamper()
        ' Assuming you have labels lblcamperid, lblfname, lblage, lblname, lblpass, lblnumber, lbladdress, lblbdate, lbljdate, lblid
        UserProfile.lblcamperid.Text = UserProfile.txtcamperid.Text
        UserProfile.lblfname.Text = UserProfile.txtFullName.Text
        UserProfile.lblage.Text = UserProfile.txtAge.Text
        UserProfile.lblname.Text = UserProfile.txtUsername.Text
        UserProfile.lblpass.Text = UserProfile.txtPassword.Text
        UserProfile.lblnumber.Text = UserProfile.txtPhoneNum.Text
        UserProfile.lbladdress.Text = UserProfile.txtAddress.Text
        UserProfile.lblbdate.Text = UserProfile.txtBirthday.Text
        UserProfile.lbljdate.Text = UserProfile.txtdate.Text
        UserProfile.lblid.Text = UserProfile.txtuserid.Text
        ' Assuming lblid is a label to display AccountID; if you want to include it in the TextBoxes, you can add it to the appropriate TextBox
    End Sub
    Public Sub SearchData()
        Dim id As String
        id = EditCampers.txtid.Text
        sqlquery = "SELECT accounts.*, campers.* FROM accounts JOIN campers ON accounts.AccountID = campers.AccountID WHERE accounts.AccountID = @id;"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@id", id)
        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                EditCampers.lblcamperid.text = reader("camperid").ToString()
                EditCampers.lblfname.Text = reader("Name").ToString()
                EditCampers.lblage.Text = reader("Age").ToString()
                EditCampers.lblname.Text = reader("Username").ToString()
                EditCampers.lblpass.Text = reader("Password").ToString()
                EditCampers.lblnumber.Text = reader("Phone_num").ToString()
                EditCampers.lbladdress.Text = reader("Address").ToString()
                EditCampers.lblbdate.Text = reader("Birthday").date.ToString()
                EditCampers.lbljdate.Text = reader("Join_Date").ToString()
                EditCampers.lblid.Text = reader("AccountID").ToString()
            Else
                MsgBox("no record found")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub
    Public Sub DisplayData(accountType As String)
        Try

            Dim sqlquery As String = "SELECT accounts.*, campers.* FROM accounts JOIN campers ON accounts.AccountID = campers.AccountID;"
            Dim adapter As New MySqlDataAdapter(sqlquery, con)
            adapter.SelectCommand.Parameters.AddWithValue("@type", accountType)

            Dim dtTable As New DataTable
            adapter.Fill(dtTable)

            ' Use the data table as the data source for the DataGridView
            With ViewCampers.dgvdata
                .DataSource = dtTable
                .AutoResizeColumns()

            End With

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub ArchiveData()
        Dim accountid As String = EditCampers.txtid.Text
        Dim deletedcampers As New Dictionary(Of String, Object)

        ' Select data to be deleted
        sqlquery = "SELECT accounts.*, campers.* FROM accounts JOIN campers ON accounts.AccountID = campers.AccountID where accounts.AccountID = @accountid;"
        Try
            Using cmdSelect As New MySqlCommand(sqlquery, con)
                cmdSelect.Parameters.AddWithValue("@accountid", accountid)
                Using reader As MySqlDataReader = cmdSelect.ExecuteReader()
                    If reader.Read() Then
                        ' Store deleted data in variables
                        deletedcampers("AccountID") = reader("AccountID")
                        deletedcampers("camperid") = reader("camperid")
                        deletedcampers("Name") = reader("Name")
                        deletedcampers("Age") = reader("Age")
                        deletedcampers("Birthday") = reader("Birthday")
                        deletedcampers("Phone_Num") = reader("Phone_Num")
                        deletedcampers("Address") = reader("Address")
                        deletedcampers("Join_Date") = reader("Join_Date")
                        deletedcampers("Username") = reader("Username")
                        deletedcampers("Password") = reader("Password")
                        deletedcampers("Account_Type") = reader("Account_Type")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error selecting data: " & ex.Message, vbInformation, "Error Message")
            Return
        End Try

        Try
            Using trans As MySqlTransaction = con.BeginTransaction()
                ' Delete record from accounts table
                sqlquery = "DELETE FROM accounts WHERE AccountID = @accountid"
                Using cmdDelete As New MySqlCommand(sqlquery, con)
                    cmdDelete.Parameters.AddWithValue("@accountid", accountid)
                    cmdDelete.ExecuteNonQuery()
                End Using

                ' Delete record from campers table
                sqlquery = "DELETE FROM campers WHERE AccountID = @accountid"
                Using cmdDelete2 As New MySqlCommand(sqlquery, con)
                    cmdDelete2.Parameters.AddWithValue("@accountid", accountid)
                    cmdDelete2.ExecuteNonQuery()
                End Using

                ' Insert data into the archives table
                sqlquery = "INSERT INTO archives (AccountID, Name, Age, Birthday, Phone_Num, Address, Join_Date, username, password, account_type,roleID)
                        VALUES (@AccountID, @Name, @Age, @Birthday, @Phone_Num, @Address, @Join_Date, @Username, @Password, @Account_Type, @camperid)"
                Using cmdInsert As New MySqlCommand(sqlquery, con)
                    cmdInsert.Parameters.AddWithValue("@AccountID", deletedcampers("AccountID"))
                    cmdInsert.Parameters.AddWithValue("@Name", deletedcampers("Name"))
                    cmdInsert.Parameters.AddWithValue("@Age", deletedcampers("Age"))
                    cmdInsert.Parameters.AddWithValue("@Birthday", deletedcampers("Birthday"))
                    cmdInsert.Parameters.AddWithValue("@Phone_Num", deletedcampers("Phone_Num"))
                    cmdInsert.Parameters.AddWithValue("@Address", deletedcampers("Address"))
                    cmdInsert.Parameters.AddWithValue("@Join_Date", deletedcampers("Join_Date"))
                    cmdInsert.Parameters.AddWithValue("@Username", deletedcampers("Username"))
                    cmdInsert.Parameters.AddWithValue("@Password", deletedcampers("Password"))
                    cmdInsert.Parameters.AddWithValue("@Account_Type", deletedcampers("Account_Type"))
                    cmdInsert.Parameters.AddWithValue("@camperid", deletedcampers("camperid"))
                    cmdInsert.ExecuteNonQuery()
                End Using

                ' Commit the transaction if everything is successful
                trans.Commit()
                MsgBox("Data transferred to another table.", vbInformation, "Transfer Message")
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        Finally
            ' Clear controls after the operation
            ' Your code for clearing controls here
        End Try
    End Sub

    Public Sub DisplayTotalCampers()
        Try
            ' SQL query to get the total number of campers
            Dim sqlquery As String = "SELECT COUNT(*) AS total_campers FROM campers;"
            Using mysqlcmd As New MySqlCommand(sqlquery, con)

                ' Execute the query and retrieve the result
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then

                        ViewCampers.lblTotalCampers.Text = reader("total_campers").ToString()
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Error retrieving total campers: " & ex.Message)
        End Try
    End Sub

    Public Sub DisplayTotalCampersadmin()
        Try
            ' SQL query to get the total number of campers
            Dim sqlquery As String = "SELECT COUNT(*) AS total_campers FROM campers;"
            Using mysqlcmd As New MySqlCommand(sqlquery, con)

                ' Execute the query and retrieve the result
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then

                        AdminInterface.lbltotal.Text = reader("total_campers").ToString()
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Error retrieving total campers: " & ex.Message)
        End Try
    End Sub
    Public Sub DisplayTotalusersadmin()
        Try
            ' SQL query to get the total number of campers
            Dim sqlquery As String = "SELECT SUM(TotalRows) AS CombinedTotalRows
FROM (
    SELECT COUNT(*) AS TotalRows FROM campers
    UNION ALL
    SELECT COUNT(*) AS TotalRows FROM Staff
) AS CombinedCounts;

"
            Using mysqlcmd As New MySqlCommand(sqlquery, con)

                ' Execute the query and retrieve the result
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then

                        AdminInterface.lblusers.Text = reader("CombinedTotalRows").ToString()
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Error retrieving total campers: " & ex.Message)
        End Try
    End Sub
    Public Sub DisplayTotalStaffsadmin()
        Try
            ' SQL query to get the total number of campers
            Dim sqlquery As String = "  
    SELECT COUNT(*) AS TotalRows FROM Staff;

"
            Using mysqlcmd As New MySqlCommand(sqlquery, con)

                ' Execute the query and retrieve the result
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then

                        AdminInterface.lblstaff.Text = reader("TotalRows").ToString()
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Error retrieving total campers: " & ex.Message)
        End Try
    End Sub
    Public Sub DisplayTotalCampersStaff()
        Try
            ' SQL query to get the total number of campers
            Dim sqlquery As String = "SELECT COUNT(*) AS total_campers FROM campers;"
            Using mysqlcmd As New MySqlCommand(sqlquery, con)

                ' Execute the query and retrieve the result
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then

                        StaffInterface.lbltotal.Text = reader("total_campers").ToString()
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Error retrieving total campers: " & ex.Message)
        End Try
    End Sub
    Public Sub ActivityDisplayData()
        Try
            Dim localDtTable As New DataTable
            Dim sqlquery As String = "SELECT * FROM Activities;"

            Using adapter As New MySqlDataAdapter(sqlquery, con)
                ' Fill the local DataTable with data from the database
                localDtTable.Clear()
                adapter.Fill(localDtTable)
            End Using

            ' Check if there is any data before setting it as the data source
            If localDtTable.Rows.Count > 0 Then
                ' Use the local data table as the data source for the DataGridView
                With ActivityCreation.dgvdata
                    .DataSource = localDtTable
                    .AutoResizeColumns()
                End With
            Else
                MsgBox("No data found.")
            End If

        Catch ex As Exception
            MsgBox("Error retrieving and displaying data: " & ex.Message)
        End Try
    End Sub
    Public Sub usercamperDisplayData()
        Try
            Dim localDtTable As New DataTable
            Dim sqlquery As String = "
SELECT 
    A.AccountID,
    A.Username,
    A.Password,
    A.Account_Creation_Date,
    A.Account_Type,
    C.CamperID,
    C.Name AS CamperName,
    C.Age AS CamperAge,
    C.Birthday AS CamperBirthday,
    C.Phone_Num AS CamperPhoneNum,
    C.Address AS CamperAddress,
    C.Join_Date AS CamperJoinDate
FROM 
    Accounts A
LEFT JOIN 
    Campers C ON A.AccountID = C.AccountID where account_type = 'Camper';"


            Using adapter As New MySqlDataAdapter(sqlquery, con)
                ' Fill the local DataTable with data from the database
                localDtTable.Clear()
                adapter.Fill(localDtTable)
            End Using

            ' Check if there is any data before setting it as the data source
            If localDtTable.Rows.Count > 0 Then
                ' Use the local data table as the data source for the DataGridView
                With UserManagement.dgvdata
                    .DataSource = localDtTable
                    .AutoResizeColumns()
                End With
            Else
                MsgBox("No data found.")
            End If

        Catch ex As Exception
            MsgBox("Error retrieving and displaying data: " & ex.Message)
        End Try
    End Sub
    Public Sub userstaffDisplayData()
        Try
            Dim localDtTable As New DataTable
            Dim sqlquery As String = "
SELECT 
    A.AccountID,
    A.Username,
    A.Password,
    A.Account_Creation_Date,
    A.Account_Type,
    S.StaffID,
    S.Name AS StaffName,
    S.Age AS StaffAge,
    S.Birthday AS StaffBirthday,
    S.Phone_Num AS StaffPhoneNum,
    S.Address AS StaffAddress,
    S.Join_Date AS StaffJoinDate
FROM 
    Accounts A
LEFT JOIN 
    Staff S ON A.AccountID = S.AccountID
 where Account_type = 'Staff';"


            Using adapter As New MySqlDataAdapter(sqlquery, con)
                ' Fill the local DataTable with data from the database
                localDtTable.Clear()
                adapter.Fill(localDtTable)
            End Using

            ' Check if there is any data before setting it as the data source
            If localDtTable.Rows.Count > 0 Then
                ' Use the local data table as the data source for the DataGridView
                With UserManagement.dgvdata2
                    .DataSource = localDtTable
                    .AutoResizeColumns()
                End With
            Else
                MsgBox("No data found.")
            End If

        Catch ex As Exception
            MsgBox("Error retrieving and displaying data: " & ex.Message)
        End Try
    End Sub

    Public Sub AddActivities()
        Dim ActivityName, Description, xdate, time, capacity As String

        ' SET TO STRING FOR TEXTBOXES
        ActivityName = ActivityCreation.txtname.Text
        Description = ActivityCreation.rtxdesc.Text
        xdate = ActivityCreation.txtdate.Text
        time = ActivityCreation.txttime.Text
        capacity = ActivityCreation.txtcap.Text

        sqlquery = "INSERT INTO activities(ActivityName, Description, date, time, capacity) 
                    VALUES (@ActivityName, @Description, @xdate, @time, @capacity)"

        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)

        ' PARAMETER VALUES

        mysqlcmd.Parameters.AddWithValue("@ActivityName", ActivityName)
        mysqlcmd.Parameters.AddWithValue("@Description", Description)
        mysqlcmd.Parameters.AddWithValue("@xdate", xdate)
        mysqlcmd.Parameters.AddWithValue("@time", time)
        mysqlcmd.Parameters.AddWithValue("@capacity", capacity)


        Try
            ' execute query commadn
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Registered Successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            TextClear()
        End Try
    End Sub
    Public Sub ActivitySearchData()
        Dim id As String
        id = ActivityCreation.txtid.Text
        sqlquery = "SELECT * FROM activities where activityid=@id;"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@id", id)
        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                ActivityCreation.txtname.Text = reader("ActivityName").ToString()
                ActivityCreation.txtcap.Text = reader("capacity").ToString()
                ActivityCreation.txtdate.Text = reader("date").ToString()
                ActivityCreation.txttime.Text = reader("time").ToString()
                ActivityCreation.rtxdesc.Text = reader("description").ToString()
                ActivityCreation.lblactid.Text = reader("Activityid").ToString()
                ActivityCreation.lbldate.Text = reader("creationtime").ToString()
            Else
                MsgBox("no record found")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub
    Public Sub DisplayTotalActivities()
        Try
            ' SQL query to get the total number of campers
            Dim sqlquery As String = "SELECT COUNT(*) AS total_act FROM activities;"
            Using mysqlcmd As New MySqlCommand(sqlquery, con)

                ' Execute the query and retrieve the result
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then

                        AdminInterface.lblact.Text = reader("total_act").ToString()
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Error retrieving total campers: " & ex.Message)
        End Try
    End Sub
    Public Sub DisplayTotalActivitiesStaff()
        Try
            ' SQL query to get the total number of campers
            Dim sqlquery As String = "SELECT COUNT(*) AS total_act FROM activities;"
            Using mysqlcmd As New MySqlCommand(sqlquery, con)

                ' Execute the query and retrieve the result
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then

                        StaffInterface.lblact.Text = reader("total_act").ToString()
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Error retrieving total campers: " & ex.Message)
        End Try
    End Sub

    Public Sub GetArchiveData()
        Dim id As String
        id = ArchiveCampers.txtid.Text
        sqlquery = "Select * From archives where ArchiveAccID = @id;"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@id", id)
        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then

                ArchiveCampers.lblfname.Text = reader("Name").ToString()
                ArchiveCampers.lblage.Text = reader("Age").ToString()
                ArchiveCampers.lblname.Text = reader("Username").ToString()
                ArchiveCampers.lblpass.Text = reader("Password").ToString()
                ArchiveCampers.lblnumber.Text = reader("Phone_num").ToString()
                ArchiveCampers.lbladdress.Text = reader("Address").ToString()
                ArchiveCampers.lblbdate.Text = reader("Birthday").ToString()
                ArchiveCampers.lbljdate.Text = reader("Join_Date").ToString()
                ArchiveCampers.lblid.Text = reader("AccountID").ToString()
                ArchiveCampers.lblarcid.Text = reader("ArchiveAccID").ToString()


            Else
                MsgBox("no record found")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub
    Public Sub DisplayArchivesData()
        Try
            Dim sqlquery As String = "SELECT * FROM Archives;"

            ' Use a DataTable directly instead of a DataGridView.DataSource
            Dim dtTable As New DataTable

            Using adapter As New MySqlDataAdapter(sqlquery, con)
                ' Fill the local DataTable with data from the database
                adapter.Fill(dtTable)
            End Using

            ' Check if there is any data before setting it as the data source
            If dtTable.Rows.Count > 0 Then
                ' Use the local data table as the data source for the DataGridView
                ArchiveCampers.dgvdata.DataSource = dtTable
                ArchiveCampers.dgvdata.AutoResizeColumns()
            Else
                MsgBox("No data found.")
                ' Clear the DataGridView if there is no data
                ArchiveCampers.dgvdata.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error retrieving and displaying data: " & ex.Message)
        End Try
    End Sub


    Public Sub ActivitiesSelection()
        Try

            Dim sqlquery As String = "SELECT activityid,activityName,description,date,time from activities;"
            Dim adapter As New MySqlDataAdapter(sqlquery, con)

            Dim dtTable As New DataTable
            adapter.Fill(dtTable)

            ' Use the data table as the data source for the DataGridView
            With CamperInterface.dgvdata
                .DataSource = dtTable
                .AutoResizeColumns()

            End With

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub viewActivities(camperid As Integer)
        Try

            Dim sqlquery As String = "SELECT 
    Activities.ActivityID,
    Activities.ActivityName,
    Activities.Description,
    Activities.Date,
    Activities.Time,
    Activities.Capacity,
    CamperActivities.CamperActivityID,
    CamperActivities.CamperID,
    CamperActivities.RegistrationDate
    FROM 
    Activities 
    INNER JOIN 
    CamperActivities  ON Activities.ActivityID = CamperActivities.ActivityID
     ;
"
            Dim adapter As New MySqlDataAdapter(sqlquery, con)
            adapter.SelectCommand.Parameters.AddWithValue("@camperid", camperid)

            Dim dtTable As New DataTable
            adapter.Fill(dtTable)

            ' Use the data table as the data source for the DataGridView
            With camperactivities.dgvdata
                .DataSource = dtTable
                .AutoResizeColumns()

            End With

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub





    Public Sub dgvclicksave(ByVal e As DataGridViewCellEventArgs)
        ' Check if a valid row index and column index is clicked
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Try
                ' Assuming your DataGridView has columns named activityid, activityName, description, date, time
                Dim camperid As String = GetcamperID(CamperInterface.UserID)
                Dim activityId As Object = CamperInterface.dgvdata.Rows(e.RowIndex).Cells("activityid").Value

                ' Ask for confirmation before inserting
                Dim result As DialogResult = MessageBox.Show("Do you want to save this activity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Build the INSERT SQL query
                    Dim insertQuery As String = "INSERT INTO camperactivities (camperid,activityid) " &
                                             "VALUES (@camperid,@activityid);"

                    ' Create a new MySqlCommand
                    Using cmd As New MySqlCommand(insertQuery, con)
                        ' Add parameters to the query
                        cmd.Parameters.AddWithValue("@activityid", activityId)
                        cmd.Parameters.AddWithValue("@camperid", camperid)

                        cmd.ExecuteNonQuery()
                    End Using

                    ' Display a message or perform any additional actions if needed
                    MsgBox("Data inserted into AnotherTable successfully!")
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub


    Public Sub SearchDataCamper()
        Dim id As String
        id = UserProfile.UserID
        sqlquery = "SELECT accounts.*, campers.* FROM accounts JOIN campers ON accounts.AccountID = campers.AccountID WHERE accounts.AccountID = @id;"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@id", id)
        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                UserProfile.lblcamperid.Text = reader("camperid").ToString()
                UserProfile.lblfname.Text = reader("Name").ToString()
                UserProfile.lblage.Text = reader("Age").ToString()
                UserProfile.lblname.Text = reader("Username").ToString()
                UserProfile.lblpass.Text = reader("Password").ToString()
                UserProfile.lblnumber.Text = reader("Phone_num").ToString()
                UserProfile.lbladdress.Text = reader("Address").ToString()
                UserProfile.lblbdate.Text = reader("Birthday").date.ToString()
                UserProfile.lbljdate.Text = reader("Join_Date").ToString()
                UserProfile.lblid.Text = reader("AccountID").ToString()
            Else
                MsgBox("no record found")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub
End Module
