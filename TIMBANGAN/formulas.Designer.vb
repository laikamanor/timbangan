<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formulas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formulas))
        Me.lblheader = New System.Windows.Forms.Label()
        Me.dgvformulas = New System.Windows.Forms.DataGridView()
        Me.formula_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvpalaman = New System.Windows.Forms.DataGridView()
        Me.category2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valuee2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvitems = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valuee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblpalaman = New System.Windows.Forms.Label()
        Me.txtbasewt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbaked = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtyield = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtunbaked = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttdw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btninactiveformula = New System.Windows.Forms.Button()
        Me.btnaddnew = New System.Windows.Forms.Button()
        Me.btnactiveformula = New System.Windows.Forms.Button()
        Me.btnset = New System.Windows.Forms.Button()
        CType(Me.dgvformulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvpalaman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(54, 30)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(166, 32)
        Me.lblheader.TabIndex = 12
        Me.lblheader.Text = "FORMULAS"
        '
        'dgvformulas
        '
        Me.dgvformulas.AllowUserToAddRows = False
        Me.dgvformulas.AllowUserToDeleteRows = False
        Me.dgvformulas.AllowUserToResizeColumns = False
        Me.dgvformulas.AllowUserToResizeRows = False
        Me.dgvformulas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvformulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvformulas.BackgroundColor = System.Drawing.Color.White
        Me.dgvformulas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvformulas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvformulas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvformulas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvformulas.ColumnHeadersHeight = 40
        Me.dgvformulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.formula_id, Me.category, Me.productt})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvformulas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvformulas.EnableHeadersVisualStyles = False
        Me.dgvformulas.GridColor = System.Drawing.Color.White
        Me.dgvformulas.Location = New System.Drawing.Point(60, 152)
        Me.dgvformulas.Name = "dgvformulas"
        Me.dgvformulas.RowHeadersVisible = False
        Me.dgvformulas.Size = New System.Drawing.Size(237, 360)
        Me.dgvformulas.TabIndex = 13
        '
        'formula_id
        '
        Me.formula_id.HeaderText = "ID"
        Me.formula_id.Name = "formula_id"
        Me.formula_id.ReadOnly = True
        Me.formula_id.Visible = False
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'productt
        '
        Me.productt.HeaderText = "Product"
        Me.productt.Name = "productt"
        Me.productt.ReadOnly = True
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.FlatAppearance.BorderSize = 0
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Location = New System.Drawing.Point(230, 121)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(67, 25)
        Me.btnsearch.TabIndex = 16
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(60, 121)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(170, 25)
        Me.txtsearch.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(57, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Category:"
        '
        'cmbcategory
        '
        Me.cmbcategory.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategory.ForeColor = System.Drawing.Color.White
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Location = New System.Drawing.Point(128, 91)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(121, 23)
        Me.cmbcategory.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.dgvpalaman)
        Me.GroupBox1.Controls.Add(Me.dgvitems)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.txtbasewt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtbaked)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtyield)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtunbaked)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttdw)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(320, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 465)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "10 IN 1 BIGDESAL Information Formula"
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpalaman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvpalaman.ColumnHeadersHeight = 40
        Me.dgvpalaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.category2, Me.itemname2, Me.valuee2, Me.UOM2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpalaman.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvpalaman.EnableHeadersVisualStyles = False
        Me.dgvpalaman.GridColor = System.Drawing.Color.White
        Me.dgvpalaman.Location = New System.Drawing.Point(14, 335)
        Me.dgvpalaman.Name = "dgvpalaman"
        Me.dgvpalaman.RowHeadersVisible = False
        Me.dgvpalaman.Size = New System.Drawing.Size(482, 124)
        Me.dgvpalaman.TabIndex = 24
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvitems.ColumnHeadersHeight = 40
        Me.dgvitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.itemname, Me.valuee, Me.uom})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvitems.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvitems.EnableHeadersVisualStyles = False
        Me.dgvitems.GridColor = System.Drawing.Color.White
        Me.dgvitems.Location = New System.Drawing.Point(14, 180)
        Me.dgvitems.Name = "dgvitems"
        Me.dgvitems.RowHeadersVisible = False
        Me.dgvitems.Size = New System.Drawing.Size(482, 125)
        Me.dgvitems.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblpalaman)
        Me.Panel5.Location = New System.Drawing.Point(14, 311)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(482, 24)
        Me.Panel5.TabIndex = 23
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
        'txtbasewt
        '
        Me.txtbasewt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbasewt.BackColor = System.Drawing.Color.White
        Me.txtbasewt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbasewt.Location = New System.Drawing.Point(175, 151)
        Me.txtbasewt.Name = "txtbasewt"
        Me.txtbasewt.ReadOnly = True
        Me.txtbasewt.Size = New System.Drawing.Size(321, 23)
        Me.txtbasewt.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(172, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Base WT (Kgs.):"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.White
        Me.txtprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(14, 151)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = True
        Me.txtprice.Size = New System.Drawing.Size(155, 23)
        Me.txtprice.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Price (Peso):"
        '
        'txtbaked
        '
        Me.txtbaked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbaked.BackColor = System.Drawing.Color.White
        Me.txtbaked.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbaked.Location = New System.Drawing.Point(175, 99)
        Me.txtbaked.Name = "txtbaked"
        Me.txtbaked.ReadOnly = True
        Me.txtbaked.Size = New System.Drawing.Size(321, 23)
        Me.txtbaked.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DW/PC of BAKED product (grams):"
        '
        'txtyield
        '
        Me.txtyield.BackColor = System.Drawing.Color.White
        Me.txtyield.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyield.Location = New System.Drawing.Point(14, 99)
        Me.txtyield.Name = "txtyield"
        Me.txtyield.ReadOnly = True
        Me.txtyield.Size = New System.Drawing.Size(155, 23)
        Me.txtyield.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "YIELD per BASE (pieces):"
        '
        'txtunbaked
        '
        Me.txtunbaked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtunbaked.BackColor = System.Drawing.Color.White
        Me.txtunbaked.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunbaked.Location = New System.Drawing.Point(175, 49)
        Me.txtunbaked.Name = "txtunbaked"
        Me.txtunbaked.ReadOnly = True
        Me.txtunbaked.Size = New System.Drawing.Size(321, 23)
        Me.txtunbaked.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DW/PC of UNBAKED product (grams):"
        '
        'txttdw
        '
        Me.txttdw.BackColor = System.Drawing.Color.White
        Me.txttdw.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttdw.Location = New System.Drawing.Point(14, 49)
        Me.txttdw.Name = "txttdw"
        Me.txttdw.ReadOnly = True
        Me.txttdw.Size = New System.Drawing.Size(155, 23)
        Me.txttdw.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TDW (grams):"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btninactiveformula
        '
        Me.btninactiveformula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btninactiveformula.BackColor = System.Drawing.Color.DodgerBlue
        Me.btninactiveformula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninactiveformula.FlatAppearance.BorderSize = 0
        Me.btninactiveformula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninactiveformula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninactiveformula.ForeColor = System.Drawing.Color.White
        Me.btninactiveformula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninactiveformula.Location = New System.Drawing.Point(583, 33)
        Me.btninactiveformula.Name = "btninactiveformula"
        Me.btninactiveformula.Size = New System.Drawing.Size(135, 29)
        Me.btninactiveformula.TabIndex = 22
        Me.btninactiveformula.Text = "In Active Formula"
        Me.btninactiveformula.UseVisualStyleBackColor = False
        '
        'btnaddnew
        '
        Me.btnaddnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddnew.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnaddnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddnew.FlatAppearance.BorderSize = 0
        Me.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddnew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnew.ForeColor = System.Drawing.Color.White
        Me.btnaddnew.Image = CType(resources.GetObject("btnaddnew.Image"), System.Drawing.Image)
        Me.btnaddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddnew.Location = New System.Drawing.Point(724, 33)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(102, 29)
        Me.btnaddnew.TabIndex = 21
        Me.btnaddnew.Text = "Add New"
        Me.btnaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddnew.UseVisualStyleBackColor = False
        '
        'btnactiveformula
        '
        Me.btnactiveformula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnactiveformula.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnactiveformula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactiveformula.FlatAppearance.BorderSize = 0
        Me.btnactiveformula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactiveformula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactiveformula.ForeColor = System.Drawing.Color.Black
        Me.btnactiveformula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactiveformula.Location = New System.Drawing.Point(442, 33)
        Me.btnactiveformula.Name = "btnactiveformula"
        Me.btnactiveformula.Size = New System.Drawing.Size(135, 29)
        Me.btnactiveformula.TabIndex = 23
        Me.btnactiveformula.Text = "Active Formula"
        Me.btnactiveformula.UseVisualStyleBackColor = False
        '
        'btnset
        '
        Me.btnset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnset.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnset.FlatAppearance.BorderSize = 0
        Me.btnset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnset.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnset.ForeColor = System.Drawing.Color.White
        Me.btnset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnset.Location = New System.Drawing.Point(60, 518)
        Me.btnset.Name = "btnset"
        Me.btnset.Size = New System.Drawing.Size(121, 29)
        Me.btnset.TabIndex = 24
        Me.btnset.Text = "Set to In Active"
        Me.btnset.UseVisualStyleBackColor = False
        Me.btnset.Visible = False
        '
        'formulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 584)
        Me.Controls.Add(Me.btnset)
        Me.Controls.Add(Me.btnactiveformula)
        Me.Controls.Add(Me.btninactiveformula)
        Me.Controls.Add(Me.btnaddnew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbcategory)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.dgvformulas)
        Me.Controls.Add(Me.lblheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formulas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvformulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvpalaman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblheader As Label
    Friend WithEvents dgvformulas As DataGridView
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbcategory As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttdw As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtunbaked As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbaked As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtyield As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbasewt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblpalaman As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents btnaddnew As Button
    Public WithEvents dgvitems As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents itemname As DataGridViewTextBoxColumn
    Friend WithEvents valuee As DataGridViewTextBoxColumn
    Friend WithEvents uom As DataGridViewTextBoxColumn
    Friend WithEvents dgvpalaman As DataGridView
    Friend WithEvents category2 As DataGridViewTextBoxColumn
    Friend WithEvents itemname2 As DataGridViewTextBoxColumn
    Friend WithEvents valuee2 As DataGridViewTextBoxColumn
    Friend WithEvents UOM2 As DataGridViewTextBoxColumn
    Public WithEvents btninactiveformula As Button
    Public WithEvents btnactiveformula As Button
    Friend WithEvents formula_id As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents productt As DataGridViewTextBoxColumn
    Public WithEvents btnset As Button
End Class
