Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports TIMBANGAN.ui_class
Imports TIMBANGAN.categories_class
Imports TIMBANGAN.items_class
Imports System.Data.SqlClient
Public Class import_items
    Dim ic As New ui_class(), catc As New categories_class(), itemc As New items_class()
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub import_items_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub import_items_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblheader.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub import_items_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, lblheader.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub import_items_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, lblheader.MouseUp
        ic.mouse_up()
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Try
            Dim con As System.Data.OleDb.OleDbConnection
            Dim ds As New DataSet
            Dim cmd As OleDbCommand
            Dim rdr As OleDbDataReader
            Dim opf As New OpenFileDialog()
            opf.Title = "Open Excel File"
            opf.Filter = "Excel Document (*.xlsx) | *.xlsx"
            Dim path As String = ""
            If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                path = opf.FileName
                dgv.Rows.Clear()
                Dim auto As New AutoCompleteStringCollection()
                con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & path & "; Extended Properties=Excel 12.0;")
                con.Open()
                cmd = New OleDbCommand("SELECT * FROM [Sheet1$]", con)
                rdr = cmd.ExecuteReader
                While rdr.Read
                    dgv.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
                    auto.Add(rdr(1))
                End While
                con.Close()
                txtsearch.AutoCompleteCustomSource = auto
                lblnodata.Visible = IIf(dgv.Rows.Count <> 0, False, True)
                Me.Cursor = Cursors.Default
                btnsubmit.Enabled = False
                check()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub check()
        Dim check_count As Integer = 0
        If dgv.Rows.Count = 0 Then
            MessageBox.Show("No data found", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblnodata.Visible = IIf(dgv.Rows.Count <> 0, False, True)
            check_count += 1
        Else
            For index As Integer = 0 To dgv.Rows.Count - 1
                catc.setCategory(dgv.Rows(index).Cells("category").Value)
                If catc.checkCategory() = False Then
                    dgv.Rows(index).Cells("category").Style.BackColor = Color.Firebrick
                    dgv.Rows(index).Cells("category").ToolTipText = "This Category is not exist"
                    check_count += 1
                End If
                itemc.setItemName(dgv.Rows(index).Cells("itemname").Value)
                If itemc.checkItemName() Then
                    dgv.Rows(index).Cells("itemname").Style.BackColor = Color.Firebrick
                    dgv.Rows(index).Cells("itemname").ToolTipText = "This Item is already exist"
                    check_count += 1
                End If
                If dgv.Rows(index).Cells("status").Value.ToString.ToLower = "Active".ToLower Or dgv.Rows(index).Cells("status").Value.ToString.ToLower = "In Active".ToLower Then

                Else
                    dgv.Rows(index).Cells("status").Style.BackColor = Color.Firebrick
                    dgv.Rows(index).Cells("status").ToolTipText = "Invalid Status"
                    check_count += 1
                End If
            Next
            If check_count = 0 Then
                btnsubmit.Enabled = True
                For index As Integer = 0 To dgv.Rows.Count - 1
                    dgv.Rows(index).Cells("category").Style.BackColor = Color.White
                    dgv.Rows(index).Cells("itemname").Style.BackColor = Color.White
                    dgv.Rows(index).Cells("status").Style.BackColor = Color.White
                    dgv.Rows(index).Cells("category").ToolTipText = ""
                    dgv.Rows(index).Cells("itemname").ToolTipText = ""
                    dgv.Rows(index).Cells("status").ToolTipText = ""
                Next
            Else
                btnsubmit.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If Not String.IsNullOrEmpty(Trim(txtsearch.Text)) Then
            If dgv.Rows.Count <> 0 Then
                For i As Integer = 0 To dgv.Rows.Count - 1
                    If dgv.Rows(i).Cells("itemname").Value = txtsearch.Text Then
                        dgv.Rows(i).Selected = True
                        dgv.CurrentCell = dgv.Rows(i).Cells("itemname")
                    Else
                        dgv.Rows(i).Selected = False
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsearch.PerformClick()
        End If
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        check()
        If btnsubmit.Enabled Then
            Dim dt As New DataTable()
            dt.Columns.Add("category")
            dt.Columns.Add("itemname")
            dt.Columns.Add("description")
            dt.Columns.Add("uom")
            dt.Columns.Add("status")
            For index As Integer = 0 To dgv.Rows.Count - 1
                dt.Rows.Add(dgv.Rows(index).Cells("category").Value, dgv.Rows(index).Cells("itemname").Value, dgv.Rows(index).Cells("description").Value, dgv.Rows(index).Cells("uom").Value, dgv.Rows(index).Cells("status").Value)
            Next
            itemc.addImportItem(dt)
            Me.Close()
        End If
    End Sub

    Private Sub import_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 5 Then
                Dim frm As New add_item()
                frm.lblheader.Text = "Edit Import Item"
                frm.current_itemname = dgv.CurrentRow.Cells("itemname").Value
                frm.txtitemname.Text = dgv.CurrentRow.Cells("itemname").Value
                frm.cmbcategory.Text = dgv.CurrentRow.Cells("category").Value
                frm.txtdescription.Text = dgv.CurrentRow.Cells("description").Value
                frm.txtuom.Text = dgv.CurrentRow.Cells("uom").Value
                frm.cmbstatus.Text = dgv.CurrentRow.Cells("status").Value
                frm.ShowDialog()
                check()
                filterChanges()
            ElseIf e.ColumnIndex = 6 Then
                Dim a As String = MsgBox("Are you sure you want to remove?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atlantic Bakery")
                If a = vbYes Then
                    dgv.Rows.RemoveAt(e.RowIndex)
                    check()
                    filterChanges()
                End If
            End If
        End If
    End Sub
    Public Sub filterChanges()
        Dim auto As New AutoCompleteStringCollection()
        For index As Integer = 0 To dgv.Rows.Count - 1
            auto.Add(dgv.Rows(index).Cells("itemname").Value)
        Next
        txtsearch.AutoCompleteCustomSource = auto
    End Sub
End Class