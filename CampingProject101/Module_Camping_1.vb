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
    Dim reader As MySqlDataReader
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
    Public Sub Login()
        Dim username, password As String
        username = Camping_Login.txtuser.Text
        password = Camping_Login.txtpass.Text
        Dim role As String = GetUserRole(username)

        Try

            Dim sqlQuery As String = "SELECT * FROM accounts WHERE Username = @username AND Password = @password"
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@username", username)
                mysqlcmd.Parameters.AddWithValue("@password", password)

                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader
                    If reader.Read Then
                        If role = "Camper" Then
                            CamperInterface.Show()
                            Camping_Login.Hide()
                        ElseIf role = "Admin" Then
                            WelcomeAdmin.Show()
                            Camping_Login.Hide()
                        ElseIf role = "Staff" Then
                            StaffInterface.Show()
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
        Dim newName As String = EditCampers.txtFullName.Text
        Dim newAge As Integer = Convert.ToInt32(EditCampers.txtAge.Text)
        Dim newUsername As String = EditCampers.txtUsername.Text
        Dim newPassword As String = EditCampers.txtPassword.Text
        Dim newPhoneNum As String = EditCampers.txtPhoneNum.Text
        Dim newAddress As String = EditCampers.txtAddress.Text
        Dim newBirthday As Date = Convert.ToDateTime(EditCampers.txtBirthday.Text)

        sqlquery = "UPDATE campers 
                SET Name = @newName, Age = @newAge, Phone_Num = @newPhoneNum, Address = @newAddress, Birthday = @newBirthday
                WHERE AccountID = @id;"

        ' Update accounts table if needed
        Dim sqlquery2 As String = "UPDATE accounts 
                               SET Username = @newUsername, Password = @newPassword
                               WHERE AccountID = @id;"

        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)

        ' PARAMETER VALUES
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
            ' Execute update commands
            mysqlcmd.ExecuteNonQuery()
            mysqlcmd2.ExecuteNonQuery()

            MsgBox("Record updated successfully")

        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message)
        End Try
    End Sub

    Public Sub SearchData()
        Dim id As String
        id = EditCampers.txtid.Text
        sqlquery = "SELECT accounts.*, campers.* FROM accounts JOIN campers ON accounts.AccountID = campers.AccountID;"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@id", id)
        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then

                EditCampers.txtFullName.Text = reader("Name").ToString()
                EditCampers.txtAge.Text = reader("Age").ToString()
                EditCampers.txtUsername.Text = reader("Username").ToString()
                EditCampers.txtPassword.Text = reader("Password").ToString()
                EditCampers.txtPhoneNum.Text = reader("Phone_num").ToString()
                EditCampers.txtAddress.Text = reader("Address").ToString()
                EditCampers.txtBirthday.Text = reader("Birthday").ToString()
                EditCampers.txtdate.Text = reader("Join_Date").ToString()
                EditCampers.txtuserid.Text = reader("AccountID").ToString()


            Else
                MsgBox("no record found")
                EditCampers.txtFullName.Clear()
                EditCampers.txtAge.Clear()
                EditCampers.txtUsername.Clear()
                EditCampers.txtPassword.Clear()
                EditCampers.txtPhoneNum.Clear()
                EditCampers.txtAddress.Clear()
                EditCampers.txtBirthday.Clear()
                EditCampers.txtdate.Clear()
                EditCampers.txtuserid.Clear()
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
        sqlquery = "SELECT accounts.*, campers.* FROM accounts JOIN campers ON accounts.AccountID = campers.AccountID;"
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

        ' Delete record from activities table
        sqlquery = "DELETE FROM accounts WHERE AccountID = @accountid"
        Try
            Using cmdDelete As New MySqlCommand(sqlquery, con)
                cmdDelete.Parameters.AddWithValue("@accountid", accountid)
                cmdDelete.ExecuteNonQuery()
                MsgBox("Deletion successful.", vbInformation, "Delete Message")
            End Using
        Catch ex As Exception
            MsgBox("Error deleting data: " & ex.Message, vbInformation, "Error Message")
            Return
        End Try
        sqlquery2 = "DELETE FROM campers WHERE AccountID = @accountid"
        Try
            Using cmdDelete2 As New MySqlCommand(sqlquery2, con)
                cmdDelete2.Parameters.AddWithValue("@accountid", accountid)
                cmdDelete2.ExecuteNonQuery()
                MsgBox("Deletion successful.", vbInformation, "Delete Message")
            End Using
        Catch ex As Exception
            MsgBox("Error deleting data: " & ex.Message, vbInformation, "Error Message")
            Return
        End Try

        ' Insert data into another table (replace 'anothertable' with the actual table name)
        sqlquery = "INSERT INTO archives (AccountID, Name, Age, Birthday, Phone_Num, Address,Join_Date)
VALUES (@AccountID, @Name, @Age, @Birthday,@Phone_Num,@Address, @Join_Date)"
        Try
            Using cmdInsert As New MySqlCommand(sqlquery, con)
                cmdInsert.Parameters.AddWithValue("@AccountID", deletedcampers("AccountID"))
                cmdInsert.Parameters.AddWithValue("@Name", deletedcampers("Name"))
                cmdInsert.Parameters.AddWithValue("@Age", deletedcampers("Age"))
                cmdInsert.Parameters.AddWithValue("@Birthday", deletedcampers("Birthday"))
                cmdInsert.Parameters.AddWithValue("@Phone_Num", deletedcampers("Phone_Num"))
                cmdInsert.Parameters.AddWithValue("@Address", deletedcampers("Address"))
                cmdInsert.Parameters.AddWithValue("@Join_Date", deletedcampers("Join_Date"))
                ' ... repeat for other columns
                cmdInsert.ExecuteNonQuery()
                MsgBox("Data transferred to another table.", vbInformation, "Transfer Message")
            End Using
        Catch ex As Exception
            MsgBox("Error inserting data: " & ex.Message, vbInformation, "Error Message")
        Finally
            ' Clear controls after the operation

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
    Public Sub ActivityDisplayData()
        Try
            Dim sqlquery As String = "SELECT * FROM Activities;"

            Using adapter As New MySqlDataAdapter(sqlquery, con)
                ' Fill the local DataTable with data from the database
                dtTable.Clear()
                adapter.Fill(dtTable)
            End Using

            ' Check if there is any data before setting it as the data source
            If dtTable.Rows.Count > 0 Then
                ' Use the local data table as the data source for the DataGridView
                With ActivityCreation.dgvdata
                    .DataSource = dtTable
                    .AutoResizeColumns()
                End With
            Else
                MsgBox("No data found.")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
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
        sqlquery = "SELECT * FROM activities;"
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
End Module
