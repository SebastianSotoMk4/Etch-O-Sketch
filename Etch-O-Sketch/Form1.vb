Public Class Form1
    'Stores (x,y) coordinates
    Dim x As Integer
    Dim y As Integer
    Dim penColor As Color = Color.Black
    Dim backGroundColor As Color = Color.LightBlue
    Public Sub DrawString()
        Dim drawSting As String = "sameple Text"
        Dim x As Single = 150.0
        Dim y As Single = 50

        Dim g As Graphics = PictureBox1.CreateGraphics
        Dim drawFont As New Font("Arial", 16)
        Dim drawBtush As New SolidBrush(Color.Black)
        Dim drawFormat As New StringFormat

    End Sub

    Sub DrawCircle()
        Dim g As Graphics = PictureBox1.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(225, 0, 0, 0))
        g.DrawEllipse(pen, 20, 20, 100, 100)
        pen.Dispose()
        g.Dispose()

    End Sub

    Sub DrawRcectangle()
        Dim g As Graphics = PictureBox1.CreateGraphics
        Dim aBrush As SolidBrush = New SolidBrush(Color.Blue)
        g.FillRectangle(aBrush, 20, 20, 100, 100)
        aBrush.Dispose()
        g.Dispose()
    End Sub

    Sub DrawLine()
        'Constructor for an instace of graphics called g
        Dim g As Graphics = PictureBox1.CreateGraphics

        'Constructor for an instance of pen object to use with the graphics object

        Dim pen As New Pen(Color.FromArgb(225, 0, 0, 0))
        '0, 0 and 150 , 50  are begining and end points of the line
        g.DrawLine(pen, 0, 0, 150, 50)
        'always dispose when done, it takes up alot of ram
        pen.Dispose()
        g.Dispose()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'DrawLine()
        'DrawCircle()
        'DrawRcectangle()

    End Sub

    Sub DrawLine(ByVal startX As Integer, ByVal startY As Integer, ByVal dynamicX As Integer, ByVal dynamicY As Integer)
        Dim g As Graphics = PictureBox1.CreateGraphics
        Dim pen As New Pen(Me.penColor)

        g.DrawLine(pen, startX, startY, dynamicX, dynamicY)
        pen.Dispose()
        g.Dispose()

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        'DrawLine(0, 0, e.X, e.Y)
        'DrawLine(e.X, e.Y, e.X, e.Y)
        If e.Button.ToString = "Left" Then
            DrawLine(Me.x, Me.y, e.X, e.Y)
        End If
        Me.x = e.X
        Me.y = e.Y
        Me.Text = $"{e.X} {e.Y} Button:{e.Button}"
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) 'Handles PictureBox1.MouseDown
        Static oldX As Integer
        Static oldY As Integer

        If e.Button.ToString = "Right" Then

            ColorDialog.ShowDialog()
            Me.penColor = ColorDialog.Color

        ElseIf e.Button.ToString = "Middle" Then
            Clear()

        End If
    End Sub
    Sub Clear()
        PictureBox1.BackColor = Color.LightBlue
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Me.backGroundColor)
        g.Dispose()
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
        ShakeMe()
    End Sub

    Private Sub PenColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenColorToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        Me.penColor = ColorDialog.Color
    End Sub

    Sub ShakeMe()
        Dim original = Location
        Dim offset As Integer = 10

        'My.Computer.Audio.Play(My.Resources.Shaker, AudioPlayMode.Background)

        For i = 0 To 10
            offset *= -1
            Me.Top += offset
            Me.Left += offset
            System.Threading.Thread.Sleep(100)
        Next
        Location = original


    End Sub
    Public Sub Shake()
        Dim original = Location
        Dim rnd = New Random(1337)
        Const shake_amplitude As Integer = 10
        For i As Integer = 0 To 9
            Location = New Point(original.X + rnd.[Next](-shake_amplitude, shake_amplitude), original.Y + rnd.[Next](-shake_amplitude, shake_amplitude))
            System.Threading.Thread.Sleep(20)
        Next
        Location = original

    End Sub
End Class
'https://docs.google.com/document/d/1VtPGln_UJFIVC9V-YtjGkQpsvjmT8OCodmGTqBEf1os/edit