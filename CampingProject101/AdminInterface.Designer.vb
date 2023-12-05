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
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel1.SuspendLayout()
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
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btncampmng)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(208, 409)
        Panel1.TabIndex = 2
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(34, 309)
        Button9.Name = "Button9"
        Button9.Size = New Size(143, 23)
        Button9.TabIndex = 9
        Button9.Text = "Settings"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(34, 280)
        Button8.Name = "Button8"
        Button8.Size = New Size(143, 23)
        Button8.TabIndex = 8
        Button8.Text = "User Management"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(34, 251)
        Button7.Name = "Button7"
        Button7.Size = New Size(143, 23)
        Button7.TabIndex = 7
        Button7.Text = "Calendar/Scheduling"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(34, 222)
        Button6.Name = "Button6"
        Button6.Size = New Size(143, 23)
        Button6.TabIndex = 6
        Button6.Text = "Reports And Analytics"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(34, 193)
        Button5.Name = "Button5"
        Button5.Size = New Size(143, 23)
        Button5.TabIndex = 5
        Button5.Text = "Activity  Scheduling"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(34, 164)
        Button4.Name = "Button4"
        Button4.Size = New Size(143, 23)
        Button4.TabIndex = 4
        Button4.Text = "Attendance tracking"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(34, 135)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 23)
        Button3.TabIndex = 3
        Button3.Text = "Financial Management"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(34, 106)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 23)
        Button2.TabIndex = 2
        Button2.Text = "Program Management"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' AdminInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(761, 390)
        Controls.Add(Panel1)
        Name = "AdminInterface"
        Text = "AdminInterface"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncampmng As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
End Class
