Public Class p1contoh1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = TextBox1.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox2.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox2.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox2.ForeColor = Color.Green
    End Sub
End Class