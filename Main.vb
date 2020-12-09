Public Class fuzzyColor

    Dim color_table As New Color() { Color.Black, Color.Red, Color.White, Color.Green, Color.Brown, Color.Blue, Color.Yellow, Color.DarkBlue, Color.Cyan, Color.Gray }

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim y As Integer = 0
        Dim x As Integer = 0
        Dim z As Integer = Convert.ToInt32(TextBox1.Text) + 1
        Dim v As Integer = Convert.ToInt32(TextBox2.Text) + 1
        Dim Img As New Bitmap(v, z)

        If Not TextBox1.Text Is "" Or TextBox2.Text Is "" Or TextBox1.Text Is "0" Or TextBox2.Text Is "0" Then
            Do

                Img.SetPixel(x, y, color_table(CInt(Int((9 * Rnd())))))
                y = y + 1
                If y = Convert.ToInt32(TextBox1.Text) And x < Convert.ToInt32(TextBox2.Text) Then
                    y = 0
                    x = x + 1
                End If
            Loop Until y = Convert.ToInt32(TextBox1.Text)
            Img.SetPixel(0, 0, Colo(0))
            Img.Save("fuzzyColor.JPG", Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub fuzzyColor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
