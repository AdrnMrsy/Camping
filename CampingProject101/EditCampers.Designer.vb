﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCampers
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
        txtBirthday = New TextBox()
        Button6 = New Button()
        Button5 = New Button()
        Button1 = New Button()
        Label10 = New Label()
        Button4 = New Button()
        Button2 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Panel1 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        Button3 = New Button()
        txtconfirmPassword = New TextBox()
        txtPassword = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtAddress = New TextBox()
        txtAge = New TextBox()
        txtPhoneNum = New TextBox()
        txtFullName = New TextBox()
        txtUsername = New TextBox()
        txtid = New TextBox()
        txtuserid = New TextBox()
        ID = New Label()
        txtdate = New TextBox()
        Label9 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Location = New Point(224, 208)
        txtBirthday.Margin = New Padding(3, 2, 3, 2)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(236, 23)
        txtBirthday.TabIndex = 62
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(47, 320)
        Button6.Name = "Button6"
        Button6.Size = New Size(99, 23)
        Button6.TabIndex = 6
        Button6.Text = "Main Menu"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(31, 263)
        Button5.Name = "Button5"
        Button5.Size = New Size(131, 23)
        Button5.TabIndex = 5
        Button5.Text = "Search Campers"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(47, 103)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 23)
        Button1.TabIndex = 1
        Button1.Text = "Add Campers"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(19, 46)
        Label10.Name = "Label10"
        Label10.Size = New Size(161, 21)
        Label10.TabIndex = 0
        Label10.Text = "Camper Management"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(47, 207)
        Button4.Name = "Button4"
        Button4.Size = New Size(99, 23)
        Button4.TabIndex = 4
        Button4.Text = "View Campers"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(47, 155)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 23)
        Button2.TabIndex = 2
        Button2.Text = "Edit Campers"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Enabled = False
        Button8.Location = New Point(275, 391)
        Button8.Name = "Button8"
        Button8.Size = New Size(117, 36)
        Button8.TabIndex = 42
        Button8.Text = "Edit Campers"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(662, 20)
        Button7.Margin = New Padding(3, 2, 3, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(53, 24)
        Button7.TabIndex = 61
        Button7.Text = "Search Campers"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(-6, -28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(195, 477)
        Panel1.TabIndex = 60
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(602, 106)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 21)
        Label8.TabIndex = 58
        Label8.Text = "Confirm Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(353, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 21)
        Label7.TabIndex = 57
        Label7.Text = "Password"
        ' 
        ' Button3
        ' 
        Button3.Enabled = False
        Button3.Location = New Point(511, 391)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 36)
        Button3.TabIndex = 41
        Button3.Text = "Delete Campers"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtconfirmPassword
        ' 
        txtconfirmPassword.Location = New Point(464, 106)
        txtconfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtconfirmPassword.Name = "txtconfirmPassword"
        txtconfirmPassword.PasswordChar = "*"c
        txtconfirmPassword.Size = New Size(114, 23)
        txtconfirmPassword.TabIndex = 56
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(224, 106)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(114, 23)
        txtPassword.TabIndex = 55
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(464, 276)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 21)
        Label6.TabIndex = 54
        Label6.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(464, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 21)
        Label5.TabIndex = 53
        Label5.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(464, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 21)
        Label4.TabIndex = 52
        Label4.Text = "Birthday (YYYY-MM-DD)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(464, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 21)
        Label3.TabIndex = 51
        Label3.Text = "Age"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(464, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 50
        Label2.Text = "Full Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(464, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 49
        Label1.Text = "Username"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(224, 276)
        txtAddress.Margin = New Padding(3, 2, 3, 2)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(236, 23)
        txtAddress.TabIndex = 48
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(224, 172)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(236, 23)
        txtAge.TabIndex = 47
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(224, 243)
        txtPhoneNum.Margin = New Padding(3, 2, 3, 2)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(236, 23)
        txtPhoneNum.TabIndex = 46
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(224, 138)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(236, 23)
        txtFullName.TabIndex = 45
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(222, 72)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(236, 23)
        txtUsername.TabIndex = 43
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(433, 20)
        txtid.Margin = New Padding(3, 2, 3, 2)
        txtid.Name = "txtid"
        txtid.Size = New Size(236, 23)
        txtid.TabIndex = 63
        ' 
        ' txtuserid
        ' 
        txtuserid.Location = New Point(224, 314)
        txtuserid.Margin = New Padding(3, 2, 3, 2)
        txtuserid.Name = "txtuserid"
        txtuserid.Size = New Size(236, 23)
        txtuserid.TabIndex = 64
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ID.Location = New Point(466, 312)
        ID.Name = "ID"
        ID.Size = New Size(25, 21)
        ID.TabIndex = 65
        ID.Text = "ID"
        ' 
        ' txtdate
        ' 
        txtdate.Location = New Point(224, 345)
        txtdate.Margin = New Padding(3, 2, 3, 2)
        txtdate.Name = "txtdate"
        txtdate.Size = New Size(236, 23)
        txtdate.TabIndex = 66
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(474, 343)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 21)
        Label9.TabIndex = 67
        Label9.Text = "Join Date"
        ' 
        ' EditCampers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(740, 453)
        Controls.Add(Label9)
        Controls.Add(txtdate)
        Controls.Add(ID)
        Controls.Add(txtuserid)
        Controls.Add(txtid)
        Controls.Add(txtBirthday)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(txtconfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAddress)
        Controls.Add(txtAge)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtFullName)
        Controls.Add(txtUsername)
        Name = "EditCampers"
        Text = "EditCampers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txtconfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents Label9 As Label
End Class