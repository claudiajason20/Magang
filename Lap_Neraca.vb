Imports CrystalDecisions.Shared
Public Class Lap_Neraca
    Public firstdate As Date
    Public seconddate As Date
    Public Sub GetReport()
        Dim rpt As New Neraca
        rpt.Load(Application.StartupPath & "\Neraca.rpt\")

        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue

        pfield.Name = "start"
        pdiscrete.Value = firstdate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "end"
        pdiscrete1.Value = seconddate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields
    End Sub

End Class