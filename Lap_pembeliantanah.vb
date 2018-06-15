Imports CrystalDecisions.Shared
Public Class Lap_pembeliantanah
    Public firstdate As Date
    Public seconddate As Date

    Public Sub Get_Akun_report()
        Dim rpt As New LaporanPembelianTanah
        rpt.Load(Application.StartupPath & "\LaporanPembelianTanah.rpt\")


        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue



        pfield.Name = "start_date"
        pdiscrete.Value = FirstDate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "end_date"
        pdiscrete1.Value = SecondDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields

    End Sub

    Private Sub Lap_Akun_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_Akun_report()
    End Sub
End Class