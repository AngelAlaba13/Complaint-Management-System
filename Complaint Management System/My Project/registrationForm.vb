Public Class registrationForm
    Private Sub registrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()

    End Sub
End Class