Public Class p4contoh1
    Private Sub p4contoh1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'perulangann untuk for next
        Dim i As Integer
        For i = 1 To 13
            ComboBox1.Items.Add(i)
        Next

        'perulangan untuk for each digunakan jika varabel berisikan array
        Dim namasiswa As String
        Dim nama() As String = {"Budi", "Andi", "dewi", "dila", "iqbal"}
        For Each namasiswa In nama
            ComboBox2.Items.Add(namasiswa)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class