Public Class layananprint
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim catataktivitas As New Catatktivitas
        catataktivitas.Show()
        Me.Hide()
    End Sub
End Class