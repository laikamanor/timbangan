Imports TIMBANGAN.step3_class
Public Class step3
    Dim cc As New connections_class, ic As New items_class, step3c As New step3_class
    Private step1id As Integer = 0, formulaid As Integer = 0
    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        'filter datagridview based on category
        loadStep2()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        'add shortcut enter when textsearch focus
        If e.KeyCode = Keys.Enter Then
            loadStep2()
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadStep2()
    End Sub


    'clear all selected data
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
                'set status and step1id to step3 class
                step3c.status = 1
                step3c.step1id = dgv.CurrentRow.Cells("id").Value
                Dim result As New DataTable()
                'get data
                result = step3c.loadStep2()
                'check if datatable has row
                If result.Rows.Count <> 0 Then
                    'loop through
                    For Each r0w As DataRow In result.Rows
                        'assign value
                        lblcategory.Text = r0w("category")
                        lblproduct.Text = r0w("product")
                        lbltargetquantity.Text = CInt(r0w("quantity")).ToString("N0")
                        lbltdw.Text = CDbl(r0w("basewt")).ToString("n2")
                        GroupBox1.Text = r0w("step1num")
                        step1id = CInt(r0w("step1id"))
                        formulaid = CInt(r0w("formulaid"))
                    Next
                Else
                    'clear when datatable row is zero
                    clear()
                End If
            End If
        End If
    End Sub

    Private Sub txtactualtdw_Leave(sender As Object, e As EventArgs) Handles txtactualtdw.Leave
        'tdw validation sub
        actualTDWValidation()
    End Sub

    ''' <summary>
    ''' Actual TDW Validation
    ''' </summary>
    ''' <returns></returns>
    Public Function actualTDWValidation() As Boolean
        'init result 
        Dim result As Boolean = False
        'check tdw if empty
        If String.IsNullOrEmpty(txtactualtdw.Text) Then
            MessageBox.Show("Actual TDW field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualtdw.Text = "0.00"
            'check tdw if numeric
        ElseIf Not IsNumeric(txtactualtdw.Text) Then
            MessageBox.Show("Actual TDW must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualtdw.Text = "0.00"
            'check tdw if value is less than or equal to zero
        ElseIf CDbl(txtactualtdw.Text) <= 0 Then
            MessageBox.Show("Input atleast 1 Actual TDW", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualtdw.Text = "0.00"
            'result become true that means all validation is success
        Else
            'assign tdw to double format
            txtactualtdw.Text = CDbl(txtactualtdw.Text).ToString("n2")
            result = True
        End If
        'return resullt
        Return result
    End Function
    Private Sub txtactualquantity_Leave(sender As Object, e As EventArgs) Handles txtactualquantity.Leave
        'quantity validation
        actualQuantityValidation()
    End Sub
    ''' <summary>
    ''' Actual Quantity Validation
    ''' </summary>
    ''' <returns></returns>
    Public Function actualQuantityValidation() As Boolean
        'init result
        Dim result As Boolean = False
        'check quantity if empty
        If String.IsNullOrEmpty(txtactualquantity.Text) Then
            MessageBox.Show("Actual Quantity field is required", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualquantity.Text = 0
            'check quantity if numeric
        ElseIf Not IsNumeric(txtactualquantity.Text) Then
            MessageBox.Show("Actual Quantity must be a number", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualquantity.Text = 0
            'check quantity if less than or equal to zero
        ElseIf CInt(txtactualquantity.Text) <= 0 Then
            MessageBox.Show("Input atleast 1 Actual Quantity", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtactualquantity.Text = 0
            'result become true that means all validation is success
        Else
            'assign quantity to double format
            txtactualquantity.Text = CInt(txtactualquantity.Text).ToString("N0")
            result = True
        End If
        'Return result
        Return True
    End Function
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        'check if quantity and tdw is success
        If actualQuantityValidation() And actualTDWValidation() Then
            'assign parameters
            Dim step3num As String = step3c.returnStep3Num
            step3c.step3Num = step3num
            step3c.step1id = step1id
            step3c.formulaID = formulaid
            step3c.product = lblproduct.Text
            step3c.tdw = CDbl(txtactualtdw.Text)
            step3c.quantity = CDbl(txtactualquantity.Text)
            step3c.userID = login.userid
            step3c.status = 1
            'insert to step3 table
            step3c.insertStep3()
            'form will refresh
            clear()
            loadStep2()
        End If
    End Sub

    Private Sub step3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get categories from item class
        ic.filterCategories(cmbcategory, False)
        'check category item has item
        If cmbcategory.Items.Count <> 0 Then
            Dim indexOfPalaman As Integer = cmbcategory.Items.IndexOf("Palaman")
            cmbcategory.Items.RemoveAt(indexOfPalaman)
            cmbcategory.SelectedIndex = 0
        End If
        'load datagridview
        loadStep2()
    End Sub
    ''' <summary>
    ''' load datagridview and get data from step3 class
    ''' </summary>
    Public Sub loadStep2()
        Try
            'assign parameters
            step3c.status = 1
            step3c.category = cmbcategory.Text
            step3c.product = txtsearch.Text
            step3c.step1id = 0
            'init datatable that hold data and autocomplete textsearch
            Dim result As New DataTable(), auto As New AutoCompleteStringCollection
            'get data from step3 class
            result = step3c.loadStep2()
            'clear datagridview rows before loop through it
            dgv.Rows.Clear()
            'check datatable has row
            If result.Rows.Count <> 0 Then
                For Each r0w As DataRow In result.Rows
                    'assign values
                    dgv.Rows.Add(r0w("step1id"), r0w("category"), r0w("product"))
                    auto.Add(r0w("product"))
                Next
            Else
                'when datatable has no row
                'clear datagridview and autocomplete
                dgv.Rows.Clear()
                auto.Clear()
            End If
            'assign autocomplete to textsearch
            txtsearch.AutoCompleteCustomSource = auto
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class