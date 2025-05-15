Imports Microsoft.Data.SqlClient

Public Class Form1

    Private MyDataApt As New SqlDataAdapter
    Private UserDataAdpt As New SqlDataAdapter
    Private MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Public Shared Mycn As New SqlConnection
    Private MyRowPosition As Integer = 0
    Private currentUserID As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Angel-connection
        Mycn.ConnectionString = "Data Source=DESKTOP-439OE8U\SQLEXPRESS;Initial Catalog=complaintDB;Integrated Security=True;Trust Server Certificate=True"
        'karl-connection
        'Mycn.ConnectionString = "Data Source=LAPTOP-O85KOUQB\SQLEXPRESS;Initial Catalog=complaintDB;Integrated Security=True;Trust Server Certificate=True"
        Mycn.Open()

        MyDataApt = New SqlDataAdapter("SELECT * FROM masterTable", Mycn)
        UserDataAdpt = New SqlDataAdapter("SELECT * FROM userTable", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDataApt)
        MyDataApt.Fill(MyDataTbl)

        userDashBoard.Visible = False
        userViewPanel.Visible = False
        reviewPanel.Visible = False
        txtLoginPass.PasswordChar = "*"c

        With MyDataTbl.Columns("ID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
        End With

        Dim MyDataRow As DataRow = MyDataTbl.Rows(5)

        yearLevelDB.Text = MyDataRow("Instructor").ToString()
        blockDB.Text = MyDataRow("Block").ToString()

        txtYearLvl.Items.Add("1st Year")
        txtYearLvl.Items.Add("2nd Year")
        txtYearLvl.Items.Add("3rd Year")
        txtYearLvl.Items.Add("4th Year")

        txtBlock.Items.Add("A")
        txtBlock.Items.Add("B")
        txtBlock.Items.Add("C")
        txtBlock.Items.Add("D")
        txtBlock.Items.Add("E")
        txtBlock.Items.Add("F")
        txtBlock.Items.Add("G")

        txtTarget.Items.Add("to Instructor")
        txtTarget.Items.Add("to the College")
        txtTarget.Items.Add("to the Officers")
        txtTarget.Items.Add("Others")

        txtComplaint.Items.Add("Complaint")
        txtComplaint.Items.Add("Feedback")
        txtComplaint.Items.Add("Suggestion")

        txtInstructor.Items.Add("Dr. Nap Nichole Greg S. Salera")
        txtInstructor.Items.Add("Engr. Esmael V. Maliberan")
        txtInstructor.Items.Add("Dr. Christian Born A. Isip")
        txtInstructor.Items.Add("Dr. Catherine R. Alimboyong")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtLoginID.Text = ""
        txtLoginPass.Text = ""



    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim loginBld = New SqlCommandBuilder(UserDataAdpt)

        Dim username As String = txtLoginID.Text
        Dim Password As String = txtLoginPass.Text

        Dim query As String = "Select * from userTable where StudentID = '" & username & "' AND [Password] = '" & Password & "'"
        Dim adapter As New SqlDataAdapter(query, Mycn)

        Dim table As New DataTable()

        Try
            adapter.Fill(table)

            Dim role As String = table.Rows(0)("Role").ToString()


            If table.Rows.Count > 0 Then
                If role = "student" Then
                    loginPanel.Visible = False
                    userViewPanel.Visible = False
                    userDashBoard.Visible = True
                    reviewPanel.Visible = False

                    MessageBox.Show("Login Successful.")
                ElseIf (role = "admin") Then
                    loginPanel.Visible = False
                    adminForm.Show()
                    Me.Hide()
                    adminForm.Focus()
                    MessageBox.Show("Paki modify ko ani nga part kay basin dli mao ang admin form nga na show and other stuff nga nagka idk wtf?")

                End If

            Else
                MessageBox.Show("Invalid Student ID or Password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub btnSendComplaint_Click(sender As Object, e As EventArgs) Handles btnSendComplaint.Click
        Try
            If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                MessageBox.Show("Please enter your Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtStudentID.Focus()
                Exit Sub
            End If


            If String.IsNullOrWhiteSpace(txtYearLvl.Text) Then
                MessageBox.Show("Please enter your Year Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtYearLvl.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtBlock.Text) Then
                MessageBox.Show("Please enter your Block.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBlock.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtTarget.Text) Then
                MessageBox.Show("Please select the Complaint Receiver.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTarget.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtComplaint.Text) Then
                MessageBox.Show("Please select the Complaint Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtComplaint.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtContent.Text) Then
                MessageBox.Show("Please provide the complaint details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContent.Focus()
                Exit Sub
            End If

            If txtTarget.Text = "to Instructor" AndAlso txtInstructor.SelectedIndex = -1 Then
                MessageBox.Show("Please select the instructor to whom the complaint is directed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtInstructor.Focus()
                Exit Sub
            End If

            Dim MyNewRow As DataRow = MyDataTbl.NewRow()
            MyDataTbl.Rows.Add(MyNewRow)
            MyRowPosition = MyDataTbl.Rows.Count - 1

            MyDataTbl.Rows(MyRowPosition)("StudentID") = txtStudentID.Text
            MyDataTbl.Rows(MyRowPosition)("YearLevel") = txtYearLvl.Text
            MyDataTbl.Rows(MyRowPosition)("Block") = txtBlock.Text
            MyDataTbl.Rows(MyRowPosition)("ComplaintReceiver") = txtTarget.Text
            MyDataTbl.Rows(MyRowPosition)("ComplaintType") = txtComplaint.Text
            MyDataTbl.Rows(MyRowPosition)("Details") = txtContent.Text
            If txtTarget.Text = "to Instructor" Then
                MyDataTbl.Rows(MyRowPosition)("Instructor") = txtInstructor.Text
            Else
                MyDataTbl.Rows(MyRowPosition)("Instructor") = DBNull.Value
            End If

            MyDataApt.Update(MyDataTbl)

            txtStudentID.Clear()
            txtYearLvl.SelectedIndex = -1
            txtBlock.SelectedIndex = -1
            txtTarget.SelectedIndex = -1
            txtInstructor.SelectedIndex = -1
            txtComplaint.SelectedIndex = -1
            txtContent.Clear()


            Dim result As DialogResult = MessageBox.Show("Your complaint has been recorded successfully. Do you want to view your response?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                currentUserID = MyDataTbl.Rows(MyRowPosition)("StudentID").ToString()

                loginPanel.Visible = False
                reviewPanel.Visible = False
                userViewPanel.Visible = True
                LoadComplains()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub showRecords()
    '    If MyDataTbl.Rows.Count = 0 Then

    '    End If
    'End Sub

    Private Sub LoadComplains()
        complainsPanel.Controls.Clear()

        Dim query As String = "SELECT ID, ComplaintReceiver, ComplaintType, Details FROM masterTable WHERE StudentID = @id"
        Using cmd As New SqlCommand(query, Mycn)
            cmd.Parameters.AddWithValue("@id", currentUserID)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim itemsPanel As New Panel With {
                        .Width = complainsPanel.Width - 20,
                        .Height = 115,
                        .BackColor = Color.White,
                    .BorderStyle = BorderStyle.FixedSingle,
                    .Margin = New Padding(5)
                    }

                    Dim lblComplaintReceiver As New Label With {
                        .Text = reader("ComplaintReceiver").ToString(),
                        .Font = New Font("Segoe UI", 15, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, 5),
                        .AutoSize = True
                        }

                    Dim lblComplaintType As New Label With {
                    .Text = reader("ComplaintType").ToString(),
                    .Font = New Font("Segoe UI", 11),
                    .ForeColor = Color.Black,
                    .Location = New Point(12, 40),
                    .AutoSize = True
                }


                    Dim lblDetails As New Label With {
                        .Text = reader("Details").ToString(),
                        .Font = New Font("Segoe UI", 10),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, 75),
                        .Size = New Size(itemsPanel.Width - 20, 40),
                        .AutoEllipsis = True
                    }

                    itemsPanel.Controls.Add(lblComplaintReceiver)
                    itemsPanel.Controls.Add(lblComplaintType)
                    itemsPanel.Controls.Add(lblDetails)

                    complainsPanel.Controls.Add(itemsPanel)



                End While
            End Using
        End Using
    End Sub

    Private Sub txtTarget_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTarget.SelectedIndexChanged
        Console.WriteLine("Target: " & txtTarget.Text)

        If txtTarget.SelectedItem IsNot Nothing AndAlso txtTarget.SelectedItem.ToString() = "to Instructor" Then
            txtInstructor.Visible = True
            Label10.Visible = True
        Else
            txtInstructor.Visible = False
            Label10.Visible = False
            txtInstructor.SelectedIndex = -1
        End If
    End Sub

    'direct to view reviews
    Private Sub viewButtonPanel_Click(sender As Object, e As EventArgs) Handles viewButtonPanel.Click
        userViewPanel.Visible = True
        loginPanel.Visible = False
        userDashBoard.Visible = False
        reviewPanel.Visible = False
    End Sub

    Private Sub viewButtonPicture_Click(sender As Object, e As EventArgs) Handles viewButtonPicture.Click
        userViewPanel.Visible = True
        loginPanel.Visible = False
        userDashBoard.Visible = False
        reviewPanel.Visible = False
    End Sub

    Private Sub viewButtonLabel_Click(sender As Object, e As EventArgs) Handles viewButtonLabel.Click
        userViewPanel.Visible = True
        loginPanel.Visible = False
        userDashBoard.Visible = False
        reviewPanel.Visible = False
    End Sub


    'direct to create
    Private Sub createReviewPanel_Click(sender As Object, e As EventArgs) Handles createReviewPanel.Click
        reviewPanel.Visible = True
        loginPanel.Visible = False
        userDashBoard.Visible = False
        userViewPanel.Visible = False
    End Sub

    Private Sub createReviewPicture_Click(sender As Object, e As EventArgs) Handles createReviewPicture.Click
        reviewPanel.Visible = True
        loginPanel.Visible = False
        userDashBoard.Visible = False
        userViewPanel.Visible = False
    End Sub

    Private Sub createReviewLabel_Click(sender As Object, e As EventArgs) Handles createReviewLabel.Click
        reviewPanel.Visible = True
        loginPanel.Visible = False
        userDashBoard.Visible = False
        userViewPanel.Visible = False
    End Sub

    Private Sub backReviewPage_Click(sender As Object, e As EventArgs) Handles backReviewPage.Click
        userDashBoard.Visible = True
        loginPanel.Visible = False
        reviewPanel.Visible = False
        userViewPanel.Visible = False
    End Sub

    Private Sub backViewPage_Click(sender As Object, e As EventArgs) Handles backViewPage.Click
        userDashBoard.Visible = True
        userViewPanel.Visible = False
        loginPanel.Visible = False
        reviewPanel.Visible = False
    End Sub

    Private Sub LabelLoginRegister_Click(sender As Object, e As EventArgs) Handles LabelLoginRegister.Click
        Dim registrationForm As New registrationForm
        registrationForm.Show()
        Hide()
    End Sub
End Class
