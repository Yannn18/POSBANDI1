<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuKetuaRTRW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuKetuaRTRW))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnManajemenPetugas = New System.Windows.Forms.Button()
        Me.btnMnjJadwal = New System.Windows.Forms.Button()
        Me.btnSesiLayanan = New System.Windows.Forms.Button()
        Me.btnLaporanUtm = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnKembaliMU = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 101)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POSBANDI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "-Pos Bantuan Digital-"
        '
        'btnManajemenPetugas
        '
        Me.btnManajemenPetugas.Location = New System.Drawing.Point(42, 152)
        Me.btnManajemenPetugas.Name = "btnManajemenPetugas"
        Me.btnManajemenPetugas.Size = New System.Drawing.Size(163, 37)
        Me.btnManajemenPetugas.TabIndex = 2
        Me.btnManajemenPetugas.Text = "Manajemen Petugas"
        Me.btnManajemenPetugas.UseVisualStyleBackColor = True
        '
        'btnMnjJadwal
        '
        Me.btnMnjJadwal.Location = New System.Drawing.Point(42, 219)
        Me.btnMnjJadwal.Name = "btnMnjJadwal"
        Me.btnMnjJadwal.Size = New System.Drawing.Size(163, 37)
        Me.btnMnjJadwal.TabIndex = 3
        Me.btnMnjJadwal.Text = "Manajemen Jadwal "
        Me.btnMnjJadwal.UseVisualStyleBackColor = True
        '
        'btnSesiLayanan
        '
        Me.btnSesiLayanan.Location = New System.Drawing.Point(42, 282)
        Me.btnSesiLayanan.Name = "btnSesiLayanan"
        Me.btnSesiLayanan.Size = New System.Drawing.Size(163, 37)
        Me.btnSesiLayanan.TabIndex = 4
        Me.btnSesiLayanan.Text = "Sesi Layanan"
        Me.btnSesiLayanan.UseVisualStyleBackColor = True
        '
        'btnLaporanUtm
        '
        Me.btnLaporanUtm.Location = New System.Drawing.Point(42, 350)
        Me.btnLaporanUtm.Name = "btnLaporanUtm"
        Me.btnLaporanUtm.Size = New System.Drawing.Size(163, 37)
        Me.btnLaporanUtm.TabIndex = 6
        Me.btnLaporanUtm.Text = "Laporan"
        Me.btnLaporanUtm.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(344, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 422)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnKembaliMU
        '
        Me.btnKembaliMU.Location = New System.Drawing.Point(42, 574)
        Me.btnKembaliMU.Name = "btnKembaliMU"
        Me.btnKembaliMU.Size = New System.Drawing.Size(163, 31)
        Me.btnKembaliMU.TabIndex = 8
        Me.btnKembaliMU.Text = "Kembali"
        Me.btnKembaliMU.UseVisualStyleBackColor = True
        '
        'MenuKetuaRTRW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 665)
        Me.Controls.Add(Me.btnKembaliMU)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLaporanUtm)
        Me.Controls.Add(Me.btnSesiLayanan)
        Me.Controls.Add(Me.btnMnjJadwal)
        Me.Controls.Add(Me.btnManajemenPetugas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuKetuaRTRW"
        Me.Text = "FormMenuUtama"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnManajemenPetugas As Button
    Friend WithEvents btnMnjJadwal As Button
    Friend WithEvents btnSesiLayanan As Button
    Friend WithEvents btnLaporanUtm As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKembaliMU As Button
End Class
