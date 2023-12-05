<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCamper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        CRegisterBack = New Button()
        Label8 = New Label()
        Label7 = New Label()
        txtconfirmPassword = New TextBox()
        txtPassword = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label10 = New Label()
        txtAddress = New TextBox()
        txtAge = New TextBox()
        txtBirthday = New TextBox()
        txtPhoneNum = New TextBox()
        txtFullName = New TextBox()
        CamperRegister = New Button()
        txtUsername = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(106, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 21)
        Label1.TabIndex = 0
        Label1.Text = "Edit Campers"
        ' 
        ' CRegisterBack
        ' 
        CRegisterBack.Location = New Point(81, 308)
        CRegisterBack.Margin = New Padding(3, 2, 3, 2)
        CRegisterBack.Name = "CRegisterBack"
        CRegisterBack.Size = New Size(127, 22)
        CRegisterBack.TabIndex = 36
        CRegisterBack.Text = "Return to Login"
        CRegisterBack.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(459, 81)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 21)
        Label8.TabIndex = 35
        Label8.Text = "Confirm Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(210, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 21)
        Label7.TabIndex = 34
        Label7.Text = "Password"
        ' 
        ' txtconfirmPassword
        ' 
        txtconfirmPassword.Location = New Point(321, 81)
        txtconfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtconfirmPassword.Name = "txtconfirmPassword"
        txtconfirmPassword.PasswordChar = "*"c
        txtconfirmPassword.Size = New Size(114, 23)
        txtconfirmPassword.TabIndex = 33
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(81, 81)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(114, 23)
        txtPassword.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(321, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 21)
        Label6.TabIndex = 31
        Label6.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(321, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 21)
        Label5.TabIndex = 30
        Label5.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(321, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 21)
        Label4.TabIndex = 29
        Label4.Text = "Birthday (YYYY-MM-DD)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(321, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 21)
        Label3.TabIndex = 28
        Label3.Text = "Age"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(321, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 27
        Label2.Text = "Full Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(321, 49)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 21)
        Label10.TabIndex = 26
        Label10.Text = "Username"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(81, 251)
        txtAddress.Margin = New Padding(3, 2, 3, 2)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(236, 23)
        txtAddress.TabIndex = 25
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(81, 147)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(236, 23)
        txtAge.TabIndex = 24
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Location = New Point(81, 183)
        txtBirthday.Margin = New Padding(3, 2, 3, 2)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(236, 23)
        txtBirthday.TabIndex = 23
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(81, 218)
        txtPhoneNum.Margin = New Padding(3, 2, 3, 2)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(236, 23)
        txtPhoneNum.TabIndex = 22
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(81, 113)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(236, 23)
        txtFullName.TabIndex = 21
        ' 
        ' CamperRegister
        ' 
        CamperRegister.Location = New Point(318, 291)
        CamperRegister.Margin = New Padding(3, 2, 3, 2)
        CamperRegister.Name = "CamperRegister"
        CamperRegister.Size = New Size(117, 39)
        CamperRegister.TabIndex = 20
        CamperRegister.Text = "Edit Campers "
        CamperRegister.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(81, 50)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(236, 23)
        txtUsername.TabIndex = 19
        ' 
        ' EditCamper1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(668, 385)
        Controls.Add(CRegisterBack)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtconfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label10)
        Controls.Add(txtAddress)
        Controls.Add(txtAge)
        Controls.Add(txtBirthday)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtFullName)
        Controls.Add(CamperRegister)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Name = "EditCamper1"
        Text = "EditCamper"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CRegisterBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtconfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents CamperRegister As Button
    Friend WithEvents txtUsername As TextBox
End Class
