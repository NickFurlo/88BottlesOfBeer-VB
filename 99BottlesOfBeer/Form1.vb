Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        BottlesSong()

    End Sub

    Private Sub BottlesSong()
        Dim count As Integer = 99
        While count > 0
            RichTextBox1.AppendText(count.ToString + " bottles	of bee on the wall, " + count.ToString + " bottles of beer
take one down, pass it around, " + (count - 1).ToString + " bottles	of beer	on the wall." + vbNewLine)
            count -= 1
        End While

    End Sub


End Class
