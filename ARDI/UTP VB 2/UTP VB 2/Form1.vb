Public Class Form1
    Private Sub btnjalankan_Click(sender As Object, e As EventArgs) Handles btnjalankan.Click
        Dim judul As String
        Dim iterasi As Integer
        judul = txtjudul.Text
        iterasi = txtiterasi.Text
        For i = 1 To iterasi
            ListBox1.Items.Add(txtjudul.Text)
        Next (i)
    End Sub
End Class
