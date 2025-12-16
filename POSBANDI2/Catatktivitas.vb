Imports MySql.Data.MySqlClient

Public Class Catatktivitas

    Dim currentKodeSesi As String = ""
    Dim waktuMulai As DateTime



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormSesiLayanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        IsiDataCombo()
    End Sub

    Sub kondisiAwal()
        ' Reset Form
        tbKodeSesi.Text = "SESI/" & Format(Now, "yyMMdd") & "/XXXX"
        tbNamaWarga.Clear()
        tbCatatanLyn.Clear()

        ' Reset Pilihan
        cbNIK.SelectedIndex = -1
        cbLayanan.SelectedIndex = -1
        cbPetugas.SelectedIndex = -1

        ' Atur Tombol
        btnMulaiSesi.Enabled = True
        btnSelesaiSesi.Enabled = False

        ' Buka kunci input
        cbNIK.Enabled = True
        cbLayanan.Enabled = True
        cbPetugas.Enabled = True
    End Sub

    Sub IsiDataCombo()
        Try
            Call connected()

            ' 1. Isi Combo NIK (Masyarakat)
            Dim da1 As New MySqlDataAdapter("SELECT nik, nama FROM masyarakat ORDER BY nama ASC", conn)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            cbNIK.DataSource = dt1
            cbNIK.DisplayMember = "nik"
            cbNIK.ValueMember = "nik"
            cbNIK.SelectedIndex = -1

            ' 2. Isi Combo Layanan
            Dim da2 As New MySqlDataAdapter("SELECT layanan_id, nama_layanan FROM layanan WHERE is_active = 1", conn)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            cbLayanan.DataSource = dt2
            cbLayanan.DisplayMember = "nama_layanan"
            cbLayanan.ValueMember = "layanan_id"
            cbLayanan.SelectedIndex = -1

            ' 3. Isi Combo Petugas
            Dim da3 As New MySqlDataAdapter("SELECT petugas_id, nama FROM petugas WHERE status_aktif = 1", conn)
            Dim dt3 As New DataTable
            da3.Fill(dt3)
            cbPetugas.DataSource = dt3
            cbPetugas.DisplayMember = "nama"
            cbPetugas.ValueMember = "petugas_id"
            cbPetugas.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub cbNIK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNIK.SelectedIndexChanged
        If cbNIK.SelectedIndex <> -1 Then
            ' Kita ambil row dari DataTable yang terikat di ComboBox
            Dim drv As DataRowView = CType(cbNIK.SelectedItem, DataRowView)
            tbNamaWarga.Text = drv("nama").ToString()
        Else
            tbNamaWarga.Clear()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblWaktu.Text = Format(Now, "HH:mm:ss")
    End Sub

    Function GenerateKodeSesi() As String
        Dim kodeBaru As String = ""
        Dim pattern As String = "SES/" & Format(Now, "yyMMdd") & "/"
        Try
            Call connected()
            ' Ambil kode terakhir hari ini
            cmd = New MySqlCommand("SELECT kode_sesi FROM sesi_bantuan WHERE kode_sesi LIKE '" & pattern & "%' ORDER BY kode_sesi DESC LIMIT 1", conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim lastKode As String = dr.Item("kode_sesi").ToString()

                ' --- BAGIAN PERBAIKAN ---
                ' Logika Lama: Mengambil 3 huruf kanan (Gagal jika format salah)
                ' Logika Baru: Memisahkan berdasarkan garis miring "/"

                ' Contoh lastKode: "SES/251127/001"
                Dim parts() As String = lastKode.Split("/")
                ' parts(0) = "SES", parts(1) = "251127", parts(2) = "001"

                ' Ambil bagian terakhir (angka urut)
                Dim angkaTerakhir As String = parts(parts.Length - 1)

                ' Ubah jadi angka dan tambah 1
                Dim hitung As Integer = Val(angkaTerakhir) + 1

                ' Gabungkan ulang: SES/251127/ + 002
                kodeBaru = pattern & hitung.ToString("000")
            Else
                ' Jika belum ada data hari ini, mulai dari 001
                kodeBaru = pattern & "001"
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error Generate Kode: " & ex.Message)
            ' Kode darurat jika error, pakai jam menit detik biar tidak duplikat
            kodeBaru = pattern & Format(Now, "HHmmss")
        Finally
            Call endconnected()
        End Try

        Return kodeBaru
    End Function

    Private Sub btnMulaiSesi_Click(sender As Object, e As EventArgs) Handles btnMulaiSesi.Click
        If cbNIK.SelectedIndex = -1 Or cbLayanan.SelectedIndex = -1 Or cbPetugas.SelectedIndex = -1 Then
            MsgBox("Mohon lengkapi data NIK, Layanan, dan Petugas!", vbExclamation, "Peringatan")
            Return
        End If

        Try

            currentKodeSesi = GenerateKodeSesi()

            ' Cek apakah berhasil generate
            If String.IsNullOrEmpty(currentKodeSesi) Then
                MsgBox("Gagal membuat Kode Sesi!")
                Return
            End If
            waktuMulai = Now
            ''' Hitung durasi (pastikan waktuMulai juga tersimpan di memori)
            ''Dim durasiMenit As Long = DateDiff(DateInterval.Minute, waktuMulai, waktuSelesai)
            'If durasiMenit < 1 Then durasiMenit = 1
            Call connected()

            ' Insert data awal dengan status 'BERJALAN'
            ' Waktu selesai & durasi masih NULL
            ' Update Query
            Dim sql As String = "INSERT INTO sesi_bantuan (kode_sesi, nik, petugas_id, layanan_id, waktu_mulai, status) VALUES (@kode, @nik, @ptg, @lyn, @mulai, 'BERJALAN')"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@kode", currentKodeSesi) ' Pastikan ini terisi
            cmd.Parameters.AddWithValue("@nik", cbNIK.SelectedValue)
            cmd.Parameters.AddWithValue("@ptg", cbPetugas.SelectedValue)
            cmd.Parameters.AddWithValue("@lyn", cbLayanan.SelectedValue)
            cmd.Parameters.AddWithValue("@mulai", waktuMulai.ToString("yyyy-MM-dd HH:mm:ss"))


            cmd.ExecuteNonQuery()

            ' Update UI
            tbKodeSesi.Text = currentKodeSesi
            MsgBox("Sesi Layanan Dimulai!", vbInformation)

            ' Kunci input agar tidak diubah saat sesi berjalan
            cbNIK.Enabled = False
            cbLayanan.Enabled = False
            cbPetugas.Enabled = False
            btnMulaiSesi.Enabled = False
            btnSelesaiSesi.Enabled = True

        Catch ex As Exception
            MsgBox("Gagal memulai sesi: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub btnSelesaiSesi_Click(sender As Object, e As EventArgs) Handles btnSelesaiSesi.Click
        MsgBox("Debug Kode: '" & currentKodeSesi & "'")

        If String.IsNullOrEmpty(currentKodeSesi) Then
            MsgBox("Tidak ada sesi yang sedang aktif untuk diselesaikan!", vbExclamation)
            Return
        End If

        Try
            Dim waktuSelesai As DateTime = Now
            Dim selisih As TimeSpan = waktuSelesai - waktuMulai
            Dim durasiString As String = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(selisih.TotalHours), selisih.Minutes, selisih.Seconds)
            ' Hitung durasi dalam menit
            '  Dim durasiMenit As Long = DateDiff(DateInterval.Minute, waktuMulai, waktuSelesai
            ' Jika durasi kurang dari 1 menit, anggap 1 menit
            '  If durasiMenit < 1 Then durasiMenit = 1

            Dim durasiMenitDb As Integer = CInt(selisih.TotalMinutes)
            If durasiMenitDb < 1 Then durasiMenitDb = 1

            Call connected()

            ' Update data untuk mengisi waktu selesai, durasi, catatan, dan ubah status
            Dim sql As String = "UPDATE sesi_bantuan SET waktu_selesai = @selesai, durasi_menit = @durasi, status = 'SELESAI', catatan = @catatan WHERE kode_sesi = @kode"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@selesai", waktuSelesai.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@durasi", durasiMenitDb)
            cmd.Parameters.AddWithValue("@catatan", tbCatatanLyn.Text)
            cmd.Parameters.AddWithValue("@kode", currentKodeSesi.Trim)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Sesi Layanan Selesai!" & vbCrLf & "Durasi: " & durasiString & "(Jam:Menit:Detik)", vbInformation)
                kondisiAwal()
                ' Kosongkan variabel kunci setelah selesai
                currentKodeSesi = ""
            Else
                MsgBox("Gagal update data. Kode Sesi tidak ditemukan: " & currentKodeSesi, vbExclamation)
            End If

        Catch ex As Exception
            MsgBox("Gagal menyelesaikan sesi: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        layananprint.show()
    End Sub

    Private Sub btnKembaliLyn_Click(sender As Object, e As EventArgs) Handles btnKembaliLyn.Click
        Me.Hide()
        menupetugas.Show()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        kondisiAwal()
        IsiDataCombo()
    End Sub
End Class