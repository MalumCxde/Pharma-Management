<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Clearlbl = New System.Windows.Forms.Label()
        Me.Closelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell Nova Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(97, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'txtUserName
        '
        Me.txtUserName.BorderRadius = 2
        Me.txtUserName.BorderThickness = 0
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.DefaultText = ""
        Me.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserName.DisabledState.Parent = Me.txtUserName
        Me.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserName.FocusedState.Parent = Me.txtUserName
        Me.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserName.HoverState.Parent = Me.txtUserName
        Me.txtUserName.Location = New System.Drawing.Point(41, 82)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.PlaceholderText = "Username"
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.ShadowDecoration.Parent = Me.txtUserName
        Me.txtUserName.Size = New System.Drawing.Size(187, 35)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 2
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(41, 140)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(187, 38)
        Me.txtPassword.TabIndex = 3
        '
        'LoginBtn
        '
        Me.LoginBtn.BorderRadius = 5
        Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
        Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
        Me.LoginBtn.FillColor = System.Drawing.Color.Teal
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.HoverState.Parent = Me.LoginBtn
        Me.LoginBtn.Location = New System.Drawing.Point(59, 205)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
        Me.LoginBtn.Size = New System.Drawing.Size(143, 43)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "Login"
        '
        'Clearlbl
        '
        Me.Clearlbl.AutoSize = True
        Me.Clearlbl.Font = New System.Drawing.Font("Rockwell Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearlbl.ForeColor = System.Drawing.Color.Teal
        Me.Clearlbl.Location = New System.Drawing.Point(109, 251)
        Me.Clearlbl.Name = "Clearlbl"
        Me.Clearlbl.Size = New System.Drawing.Size(43, 25)
        Me.Clearlbl.TabIndex = 5
        Me.Clearlbl.Text = "Clear"
        '
        'Closelbl
        '
        Me.Closelbl.AutoSize = True
        Me.Closelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closelbl.ForeColor = System.Drawing.Color.Red
        Me.Closelbl.Location = New System.Drawing.Point(242, 9)
        Me.Closelbl.Name = "Closelbl"
        Me.Closelbl.Size = New System.Drawing.Size(20, 20)
        Me.Closelbl.TabIndex = 6
        Me.Closelbl.Text = "X"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 302)
        Me.Controls.Add(Me.Closelbl)
        Me.Controls.Add(Me.Clearlbl)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Clearlbl As Label
    Friend WithEvents Closelbl As Label
End Class
