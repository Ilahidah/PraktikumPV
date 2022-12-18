Public Class p8soal3
    Dim week As New Hashtable
    Dim days As DictionaryEntry
    Private Sub p8contoh3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        week.Add("0", "Minggu")
        week.Add("1", "Senin")
        week.Add("2", "Selasa")
        week.Add("3", "Rabu")
        week.Add("4", "Kamis")
        week.Add("5", "Jumat")
        week.Add("6", "Sabtu")
        For Each days In week
            ListBox1.Items.Add(days.Value)
        Next
    End Sub
    'button1 as cari
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If week.ContainsValue(TextBox1.Text) Then
            MsgBox("data ditemukan")
        Else
            MsgBox("data tidak ditemukan")
        End If
    End Sub
    'button2 as button hapus
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        MsgBox("Removed")
    End Sub
End Class