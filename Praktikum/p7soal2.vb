Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class p7soal2
    Private data1 As New Collection
    Sub tampilkan()
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub
    Private Sub p7soal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
        ListBox1.Items.Add("Daftar data NIM")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datanya As New data1
        datanya.get_nim = TextBox1.Text
        datanya.get_nama = TextBox2.Text
        datanya.get_prodi = TextBox3.Text

        data1.Add(datanya)
        MessageBox.Show("Data ditambahkan!")
        ListBox1.Items.Add(datanya.get_nim)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mhs As data1 = CType(data1.Item(ListBox1.SelectedIndex), data1)
        Label7.Text = mhs.get_nim
        Label8.Text = mhs.get_nama
        Label9.Text = mhs.get_prodi
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        MessageBox.Show("Data dihapus!")
    End Sub
End Class