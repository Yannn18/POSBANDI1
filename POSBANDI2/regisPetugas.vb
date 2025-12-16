Imports MySql.Data.MySqlClient

Public Class regisPetugas
    Private Sub regisPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboPetugas()
    End Sub

    Sub IsiComboPetugas()
        Try
            connected()
            Dim sql As String = "SELECT petugas_id, nama FROM petugas WHERE user_id IS NULL AND status_aktif = 1"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            cbpetugas.DataSource = dt
            cbpetugas.DisplayMember = "nama"
            cbpetugas.ValueMember = "petugas_id"
            cbpetugas.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Gagal memuat data petugas: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub
    Private Sub btnMasukPtg_Click(sender As Object, e As EventArgs) Handles btnMasukPtg.Click
        If cbpetugas.SelectedIndex = -1 Then
            MsgBox("Pilih petugas yang akan didaftarkan!", vbExclamation)
            Return
        End If
        If tbuser.Text = "" Or tbpass.Text = "" Then
            MsgBox("Username dan Password wajib diisi!", vbExclamation)
            Return
        End If

        Try
            connected()

            ' Cek Username Kembar
            Dim cmdCek As New MySqlCommand("SELECT COUNT(*) FROM users WHERE username = @user", conn)
            cmdCek.Parameters.AddWithValue("@user", tbuser.Text)
            If Convert.ToInt32(cmdCek.ExecuteScalar()) > 0 Then
                MsgBox("Username sudah dipakai, silakan ganti yang lain.", vbExclamation)
                Return
            End If

            ' --- MULAI PROSES PENYIMPANAN ---



            ' 3. Insert ke Tabel USERS (Role ID 2 = Petugas)
            Dim sqlUser As String = "INSERT INTO users (username, password, role_id, is_active) VALUES (@user, @pass, 2, 1); SELECT LAST_INSERT_ID();"
            cmd = New MySqlCommand(sqlUser, conn)
            cmd.Parameters.AddWithValue("@user", tbuser.Text)
            cmd.Parameters.AddWithValue("@pass", tbpass.Text)

            ' Eksekusi dan ambil ID User yang baru dibuat
            Dim newUserID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' 4. Update Tabel PETUGAS (Hubungkan user_id)
            Dim sqlPetugas As String = "UPDATE petugas SET user_id = @userid WHERE petugas_id = @ptgid"
            cmd = New MySqlCommand(sqlPetugas, conn)
            cmd.Parameters.AddWithValue("@userid", newUserID)
            cmd.Parameters.AddWithValue("@ptgid", cbpetugas.SelectedValue)
            cmd.ExecuteNonQuery()

            MsgBox("Akun Petugas Berhasil Dibuat!", vbInformation)

            ' Reset form
            tbuser.Clear()
            tbpass.Clear()
            IsiComboPetugas() ' Refresh combo agar nama petugas yg sudah didaftarkan hilang dari list

        Catch ex As Exception
            MsgBox("Gagal Registrasi: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim formrt As New MenuKetuaRTRW
        formrt.Show()
    End Sub

End Class