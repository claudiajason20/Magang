Imports MySql.Data.MySqlClient

Public Class Akun

    Private Sub Jurnal_Keuangan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel2.Text = "Nama: " + global_nama
        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select nomorAkun, namaAkun, jenis_akun, jenis_laporan from akun"
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tambahakun.Show()

        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select nomorAkun, namaAkun, jenis_akun, jenis_laporan from akun"
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)

    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim idLocRemv As String = DataGridView1.CurrentCell.Value.ToString()
        Dim sql As String = "DELETE FROM akun WHERE nomorAkun = " + idLocRemv
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

        Dim sqli As String = "Select nomorAkun, namaAkun, jenis_akun, jenis_laporan from akun"
        Dim Adptakun As New MySqlDataAdapter(sqli, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub Cari_Click(sender As Object, e As EventArgs) Handles Cari.Click
        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select nomorAkun, namaAkun from akun where namaAkun like '%" + TextBox1.Text + "%' or nomorAkun = " + CInt(TextBox1.Text)
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)
    End Sub

End Class