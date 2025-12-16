Imports MySql.Data.MySqlClient

Public Class menulogin

    Public Shared UserIDLogin As Integer
    Public Shared RoleLogin As String
    Public Shared NamaLogin As String
    Private Sub menulogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMasukRt_Click(sender As Object, e As EventArgs) Handles btnMasukRt.Click
        If tbuser.Text = "" Or tbpass.Text = "" Then
            MsgBox("Username dan Password harus diisi!", vbExclamation)
            Return
        End If

        Try
            connected()
            ' Kita join tabel users dan role untuk mengambil nama role sekalian
            Dim sql As String = "SELECT u.user_id, u.username, u.role_id, r.role_name " &
                                "FROM users u JOIN role r ON u.role_id = r.role_id " &
                                "WHERE u.username = @user AND u.password = @pass AND u.is_active = 1"

            ' CATATAN KEAMANAN: 
            ' Di project nyata, password harus di-hash (dienkripsi). 
            ' Jika di database Anda password masih polos, kode ini jalan.
            ' Jika sudah di-hash, Anda perlu library verifikasi hash (misal BCrypt).

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", tbuser.Text)
            cmd.Parameters.AddWithValue("@pass", tbpass.Text)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                ' Login Berhasil
                UserIDLogin = dr("user_id")
                RoleLogin = dr("role_name").ToString()
                NamaLogin = dr("username").ToString()

                MsgBox("Selamat Datang, " & NamaLogin & " (" & RoleLogin & ")", vbInformation)

                ' --- LOGIKA PENGARAHAN MENU (ROUTING) ---
                If RoleLogin = "ketua RT/RW" Or dr("role_id") = 1 Then
                    ' Buka Dashboard Ketua RT
                    MenuKetuaRTRW.Show()
                    MsgBox("Membuka Menu Ketua RT...")
                Else
                    ' Buka Dashboard Petugas
                    menupetugas.Show()
                    MsgBox("Membuka Menu Petugas...")
                End If

                ' Sembunyikan form login
                Me.Hide()
            Else
                MsgBox("Username atau Password salah, atau akun tidak aktif.", vbCritical)
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Gagal Login: " & ex.Message)
        Finally
            Call endconnected()
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Dim formUtama As New pilihanLogin
        formUtama.Show()
    End Sub


End Class