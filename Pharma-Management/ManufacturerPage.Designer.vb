<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManufacturerPage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.EditBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgManufacturer = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhoneNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConpanyID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgManufacturer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(803, 100)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Manufacturer"
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
        'btnBack
        '
        Me.btnBack.BorderRadius = 5
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.Teal
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(112, 443)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(58, 32)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Back"
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
        Me.btnDelete.Location = New System.Drawing.Point(177, 405)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(58, 32)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
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
        Me.EditBtn.Location = New System.Drawing.Point(112, 405)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.ShadowDecoration.Parent = Me.EditBtn
        Me.EditBtn.Size = New System.Drawing.Size(58, 32)
        Me.EditBtn.TabIndex = 22
        Me.EditBtn.Text = "Edit"
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
        Me.btnAdd.Location = New System.Drawing.Point(48, 405)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(58, 32)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(484, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Manufacturer List"
        '
        'dtgManufacturer
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtgManufacturer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgManufacturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgManufacturer.BackgroundColor = System.Drawing.Color.White
        Me.dtgManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgManufacturer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgManufacturer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgManufacturer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgManufacturer.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgManufacturer.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgManufacturer.EnableHeadersVisualStyles = False
        Me.dtgManufacturer.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgManufacturer.Location = New System.Drawing.Point(274, 137)
        Me.dtgManufacturer.Name = "dtgManufacturer"
        Me.dtgManufacturer.RowHeadersVisible = False
        Me.dtgManufacturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgManufacturer.Size = New System.Drawing.Size(514, 338)
        Me.dtgManufacturer.TabIndex = 19
        Me.dtgManufacturer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dtgManufacturer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgManufacturer.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgManufacturer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgManufacturer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgManufacturer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgManufacturer.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgManufacturer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgManufacturer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgManufacturer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgManufacturer.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgManufacturer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgManufacturer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgManufacturer.ThemeStyle.HeaderStyle.Height = 4
        Me.dtgManufacturer.ThemeStyle.ReadOnly = False
        Me.dtgManufacturer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgManufacturer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgManufacturer.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgManufacturer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgManufacturer.ThemeStyle.RowsStyle.Height = 22
        Me.dtgManufacturer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgManufacturer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtAddress
        '
        Me.txtAddress.BorderRadius = 2
        Me.txtAddress.BorderThickness = 0
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.Parent = Me.txtAddress
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.FocusedState.Parent = Me.txtAddress
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.HoverState.Parent = Me.txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(48, 297)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = "Address"
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.ShadowDecoration.Parent = Me.txtAddress
        Me.txtAddress.Size = New System.Drawing.Size(187, 35)
        Me.txtAddress.TabIndex = 17
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BorderRadius = 2
        Me.txtPhoneNumber.BorderThickness = 0
        Me.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNumber.DefaultText = ""
        Me.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.Parent = Me.txtPhoneNumber
        Me.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.FocusedState.Parent = Me.txtPhoneNumber
        Me.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.HoverState.Parent = Me.txtPhoneNumber
        Me.txtPhoneNumber.Location = New System.Drawing.Point(48, 256)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNumber.PlaceholderText = "Phone Number"
        Me.txtPhoneNumber.SelectedText = ""
        Me.txtPhoneNumber.ShadowDecoration.Parent = Me.txtPhoneNumber
        Me.txtPhoneNumber.Size = New System.Drawing.Size(187, 35)
        Me.txtPhoneNumber.TabIndex = 16
        '
        'txtCompanyName
        '
        Me.txtCompanyName.BorderRadius = 2
        Me.txtCompanyName.BorderThickness = 0
        Me.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyName.DefaultText = ""
        Me.txtCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.DisabledState.Parent = Me.txtCompanyName
        Me.txtCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyName.FocusedState.Parent = Me.txtCompanyName
        Me.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyName.HoverState.Parent = Me.txtCompanyName
        Me.txtCompanyName.Location = New System.Drawing.Point(48, 215)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyName.PlaceholderText = "CompanyName"
        Me.txtCompanyName.SelectedText = ""
        Me.txtCompanyName.ShadowDecoration.Parent = Me.txtCompanyName
        Me.txtCompanyName.Size = New System.Drawing.Size(187, 35)
        Me.txtCompanyName.TabIndex = 15
        '
        'txtConpanyID
        '
        Me.txtConpanyID.BorderRadius = 2
        Me.txtConpanyID.BorderThickness = 0
        Me.txtConpanyID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConpanyID.DefaultText = ""
        Me.txtConpanyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConpanyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConpanyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConpanyID.DisabledState.Parent = Me.txtConpanyID
        Me.txtConpanyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConpanyID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConpanyID.FocusedState.Parent = Me.txtConpanyID
        Me.txtConpanyID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConpanyID.HoverState.Parent = Me.txtConpanyID
        Me.txtConpanyID.Location = New System.Drawing.Point(48, 174)
        Me.txtConpanyID.Name = "txtConpanyID"
        Me.txtConpanyID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConpanyID.PlaceholderText = "Conpany ID"
        Me.txtConpanyID.SelectedText = ""
        Me.txtConpanyID.ShadowDecoration.Parent = Me.txtConpanyID
        Me.txtConpanyID.Size = New System.Drawing.Size(187, 35)
        Me.txtConpanyID.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 497)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 10)
        Me.Panel2.TabIndex = 25
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
        'ManufacturerPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 507)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtgManufacturer)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.txtConpanyID)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManufacturerPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManufacturerPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgManufacturer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EditBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgManufacturer As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConpanyID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
End Class
