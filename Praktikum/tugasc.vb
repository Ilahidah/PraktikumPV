Public Class tugasc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim parag As String
        Dim jumlah As Integer
        parag = TextBox1.Text
        jumlah = TextBox2.Text
        For i = 1 To jumlah
            ListBox1.Items.Add(TextBox1.Text & " " & i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class