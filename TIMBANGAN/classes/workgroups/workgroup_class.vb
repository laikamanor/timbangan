Imports TIMBANGAN.connections_class
Imports System.Data.SqlClient
Public Class workgroup_class
    Dim cc As New connections_class()
    Private current_workgroup As String = "", workgroup As String = "", description As String = "", userid As Integer = 0, status As Integer = 0
    Public ReadOnly Property getCurentWorkgroup() As String
        Get
            Return current_workgroup
        End Get
    End Property
    Public Sub setCurentWorkgroup(ByVal value As String)
        current_workgroup = value
    End Sub
    Public ReadOnly Property getWorkgroup() As String
        Get
            Return workgroup
        End Get
    End Property
    Public Sub setWorkgroup(ByVal value As String)
        workgroup = value
    End Sub
    Public ReadOnly Property getDescription() As String
        Get
            Return description
        End Get
    End Property
    Public Sub setDescription(ByVal value As String)
        description = value
    End Sub
    Public ReadOnly Property getUserID() As Integer
        Get
            Return userid
        End Get
    End Property
    Public Sub setUserID(ByVal value As Integer)
        userid = value
    End Sub
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub
    Public Function checkWorkgroup() As Boolean
        Dim result_num As Integer = 0, result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.checkWorkgroup(@workgroup)", cc.con)
        cc.cmd.Parameters.AddWithValue("@workgroup", workgroup)
        result_num = cc.cmd.ExecuteScalar()
        cc.con.Close()
        result = IIf(result_num = 1, True, False)
        Return result
    End Function

    Public Sub addWorkgroup()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("insertWorkgroup", cc.con)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.Parameters.AddWithValue("@workgroup", workgroup)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@userid", userid)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub

    Public Function showWorkgroups() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT name,description,status FROM workgroups WHERE name LIKE '%" & workgroup & "%' AND status=" & status & ";", cc.con)
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function

    Public Function getWorkgroupID() As Integer
        Dim result As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT workgroupid FROM workgroups WHERE name=@name;", cc.con)
        cc.cmd.Parameters.AddWithValue("@name", current_workgroup)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            result = CInt(cc.rdr("workgroupid"))
        End If
        cc.con.Close()
        Return result
    End Function

    Public Sub updateWorkgroup()
        Try
            Dim result As Integer = getWorkgroupID()
            cc.con.Open()
            cc.cmd = New SqlCommand("updateWorkgroup", cc.con)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.Parameters.AddWithValue("@workgroup", workgroup)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.Parameters.AddWithValue("@workgroupid", result)
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub

End Class
