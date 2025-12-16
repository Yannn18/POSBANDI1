Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Formlaporan
    Private Sub Formlaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturKondisiAwal()
    End Sub

    Sub AturKondisiAwal()
        ' Set default tanggal (Awal bulan sampai hari ini)
        Dim hariIni As Date = Date.Now
        dtpmulai.Value = New Date(hariIni.Year, hariIni.Month, 1)
        dtpselesai.Value = hariIni

        ' Muat riwayat laporan yang pernah dibuat sebelumnya
        TampilkanRiwayat()
    End Sub
    Private Sub btntampilkan_Click(sender As Object, e As EventArgs) Handles btntampilkan.Click
        TampilkanPreview()
    End Sub

    Sub TampilkanPreview()
        Try
            Call connected()

            ' QUERY KOMPLEKS: Menggabungkan Sesi, Warga, Petugas, dan Layanan
            ' Hanya mengambil data dalam rentang waktu yang dipilih
            Dim sql As String = "SELECT s.kode_sesi, m.nama AS Nama_Warga, p.nama AS Nama_Petugas, " &
                                "l.nama_layanan, s.waktu_mulai, s.status, s.catatan " &
                                "FROM sesi_bantuan s " &
                                "JOIN masyarakat m ON s.nik = m.nik " &
                                "JOIN petugas p ON s.petugas_id = p.petugas_id " &
                                "JOIN layanan l ON s.layanan_id = l.layanan_id " &
                                "WHERE DATE(s.waktu_mulai) BETWEEN @tglAwal AND @tglAkhir " &
                                "ORDER BY s.waktu_mulai DESC"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@tglAwal", dtpmulai.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@tglAkhir", dtpselesai.Value.ToString("yyyy-MM-dd"))

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvlaporan.DataSource = dt

            ' Format Grid agar rapi
            dgvlaporan.Columns("waktu_mulai").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"

            If dt.Rows.Count = 0 Then
                MsgBox("Tidak ada aktivitas layanan pada periode ini.", vbInformation)
            End If

        Catch ex As Exception
            MsgBox("Error Load Data: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub



    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        If dgvlaporan.Rows.Count = 0 Then
            MsgBox("Tidak ada data untuk dicetak. Klik 'Tampilkan Data' terlebih dahulu.", vbExclamation)
            Return
        End If

        Try
            ' 1. SIMPAN RIWAYAT KE TABEL 'LAPORAN'
            Call connected()
            Dim sqlHistory As String = "INSERT INTO laporan (jenis, periode_start, periode_end, created_by, created_at) " &
                                       "VALUES ('Laporan Bulanan', @start, @end, @user, NOW())"

            cmd = New MySqlCommand(sqlHistory, conn)
            cmd.Parameters.AddWithValue("@start", dtpmulai.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@end", dtpselesai.Value.ToString("yyyy-MM-dd"))
            ' Asumsi: Anda punya variabel global UserIDLogin dari form Login
            ' Jika belum ada, ganti dengan ID admin default sementara, misal '1'
            cmd.Parameters.AddWithValue("@user", menulogin.UserIDLogin)

            cmd.ExecuteNonQuery()

            ' 2. BUKA CRYSTAL REPORT
            Dim frmCetak As New fromcetaklaporan ' Form Viewer yang sudah Anda siapkan

            ' Kirim parameter tanggal ke Form Viewer agar laporan terfilter
            frmCetak.TglMulai = dtpmulai.Value
            frmCetak.TglSelesai = dtpselesai.Value

            frmCetak.ShowDialog()

            ' Refresh tabel history
            TampilkanRiwayat()

        Catch ex As Exception
            MsgBox("Gagal Mencetak: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Sub TampilkanRiwayat()
        Try
            Call connected()
            ' Menampilkan siapa yang mencetak laporan dan kapan
            Dim sql As String = "SELECT l.laporan_id, l.jenis, l.periode_start, l.periode_end, u.username AS Dicetak_Oleh, l.created_at " &
                                "FROM laporan l " &
                                "LEFT JOIN users u ON l.created_by = u.user_id " &
                                "ORDER BY l.created_at DESC LIMIT 10"

            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvhistory.DataSource = dt
        Catch ex As Exception
            ' Ignore error history load
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuketuartrw As New MenuKetuaRTRW
        menuketuartrw.Show()
        Me.Hide()
    End Sub
End Class