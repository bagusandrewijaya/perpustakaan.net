<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_login
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
        Me.Uname = New System.Windows.Forms.TextBox()
        Me.Upass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Uname
        '
        Me.Uname.Location = New System.Drawing.Point(59, 168)
        Me.Uname.Name = "Uname"
        Me.Uname.Size = New System.Drawing.Size(226, 20)
        Me.Uname.TabIndex = 0
        '
        'Upass
        '
        Me.Upass.Location = New System.Drawing.Point(59, 231)
        Me.Upass.Name = "Upass"
        Me.Upass.Size = New System.Drawing.Size(226, 20)
        Me.Upass.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LOGI PAGE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "USERNAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "PASSWORD"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 52)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "ANGGOTA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'menu_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 486)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Upass)
        Me.Controls.Add(Me.Uname)
        Me.Name = "menu_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Uname As System.Windows.Forms.TextBox
    Friend WithEvents Upass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
