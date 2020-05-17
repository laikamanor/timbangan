Imports TIMBANGAN.ui_class
Public Class step2_viewbatch
    Dim uic As New ui_class()
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub step2_viewbatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvitems.Rows.Add("Atlantic (1st  class Flour)", "Atlantic (1st  class Flour)", CDbl(800).ToString("n2"), CDbl(809).ToString("n2"))
        dgvitems.Rows.Add("B.O.S (Butter oil Subtitute)", "B.O.S (Butter oil Subtitute)", CDbl(10).ToString("n2"), CDbl(11).ToString("n2"))
        dgvitems.Rows.Add("IFFCO/shortening", "IFFCO/shortening", CDbl(55).ToString("n2"), CDbl(59).ToString("n2"))
        dgvitems.Rows.Add("Kalabasa", "Kalabasa", CDbl(40).ToString("n2"), CDbl(42).ToString("n2"))
        dgvitems.Rows.Add("Malunggay", "Malunggay", CDbl(10).ToString("n2"), CDbl(12).ToString("n2"))
        dgvitems.Rows.Add("P 10 IN 1", "P 10 IN 1", CDbl(130).ToString("n2"), CDbl(140).ToString("n2"))
        dgvitems.Rows.Add("President  (1st Class Flour)", "President  (1st Class Flour)", CDbl(32.5).ToString("n2"), CDbl(35).ToString("n2"))
        dgvitems.Rows.Add("T3", "T3", CDbl(62.5).ToString("n2"), CDbl(70).ToString("n2"))
        dgvitems.Rows.Add("Water", "Water", CDbl(407.5).ToString("n2"), CDbl(410).ToString("n2"))
    End Sub

    Private Sub step2_viewbatch_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblinvid.MouseDown, lblheader.MouseDown, Label9.MouseDown, Label8.MouseDown, Label7.MouseDown, Label6.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, Label1.MouseDown
        uic.mouse_down(Me)
    End Sub

    Private Sub step2_viewbatch_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, lblinvid.MouseMove, lblheader.MouseMove, Label9.MouseMove, Label8.MouseMove, Label7.MouseMove, Label6.MouseMove, Label5.MouseMove, Label4.MouseMove, Label3.MouseMove, Label2.MouseMove, Label1.MouseMove
        uic.mouse_move(Me)
    End Sub

    Private Sub step2_viewbatch_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, lblinvid.MouseUp, lblheader.MouseUp, Label9.MouseUp, Label8.MouseUp, Label7.MouseUp, Label6.MouseUp, Label5.MouseUp, Label4.MouseUp, Label3.MouseUp, Label2.MouseUp, Label1.MouseUp
        uic.mouse_up()
    End Sub

    Private Sub step2_viewbatch_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class