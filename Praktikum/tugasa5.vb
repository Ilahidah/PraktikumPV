Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class tugasa5
    Dim nilai(100) As Integer
    Dim maks, min, n As Integer
    Private Sub tugasa5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Nama", 100)
        ListView1.Columns.Add("Nilai")
        TextBox1.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(1) As String
        arr(0) = TextBox1.Text
        arr(1) = TextBox2.Text
        n = n + 1
        nilai(n) = CInt(TextBox2.Text)
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        maks = nilai(1)
        For i = 1 To n
            If nilai(i) > maks Then maks = nilai(i)
        Next
        ListBox1.Items.Add("")
        ListBox1.Items.Add("nilai maks data = " & maks)

        min = nilai(1)
        For i = 1 To n
            If nilai(i) < min Then min = nilai(i)
        Next
        ListBox1.Items.Add("")
        ListBox1.Items.Add("nilai min data = " & min)
    End Sub
End Class