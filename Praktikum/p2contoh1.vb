Public Class p2contoh1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnEnter_Click_1(sender As Object, e As EventArgs) Handles BtnEnter.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the length of the string
        MessageBox.Show(strResults.Length.ToString & " karakter", "Panjang Strings")
    End Sub
End Class