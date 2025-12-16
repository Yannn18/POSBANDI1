Public Class pilihanLogin
    Private Sub btnPilihanPtg_Click(sender As Object, e As EventArgs) Handles btnPilihanPtg.Click
        Me.Hide()
        Dim landing As New LandingPage
        landing.Show()
    End Sub

    Private Sub btnPilihanRt_Click(sender As Object, e As EventArgs) Handles btnPilihanRt.Click
        Dim loginRTRW As New menulogin
        loginRTRW.Show()
        Me.Hide()
    End Sub
End Class