Imports CrystalDecisions.Shared

Public Class lap_labarugi
    Public FirstDate As Date
    Public SecondDate As Date

    Public Sub GetReport()
        Dim rpt As New ReportLabarugi
        rpt.Load(Application.StartupPath & "\ReportLabaRugi.rpt\")

        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue

        pfield.Name = "start"
        pdiscrete.Value = FirstDate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "end"
        pdiscrete1.Value = SecondDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields

    End Sub

    Private Sub lap_labarugi_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetReport()
    End Sub
End Class