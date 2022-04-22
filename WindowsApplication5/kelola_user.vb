Public Class kelola_user
    Public Sub dgview()
        Me.DataGridView1.Rows.Clear()
        open_con()
        rec.Open("select * from users", conn, 3, 2)
        Do While Not rec.EOF
            Me.DataGridView1.Rows.Add(rec.Fields(0).Value, rec.Fields(1).Value, rec.Fields(2).Value, rec.Fields(3).Value, rec.Fields(4).Value, rec.Fields(5).Value)
            rec.MoveNext()

        Loop
        cls()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql_add As String
        open_con()
        sql_add = "insert into users(nama,uername,password,status,level) values('" & nama.Text & "','" & username.Text & "','" & password.Text & "','" & status.Text & "','" & level.Text & "') "
    End Sub

    Private Sub kelola_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim judul() As String = {"kd_user", "nama", "username", "password", "status", "level"}
        Dim lebar() As String = {50, 150, 100, 100, 30, 30}
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnCount = 6
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql_update As String
        conn.Open()

        sql_update = "UPDATE users SET nama='" & nama.Text & "', username='" & username.Text & "', password='" & password.Text & "', status='" & status.Text & "', level='" & level.Text & "'where kd_users='" & kode_user.Text & "'"
        conn.Execute(sql_update)
        MsgBox("data di update")
        cls()

        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kelola_user_Load(e, e) 'me reload halaman
        MsgBox("Thank you for sending data", vbInformation, "")
        Refresh()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        open_con()
        rec.Open("select * from users where kd_users='" & kode_user.Text & "'", conn, 3, 2)
        Me.nama.Text = rec.Fields("nama").Value
        Me.username.Text = rec.Fields("username").Value
        Me.password.Text = rec.Fields("password").Value
        Me.status.Text = rec.Fields("status").Value
        Me.level.Text = rec.Fields("level").Value
        cls()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sql_Delete As String
        open_con()
        sql_Delete = "delete from users where kd_users='" & kode_user.Text & "'"
        conn.Execute(sql_Delete)
        MsgBox("data dihapus")
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kelola_user_Load(e, e) 'me reload halaman
        MsgBox("Thank you for sending data", vbInformation, "")
        Refresh()
    End Sub
End Class