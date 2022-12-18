Public Class tugasb
    Public hargaMak As Integer
    Public hargaMin As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Coto Makassar"
                TextBox1.Text = "15000"
                hargaMak = 15000
            Case "Laksa Singapore"
                TextBox1.Text = "17000"
                hargaMak = 17000
            Case "Rendang"
                TextBox1.Text = "10000"
                hargaMak = 10000
            Case "White Curry"
                TextBox1.Text = "25000"
                hargaMak = 25000
            Case "Beef steak"
                TextBox1.Text = "50000"
                hargaMak = 50000
        End Select
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Iced tea"
                TextBox3.Text = "5000"
                hargaMin = 5000
            Case "Lemon mujito"
                TextBox3.Text = "20000"
                hargaMin = 20000
            Case "Cendol"
                TextBox3.Text = "10000"
                hargaMin = 10000
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jumlahMak, hasilMak As Integer
        jumlahMak = TextBox2.Text
        hasilMak = hargaMak * jumlahMak
        TextBox5.Text = "Rp.  " & hasilMak

        Dim jumlahMin, hasilMin As Integer
        jumlahMin = TextBox4.Text
        hasilMin = hargaMin * jumlahMin
        TextBox6.Text = "Rp.  " & hasilMin

        Dim totalJum As Integer
        totalJum = hasilMak + hasilMin
        TextBox7.Text = "Rp.  " & totalJum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
End Class