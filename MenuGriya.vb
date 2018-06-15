Public Class MenuGriya
    Private Sub JenisPembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisPembayaranToolStripMenuItem.Click
        JenispenjualanGriya.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        penjualanGriya.Show()
    End Sub

    Private Sub JenisPengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisPengeluaranToolStripMenuItem.Click
        JenisPengeluaranGriya.Show()
    End Sub
    Private Sub MenuManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel1.Text = "Nama:" + global_nama
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TambahPengeluaranGriya.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Login_Menus.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Lap_pendapatanGriya.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Lap_PengeluaranGriya.Show()
    End Sub
End Class