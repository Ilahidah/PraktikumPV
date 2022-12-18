Public Class p1contoh2
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim bil1 = TextBox1.Text
        Dim bil2 = TextBox2.Text
        Dim hasil = CInt(bil1) + CInt(bil2)

        TextBox3.Text = hasil
    End Sub
End Class