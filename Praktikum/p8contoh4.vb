Public Class p8contoh4
    Dim indeks As Integer = 0
    Dim jumlah_data As Integer = 5
    Dim kodeproduk() As String
    Dim namaproduk() As String
    Private Sub p8contoh4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim kodeproduk(5)
        ReDim namaproduk(5)
    End Sub
    'buttonsimpan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If indeks > jumlah_data - 1 Then
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
End Class