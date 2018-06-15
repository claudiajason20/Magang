Imports MySql.Data.MySqlClient
Public Class JenisPengeluaranGriya
    Private Sub TambahpengeluaranGriya_Load(sender As Object, e As EventArgs) Handles Me.Load
        ToolStripStatusLabel2.Text = "Nama: " + global_nama
        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select NomorJenis, NamaJenis from jenispenjualangriya"
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MenuGriya.Show()
        Me.Close()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim idLocRemv As String = DataGridView1.CurrentCell.Value.ToString()
        Dim sql As String = "DELETE FROM jenispengeluarangriya WHERE nomorJenis = " + idLocRemv + "or namaJenis like '%" + idLocRemv + "%'"
        Dim comm As MySqlCommand = New MySqlCommand()

        comm.Connection = conakun

        'delete query 
        comm.CommandText = sql
        comm.ExecuteNonQuery()

        conakun.Close()

        'reaload akun 
        'data akun load
        ''create connection 
        conakun.Open()

        Dim sqli As String = "Select nomorJenisL as Nomor, NamaJenisL as Nama from jenispengeluarangriya"
        Dim Adptakun As New MySqlDataAdapter(sqli, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        TambahJenisGriya.Show()
    End Sub

    Private Sub Cari_Click(sender As Object, e As EventArgs) Handles Cari.Click

    End Sub
End Class