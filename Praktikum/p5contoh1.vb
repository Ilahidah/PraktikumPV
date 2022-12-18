Public Class p5contoh1
    Private Sub p5contoh1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("Nama", 115)
        ListView1.Columns.Add("Prodi", 110)
        TextBox2.Text = 1
        TextBox1.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Arr(2) As String
        Arr(0) = TextBox1.Text
        Arr(1) = TextBox2.Text
        Arr(2) = TextBox3.Text

        Dim listen As ListViewItem
        listen = New ListViewItem
        listen = ListView1.Items.Add(Arr(1))
        listen.SubItems.Add(Arr(0))
        listen.SubItems.Add(Arr(2))

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub
End Class