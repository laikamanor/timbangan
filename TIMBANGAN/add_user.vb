Imports TIMBANGAN.user_class
Imports TIMBANGAN.ui_class
Imports TIMBANGAN.security_class
Imports TIMBANGAN.access_class
Public Class add_user
    Dim uc As New user_class(), ic As New ui_class(), sc As New security_class(), ac As New access_class
    Public current_username As String = ""
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub add_user_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblheader.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, Label1.MouseDown, panelmsg.MouseDown, lblerror.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub add_user_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, lblheader.MouseMove, Label5.MouseMove, Label4.MouseMove, Label3.MouseMove, Label2.MouseMove, Label1.MouseMove, panelmsg.MouseMove, lblerror.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub add_user_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, lblheader.MouseUp, Label5.MouseUp, Label4.MouseUp, Label3.MouseUp, Label2.MouseUp, Label1.MouseUp, panelmsg.MouseUp, lblerror.MouseUp
        ic.mouse_up()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
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
        uc.setUsername(txtusername.Text)
        uc.setFullName(txtfullname.Text)
        uc.setWorkgroup(cmbworkgroup.Text)
        uc.setPassword(sc.Encode(txtretypepassword.Text))
        uc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        uc.setUserID(1)
        uc.addUser()
        ic.msgShow(panelmsg, True, lblerror, "Username " & txtusername.Text & " is now registered", True)
    End Sub
    Public Sub edit()
        uc.setCurrentUsername(current_username)
        uc.setUsername(txtusername.Text)
        uc.setFullName(txtfullname.Text)
        uc.setWorkgroup(cmbworkgroup.Text)
        uc.setPassword(sc.Encode(txtretypepassword.Text))
        uc.setStatus(IIf(cmbstatus.SelectedIndex = 0, 1, 0))
        uc.updateUser()
        ic.msgShow(panelmsg, True, lblerror, "Username " & txtusername.Text & " is now updated", True)
    End Sub
    Public Sub submit()
        Try
            uc.setUsername(txtusername.Text)
            uc.setWorkgroup(cmbworkgroup.Text)
            If String.IsNullOrEmpty(cmbworkgroup.Text) Then
                msg("Workgroups field is required", txtusername)
            ElseIf uc.checkWorkgroup() = False Then
                msg("Workgroup " & cmbworkgroup.Text & " not found", cmbworkgroup)
            ElseIf String.IsNullOrEmpty(txtusername.Text) Then
                msg("Username field is required", txtusername)
            ElseIf uc.checkUsername() And current_username <> txtusername.Text Then
                msg("Username " & txtusername.Text & " is already registered", txtusername)
            ElseIf String.IsNullOrEmpty(txtfullname.Text) Then
                msg("Full Name field is required", txtfullname)
            ElseIf String.IsNullOrEmpty(txtpassword.Text) Then
                msg("Password field is required", txtpassword)
            ElseIf txtpassword.TextLength <= 5 Then
                msg("Password field is required atleast 6 characters", txtpassword)
            ElseIf String.IsNullOrEmpty(txtretypepassword.Text) Then
                msg("Retype-Password field is required", txtretypepassword)
            ElseIf txtretypepassword.Text <> txtpassword.Text Then
                msg("Password not match", txtretypepassword)
            Else
                If lblheader.Text = "Add User" Then
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
        cmbworkgroup.SelectedIndex = 0
        cmbstatus.SelectedIndex = 0
        txtusername.Text = ""
        txtfullname.Text = ""
        txtpassword.Text = ""
        txtretypepassword.Text = ""
    End Sub
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub checkpassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkpassword.CheckedChanged
        txtpassword.UseSystemPasswordChar = IIf(checkpassword.Checked, False, True)
    End Sub

    Private Sub checkretypepassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkretypepassword.CheckedChanged
        txtretypepassword.UseSystemPasswordChar = IIf(checkretypepassword.Checked, False, True)
    End Sub

    Private Sub add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uc.filterWorkgroups(cmbworkgroup, True)
        If lblheader.Text = "Add User" Then
            cmbstatus.SelectedIndex = 0
            cmbworkgroup.SelectedIndex = 0
        Else
            uc.setUsername(txtusername.Text)
            txtpassword.Text = uc.returnPassword()
        End If
    End Sub

    Private Sub add_user_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbworkgroup_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbworkgroup.KeyDown, txtusername.KeyDown, txtretypepassword.KeyDown, txtpassword.KeyDown, txtfullname.KeyDown, cmbstatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub

    Private Sub cmbworkgroup_Leave(sender As Object, e As EventArgs) Handles cmbworkgroup.Leave
        If cmbworkgroup.Text = "" Then
            cmbworkgroup.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress, txtretypepassword.KeyPress, txtpassword.KeyPress
        If Not Char.IsControl(e.KeyChar) And Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ac.checkAccess(users.btnaddnew) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub
End Class