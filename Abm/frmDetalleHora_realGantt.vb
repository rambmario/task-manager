Public Class frmDetalleHora_realGantt

    Private Sub frmDetalleHora_real_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscatarea, "Buscar Nuevo Tarea")
        Me.ttGeneral.SetToolTip(Me.btnBuscausuario, "Buscar Nuevo Usuario")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Hora_real")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()
            Me.txtidentificador.Text = vgNombreUsuario

            'Me.cmbTarea.Text = oTarea.GetOne(CInt(Me.lblid_Tarea.Text)).Rows(0).Item("nombre Tarea").ToString.Trim
            Me.cmbusuario_asignado.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_asignado.Text)).Rows(0).Item("identificador").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaHora_real = 1 Then
            Me.LimpiarControles()
            'Me.lblid_usuario_asignado.Text = CType(Me.Owner, frmGantt).lblid_usuario_asignado.Text

            Me.lblid_usuario_asignado.Text = frmGantt.lblid_usuario.Text
            Me.cmbusuario_asignado.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_asignado.Text)).Rows(0).Item("identificador").ToString.Trim
        End If

        Me.lblid_tarea.Text = frmGantt.lblid_tarea.Text

        If vgCodigoTipoUsuario = 3 Then
            Me.cmbusuario_asignado.Enabled = False
        End If
        Me.Text = "Carga de Horas" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.cmbusuario_asignado.Focus()
    End Sub

    Sub CargarCombos()
        Me.CargarTarea()
        Me.CargarUsuario()
    End Sub

    Sub CargarTarea()
        Dim odt As New DataTable

        odt = oTarea.GetCmb
        With Me.cmbtarea
            .DataSource = odt
            .DisplayMember = "nombre_tarea"
            .ValueMember = "id_tarea"
        End With
        If Me.cmbtarea.SelectedIndex >= 0 Then
            cmbtarea.SelectedIndex = 0
            Me.lblid_tarea.Text = cmbtarea.SelectedValue.ToString
        End If
    End Sub

    Sub CargarUsuario()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbusuario_asignado
            .DataSource = odt
            .DisplayMember = "identificador"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbusuario_asignado.SelectedIndex >= 0 Then
            cmbusuario_asignado.SelectedIndex = 0
            Me.lblid_usuario_asignado.Text = cmbusuario_asignado.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        'Me.lblid_tarea.Text = "0"
        Me.cmbtarea.Text = ""
        '  Me.lblid_usuario.Text = "0"
        '  Me.cmbusuario_asignado.Text = ""
        Me.dtpfecha_carga.Value = DateTime.Now
        Me.txthora_real.Text = "0"
        Me.txtComentario.Text = ""
        Me.txtCosto.Text = "0"
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_tarea.Text = frmGantt.lblid_tarea.Text
        'Me.lblid_tarea.Text = frmGantt.lblid_tarea.Text
        If BanderaHora_real = 2 Then
            Me.lblid_usuario_asignado.Text = oHora_real.id_usuario_asignado.ToString
        End If

        Me.dtpfecha_carga.Value = oHora_real.fecha_carga
        Me.txthora_real.Text = oHora_real.hora_real.ToString.Trim
        Me.txtComentario.Text = oHora_real.comentario
        Me.txtCosto.Text = oHora_real.costo.ToString
    End Sub

    Private Sub AsignarDatos()
        oHora_real.id_tarea = CInt(Me.lblid_tarea.Text)
        oHora_real.id_usuario_asignado = CInt(Me.lblid_usuario_asignado.Text)
        oHora_real.id_usuario = vgCodigoUsuario
        oHora_real.fecha_carga = Me.dtpfecha_carga.Value.Date
        oHora_real.hora_real = CDec(Me.txthora_real.Text)
        oHora_real.comentario = Me.txtComentario.Text
        oHora_real.costo = CDec(Me.txtCosto.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbtarea.Enabled = False
        Me.btnBuscatarea.Enabled = False
        Me.cmbusuario_asignado.Enabled = False
        Me.btnBuscausuario.Enabled = False
        Me.dtpfecha_carga.Enabled = False
        Me.txthora_real.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oHora_real.Exist() Then
                If BanderaHora_real = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaHora_real = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaHora_real
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oHora_real.Guardar()
                    'CType(Me.Owner, frmGantt).RefrescarHora_real()

                    frmGantt.RefrescarGrillaHoras()




                        'Me.CargarCombos()
                        oHora_real.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpfecha_carga.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oHora_real.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If _
        Me.txthora_real.Text = "" Or
        Me.txtComentario.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'If CDbl(Me.lblid_tarea.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de tarea")
        '    Exit Sub
        'End If
        If CDbl(Me.lblid_usuario_asignado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaHora_real = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbTarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtarea.SelectedIndexChanged
        If Me.cmbtarea.SelectedIndex >= 0 Then
            Me.lblid_tarea.Text = cmbtarea.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaTarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatarea.Click
        'Dim frmTemporal As New FrmAbmTarea
        'frmTemporal.ShowDialog()
        'Me.CargarTarea()
        'Me.cmbTarea.Focus()
        'Me.cmbTarea.Text = ""
        'Me.lblid_Tarea.Text = "0"
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario_asignado.SelectedIndexChanged
        If Me.cmbusuario_asignado.SelectedIndex >= 0 Then
            Me.lblid_usuario_asignado.Text = cmbusuario_asignado.SelectedValue.ToString
        End If

        If Not IsNumeric(Me.lblid_usuario_asignado.Text) Then
            Exit Sub
        End If
        Me.txtCosto.Text = CStr(oUsuario.GetOne(CInt(Me.lblid_usuario_asignado.Text)).Rows(0).Item("costo"))
    End Sub

    Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscausuario.Click
        'Dim frmTemporal As New FrmAbmUsuario
        'frmTemporal.ShowDialog()

        frmAbmUsuario.ShowDialog()
        frmAbmUsuario.Dispose()

        Me.CargarUsuario()
        Me.cmbusuario_asignado.Focus()
        Me.cmbusuario_asignado.Text = ""
        Me.lblid_usuario_asignado.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtComentario.KeyPress, txtidentificador.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbtarea.KeyDown, cmbusuario_asignado.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txthora_real.KeyPress, txtCosto.KeyPress

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

End Class
