Public Class Form1


    Private Sub hrd_Click(sender As Object, e As EventArgs) Handles hrd.Click
        Module1.hard_store()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub mid_Click(sender As Object, e As EventArgs) Handles mid.Click
        Module1.mid_store()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub esy_Click(sender As Object, e As EventArgs) Handles esy.Click
        Module1.easy_store()
        Me.Hide()
        Form2.Show()
    End Sub
End Class
