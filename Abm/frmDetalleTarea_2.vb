Public Class frmDetalleTarea_2

    Private Sub frmDetalleTarea_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Tarea")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            oHora_real.Cargar()
            CargarCombos()
            Me.txtidentificador.Text = vgNombreUsuario
            ObtenerDatos()


            Me.cmbtipo_tarea.Text = oTipo_tarea.GetOne(CInt(Me.lblid_tipo_tarea.Text)).Rows(0).Item("nombre Tipo tarea").ToString.Trim
            Me.cmbusuario_asignado.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_asignado.Text)).Rows(0).Item("identificador").ToString.Trim

        Catch ex As Exception

        End Try


        If BanderaTarea = 1 Then
            Me.LimpiarControles()
            'Me.lblid_empresa.Text = CType(Me.Owner, frmAbmTarea).lblid_empresa.Text
            'Me.lblid_proyecto.Text = CType(Me.Owner, frmAbmTarea).lblid_proyecto.Text
            'Me.lblid_sub_proyecto.Text = CType(Me.Owner, frmAbmTarea).lblid_sub_proyecto.Text
            'Me.lblid_usuario_asignado.Text = CType(Me.Owner, frmAbmTarea).lblid_usuario_asignado.Text

            'Me.cmbCod_empresa.SelectedValue = Me.lblid_empresa.Text
            'Me.cmbCod_Proyecto.SelectedValue = CType(Me.Owner, frmAbmTarea).lblid_proyecto.Text
            'Me.cmbCod_sub_proyecto.SelectedValue = CType(Me.Owner, frmAbmTarea).lblid_sub_proyecto.Text

            Me.lblid_empresa.Text = frmAbmTarea.lblid_empresa.Text
            Me.lblid_proyecto.Text = frmAbmTarea.lblid_proyecto.Text
            Me.lblid_sub_proyecto.Text = frmAbmTarea.lblid_sub_proyecto.Text
            Me.lblid_usuario_asignado.Text = frmAbmTarea.lblid_usuario_asignado.Text

            Me.cmbCod_empresa.SelectedValue = Me.lblid_empresa.Text
            Me.cmbCod_Proyecto.SelectedValue = frmAbmTarea.lblid_proyecto.Text
            Me.cmbCod_sub_proyecto.SelectedValue = frmAbmTarea.lblid_sub_proyecto.Text

            Me.cmbEmpresa.SelectedValue = Me.lblid_empresa.Text
            Me.cmbproyecto.SelectedValue = Me.lblid_proyecto.Text
            Me.cmbSub_proyecto.SelectedValue = Me.lblid_sub_proyecto.Text

            Me.cmbusuario_asignado.SelectedValue = Me.lblid_usuario_asignado.Text

        Else
            Me.RefrescarHora_real()

            Dim idEmp As Integer = 0
            Dim idProy As Integer = 0
            Dim idSubproy As Integer = 0

            idEmp = CInt(lblid_empresa.Text)
            idProy = CInt(Me.lblid_proyecto.Text)
            idSubproy = CInt(Me.lblid_sub_proyecto.Text)

            Me.cmbCod_sub_proyecto.SelectedValue = CStr(idSubproy)
            Me.cmbCod_Proyecto.SelectedValue = CStr(idProy)
            Me.cmbCod_empresa.SelectedValue = CStr(idEmp)

            Me.cmbSub_proyecto.SelectedValue = CStr(idSubproy)
            Me.cmbproyecto.SelectedValue = CStr(idProy)
            Me.cmbEmpresa.SelectedValue = CStr(idEmp)

            Me.cmbtipo_tarea.SelectedValue = Me.lblid_tipo_tarea.Text
            Me.cmbusuario_asignado.SelectedValue = Me.lblid_usuario_asignado.Text

            'Me.cmbSub_proyecto.Text = oSub_proyecto.GetOne(CInt(Me.lblid_sub_proyecto.Text)).Rows(0).Item("nombre sub proyecto").ToString.Trim
            'Me.cmbproyecto.Text = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text)).Rows(0).Item("nombre proyecto").ToString.Trim
            'Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_empresa.Text)).Rows(0).Item("nombre empresa").ToString.Trim

            ''*
            'Me.cmbempresa_asignada.SelectedValue = oUsuario.GetOne(CInt(Me.lblid_usuario_asignado.Text)).Rows(0).Item("id empresa").ToString.Trim
            ''*
        End If

        Try
            Me.txtCapacidad_trabajo.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_asignado.Text)).Rows(0).Item("capacidad trabajo").ToString.Trim
        Catch ex As Exception
            Errores(ex)
        End Try


        If vgCodigoTipoUsuario = 3 Then
            Me.cmbusuario_asignado.Enabled = False
            Me.cmbempresa_asignada.Enabled = False

            cmbempresa_asignada.SelectedValue = oUsuario.GetOne(3).Rows(0).Item("id empresa")
            cmbusuario_asignado.SelectedValue = 3
        End If

        RefrescarHora_real()
        Me.Text = "Tarea" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.cmbtipo_tarea.Focus()

        Me.RefrescarTotalHora()
    End Sub

    Sub RefrescarTotalHora()
        Dim odt As New DataTable
        odt = oTarea.GetAllHorasPrevistas(CInt(Me.lblid_usuario_asignado.Text), Me.dtpFecha_inicio.Value.Date)

        If odt.Rows.Count > 0 Then
            Me.txtTotalHoraDia.Text = CStr(odt.Rows(0).Item("Hora prevista"))
            Me.txtTotalHoraDiaReal.Text = CStr(odt.Rows(0).Item("Hora real"))
        Else
            Me.txtTotalHoraDia.Text = "0"
            Me.txtTotalHoraDiaReal.Text = "0"
        End If

        If Me.txthora_prevista.Text = "" Then
            Me.txthora_prevista.Text = "0"
        End If
        If Me.txtHoraPrevistaPrevia.Text = "" Then
            Me.txtHoraPrevistaPrevia.Text = "0"
        End If

        'si cambia la fecha no descuento las horas de la tarea
        If Me.dtpFecha_inicio.Value.Date = Me.dtpFechaInicioPrevio.Value.Date Then
            Me.txtTotalHorasPrevistasAcumuladas.Text = CStr(CDec(Me.txtTotalHoraDia.Text) + CDec(Me.txthora_prevista.Text) - CDec(Me.txtHoraPrevistaPrevia.Text))
        Else
            Me.txtTotalHorasPrevistasAcumuladas.Text = CStr(CDec(Me.txtTotalHoraDia.Text) + CDec(Me.txthora_prevista.Text) - 0)
        End If

        'si las horas superan la capacidad
        If CDec(Me.txtTotalHorasPrevistasAcumuladas.Text) > CDec(Me.txtCapacidad_trabajo.Text) Then
            Me.txtTotalHorasPrevistasAcumuladas.BackColor = Color.Red
        Else
            Me.txtTotalHorasPrevistasAcumuladas.BackColor = Color.SteelBlue
        End If

        Dim oldWeekDayName As String
        Dim odtFeriado As New DataTable

        oldWeekDayName = WeekdayName(Weekday(Me.dtpFecha_inicio.Value))
        odtFeriado = oFeriado.GetOne_Fecha(Me.dtpFecha_inicio.Value.Date)

        If odtFeriado.Rows.Count > 0 Then
            Me.txtDiaInicio.Text = "Feriado"
            Me.txtDiaInicio.BackColor = Color.Red
            chkEs_feriado.Checked = True
        Else
            If oldWeekDayName = "sábado" Or oldWeekDayName = "domingo" Then
                Me.txtDiaInicio.BackColor = Color.LightGray
            Else
                Me.txtDiaInicio.BackColor = Color.SteelBlue
            End If
            Me.txtDiaInicio.Text = oldWeekDayName
            chkEs_feriado.Checked = False
        End If

        oldWeekDayName = WeekdayName(Weekday(Me.dtpfecha_fin.Value))
        odtFeriado = oFeriado.GetOne_Fecha(Me.dtpfecha_fin.Value.Date)

        If odtFeriado.Rows.Count > 0 Then
            Me.txtDiaFin.Text = "Feriado"
            Me.txtDiaFin.BackColor = Color.Red
        Else
            If oldWeekDayName = "sábado" Or oldWeekDayName = "domingo" Then
                Me.txtDiaFin.BackColor = Color.LightGray
            Else
                Me.txtDiaFin.BackColor = Color.SteelBlue
            End If
            Me.txtDiaFin.Text = oldWeekDayName
        End If



    End Sub
    Sub RefrescarHora_real()
        Dim odt As DataTable
        Dim hora_real As Decimal = 0


        odt = oHora_real.GetTarea(CInt(Me.lblid_tarea.Text))

        Me.dgvHora_real.DataSource = odt
        Me.dgvHora_real.Columns(0).Visible = False
        Me.dgvHora_real.Columns(1).Visible = False

        For Each row As DataRow In odt.Rows
            hora_real += CDec(row("Hora real"))
        Next
        Me.txthora_real.Text = hora_real.ToString()

    End Sub


    Sub CargarCombos()
        CargarTipo_tarea()
        CargarEmpresa()
        CargarCod_Empresa()
        CargarEmpresaAsiganda()
        CargarUsuarioAsignado()
        CargarProyecto()
        CargarCod_Proyecto()
        CargarSub_Proyecto()
        CargarCod_Sub_Proyecto()
    End Sub

    'Combos relacionados a la parte superior
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

    Sub CargarEmpresaAsiganda()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbempresa_asignada
            .DataSource = odt
            .DisplayMember = "nombre_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbempresa_asignada.SelectedIndex >= 0 Then
            cmbempresa_asignada.SelectedIndex = 0
            Me.lblid_empresa_asignada.Text = cmbempresa_asignada.SelectedValue.ToString
        End If
    End Sub

    Sub CargarUsuarioAsignado()
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

    'combos relacionados a la parte inferior
    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbEmpresa
            .DataSource = odt
            .DisplayMember = "nombre_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            cmbEmpresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub
    Sub CargarProyecto()
        Dim odt As New DataTable

        odt = oProyecto.GetCmbEmpresa(CInt(Me.lblid_empresa.Text))
        With Me.cmbproyecto
            .DataSource = odt
            .DisplayMember = "nombre_proyecto"
            .ValueMember = "id_proyecto"
        End With
        If Me.cmbproyecto.SelectedIndex >= 0 Then
            cmbproyecto.SelectedIndex = 0
            Me.lblid_proyecto.Text = cmbproyecto.SelectedValue.ToString
        End If
    End Sub

    Sub CargarSub_Proyecto()
        Dim odt As New DataTable

        odt = oSub_proyecto.GetCmbProyecto(CInt(Me.lblid_proyecto.Text))
        With Me.cmbSub_proyecto
            .DataSource = odt
            .DisplayMember = "nombre_sub_proyecto"
            .ValueMember = "id_sub_proyecto"
        End With
        If Me.cmbSub_proyecto.SelectedIndex >= 0 Then
            cmbSub_proyecto.SelectedIndex = 0
            Me.lblid_sub_proyecto.Text = cmbSub_proyecto.SelectedValue.ToString
        End If
    End Sub
    '***
    Sub CargarCod_Empresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbCod_empresa
            .DataSource = odt
            .DisplayMember = "codigo_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbCod_empresa.SelectedIndex >= 0 Then
            cmbCod_empresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbCod_empresa.SelectedValue.ToString
        End If
    End Sub
    Sub CargarCod_Proyecto()
        Dim odt As New DataTable

        odt = oProyecto.GetCmbEmpresa(CInt(Me.lblid_empresa.Text))
        With Me.cmbCod_Proyecto
            .DataSource = odt
            .DisplayMember = "codigo_proyecto"
            .ValueMember = "id_proyecto"
        End With
        If Me.cmbCod_Proyecto.SelectedIndex >= 0 Then
            cmbCod_Proyecto.SelectedIndex = 0
            Me.lblid_proyecto.Text = cmbCod_Proyecto.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCod_Sub_Proyecto()
        Dim odt As New DataTable

        odt = oSub_proyecto.GetCmbProyecto(CInt(Me.lblid_proyecto.Text))
        With Me.cmbCod_sub_proyecto
            .DataSource = odt
            .DisplayMember = "codigo_sub_proyecto"
            .ValueMember = "id_sub_proyecto"
        End With
        If Me.cmbCod_sub_proyecto.SelectedIndex >= 0 Then
            cmbCod_sub_proyecto.SelectedIndex = 0
            Me.lblid_sub_proyecto.Text = cmbCod_sub_proyecto.SelectedValue.ToString
        End If
    End Sub
