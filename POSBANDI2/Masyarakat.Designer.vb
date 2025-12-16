<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masyarakat
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
        Me.tbnik = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbtempatlahir = New System.Windows.Forms.TextBox()
        Me.tbtanggallahir = New System.Windows.Forms.DateTimePicker()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.tbalamat = New System.Windows.Forms.RichTextBox()
        Me.tbtelp = New System.Windows.Forms.TextBox()
        Me.btnKembaliMU = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbnik
        '
        Me.tbnik.Location = New System.Drawing.Point(185, 69)
        Me.tbnik.Name = "tbnik"
        Me.tbnik.Size = New System.Drawing.Size(214, 22)
        Me.tbnik.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(437, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(437, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Alamat "
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(459, 279)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 2
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(540, 279)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 2
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(621, 279)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 2
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(58, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(653, 208)
        Me.DataGridView1.TabIndex = 3
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(185, 109)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(214, 22)
        Me.tbnama.TabIndex = 0
        '
        'tbtempatlahir
        '
        Me.tbtempatlahir.Location = New System.Drawing.Point(185, 145)
        Me.tbtempatlahir.Name = "tbtempatlahir"
        Me.tbtempatlahir.Size = New System.Drawing.Size(214, 22)
        Me.tbtempatlahir.TabIndex = 0
        '
        'tbtanggallahir
        '
        Me.tbtanggallahir.Location = New System.Drawing.Point(185, 180)
        Me.tbtanggallahir.Name = "tbtanggallahir"
        Me.tbtanggallahir.Size = New System.Drawing.Size(214, 22)
        Me.tbtanggallahir.TabIndex = 4
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(567, 69)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(88, 20)
        Me.rblaki.TabIndex = 5
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki - Laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(567, 95)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(98, 20)
        Me.rbperempuan.TabIndex = 5
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(441, 168)
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(255, 86)
        Me.tbalamat.TabIndex = 6
        Me.tbalamat.Text = ""
        '
        'tbtelp
        '
        Me.tbtelp.Location = New System.Drawing.Point(185, 217)
        Me.tbtelp.Name = "tbtelp"
        Me.tbtelp.Size = New System.Drawing.Size(214, 22)
        Me.tbtelp.TabIndex = 0
        '
        'btnKembaliMU
        '
        Me.btnKembaliMU.Location = New System.Drawing.Point(58, 600)
        Me.btnKembaliMU.Name = "btnKembaliMU"
        Me.btnKembaliMU.Size = New System.Drawing.Size(163, 31)
        Me.btnKembaliMU.TabIndex = 14
        Me.btnKembaliMU.Text = "Kembali"
        Me.btnKembaliMU.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Heavy", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 29)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Manajemen Warga"
        '
        'Masyarakat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(877, 693)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnKembaliMU)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.rbperempuan)
        Me.Controls.Add(Me.rblaki)
        Me.Controls.Add(Me.tbtanggallahir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbtelp)
        Me.Controls.Add(Me.tbtempatlahir)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.tbnik)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Masyarakat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Masyarakat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbnik As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbnama As TextBox
    Friend WithEvents tbtempatlahir As TextBox
    Friend WithEvents tbtanggallahir As DateTimePicker
    Friend WithEvents rblaki As RadioButton
    Friend WithEvents rbperempuan As RadioButton
    Friend WithEvents tbalamat As RichTextBox
    Friend WithEvents tbtelp As TextBox
    Friend WithEvents btnKembaliMU As Button
    Friend WithEvents Label8 As Label
End Class
