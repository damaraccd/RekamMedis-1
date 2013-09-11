Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Image
Imports System.IO
Public Class DaftarRI
    Dim CoonStr As String = "Data Source=YOGIADIGUNA;Initial Catalog=REKAMMEDIS;Integrated Security=True"
    Dim Conn As SqlConnection
    Dim eksekusi As New SqlCommand
    Dim SQL As String
    Dim RecCount As Integer
    Dim memoryStream As MemoryStream
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New REKAMMEDISDataSet()

    Private Sub DaftarRI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BSave.Enabled = False
        Dim Conn As SqlConnection
        Dim Ds As DataSet
        Dim Da As SqlDataAdapter
        Dim SQL As String = "Select * From RI3"

        Try
            Conn = New SqlConnection(CoonStr)
            Ds = New DataSet
            Da = New SqlDataAdapter(SQL, Conn)
            Da.Fill(Ds, "RI3")
            'DataGridView1.DataSource = Ds.Tables("Pasien2")
        Catch
            'MessageBox.Show("Tabel tidak dapat ditampilkan ... ", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub FormAktif()
        TRM.Enabled = True
        TKM.Enabled = True
        TNama.Enabled = True
        TJEnis.Enabled = True
        TGolongan.Enabled = True
        TTanggal.Enabled = True
        TUmur.Enabled = True
        TAlamat.Enabled = True
        TKecamatan.Enabled = True
        TKabupaten.Enabled = True
        TPropinsi.Enabled = True
        TBangsa.Enabled = True
        TAgama.Enabled = True
        TStatus.Enabled = True
        TCara.Enabled = True
        TPekerjaan.Enabled = True
        TPelayanan.Enabled = True
        TKirim.Enabled = True
        TDokter.Enabled = True
        TDiagnosa.Enabled = True
    End Sub
    Private Sub FormKosong()
        TRM.Text = ""
        TKM.Text = ""
        TNama.Text = ""
        TJEnis.Text = ""
        TGolongan.Text = ""
        TTanggal.Text = ""
        TUmur.Text = ""
        TAlamat.Text = ""
        TKecamatan.Text = ""
        TKabupaten.Text = ""
        TPropinsi.Text = ""
        TBangsa.Text = ""
        TAgama.Text = ""
        TStatus.Text = ""
        TCara.Text = ""
        TPekerjaan.Text = ""
        TPelayanan.Text = ""
        TKirim.Text = ""
        TDokter.Text = ""
        TDiagnosa.Text = ""
    End Sub

    Private Sub Non()
        TRM.Enabled = False
        TKM.Enabled = False
        TNama.Enabled = False
        TJEnis.Enabled = False
        TGolongan.Enabled = False
        TTanggal.Enabled = False
        TUmur.Enabled = False
        TAlamat.Enabled = False
        TKecamatan.Enabled = False
        TKabupaten.Enabled = False
        TPropinsi.Enabled = False
        TBangsa.Enabled = False
        TAgama.Enabled = False
        TStatus.Enabled = False
        TCara.Enabled = False
        TPekerjaan.Enabled = False
        TPelayanan.Enabled = False
        TKirim.Enabled = False
        TDokter.Enabled = False
        TDiagnosa.Enabled = False
    End Sub


    Private Sub TNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNew.Click
        TRI.Enabled = False
        BSave.Enabled = True
        Conn = New SqlConnection(CoonStr)
        'Dim Kode As String
        'FormAktif()
        FormKosong()
        Try
            Dim daRI As SqlDataAdapter = New SqlDataAdapter("select no_ri from RI3", Conn)
            Dim dtRI As New DataTable
            'Me.DataGridView1.SendToBack()
            dtRI.Clear()
            daRI.Fill(dtRI)
            Me.BindingContext(dtRI).Position = Me.BindingContext(dtRI).Count + 1
            'Mengosongkan selain TNomor untuk autonumber pasien
            'tapi petama harus dilepas bindingnya
            TRI.DataBindings.Add("text", dtRI, "no_ri")
            'TNomor.Text = 10000
            If TRI.Text = Nothing Then
                TRI.Text = 8800000000
                'Else
            End If
            'TNomor.Text = Val(Right(TNomor.Text, 4))
            TRI.Text += 1
            TRI.DataBindings.Clear()
            
            'Me.Button1.Visible = False
            'If Val(TNomor.Text) < 10 Then
            'TNomor.Text = "RM000" & TNomor.Text
            'ElseIf Val(TNomor.Text) < 100 Then
            'TNomor.Text = "RM00" & TNomor.Text
            'ElseIf Val(TNomor.Text < 1000) Then
            'TNomor.Text = "RM0" & TNomor.Text
            'ElseIf Val(TNomor.Text < 10000) Then
            'TNomor.Text = "RM" & TNomor.Text
            'Else
            'MsgBox("Kapasistas Pasien Tidak Memadai", MsgBoxStyle.Information)

            'End If
            'Me.TNama.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub


    Private Sub lepas()
        TRI.DataBindings.Clear()
    End Sub

    Private Sub databinding(ByVal dtpasien)
        TRI.DataBindings.Add("Text", dtpasien, "no_ri")
    End Sub

    Private Sub TRM_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TRM.KeyUp
        Conn = New SqlConnection(CoonStr)
        Conn.Open()
        Dim cmd As SqlCommand
        TNama.Text = ""
        TJenis.Text = ""
        TGolongan.Text = ""
        TTanggal.Text = ""
        TAlamat.Text = ""
        TKecamatan.Text = ""
        TKabupaten.Text = ""
        TPropinsi.Text = ""
        TBangsa.Text = ""
        TAgama.Text = ""
        TStatus.Text = ""
        TPekerjaan.Text = ""
        Dim st As String = "Select * from Pasien2 where no_rm = '" + TRM.Text.Trim + "'"
        cmd = New SqlCommand(st, Conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            TNama.Text = dr(1).ToString
            TJenis.Text = dr(2).ToString
            TGolongan.Text = dr(14).ToString
            TTanggal.Value = dr(4)
            TAlamat.Text = dr(10).ToString
            TKecamatan.Text = dr(11).ToString
            TKabupaten.Text = dr(12).ToString
            TPropinsi.Text = dr(13).ToString
            TBangsa.Text = dr(7).ToString
            TAgama.Text = dr(5).ToString
            TStatus.Text = dr(6).ToString
            TPekerjaan.Text = dr(8).ToString
            TLokasi.Text = dr(15).ToString
        End While
        Dim tahun As Long
        Dim skrg As Date = Now
        Dim lhr As Date = TTanggal.Value
        tahun = DateDiff(DateInterval.Year, lhr, skrg)
        TUmur.Text = tahun.ToString
        dr.Close()

    End Sub

    Private Sub TCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCari.Click
        TabelDokter.Show()
    End Sub

    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        Conn = New SqlConnection(CoonStr)
        Try
            If (Me.TRI.Text = Nothing) Or (Me.TRM.Text = Nothing) Or (Me.TKM.Text = Nothing) Or (Me.TUmur.Text = Nothing) Or (Me.TCara.Text = Nothing) Or _
                (Me.TPelayanan.Text = Nothing) Or (Me.TKirim.Text = Nothing) Or (Me.TDokter.Text = Nothing) Or (Me.TDiagnosa.Text = Nothing) Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation, "Error")

            Else
                eksekusi.Connection = Conn
                eksekusi.CommandText = "Insert into RI3 values('" & TRI.Text & "','" & TRM.Text & "','" & TKM.Text & "', '" & TUmur.Text & "','" & TCara.Text & "','" & TJenis.Text & _
                "','" & TKirim.Text & "','" & TDokter.Text & "','" & TDiagnosa.Text & "','" & TMasuk.Value.ToString & "')"

                eksekusi.CommandType = CommandType.Text
                myDA.SelectCommand = eksekusi

                'Ds = New DataSet
                'da = New SqlDataAdapter(SQL, Conn)
                myDA.Fill(MyDS, "RI3")
                'DataGridView1.DataSource = Ds.Tables("Pasien2")
                'DataGridView1.Refresh()
                MsgBox("Data Tersimpan")
                BSave.Enabled = False
            End If
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGo.Click
        TabelKamar.Show()
    End Sub

    Private Sub BRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tabel_Pasien.Show()
    End Sub

    Private Sub TLokasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLokasi.TextChanged
        Try
            If Me.TLokasi.Text = "" Then
                Me.foto.CreateGraphics.Clear(Color.Aqua)
                Exit Sub
            End If
            Me.foto.Image = Image.FromFile(Me.TLokasi.Text)
        Catch ex As Exception
            Me.foto.CreateGraphics.Clear(Color.Aqua)

        End Try
    End Sub

    Private Sub TMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMain.Click
        MRI.Show()
        Me.Hide()
    End Sub
End Class