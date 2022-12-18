Imports System.Xml.Schema

Public Class tugasb5
    Dim totalgaji As Integer
    Const gaji As Integer = 2000000
    Public lamakerja As Integer
    Public Structure data
        Dim NIK, Nama, LAMAKERJA As String
    End Structure
    Private Sub p5contoh3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = "2000000"
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
            totalgaji = gaji + (gaji * 5 / 100)
        ElseIf (data = "2 tahun") Then
            lamakerja = 2
            totalgaji = gaji + (gaji * 6 / 100)
        ElseIf (data = "3 tahun") Then
            lamakerja = 3
            totalgaji = gaji + (gaji * 7 / 100)
        ElseIf (data = "4 tahun") Then
            lamakerja = 4
            totalgaji = gaji + (gaji * 8 / 100)
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
            listitem.SubItems.Add(totalgaji)
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
        End With
    End Sub

End Class