Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module DatabaseModule
    Private connectionString As String = "Data Source=DESKTOP-439OE8U\SQLEXPRESS;Initial Catalog=complaintDB;Integrated Security=True;Trust Server Certificate=True"
    'karl-connection
    'Private connectionString As String = "Data Source=LAPTOP-O85KOUQB\SQLEXPRESS;Initial Catalog=complaintDB;Integrated Security=True;Trust Server Certificate=True"

    ' Get a new SqlConnection instance
    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    ' Open connection 
    Public Sub OpenConnection(conn As SqlConnection)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Close connection
    Public Sub CloseConnection(conn As SqlConnection)
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub

    Public Function ExecuteQuery(query As String) As SqlDataReader
        Dim connection As SqlConnection = GetConnection()
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        Return command.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

End Module
