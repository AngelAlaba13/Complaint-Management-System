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
        btnRegisterCancel = New Button()
        RegisterLabelID = New Label()
        btnRegisterConfirm = New Button()
        txtRegisterID = New TextBox()
        txtRegisterName = New TextBox()
        RegisterLabelName = New Label()
        RegisterLabelYear = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        txtRegisterYear = New ComboBox()
        RegisterLabelBlock = New Label()
        txtRegisterBlock = New TextBox()
        RegisterLabelPassword = New Label()
        txtRegisterPass = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnRegisterCancel
        ' 
        btnRegisterCancel.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnRegisterCancel.FlatStyle = FlatStyle.Flat
        btnRegisterCancel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnRegisterCancel.ForeColor = Color.White
        btnRegisterCancel.Location = New Point(418, 307)
        btnRegisterCancel.Name = "btnRegisterCancel"
        btnRegisterCancel.Size = New Size(134, 41)
        btnRegisterCancel.TabIndex = 1
        btnRegisterCancel.Text = "Cancel"
        btnRegisterCancel.UseVisualStyleBackColor = False
        ' 
        ' RegisterLabelID
        ' 
        RegisterLabelID.AutoSize = True
        RegisterLabelID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        RegisterLabelID.Location = New Point(177, 131)
        RegisterLabelID.Name = "RegisterLabelID"
        RegisterLabelID.Size = New Size(96, 23)
        RegisterLabelID.TabIndex = 2
        RegisterLabelID.Text = "Student ID:"
        ' 
        ' btnRegisterConfirm
        ' 
        btnRegisterConfirm.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnRegisterConfirm.FlatStyle = FlatStyle.Flat
        btnRegisterConfirm.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnRegisterConfirm.ForeColor = Color.White
        btnRegisterConfirm.Location = New Point(278, 307)
        btnRegisterConfirm.Name = "btnRegisterConfirm"
        btnRegisterConfirm.Size = New Size(134, 41)
        btnRegisterConfirm.TabIndex = 3
        btnRegisterConfirm.Text = "Register"
        btnRegisterConfirm.UseVisualStyleBackColor = False
        ' 
        ' txtRegisterID
        ' 
        txtRegisterID.BorderStyle = BorderStyle.FixedSingle
        txtRegisterID.Location = New Point(278, 130)
        txtRegisterID.Name = "txtRegisterID"
        txtRegisterID.Size = New Size(274, 27)
        txtRegisterID.TabIndex = 4
        ' 
        ' txtRegisterName
        ' 
        txtRegisterName.BorderStyle = BorderStyle.FixedSingle
        txtRegisterName.Location = New Point(278, 163)
        txtRegisterName.Name = "txtRegisterName"
        txtRegisterName.Size = New Size(274, 27)
        txtRegisterName.TabIndex = 6
        ' 
        ' RegisterLabelName
        ' 
        RegisterLabelName.AutoSize = True
        RegisterLabelName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        RegisterLabelName.Location = New Point(177, 164)
        RegisterLabelName.Name = "RegisterLabelName"
        RegisterLabelName.Size = New Size(92, 23)
        RegisterLabelName.TabIndex = 5
        RegisterLabelName.Text = "Full Name:"
        ' 
        ' RegisterLabelYear
        ' 
        RegisterLabelYear.AutoSize = True
        RegisterLabelYear.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        RegisterLabelYear.Location = New Point(177, 197)
        RegisterLabelYear.Name = "RegisterLabelYear"
        RegisterLabelYear.Size = New Size(90, 23)
        RegisterLabelYear.TabIndex = 7
        RegisterLabelYear.Text = "Year Level:"
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' txtRegisterYear
        ' 
        txtRegisterYear.FormattingEnabled = True
        txtRegisterYear.Location = New Point(278, 197)
        txtRegisterYear.Name = "txtRegisterYear"
        txtRegisterYear.Size = New Size(100, 28)
        txtRegisterYear.TabIndex = 9
        ' 
        ' RegisterLabelBlock
        ' 
        RegisterLabelBlock.AutoSize = True
        RegisterLabelBlock.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        RegisterLabelBlock.Location = New Point(177, 232)
        RegisterLabelBlock.Name = "RegisterLabelBlock"
        RegisterLabelBlock.Size = New Size(56, 23)
        RegisterLabelBlock.TabIndex = 5
        RegisterLabelBlock.Text = "Block:"
        ' 
        ' txtRegisterBlock
        ' 
        txtRegisterBlock.BorderStyle = BorderStyle.FixedSingle
        txtRegisterBlock.Location = New Point(278, 231)
        txtRegisterBlock.Name = "txtRegisterBlock"
        txtRegisterBlock.Size = New Size(100, 27)
        txtRegisterBlock.TabIndex = 6
        ' 
        ' RegisterLabelPassword
        ' 
        RegisterLabelPassword.AutoSize = True
        RegisterLabelPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        RegisterLabelPassword.Location = New Point(177, 265)
        RegisterLabelPassword.Name = "RegisterLabelPassword"
        RegisterLabelPassword.Size = New Size(86, 23)
        RegisterLabelPassword.TabIndex = 5
        RegisterLabelPassword.Text = "Password:"
        ' 
        ' txtRegisterPass
        ' 
        txtRegisterPass.BorderStyle = BorderStyle.FixedSingle
        txtRegisterPass.Location = New Point(278, 264)
        txtRegisterPass.Name = "txtRegisterPass"
        txtRegisterPass.Size = New Size(274, 27)
        txtRegisterPass.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(324, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 28)
        Label1.TabIndex = 10
        Label1.Text = "Account Registration"
        ' 
        ' registrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtRegisterYear)
        Controls.Add(RegisterLabelYear)
        Controls.Add(txtRegisterBlock)
        Controls.Add(RegisterLabelBlock)
        Controls.Add(txtRegisterPass)
        Controls.Add(RegisterLabelPassword)
        Controls.Add(txtRegisterName)
        Controls.Add(RegisterLabelName)
        Controls.Add(txtRegisterID)
        Controls.Add(btnRegisterConfirm)
        Controls.Add(RegisterLabelID)
        Controls.Add(btnRegisterCancel)
        Name = "registrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registrationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegisterCancel As Button
    Friend WithEvents RegisterLabelID As Label
    Friend WithEvents btnRegisterConfirm As Button
    Friend WithEvents txtRegisterID As TextBox
    Friend WithEvents txtRegisterName As TextBox
    Friend WithEvents RegisterLabelName As Label
    Friend WithEvents RegisterLabelYear As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents txtRegisterYear As ComboBox
    Friend WithEvents RegisterLabelBlock As Label
    Friend WithEvents txtRegisterBlock As TextBox
    Friend WithEvents RegisterLabelPassword As Label
    Friend WithEvents txtRegisterPass As TextBox
    Friend WithEvents Label1 As Label
End Class
