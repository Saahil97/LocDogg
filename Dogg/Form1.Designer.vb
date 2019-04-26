<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ground = New System.Windows.Forms.PictureBox()
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'ground
        '
        Me.ground.BackColor = System.Drawing.Color.SaddleBrown
        Me.ground.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ground.Location = New System.Drawing.Point(0, 349)
        Me.ground.Name = "ground"
        Me.ground.Size = New System.Drawing.Size(474, 17)
        Me.ground.TabIndex = 1
        Me.ground.TabStop = False
        '
        'bird
        '
        Me.bird.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.bird.BackColor = System.Drawing.Color.DarkOrange
        Me.bird.Image = Global.WindowsApp1.My.Resources.Resources.Capture
        Me.bird.Location = New System.Drawing.Point(151, 26)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(42, 42)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird.TabIndex = 0
        Me.bird.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Pause
        Me.PictureBox1.Location = New System.Drawing.Point(437, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Background1
        Me.ClientSize = New System.Drawing.Size(474, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ground)
        Me.Controls.Add(Me.bird)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ground As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
