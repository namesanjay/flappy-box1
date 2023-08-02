Public Class Form3

    Private Sub Restart_btn_Click(sender As Object, e As EventArgs) Handles Restart_btn.Click
        Me.Hide()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub menu_btn_Click(sender As Object, e As EventArgs) Handles menu_btn.Click
        Me.Hide()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class