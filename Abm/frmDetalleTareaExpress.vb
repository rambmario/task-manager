Public Class frmDetalleTareaExpress

    Private Sub frmDetalleTareaExpress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblid_empresa.Text = frmAbmTarea.lblid_empresa.Text
        Me.lblid_proyecto.Text = frmAbmTarea.lblid_proyecto.Text
        Me.lblid_sub_proyecto.Text = frmAbmTarea.lblid_sub_proyecto.Text
        Me.lblid_usuario_asignado.Text = frmAbmTarea.lblid_usuario_asignado.Text

        Me.txtUnidad.Text = frmAbmTarea.cmbEmpresa.Text
        Me.txtProyecto.Text = frmAbmTarea.cmbproyecto.Text
        Me.txtSubproyecto.Text = frmAbmTarea.cmbSub_proyecto.Text
        Me.txtAsignado.Text = frmAbmTarea.cmbUsuario.Text

        Me.CargarTipo_tarea()

        Me.RefrescarFeriado()
    End Sub

    Sub CargarTipo_tarea()
        Dim odt As New DataTable

        odt = oTipo_tarea.GetCmb
        With Me.cmbtipo_tarea
            .DataSource = odt
            .DisplayMember = "nombre_tipo_tarea"
            .ValueMember = "id_tipo_tarea"
        End With
        If Me.cmbtipo_tarea.SelectedIndex >= 0 Then
            cmbtipo_tarea.SelectedIndex = 0
            Me.lblid_tipo_tarea.Text = cmbtipo_tarea.SelectedValue.ToString
        End If
    End Sub

    Sub RefrescarFeriado()
        Dim odtFeriado As New DataTable

        odtFeriado = oFeriado.GetOne_Fecha(Me.dtpFecha_pedido.Value.Date)

        If odtFeriado.Rows.Count > 0 Then
            chkEs_feriado.Checked = True
        Else
            chkEs_feriado.Checked = False
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.txtnombre_tarea.Text = "" Or Me.txthora_prevista.Text = "" Then

            MessageBox.Show("Debe llenar todos los campos")
            Exit Sub
        End If

        oTarea.Cargar()
        oTarea.Insertar()
        oTarea.id_tipo_tarea = CInt(Me.lblid_tipo_tarea.Text)
        oTarea.id_sub_proyecto = CInt(Me.lblid_sub_proyecto.Text)
        oTarea.nombre_tarea = Me.txtnombre_tarea.Text.Trim
        oTarea.fecha_fin = Me.dtpFecha_pedido.Value.Date
        oTarea.fecha_real = Me.dtpFecha_pedido.Value.Date
        oTarea.ubicacion_documento = ""
        oTarea.hora_prevista = CDec(Me.txthora_prevista.Text)
        oTarea.hora_real = CDec(Me.txthora_prevista.Text)
        oTarea.id_usuario = vgCodigoUsuario
        oTarea.id_proyecto = CInt(Me.lblid_proyecto.Text)
        oTarea.id_empresa = CInt(Me.lblid_empresa.Text)
        oTarea.id_usuario_asignado = CInt(Me.lblid_usuario_asignado.Text)
        oTarea.fecha_pedido = dtpFecha_pedido.Value.Date
        oTarea.fecha_inicio = Me.dtpFecha_pedido.Value.Date
        oTarea.prioridad = 1
        oTarea.id_estado_tarea = 1
        oTarea.complejidad = "B"
        oTarea.es_feriado = Me.chkEs_feriado.Checked
        oTarea.Guardar()

        Me.lblid_tarea.Text = CStr(oTarea.id_tarea)

        'cargo el detalle de la tarea
        oHora_real.Cargar()
        oHora_real.Insertar()
        oHora_real.comentario = Me.txtnombre_tarea.Text
        oHora_real.costo = 10
        oHora_real.fecha_carga = Me.dtpFecha_pedido.Value.Date
        oHora_real.hora_real = CDec(Me.txthora_prevista.Text)
        oHora_real.id_tarea = CInt(Me.lblid_tarea.Text)
        oHora_real.id_usuario = vgCodigoUsuario
        oHora_real.id_usuario_asignado = CInt(Me.lblid_usuario_asignado.Text)
        oHora_real.Guardar()

        Me.txthora_prevista.Text = ""
        Me.txtnombre_tarea.Text = ""
        Me.dtpFecha_pedido.Focus()
    End Sub

    Private Sub cmbTipo_tarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_tarea.SelectedIndexChanged
        If Me.cmbTipo_tarea.SelectedIndex >= 0 Then
            Me.lblid_tipo_tarea.Text = cmbTipo_tarea.SelectedValue.ToString
        End If
    End Sub

    Private Sub dtpFecha_pedido_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_pedido.ValueChanged
        Me.RefrescarFeriado()
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txthora_prevista.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = CChar(",")
            End If
        End If

        Dim Largo As Integer = InStr(txtTemp.Text, ",")

        If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
            e.Handled = True
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnombre_tarea.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpFecha_pedido.KeyDown, cmbtipo_tarea.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub
End Class