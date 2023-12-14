<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CamperInterface
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        dgvdata = New DataGridView()
        txtid = New TextBox()
        Panel1.SuspendLayout()
        CType(dgvdata, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(43, 74)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Members"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(43, 140)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 23)
        Button2.TabIndex = 1
        Button2.Text = "Camping Activities"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(43, 210)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 23)
        Button3.TabIndex = 2
        Button3.Text = "User Profile"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 3
        Label1.Text = "Camper Interface"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 337)
        Panel1.TabIndex = 4
        ' 
        ' dgvdata
        ' 
        dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata.Location = New Point(317, 61)
        dgvdata.Name = "dgvdata"
        dgvdata.RowTemplate.Height = 25
        dgvdata.Size = New Size(240, 150)
        dgvdata.TabIndex = 5
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(317, 255)
        txtid.Name = "txtid"
        txtid.Size = New Size(100, 23)
        txtid.TabIndex = 6
        ' 
        ' CamperInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(672, 337)
        Controls.Add(txtid)
        Controls.Add(dgvdata)
        Controls.Add(Panel1)
        Name = "CamperInterface"
        Text = "CamperInterface"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvdata, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents txtid As TextBox
End Class
