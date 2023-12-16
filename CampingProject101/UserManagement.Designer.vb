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
        dgvdata = New DataGridView()
        Panel1 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Label10 = New Label()
        Panel3 = New Panel()
        lblcampers = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        lbltotal = New Label()
        Label2 = New Label()
        Panel4 = New Panel()
        lblstaff = New Label()
        Label3 = New Label()
        dgvdata2 = New DataGridView()
        CType(dgvdata, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvdata2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvdata
        ' 
        dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata.Location = New Point(239, 148)
        dgvdata.Name = "dgvdata"
        dgvdata.RowTemplate.Height = 25
        dgvdata.Size = New Size(500, 142)
        dgvdata.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(181, 477)
        Panel1.TabIndex = 95
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(44, 170)
        Button6.Name = "Button6"
        Button6.Size = New Size(99, 23)
        Button6.TabIndex = 6
        Button6.Text = "Main Menu"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(31, 119)
        Button5.Name = "Button5"
        Button5.Size = New Size(131, 23)
        Button5.TabIndex = 5
        Button5.Text = "Archive users"
        Button5.UseVisualStyleBackColor = True
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
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(lblcampers)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(421, 29)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(124, 100)
        Panel3.TabIndex = 97
        ' 
        ' lblcampers
        ' 
        lblcampers.AutoSize = True
        lblcampers.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblcampers.Location = New Point(51, 59)
        lblcampers.Name = "lblcampers"
        lblcampers.Size = New Size(19, 21)
        lblcampers.TabIndex = 12
        lblcampers.Text = "0"
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
        Panel2.Location = New Point(239, 29)
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
        Panel4.Controls.Add(lblstaff)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(606, 29)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(133, 100)
        Panel4.TabIndex = 98
        ' 
        ' lblstaff
        ' 
        lblstaff.AutoSize = True
        lblstaff.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblstaff.Location = New Point(59, 59)
        lblstaff.Name = "lblstaff"
        lblstaff.Size = New Size(19, 21)
        lblstaff.TabIndex = 12
        lblstaff.Text = "0"
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
        ' dgvdata2
        ' 
        dgvdata2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata2.Location = New Point(239, 296)
        dgvdata2.Name = "dgvdata2"
        dgvdata2.RowTemplate.Height = 25
        dgvdata2.Size = New Size(500, 142)
        dgvdata2.TabIndex = 100
        ' 
        ' UserManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvdata2)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(dgvdata)
        Name = "UserManagement"
        Text = "UserManagement"
        CType(dgvdata, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvdata2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblcampers As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblstaff As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvdata2 As DataGridView
End Class
