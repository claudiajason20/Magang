Public Class MenuUtama

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        PerubahanModal.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Jurnal_Keuangan.Show()
        Me.Hide()
    End Sub
    Private Sub MenuManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel2.Text = "Nama:" + global_nama
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Login_Menus.Show()
        Me.Close()
    End Sub

    Private Sub AkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkunToolStripMenuItem.Click
        Akun.Show()
        Me.Close()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        User_control.Show()
        Me.Close()
    End Sub

    Private Sub LabaRugiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabaRugiToolStripMenuItem.Click
        PilihTanggalLabarugi.Show()
    End Sub

    Private Sub JurnalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JurnalToolStripMenuItem.Click
        Lap_JurnalKeuangan.Show()
    End Sub

    Private Sub LaporanAkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanAkunToolStripMenuItem.Click
        Pilih_Akun.Show()
    End Sub

    Private Sub NeracaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeracaToolStripMenuItem.Click
        PilihTanggalNeraca.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        MenuGriya.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MenuTanah.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        MenuMobil.Show()
        Me.Hide()
    End Sub
End Class