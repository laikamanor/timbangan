Imports TIMBANGAN.categories_class
Imports TIMBANGAN.access_class
Imports TIMBANGAN.ui_class
Public Class categories
    Dim cat_class As New categories_class(), ac As New access_class(), ic As New ui_class()
    Private Sub categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbstatus.SelectedIndex = 0

    End Sub
    Public Sub loadCategories()
        Try
            cat_class.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
            cat_class.setCategory(txtsearch.Text)
            Dim dt As New DataTable(), auto As New AutoCompleteStringCollection()
            dt = cat_class.showCategories()
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                dgv.Rows.Add(r0w("category"), IIf(r0w("status") = 1, "Active", "In Active"))
                auto.Add(r0w("category"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        If ac.checkAccess(btnaddnew) Then
            MessageBox.Show("You have no permission to access Add New", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New add_category()
            frm.ShowDialog()
            loadCategories()
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadCategories()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCategories()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btncategory) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnimport.Click
        import_categories.ShowDialog()
        import_categories.dgv.Rows.Clear()
        import_categories.btnsubmit.Enabled = False
        loadCategories()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 2 Then
                If ac.checkAccess(dgv) Then
                    MessageBox.Show("You have no permission to access Edit", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim frm As New add_category()
                    frm.lblheader.Text = "Edit Category"
                    frm.current_category = dgv.CurrentRow.Cells("category").Value
                    frm.txtcategory.Text = dgv.CurrentRow.Cells("category").Value
                    frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                    frm.ShowDialog()
                    loadCategories()
                End If
            End If
        End If
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged
        loadCategories()
    End Sub
End Class