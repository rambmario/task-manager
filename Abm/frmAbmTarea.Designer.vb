<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmTarea
    Inherits System.Windows.Forms.Form
    'Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
       If disposing AndAlso components IsNot Nothing Then
           components.Dispose()
       End If
       MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Dise�ador de Windows Forms.
   'No lo modifique con el editor de c�digo.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmTarea))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCalendario = New System.Windows.Forms.Button()
        Me.btnImprimirGantt = New System.Windows.Forms.Button()
        Me.btnImprimirEntreFechaIngesoftSubproyecto = New System.Windows.Forms.Button()
        Me.btnImprimirEntreFechaSubproyecto = New System.Windows.Forms.Button()
        Me.btnImprimirEntreFechaIngesoftProyecto = New System.Windows.Forms.Button()
        Me.btnImprimirEntreFechaProyecto = New System.Windows.Forms.Button()
        Me.btnImprimirEntreFechaIngesoft = New System.Windows.Forms.Button()
        Me.btnImprimirEntreFecha = New System.Windows.Forms.Button()
        Me.btnBuscarExcel = New System.Windows.Forms.Button()
        Me.btnImportarTareas = New System.Windows.Forms.Button()
        Me.btnMailing = New System.Windows.Forms.Button()
        Me.btnAgregarExpress = New System.Windows.Forms.Button()
        Me.btnExportarTareas = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.rbtEmpresa = New System.Windows.Forms.RadioButton()
        Me.rbtProyecto = New System.Windows.Forms.RadioButton()
        Me.txtBanderaConsulta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.rbtSubProyecto = New System.Windows.Forms.RadioButton()
        Me.rbtUsuario = New System.Windows.Forms.RadioButton()
        Me.lblid_empresa = New System.Windows.Forms.Label()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.lblid_sub_proyecto = New System.Windows.Forms.Label()
        Me.cmbSub_proyecto = New System.Windows.Forms.ComboBox()
        Me.lblid_usuario_asignado = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.lblid_estado_tarea = New System.Windows.Forms.Label()
        Me.cmbestado_tarea = New System.Windows.Forms.ComboBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.etiquetaid_tipo_tarea = New System.Windows.Forms.Label()
        Me.txtidentificador = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTipo_mejora = New System.Windows.Forms.ComboBox()
        Me.lblid_tipo_mejora = New System.Windows.Forms.Label()
        Me.cmbTipo_tarea = New System.Windows.Forms.ComboBox()
        Me.cmbEstado_mejora = New System.Windows.Forms.ComboBox()
        Me.lblid_tipo_tarea = New System.Windows.Forms.Label()
        Me.lblid_estado_mejora = New System.Windows.Forms.Label()
        Me.dtpFecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFecha_filtro = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkAsigando = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar_usuario = New System.Windows.Forms.Button()
        Me.maskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.maskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.maskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.maskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCod_sub_proyecto = New System.Windows.Forms.ComboBox()
        Me.cmbCod_empresa = New System.Windows.Forms.ComboBox()
        Me.cmbCod_Proyecto = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanceladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaPersonalizadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarPrioridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chktodo = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdScript = New System.Windows.Forms.OpenFileDialog()
        Me.txt_import = New System.Windows.Forms.TextBox()
        Me.lblid_estado_tarea_grilla = New System.Windows.Forms.Label()
        Me.chkTipo_tarea = New System.Windows.Forms.CheckBox()
        Me.chkActivo_mejora = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPendientes = New System.Windows.Forms.Button()
        Me.btnRetrasadas = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPrioritarias = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnHoy = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSemana = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblHorasEstimadas = New System.Windows.Forms.Label()
        Me.lblHorasReales = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarEstadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanceladoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendidaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramadaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFechaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaActualToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaPersonalizadaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarPrioridadToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCambiarForm = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnPrimera_Pagina = New System.Windows.Forms.Button()
        Me.btnUltima_Pagina = New System.Windows.Forms.Button()
        Me.btnActualizar_Maximo = New System.Windows.Forms.Button()
        Me.btnSiguente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnBuscar_sub_proyecto = New System.Windows.Forms.Button()
        Me.btnBuscar_empresa = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscaproyecto = New System.Windows.Forms.Button()
        Me.lblcargandoreporte = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalendario
        '
        Me.btnCalendario.Image = Global.Gestion_tarea.My.Resources.Resources.Calendar16
        Me.btnCalendario.Location = New System.Drawing.Point(796, 68)
        Me.btnCalendario.Name = "btnCalendario"
        Me.btnCalendario.Size = New System.Drawing.Size(30, 21)
        Me.btnCalendario.TabIndex = 660
        Me.ttGeneral.SetToolTip(Me.btnCalendario, "Calendar")
        Me.btnCalendario.UseVisualStyleBackColor = True
        '
        'btnImprimirGantt
        '
        Me.btnImprimirGantt.Image = Global.Gestion_tarea.My.Resources.Resources.gantt_16
        Me.btnImprimirGantt.Location = New System.Drawing.Point(757, 69)
        Me.btnImprimirGantt.Name = "btnImprimirGantt"
        Me.btnImprimirGantt.Size = New System.Drawing.Size(30, 21)
        Me.btnImprimirGantt.TabIndex = 659
        Me.ttGeneral.SetToolTip(Me.btnImprimirGantt, "Gantt")
        Me.btnImprimirGantt.UseVisualStyleBackColor = True
        '
        'btnImprimirEntreFechaIngesoftSubproyecto
        '
        Me.btnImprimirEntreFechaIngesoftSubproyecto.Image = CType(resources.GetObject("btnImprimirEntreFechaIngesoftSubproyecto.Image"), System.Drawing.Image)
        Me.btnImprimirEntreFechaIngesoftSubproyecto.Location = New System.Drawing.Point(721, 69)
        Me.btnImprimirEntreFechaIngesoftSubproyecto.Name = "btnImprimirEntreFechaIngesoftSubproyecto"
        Me.btnImprimirEntreFechaIngesoftSubproyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnImprimirEntreFechaIngesoftSubproyecto.TabIndex = 658
        Me.ttGeneral.SetToolTip(Me.btnImprimirEntreFechaIngesoftSubproyecto, "Reporte Avance")
        Me.btnImprimirEntreFechaIngesoftSubproyecto.UseVisualStyleBackColor = True
        '
        'btnImprimirEntreFechaSubproyecto
        '
        Me.btnImprimirEntreFechaSubproyecto.Image = CType(resources.GetObject("btnImprimirEntreFechaSubproyecto.Image"), System.Drawing.Image)
        Me.btnImprimirEntreFechaSubproyecto.Location = New System.Drawing.Point(685, 70)
        Me.btnImprimirEntreFechaSubproyecto.Name = "btnImprimirEntreFechaSubproyecto"
        Me.btnImprimirEntreFechaSubproyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnImprimirEntreFechaSubproyecto.TabIndex = 657
        Me.ttGeneral.SetToolTip(Me.btnImprimirEntreFechaSubproyecto, "Reporte Resumen")
        Me.btnImprimirEntreFechaSubproyecto.UseVisualStyleBackColor = True
        '
        'btnImprimirEntreFechaIngesoftProyecto
        '
        Me.btnImprimirEntreFechaIngesoftProyecto.Image = CType(resources.GetObject("btnImprimirEntreFechaIngesoftProyecto.Image"), System.Drawing.Image)
        Me.btnImprimirEntreFechaIngesoftProyecto.Location = New System.Drawing.Point(721, 42)
        Me.btnImprimirEntreFechaIngesoftProyecto.Name = "btnImprimirEntreFechaIngesoftProyecto"
        Me.btnImprimirEntreFechaIngesoftProyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnImprimirEntreFechaIngesoftProyecto.TabIndex = 656
        Me.ttGeneral.SetToolTip(Me.btnImprimirEntreFechaIngesoftProyecto, "Reporte Avance")
        Me.btnImprimirEntreFechaIngesoftProyecto.UseVisualStyleBackColor = True
        '
        'btnImprimirEntreFechaProyecto
        '
        Me.btnImprimirEntreFechaProyecto.Image = CType(resources.GetObject("btnImprimirEntreFechaProyecto.Image"), System.Drawing.Image)
        Me.btnImprimirEntreFechaProyecto.Location = New System.Drawing.Point(685, 43)
        Me.btnImprimirEntreFechaProyecto.Name = "btnImprimirEntreFechaProyecto"
        Me.btnImprimirEntreFechaProyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnImprimirEntreFechaProyecto.TabIndex = 655
        Me.ttGeneral.SetToolTip(Me.btnImprimirEntreFechaProyecto, "Reporte Resumen")
        Me.btnImprimirEntreFechaProyecto.UseVisualStyleBackColor = True
        '
        'btnImprimirEntreFechaIngesoft
        '
        Me.btnImprimirEntreFechaIngesoft.Image = CType(resources.GetObject("btnImprimirEntreFechaIngesoft.Image"), System.Drawing.Image)
        Me.btnImprimirEntreFechaIngesoft.Location = New System.Drawing.Point(721, 13)
        Me.btnImprimirEntreFechaIngesoft.Name = "btnImprimirEntreFechaIngesoft"
        Me.btnImprimirEntreFechaIngesoft.Size = New System.Drawing.Size(30, 21)
        Me.btnImprimirEntreFechaIngesoft.TabIndex = 640
        Me.ttGeneral.SetToolTip(Me.btnImprimirEntreFechaIngesoft, "Reporte Avance")
        Me.btnImprimirEntreFechaIngesoft.UseVisualStyleBackColor = True
        '
        'btnImprimirEntreFecha
        '
        Me.btnImprimirEntreFecha.Image = CType(resources.GetObject("btnImprimirEntreFecha.Image"), System.Drawing.Image)
        Me.btnImprimirEntreFecha.Location = New System.Drawing.Point(685, 14)
        Me.btnImprimirEntreFecha.Name = "btnImprimirEntreFecha"
        Me.btnImprimirEntreFecha.Size = New System.Drawing.Size(30, 21)
        Me.btnImprimirEntreFecha.TabIndex = 639
        Me.ttGeneral.SetToolTip(Me.btnImprimirEntreFecha, "Reporte Resumen")
        Me.btnImprimirEntreFecha.UseVisualStyleBackColor = True
        '
        'btnBuscarExcel
        '
        Me.btnBuscarExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarExcel.Image = CType(resources.GetObject("btnBuscarExcel.Image"), System.Drawing.Image)
        Me.btnBuscarExcel.Location = New System.Drawing.Point(927, 315)
        Me.btnBuscarExcel.Name = "btnBuscarExcel"
        Me.btnBuscarExcel.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscarExcel.TabIndex = 634
        Me.ttGeneral.SetToolTip(Me.btnBuscarExcel, "Buscar archivo excel para importar tareas")
        Me.btnBuscarExcel.UseVisualStyleBackColor = True
        Me.btnBuscarExcel.Visible = False
        '
        'btnImportarTareas
        '
        Me.btnImportarTareas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportarTareas.Image = CType(resources.GetObject("btnImportarTareas.Image"), System.Drawing.Image)
        Me.btnImportarTareas.Location = New System.Drawing.Point(963, 315)
        Me.btnImportarTareas.Name = "btnImportarTareas"
        Me.btnImportarTareas.Size = New System.Drawing.Size(30, 21)
        Me.btnImportarTareas.TabIndex = 633
        Me.ttGeneral.SetToolTip(Me.btnImportarTareas, "Importar tareas")
        Me.btnImportarTareas.UseVisualStyleBackColor = True
        Me.btnImportarTareas.Visible = False
        '
        'btnMailing
        '
        Me.btnMailing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMailing.Image = CType(resources.GetObject("btnMailing.Image"), System.Drawing.Image)
        Me.btnMailing.Location = New System.Drawing.Point(669, 315)
        Me.btnMailing.Name = "btnMailing"
        Me.btnMailing.Size = New System.Drawing.Size(30, 21)
        Me.btnMailing.TabIndex = 632
        Me.ttGeneral.SetToolTip(Me.btnMailing, "Enviar por mail las actualizaciones")
        Me.btnMailing.UseVisualStyleBackColor = True
        Me.btnMailing.Visible = False
        '
        'btnAgregarExpress
        '
        Me.btnAgregarExpress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarExpress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarExpress.Image = CType(resources.GetObject("btnAgregarExpress.Image"), System.Drawing.Image)
        Me.btnAgregarExpress.Location = New System.Drawing.Point(279, 173)
        Me.btnAgregarExpress.Name = "btnAgregarExpress"
        Me.btnAgregarExpress.Size = New System.Drawing.Size(45, 40)
        Me.btnAgregarExpress.TabIndex = 661
        Me.btnAgregarExpress.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ttGeneral.SetToolTip(Me.btnAgregarExpress, "Ingreso Express")
        Me.btnAgregarExpress.UseVisualStyleBackColor = True
        '
        'btnExportarTareas
        '
        Me.btnExportarTareas.Image = CType(resources.GetObject("btnExportarTareas.Image"), System.Drawing.Image)
        Me.btnExportarTareas.Location = New System.Drawing.Point(832, 68)
        Me.btnExportarTareas.Name = "btnExportarTareas"
        Me.btnExportarTareas.Size = New System.Drawing.Size(30, 21)
        Me.btnExportarTareas.TabIndex = 662
        Me.ttGeneral.SetToolTip(Me.btnExportarTareas, "Reporte Avance")
        Me.btnExportarTareas.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(243, 287)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(284, 30)
        Me.lblTitulo.TabIndex = 566
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitulo.Visible = False
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(22, 277)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 565
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(585, 48)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 572
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'cmbproyecto
        '
        Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(243, 42)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(391, 21)
        Me.cmbproyecto.TabIndex = 568
        '
        'rbtEmpresa
        '
        Me.rbtEmpresa.AutoSize = True
        Me.rbtEmpresa.Checked = True
        Me.rbtEmpresa.Location = New System.Drawing.Point(12, 17)
        Me.rbtEmpresa.Name = "rbtEmpresa"
        Me.rbtEmpresa.Size = New System.Drawing.Size(59, 17)
        Me.rbtEmpresa.TabIndex = 577
        Me.rbtEmpresa.TabStop = True
        Me.rbtEmpresa.Text = "Unidad"
        Me.rbtEmpresa.UseVisualStyleBackColor = True
        '
        'rbtProyecto
        '
        Me.rbtProyecto.AutoSize = True
        Me.rbtProyecto.Location = New System.Drawing.Point(12, 44)
        Me.rbtProyecto.Name = "rbtProyecto"
        Me.rbtProyecto.Size = New System.Drawing.Size(104, 17)
        Me.rbtProyecto.TabIndex = 578
        Me.rbtProyecto.Text = "Proyecto-Cuenta"
        Me.rbtProyecto.UseVisualStyleBackColor = True
        '
        'txtBanderaConsulta
        '
        Me.txtBanderaConsulta.Location = New System.Drawing.Point(548, 316)
        Me.txtBanderaConsulta.Name = "txtBanderaConsulta"
        Me.txtBanderaConsulta.Size = New System.Drawing.Size(30, 20)
        Me.txtBanderaConsulta.TabIndex = 580
        Me.txtBanderaConsulta.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 585
        Me.Label2.Text = "Horas Estimadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 587
        Me.Label3.Text = "Horas Consumidas"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(745, 368)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(77, 26)
        Me.btnImprimir.TabIndex = 588
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'rbtSubProyecto
        '
        Me.rbtSubProyecto.AutoSize = True
        Me.rbtSubProyecto.Location = New System.Drawing.Point(12, 71)
        Me.rbtSubProyecto.Name = "rbtSubProyecto"
        Me.rbtSubProyecto.Size = New System.Drawing.Size(89, 17)
        Me.rbtSubProyecto.TabIndex = 589
        Me.rbtSubProyecto.Text = "Sub Proyecto"
        Me.rbtSubProyecto.UseVisualStyleBackColor = True
        '
        'rbtUsuario
        '
        Me.rbtUsuario.AutoSize = True
        Me.rbtUsuario.Location = New System.Drawing.Point(588, 317)
        Me.rbtUsuario.Name = "rbtUsuario"
        Me.rbtUsuario.Size = New System.Drawing.Size(69, 17)
        Me.rbtUsuario.TabIndex = 590
        Me.rbtUsuario.Text = "Asignado"
        Me.rbtUsuario.UseVisualStyleBackColor = True
        Me.rbtUsuario.Visible = False
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(585, 21)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 593
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(243, 15)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(391, 21)
        Me.cmbEmpresa.TabIndex = 591
        '
        'lblid_sub_proyecto
        '
        Me.lblid_sub_proyecto.AutoSize = True
        Me.lblid_sub_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_sub_proyecto.Location = New System.Drawing.Point(585, 72)
        Me.lblid_sub_proyecto.Name = "lblid_sub_proyecto"
        Me.lblid_sub_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_sub_proyecto.TabIndex = 597
        Me.lblid_sub_proyecto.Text = "0"
        Me.lblid_sub_proyecto.Visible = False
        '
        'cmbSub_proyecto
        '
        Me.cmbSub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSub_proyecto.FormattingEnabled = True
        Me.cmbSub_proyecto.Location = New System.Drawing.Point(243, 69)
        Me.cmbSub_proyecto.Name = "cmbSub_proyecto"
        Me.cmbSub_proyecto.Size = New System.Drawing.Size(391, 21)
        Me.cmbSub_proyecto.TabIndex = 595
        '
        'lblid_usuario_asignado
        '
        Me.lblid_usuario_asignado.AutoSize = True
        Me.lblid_usuario_asignado.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_asignado.Location = New System.Drawing.Point(285, 35)
        Me.lblid_usuario_asignado.Name = "lblid_usuario_asignado"
        Me.lblid_usuario_asignado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_asignado.TabIndex = 601
        Me.lblid_usuario_asignado.Text = "0"
        Me.lblid_usuario_asignado.Visible = False
        '
        'cmbUsuario
        '
        Me.cmbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(112, 32)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(230, 21)
        Me.cmbUsuario.TabIndex = 599
        '
        'lblid_estado_tarea
        '
        Me.lblid_estado_tarea.AutoSize = True
        Me.lblid_estado_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_estado_tarea.Location = New System.Drawing.Point(101, 13)
        Me.lblid_estado_tarea.Name = "lblid_estado_tarea"
        Me.lblid_estado_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_estado_tarea.TabIndex = 604
        Me.lblid_estado_tarea.Text = "0"
        Me.lblid_estado_tarea.Visible = False
        '
        'cmbestado_tarea
        '
        Me.cmbestado_tarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbestado_tarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbestado_tarea.FormattingEnabled = True
        Me.cmbestado_tarea.Location = New System.Drawing.Point(112, 5)
        Me.cmbestado_tarea.Name = "cmbestado_tarea"
        Me.cmbestado_tarea.Size = New System.Drawing.Size(230, 21)
        Me.cmbestado_tarea.TabIndex = 603
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(8, 262)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.Size = New System.Drawing.Size(1002, 465)
        Me.dgv1.TabIndex = 606
        '
        'etiquetaid_tipo_tarea
        '
        Me.etiquetaid_tipo_tarea.AutoSize = True
        Me.etiquetaid_tipo_tarea.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_tipo_tarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_tarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_tarea.Location = New System.Drawing.Point(776, 26)
        Me.etiquetaid_tipo_tarea.Name = "etiquetaid_tipo_tarea"
        Me.etiquetaid_tipo_tarea.Size = New System.Drawing.Size(50, 15)
        Me.etiquetaid_tipo_tarea.TabIndex = 608
        Me.etiquetaid_tipo_tarea.Text = "Usuario"
        Me.etiquetaid_tipo_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtidentificador
        '
        Me.txtidentificador.BackColor = System.Drawing.Color.SteelBlue
        Me.txtidentificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidentificador.ForeColor = System.Drawing.Color.White
        Me.txtidentificador.Location = New System.Drawing.Point(832, 22)
        Me.txtidentificador.MaxLength = 5000
        Me.txtidentificador.Name = "txtidentificador"
        Me.txtidentificador.Size = New System.Drawing.Size(179, 22)
        Me.txtidentificador.TabIndex = 607
        Me.txtidentificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbTipo_mejora)
        Me.Panel1.Controls.Add(Me.lblid_tipo_mejora)
        Me.Panel1.Controls.Add(Me.cmbTipo_tarea)
        Me.Panel1.Controls.Add(Me.cmbEstado_mejora)
        Me.Panel1.Controls.Add(Me.lblid_tipo_tarea)
        Me.Panel1.Controls.Add(Me.lblid_estado_mejora)
        Me.Panel1.Controls.Add(Me.dtpFecha_hasta)
        Me.Panel1.Controls.Add(Me.chkFecha_filtro)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.chkAsigando)
        Me.Panel1.Controls.Add(Me.chkEstado)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpFecha_desde)
        Me.Panel1.Controls.Add(Me.cmbestado_tarea)
        Me.Panel1.Controls.Add(Me.lblid_estado_tarea)
        Me.Panel1.Controls.Add(Me.cmbUsuario)
        Me.Panel1.Controls.Add(Me.btnBuscar_usuario)
        Me.Panel1.Controls.Add(Me.lblid_usuario_asignado)
        Me.Panel1.Location = New System.Drawing.Point(6, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 57)
        Me.Panel1.TabIndex = 610
        '
        'cmbTipo_mejora
        '
        Me.cmbTipo_mejora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipo_mejora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipo_mejora.FormattingEnabled = True
        Me.cmbTipo_mejora.Location = New System.Drawing.Point(447, 3)
        Me.cmbTipo_mejora.Name = "cmbTipo_mejora"
        Me.cmbTipo_mejora.Size = New System.Drawing.Size(230, 21)
        Me.cmbTipo_mejora.TabIndex = 637
        Me.cmbTipo_mejora.Visible = False
        '
        'lblid_tipo_mejora
        '
        Me.lblid_tipo_mejora.AutoSize = True
        Me.lblid_tipo_mejora.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_mejora.Location = New System.Drawing.Point(447, 11)
        Me.lblid_tipo_mejora.Name = "lblid_tipo_mejora"
        Me.lblid_tipo_mejora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_mejora.TabIndex = 638
        Me.lblid_tipo_mejora.Text = "0"
        Me.lblid_tipo_mejora.Visible = False
        '
        'cmbTipo_tarea
        '
        Me.cmbTipo_tarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipo_tarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipo_tarea.FormattingEnabled = True
        Me.cmbTipo_tarea.Location = New System.Drawing.Point(447, 3)
        Me.cmbTipo_tarea.Name = "cmbTipo_tarea"
        Me.cmbTipo_tarea.Size = New System.Drawing.Size(230, 21)
        Me.cmbTipo_tarea.TabIndex = 608
        '
        'cmbEstado_mejora
        '
        Me.cmbEstado_mejora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstado_mejora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstado_mejora.FormattingEnabled = True
        Me.cmbEstado_mejora.Location = New System.Drawing.Point(112, 5)
        Me.cmbEstado_mejora.Name = "cmbEstado_mejora"
        Me.cmbEstado_mejora.Size = New System.Drawing.Size(230, 21)
        Me.cmbEstado_mejora.TabIndex = 1073
        Me.cmbEstado_mejora.Visible = False
        '
        'lblid_tipo_tarea
        '
        Me.lblid_tipo_tarea.AutoSize = True
        Me.lblid_tipo_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_tarea.Location = New System.Drawing.Point(447, 13)
        Me.lblid_tipo_tarea.Name = "lblid_tipo_tarea"
        Me.lblid_tipo_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_tarea.TabIndex = 609
        Me.lblid_tipo_tarea.Text = "0"
        Me.lblid_tipo_tarea.Visible = False
        '
        'lblid_estado_mejora
        '
        Me.lblid_estado_mejora.AutoSize = True
        Me.lblid_estado_mejora.BackColor = System.Drawing.Color.Red
        Me.lblid_estado_mejora.Location = New System.Drawing.Point(101, 0)
        Me.lblid_estado_mejora.Name = "lblid_estado_mejora"
        Me.lblid_estado_mejora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_estado_mejora.TabIndex = 1074
        Me.lblid_estado_mejora.Text = "0"
        Me.lblid_estado_mejora.Visible = False
        '
        'dtpFecha_hasta
        '
        Me.dtpFecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_hasta.Location = New System.Drawing.Point(700, 33)
        Me.dtpFecha_hasta.Name = "dtpFecha_hasta"
        Me.dtpFecha_hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha_hasta.TabIndex = 1071
        '
        'chkFecha_filtro
        '
        Me.chkFecha_filtro.AutoSize = True
        Me.chkFecha_filtro.Location = New System.Drawing.Point(389, 35)
        Me.chkFecha_filtro.Name = "chkFecha_filtro"
        Me.chkFecha_filtro.Size = New System.Drawing.Size(15, 14)
        Me.chkFecha_filtro.TabIndex = 1072
        Me.chkFecha_filtro.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(618, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 1070
        Me.Label5.Text = "Fecha Hasta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAsigando
        '
        Me.chkAsigando.AutoSize = True
        Me.chkAsigando.Location = New System.Drawing.Point(17, 31)
        Me.chkAsigando.Name = "chkAsigando"
        Me.chkAsigando.Size = New System.Drawing.Size(70, 17)
        Me.chkAsigando.TabIndex = 607
        Me.chkAsigando.Text = "Asigando"
        Me.chkAsigando.UseVisualStyleBackColor = True
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Location = New System.Drawing.Point(17, 9)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(59, 17)
        Me.chkEstado.TabIndex = 606
        Me.chkEstado.Text = "Estado"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(410, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 1069
        Me.Label6.Text = "Fecha Desde"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha_desde
        '
        Me.dtpFecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_desde.Location = New System.Drawing.Point(496, 32)
        Me.dtpFecha_desde.Name = "dtpFecha_desde"
        Me.dtpFecha_desde.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha_desde.TabIndex = 1068
        '
        'btnBuscar_usuario
        '
        Me.btnBuscar_usuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_usuario.Image = CType(resources.GetObject("btnBuscar_usuario.Image"), System.Drawing.Image)
        Me.btnBuscar_usuario.Location = New System.Drawing.Point(348, 33)
        Me.btnBuscar_usuario.Name = "btnBuscar_usuario"
        Me.btnBuscar_usuario.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscar_usuario.TabIndex = 600
        Me.btnBuscar_usuario.UseVisualStyleBackColor = True
        '
        'maskedTextBox4
        '
        Me.maskedTextBox4.Location = New System.Drawing.Point(591, 185)
        Me.maskedTextBox4.Mask = "9999999999"
        Me.maskedTextBox4.Name = "maskedTextBox4"
        Me.maskedTextBox4.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.maskedTextBox4.Size = New System.Drawing.Size(31, 20)
        Me.maskedTextBox4.TabIndex = 620
        Me.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'maskedTextBox3
        '
        Me.maskedTextBox3.Enabled = False
        Me.maskedTextBox3.Location = New System.Drawing.Point(819, 185)
        Me.maskedTextBox3.Mask = "9999999999"
        Me.maskedTextBox3.Name = "maskedTextBox3"
        Me.maskedTextBox3.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.maskedTextBox3.Size = New System.Drawing.Size(31, 20)
        Me.maskedTextBox3.TabIndex = 619
        Me.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'maskedTextBox2
        '
        Me.maskedTextBox2.Enabled = False
        Me.maskedTextBox2.Location = New System.Drawing.Point(774, 185)
        Me.maskedTextBox2.Mask = "9999999999"
        Me.maskedTextBox2.Name = "maskedTextBox2"
        Me.maskedTextBox2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.maskedTextBox2.Size = New System.Drawing.Size(31, 20)
        Me.maskedTextBox2.TabIndex = 618
        Me.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'maskedTextBox1
        '
        Me.maskedTextBox1.Enabled = False
        Me.maskedTextBox1.Location = New System.Drawing.Point(706, 185)
        Me.maskedTextBox1.Mask = "9999999999"
        Me.maskedTextBox1.Name = "maskedTextBox1"
        Me.maskedTextBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.maskedTextBox1.Size = New System.Drawing.Size(31, 20)
        Me.maskedTextBox1.TabIndex = 617
        Me.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(520, 185)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 616
        Me.label4.Text = "Max. por pag."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(747, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 614
        Me.Label8.Text = "Pag."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(677, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 613
        Me.Label10.Text = "Cant."
        '
        'cmbCod_sub_proyecto
        '
        Me.cmbCod_sub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_sub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_sub_proyecto.FormattingEnabled = True
        Me.cmbCod_sub_proyecto.Location = New System.Drawing.Point(118, 69)
        Me.cmbCod_sub_proyecto.Name = "cmbCod_sub_proyecto"
        Me.cmbCod_sub_proyecto.Size = New System.Drawing.Size(119, 21)
        Me.cmbCod_sub_proyecto.TabIndex = 630
        '
        'cmbCod_empresa
        '
        Me.cmbCod_empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_empresa.FormattingEnabled = True
        Me.cmbCod_empresa.Location = New System.Drawing.Point(118, 15)
        Me.cmbCod_empresa.Name = "cmbCod_empresa"
        Me.cmbCod_empresa.Size = New System.Drawing.Size(119, 21)
        Me.cmbCod_empresa.TabIndex = 629
        '
        'cmbCod_Proyecto
        '
        Me.cmbCod_Proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_Proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_Proyecto.FormattingEnabled = True
        Me.cmbCod_Proyecto.Location = New System.Drawing.Point(118, 42)
        Me.cmbCod_Proyecto.Name = "cmbCod_Proyecto"
        Me.cmbCod_Proyecto.Size = New System.Drawing.Size(119, 21)
        Me.cmbCod_Proyecto.TabIndex = 628
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarEstadoToolStripMenuItem, Me.CambiarFechaToolStripMenuItem, Me.CambiarPrioridadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 70)
        '
        'CambiarEstadoToolStripMenuItem
        '
        Me.CambiarEstadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalizadoToolStripMenuItem, Me.CanceladoToolStripMenuItem, Me.SuspendidaToolStripMenuItem, Me.ProgramadaToolStripMenuItem})
        Me.CambiarEstadoToolStripMenuItem.Name = "CambiarEstadoToolStripMenuItem"
        Me.CambiarEstadoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CambiarEstadoToolStripMenuItem.Text = "Cambiar Estado"
        '
        'FinalizadoToolStripMenuItem
        '
        Me.FinalizadoToolStripMenuItem.Name = "FinalizadoToolStripMenuItem"
        Me.FinalizadoToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.FinalizadoToolStripMenuItem.Text = "Finalizada"
        '
        'CanceladoToolStripMenuItem
        '
        Me.CanceladoToolStripMenuItem.Name = "CanceladoToolStripMenuItem"
        Me.CanceladoToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CanceladoToolStripMenuItem.Text = "Cancelada"
        '
        'SuspendidaToolStripMenuItem
        '
        Me.SuspendidaToolStripMenuItem.Name = "SuspendidaToolStripMenuItem"
        Me.SuspendidaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SuspendidaToolStripMenuItem.Text = "Suspendida"
        '
        'ProgramadaToolStripMenuItem
        '
        Me.ProgramadaToolStripMenuItem.Name = "ProgramadaToolStripMenuItem"
        Me.ProgramadaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProgramadaToolStripMenuItem.Text = "Programada"
        '
        'CambiarFechaToolStripMenuItem
        '
        Me.CambiarFechaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FechaActualToolStripMenuItem, Me.FechaPersonalizadaToolStripMenuItem})
        Me.CambiarFechaToolStripMenuItem.Name = "CambiarFechaToolStripMenuItem"
        Me.CambiarFechaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CambiarFechaToolStripMenuItem.Text = "Cambiar Fecha Real"
        '
        'FechaActualToolStripMenuItem
        '
        Me.FechaActualToolStripMenuItem.Name = "FechaActualToolStripMenuItem"
        Me.FechaActualToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FechaActualToolStripMenuItem.Text = "Fecha Actual"
        '
        'FechaPersonalizadaToolStripMenuItem
        '
        Me.FechaPersonalizadaToolStripMenuItem.Name = "FechaPersonalizadaToolStripMenuItem"
        Me.FechaPersonalizadaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FechaPersonalizadaToolStripMenuItem.Text = "Fecha Personalizada"
        '
        'CambiarPrioridadToolStripMenuItem
        '
        Me.CambiarPrioridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaToolStripMenuItem, Me.MediaToolStripMenuItem, Me.AltaToolStripMenuItem})
        Me.CambiarPrioridadToolStripMenuItem.Name = "CambiarPrioridadToolStripMenuItem"
        Me.CambiarPrioridadToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CambiarPrioridadToolStripMenuItem.Text = "Cambiar Prioridad"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'MediaToolStripMenuItem
        '
        Me.MediaToolStripMenuItem.Name = "MediaToolStripMenuItem"
        Me.MediaToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.MediaToolStripMenuItem.Text = "Media"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'chktodo
        '
        Me.chktodo.AutoSize = True
        Me.chktodo.Location = New System.Drawing.Point(23, 147)
        Me.chktodo.Name = "chktodo"
        Me.chktodo.Size = New System.Drawing.Size(51, 17)
        Me.chktodo.TabIndex = 607
        Me.chktodo.Text = "Todo"
        Me.chktodo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(806, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 631
        Me.Label1.Text = "-"
        '
        'ofdScript
        '
        Me.ofdScript.InitialDirectory = "C:\"
        '
        'txt_import
        '
        Me.txt_import.BackColor = System.Drawing.Color.LightBlue
        Me.txt_import.Location = New System.Drawing.Point(710, 315)
        Me.txt_import.Name = "txt_import"
        Me.txt_import.Size = New System.Drawing.Size(205, 20)
        Me.txt_import.TabIndex = 635
        Me.txt_import.Visible = False
        '
        'lblid_estado_tarea_grilla
        '
        Me.lblid_estado_tarea_grilla.AutoSize = True
        Me.lblid_estado_tarea_grilla.BackColor = System.Drawing.Color.Red
        Me.lblid_estado_tarea_grilla.Location = New System.Drawing.Point(76, 277)
        Me.lblid_estado_tarea_grilla.Name = "lblid_estado_tarea_grilla"
        Me.lblid_estado_tarea_grilla.Size = New System.Drawing.Size(13, 13)
        Me.lblid_estado_tarea_grilla.TabIndex = 636
        Me.lblid_estado_tarea_grilla.Text = "0"
        Me.lblid_estado_tarea_grilla.Visible = False
        '
        'chkTipo_tarea
        '
        Me.chkTipo_tarea.AutoSize = True
        Me.chkTipo_tarea.Location = New System.Drawing.Point(395, 100)
        Me.chkTipo_tarea.Name = "chkTipo_tarea"
        Me.chkTipo_tarea.Size = New System.Drawing.Size(47, 17)
        Me.chkTipo_tarea.TabIndex = 610
        Me.chkTipo_tarea.Text = "Tipo"
        Me.chkTipo_tarea.UseVisualStyleBackColor = True
        '
        'chkActivo_mejora
        '
        Me.chkActivo_mejora.AutoSize = True
        Me.chkActivo_mejora.Location = New System.Drawing.Point(391, 319)
        Me.chkActivo_mejora.Name = "chkActivo_mejora"
        Me.chkActivo_mejora.Size = New System.Drawing.Size(118, 17)
        Me.chkActivo_mejora.TabIndex = 637
        Me.chkActivo_mejora.Text = "Esta activo mejoras"
        Me.chkActivo_mejora.UseVisualStyleBackColor = True
        Me.chkActivo_mejora.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Mejora.png")
        Me.ImageList1.Images.SetKeyName(1, "Tarea.png")
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 643
        Me.Label7.Text = "Pendientes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPendientes
        '
        Me.btnPendientes.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendientes.ForeColor = System.Drawing.Color.White
        Me.btnPendientes.Location = New System.Drawing.Point(8, 233)
        Me.btnPendientes.Name = "btnPendientes"
        Me.btnPendientes.Size = New System.Drawing.Size(61, 23)
        Me.btnPendientes.TabIndex = 644
        Me.btnPendientes.Text = "0"
        Me.btnPendientes.UseVisualStyleBackColor = False
        '
        'btnRetrasadas
        '
        Me.btnRetrasadas.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRetrasadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetrasadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrasadas.ForeColor = System.Drawing.Color.White
        Me.btnRetrasadas.Location = New System.Drawing.Point(75, 233)
        Me.btnRetrasadas.Name = "btnRetrasadas"
        Me.btnRetrasadas.Size = New System.Drawing.Size(60, 23)
        Me.btnRetrasadas.TabIndex = 646
        Me.btnRetrasadas.Text = "0"
        Me.btnRetrasadas.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(75, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 645
        Me.Label9.Text = "Retrasadas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrioritarias
        '
        Me.btnPrioritarias.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrioritarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrioritarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrioritarias.ForeColor = System.Drawing.Color.White
        Me.btnPrioritarias.Location = New System.Drawing.Point(141, 233)
        Me.btnPrioritarias.Name = "btnPrioritarias"
        Me.btnPrioritarias.Size = New System.Drawing.Size(61, 23)
        Me.btnPrioritarias.TabIndex = 648
        Me.btnPrioritarias.Text = "0"
        Me.btnPrioritarias.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(142, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 647
        Me.Label11.Text = "Prioritarias"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHoy
        '
        Me.btnHoy.BackColor = System.Drawing.Color.SteelBlue
        Me.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoy.ForeColor = System.Drawing.Color.White
        Me.btnHoy.Location = New System.Drawing.Point(208, 233)
        Me.btnHoy.Name = "btnHoy"
        Me.btnHoy.Size = New System.Drawing.Size(61, 23)
        Me.btnHoy.TabIndex = 650
        Me.btnHoy.Text = "0"
        Me.btnHoy.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(209, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 649
        Me.Label12.Text = "Hoy"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSemana
        '
        Me.btnSemana.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemana.ForeColor = System.Drawing.Color.White
        Me.btnSemana.Location = New System.Drawing.Point(275, 233)
        Me.btnSemana.Name = "btnSemana"
        Me.btnSemana.Size = New System.Drawing.Size(61, 23)
        Me.btnSemana.TabIndex = 652
        Me.btnSemana.Text = "0"
        Me.btnSemana.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(276, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 651
        Me.Label13.Text = "Semana"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorasEstimadas
        '
        Me.lblHorasEstimadas.BackColor = System.Drawing.Color.SteelBlue
        Me.lblHorasEstimadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorasEstimadas.ForeColor = System.Drawing.Color.White
        Me.lblHorasEstimadas.Location = New System.Drawing.Point(401, 233)
        Me.lblHorasEstimadas.Name = "lblHorasEstimadas"
        Me.lblHorasEstimadas.Size = New System.Drawing.Size(61, 23)
        Me.lblHorasEstimadas.TabIndex = 653
        Me.lblHorasEstimadas.Text = "Label14"
        Me.lblHorasEstimadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorasReales
        '
        Me.lblHorasReales.BackColor = System.Drawing.Color.SteelBlue
        Me.lblHorasReales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorasReales.ForeColor = System.Drawing.Color.White
        Me.lblHorasReales.Location = New System.Drawing.Point(503, 233)
        Me.lblHorasReales.Name = "lblHorasReales"
        Me.lblHorasReales.Size = New System.Drawing.Size(61, 23)
        Me.lblHorasReales.TabIndex = 654
        Me.lblHorasReales.Text = "Label14"
        Me.lblHorasReales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarEstadoToolStripMenuItem2, Me.CambiarFechaToolStripMenuItem2, Me.CambiarPrioridadToolStripMenuItem2})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(179, 70)
        '
        'CambiarEstadoToolStripMenuItem2
        '
        Me.CambiarEstadoToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalizadoToolStripMenuItem2, Me.CanceladoToolStripMenuItem2, Me.SuspendidaToolStripMenuItem2, Me.ProgramadaToolStripMenuItem2})
        Me.CambiarEstadoToolStripMenuItem2.Name = "CambiarEstadoToolStripMenuItem2"
        Me.CambiarEstadoToolStripMenuItem2.Size = New System.Drawing.Size(178, 22)
        Me.CambiarEstadoToolStripMenuItem2.Text = "Cambiar Estado"
        '
        'FinalizadoToolStripMenuItem2
        '
        Me.FinalizadoToolStripMenuItem2.Name = "FinalizadoToolStripMenuItem2"
        Me.FinalizadoToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.FinalizadoToolStripMenuItem2.Text = "Finalizada"
        '
        'CanceladoToolStripMenuItem2
        '
        Me.CanceladoToolStripMenuItem2.Name = "CanceladoToolStripMenuItem2"
        Me.CanceladoToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.CanceladoToolStripMenuItem2.Text = "Cancelada"
        '
        'SuspendidaToolStripMenuItem2
        '
        Me.SuspendidaToolStripMenuItem2.Name = "SuspendidaToolStripMenuItem2"
        Me.SuspendidaToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.SuspendidaToolStripMenuItem2.Text = "Suspendida"
        '
        'ProgramadaToolStripMenuItem2
        '
        Me.ProgramadaToolStripMenuItem2.Name = "ProgramadaToolStripMenuItem2"
        Me.ProgramadaToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.ProgramadaToolStripMenuItem2.Text = "Programada"
        '
        'CambiarFechaToolStripMenuItem2
        '
        Me.CambiarFechaToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FechaActualToolStripMenuItem2, Me.FechaPersonalizadaToolStripMenuItem2})
        Me.CambiarFechaToolStripMenuItem2.Name = "CambiarFechaToolStripMenuItem2"
        Me.CambiarFechaToolStripMenuItem2.Size = New System.Drawing.Size(178, 22)
        Me.CambiarFechaToolStripMenuItem2.Text = "Cambiar Fecha Real"
        '
        'FechaActualToolStripMenuItem2
        '
        Me.FechaActualToolStripMenuItem2.Name = "FechaActualToolStripMenuItem2"
        Me.FechaActualToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.FechaActualToolStripMenuItem2.Text = "Fecha Actual"
        '
        'FechaPersonalizadaToolStripMenuItem2
        '
        Me.FechaPersonalizadaToolStripMenuItem2.Name = "FechaPersonalizadaToolStripMenuItem2"
        Me.FechaPersonalizadaToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.FechaPersonalizadaToolStripMenuItem2.Text = "Fecha Personalizada"
        '
        'CambiarPrioridadToolStripMenuItem2
        '
        Me.CambiarPrioridadToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaToolStripMenuItem2, Me.MediaToolStripMenuItem2, Me.AltaToolStripMenuItem2})
        Me.CambiarPrioridadToolStripMenuItem2.Name = "CambiarPrioridadToolStripMenuItem2"
        Me.CambiarPrioridadToolStripMenuItem2.Size = New System.Drawing.Size(178, 22)
        Me.CambiarPrioridadToolStripMenuItem2.Text = "Cambiar Prioridad"
        '
        'BajaToolStripMenuItem2
        '
        Me.BajaToolStripMenuItem2.Name = "BajaToolStripMenuItem2"
        Me.BajaToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.BajaToolStripMenuItem2.Text = "Baja"
        '
        'MediaToolStripMenuItem2
        '
        Me.MediaToolStripMenuItem2.Name = "MediaToolStripMenuItem2"
        Me.MediaToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.MediaToolStripMenuItem2.Text = "Media"
        '
        'AltaToolStripMenuItem2
        '
        Me.AltaToolStripMenuItem2.Name = "AltaToolStripMenuItem2"
        Me.AltaToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.AltaToolStripMenuItem2.Text = "Alta"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(898, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 641
        Me.PictureBox1.TabStop = False
        '
        'btnCambiarForm
        '
        Me.btnCambiarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarForm.Image = CType(resources.GetObject("btnCambiarForm.Image"), System.Drawing.Image)
        Me.btnCambiarForm.Location = New System.Drawing.Point(224, 173)
        Me.btnCambiarForm.Name = "btnCambiarForm"
        Me.btnCambiarForm.Size = New System.Drawing.Size(45, 40)
        Me.btnCambiarForm.TabIndex = 638
        Me.btnCambiarForm.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(414, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(45, 40)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(685, 354)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 40)
        Me.Button4.TabIndex = 12
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(612, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 40)
        Me.Button3.TabIndex = 10
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(160, 173)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(45, 40)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(112, 173)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(45, 40)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(548, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(64, 173)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 40)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnPrimera_Pagina
        '
        Me.btnPrimera_Pagina.Image = Global.Gestion_tarea.My.Resources.Resources.first_24
        Me.btnPrimera_Pagina.Location = New System.Drawing.Point(856, 178)
        Me.btnPrimera_Pagina.Name = "btnPrimera_Pagina"
        Me.btnPrimera_Pagina.Size = New System.Drawing.Size(34, 33)
        Me.btnPrimera_Pagina.TabIndex = 623
        Me.btnPrimera_Pagina.UseVisualStyleBackColor = True
        '
        'btnUltima_Pagina
        '
        Me.btnUltima_Pagina.Image = Global.Gestion_tarea.My.Resources.Resources.last_24
        Me.btnUltima_Pagina.Location = New System.Drawing.Point(976, 178)
        Me.btnUltima_Pagina.Name = "btnUltima_Pagina"
        Me.btnUltima_Pagina.Size = New System.Drawing.Size(34, 33)
        Me.btnUltima_Pagina.TabIndex = 622
        Me.btnUltima_Pagina.UseVisualStyleBackColor = True
        '
        'btnActualizar_Maximo
        '
        Me.btnActualizar_Maximo.Image = CType(resources.GetObject("btnActualizar_Maximo.Image"), System.Drawing.Image)
        Me.btnActualizar_Maximo.Location = New System.Drawing.Point(629, 178)
        Me.btnActualizar_Maximo.Name = "btnActualizar_Maximo"
        Me.btnActualizar_Maximo.Size = New System.Drawing.Size(34, 33)
        Me.btnActualizar_Maximo.TabIndex = 621
        Me.btnActualizar_Maximo.UseVisualStyleBackColor = True
        '
        'btnSiguente
        '
        Me.btnSiguente.Image = Global.Gestion_tarea.My.Resources.Resources.next_24
        Me.btnSiguente.Location = New System.Drawing.Point(936, 178)
        Me.btnSiguente.Name = "btnSiguente"
        Me.btnSiguente.Size = New System.Drawing.Size(34, 33)
        Me.btnSiguente.TabIndex = 612
        Me.btnSiguente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Image = Global.Gestion_tarea.My.Resources.Resources.previous_24
        Me.btnAnterior.Location = New System.Drawing.Point(896, 178)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(34, 33)
        Me.btnAnterior.TabIndex = 611
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnBuscar_sub_proyecto
        '
        Me.btnBuscar_sub_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_sub_proyecto.Image = CType(resources.GetObject("btnBuscar_sub_proyecto.Image"), System.Drawing.Image)
        Me.btnBuscar_sub_proyecto.Location = New System.Drawing.Point(640, 68)
        Me.btnBuscar_sub_proyecto.Name = "btnBuscar_sub_proyecto"
        Me.btnBuscar_sub_proyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscar_sub_proyecto.TabIndex = 596
        Me.btnBuscar_sub_proyecto.UseVisualStyleBackColor = True
        '
        'btnBuscar_empresa
        '
        Me.btnBuscar_empresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_empresa.Image = CType(resources.GetObject("btnBuscar_empresa.Image"), System.Drawing.Image)
        Me.btnBuscar_empresa.Location = New System.Drawing.Point(640, 14)
        Me.btnBuscar_empresa.Name = "btnBuscar_empresa"
        Me.btnBuscar_empresa.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscar_empresa.TabIndex = 592
        Me.btnBuscar_empresa.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(8, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 40)
        Me.Button1.TabIndex = 581
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBuscaproyecto
        '
        Me.btnBuscaproyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproyecto.Image = CType(resources.GetObject("btnBuscaproyecto.Image"), System.Drawing.Image)
        Me.btnBuscaproyecto.Location = New System.Drawing.Point(640, 41)
        Me.btnBuscaproyecto.Name = "btnBuscaproyecto"
        Me.btnBuscaproyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproyecto.TabIndex = 570
        Me.btnBuscaproyecto.UseVisualStyleBackColor = True
        '
        'lblcargandoreporte
        '
        Me.lblcargandoreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcargandoreporte.Location = New System.Drawing.Point(36, 516)
        Me.lblcargandoreporte.Name = "lblcargandoreporte"
        Me.lblcargandoreporte.Size = New System.Drawing.Size(751, 20)
        Me.lblcargandoreporte.TabIndex = 1086
        Me.lblcargandoreporte.Text = "Cargando reporte. Espere por favor..."
        Me.lblcargandoreporte.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Chartreuse
        Me.ProgressBar1.Location = New System.Drawing.Point(40, 543)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(747, 23)
        Me.ProgressBar1.TabIndex = 1085
        Me.ProgressBar1.Visible = False
        '
        'frmAbmTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.lblcargandoreporte)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnExportarTareas)
        Me.Controls.Add(Me.btnAgregarExpress)
        Me.Controls.Add(Me.btnCalendario)
        Me.Controls.Add(Me.btnImprimirGantt)
        Me.Controls.Add(Me.btnImprimirEntreFechaIngesoftSubproyecto)
        Me.Controls.Add(Me.btnImprimirEntreFechaSubproyecto)
        Me.Controls.Add(Me.btnImprimirEntreFechaIngesoftProyecto)
        Me.Controls.Add(Me.btnImprimirEntreFechaProyecto)
        Me.Controls.Add(Me.lblHorasReales)
        Me.Controls.Add(Me.lblHorasEstimadas)
        Me.Controls.Add(Me.btnSemana)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnHoy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnPrioritarias)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnRetrasadas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnPendientes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnImprimirEntreFechaIngesoft)
        Me.Controls.Add(Me.btnImprimirEntreFecha)
        Me.Controls.Add(Me.btnCambiarForm)
        Me.Controls.Add(Me.chkActivo_mejora)
        Me.Controls.Add(Me.chkTipo_tarea)
        Me.Controls.Add(Me.lblid_estado_tarea_grilla)
        Me.Controls.Add(Me.txt_import)
        Me.Controls.Add(Me.btnBuscarExcel)
        Me.Controls.Add(Me.btnImportarTareas)
        Me.Controls.Add(Me.btnMailing)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.chktodo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbCod_sub_proyecto)
        Me.Controls.Add(Me.rbtUsuario)
        Me.Controls.Add(Me.cmbCod_empresa)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmbCod_Proyecto)
        Me.Controls.Add(Me.btnPrimera_Pagina)
        Me.Controls.Add(Me.btnUltima_Pagina)
        Me.Controls.Add(Me.btnActualizar_Maximo)
        Me.Controls.Add(Me.maskedTextBox4)
        Me.Controls.Add(Me.maskedTextBox3)
        Me.Controls.Add(Me.maskedTextBox2)
        Me.Controls.Add(Me.maskedTextBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSiguente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.etiquetaid_tipo_tarea)
        Me.Controls.Add(Me.txtidentificador)
        Me.Controls.Add(Me.lblid_sub_proyecto)
        Me.Controls.Add(Me.btnBuscar_sub_proyecto)
        Me.Controls.Add(Me.cmbSub_proyecto)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.btnBuscar_empresa)
        Me.Controls.Add(Me.cmbEmpresa)
        Me.Controls.Add(Me.rbtSubProyecto)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBanderaConsulta)
        Me.Controls.Add(Me.rbtProyecto)
        Me.Controls.Add(Me.rbtEmpresa)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.btnBuscaproyecto)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAbmTarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscaproyecto As System.Windows.Forms.Button
    Friend WithEvents cmbproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents rbtEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents rbtProyecto As System.Windows.Forms.RadioButton
    Friend WithEvents txtBanderaConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Protected WithEvents Button4 As System.Windows.Forms.Button
    Protected WithEvents Button3 As System.Windows.Forms.Button
    Protected WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rbtSubProyecto As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUsuario As System.Windows.Forms.RadioButton
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_empresa As System.Windows.Forms.Button
    Friend WithEvents cmbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_sub_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_sub_proyecto As System.Windows.Forms.Button
    Friend WithEvents cmbSub_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_usuario_asignado As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_usuario As System.Windows.Forms.Button
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_estado_tarea As System.Windows.Forms.Label
    Friend WithEvents cmbestado_tarea As System.Windows.Forms.ComboBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblid_pk As System.Windows.Forms.Label
    Friend WithEvents etiquetaid_tipo_tarea As System.Windows.Forms.Label
    Protected WithEvents txtidentificador As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Private WithEvents btnPrimera_Pagina As System.Windows.Forms.Button
    Private WithEvents btnUltima_Pagina As System.Windows.Forms.Button
    Private WithEvents btnActualizar_Maximo As System.Windows.Forms.Button
    Private WithEvents maskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Private WithEvents maskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Private WithEvents maskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents maskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents btnSiguente As System.Windows.Forms.Button
    Private WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents cmbCod_sub_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCod_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCod_Proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarEstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalizadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaActualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaPersonalizadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chktodo As System.Windows.Forms.CheckBox
    Friend WithEvents CanceladoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarPrioridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAsigando As System.Windows.Forms.CheckBox
    Friend WithEvents btnMailing As System.Windows.Forms.Button
    Friend WithEvents btnImportarTareas As System.Windows.Forms.Button
    Friend WithEvents btnBuscarExcel As System.Windows.Forms.Button
    Friend WithEvents ofdScript As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_import As System.Windows.Forms.TextBox
    Friend WithEvents lblid_estado_tarea_grilla As System.Windows.Forms.Label
    Friend WithEvents chkTipo_tarea As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTipo_tarea As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_tipo_tarea As System.Windows.Forms.Label
    Friend WithEvents chkFecha_filtro As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEstado_mejora As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_estado_mejora As System.Windows.Forms.Label
    Friend WithEvents cmbTipo_mejora As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_tipo_mejora As System.Windows.Forms.Label
    Friend WithEvents chkActivo_mejora As System.Windows.Forms.CheckBox
    Friend WithEvents btnCambiarForm As System.Windows.Forms.Button
    Protected WithEvents btnAgregar As Button
    Protected WithEvents btnModificar As Button
    Protected WithEvents btnBorrar As Button
    Friend WithEvents btnImprimirEntreFecha As System.Windows.Forms.Button
    Friend WithEvents btnImprimirEntreFechaIngesoft As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPendientes As System.Windows.Forms.Button
    Friend WithEvents btnRetrasadas As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPrioritarias As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnHoy As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSemana As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblHorasEstimadas As System.Windows.Forms.Label
    Friend WithEvents lblHorasReales As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarEstadoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalizadoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanceladoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendidaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramadaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarFechaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaActualToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaPersonalizadaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarPrioridadToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnImprimirEntreFechaIngesoftProyecto As Button
    Friend WithEvents btnImprimirEntreFechaProyecto As Button
    Friend WithEvents btnImprimirEntreFechaIngesoftSubproyecto As Button
    Friend WithEvents btnImprimirEntreFechaSubproyecto As Button
    Friend WithEvents btnImprimirGantt As System.Windows.Forms.Button
    Friend WithEvents btnCalendario As Button
    Protected WithEvents btnAgregarExpress As System.Windows.Forms.Button
    Friend WithEvents btnExportarTareas As System.Windows.Forms.Button
    Friend WithEvents lblcargandoreporte As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class

