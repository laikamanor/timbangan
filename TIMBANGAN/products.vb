Imports TIMBANGAN.items_class
Imports TIMBANGAN.access_class
Imports TIMBANGAN.products_class
Public Class products
    Dim ac As New access_class(), ic As New items_class(), pc As New products_class()
    Private Sub products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, False)
        cmbstatus.SelectedIndex = 0
        cmbcategory.SelectedIndex = 0
    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        If ac.checkAccess(btnaddnew) Then
            MessageBox.Show("You have no permission to access Add New", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New add_product()
            frm.ShowDialog()
            loadProducts()
        End If
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged
        loadProducts()
    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        loadProducts()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadProducts()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 4 Then
                If ac.checkAccess(dgv) Then
                    MessageBox.Show("You have no permission to access Edit", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim frm As New add_product()
                    frm.lblheader.Text = "Edit Product"
                    frm.current_product = dgv.CurrentRow.Cells("product").Value
                    frm.txtproduct.Text = dgv.CurrentRow.Cells("product").Value
                    frm.cmbcategory.Text = dgv.CurrentRow.Cells("category").Value
                    frm.txtdescription.Text = dgv.CurrentRow.Cells("description").Value
                    frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                    frm.ShowDialog()
                    loadProducts()
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btnproducts) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnimport.Click
        import_products.ShowDialog()
        import_products.dgv.Rows.Clear()
        import_products.btnsubmit.Enabled = False
        loadProducts()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadProducts()
        End If
    End Sub

    Public Sub loadProducts()
        Try
            Dim auto As New AutoCompleteStringCollection()
            pc.setProductName(txtsearch.Text)
            pc.setCategory(cmbcategory.Text)
            pc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
            Dim dt As New DataTable()
            dt = pc.readProducts(cmbcategory)
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                auto.Add(r0w("product"))
                dgv.Rows.Add(r0w("category"), r0w("product"), r0w("description"), IIf(r0w("status") = 1, "Active", "In Active"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            lblnodata.Visible = IIf(dgv.Rows.Count = 0, True, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class