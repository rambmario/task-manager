<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTarea_2
    'Inherits System.Windows.Forms.Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTarea_2))
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.etiquetaid_tipo_tarea = New System.Windows.Forms.Label()
        Me.txtidentificador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblid_usuario_asignado = New System.Windows.Forms.Label()
        Me.cmbusuario_asignado = New System.Windows.Forms.ComboBox()
        Me.lblid_tipo_tarea = New System.Windows.Forms.Label()
        Me.cmbtipo_tarea = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre_tarea = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_tarea = New System.Windows.Forms.Label()
        Me.lblid_sub_proyecto = New System.Windows.Forms.Label()
        Me.cmbSub_proyecto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblid_empresa = New System.Windows.Forms.Label()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_proyecto = New System.Windows.Forms.Label()
        Me.txthora_prevista = New System.Windows.Forms.TextBox()
        Me.etiquetahora_prevista = New System.Windows.Forms.Label()
        Me.dtpfecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_prevista = New System.Windows.Forms.Label()
        Me.txtUbicacion_documento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfecha_real = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_real = New System.Windows.Forms.Label()
        Me.txthora_real = New System.Windows.Forms.TextBox()
        Me.etiquetahora_real = New System.Windows.Forms.Label()
        Me.dgvHora_real = New System.Windows.Forms.DataGridView()
        Me.cmbCod_sub_proyecto = New System.Windows.Forms.ComboBox()
        Me.cmbCod_empresa = New System.Windows.Forms.ComboBox()
        Me.cmbCod_Proyecto = New System.Windows.Forms.ComboBox()
        Me.lblid_empresa_asignada = New System.Windows.Forms.Label()
        Me.cmbempresa_asignada = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtBaja = New System.Windows.Forms.RadioButton()
        Me.rbtMedia = New System.Windows.Forms.RadioButton()
        Me.rbtAlta = New System.Windows.Forms.RadioButton()
        Me.rbtFinalizada = New System.Windows.Forms.RadioButton()
        Me.rbtCancelada = New System.Windows.Forms.RadioButton()
        Me.rbtProgramada = New System.Windows.Forms.RadioButton()
        Me.rbtSuspendida = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblid_hora_real = New System.Windows.Forms.Label()
        Me.lblid_tarea = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkEs_feriado = New System.Windows.Forms.CheckBox()
        Me.txtDiaFin = New System.Windows.Forms.TextBox()
        Me.txtDiaInicio = New System.Windows.Forms.TextBox()
        Me.dtpFechaInicioPrevio = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraPrevistaPrevia = New System.Windows.Forms.TextBox()
        Me.txtTotalHorasPrevistasAcumuladas = New System.Windows.Forms.TextBox()
        Me.txtCapacidad_trabajo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAbrirExplorador = New System.Windows.Forms.Button()
        Me.dtpFecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtComplejidad_media = New System.Windows.Forms.RadioButton()
        Me.rbtComplejidad_alta = New System.Windows.Forms.RadioButton()
        Me.rbtComplejidad_baja = New System.Windows.Forms.RadioButton()
        Me.dtpFecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPathCroquis = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalHoraDiaReal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalHoraDia = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscaTipo_tarea = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscaproyecto = New System.Windows.Forms.Button()
        Me.btnBuscar_empresa = New System.Windows.Forms.Button()
        Me.btnBuscar_sub_proyecto = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvHora_real, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'etiquetaid_tipo_tarea
        '
        Me.etiquetaid_tipo_tarea.AutoSize = True
        Me.etiquetaid_tipo_tarea.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_tipo_tarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_tarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_tarea.Location = New System.Drawing.Point(445, 13)
        Me.etiquetaid_tipo_tarea.Name = "etiquetaid_tipo_tarea"
        Me.etiquetaid_tipo_tarea.Size = New System.Drawing.Size(50, 15)
        Me.etiquetaid_tipo_tarea.TabIndex = 503
        Me.etiquetaid_tipo_tarea.Text = "Usuario"
        Me.etiquetaid_tipo_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtidentificador
        '
        Me.txtidentificador.BackColor = System.Drawing.Color.SteelBlue
        Me.txtidentificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidentificador.ForeColor = System.Drawing.Color.White
        Me.txtidentificador.Location = New System.Drawing.Point(501, 13)
        Me.txtidentificador.MaxLength = 5000
        Me.txtidentificador.Name = "txtidentificador"
        Me.txtidentificador.Size = New System.Drawing.Size(284, 20)
        Me.txtidentificador.TabIndex = 502
        Me.txtidentificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 504
        Me.Label1.Text = "Asignado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario_asignado
        '
        Me.lblid_usuario_asignado.AutoSize = True
        Me.lblid_usuario_asignado.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_asignado.Location = New System.Drawing.Point(320, 13)
        Me.lblid_usuario_asignado.Name = "lblid_usuario_asignado"
        Me.lblid_usuario_asignado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_asignado.TabIndex = 506
        Me.lblid_usuario_asignado.Text = "0"
        Me.lblid_usuario_asignado.Visible = False
        '
        'cmbusuario_asignado
        '
        Me.cmbusuario_asignado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario_asignado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario_asignado.FormattingEnabled = True
        Me.cmbusuario_asignado.Location = New System.Drawing.Point(115, 13)
        Me.cmbusuario_asignado.Name = "cmbusuario_asignado"
        Me.cmbusuario_asignado.Size = New System.Drawing.Size(284, 21)
        Me.cmbusuario_asignado.TabIndex = 4
        '
        'lblid_tipo_tarea
        '
        Me.lblid_tipo_tarea.AutoSize = True
        Me.lblid_tipo_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_tarea.Location = New System.Drawing.Point(324, 40)
        Me.lblid_tipo_tarea.Name = "lblid_tipo_tarea"
        Me.lblid_tipo_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_tarea.TabIndex = 509
        Me.lblid_tipo_tarea.Text = "0"
        Me.lblid_tipo_tarea.Visible = False
        '
        'cmbtipo_tarea
        '
        Me.cmbtipo_tarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_tarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_tarea.FormattingEnabled = True
        Me.cmbtipo_tarea.Location = New System.Drawing.Point(115, 40)
        Me.cmbtipo_tarea.Name = "cmbtipo_tarea"
        Me.cmbtipo_tarea.Size = New System.Drawing.Size(284, 21)
        Me.cmbtipo_tarea.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(78, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 507
        Me.Label3.Text = "Tipo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre_tarea
        '
        Me.txtnombre_tarea.BackColor = System.Drawing.Color.White
        Me.txtnombre_tarea.Location = New System.Drawing.Point(115, 93)
        Me.txtnombre_tarea.MaxLength = 5000
        Me.txtnombre_tarea.Multiline = True
        Me.txtnombre_tarea.Name = "txtnombre_tarea"
        Me.txtnombre_tarea.Size = New System.Drawing.Size(542, 58)
        Me.txtnombre_tarea.TabIndex = 8
        '
        'etiquetanombre_tarea
        '
        Me.etiquetanombre_tarea.AutoSize = True
        Me.etiquetanombre_tarea.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre_tarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_tarea.Location = New System.Drawing.Point(37, 93)
        Me.etiquetanombre_tarea.Name = "etiquetanombre_tarea"
        Me.etiquetanombre_tarea.Size = New System.Drawing.Size(72, 15)
        Me.etiquetanombre_tarea.TabIndex = 512
        Me.etiquetanombre_tarea.Text = "Descripción"
        Me.etiquetanombre_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_sub_proyecto
        '
        Me.lblid_sub_proyecto.AutoSize = True
        Me.lblid_sub_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_sub_proyecto.Location = New System.Drawing.Point(309, 212)
        Me.lblid_sub_proyecto.Name = "lblid_sub_proyecto"
        Me.lblid_sub_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_sub_proyecto.TabIndex = 609
        Me.lblid_sub_proyecto.Text = "0"
        Me.lblid_sub_proyecto.Visible = False
        '
        'cmbSub_proyecto
        '
        Me.cmbSub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSub_proyecto.FormattingEnabled = True
        Me.cmbSub_proyecto.Location = New System.Drawing.Point(328, 208)
        Me.cmbSub_proyecto.Name = "cmbSub_proyecto"
        Me.cmbSub_proyecto.Size = New System.Drawing.Size(329, 21)
        Me.cmbSub_proyecto.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 610
        Me.Label7.Text = "Sub Proyecto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(309, 157)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 605
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(328, 157)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(329, 21)
        Me.cmbEmpresa.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(52, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 606
        Me.Label5.Text = "Empresa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(309, 185)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 601
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'cmbproyecto
        '
        Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(328, 181)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(329, 21)
        Me.cmbproyecto.TabIndex = 10
        '
        'etiquetaid_proyecto
        '
        Me.etiquetaid_proyecto.AutoSize = True
        Me.etiquetaid_proyecto.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proyecto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proyecto.Location = New System.Drawing.Point(55, 188)
        Me.etiquetaid_proyecto.Name = "etiquetaid_proyecto"
        Me.etiquetaid_proyecto.Size = New System.Drawing.Size(54, 15)
        Me.etiquetaid_proyecto.TabIndex = 602
        Me.etiquetaid_proyecto.Text = "Proyecto"
        Me.etiquetaid_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txthora_prevista
        '
        Me.txthora_prevista.BackColor = System.Drawing.Color.White
        Me.txthora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_prevista.ForeColor = System.Drawing.Color.Blue
        Me.txthora_prevista.Location = New System.Drawing.Point(115, 238)
        Me.txthora_prevista.MaxLength = 50
        Me.txthora_prevista.Name = "txthora_prevista"
        Me.txthora_prevista.Size = New System.Drawing.Size(113, 26)
        Me.txthora_prevista.TabIndex = 12
        Me.txthora_prevista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_prevista
        '
        Me.etiquetahora_prevista.AutoSize = True
        Me.etiquetahora_prevista.BackColor = System.Drawing.Color.Transparent
        Me.etiquetahora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_prevista.ForeColor = System.Drawing.Color.Black
        Me.etiquetahora_prevista.Location = New System.Drawing.Point(18, 246)
        Me.etiquetahora_prevista.Name = "etiquetahora_prevista"
        Me.etiquetahora_prevista.Size = New System.Drawing.Size(91, 15)
        Me.etiquetahora_prevista.TabIndex = 612
        Me.etiquetahora_prevista.Text = "Horas previstas"
        Me.etiquetahora_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_fin
        '
        Me.dtpfecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_fin.Location = New System.Drawing.Point(473, 243)
        Me.dtpfecha_fin.Name = "dtpfecha_fin"
        Me.dtpfecha_fin.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_fin.TabIndex = 13
        '
        'etiquetafecha_prevista
        '
        Me.etiquetafecha_prevista.AutoSize = True
        Me.etiquetafecha_prevista.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_prevista.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_prevista.Location = New System.Drawing.Point(398, 245)
        Me.etiquetafecha_prevista.Name = "etiquetafecha_prevista"
        Me.etiquetafecha_prevista.Size = New System.Drawing.Size(69, 15)
        Me.etiquetafecha_prevista.TabIndex = 614
        Me.etiquetafecha_prevista.Text = "Fin previsto"
        Me.etiquetafecha_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUbicacion_documento
        '
        Me.txtUbicacion_documento.BackColor = System.Drawing.Color.White
        Me.txtUbicacion_documento.Enabled = False
        Me.txtUbicacion_documento.Location = New System.Drawing.Point(156, 524)
        Me.txtUbicacion_documento.MaxLength = 5000
        Me.txtUbicacion_documento.Multiline = True
        Me.txtUbicacion_documento.Name = "txtUbicacion_documento"
        Me.txtUbicacion_documento.Size = New System.Drawing.Size(501, 24)
        Me.txtUbicacion_documento.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 524)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 616
        Me.Label2.Text = "Ubicación documentos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_real
        '
        Me.dtpfecha_real.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_real.Location = New System.Drawing.Point(343, 483)
        Me.dtpfecha_real.Name = "dtpfecha_real"
        Me.dtpfecha_real.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_real.TabIndex = 15
        '
        'etiquetafecha_real
        '
        Me.etiquetafecha_real.AutoSize = True
        Me.etiquetafecha_real.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_real.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_real.Location = New System.Drawing.Point(270, 487)
        Me.etiquetafecha_real.Name = "etiquetafecha_real"
        Me.etiquetafecha_real.Size = New System.Drawing.Size(65, 15)
        Me.etiquetafecha_real.TabIndex = 619
        Me.etiquetafecha_real.Text = "Fecha real"
        Me.etiquetafecha_real.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txthora_real
        '
        Me.txthora_real.BackColor = System.Drawing.Color.White
        Me.txthora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_real.ForeColor = System.Drawing.Color.Blue
        Me.txthora_real.Location = New System.Drawing.Point(115, 477)
        Me.txthora_real.MaxLength = 50
        Me.txthora_real.Name = "txthora_real"
        Me.txthora_real.Size = New System.Drawing.Size(113, 26)
        Me.txthora_real.TabIndex = 14
        Me.txthora_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_real
        '
        Me.etiquetahora_real.AutoSize = True
        Me.etiquetahora_real.BackColor = System.Drawing.Color.Transparent
        Me.etiquetahora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_real.ForeColor = System.Drawing.Color.Black
        Me.etiquetahora_real.Location = New System.Drawing.Point(32, 488)
        Me.etiquetahora_real.Name = "etiquetahora_real"
        Me.etiquetahora_real.Size = New System.Drawing.Size(77, 15)
        Me.etiquetahora_real.TabIndex = 620
        Me.etiquetahora_real.Text = "Horas reales"
        Me.etiquetahora_real.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvHora_real
        '
        Me.dgvHora_real.AllowUserToAddRows = False
        Me.dgvHora_real.AllowUserToResizeColumns = False
        Me.dgvHora_real.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvHora_real.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHora_real.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvHora_real.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHora_real.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHora_real.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHora_real.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHora_real.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHora_real.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvHora_real.Location = New System.Drawing.Point(12, 298)
        Me.dgvHora_real.Name = "dgvHora_real"
        Me.dgvHora_real.ReadOnly = True
        Me.dgvHora_real.ShowCellErrors = False
        Me.dgvHora_real.ShowRowErrors = False
        Me.dgvHora_real.Size = New System.Drawing.Size(728, 173)
        Me.dgvHora_real.StandardTab = True
        Me.dgvHora_real.TabIndex = 621
        '
        'cmbCod_sub_proyecto
        '
        Me.cmbCod_sub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_sub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_sub_proyecto.FormattingEnabled = True
        Me.cmbCod_sub_proyecto.Location = New System.Drawing.Point(115, 209)
        Me.cmbCod_sub_proyecto.Name = "cmbCod_sub_proyecto"
        Me.cmbCod_sub_proyecto.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_sub_proyecto.TabIndex = 627
        '
        'cmbCod_empresa
        '
        Me.cmbCod_empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_empresa.FormattingEnabled = True
        Me.cmbCod_empresa.Location = New System.Drawing.Point(115, 158)
        Me.cmbCod_empresa.Name = "cmbCod_empresa"
        Me.cmbCod_empresa.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_empresa.TabIndex = 626
        '
        'cmbCod_Proyecto
        '
        Me.cmbCod_Proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_Proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_Proyecto.FormattingEnabled = True
        Me.cmbCod_Proyecto.Location = New System.Drawing.Point(115, 182)
        Me.cmbCod_Proyecto.Name = "cmbCod_Proyecto"
        Me.cmbCod_Proyecto.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_Proyecto.TabIndex = 625
        '
        'lblid_empresa_asignada
        '
        Me.lblid_empresa_asignada.AutoSize = True
        Me.lblid_empresa_asignada.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa_asignada.Location = New System.Drawing.Point(742, 128)
        Me.lblid_empresa_asignada.Name = "lblid_empresa_asignada"
        Me.lblid_empresa_asignada.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa_asignada.TabIndex = 630
        Me.lblid_empresa_asignada.Text = "0"
        Me.lblid_empresa_asignada.Visible = False
        '
        'cmbempresa_asignada
        '
        Me.cmbempresa_asignada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbempresa_asignada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbempresa_asignada.FormattingEnabled = True
        Me.cmbempresa_asignada.Location = New System.Drawing.Point(747, 123)
        Me.cmbempresa_asignada.Name = "cmbempresa_asignada"
        Me.cmbempresa_asignada.Size = New System.Drawing.Size(38, 21)
        Me.cmbempresa_asignada.TabIndex = 6
        Me.cmbempresa_asignada.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(678, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 628
        Me.Label6.Text = "Empresa"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'rbtBaja
        '
        Me.rbtBaja.AutoSize = True
        Me.rbtBaja.Checked = True
        Me.rbtBaja.Location = New System.Drawing.Point(29, 61)
        Me.rbtBaja.Name = "rbtBaja"
        Me.rbtBaja.Size = New System.Drawing.Size(46, 17)
        Me.rbtBaja.TabIndex = 639
        Me.rbtBaja.TabStop = True
        Me.rbtBaja.Text = "Baja"
        Me.rbtBaja.UseVisualStyleBackColor = True
        '
        'rbtMedia
        '
        Me.rbtMedia.AutoSize = True
        Me.rbtMedia.Location = New System.Drawing.Point(29, 38)
        Me.rbtMedia.Name = "rbtMedia"
        Me.rbtMedia.Size = New System.Drawing.Size(54, 17)
        Me.rbtMedia.TabIndex = 638
        Me.rbtMedia.Text = "Media"
        Me.rbtMedia.UseVisualStyleBackColor = True
        '
        'rbtAlta
        '
        Me.rbtAlta.AutoSize = True
        Me.rbtAlta.Location = New System.Drawing.Point(29, 15)
        Me.rbtAlta.Name = "rbtAlta"
        Me.rbtAlta.Size = New System.Drawing.Size(43, 17)
        Me.rbtAlta.TabIndex = 637
        Me.rbtAlta.Text = "Alta"
        Me.rbtAlta.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtSuspendida)
        Me.GroupBox1.Controls.Add(Me.rbtProgramada)
        Me.GroupBox1.Controls.Add(Me.rbtCancelada)
        Me.GroupBox1.Controls.Add(Me.rbtFinalizada)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 554)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 109)
        Me.GroupBox1.TabIndex = 640
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtMedia)
        Me.GroupBox2.Controls.Add(Me.rbtAlta)
        Me.GroupBox2.Controls.Add(Me.rbtBaja)
        Me.GroupBox2.Location = New System.Drawing.Point(234, 556)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 107)
        Me.GroupBox2.TabIndex = 641
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prioridad"
        '
        'lblid_hora_real
        '
        Me.lblid_hora_real.AutoSize = True
        Me.lblid_hora_real.BackColor = System.Drawing.Color.Red
        Me.lblid_hora_real.Location = New System.Drawing.Point(38, 324)
        Me.lblid_hora_real.Name = "lblid_hora_real"
        Me.lblid_hora_real.Size = New System.Drawing.Size(13, 13)
        Me.lblid_hora_real.TabIndex = 642
        Me.lblid_hora_real.Text = "0"
        Me.lblid_hora_real.Visible = False
        '
        'lblid_tarea
        '
        Me.lblid_tarea.AutoSize = True
        Me.lblid_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tarea.Location = New System.Drawing.Point(17, 13)
        Me.lblid_tarea.Name = "lblid_tarea"
        Me.lblid_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tarea.TabIndex = 643
        Me.lblid_tarea.Text = "0"
        Me.lblid_tarea.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblid_tipo_tarea)
        Me.Panel1.Controls.Add(Me.lblid_usuario_asignado)
        Me.Panel1.Controls.Add(Me.chkEs_feriado)
        Me.Panel1.Controls.Add(Me.txtDiaFin)
        Me.Panel1.Controls.Add(Me.txtDiaInicio)
        Me.Panel1.Controls.Add(Me.dtpFechaInicioPrevio)
        Me.Panel1.Controls.Add(Me.txtHoraPrevistaPrevia)
        Me.Panel1.Controls.Add(Me.txtTotalHorasPrevistasAcumuladas)
        Me.Panel1.Controls.Add(Me.txtCapacidad_trabajo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnAbrirExplorador)
        Me.Panel1.Controls.Add(Me.dtpFecha_inicio)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.dtpFecha_pedido)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnPathCroquis)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTotalHoraDiaReal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTotalHoraDia)
        Me.Panel1.Controls.Add(Me.lblid_tarea)
        Me.Panel1.Controls.Add(Me.txtidentificador)
        Me.Panel1.Controls.Add(Me.lblid_hora_real)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.etiquetaid_tipo_tarea)
        Me.Panel1.Controls.Add(Me.lblid_empresa_asignada)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbempresa_asignada)
        Me.Panel1.Controls.Add(Me.cmbusuario_asignado)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbCod_sub_proyecto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbCod_empresa)
        Me.Panel1.Controls.Add(Me.cmbtipo_tarea)
        Me.Panel1.Controls.Add(Me.cmbCod_Proyecto)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Controls.Add(Me.btnBuscaTipo_tarea)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.etiquetanombre_tarea)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.txtnombre_tarea)
        Me.Panel1.Controls.Add(Me.dgvHora_real)
        Me.Panel1.Controls.Add(Me.etiquetaid_proyecto)
        Me.Panel1.Controls.Add(Me.dtpfecha_real)
        Me.Panel1.Controls.Add(Me.cmbproyecto)
        Me.Panel1.Controls.Add(Me.etiquetafecha_real)
        Me.Panel1.Controls.Add(Me.btnBuscaproyecto)
        Me.Panel1.Controls.Add(Me.txthora_real)
        Me.Panel1.Controls.Add(Me.lblid_proyecto)
        Me.Panel1.Controls.Add(Me.etiquetahora_real)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtUbicacion_documento)
        Me.Panel1.Controls.Add(Me.cmbEmpresa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnBuscar_empresa)
        Me.Panel1.Controls.Add(Me.dtpfecha_fin)
        Me.Panel1.Controls.Add(Me.lblid_empresa)
        Me.Panel1.Controls.Add(Me.etiquetafecha_prevista)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txthora_prevista)
        Me.Panel1.Controls.Add(Me.cmbSub_proyecto)
        Me.Panel1.Controls.Add(Me.etiquetahora_prevista)
        Me.Panel1.Controls.Add(Me.btnBuscar_sub_proyecto)
        Me.Panel1.Controls.Add(Me.lblid_sub_proyecto)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 668)
        Me.Panel1.TabIndex = 0
        '
        'chkEs_feriado
        '
        Me.chkEs_feriado.AutoSize = True
        Me.chkEs_feriado.Enabled = False
        Me.chkEs_feriado.Location = New System.Drawing.Point(261, 269)
        Me.chkEs_feriado.Name = "chkEs_feriado"
        Me.chkEs_feriado.Size = New System.Drawing.Size(15, 14)
        Me.chkEs_feriado.TabIndex = 660
        Me.chkEs_feriado.UseVisualStyleBackColor = True
        '
        'txtDiaFin
        '
        Me.txtDiaFin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDiaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaFin.ForeColor = System.Drawing.Color.White
        Me.txtDiaFin.Location = New System.Drawing.Point(473, 270)
        Me.txtDiaFin.MaxLength = 5000
        Me.txtDiaFin.Name = "txtDiaFin"
        Me.txtDiaFin.Size = New System.Drawing.Size(93, 22)
        Me.txtDiaFin.TabIndex = 659
        Me.txtDiaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaInicio
        '
        Me.txtDiaInicio.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDiaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaInicio.ForeColor = System.Drawing.Color.White
        Me.txtDiaInicio.Location = New System.Drawing.Point(282, 269)
        Me.txtDiaInicio.MaxLength = 5000
        Me.txtDiaInicio.Name = "txtDiaInicio"
        Me.txtDiaInicio.Size = New System.Drawing.Size(93, 22)
        Me.txtDiaInicio.TabIndex = 658
        Me.txtDiaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaInicioPrevio
        '
        Me.dtpFechaInicioPrevio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicioPrevio.Location = New System.Drawing.Point(747, 159)
        Me.dtpFechaInicioPrevio.Name = "dtpFechaInicioPrevio"
        Me.dtpFechaInicioPrevio.Size = New System.Drawing.Size(38, 20)
        Me.dtpFechaInicioPrevio.TabIndex = 657
        Me.dtpFechaInicioPrevio.Visible = False
        '
        'txtHoraPrevistaPrevia
        '
        Me.txtHoraPrevistaPrevia.BackColor = System.Drawing.Color.SteelBlue
        Me.txtHoraPrevistaPrevia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraPrevistaPrevia.ForeColor = System.Drawing.Color.White
        Me.txtHoraPrevistaPrevia.Location = New System.Drawing.Point(747, 185)
        Me.txtHoraPrevistaPrevia.MaxLength = 5000
        Me.txtHoraPrevistaPrevia.Name = "txtHoraPrevistaPrevia"
        Me.txtHoraPrevistaPrevia.Size = New System.Drawing.Size(38, 22)
        Me.txtHoraPrevistaPrevia.TabIndex = 656
        Me.txtHoraPrevistaPrevia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHoraPrevistaPrevia.Visible = False
        '
        'txtTotalHorasPrevistasAcumuladas
        '
        Me.txtTotalHorasPrevistasAcumuladas.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTotalHorasPrevistasAcumuladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHorasPrevistasAcumuladas.ForeColor = System.Drawing.Color.White
        Me.txtTotalHorasPrevistasAcumuladas.Location = New System.Drawing.Point(748, 242)
        Me.txtTotalHorasPrevistasAcumuladas.MaxLength = 5000
        Me.txtTotalHorasPrevistasAcumuladas.Name = "txtTotalHorasPrevistasAcumuladas"
        Me.txtTotalHorasPrevistasAcumuladas.Size = New System.Drawing.Size(44, 22)
        Me.txtTotalHorasPrevistasAcumuladas.TabIndex = 655
        Me.txtTotalHorasPrevistasAcumuladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCapacidad_trabajo
        '
        Me.txtCapacidad_trabajo.BackColor = System.Drawing.Color.SteelBlue
        Me.txtCapacidad_trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad_trabajo.ForeColor = System.Drawing.Color.White
        Me.txtCapacidad_trabajo.Location = New System.Drawing.Point(748, 213)
        Me.txtCapacidad_trabajo.MaxLength = 5000
        Me.txtCapacidad_trabajo.Name = "txtCapacidad_trabajo"
        Me.txtCapacidad_trabajo.Size = New System.Drawing.Size(38, 22)
        Me.txtCapacidad_trabajo.TabIndex = 654
        Me.txtCapacidad_trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCapacidad_trabajo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Gestion_tarea.My.Resources.Resources.tareasgris
        Me.PictureBox1.Location = New System.Drawing.Point(725, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 653
        Me.PictureBox1.TabStop = False
        '
        'btnAbrirExplorador
        '
        Me.btnAbrirExplorador.Image = Global.Gestion_tarea.My.Resources.Resources.Carpeta16
        Me.btnAbrirExplorador.Location = New System.Drawing.Point(672, 524)
        Me.btnAbrirExplorador.Name = "btnAbrirExplorador"
        Me.btnAbrirExplorador.Size = New System.Drawing.Size(30, 24)
        Me.btnAbrirExplorador.TabIndex = 652
        Me.btnAbrirExplorador.UseVisualStyleBackColor = True
        '
        'dtpFecha_inicio
        '
        Me.dtpFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_inicio.Location = New System.Drawing.Point(282, 243)
        Me.dtpFecha_inicio.Name = "dtpFecha_inicio"
        Me.dtpFecha_inicio.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecha_inicio.TabIndex = 650
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(240, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 651
        Me.Label10.Text = "Inicio"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtComplejidad_media)
        Me.GroupBox3.Controls.Add(Me.rbtComplejidad_alta)
        Me.GroupBox3.Controls.Add(Me.rbtComplejidad_baja)
        Me.GroupBox3.Location = New System.Drawing.Point(327, 556)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 107)
        Me.GroupBox3.TabIndex = 642
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Complejidad"
        '
        'rbtComplejidad_media
        '
        Me.rbtComplejidad_media.AutoSize = True
        Me.rbtComplejidad_media.Location = New System.Drawing.Point(29, 38)
        Me.rbtComplejidad_media.Name = "rbtComplejidad_media"
        Me.rbtComplejidad_media.Size = New System.Drawing.Size(54, 17)
        Me.rbtComplejidad_media.TabIndex = 638
        Me.rbtComplejidad_media.Text = "Media"
        Me.rbtComplejidad_media.UseVisualStyleBackColor = True
        '
        'rbtComplejidad_alta
        '
        Me.rbtComplejidad_alta.AutoSize = True
        Me.rbtComplejidad_alta.Location = New System.Drawing.Point(29, 15)
        Me.rbtComplejidad_alta.Name = "rbtComplejidad_alta"
        Me.rbtComplejidad_alta.Size = New System.Drawing.Size(43, 17)
        Me.rbtComplejidad_alta.TabIndex = 637
        Me.rbtComplejidad_alta.Text = "Alta"
        Me.rbtComplejidad_alta.UseVisualStyleBackColor = True
        '
        'rbtComplejidad_baja
        '
        Me.rbtComplejidad_baja.AutoSize = True
        Me.rbtComplejidad_baja.Checked = True
        Me.rbtComplejidad_baja.Location = New System.Drawing.Point(29, 61)
        Me.rbtComplejidad_baja.Name = "rbtComplejidad_baja"
        Me.rbtComplejidad_baja.Size = New System.Drawing.Size(46, 17)
        Me.rbtComplejidad_baja.TabIndex = 639
        Me.rbtComplejidad_baja.TabStop = True
        Me.rbtComplejidad_baja.Text = "Baja"
        Me.rbtComplejidad_baja.UseVisualStyleBackColor = True
        '
        'dtpFecha_pedido
        '
        Me.dtpFecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_pedido.Location = New System.Drawing.Point(115, 67)
        Me.dtpFecha_pedido.Name = "dtpFecha_pedido"
        Me.dtpFecha_pedido.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecha_pedido.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(50, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 15)
        Me.Label9.TabIndex = 649
        Me.Label9.Text = "Pedido el"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPathCroquis
        '
        Me.btnPathCroquis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPathCroquis.Image = CType(resources.GetObject("btnPathCroquis.Image"), System.Drawing.Image)
        Me.btnPathCroquis.Location = New System.Drawing.Point(710, 524)
        Me.btnPathCroquis.Name = "btnPathCroquis"
        Me.btnPathCroquis.Size = New System.Drawing.Size(30, 24)
        Me.btnPathCroquis.TabIndex = 67
        Me.btnPathCroquis.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(462, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 647
        Me.Label8.Text = "Total Hs Dia Real"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalHoraDiaReal
        '
        Me.txtTotalHoraDiaReal.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTotalHoraDiaReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHoraDiaReal.ForeColor = System.Drawing.Color.White
        Me.txtTotalHoraDiaReal.Location = New System.Drawing.Point(571, 480)
        Me.txtTotalHoraDiaReal.MaxLength = 5000
        Me.txtTotalHoraDiaReal.Name = "txtTotalHoraDiaReal"
        Me.txtTotalHoraDiaReal.Size = New System.Drawing.Size(44, 22)
        Me.txtTotalHoraDiaReal.TabIndex = 646
        Me.txtTotalHoraDiaReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(572, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 645
        Me.Label4.Text = "Total Hs Dia Prevista"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalHoraDia
        '
        Me.txtTotalHoraDia.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTotalHoraDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHoraDia.ForeColor = System.Drawing.Color.White
        Me.txtTotalHoraDia.Location = New System.Drawing.Point(698, 242)
        Me.txtTotalHoraDia.MaxLength = 5000
        Me.txtTotalHoraDia.Name = "txtTotalHoraDia"
        Me.txtTotalHoraDia.Size = New System.Drawing.Size(44, 22)
        Me.txtTotalHoraDia.TabIndex = 644
        Me.txtTotalHoraDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(746, 388)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(39, 39)
        Me.btnBorrar.TabIndex = 624
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscaTipo_tarea
        '
        Me.btnBuscaTipo_tarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaTipo_tarea.Image = CType(resources.GetObject("btnBuscaTipo_tarea.Image"), System.Drawing.Image)
        Me.btnBuscaTipo_tarea.Location = New System.Drawing.Point(405, 39)
        Me.btnBuscaTipo_tarea.Name = "btnBuscaTipo_tarea"
        Me.btnBuscaTipo_tarea.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaTipo_tarea.TabIndex = 510
        Me.btnBuscaTipo_tarea.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(746, 343)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(39, 39)
        Me.btnModificar.TabIndex = 623
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(747, 298)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(39, 39)
        Me.btnAgregar.TabIndex = 622
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscaproyecto
        '
        Me.btnBuscaproyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproyecto.Image = CType(resources.GetObject("btnBuscaproyecto.Image"), System.Drawing.Image)
        Me.btnBuscaproyecto.Location = New System.Drawing.Point(672, 181)
        Me.btnBuscaproyecto.Name = "btnBuscaproyecto"
        Me.btnBuscaproyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproyecto.TabIndex = 600
        Me.btnBuscaproyecto.UseVisualStyleBackColor = True
        '
        'btnBuscar_empresa
        '
        Me.btnBuscar_empresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_empresa.Image = CType(resources.GetObject("btnBuscar_empresa.Image"), System.Drawing.Image)
        Me.btnBuscar_empresa.Location = New System.Drawing.Point(672, 157)
        Me.btnBuscar_empresa.Name = "btnBuscar_empresa"
        Me.btnBuscar_empresa.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscar_empresa.TabIndex = 604
        Me.btnBuscar_empresa.UseVisualStyleBackColor = True
        '
        'btnBuscar_sub_proyecto
        '
        Me.btnBuscar_sub_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_sub_proyecto.Image = CType(resources.GetObject("btnBuscar_sub_proyecto.Image"), System.Drawing.Image)
        Me.btnBuscar_sub_proyecto.Location = New System.Drawing.Point(672, 208)
        Me.btnBuscar_sub_proyecto.Name = "btnBuscar_sub_proyecto"
        Me.btnBuscar_sub_proyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscar_sub_proyecto.TabIndex = 608
        Me.btnBuscar_sub_proyecto.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(629, 685)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(716, 685)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 58)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmDetalleTarea_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmDetalleTarea_2"
        Me.Text = "frmDetalleTarea_2"
        CType(Me.dgvHora_real, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents etiquetaid_tipo_tarea As System.Windows.Forms.Label
    Protected WithEvents txtidentificador As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblid_usuario_asignado As System.Windows.Forms.Label
    Friend WithEvents cmbusuario_asignado As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_tipo_tarea As System.Windows.Forms.Label
    Friend WithEvents cmbtipo_tarea As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscaTipo_tarea As System.Windows.Forms.Button
    Protected WithEvents txtnombre_tarea As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_tarea As System.Windows.Forms.Label
    Friend WithEvents lblid_sub_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_sub_proyecto As System.Windows.Forms.Button
    Friend WithEvents cmbSub_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_empresa As System.Windows.Forms.Button
    Friend WithEvents cmbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscaproyecto As System.Windows.Forms.Button
    Friend WithEvents cmbproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_proyecto As System.Windows.Forms.Label
    Protected WithEvents txthora_prevista As System.Windows.Forms.TextBox
    Friend WithEvents etiquetahora_prevista As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_prevista As System.Windows.Forms.Label
    Protected WithEvents txtUbicacion_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_real As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_real As System.Windows.Forms.Label
    Protected WithEvents txthora_real As System.Windows.Forms.TextBox
    Friend WithEvents etiquetahora_real As System.Windows.Forms.Label
    Protected WithEvents dgvHora_real As System.Windows.Forms.DataGridView
    Protected WithEvents btnBorrar As System.Windows.Forms.Button
    Protected WithEvents btnModificar As System.Windows.Forms.Button
    Protected WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cmbCod_sub_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCod_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCod_Proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_empresa_asignada As System.Windows.Forms.Label
    Friend WithEvents cmbempresa_asignada As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbtBaja As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMedia As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAlta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFinalizada As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCancelada As System.Windows.Forms.RadioButton
    Friend WithEvents rbtProgramada As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSuspendida As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblid_hora_real As System.Windows.Forms.Label
    Friend WithEvents lblid_tarea As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents txtTotalHoraDia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Protected WithEvents txtTotalHoraDiaReal As System.Windows.Forms.TextBox
    Friend WithEvents btnPathCroquis As System.Windows.Forms.Button
    Protected WithEvents dtpFecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtComplejidad_media As System.Windows.Forms.RadioButton
    Friend WithEvents rbtComplejidad_alta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtComplejidad_baja As System.Windows.Forms.RadioButton
    Protected WithEvents dtpFecha_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAbrirExplorador As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents txtCapacidad_trabajo As System.Windows.Forms.TextBox
    Protected WithEvents txtTotalHorasPrevistasAcumuladas As System.Windows.Forms.TextBox
    Protected WithEvents txtHoraPrevistaPrevia As System.Windows.Forms.TextBox
    Protected WithEvents dtpFechaInicioPrevio As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtDiaInicio As TextBox
    Protected WithEvents txtDiaFin As TextBox
    Friend WithEvents chkEs_feriado As CheckBox
End Class
