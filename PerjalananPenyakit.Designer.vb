<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerjalananPenyakit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PerjalananPenyakit))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.per = New System.Windows.Forms.TextBox
        Me.RM = New System.Windows.Forms.TextBox
        Me.MP = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.RInap = New System.Windows.Forms.Button
        Me.BSave = New System.Windows.Forms.Button
        Me.TTanggal = New System.Windows.Forms.DateTimePicker
        Me.TPengobatan = New System.Windows.Forms.TextBox
        Me.TPerawat = New System.Windows.Forms.TextBox
        Me.TKeadaan = New System.Windows.Forms.TextBox
        Me.TJam = New System.Windows.Forms.TextBox
        Me.TNomor = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(0, 368)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(806, 36)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.per)
        Me.Panel2.Controls.Add(Me.RM)
        Me.Panel2.Controls.Add(Me.MP)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.RInap)
        Me.Panel2.Controls.Add(Me.BSave)
        Me.Panel2.Controls.Add(Me.TTanggal)
        Me.Panel2.Controls.Add(Me.TPengobatan)
        Me.Panel2.Controls.Add(Me.TPerawat)
        Me.Panel2.Controls.Add(Me.TKeadaan)
        Me.Panel2.Controls.Add(Me.TJam)
        Me.Panel2.Controls.Add(Me.TNomor)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 140)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 229)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'per
        '
        Me.per.Location = New System.Drawing.Point(569, 190)
        Me.per.Name = "per"
        Me.per.Size = New System.Drawing.Size(100, 20)
        Me.per.TabIndex = 20
        Me.per.Visible = False
        '
        'RM
        '
        Me.RM.Location = New System.Drawing.Point(438, 190)
        Me.RM.Name = "RM"
        Me.RM.Size = New System.Drawing.Size(100, 20)
        Me.RM.TabIndex = 19
        Me.RM.Visible = False
        '
        'MP
        '
        Me.MP.Location = New System.Drawing.Point(317, 189)
        Me.MP.Name = "MP"
        Me.MP.Size = New System.Drawing.Size(100, 20)
        Me.MP.TabIndex = 18
        Me.MP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(434, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(249, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Perjalanan Penyakit Pasien"
        '
        'RInap
        '
        Me.RInap.Location = New System.Drawing.Point(702, 186)
        Me.RInap.Name = "RInap"
        Me.RInap.Size = New System.Drawing.Size(75, 23)
        Me.RInap.TabIndex = 16
        Me.RInap.Text = "kembali"
        Me.RInap.UseVisualStyleBackColor = True
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(28, 186)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(75, 23)
        Me.BSave.TabIndex = 13
        Me.BSave.Text = "save"
        Me.BSave.UseVisualStyleBackColor = True
        '
        'TTanggal
        '
        Me.TTanggal.Enabled = False
        Me.TTanggal.Location = New System.Drawing.Point(129, 49)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(200, 20)
        Me.TTanggal.TabIndex = 12
        '
        'TPengobatan
        '
        Me.TPengobatan.Location = New System.Drawing.Point(129, 125)
        Me.TPengobatan.MaxLength = 100
        Me.TPengobatan.Name = "TPengobatan"
        Me.TPengobatan.Size = New System.Drawing.Size(648, 20)
        Me.TPengobatan.TabIndex = 11
        '
        'TPerawat
        '
        Me.TPerawat.Enabled = False
        Me.TPerawat.Location = New System.Drawing.Point(129, 151)
        Me.TPerawat.Name = "TPerawat"
        Me.TPerawat.Size = New System.Drawing.Size(200, 20)
        Me.TPerawat.TabIndex = 10
        '
        'TKeadaan
        '
        Me.TKeadaan.Location = New System.Drawing.Point(129, 99)
        Me.TKeadaan.MaxLength = 100
        Me.TKeadaan.Name = "TKeadaan"
        Me.TKeadaan.Size = New System.Drawing.Size(648, 20)
        Me.TKeadaan.TabIndex = 9
        '
        'TJam
        '
        Me.TJam.Location = New System.Drawing.Point(129, 74)
        Me.TJam.MaxLength = 10
        Me.TJam.Name = "TJam"
        Me.TJam.Size = New System.Drawing.Size(200, 20)
        Me.TJam.TabIndex = 8
        '
        'TNomor
        '
        Me.TNomor.Enabled = False
        Me.TNomor.Location = New System.Drawing.Point(129, 23)
        Me.TNomor.Name = "TNomor"
        Me.TNomor.Size = New System.Drawing.Size(200, 20)
        Me.TNomor.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(26, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Id Perawat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(26, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pengobatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(26, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Keadaan Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(26, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 140)
        Me.Panel1.TabIndex = 0
        '
        'PerjalananPenyakit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 397)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PerjalananPenyakit"
        Me.Text = "Form4"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BSave As System.Windows.Forms.Button
    Friend WithEvents TTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents TPengobatan As System.Windows.Forms.TextBox
    Friend WithEvents TPerawat As System.Windows.Forms.TextBox
    Friend WithEvents TKeadaan As System.Windows.Forms.TextBox
    Friend WithEvents TJam As System.Windows.Forms.TextBox
    Friend WithEvents TNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RInap As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MP As System.Windows.Forms.TextBox
    Friend WithEvents RM As System.Windows.Forms.TextBox
    Friend WithEvents per As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
