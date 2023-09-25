Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop

Public Class frmAbmTarea

    Dim odt As DataTable
    Dim BanderaConsultaTarea As Integer
    Dim columnaseleccionada As Integer

    Private Sub frmAbmTarea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Tarea")
        Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Tarea Existente")
        Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Tarea Existente")
        'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Tarea Existente")
        parametro_tarea_general = 1 'usuario
        Dim odt As DataTable
        Dim odt2 As DataTable

        odt = oTarea.Cargar()
        odt2 = oMejora.Cargar

        Me.txtidentificador.Text = vgNombreUsuario
        CargarCombos()



        If vgCodigoTipoUsuario = 3 Then
            rbtUsuario.Visible = False
            cmbUsuario.Visible = False
            btnBuscar_usuario.Visible = False
        End If




        ' Me.lblTitulo.Text = "Tarea"
        '  Me.Text = "Tarea" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        ' Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        'Me.MinimizeBox = False
        'Me.MaximizeBox = False
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        LimpiarCombos()
        Me.cmbUsuario.SelectedValue = vgCodigoUsuario
        Me.lblid_usuario_asignado.Text = CStr(vgCodigoUsuario)

        Me.lblid_estado_tarea.Text = "1"
        Me.cmbestado_tarea.Text = "Programada"

        If vgTareaMejora = 1 Then
            Me.chkActivo_mejora.Checked = False
        Else
            Me.chkActivo_mejora.Checked = True
        End If


        If chkActivo_mejora.Checked Then
            RefrescarGrillaMejora()
            Me.PictureBox1.Image = My.Resources.mejorasgris
        Else
            RefrescarGrillaTarea()
            Me.PictureBox1.Image = My.Resources.tareasgris
        End If

        Me.RefrescarDashboard()

    End Sub

    Sub LimpiarCombos()
        Me.cmbCod_empresa.Text = ""
        Me.cmbCod_Proyecto.Text = ""
        Me.cmbCod_sub_proyecto.Text = ""
        Me.cmbEmpresa.Text = ""
        Me.cmbestado_tarea.Text = ""
        Me.cmbproyecto.Text = ""
        Me.cmbSub_proyecto.Text = ""
        Me.cmbEstado_mejora.Text = ""
        Me.cmbTipo_mejora.Text = ""
        Me.lblid_empresa.Text = "0"
        Me.lblid_estado_tarea.Text = "0"
        Me.lblid_proyecto.Text = "0"
        Me.lblid_sub_proyecto.Text = "0"
        Me.lblid_estado_mejora.Text = "0"
        Me.lblid_tipo_mejora.Text = "0"
    End Sub
    Sub CargarCombos()
        Me.CargarEmpresa()
        Me.CargarCod_Empresa()
        Me.CargarProyecto()
        Me.CargarCod_Proyecto()
        Me.CargarSub_Proyecto()
        Me.CargarCod_Sub_Proyecto()
        Me.CargarUsuario()
        Me.CargarEstado_mejora()
        Me.CargarTipo_mejora()
        Me.CargarEstado_tarea()
        Me.CargarTipo_tarea()
    End Sub

    Public Sub RefrescarGrillaMejora()



        Dim odt As DataTable
        Dim Maximo_x_Pagina As Integer = 40 'por defecto

        odt = oMejora.GetAllMaestroODT(parametro_tarea_general, CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proyecto.Text), CInt(Me.lblid_sub_proyecto.Text), CInt(Me.lblid_usuario_asignado.Text),
                                      CInt(Me.lblid_estado_mejora.Text), parametro_tarea_estado, chktodo.Checked, chkAsigando.Checked, chkTipo_tarea.Checked, chkFecha_filtro.Checked,
                                      CInt(Me.lblid_tipo_mejora.Text), Me.dtpFecha_desde.Value, Me.dtpFecha_hasta.Value)
        Paginar("Mejora", Maximo_x_Pagina,
                oMejora.GetAllMaestroODS(parametro_tarea_general, CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proyecto.Text), CInt(Me.lblid_sub_proyecto.Text), CInt(Me.lblid_usuario_asignado.Text),
                                      CInt(Me.lblid_estado_mejora.Text), parametro_tarea_estado, chktodo.Checked, chkAsigando.Checked, chkTipo_tarea.Checked, chkFecha_filtro.Checked,
                                      CInt(Me.lblid_tipo_mejora.Text), Me.dtpFecha_desde.Value, Me.dtpFecha_hasta.Value))

        Me.dgv1.DataSource = Cargar()
        Me.dgv1.DataMember = "Mejora"
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv1.Columns(1).DefaultCellStyle.Font = New Font(dgv1.Font, FontStyle.Bold)
        Me.dgv1.Columns(2).DefaultCellStyle.Font = New Font(dgv1.Font, FontStyle.Bold)

        Me.dgv1.ContextMenuStrip = Nothing

        Actualizar()
    End Sub

    Public Sub RefrescarGrillaTarea()
        Dim odt As DataTable
        Dim Maximo_x_Pagina As Integer = 60 'por defecto

        odt = oTarea.GetAllMaestroODT(parametro_tarea_general, CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proyecto.Text), CInt(Me.lblid_sub_proyecto.Text), CInt(Me.lblid_usuario_asignado.Text),
                                      CInt(Me.lblid_estado_tarea.Text), parametro_tarea_estado, chktodo.Checked, chkAsigando.Checked, chkTipo_tarea.Checked, chkFecha_filtro.Checked,
                                      CInt(Me.lblid_tipo_tarea.Text), Me.dtpFecha_desde.Value, Me.dtpFecha_hasta.Value)
        Paginar("Tarea", Maximo_x_Pagina,
                oTarea.GetAllMaestroODS(parametro_tarea_general, CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proyecto.Text), CInt(Me.lblid_sub_proyecto.Text),
                                        CInt(Me.lblid_usuario_asignado.Text), CInt(Me.lblid_estado_tarea.Text), parametro_tarea_estado, chktodo.Checked, chkAsigando.Checked, chkTipo_tarea.Checked,
                                        chkFecha_filtro.Checked, CInt(Me.lblid_tipo_tarea.Text), Me.dtpFecha_desde.Value, Me.dtpFecha_hasta.Value))

        Me.dgv1.DataSource = Cargar()
        Me.dgv1.DataMember = "Tarea"
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv1.Columns(1).DefaultCellStyle.Font = New Font(dgv1.Font, FontStyle.Bold)
        Me.dgv1.Columns(2).DefaultCellStyle.Font = New Font(dgv1.Font, FontStyle.Bold)

        Dim real As Decimal = 0
        Dim estimada As Decimal = 0
        For Each row As DataRow In odt.Rows
            real = real + CDec(row("hora real"))
            estimada = estimada + CDec(row("hora prevista"))
        Next

        Me.lblHorasEstimadas.Text = CStr(estimada)
        Me.lblHorasReales.Text = CStr(real)
        Me.dgv1.ContextMenuStrip = Me.ContextMenuStrip1

        Actualizar()
    End Sub

    Sub RefrescarDashboard()
        Dim odt As New DataTable

        odt = oTarea.GetAllDashboard(vgCodigoUsuario, Date.Now)

        If odt.Rows.Count > 0 Then
            Me.btnPendientes.Text = CStr(odt.Rows(0).Item("pendiente"))
            Me.btnRetrasadas.Text = CStr(odt.Rows(0).Item("retrasada"))
            Me.btnPrioritarias.Text = CStr(odt.Rows(0).Item("prioritaria"))
            Me.btnHoy.Text = CStr(odt.Rows(0).Item("hoy"))
        End If
    End Sub

    Sub RefrescarGrillaDashboard(ByVal consulta As Integer)
        Dim odt As DataTable
        Dim Maximo_x_Pagina As Integer = 60 'por defecto

        odt = oTarea.GetAllMaestroDashboard(vgCodigoUsuario, Date.Now, consulta)
        Paginar("Tarea", Maximo_x_Pagina,
                oTarea.GetAllMaestroODSDashboard(vgCodigoUsuario, Date.Now, consulta))

        Me.dgv1.DataSource = Cargar()
        Me.dgv1.DataMember = "Tarea"
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv1.Columns(1).DefaultCellStyle.Font = New Font(dgv1.Font, FontStyle.Bold)
        Me.dgv1.Columns(2).DefaultCellStyle.Font = New Font(dgv1.Font, FontStyle.Bold)

        Dim real As Decimal = 0
        Dim estimada As Decimal = 0
        For Each row As DataRow In odt.Rows
            real = real + CDec(row("hora real"))
            estimada = estimada + CDec(row("hora prevista"))
        Next

        Me.lblHorasEstimadas.Text = CStr(estimada)
        Me.lblHorasReales.Text = CStr(real)
        Me.dgv1.ContextMenuStrip = Me.ContextMenuStrip1

        Actualizar()
    End Sub
    Public Sub Actualizar()
        maskedTextBox1.Text = countRow.ToString
        maskedTextBox2.Text = NumPag.ToString
        maskedTextBox3.Text = countPag.ToString
        maskedTextBox4.Text = LimiteRow.ToString
    End Sub

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

    Sub CargarEstado_tarea()
        Dim odt As New DataTable

        odt = oEstado_tarea.GetCmb
        With Me.cmbestado_tarea
            .DataSource = odt
            .DisplayMember = "nombre_estado_tarea"
            .ValueMember = "id_estado_tarea"
        End With
        If Me.cmbestado_tarea.SelectedIndex >= 0 Then
            cmbestado_tarea.SelectedIndex = 0
            Me.lblid_estado_tarea.Text = cmbestado_tarea.SelectedValue.ToString
        End If
    End Sub

    Sub CargarEstado_mejora()
        Dim odt As New DataTable

        odt = oEstado_mejora.GetCmb
        With Me.cmbEstado_mejora
            .DataSource = odt
            .DisplayMember = "nombre_estado_mejora"
            .ValueMember = "id_estado_mejora"
        End With
        If Me.cmbEstado_mejora.SelectedIndex >= 0 Then
            cmbEstado_mejora.SelectedIndex = 0
            Me.lblid_estado_mejora.Text = cmbEstado_mejora.SelectedValue.ToString
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
    Sub CargarUsuario()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbUsuario
            .DataSource = odt
            .DisplayMember = "identificador"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbUsuario.SelectedIndex >= 0 Then
            cmbUsuario.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbUsuario.SelectedValue.ToString
        End If
    End Sub

    Sub CargarTipo_mejora()
        Dim odt As New DataTable

        odt = oTipo_mejora.GetCmb
        With Me.cmbTipo_mejora
            .DataSource = odt
            .DisplayMember = "nombre_tipo_mejora"
            .ValueMember = "id_tipo_mejora"
        End With
        If Me.cmbTipo_mejora.SelectedIndex >= 0 Then
            cmbTipo_mejora.SelectedIndex = 0
            Me.lblid_tipo_mejora.Text = cmbTipo_mejora.SelectedValue.ToString
        End If
    End Sub

    Sub CargarTipo_tarea()
        Dim odt As New DataTable

        odt = oTipo_tarea.GetCmb
        With Me.cmbTipo_tarea
            .DataSource = odt
            .DisplayMember = "nombre_tipo_tarea"
            .ValueMember = "id_tipo_tarea"
        End With
        If Me.cmbTipo_tarea.SelectedIndex >= 0 Then
            cmbTipo_tarea.SelectedIndex = 0
            Me.lblid_tipo_tarea.Text = cmbTipo_tarea.SelectedValue.ToString
        End If
    End Sub

    Public Sub Combos(sender As Object, e As EventArgs) Handles rbtEmpresa.CheckedChanged, rbtProyecto.CheckedChanged, rbtSubProyecto.CheckedChanged,
    rbtUsuario.CheckedChanged
        Dim rbtTemp As New RadioButton
        rbtTemp = CType(sender, RadioButton)


        Select Case rbtTemp.Name
            'Case "chktodo"
            '    parametro_tarea_general = 1
            'cmbEmpresa.Enabled = False
            'cmbproyecto.Enabled = False
            'cmbSub_proyecto.Enabled = False
            'cmbUsuario.Enabled = False
            Case "rbtEmpresa"
                parametro_tarea_general = 1
                'cmbEmpresa.Enabled = True
                'cmbproyecto.Enabled = False
                'cmbSub_proyecto.Enabled = False
                'cmbUsuario.Enabled = False
                'CargarEmpresa()
            Case "rbtProyecto"
                parametro_tarea_general = 2
                'cmbEmpresa.Enabled = False
                'cmbproyecto.Enabled = True
                'cmbSub_proyecto.Enabled = False
                'cmbUsuario.Enabled = False
                'CargarProyecto()
            Case "rbtSubProyecto"
                parametro_tarea_general = 3
                'cmbEmpresa.Enabled = False
                'cmbproyecto.Enabled = False
                'cmbSub_proyecto.Enabled = True
                'cmbUsuario.Enabled = False
                'CargarSub_Proyecto()
            Case Else
                parametro_tarea_general = 1
                'cmbEmpresa.Enabled = False
                'cmbproyecto.Enabled = False
                'cmbSub_proyecto.Enabled = False
                'cmbUsuario.Enabled = False
        End Select
    End Sub



    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            If chkActivo_mejora.Checked Then
                Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
                Me.lblid_estado_tarea_grilla.Text = "0"
            Else
                Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
                Dim odt As New DataTable
                odt = oTarea.GetOne(CInt(Me.lblid_pk.Text))

                If odt.Rows.Count > 0 Then
                    Me.lblid_estado_tarea_grilla.Text = CStr(odt.Rows(0).Item("id estado tarea"))
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click,
         btnBorrar.Click, btnModificar.Click, btnSalir.Click, Button4.Click, Button3.Click, Button2.Click

        Dim btnTemp As New Button
        'Dim frmDetalle As New frmDetalleTarea_2
        btnTemp = CType(sender, Button)
        Dim i As Integer = 0


        Try

            If Me.dgv1.RowCount > 0 Then
                i = Me.dgv1.CurrentRow.Index
            Else
                i = 0
            End If


            Select Case btnTemp.Name
                Case "btnAgregar"
                    If chkActivo_mejora.Checked Then
                        BanderaMejora = 1
                        '  Me.AddOwnedForm(frmDetalle)
                        oMejora.Insertar()
                        frmDetalleMejora.ShowDialog()
                        frmDetalleMejora.Dispose()
                        '  frmDetalle.ShowDialog()
                    Else
                        BanderaTarea = 1
                        '  Me.AddOwnedForm(frmDetalle)
                        oTarea.Insertar()
                        frmDetalleTarea_2.ShowDialog()
                        frmDetalleTarea_2.Dispose()
                        '  frmDetalle.ShowDialog()
                    End If

                    Me.dgv1.CurrentCell = Me.dgv1.Rows(i).Cells(1)
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If chkActivo_mejora.Checked Then
                        BanderaMejora = 2
                        'Me.AddOwnedForm(frmDetalle)
                        oMejora.Modificar(CInt(Me.lblid_pk.Text))

                        frmDetalleMejora.ShowDialog()
                        frmDetalleMejora.Dispose()
                        'frmDetalle.ShowDialog()
                        RefrescarGrillaMejora()
                    Else
                        BanderaTarea = 2
                        'Me.AddOwnedForm(frmDetalle)
                        oTarea.Modificar(CInt(Me.lblid_pk.Text))

                        'enabled false cuando esta finalizada
                        If Me.lblid_estado_tarea_grilla.Text = "4" Then
                            frmDetalleTarea_2.Panel1.Enabled = False
                            frmDetalleTarea_2.btnGuardar.Enabled = False
                            'frmDetalle.Panel1.Enabled = False
                        End If
                        frmDetalleTarea_2.ShowDialog()
                        frmDetalleTarea_2.Dispose()
                        'frmDetalle.ShowDialog()
                        RefrescarGrillaTarea()
                    End If


                    If i = 0 Then
                        Exit Select
                    End If
                    Me.dgv1.CurrentCell = Me.dgv1.Rows(i).Cells(1)
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If


                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    If chkActivo_mejora.Checked Then
                        oMejora.Borrar(CInt(Me.lblid_pk.Text))
                        RefrescarGrillaMejora()
                    Else
                        oTarea.Borrar(CInt(Me.lblid_pk.Text))
                        RefrescarGrillaTarea()
                    End If

                    Me.dgv1.CurrentCell = Me.dgv1.Rows(i + 1).Cells(1)
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmTarea.avi")
                Case "btnSalir"
                    Me.Close()
            End Select

        Catch ex As Exception
            MessageBox.Show("Grilla Reorganizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbproyecto.KeyDown, cmbEmpresa.KeyDown, cmbSub_proyecto.KeyDown, cmbUsuario.KeyDown, cmbestado_tarea.KeyDown, cmbTipo_tarea.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If chkActivo_mejora.Checked Then
            Me.RefrescarGrillaMejora()
        Else
            Me.RefrescarGrillaTarea()
        End If
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim frmTemp As New frmReporteTarea
        frmTemp.ShowDialog()
    End Sub


    Private Sub cmbProyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproyecto.SelectedIndexChanged
        If Me.cmbproyecto.SelectedIndex >= 0 And IsNumeric(cmbproyecto.SelectedValue) Then
            Me.lblid_proyecto.Text = cmbproyecto.SelectedValue.ToString
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbCod_Proyecto.SelectedValue = Me.cmbproyecto.SelectedValue
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
        'If Me.cmbproyecto.SelectedIndex >= 0 And IsNumeric(cmbproyecto.SelectedValue) Then
        '    Me.lblid_proyecto.Text = cmbproyecto.SelectedValue.ToString
        'End If
        'If Not IsNumeric(Me.lblid_proyecto.Text) Then
        '    Exit Sub
        'End If
        'Me.CargarSub_Proyecto()
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
        'If Me.cmbEmpresa.SelectedIndex >= 0 And IsNumeric(cmbEmpresa.SelectedValue) Then
        '    Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        'End If
        'If Not IsNumeric(Me.lblid_empresa.Text) Then
        '    Exit Sub
        'End If
        'Me.CargarProyecto()
    End Sub

    Private Sub cmbSub_proyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSub_proyecto.SelectedIndexChanged
        If Me.cmbSub_proyecto.SelectedIndex >= 0 And IsNumeric(cmbSub_proyecto.SelectedValue) Then
            Me.lblid_sub_proyecto.Text = cmbSub_proyecto.SelectedValue.ToString
            Me.cmbCod_sub_proyecto.SelectedValue = Me.cmbSub_proyecto.SelectedValue
        End If
        'If Me.cmbSub_proyecto.SelectedIndex >= 0 And IsNumeric(cmbSub_proyecto.SelectedValue) Then
        '    Me.lblid_sub_proyecto.Text = cmbSub_proyecto.SelectedValue.ToString
        'End If
        'If Not IsNumeric(Me.lblid_sub_proyecto.Text) Then
        '    Exit Sub
        'End If
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged

        If Me.cmbUsuario.SelectedIndex >= 0 And IsNumeric(cmbUsuario.SelectedValue) Then
            Me.lblid_usuario_asignado.Text = cmbUsuario.SelectedValue.ToString

        End If
    End Sub
    Private Sub cmbestado_tarea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbestado_tarea.SelectedIndexChanged
        If Me.cmbestado_tarea.SelectedIndex >= 0 And IsNumeric(cmbestado_tarea.SelectedValue) Then
            Me.lblid_estado_tarea.Text = cmbestado_tarea.SelectedValue.ToString
            'Try
            '    parametro_tarea_general = 6
            '    RefrescarGrilla()

            'Catch ex As Exception

            'End Try

        End If
    End Sub

#Region "Botones Buscar"
    Private Sub btnBuscaProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproyecto.Click
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



    Private Sub btnBuscar_empresa_Click(sender As Object, e As EventArgs) Handles btnBuscar_empresa.Click

        frmAbmEmpresa.ShowDialog()
        frmAbmEmpresa.Dispose()

        Me.CargarEmpresa()
        Me.CargarCod_Empresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.cmbCod_empresa.Text = ""
        Me.lblid_empresa.Text = "0"
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

    Private Sub btnBuscar_usuario_Click(sender As Object, e As EventArgs) Handles btnBuscar_usuario.Click
        'Dim frmTemporal As New frmAbmUsuario
        'frmTemporal.ShowDialog()

        frmAbmUsuario.ShowDialog()
        frmAbmUsuario.Dispose()

        Me.CargarUsuario()
        Me.cmbUsuario.Focus()
        Me.cmbUsuario.Text = ""
        Me.lblid_usuario_asignado.Text = "0"
    End Sub
#End Region

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        parametro_tarea_estado = chkEstado.Checked
    End Sub

    Private Sub btnActualizar_Maximo_Click(sender As Object, e As EventArgs) Handles btnActualizar_Maximo.Click
        ActualizarTope(CInt(maskedTextBox4.Text))
        Actualizar()
    End Sub

    Private Sub btnPrimera_Pagina_Click(sender As Object, e As EventArgs) Handles btnPrimera_Pagina.Click
        PrimeraPagina()
        Actualizar()
    End Sub

    Private Sub btnUltima_Pagina_Click(sender As Object, e As EventArgs) Handles btnUltima_Pagina.Click
        UltimaPagina()
        Actualizar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Atras()
        Actualizar()
    End Sub

    Private Sub btnSiguente_Click(sender As Object, e As EventArgs) Handles btnSiguente.Click
        Adelante()
        Actualizar()
    End Sub

    'Private Sub cmbEmpresa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmpresa.LostFocus
    '    Try
    '        Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub dgv1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv1.CellFormatting

        If Me.dgv1.Columns(e.ColumnIndex).Name = "Estado" Then
            Dim Valor_Estado As String = CStr(e.Value)
            Dim row As DataGridViewRow = dgv1.Rows(e.RowIndex)

            If Valor_Estado = "Finalizada" Or Valor_Estado = "Cancelada" Then
                row.DefaultCellStyle.ForeColor = Color.Gray

            ElseIf Valor_Estado = "Suspendida" Then
                row.DefaultCellStyle.ForeColor = Color.Orange

            Else
                row.DefaultCellStyle.ForeColor = Color.Black
            End If


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

    Private Sub dgv1_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then

            ' Si se ha pulsado el botón derecho del ratón,
            ' seleccionamos la fila completa del control
            ' DataGridView.
            '
            With dgv1

                Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)

                ' Obtenemos la parte del control a las que
                ' pertenecen las coordenadas.
                '
                If hti.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell =
                    .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                End If

            End With
        End If
    End Sub

    Private Sub FinalizadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizadoToolStripMenuItem.Click, CanceladoToolStripMenuItem.Click, ProgramadaToolStripMenuItem.Click,
        SuspendidaToolStripMenuItem.Click
        Dim TSTemp As New ToolStripMenuItem
        TSTemp = CType(sender, ToolStripMenuItem)
        Dim id_estado_tarea As Integer = 0


        If IsNumeric(Me.lblid_pk.Text) Then

            Select Case TSTemp.Name

                Case "FinalizadoToolStripMenuItem"
                    id_estado_tarea = 4
                Case "CanceladoToolStripMenuItem"
                    id_estado_tarea = 3
                Case "ProgramadaToolStripMenuItem"
                    id_estado_tarea = 1
                Case "SuspendidaToolStripMenuItem"
                    id_estado_tarea = 2

            End Select

            With oTarea
                .Cargar()
                .Modificar(CInt(Me.lblid_pk.Text))
                .id_estado_tarea = id_estado_tarea

                If id_estado_tarea <> 1 Then
                    .fecha_real = DateTime.Today
                End If

                .Guardar()
            End With
        End If
        RefrescarGrillaTarea()

    End Sub

    Private Sub FechaActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaActualToolStripMenuItem.Click
        If IsNumeric(Me.lblid_pk.Text) Then
            With oTarea
                .Cargar()
                .Modificar(CInt(Me.lblid_pk.Text))
                .fecha_real = DateTime.Now
                .Guardar()
            End With
        End If
        RefrescarGrillaTarea()
    End Sub

    Private Sub FechaPersonalizadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaPersonalizadaToolStripMenuItem.Click
        If Not IsNumeric(Me.lblid_pk.Text) Then
            Exit Sub
        End If

        Dim frm As New frmtemp()
        Me.AddOwnedForm(frm)
        frm.ShowDialog()
        RefrescarGrillaTarea()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click, MediaToolStripMenuItem.Click, AltaToolStripMenuItem.Click
        Dim TSTemp As New ToolStripMenuItem
        TSTemp = CType(sender, ToolStripMenuItem)
        Dim prioridad As Integer = 0


        If IsNumeric(Me.lblid_pk.Text) Then

            Select Case TSTemp.Name

                Case "BajaToolStripMenuItem"
                    prioridad = 3
                Case "MediaToolStripMenuItem"
                    prioridad = 2
                Case "AltaToolStripMenuItem"
                    prioridad = 1

            End Select

            With oTarea
                .Cargar()
                .Modificar(CInt(Me.lblid_pk.Text))
                .prioridad = prioridad
                '  .fecha_real = DateTime.Today
                .Guardar()
            End With
        End If
        RefrescarGrillaTarea()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Select Case dgv1.CurrentCell.ColumnIndex
            Case 1
                CambiarEstadoToolStripMenuItem.Visible = True
                CambiarFechaToolStripMenuItem.Visible = False
                CambiarPrioridadToolStripMenuItem.Visible = False
            Case 2
                CambiarEstadoToolStripMenuItem.Visible = False
                CambiarFechaToolStripMenuItem.Visible = False
                CambiarPrioridadToolStripMenuItem.Visible = True
            Case 7
                CambiarEstadoToolStripMenuItem.Visible = False
                CambiarFechaToolStripMenuItem.Visible = True
                CambiarPrioridadToolStripMenuItem.Visible = False
            Case Else
                e.Cancel = True
        End Select
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick

        btnModificar.PerformClick()
    End Sub

    Private Sub etiquetaid_tipo_tarea_Click(sender As Object, e As EventArgs) Handles etiquetaid_tipo_tarea.Click

    End Sub

    Private Sub btnMailing_Click(sender As Object, e As EventArgs) Handles btnMailing.Click
        Dim frmDetalle As New frmMariling

        Me.AddOwnedForm(frmDetalle)
        frmDetalle.ShowDialog()
    End Sub

    Private Sub btnBuscarExcel_Click(sender As Object, e As EventArgs) Handles btnBuscarExcel.Click
        Try
            With ofdScript
                ' Vea btnRetriveFileNames_Click para obtener una explicación de los valores predeterminados
                ' de las propiedades.

                ' Comprobar que el archivo seleccionado existe. El cuadro de diálogo muestra
                ' una advertencia en caso contrario.
                .CheckFileExists = True

                ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra 
                ' una advertencia en caso contrario.
                .CheckPathExists = True

                ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
                .DefaultExt = "xls"

                ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo
                ' seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
                .DereferenceLinks = True

                ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada
                ' par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario
                ' poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el
                ' filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
                .Filter =
                "Archivos Excel (*.xls;*.xlsx)|*.xls;*.xlsx" '|All files|*.*"

                ' .Multiselect = False

                ' ¿Restaurar el directorio original después de seleccionar
                ' un archivo? Si False, el directorio actual cambia
                ' al directorio en el que seleccionó el archivo.
                ' Establézcalo como True para poner la carpeta actual de nuevo
                ' donde estaba cuando comenzó.
                ' El valor predeterminado es False.
                .RestoreDirectory = True

                ' ¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
                .ShowHelp = True
                .ShowReadOnly = False

                ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
                ' Esto sólo tiene sentido si ShowReadOnly es True.
                .ReadOnlyChecked = False

                .Title = "Select a file to open"

                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        Me.txt_import.Text = .FileName
                        '  txtFileContents.Text = My.Computer.FileSystem.ReadAllText(.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Function importar() As Data.DataTable
        If txt_import.Text = "" Then
            MessageBox.Show("no cargo la ruta del archivo a importar")
            btnBuscarExcel.Focus()
        Else
            Try
                Dim myConnection As String = ""
                Dim extension As String = ""
                Dim longitud As Integer = 0

                longitud = Me.txt_import.Text.LastIndexOf(".")
                extension = Me.txt_import.Text.Substring(longitud)

                If extension = ".xls" Then
                    myConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Me.txt_import.Text & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"";"
                ElseIf extension = ".xlsx" Then
                    myConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Me.txt_import.Text & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
                Else
                    MessageBox.Show("formato no reconocido")
                End If

                Dim conn As New OleDb.OleDbConnection(myConnection)
                Dim strSQL As String = ""
                strSQL = "SELECT * FROM [tareas$]"
                Dim odt As New DataTable
                Dim cmd As New OleDb.OleDbCommand(strSQL, conn)
                Dim adapter As New OleDb.OleDbDataAdapter(cmd)

                adapter.Fill(odt)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            End Try
        End If
        Return odt
    End Function


    Private Sub btnImportarTareas_Click(sender As Object, e As EventArgs) Handles btnImportarTareas.Click
        Dim myConnection As String = ""
        Dim extension As String = ""
        Dim longitud As Integer = 0

        longitud = Me.txt_import.Text.LastIndexOf(".")
        extension = Me.txt_import.Text.Substring(longitud)

        If extension = ".xls" Then
            myConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Me.txt_import.Text & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"";"
        ElseIf extension = ".xlsx" Then
            myConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Me.txt_import.Text & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
        Else
            MessageBox.Show("formato no reconocido")
        End If


        Dim conn As New OleDb.OleDbConnection(myConnection)
        Dim strSQL As String = ""
        strSQL = "SELECT * FROM [precio$]"
        Dim odt As New DataTable
        Dim cmd As New OleDb.OleDbCommand(strSQL, conn)
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        Dim contador As Integer = 0

        adapter.Fill(odt)


        For Each row As DataRow In odt.Rows
            If IsDBNull(row("tarea")) Then
                Exit For
            End If
            oTarea.Cargar()
            oTarea.Insertar()
            oTarea.archivo_relacionado = ""
            oTarea.ubicacion_documento = ""
            oTarea.enviada = False
            oTarea.fecha_inicio = DateAdd(DateInterval.Day, 10, DateTime.Now.Date)
            oTarea.fecha_pedido = DateAdd(DateInterval.Day, 10, DateTime.Now.Date)
            oTarea.fecha_fin = DateAdd(DateInterval.Day, 10, DateTime.Now.Date)
            oTarea.fecha_real = DateAdd(DateInterval.Day, 10, DateTime.Now.Date)
            oTarea.hora_prevista = 1
            oTarea.hora_real = 0
            oTarea.id_empresa = CInt(Me.lblid_empresa.Text)
            oTarea.id_estado_tarea = 1
            oTarea.id_proyecto = CInt(Me.lblid_proyecto.Text)
            oTarea.id_sub_proyecto = CInt(Me.lblid_sub_proyecto.Text)
            oTarea.id_tipo_tarea = 2
            oTarea.id_usuario = vgCodigoUsuario
            oTarea.id_usuario_asignado = CInt(Me.lblid_usuario_asignado.Text)
            oTarea.nombre_tarea = CStr(row("tarea"))
            oTarea.prioridad = CDec(row("prioridad"))
            oTarea.Guardar()

            contador = contador + 1
        Next

        MessageBox.Show("se agregaron " & contador & " tareas")
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub cmbTipo_tarea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo_tarea.SelectedIndexChanged
        If Me.cmbTipo_tarea.SelectedIndex >= 0 And IsNumeric(cmbTipo_tarea.SelectedValue) Then
            Me.lblid_tipo_tarea.Text = cmbTipo_tarea.SelectedValue.ToString
        End If
    End Sub

    Private Sub dtpFecha_desde_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_desde.ValueChanged
        Me.dtpFecha_hasta.MinDate = Me.dtpFecha_desde.Value
    End Sub

    Private Sub cmbEstado_mejora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado_mejora.SelectedIndexChanged
        If Me.cmbEstado_mejora.SelectedIndex >= 0 And IsNumeric(cmbEstado_mejora.SelectedValue) Then
            Me.lblid_estado_mejora.Text = cmbEstado_mejora.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbTipo_mejora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo_mejora.SelectedIndexChanged
        If Me.cmbTipo_mejora.SelectedIndex >= 0 And IsNumeric(cmbTipo_mejora.SelectedValue) Then
            Me.lblid_tipo_mejora.Text = cmbTipo_mejora.SelectedValue.ToString
        End If
    End Sub

    Private Sub chkActivo_mejora_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo_mejora.CheckedChanged
        If chkActivo_mejora.Checked Then
            Me.RefrescarGrillaMejora()
            Me.CargarEstado_mejora()
            Me.cmbestado_tarea.Visible = False
            Me.cmbEstado_mejora.Visible = True
            Me.cmbTipo_mejora.Visible = True
            Me.cmbTipo_tarea.Visible = False
            Me.lblid_estado_mejora.Text = "1"
            Me.cmbEstado_mejora.Text = "Programada"
            Me.lblid_tipo_mejora.Text = "0"
            cmbTipo_mejora.Text = ""
        Else
            Me.RefrescarGrillaTarea()
            Me.CargarEstado_tarea()
            Me.cmbestado_tarea.Visible = True
            Me.cmbEstado_mejora.Visible = False
            Me.cmbTipo_mejora.Visible = False
            Me.cmbTipo_tarea.Visible = True
            Me.lblid_estado_tarea.Text = "1"
            Me.cmbestado_tarea.Text = "Programada"
            Me.lblid_tipo_tarea.Text = "0"
            Me.cmbTipo_tarea.Text = ""
        End If
    End Sub

    Private Sub btnCambiarForm_Click(sender As Object, e As EventArgs) Handles btnCambiarForm.Click
        Me.chkActivo_mejora.Checked = Not (Me.chkActivo_mejora.Checked)
        If Me.chkActivo_mejora.Checked = True Then
            Me.PictureBox1.Image = My.Resources.mejorasgris
            Me.rbtSubProyecto.Text = "Área/Proceso"
        Else
            Me.PictureBox1.Image = My.Resources.tareasgris
            Me.rbtSubProyecto.Text = "Sub Proyecto"
        End If
    End Sub

    Private Sub btnImprimirEntreFecha_Click(sender As Object, e As EventArgs) Handles btnImprimirEntreFecha.Click
        Dim frm As New frmReporteTareasEntreFechas

        parametro_reporte = "porEmpresa"
        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
        parametro_id_proyecto = CInt(Me.lblid_proyecto.Text)
        parametro_id_subproyecto = CInt(Me.lblid_sub_proyecto.Text)
        parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
        parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date

        Me.AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirEntreFechaIngesoft_Click(sender As Object, e As EventArgs) Handles btnImprimirEntreFechaIngesoft.Click
        Dim frm As New frmReporteTareasEntreFechasIngesoft

        parametro_reporte = "porEmpresa"
        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
        parametro_id_proyecto = CInt(Me.lblid_proyecto.Text)
        parametro_id_subproyecto = CInt(Me.lblid_sub_proyecto.Text)
        parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
        parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date

        Me.AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        Me.RefrescarGrillaDashboard(1)
    End Sub

    Private Sub btnRetrasadas_Click(sender As Object, e As EventArgs) Handles btnRetrasadas.Click
        Me.RefrescarGrillaDashboard(2)
    End Sub

    Private Sub btnPrioritarias_Click(sender As Object, e As EventArgs) Handles btnPrioritarias.Click
        Me.RefrescarGrillaDashboard(3)
    End Sub

    Private Sub btnHoy_Click(sender As Object, e As EventArgs) Handles btnHoy.Click
        Me.RefrescarGrillaDashboard(4)
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        Select Case dgv1.CurrentCell.ColumnIndex
            Case 1
                CambiarEstadoToolStripMenuItem2.Visible = True
                CambiarFechaToolStripMenuItem2.Visible = False
                CambiarPrioridadToolStripMenuItem2.Visible = False
            Case 2
                CambiarEstadoToolStripMenuItem2.Visible = False
                CambiarFechaToolStripMenuItem2.Visible = False
                CambiarPrioridadToolStripMenuItem2.Visible = True
            Case 7
                CambiarEstadoToolStripMenuItem2.Visible = False
                CambiarFechaToolStripMenuItem2.Visible = True
                CambiarPrioridadToolStripMenuItem2.Visible = False
            Case Else
                e.Cancel = True
        End Select
    End Sub


    Private Sub FinalizadoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FinalizadoToolStripMenuItem2.Click, CanceladoToolStripMenuItem2.Click, ProgramadaToolStripMenuItem2.Click,
        SuspendidaToolStripMenuItem2.Click
        Dim TSTemp As New ToolStripMenuItem
        TSTemp = CType(sender, ToolStripMenuItem)
        Dim id_estado_mejora As Integer = 0


        If IsNumeric(Me.lblid_pk.Text) Then

            Select Case TSTemp.Name

                Case "FinalizadoToolStripMenuItem2"
                    id_estado_mejora = 4
                Case "CanceladoToolStripMenuItem2"
                    id_estado_mejora = 3
                Case "ProgramadaToolStripMenuItem2"
                    id_estado_mejora = 1
                Case "SuspendidaToolStripMenuItem2"
                    id_estado_mejora = 2

            End Select

            With oMejora
                .Cargar()
                .Modificar(CInt(Me.lblid_pk.Text))
                .id_estado_mejora = id_estado_mejora

                If id_estado_mejora <> 1 Then
                    .fecha_real = DateTime.Today
                End If

                .Guardar()
            End With
        End If
        RefrescarGrillaMejora()

    End Sub

    Private Sub BajaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem2.Click, MediaToolStripMenuItem2.Click, AltaToolStripMenuItem2.Click
        Dim TSTemp As New ToolStripMenuItem
        TSTemp = CType(sender, ToolStripMenuItem)
        Dim prioridad As Integer = 0


        If IsNumeric(Me.lblid_pk.Text) Then

            Select Case TSTemp.Name

                Case "BajaToolStripMenuItem2"
                    prioridad = 3
                Case "MediaToolStripMenuItem2"
                    prioridad = 2
                Case "AltaToolStripMenuItem2"
                    prioridad = 1

            End Select

            With oMejora
                .Cargar()
                .Modificar(CInt(Me.lblid_pk.Text))
                .prioridad = prioridad
                ' .fecha_real = DateTime.Today
                .Guardar()
            End With
        End If
        RefrescarGrillaMejora()

    End Sub

    Private Sub FechaActualToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FechaActualToolStripMenuItem2.Click
        If IsNumeric(Me.lblid_pk.Text) Then
            With oMejora
                .Cargar()
                .Modificar(CInt(Me.lblid_pk.Text))
                .fecha_real = DateTime.Now
                .Guardar()
            End With
        End If
        RefrescarGrillaMejora()
    End Sub

    Private Sub FechaPersonalizadaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FechaPersonalizadaToolStripMenuItem2.Click
        If Not IsNumeric(Me.lblid_pk.Text) Then
            Exit Sub
        End If

        Dim frm As New frmtemp()
        Me.AddOwnedForm(frm)
        frm.ShowDialog()
        RefrescarGrillaMejora()
    End Sub

    Private Sub btnImprimirEntreFechaProyecto_Click(sender As Object, e As EventArgs) Handles btnImprimirEntreFechaProyecto.Click
        Dim frm As New frmReporteTareasEntreFechas

        parametro_reporte = "porProyecto"
        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
        parametro_id_proyecto = CInt(Me.lblid_proyecto.Text)
        parametro_id_subproyecto = CInt(Me.lblid_sub_proyecto.Text)
        parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
        parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date

        Me.AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirEntreFechaSubproyecto_Click(sender As Object, e As EventArgs) Handles btnImprimirEntreFechaSubproyecto.Click
        Dim frm As New frmReporteTareasEntreFechas

        parametro_reporte = "porSubproyecto"
        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
        parametro_id_proyecto = CInt(Me.lblid_proyecto.Text)
        parametro_id_subproyecto = CInt(Me.lblid_sub_proyecto.Text)
        parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
        parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date

        Me.AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirEntreFechaIngesoftProyecto_Click(sender As Object, e As EventArgs) Handles btnImprimirEntreFechaIngesoftProyecto.Click
        Dim frm As New frmReporteTareasEntreFechasIngesoft

        parametro_reporte = "porProyecto"
        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
        parametro_id_proyecto = CInt(Me.lblid_proyecto.Text)
        parametro_id_subproyecto = CInt(Me.lblid_sub_proyecto.Text)
        parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
        parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date

        Me.AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirEntreFechaIngesoftSubproyecto_Click(sender As Object, e As EventArgs) Handles btnImprimirEntreFechaIngesoftSubproyecto.Click
        Dim frm As New frmReporteTareasEntreFechasIngesoft

        parametro_reporte = "porSubproyecto"
        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
        parametro_id_proyecto = CInt(Me.lblid_proyecto.Text)
        parametro_id_subproyecto = CInt(Me.lblid_sub_proyecto.Text)
        parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
        parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date

        Me.AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirGantt_Click(sender As Object, e As EventArgs) Handles btnImprimirGantt.Click
        frmGantt.ShowDialog()
        frmGantt.Dispose()
    End Sub

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles btnCalendario.Click
        frmCalendario.ShowDialog()
        frmCalendario.Dispose()
    End Sub

    Private Sub btnAgregarExpress_Click(sender As Object, e As EventArgs) Handles btnAgregarExpress.Click
        BanderaMejora = 1
        '  Me.AddOwnedForm(frmDetalle)
        oMejora.Insertar()
        frmDetalleTareaExpress.ShowDialog()
        frmDetalleTareaExpress.Dispose()
        '  frmDetalle.ShowDialog()
    End Sub

    Private Sub btnExportarTareas_Click(sender As Object, e As EventArgs) Handles btnExportarTareas.Click
        ' Procesamos los mensajes que actualmente están
        ' en la cola de mensajes.
        '
        Application.DoEvents()

        ' Cambiamos el tipo de cursor
        '
        Dim tipoCursor As Cursor = Me.Cursor
        Me.Cursor = Cursors.WaitCursor

        Try
            ' Referenciamos el objeto DataTable enlazado con
            ' el control DataGridView.
            '
            Dim dt As DataTable = oTarea.GetAll_Dinamica(dtpFecha_desde.Value.Date, dtpFecha_hasta.Value.Date)

            ' Exportamos los datos a la hoja de Excel de un
            ' libro de Excel 2007 - 2010.
            'Borrar()
            '
            ExportToExcel(dt, Application.StartupPath + "\LibroDinamic_tarea.xlsm", "Hoja1")

            System.Diagnostics.Process.Start(Application.StartupPath + "\LibroDinamic_tarea.xlsm")


            'MessageBox.Show("Los datos han sido exportados satisfactoriamente.")

        Catch ex As Exception
            ' Se ha producido un error.
            '
            MessageBox.Show(ex.Message)

        Finally
            ' Restauramos el tipo de cursos existente
            '
            Me.Cursor = tipoCursor

        End Try
    End Sub

    Public Sub ExportToExcel(ByVal dt As DataTable,
                       ByVal fileName As String,
                       ByVal sheetName As String)

        ' Verificamos los parámetros pasados
        '
        If ((dt Is Nothing) OrElse
            (String.IsNullOrEmpty(fileName)) OrElse
            (String.IsNullOrEmpty(sheetName))) Then _
            Throw New ArgumentNullException()

        Dim app As Excel.Application = Nothing
        Dim book As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing
        Dim sheet_2 As Excel.Worksheet = Nothing
        Try
            ' Referenciamos la aplicación Excel.
            '
            app = New Excel.Application()

            ' Abrimos el libro de trabajo.
            '
            book = app.Workbooks.Open(fileName)

            ' Referenciamos la hoja de cálculo del libro.
            '
            sheet = DirectCast(book.Sheets(sheetName), Excel.Worksheet)

            With sheet
                ' Limpiamos el contenido de toda la hoja.
                '
                '.Cells.Select()
                '.Cells.ClearContents()
                .Range("A2:CS100000").ClearContents()


                ' Seleccionamos la primera celda de la hoja.
                '
                '.Range("A1").Select()

                ' Escribimos los nombres de las columnas en la primera
                ' celda de la primera fila de la hoja de cálculo
                '
                Dim fila As Integer = 1
                Dim columna As Integer = 1

                For Each dc As DataColumn In dt.Columns
                    .Cells(fila, columna) = dc.ColumnName
                    columna += 1
                Next

                ' Establecemos los atributos de la fuente para las
                ' celdas de la primera fila.
                '
                With .Range(.Cells(1, 1), .Cells(1, dt.Columns.Count)).Font
                    .Name = "Calibri"
                    .Bold = True
                    .Size = 12
                End With

                ' Insertamos los datos en la hoja de cálculo, comenzando por la
                ' fila número 2, ya que la primera fila está ocupada
                ' por el nombre de las columnas.
                '
                fila = 2

                Me.lblcargandoreporte.Visible = True
                Me.ProgressBar1.Visible = True
                Me.lblcargandoreporte.Refresh()
                Dim cont As Integer = 0

                Me.ProgressBar1.Maximum = dt.Rows.Count


                For Each row As DataRow In dt.Rows

                    ' Primera columna
                    columna = 1

                    For Each dc As DataColumn In dt.Columns
                        .Cells(fila, columna) = row(dc.ColumnName)

                        ' Siguiente columna
                        columna += 1
                    Next

                    ' Siguiente fila
                    fila += 1

                    'Acumulo el progressbar
                    Me.ProgressBar1.Value = cont
                    cont = cont + 1

                    Me.ProgressBar1.Refresh()
                    Me.lblcargandoreporte.Refresh()

                Next

                ' Autoajustamos el ancho de todas las columnas utilizadas.
                '
                .Columns().AutoFit()

                Me.ProgressBar1.Visible = False
                Me.lblcargandoreporte.Visible = False
            End With

            sheet_2 = DirectCast(book.Sheets("Menu"), Excel.Worksheet)
            sheet_2.Select()



        Catch ex As Exception
            ' Se ha producido una excepción;
            ' indicamos que el libro ha sido guardado.
            '
            If (book IsNot Nothing) Then
                book.Saved = True
            End If

            ' Devolvemos la excepción al procedimiento llamador
            Throw

        Finally
            sheet = Nothing

            If (book IsNot Nothing) Then
                ' Si procede, guardamos el libro de trabajo.
                If (Not (book.Saved)) Then book.Save()
                ' Cerramos el libro de Excel.
                book.Close()
            End If
            book = Nothing

            If (app IsNot Nothing) Then
                ' Si procede, cerramos Excel y disminuimos el recuento
                ' de referencias al objeto Excel.Application.
                app.Quit()
                While (System.Runtime.InteropServices.Marshal.ReleaseComObject(app) > 0)
                    ' Sin implementación.
                End While
            End If
            app = Nothing

        End Try

    End Sub

End Class
