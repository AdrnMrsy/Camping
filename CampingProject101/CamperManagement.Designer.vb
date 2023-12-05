<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CamperManagement
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
        Panel1 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button1 = New Button()
        Label10 = New Label()
        Button4 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        Panel1.Controls.Add(Button3)
        Panel1.Location = New Point(295, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(194, 488)
        Panel1.TabIndex = 39
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(47, 333)
        Button6.Name = "Button6"
        Button6.Size = New Size(99, 23)
        Button6.TabIndex = 6
        Button6.Text = "Main Menu"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(28, 288)
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
        Button4.Location = New Point(47, 245)
        Button4.Name = "Button4"
        Button4.Size = New Size(99, 23)
        Button4.TabIndex = 4
        Button4.Text = "View Campers"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(47, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 23)
        Button2.TabIndex = 2
        Button2.Text = "Edit Campers"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(47, 198)
        Button3.Name = "Button3"
        Button3.Size = New Size(99, 23)
        Button3.TabIndex = 3
        Button3.Text = "Delete Campers"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CamperManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "CamperManagement"
        Text = "CampingManagement"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
