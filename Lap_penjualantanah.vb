Imports CrystalDecisions.Shared
Public Class Lap_penjualantanah
    Public firstdate As Date
    Public seconddate As Date

    Public Sub Get_Akun_report()
        Dim rpt As LaporanPenjualanTanah
        rpt.Load(Application.StartupPath & "\LaporanPenjualanTanah.rpt\")


        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue


        pfield.Name = "mulai"
        pdiscrete.Value = firstdate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "akhir"
        pdiscrete1.Value = seconddate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields
    End Sub

End Class