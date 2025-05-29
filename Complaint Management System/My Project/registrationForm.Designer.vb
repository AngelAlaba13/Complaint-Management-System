<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationForm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        RegisterLabelID = New Label()
        RegisterLabelName = New Label()
        RegisterLabelYear = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        RegisterLabelBlock = New Label()
        RegisterLabelPassword = New Label()
        Label1 = New Label()
        txtRegisterID = New Guna.UI2.WinForms.Guna2TextBox()
        txtRegisterName = New Guna.UI2.WinForms.Guna2TextBox()
        txtRegisterBlock = New Guna.UI2.WinForms.Guna2TextBox()
        txtRegisterPass = New Guna.UI2.WinForms.Guna2TextBox()
        txtRegisterYear = New Guna.UI2.WinForms.Guna2ComboBox()
        btnRegisterConfirm = New Guna.UI2.WinForms.Guna2Button()
        btnRegisterCancel = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' RegisterLabelID
        ' 
        RegisterLabelID.AutoSize = True
        RegisterLabelID.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RegisterLabelID.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        RegisterLabelID.Location = New Point(198, 213)
        RegisterLabelID.Name = "RegisterLabelID"
        RegisterLabelID.Size = New Size(136, 27)
        RegisterLabelID.TabIndex = 2
        RegisterLabelID.Text = "Student ID:"
        ' 
        ' RegisterLabelName
        ' 
        RegisterLabelName.AutoSize = True
        RegisterLabelName.Font = New Font("Arial Rounded MT Bold", 13.8F)
        RegisterLabelName.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        RegisterLabelName.Location = New Point(198, 304)
        RegisterLabelName.Name = "RegisterLabelName"
        RegisterLabelName.Size = New Size(130, 27)
        RegisterLabelName.TabIndex = 5
        RegisterLabelName.Text = "Full Name:"
        ' 
        ' RegisterLabelYear
        ' 
        RegisterLabelYear.AutoSize = True
        RegisterLabelYear.Font = New Font("Arial Rounded MT Bold", 13.8F)
        RegisterLabelYear.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        RegisterLabelYear.Location = New Point(602, 210)
        RegisterLabelYear.Name = "RegisterLabelYear"
        RegisterLabelYear.Size = New Size(137, 27)
        RegisterLabelYear.TabIndex = 7
        RegisterLabelYear.Text = "Year Level:"
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' RegisterLabelBlock
        ' 
        RegisterLabelBlock.AutoSize = True
        RegisterLabelBlock.Font = New Font("Arial Rounded MT Bold", 13.8F)
        RegisterLabelBlock.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        RegisterLabelBlock.Location = New Point(602, 304)
        RegisterLabelBlock.Name = "RegisterLabelBlock"
        RegisterLabelBlock.Size = New Size(83, 27)
        RegisterLabelBlock.TabIndex = 5
        RegisterLabelBlock.Text = "Block:"
        ' 
        ' RegisterLabelPassword
        ' 
        RegisterLabelPassword.AutoSize = True
        RegisterLabelPassword.Font = New Font("Arial Rounded MT Bold", 13.8F)
        RegisterLabelPassword.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        RegisterLabelPassword.Location = New Point(198, 391)
        RegisterLabelPassword.Name = "RegisterLabelPassword"
        RegisterLabelPassword.Size = New Size(129, 27)
        RegisterLabelPassword.TabIndex = 5
        RegisterLabelPassword.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(231, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(573, 67)
        Label1.TabIndex = 10
        Label1.Text = "REGISTER ACCOUNT"
        ' 
        ' txtRegisterID
        ' 
        txtRegisterID.BorderRadius = 3
        txtRegisterID.CustomizableEdges = CustomizableEdges1
        txtRegisterID.DefaultText = ""
        txtRegisterID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRegisterID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRegisterID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterID.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegisterID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterID.Location = New Point(198, 245)
        txtRegisterID.Margin = New Padding(4, 5, 4, 5)
        txtRegisterID.Name = "txtRegisterID"
        txtRegisterID.PlaceholderText = ""
        txtRegisterID.SelectedText = ""
        txtRegisterID.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtRegisterID.Size = New Size(329, 31)
        txtRegisterID.TabIndex = 11
        ' 
        ' txtRegisterName
        ' 
        txtRegisterName.BorderRadius = 3
        txtRegisterName.CustomizableEdges = CustomizableEdges3
        txtRegisterName.DefaultText = ""
        txtRegisterName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRegisterName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRegisterName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegisterName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterName.Location = New Point(198, 336)
        txtRegisterName.Margin = New Padding(4, 5, 4, 5)
        txtRegisterName.Name = "txtRegisterName"
        txtRegisterName.PlaceholderText = ""
        txtRegisterName.SelectedText = ""
        txtRegisterName.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtRegisterName.Size = New Size(329, 31)
        txtRegisterName.TabIndex = 12
        ' 
        ' txtRegisterBlock
        ' 
        txtRegisterBlock.BorderRadius = 3
        txtRegisterBlock.CustomizableEdges = CustomizableEdges5
        txtRegisterBlock.DefaultText = ""
        txtRegisterBlock.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRegisterBlock.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRegisterBlock.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterBlock.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterBlock.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterBlock.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegisterBlock.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterBlock.Location = New Point(602, 336)
        txtRegisterBlock.Margin = New Padding(4, 5, 4, 5)
        txtRegisterBlock.Name = "txtRegisterBlock"
        txtRegisterBlock.PlaceholderText = ""
        txtRegisterBlock.SelectedText = ""
        txtRegisterBlock.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtRegisterBlock.Size = New Size(216, 31)
        txtRegisterBlock.TabIndex = 13
        ' 
        ' txtRegisterPass
        ' 
        txtRegisterPass.BorderRadius = 3
        txtRegisterPass.CustomizableEdges = CustomizableEdges7
        txtRegisterPass.DefaultText = ""
        txtRegisterPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRegisterPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRegisterPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRegisterPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterPass.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegisterPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterPass.Location = New Point(198, 421)
        txtRegisterPass.Margin = New Padding(4, 5, 4, 5)
        txtRegisterPass.Name = "txtRegisterPass"
        txtRegisterPass.PlaceholderText = ""
        txtRegisterPass.SelectedText = ""
        txtRegisterPass.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtRegisterPass.Size = New Size(329, 31)
        txtRegisterPass.TabIndex = 14
        ' 
        ' txtRegisterYear
        ' 
        txtRegisterYear.BackColor = Color.Transparent
        txtRegisterYear.BorderRadius = 3
        txtRegisterYear.CustomizableEdges = CustomizableEdges9
        txtRegisterYear.DrawMode = DrawMode.OwnerDrawFixed
        txtRegisterYear.DropDownStyle = ComboBoxStyle.DropDownList
        txtRegisterYear.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterYear.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRegisterYear.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegisterYear.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        txtRegisterYear.ItemHeight = 30
        txtRegisterYear.Location = New Point(602, 240)
        txtRegisterYear.Name = "txtRegisterYear"
        txtRegisterYear.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtRegisterYear.Size = New Size(216, 36)
        txtRegisterYear.TabIndex = 15
        ' 
        ' btnRegisterConfirm
        ' 
        btnRegisterConfirm.BorderRadius = 10
        btnRegisterConfirm.CustomizableEdges = CustomizableEdges11
        btnRegisterConfirm.DisabledState.BorderColor = Color.DarkGray
        btnRegisterConfirm.DisabledState.CustomBorderColor = Color.DarkGray
        btnRegisterConfirm.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRegisterConfirm.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRegisterConfirm.FillColor = Color.FromArgb(CByte(207), CByte(176), CByte(49))
        btnRegisterConfirm.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnRegisterConfirm.ForeColor = Color.White
        btnRegisterConfirm.Location = New Point(368, 525)
        btnRegisterConfirm.Name = "btnRegisterConfirm"
        btnRegisterConfirm.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnRegisterConfirm.Size = New Size(148, 46)
        btnRegisterConfirm.TabIndex = 16
        btnRegisterConfirm.Text = "REGISTER"
        ' 
        ' btnRegisterCancel
        ' 
        btnRegisterCancel.BorderRadius = 10
        btnRegisterCancel.CustomizableEdges = CustomizableEdges13
        btnRegisterCancel.DisabledState.BorderColor = Color.DarkGray
        btnRegisterCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnRegisterCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRegisterCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRegisterCancel.FillColor = Color.FromArgb(CByte(207), CByte(176), CByte(49))
        btnRegisterCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnRegisterCancel.ForeColor = Color.White
        btnRegisterCancel.Location = New Point(533, 525)
        btnRegisterCancel.Name = "btnRegisterCancel"
        btnRegisterCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnRegisterCancel.Size = New Size(148, 46)
        btnRegisterCancel.TabIndex = 17
        btnRegisterCancel.Text = "CANCEL"
        ' 
        ' registrationForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        ClientSize = New Size(1018, 623)
        Controls.Add(btnRegisterCancel)
        Controls.Add(btnRegisterConfirm)
        Controls.Add(txtRegisterYear)
        Controls.Add(txtRegisterPass)
        Controls.Add(txtRegisterBlock)
        Controls.Add(txtRegisterName)
        Controls.Add(txtRegisterID)
        Controls.Add(Label1)
        Controls.Add(RegisterLabelYear)
        Controls.Add(RegisterLabelBlock)
        Controls.Add(RegisterLabelPassword)
        Controls.Add(RegisterLabelName)
        Controls.Add(RegisterLabelID)
        Name = "registrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registrationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RegisterLabelID As Label
    'Friend WithEvents txtRegisterID As TextBox
    'Friend WithEvents txtRegisterName As TextBox
    Friend WithEvents RegisterLabelName As Label
    Friend WithEvents RegisterLabelYear As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    'Friend WithEvents txtRegisterYear As ComboBox
    Friend WithEvents RegisterLabelBlock As Label
    'Friend WithEvents txtRegisterBlock As TextBox
    Friend WithEvents RegisterLabelPassword As Label
    'Friend WithEvents txtRegisterPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegisterID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegisterName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegisterBlock As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegisterPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegisterYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnRegisterConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRegisterCancel As Guna.UI2.WinForms.Guna2Button
End Class
