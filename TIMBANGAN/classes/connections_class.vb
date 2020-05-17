Imports System.Data.SqlClient
Imports TIMBANGAN.security_class
Public Class connections_class
    Dim sc As New security_class()
    Public conString As String = sc.Decode(System.IO.File.ReadAllText("connectionstring.txt"))
    Public con As New SqlConnection(sc.Decode(System.IO.File.ReadAllText("connectionstring.txt")))
    Public rdr As SqlDataReader
    Public cmd As SqlCommand
    Public tr As SqlTransaction
    Public transaction As SqlTransaction

    Public Function getSystemDate() As DateTime
        Dim result As New DateTime
        con.Open()
        cmd = New SqlCommand("SELECT dbo.funcSystemDate()", con)
        result = cmd.ExecuteScalar
        con.Close()
        Return result
    End Function

End Class
