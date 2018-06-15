Imports MySql.Data.MySqlClient

Public Class Berkas_Masuk
    Private Sub Berkas_Masuk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel2.Text = "Nama: " + global_nama
    End Sub

    Private Sub searchakun_Click(sender As Object, e As EventArgs) Handles searchakun.Click
        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select * from berkas"
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView1.DataSource = dsakun.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rownum As Integer = DataGridView1.CurrentRow.Index
        Dim value As Object = DataGridView1.Rows(rownum).Cells(0).Value
        Dim id As String = CType(value, String)
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()
        Dim sql As String = "update status_berkas from berkas where berkas_id =" + id
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()


        conakun.Open()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class