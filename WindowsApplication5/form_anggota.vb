Public Class form_anggota
   
    Public Sub dgview()
        Me.DataGridView1.Rows.Clear()
        open_con()
        rec.Open("select buku.kd_buku, buku.judul,pengarang.nama,penerbit.nama,buku.stok from buku Join pengarang Join penerbit on pengarang.kd_pengarang = buku.kd_pengarang where penerbit.kd_penerbit = buku.kd_penerbit", conn, 3, 2)
        Do While Not rec.EOF
            Me.DataGridView1.Rows.Add(rec.Fields(0).Value, rec.Fields(1).Value, rec.Fields(2).Value, rec.Fields(3).Value, rec.Fields(4).Value)

            rec.MoveNext()

        Loop
        cls()

    End Sub

    Public Sub dg_lihat()
        Me.DataGridView2.Rows.Clear()
        open_con()
        rec.Open("select buku.judul,peminjaman.jumlah_pinjam,peminjaman.tanggal_pinjam,peminjaman.date_kmbali from peminjaman join buku join anggota  on buku.kd_buku = peminjaman.kd_buku and anggota.kd_anggota = peminjaman.kd_Anggota where peminjaman.kd_anggota='" & id_kamu.Text & "'", conn, 3, 2)
        Do While Not rec.EOF
            Me.DataGridView2.Rows.Add(rec.Fields(0).Value, rec.Fields(1).Value, rec.Fields(2).Value, rec.Fields(3).Value)

            rec.MoveNext()

        Loop
        cls()

    End Sub
    Public Sub cari_buku()
        open_con()
        Me.DataGridView1.Rows.Clear()
        rec.Open("select buku.kd_buku, buku.judul,pengarang.nama,penerbit.nama,buku.stok from buku Join pengarang Join penerbit on pengarang.kd_pengarang = buku.kd_pengarang and penerbit.kd_penerbit = buku.kd_penerbit where buku.judul like'%" & cari_bk.Text & "%' ", conn, 3, 2)
        Do While Not rec.EOF
            Me.DataGridView1.Rows.Add(rec.Fields(0).Value, rec.Fields(1).Value, rec.Fields(2).Value, rec.Fields(3).Value)

            rec.MoveNext()
        Loop
        cls()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id_kamu.Text = menu_login.leve_user
        Dim judul() As String = {"kd_buku", "judul", "pengarang", "penerbit", "stok"}
        Dim lebar() As String = {50, 200, 150, 150, 80}
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnCount = 5
        DataGridView1.RowCount = 1
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("arial", 8)
        For i = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Columns(i).HeaderText = judul(i)
            DataGridView1.Columns(i).Width = lebar(i)
            DataGridView1.Columns(i).DefaultCellStyle.Font = New Font("arial", 8)

        Next
        dgview()
        Dim jdl() As String = {"nama_peminjam", "judul", "jumlah", "tanggal_pinjam", "tanggal_kembali"}
        Dim br() As String = {100, 200, 150, 150, 150}
        DataGridView2.RowHeadersVisible = False
        DataGridView2.ColumnCount = 5
        DataGridView2.RowCount = 1
        DataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("arial", 8)
        For i = 0 To DataGridView2.ColumnCount - 1
            DataGridView2.Columns(i).HeaderText = jdl(i)
            DataGridView2.Columns(i).Width = br(i)
            DataGridView2.Columns(i).DefaultCellStyle.Font = New Font("arial", 8)

        Next
        dg_lihat()


    End Sub

    Private Sub cari_bk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari_bk.TextChanged
        cari_buku()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        Form1_Load(e, e) 'me reload halaman
        MsgBox("halaman di refresh", vbInformation, "")
        Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        menu_login.Show()
    End Sub
End Class