#Region "-> SELECTEDINDEXCHANGED - DIVERSOS COMBOS"
    Private Sub cmbusuario_asignado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbusuario_asignado.SelectedIndexChanged
        If Me.cmbusuario_asignado.SelectedIndex >= 0 And IsNumeric(cmbusuario_asignado.SelectedValue) Then
            Me.lblid_usuario_asignado.Text = cmbusuario_asignado.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_usuario_asignado.Text) Then
            Exit Sub
        End If

        Dim odtTemp As New DataTable
        odtTemp = oUsuario.GetOne(CInt(Me.lblid_usuario_asignado.Text))
        If odtTemp.Rows.Count > 0 Then
            Me.txtCapacidad_trabajo.Text = CStr(odtTemp.Rows(0).Item("capacidad trabajo"))
        Else
            Me.txtCapacidad_trabajo.Text = "0"
        End If

        Me.RefrescarTotalHora()
    End Sub

    Private Sub cmbtipo_tarea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipo_tarea.SelectedIndexChanged
        If Me.cmbtipo_tarea.SelectedIndex >= 0 And IsNumeric(cmbtipo_tarea.SelectedValue) Then
            Me.lblid_tipo_tarea.Text = cmbtipo_tarea.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbempresa_asignada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbempresa_asignada.SelectedIndexChanged
        If Me.cmbempresa_asignada.SelectedIndex >= 0 And IsNumeric(cmbempresa_asignada.SelectedValue) Then
            Me.lblid_empresa_asignada.Text = cmbempresa_asignada.SelectedValue.ToString
            Me.cmbusuario_asignado.Text = ""
            Me.lblid_usuario_asignado.Text = "0"
            CargarUsuarioAsignado()
        End If
    End Sub

    Private Sub cmbCod_empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCod_empresa.SelectedIndexChanged
        If Me.cmbCod_empresa.SelectedIndex >= 0 And IsNumeric(cmbCod_empresa.SelectedValue) Then
            Me.lblid_empresa.Text = cmbCod_empresa.SelectedValue.ToString
            Me.cmbproyecto.Text = ""
            Me.cmbCod_Proyecto.Text = ""
            Me.lblid_proyecto.Text = "0"
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbEmpresa.SelectedValue = cmbCod_empresa.SelectedValue
            CargarProyecto()
            CargarCod_Proyecto()
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbCod_Proyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCod_Proyecto.SelectedIndexChanged
        If Me.cmbCod_Proyecto.SelectedIndex >= 0 And IsNumeric(cmbCod_Proyecto.SelectedValue) Then
            Me.lblid_proyecto.Text = cmbCod_Proyecto.SelectedValue.ToString
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbproyecto.SelectedValue = Me.cmbCod_Proyecto.SelectedValue
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbCod_sub_proyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCod_sub_proyecto.SelectedIndexChanged
        If Me.cmbCod_sub_proyecto.SelectedIndex >= 0 And IsNumeric(cmbCod_sub_proyecto.SelectedValue) Then
            Me.lblid_sub_proyecto.Text = cmbCod_sub_proyecto.SelectedValue.ToString
            Me.cmbSub_proyecto.SelectedValue = Me.cmbCod_sub_proyecto.SelectedValue
        End If
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        If Me.cmbEmpresa.SelectedIndex >= 0 And IsNumeric(cmbEmpresa.SelectedValue) Then
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
            Me.cmbproyecto.Text = ""
            Me.cmbCod_Proyecto.Text = ""
            Me.lblid_proyecto.Text = "0"
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbCod_empresa.SelectedValue = Me.cmbEmpresa.SelectedValue
            CargarProyecto()
            CargarCod_Proyecto()
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbproyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproyecto.SelectedIndexChanged
        If Me.cmbproyecto.SelectedIndex >= 0 And IsNumeric(cmbproyecto.SelectedValue) Then
            Me.lblid_proyecto.Text = cmbproyecto.SelectedValue.ToString
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbCod_Proyecto.SelectedValue = Me.cmbproyecto.SelectedValue
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbSub_proyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSub_proyecto.SelectedIndexChanged
        If Me.cmbSub_proyecto.SelectedIndex >= 0 And IsNumeric(cmbSub_proyecto.SelectedValue) Then
            Me.lblid_sub_proyecto.Text = cmbSub_proyecto.SelectedValue.ToString
            Me.cmbCod_sub_proyecto.SelectedValue = Me.cmbSub_proyecto.SelectedValue
        End If
    End Sub
