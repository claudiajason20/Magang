Imports CrystalDecisions.Shared
Public Class Lap_User
    Public userid As String


    Public Sub Get_cust_report()
        Dim rpt As Laporan_user
        rpt.Load(Application.StartupPath & "\Laporan_user.rpt\")


        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue


        pfield.Name = "customer_id"
        pdiscrete.Value = userid
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)


        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields
    End Sub

    Private Sub Lap_User_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_cust_report()
    End Sub
End Class