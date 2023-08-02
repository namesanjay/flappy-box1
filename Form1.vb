Imports System.Data.SqlClient
Public Class Form1


    Private Sub hrd_Click(sender As Object, e As EventArgs) Handles hrd.Click
        Module1.hard_store()
        Me.Hide()
        Form2.Show()
        DGV.Refresh()
    End Sub

    Private Sub mid_Click(sender As Object, e As EventArgs) Handles mid.Click
        Module1.mid_store()
        Me.Hide()
        Form2.Show()
        DGV.Refresh()
    End Sub

    Private Sub esy_Click(sender As Object, e As EventArgs) Handles esy.Click
        Module1.easy_store()
        Me.Hide()
        Form2.Show()
        DGV.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FU1FP10\SQLEXPRESS;Initial Catalog=flappy;Integrated Security=True;TrustServerCertificate=True")
        con.Open()
        Dim cmd As SqlCommand
        Dim sda As SqlDataAdapter = New SqlDataAdapter
        Dim query As String = "Select easy,mid,hard from info where id=1"
        cmd = New SqlCommand(query, con)
        Dim dt As DataTable = New DataTable
        sda.SelectCommand = cmd
        sda.Fill(dt)
        DGV.DataSource = dt
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming you want to remove the first row (index 0) from the DataGridView
        If DGV.Rows.Count > 0 Then
            DGV.Rows.RemoveAt(0)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
