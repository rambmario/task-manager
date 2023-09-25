Public Class frmReporteTarea

    Private Sub frmReporteTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Gestion_tareaDataSet.cop_Tarea_GetAll_2' table. You can move, or remove it, as needed.
        Me.cop_Tarea_GetAll_2TableAdapter.Fill(Me.Gestion_tareaDataSet.cop_Tarea_GetAll_2)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class