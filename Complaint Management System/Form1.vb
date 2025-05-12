Imports Microsoft.Data.SqlClient

Public Class Form1

    Private MyDataApt As New SqlDataAdapter
    Private MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Private Mycn As New SqlConnection
    Private MyRowPosition As Integer = 0
    Private currentUserID As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mycn.ConnectionString = "Data Source=DESKTOP-439OE8U\SQLEXPRESS;Initial Catalog=complaintDB;Integrated Security=True;Trust Server Certificate=True"
        Mycn.Open()

        MyDataApt = New SqlDataAdapter("SELECT * FROM masterTable", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDataApt)
        MyDataApt.Fill(MyDataTbl)

        With MyDataTbl.Columns("ID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
        End With

        Dim MyDataRow As DataRow = MyDataTbl.Rows(0)

        yearLevelDB.Text = MyDataRow("YearLevel").ToString()
        blockDB.Text = MyDataRow("Block").ToString()


        txtTarget.Items.Add("to Instructor")
        txtTarget.Items.Add("to the College")
        txtTarget.Items.Add("to the Officers")
        txtTarget.Items.Add("Others")

        txtComplaint.Items.Add("Complaint")
        txtComplaint.Items.Add("Feedback")
        txtComplaint.Items.Add("Suggestion")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim registrationForm As New registrationForm
        registrationForm.Show()
        Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginPanel.Visible = False
        reviewPanel.Visible = True
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

            Dim MyNewRow As DataRow = MyDataTbl.NewRow()
            MyDataTbl.Rows.Add(MyNewRow)
            MyRowPosition = MyDataTbl.Rows.Count - 1

            MyDataTbl.Rows(MyRowPosition)("StudentID") = txtStudentID.Text
            MyDataTbl.Rows(MyRowPosition)("YearLevel") = txtYearLvl.Text
            MyDataTbl.Rows(MyRowPosition)("Block") = txtBlock.Text
            MyDataTbl.Rows(MyRowPosition)("ComplaintReceiver") = txtTarget.Text
            MyDataTbl.Rows(MyRowPosition)("ComplaintType") = txtComplaint.Text
            MyDataTbl.Rows(MyRowPosition)("Details") = txtContent.Text

            MyDataApt.Update(MyDataTbl)

            txtStudentID.Clear()
            txtYearLvl.Clear()
            txtBlock.Clear()
            txtTarget.SelectedIndex = -1
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
                        .Height = 120,
                        .BackColor = Color.White,
                    .BorderStyle = BorderStyle.FixedSingle,
                    .Margin = New Padding(5)
                    }

                    Dim lblComplaintReceiver As New Label With {
                        .Text = reader("ComplaintReceiver").ToString(),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, 10),
                        .AutoSize = True
                        }

                    Dim lblComplaintType As New Label With {
                    .Text = reader("ComplaintType").ToString(),
                    .ForeColor = Color.Gray,
                    .Location = New Point(10, 35),
                    .AutoSize = True
                }


                    Dim lblDetails As New Label With {
                        .Text = reader("Details").ToString(),
                        .Font = New Font("Segoe UI", 10),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, 60),
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
End Class
