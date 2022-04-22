Public Class main_menu

    Private Sub main_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.Height = Me.Height
        kel_buku.MdiParent = Me
        btn_back.Hide()
        kelola_pinjam.MdiParent = Me
        register.MdiParent = Me
        form_petugas.MdiParent = Me
        kelola_user.MdiParent = Me
        lihat_data.MdiParent = Me
        form_anggota.MdiParent = Me


    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
        menu_login.Close()
    End Sub


    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text = "kelola data" Then
            form_petugas.MdiParent = Me
            form_petugas.Show()
        ElseIf TreeView1.SelectedNode.Text = "kelola petugas" Then
            form_kepala.MdiParent = Me
            form_kepala.Show()

        End If










    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        kel_buku.Hide()
        register.Hide()
        kelola_pinjam.Hide()
        form_petugas.Hide()
        form_petugas.Show()

    End Sub

End Class