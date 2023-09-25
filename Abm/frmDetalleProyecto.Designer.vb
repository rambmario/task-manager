<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleProyecto
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_proyecto = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_proyecto = New System.Windows.Forms.Label()
        Me.txtcodigo_proyecto = New System.Windows.Forms.TextBox()
        Me.etiquetacodigo_proyecto = New System.Windows.Forms.Label()
        Me.lblid_tipo_proyecto = New System.Windows.Forms.Label()
        Me.btnBuscatipo_proyecto = New System.Windows.Forms.Button()
        Me.cmbtipo_proyecto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_tipo_proyecto = New System.Windows.Forms.Label()
        Me.lblid_empresa = New System.Windows.Forms.Label()
        Me.btnBuscaempresa = New System.Windows.Forms.Button()
        Me.cmbempresa = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_empresa = New System.Windows.Forms.Label()
        Me.txthora_prevista = New System.Windows.Forms.TextBox()
        Me.etiquetahora_prevista = New System.Windows.Forms.Label()
        Me.txthora_real = New System.Windows.Forms.TextBox()
        Me.etiquetahora_real = New System.Windows.Forms.Label()
        Me.dtpfecha_prevista_fin = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_prevista_fin = New System.Windows.Forms.Label()
        Me.dtpfecha_real_fin = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_real_fin = New System.Windows.Forms.Label()
        Me.lblid_estado_proyecto = New System.Windows.Forms.Label()
        Me.btnBuscaestado_proyecto = New System.Windows.Forms.Button()
        Me.cmbestado_proyecto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_estado_proyecto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.Gestion_tarea.My.Resources.Resources.salir_c_1_35
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 517)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 517)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtnombre_proyecto
        '
        Me.txtnombre_proyecto.BackColor = System.Drawing.Color.White
        Me.txtnombre_proyecto.Location = New System.Drawing.Point(161, 70)
        Me.txtnombre_proyecto.MaxLength = 50
        Me.txtnombre_proyecto.Name = "txtnombre_proyecto"
        Me.txtnombre_proyecto.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_proyecto.TabIndex = 4
        '
        'etiquetanombre_proyecto
        '
        Me.etiquetanombre_proyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetanombre_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_proyecto.ForeColor = System.Drawing.Color.White
        Me.etiquetanombre_proyecto.Location = New System.Drawing.Point(22, 70)
        Me.etiquetanombre_proyecto.Name = "etiquetanombre_proyecto"
        Me.etiquetanombre_proyecto.Size = New System.Drawing.Size(133, 21)
        Me.etiquetanombre_proyecto.TabIndex = 500
        Me.etiquetanombre_proyecto.Text = "Nombre proyecto"
        Me.etiquetanombre_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcodigo_proyecto
        '
        Me.txtcodigo_proyecto.BackColor = System.Drawing.Color.White
        Me.txtcodigo_proyecto.Location = New System.Drawing.Point(161, 113)
        Me.txtcodigo_proyecto.MaxLength = 50
        Me.txtcodigo_proyecto.Name = "txtcodigo_proyecto"
        Me.txtcodigo_proyecto.Size = New System.Drawing.Size(385, 20)
        Me.txtcodigo_proyecto.TabIndex = 5
        '
        'etiquetacodigo_proyecto
        '
        Me.etiquetacodigo_proyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetacodigo_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacodigo_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo_proyecto.ForeColor = System.Drawing.Color.White
        Me.etiquetacodigo_proyecto.Location = New System.Drawing.Point(22, 113)
        Me.etiquetacodigo_proyecto.Name = "etiquetacodigo_proyecto"
        Me.etiquetacodigo_proyecto.Size = New System.Drawing.Size(133, 21)
        Me.etiquetacodigo_proyecto.TabIndex = 501
        Me.etiquetacodigo_proyecto.Text = "C�digo proyecto"
        Me.etiquetacodigo_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_tipo_proyecto
        '
        Me.lblid_tipo_proyecto.AutoSize = True
        Me.lblid_tipo_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_proyecto.Location = New System.Drawing.Point(370, 156)
        Me.lblid_tipo_proyecto.Name = "lblid_tipo_proyecto"
        Me.lblid_tipo_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_proyecto.TabIndex = 502
        Me.lblid_tipo_proyecto.Text = "0"
        Me.lblid_tipo_proyecto.Visible = False
        '
        'btnBuscatipo_proyecto
        '
        Me.btnBuscatipo_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_proyecto.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscatipo_proyecto.Location = New System.Drawing.Point(516, 156)
        Me.btnBuscatipo_proyecto.Name = "btnBuscatipo_proyecto"
        Me.btnBuscatipo_proyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_proyecto.TabIndex = 60
        Me.btnBuscatipo_proyecto.UseVisualStyleBackColor = True
        '
        'cmbtipo_proyecto
        '
        Me.cmbtipo_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_proyecto.FormattingEnabled = True
        Me.cmbtipo_proyecto.Location = New System.Drawing.Point(161, 156)
        Me.cmbtipo_proyecto.Name = "cmbtipo_proyecto"
        Me.cmbtipo_proyecto.Size = New System.Drawing.Size(349, 21)
        Me.cmbtipo_proyecto.TabIndex = 6
        '
        'etiquetaid_tipo_proyecto
        '
        Me.etiquetaid_tipo_proyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_tipo_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_proyecto.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_tipo_proyecto.Location = New System.Drawing.Point(22, 156)
        Me.etiquetaid_tipo_proyecto.Name = "etiquetaid_tipo_proyecto"
        Me.etiquetaid_tipo_proyecto.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_tipo_proyecto.TabIndex = 503
        Me.etiquetaid_tipo_proyecto.Text = "Tipo proyecto"
        Me.etiquetaid_tipo_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(370, 199)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 504
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'btnBuscaempresa
        '
        Me.btnBuscaempresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaempresa.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscaempresa.Location = New System.Drawing.Point(516, 199)
        Me.btnBuscaempresa.Name = "btnBuscaempresa"
        Me.btnBuscaempresa.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaempresa.TabIndex = 61
        Me.btnBuscaempresa.UseVisualStyleBackColor = True
        '
        'cmbempresa
        '
        Me.cmbempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbempresa.FormattingEnabled = True
        Me.cmbempresa.Location = New System.Drawing.Point(161, 199)
        Me.cmbempresa.Name = "cmbempresa"
        Me.cmbempresa.Size = New System.Drawing.Size(349, 21)
        Me.cmbempresa.TabIndex = 7
        '
        'etiquetaid_empresa
        '
        Me.etiquetaid_empresa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_empresa.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_empresa.Location = New System.Drawing.Point(22, 199)
        Me.etiquetaid_empresa.Name = "etiquetaid_empresa"
        Me.etiquetaid_empresa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_empresa.TabIndex = 505
        Me.etiquetaid_empresa.Text = "Empresa"
        Me.etiquetaid_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthora_prevista
        '
        Me.txthora_prevista.BackColor = System.Drawing.Color.White
        Me.txthora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_prevista.ForeColor = System.Drawing.Color.Blue
        Me.txthora_prevista.Location = New System.Drawing.Point(161, 242)
        Me.txthora_prevista.MaxLength = 50
        Me.txthora_prevista.Name = "txthora_prevista"
        Me.txthora_prevista.Size = New System.Drawing.Size(222, 31)
        Me.txthora_prevista.TabIndex = 8
        Me.txthora_prevista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_prevista
        '
        Me.etiquetahora_prevista.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetahora_prevista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetahora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_prevista.ForeColor = System.Drawing.Color.White
        Me.etiquetahora_prevista.Location = New System.Drawing.Point(22, 242)
        Me.etiquetahora_prevista.Name = "etiquetahora_prevista"
        Me.etiquetahora_prevista.Size = New System.Drawing.Size(133, 21)
        Me.etiquetahora_prevista.TabIndex = 506
        Me.etiquetahora_prevista.Text = "Hora prevista"
        Me.etiquetahora_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthora_real
        '
        Me.txthora_real.BackColor = System.Drawing.Color.White
        Me.txthora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_real.ForeColor = System.Drawing.Color.Blue
        Me.txthora_real.Location = New System.Drawing.Point(161, 295)
        Me.txthora_real.MaxLength = 50
        Me.txthora_real.Name = "txthora_real"
        Me.txthora_real.Size = New System.Drawing.Size(222, 31)
        Me.txthora_real.TabIndex = 9
        Me.txthora_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_real
        '
        Me.etiquetahora_real.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetahora_real.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetahora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_real.ForeColor = System.Drawing.Color.White
        Me.etiquetahora_real.Location = New System.Drawing.Point(22, 295)
        Me.etiquetahora_real.Name = "etiquetahora_real"
        Me.etiquetahora_real.Size = New System.Drawing.Size(133, 21)
        Me.etiquetahora_real.TabIndex = 507
        Me.etiquetahora_real.Text = "Hora real"
        Me.etiquetahora_real.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecha_prevista_fin
        '
        Me.dtpfecha_prevista_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_prevista_fin.Location = New System.Drawing.Point(161, 348)
        Me.dtpfecha_prevista_fin.Name = "dtpfecha_prevista_fin"
        Me.dtpfecha_prevista_fin.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_prevista_fin.TabIndex = 10
        '
        'etiquetafecha_prevista_fin
        '
        Me.etiquetafecha_prevista_fin.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_prevista_fin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_prevista_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_prevista_fin.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_prevista_fin.Location = New System.Drawing.Point(22, 348)
        Me.etiquetafecha_prevista_fin.Name = "etiquetafecha_prevista_fin"
        Me.etiquetafecha_prevista_fin.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_prevista_fin.TabIndex = 508
        Me.etiquetafecha_prevista_fin.Text = "Fecha prevista fin"
        Me.etiquetafecha_prevista_fin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecha_real_fin
        '
        Me.dtpfecha_real_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_real_fin.Location = New System.Drawing.Point(161, 391)
        Me.dtpfecha_real_fin.Name = "dtpfecha_real_fin"
        Me.dtpfecha_real_fin.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_real_fin.TabIndex = 11
        '
        'etiquetafecha_real_fin
        '
        Me.etiquetafecha_real_fin.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_real_fin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_real_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_real_fin.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_real_fin.Location = New System.Drawing.Point(22, 391)
        Me.etiquetafecha_real_fin.Name = "etiquetafecha_real_fin"
        Me.etiquetafecha_real_fin.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_real_fin.TabIndex = 509
        Me.etiquetafecha_real_fin.Text = "Fecha real fin"
        Me.etiquetafecha_real_fin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_estado_proyecto
        '
        Me.lblid_estado_proyecto.AutoSize = True
        Me.lblid_estado_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_estado_proyecto.Location = New System.Drawing.Point(370, 434)
        Me.lblid_estado_proyecto.Name = "lblid_estado_proyecto"
        Me.lblid_estado_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_estado_proyecto.TabIndex = 510
        Me.lblid_estado_proyecto.Text = "0"
        Me.lblid_estado_proyecto.Visible = False
        '
        'btnBuscaestado_proyecto
        '
        Me.btnBuscaestado_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaestado_proyecto.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscaestado_proyecto.Location = New System.Drawing.Point(516, 434)
        Me.btnBuscaestado_proyecto.Name = "btnBuscaestado_proyecto"
        Me.btnBuscaestado_proyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaestado_proyecto.TabIndex = 62
        Me.btnBuscaestado_proyecto.UseVisualStyleBackColor = True
        Me.btnBuscaestado_proyecto.Visible = False
        '
        'cmbestado_proyecto
        '
        Me.cmbestado_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbestado_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbestado_proyecto.FormattingEnabled = True
        Me.cmbestado_proyecto.Location = New System.Drawing.Point(161, 434)
        Me.cmbestado_proyecto.Name = "cmbestado_proyecto"
        Me.cmbestado_proyecto.Size = New System.Drawing.Size(349, 21)
        Me.cmbestado_proyecto.TabIndex = 12
        '
        'etiquetaid_estado_proyecto
        '
        Me.etiquetaid_estado_proyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_estado_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_estado_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_estado_proyecto.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_estado_proyecto.Location = New System.Drawing.Point(22, 434)
        Me.etiquetaid_estado_proyecto.Name = "etiquetaid_estado_proyecto"
        Me.etiquetaid_estado_proyecto.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_estado_proyecto.TabIndex = 511
        Me.etiquetaid_estado_proyecto.Text = "Estado proyecto"
        Me.etiquetaid_estado_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDetalleProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 597)
        Me.Controls.Add(Me.txtnombre_proyecto)
        Me.Controls.Add(Me.etiquetanombre_proyecto)
        Me.Controls.Add(Me.txtcodigo_proyecto)
        Me.Controls.Add(Me.etiquetacodigo_proyecto)
        Me.Controls.Add(Me.lblid_tipo_proyecto)
        Me.Controls.Add(Me.btnBuscatipo_proyecto)
        Me.Controls.Add(Me.cmbtipo_proyecto)
        Me.Controls.Add(Me.etiquetaid_tipo_proyecto)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.btnBuscaempresa)
        Me.Controls.Add(Me.cmbempresa)
        Me.Controls.Add(Me.etiquetaid_empresa)
        Me.Controls.Add(Me.txthora_prevista)
        Me.Controls.Add(Me.etiquetahora_prevista)
        Me.Controls.Add(Me.txthora_real)
        Me.Controls.Add(Me.etiquetahora_real)
        Me.Controls.Add(Me.dtpfecha_prevista_fin)
        Me.Controls.Add(Me.etiquetafecha_prevista_fin)
        Me.Controls.Add(Me.dtpfecha_real_fin)
        Me.Controls.Add(Me.etiquetafecha_real_fin)
        Me.Controls.Add(Me.lblid_estado_proyecto)
        Me.Controls.Add(Me.btnBuscaestado_proyecto)
        Me.Controls.Add(Me.cmbestado_proyecto)
        Me.Controls.Add(Me.etiquetaid_estado_proyecto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleProyecto"
        Me.Text = "PROYECTO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtnombre_proyecto As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_proyecto As System.Windows.Forms.Label
    Protected WithEvents txtcodigo_proyecto As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacodigo_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_tipo_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscatipo_proyecto As System.Windows.Forms.Button
    Friend WithEvents cmbtipo_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_tipo_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents btnBuscaempresa As System.Windows.Forms.Button
    Friend WithEvents cmbempresa As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_empresa As System.Windows.Forms.Label
    Protected WithEvents txthora_prevista As System.Windows.Forms.TextBox
    Friend WithEvents etiquetahora_prevista As System.Windows.Forms.Label
    Protected WithEvents txthora_real As System.Windows.Forms.TextBox
    Friend WithEvents etiquetahora_real As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_prevista_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_prevista_fin As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_real_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_real_fin As System.Windows.Forms.Label
    Friend WithEvents lblid_estado_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscaestado_proyecto As System.Windows.Forms.Button
    Friend WithEvents cmbestado_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_estado_proyecto As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

