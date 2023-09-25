Public Class frmFechaTarea
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        parametro_fecha = Me.MonthCalendar1.SelectionStart.Date
        Me.Close()
    End Sub

End Class