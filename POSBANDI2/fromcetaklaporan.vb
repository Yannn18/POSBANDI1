
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class fromcetaklaporan

    Public Property TglMulai As Date
    Public Property TglSelesai As Date
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub fromcetaklaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New laporanbaru ' Nama file .rpt Anda

        Try
            ' Login Database (Wajib)
            rpt.ReportOptions.EnableSaveDataWithReport = False
            Dim connectionInfo As New ConnectionInfo()
            connectionInfo.ServerName = "laporan" ' Nama DSN ODBC
            connectionInfo.DatabaseName = "posbandi"
            connectionInfo.UserID = "root"
            connectionInfo.Password = ""

            Dim myTables As Tables = rpt.Database.Tables
            For Each myTable As Table In myTables
                Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                myTableLogonInfo.ConnectionInfo = connectionInfo

                ' --- MULAI LANGKAH 2: PERBAIKAN NAMA TABEL (ALIAS) ---
                ' Masalah: Report pakai nama "sesi_bantuan1", Database pakai "sesi_bantuan"
                ' Solusi: Kita paksa Report membaca tabel asli (tanpa angka 1)

                Dim NamaDiReport As String = myTable.Name

                ' Cek apakah karakter terakhir adalah angka (misal: "1")
                If IsNumeric(Microsoft.VisualBasic.Right(NamaDiReport, 1)) Then
                    ' Jika ya, set Lokasi ke nama tabel tanpa angka terakhir
                    ' Contoh: "sesi_bantuan1" menjad "sesi_bantuan"
                    myTable.Location = Microsoft.VisualBasic.Left(NamaDiReport, Len(NamaDiReport) - 1)
                Else
                    ' Jika tidak ada angka, pastikan Lokasi sama dengan nama tabel
                    myTable.Location = NamaDiReport
                End If
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next

            ' TAMBAHKAN BARIS INI:
            ' Ini memaksa tabel "sesi_bantuan1" membaca data dari tabel asli "sesi_bantuan"
            ' Kita buang angka "1" atau angka lain di belakang nama tabel

            ' Kirim Parameter Tanggal ke Crystal Report (Record Selection Formula)
            ' Pastikan di Crystal Report Anda sudah membuat Parameter Field: "pTglAwal" dan "pTglAkhir"
            rpt.SetParameterValue("pTglAwal", TglMulai)
            rpt.SetParameterValue("pTglAkhir", TglSelesai)

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class