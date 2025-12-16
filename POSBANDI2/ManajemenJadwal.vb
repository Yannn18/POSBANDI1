Imports MySql.Data.MySqlClient

Public Class ManajemenJadwal
    Dim currentJadwalID As String = ""
    Private Sub ManajemenJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Sub KondisiAwal()
        ' Bersihkan Input
        tbtanggal.Value = Date.Now
        tbjammulai.Value = DateTime.Now
        tbjamselesai.Value = DateTime.Now.AddHours(1)
        tblokasi.Clear()
        tbketerangan.Clear()
        currentJadwalID = ""

        ' Atur Tombol
        btnsmpn.Enabled = True
        btnupdt.Enabled = False
        btnhps.Enabled = False

        ' Muat Data
        IsiComboPetugas()
        TampilkanJadwal()
    End Sub

    Sub IsiComboPetugas()
        Try
            connected()
            Dim da As New MySqlDataAdapter("SELECT petugas_id, nama FROM petugas WHERE status_aktif = 1 ORDER BY nama", conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            cbpetugas.DataSource = dt
            cbpetugas.DisplayMember = "nama"      ' Yang tampil di layar
            cbpetugas.ValueMember = "petugas_id"  ' Yang disimpan (ID)
            cbpetugas.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Gagal memuat petugas: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Sub TampilkanJadwal()
        Try
            connected()
            ' Join tabel jadwal dan petugas untuk menampilkan nama petugas, bukan ID
            Dim sql As String = "SELECT j.jadwal_id, j.tanggal, j.jam_mulai, j.jam_selesai, j.lokasi, p.nama AS Nama_Petugas, j.keterangan, j.petugas_id " &
                                "FROM jadwal_layanan j " &
                                "JOIN petugas p ON j.petugas_id = p.petugas_id " &
                                "ORDER BY j.tanggal DESC"

            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvjadwal.DataSource = dt

            ' Sembunyikan kolom ID agar rapi
            dgvjadwal.Columns("jadwal_id").Visible = False
            dgvjadwal.Columns("petugas_id").Visible = False

        Catch ex As Exception
            MsgBox("Gagal menampilkan jadwal: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub







    Private Sub btbaru_Click(sender As Object, e As EventArgs) Handles btbaru.Click
        KondisiAwal()
    End Sub
    Private Sub btnsmpn_Click(sender As Object, e As EventArgs) Handles btnsmpn.Click
        If cbpetugas.SelectedIndex = -1 Or tblokasi.Text = "" Then
            MsgBox("Lokasi dan Petugas wajib diisi!", vbExclamation)
            Return
        End If

        Try
            connected()
            Dim sql As String = "INSERT INTO jadwal_layanan (tanggal, jam_mulai, jam_selesai, lokasi, petugas_id, keterangan) " &
                                "VALUES (@tgl, @mulai, @selesai, @lokasi, @petugas, @ket)"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@tgl", tbtanggal.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@mulai", tbjammulai.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@selesai", tbjamselesai.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@lokasi", tblokasi.Text)
            cmd.Parameters.AddWithValue("@petugas", cbpetugas.SelectedValue)
            cmd.Parameters.AddWithValue("@ket", tbketerangan.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Jadwal Berhasil Disimpan!", vbInformation)
            KondisiAwal()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub
    Private Sub btnupdt_Click(sender As Object, e As EventArgs) Handles btnupdt.Click
        If currentJadwalID = "" Then Return

        Try
            connected()
            Dim sql As String = "UPDATE jadwal_layanan SET tanggal=@tgl, jam_mulai=@mulai, jam_selesai=@selesai, " &
                                "lokasi=@lokasi, petugas_id=@petugas, keterangan=@ket WHERE jadwal_id=@id"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@tgl", tbtanggal.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@mulai", tbjammulai.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@selesai", tbjamselesai.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@lokasi", tblokasi.Text)
            cmd.Parameters.AddWithValue("@petugas", cbpetugas.SelectedValue)
            cmd.Parameters.AddWithValue("@ket", tbketerangan.Text)
            cmd.Parameters.AddWithValue("@id", currentJadwalID)

            cmd.ExecuteNonQuery()
            MsgBox("Jadwal Berhasil Diupdate!", vbInformation)
            KondisiAwal()

        Catch ex As Exception
            MsgBox("Gagal Update: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub
    Private Sub btnhps_Click(sender As Object, e As EventArgs) Handles btnhps.Click
        If currentJadwalID = "" Then Return

        If MessageBox.Show("Yakin ingin menghapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                connected()
                Dim sql As String = "DELETE FROM jadwal_layanan WHERE jadwal_id = @id"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", currentJadwalID)

                cmd.ExecuteNonQuery()
                MsgBox("Data Terhapus", vbInformation)
                KondisiAwal()
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            Finally
                Call endconnected()
            End Try
        End If
    End Sub




    Private Sub tbketerangan_TextChanged(sender As Object, e As EventArgs) Handles tbketerangan.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpetugas.SelectedIndexChanged

    End Sub

    Private Sub dgvjadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvjadwal.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvjadwal.Rows(e.RowIndex)

            ' Simpan ID untuk keperluan Update/Hapus
            currentJadwalID = row.Cells("jadwal_id").Value.ToString()

            ' Isi Form
            tbtanggal.Value = Convert.ToDateTime(row.Cells("tanggal").Value)
            ' Konversi object TimeSpan (dari DB) ke DateTime agar bisa masuk ke DateTimePicker
            tbjammulai.Value = DateTime.Today.Add(CType(row.Cells("jam_mulai").Value, TimeSpan))
            tbjamselesai.Value = DateTime.Today.Add(CType(row.Cells("jam_selesai").Value, TimeSpan))

            tblokasi.Text = row.Cells("lokasi").Value.ToString()
            tbketerangan.Text = row.Cells("keterangan").Value.ToString()

            ' Set ComboBox Petugas berdasarkan ID yang tersembunyi
            cbpetugas.SelectedValue = row.Cells("petugas_id").Value

            ' Ubah Mode Tombol
            btnsmpn.Enabled = False
            btnupdt.Enabled = True
            btnhps.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim menuketuartrw As New MenuKetuaRTRW
        menuketuartrw.Show()
    End Sub
End Class