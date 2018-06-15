Imports MySql.Data.MySqlClient
Public Class JenisPendapatanMobilvb
    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim idLocRemv As String = DataGridView1.CurrentCell.Value.ToString()
        Dim sql As String = "DELETE FROM jenispenjualanmobil WHERE NomorIdJual = " + idLocRemv + "or namaJual like '%" + idLocRemv + "%'"
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

        Dim sqli As String = "Select Nomoridjual as Nomor, NamaJual as Nama from jenispenjualanmobil"
        Dim Adptakun As New MySqlDataAdapter(sqli, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        Tambahkodemobil.Show()
    End Sub

    Private Sub Cari_Click(sender As Object, e As EventArgs) Handles Cari.Click
        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select * from akun where namaJual like '%" + TextBox4.Text + "%' or nomorAkun = " + CInt(TextBox4.Text)
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MenuMobil.Show()
        Me.Close()
    End Sub
End Class