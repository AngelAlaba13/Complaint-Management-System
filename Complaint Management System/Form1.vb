Imports Microsoft.Data.SqlClient

Public Class Form1

    Private MyDataApt As New SqlDataAdapter
    Private MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Private Mycn As New SqlConnection
    Private MyRowPosition As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mycn.ConnectionString = "Data Source=DESKTOP-439OE8U\SQLEXPRESS;Initial Catalog=complaintDB;Integrated Security=True;Trust Server Certificate=True"
        Mycn.Open()

        MyDataApt = New SqlDataAdapter("SELECT * FROM masterTable", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDataApt)
        MyDataApt.Fill(MyDataTbl)
        Dim MyDataRow As DataRow = MyDataTbl.Rows(0)

        yearLevelDB.Text = MyDataRow("YearLevel").ToString()
        blockDB.Text = MyDataRow("Block").ToString()

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

End Class
