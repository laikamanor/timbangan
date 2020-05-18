Imports TIMBANGAN.connections_class
Imports TIMBANGAN.security_class
Imports System.Data.SqlClient
Public Class formula_class
    Dim cc As New connections_class(), sc As New security_class()
    Private category As String = "", formulaNumber As String = "", itemname As String = "", product As String = "", price As Double = 0.00, basewt As Double = 0.00, status As Integer = 0,
        tdw As Double = 0.00, unbaked As Double = 0.00, baked As Double = 0.00, yield As Double = 0.00, palaman As String = ""
    Dim transaction As SqlTransaction
    Public ReadOnly Property getCategory() As String
    Get
            Return category
        End Get
    End Property
    Public Sub setCategory(ByVal value As String)
        category = value
    End Sub
    Public ReadOnly Property getFormulaNumber() As String
        Get
            Return formulaNumber
        End Get
    End Property
    Public Sub setFormulaNumber(ByVal value As String)
        formulaNumber = value
    End Sub
    Public ReadOnly Property getItem() As String
        Get
            Return itemname
        End Get
    End Property
    Public Sub setItem(ByVal value As String)
        itemname = value
    End Sub
    Public ReadOnly Property getProduct() As String
        Get
            Return product
        End Get
    End Property
    Public Sub setProduct(ByVal value As String)
        product = value
    End Sub
    Public ReadOnly Property getPrice() As Double
        Get
            Return price
        End Get
    End Property
    Public Sub setPrice(ByVal value As Double)
        price = value
    End Sub
    Public ReadOnly Property getBaseWT() As Double
        Get
            Return basewt
        End Get
    End Property
    Public Sub setBaseWT(ByVal value As Double)
        basewt = value
    End Sub
    Public ReadOnly Property getTDW() As Double
        Get
            Return tdw
        End Get
    End Property
    Public Sub setTDW(ByVal value As Double)
        tdw = value
    End Sub
    Public ReadOnly Property getUnBaked() As Double
        Get
            Return unbaked
        End Get
    End Property
    Public Sub setUnBaked(ByVal value As Double)
        unbaked = value
    End Sub
    Public ReadOnly Property getBaked() As Double
        Get
            Return baked
        End Get
    End Property
    Public Sub setBaked(ByVal value As Double)
        baked = value
    End Sub
    Public ReadOnly Property getYield() As Double
        Get
            Return yield
        End Get
    End Property
    Public Sub setYield(ByVal value As Double)
        yield = value
    End Sub
    Public Sub setPalaman(ByVal value As String)
        palaman = value
    End Sub
    Public ReadOnly Property getPalman() As String
        Get
            Return palaman
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub filterProducts(ByVal cmb As ComboBox, ByVal isAdd As Boolean)
        Try
            cmb.Items.Clear()
            If isAdd = False Then
                cmb.Items.Add("All")
            End If
            cc.con.Open()
            Dim auto As New AutoCompleteStringCollection()
            cc.cmd = New SqlClient.SqlCommand("SELECT product FROM products WHERE status=1 AND catid=(SELECT catid FROM categories WHERE category=@category) ORDER BY product ASC", cc.con)
            cc.cmd.Parameters.AddWithValue("@category", category)
            cc.rdr = cc.cmd.ExecuteReader
            While cc.rdr.Read
                cmb.Items.Add(cc.rdr("product"))
                auto.Add(cc.rdr("product"))
            End While
            cc.con.Close()
            cmb.AutoCompleteCustomSource = auto
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub

    Public Sub filterItems(ByVal cmb As ComboBox, ByVal isAdd As Boolean, uom As TextBox)
        Try
            cmb.Items.Clear()
            If isAdd = False Then
                cmb.Items.Add("All")
            End If
            cc.con.Open()
            Dim auto As New AutoCompleteStringCollection()
            cc.cmd = New SqlClient.SqlCommand("SELECT itemname,description,uom FROM items WHERE status=1 AND catid=(SELECT catid FROM categories WHERE category=@category) ORDER BY itemname ASC", cc.con)
            cc.cmd.Parameters.AddWithValue("@category", category)
            cc.rdr = cc.cmd.ExecuteReader
            While cc.rdr.Read
                cmb.Items.Add(cc.rdr("itemname"))
                uom.Text = cc.rdr("uom")
                auto.Add(cc.rdr("itemname"))
            End While
            cc.con.Close()
            cmb.AutoCompleteCustomSource = auto
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub

    Public Function checkItems() As Boolean
        Dim result_num As Integer = 0, result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT dbo.checkItem(@item,@category)", cc.con)
        cc.cmd.Parameters.AddWithValue("@item", itemname)
        cc.cmd.Parameters.AddWithValue("@category", category)
        result_num = cc.cmd.ExecuteScalar()
        cc.con.Close()
        result = IIf(result_num = 1, True, False)
        Return result
    End Function

    Public Sub addFormula(ByVal dt1 As DataTable, ByVal dt2 As DataTable)
        Try
            Using connection As New SqlConnection(sc.Decode(System.IO.File.ReadAllText("connectionstring.txt")))
                Dim command As New SqlCommand()
                command.Connection = connection
                connection.Open()
                transaction = connection.BeginTransaction()
                command.Transaction = transaction
                command.CommandText = "insertFormula"
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@formnum", formulaNumber))
                command.Parameters.Add(New SqlParameter("@product", product))
                command.Parameters.Add(New SqlParameter("@price", price))
                command.Parameters.Add(New SqlParameter("@basewt", basewt))
                command.Parameters.Add(New SqlParameter("@tdw", tdw))
                command.Parameters.Add(New SqlParameter("@unbaked", unbaked))
                command.Parameters.Add(New SqlParameter("@baked", baked))
                command.Parameters.Add(New SqlParameter("@yield", yield))
                command.Parameters.Add(New SqlParameter("@userid", login.userid))
                command.ExecuteNonQuery()
                If dt1.Rows.Count <> 0 Then
                    For Each r0w As DataRow In dt1.Rows
                        command.Parameters.Clear()
                        command.CommandText = "insertFormulaItems"
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.Add(New SqlParameter("@item", r0w("item")))
                        command.Parameters.Add(New SqlParameter("@value", r0w("value")))
                        command.Parameters.Add(New SqlParameter("@userid", login.userid))
                        command.ExecuteNonQuery()
                    Next
                End If
                If dt2.Rows.Count <> 0 Then
                    For Each r0w As DataRow In dt2.Rows
                        command.Parameters.Clear()
                        command.CommandText = "insertFormulaPalaman"
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.Add(New SqlParameter("@palaman", palaman.Replace("Palaman: ", "")))
                        command.Parameters.Add(New SqlParameter("@item", r0w("item")))
                        command.Parameters.Add(New SqlParameter("@value", r0w("value")))
                        command.Parameters.Add(New SqlParameter("@userid", login.userid))
                        command.ExecuteNonQuery()
                    Next
                End If
                transaction.Commit()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Try
                transaction.Rollback()
            Catch ex2 As Exception

            End Try
        End Try

    End Sub

    Public Function returnFormulaNumber() As String
        Dim result As Integer = 0, totalZero As String = "", result_format As String = ""
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT ISNULL(MAX(formulaid),0)+1 FROM formulas;", cc.con)
        result = cc.cmd.ExecuteScalar
        cc.con.Close()

        If result < 1000000 Then
            Dim cselectcount_result As String = CStr(result)
            For temp As Integer = 0 To 6 - cselectcount_result.Length
                totalZero += "0"
            Next
            result_format = "Formula - " & totalZero & result
        Else
            result_format = "Formula - " & totalZero & result
        End If
        Return result_format
    End Function

    Public Function checkProductFormula() As Boolean
        Dim result As Boolean = False, result_int As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT dbo.checkProductFormula(@product,@status);", cc.con)
        cc.cmd.Parameters.AddWithValue("@product", product)
        cc.cmd.Parameters.AddWithValue("@status", status)
        result_int = cc.cmd.ExecuteScalar
        cc.con.Close()
        result = IIf(result_int = 1, True, False)
        Return result
    End Function

    Public Function showFormulas() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT a.formulaid AS id,b.product,c.category FROM formulas a INNER JOIN products b ON a.productid = b.productid INNER JOIN categories c ON b.catid = c.catid WHERE c.status=1 AND b.status=1 AND a.status=" & status & " AND b.product LIKE '%" & product & "%'" & IIf(category = "All", ";", " AND c.category='" & category & "';"), cc.con)
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function
    Public Function cellClickProducts(ByVal id As Integer) As DataTable
        Dim dt As New DataTable()
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT b.product,a.price,a.tdw,a.unbaked,a.baked,a.yield,a.basewt,formula_number FROM formulas a INNER JOIN products b ON a.productid = b.productid WHERE a.formulaid=" & id & ";", cc.con)
        Dim adptr As New SqlClient.SqlDataAdapter()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function
    Public Function cellClickItems(ByVal id As Integer, tableName As String) As DataTable
        Dim dt As New DataTable()
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT c.category,b.itemname,a.value,b.uom,a.formula_itemid,b.itemid FROM " & tableName & " a INNER JOIN items b ON a.itemid = b.itemid INNER JOIN categories c ON b.catid = c.catid WHERE a.formulaid=" & id & " ORDER BY b.itemname;", cc.con)
        Dim adptr As New SqlClient.SqlDataAdapter()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function

    Public Sub updateFormulaStatus(ByVal currentFormulaID As Integer)
        Dim formulaid_active As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT dbo.funcgetFormulaActiveStatus(@itemname)", cc.con)
        cc.cmd.Parameters.AddWithValue("@itemname", product)
        formulaid_active = cc.cmd.ExecuteScalar
        cc.con.Close()

        Try
            Using connection As New SqlConnection(sc.Decode(System.IO.File.ReadAllText("connectionstring.txt")))
                Dim command As New SqlCommand()
                command.Connection = connection
                connection.Open()
                transaction = connection.BeginTransaction()
                command.Transaction = transaction

                command.Parameters.Clear()
                command.CommandText = "UPDATE formulas SET status=0,userid_modified=@userid,datemodified=(SELECT GETDATE()) WHERE formulaid=@id"
                command.Parameters.AddWithValue("@id", formulaid_active)
                command.Parameters.AddWithValue("@userid", login.userid)
                command.ExecuteNonQuery()

                If currentFormulaID <> 0 Then
                    command.Parameters.Clear()
                    command.CommandText = "UPDATE formulas SET status=1,userid_modified=@userid,datemodified=(SELECT GETDATE()) WHERE formulaid=@id"
                    command.Parameters.AddWithValue("@id", currentFormulaID)
                    command.Parameters.AddWithValue("@userid", login.userid)
                    command.ExecuteNonQuery()
                End If

                transaction.Commit()

                If currentFormulaID <> 0 Then
                    MessageBox.Show("Formula Updated", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MessageBox.Show(ex2.ToString)
            End Try
        End Try
    End Sub
End Class
