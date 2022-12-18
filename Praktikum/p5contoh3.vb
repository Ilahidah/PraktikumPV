Public Class p5contoh3
    Const gaji As Integer = 2000000
    Public lamakerja As Integer
    Public Structure data
        Dim NIK, Nama, LAMAKERJA As String
    End Structure
    Private Sub p5contoh3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("Nama", 100)
        ListView1.Columns.Add("Lama bekerja", 100)
        ListView1.Columns.Add("Gaji", 100)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim data As String = ComboBox1.Text
        If (data = "1 tahun") Then
            lamakerja = 1
        ElseIf (data = "2 tahun") Then
            lamakerja = 2
        ElseIf (data = "3 tahun") Then
            lamakerja = 3
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datainput As data
        With datainput
            .NIK = TextBox2.Text
            .Nama = TextBox1.Text
            .LAMAKERJA = lamakerja
            Dim listitem As ListViewItem
            listitem = New ListViewItem
            listitem = ListView1.Items.Add(.NIK)
            listitem.SubItems.Add(.Nama)
            listitem.SubItems.Add(ComboBox1.Text)
            listitem.SubItems.Add(gaji * lamakerja)
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class