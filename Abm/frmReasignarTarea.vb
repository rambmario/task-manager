Public Class frmReasignarTarea
    Private Sub frmReasignarTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim odt As New DataTable

        odt = oTarea.GetOne(vgIdTareaGantt)

        If odt.Rows.Count > 0 Then
            Me.dtpFecha_inicio.Value = CDate(odt.Rows(0).Item("fecha inicio"))
            Me.dtpfecha_fin.Value = CDate(odt.Rows(0).Item("fecha fin"))
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        oTarea.Cargar()
        oTarea.Modificar(vgIdTareaGantt)
        oTarea.fecha_inicio = Me.dtpFecha_inicio.Value.Date
        oTarea.fecha_fin = Me.dtpfecha_fin.Value.Date
        oTarea.Guardar()

        Me.Close()
    End Sub


End Class