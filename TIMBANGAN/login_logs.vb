Imports TIMBANGAN.user_class
Imports TIMBANGAN.access_class
Public Class login_logs
    Dim uc As New user_class(), ac As New access_class()

    Public Sub loadLogs()
        Try
            uc.setDateCreated(dtdate.Text)
            uc.setUsername(txtsearch.Text)
            Dim dt As New DataTable(), auto As New AutoCompleteStringCollection()
            dt = uc.showLoginLogs()
            dgv.Rows.Clear()
            For Each r0w As DataRow In dt.Rows
                auto.Add(r0w("username"))
                dgv.Rows.Add(r0w("username"), CDate(r0w("login")).ToString("hh:mm tt"), CDate(r0w("logout")).ToString("hh:mm tt"))
            Next
            txtsearch.AutoCompleteCustomSource = auto
            lblnodata.Visible = IIf(dgv.Rows.Count = 0, True, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub login_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLogs()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtdate.ValueChanged
        loadLogs()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadLogs()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadLogs()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ac.checkAccess(main.btnloginlogs) Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub
End Class