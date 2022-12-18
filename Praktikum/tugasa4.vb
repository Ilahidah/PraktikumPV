Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class tugasa4
    Private Sub tugasa4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 13 To 1 Step -1
            ComboBox1.Items.Add(i)
        Next
        'perulangan untuk for each digunakan jika varabel berisikan array
        Dim namasiswa As String
        Dim nama() As String = {"Budi", "Andi", "dewi", "dila", "iqbal"}
        For Each namasiswa In nama
            ComboBox2.Items.Add(namasiswa)
        Next
    End Sub
End Class