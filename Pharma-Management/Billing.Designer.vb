<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgAgent = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Guna2PictureBox5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 100)
        Me.Panel1.TabIndex = 4
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = Global.Pharma_Management.My.Resources.Resources.logoff_removebg_preview
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(732, 12)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.ShadowDecoration.Parent = Me.Guna2PictureBox5
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(56, 28)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox5.TabIndex = 11
        Me.Guna2PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Billing"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sizwe Pharma"
        '
        'dtgAgent
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtgAgent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgAgent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgAgent.BackgroundColor = System.Drawing.Color.White
        Me.dtgAgent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgAgent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgAgent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgAgent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgAgent.ColumnHeadersHeight = 25
        Me.dtgAgent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgAgent.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgAgent.EnableHeadersVisualStyles = False
        Me.dtgAgent.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgAgent.Location = New System.Drawing.Point(264, 106)
        Me.dtgAgent.Name = "dtgAgent"
        Me.dtgAgent.RowHeadersVisible = False
        Me.dtgAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgAgent.Size = New System.Drawing.Size(524, 358)
        Me.dtgAgent.TabIndex = 31
        Me.dtgAgent.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dtgAgent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgAgent.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgAgent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgAgent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgAgent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgAgent.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgAgent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgAgent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgAgent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgAgent.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgAgent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgAgent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgAgent.ThemeStyle.HeaderStyle.Height = 25
        Me.dtgAgent.ThemeStyle.ReadOnly = False
        Me.dtgAgent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgAgent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgAgent.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgAgent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgAgent.ThemeStyle.RowsStyle.Height = 22
        Me.dtgAgent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgAgent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "MedID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "MedName"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "UnitPrice"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TotalPrice"
        Me.Column5.Name = "Column5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Billing Form"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderRadius = 2
        Me.Guna2ComboBox1.BorderThickness = 0
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.FormattingEnabled = True
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(49, 165)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(187, 36)
        Me.Guna2ComboBox1.TabIndex = 33
        '
        'btnAdd
        '
        Me.btnAdd.BorderRadius = 5
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.Teal
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(366, 471)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(127, 32)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Print"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Teal
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(522, 470)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(127, 32)
        Me.Guna2Button1.TabIndex = 35
        Me.Guna2Button1.Text = "Back"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.BorderRadius = 2
        Me.txtEmployeeID.BorderThickness = 0
        Me.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployeeID.DefaultText = ""
        Me.txtEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeID.DisabledState.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployeeID.FocusedState.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployeeID.HoverState.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.Location = New System.Drawing.Point(49, 251)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeID.PlaceholderText = "Quantity"
        Me.txtEmployeeID.SelectedText = ""
        Me.txtEmployeeID.ShadowDecoration.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.Size = New System.Drawing.Size(187, 35)
        Me.txtEmployeeID.TabIndex = 36
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Teal
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(76, 292)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(127, 32)
        Me.Guna2Button2.TabIndex = 37
        Me.Guna2Button2.Text = "Add to bill"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Available Stock"
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 515)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Guna2ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtgAgent)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgAgent As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
End Class
