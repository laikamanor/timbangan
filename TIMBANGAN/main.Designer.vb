<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelside = New System.Windows.Forms.Panel()
        Me.panelusers = New System.Windows.Forms.Panel()
        Me.btnaccess = New System.Windows.Forms.Button()
        Me.btnmodules = New System.Windows.Forms.Button()
        Me.btnloginlogs = New System.Windows.Forms.Button()
        Me.btnworkgroups = New System.Windows.Forms.Button()
        Me.btnmanageusers = New System.Windows.Forms.Button()
        Me.btnusers = New System.Windows.Forms.Button()
        Me.panelsteps = New System.Windows.Forms.Panel()
        Me.btnstep4 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnstep3 = New System.Windows.Forms.Button()
        Me.btnstep2 = New System.Windows.Forms.Button()
        Me.btnstep1 = New System.Windows.Forms.Button()
        Me.btnsteps = New System.Windows.Forms.Button()
        Me.panelformula = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnmanageformula = New System.Windows.Forms.Button()
        Me.btnformula = New System.Windows.Forms.Button()
        Me.panelsubsetup = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnproducts = New System.Windows.Forms.Button()
        Me.btnitems = New System.Windows.Forms.Button()
        Me.btncategory = New System.Windows.Forms.Button()
        Me.btnsetup = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnaddaccess = New System.Windows.Forms.Button()
        Me.lblworkgroup = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.profilepic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.panelnav = New System.Windows.Forms.Panel()
        Me.btnlock = New System.Windows.Forms.Button()
        Me.btnfullscreen = New System.Windows.Forms.Button()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.panelbody = New System.Windows.Forms.Panel()
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse8 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse9 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse10 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse11 = New ns1.BunifuElipse(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panelmsg = New System.Windows.Forms.Panel()
        Me.lblmsgclose = New System.Windows.Forms.Label()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.panelside.SuspendLayout()
        Me.panelusers.SuspendLayout()
        Me.panelsteps.SuspendLayout()
        Me.panelformula.SuspendLayout()
        Me.panelsubsetup.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.profilepic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelnav.SuspendLayout()
        Me.panelmsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel1.Controls.Add(Me.panelside)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 697)
        Me.Panel1.TabIndex = 0
        '
        'panelside
        '
        Me.panelside.AutoScroll = True
        Me.panelside.Controls.Add(Me.panelusers)
        Me.panelside.Controls.Add(Me.btnusers)
        Me.panelside.Controls.Add(Me.panelsteps)
        Me.panelside.Controls.Add(Me.btnsteps)
        Me.panelside.Controls.Add(Me.panelformula)
        Me.panelside.Controls.Add(Me.btnformula)
        Me.panelside.Controls.Add(Me.panelsubsetup)
        Me.panelside.Controls.Add(Me.btnsetup)
        Me.panelside.Controls.Add(Me.btndashboard)
        Me.panelside.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelside.Location = New System.Drawing.Point(0, 160)
        Me.panelside.Name = "panelside"
        Me.panelside.Size = New System.Drawing.Size(184, 537)
        Me.panelside.TabIndex = 1
        '
        'panelusers
        '
        Me.panelusers.Controls.Add(Me.btnaccess)
        Me.panelusers.Controls.Add(Me.btnmodules)
        Me.panelusers.Controls.Add(Me.btnloginlogs)
        Me.panelusers.Controls.Add(Me.btnworkgroups)
        Me.panelusers.Controls.Add(Me.btnmanageusers)
        Me.panelusers.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelusers.Location = New System.Drawing.Point(0, 639)
        Me.panelusers.Name = "panelusers"
        Me.panelusers.Size = New System.Drawing.Size(167, 297)
        Me.panelusers.TabIndex = 18
        Me.panelusers.Visible = False
        '
        'btnaccess
        '
        Me.btnaccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnaccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccess.FlatAppearance.BorderSize = 0
        Me.btnaccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaccess.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccess.ForeColor = System.Drawing.Color.White
        Me.btnaccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaccess.Location = New System.Drawing.Point(28, 153)
        Me.btnaccess.Name = "btnaccess"
        Me.btnaccess.Size = New System.Drawing.Size(120, 42)
        Me.btnaccess.TabIndex = 18
        Me.btnaccess.Text = "Access"
        Me.btnaccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaccess.UseVisualStyleBackColor = False
        '
        'btnmodules
        '
        Me.btnmodules.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnmodules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodules.FlatAppearance.BorderSize = 0
        Me.btnmodules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodules.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodules.ForeColor = System.Drawing.Color.White
        Me.btnmodules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodules.Location = New System.Drawing.Point(28, 105)
        Me.btnmodules.Name = "btnmodules"
        Me.btnmodules.Size = New System.Drawing.Size(120, 42)
        Me.btnmodules.TabIndex = 17
        Me.btnmodules.Text = "Modules"
        Me.btnmodules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodules.UseVisualStyleBackColor = False
        '
        'btnloginlogs
        '
        Me.btnloginlogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnloginlogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnloginlogs.FlatAppearance.BorderSize = 0
        Me.btnloginlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloginlogs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginlogs.ForeColor = System.Drawing.Color.White
        Me.btnloginlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnloginlogs.Location = New System.Drawing.Point(28, 201)
        Me.btnloginlogs.Name = "btnloginlogs"
        Me.btnloginlogs.Size = New System.Drawing.Size(120, 42)
        Me.btnloginlogs.TabIndex = 16
        Me.btnloginlogs.Text = "Login Logs"
        Me.btnloginlogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnloginlogs.UseVisualStyleBackColor = False
        '
        'btnworkgroups
        '
        Me.btnworkgroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnworkgroups.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnworkgroups.FlatAppearance.BorderSize = 0
        Me.btnworkgroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnworkgroups.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnworkgroups.ForeColor = System.Drawing.Color.White
        Me.btnworkgroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnworkgroups.Location = New System.Drawing.Point(28, 57)
        Me.btnworkgroups.Name = "btnworkgroups"
        Me.btnworkgroups.Size = New System.Drawing.Size(120, 42)
        Me.btnworkgroups.TabIndex = 15
        Me.btnworkgroups.Text = "Workgroups"
        Me.btnworkgroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnworkgroups.UseVisualStyleBackColor = False
        '
        'btnmanageusers
        '
        Me.btnmanageusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnmanageusers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmanageusers.FlatAppearance.BorderSize = 0
        Me.btnmanageusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmanageusers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmanageusers.ForeColor = System.Drawing.Color.White
        Me.btnmanageusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmanageusers.Location = New System.Drawing.Point(28, 8)
        Me.btnmanageusers.Name = "btnmanageusers"
        Me.btnmanageusers.Size = New System.Drawing.Size(120, 42)
        Me.btnmanageusers.TabIndex = 14
        Me.btnmanageusers.Text = "Manage Users"
        Me.btnmanageusers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmanageusers.UseVisualStyleBackColor = False
        '
        'btnusers
        '
        Me.btnusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnusers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnusers.FlatAppearance.BorderSize = 0
        Me.btnusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnusers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusers.ForeColor = System.Drawing.Color.White
        Me.btnusers.Image = CType(resources.GetObject("btnusers.Image"), System.Drawing.Image)
        Me.btnusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnusers.Location = New System.Drawing.Point(0, 597)
        Me.btnusers.Name = "btnusers"
        Me.btnusers.Size = New System.Drawing.Size(167, 42)
        Me.btnusers.TabIndex = 17
        Me.btnusers.Text = "Users"
        Me.btnusers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnusers.UseVisualStyleBackColor = False
        '
        'panelsteps
        '
        Me.panelsteps.Controls.Add(Me.btnstep4)
        Me.panelsteps.Controls.Add(Me.Panel6)
        Me.panelsteps.Controls.Add(Me.btnstep3)
        Me.panelsteps.Controls.Add(Me.btnstep2)
        Me.panelsteps.Controls.Add(Me.btnstep1)
        Me.panelsteps.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelsteps.Location = New System.Drawing.Point(0, 388)
        Me.panelsteps.Name = "panelsteps"
        Me.panelsteps.Size = New System.Drawing.Size(167, 209)
        Me.panelsteps.TabIndex = 16
        Me.panelsteps.Visible = False
        '
        'btnstep4
        '
        Me.btnstep4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnstep4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstep4.FlatAppearance.BorderSize = 0
        Me.btnstep4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstep4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstep4.ForeColor = System.Drawing.Color.White
        Me.btnstep4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep4.Location = New System.Drawing.Point(28, 160)
        Me.btnstep4.Name = "btnstep4"
        Me.btnstep4.Size = New System.Drawing.Size(120, 42)
        Me.btnstep4.TabIndex = 17
        Me.btnstep4.Text = "Step 4"
        Me.btnstep4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep4.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 208)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(167, 1)
        Me.Panel6.TabIndex = 13
        '
        'btnstep3
        '
        Me.btnstep3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnstep3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstep3.FlatAppearance.BorderSize = 0
        Me.btnstep3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstep3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstep3.ForeColor = System.Drawing.Color.White
        Me.btnstep3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep3.Location = New System.Drawing.Point(28, 112)
        Me.btnstep3.Name = "btnstep3"
        Me.btnstep3.Size = New System.Drawing.Size(120, 42)
        Me.btnstep3.TabIndex = 16
        Me.btnstep3.Text = "Step 3"
        Me.btnstep3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep3.UseVisualStyleBackColor = False
        '
        'btnstep2
        '
        Me.btnstep2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnstep2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstep2.FlatAppearance.BorderSize = 0
        Me.btnstep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstep2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstep2.ForeColor = System.Drawing.Color.White
        Me.btnstep2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep2.Location = New System.Drawing.Point(30, 64)
        Me.btnstep2.Name = "btnstep2"
        Me.btnstep2.Size = New System.Drawing.Size(120, 42)
        Me.btnstep2.TabIndex = 15
        Me.btnstep2.Text = "Step 2"
        Me.btnstep2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep2.UseVisualStyleBackColor = False
        '
        'btnstep1
        '
        Me.btnstep1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnstep1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstep1.FlatAppearance.BorderSize = 0
        Me.btnstep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstep1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstep1.ForeColor = System.Drawing.Color.White
        Me.btnstep1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep1.Location = New System.Drawing.Point(30, 15)
        Me.btnstep1.Name = "btnstep1"
        Me.btnstep1.Size = New System.Drawing.Size(120, 42)
        Me.btnstep1.TabIndex = 14
        Me.btnstep1.Text = "Step 1"
        Me.btnstep1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstep1.UseVisualStyleBackColor = False
        '
        'btnsteps
        '
        Me.btnsteps.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnsteps.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsteps.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsteps.FlatAppearance.BorderSize = 0
        Me.btnsteps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsteps.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsteps.ForeColor = System.Drawing.Color.White
        Me.btnsteps.Image = CType(resources.GetObject("btnsteps.Image"), System.Drawing.Image)
        Me.btnsteps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsteps.Location = New System.Drawing.Point(0, 346)
        Me.btnsteps.Name = "btnsteps"
        Me.btnsteps.Size = New System.Drawing.Size(167, 42)
        Me.btnsteps.TabIndex = 15
        Me.btnsteps.Text = "Steps"
        Me.btnsteps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsteps.UseVisualStyleBackColor = False
        '
        'panelformula
        '
        Me.panelformula.Controls.Add(Me.Panel4)
        Me.panelformula.Controls.Add(Me.btnmanageformula)
        Me.panelformula.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelformula.Location = New System.Drawing.Point(0, 290)
        Me.panelformula.Name = "panelformula"
        Me.panelformula.Size = New System.Drawing.Size(167, 56)
        Me.panelformula.TabIndex = 14
        Me.panelformula.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 55)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(167, 1)
        Me.Panel4.TabIndex = 13
        '
        'btnmanageformula
        '
        Me.btnmanageformula.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnmanageformula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmanageformula.FlatAppearance.BorderSize = 0
        Me.btnmanageformula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmanageformula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmanageformula.ForeColor = System.Drawing.Color.White
        Me.btnmanageformula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmanageformula.Location = New System.Drawing.Point(30, 6)
        Me.btnmanageformula.Name = "btnmanageformula"
        Me.btnmanageformula.Size = New System.Drawing.Size(120, 42)
        Me.btnmanageformula.TabIndex = 14
        Me.btnmanageformula.Text = "Manage Formula"
        Me.btnmanageformula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmanageformula.UseVisualStyleBackColor = False
        '
        'btnformula
        '
        Me.btnformula.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnformula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnformula.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnformula.FlatAppearance.BorderSize = 0
        Me.btnformula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnformula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnformula.ForeColor = System.Drawing.Color.White
        Me.btnformula.Image = CType(resources.GetObject("btnformula.Image"), System.Drawing.Image)
        Me.btnformula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnformula.Location = New System.Drawing.Point(0, 248)
        Me.btnformula.Name = "btnformula"
        Me.btnformula.Size = New System.Drawing.Size(167, 42)
        Me.btnformula.TabIndex = 13
        Me.btnformula.Text = "Formula"
        Me.btnformula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnformula.UseVisualStyleBackColor = False
        '
        'panelsubsetup
        '
        Me.panelsubsetup.Controls.Add(Me.Panel11)
        Me.panelsubsetup.Controls.Add(Me.btnproducts)
        Me.panelsubsetup.Controls.Add(Me.btnitems)
        Me.panelsubsetup.Controls.Add(Me.btncategory)
        Me.panelsubsetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelsubsetup.Location = New System.Drawing.Point(0, 84)
        Me.panelsubsetup.Name = "panelsubsetup"
        Me.panelsubsetup.Size = New System.Drawing.Size(167, 164)
        Me.panelsubsetup.TabIndex = 12
        Me.panelsubsetup.Visible = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 163)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(167, 1)
        Me.Panel11.TabIndex = 13
        '
        'btnproducts
        '
        Me.btnproducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnproducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproducts.FlatAppearance.BorderSize = 0
        Me.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproducts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproducts.ForeColor = System.Drawing.Color.White
        Me.btnproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproducts.Location = New System.Drawing.Point(30, 103)
        Me.btnproducts.Name = "btnproducts"
        Me.btnproducts.Size = New System.Drawing.Size(120, 42)
        Me.btnproducts.TabIndex = 16
        Me.btnproducts.Text = "Products"
        Me.btnproducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproducts.UseVisualStyleBackColor = False
        '
        'btnitems
        '
        Me.btnitems.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnitems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnitems.FlatAppearance.BorderSize = 0
        Me.btnitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnitems.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnitems.ForeColor = System.Drawing.Color.White
        Me.btnitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnitems.Location = New System.Drawing.Point(32, 55)
        Me.btnitems.Name = "btnitems"
        Me.btnitems.Size = New System.Drawing.Size(120, 42)
        Me.btnitems.TabIndex = 15
        Me.btnitems.Text = "Items"
        Me.btnitems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnitems.UseVisualStyleBackColor = False
        '
        'btncategory
        '
        Me.btncategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btncategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncategory.FlatAppearance.BorderSize = 0
        Me.btncategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategory.ForeColor = System.Drawing.Color.White
        Me.btncategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncategory.Location = New System.Drawing.Point(32, 6)
        Me.btncategory.Name = "btncategory"
        Me.btncategory.Size = New System.Drawing.Size(120, 42)
        Me.btncategory.TabIndex = 14
        Me.btncategory.Text = "Category"
        Me.btncategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncategory.UseVisualStyleBackColor = False
        '
        'btnsetup
        '
        Me.btnsetup.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnsetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsetup.FlatAppearance.BorderSize = 0
        Me.btnsetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsetup.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsetup.ForeColor = System.Drawing.Color.White
        Me.btnsetup.Image = CType(resources.GetObject("btnsetup.Image"), System.Drawing.Image)
        Me.btnsetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsetup.Location = New System.Drawing.Point(0, 42)
        Me.btnsetup.Name = "btnsetup"
        Me.btnsetup.Size = New System.Drawing.Size(167, 42)
        Me.btnsetup.TabIndex = 11
        Me.btnsetup.Text = "Setup"
        Me.btnsetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsetup.UseVisualStyleBackColor = False
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndashboard.FlatAppearance.BorderSize = 0
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.White
        Me.btndashboard.Image = CType(resources.GetObject("btndashboard.Image"), System.Drawing.Image)
        Me.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndashboard.Location = New System.Drawing.Point(0, 0)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(167, 42)
        Me.btndashboard.TabIndex = 3
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnaddaccess)
        Me.Panel2.Controls.Add(Me.lblworkgroup)
        Me.Panel2.Controls.Add(Me.lblname)
        Me.Panel2.Controls.Add(Me.profilepic)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 160)
        Me.Panel2.TabIndex = 1
        '
        'btnaddaccess
        '
        Me.btnaddaccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnaddaccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddaccess.FlatAppearance.BorderSize = 0
        Me.btnaddaccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddaccess.Image = CType(resources.GetObject("btnaddaccess.Image"), System.Drawing.Image)
        Me.btnaddaccess.Location = New System.Drawing.Point(133, 79)
        Me.btnaddaccess.Name = "btnaddaccess"
        Me.btnaddaccess.Size = New System.Drawing.Size(31, 34)
        Me.btnaddaccess.TabIndex = 0
        Me.btnaddaccess.UseVisualStyleBackColor = False
        '
        'lblworkgroup
        '
        Me.lblworkgroup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblworkgroup.AutoSize = True
        Me.lblworkgroup.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblworkgroup.ForeColor = System.Drawing.Color.White
        Me.lblworkgroup.Location = New System.Drawing.Point(32, 131)
        Me.lblworkgroup.Name = "lblworkgroup"
        Me.lblworkgroup.Size = New System.Drawing.Size(62, 12)
        Me.lblworkgroup.TabIndex = 7
        Me.lblworkgroup.Text = "Developer"
        '
        'lblname
        '
        Me.lblname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(31, 116)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(123, 15)
        Me.lblname.TabIndex = 6
        Me.lblname.Text = "Gordon Macaraeg"
        '
        'profilepic
        '
        Me.profilepic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.profilepic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profilepic.Image = CType(resources.GetObject("profilepic.Image"), System.Drawing.Image)
        Me.profilepic.Location = New System.Drawing.Point(53, 35)
        Me.profilepic.Name = "profilepic"
        Me.profilepic.Size = New System.Drawing.Size(80, 78)
        Me.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilepic.TabIndex = 4
        Me.profilepic.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TIMBANGAN"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 70
        Me.BunifuElipse1.TargetControl = Me.profilepic
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.btncategory
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 10
        Me.BunifuElipse3.TargetControl = Me.btnitems
        '
        'panelnav
        '
        Me.panelnav.Controls.Add(Me.btnlock)
        Me.panelnav.Controls.Add(Me.btnfullscreen)
        Me.panelnav.Controls.Add(Me.lbltime)
        Me.panelnav.Controls.Add(Me.btnlogout)
        Me.panelnav.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelnav.Location = New System.Drawing.Point(184, 0)
        Me.panelnav.Name = "panelnav"
        Me.panelnav.Size = New System.Drawing.Size(927, 48)
        Me.panelnav.TabIndex = 1
        '
        'btnlock
        '
        Me.btnlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlock.FlatAppearance.BorderSize = 0
        Me.btnlock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlock.Image = CType(resources.GetObject("btnlock.Image"), System.Drawing.Image)
        Me.btnlock.Location = New System.Drawing.Point(810, 11)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(25, 26)
        Me.btnlock.TabIndex = 3
        Me.btnlock.UseVisualStyleBackColor = True
        '
        'btnfullscreen
        '
        Me.btnfullscreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfullscreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfullscreen.FlatAppearance.BorderSize = 0
        Me.btnfullscreen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnfullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfullscreen.Image = CType(resources.GetObject("btnfullscreen.Image"), System.Drawing.Image)
        Me.btnfullscreen.Location = New System.Drawing.Point(841, 11)
        Me.btnfullscreen.Name = "btnfullscreen"
        Me.btnfullscreen.Size = New System.Drawing.Size(25, 26)
        Me.btnfullscreen.TabIndex = 2
        Me.btnfullscreen.UseVisualStyleBackColor = True
        '
        'lbltime
        '
        Me.lbltime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(444, 19)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(48, 12)
        Me.lbltime.TabIndex = 1
        Me.lbltime.Text = "4:29 PM"
        '
        'btnlogout
        '
        Me.btnlogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.Location = New System.Drawing.Point(872, 11)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(25, 26)
        Me.btnlogout.TabIndex = 0
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'panelbody
        '
        Me.panelbody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelbody.BackColor = System.Drawing.SystemColors.Control
        Me.panelbody.Location = New System.Drawing.Point(184, 73)
        Me.panelbody.Name = "panelbody"
        Me.panelbody.Size = New System.Drawing.Size(927, 624)
        Me.panelbody.TabIndex = 2
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 10
        Me.BunifuElipse4.TargetControl = Me.btnproducts
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 10
        Me.BunifuElipse5.TargetControl = Me.btnmanageformula
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 10
        Me.BunifuElipse6.TargetControl = Me.btnstep1
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 10
        Me.BunifuElipse7.TargetControl = Me.btnstep2
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 10
        Me.BunifuElipse8.TargetControl = Me.btnstep3
        '
        'BunifuElipse9
        '
        Me.BunifuElipse9.ElipseRadius = 10
        Me.BunifuElipse9.TargetControl = Me.btnstep4
        '
        'BunifuElipse10
        '
        Me.BunifuElipse10.ElipseRadius = 10
        Me.BunifuElipse10.TargetControl = Me.btnmanageusers
        '
        'BunifuElipse11
        '
        Me.BunifuElipse11.ElipseRadius = 10
        Me.BunifuElipse11.TargetControl = Me.btnworkgroups
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog2"
        '
        'panelmsg
        '
        Me.panelmsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.panelmsg.Controls.Add(Me.lblmsgclose)
        Me.panelmsg.Controls.Add(Me.lblerror)
        Me.panelmsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelmsg.Location = New System.Drawing.Point(184, 48)
        Me.panelmsg.Name = "panelmsg"
        Me.panelmsg.Size = New System.Drawing.Size(927, 27)
        Me.panelmsg.TabIndex = 25
        Me.panelmsg.Visible = False
        '
        'lblmsgclose
        '
        Me.lblmsgclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmsgclose.AutoSize = True
        Me.lblmsgclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmsgclose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgclose.ForeColor = System.Drawing.Color.White
        Me.lblmsgclose.Location = New System.Drawing.Point(907, 5)
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
        Me.lblerror.Size = New System.Drawing.Size(189, 16)
        Me.lblerror.TabIndex = 25
        Me.lblerror.Text = "Username Gordon is created"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1111, 697)
        Me.Controls.Add(Me.panelmsg)
        Me.Controls.Add(Me.panelbody)
        Me.Controls.Add(Me.panelnav)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.panelside.ResumeLayout(False)
        Me.panelusers.ResumeLayout(False)
        Me.panelsteps.ResumeLayout(False)
        Me.panelformula.ResumeLayout(False)
        Me.panelsubsetup.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.profilepic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelnav.ResumeLayout(False)
        Me.panelnav.PerformLayout()
        Me.panelmsg.ResumeLayout(False)
        Me.panelmsg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblworkgroup As Label
    Friend WithEvents lblname As Label
    Friend WithEvents profilepic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents panelside As Panel
    Friend WithEvents panelusers As Panel
    Friend WithEvents btnusers As Button
    Friend WithEvents panelsteps As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnsteps As Button
    Friend WithEvents panelformula As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnformula As Button
    Friend WithEvents panelsubsetup As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnsetup As Button
    Friend WithEvents btndashboard As Button
    Friend WithEvents panelnav As Panel
    Friend WithEvents panelbody As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse5 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse6 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse7 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse8 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse9 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse10 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse11 As ns1.BunifuElipse
    Friend WithEvents lbltime As Label
    Friend WithEvents btnfullscreen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents panelmsg As Panel
    Friend WithEvents lblmsgclose As Label
    Friend WithEvents lblerror As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Public WithEvents btncategory As Button
    Public WithEvents btnitems As Button
    Public WithEvents btnmanageformula As Button
    Public WithEvents btnproducts As Button
    Public WithEvents btnworkgroups As Button
    Public WithEvents btnmanageusers As Button
    Public WithEvents btnstep4 As Button
    Public WithEvents btnstep3 As Button
    Public WithEvents btnstep2 As Button
    Public WithEvents btnstep1 As Button
    Public WithEvents btnloginlogs As Button
    Public WithEvents btnmodules As Button
    Public WithEvents btnaccess As Button
    Friend WithEvents btnaddaccess As Button
    Friend WithEvents btnlock As Button
End Class
