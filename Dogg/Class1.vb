Imports System.IO
Public Class Entrance
    Public Name1 As String
    Dim Highscore As String
    Public Mute As Boolean

    Private Sub Entrance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Get Ready to Play Flappy Bird, Immediately after you click yes the game will start", "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static int1 As Integer = 0
        Static int2 As Integer = 0
        int1 += 1
        int2 += 1
        If int1 < 20 Then
            pcLogo.Top += 1
            .Top += 1
        End If
        If int1 > 20 Then
            pcLogo.Top -= 1
            pcBird.Top -= 1
        End If
        If int1 = 40 Then
            int1 = 0
            pcLogo.Location = New Point(29, 31)
            pcBird.Location = New Point(235, 59)
        End If
        Select Case int2
            Case 5
                pcBird.Image = My.Resources.tumblr_n0dw9jUXOD1s6294bo1_r2_5001
                Me.Icon = My.Resources.FlappyICON
            Case 10
                pcBird.Image = My.Resources.Flappy_Bird_FlapII
                Me.Icon = My.Resources.favicon
            Case 15
                int2 = 0
        End Select
    End Sub

    'Private Sub Entrance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'My.Computer.Audio.Play(My.Resources.FlappyBird_ThemeSong, AudioPlayMode.BackgroundLoop)
    'Name1 = InputBox("Please Enter a username!", "Username!")
    'End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Get Ready to Play Flappy Bird, Immediately after you click yes the game will start", "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Computer.Audio.Stop()
        frmFlappyBird.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MessageBox.Show("Please Take Time to Enter your Comments!", "Share")
        My.Settings.Comments.Add(InputBox("Please Enter your name with a comment", "Comment"))
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        MessageBox.Show("Creator : Pradeep Kumar ")
    End Sub

    Private Sub FlappyBirdThemeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.FlappyBird_ThemeSong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub MuteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuteToolStripMenuItem.Click
        My.Computer.Audio.Stop()
    End Sub
End Class