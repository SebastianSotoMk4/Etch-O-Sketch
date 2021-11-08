'Sebastian Soto
'RCET0265
'Fall 2021
'Etch o Sketch
'https://github.com/SebastianSotoMk4/Etch-O-Sketch.git
Option Strict On
Option Explicit On
Public Class EtchASketchForm
    'Stores (x,y) coordinates
    Dim x As Integer
    Dim y As Integer
    'Stores Color for the pen and back grouond
    Dim penColor As Color = Color.Black
    Dim backGroundColor As Color = Color.LightGray


    'The DrawLine Sub is used for the LeftClick to draw function
    Sub DrawLine(ByVal startX As Integer, ByVal startY As Integer, ByVal dynamicX As Integer, ByVal dynamicY As Integer)
        Dim g As Graphics = PictureBox1.CreateGraphics
        Dim pen As New Pen(Me.penColor)

        g.DrawLine(pen, startX, startY, dynamicX, dynamicY)
        pen.Dispose()
        g.Dispose()
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button.ToString = "Left" Then
            DrawLine(Me.x, Me.y, e.X, e.Y)
        End If
        Me.x = e.X
        Me.y = e.Y
        Me.Text = $"{e.X} {e.Y} Button:{e.Button}"
    End Sub


    'This Sub handles the mouse middle click, when clicked calls the pen color select.
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button.ToString = "Middle" Then
            PenColorSelect()
        End If
    End Sub


    'Clear Sub handels clearing the picture box and calls the shake sub 
    Sub Clear()
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Me.backGroundColor)
        g.Dispose()
        Shake()
    End Sub
    'This Sub Clears the picture box when the clear is clicked
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()
    End Sub
    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        Clear()
    End Sub

    'Shakes the window when called.
    Sub Shake()
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


    'This Sub draws the graticules 
    Sub DrawDivisions()
        Dim xmid As Integer = PictureBox1.Width \ 2
        Dim ymid As Integer = PictureBox1.Height \ 2
        Dim xLast As Integer = xmid
        Dim yLast As Integer = ymid
        Dim offset As Integer = 100

        Dim xOffset As Integer = CInt(100 * Math.Cos((Math.PI / 180) * 135))
        Dim yOffset As Integer = CInt(100 * Math.Cos((Math.PI / 180) * 135))


        'PictureBox1.
        'DrawLine(0, 0, PictureBox1.Width, PictureBox1.Height)
        'DrawLine(xmid, ymid, xmid + xOffset, ymid + yOffset)
        'DrawLine(0, ymid, PictureBox1.Width, ymid)
        'DrawLine(xmid, 0, xmid, PictureBox1.Height)
        For i = 0 To PictureBox1.Height Step PictureBox1.Height \ 8
            DrawLine(0, i, PictureBox1.Width, i)

        Next
        For i = 0 To PictureBox1.Width Step PictureBox1.Width \ 10
            DrawLine(i, 0, i, PictureBox1.Height)

        Next
    End Sub
    Sub DrawSine()
        Dim x As Double
        Dim y As Double
        Me.penColor = Color.Purple
        For b As Double = 0 To PictureBox1.Width
            y = (Math.Sin(b / 250 * 2 * Math.PI) * 100 + 100) + 30
            x = b
            DrawLine(CInt(x), CInt(y), CInt(x + 1), CInt(y))
        Next
        Me.penColor = Color.Black
    End Sub
    Sub DrawCosine()
        Dim x As Double
        Dim y As Double
        Me.penColor = Color.Green
        For q As Double = 0 To PictureBox1.Width
            y = (Math.Cos(q / 250 * 2 * Math.PI) * 100 + 100) + (PictureBox1.Height / 3)
            x = q
            DrawLine(CInt(x), CInt(y), CInt(x + 1), CInt(y))
        Next
        Me.penColor = Color.Black
    End Sub
    Sub DrawTan()
        Dim x As Double
        Dim y As Double
        Me.penColor = Color.Red
        For u As Double = 0 To PictureBox1.Width
            y = (Math.Tan(u / 250 * 2 * Math.PI) * 50 + 50) + (PictureBox1.Height - (PictureBox1.Height / 3))

            x = u
            DrawLine(CInt(x), CInt(y), CInt(x + 1), CInt(y))
        Next
        Me.penColor = Color.Black
    End Sub
    Private Sub DrawWaveFormButton_Click(sender As Object, e As EventArgs) Handles DrawWaveFormButton.Click
        Clear()
        DrawDivisions()
        DrawSine()
        DrawCosine()
        DrawTan()
    End Sub
    Private Sub DrawWaveFormsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveFormsToolStripMenuItem.Click
        Clear()
        DrawDivisions()
        DrawSine()
        DrawCosine()
        DrawTan()
    End Sub


    'These subs close the program when the either exit button is called
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub




    'Changes Pen pen color
    Sub PenColorSelect()
        ColorDialog.ShowDialog()
        Me.penColor = ColorDialog.Color
    End Sub
    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        PenColorSelect()
    End Sub
    Private Sub PenColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenColorToolStripMenuItem.Click
        PenColorSelect()
    End Sub
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        PenColorSelect()
    End Sub


    'Changes BackGround Color
    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        Dim g As Graphics = PictureBox1.CreateGraphics
        ColorDialog.ShowDialog()
        Me.backGroundColor = ColorDialog.Color
        g.Clear(Me.backGroundColor)
    End Sub


    'opens a message Box when the about button is clicked
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox($"Made By: Sebastian Soto{vbNewLine}Semester: Fall 2021")
    End Sub
End Class
