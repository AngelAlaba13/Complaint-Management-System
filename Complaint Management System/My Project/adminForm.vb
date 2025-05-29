Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient

Public Class adminForm
    Private Async Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("B")
        ComboBox1.Items.Add("C")
        ComboBox1.Items.Add("D")
        ComboBox1.Items.Add("E")
        ComboBox1.Items.Add("F")
        ComboBox1.Items.Add("G")
        ComboBox1.Items.Add("H")
        ComboBox1.Items.Add("I")
        Await LoadStudentRecordsAsync()
    End Sub

    Private Sub txtBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSearch.TextChanged
        LoadStudentsRecords()
    End Sub

    Private Sub LoadStudentsRecords()
        Dim searchText As String = txtBoxSearch.Text.Trim()
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE StudentID LIKE @searchText OR " &
                               "YearLevel LIKE @searchText OR " &
                               "Block LIKE @searchText OR " &
                               "ComplaintReceiver LIKE @searchText OR " &
                               "Instructor LIKE @searchText OR " &
                               "ComplaintType LIKE @searchText OR " &
                               "Details LIKE @searchText;"


        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Async Function LoadStudentRecordsAsync() As Task
        Dim searchText As String = txtBoxSearch.Text.Trim()
        DataGridView1.DataSource = Nothing
        Dim query1 As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE StudentID LIKE @searchText OR " &
                               "YearLevel LIKE @searchText OR " &
                               "Block LIKE @searchText OR " &
                               "ComplaintReceiver LIKE @searchText OR " &
                               "Instructor LIKE @searchText OR " &
                               "ComplaintType LIKE @searchText OR " &
                               "Details LIKE @searchText;"

        Using Connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query1, Connection)
                command.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                Try
                    Await Connection.OpenAsync()
                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No record found: ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

    End Function

    Private Sub btnShowFirstYear_Click(sender As Object, e As EventArgs) Handles btnShowFirstYear.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE YearLevel = '1st Year';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowSecondYear_Click(sender As Object, e As EventArgs)
        DataGridView1.DataSource = Nothing
        Dim query = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE YearLevel = '2nd Year';"

        Using connection = GetConnection()

            Using command As New SqlCommand(query, connection)
                Try
                    OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowThirdYear_Click(sender As Object, e As EventArgs)
        DataGridView1.DataSource = Nothing
        Dim query = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE YearLevel = '3rd Year';"

        Using connection = GetConnection()

            Using command As New SqlCommand(query, connection)
                Try
                    OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowFourthYear_Click(sender As Object, e As EventArgs)
        DataGridView1.DataSource = Nothing
        Dim query = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE YearLevel = '4th Year';"

        Using connection = GetConnection()

            Using command As New SqlCommand(query, connection)
                Try
                    OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowInstructors_Click(sender As Object, e As EventArgs) Handles btnShowInstructors.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE ComplaintReceiver = 'to Instructor';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowCollege_Click(sender As Object, e As EventArgs) Handles btnShowCollege.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE ComplaintReceiver = 'to the College';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowOfficers_Click(sender As Object, e As EventArgs) Handles btnShowOfficers.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE ComplaintReceiver = 'to the Officers';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowOthers_Click(sender As Object, e As EventArgs) Handles btnShowOthers.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE ComplaintReceiver = 'Others';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowComplaints_Click(sender As Object, e As EventArgs) Handles btnShowComplaints.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE ComplaintType = 'Complaint';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowFeedbacks_Click(sender As Object, e As EventArgs) Handles btnShowFeedbacks.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE ComplaintType = 'Feedback';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShowSuggestions_Click(sender As Object, e As EventArgs) Handles btnShowSuggestions.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE ComplaintType = 'Suggestion';"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"

                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE Block = @block;"

        Using connection As SqlConnection = DatabaseModule.GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@block", ComboBox1.SelectedItem.ToString())
                Try
                    DatabaseModule.OpenConnection(connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        If dataTable.Rows.Count = 0 Then
                            MessageBox.Show("No records found for the selected block.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        DataGridView1.DataSource = dataTable
                        DataGridView1.Columns("StudentID").HeaderText = "Student ID"
                        DataGridView1.Columns("YearLevel").HeaderText = "Year Level"
                        DataGridView1.Columns("Block").HeaderText = "Block"
                        DataGridView1.Columns("ComplaintReceiver").HeaderText = "Receiver"
                        DataGridView1.Columns("Instructor").HeaderText = "Instructor"
                        DataGridView1.Columns("ComplaintType").HeaderText = "Problem Type"
                        DataGridView1.Columns("Details").HeaderText = "Details"
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    DatabaseModule.CloseConnection(connection)
                End Try
            End Using

        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        ' Show the login form
        Dim loginForm As New Form1()
        loginForm.Show()

        ' Optionally clear any admin session data here

        ' Hide or close the admin form
        Me.Hide()

        MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            If DataGridView1.IsCurrentCellDirty Then DataGridView1.EndEdit()

            DataGridView1.ClearSelection()
            DataGridView1.Rows(e.RowIndex).Selected = True
            DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)

            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim studentID As String = selectedRow.Cells("StudentID").Value.ToString()
            GlobalDataModule.studentId = studentID

            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub deleteToolStrip_Click(sender As Object, e As EventArgs) Handles deleteToolStrip.Click
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow

        If selectedRow IsNot Nothing Then
            Dim studentId As String = GlobalDataModule.studentId
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeleteRecordsFromDatabase()
                LoadStudentsRecords()
            End If
        Else
            MessageBox.Show("Please select a record to delete.")
        End If
    End Sub

    Private Sub DeleteRecordsFromDatabase()
        Dim studentId As String = GlobalDataModule.studentId
        Dim deleteQuery As String = "DELETE FROM masterTable WHERE ID = @ID"

        Try
            Using connection As SqlConnection = DatabaseModule.GetConnection()
                DatabaseModule.OpenConnection(connection)

                Using command As New SqlCommand(deleteQuery, connection)
                    command.Parameters.AddWithValue("@ID", studentId)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record deleted successfully.")
                    Else
                        MessageBox.Show("No record found to delete.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        End Try
    End Sub
End Class