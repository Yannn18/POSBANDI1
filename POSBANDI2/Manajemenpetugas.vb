Imports CrystalDecisions.ReportAppServer
Imports MySql.Data.MySqlClient

Public Class Manajemenpetugas
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim ds As New DataSet
    Public da As MySqlDataAdapter


    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''TAB 1
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub
    Sub KondisiAwal()
        ' Bersihkan semua input
        tbnama.Clear()
        tbtlp.Clear()
        tbalmt.Clear()
        tbusia.Clear()
        tbdate.Value = Date.Now
        rbaktif.Checked = True ' Set default ke Aktif

        ' Atur tombol
        btnsimpan.Enabled = True
        btnupdate.Enabled = False
        btnhapus.Enabled = False

        ' Hasilkan kode petugas baru dan tampilkan data
        GenerateKodePetugas()
        TampilkanData()
    End Sub

    Sub TampilkanData()
        Try
            connected()
            ' Ambil hanya kolom yang relevan
            Dim sql As String = "SELECT kode_petugas, nama, telp, alamat, usia, status_aktif, created_at FROM petugas"
            da = New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvpetugas.DataSource = dt
        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message, vbCritical)
        Finally
            endconnected()
        End Try
    End Sub

    Sub GenerateKodePetugas()
        Try
            connected()
            ' 1. Ambil kode petugas terakhir
            cmd = New MySqlCommand("SELECT kode_petugas FROM petugas ORDER BY kode_petugas DESC LIMIT 1", conn)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                ' 2. Jika ada data, baca kodenya (misal: "PT009")
                dr.Read()
                Dim lastCode As String = dr.GetString(0)
                ' 3. Ambil 3 digit angka terakhir ("009")
                Dim lastNum As Integer = CInt(lastCode.Substring(2))
                ' 4. Tambah 1 (jadi 10)
                lastNum += 1
                ' 5. Format kembali menjadi "PT010"
                kdptgs.Text = "PT" & lastNum.ToString("000")
            Else
                ' 2. Jika tidak ada data, ini adalah rekor pertama
                kdptgs.Text = "PT001"
            End If

            kdptgs.ReadOnly = True ' Kunci textbox agar tidak bisa diubah

        Catch ex As Exception
            MsgBox("Gagal generate kode: " & ex.Message, vbCritical)
        Finally
            endconnected()
        End Try
    End Sub

    Private Function ValidasiInput() As Boolean
        ' Validasi Nama
        If String.IsNullOrWhiteSpace(tbnama.Text) Then
            MessageBox.Show("Nama Petugas wajib diisi.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbnama.Focus()
            Return False
        End If

        ' Validasi Usia (Sesuai permintaan Anda)
        If Not String.IsNullOrWhiteSpace(tbusia.Text) AndAlso Not IsNumeric(tbusia.Text) Then
            MessageBox.Show("Usia harus diisi dengan angka.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbusia.Focus()
            Return False
        End If

        ' Validasi Telepon
        If String.IsNullOrWhiteSpace(tbtlp.Text) Then
            MessageBox.Show("Nomor Telepon wajib diisi.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbtlp.Focus()
            Return False
        End If

        ' Validasi Status (memastikan salah satu terpilih)
        If Not rbaktif.Checked And Not rbnonaktif.Checked Then
            MessageBox.Show("Silakan pilih Status (Aktif / NonAktif).", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True ' Semua validasi lolos
    End Function

    Private Sub btnbaru_Click(sender As Object, e As EventArgs)
        KondisiAwal()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs)
        If Not ValidasiInput() Then Return

        Try
            connected()
            ' 2. Siapkan data
            Dim sql As String = "INSERT INTO petugas (kode_petugas, nama, telp, alamat, usia, status_aktif, user_id) VALUES (@kode, @nama, @telp, @alamat, @usia, @status, NULL)"
            cmd = New MySqlCommand(sql, conn)

            ' KONDISI 2: Status 1 untuk Aktif, 0 untuk NonAktif
            Dim status As Integer = If(rbaktif.Checked, 1, 0)
            'Dim create As String = tbdate.Value.ToString("yyyy-MM-dd")

            ' 3. Gunakan parameters
            cmd.Parameters.AddWithValue("@kode", kdptgs.Text)
            cmd.Parameters.AddWithValue("@nama", tbnama.Text)
            cmd.Parameters.AddWithValue("@telp", tbtlp.Text)
            cmd.Parameters.AddWithValue("@alamat", tbalmt.Text)
            cmd.Parameters.AddWithValue("@usia", tbusia.Text)
            cmd.Parameters.AddWithValue("@status", status)
            'cmd.Parameters.AddWithValue("@created_at", create)

            ' 4. Eksekusi
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data petugas baru berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            KondisiAwal() ' Bersihkan form

        Catch ex As Exception
            MsgBox("Gagal menyimpan: " & ex.Message, vbCritical)
        Finally
            endconnected()
        End Try

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs)
        If Not ValidasiInput() Then Return

        Try
            connected()
            Dim sql As String = "UPDATE petugas SET nama=@nama, telp=@telp, alamat=@alamat, usia=@usia, status_aktif=@status WHERE kode_petugas=@kode"
            cmd = New MySqlCommand(sql, conn)

            Dim status As Integer = If(rbaktif.Checked, 1, 0)
            'Dim create As String = tbdate.Value.ToString("yyyy-MM-dd")

            cmd.Parameters.AddWithValue("@nama", tbnama.Text)
            cmd.Parameters.AddWithValue("@telp", tbtlp.Text)
            cmd.Parameters.AddWithValue("@alamat", tbalmt.Text)
            cmd.Parameters.AddWithValue("@usia", tbusia.Text)
            cmd.Parameters.AddWithValue("@status", status)
            'cmd.Parameters.AddWithValue("@crreated_at", create)
            cmd.Parameters.AddWithValue("@kode", kdptgs.Text) ' Primary Key untuk WHERE

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data petugas berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            KondisiAwal()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message, vbCritical)
        Finally
            endconnected()
        End Try
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(kdptgs.Text) Then Return
        If MessageBox.Show("Apakah Anda yakin ingin menghapus data " & kdptgs.Text & " (" & tbnama.Text & ")?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                connected()
                Dim sql As String = "DELETE FROM petugas WHERE kode_petugas=@kode"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kode", kdptgs.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data petugas berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                KondisiAwal()

            Catch ex As Exception
                MsgBox("Gagal hapus: " & ex.Message, vbCritical)
            Finally
                endconnected()
            End Try
        End If
    End Sub

    Private Sub tbtlp_TKeyPress(sender As Object, e As KeyPressEventArgs)
        ' Hanya izinkan angka (digit) dan tombol kontrol (seperti Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Tolak input karakter
        End If
    End Sub

    Private Sub dgvpetugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvpetugas.Rows(e.RowIndex)

            ' Isi semua field berdasarkan data baris yang diklik
            kdptgs.Text = row.Cells("kode_petugas").Value.ToString()
            tbnama.Text = row.Cells("nama").Value.ToString()
            tbtlp.Text = row.Cells("telp").Value.ToString()
            tbalmt.Text = row.Cells("alamat").Value.ToString()
            tbusia.Text = row.Cells("usia").Value.ToString()
            'tbdate.Value = Convert.ToDateTime(row.Cells("tanggal_lahir").Value)

            ' Set RadioButton berdasarkan nilai status_aktif (1 atau 0)
            Dim status As Integer = Convert.ToInt32(row.Cells("status_aktif").Value)
            If status = 1 Then
                rbaktif.Checked = True
            Else
                rbnonaktif.Checked = False
            End If

            ' Atur tombol ke mode Edit
            btnsimpan.Enabled = False
            btnupdate.Enabled = True
            btnhapus.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim petugas1 As New cetakpetugas()
        Me.Hide()
        petugas1.Show()

    End Sub

    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''TAB 2
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        cetakpetugas.Show()
    End Sub
End Class
