Public Class Form1
    Dim yspeed As Integer = 0
    Dim gravity As Integer = 5
    'Public bird As PictureBox
    Dim pipe(1) As PictureBox
    Dim Pause As Boolean = True
    Dim topPipe(1) As PictureBox
    Public Score As Double
    'Dim scorez As Integer = CInt(a1)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Enabled = True
        CreatePipes(1)
        CreateTopPipes(1)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        yspeed += gravity
        bird.Top += yspeed
        Score += 0.0084
        If Score = 1 Then
            My.Computer.Audio.Play(My.Resources.thisissomegood, AudioPlayMode.Background)
        End If

        Dim scorez As Integer = CInt(Score)

        Me.Text = "loc Bird" & "    " & Str(scorez)
        For i = 0 To 1
            pipe(i).Left -= 2
            topPipe(i).Left -= 2


            'If Game(pipe(i), bird) = True Or Game(topPipe(i), bird) Then
            'score = score + 1
            'End If

            If Collision(pipe(i), bird) = True Or Collision(topPipe(i), bird) Or Collision(ground, bird) Then
                Timer1.Stop()
                MessageBox.Show("Score is :" & scorez)
                Application.Restart()
                Entrance.Show()

            End If
            If pipe(i).Left < 0 Then
                pipe(i).Left += 400
                topPipe(i).Left += 400
                pipe(i).Top = 60 + 230 * Rnd()
                topPipe(i).Top = pipe(i).Top - 450
            End If
        Next

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            yspeed = -15
        End If
        If e.KeyCode = Keys.P Then
            PauseAndPlay()
        End If
    End Sub

    Private Sub CreatePipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.FixedSingle
            temp.BackColor = Color.DarkSeaGreen
            temp.Top = 60 + 230 * Rnd()
            temp.Left = (i * 200) + 100
            pipe(i) = temp
            pipe(i).Visible = True
        Next
    End Sub

    Private Sub CreateTopPipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.FixedSingle
            temp.BackColor = Color.DarkSeaGreen
            temp.Top = pipe(i).Top - 450
            temp.Left = (i * 200) + 100
            topPipe(i) = temp
            topPipe(i).Visible = True
        Next
    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
            Object2.Top + Object2.Height >= Object1.Top And
            Object1.Left + Object1.Width >= Object2.Left And
            Object2.Left + Object2.Width >= Object1.Left And Object1.visible = True And Object2.visible = True Then
            collided = True
        End If
        Return collided
    End Function

    Sub PauseAndPlay()
        Try
            If Pause = True Then
                PictureBox1.Image = My.Resources.Play
                Timer1.Stop()
                Pause = False
                Exit Try
            ElseIf Pause = False Then
                PictureBox1.Image = My.Resources.Pause
                Timer1.Start()
                Pause = True
                Exit Try
            End If
        Catch ex As Exception
        End Try
        'Me.Text = "loc Bird" & "    " & Str()
    End Sub

End Class