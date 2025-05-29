Imports Microsoft.Data.SqlClient

Partial Class registrationForm

    Dim getStudentID = GlobalDataModule.studentId
    'Inherits System.Windows.Forms.Form

    Private Sub registrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRegisterYear.Items.Add("1st Year")
        txtRegisterYear.Items.Add("2nd Year")
        txtRegisterYear.Items.Add("3rd Year")
        txtRegisterYear.Items.Add("4th Year")

        txtRegisterPass.PasswordChar = "*"c


        Me.btnRegisterConfirm.Text = "&Save"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegisterCancel.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()

    End Sub

    Private Sub btnRegisterConfirm_Click(sender As Object, e As EventArgs) Handles btnRegisterConfirm.Click
        'Try

        '    ' Load data from the userTable into the DataTable
        '    Dim query As String = "SELECT * FROM userTable"
        '    Dim adapter As New SqlDataAdapter(query, Form1.Mycn)
        '    Dim builder As New SqlCommandBuilder(adapter)

        '    Dim MyDataTbl As New DataTable()
        '    adapter.Fill(MyDataTbl)

        '    ' Create a new row
        '    Dim newRow As DataRow = MyDataTbl.NewRow()
        '    newRow("StudentID") = txtRegisterID.Text
        '    newRow("Name") = txtRegisterName.Text
        '    newRow("YearLevel") = txtRegisterYear.Text
        '    newRow("Block") = txtRegisterBlock.Text
        '    newRow("Password") = txtRegisterPass.Text
        '    newRow("Role") = "student"

        '    ' Add the new row to the DataTable
        '    MyDataTbl.Rows.Add(newRow)

        '    ' Push changes to the database
        '    adapter.Update(MyDataTbl)

        '    MessageBox.Show("Registration successful!")
        '    Me.Hide()
        '    Form1.Show()
        '    Form1.Focus()

        'Catch ex As Exception
        '    MessageBox.Show("Error: " & ex.Message)
        'End Try

        Dim insertQuery As String = "INSERT INTO userTable(StudentID, Name, YearLevel, Block, Role, Password) " &
                                "VALUES (@StudentID, @Name, @YearLevel, @Block, @Role, @Password)"
        Try
            Using connection As SqlConnection = DatabaseModule.GetConnection()
                Using command As New SqlCommand(insertQuery, connection)
                    'command.Parameters.AddWithValue("@faculty_id", getItemID)
                    command.Parameters.AddWithValue("@StudentID", txtRegisterID.Text)
                    command.Parameters.AddWithValue("@Name", txtRegisterName.Text)
                    command.Parameters.AddWithValue("@YearLevel", txtRegisterYear.Text)
                    command.Parameters.AddWithValue("@Block", txtRegisterBlock.Text)
                    command.Parameters.AddWithValue("@Role", "student")
                    command.Parameters.AddWithValue("@Password", txtRegisterPass.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using

            End Using
            MessageBox.Show("Registration successful!")
            Me.Hide()
            Form1.Show()
            Form1.Focus()
        Catch ex As Exception
            MessageBox.Show("Error registration: " & ex.Message)
        End Try


    End Sub
End Class