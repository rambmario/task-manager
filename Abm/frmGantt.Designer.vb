<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGantt
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGantt))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmReasignarFecha = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanceladaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaDeHoyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaViejaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaPersonalizadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFecha_inicio = New System.Windows.Forms.Label()
        Me.lblid_tarea = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.lblid_hora_real = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscaFeriado = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnFinalizarRapido = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(485, 632)
        Me.DataGridView1.TabIndex = 0
        '
        'cmbUsuario
        '
        Me.cmbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(380, 25)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(344, 21)
        Me.cmbUsuario.TabIndex = 601
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(389, 29)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 600
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.Location = New System.Drawing.Point(504, 89)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(504, 324)
        Me.DataGridView2.TabIndex = 623
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmReasignarFecha, Me.CambiarEstadoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 48)
        '
        'tsmReasignarFecha
        '
        Me.tsmReasignarFecha.Name = "tsmReasignarFecha"
        Me.tsmReasignarFecha.Size = New System.Drawing.Size(217, 22)
        Me.tsmReasignarFecha.Text = "Reasignar Fecha de la Tarea"
        '
        'CambiarEstadoToolStripMenuItem
        '
        Me.CambiarEstadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramadaToolStripMenuItem, Me.CanceladaToolStripMenuItem, Me.SuspendidaToolStripMenuItem, Me.FinalizadaToolStripMenuItem})
        Me.CambiarEstadoToolStripMenuItem.Name = "CambiarEstadoToolStripMenuItem"
        Me.CambiarEstadoToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CambiarEstadoToolStripMenuItem.Text = "Cambiar Estado"
        '
        'ProgramadaToolStripMenuItem
        '
        Me.ProgramadaToolStripMenuItem.Name = "ProgramadaToolStripMenuItem"
        Me.ProgramadaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProgramadaToolStripMenuItem.Text = "Programada"
        '
        'CanceladaToolStripMenuItem
        '
        Me.CanceladaToolStripMenuItem.Name = "CanceladaToolStripMenuItem"
        Me.CanceladaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CanceladaToolStripMenuItem.Text = "Cancelada"
        '
        'SuspendidaToolStripMenuItem
        '
        Me.SuspendidaToolStripMenuItem.Name = "SuspendidaToolStripMenuItem"
        Me.SuspendidaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SuspendidaToolStripMenuItem.Text = "Suspendida"
        '
        'FinalizadaToolStripMenuItem
        '
        Me.FinalizadaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FechaDeHoyToolStripMenuItem, Me.FechaViejaToolStripMenuItem, Me.FechaPersonalizadaToolStripMenuItem})
        Me.FinalizadaToolStripMenuItem.Name = "FinalizadaToolStripMenuItem"
        Me.FinalizadaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.FinalizadaToolStripMenuItem.Text = "Finalizada"
        '
        'FechaDeHoyToolStripMenuItem
        '
        Me.FechaDeHoyToolStripMenuItem.Name = "FechaDeHoyToolStripMenuItem"
        Me.FechaDeHoyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FechaDeHoyToolStripMenuItem.Text = "Fecha de Hoy"
        '
        'FechaViejaToolStripMenuItem
        '
        Me.FechaViejaToolStripMenuItem.Name = "FechaViejaToolStripMenuItem"
        Me.FechaViejaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FechaViejaToolStripMenuItem.Text = "Fecha Vieja"
        '
        'FechaPersonalizadaToolStripMenuItem
        '
        Me.FechaPersonalizadaToolStripMenuItem.Name = "FechaPersonalizadaToolStripMenuItem"
        Me.FechaPersonalizadaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FechaPersonalizadaToolStripMenuItem.Text = "Fecha Personalizada"
        '
        'lblFecha_inicio
        '
        Me.lblFecha_inicio.AutoSize = True
        Me.lblFecha_inicio.BackColor = System.Drawing.Color.Red
        Me.lblFecha_inicio.Location = New System.Drawing.Point(23, 103)
        Me.lblFecha_inicio.Name = "lblFecha_inicio"
        Me.lblFecha_inicio.Size = New System.Drawing.Size(13, 13)
        Me.lblFecha_inicio.TabIndex = 624
        Me.lblFecha_inicio.Text = "0"
        Me.lblFecha_inicio.Visible = False
        '
        'lblid_tarea
        '
        Me.lblid_tarea.AutoSize = True
        Me.lblid_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tarea.Location = New System.Drawing.Point(522, 103)
        Me.lblid_tarea.Name = "lblid_tarea"
        Me.lblid_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tarea.TabIndex = 625
        Me.lblid_tarea.Text = "0"
        Me.lblid_tarea.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 626
        Me.Label1.Text = "Usuario Asignado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 629
        Me.Label2.Text = "  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(135, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 630
        Me.Label3.Text = "  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 631
        Me.Label4.Text = "Sábado - Domingo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 632
        Me.Label5.Text = "Feriado"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 78)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(995, 10)
        Me.ProgressBar1.TabIndex = 633
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(504, 464)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(504, 257)
        Me.DataGridView3.TabIndex = 634
        '
        'lblid_hora_real
        '
        Me.lblid_hora_real.AutoSize = True
        Me.lblid_hora_real.BackColor = System.Drawing.Color.Red
        Me.lblid_hora_real.Location = New System.Drawing.Point(522, 511)
        Me.lblid_hora_real.Name = "lblid_hora_real"
        Me.lblid_hora_real.Size = New System.Drawing.Size(13, 13)
        Me.lblid_hora_real.TabIndex = 635
        Me.lblid_hora_real.Text = "0"
        Me.lblid_hora_real.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 640
        Me.Label6.Text = "Hoy"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(204, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 15)
        Me.Label7.TabIndex = 639
        Me.Label7.Text = "  "
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(594, 419)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(39, 39)
        Me.btnBorrar.TabIndex = 638
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.btnBorrar, "Borrar Horas")
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(549, 419)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(39, 39)
        Me.btnModificar.TabIndex = 637
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar Horas")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(504, 419)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(39, 39)
        Me.btnAgregar.TabIndex = 636
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar Horas")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscaFeriado
        '
        Me.btnBuscaFeriado.Image = Global.Gestion_tarea.My.Resources.Resources.Calendar16
        Me.btnBuscaFeriado.Location = New System.Drawing.Point(770, 25)
        Me.btnBuscaFeriado.Name = "btnBuscaFeriado"
        Me.btnBuscaFeriado.Size = New System.Drawing.Size(34, 26)
        Me.btnBuscaFeriado.TabIndex = 627
        Me.ToolTip1.SetToolTip(Me.btnBuscaFeriado, "Cargar Feriados")
        Me.btnBuscaFeriado.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(730, 25)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(34, 26)
        Me.btnConsultar.TabIndex = 622
        Me.ToolTip1.SetToolTip(Me.btnConsultar, "Consultar")
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnFinalizarRapido
        '
        Me.btnFinalizarRapido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizarRapido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizarRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarRapido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarRapido.Image = Global.Gestion_tarea.My.Resources.Resources.guardar_3_1_35
        Me.btnFinalizarRapido.Location = New System.Drawing.Point(754, 419)
        Me.btnFinalizarRapido.Name = "btnFinalizarRapido"
        Me.btnFinalizarRapido.Size = New System.Drawing.Size(34, 21)
        Me.btnFinalizarRapido.TabIndex = 641
        Me.btnFinalizarRapido.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.btnFinalizarRapido, "Finalizar Tarea")
        Me.btnFinalizarRapido.UseVisualStyleBackColor = True
        '
        'frmGantt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 723)
        Me.Controls.Add(Me.btnFinalizarRapido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblid_hora_real)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscaFeriado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_tarea)
        Me.Controls.Add(Me.lblFecha_inicio)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Name = "frmGantt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planner"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_usuario As System.Windows.Forms.Label
    Private WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblFecha_inicio As System.Windows.Forms.Label
    Friend WithEvents lblid_tarea As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnBuscaFeriado As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tsmReasignarFecha As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents lblid_hora_real As System.Windows.Forms.Label
    Protected WithEvents btnBorrar As Button
    Protected WithEvents btnModificar As Button
    Protected WithEvents btnAgregar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CambiarEstadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CanceladaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuspendidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalizadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechaDeHoyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechaViejaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechaPersonalizadaToolStripMenuItem As ToolStripMenuItem
    Protected WithEvents btnFinalizarRapido As System.Windows.Forms.Button
End Class
