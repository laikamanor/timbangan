Imports TIMBANGAN.connections_class
Imports System.Data.SqlClient
Public Class step1_class
    Dim cc As New connections_class, transaction As SqlTransaction
    Private step1num As String = "",
        product As String = "",
        formulaid As Integer = 0,
        quantity As Double = 0.00,
        basewt As Double = 0.00,
        status As Integer = 0
    Public ReadOnly Property getProduct() As String
        Get
            Return product
        End Get
    End Property
    Public Sub setProduct(ByVal value As String)
        product = value
    End Sub
    Public ReadOnly Property getStep1Num() As String
        Get
            Return step1num
        End Get
    End Property
    Public Sub setStep1Num(ByVal value As String)
        step1num = value
    End Sub
    Public ReadOnly Property getFormulaID() As Integer
        Get
            Return formulaid
        End Get
    End Property
    Public Sub setFormulaID(ByVal value As Integer)
        formulaid = value
    End Sub
    Public ReadOnly Property getQuantity() As Double
        Get
            Return quantity
        End Get
    End Property
    Public Sub setQuantity(ByVal value As Double)
        quantity = value
    End Sub
    Public ReadOnly Property getBaseWT() As Double
        Get
            Return basewt
        End Get
    End Property
    Public Sub setBaseWT(ByVal value As Double)
        basewt = value
    End Sub
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub
    Public Sub insertStep1(ByVal dtItem As DataTable, dtPalaman As DataTable)
        Try
            Using connection As New SqlConnection(cc.conString)
                Dim command As New SqlCommand()
                command.Connection = connection
                connection.Open()
                transaction = connection.BeginTransaction()
                command.Transaction = transaction

                command.CommandText = "insertStep1"
                command.Parameters.AddWithValue("@step1num", step1num)
                command.Parameters.AddWithValue("@formulaid", formulaid)
                command.Parameters.AddWithValue("@quantity", quantity)
                command.Parameters.AddWithValue("@basewt", basewt)
                command.Parameters.AddWithValue("@status", status)
                command.Parameters.AddWithValue("@userid", login.userid)
                command.Parameters.AddWithValue("@product", product)
                command.CommandType = CommandType.StoredProcedure
                command.ExecuteNonQuery()

                If dtItem.Rows.Count <> 0 Then
                    For Each r0w As DataRow In dtItem.Rows
                        'MessageBox.Show(r0w("value"))
                        command.Parameters.Clear()
                        command.CommandText = "insertStep1Item"
                        command.Parameters.AddWithValue("@itemid", r0w("itemid"))
                        command.Parameters.AddWithValue("@value", CDbl(r0w("value")))
                        command.Parameters.AddWithValue("@actual", CDbl(r0w("actual")))
                        command.Parameters.AddWithValue("@userid", login.userid)
                        command.Parameters.AddWithValue("@status", 1)
                        command.Parameters.AddWithValue("@formula_itemid", r0w("formula_itemid"))
                        command.CommandType = CommandType.StoredProcedure
                        command.ExecuteNonQuery()
                    Next
                End If

                If dtPalaman.Rows.Count <> 0 Then
                    For Each r0w As DataRow In dtPalaman.Rows
                        command.Parameters.Clear()
                        command.CommandText = "insertStep1Palaman"
                        command.Parameters.AddWithValue("@itemid", r0w("itemid"))
                        command.Parameters.AddWithValue("@value", CDbl(r0w("value")))
                        command.Parameters.AddWithValue("@actual", CDbl(r0w("actual")))
                        command.Parameters.AddWithValue("@userid", login.userid)
                        command.Parameters.AddWithValue("@status", 1)
                        command.Parameters.AddWithValue("@formula_itemid", r0w("formula_itemid"))
                        command.CommandType = CommandType.StoredProcedure
                        command.ExecuteNonQuery()
                    Next
                End If

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

    Public Function returnFormulaNumber() As String
        Dim result As Integer = 0, totalZero As String = "", result_format As String = ""
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT ISNULL(MAX(step1id),0)+1 FROM step1;", cc.con)
        result = cc.cmd.ExecuteScalar
        cc.con.Close()

        If result < 1000000 Then
            Dim cselectcount_result As String = CStr(result)
            For temp As Integer = 0 To 6 - cselectcount_result.Length
                totalZero += "0"
            Next
            result_format = "Step1 - " & totalZero & result
        Else
            result_format = "Step1 - " & totalZero & result
        End If
        Return result_format
    End Function
End Class
