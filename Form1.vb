Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnYourgender.Click
        Dim stYourgender As String

        stYourgender = ListBox1.SelectedItem
        MsgBox("you are " & stYourgender)



    End Sub
End Class
