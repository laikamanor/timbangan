Imports TIMBANGAN.connections_class
Imports System.Data.SqlClient
Public Class step2_class
    Dim cc As New connections_class, transaction As SqlTransaction
    Private status As Integer = 0, datecreated As DateTime, category As String = "", product As String = "", step1id As Integer = 0, formulaid As Integer = 0, step2num As String = "", quantity As Double = 0.00
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub
    Public ReadOnly Property getDateCreated() As DateTime
        Get
            Return datecreated
        End Get
    End Property
    Public Sub setDateCreated(ByVal value As DateTime)
        datecreated = value
    End Sub
    Public ReadOnly Property getCategory() As String
        Get
            Return category
        End Get
    End Property
    Public Sub setCategory(ByVal value As String)
        category = value
    End Sub
    Public ReadOnly Property getProduct() As String
        Get
            Return product
        End Get
    End Property
    Public Sub setProduct(ByVal value As String)
        product = value
    End Sub
    Public ReadOnly Property getStep1ID() As Integer
        Get
            Return step1id
        End Get
    End Property
    Public Sub setStep1ID(ByVal value As Integer)
        step1id = value
    End Sub
    Public ReadOnly Property getFormulaID() As Integer
        Get
            Return formulaid
        End Get
    End Property
    Public Sub setFormulaID(ByVal value As Integer)
        formulaid = value
    End Sub
    Public ReadOnly Property getStep2Num() As String
        Get
            Return step2num
        End Get
    End Property
    Public Sub setStep2Num(ByVal value As String)
        step2num = value
    End Sub
    Public ReadOnly Property getQuantity() As Double
        Get
            Return quantity
        End Get
    End Property
    Public Sub setQuantity(ByVal value As Double)
        quantity = value
    End Sub
    Public Function loadStep1() As DataTable
        Dim result As New DataTable, adptr As New SqlClient.SqlDataAdapter
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT * FROM funcStep1(@status,@category,@product)", cc.con)
        cc.cmd.Parameters.AddWithValue("@status", status)
        cc.cmd.Parameters.AddWithValue("@category", category)
        cc.cmd.Parameters.AddWithValue("@product", product)
        adptr.SelectCommand = cc.cmd
        adptr.Fill(result)
        cc.con.Close()
        Return result
    End Function

    Public Function loadItemsPalaman(ByVal viewName As String, step1id As Integer) As DataTable
        Dim result As New DataTable(), adptr As New SqlClient.SqlDataAdapter
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT itemid,formula_itemid,category,itemname,actual [value] FROM " & viewName & " WHERE step1id=" & step1id & ";", cc.con)
        adptr.SelectCommand = cc.cmd
        adptr.Fill(result)
        cc.con.Close()
        Return result
    End Function

    Public Function returnFormulaNumber() As String
        Dim result As Integer = 0, totalZero As String = "", result_format As String = ""
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT ISNULL(MAX(step2id),0) +1 FROM step2;", cc.con)
        result = cc.cmd.ExecuteScalar
        cc.con.Close()
        If result < 1000000 Then
            For temp As Integer = 0 To 6 - result
                totalZero += "0"
            Next
            result_format = "Step2 - " & totalZero & result
        Else
            result_format = "Step2 - " & totalZero & result
        End If
        Return result_format
    End Function

    Public Sub insertStep1(ByVal dtItem As DataTable, ByVal dtPalaman As DataTable)
        Try
            Using connection As New SqlConnection(cc.conString)
                Dim command As New SqlCommand()
                command.Connection = connection
                connection.Open()
                transaction = connection.BeginTransaction()
                command.Transaction = transaction

                command.CommandText = "insertStep2"
                command.Parameters.AddWithValue("@step2num", step2num)
                command.Parameters.AddWithValue("@step1id", step1id)
                command.Parameters.AddWithValue("@formulaid", formulaid)
                command.Parameters.AddWithValue("@product", product)
                command.Parameters.AddWithValue("@quantity", quantity)
                command.Parameters.AddWithValue("@status", status)
                command.Parameters.AddWithValue("@userid", login.userid)
                command.CommandType = CommandType.StoredProcedure
                command.ExecuteNonQuery()

                transaction.Commit()
                MessageBox.Show("Transaction Completed", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
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
