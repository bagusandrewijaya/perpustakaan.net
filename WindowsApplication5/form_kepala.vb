Public Class form_kepala

    Private Sub form_kepala_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_con()
        rec.Open("select count(*) from users", conn, 3, 2)
        If Not rec.EOF Then
            Me.Label2.Text = rec.Fields("count(*)").Value
        End If
        cls()
        open_con()
        rec.Open("select count(*) from peminjaman", conn, 3, 2)
        If Not rec.EOF Then
            Me.Label3.Text = rec.Fields("count(*)").Value
        End If
        cls()
        open_con()
        rec.Open("select count(*) from buku", conn, 3, 2)
        If Not rec.EOF Then
            Me.Label5.Text = rec.Fields("count(*)").Value
        End If
        cls()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kelola_user.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lihat_data.Show()
        Me.Hide()

    End Sub
End Class