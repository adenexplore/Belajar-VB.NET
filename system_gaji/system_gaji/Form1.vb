Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ngitung As Integer

        ngitung = Me.TextBox1.Text * 15000 + Me.TextBox2.Text * 10000 - (Me.TextBox3.Text * 100000)
        Me.TextBox4.Text = ngitung


        Dim duit_makan As Double

        duit_makan = Me.TextBox1.Text * 10000
        Me.TextBox5.Text = duit_makan
    End Sub
End Class
