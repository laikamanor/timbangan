Imports TIMBANGAN.ui_class
Imports TIMBANGAN.access_class
Imports TIMBANGAN.items_class
Imports TIMBANGAN.formula_class
Imports TIMBANGAN.categories_class
Imports TIMBANGAN.products_class
Public Class add_formula
    Dim ic As New ui_class(), ac As New access_class(), itemc As New items_class(), fc As New formula_class(), cc As New categories_class(),
        pc As New products_class()
    Private Sub add_formula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itemc.filterCategories(cmbcategory, True)
        If cmbcategory.Items.Count <> 0 Then
            Dim indexOfPalaman As Integer = cmbcategory.Items.IndexOf("Palaman")
            cmbcategory.Items.RemoveAt(indexOfPalaman)
            cmbcategory.AutoCompleteCustomSource.RemoveAt(indexOfPalaman)
            cmbcategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub add_formula_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Label1.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub btnadditem_Click(sender As Object, e As EventArgs) Handles btnadditem.Click
        Dim frm As New formula_add_item()
        frm.lblheader.Text = "Add Item"
        frm.ShowDialog()
        getTdw()
        palamanFormat()
    End Sub

    Public Sub palamanFormat()
        Dim result As Boolean = False, item As String = ""
        For index As Integer = 0 To dgvitems.Rows.Count - 1
            If "Palaman" = dgvitems.Rows(index).Cells("category").Value Then
                item = dgvitems.Rows(index).Cells("itemname").Value
                result = True
            End If
        Next
        If result Then
            lblpalaman.Text = "Palaman: " & item
        Else
            lblpalaman.Text = "Palaman: N/A"
            dgvpalaman.Rows.Clear()
        End If
    End Sub

    Private Sub btnaddpalamanitem_Click(sender As Object, e As EventArgs) Handles btnaddpalamanitem.Click
        Dim result As Boolean = False
        For index As Integer = 0 To dgvitems.Rows.Count - 1
            If dgvitems.Rows(index).Cells("category").Value = "Palaman" Then
                result = True
            End If
        Next
        If result Then
            Dim frm As New formula_add_item()
            frm.lblheader.Text = "Add Palaman Item"
            frm.ShowDialog()
            getPalamanValue()
        Else
            MessageBox.Show("Add Palaman first", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub getPalamanValue()
        For index As Integer = 0 To dgvitems.Rows.Count - 1
            If dgvitems.Rows(index).Cells("category").Value.ToString.ToLower = "Palaman".ToLower Then
                Dim result As Double = 0.00
                For index2 As Integer = 0 To dgvpalaman.Rows.Count - 1
                    result += dgvpalaman.Rows(index2).Cells("valuee2").Value
                Next
                dgvitems.Rows(index).Cells("valuee").Value = result
                Continue For
            End If
        Next
        getTdw()
    End Sub


    Private Sub cmbcategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedValueChanged
    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        fc.setCategory(cmbcategory.Text)
        fc.filterProducts(cmbproducts, True)
        If cmbproducts.Items.Count <> 0 Then
            cmbproducts.SelectedIndex = 0
        Else
            cmbproducts.ResetText()
        End If
    End Sub

    Private Sub add_formula_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub dgvitems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvitems.CellClick
        If dgvitems.Rows.Count <> 0 Then
            If e.ColumnIndex = 4 Then
                Dim frm As New formula_add_item()
                frm.lblheader.Text = "Edit Item"
                frm.cmbcategory.Text = dgvitems.CurrentRow.Cells("category").Value
                frm.cmbitems.Text = dgvitems.CurrentRow.Cells("itemname").Value
                frm.txtvalue.Text = dgvitems.CurrentRow.Cells("valuee").Value
                frm.txtuom.Text = dgvitems.CurrentRow.Cells("uom").Value
                frm.cmbcategory.Enabled = False
                frm.cmbitems.Enabled = False
                frm.txtvalue.Focus()
                frm.ShowDialog()
            ElseIf e.ColumnIndex = 5 Then
                Dim a As String = MsgBox("Are you sure you want to remove?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atlantic Bakery")
                If a = vbYes Then
                    dgvitems.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
        getTdw()
        palamanFormat()
    End Sub

    Public Sub getTdw()
        Dim tdw As Double = 0.00
        For index As Integer = 0 To dgvitems.Rows.Count - 1
            tdw += dgvitems.Rows(index).Cells("valuee").Value
        Next
        txttdw.Text = tdw
        yield()
    End Sub

    Public Sub yield()
        Dim tdw As Double = Val(txttdw.Text)
        Dim unbaked As Double = Val(txtunbaked.Text)

        If unbaked = 0 Then
            txtyield.Text = 0
        Else
            txtyield.Text = Fix(tdw / unbaked)
        End If
    End Sub

    Private Sub dgvpalaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpalaman.CellClick
        If dgvpalaman.Rows.Count <> 0 Then
            If e.ColumnIndex = 4 Then
                Dim frm As New formula_add_item()
                frm.lblheader.Text = "Edit Palaman Item"
                frm.cmbcategory.Text = dgvpalaman.CurrentRow.Cells("category2").Value
                frm.cmbitems.Text = dgvpalaman.CurrentRow.Cells("itemname2").Value
                frm.txtvalue.Text = dgvpalaman.CurrentRow.Cells("valuee2").Value
                frm.txtuom.Text = dgvpalaman.CurrentRow.Cells("uom2").Value
                frm.cmbcategory.Enabled = False
                frm.cmbitems.Enabled = False
                frm.txtvalue.Focus()
                frm.ShowDialog()
                getPalamanValue()
            ElseIf e.ColumnIndex = 5 Then
                Dim a As String = MsgBox("Are you sure you want to remove?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atlantic Bakery")
                If a = vbYes Then
                    dgvpalaman.Rows.RemoveAt(e.RowIndex)
                    getPalamanValue()
                End If
            End If
        End If
    End Sub

    Public Sub submit()
        Try
            cc.setCategory(cmbcategory.Text)
            pc.setProductName(cmbproducts.Text)
            fc.setProduct(cmbproducts.Text)
            fc.setStatus(1)
            If String.IsNullOrEmpty(cmbcategory.Text) Then
                MessageBox.Show("Category field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbcategory.Focus()
            ElseIf cc.checkCategory() = False Then
                MessageBox.Show("Category " & cmbcategory.Text & " not found", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbcategory.Focus()
            ElseIf String.IsNullOrEmpty(cmbproducts.Text) Then
                MessageBox.Show("Product field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbproducts.Focus()
            ElseIf pc.checkProduct() = False Then
                MessageBox.Show("Product " & cmbproducts.Text & " not found", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbproducts.Focus()
            ElseIf String.IsNullOrEmpty(txtprice.Text) Then
                MessageBox.Show("Price field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtprice.Focus()
            ElseIf IsNumeric(txtprice.Text) = False Then
                MessageBox.Show("Price must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtprice.Focus()
            ElseIf String.IsNullOrEmpty(txtbasewt.Text) Then
                MessageBox.Show("Base WT field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbasewt.Focus()
            ElseIf IsNumeric(txtbasewt.Text) = False Then
                MessageBox.Show("Base WT must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbasewt.Focus()
            ElseIf String.IsNullOrEmpty(txtunbaked.Text) Then
                MessageBox.Show("Unbaked field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtunbaked.Focus()
            ElseIf IsNumeric(txtunbaked.Text) = False Then
                MessageBox.Show("Unbaked must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtunbaked.Focus()
            ElseIf String.IsNullOrEmpty(txtbaked.Text) Then
                MessageBox.Show("Baked field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbaked.Focus()
            ElseIf IsNumeric(txtbaked.Text) = False Then
                MessageBox.Show("Baked must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbaked.Focus()
            ElseIf dgvitems.rows.Count = 0 Then
                MessageBox.Show("Please input item(s)", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'ElseIf fc.checkProductFormula() Then
                '    MessageBox.Show("Product " & cmbproducts.Text & " is already active", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    cmbproducts.Focus()
            Else
                Dim haveActiveFormula As Integer = 0
                haveActiveFormula = IIf(fc.checkProductFormula(), 1, 0)

                If haveActiveFormula Then
                    Dim a As String = MsgBox("Product '" & cmbproducts.Text & "' is already exist, the Active Formula will be In Active. Are you sure you want to add this formula?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "")
                    If a = vbYes Then
                        insertQuery()
                    End If
                Else
                    insertQuery()
                End If
                End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub insertQuery()
        'data from items
        Dim dt1 As New DataTable()
        dt1.Columns.Add("category")
        dt1.Columns.Add("item")
        dt1.Columns.Add("value")
        dt1.Columns.Add("uom")

        For index As Integer = 0 To dgvitems.Rows.Count - 1
            dt1.Rows.Add(dgvitems.Rows(index).Cells("category").Value,
                dgvitems.Rows(index).Cells("itemname").Value,
                dgvitems.Rows(index).Cells("valuee").Value,
                dgvitems.Rows(index).Cells("uom").Value)
        Next

        Dim dt2 As New DataTable()
        dt2.Columns.Add("category")
        dt2.Columns.Add("item")
        dt2.Columns.Add("value")
        dt2.Columns.Add("uom")

        For index As Integer = 0 To dgvpalaman.Rows.Count - 1
            dt2.Rows.Add(dgvpalaman.Rows(index).Cells("category2").Value,
                dgvpalaman.Rows(index).Cells("itemname2").Value,
                dgvpalaman.Rows(index).Cells("valuee2").Value,
                dgvpalaman.Rows(index).Cells("uom2").Value)
        Next

        fc.setProduct(cmbproducts.Text)
        fc.updateFormulaStatus(0)

        Dim formnum As String = fc.returnFormulaNumber()
        fc.setPrice(txtprice.Text)
        fc.setBaseWT(txtbasewt.Text)
        fc.setTDW(txttdw.Text)
        fc.setUnBaked(txtunbaked.Text)
        fc.setBaked(txtbaked.Text)
        fc.setYield(txtyield.Text)
        fc.setFormulaNumber(formnum)
        fc.setPalaman(lblpalaman.Text)
        fc.addFormula(dt1, dt2)
        MessageBox.Show("Formula Added", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Private Sub cmbcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcategory.KeyDown, txtunbaked.KeyDown, txtprice.KeyDown, txtbasewt.KeyDown, txtbaked.KeyDown, cmbproducts.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub txtunbaked_TextChanged(sender As Object, e As EventArgs) Handles txtunbaked.TextChanged
        yield()
    End Sub

    Private Sub add_formula_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Label1.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(formulas.btnaddnew) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub add_formula_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Label1.MouseUp
        ic.mouse_up()
    End Sub
End Class