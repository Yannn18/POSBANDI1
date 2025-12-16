Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class cetakpetugas
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
    Public Property KodePetugasTerpilih As String
    Private Sub cetakpetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New petugas   ' Ganti dengan nama file rpt Anda

        Try


            rpt.ReportOptions.EnableSaveDataWithReport = False

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()

            ' --- BAGIAN PENTING: LOGIN ULANG KE DATABASE ---
            ' Crystal Report butuh login ulang saat runtime agar bisa tarik data baru
            Dim connectionInfo As New ConnectionInfo()
            connectionInfo.ServerName = "petugas" ' Atau DSN Anda
            connectionInfo.DatabaseName = "posbandi"
            connectionInfo.UserID = "root"
            connectionInfo.Password = "" ' Isi jika ada password

            rpt.SetParameterValue("pkodepetugas", Me.KodePetugasTerpilih)

            SetDBLogonForReport(connectionInfo, rpt)
            ' ------------------------------------------------

            ' --- PAKSA REFRESH DATA ---
            rpt.Refresh()

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh() ' Refresh juga viewernya
        Catch ex As Exception
            MessageBox.Show("Gagal mencetak: " & ex.Message)
        End Try
    End Sub

    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim manajemenpetugas As New Manajemenpetugas
        manajemenpetugas.Show()
        Me.Hide()
    End Sub
End Class