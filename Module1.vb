Imports Microsoft.Data.SqlClient
Module Module1
    Public velocity, gravity, pipeVelocity, pipeVerticalGap, pipeWidth, pipeHorizontalGap, velocity_interval, loop_interval, b_width, b_height As Single
    Public level, high_score As Integer
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FU1FP10\SQLEXPRESS;Initial Catalog=flappy;Integrated Security=True;TrustServerCertificate=True")
    Public Sub hard_store()
        con.Open()
        Dim query1 As String = "select hard from info where id=1"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query1, con)
        high_score = cmd.ExecuteScalar()
        con.Close()
        velocity = -0.9
        gravity = 3.2
        pipeVelocity = 6.5
        pipeVerticalGap = 170
        b_height = 53
        b_width = 52
        loop_interval = 90
        velocity_interval = 22.5
        level = 3
        '  MsgBox(high_score)
    End Sub
    Public Sub mid_store()
        con.Open()
        Dim query1 As String = "select mid from info where id=1"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query1, con)
        high_score = cmd.ExecuteScalar()
        con.Close()
        velocity = -0.9
        gravity = 3.1
        pipeVelocity = 7
        pipeVerticalGap = 180
        velocity_interval = -22
        b_height = 49
        b_width = 48
        loop_interval = 90
        velocity_interval = 21
        level = 2
        ' MsgBox(high_score)
    End Sub
    Public Sub easy_store()
        con.Open()
        Dim query1 As String = "select easy from info where id=1"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query1, con)
        high_score = cmd.ExecuteScalar()
        con.Close()
        velocity = -0.9
        gravity = 2.9
        pipeVelocity = 5
        pipeVerticalGap = 200
        velocity_interval = 20
        loop_interval = 140
        b_height = 48
        b_width = 47
        level = 1
        ' MsgBox(high_score)
    End Sub
End Module
