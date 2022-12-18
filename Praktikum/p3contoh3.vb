Public Class p3contoh3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jumlah As Integer
        jumlah = TextBox1.Text
        For i = 1 To jumlah
            ListBox1.Items.Add("Item ke " & i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
    End Sub
End Class