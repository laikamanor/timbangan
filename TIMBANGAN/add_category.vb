Imports TIMBANGAN.categories_class
Imports TIMBANGAN.ui_class
Imports TIMBANGAN.access_class
Imports System.Data.SqlClient
Public Class add_category
    Dim cc As New categories_class(), ac As New access_class()
    Dim ic As New ui_class()
    Public current_category As String = ""
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub add_category_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, panelmsg.MouseDown, lblerror.MouseDown, lblheader.MouseDown, Label2.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub add_category_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, panelmsg.MouseMove, lblerror.MouseMove, lblheader.MouseMove, Label2.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub add_category_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, panelmsg.MouseUp, lblerror.MouseUp, lblheader.MouseUp, Label2.MouseUp
        ic.mouse_up()
    End Sub
    Public Sub timerShow()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Public Sub msg(ByVal msg As String, ByVal txt As Control)
        ic.msgShow(panelmsg, True, lblerror, msg, False)
        txt.Focus()
        timerShow()
    End Sub

    Public Sub add()
        cc.addCategory()
        ic.msgShow(panelmsg, True, lblerror, "Category " & txtcategory.Text & " is now registered", True)
        txtcategory.Text = ""
    End Sub
    Public Sub edit()
        cc.updateCategory()
        ic.msgShow(panelmsg, True, lblerror, "Category " & txtcategory.Text & " is now updated", True)
        txtcategory.Text = ""
    End Sub
    Public Sub edit_import()
        import_categories.dgv.CurrentRow.Cells("category").Value = txtcategory.Text
        import_categories.dgv.CurrentRow.Cells("status").Value = cmbstatus.Text
        Me.Close()
    End Sub
    Public Sub submit()
        cc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        cc.setCategory(txtcategory.Text)
        cc.setCurrentCategory(current_category)
        If String.IsNullOrEmpty(txtcategory.Text) Then
            msg("Category field is required", txtcategory)
        ElseIf txtcategory.TextLength < 1 Then
            msg("Category field is too short", txtcategory)
        ElseIf cc.checkCategory() And current_category <> txtcategory.Text Then
            msg(txtcategory.Text & " is already exist", txtcategory)
        ElseIf lblheader.Text = "Edit Import Category" And cmbstatus.Text = "" Then
            msg("Pick status first", cmbstatus)
        Else
            If lblheader.Text = "Add Category" Then
                add()
            ElseIf lblheader.Text = "Edit Category" Then
                edit()
            ElseIf lblheader.Text = "Edit Import Category" Then
                edit_import()
            End If
        End If
    End Sub
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub add_category_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub

    Private Sub add_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblheader.Text = "Add Category" Then
            cmbstatus.SelectedIndex = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ac.checkAccess(categories.btnaddnew) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub
End Class