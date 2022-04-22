Public Class register
    Public Sub dgview()
        Me.DataGridView1.Rows.Clear()
        open_con()
        rec.Open("select * from anggota", conn, 3, 2)
        Do While Not rec.EOF
            Me.DataGridView1.Rows.Add(rec.Fields.Item(0).Value, rec.Fields(1).Value)
            rec.MoveNext()

        Loop
        cls()
    End Sub
    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim judul() As String = {"kode anggota", "nama"}
        Dim lebar() As String = {70, 150}
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnCount = 2
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
        Dim username As String


        username = R_name.Text
       
        Dim sql_tambah As String
        open_con()
        If username = "" Then
            MsgBox("DATA TIDAK BOLEH KOSONG")
        Else
            rec.Open("select * from users where username='" & username & "'", conn, 3, 2)
            If rec.EOF = True Then
                sql_tambah = "insert into anggota(nama,password) values('" & username & "','" & insert_Pass.Text & "')"
                conn.Execute(sql_tambah)
                MsgBox("berhasil daftar")

            End If
        End If
        
        cls()
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        register_Load(e, e) 'me reload halaman
        MsgBox("Thank you for sending data", vbInformation, "")
        Refresh()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        menu_login.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sql_update As String
        conn.Open()

        sql_update = "UPDATE anggota SET nama='" & nama_set.Text & "',password='" & update_pass.Text & "'where kd_anggota='" & id_anggota.Text & "'"
        conn.Execute(sql_update)
        MsgBox("data di update")
        cls()
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        register_Load(e, e) 'me reload halaman
        MsgBox("Thank you for update", vbInformation, "")
        Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn.Open()
        Dim sql_update As String
        sql_update = "delete from anggota where kd_anggota='" & id_anggota.Text & "'"
        conn.Execute(sql_update)
        MsgBox("data di hapus")
        cls()
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        register_Load(e, e) 'me reload halaman
        MsgBox("Thank you for delete data", vbInformation, "")
        Refresh()
    End Sub
End Class