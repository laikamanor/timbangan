Imports TIMBANGAN.ui_class
Imports TIMBANGAN.user_class
Imports TIMBANGAN.modules_class
Imports TIMBANGAN.access_class
Public Class add_module
    Dim ic As New ui_class(), uc As New user_class(), mc As New modules_class(), ac As New access_class()
    Public current_module As String = ""
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub add_module_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, panelmsg.MouseDown, lblheader.MouseDown, lblerror.MouseDown, Label6.MouseDown, Label5.MouseDown, Label3.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub add_module_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, panelmsg.MouseMove, lblheader.MouseMove, lblerror.MouseMove, Label6.MouseMove, Label5.MouseMove, Label3.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub add_module_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, panelmsg.MouseUp, lblheader.MouseUp, lblerror.MouseUp, Label6.MouseUp, Label5.MouseUp, Label3.MouseUp
        ic.mouse_up()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub add_module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbstatus.SelectedIndex = 0
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
        mc.setModuleName(txtmodule.Text)
        mc.setDescription(txtdescription.Text)
        mc.setUserID(login.userid)
        mc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        mc.insertModule()
        ic.msgShow(panelmsg, True, lblerror, "Module " & txtmodule.Text & " is now registered", True)
    End Sub
    Public Sub edit()
        mc.setCurrentModuleName(current_module)
        mc.setModuleName(txtmodule.Text)
        mc.setDescription(txtdescription.Text)
        mc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        mc.updateModule()
        ic.msgShow(panelmsg, True, lblerror, "Module " & txtmodule.Text & " is now updated", True)
    End Sub
    Public Sub submit()
        Try
            mc.setModuleName(txtmodule.Text)
            If String.IsNullOrEmpty(txtmodule.Text) Then
                msg("Module field is required", txtmodule)
            ElseIf mc.checkModule() And current_module <> txtmodule.Text Then
                msg("Module " & txtmodule.Text & " is already registered", txtmodule)
            Else
                If lblheader.Text = "Add Module" Then
                    add()
                Else
                    edit()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub add_module_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ac.checkAccess(modules.btnaddnew) Then
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

    Private Sub cmbworkgroup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmodule.KeyDown, txtdescription.KeyDown, cmbstatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub
End Class