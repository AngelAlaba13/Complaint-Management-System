<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        txtBoxSearch = New TextBox()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        Label1 = New Label()
        btnShowComplaints = New Button()
        btnShowFeedbacks = New Button()
        btnShowSuggestions = New Button()
        btnShowInstructors = New Button()
        btnShowCollege = New Button()
        btnShowOfficers = New Button()
        btnShowOthers = New Button()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        btnShowFirstYear = New Guna.UI2.WinForms.Guna2Button()
        btnShowSecondYear = New Guna.UI2.WinForms.Guna2Button()
        btnShowThirdYear = New Guna.UI2.WinForms.Guna2Button()
        btnShowFourthYear = New Guna.UI2.WinForms.Guna2Button()
        Label3 = New Label()
        Panel1 = New Panel()
        Label13 = New Label()
        PictureBox1 = New PictureBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        deleteToolStrip = New ToolStripMenuItem()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBoxSearch
        ' 
        txtBoxSearch.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBoxSearch.Location = New Point(333, 166)
        txtBoxSearch.Name = "txtBoxSearch"
        txtBoxSearch.Size = New Size(460, 34)
        txtBoxSearch.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(219, 219)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(970, 578)
        DataGridView1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Arial Black", 40.0F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(596, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(499, 97)
        Label7.TabIndex = 3
        Label7.Text = "Admin Panel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 28.2F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1220, 238)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 67)
        Label1.TabIndex = 4
        Label1.Text = "Task Bar" & vbCrLf
        ' 
        ' btnShowComplaints
        ' 
        btnShowComplaints.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowComplaints.FlatAppearance.BorderSize = 2
        btnShowComplaints.Font = New Font("Consolas", 9.0F)
        btnShowComplaints.Location = New Point(1260, 528)
        btnShowComplaints.Name = "btnShowComplaints"
        btnShowComplaints.Size = New Size(171, 35)
        btnShowComplaints.TabIndex = 5
        btnShowComplaints.Text = "Complaints"
        btnShowComplaints.UseVisualStyleBackColor = True
        ' 
        ' btnShowFeedbacks
        ' 
        btnShowFeedbacks.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowFeedbacks.FlatAppearance.BorderSize = 2
        btnShowFeedbacks.Font = New Font("Consolas", 9.0F)
        btnShowFeedbacks.Location = New Point(1260, 569)
        btnShowFeedbacks.Name = "btnShowFeedbacks"
        btnShowFeedbacks.Size = New Size(171, 35)
        btnShowFeedbacks.TabIndex = 6
        btnShowFeedbacks.Text = "Feedbacks"
        btnShowFeedbacks.UseVisualStyleBackColor = True
        ' 
        ' btnShowSuggestions
        ' 
        btnShowSuggestions.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowSuggestions.FlatAppearance.BorderSize = 2
        btnShowSuggestions.Font = New Font("Consolas", 9.0F)
        btnShowSuggestions.Location = New Point(1260, 610)
        btnShowSuggestions.Name = "btnShowSuggestions"
        btnShowSuggestions.Size = New Size(171, 35)
        btnShowSuggestions.TabIndex = 7
        btnShowSuggestions.Text = "Suggestions"
        btnShowSuggestions.UseVisualStyleBackColor = True
        ' 
        ' btnShowInstructors
        ' 
        btnShowInstructors.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowInstructors.FlatAppearance.BorderSize = 2
        btnShowInstructors.Font = New Font("Consolas", 9.0F)
        btnShowInstructors.Location = New Point(1260, 311)
        btnShowInstructors.Name = "btnShowInstructors"
        btnShowInstructors.Size = New Size(171, 35)
        btnShowInstructors.TabIndex = 8
        btnShowInstructors.Text = "to Instructor"
        btnShowInstructors.UseVisualStyleBackColor = True
        ' 
        ' btnShowCollege
        ' 
        btnShowCollege.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowCollege.FlatAppearance.BorderSize = 2
        btnShowCollege.Font = New Font("Consolas", 9.0F)
        btnShowCollege.Location = New Point(1260, 352)
        btnShowCollege.Name = "btnShowCollege"
        btnShowCollege.Size = New Size(171, 35)
        btnShowCollege.TabIndex = 9
        btnShowCollege.Text = "to the college"
        btnShowCollege.UseVisualStyleBackColor = True
        ' 
        ' btnShowOfficers
        ' 
        btnShowOfficers.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowOfficers.FlatAppearance.BorderSize = 2
        btnShowOfficers.Font = New Font("Consolas", 9.0F)
        btnShowOfficers.Location = New Point(1260, 393)
        btnShowOfficers.Name = "btnShowOfficers"
        btnShowOfficers.Size = New Size(171, 35)
        btnShowOfficers.TabIndex = 10
        btnShowOfficers.Text = "to the officers"
        btnShowOfficers.UseVisualStyleBackColor = True
        ' 
        ' btnShowOthers
        ' 
        btnShowOthers.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowOthers.FlatAppearance.BorderSize = 2
        btnShowOthers.Font = New Font("Consolas", 9.0F)
        btnShowOthers.Location = New Point(1260, 434)
        btnShowOthers.Name = "btnShowOthers"
        btnShowOthers.Size = New Size(171, 35)
        btnShowOthers.TabIndex = 11
        btnShowOthers.Text = "others"
        btnShowOthers.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(84), CByte(223), CByte(192))
        Label2.Location = New Point(219, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 41)
        Label2.TabIndex = 16
        Label2.Text = "Search:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(1006, 166)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(183, 33)
        ComboBox1.TabIndex = 17
        ' 
        ' btnShowFirstYear
        ' 
        btnShowFirstYear.Animated = True
        btnShowFirstYear.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowFirstYear.BorderRadius = 14
        btnShowFirstYear.BorderThickness = 2
        btnShowFirstYear.CustomizableEdges = CustomizableEdges1
        btnShowFirstYear.DisabledState.BorderColor = Color.DarkGray
        btnShowFirstYear.DisabledState.CustomBorderColor = Color.DarkGray
        btnShowFirstYear.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnShowFirstYear.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnShowFirstYear.FillColor = Color.FromArgb(CByte(178), CByte(137), CByte(255))
        btnShowFirstYear.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowFirstYear.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(254))
        btnShowFirstYear.Location = New Point(29, 219)
        btnShowFirstYear.Name = "btnShowFirstYear"
        btnShowFirstYear.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnShowFirstYear.Size = New Size(171, 40)
        btnShowFirstYear.TabIndex = 28
        btnShowFirstYear.Text = "1st Year"
        ' 
        ' btnShowSecondYear
        ' 
        btnShowSecondYear.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowSecondYear.BorderRadius = 14
        btnShowSecondYear.BorderThickness = 2
        btnShowSecondYear.CustomizableEdges = CustomizableEdges3
        btnShowSecondYear.DisabledState.BorderColor = Color.DarkGray
        btnShowSecondYear.DisabledState.CustomBorderColor = Color.DarkGray
        btnShowSecondYear.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnShowSecondYear.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnShowSecondYear.FillColor = Color.FromArgb(CByte(178), CByte(137), CByte(255))
        btnShowSecondYear.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowSecondYear.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(254))
        btnShowSecondYear.Location = New Point(29, 265)
        btnShowSecondYear.Name = "btnShowSecondYear"
        btnShowSecondYear.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnShowSecondYear.Size = New Size(171, 40)
        btnShowSecondYear.TabIndex = 29
        btnShowSecondYear.Text = "2nd Year"
        ' 
        ' btnShowThirdYear
        ' 
        btnShowThirdYear.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowThirdYear.BorderRadius = 14
        btnShowThirdYear.BorderThickness = 2
        btnShowThirdYear.CustomizableEdges = CustomizableEdges5
        btnShowThirdYear.DisabledState.BorderColor = Color.DarkGray
        btnShowThirdYear.DisabledState.CustomBorderColor = Color.DarkGray
        btnShowThirdYear.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnShowThirdYear.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnShowThirdYear.FillColor = Color.FromArgb(CByte(178), CByte(137), CByte(255))
        btnShowThirdYear.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowThirdYear.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(254))
        btnShowThirdYear.Location = New Point(29, 311)
        btnShowThirdYear.Name = "btnShowThirdYear"
        btnShowThirdYear.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnShowThirdYear.Size = New Size(171, 40)
        btnShowThirdYear.TabIndex = 30
        btnShowThirdYear.Text = "3rd Year"
        ' 
        ' btnShowFourthYear
        ' 
        btnShowFourthYear.BorderColor = Color.FromArgb(CByte(50), CByte(52), CByte(144))
        btnShowFourthYear.BorderRadius = 14
        btnShowFourthYear.BorderThickness = 2
        btnShowFourthYear.CustomizableEdges = CustomizableEdges7
        btnShowFourthYear.DisabledState.BorderColor = Color.DarkGray
        btnShowFourthYear.DisabledState.CustomBorderColor = Color.DarkGray
        btnShowFourthYear.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnShowFourthYear.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnShowFourthYear.FillColor = Color.FromArgb(CByte(178), CByte(137), CByte(255))
        btnShowFourthYear.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowFourthYear.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(254))
        btnShowFourthYear.Location = New Point(29, 357)
        btnShowFourthYear.Name = "btnShowFourthYear"
        btnShowFourthYear.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnShowFourthYear.Size = New Size(171, 40)
        btnShowFourthYear.TabIndex = 31
        btnShowFourthYear.Text = "4th Year"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(84), CByte(223), CByte(192))
        Label3.Location = New Point(900, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 41)
        Label3.TabIndex = 32
        Label3.Text = "Block:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(248), CByte(55), CByte(120))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(29, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(243, 90)
        Panel1.TabIndex = 33
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BorderStyle = BorderStyle.FixedSingle
        Label13.Font = New Font("Arial Black", 20.2F, FontStyle.Bold)
        Label13.ForeColor = Color.FromArgb(CByte(249), CByte(185), CByte(200))
        Label13.Location = New Point(80, 21)
        Label13.Name = "Label13"
        Label13.Size = New Size(152, 50)
        Label13.TabIndex = 1
        Label13.Text = "Logout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {deleteToolStrip})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(211, 56)
        ' 
        ' deleteToolStrip
        ' 
        deleteToolStrip.Name = "deleteToolStrip"
        deleteToolStrip.Size = New Size(210, 24)
        deleteToolStrip.Text = "Delete"
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(93), CByte(51), CByte(189))
        ClientSize = New Size(1517, 890)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(btnShowFourthYear)
        Controls.Add(btnShowThirdYear)
        Controls.Add(btnShowSecondYear)
        Controls.Add(btnShowFirstYear)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(btnShowOthers)
        Controls.Add(btnShowOfficers)
        Controls.Add(btnShowCollege)
        Controls.Add(btnShowInstructors)
        Controls.Add(btnShowSuggestions)
        Controls.Add(btnShowFeedbacks)
        Controls.Add(btnShowComplaints)
        Controls.Add(Label1)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(txtBoxSearch)
        Name = "adminForm"
        Text = "adminForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowComplaints As Button
    Friend WithEvents btnShowFeedbacks As Button
    Friend WithEvents btnShowSuggestions As Button
    Friend WithEvents btnShowInstructors As Button
    Friend WithEvents btnShowCollege As Button
    Friend WithEvents btnShowOfficers As Button
    Friend WithEvents btnShowOthers As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnShowFirstYear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnShowSecondYear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnShowThirdYear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnShowFourthYear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents deleteToolStrip As ToolStripMenuItem
End Class
