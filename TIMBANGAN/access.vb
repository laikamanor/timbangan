Imports TIMBANGAN.user_class
Imports TIMBANGAN.access_class
Imports TIMBANGAN.ui_class
Public Class access
    Dim uc As New user_class(), ac As New access_class(), ic As New ui_class()
    Private Sub access_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uc.filterWorkgroups(cmbworkgroup, True)
        cmbworkgroup.SelectedIndex = 0
        'loadAccess()
    End Sub
    Public Sub loadAccess()
        Try
            If String.IsNullOrEmpty(Trim(cmbworkgroup.Text)) Then
                cmbworkgroup.SelectedIndex = 0
            End If
            ac.setWorkgroup(cmbworkgroup.Text)
            Dim dt As New DataTable()
            dt = ac.showAccess()
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                dgv.Rows.Add(IIf(CInt(r0w("isHave")) = 1, True, False), r0w("name"), r0w("module"))
            Next
            lblnodata.Visible = IIf(dgv.Rows.Count = 0, True, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmbworkgroup_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbworkgroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadAccess()
        End If
    End Sub

    Private Sub cmbworkgroup_Leave(sender As Object, e As EventArgs) Handles cmbworkgroup.Leave
        loadAccess()
    End Sub


    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit, dgv.CellClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 0 And dgv.CurrentRow.Cells("modulee").Value = "Access" And dgv.CurrentRow.Cells("workgroup").Value = "Developer" Then
                dgv.CurrentRow.Cells("selectt").Value = True
            End If
        End If
    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        If dgv.Rows.Count <> 0 Then
            If e.ColumnIndex = 0 And dgv.CurrentRow.Cells("modulee").Value = "Access" And dgv.CurrentRow.Cells("workgroup").Value = "Developer" Then
                dgv.CurrentRow.Cells("selectt").Value = True
            End If
        End If
    End Sub

    Private Sub cmbworkgroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbworkgroup.SelectedValueChanged
        loadAccess()
        dgv.Columns("selectt").ReadOnly = True
        btnsubmit.Text = "Edit"
        btnsubmit.BackColor = Color.DodgerBlue
    End Sub

    Public Sub timerShow()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Public Sub msg(ByVal msg As String, ByVal txt As TextBox)
        ic.msgShow(panelmsg, True, lblerror, msg, False)
        txt.Focus()
        timerShow()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ac.checkAccess(main.btnaccess) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        dgv.Columns("selectt").ReadOnly = IIf(btnsubmit.Text = "Edit" And dgv.Rows.Count <> 0, False, True)
        btnsubmit.Text = IIf(btnsubmit.Text = "Edit" And dgv.Rows.Count <> 0, "Save", "Edit")
        btnsubmit.BackColor = IIf(btnsubmit.Text = "Edit" And dgv.Rows.Count <> 0, Color.DodgerBlue, Color.FromArgb(76, 209, 149))
        If btnsubmit.Text = "Edit" And dgv.Rows.Count <> 0 Then
            Dim dt As New DataTable()
            dt.Columns.Add("isHave", GetType(Integer))
            dt.Columns.Add("module", GetType(String))
            dt.Columns.Add("workgroup", GetType(String))
            For i As Integer = 0 To dgv.Rows.Count - 1
                dt.Rows.Add(IIf(CBool(dgv.Rows(i).Cells("selectt").Value) = False, 0, 1), dgv.Rows(i).Cells("modulee").Value, dgv.Rows(i).Cells("workgroup").Value)
            Next
            ac.updateAccess(dt)
            ic.msgShow(panelmsg, True, lblerror, "Access Completed", True)
            loadAccess()
        End If
    End Sub
End Class