<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formula_add_item
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
        Me.lblheader = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelmsg = New System.Windows.Forms.Panel()
        Me.lblmsgclose = New System.Windows.Forms.Label()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.txtuom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvalue = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.cmbitems = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelmsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(37, 45)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(178, 24)
        Me.lblheader.TabIndex = 17
        Me.lblheader.Text = "Add Palaman Item"
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(334, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(26, 25)
        Me.btnclose.TabIndex = 29
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(358, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 438)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 437)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(358, 1)
        Me.Panel2.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(358, 1)
        Me.Panel3.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 436)
        Me.Panel4.TabIndex = 31
        '
        'panelmsg
        '
        Me.panelmsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelmsg.Controls.Add(Me.lblmsgclose)
        Me.panelmsg.Controls.Add(Me.lblerror)
        Me.panelmsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelmsg.Location = New System.Drawing.Point(1, 1)
        Me.panelmsg.Name = "panelmsg"
        Me.panelmsg.Size = New System.Drawing.Size(357, 27)
        Me.panelmsg.TabIndex = 38
        Me.panelmsg.Visible = False
        '
        'lblmsgclose
        '
        Me.lblmsgclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmsgclose.AutoSize = True
        Me.lblmsgclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmsgclose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgclose.ForeColor = System.Drawing.Color.White
        Me.lblmsgclose.Location = New System.Drawing.Point(337, 5)
        Me.lblmsgclose.Name = "lblmsgclose"
        Me.lblmsgclose.Size = New System.Drawing.Size(17, 16)
        Me.lblmsgclose.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(38, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 27
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
        Me.cmbcategory.Location = New System.Drawing.Point(41, 122)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(285, 25)
        Me.cmbcategory.TabIndex = 0
        '
        'txtuom
        '
        Me.txtuom.BackColor = System.Drawing.Color.White
        Me.txtuom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuom.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtuom.Enabled = False
        Me.txtuom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuom.Location = New System.Drawing.Point(41, 253)
        Me.txtuom.Name = "txtuom"
        Me.txtuom.ReadOnly = True
        Me.txtuom.Size = New System.Drawing.Size(285, 19)
        Me.txtuom.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(38, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "UOM:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(38, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Item:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(38, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Value:"
        '
        'txtvalue
        '
        Me.txtvalue.BackColor = System.Drawing.Color.White
        Me.txtvalue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtvalue.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalue.Location = New System.Drawing.Point(41, 318)
        Me.txtvalue.Name = "txtvalue"
        Me.txtvalue.Size = New System.Drawing.Size(285, 26)
        Me.txtvalue.TabIndex = 2
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.FlatAppearance.BorderSize = 0
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Location = New System.Drawing.Point(41, 368)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(285, 36)
        Me.btnsubmit.TabIndex = 3
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'cmbitems
        '
        Me.cmbitems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbitems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbitems.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbitems.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbitems.ForeColor = System.Drawing.Color.White
        Me.cmbitems.FormattingEnabled = True
        Me.cmbitems.Location = New System.Drawing.Point(41, 185)
        Me.cmbitems.Name = "cmbitems"
        Me.cmbitems.Size = New System.Drawing.Size(285, 25)
        Me.cmbitems.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'formula_add_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 438)
        Me.Controls.Add(Me.cmbitems)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtvalue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtuom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbcategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelmsg)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblheader)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "formula_add_item"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formula_add_item"
        Me.panelmsg.ResumeLayout(False)
        Me.panelmsg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblheader As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelmsg As Panel
    Friend WithEvents lblmsgclose As Label
    Friend WithEvents lblerror As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbcategory As ComboBox
    Friend WithEvents txtuom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtvalue As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents cmbitems As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
