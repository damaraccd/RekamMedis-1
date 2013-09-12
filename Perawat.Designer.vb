<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perawat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perawat))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BRefresh = New System.Windows.Forms.Button
        Me.BCari = New System.Windows.Forms.Button
        Me.BNew = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button5 = New System.Windows.Forms.Button
        Me.BBrowse = New System.Windows.Forms.Button
        Me.BDelete = New System.Windows.Forms.Button
        Me.BEdit = New System.Windows.Forms.Button
        Me.BSave = New System.Windows.Forms.Button
        Me.foto = New System.Windows.Forms.PictureBox
        Me.TTanggal = New System.Windows.Forms.DateTimePicker
        Me.TStatus = New System.Windows.Forms.ComboBox
        Me.TJenis = New System.Windows.Forms.ComboBox
        Me.TAlamat = New System.Windows.Forms.TextBox
        Me.TTempat = New System.Windows.Forms.TextBox
        Me.TNama = New System.Windows.Forms.TextBox
        Me.TId = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RekammedisDataSet1 = New ProV.REKAMMEDISDataSet
        Me.TLokasi = New System.Windows.Forms.TextBox
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RekammedisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(0, 522)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(803, 45)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.TLokasi)
        Me.Panel2.Controls.Add(Me.BRefresh)
        Me.Panel2.Controls.Add(Me.BCari)
        Me.Panel2.Controls.Add(Me.BNew)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.BBrowse)
        Me.Panel2.Controls.Add(Me.BDelete)
        Me.Panel2.Controls.Add(Me.BEdit)
        Me.Panel2.Controls.Add(Me.BSave)
        Me.Panel2.Controls.Add(Me.foto)
        Me.Panel2.Controls.Add(Me.TTanggal)
        Me.Panel2.Controls.Add(Me.TStatus)
        Me.Panel2.Controls.Add(Me.TJenis)
        Me.Panel2.Controls.Add(Me.TAlamat)
        Me.Panel2.Controls.Add(Me.TTempat)
        Me.Panel2.Controls.Add(Me.TNama)
        Me.Panel2.Controls.Add(Me.TId)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 381)
        Me.Panel2.TabIndex = 1
        '
        'BRefresh
        '
        Me.BRefresh.Location = New System.Drawing.Point(435, 153)
        Me.BRefresh.Name = "BRefresh"
        Me.BRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BRefresh.TabIndex = 25
        Me.BRefresh.Text = "refresh"
        Me.BRefresh.UseVisualStyleBackColor = True
        '
        'BCari
        '
        Me.BCari.Location = New System.Drawing.Point(354, 153)
        Me.BCari.Name = "BCari"
        Me.BCari.Size = New System.Drawing.Size(75, 23)
        Me.BCari.TabIndex = 24
        Me.BCari.Text = "cari"
        Me.BCari.UseVisualStyleBackColor = True
        '
        'BNew
        '
        Me.BNew.Location = New System.Drawing.Point(30, 153)
        Me.BNew.Name = "BNew"
        Me.BNew.Size = New System.Drawing.Size(75, 23)
        Me.BNew.TabIndex = 23
        Me.BNew.Text = "new"
        Me.BNew.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.Location = New System.Drawing.Point(32, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 150)
        Me.DataGridView1.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(693, 349)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BBrowse
        '
        Me.BBrowse.Location = New System.Drawing.Point(696, 153)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BBrowse.TabIndex = 20
        Me.BBrowse.Text = "browse foto"
        Me.BBrowse.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Location = New System.Drawing.Point(273, 153)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(75, 23)
        Me.BDelete.TabIndex = 19
        Me.BDelete.Text = "delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BEdit
        '
        Me.BEdit.Location = New System.Drawing.Point(192, 153)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(75, 23)
        Me.BEdit.TabIndex = 18
        Me.BEdit.Text = "edit"
        Me.BEdit.UseVisualStyleBackColor = True
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(111, 153)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(75, 23)
        Me.BSave.TabIndex = 17
        Me.BSave.Text = "save"
        Me.BSave.UseVisualStyleBackColor = True
        '
        'foto
        '
        Me.foto.Location = New System.Drawing.Point(693, 52)
        Me.foto.Name = "foto"
        Me.foto.Size = New System.Drawing.Size(80, 90)
        Me.foto.TabIndex = 16
        Me.foto.TabStop = False
        '
        'TTanggal
        '
        Me.TTanggal.Location = New System.Drawing.Point(440, 51)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(230, 20)
        Me.TTanggal.TabIndex = 14
        '
        'TStatus
        '
        Me.TStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TStatus.FormattingEnabled = True
        Me.TStatus.Items.AddRange(New Object() {"Kawin", "Tidak Kawin", "Duda", "Janda"})
        Me.TStatus.Location = New System.Drawing.Point(439, 97)
        Me.TStatus.Name = "TStatus"
        Me.TStatus.Size = New System.Drawing.Size(231, 21)
        Me.TStatus.TabIndex = 13
        '
        'TJenis
        '
        Me.TJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TJenis.FormattingEnabled = True
        Me.TJenis.Items.AddRange(New Object() {"laki - laki", "perempuan"})
        Me.TJenis.Location = New System.Drawing.Point(102, 94)
        Me.TJenis.Name = "TJenis"
        Me.TJenis.Size = New System.Drawing.Size(238, 21)
        Me.TJenis.TabIndex = 12
        '
        'TAlamat
        '
        Me.TAlamat.Location = New System.Drawing.Point(439, 74)
        Me.TAlamat.MaxLength = 50
        Me.TAlamat.Name = "TAlamat"
        Me.TAlamat.Size = New System.Drawing.Size(231, 20)
        Me.TAlamat.TabIndex = 11
        '
        'TTempat
        '
        Me.TTempat.Location = New System.Drawing.Point(102, 118)
        Me.TTempat.MaxLength = 30
        Me.TTempat.Name = "TTempat"
        Me.TTempat.Size = New System.Drawing.Size(238, 20)
        Me.TTempat.TabIndex = 10
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(102, 71)
        Me.TNama.MaxLength = 20
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(238, 20)
        Me.TNama.TabIndex = 9
        '
        'TId
        '
        Me.TId.Location = New System.Drawing.Point(102, 48)
        Me.TId.Name = "TId"
        Me.TId.Size = New System.Drawing.Size(238, 20)
        Me.TId.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(361, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(361, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(361, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(29, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(27, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(29, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(29, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id perawat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(337, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Perawat"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 141)
        Me.Panel1.TabIndex = 0
        '
        'RekammedisDataSet1
        '
        Me.RekammedisDataSet1.DataSetName = "REKAMMEDISDataSet"
        Me.RekammedisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TLokasi
        '
        Me.TLokasi.Location = New System.Drawing.Point(531, 155)
        Me.TLokasi.Name = "TLokasi"
        Me.TLokasi.Size = New System.Drawing.Size(100, 20)
        Me.TLokasi.TabIndex = 26
        Me.TLokasi.Visible = False
        '
        'Perawat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 553)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Perawat"
        Me.Text = "Form19"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RekammedisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents foto As System.Windows.Forms.PictureBox
    Friend WithEvents TTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents TStatus As System.Windows.Forms.ComboBox
    Friend WithEvents TJenis As System.Windows.Forms.ComboBox
    Friend WithEvents TAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TTempat As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TId As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BBrowse As System.Windows.Forms.Button
    Friend WithEvents BDelete As System.Windows.Forms.Button
    Friend WithEvents BEdit As System.Windows.Forms.Button
    Friend WithEvents BSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BNew As System.Windows.Forms.Button
    Friend WithEvents BRefresh As System.Windows.Forms.Button
    Friend WithEvents BCari As System.Windows.Forms.Button
    Friend WithEvents RekammedisDataSet1 As ProV.REKAMMEDISDataSet
    Friend WithEvents TLokasi As System.Windows.Forms.TextBox
End Class
