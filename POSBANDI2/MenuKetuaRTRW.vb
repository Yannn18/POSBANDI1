Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

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



    Private Sub btnLaporanUtm_Click(sender As Object, e As EventArgs) Handles btnLaporanUtm.Click
        Me.Hide()
        Dim laporanutama As New Formlaporan
        laporanutama.Show()
    End Sub

    Private Sub btnKembaliMU_Click(sender As Object, e As EventArgs) Handles btnKembaliMU.Click
        Dim landingpage As New pilihanLogin
        landingpage.Show()
        Me.Hide()
    End Sub

    Private Sub btnregistrasi_Click(sender As Object, e As EventArgs) Handles btnregistrasi.Click
        Me.Hide()
        Dim formregis As New regisPetugas
        formregis.Show()
    End Sub



    '=============================================================================


    Private Sub MenuKetuaRTRW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiComboTahun()
        ' Set Default ke Bulan & Tahun sekarang
        cbbulan.SelectedIndex = Month(Now) - 1
        cbtahun.SelectedItem = Year(Now).ToString()

        LoadDashboard()
    End Sub

    Sub isiComboTahun()
        cbtahun.Items.Clear()
        For i As Integer = 2024 To Year(Now) + 1
            cbtahun.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles chartlayanan.Click

    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        LoadDashboard()
    End Sub

    Sub LoadDashboard()
        Dim bulan As Integer = cbbulan.SelectedIndex + 1
        Dim tahun As Integer = CInt(cbtahun.SelectedItem)

        ' Panggil sub-fungsi masing-masing bagian
        HitungKartuStatistik(bulan, tahun)
        MuatGrafikLayanan(bulan, tahun)
        ' MuatTabelKendala(bulan, tahun)
    End Sub

    Sub HitungKartuStatistik(bln As Integer, thn As Integer)
        Try
            Call connected()

            ' A. Hitung Total Warga (Unik berdasarkan NIK)
            Dim sqlWarga As String = "SELECT COUNT(DISTINCT nik) FROM sesi_bantuan " &
                                     "WHERE MONTH(waktu_mulai) = @b AND YEAR(waktu_mulai) = @t"
            cmd = New MySqlCommand(sqlWarga, conn)
            cmd.Parameters.AddWithValue("@b", bln)
            cmd.Parameters.AddWithValue("@t", thn)
            Dim totWarga As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lbltotalwarga.Text = totWarga.ToString() & " Orang"

            ' B. Hitung Total Sesi Layanan
            Dim sqlSesi As String = "SELECT COUNT(*) FROM sesi_bantuan " &
                                    "WHERE MONTH(waktu_mulai) = @b AND YEAR(waktu_mulai) = @t"
            cmd = New MySqlCommand(sqlSesi, conn)
            cmd.Parameters.AddWithValue("@b", bln)
            cmd.Parameters.AddWithValue("@t", thn)
            Dim totSesi As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lbltotalsesi.Text = totSesi.ToString() & " Sesi"

            ' C. Layanan Paling Populer (Mode)
            Dim sqlTop As String = "SELECT l.nama_layanan FROM sesi_bantuan s " &
                                   "JOIN layanan l ON s.layanan_id = l.layanan_id " &
                                   "WHERE MONTH(s.waktu_mulai) = @b AND YEAR(s.waktu_mulai) = @t " &
                                   "GROUP BY l.nama_layanan ORDER BY COUNT(*) DESC LIMIT 1"
            cmd = New MySqlCommand(sqlTop, conn)
            cmd.Parameters.AddWithValue("@b", bln)
            cmd.Parameters.AddWithValue("@t", thn)

            Dim hasilTop As Object = cmd.ExecuteScalar()
            If hasilTop IsNot Nothing Then
                lbltoplayanan.Text = hasilTop.ToString()
            Else
                lbltoplayanan.Text = "-"
            End If

        Catch ex As Exception
            MsgBox("Gagal memuat statistik: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Sub MuatGrafikLayanan(bln As Integer, thn As Integer)
        Try
            Call connected()
            ' Query Grouping: Nama Layanan & Jumlahnya
            Dim sql As String = "SELECT l.nama_layanan, COUNT(s.sesi_id) as Jumlah " &
                                "FROM sesi_bantuan s " &
                                "JOIN layanan l ON s.layanan_id = l.layanan_id " &
                                "WHERE MONTH(s.waktu_mulai) = @b AND YEAR(s.waktu_mulai) = @t " &
                                "GROUP BY l.nama_layanan"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@b", bln)
            cmd.Parameters.AddWithValue("@t", thn)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Bersihkan Chart Lama
            chartlayanan.Series.Clear()
            chartlayanan.Titles.Clear()

            ' Tambahkan Judul Chart
            chartlayanan.Titles.Add("Statistik Layanan Bulan " & bln & "/" & thn)

            ' Buat Series Baru
            Dim s As New Series("Jumlah Layanan")
            s.ChartType = SeriesChartType.Column ' Bisa diganti .Pie atau .Doughnut
            s.IsValueShownAsLabel = True ' Tampilkan angka di batang grafik

            ' Isi Data ke Chart
            While dr.Read()
                s.Points.AddXY(dr("nama_layanan").ToString(), dr("Jumlah"))
            End While

            chartlayanan.Series.Add(s)
            dr.Close()

        Catch ex As Exception
            MsgBox("Error Grafik: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub lbltotalwarga_Click(sender As Object, e As EventArgs) Handles lbltotalwarga.Click

    End Sub

    Private Sub lblwarga_Click(sender As Object, e As EventArgs) Handles lblwarga.Click

    End Sub

    Private Sub lblsesi_Click(sender As Object, e As EventArgs) Handles lblsesi.Click

    End Sub

    Private Sub lbltop_Click(sender As Object, e As EventArgs) Handles lbltop.Click

    End Sub
End Class