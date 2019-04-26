Imports System.IO
Partial Public Class Entrance

    Public Name1 As String
    Dim Highscore As String
    Public Mute As Boolean
    Private birdy As Form1

    Private Sub Entrance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Or Keys.Space Then
            MessageBox.Show("Get Ready to Play Flappy Bird, Immediately after you click yes the game will start", "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static int1 As Integer = 0
        Static int2 As Integer = 0
        int1 += 1
        int2 += 1
        If int1 < 20 Then
            pcLogo.Top += 1
            locdog1.Top += 1
        End If
        If int1 > 20 Then
            pcLogo.Top -= 1
            locdog1.Top -= 1
        End If
        If int1 = 40 Then
            int1 = 0
            pcLogo.Location = New Point(29, 31)
            locdog1.Location = New Point(235, 59)
        End If
        Select Case int2
            Case 5
                locdog1.Image = My.Resources.Capture
              '  Me.Icon = My.Resources.FlappyICON
            Case 10
                locdog1.Image = My.Resources.Capture
               ' Me.Icon = My.Resources.favicon
            Case 15
                int2 = 0
        End Select
    End Sub

    'Private Sub Entrance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'My.Computer.Audio.Play(My.Resources.FlappyBird_ThemeSong, AudioPlayMode.BackgroundLoop)
    'Name1 = InputBox("Please Enter a username!", "Username!")
    'End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Get Ready to Play Flappy Bird, Immediately after you click yes the game will start", "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub OnToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem2.Click
        My.Computer.Audio.Play(My.Resources.GTA, AudioPlayMode.Background)
    End Sub

    Private Sub OffToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OffToolStripMenuItem2.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub CreditsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem1.Click
        MessageBox.Show("Creator : Saahil Afaq ")
    End Sub

    Private Sub ShareToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShareToolStripMenuItem1.Click
        MessageBox.Show("Break Yo'Self FOOL!!")
    End Sub

    Private Sub StartToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem1.Click
        MessageBox.Show("Get Ready to Play Flappy Bird, Immediately after you click yes the game will start", "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show("Break Yo'Self FOOL!!")
    End Sub
End Class