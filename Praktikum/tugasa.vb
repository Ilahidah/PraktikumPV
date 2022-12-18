Public Class tugasa
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim math = txtMath.Text
        Dim IPA = txtIPA.Text
        Dim bindo = txtBindo.Text
        Dim bing = txtBing.Text
        Dim IPS = txtIPS.Text

        Dim rata = (CInt(math) + CInt(IPA) + CInt(bindo) + CInt(bing) + CInt(IPS)) / 5

        If (rata >= 75) Then
            txtKet.Text = "Lulus"
        Else
            txtKet.Text = "Tidak Lulus"
        End If

        txtRata.Text = rata
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        txtNama.Text = ""
        txtNIM.Text = ""
        txtMath.Text = ""
        txtIPA.Text = ""
        txtBindo.Text = ""
        txtBing.Text = ""
        txtIPS.Text = ""
        txtRata.Text = ""
        txtKet.Text = ""
    End Sub
End Class