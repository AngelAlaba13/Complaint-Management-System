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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        loginPanel = New Panel()
        Label11 = New Label()
        Button1 = New Guna.UI2.WinForms.Guna2Button()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        txtLoginPass = New Guna.UI2.WinForms.Guna2TextBox()
        txtLoginID = New Guna.UI2.WinForms.Guna2TextBox()
        LabelLoginTitle = New Label()
        LabelLoginRegister = New Label()
        LabelLoginDont = New Label()
        LabelLoginPass = New Label()
        LabelLoginID = New Label()
        reviewPanel = New Panel()
        Label12 = New Label()
        Label8 = New Label()
        btnSendComplaint = New Guna.UI2.WinForms.Guna2Button()
        backReviewPage = New PictureBox()
        txtInstructor = New ComboBox()
        Label10 = New Label()
        txtBlock = New ComboBox()
        txtYearLvl = New ComboBox()
        txtStudentID = New TextBox()
        Label9 = New Label()
        txtComplaint = New ComboBox()
        txtTarget = New ComboBox()
        txtContent = New RichTextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        userDashBoard = New Panel()
        Panel1 = New Panel()
        Label13 = New Label()
        PictureBox1 = New PictureBox()
        createReviewPanel = New Panel()
        createReviewLabel = New Label()
        createReviewPicture = New PictureBox()
        viewButtonPanel = New Panel()
        viewButtonLabel = New Label()
        viewButtonPicture = New PictureBox()
        userViewPanel = New Panel()
        backViewPage = New PictureBox()
        Label7 = New Label()
        complainsPanel = New FlowLayoutPanel()
        itemsPanel = New Guna.UI2.WinForms.Guna2Panel()
        SqlCommandBuilder1 = New Microsoft.Data.SqlClient.SqlCommandBuilder()
        loginPanel.SuspendLayout()
        reviewPanel.SuspendLayout()
        CType(backReviewPage, ComponentModel.ISupportInitialize).BeginInit()
        userDashBoard.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        createReviewPanel.SuspendLayout()
        CType(createReviewPicture, ComponentModel.ISupportInitialize).BeginInit()
        viewButtonPanel.SuspendLayout()
        CType(viewButtonPicture, ComponentModel.ISupportInitialize).BeginInit()
        userViewPanel.SuspendLayout()
        CType(backViewPage, ComponentModel.ISupportInitialize).BeginInit()
        complainsPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        loginPanel.Controls.Add(Label11)
        loginPanel.Controls.Add(Button1)
        loginPanel.Controls.Add(btnLogin)
        loginPanel.Controls.Add(txtLoginPass)
        loginPanel.Controls.Add(txtLoginID)
        loginPanel.Controls.Add(LabelLoginTitle)
        loginPanel.Controls.Add(LabelLoginRegister)
        loginPanel.Controls.Add(LabelLoginDont)
        loginPanel.Controls.Add(LabelLoginPass)
        loginPanel.Controls.Add(LabelLoginID)
        loginPanel.Location = New Point(-2, -3)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(1527, 894)
        loginPanel.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Black", 45.0F, FontStyle.Bold)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(196, 437)
        Label11.Name = "Label11"
        Label11.Size = New Size(590, 106)
        Label11.TabIndex = 20
        Label11.Text = "SmartReview"
        ' 
        ' Button1
        ' 
        Button1.Animated = True
        Button1.BackColor = Color.Transparent
        Button1.BorderRadius = 10
        Button1.BorderThickness = 1
        Button1.CustomizableEdges = CustomizableEdges13
        Button1.DisabledState.BorderColor = Color.DarkGray
        Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Button1.FillColor = Color.FromArgb(CByte(207), CByte(176), CByte(49))
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1202, 570)
        Button1.Name = "Button1"
        Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Button1.Size = New Size(148, 46)
        Button1.TabIndex = 19
        Button1.Text = "CLEAR"
        Button1.UseTransparentBackground = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(72), CByte(35), CByte(155))
        btnLogin.BorderRadius = 10
        btnLogin.BorderThickness = 1
        btnLogin.CustomizableEdges = CustomizableEdges15
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(207), CByte(176), CByte(49))
        btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(1045, 570)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnLogin.Size = New Size(148, 46)
        btnLogin.TabIndex = 18
        btnLogin.Text = "LOG IN"
        ' 
        ' txtLoginPass
        ' 
        txtLoginPass.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(201))
        txtLoginPass.BorderRadius = 3
        txtLoginPass.CustomizableEdges = CustomizableEdges17
        txtLoginPass.DefaultText = ""
        txtLoginPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtLoginPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtLoginPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoginPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoginPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoginPass.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLoginPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoginPass.Location = New Point(1016, 373)
        txtLoginPass.Margin = New Padding(4, 5, 4, 5)
        txtLoginPass.Name = "txtLoginPass"
        txtLoginPass.PlaceholderText = ""
        txtLoginPass.SelectedText = ""
        txtLoginPass.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        txtLoginPass.Size = New Size(329, 31)
        txtLoginPass.TabIndex = 13
        ' 
        ' txtLoginID
        ' 
        txtLoginID.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(201))
        txtLoginID.BorderRadius = 3
        txtLoginID.CustomizableEdges = CustomizableEdges19
        txtLoginID.DefaultText = ""
        txtLoginID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtLoginID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtLoginID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoginID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoginID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoginID.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLoginID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoginID.Location = New Point(1016, 321)
        txtLoginID.Margin = New Padding(4, 5, 4, 5)
        txtLoginID.Name = "txtLoginID"
        txtLoginID.PlaceholderText = ""
        txtLoginID.SelectedText = ""
        txtLoginID.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        txtLoginID.Size = New Size(329, 31)
        txtLoginID.TabIndex = 12
        ' 
        ' LabelLoginTitle
        ' 
        LabelLoginTitle.AutoSize = True
        LabelLoginTitle.Font = New Font("Arial Black", 55.0F, FontStyle.Bold)
        LabelLoginTitle.ForeColor = Color.White
        LabelLoginTitle.Location = New Point(126, 335)
        LabelLoginTitle.Name = "LabelLoginTitle"
        LabelLoginTitle.Size = New Size(428, 129)
        LabelLoginTitle.TabIndex = 7
        LabelLoginTitle.Text = "NEMSU"
        ' 
        ' LabelLoginRegister
        ' 
        LabelLoginRegister.AutoSize = True
        LabelLoginRegister.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        LabelLoginRegister.Cursor = Cursors.Hand
        LabelLoginRegister.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Underline)
        LabelLoginRegister.ForeColor = Color.LightSkyBlue
        LabelLoginRegister.Location = New Point(1177, 446)
        LabelLoginRegister.Name = "LabelLoginRegister"
        LabelLoginRegister.Size = New Size(132, 28)
        LabelLoginRegister.TabIndex = 6
        LabelLoginRegister.Text = "Register here"
        ' 
        ' LabelLoginDont
        ' 
        LabelLoginDont.AutoSize = True
        LabelLoginDont.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        LabelLoginDont.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LabelLoginDont.ForeColor = Color.White
        LabelLoginDont.Location = New Point(953, 446)
        LabelLoginDont.Name = "LabelLoginDont"
        LabelLoginDont.Size = New Size(223, 28)
        LabelLoginDont.TabIndex = 5
        LabelLoginDont.Text = "Don't have an account?"
        ' 
        ' LabelLoginPass
        ' 
        LabelLoginPass.AutoSize = True
        LabelLoginPass.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        LabelLoginPass.Font = New Font("Arial Rounded MT Bold", 13.8F)
        LabelLoginPass.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        LabelLoginPass.Location = New Point(870, 377)
        LabelLoginPass.Name = "LabelLoginPass"
        LabelLoginPass.Size = New Size(129, 27)
        LabelLoginPass.TabIndex = 3
        LabelLoginPass.Text = "Password:"
        ' 
        ' LabelLoginID
        ' 
        LabelLoginID.AutoSize = True
        LabelLoginID.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        LabelLoginID.Font = New Font("Arial Rounded MT Bold", 13.8F)
        LabelLoginID.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        LabelLoginID.Location = New Point(863, 323)
        LabelLoginID.Name = "LabelLoginID"
        LabelLoginID.Size = New Size(136, 27)
        LabelLoginID.TabIndex = 2
        LabelLoginID.Text = "Student ID:"
        ' 
        ' reviewPanel
        ' 
        reviewPanel.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        reviewPanel.Controls.Add(Label12)
        reviewPanel.Controls.Add(Label8)
        reviewPanel.Controls.Add(btnSendComplaint)
        reviewPanel.Controls.Add(backReviewPage)
        reviewPanel.Controls.Add(txtInstructor)
        reviewPanel.Controls.Add(Label10)
        reviewPanel.Controls.Add(txtBlock)
        reviewPanel.Controls.Add(txtYearLvl)
        reviewPanel.Controls.Add(txtStudentID)
        reviewPanel.Controls.Add(Label9)
        reviewPanel.Controls.Add(txtComplaint)
        reviewPanel.Controls.Add(txtTarget)
        reviewPanel.Controls.Add(txtContent)
        reviewPanel.Controls.Add(Label6)
        reviewPanel.Controls.Add(Label5)
        reviewPanel.Controls.Add(Label4)
        reviewPanel.Controls.Add(Label3)
        reviewPanel.Controls.Add(Label2)
        reviewPanel.Controls.Add(Label1)
        reviewPanel.Location = New Point(2, -2)
        reviewPanel.Name = "reviewPanel"
        reviewPanel.Size = New Size(1521, 896)
        reviewPanel.TabIndex = 3
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 15.0F)
        Label12.ForeColor = Color.Transparent
        Label12.Location = New Point(980, 166)
        Label12.Name = "Label12"
        Label12.Size = New Size(165, 29)
        Label12.TabIndex = 31
        Label12.Text = "Your Review"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 15.0F)
        Label8.ForeColor = Color.Transparent
        Label8.Location = New Point(282, 166)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 29)
        Label8.TabIndex = 30
        Label8.Text = "About You"
        ' 
        ' btnSendComplaint
        ' 
        btnSendComplaint.BorderRadius = 10
        btnSendComplaint.CustomizableEdges = CustomizableEdges21
        btnSendComplaint.DisabledState.BorderColor = Color.DarkGray
        btnSendComplaint.DisabledState.CustomBorderColor = Color.DarkGray
        btnSendComplaint.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSendComplaint.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSendComplaint.FillColor = Color.FromArgb(CByte(207), CByte(176), CByte(49))
        btnSendComplaint.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnSendComplaint.ForeColor = Color.White
        btnSendComplaint.Location = New Point(1224, 748)
        btnSendComplaint.Name = "btnSendComplaint"
        btnSendComplaint.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        btnSendComplaint.Size = New Size(148, 46)
        btnSendComplaint.TabIndex = 29
        btnSendComplaint.Text = "Send"
        ' 
        ' backReviewPage
        ' 
        backReviewPage.Image = CType(resources.GetObject("backReviewPage.Image"), Image)
        backReviewPage.Location = New Point(29, 21)
        backReviewPage.Name = "backReviewPage"
        backReviewPage.Size = New Size(70, 49)
        backReviewPage.SizeMode = PictureBoxSizeMode.StretchImage
        backReviewPage.TabIndex = 26
        backReviewPage.TabStop = False
        ' 
        ' txtInstructor
        ' 
        txtInstructor.Font = New Font("Segoe UI", 12.0F)
        txtInstructor.FormattingEnabled = True
        txtInstructor.Location = New Point(158, 602)
        txtInstructor.Name = "txtInstructor"
        txtInstructor.Size = New Size(481, 36)
        txtInstructor.TabIndex = 25
        txtInstructor.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 13.8F)
        Label10.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        Label10.Location = New Point(158, 572)
        Label10.Name = "Label10"
        Label10.Size = New Size(194, 27)
        Label10.TabIndex = 24
        Label10.Text = "Instructor Name"
        Label10.Visible = False
        ' 
        ' txtBlock
        ' 
        txtBlock.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBlock.FormattingEnabled = True
        txtBlock.Location = New Point(158, 500)
        txtBlock.Name = "txtBlock"
        txtBlock.Size = New Size(481, 36)
        txtBlock.TabIndex = 23
        ' 
        ' txtYearLvl
        ' 
        txtYearLvl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtYearLvl.FormattingEnabled = True
        txtYearLvl.Location = New Point(158, 398)
        txtYearLvl.Name = "txtYearLvl"
        txtYearLvl.Size = New Size(481, 36)
        txtYearLvl.TabIndex = 22
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStudentID.Location = New Point(158, 304)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(481, 34)
        txtStudentID.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 13.8F)
        Label9.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        Label9.Location = New Point(158, 274)
        Label9.Name = "Label9"
        Label9.Size = New Size(129, 27)
        Label9.TabIndex = 20
        Label9.Text = "Student ID"
        ' 
        ' txtComplaint
        ' 
        txtComplaint.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComplaint.FormattingEnabled = True
        txtComplaint.Location = New Point(792, 390)
        txtComplaint.Name = "txtComplaint"
        txtComplaint.Size = New Size(580, 36)
        txtComplaint.TabIndex = 18
        ' 
        ' txtTarget
        ' 
        txtTarget.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTarget.FormattingEnabled = True
        txtTarget.Location = New Point(792, 294)
        txtTarget.Name = "txtTarget"
        txtTarget.Size = New Size(580, 36)
        txtTarget.TabIndex = 17
        ' 
        ' txtContent
        ' 
        txtContent.Location = New Point(800, 500)
        txtContent.Name = "txtContent"
        txtContent.Size = New Size(572, 211)
        txtContent.TabIndex = 11
        txtContent.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 13.8F)
        Label6.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        Label6.Location = New Point(792, 454)
        Label6.Name = "Label6"
        Label6.Size = New Size(285, 27)
        Label6.TabIndex = 10
        Label6.Text = "Details of the Complaint:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 13.8F)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        Label5.Location = New Point(792, 352)
        Label5.Name = "Label5"
        Label5.Size = New Size(213, 27)
        Label5.TabIndex = 8
        Label5.Text = "Type of Complaint"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 13.8F)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        Label4.Location = New Point(792, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(205, 27)
        Label4.TabIndex = 6
        Label4.Text = "Complaint Target"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 13.8F)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        Label3.Location = New Point(158, 470)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 27)
        Label3.TabIndex = 4
        Label3.Text = "Block"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 13.8F)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(211), CByte(23))
        Label2.Location = New Point(158, 365)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 27)
        Label2.TabIndex = 2
        Label2.Text = "Year Level"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 28.2F, FontStyle.Bold)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(105, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(405, 67)
        Label1.TabIndex = 1
        Label1.Text = "Send a Review"
        ' 
        ' userDashBoard
        ' 
        userDashBoard.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        userDashBoard.Controls.Add(Panel1)
        userDashBoard.Controls.Add(createReviewPanel)
        userDashBoard.Controls.Add(viewButtonPanel)
        userDashBoard.Location = New Point(3, 460)
        userDashBoard.Name = "userDashBoard"
        userDashBoard.Size = New Size(1525, 897)
        userDashBoard.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(248), CByte(55), CByte(120))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(34, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(243, 90)
        Panel1.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Black", 20.2F, FontStyle.Bold)
        Label13.ForeColor = Color.FromArgb(CByte(249), CByte(185), CByte(200))
        Label13.Location = New Point(92, 21)
        Label13.Name = "Label13"
        Label13.Size = New Size(150, 48)
        Label13.TabIndex = 1
        Label13.Text = "Logout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 82)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' createReviewPanel
        ' 
        createReviewPanel.BackColor = Color.FromArgb(CByte(207), CByte(176), CByte(49))
        createReviewPanel.BorderStyle = BorderStyle.FixedSingle
        createReviewPanel.Controls.Add(createReviewLabel)
        createReviewPanel.Controls.Add(createReviewPicture)
        createReviewPanel.ForeColor = Color.White
        createReviewPanel.Location = New Point(820, 337)
        createReviewPanel.Name = "createReviewPanel"
        createReviewPanel.Size = New Size(275, 221)
        createReviewPanel.TabIndex = 2
        ' 
        ' createReviewLabel
        ' 
        createReviewLabel.AutoSize = True
        createReviewLabel.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        createReviewLabel.Location = New Point(74, 171)
        createReviewLabel.Name = "createReviewLabel"
        createReviewLabel.Size = New Size(132, 25)
        createReviewLabel.TabIndex = 1
        createReviewLabel.Text = "Send a Review"
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
        viewButtonPanel.BackColor = Color.FromArgb(CByte(207), CByte(176), CByte(49))
        viewButtonPanel.BorderStyle = BorderStyle.FixedSingle
        viewButtonPanel.Controls.Add(viewButtonLabel)
        viewButtonPanel.Controls.Add(viewButtonPicture)
        viewButtonPanel.ForeColor = Color.White
        viewButtonPanel.Location = New Point(461, 337)
        viewButtonPanel.Name = "viewButtonPanel"
        viewButtonPanel.Size = New Size(275, 221)
        viewButtonPanel.TabIndex = 1
        ' 
        ' viewButtonLabel
        ' 
        viewButtonLabel.AutoSize = True
        viewButtonLabel.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewButtonLabel.Location = New Point(52, 171)
        viewButtonLabel.Name = "viewButtonLabel"
        viewButtonLabel.Size = New Size(168, 25)
        viewButtonLabel.TabIndex = 1
        viewButtonLabel.Text = "View Sent Reviews"
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
        ' userViewPanel
        ' 
        userViewPanel.AutoScroll = True
        userViewPanel.BackColor = Color.FromArgb(CByte(56), CByte(20), CByte(137))
        userViewPanel.Controls.Add(backViewPage)
        userViewPanel.Controls.Add(Label7)
        userViewPanel.Controls.Add(complainsPanel)
        userViewPanel.Location = New Point(2, -1)
        userViewPanel.Name = "userViewPanel"
        userViewPanel.Size = New Size(1525, 899)
        userViewPanel.TabIndex = 4
        ' 
        ' backViewPage
        ' 
        backViewPage.Image = CType(resources.GetObject("backViewPage.Image"), Image)
        backViewPage.Location = New Point(65, 59)
        backViewPage.Name = "backViewPage"
        backViewPage.Size = New Size(70, 51)
        backViewPage.SizeMode = PictureBoxSizeMode.StretchImage
        backViewPage.TabIndex = 27
        backViewPage.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Black", 28.2F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(619, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(376, 67)
        Label7.TabIndex = 0
        Label7.Text = "Your Reviews"
        ' 
        ' complainsPanel
        ' 
        complainsPanel.AutoScroll = True
        complainsPanel.Controls.Add(itemsPanel)
        complainsPanel.Location = New Point(62, 155)
        complainsPanel.Name = "complainsPanel"
        complainsPanel.Size = New Size(1390, 715)
        complainsPanel.TabIndex = 1
        ' 
        ' itemsPanel
        ' 
        itemsPanel.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        itemsPanel.BorderRadius = 30
        itemsPanel.CustomizableEdges = CustomizableEdges23
        itemsPanel.FillColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        itemsPanel.Location = New Point(3, 3)
        itemsPanel.Name = "itemsPanel"
        itemsPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        itemsPanel.Size = New Size(1351, 96)
        itemsPanel.TabIndex = 28
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1517, 890)
        Controls.Add(userViewPanel)
        Controls.Add(reviewPanel)
        Controls.Add(userDashBoard)
        Controls.Add(reviewPanel)
        Controls.Add(userViewPanel)
        Controls.Add(loginPanel)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        reviewPanel.ResumeLayout(False)
        reviewPanel.PerformLayout()
        CType(backReviewPage, ComponentModel.ISupportInitialize).EndInit()
        userDashBoard.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        createReviewPanel.ResumeLayout(False)
        createReviewPanel.PerformLayout()
        CType(createReviewPicture, ComponentModel.ISupportInitialize).EndInit()
        viewButtonPanel.ResumeLayout(False)
        viewButtonPanel.PerformLayout()
        CType(viewButtonPicture, ComponentModel.ISupportInitialize).EndInit()
        userViewPanel.ResumeLayout(False)
        userViewPanel.PerformLayout()
        CType(backViewPage, ComponentModel.ISupportInitialize).EndInit()
        complainsPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents loginPanel As Panel
    Friend WithEvents reviewPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContent As RichTextBox
    Friend WithEvents txtTarget As ComboBox
    Friend WithEvents txtComplaint As ComboBox
    Friend WithEvents userViewPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents complainsPanel As FlowLayoutPanel
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
    Friend WithEvents LabelLoginRegister As Label
    Friend WithEvents LabelLoginDont As Label
    Friend WithEvents LabelLoginTitle As Label
    Friend WithEvents SqlCommandBuilder1 As Microsoft.Data.SqlClient.SqlCommandBuilder
    Friend WithEvents txtLoginPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLoginID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSendComplaint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents itemsPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
