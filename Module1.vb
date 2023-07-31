Module Module1
    Public velocity, gravity, pipeVelocity, pipeVerticalGap, pipeWidth, pipeHorizontalGap, velocity_interval, loop_interval, b_width, b_height As Single
    Public Sub hard_store()
        velocity = -0.9
        gravity = 3.2
        pipeVelocity = 6.5
        pipeVerticalGap = 170
        b_height = 53
        b_width = 52
        loop_interval = 90
        velocity_interval = -22.5
    End Sub
    Public Sub mid_store()
        velocity = -0.9
        gravity = 3.1
        pipeVelocity = 7
        pipeVerticalGap = 180
        velocity_interval = -22
        b_height = 49
        b_width = 48
        loop_interval = 90
        velocity_interval = -21
    End Sub
    Public Sub easy_store()
        velocity = -0.9
        gravity = 2.9
        pipeVelocity = 5
        pipeVerticalGap = 20
        velocity_interval = -20
        loop_interval = 140
        b_height = 48
        b_width = 47
    End Sub
End Module
