<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManajemenJadwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvjadwal = New System.Windows.Forms.DataGridView()
        Me.btnupdt = New System.Windows.Forms.Button()
        Me.btnhps = New System.Windows.Forms.Button()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.btnsmpn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbketerangan = New System.Windows.Forms.TextBox()
        Me.tblokasi = New System.Windows.Forms.TextBox()
        Me.tbtanggal = New System.Windows.Forms.DateTimePicker()
        Me.tbjammulai = New System.Windows.Forms.DateTimePicker()
        Me.tbjamselesai = New System.Windows.Forms.DateTimePicker()
        Me.cbpetugas = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvjadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvjadwal
        '
        Me.dgvjadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjadwal.Location = New System.Drawing.Point(235, 336)
        Me.dgvjadwal.Name = "dgvjadwal"
        Me.dgvjadwal.RowHeadersWidth = 51
        Me.dgvjadwal.RowTemplate.Height = 24
        Me.dgvjadwal.Size = New System.Drawing.Size(637, 262)
        Me.dgvjadwal.TabIndex = 20
        '
        'btnupdt
        '
        Me.btnupdt.Location = New System.Drawing.Point(563, 273)
        Me.btnupdt.Name = "btnupdt"
        Me.btnupdt.Size = New System.Drawing.Size(75, 23)
        Me.btnupdt.TabIndex = 19
        Me.btnupdt.Text = "Update"
        Me.btnupdt.UseVisualStyleBackColor = True
        '
        'btnhps
        '
        Me.btnhps.Location = New System.Drawing.Point(658, 273)
        Me.btnhps.Name = "btnhps"
        Me.btnhps.Size = New System.Drawing.Size(75, 23)
        Me.btnhps.TabIndex = 18
        Me.btnhps.Text = "Hapus"
        Me.btnhps.UseVisualStyleBackColor = True
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(466, 273)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(75, 23)
        Me.btbaru.TabIndex = 17
        Me.btbaru.Text = "Baru"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'btnsmpn
        '
        Me.btnsmpn.Location = New System.Drawing.Point(372, 273)
        Me.btnsmpn.Name = "btnsmpn"
        Me.btnsmpn.Size = New System.Drawing.Size(75, 23)
        Me.btnsmpn.TabIndex = 16
        Me.btnsmpn.Text = "Simpan"
        Me.btnsmpn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(611, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Keterangan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(630, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Petugas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Jam Selesai"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(239, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Jam Mulai"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(239, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Lokasi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(239, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tanggal"
        '
        'tbketerangan
        '
        Me.tbketerangan.Location = New System.Drawing.Point(708, 146)
        Me.tbketerangan.Name = "tbketerangan"
        Me.tbketerangan.Size = New System.Drawing.Size(158, 22)
        Me.tbketerangan.TabIndex = 6
        '
        'tblokasi
        '
        Me.tblokasi.Location = New System.Drawing.Point(341, 135)
        Me.tblokasi.Name = "tblokasi"
        Me.tblokasi.Size = New System.Drawing.Size(200, 22)
        Me.tblokasi.TabIndex = 9
        '
        'tbtanggal
        '
        Me.tbtanggal.Location = New System.Drawing.Point(341, 96)
        Me.tbtanggal.Name = "tbtanggal"
        Me.tbtanggal.Size = New System.Drawing.Size(200, 22)
        Me.tbtanggal.TabIndex = 21
        '
        'tbjammulai
        '
        Me.tbjammulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tbjammulai.Location = New System.Drawing.Point(341, 168)
        Me.tbjammulai.Name = "tbjammulai"
        Me.tbjammulai.ShowUpDown = True
        Me.tbjammulai.Size = New System.Drawing.Size(200, 22)
        Me.tbjammulai.TabIndex = 21
        '
        'tbjamselesai
        '
        Me.tbjamselesai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tbjamselesai.Location = New System.Drawing.Point(341, 206)
        Me.tbjamselesai.Name = "tbjamselesai"
        Me.tbjamselesai.ShowUpDown = True
        Me.tbjamselesai.Size = New System.Drawing.Size(200, 22)
        Me.tbjamselesai.TabIndex = 21
        '
        'cbpetugas
        '
        Me.cbpetugas.FormattingEnabled = True
        Me.cbpetugas.Location = New System.Drawing.Point(708, 105)
        Me.cbpetugas.Name = "cbpetugas"
        Me.cbpetugas.Size = New System.Drawing.Size(158, 24)
        Me.cbpetugas.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(940, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(430, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 29)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Manajemen Jadwal"
        '
        'ManajemenJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1052, 665)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbpetugas)
        Me.Controls.Add(Me.tbjamselesai)
        Me.Controls.Add(Me.tbjammulai)
        Me.Controls.Add(Me.tbtanggal)
        Me.Controls.Add(Me.dgvjadwal)
        Me.Controls.Add(Me.btnupdt)
        Me.Controls.Add(Me.btnhps)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.btnsmpn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbketerangan)
        Me.Controls.Add(Me.tblokasi)
        Me.Name = "ManajemenJadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManajemenJadwal"
        CType(Me.dgvjadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvjadwal As DataGridView
    Friend WithEvents btnupdt As Button
    Friend WithEvents btnhps As Button
    Friend WithEvents btbaru As Button
    Friend WithEvents btnsmpn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbketerangan As TextBox
    Friend WithEvents tblokasi As TextBox
    Friend WithEvents tbtanggal As DateTimePicker
    Friend WithEvents tbjammulai As DateTimePicker
    Friend WithEvents tbjamselesai As DateTimePicker
    Friend WithEvents cbpetugas As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
