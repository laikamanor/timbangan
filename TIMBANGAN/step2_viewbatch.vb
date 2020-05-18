Imports TIMBANGAN.ui_class
Imports TIMBANGAN.step2_class
Public Class step2_viewbatch
    Public id As Integer = 0
    Dim uic As New ui_class(), step2c As New step2_class()
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub step2_viewbatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Public Sub loadData()
        step2c.setStatus(1)
        step2c.setStep1ID(id)
        Dim result As New DataTable()
        result = step2c.loadStep1()

        If result.Rows.Count <> 0 Then
            For Each r0w As DataRow In result.Rows
                lblstepnum.Text = r0w("step1num")
                lblcategory.Text = r0w("category")
                lblproduct.Text = r0w("product")
                lblquantity.Text = CInt(r0w("batch")).ToString("N0") & "/" & CInt(r0w("quantity")).ToString("N0")
                lbltdw.Text = r0w("basewt")
            Next
        Else
            clear()
        End If
        Dim batchesCount As New DataTable(), auto As New AutoCompleteStringCollection
        batchesCount = step2c.returnBatchesCount
        cmbatches.Items.Clear()

        For Each r0w As DataRow In batchesCount.Rows
            cmbatches.Items.Add(r0w("batch"))
            auto.Add(r0w("step2id"))
        Next
        If cmbatches.Items.Count <> 0 Then
            cmbatches.AutoCompleteCustomSource = auto
        End If
    End Sub
    Public Sub clear()
        lblstepnum.Text = "N/A"
        lblcategory.Text = "N/A"
        lblproduct.Text = "N/A"
        lblquantity.Text = "0/0"
        lbltdw.Text = "N/A"
        cmbatches.Items.Clear()
        cmbatches.SelectedIndex = -1
        lblbatchquantity.Text = "Batch Quantity: 0"
        dgvitems.Rows.Clear()
        dgvpalaman.Rows.Clear()
    End Sub
    Private Sub step2_viewbatch_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblbatchquantity.MouseDown, lblheader.MouseDown, Label9.MouseDown, lblstepnum.MouseDown, Label7.MouseDown, Label6.MouseDown, lblcategory.MouseDown, lblquantity.MouseDown, lblproduct.MouseDown, Label2.MouseDown, Label1.MouseDown
        uic.mouse_down(Me)
    End Sub

    Private Sub step2_viewbatch_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, lblbatchquantity.MouseMove, lblheader.MouseMove, Label9.MouseMove, lblstepnum.MouseMove, Label7.MouseMove, Label6.MouseMove, lblcategory.MouseMove, lblquantity.MouseMove, lblproduct.MouseMove, Label2.MouseMove, Label1.MouseMove
        uic.mouse_move(Me)
    End Sub

    Private Sub step2_viewbatch_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, lblbatchquantity.MouseUp, lblheader.MouseUp, Label9.MouseUp, lblstepnum.MouseUp, Label7.MouseUp, Label6.MouseUp, lblcategory.MouseUp, lblquantity.MouseUp, lblproduct.MouseUp, Label2.MouseUp, Label1.MouseUp
        uic.mouse_up()
    End Sub

    Private Sub cmbatches_Leave(sender As Object, e As EventArgs) Handles cmbatches.Leave
        Dim itemTableName As String = "step2_items",
   palamanTableName As String = "step2_palaman",
   dtItems As New DataTable(), dtPalaman As New DataTable()
        Dim step2id As Integer = cmbatches.AutoCompleteCustomSource(cmbatches.SelectedIndex)
        step2c.gsstep2ID = step2id

        lblbatchquantity.Text = "Batch Quantity: " & step2c.returnBatchQuantity.ToString("N0")
        dtItems = step2c.returnItemsPalaman(itemTableName)
        dtPalaman = step2c.returnItemsPalaman(palamanTableName)
        'dgvitems
        If dtItems.Rows.Count <> 0 Then
            dgvitems.Rows.Clear()
            For Each r0w As DataRow In dtItems.Rows
                dgvitems.Rows.Add(r0w("itemname"), CDbl(r0w("value")).ToString("n2"), CDbl(r0w("actual")).ToString("n2"))
            Next
        Else
            dgvitems.Rows.Clear()
        End If
        'dgvpalaman
        If dtPalaman.Rows.Count <> 0 Then
            dgvpalaman.Rows.Clear()
            For Each r0w As DataRow In dtPalaman.Rows
                dgvpalaman.Rows.Add(r0w("itemname"), CDbl(r0w("value")).ToString("n2"), CDbl(r0w("actual")).ToString("n2"))
            Next
        Else
            dgvpalaman.Rows.Clear()
        End If
        '' show label no data to fetch when datagridview row is zero.
        lblitemsnocount.Visible = IIf(dgvitems.Rows.Count = 0, True, False)
        lblpalamannocount.Visible = IIf(dgvpalaman.Rows.Count = 0, True, False)
    End Sub

    Private Sub step2_viewbatch_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class