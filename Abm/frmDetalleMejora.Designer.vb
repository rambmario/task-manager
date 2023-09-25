<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleMejora
   Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleMejora))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtdescripcion_mejora = New System.Windows.Forms.TextBox()
        Me.etiquetadescripcion_mejora = New System.Windows.Forms.Label()
        Me.lblid_tipo_mejora = New System.Windows.Forms.Label()
        Me.cmbtipo_mejora = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_tipo_mejora = New System.Windows.Forms.Label()
        Me.dtpfecha_prevista_cierre = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_prevista_cierre = New System.Windows.Forms.Label()
        Me.lblid_usuario_asignado = New System.Windows.Forms.Label()
        Me.cmbusuario_asignado = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario_asignado = New System.Windows.Forms.Label()
        Me.lblid_origen_mejora = New System.Windows.Forms.Label()
        Me.cmborigen_mejora = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_origen_mejora = New System.Windows.Forms.Label()
        Me.txtubicacion_archivos = New System.Windows.Forms.TextBox()
        Me.etiquetaubicacion_archivos = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCod_sub_proyecto = New System.Windows.Forms.ComboBox()
        Me.cmbCod_empresa = New System.Windows.Forms.ComboBox()
        Me.cmbCod_Proyecto = New System.Windows.Forms.ComboBox()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.cmbSub_proyecto = New System.Windows.Forms.ComboBox()
        Me.lblid_sub_proyecto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tpCierre = New System.Windows.Forms.TabPage()
        Me.txtcosto_total = New System.Windows.Forms.TextBox()
        Me.etiquetacosto_total = New System.Windows.Forms.Label()
        Me.dtpfecha_cierre = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_cierre = New System.Windows.Forms.Label()
        Me.txtcosto_no_calidad = New System.Windows.Forms.TextBox()
        Me.etiquetacosto_no_calidad = New System.Windows.Forms.Label()
        Me.txtcosto_acciones = New System.Windows.Forms.TextBox()
        Me.etiquetacosto_acciones = New System.Windows.Forms.Label()
        Me.txtdescripcion_cierre = New System.Windows.Forms.TextBox()
        Me.etiquetadescripcion_cierre = New System.Windows.Forms.Label()
        Me.txtcosto_prevencion = New System.Windows.Forms.TextBox()
        Me.etiquetacosto_prevencion = New System.Windows.Forms.Label()
        Me.txtnumero_accion_relacionada = New System.Windows.Forms.TextBox()
        Me.etiquetanumero_accion_relacionada = New System.Windows.Forms.Label()
        Me.rbtPocoEficaz = New System.Windows.Forms.RadioButton()
        Me.rbtNoEficaz = New System.Windows.Forms.RadioButton()
        Me.rbtEficaz = New System.Windows.Forms.RadioButton()
        Me.etiquetaanalisis_eficacia = New System.Windows.Forms.Label()
        Me.lblid_usuario_cierre = New System.Windows.Forms.Label()
        Me.cmbusuario_cierre = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario_cierre = New System.Windows.Forms.Label()
        Me.tpAccionCorrectiva = New System.Windows.Forms.TabPage()
        Me.dtpfecha_accion_correctiva = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_accion_correctiva = New System.Windows.Forms.Label()
        Me.txtprevision_accion_correctiva = New System.Windows.Forms.TextBox()
        Me.etiquetaprevision_accion_correctiva = New System.Windows.Forms.Label()
        Me.txtdescripcion_accion_correctiva = New System.Windows.Forms.TextBox()
        Me.etiquetadescripcion_accion_correctiva = New System.Windows.Forms.Label()
        Me.lblid_usuario_accion_correctiva = New System.Windows.Forms.Label()
        Me.cmbusuario_accion_correctiva = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario_accion_correctiva = New System.Windows.Forms.Label()
        Me.tpAccion = New System.Windows.Forms.TabPage()
        Me.lblid_mejora_accion = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvMejoraAccion = New System.Windows.Forms.DataGridView()
        Me.tpCausa = New System.Windows.Forms.TabPage()
        Me.etiquetaid_responsable_analisis = New System.Windows.Forms.Label()
        Me.lblid_responsable_analisis = New System.Windows.Forms.Label()
        Me.cmbresponsable_analisis = New System.Windows.Forms.ComboBox()
        Me.etiquetadescripcion_causa = New System.Windows.Forms.Label()
        Me.lblid_metodo_causa = New System.Windows.Forms.Label()
        Me.cmbmetodo_causa = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_metodo_causa = New System.Windows.Forms.Label()
        Me.MetroTabControl1 = New System.Windows.Forms.TabControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtMedia = New System.Windows.Forms.RadioButton()
        Me.rbtAlta = New System.Windows.Forms.RadioButton()
        Me.rbtBaja = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtSuspendida = New System.Windows.Forms.RadioButton()
        Me.rbtProgramada = New System.Windows.Forms.RadioButton()
        Me.rbtCancelada = New System.Windows.Forms.RadioButton()
        Me.rbtFinalizada = New System.Windows.Forms.RadioButton()
        Me.lblid_empresa = New System.Windows.Forms.Label()
        Me.lblid_mejora = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnAbrirExplorador = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPathCroquis = New System.Windows.Forms.Button()
        Me.btnBuscaproyecto = New System.Windows.Forms.Button()
        Me.btnBuscar_empresa = New System.Windows.Forms.Button()
        Me.btnBuscar_sub_proyecto = New System.Windows.Forms.Button()
        Me.btnBuscatipo_mejora = New System.Windows.Forms.Button()
        Me.btnBuscaorigen_mejora = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscametodo_causa = New System.Windows.Forms.Button()
        Me.txtdescripcion_causa = New System.Windows.Forms.TextBox()
        Me.dtpfecha_causa = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_causa = New System.Windows.Forms.Label()
        Me.dtpfecha_finalizacion_accion = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_finalizacion_accion = New System.Windows.Forms.Label()
        Me.tpCierre.SuspendLayout()
        Me.tpAccionCorrectiva.SuspendLayout()
        Me.tpAccion.SuspendLayout()
        CType(Me.dgvMejoraAccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCausa.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdescripcion_mejora
        '
        Me.txtdescripcion_mejora.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_mejora.Location = New System.Drawing.Point(161, 159)
        Me.txtdescripcion_mejora.MaxLength = 5000
        Me.txtdescripcion_mejora.Multiline = True
        Me.txtdescripcion_mejora.Name = "txtdescripcion_mejora"
        Me.txtdescripcion_mejora.Size = New System.Drawing.Size(518, 63)
        Me.txtdescripcion_mejora.TabIndex = 7
        '
        'etiquetadescripcion_mejora
        '
        Me.etiquetadescripcion_mejora.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetadescripcion_mejora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadescripcion_mejora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadescripcion_mejora.ForeColor = System.Drawing.Color.White
        Me.etiquetadescripcion_mejora.Location = New System.Drawing.Point(22, 159)
        Me.etiquetadescripcion_mejora.Name = "etiquetadescripcion_mejora"
        Me.etiquetadescripcion_mejora.Size = New System.Drawing.Size(133, 21)
        Me.etiquetadescripcion_mejora.TabIndex = 500
        Me.etiquetadescripcion_mejora.Text = "Descripcion"
        Me.etiquetadescripcion_mejora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_tipo_mejora
        '
        Me.lblid_tipo_mejora.AutoSize = True
        Me.lblid_tipo_mejora.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_mejora.Location = New System.Drawing.Point(370, 134)
        Me.lblid_tipo_mejora.Name = "lblid_tipo_mejora"
        Me.lblid_tipo_mejora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_mejora.TabIndex = 501
        Me.lblid_tipo_mejora.Text = "0"
        Me.lblid_tipo_mejora.Visible = False
        '
        'cmbtipo_mejora
        '
        Me.cmbtipo_mejora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_mejora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_mejora.FormattingEnabled = True
        Me.cmbtipo_mejora.Location = New System.Drawing.Point(161, 134)
        Me.cmbtipo_mejora.Name = "cmbtipo_mejora"
        Me.cmbtipo_mejora.Size = New System.Drawing.Size(349, 21)
        Me.cmbtipo_mejora.TabIndex = 6
        '
        'etiquetaid_tipo_mejora
        '
        Me.etiquetaid_tipo_mejora.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_tipo_mejora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_mejora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_mejora.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_tipo_mejora.Location = New System.Drawing.Point(22, 134)
        Me.etiquetaid_tipo_mejora.Name = "etiquetaid_tipo_mejora"
        Me.etiquetaid_tipo_mejora.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_tipo_mejora.TabIndex = 502
        Me.etiquetaid_tipo_mejora.Text = "Tipo"
        Me.etiquetaid_tipo_mejora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecha_prevista_cierre
        '
        Me.dtpfecha_prevista_cierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_prevista_cierre.Location = New System.Drawing.Point(161, 352)
        Me.dtpfecha_prevista_cierre.Name = "dtpfecha_prevista_cierre"
        Me.dtpfecha_prevista_cierre.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_prevista_cierre.TabIndex = 12
        '
        'etiquetafecha_prevista_cierre
        '
        Me.etiquetafecha_prevista_cierre.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_prevista_cierre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_prevista_cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_prevista_cierre.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_prevista_cierre.Location = New System.Drawing.Point(22, 352)
        Me.etiquetafecha_prevista_cierre.Name = "etiquetafecha_prevista_cierre"
        Me.etiquetafecha_prevista_cierre.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_prevista_cierre.TabIndex = 505
        Me.etiquetafecha_prevista_cierre.Text = "Fecha prevista cierre"
        Me.etiquetafecha_prevista_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_usuario_asignado
        '
        Me.lblid_usuario_asignado.AutoSize = True
        Me.lblid_usuario_asignado.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_asignado.Location = New System.Drawing.Point(370, 107)
        Me.lblid_usuario_asignado.Name = "lblid_usuario_asignado"
        Me.lblid_usuario_asignado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_asignado.TabIndex = 510
        Me.lblid_usuario_asignado.Text = "0"
        Me.lblid_usuario_asignado.Visible = False
        '
        'cmbusuario_asignado
        '
        Me.cmbusuario_asignado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario_asignado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario_asignado.FormattingEnabled = True
        Me.cmbusuario_asignado.Location = New System.Drawing.Point(161, 107)
        Me.cmbusuario_asignado.Name = "cmbusuario_asignado"
        Me.cmbusuario_asignado.Size = New System.Drawing.Size(349, 21)
        Me.cmbusuario_asignado.TabIndex = 5
        '
        'etiquetaid_usuario_asignado
        '
        Me.etiquetaid_usuario_asignado.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_usuario_asignado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_usuario_asignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario_asignado.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_usuario_asignado.Location = New System.Drawing.Point(22, 107)
        Me.etiquetaid_usuario_asignado.Name = "etiquetaid_usuario_asignado"
        Me.etiquetaid_usuario_asignado.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_usuario_asignado.TabIndex = 511
        Me.etiquetaid_usuario_asignado.Text = "Asignado"
        Me.etiquetaid_usuario_asignado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_origen_mejora
        '
        Me.lblid_origen_mejora.AutoSize = True
        Me.lblid_origen_mejora.BackColor = System.Drawing.Color.Red
        Me.lblid_origen_mejora.Location = New System.Drawing.Point(370, 317)
        Me.lblid_origen_mejora.Name = "lblid_origen_mejora"
        Me.lblid_origen_mejora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_origen_mejora.TabIndex = 512
        Me.lblid_origen_mejora.Text = "0"
        Me.lblid_origen_mejora.Visible = False
        '
        'cmborigen_mejora
        '
        Me.cmborigen_mejora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmborigen_mejora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmborigen_mejora.FormattingEnabled = True
        Me.cmborigen_mejora.Location = New System.Drawing.Point(161, 317)
        Me.cmborigen_mejora.Name = "cmborigen_mejora"
        Me.cmborigen_mejora.Size = New System.Drawing.Size(349, 21)
        Me.cmborigen_mejora.TabIndex = 11
        '
        'etiquetaid_origen_mejora
        '
        Me.etiquetaid_origen_mejora.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_origen_mejora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_origen_mejora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_origen_mejora.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_origen_mejora.Location = New System.Drawing.Point(22, 317)
        Me.etiquetaid_origen_mejora.Name = "etiquetaid_origen_mejora"
        Me.etiquetaid_origen_mejora.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_origen_mejora.TabIndex = 513
        Me.etiquetaid_origen_mejora.Text = "Origen"
        Me.etiquetaid_origen_mejora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtubicacion_archivos
        '
        Me.txtubicacion_archivos.BackColor = System.Drawing.Color.White
        Me.txtubicacion_archivos.Enabled = False
        Me.txtubicacion_archivos.Location = New System.Drawing.Point(160, 378)
        Me.txtubicacion_archivos.MaxLength = 5000
        Me.txtubicacion_archivos.Name = "txtubicacion_archivos"
        Me.txtubicacion_archivos.Size = New System.Drawing.Size(483, 20)
        Me.txtubicacion_archivos.TabIndex = 13
        '
        'etiquetaubicacion_archivos
        '
        Me.etiquetaubicacion_archivos.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaubicacion_archivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaubicacion_archivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaubicacion_archivos.ForeColor = System.Drawing.Color.White
        Me.etiquetaubicacion_archivos.Location = New System.Drawing.Point(21, 378)
        Me.etiquetaubicacion_archivos.Name = "etiquetaubicacion_archivos"
        Me.etiquetaubicacion_archivos.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaubicacion_archivos.TabIndex = 514
        Me.etiquetaubicacion_archivos.Text = "Ubicacion archivos"
        Me.etiquetaubicacion_archivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.SteelBlue
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(161, 81)
        Me.txtUsuario.MaxLength = 5000
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(349, 20)
        Me.txtUsuario.TabIndex = 537
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 21)
        Me.Label1.TabIndex = 538
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCod_sub_proyecto
        '
        Me.cmbCod_sub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_sub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_sub_proyecto.FormattingEnabled = True
        Me.cmbCod_sub_proyecto.Location = New System.Drawing.Point(160, 279)
        Me.cmbCod_sub_proyecto.Name = "cmbCod_sub_proyecto"
        Me.cmbCod_sub_proyecto.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_sub_proyecto.TabIndex = 10
        '
        'cmbCod_empresa
        '
        Me.cmbCod_empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_empresa.FormattingEnabled = True
        Me.cmbCod_empresa.Location = New System.Drawing.Point(160, 228)
        Me.cmbCod_empresa.Name = "cmbCod_empresa"
        Me.cmbCod_empresa.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_empresa.TabIndex = 8
        '
        'cmbCod_Proyecto
        '
        Me.cmbCod_Proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_Proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_Proyecto.FormattingEnabled = True
        Me.cmbCod_Proyecto.Location = New System.Drawing.Point(160, 252)
        Me.cmbCod_Proyecto.Name = "cmbCod_Proyecto"
        Me.cmbCod_Proyecto.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_Proyecto.TabIndex = 9
        '
        'cmbproyecto
        '
        Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(350, 252)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(329, 21)
        Me.cmbproyecto.TabIndex = 629
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(331, 256)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 632
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(350, 228)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(329, 21)
        Me.cmbEmpresa.TabIndex = 628
        '
        'cmbSub_proyecto
        '
        Me.cmbSub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSub_proyecto.FormattingEnabled = True
        Me.cmbSub_proyecto.Location = New System.Drawing.Point(350, 279)
        Me.cmbSub_proyecto.Name = "cmbSub_proyecto"
        Me.cmbSub_proyecto.Size = New System.Drawing.Size(329, 21)
        Me.cmbSub_proyecto.TabIndex = 630
        '
        'lblid_sub_proyecto
        '
        Me.lblid_sub_proyecto.AutoSize = True
        Me.lblid_sub_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_sub_proyecto.Location = New System.Drawing.Point(331, 283)
        Me.lblid_sub_proyecto.Name = "lblid_sub_proyecto"
        Me.lblid_sub_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_sub_proyecto.TabIndex = 635
        Me.lblid_sub_proyecto.Text = "0"
        Me.lblid_sub_proyecto.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 21)
        Me.Label2.TabIndex = 639
        Me.Label2.Text = "Area/Proceso"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 21)
        Me.Label3.TabIndex = 640
        Me.Label3.Text = "Proyecto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 21)
        Me.Label4.TabIndex = 641
        Me.Label4.Text = "Empresa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpCierre
        '
        Me.tpCierre.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tpCierre.Controls.Add(Me.txtcosto_total)
        Me.tpCierre.Controls.Add(Me.etiquetacosto_total)
        Me.tpCierre.Controls.Add(Me.dtpfecha_cierre)
        Me.tpCierre.Controls.Add(Me.etiquetafecha_cierre)
        Me.tpCierre.Controls.Add(Me.txtcosto_no_calidad)
        Me.tpCierre.Controls.Add(Me.etiquetacosto_no_calidad)
        Me.tpCierre.Controls.Add(Me.txtcosto_acciones)
        Me.tpCierre.Controls.Add(Me.etiquetacosto_acciones)
        Me.tpCierre.Controls.Add(Me.txtdescripcion_cierre)
        Me.tpCierre.Controls.Add(Me.etiquetadescripcion_cierre)
        Me.tpCierre.Controls.Add(Me.txtcosto_prevencion)
        Me.tpCierre.Controls.Add(Me.etiquetacosto_prevencion)
        Me.tpCierre.Controls.Add(Me.txtnumero_accion_relacionada)
        Me.tpCierre.Controls.Add(Me.etiquetanumero_accion_relacionada)
        Me.tpCierre.Controls.Add(Me.rbtPocoEficaz)
        Me.tpCierre.Controls.Add(Me.rbtNoEficaz)
        Me.tpCierre.Controls.Add(Me.rbtEficaz)
        Me.tpCierre.Controls.Add(Me.etiquetaanalisis_eficacia)
        Me.tpCierre.Controls.Add(Me.lblid_usuario_cierre)
        Me.tpCierre.Controls.Add(Me.cmbusuario_cierre)
        Me.tpCierre.Controls.Add(Me.etiquetaid_usuario_cierre)
        Me.tpCierre.Location = New System.Drawing.Point(4, 32)
        Me.tpCierre.Name = "tpCierre"
        Me.tpCierre.Size = New System.Drawing.Size(737, 313)
        Me.tpCierre.TabIndex = 3
        Me.tpCierre.Text = "Cierre"
        '
        'txtcosto_total
        '
        Me.txtcosto_total.BackColor = System.Drawing.Color.White
        Me.txtcosto_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto_total.ForeColor = System.Drawing.Color.Blue
        Me.txtcosto_total.Location = New System.Drawing.Point(532, 194)
        Me.txtcosto_total.MaxLength = 50
        Me.txtcosto_total.Name = "txtcosto_total"
        Me.txtcosto_total.Size = New System.Drawing.Size(167, 31)
        Me.txtcosto_total.TabIndex = 34
        Me.txtcosto_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacosto_total
        '
        Me.etiquetacosto_total.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetacosto_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacosto_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacosto_total.ForeColor = System.Drawing.Color.White
        Me.etiquetacosto_total.Location = New System.Drawing.Point(398, 194)
        Me.etiquetacosto_total.Name = "etiquetacosto_total"
        Me.etiquetacosto_total.Size = New System.Drawing.Size(130, 21)
        Me.etiquetacosto_total.TabIndex = 661
        Me.etiquetacosto_total.Text = "Costo total"
        Me.etiquetacosto_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecha_cierre
        '
        Me.dtpfecha_cierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_cierre.Location = New System.Drawing.Point(532, 231)
        Me.dtpfecha_cierre.Name = "dtpfecha_cierre"
        Me.dtpfecha_cierre.Size = New System.Drawing.Size(115, 20)
        Me.dtpfecha_cierre.TabIndex = 660
        '
        'etiquetafecha_cierre
        '
        Me.etiquetafecha_cierre.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_cierre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_cierre.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_cierre.Location = New System.Drawing.Point(398, 230)
        Me.etiquetafecha_cierre.Name = "etiquetafecha_cierre"
        Me.etiquetafecha_cierre.Size = New System.Drawing.Size(130, 21)
        Me.etiquetafecha_cierre.TabIndex = 662
        Me.etiquetafecha_cierre.Text = "Fecha cierre"
        Me.etiquetafecha_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcosto_no_calidad
        '
        Me.txtcosto_no_calidad.BackColor = System.Drawing.Color.White
        Me.txtcosto_no_calidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto_no_calidad.ForeColor = System.Drawing.Color.Blue
        Me.txtcosto_no_calidad.Location = New System.Drawing.Point(532, 152)
        Me.txtcosto_no_calidad.MaxLength = 50
        Me.txtcosto_no_calidad.Name = "txtcosto_no_calidad"
        Me.txtcosto_no_calidad.Size = New System.Drawing.Size(167, 31)
        Me.txtcosto_no_calidad.TabIndex = 33
        Me.txtcosto_no_calidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacosto_no_calidad
        '
        Me.etiquetacosto_no_calidad.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetacosto_no_calidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacosto_no_calidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacosto_no_calidad.ForeColor = System.Drawing.Color.White
        Me.etiquetacosto_no_calidad.Location = New System.Drawing.Point(398, 154)
        Me.etiquetacosto_no_calidad.Name = "etiquetacosto_no_calidad"
        Me.etiquetacosto_no_calidad.Size = New System.Drawing.Size(130, 21)
        Me.etiquetacosto_no_calidad.TabIndex = 658
        Me.etiquetacosto_no_calidad.Text = "Costo no calidad"
        Me.etiquetacosto_no_calidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcosto_acciones
        '
        Me.txtcosto_acciones.BackColor = System.Drawing.Color.White
        Me.txtcosto_acciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto_acciones.ForeColor = System.Drawing.Color.Blue
        Me.txtcosto_acciones.Location = New System.Drawing.Point(194, 224)
        Me.txtcosto_acciones.MaxLength = 50
        Me.txtcosto_acciones.Name = "txtcosto_acciones"
        Me.txtcosto_acciones.Size = New System.Drawing.Size(200, 31)
        Me.txtcosto_acciones.TabIndex = 32
        Me.txtcosto_acciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacosto_acciones
        '
        Me.etiquetacosto_acciones.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetacosto_acciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacosto_acciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacosto_acciones.ForeColor = System.Drawing.Color.White
        Me.etiquetacosto_acciones.Location = New System.Drawing.Point(54, 224)
        Me.etiquetacosto_acciones.Name = "etiquetacosto_acciones"
        Me.etiquetacosto_acciones.Size = New System.Drawing.Size(133, 21)
        Me.etiquetacosto_acciones.TabIndex = 656
        Me.etiquetacosto_acciones.Text = "Costo acciones"
        Me.etiquetacosto_acciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdescripcion_cierre
        '
        Me.txtdescripcion_cierre.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_cierre.Location = New System.Drawing.Point(195, 85)
        Me.txtdescripcion_cierre.MaxLength = 5000
        Me.txtdescripcion_cierre.Multiline = True
        Me.txtdescripcion_cierre.Name = "txtdescripcion_cierre"
        Me.txtdescripcion_cierre.Size = New System.Drawing.Size(330, 54)
        Me.txtdescripcion_cierre.TabIndex = 29
        '
        'etiquetadescripcion_cierre
        '
        Me.etiquetadescripcion_cierre.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetadescripcion_cierre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadescripcion_cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadescripcion_cierre.ForeColor = System.Drawing.Color.White
        Me.etiquetadescripcion_cierre.Location = New System.Drawing.Point(56, 85)
        Me.etiquetadescripcion_cierre.Name = "etiquetadescripcion_cierre"
        Me.etiquetadescripcion_cierre.Size = New System.Drawing.Size(133, 21)
        Me.etiquetadescripcion_cierre.TabIndex = 654
        Me.etiquetadescripcion_cierre.Text = "Descripcion"
        Me.etiquetadescripcion_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcosto_prevencion
        '
        Me.txtcosto_prevencion.BackColor = System.Drawing.Color.White
        Me.txtcosto_prevencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto_prevencion.ForeColor = System.Drawing.Color.Blue
        Me.txtcosto_prevencion.Location = New System.Drawing.Point(193, 190)
        Me.txtcosto_prevencion.MaxLength = 50
        Me.txtcosto_prevencion.Name = "txtcosto_prevencion"
        Me.txtcosto_prevencion.Size = New System.Drawing.Size(200, 31)
        Me.txtcosto_prevencion.TabIndex = 31
        Me.txtcosto_prevencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacosto_prevencion
        '
        Me.etiquetacosto_prevencion.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetacosto_prevencion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacosto_prevencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacosto_prevencion.ForeColor = System.Drawing.Color.White
        Me.etiquetacosto_prevencion.Location = New System.Drawing.Point(54, 190)
        Me.etiquetacosto_prevencion.Name = "etiquetacosto_prevencion"
        Me.etiquetacosto_prevencion.Size = New System.Drawing.Size(133, 21)
        Me.etiquetacosto_prevencion.TabIndex = 652
        Me.etiquetacosto_prevencion.Text = "Costo prevencion"
        Me.etiquetacosto_prevencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnumero_accion_relacionada
        '
        Me.txtnumero_accion_relacionada.BackColor = System.Drawing.Color.White
        Me.txtnumero_accion_relacionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero_accion_relacionada.ForeColor = System.Drawing.Color.Blue
        Me.txtnumero_accion_relacionada.Location = New System.Drawing.Point(193, 151)
        Me.txtnumero_accion_relacionada.MaxLength = 50
        Me.txtnumero_accion_relacionada.Name = "txtnumero_accion_relacionada"
        Me.txtnumero_accion_relacionada.Size = New System.Drawing.Size(200, 31)
        Me.txtnumero_accion_relacionada.TabIndex = 30
        Me.txtnumero_accion_relacionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetanumero_accion_relacionada
        '
        Me.etiquetanumero_accion_relacionada.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetanumero_accion_relacionada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_accion_relacionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_accion_relacionada.ForeColor = System.Drawing.Color.White
        Me.etiquetanumero_accion_relacionada.Location = New System.Drawing.Point(55, 153)
        Me.etiquetanumero_accion_relacionada.Name = "etiquetanumero_accion_relacionada"
        Me.etiquetanumero_accion_relacionada.Size = New System.Drawing.Size(133, 21)
        Me.etiquetanumero_accion_relacionada.TabIndex = 650
        Me.etiquetanumero_accion_relacionada.Text = "Numero"
        Me.etiquetanumero_accion_relacionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtPocoEficaz
        '
        Me.rbtPocoEficaz.AutoSize = True
        Me.rbtPocoEficaz.Location = New System.Drawing.Point(285, 55)
        Me.rbtPocoEficaz.Name = "rbtPocoEficaz"
        Me.rbtPocoEficaz.Size = New System.Drawing.Size(82, 17)
        Me.rbtPocoEficaz.TabIndex = 648
        Me.rbtPocoEficaz.Text = "Poco Eficaz"
        Me.rbtPocoEficaz.UseVisualStyleBackColor = True
        '
        'rbtNoEficaz
        '
        Me.rbtNoEficaz.AutoSize = True
        Me.rbtNoEficaz.Location = New System.Drawing.Point(403, 55)
        Me.rbtNoEficaz.Name = "rbtNoEficaz"
        Me.rbtNoEficaz.Size = New System.Drawing.Size(71, 17)
        Me.rbtNoEficaz.TabIndex = 647
        Me.rbtNoEficaz.TabStop = True
        Me.rbtNoEficaz.Text = "No Eficaz"
        Me.rbtNoEficaz.UseVisualStyleBackColor = True
        '
        'rbtEficaz
        '
        Me.rbtEficaz.AutoSize = True
        Me.rbtEficaz.Checked = True
        Me.rbtEficaz.Location = New System.Drawing.Point(199, 55)
        Me.rbtEficaz.Name = "rbtEficaz"
        Me.rbtEficaz.Size = New System.Drawing.Size(54, 17)
        Me.rbtEficaz.TabIndex = 646
        Me.rbtEficaz.TabStop = True
        Me.rbtEficaz.Text = "Eficaz"
        Me.rbtEficaz.UseVisualStyleBackColor = True
        '
        'etiquetaanalisis_eficacia
        '
        Me.etiquetaanalisis_eficacia.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaanalisis_eficacia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaanalisis_eficacia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaanalisis_eficacia.ForeColor = System.Drawing.Color.White
        Me.etiquetaanalisis_eficacia.Location = New System.Drawing.Point(56, 52)
        Me.etiquetaanalisis_eficacia.Name = "etiquetaanalisis_eficacia"
        Me.etiquetaanalisis_eficacia.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaanalisis_eficacia.TabIndex = 532
        Me.etiquetaanalisis_eficacia.Text = "Analisis eficacia"
        Me.etiquetaanalisis_eficacia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_usuario_cierre
        '
        Me.lblid_usuario_cierre.AutoSize = True
        Me.lblid_usuario_cierre.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_cierre.Location = New System.Drawing.Point(339, 20)
        Me.lblid_usuario_cierre.Name = "lblid_usuario_cierre"
        Me.lblid_usuario_cierre.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_cierre.TabIndex = 530
        Me.lblid_usuario_cierre.Text = "0"
        Me.lblid_usuario_cierre.Visible = False
        '
        'cmbusuario_cierre
        '
        Me.cmbusuario_cierre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario_cierre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario_cierre.FormattingEnabled = True
        Me.cmbusuario_cierre.Location = New System.Drawing.Point(195, 20)
        Me.cmbusuario_cierre.Name = "cmbusuario_cierre"
        Me.cmbusuario_cierre.Size = New System.Drawing.Size(330, 21)
        Me.cmbusuario_cierre.TabIndex = 28
        '
        'etiquetaid_usuario_cierre
        '
        Me.etiquetaid_usuario_cierre.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_usuario_cierre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_usuario_cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario_cierre.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_usuario_cierre.Location = New System.Drawing.Point(56, 19)
        Me.etiquetaid_usuario_cierre.Name = "etiquetaid_usuario_cierre"
        Me.etiquetaid_usuario_cierre.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_usuario_cierre.TabIndex = 531
        Me.etiquetaid_usuario_cierre.Text = "Usuario"
        Me.etiquetaid_usuario_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpAccionCorrectiva
        '
        Me.tpAccionCorrectiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tpAccionCorrectiva.Controls.Add(Me.dtpfecha_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.etiquetafecha_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.txtprevision_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.etiquetaprevision_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.txtdescripcion_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.etiquetadescripcion_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.lblid_usuario_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.cmbusuario_accion_correctiva)
        Me.tpAccionCorrectiva.Controls.Add(Me.etiquetaid_usuario_accion_correctiva)
        Me.tpAccionCorrectiva.Location = New System.Drawing.Point(4, 32)
        Me.tpAccionCorrectiva.Name = "tpAccionCorrectiva"
        Me.tpAccionCorrectiva.Size = New System.Drawing.Size(737, 313)
        Me.tpAccionCorrectiva.TabIndex = 2
        Me.tpAccionCorrectiva.Text = "Accion Correctiva"
        '
        'dtpfecha_accion_correctiva
        '
        Me.dtpfecha_accion_correctiva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_accion_correctiva.Location = New System.Drawing.Point(203, 177)
        Me.dtpfecha_accion_correctiva.Name = "dtpfecha_accion_correctiva"
        Me.dtpfecha_accion_correctiva.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_accion_correctiva.TabIndex = 27
        '
        'etiquetafecha_accion_correctiva
        '
        Me.etiquetafecha_accion_correctiva.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_accion_correctiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_accion_correctiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_accion_correctiva.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_accion_correctiva.Location = New System.Drawing.Point(64, 177)
        Me.etiquetafecha_accion_correctiva.Name = "etiquetafecha_accion_correctiva"
        Me.etiquetafecha_accion_correctiva.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_accion_correctiva.TabIndex = 532
        Me.etiquetafecha_accion_correctiva.Text = "Fecha"
        Me.etiquetafecha_accion_correctiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtprevision_accion_correctiva
        '
        Me.txtprevision_accion_correctiva.BackColor = System.Drawing.Color.White
        Me.txtprevision_accion_correctiva.Location = New System.Drawing.Point(201, 137)
        Me.txtprevision_accion_correctiva.MaxLength = 5000
        Me.txtprevision_accion_correctiva.Name = "txtprevision_accion_correctiva"
        Me.txtprevision_accion_correctiva.Size = New System.Drawing.Size(330, 20)
        Me.txtprevision_accion_correctiva.TabIndex = 26
        '
        'etiquetaprevision_accion_correctiva
        '
        Me.etiquetaprevision_accion_correctiva.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaprevision_accion_correctiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprevision_accion_correctiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprevision_accion_correctiva.ForeColor = System.Drawing.Color.White
        Me.etiquetaprevision_accion_correctiva.Location = New System.Drawing.Point(62, 136)
        Me.etiquetaprevision_accion_correctiva.Name = "etiquetaprevision_accion_correctiva"
        Me.etiquetaprevision_accion_correctiva.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaprevision_accion_correctiva.TabIndex = 530
        Me.etiquetaprevision_accion_correctiva.Text = "Prevision"
        Me.etiquetaprevision_accion_correctiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdescripcion_accion_correctiva
        '
        Me.txtdescripcion_accion_correctiva.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_accion_correctiva.Location = New System.Drawing.Point(202, 66)
        Me.txtdescripcion_accion_correctiva.MaxLength = 5000
        Me.txtdescripcion_accion_correctiva.Multiline = True
        Me.txtdescripcion_accion_correctiva.Name = "txtdescripcion_accion_correctiva"
        Me.txtdescripcion_accion_correctiva.Size = New System.Drawing.Size(330, 53)
        Me.txtdescripcion_accion_correctiva.TabIndex = 25
        '
        'etiquetadescripcion_accion_correctiva
        '
        Me.etiquetadescripcion_accion_correctiva.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetadescripcion_accion_correctiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadescripcion_accion_correctiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadescripcion_accion_correctiva.ForeColor = System.Drawing.Color.White
        Me.etiquetadescripcion_accion_correctiva.Location = New System.Drawing.Point(63, 65)
        Me.etiquetadescripcion_accion_correctiva.Name = "etiquetadescripcion_accion_correctiva"
        Me.etiquetadescripcion_accion_correctiva.Size = New System.Drawing.Size(133, 21)
        Me.etiquetadescripcion_accion_correctiva.TabIndex = 528
        Me.etiquetadescripcion_accion_correctiva.Text = "Descripcion"
        Me.etiquetadescripcion_accion_correctiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_usuario_accion_correctiva
        '
        Me.lblid_usuario_accion_correctiva.AutoSize = True
        Me.lblid_usuario_accion_correctiva.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_accion_correctiva.Location = New System.Drawing.Point(348, 22)
        Me.lblid_usuario_accion_correctiva.Name = "lblid_usuario_accion_correctiva"
        Me.lblid_usuario_accion_correctiva.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_accion_correctiva.TabIndex = 525
        Me.lblid_usuario_accion_correctiva.Text = "0"
        Me.lblid_usuario_accion_correctiva.Visible = False
        '
        'cmbusuario_accion_correctiva
        '
        Me.cmbusuario_accion_correctiva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario_accion_correctiva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario_accion_correctiva.FormattingEnabled = True
        Me.cmbusuario_accion_correctiva.Location = New System.Drawing.Point(204, 22)
        Me.cmbusuario_accion_correctiva.Name = "cmbusuario_accion_correctiva"
        Me.cmbusuario_accion_correctiva.Size = New System.Drawing.Size(320, 21)
        Me.cmbusuario_accion_correctiva.TabIndex = 24
        '
        'etiquetaid_usuario_accion_correctiva
        '
        Me.etiquetaid_usuario_accion_correctiva.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_usuario_accion_correctiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_usuario_accion_correctiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario_accion_correctiva.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_usuario_accion_correctiva.Location = New System.Drawing.Point(62, 22)
        Me.etiquetaid_usuario_accion_correctiva.Name = "etiquetaid_usuario_accion_correctiva"
        Me.etiquetaid_usuario_accion_correctiva.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_usuario_accion_correctiva.TabIndex = 526
        Me.etiquetaid_usuario_accion_correctiva.Text = "Usuario"
        Me.etiquetaid_usuario_accion_correctiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpAccion
        '
        Me.tpAccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tpAccion.Controls.Add(Me.lblid_mejora_accion)
        Me.tpAccion.Controls.Add(Me.btnBorrar)
        Me.tpAccion.Controls.Add(Me.btnModificar)
        Me.tpAccion.Controls.Add(Me.btnAgregar)
        Me.tpAccion.Controls.Add(Me.dgvMejoraAccion)
        Me.tpAccion.Location = New System.Drawing.Point(4, 32)
        Me.tpAccion.Name = "tpAccion"
        Me.tpAccion.Size = New System.Drawing.Size(737, 313)
        Me.tpAccion.TabIndex = 0
        Me.tpAccion.Text = "Accion"
        '
        'lblid_mejora_accion
        '
        Me.lblid_mejora_accion.AutoSize = True
        Me.lblid_mejora_accion.BackColor = System.Drawing.Color.Red
        Me.lblid_mejora_accion.Location = New System.Drawing.Point(362, 147)
        Me.lblid_mejora_accion.Name = "lblid_mejora_accion"
        Me.lblid_mejora_accion.Size = New System.Drawing.Size(13, 13)
        Me.lblid_mejora_accion.TabIndex = 650
        Me.lblid_mejora_accion.Text = "0"
        Me.lblid_mejora_accion.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(667, 133)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(45, 40)
        Me.btnBorrar.TabIndex = 649
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(666, 77)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(45, 40)
        Me.btnModificar.TabIndex = 648
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(665, 25)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 40)
        Me.btnAgregar.TabIndex = 647
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvMejoraAccion
        '
        Me.dgvMejoraAccion.AllowUserToAddRows = False
        Me.dgvMejoraAccion.AllowUserToResizeColumns = False
        Me.dgvMejoraAccion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMejoraAccion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMejoraAccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMejoraAccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMejoraAccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMejoraAccion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMejoraAccion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMejoraAccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMejoraAccion.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMejoraAccion.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvMejoraAccion.Location = New System.Drawing.Point(2, 2)
        Me.dgvMejoraAccion.Name = "dgvMejoraAccion"
        Me.dgvMejoraAccion.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMejoraAccion.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMejoraAccion.ShowCellErrors = False
        Me.dgvMejoraAccion.Size = New System.Drawing.Size(650, 250)
        Me.dgvMejoraAccion.TabIndex = 644
        '
        'tpCausa
        '
        Me.tpCausa.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tpCausa.Controls.Add(Me.dtpfecha_finalizacion_accion)
        Me.tpCausa.Controls.Add(Me.etiquetafecha_finalizacion_accion)
        Me.tpCausa.Controls.Add(Me.dtpfecha_causa)
        Me.tpCausa.Controls.Add(Me.etiquetafecha_causa)
        Me.tpCausa.Controls.Add(Me.btnBuscametodo_causa)
        Me.tpCausa.Controls.Add(Me.txtdescripcion_causa)
        Me.tpCausa.Controls.Add(Me.etiquetaid_responsable_analisis)
        Me.tpCausa.Controls.Add(Me.lblid_responsable_analisis)
        Me.tpCausa.Controls.Add(Me.cmbresponsable_analisis)
        Me.tpCausa.Controls.Add(Me.etiquetadescripcion_causa)
        Me.tpCausa.Controls.Add(Me.lblid_metodo_causa)
        Me.tpCausa.Controls.Add(Me.cmbmetodo_causa)
        Me.tpCausa.Controls.Add(Me.etiquetaid_metodo_causa)
        Me.tpCausa.Location = New System.Drawing.Point(4, 32)
        Me.tpCausa.Name = "tpCausa"
        Me.tpCausa.Size = New System.Drawing.Size(737, 313)
        Me.tpCausa.TabIndex = 1
        Me.tpCausa.Text = "Causa"
        '
        'etiquetaid_responsable_analisis
        '
        Me.etiquetaid_responsable_analisis.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_responsable_analisis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_responsable_analisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_responsable_analisis.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_responsable_analisis.Location = New System.Drawing.Point(44, 26)
        Me.etiquetaid_responsable_analisis.Name = "etiquetaid_responsable_analisis"
        Me.etiquetaid_responsable_analisis.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_responsable_analisis.TabIndex = 527
        Me.etiquetaid_responsable_analisis.Text = "Responsable analisis"
        Me.etiquetaid_responsable_analisis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_responsable_analisis
        '
        Me.lblid_responsable_analisis.AutoSize = True
        Me.lblid_responsable_analisis.BackColor = System.Drawing.Color.Red
        Me.lblid_responsable_analisis.Location = New System.Drawing.Point(413, 26)
        Me.lblid_responsable_analisis.Name = "lblid_responsable_analisis"
        Me.lblid_responsable_analisis.Size = New System.Drawing.Size(13, 13)
        Me.lblid_responsable_analisis.TabIndex = 526
        Me.lblid_responsable_analisis.Text = "0"
        Me.lblid_responsable_analisis.Visible = False
        '
        'cmbresponsable_analisis
        '
        Me.cmbresponsable_analisis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbresponsable_analisis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbresponsable_analisis.FormattingEnabled = True
        Me.cmbresponsable_analisis.Location = New System.Drawing.Point(183, 24)
        Me.cmbresponsable_analisis.Name = "cmbresponsable_analisis"
        Me.cmbresponsable_analisis.Size = New System.Drawing.Size(349, 21)
        Me.cmbresponsable_analisis.TabIndex = 20
        '
        'etiquetadescripcion_causa
        '
        Me.etiquetadescripcion_causa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetadescripcion_causa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadescripcion_causa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadescripcion_causa.ForeColor = System.Drawing.Color.White
        Me.etiquetadescripcion_causa.Location = New System.Drawing.Point(45, 127)
        Me.etiquetadescripcion_causa.Name = "etiquetadescripcion_causa"
        Me.etiquetadescripcion_causa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetadescripcion_causa.TabIndex = 524
        Me.etiquetadescripcion_causa.Text = "Descripcion causa"
        Me.etiquetadescripcion_causa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_metodo_causa
        '
        Me.lblid_metodo_causa.AutoSize = True
        Me.lblid_metodo_causa.BackColor = System.Drawing.Color.Red
        Me.lblid_metodo_causa.Location = New System.Drawing.Point(328, 81)
        Me.lblid_metodo_causa.Name = "lblid_metodo_causa"
        Me.lblid_metodo_causa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_metodo_causa.TabIndex = 521
        Me.lblid_metodo_causa.Text = "0"
        Me.lblid_metodo_causa.Visible = False
        '
        'cmbmetodo_causa
        '
        Me.cmbmetodo_causa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmetodo_causa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmetodo_causa.FormattingEnabled = True
        Me.cmbmetodo_causa.Location = New System.Drawing.Point(184, 78)
        Me.cmbmetodo_causa.Name = "cmbmetodo_causa"
        Me.cmbmetodo_causa.Size = New System.Drawing.Size(349, 21)
        Me.cmbmetodo_causa.TabIndex = 21
        '
        'etiquetaid_metodo_causa
        '
        Me.etiquetaid_metodo_causa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_metodo_causa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_metodo_causa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_metodo_causa.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_metodo_causa.Location = New System.Drawing.Point(43, 78)
        Me.etiquetaid_metodo_causa.Name = "etiquetaid_metodo_causa"
        Me.etiquetaid_metodo_causa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_metodo_causa.TabIndex = 522
        Me.etiquetaid_metodo_causa.Text = "Metodo causa"
        Me.etiquetaid_metodo_causa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tpCausa)
        Me.MetroTabControl1.Controls.Add(Me.tpAccion)
        Me.MetroTabControl1.Controls.Add(Me.tpAccionCorrectiva)
        Me.MetroTabControl1.Controls.Add(Me.tpCierre)
        Me.MetroTabControl1.Location = New System.Drawing.Point(21, 404)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.Padding = New System.Drawing.Point(6, 8)
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(745, 349)
        Me.MetroTabControl1.TabIndex = 642
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtMedia)
        Me.GroupBox2.Controls.Add(Me.rbtAlta)
        Me.GroupBox2.Controls.Add(Me.rbtBaja)
        Me.GroupBox2.Location = New System.Drawing.Point(744, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 107)
        Me.GroupBox2.TabIndex = 644
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prioridad"
        '
        'rbtMedia
        '
        Me.rbtMedia.AutoSize = True
        Me.rbtMedia.Location = New System.Drawing.Point(29, 50)
        Me.rbtMedia.Name = "rbtMedia"
        Me.rbtMedia.Size = New System.Drawing.Size(54, 17)
        Me.rbtMedia.TabIndex = 638
        Me.rbtMedia.Text = "Media"
        Me.rbtMedia.UseVisualStyleBackColor = True
        '
        'rbtAlta
        '
        Me.rbtAlta.AutoSize = True
        Me.rbtAlta.Location = New System.Drawing.Point(29, 27)
        Me.rbtAlta.Name = "rbtAlta"
        Me.rbtAlta.Size = New System.Drawing.Size(43, 17)
        Me.rbtAlta.TabIndex = 637
        Me.rbtAlta.Text = "Alta"
        Me.rbtAlta.UseVisualStyleBackColor = True
        '
        'rbtBaja
        '
        Me.rbtBaja.AutoSize = True
        Me.rbtBaja.Checked = True
        Me.rbtBaja.Location = New System.Drawing.Point(29, 73)
        Me.rbtBaja.Name = "rbtBaja"
        Me.rbtBaja.Size = New System.Drawing.Size(46, 17)
        Me.rbtBaja.TabIndex = 639
        Me.rbtBaja.TabStop = True
        Me.rbtBaja.Text = "Baja"
        Me.rbtBaja.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtSuspendida)
        Me.GroupBox1.Controls.Add(Me.rbtProgramada)
        Me.GroupBox1.Controls.Add(Me.rbtCancelada)
        Me.GroupBox1.Controls.Add(Me.rbtFinalizada)
        Me.GroupBox1.Location = New System.Drawing.Point(744, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 109)
        Me.GroupBox1.TabIndex = 643
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'rbtSuspendida
        '
        Me.rbtSuspendida.AutoSize = True
        Me.rbtSuspendida.Location = New System.Drawing.Point(26, 38)
        Me.rbtSuspendida.Name = "rbtSuspendida"
        Me.rbtSuspendida.Size = New System.Drawing.Size(81, 17)
        Me.rbtSuspendida.TabIndex = 633
        Me.rbtSuspendida.Text = "Suspendida"
        Me.rbtSuspendida.UseVisualStyleBackColor = True
        '
        'rbtProgramada
        '
        Me.rbtProgramada.AutoSize = True
        Me.rbtProgramada.Checked = True
        Me.rbtProgramada.Location = New System.Drawing.Point(26, 15)
        Me.rbtProgramada.Name = "rbtProgramada"
        Me.rbtProgramada.Size = New System.Drawing.Size(82, 17)
        Me.rbtProgramada.TabIndex = 632
        Me.rbtProgramada.TabStop = True
        Me.rbtProgramada.Text = "Programada"
        Me.rbtProgramada.UseVisualStyleBackColor = True
        '
        'rbtCancelada
        '
        Me.rbtCancelada.AutoSize = True
        Me.rbtCancelada.Location = New System.Drawing.Point(26, 61)
        Me.rbtCancelada.Name = "rbtCancelada"
        Me.rbtCancelada.Size = New System.Drawing.Size(76, 17)
        Me.rbtCancelada.TabIndex = 634
        Me.rbtCancelada.Text = "Cancelada"
        Me.rbtCancelada.UseVisualStyleBackColor = True
        '
        'rbtFinalizada
        '
        Me.rbtFinalizada.AutoSize = True
        Me.rbtFinalizada.Location = New System.Drawing.Point(26, 84)
        Me.rbtFinalizada.Name = "rbtFinalizada"
        Me.rbtFinalizada.Size = New System.Drawing.Size(72, 17)
        Me.rbtFinalizada.TabIndex = 635
        Me.rbtFinalizada.Text = "Finalizada"
        Me.rbtFinalizada.UseVisualStyleBackColor = True
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(331, 232)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 645
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'lblid_mejora
        '
        Me.lblid_mejora.AutoSize = True
        Me.lblid_mejora.BackColor = System.Drawing.Color.Red
        Me.lblid_mejora.Location = New System.Drawing.Point(104, 34)
        Me.lblid_mejora.Name = "lblid_mejora"
        Me.lblid_mejora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_mejora.TabIndex = 647
        Me.lblid_mejora.Text = "0"
        Me.lblid_mejora.Visible = False
        '
        'btnAbrirExplorador
        '
        Me.btnAbrirExplorador.Image = Global.Gestion_tarea.My.Resources.Resources.Carpeta16
        Me.btnAbrirExplorador.Location = New System.Drawing.Point(649, 374)
        Me.btnAbrirExplorador.Name = "btnAbrirExplorador"
        Me.btnAbrirExplorador.Size = New System.Drawing.Size(30, 24)
        Me.btnAbrirExplorador.TabIndex = 649
        Me.btnAbrirExplorador.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Gestion_tarea.My.Resources.Resources.mejorasgris
        Me.PictureBox1.Location = New System.Drawing.Point(813, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 648
        Me.PictureBox1.TabStop = False
        '
        'btnPathCroquis
        '
        Me.btnPathCroquis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPathCroquis.Image = CType(resources.GetObject("btnPathCroquis.Image"), System.Drawing.Image)
        Me.btnPathCroquis.Location = New System.Drawing.Point(694, 374)
        Me.btnPathCroquis.Name = "btnPathCroquis"
        Me.btnPathCroquis.Size = New System.Drawing.Size(30, 24)
        Me.btnPathCroquis.TabIndex = 646
        Me.btnPathCroquis.UseVisualStyleBackColor = True
        '
        'btnBuscaproyecto
        '
        Me.btnBuscaproyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproyecto.Image = CType(resources.GetObject("btnBuscaproyecto.Image"), System.Drawing.Image)
        Me.btnBuscaproyecto.Location = New System.Drawing.Point(694, 252)
        Me.btnBuscaproyecto.Name = "btnBuscaproyecto"
        Me.btnBuscaproyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproyecto.TabIndex = 631
        Me.btnBuscaproyecto.UseVisualStyleBackColor = True
        '
        'btnBuscar_empresa
        '
        Me.btnBuscar_empresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_empresa.Image = CType(resources.GetObject("btnBuscar_empresa.Image"), System.Drawing.Image)
        Me.btnBuscar_empresa.Location = New System.Drawing.Point(694, 228)
        Me.btnBuscar_empresa.Name = "btnBuscar_empresa"
        Me.btnBuscar_empresa.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscar_empresa.TabIndex = 633
        Me.btnBuscar_empresa.UseVisualStyleBackColor = True
        '
        'btnBuscar_sub_proyecto
        '
        Me.btnBuscar_sub_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_sub_proyecto.Image = CType(resources.GetObject("btnBuscar_sub_proyecto.Image"), System.Drawing.Image)
        Me.btnBuscar_sub_proyecto.Location = New System.Drawing.Point(694, 279)
        Me.btnBuscar_sub_proyecto.Name = "btnBuscar_sub_proyecto"
        Me.btnBuscar_sub_proyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscar_sub_proyecto.TabIndex = 634
        Me.btnBuscar_sub_proyecto.UseVisualStyleBackColor = True
        '
        'btnBuscatipo_mejora
        '
        Me.btnBuscatipo_mejora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_mejora.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscatipo_mejora.Location = New System.Drawing.Point(516, 133)
        Me.btnBuscatipo_mejora.Name = "btnBuscatipo_mejora"
        Me.btnBuscatipo_mejora.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_mejora.TabIndex = 60
        Me.btnBuscatipo_mejora.UseVisualStyleBackColor = True
        '
        'btnBuscaorigen_mejora
        '
        Me.btnBuscaorigen_mejora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaorigen_mejora.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscaorigen_mejora.Location = New System.Drawing.Point(516, 317)
        Me.btnBuscaorigen_mejora.Name = "btnBuscaorigen_mejora"
        Me.btnBuscaorigen_mejora.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaorigen_mejora.TabIndex = 64
        Me.btnBuscaorigen_mejora.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.Gestion_tarea.My.Resources.Resources.salir_c_1_35
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(801, 691)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 58)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = Global.Gestion_tarea.My.Resources.Resources.guardar_3_1_35
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(801, 614)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBuscametodo_causa
        '
        Me.btnBuscametodo_causa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscametodo_causa.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscametodo_causa.Location = New System.Drawing.Point(539, 78)
        Me.btnBuscametodo_causa.Name = "btnBuscametodo_causa"
        Me.btnBuscametodo_causa.Size = New System.Drawing.Size(31, 21)
        Me.btnBuscametodo_causa.TabIndex = 532
        Me.btnBuscametodo_causa.UseVisualStyleBackColor = True
        '
        'txtdescripcion_causa
        '
        Me.txtdescripcion_causa.BackColor = System.Drawing.Color.White
        Me.txtdescripcion_causa.Location = New System.Drawing.Point(186, 127)
        Me.txtdescripcion_causa.MaxLength = 5000
        Me.txtdescripcion_causa.Multiline = True
        Me.txtdescripcion_causa.Name = "txtdescripcion_causa"
        Me.txtdescripcion_causa.Size = New System.Drawing.Size(375, 92)
        Me.txtdescripcion_causa.TabIndex = 531
        '
        'dtpfecha_causa
        '
        Me.dtpfecha_causa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpfecha_causa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_causa.Location = New System.Drawing.Point(186, 231)
        Me.dtpfecha_causa.Name = "dtpfecha_causa"
        Me.dtpfecha_causa.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_causa.TabIndex = 533
        '
        'etiquetafecha_causa
        '
        Me.etiquetafecha_causa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_causa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_causa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_causa.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_causa.Location = New System.Drawing.Point(45, 233)
        Me.etiquetafecha_causa.Name = "etiquetafecha_causa"
        Me.etiquetafecha_causa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_causa.TabIndex = 534
        Me.etiquetafecha_causa.Text = "Fecha causa"
        Me.etiquetafecha_causa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecha_finalizacion_accion
        '
        Me.dtpfecha_finalizacion_accion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_finalizacion_accion.Location = New System.Drawing.Point(186, 268)
        Me.dtpfecha_finalizacion_accion.Name = "dtpfecha_finalizacion_accion"
        Me.dtpfecha_finalizacion_accion.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_finalizacion_accion.TabIndex = 647
        '
        'etiquetafecha_finalizacion_accion
        '
        Me.etiquetafecha_finalizacion_accion.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_finalizacion_accion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_finalizacion_accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_finalizacion_accion.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_finalizacion_accion.Location = New System.Drawing.Point(45, 270)
        Me.etiquetafecha_finalizacion_accion.Name = "etiquetafecha_finalizacion_accion"
        Me.etiquetafecha_finalizacion_accion.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_finalizacion_accion.TabIndex = 648
        Me.etiquetafecha_finalizacion_accion.Text = "Fecha finalizacion"
        Me.etiquetafecha_finalizacion_accion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDetalleMejora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 760)
        Me.Controls.Add(Me.btnAbrirExplorador)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblid_mejora)
        Me.Controls.Add(Me.btnPathCroquis)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCod_sub_proyecto)
        Me.Controls.Add(Me.cmbCod_empresa)
        Me.Controls.Add(Me.cmbCod_Proyecto)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.btnBuscaproyecto)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.cmbEmpresa)
        Me.Controls.Add(Me.btnBuscar_empresa)
        Me.Controls.Add(Me.cmbSub_proyecto)
        Me.Controls.Add(Me.btnBuscar_sub_proyecto)
        Me.Controls.Add(Me.lblid_sub_proyecto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtdescripcion_mejora)
        Me.Controls.Add(Me.etiquetadescripcion_mejora)
        Me.Controls.Add(Me.lblid_tipo_mejora)
        Me.Controls.Add(Me.btnBuscatipo_mejora)
        Me.Controls.Add(Me.cmbtipo_mejora)
        Me.Controls.Add(Me.etiquetaid_tipo_mejora)
        Me.Controls.Add(Me.dtpfecha_prevista_cierre)
        Me.Controls.Add(Me.etiquetafecha_prevista_cierre)
        Me.Controls.Add(Me.lblid_usuario_asignado)
        Me.Controls.Add(Me.cmbusuario_asignado)
        Me.Controls.Add(Me.etiquetaid_usuario_asignado)
        Me.Controls.Add(Me.lblid_origen_mejora)
        Me.Controls.Add(Me.btnBuscaorigen_mejora)
        Me.Controls.Add(Me.cmborigen_mejora)
        Me.Controls.Add(Me.etiquetaid_origen_mejora)
        Me.Controls.Add(Me.txtubicacion_archivos)
        Me.Controls.Add(Me.etiquetaubicacion_archivos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleMejora"
        Me.Text = "Mejora"
        Me.tpCierre.ResumeLayout(False)
        Me.tpCierre.PerformLayout()
        Me.tpAccionCorrectiva.ResumeLayout(False)
        Me.tpAccionCorrectiva.PerformLayout()
        Me.tpAccion.ResumeLayout(False)
        Me.tpAccion.PerformLayout()
        CType(Me.dgvMejoraAccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCausa.ResumeLayout(False)
        Me.tpCausa.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtdescripcion_mejora As System.Windows.Forms.TextBox
    Friend WithEvents etiquetadescripcion_mejora As System.Windows.Forms.Label
    Friend WithEvents lblid_tipo_mejora As System.Windows.Forms.Label
    Friend WithEvents btnBuscatipo_mejora As System.Windows.Forms.Button
    Friend WithEvents cmbtipo_mejora As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_tipo_mejora As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_prevista_cierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_prevista_cierre As System.Windows.Forms.Label
    Friend WithEvents lblid_usuario_asignado As System.Windows.Forms.Label
    Friend WithEvents cmbusuario_asignado As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_usuario_asignado As System.Windows.Forms.Label
    Friend WithEvents lblid_origen_mejora As System.Windows.Forms.Label
    Friend WithEvents btnBuscaorigen_mejora As System.Windows.Forms.Button
    Friend WithEvents cmborigen_mejora As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_origen_mejora As System.Windows.Forms.Label
    Protected WithEvents txtubicacion_archivos As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaubicacion_archivos As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCod_sub_proyecto As ComboBox
    Friend WithEvents cmbCod_empresa As ComboBox
    Friend WithEvents cmbCod_Proyecto As ComboBox
    Friend WithEvents cmbproyecto As ComboBox
    Friend WithEvents btnBuscaproyecto As Button
    Friend WithEvents lblid_proyecto As Label
    Friend WithEvents cmbEmpresa As ComboBox
    Friend WithEvents btnBuscar_empresa As Button
    Friend WithEvents cmbSub_proyecto As ComboBox
    Friend WithEvents btnBuscar_sub_proyecto As Button
    Friend WithEvents lblid_sub_proyecto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tpCierre As TabPage
    Friend WithEvents tpAccionCorrectiva As TabPage
    Friend WithEvents tpAccion As TabPage
    Friend WithEvents tpCausa As TabPage
    Friend WithEvents etiquetaid_responsable_analisis As Label
    Friend WithEvents lblid_responsable_analisis As Label
    Friend WithEvents cmbresponsable_analisis As ComboBox
    Friend WithEvents etiquetadescripcion_causa As Label
    Friend WithEvents lblid_metodo_causa As Label
    Friend WithEvents cmbmetodo_causa As ComboBox
    Friend WithEvents etiquetaid_metodo_causa As Label
    Friend WithEvents dgvMejoraAccion As DataGridView
    Protected WithEvents btnBorrar As Button
    Protected WithEvents btnModificar As Button
    Protected WithEvents btnAgregar As Button
    Friend WithEvents rbtPocoEficaz As RadioButton
    Friend WithEvents rbtNoEficaz As RadioButton
    Friend WithEvents rbtEficaz As RadioButton
    Friend WithEvents etiquetaanalisis_eficacia As Label
    Friend WithEvents lblid_usuario_cierre As Label
    Friend WithEvents cmbusuario_cierre As ComboBox
    Friend WithEvents etiquetaid_usuario_cierre As Label
    Protected WithEvents dtpfecha_accion_correctiva As DateTimePicker
    Friend WithEvents etiquetafecha_accion_correctiva As Label
    Protected WithEvents txtprevision_accion_correctiva As TextBox
    Friend WithEvents etiquetaprevision_accion_correctiva As Label
    Protected WithEvents txtdescripcion_accion_correctiva As TextBox
    Friend WithEvents etiquetadescripcion_accion_correctiva As Label
    Friend WithEvents lblid_usuario_accion_correctiva As Label
    Friend WithEvents cmbusuario_accion_correctiva As ComboBox
    Friend WithEvents etiquetaid_usuario_accion_correctiva As Label
    Protected WithEvents txtcosto_total As TextBox
    Friend WithEvents etiquetacosto_total As Label
    Protected WithEvents dtpfecha_cierre As DateTimePicker
    Friend WithEvents etiquetafecha_cierre As Label
    Protected WithEvents txtcosto_no_calidad As TextBox
    Friend WithEvents etiquetacosto_no_calidad As Label
    Protected WithEvents txtcosto_acciones As TextBox
    Friend WithEvents etiquetacosto_acciones As Label
    Protected WithEvents txtdescripcion_cierre As TextBox
    Friend WithEvents etiquetadescripcion_cierre As Label
    Protected WithEvents txtcosto_prevencion As TextBox
    Friend WithEvents etiquetacosto_prevencion As Label
    Protected WithEvents txtnumero_accion_relacionada As TextBox
    Friend WithEvents etiquetanumero_accion_relacionada As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtMedia As RadioButton
    Friend WithEvents rbtAlta As RadioButton
    Friend WithEvents rbtBaja As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtSuspendida As RadioButton
    Friend WithEvents rbtProgramada As RadioButton
    Friend WithEvents rbtCancelada As RadioButton
    Friend WithEvents rbtFinalizada As RadioButton
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents btnPathCroquis As System.Windows.Forms.Button
    Friend WithEvents lblid_mejora As System.Windows.Forms.Label
    Friend WithEvents lblid_mejora_accion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents MetroTabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnAbrirExplorador As System.Windows.Forms.Button
    Friend WithEvents btnBuscametodo_causa As Button
    Protected WithEvents txtdescripcion_causa As TextBox
    Protected WithEvents dtpfecha_finalizacion_accion As DateTimePicker
    Friend WithEvents etiquetafecha_finalizacion_accion As Label
    Protected WithEvents dtpfecha_causa As DateTimePicker
    Friend WithEvents etiquetafecha_causa As Label
End Class

