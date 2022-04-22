Public Class kel_buku
    Public Sub penerbit()
        open_con()
        rec.Open("select * from penerbit", conn, 3, 2)
        Do While Not rec.EOF
            Me.ComboBox1.Items.Add(rec.Fields("nama").Value)
            rec.MoveNext()
        Loop
        cls()
    End Sub
    Public Sub pengarang()
        open_con()
        rec.Open("select * from pengarang", conn, 3, 2)
        Do While Not rec.EOF
            Me.ComboBox2.Items.Add(rec.Fields("nama").Value)
            rec.MoveNext()

        Loop
        cls()

    End Sub



    Public Sub jenis()
        open_con()
        rec.Open("select * from jenis_buku", conn, 3, 2)
        Do While Not rec.EOF
            Me.ComboBox3.Items.Add(rec.Fields("nama").Value)
            rec.MoveNext()

        Loop
        cls()

    End Sub
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
    
    Public Sub kel_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        pengarang()
        penerbit()
        jenis()
        main_menu.btn_back.Show()
        Dim judul() As String = {"kd_buku", "judul", "pengarang", "penerbit", "stok"}
        Dim lebar() As String = {100, 300, 100, 100, 100}
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

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        open_con()
        Dim sql_Del As String

        sql_Del = "delete from buku where kd_buku ='" & id_ud.Text & "' "
        conn.Execute(sql_Del)
        cls()
        id_ud.Text() = ""
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kel_buku_Load(e, e) 'me reload halaman
        MsgBox("delete success", vbInformation, "")
        Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        open_con()
        Dim sql_Add As String
        sql_Add = "insert into pengarang (nama) values('" & t_p.Text & "')"
        conn.Execute(sql_Add)
        cls()


        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kel_buku_Load(e, e) 'me reload halaman
        MsgBox("Thank you for sending data", vbInformation, "")
        Refresh()
    End Sub




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        open_con()
        Dim sql_Add As String
        sql_Add = "insert into  penerbit (nama) values('" & t_pener.Text & "')"
        conn.Execute(sql_Add)
        cls()

        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kel_buku_Load(e, e) 'me reload halaman
        MsgBox("Thank you for sending data", vbInformation, "")
        Refresh()


    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        open_con()
        Dim sql_Add As String
        sql_Add = "insert into jenis_buku (nama) values('" & t_jenis.Text & "')"
        conn.Execute(sql_Add)
        ComboBox3.Update()
        cls()
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kel_buku_Load(e, e) 'me reload halaman
        MsgBox("Thank you for sending data", vbInformation, "")
        Refresh()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        open_con()
        rec.Open("select kd_penerbit from penerbit where nama='" & ComboBox1.Text & "'", conn, 3, 2)
        If Not rec.EOF Then
            Me.id_penerbit.Text = rec.Fields("kd_penerbit").Value
        End If
        cls()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        open_con()
        rec.Open("select kd_pengarang from pengarang where nama='" & ComboBox2.Text & "'", conn, 3, 2)
        If Not rec.EOF Then
            Me.id_pengarang.Text = rec.Fields("kd_pengarang").Value
        End If
        cls()
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        open_con()
        rec.Open("select * from jenis_buku where nama='" & ComboBox3.Text & "'", conn, 3, 2)
        If Not rec.EOF Then
            Me.id_jenis.Text = rec.Fields(0).Value
        End If
        cls()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        open_con()
        Dim sql_Add As String
        sql_Add = "insert into buku(judul,kd_jenis_buku,kd_penerbit,kd_pengarang,stok) values('" & judul.Text & "','" & id_jenis.Text & "','" & id_penerbit.Text & "','" & id_pengarang.Text & "','" & stok.Text & "')"
        conn.Execute(sql_Add)

        cls()
        dgview()
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kel_buku_Load(e, e) 'me reload halaman
        MsgBox("Thank you for sending data", vbInformation, "")
        Refresh()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If id_ud.Text = "" Then
            MsgBox("masukan id yang akan di update/delete!")
        Else
            Dim sql_update As String
            conn.Open()

            sql_update = "UPDATE buku SET judul='" & judul.Text & "', stok='" & stok.Text & "', kd_penerbit='" & id_penerbit.Text & "', kd_pengarang='" & id_pengarang.Text & "', kd_jenis_buku='" & id_jenis.Text & "'where kd_buku='" & id_ud.Text & "'"
            conn.Execute(sql_update)
            MsgBox("data di update")
            cls()
        End If
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kel_buku_Load(e, e) 'me reload halaman
        MsgBox("update success", vbInformation, "")
        Refresh()
    End Sub

   

   
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        open_con()
        rec.Open("select * from buku where kd_buku='" & id_ud.Text & "'", conn, 3, 2)
        Me.judul.Text = rec.Fields("judul").Value
        Me.stok.Text = rec.Fields("stok").Value
        cls()
    End Sub
End Class