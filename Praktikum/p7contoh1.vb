Public Class p7contoh1
    Public datas As ArrayList = New ArrayList()
    Private Sub p7contoh1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim data As ArrayList = New ArrayList()
        data.Add(TextBox1.Text)
        data.Add(TextBox2.Text)
        data.Add(TextBox3.Text)

        datas.Insert(0, data)
        ListView1.Items.Clear()
        Dim listitem As ListViewItem
        For Each i In datas
            listitem = ListView1.Items.Add(i(0))
            listitem.SubItems.Add(i(1))
            listitem.SubItems.Add(i(2))
        Next i
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        datas.RemoveAt(0)
        ListView1.Items.Clear()

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        For Each i In datas
            listitem = ListView1.Items.Add(i(0))
            listitem.SubItems.Add(i(1))
            listitem.SubItems.Add(i(2))
        Next i
    End Sub

End Class