Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.BackColor = Color.Red
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnObjectDemo_Click(sender As Object, e As EventArgs) Handles btnObjectDemo.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
