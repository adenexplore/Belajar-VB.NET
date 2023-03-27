Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim hitung As Double

        hitung = Me.TextBox1.Text / (Me.TextBox2.Text * Me.TextBox2.Text)
        Me.TextBox3.Text = hitung

    End Sub
End Class