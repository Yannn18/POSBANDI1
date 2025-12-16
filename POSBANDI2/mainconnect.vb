Imports MySql.Data.MySqlClient

Module mainconnect
    Private ConnectionString As String = "server=localhost;user id=root; database=posbandi; port = 3308"

    Public conn As New MySqlConnection(ConnectionString)
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public rd As MySqlDataReader



    Public Sub connected()

        Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MessageBox.Show("Koneksi ke database berhasil!", "Status Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox("fail to open connection : " & ex.Message)
        End Try
    End Sub

    Public Sub endconnected()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("fail to close the connection")
        End Try

    End Sub

End Module
