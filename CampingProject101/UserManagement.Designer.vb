<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button1 = New Button()
        Label10 = New Label()
        Button2 = New Button()
        Panel3 = New Panel()
        lblact = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        lbltotal = New Label()
        Label2 = New Label()
        Panel4 = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        Panel5 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(253, 154)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(500, 270)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(181, 477)
        Panel1.TabIndex = 95
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(47, 306)
        Button6.Name = "Button6"
        Button6.Size = New Size(99, 23)
        Button6.TabIndex = 6
        Button6.Text = "Main Menu"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(31, 238)
        Button5.Name = "Button5"
        Button5.Size = New Size(131, 23)
        Button5.TabIndex = 5
        Button5.Text = "Archive Campers"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(47, 106)
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
        Label10.Location = New Point(24, 43)
        Label10.Name = "Label10"
        Label10.Size = New Size(138, 21)
        Label10.TabIndex = 0
        Label10.Text = "User Management"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(31, 177)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 23)
        Button2.TabIndex = 2
        Button2.Text = "Edit Campers"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(lblact)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(361, 29)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(124, 100)
        Panel3.TabIndex = 97
        ' 
        ' lblact
        ' 
        lblact.AutoSize = True
        lblact.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblact.Location = New Point(51, 59)
        lblact.Name = "lblact"
        lblact.Size = New Size(19, 21)
        lblact.TabIndex = 12
        lblact.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(26, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 21)
        Label4.TabIndex = 11
        Label4.Text = "Campers"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(lbltotal)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(214, 29)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(120, 100)
        Panel2.TabIndex = 96
        ' 
        ' lbltotal
        ' 
        lbltotal.AutoSize = True
        lbltotal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltotal.Location = New Point(54, 59)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New Size(19, 21)
        lbltotal.TabIndex = 12
        lbltotal.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(39, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 21)
        Label2.TabIndex = 11
        Label2.Text = "Users"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveBorder
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(514, 29)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(124, 100)
        Panel4.TabIndex = 98
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(59, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 21)
        Label1.TabIndex = 12
        Label1.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(48, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 21)
        Label3.TabIndex = 11
        Label3.Text = "Staffs"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveBorder
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(664, 29)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(124, 100)
        Panel5.TabIndex = 99
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(56, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(19, 21)
        Label5.TabIndex = 12
        Label5.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(38, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 21)
        Label6.TabIndex = 11
        Label6.Text = "Admin "
        ' 
        ' UserManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Name = "UserManagement"
        Text = "UserManagement"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblact As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
