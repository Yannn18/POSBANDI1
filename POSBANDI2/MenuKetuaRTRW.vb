Public Class MenuKetuaRTRW
    Private Sub btnManajemenPetugas_Click(sender As Object, e As EventArgs) Handles btnManajemenPetugas.Click
        Dim manajemenpetugas As New Manajemenpetugas
        manajemenpetugas.Show()
        Me.Hide()
    End Sub

    Private Sub btnMnjJadwal_Click(sender As Object, e As EventArgs) Handles btnMnjJadwal.Click
        Dim manajemenjadwal As New ManajemenJadwal
        manajemenjadwal.Show()
        Me.Hide()
    End Sub

    Private Sub btnSesiLayanan_Click(sender As Object, e As EventArgs) Handles btnSesiLayanan.Click
        Dim sesiLayanan As New FormSesiLayanan
        sesiLayanan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporanUtm_Click(sender As Object, e As EventArgs) Handles btnLaporanUtm.Click

    End Sub

    Private Sub btnKembaliMU_Click(sender As Object, e As EventArgs) Handles btnKembaliMU.Click
        Dim landingpage As New LandingPage
        landingpage.Show()
        Me.Hide()
    End Sub
End Class