<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_user
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbworkgroup = New System.Windows.Forms.ComboBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtretypepassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkpassword = New System.Windows.Forms.CheckBox()
        Me.checkretypepassword = New System.Windows.Forms.CheckBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelmsg = New System.Windows.Forms.Panel()
        Me.lblmsgclose = New System.Windows.Forms.Label()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panelmsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(351, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(26, 25)
        Me.btnclose.TabIndex = 8
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(37, 45)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(95, 24)
        Me.lblheader.TabIndex = 11
        Me.lblheader.Text = "Add User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(38, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Workgroup:"
        '
        'cmbworkgroup
        '
        Me.cmbworkgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbworkgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbworkgroup.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbworkgroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbworkgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbworkgroup.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbworkgroup.ForeColor = System.Drawing.Color.White
        Me.cmbworkgroup.FormattingEnabled = True
        Me.cmbworkgroup.Location = New System.Drawing.Point(41, 122)
        Me.cmbworkgroup.Name = "cmbworkgroup"
        Me.cmbworkgroup.Size = New System.Drawing.Size(285, 25)
        Me.cmbworkgroup.TabIndex = 0
        Me.cmbworkgroup.Tag = ""
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(41, 185)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(285, 26)
        Me.txtusername.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(38, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Username:"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(41, 318)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(285, 26)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(38, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Password:"
        '
        'txtretypepassword
        '
        Me.txtretypepassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtretypepassword.Location = New System.Drawing.Point(41, 379)
        Me.txtretypepassword.Name = "txtretypepassword"
        Me.txtretypepassword.Size = New System.Drawing.Size(285, 26)
        Me.txtretypepassword.TabIndex = 4
        Me.txtretypepassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(38, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Retype Password:"
        '
        'txtfullname
        '
        Me.txtfullname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Location = New System.Drawing.Point(41, 250)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(285, 26)
        Me.txtfullname.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(38, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Full Name:"
        '
        'checkpassword
        '
        Me.checkpassword.AutoSize = True
        Me.checkpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkpassword.Location = New System.Drawing.Point(332, 325)
        Me.checkpassword.Name = "checkpassword"
        Me.checkpassword.Size = New System.Drawing.Size(15, 14)
        Me.checkpassword.TabIndex = 30
        Me.checkpassword.UseVisualStyleBackColor = True
        '
        'checkretypepassword
        '
        Me.checkretypepassword.AutoSize = True
        Me.checkretypepassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkretypepassword.Location = New System.Drawing.Point(331, 386)
        Me.checkretypepassword.Name = "checkretypepassword"
        Me.checkretypepassword.Size = New System.Drawing.Size(15, 14)
        Me.checkretypepassword.TabIndex = 31
        Me.checkretypepassword.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.FlatAppearance.BorderSize = 0
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Location = New System.Drawing.Point(41, 480)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(285, 36)
        Me.btnsubmit.TabIndex = 6
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 551)
        Me.Panel1.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(377, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 551)
        Me.Panel2.TabIndex = 34
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(1, 550)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 1)
        Me.Panel3.TabIndex = 34
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 1)
        Me.Panel4.TabIndex = 34
        '
        'panelmsg
        '
        Me.panelmsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelmsg.Controls.Add(Me.lblmsgclose)
        Me.panelmsg.Controls.Add(Me.lblerror)
        Me.panelmsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelmsg.Location = New System.Drawing.Point(1, 1)
        Me.panelmsg.Name = "panelmsg"
        Me.panelmsg.Size = New System.Drawing.Size(376, 27)
        Me.panelmsg.TabIndex = 36
        Me.panelmsg.Visible = False
        '
        'lblmsgclose
        '
        Me.lblmsgclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmsgclose.AutoSize = True
        Me.lblmsgclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmsgclose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgclose.ForeColor = System.Drawing.Color.White
        Me.lblmsgclose.Location = New System.Drawing.Point(356, 5)
        Me.lblmsgclose.Name = "lblmsgclose"
        Me.lblmsgclose.Size = New System.Drawing.Size(17, 16)
        Me.lblmsgclose.TabIndex = 26
        Me.lblmsgclose.Text = "X"
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.White
        Me.lblerror.Location = New System.Drawing.Point(3, 6)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(176, 16)
        Me.lblerror.TabIndex = 25
        Me.lblerror.Text = "Username field is required"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(38, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Status:"
        '
        'cmbstatus
        '
        Me.cmbstatus.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbstatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbstatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstatus.ForeColor = System.Drawing.Color.White
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Active", "In Active"})
        Me.cmbstatus.Location = New System.Drawing.Point(41, 438)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(285, 25)
        Me.cmbstatus.TabIndex = 5
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(378, 551)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.panelmsg)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.checkretypepassword)
        Me.Controls.Add(Me.checkpassword)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtretypepassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbworkgroup)
        Me.Controls.Add(Me.lblheader)
        Me.Controls.Add(Me.btnclose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "add_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.panelmsg.ResumeLayout(False)
        Me.panelmsg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents lblheader As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbworkgroup As ComboBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtretypepassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents checkpassword As CheckBox
    Friend WithEvents checkretypepassword As CheckBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelmsg As Panel
    Friend WithEvents lblmsgclose As Label
    Friend WithEvents lblerror As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbstatus As ComboBox
    Friend WithEvents Timer2 As Timer
End Class
