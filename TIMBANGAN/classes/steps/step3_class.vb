Imports TIMBANGAN.connections_class
Public Class step3_class
    Dim cc As New connections_class()
    Private vstatus As Integer = 0, vcategory As String = "", vproduct As String = "", vstep1id
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
    Public Function loadStep2() As DataTable
        Dim result As New DataTable, adptr As New SqlClient.SqlDataAdapter
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT * FROM funcStep2(@status,@category,@product,@id)", cc.con)
        cc.cmd.Parameters.AddWithValue("@status", vstatus)
        cc.cmd.Parameters.AddWithValue("@category", vcategory)
        cc.cmd.Parameters.AddWithValue("@product", vproduct)
        cc.cmd.Parameters.AddWithValue("@id", vstep1id)
        adptr.SelectCommand = cc.cmd
        adptr.Fill(result)
        cc.con.Close()
        Return result
    End Function
End Class
