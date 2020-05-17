Imports System.Data.SqlClient
Public Class ui_class
    Dim cc As New connections_class()
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim errorColor As Color = Color.FromArgb(228, 0, 0)
    Dim successColor As Color = Color.FromArgb(52, 168, 83)
    Dim brandColor As Color = Color.FromArgb(76, 209, 149)
    Public Sub mouse_down(ByVal frm As Form)
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - frm.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - frm.Top 'Sets variable mousey
    End Sub
    Public Sub mouse_move(ByVal frm As Form)
        'If drag is set to true then move the form accordingly.
        If drag Then
            frm.Top = Windows.Forms.Cursor.Position.Y - mousey
            frm.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Public Sub mouse_up()
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub
    Public Sub msgShow(ByVal pnl As Panel, ByVal isShow As Boolean, ByVal lbl As Control, ByVal msg As String, ByVal typeMsg As Boolean)
        pnl.Visible = isShow
        pnl.BackColor = IIf(typeMsg = True, successColor, errorColor)
        lbl.ForeColor = Color.White
        lbl.Text = msg
    End Sub

End Class
