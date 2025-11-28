<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSesiLayanan
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.tbKodeSesi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbNIK = New System.Windows.Forms.ComboBox()
        Me.tbNamaWarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbLayanan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbPetugas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCatatanLyn = New System.Windows.Forms.TextBox()
        Me.btnMulaiSesi = New System.Windows.Forms.Button()
        Me.btnSelesaiSesi = New System.Windows.Forms.Button()
        Me.btnClearLyn = New System.Windows.Forms.Button()
        Me.btnKembaliLyn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Sesi"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Location = New System.Drawing.Point(528, 33)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(45, 16)
        Me.lblWaktu.TabIndex = 1
        Me.lblWaktu.Text = "Waktu"
        '
        'tbKodeSesi
        '
        Me.tbKodeSesi.Location = New System.Drawing.Point(156, 33)
        Me.tbKodeSesi.Name = "tbKodeSesi"
        Me.tbKodeSesi.ReadOnly = True
        Me.tbKodeSesi.Size = New System.Drawing.Size(158, 22)
        Me.tbKodeSesi.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NIK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Warga"
        '
        'cbNIK
        '
        Me.cbNIK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNIK.FormattingEnabled = True
        Me.cbNIK.Location = New System.Drawing.Point(156, 72)
        Me.cbNIK.Name = "cbNIK"
        Me.cbNIK.Size = New System.Drawing.Size(219, 24)
        Me.cbNIK.TabIndex = 5
        '
        'tbNamaWarga
        '
        Me.tbNamaWarga.Location = New System.Drawing.Point(531, 74)
        Me.tbNamaWarga.Name = "tbNamaWarga"
        Me.tbNamaWarga.ReadOnly = True
        Me.tbNamaWarga.Size = New System.Drawing.Size(219, 22)
        Me.tbNamaWarga.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Layanan"
        '
        'cbLayanan
        '
        Me.cbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLayanan.FormattingEnabled = True
        Me.cbLayanan.Location = New System.Drawing.Point(156, 121)
        Me.cbLayanan.Name = "cbLayanan"
        Me.cbLayanan.Size = New System.Drawing.Size(219, 24)
        Me.cbLayanan.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Petugas"
        '
        'cbPetugas
        '
        Me.cbPetugas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPetugas.FormattingEnabled = True
        Me.cbPetugas.Location = New System.Drawing.Point(156, 164)
        Me.cbPetugas.Name = "cbPetugas"
        Me.cbPetugas.Size = New System.Drawing.Size(121, 24)
        Me.cbPetugas.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(153, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Catatan Layanan"
        '
        'tbCatatanLyn
        '
        Me.tbCatatanLyn.Location = New System.Drawing.Point(156, 241)
        Me.tbCatatanLyn.Multiline = True
        Me.tbCatatanLyn.Name = "tbCatatanLyn"
        Me.tbCatatanLyn.Size = New System.Drawing.Size(594, 86)
        Me.tbCatatanLyn.TabIndex = 12
        '
        'btnMulaiSesi
        '
        Me.btnMulaiSesi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMulaiSesi.Location = New System.Drawing.Point(156, 368)
        Me.btnMulaiSesi.Name = "btnMulaiSesi"
        Me.btnMulaiSesi.Size = New System.Drawing.Size(98, 37)
        Me.btnMulaiSesi.TabIndex = 13
        Me.btnMulaiSesi.Text = "Mulai Sesi"
        Me.btnMulaiSesi.UseVisualStyleBackColor = False
        '
        'btnSelesaiSesi
        '
        Me.btnSelesaiSesi.BackColor = System.Drawing.Color.IndianRed
        Me.btnSelesaiSesi.Location = New System.Drawing.Point(277, 368)
        Me.btnSelesaiSesi.Name = "btnSelesaiSesi"
        Me.btnSelesaiSesi.Size = New System.Drawing.Size(86, 37)
        Me.btnSelesaiSesi.TabIndex = 14
        Me.btnSelesaiSesi.Text = "Selesai"
        Me.btnSelesaiSesi.UseVisualStyleBackColor = False
        '
        'btnClearLyn
        '
        Me.btnClearLyn.Location = New System.Drawing.Point(390, 368)
        Me.btnClearLyn.Name = "btnClearLyn"
        Me.btnClearLyn.Size = New System.Drawing.Size(75, 37)
        Me.btnClearLyn.TabIndex = 15
        Me.btnClearLyn.Text = "Clear"
        Me.btnClearLyn.UseVisualStyleBackColor = True
        '
        'btnKembaliLyn
        '
        Me.btnKembaliLyn.Location = New System.Drawing.Point(675, 368)
        Me.btnKembaliLyn.Name = "btnKembaliLyn"
        Me.btnKembaliLyn.Size = New System.Drawing.Size(75, 37)
        Me.btnKembaliLyn.TabIndex = 16
        Me.btnKembaliLyn.Text = "Kembali"
        Me.btnKembaliLyn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(578, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormSesiLayanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKembaliLyn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClearLyn)
        Me.Controls.Add(Me.btnSelesaiSesi)
        Me.Controls.Add(Me.btnMulaiSesi)
        Me.Controls.Add(Me.tbCatatanLyn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbPetugas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbLayanan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNamaWarga)
        Me.Controls.Add(Me.cbNIK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbKodeSesi)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSesiLayanan"
        Me.Text = "FormSesiLayanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblWaktu As Label
    Friend WithEvents tbKodeSesi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbNIK As ComboBox
    Friend WithEvents tbNamaWarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbLayanan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbPetugas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCatatanLyn As TextBox
    Friend WithEvents btnMulaiSesi As Button
    Friend WithEvents btnSelesaiSesi As Button
    Friend WithEvents btnClearLyn As Button
    Friend WithEvents btnKembaliLyn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
