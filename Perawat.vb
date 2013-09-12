'ini tes untuk melihat modifikasi via GIT :P
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Image
Imports System.IO
Public Class Perawat
    Dim CoonStr As String = "Data Source=YOGIADIGUNA;Initial Catalog=REKAMMEDIS;Integrated Security=True"
    Dim Conn As SqlConnection
    Dim eksekusi As New SqlCommand
    Dim SQL As String
    Dim RecCount As Integer
    Dim memoryStream As MemoryStream
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New REKAMMEDISDataSet()


    Private Sub Perawat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BSave.Enabled = False
        BEdit.Enabled = False
        BDelete.Enabled = False
        'Non()
        Dim Conn As SqlConnection
        Dim Ds As DataSet
        Dim Da As SqlDataAdapter
        Dim SQL As String = "Select * From Perawat"

        Try
            Conn = New SqlConnection(CoonStr)
            Ds = New DataSet
            Da = New SqlDataAdapter(SQL, Conn)
            Da.Fill(Ds, "Perawat")
            DataGridView1.DataSource = Ds.Tables("Perawat")
        Catch
            MessageBox.Show("Tabel tidak dapat ditampilkan ... ", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub FormAktif()
        TNama.Enabled = True
        TJenis.Enabled = True
        TTempat.Enabled = True
        TTanggal.Enabled = True
        TAlamat.Enabled = True
        TStatus.Enabled = True
    End Sub
    Private Sub FormKosong()
        TId.Text = ""
        TNama.Text = ""
        TJenis.Text = ""
        TTempat.Text = ""
        TTanggal.Text = ""
        TAlamat.Text = ""
        TStatus.Text = ""
    End Sub

    Private Sub Non()
        TNama.Enabled = False
        TJenis.Enabled = False
        TTempat.Enabled = False
        TTanggal.Enabled = False
        TAlamat.Enabled = False
        TStatus.Enabled = False
    End Sub

    Private Sub BNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNew.Click
        TId.Enabled = False
        BSave.Enabled = True
        Conn = New SqlConnection(CoonStr)
        Dim Kode As String
        FormAktif()
        FormKosong()
        BBrowse.Enabled = True
        Try
            Dim daperawat As SqlDataAdapter = New SqlDataAdapter("select id_perawat from perawat", Conn)
            Dim dtperawat As New DataTable
            Me.DataGridView1.SendToBack()
            dtperawat.Clear()
            daperawat.Fill(dtperawat)
            Me.BindingContext(dtperawat).Position = Me.BindingContext(dtperawat).Count + 1
            'Mengosongkan selain TNomor untuk autonumber pasien
            'tapi petama harus dilepas bindingnya
            TId.DataBindings.Add("text", dtperawat, "id_perawat")
            'TNomor.Text = 10000
            If TId.Text = Nothing Then
                TId.Text = 2200000000
                'Else
            End If
            'TNomor.Text = Val(Right(TNomor.Text, 4))
            TId.Text += 1
            TId.DataBindings.Clear()

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
            Me.TNama.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub

    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        Conn = New SqlConnection(CoonStr)
        Try
            If (Me.TId.Text = Nothing) Or (Me.TNama.Text = Nothing) Or (Me.TJenis.Text = Nothing) Or (Me.TTempat.Text = Nothing) Or (Me.TTanggal.Text = Nothing) Or _
                (Me.TAlamat.Text = Nothing) Or (Me.TStatus.Text = Nothing) Or (Me.TLokasi.Text = Nothing) Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation, "Error")

            Else
                eksekusi.Connection = Conn
                eksekusi.CommandText = "Insert into perawat values('" & TId.Text & "','" & TNama.Text & "','" & TJenis.Text & "', '" & TTempat.Text & "','" & TTanggal.Value.ToString & _
                "','" & TAlamat.Text & "','" & TStatus.Text & "','" & TLokasi.Text & "')"

                eksekusi.CommandType = CommandType.Text
                myDA.SelectCommand = eksekusi

                'Ds = New DataSet
                'da = New SqlDataAdapter(SQL, Conn)
                myDA.Fill(MyDS, "perawat")
                'DataGridView1.DataSource = Ds.Tables("Pasien2")
                DataGridView1.Refresh()
                MsgBox("Data Tersimpan")
            End If
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEdit.Click
        TId.Enabled = False
        FormAktif()
        Conn = New SqlConnection(CoonStr)
        Try
            Dim StrSql As String
            Dim Cmd As SqlCommand


            StrSql = "Update perawat "
            StrSql += "Set nama ='" & TNama.Text & "',"
            StrSql += "jenis_kel = '" & TJenis.Text & "',"
            StrSql += "tmp_lahir = '" & TTempat.Text & "',"
            StrSql += "tgl_lahir = '" & TTanggal.Value.ToString & "',"
            StrSql += "alamat = '" & TAlamat.Text & "',"
            StrSql += "Status_per = '" & TStatus.Text & "',"
            StrSql += "ft = '" & TLokasi.Text & "' "
            StrSql += "where id_perawat = '" & TId.Text & "'"

            Cmd = New SqlCommand(StrSql)
            Cmd.Connection = Conn
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
            MsgBox("Anda telah selesai mengedit perawat dengan Id Perawat " & TId.Text, MsgBoxStyle.Information, "Perhatian")
            Me.BRefresh.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian ")
        End Try
    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        Conn = New SqlConnection(CoonStr)
        Try
            If Len(TNama.Text) = 0 Then
                MsgBox("Tidak Ada Data Yang Akan Dihapus", MsgBoxStyle.Information, "Perhatian")
                Exit Sub
            Else
                Dim strSql As String
                Dim cmd As SqlCommand
                Dim a As Int16
                a = MsgBox("Apakah anda yakin ingin menghapus data Perawat " & TNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                Select Case a
                    Case vbCancel
                        Exit Sub
                    Case vbOK
                        strSql = "Delete From perawat where id_perawat = '" & TId.Text & "'"
                        cmd = New SqlCommand(strSql)
                        cmd.Connection = Conn
                        Conn.Open()
                        cmd.ExecuteNonQuery()
                        Conn.Close()
                        MsgBox("Perawat dengan Nomor id " & TId.Text & " dan Nama : " & TNama.Text & " telah terhapus", MsgBoxStyle.Information, "Informasi")
                        Me.BRefresh.PerformClick()

                End Select

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")

        End Try
    End Sub

    Private Sub BCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCari.Click
        TId.Enabled = True
        Conn = New SqlConnection(CoonStr)
        Try
            Dim dtperawat As New DataTable
            Dim daperawat As SqlDataAdapter
            daperawat = New SqlDataAdapter("Select * from perawat where id_perawat = '" & TId.Text & "' ", Conn)
            dtperawat.Clear()
            daperawat.Fill(dtperawat)
            If dtperawat.Rows.Count = Nothing Then
                MsgBox("Tidak ada data", MsgBoxStyle.Information, "Perhatian")
                TId.Text = DataGridView1.CurrentCell.ToString
                Exit Sub
            Else
                databinding(dtperawat)
                Call lepas()
                Me.DataGridView1.DataSource = dtperawat
                Me.BSave.Enabled = False
                Me.BEdit.Enabled = True
                Me.BDelete.Enabled = True
                'Me.BNew.Enabled = False
                Me.DataGridView1.SendToBack()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")

        End Try
    End Sub

    Private Sub lepas()
        TId.DataBindings.Clear()
        TNama.DataBindings.Clear()
        TJenis.DataBindings.Clear()
        TTempat.DataBindings.Clear()
        TTanggal.DataBindings.Clear()
        TAlamat.DataBindings.Clear()
        TStatus.DataBindings.Clear()
    End Sub

    Private Sub databinding(ByVal dtperawat)
        TId.DataBindings.Add("Text", dtperawat, "id_perawat")
        TNama.DataBindings.Add("Text", dtperawat, "nama")
        TJenis.DataBindings.Add("Text", dtperawat, "jenis_kel")
        TTempat.DataBindings.Add("Text", dtperawat, "tgl_lahir")
        TTanggal.DataBindings.Add("Text", dtperawat, "tgl_lahir")
        TAlamat.DataBindings.Add("Text", dtperawat, "alamat")
        TStatus.DataBindings.Add("Text", dtperawat, "status_per")
    End Sub

    Private Sub BRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefresh.Click
        TId.Enabled = True
        'RekamMedisDataset1.Tables("no_rm").NewRow
        'RekammedisDataSet1.Tables("no_rm")
        Conn = New SqlConnection(CoonStr)
        Try
            Me.DataGridView1.BringToFront()
            Dim daperawat As SqlDataAdapter = New SqlDataAdapter("Select * From perawat", Conn)
            Dim dtperawat As New DataTable
            dtperawat.Clear()
            daperawat.Fill(dtperawat)
            Me.DataGridView1.DataSource = dtperawat

            FormKosong()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        BSave.Enabled = False
        BEdit.Enabled = True
        BDelete.Enabled = True
        With DataGridView1
            Dim baris As Integer
            'baris keberapa yg diklik?  
            baris = .CurrentRow.Index()
            'isikan data ke isian  
            TId.Text = .Item(0, baris).Value
            TNama.Text = .Item(1, baris).Value
            TJenis.Text = .Item(2, baris).Value
            TTempat.Text = .Item(3, baris).Value
            TTanggal.Text = .Item(4, baris).Value
            TAlamat.Text = .Item(5, baris).Value
            TStatus.Text = .Item(6, baris).Value
            TLokasi.Text = .Item(7, baris).Value
        End With
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

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TLokasi.Text = OpenFileDialog1.FileName
            Dim gambar = Image.FromFile(Me.TLokasi.Text)
            Me.foto.Image = gambar
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class