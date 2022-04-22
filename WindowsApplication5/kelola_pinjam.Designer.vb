<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kelola_pinjam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nm_pinjam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kd_Anggota = New System.Windows.Forms.TextBox()
        Me.judul_bku = New System.Windows.Forms.TextBox()
        Me.kd_buku = New System.Windows.Forms.TextBox()
        Me.jml_pinjam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_pinjam = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.kd_cari = New System.Windows.Forms.TextBox()
        Me.nama_Cari = New System.Windows.Forms.TextBox()
        Me.jumlah_kembali = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(378, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KELOLA PINJAM BUKU"
        '
        'nm_pinjam
        '
        Me.nm_pinjam.Location = New System.Drawing.Point(28, 155)
        Me.nm_pinjam.Name = "nm_pinjam"
        Me.nm_pinjam.Size = New System.Drawing.Size(100, 20)
        Me.nm_pinjam.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NAMA ANGGOTA"
        '
        'kd_Anggota
        '
        Me.kd_Anggota.Location = New System.Drawing.Point(76, 110)
        Me.kd_Anggota.Name = "kd_Anggota"
        Me.kd_Anggota.Size = New System.Drawing.Size(52, 20)
        Me.kd_Anggota.TabIndex = 4
        '
        'judul_bku
        '
        Me.judul_bku.Location = New System.Drawing.Point(229, 155)
        Me.judul_bku.Name = "judul_bku"
        Me.judul_bku.Size = New System.Drawing.Size(100, 20)
        Me.judul_bku.TabIndex = 5
        '
        'kd_buku
        '
        Me.kd_buku.Location = New System.Drawing.Point(291, 110)
        Me.kd_buku.Name = "kd_buku"
        Me.kd_buku.Size = New System.Drawing.Size(40, 20)
        Me.kd_buku.TabIndex = 6
        '
        'jml_pinjam
        '
        Me.jml_pinjam.Location = New System.Drawing.Point(99, 203)
        Me.jml_pinjam.Name = "jml_pinjam"
        Me.jml_pinjam.Size = New System.Drawing.Size(29, 20)
        Me.jml_pinjam.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "JUDUL BUKU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "JUMLAH PINJAM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "kode"
        '
        'btn_pinjam
        '
        Me.btn_pinjam.Location = New System.Drawing.Point(83, 229)
        Me.btn_pinjam.Name = "btn_pinjam"
        Me.btn_pinjam.Size = New System.Drawing.Size(118, 52)
        Me.btn_pinjam.TabIndex = 12
        Me.btn_pinjam.Text = "TAMBAH"
        Me.btn_pinjam.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 52)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "PENGEMBALIAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.nm_pinjam)
        Me.Panel1.Controls.Add(Me.btn_pinjam)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.kd_Anggota)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.judul_bku)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.kd_buku)
        Me.Panel1.Controls.Add(Me.jml_pinjam)
        Me.Panel1.Location = New System.Drawing.Point(55, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 295)
        Me.Panel1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "USERID"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(363, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 35)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "cek"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(139, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 35)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "cek"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PEMINJAMAN ANGGOTA"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.jumlah_kembali)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.kd_cari)
        Me.Panel2.Controls.Add(Me.nama_Cari)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(555, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 295)
        Me.Panel2.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "KODE PINJAM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "NAMA ANGGOTA"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 52)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "CARI"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'kd_cari
        '
        Me.kd_cari.Location = New System.Drawing.Point(22, 111)
        Me.kd_cari.Name = "kd_cari"
        Me.kd_cari.Size = New System.Drawing.Size(100, 20)
        Me.kd_cari.TabIndex = 17
        '
        'nama_Cari
        '
        Me.nama_Cari.Location = New System.Drawing.Point(22, 49)
        Me.nama_Cari.Name = "nama_Cari"
        Me.nama_Cari.Size = New System.Drawing.Size(100, 20)
        Me.nama_Cari.TabIndex = 16
        '
        'jumlah_kembali
        '
        Me.jumlah_kembali.Location = New System.Drawing.Point(22, 155)
        Me.jumlah_kembali.Name = "jumlah_kembali"
        Me.jumlah_kembali.Size = New System.Drawing.Size(100, 20)
        Me.jumlah_kembali.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "JUMLAH PINJAM"
        '
        'kelola_pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(853, 361)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "kelola_pinjam"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nm_pinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents kd_Anggota As System.Windows.Forms.TextBox
    Friend WithEvents judul_bku As System.Windows.Forms.TextBox
    Friend WithEvents kd_buku As System.Windows.Forms.TextBox
    Friend WithEvents jml_pinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_pinjam As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents kd_cari As System.Windows.Forms.TextBox
    Friend WithEvents nama_Cari As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents jumlah_kembali As System.Windows.Forms.TextBox
End Class
