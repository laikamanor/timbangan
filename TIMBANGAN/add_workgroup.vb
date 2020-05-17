Imports TIMBANGAN.ui_class
Imports TIMBANGAN.workgroup_class
Imports TIMBANGAN.access_class
Public Class add_workgroup
    Dim uic As New ui_class(), wc As New workgroup_class(), ac As New access_class()
    Public current_name As String = ""
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub add_workgroup_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblheader.MouseDown, Label6.MouseDown, Label2.MouseDown, Label1.MouseDown, panelmsg.MouseDown, lblerror.MouseDown
        uic.mouse_down(Me)
    End Sub

    Private Sub add_workgroup_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, lblheader.MouseMove, Label6.MouseMove, Label2.MouseMove, Label1.MouseMove, panelmsg.MouseMove, lblerror.MouseMove
        uic.mouse_move(Me)
    End Sub

    Private Sub add_workgroup_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, lblheader.MouseUp, Label6.MouseUp, Label2.MouseUp, Label1.MouseUp, panelmsg.MouseUp, lblerror.MouseUp
        uic.mouse_up()
    End Sub

    Private Sub add_workgroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblheader.Text = "Add Workgroup" Then
            cmbstatus.SelectedIndex = 0
        End If
    End Sub

    Public Sub add()
        wc.setWorkgroup(txtname.Text)
        wc.setDescription(txtdescription.Text)
        wc.setUserID(1)
        wc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        wc.addWorkgroup()
        uic.msgShow(panelmsg, True, lblerror, "Workgroup Added", True)
    End Sub
    Public Sub edit()
        wc.setCurentWorkgroup(current_name)
        wc.setWorkgroup(txtname.Text)
        wc.setDescription(txtdescription.Text)
        wc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        wc.updateWorkgroup()
        uic.msgShow(panelmsg, True, lblerror, "Workgroup Updated", True)
    End Sub
    Public Sub submit()
        Try
            wc.setWorkgroup(txtname.Text)
            If String.IsNullOrEmpty(txtname.Text) Then
                uic.msgShow(panelmsg, True, lblerror, "Name field is required", False)
                txtname.Focus()
                timerShow()
            ElseIf wc.checkWorkgroup() And current_name <> txtname.Text Then
                uic.msgShow(panelmsg, True, lblerror, "Name " & txtname.Text & " is already registered", False)
                txtname.Focus()
                timerShow()
            ElseIf String.IsNullOrEmpty(txtdescription.Text) Then
                uic.msgShow(panelmsg, True, lblerror, "Description field is required", False)
                txtdescription.Focus()
                timerShow()
            Else
                If lblheader.Text = "Add Workgroup" Then
                    add()
                Else
                    edit()
                End If
                timerShow()
                clear_all()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub clear_all()
        txtname.Text = ""
        txtdescription.Text = ""
        cmbstatus.SelectedIndex = 0
        txtname.Focus()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown, txtdescription.KeyDown, cmbstatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub

    Private Sub add_workgroup_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Public Sub timerShow()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ac.checkAccess(workgroups.btnaddnew) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub
End Class