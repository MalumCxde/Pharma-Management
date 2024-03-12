<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicinePage
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
        Me.txtMedicine = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBuyingPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSellingPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CompCb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtgMedicine = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.EditBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpExpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(867, 100)
        Me.Panel1.TabIndex = 1
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = Global.Pharma_Management.My.Resources.Resources.logoff_removebg_preview
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(711, 9)
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
        Me.Label2.Location = New System.Drawing.Point(346, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Medicine"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sizwe Pharma"
        '
        'txtMedicine
        '
        Me.txtMedicine.BorderRadius = 2
        Me.txtMedicine.BorderThickness = 0
        Me.txtMedicine.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMedicine.DefaultText = ""
        Me.txtMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicine.DisabledState.Parent = Me.txtMedicine
        Me.txtMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicine.FocusedState.Parent = Me.txtMedicine
        Me.txtMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicine.HoverState.Parent = Me.txtMedicine
        Me.txtMedicine.Location = New System.Drawing.Point(29, 131)
        Me.txtMedicine.Name = "txtMedicine"
        Me.txtMedicine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMedicine.PlaceholderText = "Medicine Name"
        Me.txtMedicine.SelectedText = ""
        Me.txtMedicine.ShadowDecoration.Parent = Me.txtMedicine
        Me.txtMedicine.Size = New System.Drawing.Size(187, 35)
        Me.txtMedicine.TabIndex = 3
        '
        'txtBuyingPrice
        '
        Me.txtBuyingPrice.BorderRadius = 2
        Me.txtBuyingPrice.BorderThickness = 0
        Me.txtBuyingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuyingPrice.DefaultText = ""
        Me.txtBuyingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuyingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuyingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuyingPrice.DisabledState.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuyingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuyingPrice.FocusedState.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuyingPrice.HoverState.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.Location = New System.Drawing.Point(29, 172)
        Me.txtBuyingPrice.Name = "txtBuyingPrice"
        Me.txtBuyingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuyingPrice.PlaceholderText = "Buying Price"
        Me.txtBuyingPrice.SelectedText = ""
        Me.txtBuyingPrice.ShadowDecoration.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.Size = New System.Drawing.Size(187, 35)
        Me.txtBuyingPrice.TabIndex = 4
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.BorderRadius = 2
        Me.txtSellingPrice.BorderThickness = 0
        Me.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSellingPrice.DefaultText = ""
        Me.txtSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSellingPrice.DisabledState.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSellingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSellingPrice.FocusedState.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSellingPrice.HoverState.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.Location = New System.Drawing.Point(29, 213)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSellingPrice.PlaceholderText = "Selling Price"
        Me.txtSellingPrice.SelectedText = ""
        Me.txtSellingPrice.ShadowDecoration.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.Size = New System.Drawing.Size(187, 35)
        Me.txtSellingPrice.TabIndex = 5
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderRadius = 2
        Me.txtQuantity.BorderThickness = 0
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.Parent = Me.txtQuantity
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.FocusedState.Parent = Me.txtQuantity
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.HoverState.Parent = Me.txtQuantity
        Me.txtQuantity.Location = New System.Drawing.Point(29, 254)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.PlaceholderText = "Quantity"
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.ShadowDecoration.Parent = Me.txtQuantity
        Me.txtQuantity.Size = New System.Drawing.Size(187, 35)
        Me.txtQuantity.TabIndex = 6
        '
        'CompCb
        '
        Me.CompCb.BackColor = System.Drawing.Color.Transparent
        Me.CompCb.BorderRadius = 2
        Me.CompCb.BorderThickness = 0
        Me.CompCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CompCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompCb.FocusedColor = System.Drawing.Color.Empty
        Me.CompCb.FocusedState.Parent = Me.CompCb
        Me.CompCb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CompCb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CompCb.FormattingEnabled = True
        Me.CompCb.HoverState.Parent = Me.CompCb
        Me.CompCb.ItemHeight = 30
        Me.CompCb.ItemsAppearance.Parent = Me.CompCb
        Me.CompCb.Location = New System.Drawing.Point(29, 346)
        Me.CompCb.Name = "CompCb"
        Me.CompCb.ShadowDecoration.Parent = Me.CompCb
        Me.CompCb.Size = New System.Drawing.Size(187, 36)
        Me.CompCb.TabIndex = 7
        '
        'dtgMedicine
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtgMedicine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgMedicine.BackgroundColor = System.Drawing.Color.White
        Me.dtgMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgMedicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMedicine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgMedicine.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgMedicine.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgMedicine.EnableHeadersVisualStyles = False
        Me.dtgMedicine.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgMedicine.Location = New System.Drawing.Point(255, 131)
        Me.dtgMedicine.Name = "dtgMedicine"
        Me.dtgMedicine.RowHeadersVisible = False
        Me.dtgMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMedicine.Size = New System.Drawing.Size(600, 344)
        Me.dtgMedicine.TabIndex = 8
        Me.dtgMedicine.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dtgMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgMedicine.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgMedicine.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgMedicine.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgMedicine.ThemeStyle.HeaderStyle.Height = 4
        Me.dtgMedicine.ThemeStyle.ReadOnly = False
        Me.dtgMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgMedicine.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgMedicine.ThemeStyle.RowsStyle.Height = 22
        Me.dtgMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Medicine List"
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
        Me.btnAdd.Location = New System.Drawing.Point(29, 399)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(58, 32)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        '
        'EditBtn
        '
        Me.EditBtn.BorderRadius = 5
        Me.EditBtn.CheckedState.Parent = Me.EditBtn
        Me.EditBtn.CustomImages.Parent = Me.EditBtn
        Me.EditBtn.FillColor = System.Drawing.Color.Teal
        Me.EditBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.HoverState.Parent = Me.EditBtn
        Me.EditBtn.Location = New System.Drawing.Point(93, 399)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.ShadowDecoration.Parent = Me.EditBtn
        Me.EditBtn.Size = New System.Drawing.Size(58, 32)
        Me.EditBtn.TabIndex = 11
        Me.EditBtn.Text = "Edit"
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 5
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.Teal
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(158, 399)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(58, 32)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        '
        'btnBack
        '
        Me.btnBack.BorderRadius = 5
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.Teal
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(93, 437)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(58, 32)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 481)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(867, 10)
        Me.Panel2.TabIndex = 14
        '
        'dtpExpDate
        '
        Me.dtpExpDate.BorderRadius = 2
        Me.dtpExpDate.CheckedState.Parent = Me.dtpExpDate
        Me.dtpExpDate.FillColor = System.Drawing.Color.Teal
        Me.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpExpDate.HoverState.Parent = Me.dtpExpDate
        Me.dtpExpDate.Location = New System.Drawing.Point(29, 304)
        Me.dtpExpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpExpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpExpDate.Name = "dtpExpDate"
        Me.dtpExpDate.ShadowDecoration.Parent = Me.dtpExpDate
        Me.dtpExpDate.Size = New System.Drawing.Size(187, 36)
        Me.dtpExpDate.TabIndex = 15
        Me.dtpExpDate.Value = New Date(2024, 3, 12, 14, 59, 16, 829)
        '
        'MedicinePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 491)
        Me.Controls.Add(Me.dtpExpDate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtgMedicine)
        Me.Controls.Add(Me.CompCb)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtSellingPrice)
        Me.Controls.Add(Me.txtBuyingPrice)
        Me.Controls.Add(Me.txtMedicine)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MedicinePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MedicinePage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMedicine As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBuyingPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSellingPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CompCb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtgMedicine As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EditBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpExpDate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
