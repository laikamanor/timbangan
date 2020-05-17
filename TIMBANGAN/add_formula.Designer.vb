<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_formula
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_formula))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbproducts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvitems = New System.Windows.Forms.DataGridView()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valuee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnedit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnremove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvpalaman = New System.Windows.Forms.DataGridView()
        Me.category2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valuee2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnedit2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnremove2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblpalaman = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbaked = New System.Windows.Forms.TextBox()
        Me.txtunbaked = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttdw = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbasewt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtyield = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnadditem = New System.Windows.Forms.Button()
        Me.btnaddpalamanitem = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        CType(Me.dgvitems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvpalaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Formula"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(41, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 162)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(54, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product Name:"
        '
        'cmbproducts
        '
        Me.cmbproducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbproducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbproducts.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbproducts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproducts.ForeColor = System.Drawing.Color.White
        Me.cmbproducts.FormattingEnabled = True
        Me.cmbproducts.Location = New System.Drawing.Point(57, 189)
        Me.cmbproducts.Name = "cmbproducts"
        Me.cmbproducts.Size = New System.Drawing.Size(191, 25)
        Me.cmbproducts.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(54, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Category:"
        '
        'cmbcategory
        '
        Me.cmbcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbcategory.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategory.ForeColor = System.Drawing.Color.White
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Location = New System.Drawing.Point(57, 127)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(191, 25)
        Me.cmbcategory.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(292, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 162)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Location = New System.Drawing.Point(41, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(252, 1)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Location = New System.Drawing.Point(41, 242)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(252, 1)
        Me.Panel4.TabIndex = 4
        '
        'dgvitems
        '
        Me.dgvitems.AllowUserToAddRows = False
        Me.dgvitems.AllowUserToDeleteRows = False
        Me.dgvitems.AllowUserToResizeColumns = False
        Me.dgvitems.AllowUserToResizeRows = False
        Me.dgvitems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvitems.BackgroundColor = System.Drawing.Color.White
        Me.dgvitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvitems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvitems.ColumnHeadersHeight = 40
        Me.dgvitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.category, Me.itemname, Me.valuee, Me.uom, Me.btnedit, Me.btnremove})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvitems.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvitems.EnableHeadersVisualStyles = False
        Me.dgvitems.GridColor = System.Drawing.Color.White
        Me.dgvitems.Location = New System.Drawing.Point(460, 81)
        Me.dgvitems.Name = "dgvitems"
        Me.dgvitems.RowHeadersVisible = False
        Me.dgvitems.Size = New System.Drawing.Size(661, 212)
        Me.dgvitems.TabIndex = 18
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'itemname
        '
        Me.itemname.HeaderText = "Item"
        Me.itemname.Name = "itemname"
        Me.itemname.ReadOnly = True
        '
        'valuee
        '
        Me.valuee.HeaderText = "Value"
        Me.valuee.Name = "valuee"
        Me.valuee.ReadOnly = True
        '
        'uom
        '
        Me.uom.HeaderText = "UOM"
        Me.uom.Name = "uom"
        Me.uom.ReadOnly = True
        '
        'btnedit
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        Me.btnedit.DefaultCellStyle = DataGridViewCellStyle10
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.HeaderText = "Action"
        Me.btnedit.Name = "btnedit"
        Me.btnedit.ReadOnly = True
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseColumnTextForButtonValue = True
        '
        'btnremove
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        Me.btnremove.DefaultCellStyle = DataGridViewCellStyle11
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove.HeaderText = "Action"
        Me.btnremove.Name = "btnremove"
        Me.btnremove.ReadOnly = True
        Me.btnremove.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnremove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseColumnTextForButtonValue = True
        '
        'dgvpalaman
        '
        Me.dgvpalaman.AllowUserToAddRows = False
        Me.dgvpalaman.AllowUserToDeleteRows = False
        Me.dgvpalaman.AllowUserToResizeColumns = False
        Me.dgvpalaman.AllowUserToResizeRows = False
        Me.dgvpalaman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvpalaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvpalaman.BackgroundColor = System.Drawing.Color.White
        Me.dgvpalaman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvpalaman.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvpalaman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpalaman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvpalaman.ColumnHeadersHeight = 40
        Me.dgvpalaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.category2, Me.itemname2, Me.valuee2, Me.UOM2, Me.btnedit2, Me.btnremove2})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpalaman.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvpalaman.EnableHeadersVisualStyles = False
        Me.dgvpalaman.GridColor = System.Drawing.Color.White
        Me.dgvpalaman.Location = New System.Drawing.Point(460, 369)
        Me.dgvpalaman.Name = "dgvpalaman"
        Me.dgvpalaman.RowHeadersVisible = False
        Me.dgvpalaman.Size = New System.Drawing.Size(661, 257)
        Me.dgvpalaman.TabIndex = 19
        '
        'category2
        '
        Me.category2.HeaderText = "Category"
        Me.category2.Name = "category2"
        Me.category2.ReadOnly = True
        '
        'itemname2
        '
        Me.itemname2.HeaderText = "Item"
        Me.itemname2.Name = "itemname2"
        Me.itemname2.ReadOnly = True
        '
        'valuee2
        '
        Me.valuee2.HeaderText = "Value"
        Me.valuee2.Name = "valuee2"
        Me.valuee2.ReadOnly = True
        '
        'UOM2
        '
        Me.UOM2.HeaderText = "UOM"
        Me.UOM2.Name = "UOM2"
        Me.UOM2.ReadOnly = True
        '
        'btnedit2
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        Me.btnedit2.DefaultCellStyle = DataGridViewCellStyle14
        Me.btnedit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit2.HeaderText = "Action"
        Me.btnedit2.Name = "btnedit2"
        Me.btnedit2.ReadOnly = True
        Me.btnedit2.Text = "Edit"
        Me.btnedit2.UseColumnTextForButtonValue = True
        '
        'btnremove2
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        Me.btnremove2.DefaultCellStyle = DataGridViewCellStyle15
        Me.btnremove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove2.HeaderText = "Action"
        Me.btnremove2.Name = "btnremove2"
        Me.btnremove2.ReadOnly = True
        Me.btnremove2.Text = "Remove"
        Me.btnremove2.UseColumnTextForButtonValue = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblpalaman)
        Me.Panel5.Location = New System.Drawing.Point(460, 346)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(661, 24)
        Me.Panel5.TabIndex = 21
        '
        'lblpalaman
        '
        Me.lblpalaman.AutoSize = True
        Me.lblpalaman.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpalaman.ForeColor = System.Drawing.Color.White
        Me.lblpalaman.Location = New System.Drawing.Point(3, 4)
        Me.lblpalaman.Name = "lblpalaman"
        Me.lblpalaman.Size = New System.Drawing.Size(95, 16)
        Me.lblpalaman.TabIndex = 22
        Me.lblpalaman.Text = "Palaman: N/A"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtbaked)
        Me.GroupBox1.Controls.Add(Me.txtunbaked)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txttdw)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtbasewt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(41, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 356)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(13, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(218, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "DW/PC of baked product (grams):"
        '
        'txtbaked
        '
        Me.txtbaked.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbaked.Location = New System.Drawing.Point(16, 252)
        Me.txtbaked.Name = "txtbaked"
        Me.txtbaked.Size = New System.Drawing.Size(357, 26)
        Me.txtbaked.TabIndex = 22
        '
        'txtunbaked
        '
        Me.txtunbaked.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunbaked.Location = New System.Drawing.Point(16, 202)
        Me.txtunbaked.Name = "txtunbaked"
        Me.txtunbaked.Size = New System.Drawing.Size(357, 26)
        Me.txtunbaked.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(13, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "DW/PC of Unbaked product (grams):"
        '
        'txttdw
        '
        Me.txttdw.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttdw.Location = New System.Drawing.Point(16, 150)
        Me.txttdw.Name = "txttdw"
        Me.txttdw.ReadOnly = True
        Me.txttdw.Size = New System.Drawing.Size(357, 26)
        Me.txttdw.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(13, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "TDW (grams):"
        '
        'txtbasewt
        '
        Me.txtbasewt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbasewt.Location = New System.Drawing.Point(16, 98)
        Me.txtbasewt.Name = "txtbasewt"
        Me.txtbasewt.Size = New System.Drawing.Size(357, 26)
        Me.txtbasewt.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(13, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Base WT (Kgs):"
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(16, 46)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(357, 26)
        Me.txtprice.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(13, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Price (Peso):"
        '
        'txtyield
        '
        Me.txtyield.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyield.Location = New System.Drawing.Point(57, 571)
        Me.txtyield.Name = "txtyield"
        Me.txtyield.ReadOnly = True
        Me.txtyield.Size = New System.Drawing.Size(357, 26)
        Me.txtyield.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(54, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Yield per BASE unit (pieces):"
        '
        'btnsubmit
        '
        Me.btnsubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.FlatAppearance.BorderSize = 0
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Location = New System.Drawing.Point(1033, 645)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(88, 37)
        Me.btnsubmit.TabIndex = 25
        Me.btnsubmit.Text = "Save"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1165, 1)
        Me.Panel6.TabIndex = 26
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DimGray
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(1164, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 708)
        Me.Panel7.TabIndex = 27
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DimGray
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(0, 708)
        Me.Panel8.TabIndex = 27
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DimGray
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 708)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1164, 1)
        Me.Panel9.TabIndex = 27
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(1137, 1)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(26, 25)
        Me.btnclose.TabIndex = 28
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnadditem
        '
        Me.btnadditem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnadditem.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnadditem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadditem.FlatAppearance.BorderSize = 0
        Me.btnadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadditem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadditem.ForeColor = System.Drawing.Color.White
        Me.btnadditem.Image = CType(resources.GetObject("btnadditem.Image"), System.Drawing.Image)
        Me.btnadditem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadditem.Location = New System.Drawing.Point(1019, 46)
        Me.btnadditem.Name = "btnadditem"
        Me.btnadditem.Size = New System.Drawing.Size(102, 29)
        Me.btnadditem.TabIndex = 29
        Me.btnadditem.Text = "Add Item"
        Me.btnadditem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadditem.UseVisualStyleBackColor = False
        '
        'btnaddpalamanitem
        '
        Me.btnaddpalamanitem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddpalamanitem.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnaddpalamanitem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddpalamanitem.FlatAppearance.BorderSize = 0
        Me.btnaddpalamanitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddpalamanitem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddpalamanitem.ForeColor = System.Drawing.Color.White
        Me.btnaddpalamanitem.Image = CType(resources.GetObject("btnaddpalamanitem.Image"), System.Drawing.Image)
        Me.btnaddpalamanitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddpalamanitem.Location = New System.Drawing.Point(995, 311)
        Me.btnaddpalamanitem.Name = "btnaddpalamanitem"
        Me.btnaddpalamanitem.Size = New System.Drawing.Size(126, 29)
        Me.btnaddpalamanitem.TabIndex = 30
        Me.btnaddpalamanitem.Text = "Add Palaman"
        Me.btnaddpalamanitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddpalamanitem.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DimGray
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 707)
        Me.Panel10.TabIndex = 31
        '
        'add_formula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1165, 709)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.btnaddpalamanitem)
        Me.Controls.Add(Me.btnadditem)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtyield)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgvpalaman)
        Me.Controls.Add(Me.dgvitems)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbproducts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbcategory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "add_formula"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Formula"
        CType(Me.dgvitems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvpalaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbproducts As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbcategory As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvpalaman As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblpalaman As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbaked As TextBox
    Friend WithEvents txtunbaked As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txttdw As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbasewt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtyield As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents Timer1 As Timer
    Public WithEvents btnadditem As Button
    Public WithEvents btnaddpalamanitem As Button
    Friend WithEvents Panel10 As Panel
    Public WithEvents dgvitems As DataGridView
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents itemname As DataGridViewTextBoxColumn
    Friend WithEvents valuee As DataGridViewTextBoxColumn
    Friend WithEvents uom As DataGridViewTextBoxColumn
    Friend WithEvents btnedit As DataGridViewButtonColumn
    Friend WithEvents btnremove As DataGridViewButtonColumn
    Friend WithEvents category2 As DataGridViewTextBoxColumn
    Friend WithEvents itemname2 As DataGridViewTextBoxColumn
    Friend WithEvents valuee2 As DataGridViewTextBoxColumn
    Friend WithEvents UOM2 As DataGridViewTextBoxColumn
    Friend WithEvents btnedit2 As DataGridViewButtonColumn
    Friend WithEvents btnremove2 As DataGridViewButtonColumn
End Class
