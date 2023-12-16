Public Class ActivityCreation
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdata.CellContentClick

    End Sub

    Private Sub ActivityCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivityDisplayData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        AdminInterface.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ActivitySearchData()
        Button2.Enabled = True
        Button3.Enabled = True
        lbl2.Visible = True
        lbl1.Visible = True
        lblactid.Visible = True
        lbldate.Visible = True
        btnadd.Enabled = False
        btnenable.Enabled = True
        btnenable.Visible = True

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles rtxdesc.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        AddActivities()
        ActivityDisplayData()
    End Sub
End Class