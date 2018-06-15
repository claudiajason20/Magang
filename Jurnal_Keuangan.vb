Imports MySql.Data.MySqlClient
Public Class Jurnal_Keuangan

    Private Sub Jurnal_Keuangan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel2.Text = "Nama: " + global_nama
        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select nomorAkun, namaAkun from akun"
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView2.DataSource = dsakun.Tables(0)



        'data jurnal load

        Dim con As New MySqlConnection(global_conn)
        con.Open()
        Dim com As String = "Select tanggal,nomorAkun,keterangan,debet,kredit from jurnal_keuangan"
        Dim Adpt As New MySqlDataAdapter(com, con)
        con.Close()

        Dim ds As New DataSet()
        Adpt.Fill(ds)

        ds.Clear()

        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Yakin Kembali?", "Kembali", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            MenuUtama.Show()
        End If
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        If MessageBox.Show("Yakin Kembali?", "Kembali", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            MenuUtama.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ''create connection 
        Dim conn As MySqlConnection = New MySqlConnection(global_conn)
        conn.Open()

        Dim sql As String = "Select tanggal,nomorAkun,keterangan,debet,kredit from jurnal_keuangan"
        Dim comm As MySqlCommand = New MySqlCommand(sql)
        comm.Connection = conn


        ''insert data to sql database row by row
        Dim akun, keterangan, debet, kredit As Object
        Dim datet As Date


        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 2
            datet = DataGridView1.Rows(i).Cells(0).Value()
            akun = DataGridView1.Rows(i).Cells(1).Value()
            keterangan = DataGridView1.Rows(i).Cells(2).Value()
            debet = DataGridView1.Rows(i).Cells(3).Value()
            kredit = DataGridView1.Rows(i).Cells(4).Value()

            comm.CommandText = "insert into jurnal_keuangan(tanggal,nomorAkun,keterangan,debet,kredit) values (STR_TO_DATE('" & datet & "','%d/%m/%Y'),'" & akun & "','" & keterangan & "','" & debet & "','" & kredit & "')"
            comm.ExecuteNonQuery()
        Next
        conn.Close()
        Me.Close()

    End Sub

    Private Sub searchakun_Click(sender As Object, e As EventArgs) Handles searchakun.Click
        'data akun load
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select nomorAkun, namaAkun from akun where namaAkun like '%" + TextBox1.Text + "%' or nomorAkun = " + CInt(TextBox1.Text)
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView2.DataSource = dsakun.Tables(0)

    End Sub

    Private Sub searchjurnalakun_Click(sender As Object, e As EventArgs) Handles searchjurnalakun.Click
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()

        Dim sql As String = "Select tanggal, nomorAkun, keterangan, debet, kredit from jurnal where nomorAkun like '%" + CInt(TextBox2.Text) + "%' "
        Dim Adptakun As New MySqlDataAdapter(sql, conakun)
        conakun.Close()

        Dim dsakun As New DataSet()
        Adptakun.Fill(dsakun)

        DataGridView2.DataSource = dsakun.Tables(0)
    End Sub

End Class