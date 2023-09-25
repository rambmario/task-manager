Imports System.IO

Public Class frmDetalleMejora

    Private Sub frmDetalleMejora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscatipo_mejora, "Buscar Nuevo Tipo_mejora")
        Me.ttGeneral.SetToolTip(Me.btnBuscaorigen_mejora, "Buscar Nuevo Origen_mejora")
        Me.ttGeneral.SetToolTip(Me.btnBuscametodo_causa, "Buscar Nuevo Metodo_causa")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Mejora")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            oMejora_accion.Cargar()
            CargarCombos()
            Me.txtUsuario.Text = vgNombreUsuario
            ObtenerDatos()

            Me.cmbtipo_mejora.Text = oTipo_mejora.GetOne(CInt(Me.lblid_tipo_mejora.Text)).Rows(0).Item("nombre Tipo mejora").ToString.Trim
            Me.cmbusuario_asignado.Text = oUsuario_asignado.GetOne(CInt(Me.lblid_usuario_asignado.Text)).Rows(0).Item("nombre Usuario asignado").ToString.Trim
            Me.cmborigen_mejora.Text = oOrigen_mejora.GetOne(CInt(Me.lblid_origen_mejora.Text)).Rows(0).Item("nombre Origen mejora").ToString.Trim
            Me.cmbresponsable_analisis.Text = oUsuario.GetOne(CInt(Me.lblid_responsable_analisis.Text)).Rows(0).Item("nombre Responsable analisis").ToString.Trim
            Me.cmbmetodo_causa.Text = oMetodo_causa.GetOne(CInt(Me.lblid_metodo_causa.Text)).Rows(0).Item("nombre Metodo causa").ToString.Trim
            Me.cmbusuario_accion_correctiva.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_accion_correctiva.Text)).Rows(0).Item("nombre Usuario accion correctiva").ToString.Trim
            Me.cmbusuario_cierre.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_cierre.Text)).Rows(0).Item("nombre Usuario cierre").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaMejora = 1 Then
            Me.LimpiarControles()


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

        Else

            Me.cmbCod_empresa.SelectedValue = Me.lblid_empresa.Text
            Me.cmbCod_Proyecto.SelectedValue = Me.lblid_proyecto.Text
            Me.cmbCod_sub_proyecto.SelectedValue = Me.lblid_sub_proyecto.Text

            Me.cmbEmpresa.SelectedValue = Me.lblid_empresa.Text
            Me.cmbproyecto.SelectedValue = Me.lblid_proyecto.Text
            Me.cmbSub_proyecto.SelectedValue = Me.lblid_sub_proyecto.Text
        End If

        RefrescarGrillaMejoraAccion()

        Me.MetroTabControl1.SelectedIndex = 0
        Me.Text = "Mejora" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarTipo_mejora()
        Me.CargarUsuario_asignado()
        Me.CargarOrigen_mejora()
        Me.CargarResponsable_analisis()
        Me.CargarMetodo_causa()
        Me.CargarUsuario_accion_correctiva()
        Me.CargarUsuario_cierre()
        CargarEmpresa()
        CargarCod_Empresa()
        CargarProyecto()
        CargarCod_Proyecto()
        CargarSub_Proyecto()
        CargarCod_Sub_Proyecto()
    End Sub

    Public Sub RefrescarGrillaMejoraAccion()
        Dim odt As DataTable
        odt = oMejora_accion.GetAll_2(CInt(Me.lblid_mejora.Text))
        dgvMejoraAccion.DataSource = odt
        dgvMejoraAccion.Columns(0).Visible = False
    End Sub
    Sub CargarTipo_mejora()
        Dim odt As New DataTable

        odt = oTipo_mejora.GetCmb
        With Me.cmbtipo_mejora
            .DataSource = odt
            .DisplayMember = "nombre_tipo_mejora"
            .ValueMember = "id_tipo_mejora"
        End With
        If Me.cmbtipo_mejora.SelectedIndex >= 0 Then
            cmbtipo_mejora.SelectedIndex = 0
            Me.lblid_tipo_mejora.Text = cmbtipo_mejora.SelectedValue.ToString
        End If
    End Sub

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

    Sub CargarUsuario_asignado()
        Dim odt As New DataTable

        odt = oUsuario_asignado.GetCmb
        With Me.cmbusuario_asignado
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbusuario_asignado.SelectedIndex >= 0 Then
            cmbusuario_asignado.SelectedIndex = 0
            Me.lblid_usuario_asignado.Text = cmbusuario_asignado.SelectedValue.ToString
        End If
    End Sub

    Sub CargarOrigen_mejora()
        Dim odt As New DataTable

        odt = oOrigen_mejora.GetCmb
        With Me.cmborigen_mejora
            .DataSource = odt
            .DisplayMember = "nombre_origen_mejora"
            .ValueMember = "id_origen_mejora"
        End With
        If Me.cmborigen_mejora.SelectedIndex >= 0 Then
            cmborigen_mejora.SelectedIndex = 0
            Me.lblid_origen_mejora.Text = cmborigen_mejora.SelectedValue.ToString
        End If
    End Sub

    Sub CargarResponsable_analisis()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbresponsable_analisis
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbresponsable_analisis.SelectedIndex >= 0 Then
            cmbresponsable_analisis.SelectedIndex = 0
            Me.lblid_responsable_analisis.Text = cmbresponsable_analisis.SelectedValue.ToString
        End If
    End Sub

    Sub CargarMetodo_causa()
        Dim odt As New DataTable

        odt = oMetodo_causa.GetCmb
        With Me.cmbmetodo_causa
            .DataSource = odt
            .DisplayMember = "nombre_metodo_causa"
            .ValueMember = "id_metodo_causa"
        End With
        If Me.cmbmetodo_causa.SelectedIndex >= 0 Then
            cmbmetodo_causa.SelectedIndex = 0
            Me.lblid_metodo_causa.Text = cmbmetodo_causa.SelectedValue.ToString
        End If
    End Sub

    Sub CargarUsuario_accion_correctiva()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbusuario_accion_correctiva
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbusuario_accion_correctiva.SelectedIndex >= 0 Then
            cmbusuario_accion_correctiva.SelectedIndex = 0
            Me.lblid_usuario_accion_correctiva.Text = cmbusuario_accion_correctiva.SelectedValue.ToString
        End If
    End Sub

    Sub CargarUsuario_cierre()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbusuario_cierre
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbusuario_cierre.SelectedIndex >= 0 Then
            cmbusuario_cierre.SelectedIndex = 0
            Me.lblid_usuario_cierre.Text = cmbusuario_cierre.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtdescripcion_mejora.Text = ""
        Me.lblid_tipo_mejora.Text = "0"
        Me.cmbtipo_mejora.Text = ""
        'Me.lblid_sub_proyecto.Text = "0"
        'Me.cmbSub_proyecto.Text = ""
        Me.dtpfecha_prevista_cierre.Value = DateTime.Now
        Me.lblid_usuario_asignado.Text = "0"
        Me.cmbusuario_asignado.Text = ""
        Me.lblid_origen_mejora.Text = "0"
        Me.cmborigen_mejora.Text = ""
        Me.txtubicacion_archivos.Text = ""
        Me.lblid_responsable_analisis.Text = "0"
        Me.cmbresponsable_analisis.Text = ""
        Me.txtdescripcion_causa.Text = ""
        Me.lblid_metodo_causa.Text = "0"
        Me.cmbmetodo_causa.Text = ""
        Me.dtpfecha_causa.Value = DateTime.Now
        Me.dtpfecha_finalizacion_accion.Value = DateTime.Now
        Me.lblid_usuario_accion_correctiva.Text = "0"
        Me.cmbusuario_accion_correctiva.Text = ""
        Me.txtdescripcion_accion_correctiva.Text = ""
        Me.txtprevision_accion_correctiva.Text = ""
        Me.dtpfecha_accion_correctiva.Value = DateTime.Now
        Me.lblid_usuario_cierre.Text = "0"
        Me.cmbusuario_cierre.Text = ""
        Me.txtdescripcion_cierre.Text = ""
        Me.txtnumero_accion_relacionada.Text = "0"
        Me.txtcosto_prevencion.Text = "0"
        Me.txtcosto_acciones.Text = "0"
        Me.txtcosto_no_calidad.Text = "0"
        Me.txtcosto_total.Text = "0"
        Me.dtpfecha_cierre.Value = DateTime.Now
    End Sub

    Private Sub ObtenerDatos()
        Me.txtdescripcion_mejora.Text = oMejora.descripcion_mejora.Trim
        Me.lblid_tipo_mejora.Text = oMejora.id_tipo_mejora.ToString
        Me.lblid_sub_proyecto.Text = oMejora.id_sub_proyecto.ToString
        Me.dtpfecha_prevista_cierre.Value = oMejora.fecha_prevista_cierre
        Me.lblid_usuario_asignado.Text = oMejora.id_usuario_asignado.ToString
        Me.lblid_origen_mejora.Text = oMejora.id_origen_mejora.ToString
        Me.txtubicacion_archivos.Text = oMejora.ubicacion_archivos.Trim
        Me.lblid_responsable_analisis.Text = oMejora.id_responsable_analisis.ToString
        Me.txtdescripcion_causa.Text = oMejora.descripcion_causa.Trim
        Me.lblid_metodo_causa.Text = oMejora.id_metodo_causa.ToString
        Me.dtpfecha_causa.Value = oMejora.fecha_causa
        Me.dtpfecha_finalizacion_accion.Value = oMejora.fecha_finalizacion_accion
        Me.lblid_usuario_accion_correctiva.Text = oMejora.id_usuario_accion_correctiva.ToString
        Me.txtdescripcion_accion_correctiva.Text = oMejora.descripcion_accion_correctiva.Trim
        Me.txtprevision_accion_correctiva.Text = oMejora.prevision_accion_correctiva.Trim
        Me.dtpfecha_accion_correctiva.Value = oMejora.fecha_accion_correctiva
        Me.lblid_usuario_cierre.Text = oMejora.id_usuario_cierre.ToString
        Me.txtdescripcion_cierre.Text = oMejora.descripcion_cierre.Trim
        Me.txtnumero_accion_relacionada.Text = oMejora.numero_accion_relacionada.ToString.Trim
        Me.txtcosto_prevencion.Text = oMejora.costo_prevencion.ToString.Trim
        Me.txtcosto_acciones.Text = oMejora.costo_acciones.ToString.Trim
        Me.txtcosto_no_calidad.Text = oMejora.costo_no_calidad.ToString.Trim
        Me.txtcosto_total.Text = oMejora.costo_total.ToString.Trim
        Me.dtpfecha_cierre.Value = oMejora.fecha_cierre

        Select Case oMejora.prioridad
            Case 1
                Me.rbtAlta.Checked = True
            Case 2
                Me.rbtMedia.Checked = True
            Case 3
                Me.rbtBaja.Checked = True
        End Select

        Select Case oMejora.id_estado_mejora
            Case 1
                Me.rbtProgramada.Checked = True
            Case 2
                Me.rbtSuspendida.Checked = True
            Case 3
                Me.rbtCancelada.Checked = True
            Case 4
                Me.rbtFinalizada.Checked = True
        End Select

        Select Case oMejora.analisis_eficacia
            Case "E"
                Me.rbtEficaz.Checked = True
            Case "P"
                Me.rbtPocoEficaz.Checked = True
            Case "N"
                Me.rbtNoEficaz.Checked = True
        End Select
    End Sub

    Private Sub AsignarDatos()
        oMejora.descripcion_mejora = Me.txtdescripcion_mejora.Text
        oMejora.id_tipo_mejora = CInt(Me.lblid_tipo_mejora.Text)
        oMejora.id_sub_proyecto = CInt(Me.lblid_sub_proyecto.Text)
        oMejora.fecha_prevista_cierre = Me.dtpfecha_prevista_cierre.Value.Date
        oMejora.id_usuario_asignado = CInt(Me.lblid_usuario_asignado.Text)
        oMejora.id_origen_mejora = CInt(Me.lblid_origen_mejora.Text)
        oMejora.ubicacion_archivos = Me.txtubicacion_archivos.Text
        oMejora.id_responsable_analisis = CInt(Me.lblid_responsable_analisis.Text)
        oMejora.descripcion_causa = Me.txtdescripcion_causa.Text
        oMejora.id_metodo_causa = CInt(Me.lblid_metodo_causa.Text)
        oMejora.fecha_causa = Me.dtpfecha_causa.Value.Date
        oMejora.fecha_finalizacion_accion = Me.dtpfecha_finalizacion_accion.Value.Date
        oMejora.id_usuario_accion_correctiva = CInt(Me.lblid_usuario_accion_correctiva.Text)
        oMejora.descripcion_accion_correctiva = Me.txtdescripcion_accion_correctiva.Text
        oMejora.prevision_accion_correctiva = Me.txtprevision_accion_correctiva.Text
        oMejora.fecha_accion_correctiva = Me.dtpfecha_accion_correctiva.Value.Date
        oMejora.id_usuario_cierre = CInt(Me.lblid_usuario_cierre.Text)
        oMejora.descripcion_cierre = Me.txtdescripcion_cierre.Text
        oMejora.numero_accion_relacionada = CDec(Me.txtnumero_accion_relacionada.Text)
        oMejora.costo_prevencion = CDec(Me.txtcosto_prevencion.Text)
        oMejora.costo_acciones = CDec(Me.txtcosto_acciones.Text)
        oMejora.costo_no_calidad = CDec(Me.txtcosto_no_calidad.Text)
        oMejora.costo_total = CDec(Me.txtcosto_total.Text)
        oMejora.fecha_cierre = Me.dtpfecha_cierre.Value.Date

        If Me.rbtAlta.Checked = True Then
            oMejora.prioridad = 1
        ElseIf Me.rbtMedia.Checked = True Then
            oMejora.prioridad = 2
        ElseIf Me.rbtBaja.Checked = True Then
            oMejora.prioridad = 3
        End If

        If Me.rbtProgramada.Checked = True Then
            oMejora.id_estado_mejora = 1
        ElseIf Me.rbtSuspendida.Checked = True Then
            oMejora.id_estado_mejora = 2
        ElseIf Me.rbtCancelada.Checked = True Then
            oMejora.id_estado_mejora = 3
        ElseIf Me.rbtFinalizada.Checked = True Then
            oMejora.id_estado_mejora = 4
        End If

        If Me.rbtEficaz.Checked = True Then
            oMejora.analisis_eficacia = "E"
        ElseIf Me.rbtPocoEficaz.Checked = True Then
            oMejora.analisis_eficacia = "P"
        ElseIf Me.rbtNoEficaz.Checked = True Then
            oMejora.analisis_eficacia = "N"
        End If

    End Sub

    Public Sub SoloLectura()
        Me.txtdescripcion_mejora.Enabled = False
        Me.cmbtipo_mejora.Enabled = False
        Me.btnBuscatipo_mejora.Enabled = False
        Me.cmbSub_proyecto.Enabled = False
        Me.dtpfecha_prevista_cierre.Enabled = False
        Me.cmbusuario_asignado.Enabled = False
        Me.cmborigen_mejora.Enabled = False
        Me.btnBuscaorigen_mejora.Enabled = False
        Me.txtubicacion_archivos.Enabled = False
        Me.cmbresponsable_analisis.Enabled = False
        Me.txtdescripcion_causa.Enabled = False
        Me.cmbmetodo_causa.Enabled = False
        Me.btnBuscametodo_causa.Enabled = False
        Me.dtpfecha_causa.Enabled = False
        Me.dtpfecha_finalizacion_accion.Enabled = False
        Me.cmbusuario_accion_correctiva.Enabled = False
        Me.txtdescripcion_accion_correctiva.Enabled = False
        Me.txtprevision_accion_correctiva.Enabled = False
        Me.dtpfecha_accion_correctiva.Enabled = False
        Me.cmbusuario_cierre.Enabled = False
        Me.txtdescripcion_cierre.Enabled = False
        Me.txtnumero_accion_relacionada.Enabled = False
        Me.txtcosto_prevencion.Enabled = False
        Me.txtcosto_acciones.Enabled = False
        Me.txtcosto_no_calidad.Enabled = False
        Me.txtcosto_total.Enabled = False
        Me.dtpfecha_cierre.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oMejora.Exist() Then
                If BanderaMejora = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaMejora = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaMejora
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oMejora.Guardar()

                    oMejora_accion.UpdateID(oMejora.id_mejora)

                    frmAbmTarea.RefrescarGrillaMejora()

                    RefrescarGrillaMejoraAccion()
                    Me.CargarCombos()
                    oMejora.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtdescripcion_mejora.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oMejora.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If _
       Me.txtdescripcion_mejora.Text = "" Or
       Me.txtnumero_accion_relacionada.Text = "" Or
       Me.txtcosto_prevencion.Text = "" Or
       Me.txtcosto_acciones.Text = "" Or
       Me.txtcosto_no_calidad.Text = "" Or
       Me.txtcosto_total.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_tipo_mejora.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_mejora")
            Me.lblid_tipo_mejora.Text = "1"
            ' Exit Sub
        End If
        If CDbl(Me.lblid_sub_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de sub_proyecto")
            Exit Sub
        End If
        If CDbl(Me.lblid_usuario_asignado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario_asignado")
            Exit Sub
        End If
        If CDbl(Me.lblid_origen_mejora.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de origen_mejora")
            Me.lblid_origen_mejora.Text = "1"
            ' Exit Sub
        End If
        If CDbl(Me.lblid_responsable_analisis.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de responsable_analisis")
            Me.lblid_responsable_analisis.Text = "1"
            ' Exit Sub
        End If
        If CDbl(Me.lblid_metodo_causa.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de metodo_causa")
            Me.lblid_metodo_causa.Text = "1"
            ' Exit Sub
        End If
        If CDbl(Me.lblid_usuario_accion_correctiva.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario_accion_correctiva")
            Me.lblid_usuario_accion_correctiva.Text = "1"
            ' Exit Sub
        End If
        If CDbl(Me.lblid_usuario_cierre.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario_cierre")
            Me.lblid_usuario_cierre.Text = "1"
            ' Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaMejora = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbTipo_mejora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_mejora.SelectedIndexChanged
        If Me.cmbtipo_mejora.SelectedIndex >= 0 Then
            Me.lblid_tipo_mejora.Text = cmbtipo_mejora.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaTipo_mejora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_mejora.Click
        Dim frmTemporal As New frmAbmTipo_mejora
        frmTemporal.ShowDialog()
        Me.CargarTipo_mejora()
        Me.cmbtipo_mejora.Focus()
        Me.cmbtipo_mejora.Text = ""
        Me.lblid_tipo_mejora.Text = "0"
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


    Private Sub cmbUsuario_asignado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario_asignado.SelectedIndexChanged
        If Me.cmbusuario_asignado.SelectedIndex >= 0 Then
            Me.lblid_usuario_asignado.Text = cmbusuario_asignado.SelectedValue.ToString
        End If
    End Sub



    Private Sub cmbOrigen_mejora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborigen_mejora.SelectedIndexChanged
        If Me.cmborigen_mejora.SelectedIndex >= 0 Then
            Me.lblid_origen_mejora.Text = cmborigen_mejora.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaOrigen_mejora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaorigen_mejora.Click
        Dim frmTemporal As New frmAbmOrigen_mejora
        frmTemporal.ShowDialog()
        Me.CargarOrigen_mejora()
        Me.cmborigen_mejora.Focus()
        Me.cmborigen_mejora.Text = ""
        Me.lblid_origen_mejora.Text = "0"
    End Sub

    Private Sub cmbResponsable_analisis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbresponsable_analisis.SelectedIndexChanged
        If Me.cmbresponsable_analisis.SelectedIndex >= 0 Then
            Me.lblid_responsable_analisis.Text = cmbresponsable_analisis.SelectedValue.ToString
        End If
    End Sub



    Private Sub cmbMetodo_causa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmetodo_causa.SelectedIndexChanged
        If Me.cmbmetodo_causa.SelectedIndex >= 0 Then
            Me.lblid_metodo_causa.Text = cmbmetodo_causa.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaMetodo_causa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemporal As New frmAbmMetodo_causa
        frmTemporal.ShowDialog()
        Me.CargarMetodo_causa()
        Me.cmbmetodo_causa.Focus()
        Me.cmbmetodo_causa.Text = ""
        Me.lblid_metodo_causa.Text = "0"
    End Sub

    Private Sub cmbUsuario_accion_correctiva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario_accion_correctiva.SelectedIndexChanged
        If Me.cmbusuario_accion_correctiva.SelectedIndex >= 0 Then
            Me.lblid_usuario_accion_correctiva.Text = cmbusuario_accion_correctiva.SelectedValue.ToString
        End If
    End Sub


    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion_accion_correctiva.KeyPress,
        txtdescripcion_cierre.KeyPress, txtdescripcion_mejora.KeyPress, txtprevision_accion_correctiva.KeyPress

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbCod_empresa.KeyDown, cmbCod_Proyecto.KeyDown, cmbCod_sub_proyecto.KeyDown, cmbEmpresa.KeyDown, cmbmetodo_causa.KeyDown, cmborigen_mejora.KeyDown, cmbproyecto.KeyDown, _
   cmbresponsable_analisis.KeyDown, cmbSub_proyecto.KeyDown, cmbtipo_mejora.KeyDown, cmbusuario_accion_correctiva.KeyDown, cmbusuario_asignado.KeyDown, cmbusuario_cierre.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcosto_acciones.KeyPress, txtcosto_no_calidad.KeyPress, txtcosto_prevencion.KeyPress, _
        txtcosto_total.KeyPress, txtnumero_accion_relacionada.KeyPress

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

    Private Sub btnPathCroquis_Click(sender As Object, e As EventArgs) Handles btnPathCroquis.Click
        Dim BuscarImagen As New FolderBrowserDialog
        BuscarImagen.SelectedPath = Me.txtubicacion_archivos.Text
        If BuscarImagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtubicacion_archivos.Text = BuscarImagen.SelectedPath
        End If
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleMejora_accion
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaMejora_accion = 1
                    Me.AddOwnedForm(frmDetalle)
                    oMejora_accion.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaMejoraAccion()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_mejora_accion.Text) Then
                        Exit Sub
                    End If
                    BanderaMejora_accion = 2
                    Me.AddOwnedForm(frmDetalle)
                    oMejora_accion.Modificar(CInt(Me.lblid_mejora_accion.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaMejoraAccion()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_mejora_accion.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oMejora_accion.Borrar(CInt(Me.lblid_mejora_accion.Text))
                    RefrescarGrillaMejoraAccion()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvMejoraAccion_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvMejoraAccion.CurrentCellChanged
        Try
            Me.lblid_mejora_accion.Text = CStr(Me.dgvMejoraAccion.Item(0, Me.dgvMejoraAccion.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbusuario_cierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbusuario_cierre.SelectedIndexChanged
        If Me.cmbusuario_cierre.SelectedIndex >= 0 Then
            Me.lblid_usuario_cierre.Text = cmbusuario_cierre.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnAbrirExplorador_Click(sender As Object, e As EventArgs) Handles btnAbrirExplorador.Click
        Shell("explorer.exe " & Me.txtubicacion_archivos.Text)
    End Sub

    Private Sub tpCierre_Click(sender As Object, e As EventArgs) Handles tpCierre.Click

    End Sub

    Private Sub etiquetadescripcion_mejora_Click(sender As Object, e As EventArgs) Handles etiquetadescripcion_mejora.Click

    End Sub
End Class
