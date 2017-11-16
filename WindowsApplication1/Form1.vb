Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles B6.Click


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles B8.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub RectangleShape1_Click(sender As System.Object, e As System.EventArgs) Handles point.Click
        Randomize()
        Dim ypoint As Integer = Int((Rnd() * 251) + 40)
        Dim xpoint As Integer = Int((Rnd() * 397) + 68)
     
        point.Location = New Point(xpoint, ypoint)
        Label1.Text = xpoint & " " & ypoint








    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
