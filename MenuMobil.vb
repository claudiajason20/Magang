Public Class MenuMobil
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Login_Menus.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        JenisMobil.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        PendapatanMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        PengeluaranMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub MenuMobil_Load(sender As Object, e As EventArgs) Handles Me.Load
        Nama.Text = "Nama: " + global_nama
    End Sub

End Class