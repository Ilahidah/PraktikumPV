Public Class tugasb4
    Dim i As Integer
    Dim jumlah As Integer
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ListBox1.Items.Clear()
        jumlah = TextBox1.Text
        For i = 1 To jumlah
            ListBox1.Items.Add("Perulangan for ke-" & i)
        Next
    End Sub
    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        ListBox1.Items.Clear()
        jumlah = TextBox1.Text
        i = 1
        Do While i <= jumlah
            ListBox1.Items.Add("Perulangan do while ke-" & i)
            i = i + 1
        Loop
    End Sub
    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        ListBox1.Items.Clear()
        jumlah = TextBox1.Text
        i = 1
        Do Until i > jumlah
            ListBox1.Items.Add("Perulangan do until ke-" & i)
            i = i + 1
        Loop
    End Sub
    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        ListBox1.Items.Clear()
        jumlah = TextBox1.Text
        i = 1
        While i <= jumlah
            ListBox1.Items.Add("Perulangan while ke-" & i)
            i = i + 1
        End While
    End Sub
End Class