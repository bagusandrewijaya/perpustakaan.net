Imports System.Data.Odbc

Public Class menu_login
    Public Shared check As String
    Public Shared leve_user As String
    Private Sub menu_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        open_con()

        If Uname.Text = "" And Upass.Text = " " Then
            MsgBox("DATA TIDAK BOLEH KOSONG")
        Else
            rec.Open("select * from users where username= '" & Uname.Text & "'and password='" & Upass.Text & "' ", conn, 3, 2)


        End If


        If rec.EOF = False Then
            If rec.Fields("level").Value = "2" Then
                main_menu.Show()
                Me.Hide()
                main_menu.TreeView1.Nodes.Clear()
                Dim node1 As New TreeNode("MENU PETUGAS")
                Dim petugas As New TreeNode("kelola data")
                main_menu.TreeView1.Nodes.Add(node1)
                node1.Nodes.Add(petugas)


            End If
            If rec.Fields("level").Value = "1" Then
                main_menu.Show()
                Me.Hide()
                main_menu.TreeView1.Nodes.Clear()
                Dim node1 As New TreeNode("MENU KEPALA")
                Dim petugas As New TreeNode("kelola petugas")
                main_menu.TreeView1.Nodes.Add(node1)
                node1.Nodes.Add(petugas)

            End If
            

        Else
            MsgBox("PASSWORD ATAU EMAIL SALAH!", MsgBoxStyle.OkOnly)
        End If
        cls()
  
     
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        open_con()
        rec.Open("select * from anggota where nama= '" & Uname.Text & "'and password='" & Upass.Text & "' ", conn, 3, 2)
        leve_user = rec.Fields(0).Value
        cls()

        If leve_user = "" Then
            MsgBox("TIDAK TERSEDIA")
        Else
            form_anggota.Show()
            Me.Hide()
            main_menu.TreeView1.Nodes.Clear()
            form_anggota.id_kamu.Text = leve_user

        End If


    End Sub

End Class
