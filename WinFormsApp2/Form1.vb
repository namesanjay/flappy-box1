Imports System.Formats.Asn1.AsnWriter
Imports System.Windows.Forms
Public Class Form1
    Private gameLoop As Timer
    Private velocity As Single = -0.9
    Private gravity As Single = 2.9
    Private hasCollided As Boolean = False
    Private pipeVelocity As Double = 5
    Private Const pipeVerticalGap As Integer = 200
    Private Const pipeWidth As Integer = 50
    Private Const pipeHorizontalGap As Integer = 200
    Private pipes As New List(Of Pipe)()
    Private score As Integer = 0

    Private Class Pipe
        Public Property TopPipe As PipeSegment
        Public Property BottomPipe As PipeSegment
    End Class
    Private Class PipeSegment
        Public Property Top As Single
        Public Property Left As Single
        Public Property Width As Single
        Public Property Height As Single
    End Class

    Public Sub New()
        InitializeComponent()
        gameLoop = New Timer()
        gameLoop.Interval = 150
        AddHandler gameLoop.Tick, AddressOf GameLoopCallback
        gameLoop.Start()
    End Sub

    Private Sub GameLoopCallback(sender As Object, e As EventArgs)
        bird.BackColor = Color.Green
        If hasCollided Then
            gameLoop.Dispose()
            bird.BackColor = Color.Purple
            MessageBox.Show("GAME OVER")
            ResetGame()
            Return
        End If
        velocity += gravity
        bird.Top += velocity
        If bird.Top < 0 Then
            bird.Top = 0
            velocity = 0
        ElseIf bird.Top > Me.Height - bird.Height Then
            bird.Top = Me.Height - bird.Height
            velocity = 0
        End If
        'For Each pipe In pipes
        For i As Integer = 0 To pipes.Count - 1
            Dim Pip As Pipe = pipes(i)
            Pip.TopPipe.Left -= pipeVelocity
            Pip.BottomPipe.Left -= pipeVelocity
            If Pip.TopPipe.Left < 0 Then
                pipes.RemoveAt(0)
                pipes.Add(GiveMePipe())
                If Not hasCollided Then
                    score += 1
                    Scr.Text = "Score : " & score
                End If
            End If
            CheckCollision(Pip.TopPipe, bird)
            CheckCollision(Pip.BottomPipe, bird)
        Next
        Me.Invalidate()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
        For i As Integer = 0 To 12
            pipes.Add(GiveMePipe())
        Next
    End Sub

    Private Function GiveMePipe() As Pipe
        Dim topPipeHeight As Integer = GiveMeRandomHeight(20, Me.Height - pipeVerticalGap)
        Dim leftOffset As Integer = 100 + 300
        If pipes.Count > 0 Then
            Dim lastPipe As Pipe = pipes(pipes.Count - 1)
            leftOffset = lastPipe.TopPipe.Left + pipeHorizontalGap
        End If
        Dim pipe As New Pipe()
        pipe.TopPipe = New PipeSegment With {
        .Top = 0,
        .Left = leftOffset,
        .Width = pipeWidth,
        .Height = topPipeHeight
        }
        pipe.BottomPipe = New PipeSegment With {
        .Top = topPipeHeight + pipeVerticalGap,
        .Left = leftOffset,
        .Width = pipeWidth,
        .Height = Me.Height - topPipeHeight - pipeVerticalGap
         }
        Return pipe
    End Function

    Private Sub CheckCollision(box1 As PipeSegment, bird As PictureBox)
        If box1.Left < bird.Left + bird.Width AndAlso
        box1.Left + box1.Width > bird.Left AndAlso
        box1.Top < bird.Top + bird.Height AndAlso
        box1.Top + box1.Height > bird.Top Then
            hasCollided = True
        End If
    End Sub

    Private Function GiveMeRandomHeight(min As Integer, max As Integer) As Integer
        Dim rnd As New Random()
        Return rnd.Next(min, max + 1)
    End Function


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        For Each pipe In pipes
            g.FillRectangle(Brushes.Green, pipe.TopPipe.Left,
            pipe.TopPipe.Top, pipe.TopPipe.Width, pipe.TopPipe.Height)
            g.FillRectangle(Brushes.Green, pipe.BottomPipe.Left,
            pipe.BottomPipe.Top, pipe.BottomPipe.Width, pipe.BottomPipe.Height)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        velocity += gravity
        bird.Top += velocity
        'mathi jana nadina
        If bird.Top < 0 Then
            bird.Top = 0
            velocity = 0
        End If
        'Tala jana nadina
        If (bird.Top > Me.Height - 2 * bird.Height) Then
            bird.Top = Me.Height - 2 * bird.Height
            velocity = 0
            'Timer1.Enabled = True
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            velocity = -20
        End If
    End Sub
    Private Sub ResetGame()
        bird.Top = Me.Height \ 2
        hasCollided = False
        Scr.Text = "Score : 0"
        velocity = 0
        pipes.Clear()
        For i As Integer = 0 To 12
            pipes.Add(GiveMePipe())
        Next
        gameLoop.Start()
    End Sub

End Class
