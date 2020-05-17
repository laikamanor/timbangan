Public Class security_class
    ''' <summary>
    ''' to encrypt data
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Function Encode(ByVal value) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value))
    End Function

    ''' <summary>
    ''' to decrypt data
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Function Decode(ByVal value As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(value))
    End Function
End Class
