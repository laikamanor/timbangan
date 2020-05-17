Imports TIMBANGAN.user_class
Imports TIMBANGAN.access_class
Public Class users
    Dim uc As New user_class(), ac As New access_class()
    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        If ac.checkAccess(btnaddnew) Then
            MessageBox.Show("You have no permission to access Add", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New add_user()
            frm.ShowDialog()
            loadUsers()
        End If
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbstatus.SelectedIndex = 0
        uc.filterWorkgroups(cmbworkgroup, False)
        cmbworkgroup.SelectedIndex = 0
    End Sub
    Public Sub loadUsers()
        Try
            uc.setUsername(txtsearch.Text)
            uc.setWorkgroup(cmbworkgroup.Text)
            uc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
            Dim dt As New DataTable(), auto As New AutoCompleteStringCollection()
            dt = uc.showUsers()
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                dgv.Rows.Add(r0w("workgroup"), r0w("fullname"), r0w("username"), IIf(r0w("status") = 1, "Active", "In Active"))
                auto.Add(r0w("username"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            lblnodata.Visible = IIf(dgv.Rows.Count = 0, True, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged
        loadUsers()
    End Sub

    Private Sub cmbworkgroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbworkgroup.SelectedIndexChanged
        loadUsers()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadUsers()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadUsers()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btnmanageusers) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 4 Then
                If ac.checkAccess(dgv) Then
                    MessageBox.Show("You have no permission to access Edit", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim frm As New add_user()
                    frm.lblheader.Text = "Edit User"
                    frm.current_username = dgv.CurrentRow.Cells("username").Value
                    frm.txtusername.Text = dgv.CurrentRow.Cells("username").Value
                    frm.cmbworkgroup.Text = dgv.CurrentRow.Cells("workgroup").Value
                    frm.txtfullname.Text = dgv.CurrentRow.Cells("namee").Value
                    frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                    frm.ShowDialog()
                    loadUsers()
                End If
            End If
        End If
    End Sub
End Class