<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityCreation
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
        btnadd = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        dgvdata = New DataGridView()
        Button5 = New Button()
        txtid = New TextBox()
        txtname = New TextBox()
        txtcap = New TextBox()
        txtdate = New TextBox()
        txttime = New TextBox()
        rtxdesc = New RichTextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lbl1 = New Label()
        lblactid = New Label()
        lbldate = New Label()
        lbl2 = New Label()
        btnenable = New Button()
        CType(dgvdata, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(34, 98)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(75, 23)
        btnadd.TabIndex = 0
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Location = New Point(34, 149)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Enabled = False
        Button3.Location = New Point(34, 194)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(34, 249)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 3
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' dgvdata
        ' 
        dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata.Location = New Point(155, 84)
        dgvdata.Name = "dgvdata"
        dgvdata.RowTemplate.Height = 25
        dgvdata.Size = New Size(539, 212)
        dgvdata.TabIndex = 4
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(578, 31)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 5
        Button5.Text = "Search"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(455, 31)
        txtid.Name = "txtid"
        txtid.Size = New Size(126, 23)
        txtid.TabIndex = 6
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(110, 316)
        txtname.Name = "txtname"
        txtname.Size = New Size(126, 23)
        txtname.TabIndex = 7
        ' 
        ' txtcap
        ' 
        txtcap.Location = New Point(110, 360)
        txtcap.Name = "txtcap"
        txtcap.Size = New Size(126, 23)
        txtcap.TabIndex = 8
        ' 
        ' txtdate
        ' 
        txtdate.Location = New Point(606, 314)
        txtdate.Name = "txtdate"
        txtdate.Size = New Size(78, 23)
        txtdate.TabIndex = 9
        ' 
        ' txttime
        ' 
        txttime.Location = New Point(606, 360)
        txttime.Name = "txttime"
        txttime.Size = New Size(78, 23)
        txttime.TabIndex = 10
        ' 
        ' rtxdesc
        ' 
        rtxdesc.Location = New Point(340, 316)
        rtxdesc.Name = "rtxdesc"
        rtxdesc.Size = New Size(180, 74)
        rtxdesc.TabIndex = 11
        rtxdesc.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(155, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 15)
        Label1.TabIndex = 12
        Label1.Text = "Activity Management"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(264, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 13
        Label2.Text = "Description:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(566, 319)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 14
        Label3.Text = "Date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 322)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 15
        Label4.Text = "Activity Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 16
        Label5.Text = "Capacity:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(564, 363)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 17
        Label6.Text = "Time:"
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Location = New Point(34, 410)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(64, 15)
        lbl1.TabIndex = 18
        lbl1.Text = "Activity ID:"
        lbl1.Visible = False
        ' 
        ' lblactid
        ' 
        lblactid.AutoSize = True
        lblactid.Location = New Point(110, 410)
        lblactid.Name = "lblactid"
        lblactid.Size = New Size(56, 15)
        lblactid.TabIndex = 19
        lblactid.Text = "Capacity:"
        lblactid.Visible = False
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Location = New Point(381, 410)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(56, 15)
        lbldate.TabIndex = 20
        lbldate.Text = "Capacity:"
        lbldate.Visible = False
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Location = New Point(278, 410)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(82, 15)
        lbl2.TabIndex = 21
        lbl2.Text = "Creation Date:"
        lbl2.Visible = False
        ' 
        ' btnenable
        ' 
        btnenable.Enabled = False
        btnenable.Location = New Point(34, 98)
        btnenable.Name = "btnenable"
        btnenable.Size = New Size(75, 23)
        btnenable.TabIndex = 22
        btnenable.Text = "Add"
        btnenable.UseVisualStyleBackColor = True
        btnenable.Visible = False
        ' 
        ' ActivityCreation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnenable)
        Controls.Add(lbl2)
        Controls.Add(lbldate)
        Controls.Add(lblactid)
        Controls.Add(lbl1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(rtxdesc)
        Controls.Add(txttime)
        Controls.Add(txtdate)
        Controls.Add(txtcap)
        Controls.Add(txtname)
        Controls.Add(txtid)
        Controls.Add(Button5)
        Controls.Add(dgvdata)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnadd)
        Name = "ActivityCreation"
        Text = "ActivityCreation"
        CType(dgvdata, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtcap As TextBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txttime As TextBox
    Friend WithEvents rtxdesc As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblactid As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnenable As Button
End Class
