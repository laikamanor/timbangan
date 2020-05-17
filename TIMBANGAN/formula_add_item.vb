Imports TIMBANGAN.ui_class
Imports TIMBANGAN.formula_class
Imports TIMBANGAN.items_class
Public Class formula_add_item
    Dim uic As New ui_class(), fc As New formula_class(), ic As New items_class()
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub formula_add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ic.filterCategories(cmbcategory, True)
        If lblheader.Text = "Add Palaman Item" Then
            If cmbcategory.Items.Count <> 0 Then
                Dim indexOfPalaman As Integer = cmbcategory.Items.IndexOf("Palaman")
                cmbcategory.Items.RemoveAt(indexOfPalaman)
                cmbcategory.AutoCompleteCustomSource.RemoveAt(indexOfPalaman)
                cmbcategory.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub formula_add_item_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, panelmsg.MouseDown, lblheader.MouseDown, lblerror.MouseDown, Label5.MouseDown, Label3.MouseDown, Label2.MouseDown, Label1.MouseDown
        uic.mouse_down(Me)
    End Sub

    Private Sub formula_add_item_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, panelmsg.MouseMove, lblheader.MouseMove, lblerror.MouseMove, Label5.MouseMove, Label3.MouseMove, Label2.MouseMove, Label1.MouseMove
        uic.mouse_move(Me)
    End Sub

    Private Sub cmbcategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedValueChanged
        fc.setCategory(cmbcategory.Text)
        fc.filterItems(cmbitems, True, txtuom)
        If cmbitems.Items.Count <> 0 Then
            cmbitems.SelectedIndex = 0
        Else
            txtuom.Text = "N/A"
            cmbitems.ResetText()
        End If
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ic.setCategory(cmbcategory.Text)
        fc.setItem(cmbitems.Text)
        fc.setCategory(cmbcategory.Text)
        If String.IsNullOrEmpty(cmbcategory.Text) Then
            msg("Category field is required", cmbcategory)
        ElseIf ic.checkCategory() = False Then
            msg("Category " & cmbcategory.Text & " not found", cmbcategory)
        ElseIf String.IsNullOrEmpty(cmbitems.Text) Then
            msg("Item field is required", cmbitems)
        ElseIf fc.checkItems() = False Then
            msg("Item " & cmbitems.Text & " not found", cmbitems)
        ElseIf String.IsNullOrEmpty(txtvalue.Text) Then
            msg("Value field is required", txtvalue)
        ElseIf IsNumeric(txtvalue.Text) = False Then
            msg("Value field is must be a number", txtvalue)
        Else
            If lblheader.Text = "Add Item" Or lblheader.Text = "Edit Item" Then
                Dim result As Integer = 0
                For index As Integer = 0 To add_formula.dgvitems.Rows.Count - 1
                    If cmbitems.Text = add_formula.dgvitems.Rows(index).Cells("itemname").Value Then
                        result += 1
                    End If
                Next
                If result = 0 Then
                    add_formula.dgvitems.Rows.Add(cmbcategory.Text, cmbitems.Text, IIf(cmbcategory.Text.ToLower = "Palaman".ToLower, 0, txtvalue.Text), txtuom.Text)
                    Me.Close()
                Else
                    If lblheader.Text = "Edit Item" Then
                        add_formula.dgvitems.CurrentRow.Cells("valuee").Value = IIf(cmbcategory.Text.ToLower = "Palaman".ToLower, 0, txtvalue.Text)
                        Me.Close()
                    Else
                        Dim result_palaman As Integer = 0
                        For index As Integer = 0 To add_formula.dgvitems.Rows.Count - 1
                            If "Palaman".ToLower = add_formula.dgvitems.Rows(index).Cells("category").Value.ToString.ToLower Then
                                result_palaman += 1
                            End If
                        Next
                        If result_palaman = 0 Then
                            msg("This item is already added", cmbitems)
                        Else
                            msg("You have already Palaman", cmbitems)
                        End If
                    End If
                End If
            Else
                Dim result As Integer = 0
                For index As Integer = 0 To add_formula.dgvpalaman.Rows.Count - 1
                    If cmbitems.Text = add_formula.dgvpalaman.Rows(index).Cells("itemname2").Value Then
                        result += 1
                    End If
                Next
                If result = 0 Then
                    add_formula.dgvpalaman.Rows.Add(cmbcategory.Text, cmbitems.Text, txtvalue.Text, txtuom.Text)
                    Me.Close()
                Else
                    If lblheader.Text = "Edit Palaman Item" Then
                        add_formula.dgvpalaman.CurrentRow.Cells("valuee2").Value = txtvalue.Text
                        Me.Close()
                    Else
                        msg("This item is already added22", cmbitems)
                    End If
                End If
            End If
        End If
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub cmbcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcategory.KeyDown, txtvalue.KeyDown, cmbitems.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmit.PerformClick()
        End If
    End Sub

    Private Sub formula_add_item_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, panelmsg.MouseUp, lblheader.MouseUp, lblerror.MouseUp, Label5.MouseUp, Label3.MouseUp, Label2.MouseUp, Label1.MouseUp
        uic.mouse_up()
    End Sub

    Private Sub formula_add_item_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class