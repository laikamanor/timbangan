Imports TIMBANGAN.access_class
Imports TIMBANGAN.formula_class
Imports TIMBANGAN.items_class
Public Class formulas
    Dim ac As New access_class(), fc As New formula_class(), ic As New items_class()
    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        If ac.checkAccess(btnaddnew) Then
            MessageBox.Show("You have no permission to access Add New", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            add_formula.ShowDialog()
            btnactiveformula.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btnmanageformula) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, False)
        If cmbcategory.Items.Count <> 0 Then
            Dim indexOfPalaman As Integer = cmbcategory.Items.IndexOf("Palaman")
            cmbcategory.Items.RemoveAt(indexOfPalaman)
            cmbcategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadFormulas()
        End If
    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        loadFormulas()
    End Sub

    Private Sub dgvformulas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvformulas.CellClick
        Dim dt As New DataTable(), dtItems As New DataTable(), dtPalaman As New DataTable()
        dt = fc.cellClickProducts(dgvformulas.CurrentRow.Cells("formula_id").Value)
        dtItems = fc.cellClickItems(dgvformulas.CurrentRow.Cells("formula_id").Value, "formula_items")
        dtPalaman = fc.cellClickItems(dgvformulas.CurrentRow.Cells("formula_id").Value, "formula_palaman_items")
        If dt.Rows.Count <> 0 Then
            For Each r0w As DataRow In dt.Rows
                GroupBox1.Text = r0w("product") & " Information Formula"
                txttdw.Text = CInt(r0w("tdw")).ToString("n2")
                txtprice.Text = CDbl(r0w("price")).ToString("N0")
                txtunbaked.Text = CInt(r0w("unbaked")).ToString("n2")
                txtbaked.Text = CInt(r0w("baked")).ToString("n2")
                txtyield.Text = CInt(r0w("yield")).ToString("n2")
                txtbasewt.Text = CInt(r0w("basewt")).ToString("n2")
            Next
        Else
            clear()
        End If
        If dtItems.Rows.Count <> 0 Then
            dgvitems.Rows.Clear()
            For Each r0w As DataRow In dtItems.Rows
                dgvitems.Rows.Add(r0w("category"), r0w("itemname"), CInt(r0w("value")).ToString("N0"), r0w("uom"))
                If r0w("category").ToString.ToLower = "Palaman".ToLower Then
                    lblpalaman.Text = "Palaman: " & r0w("itemname")
                End If
            Next
        Else
            dgvitems.Rows.Clear()
        End If
        If dtPalaman.Rows.Count <> 0 Then
            dgvpalaman.Rows.Clear()
            For Each r0w As DataRow In dtPalaman.Rows
                dgvpalaman.Rows.Add(r0w("category"), r0w("itemname"), CInt(r0w("value")).ToString("N0"), r0w("uom"))
            Next
        Else
            dgvpalaman.Rows.Clear()
        End If
    End Sub
    Public Sub clear()
        GroupBox1.Text = "N/A Information Formula"
        lblpalaman.Text = "Palaman: N/A"
        txttdw.Text = 0.00
        txtprice.Text = 0.00
        txtunbaked.Text = 0.00
        txtbaked.Text = 0.00
        txtyield.Text = 0.00
        txtbasewt.Text = 0.00
        dgvitems.Rows.Clear()
        dgvpalaman.Rows.Clear()
    End Sub

    Private Sub btnactiveformula_Click(sender As Object, e As EventArgs) Handles btnactiveformula.Click
        btnactiveformula.ForeColor = Color.Black
        btninactiveformula.ForeColor = Color.White
        btnset.Text = "Set to In Active"
        btnset.Visible = False
        loadFormulas()
    End Sub

    Private Sub btninactiveformula_Click(sender As Object, e As EventArgs) Handles btninactiveformula.Click
        btnactiveformula.ForeColor = Color.White
        btninactiveformula.ForeColor = Color.Black
        btnset.Text = "Set to Active"
        btnset.Visible = True
        loadFormulas()
    End Sub

    Private Sub btnset_Click(sender As Object, e As EventArgs) Handles btnset.Click
        Dim a As String = MsgBox("Are you sure you want to enable this formula?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atlantic Bakery")
        If a = vbYes Then
            fc.setProduct(dgvformulas.CurrentRow.Cells("productt").Value)
            fc.updateFormulaStatus(dgvformulas.CurrentRow.Cells("formula_id").Value)
            loadFormulas()
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadFormulas()
    End Sub

    Public Sub loadFormulas()
        Try
            clear()
            fc.setProduct(txtsearch.Text)
            fc.setCategory(cmbcategory.Text)
            fc.setStatus(IIf(btnactiveformula.ForeColor = Color.Black, 1, 0))
            Dim dt As New DataTable(), auto As New AutoCompleteStringCollection()
            dt = fc.showFormulas()
            dgvformulas.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                dgvformulas.Rows.Add(r0w("id"), r0w("category"), r0w("product"))
                auto.Add(r0w("product"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            If dgvformulas.Rows.Count = 0 Then
                clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class