Public Class step2
    Dim step2c As New step2_class(), cc As New connections_class, ic As New items_class
    Dim step1id As Integer = 0, formulaid As Integer = 0
    Private Sub step2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        loadStep1()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadStep1()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadStep1()
        End If
    End Sub

    Public Sub loadStep1()
        Try
            step2c.setStatus(1)
            step2c.setCategory(cmbcategory.Text)
            step2c.setProduct(txtsearch.Text)
            step2c.setStep1ID(0)
            Dim result As New DataTable(), auto As New AutoCompleteStringCollection
            result = step2c.loadStep1()
            dgv.Rows.Clear()
            If result.Rows.Count <> 0 Then
                For Each r0w As DataRow In result.Rows
                    dgv.Rows.Add(r0w("step1id"), r0w("category"), r0w("product"))
                    auto.Add(r0w("product"))
                Next
            Else
                dgv.Rows.Clear()
                auto.Clear()
            End If
            txtsearch.AutoCompleteCustomSource = auto
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 3 Then
                Dim frm As New step2_viewbatch()
                frm.id = dgv.CurrentRow.Cells("id").Value
                frm.ShowDialog()
            Else
                txtbatchquantity.Text = "1"
                cellClick()
            End If
        End If
    End Sub

    Private Sub txtbatchquantity_Leave(sender As Object, e As EventArgs) Handles txtbatchquantity.Leave
        If lblproduct.Text <> "N/A" Then
            cellClick()
        End If
    End Sub

    Public Sub clear()
        lblcategory.Text = "N/A"
        lblproduct.Text = "N/A"
        lblquantity.Text = "0/0"
        lbltdw.Text = "0.00"
        lblpalaman.Text = "N/A"
        'txtbatchquantity.Text = "0"
        dgvitems.Rows.Clear()
        dgvpalaman.Rows.Clear()
        step1id = 0
        formulaid = 0
        GroupBox1.Text = "N/A"
        loadStep1()
    End Sub
    Public Function itemsValidation() As Boolean
        Dim counter As Integer = 0, result As Boolean = False
        If dgvitems.Rows.Count <> 0 Then
            For i As Integer = 0 To dgvitems.Rows.Count - 1
                If String.IsNullOrEmpty(dgvitems.Rows(i).Cells("actuall").Value) Then
                    dgvitems.Rows(i).Cells("actuall").ToolTipText = "Actual is required"
                    dgvitems.Rows(i).Cells("actuall").Style.BackColor = Color.Red
                    counter += 1
                ElseIf Not IsNumeric(dgvitems.Rows(i).Cells("actuall").Value) Then
                    dgvitems.Rows(i).Cells("actuall").ToolTipText = "Actual must be a number"
                    dgvitems.Rows(i).Cells("actuall").Style.BackColor = Color.Red
                    counter += 1
                ElseIf CDbl(dgvitems.Rows(i).Cells("valuee").Value) > CDbl(dgvitems.Rows(i).Cells("actuall").Value) Then
                    dgvitems.Rows(i).Cells("actuall").ToolTipText = "Actual must be a greater than or equal to value"
                    dgvitems.Rows(i).Cells("actuall").Style.BackColor = Color.Red
                    counter += 1
                Else
                    dgvitems.Rows(i).Cells("actuall").ToolTipText = ""
                    dgvitems.Rows(i).Cells("actuall").Style.BackColor = Color.White
                End If
            Next
        End If
        result = IIf(counter = 0, True, False)
        Return result
    End Function
    Public Function PalamanValidation() As Boolean
        Dim counter As Integer = 0, result As Boolean = False
        If dgvpalaman.Rows.Count <> 0 Then
            For i As Integer = 0 To dgvpalaman.Rows.Count - 1
                If String.IsNullOrEmpty(dgvpalaman.Rows(i).Cells("actualll").Value) Then
                    dgvpalaman.Rows(i).Cells("actualll").ToolTipText = "Actual is required"
                    dgvpalaman.Rows(i).Cells("actualll").Style.BackColor = Color.Red
                    counter += 1
                ElseIf Not IsNumeric(dgvpalaman.Rows(i).Cells("actualll").Value) Then
                    dgvpalaman.Rows(i).Cells("actualll").ToolTipText = "Actual must be a number"
                    dgvpalaman.Rows(i).Cells("actualll").Style.BackColor = Color.Red
                    counter += 1
                ElseIf CDbl(dgvpalaman.Rows(i).Cells("valueee").Value) > CDbl(dgvpalaman.Rows(i).Cells("actualll").Value) Then
                    dgvpalaman.Rows(i).Cells("actualll").ToolTipText = "Actual must be a greater than or equal to value"
                    dgvpalaman.Rows(i).Cells("actualll").Style.BackColor = Color.Red
                    counter += 1
                Else
                    dgvpalaman.Rows(i).Cells("actualll").ToolTipText = ""
                    dgvpalaman.Rows(i).Cells("actualll").Style.BackColor = Color.White
                End If
            Next
        End If
        result = IIf(counter = 0, True, False)
        Return result
    End Function
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If itemsValidation() = False Then
            MessageBox.Show("There's an error in items", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf PalamanValidation() = False Then
            MessageBox.Show("There's an error in palaman", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(txtbatchquantity.Text) Then
            MessageBox.Show("Quantity must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtbatchquantity.Text) Then
            MessageBox.Show("Quantity is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CDbl(txtbatchquantity.Text) = 0 Then
            MessageBox.Show("Please input quantity alteast 1", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf itemsValidation() And PalamanValidation() Then
            MessageBox.Show("ok")
            insertQuery()
            clear()
        End If
    End Sub
    Public Sub insertQuery()
        Dim dtItem As New DataTable(), dtPalaman As New DataTable()
        dtItem.Columns.Add("step1_itemid")
        dtItem.Columns.Add("formula_itemid")
        dtItem.Columns.Add("itemid")
        dtItem.Columns.Add("value")
        dtItem.Columns.Add("actual")

        dtPalaman.Columns.Add("step1_itemid")
        dtPalaman.Columns.Add("formula_itemid")
        dtPalaman.Columns.Add("itemid")
        dtPalaman.Columns.Add("value")
        dtPalaman.Columns.Add("actual")

        For index As Integer = 0 To dgvitems.Rows.Count - 1
            dtItem.Rows.Add(dgvitems.Rows(index).Cells("step1_id").Value, dgvitems.Rows(index).Cells("formula_itemid").Value, dgvitems.Rows(index).Cells("itemid").Value, dgvitems.Rows(index).Cells("valuee").Value, dgvitems.Rows(index).Cells("actuall").Value)
        Next

        For index As Integer = 0 To dgvpalaman.Rows.Count - 1
            dtPalaman.Rows.Add(dgvpalaman.Rows(index).Cells("step1_idd").Value, dgvpalaman.Rows(index).Cells("formula_itemidd").Value, dgvpalaman.Rows(index).Cells("itemidd").Value, dgvpalaman.Rows(index).Cells("valueee").Value, dgvpalaman.Rows(index).Cells("actualll").Value)
        Next
        Dim step2num As String = step2c.returnFormulaNumber()
        step2c.setStep2Num(step2num)
        step2c.setStep1ID(step1id)
        step2c.setFormulaID(formulaid)
        step2c.setProduct(lblproduct.Text)
        step2c.setQuantity(txtbatchquantity.Text)
        step2c.setStatus(1)
        step2c.insertStep1(dtItem, dtPalaman)
    End Sub
    Private Sub dgvitems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvitems.CellEndEdit
        If dgvitems.Rows.Count <> 0 Then
            If e.ColumnIndex = 6 Then
                If String.IsNullOrEmpty(dgvitems.CurrentRow.Cells("actuall").Value) Then
                    MessageBox.Show("Actual is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgvitems.CurrentRow.Cells("actuall").Value = "0.00"
                ElseIf Not IsNumeric(dgvitems.CurrentRow.Cells("actuall").Value) Then
                    MessageBox.Show("Actual must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgvitems.CurrentRow.Cells("actuall").Value = "0.00"
                ElseIf CDbl(dgvitems.CurrentRow.Cells("valuee").Value) > CDbl(dgvitems.CurrentRow.Cells("actuall").Value) Then
                    MessageBox.Show("Actual must be a greater than or equal to value", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgvitems.CurrentRow.Cells("actuall").Value = "0.00"
                Else
                    dgvitems.CurrentRow.Cells("actuall").Value = CDbl(dgvitems.CurrentRow.Cells("actuall").Value).ToString("n2")
                    dgvitems.CurrentRow.Cells("actuall").ToolTipText = ""
                    dgvitems.CurrentRow.Cells("actuall").Style.BackColor = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub step2_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, False)
        If cmbcategory.Items.Count <> 0 Then
            Dim indexOfPalaman As Integer = cmbcategory.Items.IndexOf("Palaman")
            cmbcategory.Items.RemoveAt(indexOfPalaman)
            cmbcategory.SelectedIndex = 0
        End If
    End Sub

    Public Function returnBatches() As Integer
        Dim result As Integer = 0, subs As Integer = 0
        subs = lblquantity.Text.IndexOf("/")
        result = lblquantity.Text.Substring(0, subs)
        Return result
    End Function
    Public Function returnTargetQuantity() As Integer
        Dim result As Integer = 0, subs As Integer = 0
        subs = lblquantity.Text.IndexOf("/")
        result = lblquantity.Text.Substring(subs + 1)
        Return result
    End Function
    Private Sub dgvpalaman_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpalaman.CellEndEdit
        If dgvpalaman.Rows.Count <> 0 Then
            If e.ColumnIndex = 6 Then
                If String.IsNullOrEmpty(dgvpalaman.CurrentRow.Cells("actualll").Value) Then
                    MessageBox.Show("Actual is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgvpalaman.CurrentRow.Cells("actualll").Value = "0.00"
                ElseIf Not IsNumeric(dgvpalaman.CurrentRow.Cells("actualll").Value) Then
                    MessageBox.Show("Actual must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgvpalaman.CurrentRow.Cells("actualll").Value = "0.00"
                ElseIf CDbl(dgvpalaman.CurrentRow.Cells("valueee").Value) > CDbl(dgvpalaman.CurrentRow.Cells("actualll").Value) Then
                    MessageBox.Show("Actual must be a greater than or equal to value", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgvpalaman.CurrentRow.Cells("actualll").Value = "0.00"
                Else
                    dgvpalaman.CurrentRow.Cells("actualll").Value = CDbl(dgvpalaman.CurrentRow.Cells("actualll").Value).ToString("n2")
                    dgvpalaman.CurrentRow.Cells("actualll").ToolTipText = ""
                    dgvpalaman.CurrentRow.Cells("actualll").Style.BackColor = Color.White
                End If
            End If
        End If
    End Sub

    Public Sub cellClick()
        Dim answer As Integer = returnTargetQuantity() - returnBatches()
        If Not IsNumeric(txtbatchquantity.Text) Then
            MessageBox.Show("Batch Quantity must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbatchquantity.Text = "0"
            itemPalamanFormula()
        ElseIf String.IsNullOrEmpty(txtbatchquantity.Text) OrElse CDbl(txtbatchquantity.Text) = 0 Then
            MessageBox.Show("Please input atleast 1 Batch Quantity", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbatchquantity.Text = "0"
            itemPalamanFormula()
        ElseIf answer < CDbl(txtbatchquantity.Text) And lblquantity.Text <> "0/0" Then
            MessageBox.Show("Remaining Quantity is " & answer, "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbatchquantity.Text = answer
            itemPalamanFormula()
        ElseIf IsNumeric(txtbatchquantity.Text) Then
            itemPalamanFormula()
        End If
    End Sub

    Public Sub itemPalamanFormula()
        step2c.setStatus(1)
        step2c.setStep1ID(dgv.CurrentRow.Cells("id").Value)
        Dim result As New DataTable(), resultItems As New DataTable(), resultPalaman As New DataTable(), auto As New AutoCompleteStringCollection,
            viewItemsName As String = "vStep1Items",
            viewPalamanName As String = "vStep1Palaman"
        result = step2c.loadStep1()
        If result.Rows.Count <> 0 Then
            For Each r0w As DataRow In result.Rows
                lblcategory.Text = r0w("category")
                lblproduct.Text = r0w("product")
                lblquantity.Text = (CInt(r0w("batch")).ToString("N0") & "/" & CInt(r0w("quantity")).ToString("N0"))
                lbltdw.Text = CDbl(r0w("basewt")).ToString("n2")
                step1id = dgv.CurrentRow.Cells("id").Value
                formulaid = r0w("formulaid")
                GroupBox1.Text = r0w("step1num")
                If r0w("category").ToString.ToLower = "Palaman".ToLower Then
                    lblpalaman.Text = r0w("itemname")
                End If

            Next
            Dim toDivide As Double = (CDbl(txtbatchquantity.Text) / CDbl(returnTargetQuantity()) * 100)
            resultItems = step2c.loadItemsPalaman(viewItemsName, step1id)
            If resultItems.Rows.Count <> 0 Then
                dgvitems.Rows.Clear()
                For Each r0w As DataRow In resultItems.Rows
                    Dim batchValue As Double = CDbl(r0w("value")) * (toDivide / 100)
                    dgvitems.Rows.Add(r0w("itemid"), r0w("formula_itemid"), r0w("id"), r0w("category"), r0w("itemname"), batchValue.ToString("n2"), "0.00")
                Next
            Else
                dgvitems.Rows.Clear()
            End If
            resultPalaman = step2c.loadItemsPalaman(viewPalamanName, step1id)
            If resultPalaman.Rows.Count <> 0 Then
                dgvpalaman.Rows.Clear()
                For Each r0w As DataRow In resultPalaman.Rows
                    Dim batchValue As Double = CDbl(r0w("value")) * (toDivide / 100)
                    dgvpalaman.Rows.Add(r0w("itemid"), r0w("formula_itemid"), r0w("id"), r0w("category"), r0w("itemname"), batchValue.ToString("n2"), "0.00")
                Next
            Else
                dgvpalaman.Rows.Clear()
            End If
        Else
            clear()
        End If
    End Sub

End Class