Public Class p7soal1
    Public datas As ArrayList = New ArrayList()
    Sub kosongkanbox()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub p7soal1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("NAMA")
        ListView1.Columns.Add("PRODI")
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim data As ArrayList = New ArrayList()
        data.Add(TextBox1.Text)
        data.Add(TextBox2.Text)
        data.Add(TextBox3.Text)
        datas.Add(data)

        ListView1.Items.Clear()
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        For Each i In datas
            listitem = ListView1.Items.Add(i(0))
            listitem.SubItems.Add(i(1))
            listitem.SubItems.Add(i(2))
        Next i
        Call kosongkanbox()
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim data As ArrayList = New ArrayList()
        data.Add(TextBox1.Text)
        data.Add(TextBox2.Text)
        data.Add(TextBox3.Text)

        datas.Insert(TextBox4.Text, data)
        ListView1.Items.Clear()
        Dim listitem As ListViewItem
        For Each i In datas
            listitem = ListView1.Items.Add(i(0))
            listitem.SubItems.Add(i(1))
            listitem.SubItems.Add(i(2))
        Next i
        Call kosongkanbox()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim idel As Integer = TextBox5.Text
        datas.RemoveAt(idel)
        ListView1.Items.Clear()

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        For Each i In datas
            listitem = ListView1.Items.Add(i(0))
            listitem.SubItems.Add(i(1))
            listitem.SubItems.Add(i(2))
        Next i
        TextBox5.Text = ""
        TextBox1.Focus()
    End Sub
End Class