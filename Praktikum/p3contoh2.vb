Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class p3contoh2
    Public harga As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Coto Makassar"
                TextBox1.Text = "15000"
                harga = 15000
            Case "Laksa Singapore"
                TextBox1.Text = "17000"
                harga = 17000
            Case "Rendang"
                TextBox1.Text = "10000"
                harga = 10000
            Case "White Curry"
                TextBox1.Text = "25000"
                harga = 25000
            Case "Beef steak"
                TextBox1.Text = "5000"
                harga = 50000
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jumlah, hasil As Integer
        jumlah = TextBox2.Text
        hasil = harga * jumlah
        TextBox3.Text = "Rp.  " & hasil
    End Sub
End Class