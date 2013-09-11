<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RawatJalan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RawatJalan))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TTanggal = New System.Windows.Forms.DateTimePicker
        Me.LabelTangal = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TJenis = New System.Windows.Forms.ComboBox
        Me.BMain = New System.Windows.Forms.Button
        Me.BSAve = New System.Windows.Forms.Button
        Me.BNew = New System.Windows.Forms.Button
        Me.TTherapi = New System.Windows.Forms.TextBox
        Me.TKomplikasi = New System.Windows.Forms.TextBox
        Me.TDSkunder = New System.Windows.Forms.TextBox
        Me.TDUtama = New System.Windows.Forms.TextBox
        Me.TUmur = New System.Windows.Forms.TextBox
        Me.TNama = New System.Windows.Forms.TextBox
        Me.TRM = New System.Windows.Forms.TextBox
        Me.TKunjungan = New System.Windows.Forms.TextBox
        Me.TTanggalKun = New System.Windows.Forms.DateTimePicker
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TNamaDokter = New System.Windows.Forms.TextBox
        Me.bcari = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(1, 519)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(803, 34)
        Me.Panel3.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.bcari)
        Me.Panel2.Controls.Add(Me.TNamaDokter)
        Me.Panel2.Controls.Add(Me.TTanggal)
        Me.Panel2.Controls.Add(Me.LabelTangal)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.TJenis)
        Me.Panel2.Controls.Add(Me.BMain)
        Me.Panel2.Controls.Add(Me.BSAve)
        Me.Panel2.Controls.Add(Me.BNew)
        Me.Panel2.Controls.Add(Me.TTherapi)
        Me.Panel2.Controls.Add(Me.TKomplikasi)
        Me.Panel2.Controls.Add(Me.TDSkunder)
        Me.Panel2.Controls.Add(Me.TDUtama)
        Me.Panel2.Controls.Add(Me.TUmur)
        Me.Panel2.Controls.Add(Me.TNama)
        Me.Panel2.Controls.Add(Me.TRM)
        Me.Panel2.Controls.Add(Me.TKunjungan)
        Me.Panel2.Controls.Add(Me.TTanggalKun)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 379)
        Me.Panel2.TabIndex = 1
        '
        'TTanggal
        '
        Me.TTanggal.Enabled = False
        Me.TTanggal.Location = New System.Drawing.Point(177, 149)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(333, 20)
        Me.TTanggal.TabIndex = 60
        '
        'LabelTangal
        '
        Me.LabelTangal.AutoSize = True
        Me.LabelTangal.BackColor = System.Drawing.Color.Transparent
        Me.LabelTangal.Location = New System.Drawing.Point(51, 151)
        Me.LabelTangal.Name = "LabelTangal"
        Me.LabelTangal.Size = New System.Drawing.Size(72, 13)
        Me.LabelTangal.TabIndex = 59
        Me.LabelTangal.Text = "Tanggal Lahir"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(516, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 150)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'TJenis
        '
        Me.TJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TJenis.FormattingEnabled = True
        Me.TJenis.Items.AddRange(New Object() {"Non bedah", "Bedah", "Kesehatan anak", "Kebidanan", "Bayi"})
        Me.TJenis.Location = New System.Drawing.Point(176, 198)
        Me.TJenis.Name = "TJenis"
        Me.TJenis.Size = New System.Drawing.Size(334, 21)
        Me.TJenis.TabIndex = 56
        '
        'BMain
        '
        Me.BMain.Location = New System.Drawing.Point(664, 349)
        Me.BMain.Name = "BMain"
        Me.BMain.Size = New System.Drawing.Size(75, 23)
        Me.BMain.TabIndex = 49
        Me.BMain.Text = "menu Utama"
        Me.BMain.UseVisualStyleBackColor = True
        '
        'BSAve
        '
        Me.BSAve.Location = New System.Drawing.Point(127, 349)
        Me.BSAve.Name = "BSAve"
        Me.BSAve.Size = New System.Drawing.Size(75, 23)
        Me.BSAve.TabIndex = 46
        Me.BSAve.Text = "save"
        Me.BSAve.UseVisualStyleBackColor = True
        '
        'BNew
        '
        Me.BNew.Location = New System.Drawing.Point(46, 349)
        Me.BNew.Name = "BNew"
        Me.BNew.Size = New System.Drawing.Size(75, 23)
        Me.BNew.TabIndex = 45
        Me.BNew.Text = "new"
        Me.BNew.UseVisualStyleBackColor = True
        '
        'TTherapi
        '
        Me.TTherapi.Location = New System.Drawing.Point(176, 297)
        Me.TTherapi.MaxLength = 50
        Me.TTherapi.Name = "TTherapi"
        Me.TTherapi.Size = New System.Drawing.Size(563, 20)
        Me.TTherapi.TabIndex = 43
        '
        'TKomplikasi
        '
        Me.TKomplikasi.Location = New System.Drawing.Point(176, 272)
        Me.TKomplikasi.MaxLength = 50
        Me.TKomplikasi.Name = "TKomplikasi"
        Me.TKomplikasi.Size = New System.Drawing.Size(563, 20)
        Me.TKomplikasi.TabIndex = 42
        '
        'TDSkunder
        '
        Me.TDSkunder.Location = New System.Drawing.Point(176, 247)
        Me.TDSkunder.MaxLength = 50
        Me.TDSkunder.Name = "TDSkunder"
        Me.TDSkunder.Size = New System.Drawing.Size(563, 20)
        Me.TDSkunder.TabIndex = 41
        '
        'TDUtama
        '
        Me.TDUtama.Location = New System.Drawing.Point(176, 223)
        Me.TDUtama.MaxLength = 50
        Me.TDUtama.Name = "TDUtama"
        Me.TDUtama.Size = New System.Drawing.Size(563, 20)
        Me.TDUtama.TabIndex = 40
        '
        'TUmur
        '
        Me.TUmur.Enabled = False
        Me.TUmur.Location = New System.Drawing.Point(176, 174)
        Me.TUmur.Name = "TUmur"
        Me.TUmur.Size = New System.Drawing.Size(334, 20)
        Me.TUmur.TabIndex = 30
        '
        'TNama
        '
        Me.TNama.Enabled = False
        Me.TNama.Location = New System.Drawing.Point(176, 123)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(334, 20)
        Me.TNama.TabIndex = 26
        '
        'TRM
        '
        Me.TRM.Location = New System.Drawing.Point(176, 76)
        Me.TRM.MaxLength = 10
        Me.TRM.Name = "TRM"
        Me.TRM.Size = New System.Drawing.Size(334, 20)
        Me.TRM.TabIndex = 25
        '
        'TKunjungan
        '
        Me.TKunjungan.Enabled = False
        Me.TKunjungan.Location = New System.Drawing.Point(176, 53)
        Me.TKunjungan.Name = "TKunjungan"
        Me.TKunjungan.Size = New System.Drawing.Size(334, 20)
        Me.TKunjungan.TabIndex = 24
        '
        'TTanggalKun
        '
        Me.TTanggalKun.Location = New System.Drawing.Point(176, 100)
        Me.TTanggalKun.Name = "TTanggalKun"
        Me.TTanggalKun.Size = New System.Drawing.Size(334, 20)
        Me.TTanggalKun.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(49, 325)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Nama Dokter"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(45, 300)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(119, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Therapi Yang Diberikan"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(49, 279)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Komplikasi"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(49, 255)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Diagnosa Skunder"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(49, 233)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Diagnosa Utama"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(51, 208)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Jenis Pelayanan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(51, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Umur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(51, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(51, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Kunjungan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(51, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Rekam Medis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(51, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Kunjungan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(328, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rawat Jalan"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 140)
        Me.Panel1.TabIndex = 0
        '
        'TNamaDokter
        '
        Me.TNamaDokter.Enabled = False
        Me.TNamaDokter.Location = New System.Drawing.Point(175, 324)
        Me.TNamaDokter.Name = "TNamaDokter"
        Me.TNamaDokter.Size = New System.Drawing.Size(269, 20)
        Me.TNamaDokter.TabIndex = 61
        '
        'bcari
        '
        Me.bcari.Location = New System.Drawing.Point(449, 323)
        Me.bcari.Name = "bcari"
        Me.bcari.Size = New System.Drawing.Size(75, 23)
        Me.bcari.TabIndex = 62
        Me.bcari.Text = "cari"
        Me.bcari.UseVisualStyleBackColor = True
        '
        'RawatJalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 551)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RawatJalan"
        Me.Text = "Form13"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TUmur As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TRM As System.Windows.Forms.TextBox
    Friend WithEvents TKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents TTanggalKun As System.Windows.Forms.DateTimePicker
    Friend WithEvents TTherapi As System.Windows.Forms.TextBox
    Friend WithEvents TKomplikasi As System.Windows.Forms.TextBox
    Friend WithEvents TDSkunder As System.Windows.Forms.TextBox
    Friend WithEvents TDUtama As System.Windows.Forms.TextBox
    Friend WithEvents BMain As System.Windows.Forms.Button
    Friend WithEvents BSAve As System.Windows.Forms.Button
    Friend WithEvents BNew As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TJenis As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelTangal As System.Windows.Forms.Label
    Friend WithEvents bcari As System.Windows.Forms.Button
    Friend WithEvents TNamaDokter As System.Windows.Forms.TextBox
End Class
