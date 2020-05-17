Imports System.Data.SqlClient
Imports TIMBANGAN.connections_class
Public Class modules_class
    Dim cc As New connections_class()
    Private current_module_name As String = "", module_name As String = "", description As String = "",
        userid As Integer = 0, status As Integer = 0
    'getter and setter
    Public ReadOnly Property getCurrentModuleName() As String
        Get
            Return current_module_name
        End Get
    End Property
    Public Sub setCurrentModuleName(ByVal value As String)
        current_module_name = value
    End Sub
    Public ReadOnly Property getModuleName() As String
        Get
            Return module_name
        End Get
    End Property
    Public Sub setModuleName(ByVal value As String)
        module_name = value
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
    Public Function checkModule() As Boolean
        Dim result_int As Integer = 0, result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.checkModuleName(@module)", cc.con)
        cc.cmd.Parameters.AddWithValue("@module", module_name)
        result_int = cc.cmd.ExecuteScalar
        cc.con.Close()
        result = IIf(result_int = 1, True, False)
        Return result
    End Function

    Public Sub insertModule()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("insertModule", cc.con)
            cc.cmd.Parameters.AddWithValue("@module", module_name)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@userid", userid)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub

    Public Sub updateModule()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("updateModule", cc.con)
            cc.cmd.Parameters.AddWithValue("@current_module", current_module_name)
            cc.cmd.Parameters.AddWithValue("@module", module_name)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function showModules() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT module,description,status FROM modules WHERE module LIKE @module AND status=" & status & ";", cc.con)
        cc.cmd.Parameters.AddWithValue("@module", "%" & module_name & "%")
        cc.cmd.Parameters.AddWithValue("@status", status)
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function
End Class
