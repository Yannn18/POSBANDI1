<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlaporan
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
        Me.dtpmulai = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpselesai = New System.Windows.Forms.DateTimePicker()
        Me.btntampilkan = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.dgvlaporan = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvhistory = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvlaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvhistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode Laporan"
        '
        'dtpmulai
        '
        Me.dtpmulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpmulai.Location = New System.Drawing.Point(389, 146)
        Me.dtpmulai.Name = "dtpmulai"
        Me.dtpmulai.Size = New System.Drawing.Size(92, 22)
        Me.dtpmulai.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(509, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "s/d"
        '
        'dtpselesai
        '
        Me.dtpselesai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpselesai.Location = New System.Drawing.Point(559, 146)
        Me.dtpselesai.Name = "dtpselesai"
        Me.dtpselesai.Size = New System.Drawing.Size(92, 22)
        Me.dtpselesai.TabIndex = 1
        '
        'btntampilkan
        '
        Me.btntampilkan.Location = New System.Drawing.Point(248, 7)
        Me.btntampilkan.Name = "btntampilkan"
        Me.btntampilkan.Size = New System.Drawing.Size(168, 30)
        Me.btntampilkan.TabIndex = 2
        Me.btntampilkan.Text = "Tampilkan Data"
        Me.btntampilkan.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(444, 7)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(168, 30)
        Me.btncetak.TabIndex = 2
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'dgvlaporan
        '
        Me.dgvlaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlaporan.Location = New System.Drawing.Point(150, 275)
        Me.dgvlaporan.Name = "dgvlaporan"
        Me.dgvlaporan.ReadOnly = True
        Me.dgvlaporan.RowHeadersWidth = 51
        Me.dgvlaporan.RowTemplate.Height = 24
        Me.dgvlaporan.Size = New System.Drawing.Size(330, 250)
        Me.dgvlaporan.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Riwayat Cetak Laporan"
        '
        'dgvhistory
        '
        Me.dgvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhistory.Location = New System.Drawing.Point(546, 275)
        Me.dgvhistory.Name = "dgvhistory"
        Me.dgvhistory.RowHeadersWidth = 51
        Me.dgvhistory.RowTemplate.Height = 24
        Me.dgvhistory.Size = New System.Drawing.Size(337, 250)
        Me.dgvhistory.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(-3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1065, 44)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btntampilkan)
        Me.Panel1.Controls.Add(Me.btncetak)
        Me.Panel1.Location = New System.Drawing.Point(-6, 576)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 44)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(466, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Laporan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Formlaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1052, 665)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpselesai)
        Me.Controls.Add(Me.dgvhistory)
        Me.Controls.Add(Me.dgvlaporan)
        Me.Controls.Add(Me.dtpmulai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Formlaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formlaporan"
        CType(Me.dgvlaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvhistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpmulai As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpselesai As DateTimePicker
    Friend WithEvents btntampilkan As Button
    Friend WithEvents btncetak As Button
    Friend WithEvents dgvlaporan As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvhistory As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
