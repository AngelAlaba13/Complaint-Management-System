<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        btnLogin = New Button()
        loginPanel = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        txtLoginPass = New TextBox()
        txtLoginID = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        reviewPanel = New Panel()
        txtInstructor = New ComboBox()
        Label10 = New Label()
        txtBlock = New ComboBox()
        txtYearLvl = New ComboBox()
        txtStudentID = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        txtComplaint = New ComboBox()
        txtTarget = New ComboBox()
        btnSendComplaint = New Button()
        blockDB = New TextBox()
        yearLevelDB = New TextBox()
        RichTextBox2 = New RichTextBox()
        txtContent = New RichTextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        userViewPanel = New Panel()
        Label7 = New Label()
        complainsPanel = New FlowLayoutPanel()
        itemsPanel = New Panel()
        lblDetails = New Label()
        lblComplaintType = New Label()
        lblComplaintReceiver = New Label()
        userDashBoard = New Panel()
        btnToView = New Button()
        Label15 = New Label()
        loginPanel.SuspendLayout()
        reviewPanel.SuspendLayout()
        userViewPanel.SuspendLayout()
        complainsPanel.SuspendLayout()
        itemsPanel.SuspendLayout()
        userDashBoard.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(403, 200)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 41)
        Button1.TabIndex = 0
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(256, 200)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(134, 41)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' loginPanel
        ' 
        loginPanel.Controls.Add(Label15)
        loginPanel.Controls.Add(Label14)
        loginPanel.Controls.Add(Label13)
        loginPanel.Controls.Add(txtLoginPass)
        loginPanel.Controls.Add(txtLoginID)
        loginPanel.Controls.Add(Label12)
        loginPanel.Controls.Add(Label11)
        loginPanel.Controls.Add(btnLogin)
        loginPanel.Controls.Add(Button1)
        loginPanel.Location = New Point(105, 4)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(805, 456)
        loginPanel.TabIndex = 2
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F)
        Label14.ForeColor = SystemColors.Highlight
        Label14.Location = New Point(424, 159)
        Label14.Name = "Label14"
        Label14.Size = New Size(96, 20)
        Label14.TabIndex = 6
        Label14.Text = "Register here"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F)
        Label13.Location = New Point(263, 159)
        Label13.Name = "Label13"
        Label13.Size = New Size(163, 20)
        Label13.TabIndex = 5
        Label13.Text = "Don't have an account?"
        ' 
        ' txtLoginPass
        ' 
        txtLoginPass.Location = New Point(253, 120)
        txtLoginPass.Name = "txtLoginPass"
        txtLoginPass.Size = New Size(284, 27)
        txtLoginPass.TabIndex = 4
        ' 
        ' txtLoginID
        ' 
        txtLoginID.Location = New Point(253, 84)
        txtLoginID.Name = "txtLoginID"
        txtLoginID.Size = New Size(284, 27)
        txtLoginID.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 11F)
        Label12.Location = New Point(133, 120)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 25)
        Label12.TabIndex = 3
        Label12.Text = "Password:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11F)
        Label11.Location = New Point(133, 84)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 25)
        Label11.TabIndex = 2
        Label11.Text = "Student ID:"
        ' 
        ' reviewPanel
        ' 
        reviewPanel.Controls.Add(txtInstructor)
        reviewPanel.Controls.Add(Label10)
        reviewPanel.Controls.Add(txtBlock)
        reviewPanel.Controls.Add(txtYearLvl)
        reviewPanel.Controls.Add(txtStudentID)
        reviewPanel.Controls.Add(Label9)
        reviewPanel.Controls.Add(Label8)
        reviewPanel.Controls.Add(txtComplaint)
        reviewPanel.Controls.Add(txtTarget)
        reviewPanel.Controls.Add(btnSendComplaint)
        reviewPanel.Controls.Add(blockDB)
        reviewPanel.Controls.Add(yearLevelDB)
        reviewPanel.Controls.Add(RichTextBox2)
        reviewPanel.Controls.Add(txtContent)
        reviewPanel.Controls.Add(Label6)
        reviewPanel.Controls.Add(Label5)
        reviewPanel.Controls.Add(Label4)
        reviewPanel.Controls.Add(Label3)
        reviewPanel.Controls.Add(Label2)
        reviewPanel.Controls.Add(Label1)
        reviewPanel.Location = New Point(122, 364)
        reviewPanel.Name = "reviewPanel"
        reviewPanel.Size = New Size(1514, 850)
        reviewPanel.TabIndex = 3
        ' 
        ' txtInstructor
        ' 
        txtInstructor.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInstructor.FormattingEnabled = True
        txtInstructor.Location = New Point(280, 499)
        txtInstructor.Name = "txtInstructor"
        txtInstructor.Size = New Size(336, 36)
        txtInstructor.TabIndex = 25
        txtInstructor.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(43, 504)
        Label10.Name = "Label10"
        Label10.Size = New Size(207, 27)
        Label10.TabIndex = 24
        Label10.Text = "Instructor Name"
        Label10.Visible = False
        ' 
        ' txtBlock
        ' 
        txtBlock.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBlock.FormattingEnabled = True
        txtBlock.Location = New Point(280, 398)
        txtBlock.Name = "txtBlock"
        txtBlock.Size = New Size(336, 36)
        txtBlock.TabIndex = 23
        ' 
        ' txtYearLvl
        ' 
        txtYearLvl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtYearLvl.FormattingEnabled = True
        txtYearLvl.Location = New Point(280, 346)
        txtYearLvl.Name = "txtYearLvl"
        txtYearLvl.Size = New Size(336, 36)
        txtYearLvl.TabIndex = 22
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStudentID.Location = New Point(280, 294)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(336, 34)
        txtStudentID.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(108, 299)
        Label9.Name = "Label9"
        Label9.Size = New Size(142, 27)
        Label9.TabIndex = 20
        Label9.Text = "Student ID"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(318, 538)
        Label8.Name = "Label8"
        Label8.Size = New Size(298, 27)
        Label8.TabIndex = 19
        Label8.Text = "Sample showing of data"
        ' 
        ' txtComplaint
        ' 
        txtComplaint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComplaint.FormattingEnabled = True
        txtComplaint.Location = New Point(1025, 231)
        txtComplaint.Name = "txtComplaint"
        txtComplaint.Size = New Size(336, 36)
        txtComplaint.TabIndex = 18
        ' 
        ' txtTarget
        ' 
        txtTarget.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTarget.FormattingEnabled = True
        txtTarget.Location = New Point(1025, 172)
        txtTarget.Name = "txtTarget"
        txtTarget.Size = New Size(336, 36)
        txtTarget.TabIndex = 17
        ' 
        ' btnSendComplaint
        ' 
        btnSendComplaint.Location = New Point(1097, 824)
        btnSendComplaint.Name = "btnSendComplaint"
        btnSendComplaint.Size = New Size(147, 35)
        btnSendComplaint.TabIndex = 16
        btnSendComplaint.Text = "Send Complaint"
        btnSendComplaint.UseVisualStyleBackColor = True
        ' 
        ' blockDB
        ' 
        blockDB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        blockDB.Location = New Point(293, 619)
        blockDB.Name = "blockDB"
        blockDB.Size = New Size(336, 34)
        blockDB.TabIndex = 15
        ' 
        ' yearLevelDB
        ' 
        yearLevelDB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        yearLevelDB.Location = New Point(293, 568)
        yearLevelDB.Name = "yearLevelDB"
        yearLevelDB.Size = New Size(336, 34)
        yearLevelDB.TabIndex = 14
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Enabled = False
        RichTextBox2.Font = New Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox2.Location = New Point(125, 165)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.RightToLeft = RightToLeft.No
        RichTextBox2.Size = New Size(505, 86)
        RichTextBox2.TabIndex = 13
        RichTextBox2.TabStop = False
        RichTextBox2.Text = "Please be assured that any information you provide in this form will be reviewed solely by the designated administrator. To protect your privacy, your identity will remain completely anonymous."
        ' 
        ' txtContent
        ' 
        txtContent.Location = New Point(758, 346)
        txtContent.Name = "txtContent"
        txtContent.Size = New Size(603, 211)
        txtContent.TabIndex = 11
        txtContent.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(758, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(337, 27)
        Label6.TabIndex = 10
        Label6.Text = "Details of the Complaint:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(758, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 27)
        Label5.TabIndex = 8
        Label5.Text = "Type of Complaint"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(771, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 27)
        Label4.TabIndex = 6
        Label4.Text = "Complaint Target"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(173, 403)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 27)
        Label3.TabIndex = 4
        Label3.Text = "Block"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(108, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 27)
        Label2.TabIndex = 2
        Label2.Text = "Year Level"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(547, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(482, 47)
        Label1.TabIndex = 1
        Label1.Text = "Let Us Hear Your Side"
        ' 
        ' userViewPanel
        ' 
        userViewPanel.Controls.Add(Label7)
        userViewPanel.Controls.Add(complainsPanel)
        userViewPanel.Location = New Point(165, 133)
        userViewPanel.Name = "userViewPanel"
        userViewPanel.Size = New Size(1525, 899)
        userViewPanel.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(572, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(350, 47)
        Label7.TabIndex = 0
        Label7.Text = "Your Complaints"
        ' 
        ' complainsPanel
        ' 
        complainsPanel.AutoScroll = True
        complainsPanel.Controls.Add(itemsPanel)
        complainsPanel.FlowDirection = FlowDirection.TopDown
        complainsPanel.Location = New Point(40, 146)
        complainsPanel.Name = "complainsPanel"
        complainsPanel.Size = New Size(1440, 715)
        complainsPanel.TabIndex = 1
        ' 
        ' itemsPanel
        ' 
        itemsPanel.BackColor = SystemColors.ActiveCaption
        itemsPanel.Controls.Add(lblDetails)
        itemsPanel.Controls.Add(lblComplaintType)
        itemsPanel.Controls.Add(lblComplaintReceiver)
        itemsPanel.Location = New Point(3, 3)
        itemsPanel.Name = "itemsPanel"
        itemsPanel.Size = New Size(1437, 98)
        itemsPanel.TabIndex = 0
        ' 
        ' lblDetails
        ' 
        lblDetails.AutoSize = True
        lblDetails.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetails.Location = New Point(720, 30)
        lblDetails.Name = "lblDetails"
        lblDetails.Size = New Size(66, 38)
        lblDetails.TabIndex = 4
        lblDetails.Text = "test"
        ' 
        ' lblComplaintType
        ' 
        lblComplaintType.AutoSize = True
        lblComplaintType.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblComplaintType.Location = New Point(395, 30)
        lblComplaintType.Name = "lblComplaintType"
        lblComplaintType.Size = New Size(66, 38)
        lblComplaintType.TabIndex = 3
        lblComplaintType.Text = "test"
        ' 
        ' lblComplaintReceiver
        ' 
        lblComplaintReceiver.AutoSize = True
        lblComplaintReceiver.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblComplaintReceiver.Location = New Point(112, 30)
        lblComplaintReceiver.Name = "lblComplaintReceiver"
        lblComplaintReceiver.Size = New Size(66, 38)
        lblComplaintReceiver.TabIndex = 2
        lblComplaintReceiver.Text = "test"
        ' 
        ' userDashBoard
        ' 
        userDashBoard.Controls.Add(loginPanel)
        userDashBoard.Controls.Add(btnToView)
        userDashBoard.Location = New Point(12, 12)
        userDashBoard.Name = "userDashBoard"
        userDashBoard.Size = New Size(1525, 897)
        userDashBoard.TabIndex = 2
        ' 
        ' btnToView
        ' 
        btnToView.Image = CType(resources.GetObject("btnToView.Image"), Image)
        btnToView.Location = New Point(403, 287)
        btnToView.Name = "btnToView"
        btnToView.Size = New Size(275, 236)
        btnToView.TabIndex = 0
        btnToView.TextAlign = ContentAlignment.BottomCenter
        btnToView.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 11F)
        Label15.Location = New Point(285, 31)
        Label15.Name = "Label15"
        Label15.Size = New Size(194, 25)
        Label15.TabIndex = 7
        Label15.Text = "NEMSU Review Board"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1517, 890)
        Controls.Add(userDashBoard)
        Controls.Add(reviewPanel)
        Controls.Add(userViewPanel)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        reviewPanel.ResumeLayout(False)
        reviewPanel.PerformLayout()
        userViewPanel.ResumeLayout(False)
        userViewPanel.PerformLayout()
        complainsPanel.ResumeLayout(False)
        itemsPanel.ResumeLayout(False)
        itemsPanel.PerformLayout()
        userDashBoard.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents loginPanel As Panel
    Friend WithEvents reviewPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContent As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents yearLevelDB As TextBox
    Friend WithEvents blockDB As TextBox
    Friend WithEvents btnSendComplaint As Button
    Friend WithEvents txtTarget As ComboBox
    Friend WithEvents txtComplaint As ComboBox
    Friend WithEvents userViewPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents complainsPanel As FlowLayoutPanel
    Friend WithEvents itemsPanel As Panel
    Friend WithEvents lblComplaintReceiver As Label
    Friend WithEvents lblComplaintType As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBlock As ComboBox
    Friend WithEvents txtYearLvl As ComboBox
    Friend WithEvents txtInstructor As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents userDashBoard As Panel
    Friend WithEvents btnToView As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLoginPass As TextBox
    Friend WithEvents Label15 As Label

End Class
