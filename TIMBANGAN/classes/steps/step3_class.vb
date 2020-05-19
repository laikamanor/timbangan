Imports TIMBANGAN.connections_class
Imports System.Data.SqlClient
Public Class step3_class
    'classes
    Dim cc As New connections_class(), transaction As SqlTransaction
    'variables
    Private vstatus As Integer = 0, vcategory As String = "", vproduct As String = "", vstep1id As Integer = 0, vtdw As Double = 0.00, vquantity As Double = 0.00, vstep3num As String = "", vformulaid As Integer = 0, vuserID As Integer = 0

    'get and set variables
    Public Property status As Integer
        Set(value As Integer)
            vstatus = value
        End Set
        Get
            Return vstatus
        End Get
    End Property
    Public Property category As String
        Set(value As String)
            vcategory = value
        End Set
        Get
            Return vcategory
        End Get
    End Property
    Public Property product As String
        Set(value As String)
            vproduct = value
        End Set
        Get
            Return vproduct
        End Get
    End Property
    Public Property step1id As Integer
        Set(value As Integer)
            vstep1id = value
        End Set
        Get
            Return vstep1id
        End Get
    End Property
    Public Property tdw As Double
        Set(value As Double)
            vtdw = value
        End Set
        Get
            Return vtdw
        End Get
    End Property
    Public Property quantity As Double
        Set(value As Double)
            vquantity = value
        End Set
        Get
            Return vquantity
        End Get
    End Property
    Public Property step3Num As String
        Set(value As String)
            vstep3num = value
        End Set
        Get
            Return vstep3num
        End Get
    End Property
    Public Property formulaID As Integer
        Set(value As Integer)
            vformulaid = value
        End Set
        Get
            Return vformulaid
        End Get
    End Property
    Public Property userID As Integer
        Set(value As Integer)
            vuserID = value
        End Set
        Get
            Return vuserID
        End Get
    End Property

    ''' <summary>
    ''' get data from step2
    ''' </summary>
    ''' <returns></returns>
    Public Function loadStep2() As DataTable
        'init datatable and data adapter
        Dim result As New DataTable, adptr As New SqlClient.SqlDataAdapter
        'get data from table-valued function in SQL Server (abc_formula)
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT * FROM funcStep2(@status,@category,@product,@id)", cc.con)
        'assign parameters
        cc.cmd.Parameters.AddWithValue("@status", vstatus)
        cc.cmd.Parameters.AddWithValue("@category", vcategory)
        cc.cmd.Parameters.AddWithValue("@product", vproduct)
        cc.cmd.Parameters.AddWithValue("@id", vstep1id)
        adptr.SelectCommand = cc.cmd
        adptr.Fill(result)
        cc.con.Close()
        'return datatable
        Return result
    End Function

    ''' <summary>
    ''' sub to insert parameters to Step 3
    ''' </summary>
    Public Sub insertStep3()
        Try
            'create new connection
            Using connection As New SqlConnection(cc.conString)
                'init command
                Dim command As New SqlCommand()
                'open connection
                command.Connection = connection
                connection.Open()
                'begin sql transaction
                transaction = connection.BeginTransaction()
                'assign sql transaction
                command.Transaction = transaction

                'clear first parameters to make sure no error
                command.Parameters.Clear()
                'procedue name for insert query to step 3 table
                command.CommandText = "insertStep3"
                'assign parameters
                command.Parameters.AddWithValue("@step3num", vstep3num)
                command.Parameters.AddWithValue("@step1id", vstep1id)
                command.Parameters.AddWithValue("@formulaid", vformulaid)
                command.Parameters.AddWithValue("@product", vproduct)
                command.Parameters.AddWithValue("@tdw", vtdw)
                command.Parameters.AddWithValue("@quantity", vquantity)
                command.Parameters.AddWithValue("@userid", vuserID)
                command.Parameters.AddWithValue("@status", vstatus)
                'define command type of this command
                command.CommandType = CommandType.StoredProcedure
                'execute
                command.ExecuteNonQuery()

                'update step2 their step3id to have relationship each other
                'clear parameters
                command.Parameters.Clear()
                'syntax for updating step3id
                command.CommandText = "UPDATE step2 SET step3id=(SELECT TOP 1 step3id FROM step3 ORDER BY step3id DESC) WHERE step1id=@step1id"
                'default command text
                command.CommandType = CommandType.Text
                'assign parameter
                command.Parameters.AddWithValue("@step1id", vstep1id)
                'execute
                command.ExecuteNonQuery()

                'when all query is done, commit
                transaction.Commit()
                'message when commit is success
                MessageBox.Show("Transaction Completed", "Atlantic Bakery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Try
                'not insert to database when have error(s)
                transaction.Rollback()
            Catch ex2 As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End Try
    End Sub

    ''' <summary>
    ''' return step 3 transaction number for reference
    ''' </summary>
    ''' <returns></returns>
    Public Function returnStep3Num() As String
        'init result and some format
        Dim result As Integer = 0, totalZero As String = "", result_format As String = ""
        'open connection
        cc.con.Open()
        'sql syntax to get last step3id
        cc.cmd = New SqlClient.SqlCommand("SELECT ISNULL(MAX(step3id),0)+1 FROM step3;", cc.con)
        'get result
        result = cc.cmd.ExecuteScalar
        'close connection
        cc.con.Close()

        'check if result is less than to integer format
        If result < 1000000 Then
            'assign result to string
            Dim cselectcount_result As String = CStr(result)
            'loop through result string
            For temp As Integer = 0 To 6 - cselectcount_result.Length
                'adding zero everytime
                totalZero += "0"
            Next
            'assign result
            result_format = "Step3 - " & totalZero & result
        Else
            'assign result
            result_format = "Step3 - " & totalZero & result
        End If
        'return result
        Return result_format
    End Function

End Class
