<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchiveCampers
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
        lblnumber = New Label()
        lblbdate = New Label()
        lblage = New Label()
        lblfname = New Label()
        lblpass = New Label()
        lblname = New Label()
        txtid = New TextBox()
        Label7 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Button1 = New Button()
        Label10 = New Label()
        Button2 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Panel1 = New Panel()
        Button3 = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label11 = New Label()
        lblarcid = New Label()
        lbljdate = New Label()
        lblid = New Label()
        lbladdress = New Label()
        Label9 = New Label()
        ID = New Label()
        Label6 = New Label()
        dgvdata = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgvdata, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblnumber
        ' 
        lblnumber.AutoSize = True
        lblnumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblnumber.Location = New Point(233, 420)
        lblnumber.Name = "lblnumber"
        lblnumber.Size = New Size(112, 21)
        lblnumber.TabIndex = 107
        lblnumber.Text = "PhoneNumber"
        ' 
        ' lblbdate
        ' 
        lblbdate.AutoSize = True
        lblbdate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblbdate.Location = New Point(245, 387)
        lblbdate.Name = "lblbdate"
        lblbdate.Size = New Size(68, 21)
        lblbdate.TabIndex = 106
        lblbdate.Text = "Birthday"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblage.Location = New Point(258, 357)
        lblage.Name = "lblage"
        lblage.Size = New Size(37, 21)
        lblage.TabIndex = 105
        lblage.Text = "Age"
        ' 
        ' lblfname
        ' 
        lblfname.AutoSize = True
        lblfname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblfname.Location = New Point(245, 336)
        lblfname.Name = "lblfname"
        lblfname.Size = New Size(74, 21)
        lblfname.TabIndex = 104
        lblfname.Text = "Fullname"
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblpass.Location = New Point(243, 308)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(76, 21)
        lblpass.TabIndex = 103
        lblpass.Text = "Password"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblname.Location = New Point(238, 280)
        lblname.Name = "lblname"
        lblname.Size = New Size(81, 21)
        lblname.TabIndex = 102
        lblname.Text = "Username"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(467, 35)
        txtid.Margin = New Padding(3, 2, 3, 2)
        txtid.Name = "txtid"
        txtid.Size = New Size(236, 23)
        txtid.TabIndex = 97
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(381, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 21)
        Label7.TabIndex = 92
        Label7.Text = "Password"
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
        Button5.Text = "Archive Campers"
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
        ' Button2
        ' 
        Button2.Location = New Point(31, 164)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 23)
        Button2.TabIndex = 2
        Button2.Text = "Edit Campers"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(545, 406)
        Button8.Name = "Button8"
        Button8.Size = New Size(117, 36)
        Button8.TabIndex = 78
        Button8.Text = "Recover"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(696, 35)
        Button7.Margin = New Padding(3, 2, 3, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(53, 24)
        Button7.TabIndex = 95
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
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(181, 477)
        Panel1.TabIndex = 94
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(671, 406)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 36)
        Button3.TabIndex = 77
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(381, 420)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 21)
        Label5.TabIndex = 88
        Label5.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(359, 387)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 21)
        Label4.TabIndex = 87
        Label4.Text = "Birthday (YYYY-MM-DD)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(400, 357)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 21)
        Label3.TabIndex = 86
        Label3.Text = "Age"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(381, 336)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 85
        Label2.Text = "Full Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(376, 280)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 84
        Label1.Text = "Username"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(647, 371)
        Label11.Name = "Label11"
        Label11.Size = New Size(141, 21)
        Label11.TabIndex = 120
        Label11.Text = "Archive Account ID"
        ' 
        ' lblarcid
        ' 
        lblarcid.AutoSize = True
        lblarcid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblarcid.Location = New Point(566, 371)
        lblarcid.Name = "lblarcid"
        lblarcid.Size = New Size(25, 21)
        lblarcid.TabIndex = 119
        lblarcid.Text = "ID"
        ' 
        ' lbljdate
        ' 
        lbljdate.AutoSize = True
        lbljdate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbljdate.Location = New Point(544, 339)
        lbljdate.Name = "lbljdate"
        lbljdate.Size = New Size(70, 21)
        lbljdate.TabIndex = 118
        lbljdate.Text = "JoinDate"
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblid.Location = New Point(566, 308)
        lblid.Name = "lblid"
        lblid.Size = New Size(25, 21)
        lblid.TabIndex = 117
        lblid.Text = "ID"
        ' 
        ' lbladdress
        ' 
        lbladdress.AutoSize = True
        lbladdress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbladdress.Location = New Point(548, 281)
        lbladdress.Name = "lbladdress"
        lbladdress.Size = New Size(66, 21)
        lbladdress.TabIndex = 116
        lbladdress.Text = "Address"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(660, 339)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 21)
        Label9.TabIndex = 115
        Label9.Text = "Join Date"
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ID.Location = New Point(662, 308)
        ID.Name = "ID"
        ID.Size = New Size(85, 21)
        ID.TabIndex = 114
        ID.Text = "Account ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(660, 280)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 21)
        Label6.TabIndex = 113
        Label6.Text = "Address"
        ' 
        ' dgvdata
        ' 
        dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata.Location = New Point(238, 84)
        dgvdata.Name = "dgvdata"
        dgvdata.RowTemplate.Height = 25
        dgvdata.Size = New Size(526, 171)
        dgvdata.TabIndex = 121
        ' 
        ' ArchiveCampers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvdata)
        Controls.Add(Label11)
        Controls.Add(lblarcid)
        Controls.Add(lbljdate)
        Controls.Add(lblid)
        Controls.Add(lbladdress)
        Controls.Add(Label9)
        Controls.Add(ID)
        Controls.Add(Label6)
        Controls.Add(lblnumber)
        Controls.Add(lblbdate)
        Controls.Add(lblage)
        Controls.Add(lblfname)
        Controls.Add(lblpass)
        Controls.Add(lblname)
        Controls.Add(txtid)
        Controls.Add(Label7)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ArchiveCampers"
        Text = "ArchiveCampers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvdata, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblnumber As Label
    Friend WithEvents lblbdate As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblarcid As Label
    Friend WithEvents lbljdate As Label
    Friend WithEvents lblid As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvdata As DataGridView
End Class
