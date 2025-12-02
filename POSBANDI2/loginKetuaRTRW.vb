Public Class loginKetuaRTRW
    Private Sub btnMasukRt_Click(sender As Object, e As EventArgs) Handles btnMasukRt.Click
        Dim menuketuartrw As New MenuKetuaRTRW
        menuketuartrw.Show()
        Me.Hide()
    End Sub
End Class