#End Region

    Sub LimpiarControles()
        Me.lblid_tarea.Text = "0"
        '  Me.lblid_usuario_asignado.Text = "0"
        Me.lblid_hora_real.Text = "0"
        '  Me.cmbusuario_asignado.Text = ""
        Me.lblid_empresa_asignada.Text = "0"
        Me.cmbempresa_asignada.Text = ""
        '  Me.lblid_tipo_tarea.Text = "0"
        '  Me.cmbtipo_tarea.Text = ""
        '  Me.lblid_sub_proyecto.Text = "0"
        '  Me.cmbSub_proyecto.Text = ""
        '  Me.cmbCod_sub_proyecto.Text = ""
        ''  Me.lblid_empresa.Text = "0"
        '  Me.cmbEmpresa.Text = ""
        '  Me.cmbCod_empresa.Text = ""
        '  Me.lblid_proyecto.Text = "0"
        '  Me.cmbproyecto.Text = ""
        '   Me.cmbCod_Proyecto.Text = ""
        Me.txtnombre_tarea.Text = ""
        Me.dtpFecha_pedido.Value = DateTime.Now
        Me.dtpFecha_inicio.Value = DateTime.Now
        Me.dtpfecha_fin.Value = DateTime.Now
        Me.dtpfecha_real.Value = DateTime.Now
        Me.txtUbicacion_documento.Text = ""
        Me.txthora_prevista.Text = "0"
        Me.txthora_real.Text = "0"
        '  Me.rbtBaja.Checked = True
        Me.rbtProgramada.Checked = True
        Me.chkEs_feriado.Checked = False
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_tarea.Text = oTarea.id_tarea.ToString
        Me.lblid_tipo_tarea.Text = oTarea.id_tipo_tarea.ToString
        Me.lblid_empresa.Text = oTarea.id_empresa.ToString
        Me.lblid_proyecto.Text = oTarea.id_proyecto.ToString
        Me.lblid_sub_proyecto.Text = oTarea.id_sub_proyecto.ToString
        Me.lblid_usuario_asignado.Text = oTarea.id_usuario_asignado.ToString
        Me.txtnombre_tarea.Text = oTarea.nombre_tarea.Trim
        Me.dtpfecha_fin.Value = oTarea.fecha_fin
        Me.dtpfecha_real.Value = oTarea.fecha_real
        Me.txtUbicacion_documento.Text = oTarea.ubicacion_documento.Trim
        Me.txthora_prevista.Text = oTarea.hora_prevista.ToString.Trim
        Me.txthora_real.Text = oTarea.hora_real.ToString.Trim
        Me.dtpFecha_pedido.Value = oTarea.fecha_pedido
        Me.dtpFecha_inicio.Value = oTarea.fecha_inicio

        Select Case oTarea.prioridad
            Case 1
                Me.rbtAlta.Checked = True
            Case 2
                Me.rbtMedia.Checked = True
            Case 3
                Me.rbtBaja.Checked = True
        End Select

        Select Case oTarea.id_estado_tarea
            Case 1
                Me.rbtProgramada.Checked = True
            Case 2
                Me.rbtSuspendida.Checked = True
            Case 3
                Me.rbtCancelada.Checked = True
            Case 4
                Me.rbtFinalizada.Checked = True
        End Select

        Select Case oTarea.complejidad
            Case "A"
                Me.rbtComplejidad_alta.Checked = True
            Case "M"
                Me.rbtComplejidad_media.Checked = True
            Case "B"
                Me.rbtComplejidad_baja.Checked = True
        End Select

        Me.txtHoraPrevistaPrevia.Text = CStr(oTarea.hora_prevista)
        Me.dtpFechaInicioPrevio.Value = Me.dtpFecha_inicio.Value.Date
        Me.chkEs_feriado.Checked = oTarea.es_feriado
    End Sub
    Private Sub AsignarDatos()
        oTarea.id_tipo_tarea = CInt(Me.lblid_tipo_tarea.Text)
        oTarea.id_sub_proyecto = CInt(Me.lblid_sub_proyecto.Text)
        oTarea.nombre_tarea = Me.txtnombre_tarea.Text.Trim
        oTarea.fecha_fin = Me.dtpfecha_fin.Value.Date
        oTarea.fecha_real = Me.dtpfecha_real.Value.Date
        oTarea.ubicacion_documento = Me.txtUbicacion_documento.Text.Trim
        oTarea.hora_prevista = CDec(Me.txthora_prevista.Text)
        oTarea.hora_real = CDec(Me.txthora_real.Text)
        oTarea.id_usuario = vgCodigoUsuario
        oTarea.id_proyecto = CInt(Me.lblid_proyecto.Text)
        oTarea.id_empresa = CInt(Me.lblid_empresa.Text)
        oTarea.id_usuario_asignado = CInt(Me.lblid_usuario_asignado.Text)
        oTarea.fecha_pedido = dtpFecha_pedido.Value.Date
        oTarea.fecha_inicio = Me.dtpFecha_inicio.Value.Date

        If Me.rbtAlta.Checked = True Then
            oTarea.prioridad = 1
        ElseIf Me.rbtMedia.Checked = True Then
            oTarea.prioridad = 2
        ElseIf Me.rbtBaja.Checked = True Then
            oTarea.prioridad = 3
        End If

        If Me.rbtProgramada.Checked = True Then
            oTarea.id_estado_tarea = 1
        ElseIf Me.rbtSuspendida.Checked = True Then
            oTarea.id_estado_tarea = 2
        ElseIf Me.rbtCancelada.Checked = True Then
            oTarea.id_estado_tarea = 3
        ElseIf Me.rbtFinalizada.Checked = True Then
            oTarea.id_estado_tarea = 4
        End If

        If Me.rbtComplejidad_alta.Checked = True Then
            oTarea.complejidad = "A"
        ElseIf Me.rbtComplejidad_media.Checked = True Then
            oTarea.complejidad = "M"
        ElseIf Me.rbtComplejidad_baja.Checked = True Then
            oTarea.complejidad = "B"
        End If

        oTarea.es_feriado = Me.chkEs_feriado.Checked
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleHora_real
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaHora_real = 1
                    Me.AddOwnedForm(frmDetalle)
                    oHora_real.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_hora_real.Text) Then
                        Exit Sub
                    End If
                    BanderaHora_real = 2
                    Me.AddOwnedForm(frmDetalle)
                    oHora_real.Modificar(CInt(Me.lblid_hora_real.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarHora_real()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_hora_real.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oHora_real.Borrar(CInt(Me.lblid_hora_real.Text))
                    RefrescarHora_real()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "-> BOTONES BUSCAR"
    Private Sub btnBuscaTipo_tarea_Click(sender As Object, e As EventArgs) Handles btnBuscaTipo_tarea.Click
        'Dim frmTemporal As New frmAbmTipo_tarea
        'frmTemporal.ShowDialog()

        frmAbmTipo_tarea.ShowDialog()
        frmAbmTipo_tarea.Dispose()

        Me.CargarTipo_tarea()
        Me.cmbtipo_tarea.Focus()
        Me.cmbtipo_tarea.Text = ""
        Me.lblid_tipo_tarea.Text = "0"
    End Sub

    Private Sub btnBuscar_empresa_Click(sender As Object, e As EventArgs) Handles btnBuscar_empresa.Click
        'Dim frmTemporal As New frmAbmEmpresa
        'frmTemporal.ShowDialog()

        frmAbmEmpresa.ShowDialog()
        frmAbmEmpresa.Dispose()

        Me.CargarEmpresa()
        Me.CargarCod_Empresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.cmbCod_empresa.Text = ""
        Me.lblid_empresa.Text = "0"
    End Sub

    Private Sub btnBuscaproyecto_Click(sender As Object, e As EventArgs) Handles btnBuscaproyecto.Click
        'Dim frmTemporal As New frmAbmProyecto
        'frmTemporal.ShowDialog()

        frmAbmProyecto.ShowDialog()
        frmAbmProyecto.Dispose()

        Me.CargarProyecto()
        Me.CargarCod_Proyecto()
        Me.cmbproyecto.Focus()
        Me.cmbproyecto.Text = ""
        Me.cmbCod_Proyecto.Text = ""
        Me.lblid_proyecto.Text = "0"
    End Sub

    Private Sub btnBuscar_sub_proyecto_Click(sender As Object, e As EventArgs) Handles btnBuscar_sub_proyecto.Click
        'Dim frmTemporal As New frmAbmSub_proyecto
        'frmTemporal.ShowDialog()

        frmAbmSub_proyecto.ShowDialog()
        frmAbmSub_proyecto.Dispose()

        Me.CargarSub_Proyecto()
        Me.CargarCod_Sub_Proyecto()
        Me.cmbSub_proyecto.Focus()
        Me.cmbSub_proyecto.Text = ""
        Me.cmbCod_sub_proyecto.Text = ""
        Me.lblid_sub_proyecto.Text = "0"
    End Sub
#End Region


    Private Sub dgvHora_real_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvHora_real.CurrentCellChanged
        Try
            Me.lblid_hora_real.Text = CStr(Me.dgvHora_real.Item(0, Me.dgvHora_real.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Me.lblid_tarea.Text = "0" Then
            oHora_real.DeleteTarea(0, vgCodigoUsuario)
        End If
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_tipo_tarea.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_tarea", "restricción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CDbl(Me.lblid_sub_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de sub_proyecto", "restricción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CDbl(Me.lblid_usuario_asignado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario Asignado", "restricción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CDbl(Me.lblid_empresa.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de Empresa", "restricción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CDbl(Me.lblid_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de Proyecto", "restricción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'If dgvHora_real.RowCount = 0 Then
        '    MessageBox.Show("Debe Cargar datos en la grilla de Horas", "restricción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios", "restricción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If BanderaTarea = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oTarea.Exist() Then
                If BanderaTarea = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaTarea = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaTarea
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oTarea.Guardar()

                    oHora_real.UpdateID(oTarea.id_tarea, vgCodigoUsuario)


                    'CType(Me.Owner, frmAbmTarea).RefrescarGrilla()

                    frmAbmTarea.RefrescarGrillaTarea()

                    RefrescarHora_real()

                    'Me.CargarCombos()
                    oTarea.Insertar()
                    ' Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_tarea.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oTarea.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If _
        Me.txtnombre_tarea.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtUbicacion_documento.KeyPress, txtnombre_tarea.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbCod_empresa.KeyDown, cmbCod_Proyecto.KeyDown, cmbCod_sub_proyecto.KeyDown, _
    cmbEmpresa.KeyDown, cmbempresa_asignada.KeyDown, cmbproyecto.KeyDown, cmbSub_proyecto.KeyDown, cmbtipo_tarea.KeyDown, _
            cmbusuario_asignado.KeyDown, dtpfecha_fin.KeyDown, dtpfecha_real.KeyDown, dtpFecha_inicio.KeyDown, dtpFecha_pedido.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txthora_real.KeyPress, txthora_prevista.KeyPress
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

    Private Sub dtpfecha_real_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha_real.ValueChanged, dtpfecha_fin.ValueChanged
        Me.dtpfecha_real.MinDate = Me.dtpfecha_fin.Value
        Me.RefrescarTotalHora()
    End Sub


    Private Sub txthora_prevista_LostFocus(sender As Object, e As EventArgs) Handles txthora_prevista.LostFocus
        '  Me.RefrescarTotalHora()
    End Sub

    Private Sub txthora_real_TextChanged(sender As Object, e As EventArgs) Handles txthora_real.TextChanged
        '  Me.RefrescarTotalHora()
    End Sub

    Private Sub btnPathCroquis_Click(sender As Object, e As EventArgs) Handles btnPathCroquis.Click
        Dim BuscarImagen As New FolderBrowserDialog
        BuscarImagen.SelectedPath = Me.txtUbicacion_documento.Text
        If BuscarImagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtUbicacion_documento.Text = BuscarImagen.SelectedPath
        End If
    End Sub

    Private Sub btnAbrirExplorador_Click(sender As Object, e As EventArgs) Handles btnAbrirExplorador.Click
        Shell("explorer.exe " & Me.txtUbicacion_documento.Text)
    End Sub

    Private Sub dtpFecha_inicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_inicio.ValueChanged
        Me.RefrescarTotalHora()


    End Sub

    Private Sub txthora_prevista_TextChanged(sender As Object, e As EventArgs) Handles txthora_prevista.TextChanged
        Me.RefrescarTotalHora()
    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class