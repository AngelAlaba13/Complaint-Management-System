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
        Button1 = New Button()
        btnLogin = New Button()
        loginPanel = New Panel()
        reviewPanel = New Panel()
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
        txtBlock = New TextBox()
        Label3 = New Label()
        txtYearLvl = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        userViewPanel = New Panel()
        complainsPanel = New FlowLayoutPanel()
        itemsPanel = New Panel()
        lblDetails = New Label()
        lblComplaintType = New Label()
        lblComplaintReceiver = New Label()
        Label7 = New Label()
        loginPanel.SuspendLayout()
        reviewPanel.SuspendLayout()
        userViewPanel.SuspendLayout()
        complainsPanel.SuspendLayout()
        itemsPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(208, 43)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 41)
        Button1.TabIndex = 0
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(208, 104)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(134, 41)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' loginPanel
        ' 
        loginPanel.Controls.Add(btnLogin)
        loginPanel.Controls.Add(Button1)
        loginPanel.Location = New Point(332, 29)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(805, 456)
        loginPanel.TabIndex = 2
        ' 
        ' reviewPanel
        ' 
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
        reviewPanel.Controls.Add(txtBlock)
        reviewPanel.Controls.Add(Label3)
        reviewPanel.Controls.Add(txtYearLvl)
        reviewPanel.Controls.Add(Label2)
        reviewPanel.Controls.Add(Label1)
        reviewPanel.Location = New Point(6, 10)
        reviewPanel.Name = "reviewPanel"
        reviewPanel.Size = New Size(1514, 850)
        reviewPanel.TabIndex = 3
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
        ' txtBlock
        ' 
        txtBlock.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBlock.Location = New Point(280, 398)
        txtBlock.Name = "txtBlock"
        txtBlock.Size = New Size(336, 34)
        txtBlock.TabIndex = 5
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
        ' txtYearLvl
        ' 
        txtYearLvl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtYearLvl.Location = New Point(280, 346)
        txtYearLvl.Name = "txtYearLvl"
        txtYearLvl.Size = New Size(336, 34)
        txtYearLvl.TabIndex = 3
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
        userViewPanel.Controls.Add(complainsPanel)
        userViewPanel.Controls.Add(Label7)
        userViewPanel.Location = New Point(-2, -5)
        userViewPanel.Name = "userViewPanel"
        userViewPanel.Size = New Size(1525, 899)
        userViewPanel.TabIndex = 4
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(595, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(350, 47)
        Label7.TabIndex = 0
        Label7.Text = "Your Complaints"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1517, 890)
        Controls.Add(reviewPanel)
        Controls.Add(userViewPanel)
        Controls.Add(loginPanel)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        loginPanel.ResumeLayout(False)
        reviewPanel.ResumeLayout(False)
        reviewPanel.PerformLayout()
        userViewPanel.ResumeLayout(False)
        userViewPanel.PerformLayout()
        complainsPanel.ResumeLayout(False)
        itemsPanel.ResumeLayout(False)
        itemsPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents loginPanel As Panel
    Friend WithEvents reviewPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYearLvl As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBlock As TextBox
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

End Class
