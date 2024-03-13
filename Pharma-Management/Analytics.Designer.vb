<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Analytics
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMedicineData = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEmployeeData = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPriceData = New Guna.UI2.WinForms.Guna2Button()
        Me.chtData = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(900, 100)
        Me.Panel1.TabIndex = 5
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = Global.Pharma_Management.My.Resources.Resources.logoff_removebg_preview
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(457, 12)
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
        Me.Label2.Location = New System.Drawing.Point(240, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Charts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sizwe Pharma"
        '
        'btnMedicineData
        '
        Me.btnMedicineData.CheckedState.Parent = Me.btnMedicineData
        Me.btnMedicineData.CustomImages.Parent = Me.btnMedicineData
        Me.btnMedicineData.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMedicineData.ForeColor = System.Drawing.Color.White
        Me.btnMedicineData.HoverState.Parent = Me.btnMedicineData
        Me.btnMedicineData.Location = New System.Drawing.Point(31, 151)
        Me.btnMedicineData.Name = "btnMedicineData"
        Me.btnMedicineData.ShadowDecoration.Parent = Me.btnMedicineData
        Me.btnMedicineData.Size = New System.Drawing.Size(123, 45)
        Me.btnMedicineData.TabIndex = 6
        Me.btnMedicineData.Text = "Medicine Data"
        '
        'btnEmployeeData
        '
        Me.btnEmployeeData.CheckedState.Parent = Me.btnEmployeeData
        Me.btnEmployeeData.CustomImages.Parent = Me.btnEmployeeData
        Me.btnEmployeeData.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEmployeeData.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeData.HoverState.Parent = Me.btnEmployeeData
        Me.btnEmployeeData.Location = New System.Drawing.Point(31, 202)
        Me.btnEmployeeData.Name = "btnEmployeeData"
        Me.btnEmployeeData.ShadowDecoration.Parent = Me.btnEmployeeData
        Me.btnEmployeeData.Size = New System.Drawing.Size(123, 43)
        Me.btnEmployeeData.TabIndex = 7
        Me.btnEmployeeData.Text = "Employee Data"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(31, 301)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(123, 43)
        Me.Guna2Button3.TabIndex = 8
        Me.Guna2Button3.Text = "Guna2Button3"
        '
        'btnPriceData
        '
        Me.btnPriceData.CheckedState.Parent = Me.btnPriceData
        Me.btnPriceData.CustomImages.Parent = Me.btnPriceData
        Me.btnPriceData.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPriceData.ForeColor = System.Drawing.Color.White
        Me.btnPriceData.HoverState.Parent = Me.btnPriceData
        Me.btnPriceData.Location = New System.Drawing.Point(31, 251)
        Me.btnPriceData.Name = "btnPriceData"
        Me.btnPriceData.ShadowDecoration.Parent = Me.btnPriceData
        Me.btnPriceData.Size = New System.Drawing.Size(123, 44)
        Me.btnPriceData.TabIndex = 9
        Me.btnPriceData.Text = "Price Data"
        '
        'chtData
        '
        ChartArea3.Name = "ChartArea1"
        Me.chtData.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chtData.Legends.Add(Legend3)
        Me.chtData.Location = New System.Drawing.Point(201, 151)
        Me.chtData.Name = "chtData"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chtData.Series.Add(Series3)
        Me.chtData.Size = New System.Drawing.Size(687, 396)
        Me.chtData.TabIndex = 10
        Me.chtData.Text = "Chart1"
        '
        'Analytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 559)
        Me.Controls.Add(Me.chtData)
        Me.Controls.Add(Me.btnPriceData)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.btnEmployeeData)
        Me.Controls.Add(Me.btnMedicineData)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Analytics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analytics"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMedicineData As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEmployeeData As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPriceData As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents chtData As DataVisualization.Charting.Chart
End Class
