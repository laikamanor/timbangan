Imports TIMBANGAN.ui_class
Imports TIMBANGAN.user_class
Imports TIMBANGAN.access_class
Public Class main
    Dim ic As New ui_class()
    Dim uc As New user_class()
    Dim ac As New access_class()
    Dim toggle_max As Boolean = True
    Private logid As Integer = 0, userid As Integer = 0
    Public Shared checkAccessValue As Boolean = False
    Public ReadOnly Property getLogID() As Integer
        Get
            Return logid
        End Get
    End Property
    Public Sub setLogID(ByVal value As Integer)
        logid = value
    End Sub
    Public ReadOnly Property getUserID() As Integer
        Get
            Return userid
        End Get
    End Property
    Public Sub setUserID(ByVal value As Integer)
        userid = value
    End Sub

    Private Sub btnsetup_Click_1(sender As Object, e As EventArgs) Handles btnsetup.Click
        panelsubsetup.Visible = IIf(panelsubsetup.Visible = True, False, True)
    End Sub

    Private Sub btnformula_Click(sender As Object, e As EventArgs) Handles btnformula.Click
        panelformula.Visible = IIf(panelformula.Visible = True, False, True)
    End Sub

    Private Sub btnsteps_Click(sender As Object, e As EventArgs) Handles btnsteps.Click
        panelsteps.Visible = IIf(panelsteps.Visible = True, False, True)
    End Sub

    Private Sub btnusers_Click(sender As Object, e As EventArgs) Handles btnusers.Click
        panelusers.Visible = IIf(panelusers.Visible = True, False, True)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim a As String = MsgBox("Are you sure you want to log out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "")
        If a = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btncategory_Click(sender As Object, e As EventArgs) Handles btncategory.Click
        checkAccess(btncategory.Name)
        If checkAccessValue = False Then
            Dim f As New categories()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub panelnav_MouseDown(sender As Object, e As MouseEventArgs) Handles panelnav.MouseDown, MyBase.MouseDown
        ic.mouse_down(Me)
    End Sub

    Private Sub panelnav_MouseMove(sender As Object, e As MouseEventArgs) Handles panelnav.MouseMove, MyBase.MouseMove
        ic.mouse_move(Me)
    End Sub

    Private Sub panelnav_MouseUp(sender As Object, e As MouseEventArgs) Handles panelnav.MouseUp, MyBase.MouseUp
        ic.mouse_up()
    End Sub

    Private Sub btnfullscreen_Click(sender As Object, e As EventArgs) Handles btnfullscreen.Click
        If toggle_max Then
            Me.WindowState = FormWindowState.Maximized
            toggle_max = False
        Else
            toggle_max = True
            Me.WindowState = FormWindowState.Normal
        End If
        Me.panelbody.Dock = DockStyle.Fill
    End Sub

    Private Sub btnitems_Click(sender As Object, e As EventArgs) Handles btnitems.Click
        checkAccess(btnitems.Name)
        If checkAccessValue = False Then
            Dim f As New items()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub btnproducts_Click(sender As Object, e As EventArgs) Handles btnproducts.Click
        checkAccess(btnproducts.Name)
        If checkAccessValue = False Then
            Dim f As New products()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub btnmanageformula_Click(sender As Object, e As EventArgs) Handles btnmanageformula.Click
        checkAccess(btnmanageformula.Name)
        If checkAccessValue = False Then
            Dim f As New formulas()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub profilepic_Click(sender As Object, e As EventArgs) Handles profilepic.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Open a Picture File"
        OpenFileDialog1.Filter = "Picture File|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            profilepic.ImageLocation = OpenFileDialog1.FileName
        End If
        uc.changeUserIcon(profilepic)
    End Sub

    Private Sub btnmanageusers_Click(sender As Object, e As EventArgs) Handles btnmanageusers.Click
        checkAccess(btnmanageusers.Name)
        If checkAccessValue = False Then
            Dim f As New users()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub btnworkgroups_Click(sender As Object, e As EventArgs) Handles btnworkgroups.Click
        checkAccess(btnworkgroups.Name)
        If checkAccessValue = False Then
            Dim f As New workgroups()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Public Sub loadUserInformation()
        Try
            uc.setUserID(userid)
            Dim dt As New DataTable()
            dt = uc.showUserInformation()
            For Each r0w As DataRow In dt.Rows
                lblname.Text = r0w("fullname")
                lblworkgroup.Text = r0w("workgroup")
                Dim tooltip As New ToolTip(components)
                tooltip.SetToolTip(lblworkgroup, r0w("description"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserInformation()
        If lblworkgroup.Text = "Developer" Then
            btnaddaccess.Visible = True
        Else
            btnaddaccess.Visible = False
        End If
        profilepic.Image = uc.loadUserIcon().Image
    End Sub

    Private Sub main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        uc.loggedOut(logid)
        Dim frm As New login()
        Me.Hide()
        frm.ShowDialog()
    End Sub

    Private Sub btnmodules_Click(sender As Object, e As EventArgs) Handles btnmodules.Click
        checkAccess(btnmodules.Name)
        If checkAccessValue = False Then
            Dim f As New modules()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub lblmsgclose_Click(sender As Object, e As EventArgs) Handles lblmsgclose.Click
        panelmsg.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub btnaccess_Click(sender As Object, e As EventArgs) Handles btnaccess.Click
        checkAccess(btnaccess.Name)
        If checkAccessValue = False Then
            Dim f As New access()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub
    Public Sub checkAccess(ByVal btnName As String)
        checkAccessValue = False
        Dim btnn As Button = Me.Controls.Find(btnName, True).FirstOrDefault()
        If ac.checkAccess(btnn) Then
            ic.msgShow(panelmsg, True, lblerror, "You have no permission to access " & btnn.Text, False)
            checkAccessValue = True
        Else
            checkAccessValue = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        panelmsg.Visible = False
        Timer2.Enabled = False
        Timer2.Stop()
    End Sub

    Public Sub timerShow()
        Timer2.Enabled = True
        Timer2.Start()
    End Sub
    Public Sub msg(ByVal msg As String, ByVal txt As TextBox)
        ic.msgShow(panelmsg, True, lblerror, msg, False)
        txt.Focus()
        timerShow()
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        checkAccess(btndashboard.Name)
    End Sub

    Private Sub btnstep1_Click(sender As Object, e As EventArgs) Handles btnstep1.Click
        checkAccess(btnmanageformula.Name)
        If checkAccessValue = False Then
            Dim f As New step1()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub btnstep2_Click(sender As Object, e As EventArgs) Handles btnstep2.Click
        checkAccess(btnstep2.Name)
        If checkAccessValue = False Then
            Dim f As New step2()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub btnstep3_Click(sender As Object, e As EventArgs) Handles btnstep3.Click
        checkAccess(btnstep3.Name)
        If checkAccessValue = False Then
            Dim f As New step3()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub

    Private Sub btnstep4_Click(sender As Object, e As EventArgs) Handles btnstep4.Click
        checkAccess(btnstep4.Name)
    End Sub

    Private Sub btnaddaccess_Click(sender As Object, e As EventArgs) Handles btnaddaccess.Click
        If ac.checkModuleAccess() Then
            ic.msgShow(panelmsg, True, lblerror, "Module Access is already registered", False)
        Else
            ac.createModuleAccess()
        End If
    End Sub

    Private Sub btnlock_Click(sender As Object, e As EventArgs) Handles btnlock.Click
        panelbody.Enabled = IIf(panelbody.Enabled = True, False, True)
        Panel1.Enabled = IIf(Panel1.Enabled = True, False, True)
    End Sub

    Private Sub btnloginlogs_Click(sender As Object, e As EventArgs) Handles btnloginlogs.Click
        checkAccess(btnloginlogs.Name)
        If checkAccessValue = False Then
            Dim f As New login_logs()
            f.TopLevel = False
            f.Dock = DockStyle.Fill
            panelbody.Controls.Add(f)
            f.BringToFront()
            f.Show()
        End If
    End Sub
End Class