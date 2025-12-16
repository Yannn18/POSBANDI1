Imports MySql.Data.MySqlClient

Public Class Masyarakat
    Private Sub Masyarakat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()

    End Sub
    Sub KondisiAwal()
        ' Bersihkan semua input
        tbnik.Clear()
        tbnama.Clear()
        rblaki.Checked = False
        rbperempuan.Checked = False
        tbtempatlahir.Clear()
        tbtanggallahir.Value = Date.Now
        tbtelp.Clear()
        tbalamat.Clear()

        ' Reset state tombol & input
        tbnik.Enabled = True ' NIK bisa diedit saat mode input baru
        btnsimpan.Enabled = True
        btnubah.Enabled = False
        btnhapus.Enabled = False

        TampilkanData()
    End Sub

    Sub TampilkanData()
        Try
            connected()
            ' UPDATE: Tambahkan tempat_lahir di query
            Dim sql As String = "SELECT nik, nama, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, telp FROM masyarakat ORDER BY nama ASC"

            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt

            ' Opsional: Rapikan Header
            DataGridView1.Columns("nik").HeaderText = "NIK"
            DataGridView1.Columns("nama").HeaderText = "Nama Lengkap"
            DataGridView1.Columns("tempat_lahir").HeaderText = "Tempat Lahir"

        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Function Validasi() As Boolean
        ' ... (Validasi NIK tetap sama) ...

        ' UPDATE: Tambahkan tbtempatlahir di pengecekan
        If tbnama.Text = "" Or tbtempatlahir.Text = "" Or tbtelp.Text = "" Or tbalamat.Text = "" Then
            MsgBox("Mohon lengkapi Nama, Tempat Lahir, Telepon, dan Alamat.", vbExclamation)
            Return False
        End If

        If tbnama.Text = "" Or tbtelp.Text = "" Or tbalamat.Text = "" Then
            MsgBox("Mohon lengkapi Nama, Telepon, dan Alamat.", vbExclamation)
            Return False
        End If

        If rblaki.Checked = False And rbperempuan.Checked = False Then
            MsgBox("Pilih Jenis Kelamin!", vbExclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub txtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnik.KeyPress, tbtelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rblaki.CheckedChanged

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If Not Validasi() Then Return

        Try
            connected()
            ' Cek dulu apakah NIK sudah ada
            cmd = New MySqlCommand("SELECT COUNT(*) FROM masyarakat WHERE nik='" & tbnik.Text & "'", conn)
            Dim hitung As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If hitung > 0 Then
                MsgBox("NIK sudah terdaftar! Gunakan tombol Ubah jika ingin mengedit.", vbExclamation)
                Return
            End If

            Dim jk As String = If(rblaki.Checked, "L", "P")

            ' UPDATE: Tambahkan tempat_lahir ke Query INSERT
            Dim sql As String = "INSERT INTO masyarakat (nik, nama, tempat_lahir, jenis_kelamin, tanggal_lahir, alamat, telp) " &
                                "VALUES (@nik, @nama, @tempat, @jk, @tgl, @alamat, @telp)"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nik", tbnik.Text)
            cmd.Parameters.AddWithValue("@nama", tbnama.Text)
            cmd.Parameters.AddWithValue("@tempat", tbtempatlahir.Text)
            cmd.Parameters.AddWithValue("@jk", jk)
            cmd.Parameters.AddWithValue("@tgl", tbtanggallahir.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@alamat", tbalamat.Text)
            cmd.Parameters.AddWithValue("@telp", tbtelp.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Data Warga Berhasil Disimpan!", vbInformation)
            KondisiAwal()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If Not Validasi() Then Return

        Try
            connected()
            Dim jk As String = If(rblaki.Checked, "L", "P")

            ' UPDATE: Tambahkan tempat_lahir=@tempat ke Query UPDATE
            Dim sql As String = "UPDATE masyarakat SET nama=@nama, tempat_lahir=@tempat, jenis_kelamin=@jk, tanggal_lahir=@tgl, alamat=@alamat, telp=@telp, updated_at=NOW() " &
                                "WHERE nik=@nik"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nama", tbnama.Text)
            cmd.Parameters.AddWithValue("@tempat", tbtempatlahir.Text) ' <-- Parameter Baru
            cmd.Parameters.AddWithValue("@jk", jk)
            cmd.Parameters.AddWithValue("@tgl", tbtanggallahir.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@alamat", tbalamat.Text)
            cmd.Parameters.AddWithValue("@telp", tbtelp.Text)
            cmd.Parameters.AddWithValue("@nik", tbnik.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Data Warga Berhasil Diperbarui!", vbInformation)
            KondisiAwal()

        Catch ex As Exception
            MsgBox("Gagal Update: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If tbnik.Text = "" Then
            MsgBox("Pilih data warga yang akan dihapus dari tabel.", vbExclamation)
            Return
        End If

        If MessageBox.Show("Yakin ingin menghapus data warga " & tbnama.Text & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                connected()
                Dim sql As String = "DELETE FROM masyarakat WHERE nik = @nik"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nik", tbnik.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Data Warga Terhapus", vbInformation)
                KondisiAwal()
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            Finally
                Call endconnected()
            End Try
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            tbnik.Text = row.Cells("nik").Value.ToString()
            tbnama.Text = row.Cells("nama").Value.ToString()

            ' UPDATE: Ambil data Tempat Lahir
            tbtempatlahir.Text = row.Cells("tempat_lahir").Value.ToString()

            tbalamat.Text = row.Cells("alamat").Value.ToString()
            tbtelp.Text = row.Cells("telp").Value.ToString()

            ' ... (Sisa kode untuk tanggal lahir dan gender tetap sama) ...
            If IsDBNull(row.Cells("tanggal_lahir").Value) Then
                tbtanggallahir.Value = Date.Now
            Else
                tbtanggallahir.Value = Convert.ToDateTime(row.Cells("tanggal_lahir").Value)
            End If

            Dim jk As String = row.Cells("jenis_kelamin").Value.ToString()
            If jk = "L" Then
                rblaki.Checked = True
            ElseIf jk = "P" Then
                rbperempuan.Checked = True
            End If

            tbnik.Enabled = False
            btnsimpan.Enabled = False
            btnubah.Enabled = True
            btnhapus.Enabled = True
        End If
    End Sub

    Private Sub btnKembaliMU_Click(sender As Object, e As EventArgs) Handles btnKembaliMU.Click
        Me.Hide()
        menupetugas.Show()

    End Sub
End Class