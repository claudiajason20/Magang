﻿Imports CrystalDecisions.Shared

Public Class Lap_Akun
    Public FirstDate As Date
    Public SecondDate As Date
    Public Account As Integer

    Public Sub Get_Akun_report()
        Dim rpt As Reportakun
        rpt.Load(Application.StartupPath & "\Reportakun.rpt\")


        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue

        Dim pfield2 As New ParameterField
        Dim pdiscrete2 As New ParameterDiscreteValue


        pfield.Name = "TanggalMulai"
        pdiscrete.Value = FirstDate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "TanggalAkhir"
        pdiscrete1.Value = SecondDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        pfield2.Name = "NomorAkun"
        pdiscrete2.Value = Account
        pfield2.CurrentValues.Add(pdiscrete2)
        pfields.Add(pfield2)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields

    End Sub

    Private Sub Lap_Akun_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_Akun_report()
    End Sub
End Class