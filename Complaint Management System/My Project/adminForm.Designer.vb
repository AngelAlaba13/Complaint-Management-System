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
        btnShowComplaints.Location = New Point(974, 260)
        btnShowComplaints.Name = "btnShowComplaints"
        btnShowComplaints.Size = New Size(171, 35)
        btnShowComplaints.TabIndex = 5
        btnShowComplaints.Text = "Complaints"
        btnShowComplaints.UseVisualStyleBackColor = True
        ' 
        ' btnShowFeedbacks
        ' 
        btnShowFeedbacks.Font = New Font("Consolas", 9F)
        btnShowFeedbacks.Location = New Point(974, 301)
        btnShowFeedbacks.Name = "btnShowFeedbacks"
        btnShowFeedbacks.Size = New Size(171, 35)
        btnShowFeedbacks.TabIndex = 6
        btnShowFeedbacks.Text = "Feedbacks"
        btnShowFeedbacks.UseVisualStyleBackColor = True
        ' 
        ' btnShowSuggestions
        ' 
        btnShowSuggestions.Font = New Font("Consolas", 9F)
        btnShowSuggestions.Location = New Point(974, 342)
        btnShowSuggestions.Name = "btnShowSuggestions"
        btnShowSuggestions.Size = New Size(171, 35)
        btnShowSuggestions.TabIndex = 7
        btnShowSuggestions.Text = "Suggestions"
        btnShowSuggestions.UseVisualStyleBackColor = True
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1517, 890)
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
End Class
