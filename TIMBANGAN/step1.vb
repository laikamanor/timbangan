Imports TIMBANGAN.formula_class
Imports TIMBANGAN.items_class
Imports TIMBANGAN.step1_class
Public Class step1
    Dim fc As New formula_class, ic As New items_class, formulaid As Integer = 0, step1c As New step1_class
    Private Sub step1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, False)
        If cmbcategory.Items.Count <> 0 Then
            Dim indexOfPalaman As Integer = cmbcategory.Items.IndexOf("Palaman")
            cmbcategory.Items.RemoveAt(indexOfPalaman)
            cmbcategory.SelectedIndex = 0
        End If
        loadFormulas()
    End Sub

    Public Sub clear()
        lblcategory.Text = "N/A"
        lblproduct.Text = "N/A"
        txtquantity.Text = "0"
        lblbasewt.Text = "0.00"
        lblpalaman.Text = "N/A"
        dgvitems.Rows.Clear()
        dgvpalaman.Rows.Clear()
        formulaid = 0
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadFormulas()
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadFormulas()
    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        loadFormulas()
    End Sub

    Private Sub dgvformulas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvformulas.CellClick
        If dgvformulas.Rows.Count <> 0 Then
            cellClick()
        End If
    End Sub
        Public Sub cellClick()
            If IsNumeric(txtquantity.Text) Then
            lblcategory.Text = dgvformulas.CurrentRow.Cells("category").Value
            lblproduct.Text = dgvformulas.CurrentRow.Cells("product").Value
            formulaid = dgvformulas.CurrentRow.Cells("formula_id").Value
            Dim dt As New DataTable(), dtItems As New DataTable(), dtPalaman As New DataTable()
            dt = fc.cellClickProducts(dgvformulas.CurrentRow.Cells("formula_id").Value)
            dtItems = fc.cellClickItems(dgvformulas.CurrentRow.Cells("formula_id").Value, "formula_items")
            dtPalaman = fc.cellClickItems(dgvformulas.CurrentRow.Cells("formula_id").Value, "formula_palaman_items")
            If dt.Rows.Count <> 0 Then
                For Each r0w As DataRow In dt.Rows
                    lblbasewt.Text = (CDbl(txtquantity.Text) / CDbl(r0w("yield"))).ToString("n2")
                Next
            Else
                clear()
            End If
            If dtItems.Rows.Count <> 0 Then
                dgvitems.Rows.Clear()
                For Each r0w As DataRow In dtItems.Rows
                    dgvitems.Rows.Add(r0w("itemid"), r0w("formula_itemid"), r0w("category"), r0w("itemname"), (CDbl(r0w("value")) * CDbl(lblbasewt.Text)).ToString("n2"), "0.00")
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
                    dgvpalaman.Rows.Add(r0w("itemid"), r0w("formula_itemid"), r0w("category"), r0w("itemname"), CDbl(r0w("value")).ToString("N0"), "0.00")
                Next
            Else
                dgvpalaman.Rows.Clear()
            End If
        ElseIf String.IsNullOrEmpty(txtquantity.Text) Then
            MessageBox.Show("Quantity is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clear()
        ElseIf Not IsNumeric(txtquantity.Text) Then
            MessageBox.Show("Quantity must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clear()
        End If
    End Sub
    Private Sub txtquantity_Leave(sender As Object, e As EventArgs) Handles txtquantity.Leave
        cellClick()
    End Sub
    Private Sub dgvitems_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvitems.DataError
        If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If
    End Sub

    Private Sub dgvitems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvitems.CellEndEdit
        If dgvitems.Rows.Count <> 0 Then
            If e.ColumnIndex = 5 Then
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

    Private Sub dgvpalaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpalaman.CellClick
        If dgvpalaman.Rows.Count <> 0 Then
            If e.ColumnIndex = 5 Then
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

    Public Sub insertQuery()
        Dim dtItem As New DataTable(), dtPalaman As New DataTable()
        dtItem.Columns.Add("value")
        dtItem.Columns.Add("actual")
        dtItem.Columns.Add("itemid")
        dtItem.Columns.Add("formula_itemid")

        dtPalaman.Columns.Add("value")
        dtPalaman.Columns.Add("actual")
        dtPalaman.Columns.Add("itemid")
        dtPalaman.Columns.Add("formula_itemid")

        For index As Integer = 0 To dgvitems.Rows.Count - 1
            dtItem.Rows.Add(dgvitems.Rows(index).Cells("valuee").Value, dgvitems.Rows(index).Cells("actuall").Value, dgvitems.Rows(index).Cells("itemid").Value, dgvitems.Rows(index).Cells("formula_itemid").Value)
        Next

        For index As Integer = 0 To dgvpalaman.Rows.Count - 1
            dtPalaman.Rows.Add(dgvpalaman.Rows(index).Cells("valueee").Value, dgvpalaman.Rows(index).Cells("actualll").Value, dgvpalaman.Rows(index).Cells("itemidd").Value, dgvitems.Rows(index).Cells("formula_itemidd").Value)
        Next

        Dim step1num As String = step1c.returnFormulaNumber()
        step1c.setProduct(lblproduct.Text)
        step1c.setStep1Num(step1num)
        step1c.setFormulaID(formulaid)
        step1c.setStatus(1)
        step1c.setQuantity(txtquantity.Text)
        step1c.setBaseWT(lblbasewt.Text)
        step1c.insertStep1(dtItem, dtPalaman)
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If itemsValidation() = False Then
            MessageBox.Show("There's an error in items", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf PalamanValidation() = False Then
            MessageBox.Show("There's an error in palaman", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(txtquantity.Text) Then
            MessageBox.Show("Quantity must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtquantity.Text) Then
            MessageBox.Show("Quantity is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CDbl(txtquantity.Text) = 0 Then
            MessageBox.Show("Please input quantity alteast 1", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf itemsValidation() And PalamanValidation() Then
            insertQuery()
            clear()
        End If
    End Sub

    Public Sub loadFormulas()
        Try
            clear()
            fc.setProduct(txtsearch.Text)
            fc.setCategory(cmbcategory.Text)
            fc.setStatus(1)
            Dim dt As New DataTable(), auto As New AutoCompleteStringCollection()
            dt = fc.showFormulas()
            dgvformulas.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                dgvformulas.Rows.Add(r0w("id"), r0w("category"), r0w("product"))
                auto.Add(r0w("product"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            'If dgvformulas.Rows.Count = 0 Then
            '    clear()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class