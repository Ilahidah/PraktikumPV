Public Class p3contoh1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nilai As Double = CDbl(TextBox2.Text)
        If (nilai >= 80) Then
            TextBox3.Text = "A"
            TextBox4.Text = "Lulus"
        ElseIf (nilai >= 70) Then
            TextBox3.Text = "B"
            TextBox4.Text = "Lulus"
        ElseIf (nilai >= 60) Then
            TextBox3.Text = "C"
            TextBox4.Text = "Lulus"
        ElseIf (nilai >= 50) Then
            TextBox3.Text = "D"
            TextBox4.Text = "Tidak Lulus"
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class