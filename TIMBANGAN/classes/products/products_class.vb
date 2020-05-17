Imports TIMBANGAN.connections_class
Imports TIMBANGAN.security_class
Imports System.Data.SqlClient
Public Class products_class
    Dim cc As New connections_class(), sc As New security_class()
    Private category As String = "", current_product_name As String = "", product_name As String = "", description As String = "", status As Integer = 0
    Dim transaction As SqlTransaction
    Public ReadOnly Property getCategory() As String
        Get
            Return category
        End Get
    End Property
    Public Sub setCategory(ByVal value As String)
        category = value
    End Sub
    Public ReadOnly Property getCurrentProductName() As String
        Get
            Return current_product_name
        End Get
    End Property
    Public Sub setCurrentProductName(ByVal value As String)
        current_product_name = value
    End Sub
    Public ReadOnly Property getProductName() As String
        Get
            Return product_name
        End Get
    End Property
    Public Sub setProductName(ByVal value As String)
        product_name = value
    End Sub
    Public ReadOnly Property getDescription() As String
        Get
            Return description
        End Get
    End Property
    Public Sub setDescription(ByVal value As String)
        description = value
    End Sub
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub

    Public Function checkProduct() As Boolean
        Dim result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT productid FROM products WHERE product=@itemname", cc.con)
        cc.cmd.Parameters.AddWithValue("@itemname", product_name)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            result = True
        End If
        cc.con.Close()
        Return result
    End Function

    Public Sub insertProduct()
        Try
            cc.con.Open()
            cc.cmd = New SqlClient.SqlCommand("insertProduct", cc.con)
            cc.cmd.Parameters.AddWithValue("@category", category)
            cc.cmd.Parameters.AddWithValue("@product", product_name)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@userid", login.userid)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub updateProduct()
        Try
            cc.con.Open()
            cc.cmd = New SqlClient.SqlCommand("updateProduct", cc.con)
            cc.cmd.Parameters.AddWithValue("@category", category)
            cc.cmd.Parameters.AddWithValue("@current_product", current_product_name)
            cc.cmd.Parameters.AddWithValue("@product", product_name)
            cc.cmd.Parameters.AddWithValue("@description", description)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public Function readProducts(ByVal cmb As ComboBox) As DataTable
        Dim dt As New DataTable()
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT b.category ,a.product,a.description,a.status FROM products a INNER JOIN categories b ON a.catid = b.catid WHERE a.status=" & status & " AND a.product LIKE '%" & product_name & "%'" & IIf(category = "All", ";", " AND b.category=@category"), cc.con)
        If category <> "All" Then
            cc.cmd.Parameters.AddWithValue("@category", category)
        End If
        Dim adptr As New SqlClient.SqlDataAdapter()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function

    Public Sub addImportProduct(ByVal dt As DataTable)
        Try
            Using connection As New SqlConnection(sc.Decode(System.IO.File.ReadAllText("connectionstring.txt")))
                Dim command As New SqlCommand()
                command.Connection = connection
                connection.Open()
                transaction = connection.BeginTransaction()
                command.Transaction = transaction
                For Each r0w As DataRow In dt.Rows
                    command.Parameters.Clear()
                    command.CommandText = "INSERT INTO products (catid,product,description,status,datecreated,userid) VALUES ((SELECT catid FROM categories WHERE category=@category),@product,@description,@status,(SELECT GETDATE())," & login.userid & ")"
                    command.Parameters.AddWithValue("@product", r0w("product"))
                    command.Parameters.AddWithValue("@category", r0w("category"))
                    command.Parameters.AddWithValue("@description", r0w("description"))
                    command.Parameters.AddWithValue("@status", IIf(r0w("status") = "Active", 1, 0))
                    command.ExecuteNonQuery()
                Next
                transaction.Commit()
            End Using
            MessageBox.Show("Import Success", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End Try
    End Sub

End Class
