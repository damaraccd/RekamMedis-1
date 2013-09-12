<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dokter
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dokter))
        Me.RekammedisDataSet1 = New ProV.REKAMMEDISDataSet
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TLokasi = New System.Windows.Forms.TextBox
        Me.BRefresh = New System.Windows.Forms.Button
        Me.BNew = New System.Windows.Forms.Button
        Me.TStatus = New System.Windows.Forms.ComboBox
        Me.TJenis = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BCari = New System.Windows.Forms.Button
        Me.BMain = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.BDelete = New System.Windows.Forms.Button
        Me.BEdit = New System.Windows.Forms.Button
        Me.BSave = New System.Windows.Forms.Button
        Me.foto = New System.Windows.Forms.PictureBox
        Me.TTanggal = New System.Windows.Forms.DateTimePicker
        Me.TAlamat = New System.Windows.Forms.TextBox
        Me.TSpesialis = New System.Windows.Forms.TextBox
        Me.TTempat = New System.Windows.Forms.TextBox
        Me.TNama = New System.Windows.Forms.TextBox
        Me.TId = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.RekammedisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RekammedisDataSet1
        '
        Me.RekammedisDataSet1.DataSetName = "REKAMMEDISDataSet"
        Me.RekammedisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(1, 550)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(804, 44)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.TLokasi)
        Me.Panel2.Controls.Add(Me.BRefresh)
        Me.Panel2.Controls.Add(Me.BNew)
        Me.Panel2.Controls.Add(Me.TStatus)
        Me.Panel2.Controls.Add(Me.TJenis)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.BCari)
        Me.Panel2.Controls.Add(Me.BMain)
        Me.Panel2.Controls.Add(Me.btnStart)
        Me.Panel2.Controls.Add(Me.BDelete)
        Me.Panel2.Controls.Add(Me.BEdit)
        Me.Panel2.Controls.Add(Me.BSave)
        Me.Panel2.Controls.Add(Me.foto)
        Me.Panel2.Controls.Add(Me.TTanggal)
        Me.Panel2.Controls.Add(Me.TAlamat)
        Me.Panel2.Controls.Add(Me.TSpesialis)
        Me.Panel2.Controls.Add(Me.TTempat)
        Me.Panel2.Controls.Add(Me.TNama)
        Me.Panel2.Controls.Add(Me.TId)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 407)
        Me.Panel2.TabIndex = 1
        '
        'TLokasi
        '
        Me.TLokasi.Location = New System.Drawing.Point(539, 171)
        Me.TLokasi.Name = "TLokasi"
        Me.TLokasi.Size = New System.Drawing.Size(135, 20)
        Me.TLokasi.TabIndex = 29
        Me.TLokasi.Visible = False
        '
        'BRefresh
        '
        Me.BRefresh.Location = New System.Drawing.Point(448, 169)
        Me.BRefresh.Name = "BRefresh"
        Me.BRefresh.Size = New System.Drawing.Size(87, 23)
        Me.BRefresh.TabIndex = 28
        Me.BRefresh.Text = "refresh"
        Me.BRefresh.UseVisualStyleBackColor = True
        '
        'BNew
        '
        Me.BNew.Location = New System.Drawing.Point(41, 169)
        Me.BNew.Name = "BNew"
        Me.BNew.Size = New System.Drawing.Size(75, 23)
        Me.BNew.TabIndex = 27
        Me.BNew.Text = "New"
        Me.BNew.UseVisualStyleBackColor = True
        '
        'TStatus
        '
        Me.TStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TStatus.FormattingEnabled = True
        Me.TStatus.Items.AddRange(New Object() {"dokter tetap", "dokter kontrak"})
        Me.TStatus.Location = New System.Drawing.Point(439, 133)
        Me.TStatus.Name = "TStatus"
        Me.TStatus.Size = New System.Drawing.Size(200, 21)
        Me.TStatus.TabIndex = 26
        '
        'TJenis
        '
        Me.TJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TJenis.FormattingEnabled = True
        Me.TJenis.Items.AddRange(New Object() {"laki - laki", "perempuan"})
        Me.TJenis.Location = New System.Drawing.Point(121, 111)
        Me.TJenis.Name = "TJenis"
        Me.TJenis.Size = New System.Drawing.Size(195, 21)
        Me.TJenis.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.Location = New System.Drawing.Point(41, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(722, 150)
        Me.DataGridView1.TabIndex = 24
        '
        'BCari
        '
        Me.BCari.Location = New System.Drawing.Point(365, 169)
        Me.BCari.Name = "BCari"
        Me.BCari.Size = New System.Drawing.Size(75, 23)
        Me.BCari.TabIndex = 23
        Me.BCari.Text = "cari"
        Me.BCari.UseVisualStyleBackColor = True
        '
        'BMain
        '
        Me.BMain.Location = New System.Drawing.Point(674, 372)
        Me.BMain.Name = "BMain"
        Me.BMain.Size = New System.Drawing.Size(87, 23)
        Me.BMain.TabIndex = 22
        Me.BMain.Text = "Menu"
        Me.BMain.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(680, 169)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(81, 23)
        Me.btnStart.TabIndex = 21
        Me.btnStart.Text = "browse foto"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Location = New System.Drawing.Point(284, 169)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(75, 23)
        Me.BDelete.TabIndex = 20
        Me.BDelete.Text = "delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BEdit
        '
        Me.BEdit.Location = New System.Drawing.Point(203, 169)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(75, 23)
        Me.BEdit.TabIndex = 19
        Me.BEdit.Text = "edit"
        Me.BEdit.UseVisualStyleBackColor = True
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(122, 169)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(75, 23)
        Me.BSave.TabIndex = 18
        Me.BSave.Text = "save"
        Me.BSave.UseVisualStyleBackColor = True
        '
        'foto
        '
        Me.foto.Location = New System.Drawing.Point(682, 61)
        Me.foto.Name = "foto"
        Me.foto.Size = New System.Drawing.Size(81, 90)
        Me.foto.TabIndex = 17
        Me.foto.TabStop = False
        '
        'TTanggal
        '
        Me.TTanggal.Location = New System.Drawing.Point(439, 60)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(200, 20)
        Me.TTanggal.TabIndex = 16
        '
        'TAlamat
        '
        Me.TAlamat.Location = New System.Drawing.Point(439, 107)
        Me.TAlamat.MaxLength = 50
        Me.TAlamat.Name = "TAlamat"
        Me.TAlamat.Size = New System.Drawing.Size(200, 20)
        Me.TAlamat.TabIndex = 14
        '
        'TSpesialis
        '
        Me.TSpesialis.Location = New System.Drawing.Point(439, 83)
        Me.TSpesialis.MaxLength = 20
        Me.TSpesialis.Name = "TSpesialis"
        Me.TSpesialis.Size = New System.Drawing.Size(200, 20)
        Me.TSpesialis.TabIndex = 13
        '
        'TTempat
        '
        Me.TTempat.Location = New System.Drawing.Point(121, 135)
        Me.TTempat.MaxLength = 30
        Me.TTempat.Name = "TTempat"
        Me.TTempat.Size = New System.Drawing.Size(195, 20)
        Me.TTempat.TabIndex = 12
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(121, 87)
        Me.TNama.MaxLength = 20
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(195, 20)
        Me.TNama.TabIndex = 10
        '
        'TId
        '
        Me.TId.Enabled = False
        Me.TId.Location = New System.Drawing.Point(121, 61)
        Me.TId.Name = "TId"
        Me.TId.Size = New System.Drawing.Size(195, 20)
        Me.TId.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(364, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(362, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(362, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Spesialis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(362, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tangal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(41, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(41, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(41, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(41, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "id dokter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(336, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Dokter"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 143)
        Me.Panel1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 591)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dokter"
        Me.Text = "Form Dokter"
        CType(Me.RekammedisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TSpesialis As System.Windows.Forms.TextBox
    Friend WithEvents TTempat As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TId As System.Windows.Forms.TextBox
    Friend WithEvents foto As System.Windows.Forms.PictureBox
    Friend WithEvents TTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents BCari As System.Windows.Forms.Button
    Friend WithEvents BMain As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents BDelete As System.Windows.Forms.Button
    Friend WithEvents BEdit As System.Windows.Forms.Button
    Friend WithEvents BSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TStatus As System.Windows.Forms.ComboBox
    Friend WithEvents TJenis As System.Windows.Forms.ComboBox
    Friend WithEvents BNew As System.Windows.Forms.Button
    Friend WithEvents RekammedisDataSet1 As ProV.REKAMMEDISDataSet
    Friend WithEvents BRefresh As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TLokasi As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
