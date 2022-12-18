Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class p5contoh2
    Private Sub p5contoh2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(3, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "Nama"
        arr(1, 0) = "Jenis Kelamin"
        arr(1, 1) = "Prodi"
        arr(2, 0) = "Laki-laki"
        arr(2, 1) = "Perempuan"
        arr(3, 0) = "Pend ilkom"
        arr(3, 1) = "ilkom"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris
        For baris = 2 To 2
            For kolom = 0 To 1
                ComboBox1.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
        For baris = 3 To 3
            For kolom = 0 To 1
                ComboBox2.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(3) As String
        arr(0) = TextBox1.Text
        arr(1) = TextBox2.Text
        arr(2) = ComboBox1.Text
        arr(3) = ComboBox2.Text
        Dim listen As ListViewItem
        listen = New ListViewItem
        listen = ListView1.Items.Add(arr(0))
        listen.SubItems.Add(arr(1))
        listen.SubItems.Add(arr(2))
        listen.SubItems.Add(arr(3))
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Focus()
    End Sub
End Class