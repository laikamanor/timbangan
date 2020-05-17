Imports TIMBANGAN.ui_class
Imports TIMBANGAN.items_class
Imports TIMBANGAN.products_class
Imports TIMBANGAN.access_class
Public Class add_product
    Dim ic As New ui_class(), itemc As New items_class(), pc As New products_class(), ac As New access_class()
    Public current_product As String = ""
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itemc.filterCategories(cmbcategory, True)
        If lblheader.Text = "Add Product" Then
            cmbstatus.SelectedIndex = 0
            cmbcategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub add_product_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblheader.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, panelmsg.MouseDown, lblerror.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub add_product_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, lblheader.MouseMove, Label4.MouseMove, Label3.MouseMove, Label2.MouseMove, panelmsg.MouseMove, lblerror.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub add_product_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, lblheader.MouseUp, Label4.MouseUp, Label3.MouseUp, Label2.MouseUp, panelmsg.MouseUp, lblerror.MouseUp
        ic.mouse_up()
    End Sub

    Public Sub add()
        pc.insertProduct()
        ic.msgShow(panelmsg, True, lblerror, "Product " & txtproduct.Text & " is now registered", True)
    End Sub

    Public Sub edit()
        pc.updateProduct()
        ic.msgShow(panelmsg, True, lblerror, "Product " & txtproduct.Text & " is now updated", True)
    End Sub

    Public Sub edit_import()
        import_products.dgv.CurrentRow.Cells("category").Value = cmbcategory.Text
        import_products.dgv.CurrentRow.Cells("product").Value = txtproduct.Text
        import_products.dgv.CurrentRow.Cells("description").Value = txtdescription.Text
        import_products.dgv.CurrentRow.Cells("status").Value = cmbstatus.Text
        Me.Close()
    End Sub

    Public Sub submit()
        pc.setCurrentProductName(current_product)
        pc.setProductName(txtproduct.Text)
        pc.setCategory(cmbcategory.Text)
        itemc.setCategory(cmbcategory.Text)
        pc.setProductName(txtproduct.Text)
        pc.setDescription(txtdescription.Text)
        pc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        If String.IsNullOrEmpty(cmbcategory.Text) Then
            msg("Category field is required", cmbcategory)
        ElseIf itemc.checkCategory() = False Then
            msg("Category " & cmbcategory.Text & " not found", cmbcategory)
        ElseIf String.IsNullOrEmpty(txtproduct.Text) Then
            msg("Product field is required", txtproduct)
        ElseIf pc.checkProduct() And current_product <> txtproduct.Text Then
            msg("Product " & txtproduct.Text & " is already registered", txtproduct)
        ElseIf String.IsNullOrEmpty(txtdescription.Text) Then
            msg("Description field is required", txtproduct)
        ElseIf lblheader.Text = "Edit Import Product" And cmbstatus.Text = "" Then
            msg("Pick status first", cmbstatus)
        Else
            If lblheader.Text = "Add Product" Then
                add()
            ElseIf lblheader.Text = "Edit Product" Then
                edit()
            ElseIf lblheader.Text = "Edit Import Product" Then
                edit_import()
            End If
        End If
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub cmbcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcategory.KeyDown, txtproduct.KeyDown, txtdescription.KeyDown, cmbstatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub

    Private Sub add_product_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub
    Public Sub timerShow()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ac.checkAccess(products.btnaddnew) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Public Sub msg(ByVal msg As String, ByVal txt As Control)
        ic.msgShow(panelmsg, True, lblerror, msg, False)
        txt.Focus()
        timerShow()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub
End Class