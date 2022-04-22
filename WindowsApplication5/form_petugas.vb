Public Class form_petugas

    Private Sub form_kepala_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main_menu.btn_back.Hide()
        open_con()


        rec.Open("select count(*) from anggota", conn, 3, 2)
        If Not rec.EOF Then
            Me.Label5.Text = rec.Fields("count(*)").Value
        End If
        cls()
        open_con()
        rec.Open("select count(*) from peminjaman", conn, 3, 2)
        If Not rec.EOF Then
            Me.Label6.Text = rec.Fields("count(*)").Value
        End If
        cls()
        open_con()
        rec.Open("select count(*) from buku", conn, 3, 2)
        If Not rec.EOF Then
            Me.Label7.Text = rec.Fields("count(*)").Value
        End If
        cls()
        Me.MdiParent = main_menu

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kel_buku.Show()
        main_menu.btn_back.Show()
        Me.Close()
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kel_buku.kel_buku_Load(e, e) 'me reload halaman

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kelola_pinjam.Show()
        main_menu.btn_back.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        register.Show()
        main_menu.btn_back.Show()
        Me.Close()
    End Sub
End Class