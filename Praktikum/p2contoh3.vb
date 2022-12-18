Public Class p2contoh3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bil1 = TextBox1.Text
        Dim bil2 = TextBox2.Text
        Dim tambah = CInt(bil1) + CInt(bil2)
        TextBox3.Text = tambah
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bil1 = TextBox1.Text
        Dim bil2 = TextBox2.Text
        Dim kali = CInt(bil1) * CInt(bil2)
        TextBox3.Text = kali
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bil1 = TextBox1.Text
        Dim bil2 = TextBox2.Text
        Dim kurang = CInt(bil1) - CInt(bil2)
        TextBox3.Text = kurang
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bil1 = TextBox1.Text
        Dim bil2 = TextBox2.Text
        Dim bagi = CInt(bil1) / CInt(bil2)
        TextBox3.Text = bagi
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim bil1 = TextBox1.Text
        Dim bil2 = TextBox2.Text
        Dim hasil = CInt(bil1) Mod CInt(bil2)
        TextBox3.Text = hasil
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim panjang = txtPanjang.Text
        Dim lebar = txtLebar.Text
        Dim keliling = (CInt(panjang) + CInt(lebar)) * 2
        txtHasilK.Text = keliling
        Dim luas = CInt(panjang) * CInt(lebar)
        txtHasilL.Text = luas
    End Sub
End Class