Public Class menupetugas
    Private Sub menupetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKembaliMU_Click(sender As Object, e As EventArgs) Handles btnKembaliMU.Click
        Me.Hide()
        pilihanLogin.Show()
    End Sub

    Private Sub btnMnjJadwal_Click(sender As Object, e As EventArgs) Handles btnMnjJadwal.Click
        Me.Hide()
        Masyarakat.Show()

    End Sub

    Private Sub btnSesiLayanan_Click(sender As Object, e As EventArgs) Handles btnSesiLayanan.Click
        Me.Hide()
        Catatktivitas.Show()
    End Sub
End Class