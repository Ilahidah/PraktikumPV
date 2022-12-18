Public Class p5contoh4
    Public Enum Bulan As Integer
        jan = 1
        feb = 2
        mar = 3
        apr = 4
        mei = 5
        jun = 6
        jul = 7
        agt = 8
        sep = 9
        okt = 10
        nov = 11
        des = 12
    End Enum

    Private Sub p5contoh4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "NILAI BULAN JANUARI ADALAH = " & Bulan.jan
    End Sub
End Class