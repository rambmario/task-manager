Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReporteTareasEntreFechasIngesoft

    Private Sub frmReporteTareasEntreFechasIngesoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument
        Dim fecha_inicio As DateTime = CType(Owner, frmAbmTarea).dtpFecha_desde.Value
        Dim fecha_fin As DateTime = CType(Owner, frmAbmTarea).dtpFecha_hasta.Value
        ' Dim id_empresa As Integer = CInt(CType(Owner, frmAbmTarea).lblid_empresa.Text)

        Dim consulta As Integer = 0

        Select Case parametro_reporte
            Case "porEmpresa"
                consulta = 1
                rpt.Load(PathReporte & "rptTareasEntreFechasIngesoft.rpt")
            Case "porProyecto"
                consulta = 2
                rpt.Load(PathReporte & "rptTareasEntreFechasIngesoft.rpt")
            Case "porSubproyecto"
                consulta = 3
                rpt.Load(PathReporte & "rptTareasEntreFechasIngesoft.rpt")
            Case Else
                consulta = 1
                rpt.Load(PathReporte & "rptTareasEntreFechasIngesoft.rpt")
        End Select

        Dim a As ParameterDiscreteValue
        Dim b As ParameterFieldDefinitions
        Dim c As ParameterFieldDefinition
        Dim d As ParameterValues

        Try
            Dim odt As DataTable
            odt = oTarea.GetEntreFechaIngesoft(parametro_fecha_inicio, parametro_fecha_fin, parametro_id_empresa, parametro_id_proyecto, parametro_id_subproyecto, consulta)

            rpt.SetDataSource(odt)
        Catch ex As Exception

        End Try


        b = rpt.DataDefinition.ParameterFields
        c = b.Item("@fecha_inicio")
        d = c.CurrentValues
        a = New CrystalDecisions.Shared.ParameterDiscreteValue
        a.Value = parametro_fecha_inicio
        d.Add(a)
        c.ApplyCurrentValues(d)

        b = rpt.DataDefinition.ParameterFields
        c = b.Item("@fecha_fin")
        d = c.CurrentValues
        a = New CrystalDecisions.Shared.ParameterDiscreteValue
        a.Value = parametro_fecha_fin
        d.Add(a)
        c.ApplyCurrentValues(d)

        b = rpt.DataDefinition.ParameterFields
        c = b.Item("@id_empresa")
        d = c.CurrentValues
        a = New CrystalDecisions.Shared.ParameterDiscreteValue
        a.Value = parametro_id_empresa
        d.Add(a)
        c.ApplyCurrentValues(d)

        b = rpt.DataDefinition.ParameterFields
        c = b.Item("@id_proyecto")
        d = c.CurrentValues
        a = New CrystalDecisions.Shared.ParameterDiscreteValue
        a.Value = parametro_id_proyecto
        d.Add(a)
        c.ApplyCurrentValues(d)

        b = rpt.DataDefinition.ParameterFields
        c = b.Item("@id_subproyecto")
        d = c.CurrentValues
        a = New CrystalDecisions.Shared.ParameterDiscreteValue
        a.Value = parametro_id_subproyecto
        d.Add(a)
        c.ApplyCurrentValues(d)

        b = rpt.DataDefinition.ParameterFields
        c = b.Item("@consulta")
        d = c.CurrentValues
        a = New CrystalDecisions.Shared.ParameterDiscreteValue
        a.Value = consulta
        d.Add(a)
        c.ApplyCurrentValues(d)

        parametro_path_logo = Environment.CurrentDirectory & "\logo_reporte.png"

        b = rpt.DataDefinition.ParameterFields
        c = b.Item("@path_logo")
        d = c.CurrentValues
        a = New CrystalDecisions.Shared.ParameterDiscreteValue
        a.Value = parametro_path_logo
        d.Add(a)
        c.ApplyCurrentValues(d)

        Me.CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class