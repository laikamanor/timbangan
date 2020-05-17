Imports TIMBANGAN.connections_class
Imports TIMBANGAN.security_class
Imports System.Data.SqlClient
Public Class items_class
    Dim cc As New connections_class(), sc As New security_class()
    Private category As String = "", itemname As String = "", description As String = "", uom As String = "", catid As Integer = 0, status As Integer = 0, current_itemname As String = ""
    Dim transaction As SqlTransaction
    Public ReadOnly Property getCategory() As String
        Get
            Return category
        End Get
    End Property
    Public ReadOnly Property getItemname() As String
        Get
            Return itemname
        End Get
    End Property
    Public Sub setItemName(ByVal value As String)
        itemname = value
    End Sub
    Public ReadOnly Property getDescription() As String
        Get
            Return description
        End Get
    End Property
    Public Sub setDescription(ByVal value As String)
        description = value
    End Sub
    Public ReadOnly Property getUOM() As String
        Get
            Return uom
        End Get
    End Property
    Public Sub setUOM(ByVal value As String)
        uom = value
    End Sub
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub
    Public ReadOnly Property getCurrentItemName() As String
        Get
            Return current_itemname
        End Get
    End Property
    Public Sub setCurrentItemName(ByVal value As String)
        current_itemname = value
    End Sub
    Public Sub setCategory(ByVal value As String)
        category = value
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT catid FROM categories WHERE category=@category", cc.con)
        cc.cmd.Parameters.AddWithValue("@category", value)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            catid = cc.rdr("catid")
        End If
        cc.con.Close()
    End Sub
    Public Sub filterCategories(ByVal cmb As ComboBox, ByVal isAdd As Boolean)
        Try
            cmb.Items.Clear()
            If isAdd = False Then
                cmb.Items.Add("All")
            End If
            cc.con.Open()
            Dim auto As New AutoCompleteStringCollection()
            cc.cmd = New SqlClient.SqlCommand("SELECT category FROM categories WHERE status=1 ORDER BY category ASC", cc.con)
            cc.rdr = cc.cmd.ExecuteReader
            While cc.rdr.Read
                cmb.Items.Add(cc.rdr("category"))
                auto.Add(cc.rdr("category"))
            End While
            cc.con.Close()
            cmb.AutoCompleteCustomSource = auto
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
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
    Public Function checkItemName() As Boolean
        Dim result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT itemid FROM items WHERE itemname=@itemname", cc.con)
        cc.cmd.Parameters.AddWithValue("@itemname", itemname)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            result = True
        End If
        cc.con.Close()
        Return result
    End Function
    Public Sub insertItem()
        Try
            cc.con.Open()
            cc.cmd = New SqlClient.SqlCommand("insertItem", cc.con)
            cc.cmd.Parameters.AddWithValue("@catid", catid)
            cc.cmd.Parameters.AddWithValue("@itemname", itemname)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@uom", uom)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub updateItem()
        Try
            cc.con.Open()
            cc.cmd = New SqlClient.SqlCommand("updateItem", cc.con)
            cc.cmd.Parameters.AddWithValue("@catid", catid)
            cc.cmd.Parameters.AddWithValue("@current_itemname", current_itemname)
            cc.cmd.Parameters.AddWithValue("@itemname", itemname)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@uom", uom)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Function readItems(ByVal cmb As ComboBox) As DataTable
        Dim dt As New DataTable()
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT b.category ,a.itemname,a.description,a.uom,a.status FROM items a INNER JOIN categories b ON a.catid = b.catid WHERE a.status=" & status & " AND a.itemname LIKE '%" & itemname & "%'" & IIf(category = "All", ";", " AND b.catid=@category"), cc.con)
        If category <> "All" Then
            cc.cmd.Parameters.AddWithValue("@category", catid)
        End If
        Dim adptr As New SqlClient.SqlDataAdapter()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function

    Public Sub addImportItem(ByVal dt As DataTable)
        Try
            Using connection As New SqlConnection(sc.Decode(System.IO.File.ReadAllText("connectionstring.txt")))
                Dim command As New SqlCommand()
                command.Connection = connection
                connection.Open()
                transaction = connection.BeginTransaction()
                command.Transaction = transaction
                For Each r0w As DataRow In dt.Rows
                    setCategory(r0w("category"))
                    command.Parameters.Clear()
                    command.CommandText = "INSERT INTO items (catid,itemname,description,uom,status,datecreated,userid) VALUES (" & catid & ",@itemname,@description,@uom,@status,(SELECT GETDATE())," & login.userid & ")"
                    command.Parameters.AddWithValue("@itemname", r0w("itemname"))
                    command.Parameters.AddWithValue("@description", r0w("description"))
                    command.Parameters.AddWithValue("@uom", r0w("uom"))
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
