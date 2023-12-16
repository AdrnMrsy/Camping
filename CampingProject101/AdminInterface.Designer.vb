<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInterface
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
        btncampmng = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        lbltotal = New Label()
        Panel3 = New Panel()
        lblact = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        lblusers = New Label()
        Label6 = New Label()
        Panel5 = New Panel()
        lblstaff = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(48, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 21)
        Label1.TabIndex = 0
        Label1.Text = "Admin Interface"
        ' 
        ' btncampmng
        ' 
        btncampmng.Location = New Point(37, 77)
        btncampmng.Name = "btncampmng"
        btncampmng.Size = New Size(140, 23)
        btncampmng.TabIndex = 1
        btncampmng.Text = "Camping Management"
        btncampmng.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(btncampmng)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(208, 409)
        Panel1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(34, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 23)
        Button1.TabIndex = 10
        Button1.Text = "logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(34, 272)
        Button9.Name = "Button9"
        Button9.Size = New Size(143, 23)
        Button9.TabIndex = 9
        Button9.Text = "Settings"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(34, 225)
        Button8.Name = "Button8"
        Button8.Size = New Size(143, 23)
        Button8.TabIndex = 8
        Button8.Text = "User Management"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(34, 171)
        Button6.Name = "Button6"
        Button6.Size = New Size(143, 23)
        Button6.TabIndex = 6
        Button6.Text = "Reports And Analytics"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(34, 127)
        Button5.Name = "Button5"
        Button5.Size = New Size(143, 23)
        Button5.TabIndex = 5
        Button5.Text = "Activity  Scheduling"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(54, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 21)
        Label2.TabIndex = 11
        Label2.Text = "Campers"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(lbltotal)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(269, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(175, 100)
        Panel2.TabIndex = 12
        ' 
        ' lbltotal
        ' 
        lbltotal.AutoSize = True
        lbltotal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltotal.Location = New Point(78, 59)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New Size(19, 21)
        lbltotal.TabIndex = 12
        lbltotal.Text = "0"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(lblact)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(503, 51)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(175, 100)
        Panel3.TabIndex = 13
        ' 
        ' lblact
        ' 
        lblact.AutoSize = True
        lblact.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblact.Location = New Point(78, 59)
        lblact.Name = "lblact"
        lblact.Size = New Size(19, 21)
        lblact.TabIndex = 12
        lblact.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(55, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 21)
        Label4.TabIndex = 11
        Label4.Text = "Activities"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveBorder
        Panel4.Controls.Add(lblusers)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(269, 226)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(175, 100)
        Panel4.TabIndex = 13
        ' 
        ' lblusers
        ' 
        lblusers.AutoSize = True
        lblusers.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblusers.Location = New Point(78, 60)
        lblusers.Name = "lblusers"
        lblusers.Size = New Size(19, 21)
        lblusers.TabIndex = 12
        lblusers.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(54, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 21)
        Label6.TabIndex = 11
        Label6.Text = "Users"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveBorder
        Panel5.Controls.Add(lblstaff)
        Panel5.Controls.Add(Label7)
        Panel5.Location = New Point(503, 226)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(175, 100)
        Panel5.TabIndex = 13
        ' 
        ' lblstaff
        ' 
        lblstaff.AutoSize = True
        lblstaff.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblstaff.Location = New Point(78, 59)
        lblstaff.Name = "lblstaff"
        lblstaff.Size = New Size(19, 21)
        lblstaff.TabIndex = 12
        lblstaff.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(67, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 21)
        Label7.TabIndex = 11
        Label7.Text = "Staff"
        ' 
        ' AdminInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(761, 390)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AdminInterface"
        Text = "AdminInterface"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncampmng As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblact As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblusers As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblstaff As Label
    Friend WithEvents Label7 As Label
End Class
