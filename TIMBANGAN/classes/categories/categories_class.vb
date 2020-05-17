Imports TIMBANGAN.connections_class
Imports TIMBANGAN.security_class
Imports System.Data.SqlClient
Public Class categories_class
    Private category As String = "", status As Integer = 0, current_category As String = ""
    Dim cc As New connections_class(), sc As New security_class()
    Dim transaction As SqlTransaction
    'setter and getter
    Public ReadOnly Property getCategory() As String
        Get
            Return category
        End Get
    End Property
    Public Sub setCategory(ByVal value As String)
        category = value
    End Sub
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub
    Public ReadOnly Property getCurrentCategory() As String
        Get
            Return current_category
        End Get
    End Property
    Public Sub setCurrentCategory(ByVal value As String)
        current_category = value
    End Sub
    Public Function checkCategory() As Boolean
        Dim result_num As Integer = 0, result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.checkCategory(@category)", cc.con)
        cc.cmd.Parameters.AddWithValue("@category", category)
        result_num = cc.cmd.ExecuteScalar()
        cc.con.Close()
        result = IIf(result_num = 1, True, False)
        Return result
    End Function

    Public Sub addCategory()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("insertCategory", cc.con)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.Parameters.AddWithValue("@createdby", 1)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.Parameters.AddWithValue("@catname", category)
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub updateCategory()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("updateCategory", cc.con)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.Parameters.AddWithValue("@current_category", current_category)
            cc.cmd.Parameters.AddWithValue("@category", category)
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Function showCategories() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT category,status FROM categories WHERE category LIKE '%" & category & "%' AND status='" & status & "';", cc.con)
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function
    Public Sub addImportCategory(ByVal dt As DataTable)
        Try
            Using connection As New SqlConnection(sc.Decode(System.IO.File.ReadAllText("connectionstring.txt")))
                Dim command As New SqlCommand()
                command.Connection = connection
                connection.Open()
                transaction = connection.BeginTransaction()
                command.Transaction = transaction
                For Each r0w As DataRow In dt.Rows
                    command.Parameters.Clear()
                    command.CommandText = "INSERT INTO categories (category,status,datecreated,userid) VALUES (@catname,@status,(SELECT GETDATE())," & login.userid & ")"
                    command.Parameters.AddWithValue("@catname", r0w("category"))
                    command.Parameters.AddWithValue("@status", IIf(r0w("status") = "Active", 1, 0))
                    command.ExecuteNonQuery()
                Next
                transaction.Commit()
            End Using
            MessageBox.Show("Import Success", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MessageBox.Show(ex2.ToString)
            End Try
        End Try
    End Sub
End Class
