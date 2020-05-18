<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class step2_viewbatch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.lblproduct = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvitems = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvpalaman = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbatches = New System.Windows.Forms.ComboBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblstepnum = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblbatchquantity = New System.Windows.Forms.Label()
        Me.lbltdw = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblitemsnocount = New System.Windows.Forms.Label()
        Me.lblpalamannocount = New System.Windows.Forms.Label()
        CType(Me.dgvitems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvpalaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(54, 42)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(219, 32)
        Me.lblheader.TabIndex = 16
        Me.lblheader.Text = "VIEW BATCHES"
        '
        'lblproduct
        '
        Me.lblproduct.AutoSize = True
        Me.lblproduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproduct.Location = New System.Drawing.Point(204, 161)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(157, 18)
        Me.lblproduct.TabIndex = 20
        Me.lblproduct.Text = "P(1) 10 IN 1 Bigdesal"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.Location = New System.Drawing.Point(204, 131)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(59, 18)
        Me.lblcategory.TabIndex = 19
        Me.lblcategory.Text = "Breads"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(58, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Product:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(58, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Category:"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(203, 195)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(35, 18)
        Me.lblquantity.TabIndex = 22
        Me.lblquantity.Text = "100"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(58, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Target Quantity:"
        '
        'dgvitems
        '
        Me.dgvitems.AllowUserToAddRows = False
        Me.dgvitems.AllowUserToDeleteRows = False
        Me.dgvitems.AllowUserToResizeColumns = False
        Me.dgvitems.AllowUserToResizeRows = False
        Me.dgvitems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvitems.BackgroundColor = System.Drawing.Color.White
        Me.dgvitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvitems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvitems.ColumnHeadersHeight = 40
        Me.dgvitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.value, Me.actual})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvitems.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvitems.EnableHeadersVisualStyles = False
        Me.dgvitems.GridColor = System.Drawing.Color.White
        Me.dgvitems.Location = New System.Drawing.Point(61, 323)
        Me.dgvitems.Name = "dgvitems"
        Me.dgvitems.RowHeadersVisible = False
        Me.dgvitems.Size = New System.Drawing.Size(392, 196)
        Me.dgvitems.TabIndex = 40
        '
        'item
        '
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        '
        'value
        '
        Me.value.HeaderText = "Value"
        Me.value.Name = "value"
        Me.value.ReadOnly = True
        '
        'actual
        '
        Me.actual.HeaderText = "Actual"
        Me.actual.Name = "actual"
        Me.actual.ReadOnly = True
        '
        'dgvpalaman
        '
        Me.dgvpalaman.AllowUserToAddRows = False
        Me.dgvpalaman.AllowUserToDeleteRows = False
        Me.dgvpalaman.AllowUserToResizeColumns = False
        Me.dgvpalaman.AllowUserToResizeRows = False
        Me.dgvpalaman.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvpalaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvpalaman.BackgroundColor = System.Drawing.Color.White
        Me.dgvpalaman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvpalaman.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvpalaman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpalaman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvpalaman.ColumnHeadersHeight = 40
        Me.dgvpalaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpalaman.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvpalaman.EnableHeadersVisualStyles = False
        Me.dgvpalaman.GridColor = System.Drawing.Color.White
        Me.dgvpalaman.Location = New System.Drawing.Point(469, 323)
        Me.dgvpalaman.Name = "dgvpalaman"
        Me.dgvpalaman.RowHeadersVisible = False
        Me.dgvpalaman.Size = New System.Drawing.Size(409, 196)
        Me.dgvpalaman.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Actual"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(58, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 14)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Batch:"
        '
        'cmbatches
        '
        Me.cmbatches.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbatches.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbatches.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbatches.ForeColor = System.Drawing.Color.White
        Me.cmbatches.FormattingEnabled = True
        Me.cmbatches.Location = New System.Drawing.Point(109, 296)
        Me.cmbatches.Name = "cmbatches"
        Me.cmbatches.Size = New System.Drawing.Size(141, 23)
        Me.cmbatches.Sorted = True
        Me.cmbatches.TabIndex = 42
        Me.cmbatches.Tag = ""
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(858, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(42, 38)
        Me.btnclose.TabIndex = 44
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblstepnum
        '
        Me.lblstepnum.AutoSize = True
        Me.lblstepnum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstepnum.Location = New System.Drawing.Point(204, 102)
        Me.lblstepnum.Name = "lblstepnum"
        Me.lblstepnum.Size = New System.Drawing.Size(34, 18)
        Me.lblstepnum.TabIndex = 46
        Me.lblstepnum.Text = "N/A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(58, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "STEP 1 #:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 1)
        Me.Panel1.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 542)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(902, 1)
        Me.Panel2.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 541)
        Me.Panel3.TabIndex = 50
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(901, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 541)
        Me.Panel4.TabIndex = 50
        '
        'lblbatchquantity
        '
        Me.lblbatchquantity.BackColor = System.Drawing.Color.Transparent
        Me.lblbatchquantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbatchquantity.ForeColor = System.Drawing.Color.DimGray
        Me.lblbatchquantity.Location = New System.Drawing.Point(289, 302)
        Me.lblbatchquantity.Name = "lblbatchquantity"
        Me.lblbatchquantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblbatchquantity.Size = New System.Drawing.Size(167, 18)
        Me.lblbatchquantity.TabIndex = 51
        Me.lblbatchquantity.Text = "Batch Quantity: 0"
        '
        'lbltdw
        '
        Me.lbltdw.AutoSize = True
        Me.lbltdw.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltdw.Location = New System.Drawing.Point(203, 231)
        Me.lbltdw.Name = "lbltdw"
        Me.lbltdw.Size = New System.Drawing.Size(35, 18)
        Me.lbltdw.TabIndex = 53
        Me.lbltdw.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(58, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "TDW:"
        '
        'lblitemsnocount
        '
        Me.lblitemsnocount.AutoSize = True
        Me.lblitemsnocount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemsnocount.ForeColor = System.Drawing.Color.DimGray
        Me.lblitemsnocount.Location = New System.Drawing.Point(215, 384)
        Me.lblitemsnocount.Name = "lblitemsnocount"
        Me.lblitemsnocount.Size = New System.Drawing.Size(92, 16)
        Me.lblitemsnocount.TabIndex = 54
        Me.lblitemsnocount.Text = "No data fetch"
        '
        'lblpalamannocount
        '
        Me.lblpalamannocount.AutoSize = True
        Me.lblpalamannocount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpalamannocount.ForeColor = System.Drawing.Color.DimGray
        Me.lblpalamannocount.Location = New System.Drawing.Point(638, 384)
        Me.lblpalamannocount.Name = "lblpalamannocount"
        Me.lblpalamannocount.Size = New System.Drawing.Size(92, 16)
        Me.lblpalamannocount.TabIndex = 55
        Me.lblpalamannocount.Text = "No data fetch"
        '
        'step2_viewbatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 543)
        Me.Controls.Add(Me.lblpalamannocount)
        Me.Controls.Add(Me.lblitemsnocount)
        Me.Controls.Add(Me.lbltdw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblbatchquantity)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblstepnum)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbatches)
        Me.Controls.Add(Me.dgvpalaman)
        Me.Controls.Add(Me.dgvitems)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblproduct)
        Me.Controls.Add(Me.lblcategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "step2_viewbatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "step2_viewbatch"
        CType(Me.dgvitems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvpalaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblheader As Label
    Friend WithEvents lblproduct As Label
    Friend WithEvents lblcategory As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvitems As DataGridView
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents value As DataGridViewTextBoxColumn
    Friend WithEvents actual As DataGridViewTextBoxColumn
    Friend WithEvents dgvpalaman As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbatches As ComboBox
    Friend WithEvents btnclose As Button
    Friend WithEvents lblstepnum As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblbatchquantity As Label
    Friend WithEvents lbltdw As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblitemsnocount As Label
    Friend WithEvents lblpalamannocount As Label
End Class
