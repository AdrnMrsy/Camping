<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffInterface
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
        Label6 = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        lblact = New Label()
        Panel3 = New Panel()
        lbltotal = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Panel1 = New Panel()
        Button5 = New Button()
        btncampmng = New Button()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(54, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 21)
        Label6.TabIndex = 11
        Label6.Text = "Campers"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveBorder
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(271, 226)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(175, 100)
        Panel4.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(78, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(19, 21)
        Label5.TabIndex = 12
        Label5.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(42, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 21)
        Label4.TabIndex = 11
        Label4.Text = "Activities"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(34, 320)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 23)
        Button1.TabIndex = 10
        Button1.Text = "logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblact
        ' 
        lblact.AutoSize = True
        lblact.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblact.Location = New Point(67, 59)
        lblact.Name = "lblact"
        lblact.Size = New Size(19, 21)
        lblact.TabIndex = 12
        lblact.Text = "0"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(lblact)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(505, 51)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(164, 100)
        Panel3.TabIndex = 17
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
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(lbltotal)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(271, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(175, 100)
        Panel2.TabIndex = 15
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(48, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 21)
        Label3.TabIndex = 0
        Label3.Text = "Staff Interface"
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(34, 273)
        Button8.Name = "Button8"
        Button8.Size = New Size(143, 23)
        Button8.TabIndex = 8
        Button8.Text = "User Management"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(34, 225)
        Button7.Name = "Button7"
        Button7.Size = New Size(143, 23)
        Button7.TabIndex = 7
        Button7.Text = "Calendar/Scheduling"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(34, 174)
        Button6.Name = "Button6"
        Button6.Size = New Size(143, 23)
        Button6.TabIndex = 6
        Button6.Text = "Reports And Analytics"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(btncampmng)
        Panel1.Location = New Point(4, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(208, 409)
        Panel1.TabIndex = 14
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
        ' btncampmng
        ' 
        btncampmng.Location = New Point(37, 77)
        btncampmng.Name = "btncampmng"
        btncampmng.Size = New Size(140, 23)
        btncampmng.TabIndex = 1
        btncampmng.Text = "Camping Management"
        btncampmng.UseVisualStyleBackColor = True
        ' 
        ' StaffInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(714, 410)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "StaffInterface"
        Text = "StaffInterface"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblact As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbltotal As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btncampmng As Button
End Class
