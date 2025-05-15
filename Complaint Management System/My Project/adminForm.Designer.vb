<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        TextBox1 = New TextBox()
        btnSearch = New Button()
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
        btnShowFirstYear = New Button()
        btnShowSecondYear = New Button()
        btnShowThirdYear = New Button()
        btnShowFourthYear = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(74, 166)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(642, 34)
        TextBox1.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(751, 162)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(149, 47)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(74, 235)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(826, 587)
        DataGridView1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(638, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(262, 47)
        Label7.TabIndex = 3
        Label7.Text = "Admin Panel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1161, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 47)
        Label1.TabIndex = 4
        Label1.Text = "Task Bar" & vbCrLf
        ' 
        ' btnShowComplaints
        ' 
        btnShowComplaints.Font = New Font("Consolas", 9F)
        btnShowComplaints.Location = New Point(1249, 477)
        btnShowComplaints.Name = "btnShowComplaints"
        btnShowComplaints.Size = New Size(171, 35)
        btnShowComplaints.TabIndex = 5
        btnShowComplaints.Text = "Complaints"
        btnShowComplaints.UseVisualStyleBackColor = True
        ' 
        ' btnShowFeedbacks
        ' 
        btnShowFeedbacks.Font = New Font("Consolas", 9F)
        btnShowFeedbacks.Location = New Point(1249, 518)
        btnShowFeedbacks.Name = "btnShowFeedbacks"
        btnShowFeedbacks.Size = New Size(171, 35)
        btnShowFeedbacks.TabIndex = 6
        btnShowFeedbacks.Text = "Feedbacks"
        btnShowFeedbacks.UseVisualStyleBackColor = True
        ' 
        ' btnShowSuggestions
        ' 
        btnShowSuggestions.Font = New Font("Consolas", 9F)
        btnShowSuggestions.Location = New Point(1249, 559)
        btnShowSuggestions.Name = "btnShowSuggestions"
        btnShowSuggestions.Size = New Size(171, 35)
        btnShowSuggestions.TabIndex = 7
        btnShowSuggestions.Text = "Suggestions"
        btnShowSuggestions.UseVisualStyleBackColor = True
        ' 
        ' btnShowInstructors
        ' 
        btnShowInstructors.Font = New Font("Consolas", 9F)
        btnShowInstructors.Location = New Point(1249, 260)
        btnShowInstructors.Name = "btnShowInstructors"
        btnShowInstructors.Size = New Size(171, 35)
        btnShowInstructors.TabIndex = 8
        btnShowInstructors.Text = "to Instructor"
        btnShowInstructors.UseVisualStyleBackColor = True
        ' 
        ' btnShowCollege
        ' 
        btnShowCollege.Font = New Font("Consolas", 9F)
        btnShowCollege.Location = New Point(1249, 301)
        btnShowCollege.Name = "btnShowCollege"
        btnShowCollege.Size = New Size(171, 35)
        btnShowCollege.TabIndex = 9
        btnShowCollege.Text = "to the college"
        btnShowCollege.UseVisualStyleBackColor = True
        ' 
        ' btnShowOfficers
        ' 
        btnShowOfficers.Font = New Font("Consolas", 9F)
        btnShowOfficers.Location = New Point(1249, 342)
        btnShowOfficers.Name = "btnShowOfficers"
        btnShowOfficers.Size = New Size(171, 35)
        btnShowOfficers.TabIndex = 10
        btnShowOfficers.Text = "to the officers"
        btnShowOfficers.UseVisualStyleBackColor = True
        ' 
        ' btnShowOthers
        ' 
        btnShowOthers.Font = New Font("Consolas", 9F)
        btnShowOthers.Location = New Point(1249, 383)
        btnShowOthers.Name = "btnShowOthers"
        btnShowOthers.Size = New Size(171, 35)
        btnShowOthers.TabIndex = 11
        btnShowOthers.Text = "others"
        btnShowOthers.UseVisualStyleBackColor = True
        ' 
        ' btnShowFirstYear
        ' 
        btnShowFirstYear.Font = New Font("Consolas", 9F)
        btnShowFirstYear.Location = New Point(991, 260)
        btnShowFirstYear.Name = "btnShowFirstYear"
        btnShowFirstYear.Size = New Size(171, 35)
        btnShowFirstYear.TabIndex = 12
        btnShowFirstYear.Text = "1st Year"
        btnShowFirstYear.UseVisualStyleBackColor = True
        ' 
        ' btnShowSecondYear
        ' 
        btnShowSecondYear.Font = New Font("Consolas", 9F)
        btnShowSecondYear.Location = New Point(991, 301)
        btnShowSecondYear.Name = "btnShowSecondYear"
        btnShowSecondYear.Size = New Size(171, 35)
        btnShowSecondYear.TabIndex = 13
        btnShowSecondYear.Text = "2nd Year"
        btnShowSecondYear.UseVisualStyleBackColor = True
        ' 
        ' btnShowThirdYear
        ' 
        btnShowThirdYear.Font = New Font("Consolas", 9F)
        btnShowThirdYear.Location = New Point(991, 342)
        btnShowThirdYear.Name = "btnShowThirdYear"
        btnShowThirdYear.Size = New Size(171, 35)
        btnShowThirdYear.TabIndex = 14
        btnShowThirdYear.Text = "3rd Year"
        btnShowThirdYear.UseVisualStyleBackColor = True
        ' 
        ' btnShowFourthYear
        ' 
        btnShowFourthYear.Font = New Font("Consolas", 9F)
        btnShowFourthYear.Location = New Point(991, 383)
        btnShowFourthYear.Name = "btnShowFourthYear"
        btnShowFourthYear.Size = New Size(171, 35)
        btnShowFourthYear.TabIndex = 15
        btnShowFourthYear.Text = "4th Year"
        btnShowFourthYear.UseVisualStyleBackColor = True
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1517, 890)
        Controls.Add(btnShowFourthYear)
        Controls.Add(btnShowThirdYear)
        Controls.Add(btnShowSecondYear)
        Controls.Add(btnShowFirstYear)
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
        Controls.Add(btnSearch)
        Controls.Add(TextBox1)
        Name = "adminForm"
        Text = "adminForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSearch As Button
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
    Friend WithEvents btnShowFirstYear As Button
    Friend WithEvents btnShowSecondYear As Button
    Friend WithEvents btnShowThirdYear As Button
    Friend WithEvents btnShowFourthYear As Button
End Class
