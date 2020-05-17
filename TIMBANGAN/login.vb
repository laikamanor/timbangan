Imports TIMBANGAN.ui_class
Imports TIMBANGAN.user_class
Imports TIMBANGAN.security_class
Public Class login
    Dim ic As New ui_class()
    Dim uc As New user_class()
    Dim sc As New security_class()
    Public Shared userid As Integer = 0
    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub
    Public Sub timerShow()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Public Sub msg(ByVal msg As String, ByVal txt As TextBox)
        ic.msgShow(panelmsg, True, lblerror, msg, False)
        txt.Focus()
        timerShow()
        txtpassword.Text = ""
    End Sub

    Public Sub submit()
        Try
            uc.setUsername(txtusername.Text)
            uc.setPassword(sc.Encode(txtpassword.Text))
            If String.IsNullOrEmpty(txtusername.Text) Then
                msg("Username field is required", txtusername)
            ElseIf String.IsNullOrEmpty(txtpassword.Text) Then
                msg("Password field is required", txtpassword)
            ElseIf uc.checkPassword() = False Then
                msg("Wrong username or password", txtusername)
            ElseIf uc.checkUsernameStatus() Then
                msg("Status of your account is In Active", txtpassword)
            ElseIf uc.checkWorkgroupUsername() Then
                msg("Workgroup of your account is In Active", txtpassword)
            Else
                Me.Hide()
                Dim frm As New main
                uc.loggedIn()
                frm.setLogID(uc.returnLogID())
                frm.setUserID(uc.returnUserID())
                userid = uc.returnUserID()
                frm.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, PictureBox1.MouseDown, Label2.MouseDown, Label1.MouseDown, Label4.MouseDown, Label3.MouseDown, panelmsg.MouseDown, lblerror.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, PictureBox1.MouseMove, Label2.MouseMove, Label1.MouseMove, Label4.MouseMove, Label3.MouseMove, panelmsg.MouseMove, lblerror.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, PictureBox1.MouseUp, Label2.MouseUp, Label1.MouseUp, Label4.MouseUp, Label3.MouseUp, panelmsg.MouseUp, lblerror.MouseUp
        ic.mouse_up()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        panelmsg.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown, txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub
End Class
