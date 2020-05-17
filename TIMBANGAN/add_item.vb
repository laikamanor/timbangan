Imports TIMBANGAN.items_class
Imports TIMBANGAN.ui_class
Imports TIMBANGAN.access_class
Public Class add_item
    Dim ic As New items_class(), uic As New ui_class(), ac As New access_class()
    Public current_itemname As String = ""
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Public Sub add()
        ic.insertItem()
        uic.msgShow(panelmsg, True, lblerror, "Item " & txtitemname.Text & " is now registered", True)
    End Sub
    Public Sub edit()
        ic.updateItem()
        uic.msgShow(panelmsg, True, lblerror, "Item " & txtitemname.Text & " is now updated", True)
    End Sub
    Public Sub edit_import()
        import_items.dgv.CurrentRow.Cells("category").Value = cmbcategory.Text
        import_items.dgv.CurrentRow.Cells("itemname").Value = txtitemname.Text
        import_items.dgv.CurrentRow.Cells("description").Value = txtdescription.Text
        import_items.dgv.CurrentRow.Cells("uom").Value = txtuom.Text
        import_items.dgv.CurrentRow.Cells("status").Value = cmbstatus.Text
        Me.Close()
    End Sub
    Public Sub timerShow()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Public Sub msg(ByVal msg As String, ByVal txt As Control)
        uic.msgShow(panelmsg, True, lblerror, msg, False)
        txt.Focus()
        timerShow()
    End Sub
    Public Sub submit()
        ic.setCategory(cmbcategory.Text)
        ic.setItemName(txtitemname.Text)
        ic.setDescription(txtdescription.Text)
        ic.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        ic.setUOM(txtuom.Text)
        ic.setCurrentItemName(current_itemname)
        If String.IsNullOrEmpty(cmbcategory.Text) Then
            msg("Category field is required", cmbcategory)
        ElseIf ic.checkCategory() = False Then
            msg("Category " & cmbcategory.Text & " not found", cmbcategory)
        ElseIf String.IsNullOrEmpty(txtitemname.Text) Then
            msg("Item Name field is required", txtitemname)
        ElseIf ic.checkItemName() And current_itemname <> txtitemname.Text Then
            msg("Item Name " & txtitemname.Text & " is already registered", txtitemname)
        ElseIf String.IsNullOrEmpty(txtdescription.Text) Then
            msg("Description field is required", txtitemname)
        ElseIf String.IsNullOrEmpty(txtuom.Text) Then
            msg("UOM field is required", txtitemname)
        ElseIf lblheader.Text = "Edit Import Item" And cmbstatus.Text = "" Then
            msg("Pick status first", cmbstatus)
        Else
            If lblheader.Text = "Add Item" Then
                add()
            ElseIf lblheader.Text = "Edit Item" Then
                edit()
            ElseIf lblheader.Text = "Edit Import Item" Then
                edit_import()
            End If
        End If
    End Sub
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, True)
        If lblheader.Text = "Add Item" Then
            cmbstatus.SelectedIndex = 0
            cmbcategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub add_item_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblheader.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, panelmsg.MouseDown, lblerror.MouseDown
        uic.mouse_down(Me)
    End Sub

    Private Sub add_item_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, lblheader.MouseMove, Label5.MouseMove, Label4.MouseMove, Label3.MouseMove, Label2.MouseMove, panelmsg.MouseMove, lblerror.MouseMove
        uic.mouse_move(Me)
    End Sub

    Private Sub add_item_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, lblheader.MouseUp, Label5.MouseUp, Label4.MouseUp, Label3.MouseUp, Label2.MouseUp, panelmsg.MouseUp, lblerror.MouseUp
        uic.mouse_up()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub add_item_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcategory.KeyDown, txtuom.KeyDown, txtitemname.KeyDown, txtdescription.KeyDown, cmbstatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ac.checkAccess(items.btnaddnew) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub
End Class