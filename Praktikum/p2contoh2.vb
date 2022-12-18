Imports System.ComponentModel

Public Class p2contoh2
    Private Sub RbtnDefault_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnDefault.CheckedChanged
        Me.BackColor = Color.Empty
    End Sub
    Private Sub RbtnMerah_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnMerah.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub RbtnKuning_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnKuning.CheckedChanged
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub RbtnHijau_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnHijau.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub RbtnBiru_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnBiru.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub
End Class