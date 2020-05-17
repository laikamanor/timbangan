Imports TIMBANGAN.connections_class
Imports TIMBANGAN.security_class
Imports System.Data.SqlClient
Imports System.IO
Public Class user_class
    Dim cc As New connections_class()
    Dim sc As New security_class()
    Private username As String = "", workgroup As String, full_name As String = "",
        password As String = "", status As Integer = 0, userid As Integer = 0, current_username As String = "", datecreated As String = ""
    'setter and getter
    Public ReadOnly Property getCurrentUsername() As String
        Get
            Return current_username
        End Get
    End Property
    Public Sub setCurrentUsername(ByVal value As String)
        current_username = value
    End Sub
    Public ReadOnly Property getUsername() As String
        Get
            Return username
        End Get
    End Property
    Public Sub setUsername(ByVal value As String)
        username = value
    End Sub
    Public ReadOnly Property getWorkgroup() As String
        Get
            Return workgroup
        End Get
    End Property
    Public Sub setWorkgroup(ByVal value As String)
        workgroup = value
    End Sub
    Public ReadOnly Property getFullName() As String
        Get
            Return full_name
        End Get
    End Property
    Public Sub setFullName(ByVal value As String)
        full_name = value
    End Sub
    Public ReadOnly Property getPassword() As String
        Get
            Return password
        End Get
    End Property
    Public Sub setPassword(ByVal value As String)
        password = value
    End Sub
    Public ReadOnly Property getStatus() As Integer
        Get
            Return status
        End Get
    End Property
    Public Sub setStatus(ByVal value As Integer)
        status = value
    End Sub
    Public ReadOnly Property getUserID() As Integer
        Get
            Return userid
        End Get
    End Property
    Public Sub setUserID(ByVal value As Integer)
        userid = value
    End Sub
    Public ReadOnly Property getDateCreated() As String
        Get
            Return datecreated
        End Get
    End Property
    Public Sub setDateCreated(ByVal value As String)
        datecreated = value
    End Sub
    Public Function checkUsername() As Boolean
        Dim result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT userid FROM users WHERE username=@username", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            result = True
        End If
        cc.con.Close()
        Return result
    End Function

    Public Function returnUserID() As Integer
        Dim result As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT userid FROM users WHERE username=@username", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        result = cc.cmd.ExecuteScalar
        cc.con.Close()
        Return result
    End Function

    Public Function returnPassword() As String
        Dim result As String = ""
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT password FROM users WHERE username=@username;", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            result = sc.Decode(cc.rdr("password"))
        End If
        cc.con.Close()
        Return result
    End Function
    Public Function checkWorkgroup() As Boolean
        Dim result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT workgroupid FROM workgroups WHERE name=@username", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", workgroup)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            result = True
        End If
        cc.con.Close()
        Return result
    End Function

    Public Sub filterWorkgroups(ByVal cmb As ComboBox, isAdd As Boolean)
        Try
            cmb.Items.Clear()
            Dim auto As New AutoCompleteStringCollection()
            If isAdd = False Then
                cmb.Items.Add("All")
                auto.Add("All")
            End If
            cc.con.Open()
            cc.cmd = New SqlCommand("SELECT name FROM workgroups WHERE status=1;", cc.con)
            cc.rdr = cc.cmd.ExecuteReader
            While cc.rdr.Read
                cmb.Items.Add(cc.rdr("name"))
                auto.Add(cc.rdr("name"))
            End While
            cc.con.Close()
            cmb.AutoCompleteCustomSource = auto
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub
    Public Sub addUser()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("insertUser", cc.con)
            cc.cmd.Parameters.AddWithValue("@username", username)
            cc.cmd.Parameters.AddWithValue("@workgroup", workgroup)
            cc.cmd.Parameters.AddWithValue("@fullname", full_name)
            cc.cmd.Parameters.AddWithValue("@password", password)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.Parameters.AddWithValue("@userid", userid)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub updateUser()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("updateUser", cc.con)
            cc.cmd.Parameters.AddWithValue("@current_username", current_username)
            cc.cmd.Parameters.AddWithValue("@username", username)
            cc.cmd.Parameters.AddWithValue("@workgroup", workgroup)
            cc.cmd.Parameters.AddWithValue("@fullname", full_name)
            cc.cmd.Parameters.AddWithValue("@password", password)
            cc.cmd.Parameters.AddWithValue("@status", status)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function showUsers() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT b.name [workgroup],a.fullname,a.username,a.status FROM users a INNER JOIN workgroups b ON a.workgroup_id = b.workgroupid WHERE a.username LIKE @username AND a.status=@status AND b.status=1 " & IIf(workgroup = "All", ";", "AND b.name=@workgroup;"), cc.con)
        cc.cmd.Parameters.AddWithValue("@username", "%" & username & "%")
        cc.cmd.Parameters.AddWithValue("@status", status)
        If workgroup <> "All" Then
            cc.cmd.Parameters.AddWithValue("@workgroup", workgroup)
        End If
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function

    Public Function checkPassword() As Boolean
        Dim result As Boolean = False, result_int As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.checkPassword(@username,@password)", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        cc.cmd.Parameters.AddWithValue("@password", password)
        result_int = cc.cmd.ExecuteScalar
        cc.con.Close()
        result = IIf(result_int = 0, False, True)
        Return result
    End Function

    Public Function checkUsernameStatus() As Boolean
        Dim result As Boolean = False, result_int As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.checkUsernameStatus(@username)", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        result_int = cc.cmd.ExecuteScalar
        cc.con.Close()
        result = IIf(result_int = 0, True, False)
        Return result
    End Function

    Public Function checkWorkgroupUsername() As Boolean
        Dim result As Boolean = False, result_int As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.checkWorkgroupUsername(@username)", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        result_int = cc.cmd.ExecuteScalar
        cc.con.Close()
        result = IIf(result_int = 0, True, False)
        Return result
    End Function

    Public Sub loggedIn()
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("loggedIn", cc.con)
            cc.cmd.Parameters.AddWithValue("@username", username)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub
    Public Sub loggedOut(ByVal logid As Integer)
        Try
            cc.con.Open()
            cc.cmd = New SqlCommand("loggedOut", cc.con)
            cc.cmd.Parameters.AddWithValue("@logid", logid)
            cc.cmd.CommandType = CommandType.StoredProcedure
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub
    Public Function returnLogID() As Integer
        Dim result As Integer = 0
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT dbo.returnLogID(@username)", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        result = cc.cmd.ExecuteScalar
        cc.con.Close()
        Return result
    End Function

    Public Function showLoginLogs() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT b.username,a.login,a.logout FROM login_logs a INNER JOIN users b ON a.userid = b.userid WHERE CAST(a.login AS date)='" & datecreated & "' AND b.username LIKE @username;", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", "%" & username & "%")
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function
    Public Function showUserInformation() As DataTable
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT a.fullname,b.name AS workgroup,b.description FROM users a INNER JOIN workgroups b ON a.workgroup_id = b.workgroupid WHERE a.userid=" & userid & ";", cc.con)
        Dim adptr As New SqlClient.SqlDataAdapter()
        Dim dt As New DataTable()
        adptr.SelectCommand = cc.cmd
        adptr.Fill(dt)
        cc.con.Close()
        Return dt
    End Function

    Public Sub changeUserIcon(ByVal pic As PictureBox)
        Try
            Dim ms As New MemoryStream(), result As Boolean = False
            pic.Image.Save(ms, pic.Image.RawFormat)
            cc.con.Open()
            cc.cmd = New SqlCommand("SELECT imageid FROM users_icon WHERE userid=" & login.userid, cc.con)
            cc.rdr = cc.cmd.ExecuteReader
            If cc.rdr.Read Then
                result = True
            End If
            cc.con.Close()

            If result Then
                cc.con.Open()
                cc.cmd = New SqlCommand("updateUserIcon", cc.con)
                cc.cmd.Parameters.AddWithValue("@userid", login.userid)
                cc.cmd.Parameters.AddWithValue("@img", SqlDbType.Image).Value = ms.ToArray()
                cc.cmd.CommandType = CommandType.StoredProcedure
                cc.cmd.ExecuteNonQuery()
                cc.con.Close()
                cc.con.Close()
            Else
                cc.con.Open()
                cc.cmd = New SqlCommand("insertUserIcon", cc.con)
                cc.cmd.Parameters.AddWithValue("@userid", login.userid)
                cc.cmd.Parameters.AddWithValue("@img", SqlDbType.Image).Value = ms.ToArray()
                cc.cmd.CommandType = CommandType.StoredProcedure
                cc.cmd.ExecuteNonQuery()
                cc.con.Close()
                cc.con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Function loadUserIcon() As PictureBox
        Dim result As New PictureBox
        cc.con.Open()
        cc.cmd = New SqlCommand("SELECT picture FROM users_icon WHERE userid=" & login.userid, cc.con)
        cc.rdr = cc.cmd.ExecuteReader
        If cc.rdr.Read Then
            If Not IsDBNull(cc.rdr("picture")) Then
                Dim img() As Byte
                img = cc.rdr("picture")
                Dim ms As New MemoryStream(img)
                result.Image = Image.FromStream(ms)
            Else
                result.Image = My.Resources.no_image
            End If
        Else
            result.Image = My.Resources.no_image
        End If
        cc.con.Close()
        Return result
    End Function
End Class
