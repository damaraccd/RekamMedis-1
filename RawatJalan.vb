'try for git
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Image
Imports System.IO
Public Class RawatJalan
    Dim CoonStr As String = "Data Source=YOGIADIGUNA;Initial Catalog=REKAMMEDIS;Integrated Security=True"
    Dim Conn As SqlConnection
    Dim eksekusi As New SqlCommand
    Dim SQL As String
    Dim RecCount As Integer
    Dim memoryStream As MemoryStream
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New REKAMMEDISDataSet()

    Private Sub RawatJalan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conn As SqlConnection
        Dim Ds As DataSet
        Dim Da As SqlDataAdapter
        Dim SQL As String = "Select * From RJ22"

        Try
            Conn = New SqlConnection(CoonStr)
            Ds = New DataSet
            Da = New SqlDataAdapter(SQL, Conn)
            Da.Fill(Ds, "RJ2")
            'DataGridView1.DataSource = Ds.Tables("Pasien2")
        Catch
            'MessageBox.Show("Tabel tidak dapat ditampilkan ... ", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormAktif()
        TRM.Enabled = True
        TTanggalKun.Enabled = True
        TNAma.Enabled = True
        TTanggal.Enabled = True
        TUmur.Enabled = True
        TJenis.Enabled = True
        TDUtama.Enabled = True
        TDSkunder.Enabled = True
        TKomplikasi.Enabled = True
        TTherapi.Enabled = True
        TNamaDokter.Enabled = True

        
    End Sub
    Private Sub FormKosong()
        TKunjungan.Text = ""
        TRM.Text = ""
        TTanggalKun.Text = ""
        TNama.Text = ""
        TTanggal.Text = ""
        TUmur.Text = ""
        TJenis.Text = ""
        TDUtama.Text = ""
        TDSkunder.Text = ""
        TKomplikasi.Text = ""
        TTherapi.Text = ""
        TNamaDokter.Text = ""
    End Sub

    Private Sub Non()
        TTanggalKun.Enabled = False
        TNama.Enabled = False
        TTanggal.Enabled = False
        TUmur.Enabled = False
        TJenis.Enabled = False
        TDUtama.Enabled = False
        TDSkunder.Enabled = False
        TKomplikasi.Enabled = False
        TTherapi.Enabled = False
        TNamaDokter.Enabled = False

    End Sub

    Private Sub BNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNew.Click
        TKunjungan.Enabled = False
        BSAve.Enabled = True
        Conn = New SqlConnection(CoonStr)
        'Dim Kode As String
        'FormAktif()
        FormKosong()
        'TBrowse.Enabled = True
        Try
            Dim daRJ As SqlDataAdapter = New SqlDataAdapter("select no_rj from RJ2", Conn)
            Dim dtRJ As New DataTable
            'Me.DataGridView1.SendToBack()
            dtRJ.Clear()
            daRJ.Fill(dtRJ)
            Me.BindingContext(dtRJ).Position = Me.BindingContext(dtRJ).Count + 1
            'Mengosongkan selain TNomor untuk autonumber pasien
            'tapi petama harus dilepas bindingnya
            TKunjungan.DataBindings.Add("text", dtRJ, "no_ri")
            'TNomor.Text = 10000
            If TKunjungan.Text = Nothing Then
                TKunjungan.Text = 5500000000
                'Else
            End If
            'TNomor.Text = Val(Right(TNomor.Text, 4))
            TKunjungan.Text += 1
            TKunjungan.DataBindings.Clear()

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

    Private Sub TRM_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TRM.KeyUp
        Conn = New SqlConnection(CoonStr)
        Conn.Open()
        Dim cmd As SqlCommand
        TNama.Text = ""
        TTanggal.Text = ""
        Dim st As String = "Select * from pasien2 where no_rm = '" + TRM.Text.Trim + "'"
        cmd = New SqlCommand(st, Conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            TNama.Text = dr(1).ToString
            TTanggal.Value = dr(4)
        End While
        Dim tahun As Long
        Dim skrg As Date = Now
        Dim lhr As Date = TTanggal.Value
        tahun = DateDiff(DateInterval.Year, lhr, skrg)
        TUmur.Text = tahun.ToString
        dr.Close()
    End Sub

    Private Sub BSAve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSAve.Click
        Conn = New SqlConnection(CoonStr)
        Try
            If (Me.TKunjungan.Text = Nothing) Or (Me.TRM.Text = Nothing) Or (Me.TTanggalKun.Text = Nothing) Or (Me.TUmur.Text = Nothing) Or (Me.TNamaDokter.Text = Nothing) Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation, "Error")

            Else
                eksekusi.Connection = Conn
                eksekusi.CommandText = "Insert into RJ2 values('" & TKunjungan.Text & "','" & TRM.Text & "','" & TTanggalKun.Text & "', '" & TUmur.Text & "','" & TNamaDokter.Text & "')"

                eksekusi.CommandType = CommandType.Text
                myDA.SelectCommand = eksekusi

                'Ds = New DataSet
                'da = New SqlDataAdapter(SQL, Conn)
                myDA.Fill(MyDS, "RJ2")
                'DataGridView1.DataSource = Ds.Tables("Pasien2")
                'DataGridView1.Refresh()
            End If
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMain.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub bcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcari.Click
        TabelDokter.Show()
    End Sub
End Class
