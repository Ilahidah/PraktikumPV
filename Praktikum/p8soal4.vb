Public Class p8soal4
    Dim indeks As Integer = 0
    Dim setarray As Integer = 5
    Dim kodeproduk() As String
    Dim namaproduk() As String
    'button simpan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If indeks > setarray - 1 Then
            MsgBox("list sudah penuh!")
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            kodeproduk(indeks) = TextBox1.Text
            namaproduk(indeks) = TextBox2.Text
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
            indeks = indeks + 1
        End If
    End Sub
    'button tampilkan
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        If indeks > 0 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            For i = 0 To indeks - 1
                ListBox1.Items.Add(kodeproduk(i))
                ListBox2.Items.Add(namaproduk(i))
            Next
        End If
    End Sub
    'button setarray
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        setarray = InputBox("masukkan banyaknya array", "input disini")
        ReDim kodeproduk(setarray)
        ReDim namaproduk(setarray)
    End Sub
End Class