<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manajemenpetugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbnonaktif = New System.Windows.Forms.RadioButton()
        Me.rbaktif = New System.Windows.Forms.RadioButton()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.tbdate = New System.Windows.Forms.DateTimePicker()
        Me.dgvpetugas = New System.Windows.Forms.DataGridView()
        Me.kdptgs = New System.Windows.Forms.TextBox()
        Me.tbusia = New System.Windows.Forms.TextBox()
        Me.tbtlp = New System.Windows.Forms.TextBox()
        Me.tbalmt = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvpetugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(720, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbnonaktif
        '
        Me.rbnonaktif.AutoSize = True
        Me.rbnonaktif.Location = New System.Drawing.Point(703, 191)
        Me.rbnonaktif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbnonaktif.Name = "rbnonaktif"
        Me.rbnonaktif.Size = New System.Drawing.Size(81, 20)
        Me.rbnonaktif.TabIndex = 33
        Me.rbnonaktif.TabStop = True
        Me.rbnonaktif.Text = "Non Aktif"
        Me.rbnonaktif.UseVisualStyleBackColor = True
        '
        'rbaktif
        '
        Me.rbaktif.AutoSize = True
        Me.rbaktif.Location = New System.Drawing.Point(636, 190)
        Me.rbaktif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbaktif.Name = "rbaktif"
        Me.rbaktif.Size = New System.Drawing.Size(53, 20)
        Me.rbaktif.TabIndex = 32
        Me.rbaktif.TabStop = True
        Me.rbaktif.Text = "Aktif"
        Me.rbaktif.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(620, 271)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(94, 23)
        Me.btnhapus.TabIndex = 31
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(520, 271)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(94, 23)
        Me.btnupdate.TabIndex = 30
        Me.btnupdate.Text = "UDPATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnbaru
        '
        Me.btnbaru.Location = New System.Drawing.Point(320, 271)
        Me.btnbaru.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(94, 23)
        Me.btnbaru.TabIndex = 29
        Me.btnbaru.Text = "BARU"
        Me.btnbaru.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(420, 271)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(94, 23)
        Me.btnsimpan.TabIndex = 28
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'tbdate
        '
        Me.tbdate.Location = New System.Drawing.Point(690, 148)
        Me.tbdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbdate.Name = "tbdate"
        Me.tbdate.Size = New System.Drawing.Size(203, 22)
        Me.tbdate.TabIndex = 27
        '
        'dgvpetugas
        '
        Me.dgvpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpetugas.Location = New System.Drawing.Point(182, 314)
        Me.dgvpetugas.Name = "dgvpetugas"
        Me.dgvpetugas.RowHeadersWidth = 51
        Me.dgvpetugas.Size = New System.Drawing.Size(734, 282)
        Me.dgvpetugas.TabIndex = 26
        '
        'kdptgs
        '
        Me.kdptgs.Location = New System.Drawing.Point(690, 102)
        Me.kdptgs.Name = "kdptgs"
        Me.kdptgs.ReadOnly = True
        Me.kdptgs.Size = New System.Drawing.Size(203, 22)
        Me.kdptgs.TabIndex = 25
        '
        'tbusia
        '
        Me.tbusia.Location = New System.Drawing.Point(303, 137)
        Me.tbusia.Name = "tbusia"
        Me.tbusia.Size = New System.Drawing.Size(199, 22)
        Me.tbusia.TabIndex = 24
        '
        'tbtlp
        '
        Me.tbtlp.Location = New System.Drawing.Point(303, 170)
        Me.tbtlp.Name = "tbtlp"
        Me.tbtlp.Size = New System.Drawing.Size(199, 22)
        Me.tbtlp.TabIndex = 23
        '
        'tbalmt
        '
        Me.tbalmt.Location = New System.Drawing.Point(303, 207)
        Me.tbalmt.Name = "tbalmt"
        Me.tbalmt.Size = New System.Drawing.Size(199, 22)
        Me.tbalmt.TabIndex = 22
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(303, 102)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(199, 22)
        Me.tbnama.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(571, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Kode Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(581, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Usia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(179, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Pembuatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nama Petugas"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(928, 628)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 25)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Kembali"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Heavy", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(430, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(233, 29)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Manajemen Petugas"
        '
        'Manajemenpetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1052, 665)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rbnonaktif)
        Me.Controls.Add(Me.rbaktif)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnbaru)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.tbdate)
        Me.Controls.Add(Me.dgvpetugas)
        Me.Controls.Add(Me.kdptgs)
        Me.Controls.Add(Me.tbusia)
        Me.Controls.Add(Me.tbtlp)
        Me.Controls.Add(Me.tbalmt)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Manajemenpetugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Petugas"
        CType(Me.dgvpetugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbIdPetugas As TextBox
    Friend WithEvents tbNamaPetugas As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents rbnonaktif As RadioButton
    Friend WithEvents rbaktif As RadioButton
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnbaru As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents tbdate As DateTimePicker
    Friend WithEvents dgvpetugas As DataGridView
    Friend WithEvents kdptgs As TextBox
    Friend WithEvents tbusia As TextBox
    Friend WithEvents tbtlp As TextBox
    Friend WithEvents tbalmt As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
End Class
