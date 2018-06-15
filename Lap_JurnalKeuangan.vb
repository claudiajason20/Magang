Imports CrystalDecisions.Shared
Public Class Lap_JurnalKeuangan
    Public FirstDate As Date
    Public SecondDate As Date

    Public Sub Get_jurnal_report()
        Dim rpt As jurnal
        rpt.Load(Application.StartupPath & "\jurnal.rpt\")


        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue



        pfield.Name = "startdate"
        pdiscrete.Value = FirstDate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "enddate"
        pdiscrete1.Value = SecondDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields

    End Sub

    Private Sub Lap_Akun_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_jurnal_report()
    End Sub
End Class