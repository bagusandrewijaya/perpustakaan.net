<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kel_buku
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
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.judul = New System.Windows.Forms.TextBox()
        Me.stok = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.asw = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.t_p = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.t_pener = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.t_jenis = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.id_penerbit = New System.Windows.Forms.TextBox()
        Me.id_pengarang = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.id_jenis = New System.Windows.Forms.TextBox()
        Me.id_ud = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(12, 370)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(105, 44)
        Me.btn_Add.TabIndex = 6
        Me.btn_Add.Text = "tambah"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(302, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "hapus"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(145, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 44)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'judul
        '
        Me.judul.Location = New System.Drawing.Point(12, 122)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(100, 20)
        Me.judul.TabIndex = 10
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(68, 146)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(44, 20)
        Me.stok.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 190)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 255)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(136, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(632, 266)
        Me.DataGridView1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "HALAMAN KELOLA BUKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "judul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "pengarang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "jenis"
        '
        'asw
        '
        Me.asw.AutoSize = True
        Me.asw.Location = New System.Drawing.Point(433, 378)
        Me.asw.Name = "asw"
        Me.asw.Size = New System.Drawing.Size(18, 13)
        Me.asw.TabIndex = 25
        Me.asw.Text = "ID"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(775, 117)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 44)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "tambah_pengarang"
        Me.Button5.UseVisualStyleBackColor = True
        '
        't_p
        '
        Me.t_p.Location = New System.Drawing.Point(775, 90)
        Me.t_p.Name = "t_p"
        Me.t_p.Size = New System.Drawing.Size(109, 20)
        Me.t_p.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(775, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "nama_pengarang"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(775, 213)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 44)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "tambah penerbit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        't_pener
        '
        Me.t_pener.Location = New System.Drawing.Point(775, 187)
        Me.t_pener.Name = "t_pener"
        Me.t_pener.Size = New System.Drawing.Size(109, 20)
        Me.t_pener.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(774, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "tambah penerbit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(777, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "tambah jenis"
        '
        't_jenis
        '
        Me.t_jenis.Location = New System.Drawing.Point(778, 290)
        Me.t_jenis.Name = "t_jenis"
        Me.t_jenis.Size = New System.Drawing.Size(109, 20)
        Me.t_jenis.TabIndex = 36
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(778, 316)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(109, 44)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "tambah jenis"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'id_penerbit
        '
        Me.id_penerbit.Location = New System.Drawing.Point(86, 214)
        Me.id_penerbit.Name = "id_penerbit"
        Me.id_penerbit.ReadOnly = True
        Me.id_penerbit.Size = New System.Drawing.Size(26, 20)
        Me.id_penerbit.TabIndex = 38
        '
        'id_pengarang
        '
        Me.id_pengarang.Location = New System.Drawing.Point(86, 282)
        Me.id_pengarang.Name = "id_pengarang"
        Me.id_pengarang.ReadOnly = True
        Me.id_pengarang.Size = New System.Drawing.Size(26, 20)
        Me.id_pengarang.TabIndex = 39
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(12, 317)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox3.TabIndex = 41
        '
        'id_jenis
        '
        Me.id_jenis.Location = New System.Drawing.Point(86, 344)
        Me.id_jenis.Name = "id_jenis"
        Me.id_jenis.ReadOnly = True
        Me.id_jenis.Size = New System.Drawing.Size(26, 20)
        Me.id_jenis.TabIndex = 42
        '
        'id_ud
        '
        Me.id_ud.Location = New System.Drawing.Point(426, 394)
        Me.id_ud.Name = "id_ud"
        Me.id_ud.Size = New System.Drawing.Size(100, 20)
        Me.id_ud.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(534, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 34)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "CARI"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'kel_buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(958, 435)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.id_ud)
        Me.Controls.Add(Me.id_jenis)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.id_pengarang)
        Me.Controls.Add(Me.id_penerbit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.t_jenis)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.t_pener)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.t_p)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.asw)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "kel_buku"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents judul As System.Windows.Forms.TextBox
    Friend WithEvents stok As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents asw As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents t_p As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents t_pener As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents t_jenis As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Private WithEvents id_penerbit As System.Windows.Forms.TextBox
    Private WithEvents id_pengarang As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Private WithEvents id_jenis As System.Windows.Forms.TextBox
    Friend WithEvents id_ud As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
