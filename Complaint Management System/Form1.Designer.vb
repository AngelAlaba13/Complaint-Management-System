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
        LabelLoginTitle = New Label()
        LabelLoginRegister = New Label()
        LabelLoginDont = New Label()
        txtLoginPass = New TextBox()
        txtLoginID = New TextBox()
        LabelLoginPass = New Label()
        LabelLoginID = New Label()
        reviewPanel = New Panel()
        backReviewPage = New PictureBox()
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
        backViewPage = New PictureBox()
        Label7 = New Label()
        complainsPanel = New FlowLayoutPanel()
        itemsPanel = New Panel()
        lblComplaintReceiver = New Label()
        userDashBoard = New Panel()
        createReviewPanel = New Panel()
        createReviewLabel = New Label()
        createReviewPicture = New PictureBox()
        viewButtonPanel = New Panel()
        viewButtonLabel = New Label()
        viewButtonPicture = New PictureBox()
        SqlCommandBuilder1 = New Microsoft.Data.SqlClient.SqlCommandBuilder()
        loginPanel.SuspendLayout()
        reviewPanel.SuspendLayout()
        CType(backReviewPage, ComponentModel.ISupportInitialize).BeginInit()
        userViewPanel.SuspendLayout()
        CType(backViewPage, ComponentModel.ISupportInitialize).BeginInit()
        complainsPanel.SuspendLayout()
        itemsPanel.SuspendLayout()
        userDashBoard.SuspendLayout()
        createReviewPanel.SuspendLayout()
        CType(createReviewPicture, ComponentModel.ISupportInitialize).BeginInit()
        viewButtonPanel.SuspendLayout()
        CType(viewButtonPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(463, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 41)
        Button1.TabIndex = 0
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(316, 274)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(134, 41)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' loginPanel
        ' 
        loginPanel.Controls.Add(LabelLoginTitle)
        loginPanel.Controls.Add(LabelLoginRegister)
        loginPanel.Controls.Add(LabelLoginDont)
        loginPanel.Controls.Add(txtLoginPass)
        loginPanel.Controls.Add(txtLoginID)
        loginPanel.Controls.Add(LabelLoginPass)
        loginPanel.Controls.Add(LabelLoginID)
        loginPanel.Controls.Add(btnLogin)
        loginPanel.Controls.Add(Button1)
        loginPanel.Location = New Point(121, 344)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(805, 456)
        loginPanel.TabIndex = 2
        ' 
        ' LabelLoginTitle
        ' 
        LabelLoginTitle.AutoSize = True
        LabelLoginTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLoginTitle.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        LabelLoginTitle.Location = New Point(345, 99)
        LabelLoginTitle.Name = "LabelLoginTitle"
        LabelLoginTitle.Size = New Size(219, 28)
        LabelLoginTitle.TabIndex = 7
        LabelLoginTitle.Text = "NEMSU Review Board"
        ' 
        ' LabelLoginRegister
        ' 
        LabelLoginRegister.AutoSize = True
        LabelLoginRegister.Cursor = Cursors.Hand
        LabelLoginRegister.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        LabelLoginRegister.ForeColor = SystemColors.Highlight
        LabelLoginRegister.Location = New Point(496, 242)
        LabelLoginRegister.Name = "LabelLoginRegister"
        LabelLoginRegister.Size = New Size(99, 20)
        LabelLoginRegister.TabIndex = 6
        LabelLoginRegister.Text = "Register here"
        ' 
        ' LabelLoginDont
        ' 
        LabelLoginDont.AutoSize = True
        LabelLoginDont.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        LabelLoginDont.Location = New Point(327, 242)
        LabelLoginDont.Name = "LabelLoginDont"
        LabelLoginDont.Size = New Size(169, 20)
        LabelLoginDont.TabIndex = 5
        LabelLoginDont.Text = "Don't have an account?"
        ' 
        ' txtLoginPass
        ' 
        txtLoginPass.BorderStyle = BorderStyle.FixedSingle
        txtLoginPass.Font = New Font("Segoe UI", 10F)
        txtLoginPass.Location = New Point(313, 194)
        txtLoginPass.Name = "txtLoginPass"
        txtLoginPass.Size = New Size(284, 30)
        txtLoginPass.TabIndex = 4
        ' 
        ' txtLoginID
        ' 
        txtLoginID.BorderStyle = BorderStyle.FixedSingle
        txtLoginID.Font = New Font("Segoe UI", 10F)
        txtLoginID.Location = New Point(313, 152)
        txtLoginID.Name = "txtLoginID"
        txtLoginID.Size = New Size(284, 30)
        txtLoginID.TabIndex = 4
        ' 
        ' LabelLoginPass
        ' 
        LabelLoginPass.AutoSize = True
        LabelLoginPass.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLoginPass.Location = New Point(204, 199)
        LabelLoginPass.Name = "LabelLoginPass"
        LabelLoginPass.Size = New Size(94, 25)
        LabelLoginPass.TabIndex = 3
        LabelLoginPass.Text = "Password:"
        ' 
        ' LabelLoginID
        ' 
        LabelLoginID.AutoSize = True
        LabelLoginID.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLoginID.Location = New Point(198, 157)
        LabelLoginID.Name = "LabelLoginID"
        LabelLoginID.Size = New Size(105, 25)
        LabelLoginID.TabIndex = 2
        LabelLoginID.Text = "Student ID:"
        ' 
        ' reviewPanel
        ' 
        reviewPanel.Controls.Add(backReviewPage)
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
        reviewPanel.Location = New Point(56, 797)
        reviewPanel.Name = "reviewPanel"
        reviewPanel.Size = New Size(1521, 896)
        reviewPanel.TabIndex = 3
        ' 
        ' backReviewPage
        ' 
        backReviewPage.Image = CType(resources.GetObject("backReviewPage.Image"), Image)
        backReviewPage.Location = New Point(29, 21)
        backReviewPage.Name = "backReviewPage"
        backReviewPage.Size = New Size(70, 49)
        backReviewPage.TabIndex = 26
        backReviewPage.TabStop = False
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
        Label8.Location = New Point(289, 663)
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
        blockDB.Location = New Point(264, 744)
        blockDB.Name = "blockDB"
        blockDB.Size = New Size(336, 34)
        blockDB.TabIndex = 15
        ' 
        ' yearLevelDB
        ' 
        yearLevelDB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        yearLevelDB.Location = New Point(264, 693)
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
        RichTextBox2.Size = New Size(512, 132)
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
        userViewPanel.Controls.Add(backViewPage)
        userViewPanel.Controls.Add(Label7)
        userViewPanel.Controls.Add(complainsPanel)
        userViewPanel.Location = New Point(118, 676)
        userViewPanel.Name = "userViewPanel"
        userViewPanel.Size = New Size(1525, 899)
        userViewPanel.TabIndex = 4
        ' 
        ' backViewPage
        ' 
        backViewPage.Image = CType(resources.GetObject("backViewPage.Image"), Image)
        backViewPage.Location = New Point(24, 18)
        backViewPage.Name = "backViewPage"
        backViewPage.Size = New Size(70, 49)
        backViewPage.TabIndex = 27
        backViewPage.TabStop = False
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
        itemsPanel.Controls.Add(lblComplaintReceiver)
        itemsPanel.Location = New Point(3, 3)
        itemsPanel.Name = "itemsPanel"
        itemsPanel.Size = New Size(1437, 98)
        itemsPanel.TabIndex = 0
        ' 
        ' lblComplaintReceiver
        ' 
        lblComplaintReceiver.AutoSize = True
        lblComplaintReceiver.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblComplaintReceiver.Location = New Point(112, 30)
        lblComplaintReceiver.Name = "lblComplaintReceiver"
        lblComplaintReceiver.Size = New Size(0, 38)
        lblComplaintReceiver.TabIndex = 2
        ' 
        ' userDashBoard
        ' 
        userDashBoard.Controls.Add(createReviewPanel)
        userDashBoard.Controls.Add(viewButtonPanel)
        userDashBoard.Location = New Point(85, 740)
        userDashBoard.Name = "userDashBoard"
        userDashBoard.Size = New Size(1525, 897)
        userDashBoard.TabIndex = 2
        ' 
        ' createReviewPanel
        ' 
        createReviewPanel.BackColor = SystemColors.ButtonFace
        createReviewPanel.BorderStyle = BorderStyle.FixedSingle
        createReviewPanel.Controls.Add(createReviewLabel)
        createReviewPanel.Controls.Add(createReviewPicture)
        createReviewPanel.Location = New Point(717, 215)
        createReviewPanel.Name = "createReviewPanel"
        createReviewPanel.Size = New Size(275, 221)
        createReviewPanel.TabIndex = 2
        ' 
        ' createReviewLabel
        ' 
        createReviewLabel.AutoSize = True
        createReviewLabel.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        createReviewLabel.Location = New Point(68, 172)
        createReviewLabel.Name = "createReviewLabel"
        createReviewLabel.Size = New Size(145, 25)
        createReviewLabel.TabIndex = 1
        createReviewLabel.Text = "Send Complaint"
        ' 
        ' createReviewPicture
        ' 
        createReviewPicture.Image = CType(resources.GetObject("createReviewPicture.Image"), Image)
        createReviewPicture.Location = New Point(74, 27)
        createReviewPicture.Name = "createReviewPicture"
        createReviewPicture.Size = New Size(132, 130)
        createReviewPicture.TabIndex = 0
        createReviewPicture.TabStop = False
        ' 
        ' viewButtonPanel
        ' 
        viewButtonPanel.BackColor = SystemColors.ButtonFace
        viewButtonPanel.BorderStyle = BorderStyle.FixedSingle
        viewButtonPanel.Controls.Add(viewButtonLabel)
        viewButtonPanel.Controls.Add(viewButtonPicture)
        viewButtonPanel.Location = New Point(358, 215)
        viewButtonPanel.Name = "viewButtonPanel"
        viewButtonPanel.Size = New Size(275, 221)
        viewButtonPanel.TabIndex = 1
        ' 
        ' viewButtonLabel
        ' 
        viewButtonLabel.AutoSize = True
        viewButtonLabel.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewButtonLabel.Location = New Point(40, 172)
        viewButtonLabel.Name = "viewButtonLabel"
        viewButtonLabel.Size = New Size(195, 25)
        viewButtonLabel.TabIndex = 1
        viewButtonLabel.Text = "View Sent Complaints"
        ' 
        ' viewButtonPicture
        ' 
        viewButtonPicture.Image = CType(resources.GetObject("viewButtonPicture.Image"), Image)
        viewButtonPicture.Location = New Point(69, 27)
        viewButtonPicture.Name = "viewButtonPicture"
        viewButtonPicture.Size = New Size(132, 123)
        viewButtonPicture.TabIndex = 0
        viewButtonPicture.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1517, 890)
        Controls.Add(loginPanel)
        Controls.Add(userViewPanel)
        Controls.Add(reviewPanel)
        Controls.Add(userDashBoard)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        reviewPanel.ResumeLayout(False)
        reviewPanel.PerformLayout()
        CType(backReviewPage, ComponentModel.ISupportInitialize).EndInit()
        userViewPanel.ResumeLayout(False)
        userViewPanel.PerformLayout()
        CType(backViewPage, ComponentModel.ISupportInitialize).EndInit()
        complainsPanel.ResumeLayout(False)
        itemsPanel.ResumeLayout(False)
        itemsPanel.PerformLayout()
        userDashBoard.ResumeLayout(False)
        createReviewPanel.ResumeLayout(False)
        createReviewPanel.PerformLayout()
        CType(createReviewPicture, ComponentModel.ISupportInitialize).EndInit()
        viewButtonPanel.ResumeLayout(False)
        viewButtonPanel.PerformLayout()
        CType(viewButtonPicture, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBlock As ComboBox
    Friend WithEvents txtYearLvl As ComboBox
    Friend WithEvents txtInstructor As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents userDashBoard As Panel
    Friend WithEvents viewButtonPicture As PictureBox
    Friend WithEvents viewButtonPanel As Panel
    Friend WithEvents viewButtonLabel As Label
    Friend WithEvents createReviewPanel As Panel
    Friend WithEvents createReviewLabel As Label
    Friend WithEvents createReviewPicture As PictureBox
    Friend WithEvents backReviewPage As PictureBox
    Friend WithEvents backViewPage As PictureBox

    Friend WithEvents btnToView As Button
    Friend WithEvents LabelLoginPass As Label
    Friend WithEvents LabelLoginID As Label
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents LabelLoginRegister As Label
    Friend WithEvents LabelLoginDont As Label
    Friend WithEvents txtLoginPass As TextBox
    Friend WithEvents LabelLoginTitle As Label
    Friend WithEvents SqlCommandBuilder1 As Microsoft.Data.SqlClient.SqlCommandBuilder

End Class
