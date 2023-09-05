Public Class Form1
    Private Sub btnYourGender_Click(sender As Object, e As EventArgs) Handles btnYourGender.Click
        Dim strYourGender As String

        strYourGender = ListBox1.SelectedItem
        MsgBox("Hi you are " + strYourGender)
    End Sub
End Class
