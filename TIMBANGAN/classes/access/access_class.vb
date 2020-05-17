Imports TIMBANGAN.connections_class
Imports System.Data.SqlClient
Public Class access_class
    Dim cc As New connections_class()
    Private workgroup As String = ""
    Public ReadOnly Property getWorkgroup() As String
        Get
            Return workgroup
        End Get
    End Property
    Public Sub setWorkgroup(ByVal value As String)
        workgroup = value
    End Sub
    Public Function showAccess() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT work.workgroupid,work.name,x.module,XX.isHave FROM workgroups work OUTER APPLY(SELECT modu.module,modu.moduleid FROM modules modu WHERE modu.status=1)x OUTER APPLY(SELECT ISNULL(COUNT(acc.accessid),0)[isHave] FROM access acc WHERE acc.workgroupid = work.workgroupid AND acc.status=1 AND acc.moduleid = x.moduleid)xx WHERE work.status=1 " & IIf(workgroup = "All", "", " AND work.name=@name"), cc.con)
        If workgroup <> "All" Then
            cc.cmd.Parameters.AddWithValue("@name", workgroup)
        End If
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function

    Public Sub updateAccess(ByVal dt As DataTable)
        Try
            If dt.Rows.Count <> 0 Then
                For Each r0w As DataRow In dt.Rows
                    Dim accessid As Integer = 0, isHave As Integer = 0
                    cc.con.Open()
                    cc.cmd = New SqlCommand("SELECT ISNULL(MAX(accessid),0)[accessid] FROM access WHERE moduleid=(SELECT moduleid FROM modules WHERE module=@module) AND workgroupid=(SELECT workgroupid FROM workgroups WHERE name=@workgroup);", cc.con)
                    cc.cmd.Parameters.AddWithValue("@module", r0w("module"))
                    cc.cmd.Parameters.AddWithValue("@workgroup", r0w("workgroup"))
                    cc.rdr = cc.cmd.ExecuteReader
                    If cc.rdr.Read Then
                        accessid = cc.rdr("accessid")
                    End If
                    cc.con.Close()
                    If accessid <> 0 Then
                        cc.con.Open()
                        cc.cmd = New SqlCommand("UPDATE access SET status=@status " & IIf(r0w("isHave") = 0, ",datedeactivate=(SELECT GETDATE())", ",dateactive=(SELECT GETDATE())") & " WHERE accessid=" & accessid, cc.con)
                        cc.cmd.Parameters.AddWithValue("@status", r0w("isHave"))
                        cc.cmd.ExecuteNonQuery()
                        cc.con.Close()
                    Else
                        cc.con.Open()
                        cc.cmd = New SqlCommand("INSERT INTO access (moduleid,workgroupid,datecreated,dateactive,status) VALUES ((SELECT moduleid FROM modules WHERE module=@module),(SELECT workgroupid FROM workgroups WHERE name=@workgroup),(SELECT GETDATE()), (SELECT GETDATE()),@status)", cc.con)
                        cc.cmd.Parameters.AddWithValue("@module", r0w("module"))
                        cc.cmd.Parameters.AddWithValue("@workgroup", r0w("workgroup"))
                        cc.cmd.Parameters.AddWithValue("@status", r0w("isHave"))
                        cc.cmd.ExecuteNonQuery()
                        cc.con.Close()
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Function checkAccess(ByVal cntrl As Control) As Boolean
        Dim result As Boolean = False, result_int As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT xx.isHave FROM workgroups work OUTER APPLY(SELECT modu.module,modu.moduleid FROM modules modu WHERE modu.status=1 AND modu.module=@modulename)x OUTER APPLY(SELECT ISNULL(COUNT(acc.accessid),0)[isHave] FROM access acc WHERE acc.workgroupid = work.workgroupid AND acc.status=1 AND acc.moduleid = x.moduleid)xx WHERE work.status=1 AND work.workgroupid=(SELECT workgroup_id FROM users WHERE userid=@userid);", cc.con)
        cc.cmd.Parameters.AddWithValue("@modulename", IIf(cntrl.Name = "dgv", "Edit", cntrl.Text))
        cc.cmd.Parameters.AddWithValue("@userid", login.userid)
        result_int = cc.cmd.ExecuteScalar
        cc.con.Close()
        result = IIf(result_int = 1, False, True)
        Return result
    End Function

    Public Sub createModuleAccess()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("createModuleAccess", cc.con)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.Parameters.AddWithValue("@userid", login.userid)
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function checkModuleAccess() As Boolean
        Dim result_num As Integer = 0, result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.checkModuleAccess()", cc.con)
        result_num = cc.cmd.ExecuteScalar()
        cc.con.Close()
        result = IIf(result_num = 1, True, False)
        Return result
    End Function

End Class
