Public Class p7contoh2
    Private data1 As New Collection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datanya As New data1
        datanya.get_nim = InputBox("Masukkan NIM: ", "Type here")
        datanya.get_nama = InputBox("Masukkan Nama: ", "Type here")
        datanya.get_prodi = InputBox("Masukkan prodi: ", "Type here")

        data1.Add(datanya)
        ListBox1.Items.Add(datanya.get_nim)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mhs As data1 = CType(data1.Item(ListBox1.SelectedIndex + 1), data1)
        MessageBox.Show("NIM = " & mhs.get_nim & "  NAMA = " & mhs.get_nama & "  PRODI = " & mhs.get_prodi)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub
End Class