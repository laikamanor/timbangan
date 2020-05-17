Imports TIMBANGAN.modules_class
Imports TIMBANGAN.access_class
Public Class modules

    Dim mc As New modules_class(), ac As New access_class()
    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        If ac.checkAccess(btnaddnew) Then
            MessageBox.Show("You have no permission to access Add New", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New add_module()
            frm.ShowDialog()
            loadModules()
        End If
    End Sub

    Private Sub modules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbstatus.SelectedIndex = 0
    End Sub

    Public Sub loadModules()
        Try
            mc.setModuleName(txtsearch.Text)
            mc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
            Dim dt As New DataTable(), auto As New AutoCompleteStringCollection()
            dt = mc.showModules()
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                dgv.Rows.Add(r0w("module"), r0w("description"), IIf(r0w("status") = 1, "Active", "In Active"))
                auto.Add(r0w("module"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            lblnodata.Visible = IIf(dgv.Rows.Count = 0, True, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged
        loadModules()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadModules()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadModules()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btnmodules) Then
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
                    Dim frm As New add_module()
                    frm.current_module = dgv.CurrentRow.Cells("modulee").Value
                    frm.txtmodule.Text = dgv.CurrentRow.Cells("modulee").Value
                    frm.txtdescription.Text = dgv.CurrentRow.Cells("description").Value
                    frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                    frm.lblheader.Text = "Edit Module"
                    frm.ShowDialog()
                    loadModules()
                End If
            End If
        End If
    End Sub
End Class