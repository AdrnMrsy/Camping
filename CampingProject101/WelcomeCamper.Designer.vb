﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeCamper
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
        Label10 = New Label()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(352, 377)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 10
        Label1.Text = "Click Anywhere"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ActiveCaption
        Label10.Font = New Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(299, 178)
        Label10.Name = "Label10"
        Label10.Size = New Size(217, 36)
        Label10.TabIndex = 9
        Label10.Text = "Welcome Camper"
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaption
        Button4.Location = New Point(-1, -1)
        Button4.Name = "Button4"
        Button4.Size = New Size(800, 454)
        Button4.TabIndex = 11
        Button4.UseVisualStyleBackColor = False
        ' 
        ' WelcomeCamper
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Label10)
        Controls.Add(Button4)
        Name = "WelcomeCamper"
        Text = "WelcomeCamper"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
End Class
