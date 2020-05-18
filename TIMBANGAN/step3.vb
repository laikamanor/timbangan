Imports TIMBANGAN.step3_class
Public Class step3
    Dim cc As New connections_class, ic As New items_class, step3c As New step3_class
    Private step1id As Integer=0
    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        loadStep2()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadStep2()
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadStep2()
    End Sub


    Public Sub clear()
        GroupBox1.Text = "N/A"
        lblcategory.Text = "N/A"
        lblproduct.Text = "N/A"
        lbltdw.Text = "0.00"
        txtactualtdw.Text = "0.00"
        lbltargetquantity.Text = "0"
        txtactualquantity.Text = "0"
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 2 Then
                step3c.status = 1
                step3c.step1id = dgv.CurrentRow.Cells("id").Value
                Dim result As New DataTable()
                result = step3c.loadStep2()
                If result.Rows.Count <> 0 Then
                    For Each r0w As DataRow In result.Rows
                        lblcategory.Text = r0w("category")
                        lblproduct.Text = r0w("product")
                        lbltargetquantity.Text = CInt(r0w("quantity")).ToString("N0")
                        lbltdw.Text = CDbl(r0w("basewt")).ToString("n2")
                        GroupBox1.Text = r0w("step1num")
                        step1id = r0w("step1id")
                    Next
                Else
                    clear()
                End If
            End If
        End If
    End Sub

    Private Sub txtactualtdw_Leave(sender As Object, e As EventArgs) Handles txtactualtdw.Leave
        actualTDWValidation()
    End Sub
    Public Function actualTDWValidation() As Boolean
        Dim result As Boolean = False
        If String.IsNullOrEmpty(txtactualtdw.Text) Then
            MessageBox.Show("Actual TDW field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualtdw.Text = "0.00"
        ElseIf Not IsNumeric(txtactualtdw.Text) Then
            MessageBox.Show("Actual TDW must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualtdw.Text = "0.00"
        ElseIf CDbl(txtactualtdw.Text) <= 0 Then
            MessageBox.Show("Input atleast 1 Actual TDW", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualtdw.Text = "0.00"
        Else
            txtactualtdw.Text = CDbl(txtactualtdw.Text).ToString("n2")
            result = True
        End If
        Return result
    End Function
    Private Sub txtactualquantity_Leave(sender As Object, e As EventArgs) Handles txtactualquantity.Leave
        actualQuantityValidation()
    End Sub
    Public Function actualQuantityValidation() As Boolean
        Dim result As Boolean = False
        If String.IsNullOrEmpty(txtactualquantity.Text) Then
            MessageBox.Show("Actual Quantity field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualquantity.Text = 0
        ElseIf Not IsNumeric(txtactualquantity.Text) Then
            MessageBox.Show("Actual Quantity must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualquantity.Text = 0
        ElseIf CInt(txtactualquantity.Text) <= 0 Then
            MessageBox.Show("Input atleast 1 Actual Quantity", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualquantity.Text = 0
        Else
            txtactualquantity.Text = CInt(txtactualquantity.Text).ToString("N0")
            result = True
        End If
        Return True
    End Function
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If actualQuantityValidation() And actualTDWValidation() Then
            MessageBox.Show("Transaction Completed", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
        End If
    End Sub

    Private Sub step3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, False)
        If cmbcategory.Items.Count <> 0 Then
            Dim indexOfPalaman As Integer = cmbcategory.Items.IndexOf("Palaman")
            cmbcategory.Items.RemoveAt(indexOfPalaman)
            cmbcategory.SelectedIndex = 0
        End If
        loadStep2()
    End Sub

    Public Sub loadStep2()
        Try
            step3c.status = 1
            step3c.category = cmbcategory.Text
            step3c.product = txtsearch.Text
            step3c.step1id = 0
            Dim result As New DataTable(), auto As New AutoCompleteStringCollection
            result = step3c.loadStep2()
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
End Class