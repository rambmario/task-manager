Public Class frmtemp

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblid_tarea.Text = CType(Me.Owner, frmAbmTarea).lblid_pk.Text
        Me.chkActivo_mejora.Checked = CType(Me.Owner, frmAbmTarea).chkActivo_mejora.Checked
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If IsNumeric(Me.lblid_tarea.Text) Then

            If Me.chkActivo_mejora.Checked = True Then
                With oMejora
                    .Cargar()
                    .Modificar(CInt(Me.lblid_tarea.Text))
                    .fecha_real = DateTimePicker1.Value.Date
                    .Guardar()
                End With
            Else
                With oTarea
                    .Cargar()
                    .Modificar(CInt(Me.lblid_tarea.Text))
                    .fecha_real = DateTimePicker1.Value.Date
                    .Guardar()
                End With
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
