Imports Microsoft.Data.SqlClient

Partial Class registrationForm
    Inherits System.Windows.Forms.Form

    Private Sub registrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRegisterYear.Items.Add("1st Year")
        txtRegisterYear.Items.Add("2nd Year")
        txtRegisterYear.Items.Add("3rd Year")
        txtRegisterYear.Items.Add("4th Year")

        txtRegisterPass.PasswordChar = "*"c

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegisterCancel.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()

    End Sub

    Private Sub btnRegisterConfirm_Click(sender As Object, e As EventArgs) Handles btnRegisterConfirm.Click
        Try

            ' Load data from the userTable into the DataTable
            Dim query As String = "SELECT * FROM userTable"
            Dim adapter As New SqlDataAdapter(query, Form1.Mycn)
            Dim builder As New SqlCommandBuilder(adapter)

            Dim MyDataTbl As New DataTable()
            adapter.Fill(MyDataTbl)

            ' Create a new row
            Dim newRow As DataRow = MyDataTbl.NewRow()
            newRow("StudentID") = txtRegisterID.Text
            newRow("Name") = txtRegisterName.Text
            newRow("YearLevel") = txtRegisterYear.Text
            newRow("Block") = txtRegisterBlock.Text
            newRow("Password") = txtRegisterPass.Text
            newRow("Role") = "student"

            ' Add the new row to the DataTable
            MyDataTbl.Rows.Add(newRow)

            ' Push changes to the database
            adapter.Update(MyDataTbl)

            MessageBox.Show("Registration successful!")
            Me.Hide()
            Form1.Show()
            Form1.Focus()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub
End Class