Public Class Form1

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
        DrawRcectangle()


    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Me.Text = $"{e.X} {e.Y} Button:{e.Button}"
        DrawLine(0, 0, e.X, e.Y)
    End Sub
End Class
