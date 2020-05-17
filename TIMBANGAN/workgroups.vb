Imports TIMBANGAN.workgroup_class
Imports TIMBANGAN.access_class
Public Class workgroups
    Dim wc As New workgroup_class(), ac As New access_class()
    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        If ac.checkAccess(btnaddnew) Then
            MessageBox.Show("You have no permission to access Add New", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New add_workgroup
            frm.ShowDialog()
            loadWorkgroups()
        End If
    End Sub

    Private Sub workgroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbworkgroup.SelectedIndex = 0
    End Sub

    Public Sub loadWorkgroups()
        Try
            wc.setWorkgroup(txtsearch.Text)
            wc.setStatus(IIf(cmbworkgroup.SelectedIndex = 0, 1, 0))
            Dim dt As New DataTable(), auto As New AutoCompleteStringCollection()
            dt = wc.showWorkgroups()
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                dgv.Rows.Add(r0w("name"), r0w("description"), IIf(r0w("status") = 1, "Active", "In Active"))
                auto.Add(r0w("name"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            lblnodata.Visible = IIf(dgv.Rows.Count = 0, True, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmbworkgroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbworkgroup.SelectedIndexChanged
        loadWorkgroups()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadWorkgroups()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadWorkgroups()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btnworkgroups) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 3 Then
                If ac.checkAccess(dgv) Then
                    MessageBox.Show("You have no permission to access Edit", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim frm As New add_workgroup()
                    frm.lblheader.Text = "Edit Workgroup"
                    frm.txtname.Text = dgv.CurrentRow.Cells("namee").Value
                    frm.txtdescription.Text = dgv.CurrentRow.Cells("description").Value
                    frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                    frm.current_name = dgv.CurrentRow.Cells("namee").Value
                    frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                    frm.ShowDialog()
                    loadWorkgroups()
                End If
            End If
        End If
    End Sub
End Class