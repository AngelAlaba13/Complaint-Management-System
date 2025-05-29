Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient

Public Class adminForm
    Private Async Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnShowSecondYear_Click(sender As Object, e As EventArgs) Handles btnShowSecondYear.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE YearLevel = '2nd Year';"

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

    Private Sub btnShowThirdYear_Click(sender As Object, e As EventArgs) Handles btnShowThirdYear.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE YearLevel = '3rd Year';"

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

    Private Sub btnShowFourthYear_Click(sender As Object, e As EventArgs) Handles btnShowFourthYear.Click
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT StudentID, YearLevel, Block, ComplaintReceiver, Instructor, ComplaintType, Details " &
                               "FROM masterTable " &
                               "WHERE YearLevel = '4th Year';"

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
End Class