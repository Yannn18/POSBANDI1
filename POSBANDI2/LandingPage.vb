Public Class LandingPage

    Private Sub btnMulaiLP_Click(sender As Object, e As EventArgs) Handles btnMulaiLP.Click
        Dim pilihanlogin As New pilihanLogin
        pilihanlogin.Show()
        Me.Hide()
    End Sub
End Class