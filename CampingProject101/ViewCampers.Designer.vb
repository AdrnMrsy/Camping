<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCampers
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
        Label1 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Button6 = New Button()
        Button3 = New Button()
        Label10 = New Label()
        Button7 = New Button()
        lblTotalCampers = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Panel3 = New Panel()
        Label4 = New Label()
        CType(dgvdata, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvdata
        ' 
        dgvdata.AllowUserToOrderColumns = True
        dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata.Location = New Point(229, 197)
        dgvdata.Name = "dgvdata"
        dgvdata.RowTemplate.Height = 25
        dgvdata.Size = New Size(545, 199)
        dgvdata.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(246, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 21)
        Label1.TabIndex = 4
        Label1.Text = "Camper List"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Button7)
        Panel1.Location = New Point(-3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(194, 488)
        Panel1.TabIndex = 40
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(47, 252)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 23)
        Button1.TabIndex = 7
        Button1.Text = "Archive Campers"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(47, 309)
        Button6.Name = "Button6"
        Button6.Size = New Size(99, 23)
        Button6.TabIndex = 6
        Button6.Text = "Main Menu"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(47, 125)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 23)
        Button3.TabIndex = 1
        Button3.Text = "Add Campers"
        Button3.UseVisualStyleBackColor = True
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
        ' Button7
        ' 
        Button7.Location = New Point(47, 186)
        Button7.Name = "Button7"
        Button7.Size = New Size(106, 23)
        Button7.TabIndex = 2
        Button7.Text = "Edit Campers"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' lblTotalCampers
        ' 
        lblTotalCampers.AutoSize = True
        lblTotalCampers.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalCampers.Location = New Point(65, 47)
        lblTotalCampers.Name = "lblTotalCampers"
        lblTotalCampers.Size = New Size(25, 30)
        lblTotalCampers.TabIndex = 41
        lblTotalCampers.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(69, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 30)
        Label2.TabIndex = 42
        Label2.Text = "0"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblTotalCampers)
        Panel2.Location = New Point(278, 37)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(148, 89)
        Panel2.TabIndex = 43
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(43, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 21)
        Label3.TabIndex = 11
        Label3.Text = "Campers"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(529, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(159, 89)
        Panel3.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(37, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 21)
        Label4.TabIndex = 11
        Label4.Text = "All Campers"
        ' 
        ' ViewCampers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(dgvdata)
        Name = "ViewCampers"
        Text = "ViewCampers"
        CType(dgvdata, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents AccountID As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents AccountCreation As DataGridViewTextBoxColumn
    Friend WithEvents AccType As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTotalCampers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
End Class
