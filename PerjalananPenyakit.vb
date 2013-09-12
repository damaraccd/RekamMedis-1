Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Image
Imports System.IO
Public Class PerjalananPenyakit
    Dim CoonStr As String = "Data Source=YOGIADIGUNA;Initial Catalog=REKAMMEDIS;Integrated Security=True"
    Dim Conn As SqlConnection
    Dim eksekusi As New SqlCommand
    Dim SQL As String
    Dim RecCount As Integer
    Dim memoryStream As MemoryStream
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New REKAMMEDISDataSet()

    Private Sub bersih()
        TNomor.Text = ""
        TJam.Text = ""
        TKeadaan.Text = ""
        TPengobatan.Text = ""
        TPerawat.Text = ""
    End Sub
    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        Conn = New SqlConnection(CoonStr)
        Try
            If (Me.TNomor.Text = Nothing) Or (Me.TTanggal.Text = Nothing) Or (Me.TJam.Text = Nothing) Or (Me.TKeadaan.Text = Nothing) Or (Me.TPengobatan.Text = Nothing) Or _
                (Me.TPerawat.Text = Nothing) Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation, "Error")

            Else
                Try
                    Dim dtdokter As New DataTable
                    Dim dadokter As SqlDataAdapter
                    dadokter = New SqlDataAdapter("Select * from perawat where id_perawat = '" & TPerawat.Text & "' ", Conn)
                    dtdokter.Clear()
                    dadokter.Fill(dtdokter)
                    If dtdokter.Rows.Count = Nothing Then
                        MsgBox("Maaf Id Perawat Yang Anda Masukkan Salah ", MsgBoxStyle.Information, "Perhatian")

                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")

                End Try
                eksekusi.Connection = Conn
                eksekusi.CommandText = "Insert into jalanPenyakit2 values('" & TNomor.Text & "','" & RM.Text & "','" & MP.Text & "','" & TTanggal.Value.Date & "','" & TJam.Text & "', '" & TKeadaan.Text & "','" & TPengobatan.Text & _
                "','" & TPerawat.Text & "')"

                eksekusi.CommandType = CommandType.Text
                myDA.SelectCommand = eksekusi

                'Ds = New DataSet
                'da = New SqlDataAdapter(SQL, Conn)
                myDA.Fill(MyDS, "JalanPenyakit2")
                'DataGridView1.DataSource = Ds.Tables("Pasien2")
                'DataGridView1.Refresh()
                MsgBox("Data Tersimpan")
                bersih()
            End If
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PerjalananPenyakit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(MP.Text)
        'MsgBox(RM.Text)
        Conn = New SqlConnection(CoonStr)
        Try
            Dim dajalan As SqlDataAdapter = New SqlDataAdapter("select no_jlp from jalanPenyakit2", Conn)
            Dim dtjalan As New DataTable
            'Me.DataGridView1.SendToBack()
            dtjalan.Clear()
            dajalan.Fill(dtjalan)
            Me.BindingContext(dtjalan).Position = Me.BindingContext(dtjalan).Count + 1
            'Mengosongkan selain TNomor untuk autonumber pasien
            'tapi petama harus dilepas bindingnya
            TNomor.DataBindings.Add("text", dtjalan, "no_jlp")
            'TNomor.Text = 10000
            If TNomor.Text = Nothing Then
                TNomor.Text = 8810000000
                'Else
            End If
            'TNomor.Text = Val(Right(TNomor.Text, 4))
            TNomor.Text += 1
            TNomor.DataBindings.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub

    Private Sub RInap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RInap.Click
        MRI.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabelPerawat.Show()
    End Sub
End Class