Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Image
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Dokter
    Inherits System.Windows.Forms.Form
    Dim CoonStr As String = "Data Source=YOGIADIGUNA;Initial Catalog=REKAMMEDIS;Integrated Security=True"
    Dim Conn As SqlConnection
    Dim eksekusi As New SqlCommand
    Dim SQL As String
    Dim RecCount As Integer
    Dim memoryStream As MemoryStream
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New REKAMMEDISDataSet()
    Dim dt As New DataTable

    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean


    Private Sub Dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BEdit.Enabled = False
        BDelete.Enabled = False
        BSave.Enabled = False

        'btnStop.Enabled = False
        'Non()
        Dim Conn As SqlConnection
        Dim Ds As DataSet
        Dim Da As SqlDataAdapter
        Dim SQL As String = "Select * From Dokter"

        Try
            Conn = New SqlConnection(CoonStr)
            Ds = New DataSet
            Da = New SqlDataAdapter(SQL, Conn)
            Da.Fill(Ds, "Dokter")
            DataGridView1.DataSource = Ds.Tables("Dokter")
        Catch
            MessageBox.Show("Tabel tidak dapat ditampilkan ... ", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    
    Private Sub kaitbinding()
        Me.TId.DataBindings.Add("text", dt, "id_dokter")
        Me.TNama.DataBindings.Add("text", dt, "nama")
        Me.TJenis.DataBindings.Add("text", dt, "jenis_kel")
        Me.TTempat.DataBindings.Add("text", dt, "tmp_lahir")
        Me.TTanggal.DataBindings.Add("text", dt, "tgl_lahir")
        Me.TSpesialis.DataBindings.Add("Text", dt, "spesialis")
        Me.TAlamat.DataBindings.Add("Text", dt, "alamat")
        Me.TStatus.DataBindings.Add("Text", dt, "status_perk")
        Me.TId.DataBindings.Clear()
        Me.TNama.DataBindings.Clear()
        Me.TJenis.DataBindings.Clear()
        Me.TTempat.DataBindings.Clear()
        Me.TTanggal.DataBindings.Clear()
        Me.TSpesialis.DataBindings.Clear()
        Me.TAlamat.DataBindings.Clear()
        Me.TStatus.DataBindings.Clear()
        Me.TLokasi.Clear()
        Me.TLokasi.DataBindings.Add("text", dt, "ft")
        Me.TLokasi.DataBindings.Clear()
        If Me.TLokasi.Text = "" Then
            Me.Foto.CreateGraphics.Clear(Color.Aqua)
            Exit Sub
        End If
        Me.Foto.Image = Image.FromFile(Me.TLokasi.Text)
    End Sub

    Private Sub FormAktif()
        TNama.Enabled = True
        TJenis.Enabled = True
        TTempat.Enabled = True
        TTanggal.Enabled = True
        TSpesialis.Enabled = True
        TAlamat.Enabled = True
        TStatus.Enabled = True
    End Sub
    Private Sub FormKosong()
        TId.Text = ""
        TNama.Text = ""
        TJenis.Text = ""
        TTempat.Text = ""
        TTanggal.Text = ""
        TSpesialis.Text = ""
        TAlamat.Text = ""
        TStatus.Text = ""
        TLokasi.Clear()
    End Sub

    Private Sub Non()
        TNama.Enabled = False
        TJenis.Enabled = False
        TTempat.Enabled = False
        TTanggal.Enabled = False
        TSpesialis.Enabled = False
        TAlamat.Enabled = False
        TStatus.Enabled = False
    End Sub
    Private Sub BNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNew.Click
        TId.Enabled = False
        BSave.Enabled = True
        Conn = New SqlConnection(CoonStr)
        FormAktif()
        FormKosong()
        btnStart.Enabled = True
        Try
            Dim dadokter As SqlDataAdapter = New SqlDataAdapter("select id_dokter from dokter", Conn)
            Dim dtdokter As New DataTable
            Me.DataGridView1.SendToBack()
            dtdokter.Clear()
            dadokter.Fill(dtdokter)
            Me.BindingContext(dtdokter).Position = Me.BindingContext(dtdokter).Count + 1
            'Mengosongkan selain TNomor untuk autonumber pasien
            'tapi petama harus dilepas bindingnya
            TId.DataBindings.Add("text", dtdokter, "id_dokter")
            'TNomor.Text = 10000
            If TId.Text = Nothing Then
                TId.Text = 1100000000
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
                (Me.TSpesialis.Text = Nothing) Or (Me.TAlamat.Text = Nothing) Or (Me.TStatus.Text = Nothing) Or (Me.TLokasi.Text = Nothing) Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation, "Error")

            Else
                eksekusi.Connection = Conn
                eksekusi.CommandText = "Insert into dokter values('" & TId.Text & "','" & TNama.Text & "','" & TJenis.Text & "', '" & TTempat.Text & "','" & TTanggal.Value.ToString & _
                "','" & TSpesialis.Text & "','" & TAlamat.Text & "','" & TStatus.Text & "','" & TLokasi.Text & "')"

                eksekusi.CommandType = CommandType.Text
                myDA.SelectCommand = eksekusi

                'Ds = New DataSet
                'da = New SqlDataAdapter(SQL, Conn)
                myDA.Fill(MyDS, "Dokter")
                'DataGridView1.DataSource = Ds.Tables("Pasien2")
                DataGridView1.Refresh()
                MsgBox("Data Tersimpan")
            End If

            BSave.Enabled = False
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


            StrSql = "Update dokter "
            StrSql += "Set nama ='" & TNama.Text & "',"
            StrSql += "jenis_kel = '" & TJenis.Text & "',"
            StrSql += "tmp_lahir = '" & TTempat.Text & "',"
            StrSql += "tgl_lahir = '" & TTanggal.Value.ToString & "',"
            StrSql += "spesialis = '" & TSpesialis.Text & "',"
            StrSql += "alamat = '" & TAlamat.Text & "',"
            StrSql += "Status_perk = '" & TStatus.Text & "',"
            StrSql += "ft = '" & TLokasi.Text & "' "
            StrSql += "where id_dokter = '" & TId.Text & "'"

            Cmd = New SqlCommand(StrSql)
            Cmd.Connection = Conn
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
            MsgBox("Anda telah selesai mengedit dokter dengan No ID " & TId.Text, MsgBoxStyle.Information, "Perhatian")
            Me.BRefresh.PerformClick()
            BEdit.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian ")
        End Try

    End Sub

    Private Sub BRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefresh.Click
        TId.Enabled = True
        'RekamMedisDataset1.Tables("no_rm").NewRow
        'RekammedisDataSet1.Tables("no_rm")
        Conn = New SqlConnection(CoonStr)
        Try
            Me.DataGridView1.BringToFront()
            Dim dadokter As SqlDataAdapter = New SqlDataAdapter("Select * From Dokter", Conn)
            Dim dtdokter As New DataTable
            dtdokter.Clear()
            dadokter.Fill(dtdokter)
            Me.DataGridView1.DataSource = dtdokter

            FormKosong()

        Catch ex As Exception

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
                a = MsgBox("Apakah anda yakin ingin menghapus data dokter " & TNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                Select Case a
                    Case vbCancel
                        Exit Sub
                    Case vbOK
                        strSql = "Delete From dokter where id_dokter = '" & TId.Text & "'"
                        cmd = New SqlCommand(strSql)
                        cmd.Connection = Conn
                        Conn.Open()
                        cmd.ExecuteNonQuery()
                        Conn.Close()
                        MsgBox("Dokter dengan Nomor id " & TId.Text & " dan Nama : " & TNama.Text & " telah terhapus", MsgBoxStyle.Information, "Informasi")
                        Me.BRefresh.PerformClick()
                        BDelete.Enabled = False
                End Select

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")

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
            TSpesialis.Text = .Item(5, baris).Value
            TAlamat.Text = .Item(6, baris).Value
            TStatus.Text = .Item(7, baris).Value
            TLokasi.Text = .Item(8, baris).Value
        End With
    End Sub
    Private Sub lepas()
        TId.DataBindings.Clear()
        TNama.DataBindings.Clear()
        TJenis.DataBindings.Clear()
        TTempat.DataBindings.Clear()
        TTanggal.DataBindings.Clear()
        TSpesialis.DataBindings.Clear()
        TAlamat.DataBindings.Clear()
        TStatus.DataBindings.Clear()
    End Sub

    Private Sub databinding(ByVal dtdokter)
        TId.DataBindings.Add("Text", dtdokter, "id_dokter")
        TNama.DataBindings.Add("Text", dtdokter, "nama")
        TJenis.DataBindings.Add("Text", dtdokter, "jenis_kel")
        TTempat.DataBindings.Add("Text", dtdokter, "tgl_lahir")
        TTanggal.DataBindings.Add("Text", dtdokter, "tgl_lahir")
        TSpesialis.DataBindings.Add("Text", dtdokter, "spesialis")
        TAlamat.DataBindings.Add("Text", dtdokter, "alamat")
        TStatus.DataBindings.Add("Text", dtdokter, "status_perk")
    End Sub

    Private Sub BCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCari.Click
        FormKosong()
        TId.Enabled = True
        Conn = New SqlConnection(CoonStr)
        Try
            Dim dtdokter As New DataTable
            Dim dadokter As SqlDataAdapter
            dadokter = New SqlDataAdapter("Select * from dokter where id_dokter = '" & TId.Text & "' ", Conn)
            dtdokter.Clear()
            dadokter.Fill(dtdokter)
            If dtdokter.Rows.Count = Nothing Then
                MsgBox("Tidak ada data", MsgBoxStyle.Information, "Perhatian")
                TId.Text = DataGridView1.CurrentCell.ToString
                Exit Sub
            Else
                databinding(dtdokter)
                Call lepas()
                Me.DataGridView1.DataSource = dtdokter
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

    Private Sub BMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMain.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TLokasi.Text = OpenFileDialog1.FileName
            Dim gambar = Image.FromFile(Me.TLokasi.Text)
            Me.foto.Image = gambar
        End If
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
End Class