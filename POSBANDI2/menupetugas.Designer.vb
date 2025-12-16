<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menupetugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menupetugas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnKembaliMU = New System.Windows.Forms.Button()
        Me.btnSesiLayanan = New System.Windows.Forms.Button()
        Me.btnMnjJadwal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(350, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 422)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnKembaliMU
        '
        Me.btnKembaliMU.Location = New System.Drawing.Point(53, 610)
        Me.btnKembaliMU.Name = "btnKembaliMU"
        Me.btnKembaliMU.Size = New System.Drawing.Size(163, 25)
        Me.btnKembaliMU.TabIndex = 13
        Me.btnKembaliMU.Text = "Kembali"
        Me.btnKembaliMU.UseVisualStyleBackColor = True
        '
        'btnSesiLayanan
        '
        Me.btnSesiLayanan.Location = New System.Drawing.Point(40, 190)
        Me.btnSesiLayanan.Name = "btnSesiLayanan"
        Me.btnSesiLayanan.Size = New System.Drawing.Size(187, 37)
        Me.btnSesiLayanan.TabIndex = 11
        Me.btnSesiLayanan.Text = "Sesi Layanan"
        Me.btnSesiLayanan.UseVisualStyleBackColor = True
        '
        'btnMnjJadwal
        '
        Me.btnMnjJadwal.Location = New System.Drawing.Point(40, 132)
        Me.btnMnjJadwal.Name = "btnMnjJadwal"
        Me.btnMnjJadwal.Size = New System.Drawing.Size(187, 37)
        Me.btnMnjJadwal.TabIndex = 10
        Me.btnMnjJadwal.Text = "Data Masyarakat "
        Me.btnMnjJadwal.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMnjJadwal)
        Me.Panel1.Controls.Add(Me.btnSesiLayanan)
        Me.Panel1.Controls.Add(Me.btnKembaliMU)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 659)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(54, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Menu Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(566, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "-Pos Bantuan Digital-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(362, 101)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "POSBANDI"
        '
        'menupetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1052, 665)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "menupetugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menupetugas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKembaliMU As Button
    Friend WithEvents btnSesiLayanan As Button
    Friend WithEvents btnMnjJadwal As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
