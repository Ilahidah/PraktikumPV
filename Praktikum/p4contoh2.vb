Public Class p4contoh2
    Dim i As Integer
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ListBox1.Items.Clear()
        'perulangan dari 1 sampai 25
        For i = 1 To 25
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        ListBox1.Items.Clear()
        i = 1
        'kondisi i kurang dari sama dengan 20 true jadi program akan bekerja selama kondisi masih true
        Do While i <= 20
            ListBox1.Items.Add(i)
            i = i + 1
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        ListBox1.Items.Clear()
        i = 1
        'kondisi i lebih dari 15 adalah false, karena i = 1 karena itu program akan berjalan hingga kondisi false
        Do Until i > 15
            ListBox1.Items.Add(i)
            i = i + 1
        Loop
    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        ListBox1.Items.Clear()
        i = 1
        'sama dengan while
        While i <= 10
            ListBox1.Items.Add(i)
            i = i + 1
        End While
    End Sub
End Class