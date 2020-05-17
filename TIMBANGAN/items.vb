Imports TIMBANGAN.items_class
Imports TIMBANGAN.access_class
Public Class items
    Dim ic As New items_class(), ac As New access_class()
    Private Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, False)
        cmbstatus.SelectedIndex = 0
        cmbcategory.SelectedIndex = 0
    End Sub
    Public Sub loadItems()
        Try
            Dim auto As New AutoCompleteStringCollection()
            ic.setItemName(txtsearch.Text)
            ic.setCategory(cmbcategory.Text)
            ic.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
            Dim dt As New DataTable()
            dt = ic.readItems(cmbcategory)
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                auto.Add(r0w("itemname"))
                dgv.Rows.Add(r0w("category"), r0w("itemname"), r0w("description"), r0w("uom"), IIf(r0w("status") = 1, "Active", "In Active"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            lblnodata.Visible = IIf(dgv.Rows.Count = 0, True, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        If ac.checkAccess(btnaddnew) Then
            MessageBox.Show("You have no permission to access Add New", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New add_item()
            frm.lblheader.Text = "Add Item"
            frm.ShowDialog()
            loadItems()
        End If
    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        loadItems()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadItems()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadItems()
        End If
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged
        loadItems()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btnitems) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnimport.Click
        import_items.ShowDialog()
        import_items.dgv.Rows.Clear()
        import_items.btnsubmit.Enabled = False
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 5 Then
                If ac.checkAccess(dgv) Then
                    MessageBox.Show("You have no permission to access Edit", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim frm As New add_item()
                    frm.lblheader.Text = "Edit Item"
                    frm.current_itemname = dgv.CurrentRow.Cells("itemname").Value
                    frm.txtitemname.Text = dgv.CurrentRow.Cells("itemname").Value
                    frm.cmbcategory.Text = dgv.CurrentRow.Cells("category").Value
                    frm.txtdescription.Text = dgv.CurrentRow.Cells("description").Value
                    frm.txtuom.Text = dgv.CurrentRow.Cells("uom").Value
                    frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                    frm.ShowDialog()
                    loadItems()
                End If
            End If
        End If
    End Sub
End Class