Public Class kelola_pinjam



    Private Sub kelola_anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        open_con()
        Dim judul_buku As String
        Dim jumlah As String
        Dim kode_buku As String
        rec.Open("select buku.kd_buku,anggota.nama,buku.judul,peminjaman.jumlah_pinjam,peminjaman.tanggal_pinjam from anggota,buku,peminjaman where anggota.nama = '" & nama_Cari.Text & "' and peminjaman.kd_peminjaman='" & kd_cari.Text & "' ", conn, 3, 2)

        If Not rec.EOF Then
            judul_buku = rec.Fields("judul").Value
            jumlah = rec.Fields("jumlah_pinjam").Value
            kode_buku = rec.Fields("kd_buku").Value

            MsgBox("data peminjaman dengan id " & kd_cari.Text & " ditemukan nama peminjam  " & nama_Cari.Text & " buku yang dipinjam " & judul_buku & " jumlah dipinjam " & jumlah, MsgBoxStyle.OkOnly)
            jumlah_kembali.Text = jumlah
        Else
            MsgBox("data peminjaman dengan id " & kd_cari.Text & " tidak ditemukan!!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
        End If
        cls()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        open_con()
        rec.Open("select nama from anggota where kd_anggota='" & kd_Anggota.Text & "'", conn, 3, 2)
        If Not rec.EOF Then
            Me.nm_pinjam.Text = rec.Fields("nama").Value
            MsgBox("data tersedia!", MsgBoxStyle.OkOnly)
            cls()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        open_con()
        rec.Open("select judul from buku where kd_buku='" & kd_buku.Text & "'", conn, 3, 2)
        If Not rec.EOF Then
            Me.judul_bku.Text = rec.Fields("judul").Value
            MsgBox("data tersedia!", MsgBoxStyle.OkOnly)

        End If
        cls()
    End Sub
    Private Sub btn_pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pinjam.Click
        MsgBox("pastikan data sudah lengkap! tekan ok jika lengkap", MsgBoxStyle.YesNo)
        If MsgBoxResult.Ok Then

            open_con()
            Dim sql_add As String
            sql_add = "insert into peminjaman(kd_anggota,kd_buku,jumlah_pinjam) values('" & kd_Anggota.Text & "','" & kd_buku.Text & "','" & jml_pinjam.Text & "')"
            conn.Execute(sql_add)

        End If

        cls()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("pastikan data sudah lengkap! tekan ok jika lengkap")

        open_con()
        Dim sql_add As String
        sql_add = "update peminjaman set date_kmbali=now(),jumlah_kembali='" & jumlah_kembali.Text & "' where kd_peminjaman='" & kd_cari.Text & "'"
        conn.Execute(sql_add)
        cls()



    End Sub
End Class